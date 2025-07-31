using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

// Token: 0x020001E6 RID: 486
internal sealed class Class497 : GClass162
{
	// Token: 0x06000D50 RID: 3408 RVA: 0x0004E360 File Offset: 0x0004C560
	public Class497()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		this.method_3();
		Class374.smethod_0().method_0(new Class374.Delegate27(this.method_2));
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00009FFF File Offset: 0x000081FF
	private void method_2(CultureInfo cultureInfo_0)
	{
		this.method_3();
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x0000A007 File Offset: 0x00008207
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("News");
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0000A015 File Offset: 0x00008215
	// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0000A01D File Offset: 0x0000821D
	public ObservableCollection<Class531> News
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("News");
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000D55 RID: 3413 RVA: 0x0000A032 File Offset: 0x00008232
	// (set) Token: 0x06000D56 RID: 3414 RVA: 0x0000A03A File Offset: 0x0000823A
	public string _Error
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0000A043 File Offset: 0x00008243
	// (set) Token: 0x06000D58 RID: 3416 RVA: 0x0000A04B File Offset: 0x0000824B
	public string Error
	{
		get
		{
			return this._Error;
		}
		set
		{
			this._Error = value;
			base.method_0("Error");
		}
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x0004E3CC File Offset: 0x0004C5CC
	private void method_3()
	{
		Class497.Struct107 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class497_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class497.Struct107>(ref @struct);
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x0004E404 File Offset: 0x0004C604
	private Task method_4()
	{
		Class497.Struct108 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class497_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class497.Struct108>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x0000A060 File Offset: 0x00008260
	private void method_5(Class254 class254_0)
	{
		this.News.Add(new Class531(class254_0));
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x0000A060 File Offset: 0x00008260
	private void method_6(Class254 class254_0)
	{
		this.News.Add(new Class531(class254_0));
	}

	// Token: 0x04000881 RID: 2177
	private string string_0 = "News.json";

	// Token: 0x04000882 RID: 2178
	public ObservableCollection<Class531> observableCollection_0 = new ObservableCollection<Class531>();

	// Token: 0x04000883 RID: 2179
	private string string_1;

	// Token: 0x04000884 RID: 2180
	private SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x020001E7 RID: 487
	private sealed class Class234
	{
		// Token: 0x06000D5E RID: 3422 RVA: 0x0000A073 File Offset: 0x00008273
		internal void method_0()
		{
			this.list_0.ForEach(new Action<Class254>(this.class235_0.class497_0.method_5));
		}

		// Token: 0x04000885 RID: 2181
		public List<Class254> list_0;

		// Token: 0x04000886 RID: 2182
		public Class497.Class235 class235_0;
	}

	// Token: 0x020001E8 RID: 488
	[StructLayout(LayoutKind.Auto)]
	private struct Struct107 : IAsyncStateMachine
	{
		// Token: 0x06000D5F RID: 3423 RVA: 0x0004E448 File Offset: 0x0004C648
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class497 @object = this.class497_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_4)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class497.Struct107>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0000A096 File Offset: 0x00008296
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000887 RID: 2183
		public int int_0;

		// Token: 0x04000888 RID: 2184
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000889 RID: 2185
		public Class497 class497_0;

		// Token: 0x0400088A RID: 2186
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001E9 RID: 489
	private sealed class Class235
	{
		// Token: 0x06000D62 RID: 3426 RVA: 0x0004E508 File Offset: 0x0004C708
		internal void method_0()
		{
			if (this.class497_0.News.Count<Class531>() > 0)
			{
				this.class497_0.News.Clear();
			}
			this.list_0.ForEach(new Action<Class254>(this.class497_0.method_6));
		}

		// Token: 0x0400088B RID: 2187
		public List<Class254> list_0;

		// Token: 0x0400088C RID: 2188
		public Class497 class497_0;
	}

	// Token: 0x020001EA RID: 490
	[StructLayout(LayoutKind.Auto)]
	private struct Struct108 : IAsyncStateMachine
	{
		// Token: 0x06000D63 RID: 3427 RVA: 0x0004E554 File Offset: 0x0004C754
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class497 @class = this.class497_0;
			try
			{
				try
				{
					TaskAwaiter<Class723> awaiter;
					TaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<Class723>);
							int num2 = -1;
							num = -1;
							this.int_0 = num2;
							goto IL_1A6;
						}
						this.class235_0 = new Class497.Class235();
						this.class235_0.class497_0 = @class;
						awaiter2 = @class.semaphoreSlim_0.WaitAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.int_0 = num3;
							this.taskAwaiter_0 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class497.Struct108>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num4 = -1;
						num = -1;
						this.int_0 = num4;
					}
					awaiter2.GetResult();
					if (Directory.Exists(Class169.string_7) && File.Exists(Path.Combine(Class169.string_7, @class.string_0)))
					{
						StreamReader streamReader = new StreamReader(Path.Combine(Class169.string_7, @class.string_0));
						try
						{
							string text = streamReader.ReadToEnd();
							streamReader.Close();
							try
							{
								Class497.Class234 class2 = new Class497.Class234();
								class2.class235_0 = this.class235_0;
								class2.list_0 = JsonConvert.DeserializeObject<List<Class254>>(text);
								Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
							}
							catch
							{
								File.Delete(Path.Combine(Class169.string_7, @class.string_0));
							}
						}
						finally
						{
							if (num < 0 && streamReader != null)
							{
								((IDisposable)streamReader).Dispose();
							}
						}
					}
					awaiter = Class215.smethod_1("News", null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num5 = 1;
						num = 1;
						this.int_0 = num5;
						this.taskAwaiter_1 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class497.Struct108>(ref awaiter, ref this);
						return;
					}
					IL_1A6:
					Class723 result = awaiter.GetResult();
					if (result.Success)
					{
						this.class235_0.list_0 = JsonConvert.DeserializeObject<List<Class254>>(result.Message);
						Application.Current.Dispatcher.Invoke(new Action(this.class235_0.method_0));
						if (!Directory.Exists(Class169.string_7))
						{
							Directory.CreateDirectory(Class169.string_7);
						}
						StreamWriter streamWriter = new StreamWriter(Path.Combine(Class169.string_7, @class.string_0));
						try
						{
							streamWriter.Write(result.Message);
							streamWriter.Close();
						}
						finally
						{
							if (num < 0 && streamWriter != null)
							{
								((IDisposable)streamWriter).Dispose();
							}
						}
						this.class235_0 = null;
					}
				}
				catch
				{
				}
				finally
				{
					if (num < 0)
					{
						@class.semaphoreSlim_0.Release();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0000A0A4 File Offset: 0x000082A4
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400088D RID: 2189
		public int int_0;

		// Token: 0x0400088E RID: 2190
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400088F RID: 2191
		public Class497 class497_0;

		// Token: 0x04000890 RID: 2192
		private Class497.Class235 class235_0;

		// Token: 0x04000891 RID: 2193
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000892 RID: 2194
		private TaskAwaiter<Class723> taskAwaiter_1;
	}
}
