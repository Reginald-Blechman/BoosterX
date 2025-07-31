using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x02000395 RID: 917
public sealed class GClass146 : GClass143, GInterface17
{
	// Token: 0x060017C8 RID: 6088 RVA: 0x0001042D File Offset: 0x0000E62D
	internal GClass146(GClass11 gclass11_1) : base(gclass11_1)
	{
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x00010441 File Offset: 0x0000E641
	protected override string vmethod_0()
	{
		return "audio/speech";
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x00010449 File Offset: 0x0000E649
	[CompilerGenerated]
	public GClass73 imethod_0()
	{
		return this.gclass73_0;
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x00010451 File Offset: 0x0000E651
	[CompilerGenerated]
	public void imethod_1(GClass73 gclass73_1)
	{
		this.gclass73_0 = gclass73_1;
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x0006C4E4 File Offset: 0x0006A6E4
	public Task<Stream> imethod_2(GClass73 gclass73_1)
	{
		GClass146.Struct209 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Stream>.Create();
		@struct.gclass146_0 = this;
		@struct.gclass73_0 = gclass73_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass146.Struct209>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x0006C530 File Offset: 0x0006A730
	public Task<Stream> imethod_3(string string_0, string string_1 = null, double? nullable_0 = null, string string_2 = null, GClass27 gclass27_0 = null)
	{
		GClass146.Struct212 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Stream>.Create();
		@struct.gclass146_0 = this;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.nullable_0 = nullable_0;
		@struct.string_2 = string_2;
		@struct.gclass27_0 = gclass27_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass146.Struct212>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x0006C5A0 File Offset: 0x0006A7A0
	public Task<FileInfo> imethod_4(GClass73 gclass73_1, string string_0)
	{
		GClass146.Struct210 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<FileInfo>.Create();
		@struct.gclass146_0 = this;
		@struct.gclass73_0 = gclass73_1;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass146.Struct210>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x0006C5F4 File Offset: 0x0006A7F4
	public Task<FileInfo> imethod_5(string string_0, string string_1, string string_2 = null, double? nullable_0 = null, string string_3 = null, GClass27 gclass27_0 = null)
	{
		GClass146.Struct211 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<FileInfo>.Create();
		@struct.gclass146_0 = this;
		@struct.string_0 = string_0;
		@struct.string_3 = string_1;
		@struct.string_1 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.string_2 = string_3;
		@struct.gclass27_0 = gclass27_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass146.Struct211>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000FB9 RID: 4025
	private GClass73 gclass73_0 = new GClass73();

	// Token: 0x02000396 RID: 918
	[StructLayout(LayoutKind.Auto)]
	private struct Struct209 : IAsyncStateMachine
	{
		// Token: 0x060017D0 RID: 6096 RVA: 0x0006C66C File Offset: 0x0006A86C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass146 gclass = this.gclass146_0;
			Stream result;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_5(null, HttpMethod.Post, this.gclass73_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass146.Struct209>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Stream>);
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

		// Token: 0x060017D1 RID: 6097 RVA: 0x0001045A File Offset: 0x0000E65A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000FBA RID: 4026
		public int int_0;

		// Token: 0x04000FBB RID: 4027
		public AsyncTaskMethodBuilder<Stream> asyncTaskMethodBuilder_0;

		// Token: 0x04000FBC RID: 4028
		public GClass146 gclass146_0;

		// Token: 0x04000FBD RID: 4029
		public GClass73 gclass73_0;

		// Token: 0x04000FBE RID: 4030
		private TaskAwaiter<Stream> taskAwaiter_0;
	}

	// Token: 0x02000397 RID: 919
	[StructLayout(LayoutKind.Auto)]
	private struct Struct210 : IAsyncStateMachine
	{
		// Token: 0x060017D2 RID: 6098 RVA: 0x0006C730 File Offset: 0x0006A930
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass146 gclass = this.gclass146_0;
			FileInfo result2;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_80;
					}
					awaiter = gclass.imethod_2(this.gclass73_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass146.Struct210>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Stream>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				Stream result = awaiter.GetResult();
				this.stream_0 = result;
				IL_80:
				try
				{
					if (num != 1)
					{
						this.fileStream_0 = new FileStream(this.string_0, FileMode.Create);
					}
					try
					{
						TaskAwaiter awaiter2;
						if (num != 1)
						{
							awaiter2 = this.stream_0.CopyToAsync(this.fileStream_0).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.int_0 = num4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass146.Struct210>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						awaiter2.GetResult();
					}
					finally
					{
						if (num < 0 && this.fileStream_0 != null)
						{
							((IDisposable)this.fileStream_0).Dispose();
						}
					}
					this.fileStream_0 = null;
				}
				finally
				{
					if (num < 0 && this.stream_0 != null)
					{
						((IDisposable)this.stream_0).Dispose();
					}
				}
				this.stream_0 = null;
				result2 = new FileInfo(this.string_0);
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

		// Token: 0x060017D3 RID: 6099 RVA: 0x00010468 File Offset: 0x0000E668
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000FBF RID: 4031
		public int int_0;

		// Token: 0x04000FC0 RID: 4032
		public AsyncTaskMethodBuilder<FileInfo> asyncTaskMethodBuilder_0;

		// Token: 0x04000FC1 RID: 4033
		public GClass146 gclass146_0;

		// Token: 0x04000FC2 RID: 4034
		public GClass73 gclass73_0;

		// Token: 0x04000FC3 RID: 4035
		public string string_0;

		// Token: 0x04000FC4 RID: 4036
		private Stream stream_0;

		// Token: 0x04000FC5 RID: 4037
		private TaskAwaiter<Stream> taskAwaiter_0;

		// Token: 0x04000FC6 RID: 4038
		private FileStream fileStream_0;

		// Token: 0x04000FC7 RID: 4039
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000398 RID: 920
	[StructLayout(LayoutKind.Auto)]
	private struct Struct211 : IAsyncStateMachine
	{
		// Token: 0x060017D4 RID: 6100 RVA: 0x0006C90C File Offset: 0x0006AB0C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass146 gclass = this.gclass146_0;
			FileInfo result;
			try
			{
				TaskAwaiter<FileInfo> awaiter;
				if (num != 0)
				{
					GClass73 gclass2 = new GClass73();
					gclass2.String_1 = this.string_0;
					gclass2.String_2 = (this.string_1 ?? gclass.imethod_0().String_2);
					double? num2 = this.nullable_0;
					gclass2.Nullable_0 = ((num2 != null) ? num2 : gclass.imethod_0().Nullable_0);
					gclass2.String_0 = (this.gclass27_0 ?? gclass.imethod_0().String_0);
					gclass2.String_3 = (this.string_2 ?? gclass.imethod_0().String_3);
					GClass73 gclass73_ = gclass2;
					awaiter = gclass.imethod_4(gclass73_, this.string_3).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<FileInfo>, GClass146.Struct211>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<FileInfo>);
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

		// Token: 0x060017D5 RID: 6101 RVA: 0x00010476 File Offset: 0x0000E676
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000FC8 RID: 4040
		public int int_0;

		// Token: 0x04000FC9 RID: 4041
		public AsyncTaskMethodBuilder<FileInfo> asyncTaskMethodBuilder_0;

		// Token: 0x04000FCA RID: 4042
		public string string_0;

		// Token: 0x04000FCB RID: 4043
		public string string_1;

		// Token: 0x04000FCC RID: 4044
		public GClass146 gclass146_0;

		// Token: 0x04000FCD RID: 4045
		public double? nullable_0;

		// Token: 0x04000FCE RID: 4046
		public GClass27 gclass27_0;

		// Token: 0x04000FCF RID: 4047
		public string string_2;

		// Token: 0x04000FD0 RID: 4048
		public string string_3;

		// Token: 0x04000FD1 RID: 4049
		private TaskAwaiter<FileInfo> taskAwaiter_0;
	}

	// Token: 0x02000399 RID: 921
	[StructLayout(LayoutKind.Auto)]
	private struct Struct212 : IAsyncStateMachine
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x0006CA64 File Offset: 0x0006AC64
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass146 gclass = this.gclass146_0;
			Stream result;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					GClass73 gclass2 = new GClass73();
					gclass2.String_1 = this.string_0;
					gclass2.String_2 = (this.string_1 ?? gclass.imethod_0().String_2);
					double? num2 = this.nullable_0;
					gclass2.Nullable_0 = ((num2 != null) ? num2 : gclass.imethod_0().Nullable_0);
					gclass2.String_0 = (this.gclass27_0 ?? gclass.imethod_0().String_0);
					gclass2.String_3 = (this.string_2 ?? gclass.imethod_0().String_3);
					GClass73 object_ = gclass2;
					awaiter = gclass.method_5(null, HttpMethod.Post, object_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass146.Struct212>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Stream>);
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

		// Token: 0x060017D7 RID: 6103 RVA: 0x00010484 File Offset: 0x0000E684
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000FD2 RID: 4050
		public int int_0;

		// Token: 0x04000FD3 RID: 4051
		public AsyncTaskMethodBuilder<Stream> asyncTaskMethodBuilder_0;

		// Token: 0x04000FD4 RID: 4052
		public string string_0;

		// Token: 0x04000FD5 RID: 4053
		public string string_1;

		// Token: 0x04000FD6 RID: 4054
		public GClass146 gclass146_0;

		// Token: 0x04000FD7 RID: 4055
		public double? nullable_0;

		// Token: 0x04000FD8 RID: 4056
		public GClass27 gclass27_0;

		// Token: 0x04000FD9 RID: 4057
		public string string_2;

		// Token: 0x04000FDA RID: 4058
		private TaskAwaiter<Stream> taskAwaiter_0;
	}
}
