using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ns0;

// Token: 0x020005FA RID: 1530
internal sealed class Class731
{
	// Token: 0x06002732 RID: 10034 RVA: 0x00098FC4 File Offset: 0x000971C4
	public static Task smethod_0(string string_0)
	{
		Class731.Struct404 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class731.Struct404>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002733 RID: 10035 RVA: 0x00099008 File Offset: 0x00097208
	private static Task<List<Class265>> smethod_1()
	{
		Class731.Struct405 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class265>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class731.Struct405>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x020005FB RID: 1531
	[StructLayout(LayoutKind.Auto)]
	private struct Struct404 : IAsyncStateMachine
	{
		// Token: 0x06002734 RID: 10036 RVA: 0x00099044 File Offset: 0x00097244
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				{
					IL_1A9:
					try
					{
						if (num != 1)
						{
							this.gclass180_0 = GClass28.smethod_0(false);
							awaiter = GClass28.smethod_1().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 1;
								num = 1;
								this.int_0 = num3;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class731.Struct404>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.int_0 = num4;
						}
						awaiter.GetResult();
						IEnumerator<GClass179> enumerator = this.gclass180_0.NetworkAdapters.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								GClass179 gclass = enumerator.Current;
								IEnumerator<GClass171> enumerator2 = gclass.Settings.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										GClass171 gclass2 = enumerator2.Current;
										this.class732_0.list_0.Add(new Class265
										{
											Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.NetworkAdapter,
											Name = gclass.Name + "|" + gclass2.NameClean,
											State = ((gclass2.Values != null) ? gclass2.SelectedRaw : gclass2.CustomValue)
										});
									}
								}
								finally
								{
									if (num < 0 && enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						this.gclass180_0 = null;
					}
					catch (Exception exception_)
					{
						GClass268.smethod_1(exception_);
					}
					this.class732_0.list_0.Add(new Class265
					{
						Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Affinity,
						Name = "ThreadsCount",
						State = Class551.class753_0.method_94().ToString()
					});
					Class261 class261_ = new Class261
					{
						DateTime_0 = DateTime.Now,
						List_0 = this.class732_0.list_0
					};
					this.list_0 = new List<ValueTuple<string, byte[]>>
					{
						new ValueTuple<string, byte[]>("BOOSTER.bux", Class689.smethod_0(class261_))
					};
					goto IL_36C;
				}
				case 2:
					goto IL_36C;
				default:
					this.class732_0 = new Class731.Class732();
					this.class732_0.list_0 = new List<Class265>();
					awaiter = Task.WhenAll(new List<Task>
					{
						Task.Run(new Func<Task>(this.class732_0.method_0)),
						Task.Run(new Func<Task>(this.class732_0.method_1)),
						Task.Run(new Func<Task>(this.class732_0.method_2)),
						Task.Run(new Func<Task>(this.class732_0.method_3)),
						Task.Run(new Action(this.class732_0.method_4)),
						Task.Run(new Func<Task>(this.class732_0.method_5))
					}).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num5 = 0;
						num = 0;
						this.int_0 = num5;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class731.Struct404>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				try
				{
					byte[] array = GClass250.smethod_1();
					if (array != null)
					{
						Class293 @class = new Class293
						{
							Name = GClass250.smethod_2(),
							Guid = GClass250.smethod_6(),
							Data = array
						};
						this.class732_0.list_0.Add(new Class265
						{
							Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Power,
							Name = "CurrentProfile",
							State = JsonConvert.SerializeObject(@class)
						});
					}
				}
				catch (Exception exception_2)
				{
					GClass268.smethod_1(exception_2);
				}
				goto IL_1A9;
				IL_36C:
				try
				{
					if (num != 2)
					{
						if (!dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_18)
						{
							goto IL_3F3;
						}
						awaiter = GClass300.smethod_9().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num6 = 2;
							num = 2;
							this.int_0 = num6;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class731.Struct404>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num7 = -1;
						num = -1;
						this.int_0 = num7;
					}
					awaiter.GetResult();
					this.list_0.Add(new ValueTuple<string, byte[]>("NVIDIA.nvx", GClass300.smethod_27().smethod_20(true)));
					IL_3F3:;
				}
				catch (Exception exception_3)
				{
					GClass268.smethod_1(exception_3);
				}
				int num8 = 0;
				try
				{
					string path;
					do
					{
						path = Class169.string_6 + string.Format("\\{0}_{1}.buxz", this.string_0, num8++);
					}
					while (File.Exists(path));
					GClass224 gclass3 = new GClass224(path);
					try
					{
						gclass3.method_1(this.list_0);
					}
					finally
					{
						if (num < 0 && gclass3 != null)
						{
							((IDisposable)gclass3).Dispose();
						}
					}
				}
				catch (Exception exception_4)
				{
					GClass268.smethod_1(exception_4);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class732_0 = null;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class732_0 = null;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0001A10F File Offset: 0x0001830F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040019D2 RID: 6610
		public int int_0;

		// Token: 0x040019D3 RID: 6611
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040019D4 RID: 6612
		private Class731.Class732 class732_0;

		// Token: 0x040019D5 RID: 6613
		public string string_0;

		// Token: 0x040019D6 RID: 6614
		private List<ValueTuple<string, byte[]>> list_0;

		// Token: 0x040019D7 RID: 6615
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x040019D8 RID: 6616
		private GClass180 gclass180_0;
	}

	// Token: 0x020005FC RID: 1532
	[StructLayout(LayoutKind.Auto)]
	private struct Struct405 : IAsyncStateMachine
	{
		// Token: 0x06002736 RID: 10038 RVA: 0x000995C4 File Offset: 0x000977C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class265> result;
			try
			{
				if (num != 0)
				{
					this.list_0 = new List<Class265>();
				}
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.gclass183_0 = GClass134.smethod_0(false);
						awaiter = GClass134.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class731.Struct405>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
					IEnumerator<GClass186> enumerator = this.gclass183_0.MsiSupportedDevices.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							GClass186 gclass = enumerator.Current;
							this.list_0.Add(new Class265
							{
								Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.DevicesMSI,
								Name = gclass.Name,
								State = gclass.MsiCurrentStatus.ToString()
							});
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					enumerator = this.gclass183_0.CanBeDisabled.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							GClass186 gclass2 = enumerator.Current;
							this.list_0.Add(new Class265
							{
								Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.DevicesDisabled,
								Name = gclass2.Name,
								State = gclass2.CurrentStatus.ToString()
							});
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					IEnumerator<GClass188> enumerator2 = this.gclass183_0.CustomDisableDevices.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							GClass188 gclass3 = enumerator2.Current;
							if (gclass3.CurrentIsDisabled != null)
							{
								this.list_0.Add(new Class265
								{
									Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.DevicesGroupDisabled,
									Name = gclass3.Name,
									State = gclass3.CurrentIsDisabled.Value.ToString()
								});
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					this.gclass183_0 = null;
				}
				catch
				{
				}
				result = this.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0001A11D File Offset: 0x0001831D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040019D9 RID: 6617
		public int int_0;

		// Token: 0x040019DA RID: 6618
		public AsyncTaskMethodBuilder<List<Class265>> asyncTaskMethodBuilder_0;

		// Token: 0x040019DB RID: 6619
		private List<Class265> list_0;

		// Token: 0x040019DC RID: 6620
		private GClass134.GClass183 gclass183_0;

		// Token: 0x040019DD RID: 6621
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005FD RID: 1533
	private sealed class Class732
	{
		// Token: 0x06002739 RID: 10041 RVA: 0x00099890 File Offset: 0x00097A90
		internal Task method_0()
		{
			Class731.Class732.Struct408 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class732_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class731.Class732.Struct408>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x000998D4 File Offset: 0x00097AD4
		internal Task method_1()
		{
			Class731.Class732.Struct409 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class732_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class731.Class732.Struct409>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00099918 File Offset: 0x00097B18
		internal Task method_2()
		{
			Class731.Class732.Struct406 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class732_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class731.Class732.Struct406>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x0009995C File Offset: 0x00097B5C
		internal Task method_3()
		{
			Class731.Class732.Struct407 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class732_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class731.Class732.Struct407>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0001A12B File Offset: 0x0001832B
		internal void method_4()
		{
			this.list_0.AddRange(Class734.smethod_1());
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000999A0 File Offset: 0x00097BA0
		internal Task method_5()
		{
			Class731.Class732.Struct410 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class732_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class731.Class732.Struct410>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040019DE RID: 6622
		public List<Class265> list_0;

		// Token: 0x020005FE RID: 1534
		[StructLayout(LayoutKind.Auto)]
		private struct Struct406 : IAsyncStateMachine
		{
			// Token: 0x0600273F RID: 10047 RVA: 0x000999E4 File Offset: 0x00097BE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class731.Class732 @class = this.class732_0;
				try
				{
					TaskAwaiter<List<Class265>> awaiter;
					if (num != 0)
					{
						this.list_0 = @class.list_0;
						awaiter = Class646.smethod_7().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class265>>, Class731.Class732.Struct406>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class265>>);
						this.int_0 = -1;
					}
					List<Class265> result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
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

			// Token: 0x06002740 RID: 10048 RVA: 0x0001A13D File Offset: 0x0001833D
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040019DF RID: 6623
			public int int_0;

			// Token: 0x040019E0 RID: 6624
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040019E1 RID: 6625
			public Class731.Class732 class732_0;

			// Token: 0x040019E2 RID: 6626
			private List<Class265> list_0;

			// Token: 0x040019E3 RID: 6627
			private TaskAwaiter<List<Class265>> taskAwaiter_0;
		}

		// Token: 0x020005FF RID: 1535
		[StructLayout(LayoutKind.Auto)]
		private struct Struct407 : IAsyncStateMachine
		{
			// Token: 0x06002741 RID: 10049 RVA: 0x00099AB8 File Offset: 0x00097CB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class731.Class732 @class = this.class732_0;
				try
				{
					TaskAwaiter<List<Class265>> awaiter;
					if (num != 0)
					{
						this.list_0 = @class.list_0;
						awaiter = Class362.smethod_6().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class265>>, Class731.Class732.Struct407>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class265>>);
						this.int_0 = -1;
					}
					List<Class265> result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
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

			// Token: 0x06002742 RID: 10050 RVA: 0x0001A14B File Offset: 0x0001834B
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040019E4 RID: 6628
			public int int_0;

			// Token: 0x040019E5 RID: 6629
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040019E6 RID: 6630
			public Class731.Class732 class732_0;

			// Token: 0x040019E7 RID: 6631
			private List<Class265> list_0;

			// Token: 0x040019E8 RID: 6632
			private TaskAwaiter<List<Class265>> taskAwaiter_0;
		}

		// Token: 0x02000600 RID: 1536
		[StructLayout(LayoutKind.Auto)]
		private struct Struct408 : IAsyncStateMachine
		{
			// Token: 0x06002743 RID: 10051 RVA: 0x00099B8C File Offset: 0x00097D8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class731.Class732 @class = this.class732_0;
				try
				{
					TaskAwaiter<List<Class265>> awaiter;
					if (num != 0)
					{
						this.list_0 = @class.list_0;
						awaiter = Class148.smethod_14().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class265>>, Class731.Class732.Struct408>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class265>>);
						this.int_0 = -1;
					}
					List<Class265> result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
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

			// Token: 0x06002744 RID: 10052 RVA: 0x0001A159 File Offset: 0x00018359
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040019E9 RID: 6633
			public int int_0;

			// Token: 0x040019EA RID: 6634
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040019EB RID: 6635
			public Class731.Class732 class732_0;

			// Token: 0x040019EC RID: 6636
			private List<Class265> list_0;

			// Token: 0x040019ED RID: 6637
			private TaskAwaiter<List<Class265>> taskAwaiter_0;
		}

		// Token: 0x02000601 RID: 1537
		[StructLayout(LayoutKind.Auto)]
		private struct Struct409 : IAsyncStateMachine
		{
			// Token: 0x06002745 RID: 10053 RVA: 0x00099C60 File Offset: 0x00097E60
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class731.Class732 @class = this.class732_0;
				try
				{
					TaskAwaiter<List<Class265>> awaiter;
					if (num != 0)
					{
						this.list_0 = @class.list_0;
						awaiter = Class242.smethod_6().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class265>>, Class731.Class732.Struct409>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class265>>);
						this.int_0 = -1;
					}
					List<Class265> result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
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

			// Token: 0x06002746 RID: 10054 RVA: 0x0001A167 File Offset: 0x00018367
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040019EE RID: 6638
			public int int_0;

			// Token: 0x040019EF RID: 6639
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040019F0 RID: 6640
			public Class731.Class732 class732_0;

			// Token: 0x040019F1 RID: 6641
			private List<Class265> list_0;

			// Token: 0x040019F2 RID: 6642
			private TaskAwaiter<List<Class265>> taskAwaiter_0;
		}

		// Token: 0x02000602 RID: 1538
		[StructLayout(LayoutKind.Auto)]
		private struct Struct410 : IAsyncStateMachine
		{
			// Token: 0x06002747 RID: 10055 RVA: 0x00099D34 File Offset: 0x00097F34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class731.Class732 @class = this.class732_0;
				try
				{
					TaskAwaiter<List<Class265>> awaiter;
					if (num != 0)
					{
						this.list_0 = @class.list_0;
						awaiter = Class731.smethod_1().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class265>>, Class731.Class732.Struct410>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class265>>);
						this.int_0 = -1;
					}
					List<Class265> result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
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

			// Token: 0x06002748 RID: 10056 RVA: 0x0001A175 File Offset: 0x00018375
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040019F3 RID: 6643
			public int int_0;

			// Token: 0x040019F4 RID: 6644
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040019F5 RID: 6645
			public Class731.Class732 class732_0;

			// Token: 0x040019F6 RID: 6646
			private List<Class265> list_0;

			// Token: 0x040019F7 RID: 6647
			private TaskAwaiter<List<Class265>> taskAwaiter_0;
		}
	}
}
