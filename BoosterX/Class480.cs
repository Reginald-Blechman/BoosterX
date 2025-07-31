using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using LibreHardwareMonitor.Hardware;
using LibreHardwareMonitor.Hardware.Cpu;

// Token: 0x02000435 RID: 1077
internal sealed class Class480
{
	// Token: 0x06001BF4 RID: 7156 RVA: 0x000775D0 File Offset: 0x000757D0
	public static void smethod_0(Class480.Delegate30 delegate30_1)
	{
		Class480.Delegate30 @delegate = Class480.delegate30_0;
		Class480.Delegate30 delegate2;
		do
		{
			delegate2 = @delegate;
			Class480.Delegate30 value = (Class480.Delegate30)Delegate.Combine(delegate2, delegate30_1);
			@delegate = Interlocked.CompareExchange<Class480.Delegate30>(ref Class480.delegate30_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x00077604 File Offset: 0x00075804
	public static void smethod_1(Class480.Delegate30 delegate30_1)
	{
		Class480.Delegate30 @delegate = Class480.delegate30_0;
		Class480.Delegate30 delegate2;
		do
		{
			delegate2 = @delegate;
			Class480.Delegate30 value = (Class480.Delegate30)Delegate.Remove(delegate2, delegate30_1);
			@delegate = Interlocked.CompareExchange<Class480.Delegate30>(ref Class480.delegate30_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x00077638 File Offset: 0x00075838
	public static void smethod_2()
	{
		if (Class480.bool_3)
		{
			return;
		}
		Class480.bool_3 = true;
		try
		{
			Class480.computer_0.Open();
			Class480.computer_0.Accept(new Class480.Class481());
		}
		catch
		{
			Class480.bool_2 = true;
		}
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00012B61 File Offset: 0x00010D61
	public static void smethod_3()
	{
		Class480.bool_3 = false;
		Class480.computer_0.Close();
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00077688 File Offset: 0x00075888
	public static void smethod_4()
	{
		Class480.float_0 = 0f;
		Class480.float_1 = 0f;
		Class480.float_2 = 0f;
		Class480.float_3 = 0f;
		Class480.float_4 = 0f;
		Class480.float_5 = 0f;
		Class480.float_6 = 0f;
		Class480.float_7 = 0f;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x000776E8 File Offset: 0x000758E8
	public static void smethod_5()
	{
		Class480.Struct274 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class480.Struct274>(ref @struct);
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x00077718 File Offset: 0x00075918
	public static void smethod_6()
	{
		Class480.Struct272 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class480.Struct272>(ref @struct);
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x00077748 File Offset: 0x00075948
	public static Task<bool> smethod_7()
	{
		Class480.Struct275 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class480.Struct275>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x00077784 File Offset: 0x00075984
	public static void smethod_8()
	{
		Class480.Struct273 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class480.Struct273>(ref @struct);
	}

	// Token: 0x040012A5 RID: 4773
	private static Class480.Delegate30 delegate30_0;

	// Token: 0x040012A6 RID: 4774
	public static bool bool_0 = false;

	// Token: 0x040012A7 RID: 4775
	private static bool bool_1 = false;

	// Token: 0x040012A8 RID: 4776
	public static bool bool_2 = false;

	// Token: 0x040012A9 RID: 4777
	public static float float_0 = 0f;

	// Token: 0x040012AA RID: 4778
	public static float float_1 = 0f;

	// Token: 0x040012AB RID: 4779
	public static float float_2 = 0f;

	// Token: 0x040012AC RID: 4780
	public static float float_3 = 0f;

	// Token: 0x040012AD RID: 4781
	public static float float_4 = 0f;

	// Token: 0x040012AE RID: 4782
	public static float float_5 = 0f;

	// Token: 0x040012AF RID: 4783
	public static float float_6 = 0f;

	// Token: 0x040012B0 RID: 4784
	public static float float_7 = 0f;

	// Token: 0x040012B1 RID: 4785
	private static Computer computer_0 = new Computer
	{
		IsCpuEnabled = true,
		IsGpuEnabled = true,
		IsMemoryEnabled = true,
		IsMotherboardEnabled = true,
		IsPsuEnabled = true
	};

	// Token: 0x040012B2 RID: 4786
	private static bool bool_3 = false;

	// Token: 0x02000436 RID: 1078
	// (Invoke) Token: 0x06001BFE RID: 7166
	public delegate void Delegate30();

	// Token: 0x02000437 RID: 1079
	[StructLayout(LayoutKind.Auto)]
	private struct Struct272 : IAsyncStateMachine
	{
		// Token: 0x06001C01 RID: 7169 RVA: 0x000777B4 File Offset: 0x000759B4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class480.Class482.class482_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class480.Struct272>(ref awaiter, ref this);
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

		// Token: 0x06001C02 RID: 7170 RVA: 0x00012B73 File Offset: 0x00010D73
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012B3 RID: 4787
		public int int_0;

		// Token: 0x040012B4 RID: 4788
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040012B5 RID: 4789
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000438 RID: 1080
	[StructLayout(LayoutKind.Auto)]
	private struct Struct273 : IAsyncStateMachine
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x00077880 File Offset: 0x00075A80
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(Class480.Class482.class482_0.method_5)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class480.Struct273>(ref awaiter, ref this);
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

		// Token: 0x06001C04 RID: 7172 RVA: 0x00012B81 File Offset: 0x00010D81
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012B6 RID: 4790
		public int int_0;

		// Token: 0x040012B7 RID: 4791
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040012B8 RID: 4792
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000439 RID: 1081
	public sealed class Class481 : IVisitor
	{
		// Token: 0x06001C06 RID: 7174 RVA: 0x00012B8F File Offset: 0x00010D8F
		public void VisitComputer(IComputer icomputer_0)
		{
			icomputer_0.Traverse(this);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0007794C File Offset: 0x00075B4C
		public void VisitHardware(IHardware ihardware_0)
		{
			ihardware_0.Update();
			IHardware[] subHardware = ihardware_0.SubHardware;
			for (int i = 0; i < subHardware.Length; i++)
			{
				subHardware[i].Accept(this);
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0000311B File Offset: 0x0000131B
		public void VisitSensor(ISensor isensor_0)
		{
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0000311B File Offset: 0x0000131B
		public void VisitParameter(IParameter iparameter_0)
		{
		}
	}

	// Token: 0x0200043A RID: 1082
	[StructLayout(LayoutKind.Auto)]
	private struct Struct274 : IAsyncStateMachine
	{
		// Token: 0x06001C0A RID: 7178 RVA: 0x00077980 File Offset: 0x00075B80
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class480.Class482.class482_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class480.Struct274>(ref awaiter, ref this);
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

		// Token: 0x06001C0B RID: 7179 RVA: 0x00012B98 File Offset: 0x00010D98
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012B9 RID: 4793
		public int int_0;

		// Token: 0x040012BA RID: 4794
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040012BB RID: 4795
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200043B RID: 1083
	[StructLayout(LayoutKind.Auto)]
	private struct Struct275 : IAsyncStateMachine
	{
		// Token: 0x06001C0C RID: 7180 RVA: 0x00077A4C File Offset: 0x00075C4C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					awaiter = Task.Run<bool>(new Func<bool>(Class480.Class482.class482_0.method_2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class480.Struct275>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<bool>);
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

		// Token: 0x06001C0D RID: 7181 RVA: 0x00012BA6 File Offset: 0x00010DA6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012BC RID: 4796
		public int int_0;

		// Token: 0x040012BD RID: 4797
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x040012BE RID: 4798
		private TaskAwaiter<bool> taskAwaiter_0;
	}

	// Token: 0x0200043C RID: 1084
	[Serializable]
	private sealed class Class482
	{
		// Token: 0x06001C10 RID: 7184 RVA: 0x00012BC0 File Offset: 0x00010DC0
		internal void method_0()
		{
			Class480.bool_1 = true;
			Class480.smethod_8();
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00012BCD File Offset: 0x00010DCD
		internal void method_1()
		{
			Class480.bool_1 = false;
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00077B18 File Offset: 0x00075D18
		internal bool method_2()
		{
			bool result;
			try
			{
				if (!Class480.bool_3)
				{
					Class480.smethod_2();
				}
				bool flag = false;
				foreach (IHardware hardware in Class480.computer_0.Hardware)
				{
					if (hardware.HardwareType == 2)
					{
						flag = (hardware as GenericCpu).CpuId.Any(new Func<CpuId[], bool>(Class480.Class482.class482_0.method_3));
					}
				}
				result = flag;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00012BD5 File Offset: 0x00010DD5
		internal bool method_3(CpuId[] cpuId_0)
		{
			return cpuId_0.Any(new Func<CpuId, bool>(Class480.Class482.class482_0.method_4));
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00012BFC File Offset: 0x00010DFC
		internal bool method_4(CpuId cpuId_0)
		{
			return cpuId_0.ThreadId == 1U;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00077BC0 File Offset: 0x00075DC0
		internal Task method_5()
		{
			Class480.Class482.Struct276 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class480.Class482.Struct276>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040012BF RID: 4799
		public static readonly Class480.Class482 class482_0 = new Class480.Class482();

		// Token: 0x040012C0 RID: 4800
		public static Action action_0;

		// Token: 0x040012C1 RID: 4801
		public static Action action_1;

		// Token: 0x040012C2 RID: 4802
		public static Func<CpuId, bool> func_0;

		// Token: 0x040012C3 RID: 4803
		public static Func<CpuId[], bool> func_1;

		// Token: 0x040012C4 RID: 4804
		public static Func<bool> func_2;

		// Token: 0x040012C5 RID: 4805
		public static Func<Task> func_3;

		// Token: 0x0200043D RID: 1085
		[StructLayout(LayoutKind.Auto)]
		private struct Struct276 : IAsyncStateMachine
		{
			// Token: 0x06001C16 RID: 7190 RVA: 0x00077BFC File Offset: 0x00075DFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (Class480.bool_2)
						{
							goto IL_312;
						}
						if (!Class480.bool_3)
						{
							Class480.smethod_2();
							goto IL_2CB;
						}
						goto IL_2CB;
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
					}
					IL_4A:
					awaiter.GetResult();
					IL_2CB:
					if (Class480.bool_1)
					{
						Class480.smethod_4();
						IEnumerator<IHardware> enumerator = Class480.computer_0.Hardware.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								IHardware hardware = enumerator.Current;
								if (hardware.HardwareType == 2)
								{
									hardware.Update();
									foreach (ISensor sensor in hardware.Sensors)
									{
										if (sensor.SensorType == 4 && sensor.Name.Contains("CPU Package"))
										{
											Class480.float_0 = sensor.Value.GetValueOrDefault();
										}
										else if (sensor.SensorType == 5 && sensor.Name.Contains("CPU Total"))
										{
											Class480.float_1 = sensor.Value.GetValueOrDefault();
										}
										else if (sensor.SensorType == 2 && sensor.Name.Contains("CPU Package"))
										{
											Class480.float_2 = sensor.Value.GetValueOrDefault();
										}
										else if (sensor.SensorType == 3 && sensor.Name.Contains("CPU Core #1"))
										{
											Class480.float_3 = sensor.Value.GetValueOrDefault();
										}
									}
								}
								if (hardware.HardwareType == 5 || hardware.HardwareType == 4)
								{
									hardware.Update();
									foreach (ISensor sensor2 in hardware.Sensors)
									{
										if (sensor2.SensorType == 4 && sensor2.Name.Contains("GPU Core"))
										{
											Class480.float_4 = sensor2.Value.GetValueOrDefault();
										}
										else if (sensor2.SensorType == 5 && sensor2.Name.Contains("GPU Core"))
										{
											Class480.float_5 = sensor2.Value.GetValueOrDefault();
										}
										else if (sensor2.SensorType == 3 && sensor2.Name.Contains("GPU Core"))
										{
											Class480.float_6 = sensor2.Value.GetValueOrDefault();
										}
										else if (sensor2.SensorType == 3 && sensor2.Name.Contains("GPU Memory"))
										{
											Class480.float_7 = sensor2.Value.GetValueOrDefault();
										}
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
						Class480.Delegate30 delegate30_ = Class480.delegate30_0;
						if (delegate30_ != null)
						{
							delegate30_();
						}
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.int_0 = num3;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class480.Class482.Struct276>(ref awaiter, ref this);
							return;
						}
						goto IL_4A;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_312:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001C17 RID: 7191 RVA: 0x00012C07 File Offset: 0x00010E07
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040012C6 RID: 4806
			public int int_0;

			// Token: 0x040012C7 RID: 4807
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040012C8 RID: 4808
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
