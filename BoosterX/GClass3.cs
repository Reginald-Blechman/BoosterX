using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

// Token: 0x02000103 RID: 259
public sealed class GClass3
{
	// Token: 0x06000784 RID: 1924 RVA: 0x00006A51 File Offset: 0x00004C51
	public GClass3()
	{
		this.concurrentDictionary_0 = new ConcurrentDictionary<int, long>();
		this.list_0 = new List<GClass41>();
		this.int_4 = 0;
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x0003E728 File Offset: 0x0003C928
	public void method_0(EventHandler<GClass41> eventHandler_1)
	{
		EventHandler<GClass41> eventHandler = this.eventHandler_0;
		EventHandler<GClass41> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GClass41> value = (EventHandler<GClass41>)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<GClass41>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x0003E760 File Offset: 0x0003C960
	public void method_1(EventHandler<GClass41> eventHandler_1)
	{
		EventHandler<GClass41> eventHandler = this.eventHandler_0;
		EventHandler<GClass41> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GClass41> value = (EventHandler<GClass41>)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<GClass41>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x0003E798 File Offset: 0x0003C998
	public void method_2(string string_0, int int_5, int int_6, int int_7, int int_8)
	{
		this.int_0 = int_7;
		this.int_2 = int_8;
		this.int_1 = int_6 * int_7;
		this.cancellationTokenSource_0 = new CancellationTokenSource();
		this.ipendPoint_0 = new IPEndPoint(Dns.GetHostAddresses(string_0).First<IPAddress>(), int_5);
		this.udpClient_0 = new UdpClient();
		this.udpClient_0.Connect(this.ipendPoint_0);
		this.udpClient_0.Client.ReceiveTimeout = this.int_3;
		this.thread_0 = new Thread(new ThreadStart(this.method_6))
		{
			IsBackground = true,
			Priority = ThreadPriority.Highest
		};
		this.thread_1 = new Thread(new ThreadStart(this.method_7))
		{
			IsBackground = true,
			Priority = ThreadPriority.Highest
		};
		this.thread_2 = new Thread(new ThreadStart(this.method_8))
		{
			IsBackground = true,
			Priority = ThreadPriority.Highest
		};
		this.thread_0.Start();
		this.thread_1.Start();
		this.thread_2.Start();
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00006A8C File Offset: 0x00004C8C
	public void method_3()
	{
		this.cancellationTokenSource_0.Cancel();
		this.udpClient_0.Close();
		this.thread_0.Join();
		this.thread_1.Join();
		this.thread_2.Join();
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x0003E8A4 File Offset: 0x0003CAA4
	public List<GClass41> method_4()
	{
		object obj = this.object_0;
		List<GClass41> result;
		lock (obj)
		{
			result = new List<GClass41>(this.list_0);
		}
		return result;
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x0003E8EC File Offset: 0x0003CAEC
	public List<GClass41> method_5()
	{
		List<GClass41> result = this.method_4();
		object obj = this.object_0;
		lock (obj)
		{
			this.list_0.Clear();
			this.concurrentDictionary_0.Clear();
		}
		return result;
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x0003E944 File Offset: 0x0003CB44
	private void method_6()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		long num = Stopwatch.Frequency / (long)this.int_0;
		long num2 = stopwatch.ElapsedTicks;
		int num3 = 0;
		Random random = new Random();
		while (!this.cancellationTokenSource_0.IsCancellationRequested)
		{
			if (num3 >= this.int_1)
			{
				break;
			}
			while (stopwatch.ElapsedTicks < num2)
			{
				Thread.SpinWait(10);
				if (this.cancellationTokenSource_0.IsCancellationRequested)
				{
					return;
				}
			}
			int num4 = Interlocked.Increment(ref this.int_4);
			long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
			this.concurrentDictionary_0[num4] = elapsedMilliseconds;
			byte[] array = new byte[4 + this.int_2];
			array[0] = (byte)(num4 >> 24);
			array[1] = (byte)(num4 >> 16);
			array[2] = (byte)(num4 >> 8);
			array[3] = (byte)num4;
			byte[] array2 = new byte[this.int_2];
			random.NextBytes(array2);
			Buffer.BlockCopy(array2, 0, array, 4, this.int_2);
			try
			{
				this.udpClient_0.Send(array, array.Length);
			}
			catch (Exception)
			{
				GClass41 gclass = new GClass41
				{
					Success = false,
					SendTime = elapsedMilliseconds,
					ReceiveTime = stopwatch.ElapsedMilliseconds
				};
				object obj = this.object_0;
				lock (obj)
				{
					this.list_0.Add(gclass);
				}
				EventHandler<GClass41> eventHandler = this.eventHandler_0;
				if (eventHandler != null)
				{
					eventHandler(this, gclass);
				}
				long num5;
				this.concurrentDictionary_0.TryRemove(num4, out num5);
			}
			num3++;
			num2 += num;
		}
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x0003EAE0 File Offset: 0x0003CCE0
	private void method_7()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		while (!this.cancellationTokenSource_0.IsCancellationRequested)
		{
			try
			{
				IPEndPoint ipendPoint = null;
				byte[] array = this.udpClient_0.Receive(ref ipendPoint);
				long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
				if (array.Length >= 4)
				{
					int key = (int)array[0] << 24 | (int)array[1] << 16 | (int)array[2] << 8 | (int)array[3];
					long num;
					if (this.concurrentDictionary_0.TryRemove(key, out num))
					{
						long num2 = elapsedMilliseconds - num;
						GClass41 gclass = new GClass41
						{
							Success = true,
							Ping = (double)num2,
							SendTime = num,
							ReceiveTime = elapsedMilliseconds
						};
						object obj = this.object_0;
						lock (obj)
						{
							this.list_0.Add(gclass);
						}
						EventHandler<GClass41> eventHandler = this.eventHandler_0;
						if (eventHandler != null)
						{
							eventHandler(this, gclass);
						}
					}
				}
			}
			catch (SocketException ex)
			{
				if (this.cancellationTokenSource_0.IsCancellationRequested)
				{
					break;
				}
				SocketError socketErrorCode = ex.SocketErrorCode;
			}
			catch (ObjectDisposedException)
			{
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x0003EC18 File Offset: 0x0003CE18
	private void method_8()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		while (!this.cancellationTokenSource_0.IsCancellationRequested)
		{
			long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
			foreach (KeyValuePair<int, long> keyValuePair in this.concurrentDictionary_0.ToArray())
			{
				int key = keyValuePair.Key;
				long value = keyValuePair.Value;
				long num;
				if (elapsedMilliseconds - value > (long)this.int_3 && this.concurrentDictionary_0.TryRemove(key, out num))
				{
					GClass41 gclass = new GClass41
					{
						Success = false,
						SendTime = value,
						ReceiveTime = elapsedMilliseconds
					};
					object obj = this.object_0;
					lock (obj)
					{
						this.list_0.Add(gclass);
					}
					EventHandler<GClass41> eventHandler = this.eventHandler_0;
					if (eventHandler != null)
					{
						eventHandler(this, gclass);
					}
				}
			}
			Thread.Sleep(10);
		}
	}

	// Token: 0x0400042E RID: 1070
	private UdpClient udpClient_0;

	// Token: 0x0400042F RID: 1071
	private IPEndPoint ipendPoint_0;

	// Token: 0x04000430 RID: 1072
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x04000431 RID: 1073
	private Thread thread_0;

	// Token: 0x04000432 RID: 1074
	private Thread thread_1;

	// Token: 0x04000433 RID: 1075
	private Thread thread_2;

	// Token: 0x04000434 RID: 1076
	private ConcurrentDictionary<int, long> concurrentDictionary_0;

	// Token: 0x04000435 RID: 1077
	private List<GClass41> list_0;

	// Token: 0x04000436 RID: 1078
	private readonly object object_0 = new object();

	// Token: 0x04000437 RID: 1079
	private int int_0;

	// Token: 0x04000438 RID: 1080
	private int int_1;

	// Token: 0x04000439 RID: 1081
	private int int_2;

	// Token: 0x0400043A RID: 1082
	private int int_3 = 2000;

	// Token: 0x0400043B RID: 1083
	private int int_4;

	// Token: 0x0400043C RID: 1084
	private EventHandler<GClass41> eventHandler_0;
}
