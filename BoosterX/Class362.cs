using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x020002FB RID: 763
internal sealed class Class362
{
	// Token: 0x060013E9 RID: 5097 RVA: 0x0000DFB7 File Offset: 0x0000C1B7
	// Note: this type is marked as 'beforefieldinit'.
	static Class362()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "o=q]?Za-j>", null);
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00062750 File Offset: 0x00060950
	public static Class515 smethod_0(bool bool_3)
	{
		object[] object_ = new object[]
		{
			bool_3
		};
		return (Class515)Class392.smethod_3().method_105(Class392.smethod_1(), "d(cuqZa-j%", object_);
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x0000DFCE File Offset: 0x0000C1CE
	public static void smethod_1()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "f>\"`#Za-iu", null);
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x000094FC File Offset: 0x000076FC
	internal static bool smethod_2()
	{
		return Class733.smethod_0();
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x0000DFE5 File Offset: 0x0000C1E5
	public static Task smethod_3()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "Ekf#hZa-j'", null);
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x0000E001 File Offset: 0x0000C201
	public static Task smethod_4()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), ",JUXnZa-is", null);
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x0000E01D File Offset: 0x0000C21D
	public static Task smethod_5()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "o=q]?Za-k/", null);
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x0000E039 File Offset: 0x0000C239
	public static Task<List<Class265>> smethod_6()
	{
		return (Task<List<Class265>>)Class392.smethod_3().method_105(Class392.smethod_1(), "Btq'_Za-k3", null);
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x0000E055 File Offset: 0x0000C255
	private static void smethod_7(ref Class362.Struct168 struct168_0)
	{
		struct168_0.asyncVoidMethodBuilder_0.Start<Class362.Struct168>(ref struct168_0);
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x0000E063 File Offset: 0x0000C263
	private static void smethod_8(ref Class362.Struct164 struct164_0)
	{
		struct164_0.asyncTaskMethodBuilder_0.Start<Class362.Struct164>(ref struct164_0);
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x0000E071 File Offset: 0x0000C271
	private static void smethod_9(ref Class362.Struct166 struct166_0)
	{
		struct166_0.asyncTaskMethodBuilder_0.Start<Class362.Struct166>(ref struct166_0);
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x0000E07F File Offset: 0x0000C27F
	private static void smethod_10(ref Class362.Struct165 struct165_0)
	{
		struct165_0.asyncTaskMethodBuilder_0.Start<Class362.Struct165>(ref struct165_0);
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x0000E08D File Offset: 0x0000C28D
	private static void smethod_11(ref Class362.Struct167 struct167_0)
	{
		struct167_0.asyncTaskMethodBuilder_0.Start<Class362.Struct167>(ref struct167_0);
	}

	// Token: 0x04000D4C RID: 3404
	private static Class515 class515_0;

	// Token: 0x04000D4D RID: 3405
	private static bool bool_0;

	// Token: 0x04000D4E RID: 3406
	private static bool bool_1;

	// Token: 0x04000D4F RID: 3407
	private static bool bool_2;

	// Token: 0x020002FC RID: 764
	[StructLayout(LayoutKind.Auto)]
	private struct Struct164 : IAsyncStateMachine
	{
		// Token: 0x060013F6 RID: 5110 RVA: 0x00062788 File Offset: 0x00060988
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "I)!(rZa-ih", array);
			}
			finally
			{
				this = (Class362.Struct164)array[0];
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0000E09B File Offset: 0x0000C29B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0000E0A9 File Offset: 0x0000C2A9
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class362.Struct164 struct164_0)
		{
			struct164_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class362.Struct164>(ref taskAwaiter_1, ref struct164_0);
		}

		// Token: 0x04000D50 RID: 3408
		public int int_0;

		// Token: 0x04000D51 RID: 3409
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000D52 RID: 3410
		private Class362.Class369 class369_0;

		// Token: 0x04000D53 RID: 3411
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002FD RID: 765
	[StructLayout(LayoutKind.Auto)]
	private struct Struct165 : IAsyncStateMachine
	{
		// Token: 0x060013F9 RID: 5113 RVA: 0x000627F0 File Offset: 0x000609F0
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "UVF4DZa-k0", array);
			}
			finally
			{
				this = (Class362.Struct165)array[0];
			}
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0000E0C6 File Offset: 0x0000C2C6
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class362.Struct165 struct165_0)
		{
			struct165_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class362.Struct165>(ref taskAwaiter_1, ref struct165_0);
		}

		// Token: 0x04000D54 RID: 3412
		public int int_0;

		// Token: 0x04000D55 RID: 3413
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000D56 RID: 3414
		private int int_1;

		// Token: 0x04000D57 RID: 3415
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002FE RID: 766
	private sealed class Class363
	{
		// Token: 0x060013FD RID: 5117 RVA: 0x00062858 File Offset: 0x00060A58
		internal void method_0()
		{
			Class362.class515_0.DeviceViewModels.Last<Class505>().Name = this.string_0;
			Class362.class515_0.DeviceViewModels.Last<Class505>().Path = this.string_1;
			Class362.class515_0.DeviceViewModels.Last<Class505>().NewAffinity = this.string_2;
			Class362.bool_2 = false;
			Class362.bool_1 = true;
		}

		// Token: 0x04000D58 RID: 3416
		public string string_0;

		// Token: 0x04000D59 RID: 3417
		public string string_1;

		// Token: 0x04000D5A RID: 3418
		public string string_2;
	}

	// Token: 0x020002FF RID: 767
	private sealed class Class364
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x0000E0D5 File Offset: 0x0000C2D5
		internal void method_0()
		{
			Class362.class515_0.JsonTweaks = this.observableCollection_0;
			Class362.class515_0.DeviceViewModels.Clear();
		}

		// Token: 0x04000D5B RID: 3419
		public ObservableCollection<Class512> observableCollection_0;
	}

	// Token: 0x02000300 RID: 768
	private sealed class Class365
	{
		// Token: 0x06001401 RID: 5121 RVA: 0x0000E0F6 File Offset: 0x0000C2F6
		internal bool method_0(string string_0)
		{
			return this.class505_0.Name.ToLower().Contains(string_0);
		}

		// Token: 0x04000D5C RID: 3420
		public Class505 class505_0;
	}

	// Token: 0x02000301 RID: 769
	[StructLayout(LayoutKind.Auto)]
	private struct Struct166 : IAsyncStateMachine
	{
		// Token: 0x06001402 RID: 5122 RVA: 0x000628C0 File Offset: 0x00060AC0
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "-GQsqZa-k*", array);
			}
			finally
			{
				this = (Class362.Struct166)array[0];
			}
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0000E10E File Offset: 0x0000C30E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0000E11C File Offset: 0x0000C31C
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class362.Struct166 struct166_0)
		{
			struct166_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class362.Struct166>(ref taskAwaiter_1, ref struct166_0);
		}

		// Token: 0x04000D5D RID: 3421
		public int int_0;

		// Token: 0x04000D5E RID: 3422
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000D5F RID: 3423
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000302 RID: 770
	private sealed class Class366
	{
		// Token: 0x06001406 RID: 5126 RVA: 0x00062928 File Offset: 0x00060B28
		internal void method_0()
		{
			Class362.class515_0.DeviceViewModels.Add(new Class505(Class362.class515_0)
			{
				Name = this.string_0,
				DeviceTypeName = this.string_1,
				Icon = this.drawingImage_0,
				Path = this.string_2,
				NewAffinity = this.string_3
			});
		}

		// Token: 0x04000D60 RID: 3424
		public string string_0;

		// Token: 0x04000D61 RID: 3425
		public string string_1;

		// Token: 0x04000D62 RID: 3426
		public DrawingImage drawingImage_0;

		// Token: 0x04000D63 RID: 3427
		public string string_2;

		// Token: 0x04000D64 RID: 3428
		public string string_3;
	}

	// Token: 0x02000303 RID: 771
	[StructLayout(LayoutKind.Auto)]
	private struct Struct167 : IAsyncStateMachine
	{
		// Token: 0x06001407 RID: 5127 RVA: 0x0006298C File Offset: 0x00060B8C
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "B>:j]Za-k4", array);
			}
			finally
			{
				this = (Class362.Struct167)array[0];
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0000E12B File Offset: 0x0000C32B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0000E139 File Offset: 0x0000C339
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class362.Struct167 struct167_0)
		{
			struct167_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class362.Struct167>(ref taskAwaiter_1, ref struct167_0);
		}

		// Token: 0x04000D65 RID: 3429
		public int int_0;

		// Token: 0x04000D66 RID: 3430
		public AsyncTaskMethodBuilder<List<Class265>> asyncTaskMethodBuilder_0;

		// Token: 0x04000D67 RID: 3431
		private List<Class265> list_0;

		// Token: 0x04000D68 RID: 3432
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000304 RID: 772
	[StructLayout(LayoutKind.Auto)]
	private struct Struct168 : IAsyncStateMachine
	{
		// Token: 0x0600140A RID: 5130 RVA: 0x000629F4 File Offset: 0x00060BF4
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "n%Z9;Za-j\"", array);
			}
			finally
			{
				this = (Class362.Struct168)array[0];
			}
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0000E148 File Offset: 0x0000C348
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0000E156 File Offset: 0x0000C356
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class362.Struct168 struct168_0)
		{
			struct168_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class362.Struct168>(ref taskAwaiter_1, ref struct168_0);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0000E156 File Offset: 0x0000C356
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class362.Struct168 struct168_0)
		{
			struct168_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class362.Struct168>(ref taskAwaiter_1, ref struct168_0);
		}

		// Token: 0x04000D69 RID: 3433
		public int int_0;

		// Token: 0x04000D6A RID: 3434
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000D6B RID: 3435
		private Class362.Class368 class368_0;

		// Token: 0x04000D6C RID: 3436
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000305 RID: 773
	private sealed class Class367
	{
		// Token: 0x0600140F RID: 5135 RVA: 0x00062A5C File Offset: 0x00060C5C
		internal void method_0()
		{
			Class362.class515_0.DeviceViewModels.Last<Class505>().Name = this.string_0;
			Class362.class515_0.DeviceViewModels.Last<Class505>().Path = this.string_1;
			Class362.class515_0.DeviceViewModels.Last<Class505>().NewAffinity = this.string_2;
			Class362.bool_2 = false;
			Class362.bool_1 = true;
		}

		// Token: 0x04000D6D RID: 3437
		public string string_0;

		// Token: 0x04000D6E RID: 3438
		public string string_1;

		// Token: 0x04000D6F RID: 3439
		public string string_2;
	}

	// Token: 0x02000306 RID: 774
	private sealed class Class368
	{
		// Token: 0x06001411 RID: 5137 RVA: 0x00062AC4 File Offset: 0x00060CC4
		internal Task method_0()
		{
			Class362.Class368.Struct169 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class368_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class362.Class368.Struct169>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000D70 RID: 3440
		public bool bool_0;

		// Token: 0x02000307 RID: 775
		[StructLayout(LayoutKind.Auto)]
		private struct Struct169 : IAsyncStateMachine
		{
			// Token: 0x06001412 RID: 5138 RVA: 0x00062B08 File Offset: 0x00060D08
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class362.Class368 @class = this.class368_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						this.class364_0 = new Class362.Class364();
						awaiter = Class148.smethod_2(typeof(dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class362.Class368.Struct169>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					ObservableCollection<Class512> result = awaiter.GetResult();
					this.class364_0.observableCollection_0 = result;
					try
					{
						Application.Current.Dispatcher.Invoke(new Action(this.class364_0.method_0));
						ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
						ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								ManagementBaseObject managementBaseObject = enumerator.Current;
								ManagementObject managementObject = (ManagementObject)managementBaseObject;
								Class362.Class366 class2 = new Class362.Class366();
								class2.string_0 = managementObject.GetPropertyValue("Description").ToString();
								if (class2.string_0.ToLower().Contains("intel") || class2.string_0.ToLower().Contains("amd") || class2.string_0.ToLower().Contains("nvidia"))
								{
									class2.string_1 = "GPU";
									class2.drawingImage_0 = Class298.smethod_4("GPUSvg");
									class2.string_2 = managementObject.GetPropertyValue("PNPDeviceID").ToString();
									class2.string_3 = Class440.smethod_0(managementObject.GetPropertyValue("PNPDeviceID").ToString());
									Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						Application.Current.Dispatcher.Invoke(new Action(Class362.Class370.class370_0.method_0));
						int num4 = 0;
						managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_USBController");
						IEnumerator<ManagementObject> enumerator2 = managementObjectSearcher.Get().Cast<ManagementObject>().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								ManagementObject managementObject2 = enumerator2.Current;
								string string_ = managementObject2["Description"].ToString();
								if (string_.smethod_3("host") || string_.smethod_3("хост"))
								{
									num4++;
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
						if (num4 == 1)
						{
							enumerator2 = managementObjectSearcher.Get().Cast<ManagementObject>().GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									ManagementObject managementObject3 = enumerator2.Current;
									string string_2 = managementObject3["Description"].ToString();
									if (string_2.smethod_3("host") || string_2.smethod_3("хост"))
									{
										Class362.Class367 class3 = new Class362.Class367();
										class3.string_0 = Class298.smethod_2("mousehostcontroller");
										class3.string_1 = managementObject3.GetPropertyValue("PNPDeviceID").ToString();
										class3.string_2 = Class440.smethod_0(managementObject3.GetPropertyValue("PNPDeviceID").ToString());
										Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
										@class.bool_0 = true;
										goto IL_544;
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
						}
						managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM win32_pointingdevice");
						enumerator2 = managementObjectSearcher.Get().Cast<ManagementObject>().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								ManagementObject managementObject4 = enumerator2.Current;
								if (@class.bool_0)
								{
									break;
								}
								ManagementObject managementObject5 = managementObject4;
								try
								{
									while (!@class.bool_0)
									{
										managementObject5 = Class440.smethod_3(Class440.smethod_2(managementObject5));
										if (managementObject5.GetPropertyValue("Description").ToString().smethod_3("I2C"))
										{
											break;
										}
										List<string>.Enumerator enumerator3 = Class725.list_8.GetEnumerator();
										try
										{
											while (enumerator3.MoveNext())
											{
												string string_3 = enumerator3.Current;
												if (@class.bool_0)
												{
													break;
												}
												if (managementObject5.GetPropertyValue("Description").ToString().smethod_3(string_3))
												{
													Class362.Class363 class4 = new Class362.Class363();
													class4.string_0 = Class298.smethod_2("mousehostcontroller");
													class4.string_1 = managementObject5.GetPropertyValue("PNPDeviceID").ToString();
													class4.string_2 = Class440.smethod_0(managementObject5.GetPropertyValue("PNPDeviceID").ToString());
													Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
													@class.bool_0 = true;
												}
											}
										}
										finally
										{
											if (num < 0)
											{
												((IDisposable)enumerator3).Dispose();
											}
										}
									}
								}
								catch
								{
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
					}
					catch
					{
					}
					try
					{
						if (!@class.bool_0)
						{
							Application.Current.Dispatcher.Invoke(new Action(Class362.Class370.class370_0.method_1));
						}
						Class362.bool_1 = true;
						Class362.bool_2 = false;
					}
					catch
					{
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class364_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_544:
				this.int_0 = -2;
				this.class364_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001413 RID: 5139 RVA: 0x0000E165 File Offset: 0x0000C365
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000D71 RID: 3441
			public int int_0;

			// Token: 0x04000D72 RID: 3442
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000D73 RID: 3443
			private Class362.Class364 class364_0;

			// Token: 0x04000D74 RID: 3444
			public Class362.Class368 class368_0;

			// Token: 0x04000D75 RID: 3445
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}
	}

	// Token: 0x02000308 RID: 776
	private sealed class Class369
	{
		// Token: 0x06001415 RID: 5141 RVA: 0x0000E173 File Offset: 0x0000C373
		internal bool method_0(Class552 class552_0)
		{
			return class552_0.method_0() == this.int_0;
		}

		// Token: 0x04000D76 RID: 3446
		public int int_0;
	}

	// Token: 0x02000309 RID: 777
	[Serializable]
	private sealed class Class370
	{
		// Token: 0x06001418 RID: 5144 RVA: 0x00063150 File Offset: 0x00061350
		internal void method_0()
		{
			Class505 item = new Class505(Class362.class515_0)
			{
				Name = Class298.smethod_2("Searching"),
				DeviceTypeName = "Mouse",
				Icon = Class298.smethod_4("MouseSvg")
			};
			Class362.class515_0.DeviceViewModels.Add(item);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0000E18F File Offset: 0x0000C38F
		internal void method_1()
		{
			Class362.class515_0.DeviceViewModels.Remove(Class362.class515_0.DeviceViewModels.Last<Class505>());
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
		internal bool method_2(Class512 class512_0)
		{
			return class512_0.method_21() == "LockInterruptRouting";
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0000E1C3 File Offset: 0x0000C3C3
		internal int method_3(Class552 class552_0)
		{
			return class552_0.Core;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0000E1CB File Offset: 0x0000C3CB
		internal Class552 method_4(IGrouping<int, Class552> igrouping_0)
		{
			return igrouping_0.OrderBy(new Func<Class552, int>(Class362.Class370.class370_0.method_5)).First<Class552>();
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0000E1F7 File Offset: 0x0000C3F7
		internal int method_5(Class552 class552_0)
		{
			return class552_0.Thread;
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0000E1C3 File Offset: 0x0000C3C3
		internal int method_6(Class552 class552_0)
		{
			return class552_0.Core;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
		internal bool method_7(Class512 class512_0)
		{
			return class512_0.method_21() == "LockInterruptRouting";
		}

		// Token: 0x04000D77 RID: 3447
		public static readonly Class362.Class370 class370_0 = new Class362.Class370();

		// Token: 0x04000D78 RID: 3448
		public static Action action_0;

		// Token: 0x04000D79 RID: 3449
		public static Action action_1;

		// Token: 0x04000D7A RID: 3450
		public static Func<Class512, bool> func_0;

		// Token: 0x04000D7B RID: 3451
		public static Func<Class552, int> func_1;

		// Token: 0x04000D7C RID: 3452
		public static Func<Class552, int> func_2;

		// Token: 0x04000D7D RID: 3453
		public static Func<IGrouping<int, Class552>, Class552> func_3;

		// Token: 0x04000D7E RID: 3454
		public static Func<Class552, int> func_4;

		// Token: 0x04000D7F RID: 3455
		public static Func<Class512, bool> func_5;
	}
}
