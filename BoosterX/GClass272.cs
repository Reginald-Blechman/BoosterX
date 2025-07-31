using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using Newtonsoft.Json;

// Token: 0x02000629 RID: 1577
public static class GClass272
{
	// Token: 0x0600282B RID: 10283 RVA: 0x0009C9B0 File Offset: 0x0009ABB0
	public static Task<string> smethod_0(string string_1, string string_2)
	{
		GClass272.Struct417 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.string_0 = string_1;
		@struct.string_1 = string_2;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass272.Struct417>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600282C RID: 10284 RVA: 0x0009C9FC File Offset: 0x0009ABFC
	public static Task<IList<GClass298>> smethod_1(string string_1, string string_2)
	{
		GClass272.Struct418 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IList<GClass298>>.Create();
		@struct.string_0 = string_1;
		@struct.string_1 = string_2;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass272.Struct418>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x0009CA48 File Offset: 0x0009AC48
	public static Task<IList<GClass298>> smethod_2(string string_1)
	{
		GClass272.Struct420 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IList<GClass298>>.Create();
		@struct.string_0 = string_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass272.Struct420>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600282E RID: 10286 RVA: 0x0009CA8C File Offset: 0x0009AC8C
	public static Task<string> smethod_3()
	{
		GClass272.Struct419 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass272.Struct419>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600282F RID: 10287 RVA: 0x0009CAC8 File Offset: 0x0009ACC8
	public static void smethod_4(string string_1, out IList<string> ilist_0, out IList<string> ilist_1, out IList<string> ilist_2)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(string_1);
		ilist_2 = new List<string>();
		ilist_1 = new List<string>();
		ilist_0 = new List<string>();
		foreach (object obj in xmlDocument.GetElementsByTagName("SecuredFragment"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			string value = xmlNode.ParentNode.ParentNode.FirstChild.Attributes[0].Value;
			string value2 = xmlNode.ParentNode.ParentNode.FirstChild.Attributes[1].Value;
			ilist_2.Add(value);
			ilist_0.Add(value2);
		}
	}

	// Token: 0x06002830 RID: 10288 RVA: 0x0009CB94 File Offset: 0x0009AD94
	public static Task<IList<Uri>> smethod_5(IList<string> ilist_0, IList<string> ilist_1, string string_1)
	{
		GClass272.Struct416 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IList<Uri>>.Create();
		@struct.ilist_0 = ilist_0;
		@struct.ilist_1 = ilist_1;
		@struct.string_0 = string_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass272.Struct416>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002831 RID: 10289 RVA: 0x0009CBE8 File Offset: 0x0009ADE8
	private static string smethod_6(string string_1)
	{
		string result = string.Empty;
		using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BoosterX.Services.StoreLib.Xml." + string_1))
		{
			StreamReader streamReader = new StreamReader(manifestResourceStream);
			try
			{
				result = streamReader.ReadToEnd();
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		return result;
	}

	// Token: 0x04001A53 RID: 6739
	private static readonly GClass244 gclass244_0 = new GClass244();

	// Token: 0x04001A54 RID: 6740
	private static readonly string string_0 = "<Device>dAA9AEUAdwBBAHcAQQBzAE4AMwBCAEEAQQBVADEAYgB5AHMAZQBtAGIAZQBEAFYAQwArADMAZgBtADcAbwBXAHkASAA3AGIAbgBnAEcAWQBtAEEAQQBMAGoAbQBqAFYAVQB2AFEAYwA0AEsAVwBFAC8AYwBDAEwANQBYAGUANABnAHYAWABkAGkAegBHAGwAZABjADEAZAAvAFcAeQAvAHgASgBQAG4AVwBRAGUAYwBtAHYAbwBjAGkAZwA5AGoAZABwAE4AawBIAG0AYQBzAHAAVABKAEwARAArAFAAYwBBAFgAbQAvAFQAcAA3AEgAagBzAEYANAA0AEgAdABsAC8AMQBtAHUAcgAwAFMAdQBtAG8AMABZAGEAdgBqAFIANwArADQAcABoAC8AcwA4ADEANgBFAFkANQBNAFIAbQBnAFIAQwA2ADMAQwBSAEoAQQBVAHYAZgBzADQAaQB2AHgAYwB5AEwAbAA2AHoAOABlAHgAMABrAFgAOQBPAHcAYQB0ADEAdQBwAFMAOAAxAEgANgA4AEEASABzAEoAegBnAFQAQQBMAG8AbgBBADIAWQBBAEEAQQBpAGcANQBJADMAUQAvAFYASABLAHcANABBAEIAcQA5AFMAcQBhADEAQgA4AGsAVQAxAGEAbwBLAEEAdQA0AHYAbABWAG4AdwBWADMAUQB6AHMATgBtAEQAaQBqAGgANQBkAEcAcgBpADgAQQBlAEUARQBWAEcAbQBXAGgASQBCAE0AUAAyAEQAVwA0ADMAZABWAGkARABUAHoAVQB0AHQARQBMAEgAaABSAGYAcgBhAGIAWgBsAHQAQQBUAEUATABmAHMARQBGAFUAYQBRAFMASgB4ADUAeQBRADgAagBaAEUAZQAyAHgANABCADMAMQB2AEIAMgBqAC8AUgBLAGEAWQAvAHEAeQB0AHoANwBUAHYAdAB3AHQAagBzADYAUQBYAEIAZQA4AHMAZwBJAG8AOQBiADUAQQBCADcAOAAxAHMANgAvAGQAUwBFAHgATgBEAEQAYQBRAHoAQQBYAFAAWABCAFkAdQBYAFEARQBzAE8AegA4AHQAcgBpAGUATQBiAEIAZQBUAFkAOQBiAG8AQgBOAE8AaQBVADcATgBSAEYAOQAzAG8AVgArAFYAQQBiAGgAcAAwAHAAUgBQAFMAZQBmAEcARwBPAHEAdwBTAGcANwA3AHMAaAA5AEoASABNAHAARABNAFMAbgBrAHEAcgAyAGYARgBpAEMAUABrAHcAVgBvAHgANgBuAG4AeABGAEQAbwBXAC8AYQAxAHQAYQBaAHcAegB5AGwATABMADEAMgB3AHUAYgBtADUAdQBtAHAAcQB5AFcAYwBLAFIAagB5AGgAMgBKAFQARgBKAFcANQBnAFgARQBJADUAcAA4ADAARwB1ADIAbgB4AEwAUgBOAHcAaQB3AHIANwBXAE0AUgBBAFYASwBGAFcATQBlAFIAegBsADkAVQBxAGcALwBwAFgALwB2AGUATAB3AFMAawAyAFMAUwBIAGYAYQBLADYAagBhAG8AWQB1AG4AUgBHAHIAOABtAGIARQBvAEgAbABGADYASgBDAGEAYQBUAEIAWABCAGMAdgB1AGUAQwBKAG8AOQA4AGgAUgBBAHIARwB3ADQAKwBQAEgAZQBUAGIATgBTAEUAWABYAHoAdgBaADYAdQBXADUARQBBAGYAZABaAG0AUwA4ADgAVgBKAGMAWgBhAEYASwA3AHgAeABnADAAdwBvAG4ANwBoADAAeABDADYAWgBCADAAYwBZAGoATAByAC8ARwBlAE8AegA5AEcANABRAFUASAA5AEUAawB5ADAAZAB5AEYALwByAGUAVQAxAEkAeQBpAGEAcABwAGgATwBQADgAUwAyAHQANABCAHIAUABaAFgAVAB2AEMAMABQADcAegBPACsAZgBHAGsAeABWAG0AKwBVAGYAWgBiAFEANQA1AHMAdwBFAD0AJgBwAD0A</Device>";

	// Token: 0x0200062A RID: 1578
	[StructLayout(LayoutKind.Auto)]
	private struct Struct416 : IAsyncStateMachine
	{
		// Token: 0x06002832 RID: 10290 RVA: 0x0009CC50 File Offset: 0x0009AE50
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			IList<Uri> result3;
			try
			{
				if (num > 1)
				{
					this.xmlDocument_0 = new XmlDocument();
					this.ilist_2 = new List<Uri>();
					this.ienumerator_0 = this.ilist_0.GetEnumerator();
				}
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_232;
						}
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<string>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_AB;
					}
					else
					{
						awaiter2 = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					IL_7B:
					HttpResponseMessage result = awaiter2.GetResult();
					this.xmlDocument_1 = this.xmlDocument_0;
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num4 = 1;
						num = 1;
						this.int_0 = num4;
						this.taskAwaiter_1 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass272.Struct416>(ref awaiter, ref this);
						return;
					}
					IL_AB:
					string result2 = awaiter.GetResult();
					this.xmlDocument_1.LoadXml(result2);
					this.xmlDocument_1 = null;
					IEnumerator enumerator = this.xmlDocument_0.GetElementsByTagName("FileLocation").GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							IEnumerator enumerator2 = ((XmlNode)obj).ChildNodes.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									object obj2 = enumerator2.Current;
									XmlNode xmlNode = (XmlNode)obj2;
									if (xmlNode.Name == "Url" && xmlNode.InnerText.Length != 99)
									{
										this.ilist_2.Add(new Uri(xmlNode.InnerText));
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									IDisposable disposable = enumerator2 as IDisposable;
									if (disposable != null)
									{
										disposable.Dispose();
									}
								}
							}
						}
						goto IL_232;
					}
					finally
					{
						if (num < 0)
						{
							IDisposable disposable = enumerator as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					IL_18A:
					string text = this.ienumerator_0.Current;
					HttpContent content = new StringContent(string.Format(GClass272.smethod_6("FE3FileUrl.xml"), text, this.ilist_1[this.ilist_0.IndexOf(text)], this.string_0 ?? GClass272.string_0), Encoding.UTF8, "application/soap+xml");
					HttpRequestMessage request = new HttpRequestMessage
					{
						RequestUri = GClass85.uri_1,
						Content = content,
						Method = HttpMethod.Post
					};
					awaiter2 = GClass272.gclass244_0.SendAsync(request, default(CancellationToken)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num5 = 0;
						num = 0;
						this.int_0 = num5;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass272.Struct416>(ref awaiter2, ref this);
						return;
					}
					goto IL_7B;
					IL_232:
					if (this.ienumerator_0.MoveNext())
					{
						goto IL_18A;
					}
				}
				finally
				{
					if (num < 0 && this.ienumerator_0 != null)
					{
						this.ienumerator_0.Dispose();
					}
				}
				this.ienumerator_0 = null;
				result3 = this.ilist_2;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.xmlDocument_0 = null;
				this.ilist_2 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.xmlDocument_0 = null;
			this.ilist_2 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x0001A984 File Offset: 0x00018B84
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001A55 RID: 6741
		public int int_0;

		// Token: 0x04001A56 RID: 6742
		public AsyncTaskMethodBuilder<IList<Uri>> asyncTaskMethodBuilder_0;

		// Token: 0x04001A57 RID: 6743
		public IList<string> ilist_0;

		// Token: 0x04001A58 RID: 6744
		public IList<string> ilist_1;

		// Token: 0x04001A59 RID: 6745
		public string string_0;

		// Token: 0x04001A5A RID: 6746
		private XmlDocument xmlDocument_0;

		// Token: 0x04001A5B RID: 6747
		private IList<Uri> ilist_2;

		// Token: 0x04001A5C RID: 6748
		private IEnumerator<string> ienumerator_0;

		// Token: 0x04001A5D RID: 6749
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001A5E RID: 6750
		private XmlDocument xmlDocument_1;

		// Token: 0x04001A5F RID: 6751
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x0200062B RID: 1579
	[StructLayout(LayoutKind.Auto)]
	private struct Struct417 : IAsyncStateMachine
	{
		// Token: 0x06002834 RID: 10292 RVA: 0x0009CFC0 File Offset: 0x0009B1C0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result2;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_14A;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_1A6;
				default:
					this.string_2 = GClass272.smethod_6("WUIDRequest.xml");
					awaiter = GClass272.smethod_3().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass272.Struct417>(ref awaiter, ref this);
						return;
					}
					break;
				}
				string result = awaiter.GetResult();
				HttpContent content = new StringContent(string.Format(this.string_2, result, this.string_0, this.string_1 ?? GClass272.string_0), Encoding.UTF8, "application/soap+xml");
				this.string_2 = null;
				HttpRequestMessage request = new HttpRequestMessage
				{
					RequestUri = GClass85.uri_0,
					Content = content,
					Method = HttpMethod.Post
				};
				awaiter2 = GClass272.gclass244_0.SendAsync(request, default(CancellationToken)).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass272.Struct417>(ref awaiter2, ref this);
					return;
				}
				IL_14A:
				awaiter = awaiter2.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass272.Struct417>(ref awaiter, ref this);
					return;
				}
				IL_1A6:
				result2 = HttpUtility.HtmlDecode(awaiter.GetResult());
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x0001A992 File Offset: 0x00018B92
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001A60 RID: 6752
		public int int_0;

		// Token: 0x04001A61 RID: 6753
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04001A62 RID: 6754
		public string string_0;

		// Token: 0x04001A63 RID: 6755
		public string string_1;

		// Token: 0x04001A64 RID: 6756
		private string string_2;

		// Token: 0x04001A65 RID: 6757
		private TaskAwaiter<string> taskAwaiter_0;

		// Token: 0x04001A66 RID: 6758
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;
	}

	// Token: 0x0200062C RID: 1580
	private sealed class Class760
	{
		// Token: 0x06002837 RID: 10295 RVA: 0x0009D1CC File Offset: 0x0009B3CC
		internal IList<GClass298> method_0()
		{
			IList<GClass298> list = new List<GClass298>();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(this.string_0);
			foreach (object obj in xmlDocument.GetElementsByTagName("AppxMetadata"))
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes.Count >= 3)
				{
					GClass298 item = new GClass298(xmlNode.Attributes.GetNamedItem("PackageMoniker").Value, new Uri("http://test.com"), GClass299.smethod_3(xmlNode.Attributes.GetNamedItem("PackageType").Value), JsonConvert.DeserializeObject<GClass103>(xmlNode.FirstChild.InnerText), string.Empty);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x04001A67 RID: 6759
		public string string_0;
	}

	// Token: 0x0200062D RID: 1581
	[StructLayout(LayoutKind.Auto)]
	private struct Struct418 : IAsyncStateMachine
	{
		// Token: 0x06002838 RID: 10296 RVA: 0x0009D2B0 File Offset: 0x0009B4B0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			IList<GClass298> result2;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				TaskAwaiter<IList<GClass298>> awaiter3;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_14E;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_1AD;
				case 3:
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter<IList<GClass298>>);
					this.int_0 = -1;
					goto IL_209;
				default:
					this.string_2 = GClass272.smethod_6("WUIDRequest.xml");
					awaiter = GClass272.smethod_3().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass272.Struct418>(ref awaiter, ref this);
						return;
					}
					break;
				}
				string result = awaiter.GetResult();
				HttpContent content = new StringContent(string.Format(this.string_2, result, this.string_0, this.string_1 ?? GClass272.string_0), Encoding.UTF8, "application/soap+xml");
				this.string_2 = null;
				HttpRequestMessage request = new HttpRequestMessage
				{
					RequestUri = GClass85.uri_0,
					Content = content,
					Method = HttpMethod.Post
				};
				awaiter2 = GClass272.gclass244_0.SendAsync(request, default(CancellationToken)).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass272.Struct418>(ref awaiter2, ref this);
					return;
				}
				IL_14E:
				awaiter = awaiter2.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass272.Struct418>(ref awaiter, ref this);
					return;
				}
				IL_1AD:
				awaiter3 = GClass272.smethod_2(HttpUtility.HtmlDecode(awaiter.GetResult())).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<GClass298>>, GClass272.Struct418>(ref awaiter3, ref this);
					return;
				}
				IL_209:
				result2 = awaiter3.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001A68 RID: 6760
		public int int_0;

		// Token: 0x04001A69 RID: 6761
		public AsyncTaskMethodBuilder<IList<GClass298>> asyncTaskMethodBuilder_0;

		// Token: 0x04001A6A RID: 6762
		public string string_0;

		// Token: 0x04001A6B RID: 6763
		public string string_1;

		// Token: 0x04001A6C RID: 6764
		private string string_2;

		// Token: 0x04001A6D RID: 6765
		private TaskAwaiter<string> taskAwaiter_0;

		// Token: 0x04001A6E RID: 6766
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;

		// Token: 0x04001A6F RID: 6767
		private TaskAwaiter<IList<GClass298>> taskAwaiter_2;
	}

	// Token: 0x0200062E RID: 1582
	[StructLayout(LayoutKind.Auto)]
	private struct Struct419 : IAsyncStateMachine
	{
		// Token: 0x0600283A RID: 10298 RVA: 0x0009D51C File Offset: 0x0009B71C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string innerText;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<string>);
						this.int_0 = -1;
						goto IL_12F;
					}
					this.xmlDocument_0 = new XmlDocument();
					HttpContent content = new StringContent(GClass272.smethod_6("GetCookie.xml"), Encoding.UTF8, "application/soap+xml");
					HttpRequestMessage request = new HttpRequestMessage
					{
						RequestUri = GClass85.uri_0,
						Content = content,
						Method = HttpMethod.Post
					};
					awaiter2 = GClass272.gclass244_0.SendAsync(request, default(CancellationToken)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass272.Struct419>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
				}
				HttpResponseMessage result = awaiter2.GetResult();
				this.xmlDocument_1 = this.xmlDocument_0;
				awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass272.Struct419>(ref awaiter, ref this);
					return;
				}
				IL_12F:
				string result2 = awaiter.GetResult();
				this.xmlDocument_1.LoadXml(result2);
				this.xmlDocument_1 = null;
				innerText = this.xmlDocument_0.GetElementsByTagName("EncryptedData")[0].InnerText;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.xmlDocument_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.xmlDocument_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(innerText);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x0001A9AE File Offset: 0x00018BAE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001A70 RID: 6768
		public int int_0;

		// Token: 0x04001A71 RID: 6769
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04001A72 RID: 6770
		private XmlDocument xmlDocument_0;

		// Token: 0x04001A73 RID: 6771
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001A74 RID: 6772
		private XmlDocument xmlDocument_1;

		// Token: 0x04001A75 RID: 6773
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x0200062F RID: 1583
	[StructLayout(LayoutKind.Auto)]
	private struct Struct420 : IAsyncStateMachine
	{
		// Token: 0x0600283C RID: 10300 RVA: 0x0009D6EC File Offset: 0x0009B8EC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			IList<GClass298> result;
			try
			{
				TaskAwaiter<IList<GClass298>> awaiter;
				if (num != 0)
				{
					awaiter = Task.Run<IList<GClass298>>(new Func<IList<GClass298>>(new GClass272.Class760
					{
						string_0 = this.string_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<GClass298>>, GClass272.Struct420>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<IList<GClass298>>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0001A9BC File Offset: 0x00018BBC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001A76 RID: 6774
		public int int_0;

		// Token: 0x04001A77 RID: 6775
		public AsyncTaskMethodBuilder<IList<GClass298>> asyncTaskMethodBuilder_0;

		// Token: 0x04001A78 RID: 6776
		public string string_0;

		// Token: 0x04001A79 RID: 6777
		private TaskAwaiter<IList<GClass298>> taskAwaiter_0;
	}
}
