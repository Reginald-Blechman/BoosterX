using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media;
using ns0;

// Token: 0x02000631 RID: 1585
internal sealed class Class761
{
	// Token: 0x06002849 RID: 10313 RVA: 0x0001AA0E File Offset: 0x00018C0E
	public static List<Class761.Class762> smethod_0()
	{
		return Class761.list_0;
	}

	// Token: 0x0600284A RID: 10314 RVA: 0x0001AA15 File Offset: 0x00018C15
	public static void smethod_1(List<Class761.Class762> list_1)
	{
		Class761.list_0 = list_1;
	}

	// Token: 0x04001A7E RID: 6782
	private static List<Class761.Class762> list_0 = new List<Class761.Class762>
	{
		new Class761.Class762(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd), Class298.smethod_4("BasicSettingsSvg"), Class298.smethod_2("settingsexp"), new Action(Class761.Class763.class763_0.method_0)),
		new Class761.Class762(typeof(dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd), Class298.smethod_4("NvidiaSvg"), Class298.smethod_2("NvidiaPage"), new Action(Class761.Class763.class763_0.method_1)),
		new Class761.Class762(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd), Class298.smethod_4("PowerSvg"), Class298.smethod_2("powermgmtexp"), new Action(Class761.Class763.class763_0.method_2)),
		new Class761.Class762(typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P8GKSQ477YXNFFJYAV9GYM8S278FJ3VXSLSUGWV2W_ejd), Class298.smethod_4("WindowsSvg"), Class298.smethod_2("uwpappsexp"), new Action(Class761.Class763.class763_0.method_3)),
		new Class761.Class762(typeof(dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd), Class298.smethod_4("CogsSvg"), Class298.smethod_2("servicesexp"), new Action(Class761.Class763.class763_0.method_4)),
		new Class761.Class762(typeof(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd), Class298.smethod_4("ServicesSvg"), Class298.smethod_2("servicesexp"), new Action(Class761.Class763.class763_0.method_5)),
		new Class761.Class762(typeof(dje_zY8TJ7HVSSL9J9VQH6V7EV8TJKMJV32VYYNUD95ZXTD6G6DK4JKGTBNA9KKRA_ejd), Class298.smethod_4("CleanUpSvg"), Class298.smethod_2("cleanupexp"), new Action(Class761.Class763.class763_0.method_6)),
		new Class761.Class762(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd), Class298.smethod_4("PrivacySvg"), Class298.smethod_2("Privacy"), new Action(Class761.Class763.class763_0.method_7)),
		new Class761.Class762(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd), Class298.smethod_4("RegistrySvg"), Class298.smethod_2("registrytweaksexp"), new Action(Class761.Class763.class763_0.method_8)),
		new Class761.Class762(typeof(dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd), Class298.smethod_4("InterruptsSvg"), Class298.smethod_2("affinityexp"), new Action(Class761.Class763.class763_0.method_9)),
		new Class761.Class762(typeof(dje_zRLTJAE4HM9QEZA4XCZRB8CQJP23F3H6N7P96KCK67U3FNVEKLZBJJQB3ZPVQ_ejd), Class298.smethod_4("AutorunsSvg"), Class298.smethod_2("autorunsexp"), new Action(Class761.Class763.class763_0.method_10)),
		new Class761.Class762(typeof(dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd), Class330.smethod_6("Chip"), Class298.smethod_2("Devices"), new Action(Class761.Class763.class763_0.method_11)),
		new Class761.Class762(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd), Class330.smethod_6("TaskAdd"), Class298.smethod_2("Tasks"), new Action(Class761.Class763.class763_0.method_12)),
		new Class761.Class762(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TW4LTJ4MDTW787U8ZU6EPEUUSCU2XC89GWA_ejd), Class330.smethod_6("CogSync"), Class298.smethod_2("Features"), new Action(Class761.Class763.class763_0.method_13)),
		new Class761.Class762(typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd), Class330.smethod_6("Brush"), Class298.smethod_2("Customization"), new Action(Class761.Class763.class763_0.method_14)),
		new Class761.Class762(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd), Class330.smethod_6("Secure"), Class298.smethod_2("Security"), new Action(Class761.Class763.class763_0.method_15)),
		new Class761.Class762(typeof(dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd), Class330.smethod_6("Cancel"), Class298.smethod_2("Depreciated"), new Action(Class761.Class763.class763_0.method_16)),
		new Class761.Class762(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TJT6P4HVXCZBEX5BLD2JKUFM4PCTXZ75CCLQQGATQ_ejd), Class330.smethod_6("Ethernet"), Class298.smethod_2("NetworkAdapters"), new Action(Class761.Class763.class763_0.method_17))
	};

	// Token: 0x02000632 RID: 1586
	public sealed class Class762
	{
		// Token: 0x0600284B RID: 10315 RVA: 0x0001AA1D File Offset: 0x00018C1D
		public Class762(Type type_1, DrawingImage drawingImage_1, string string_1, Action action_1)
		{
			this.method_1(type_1);
			this.Name = string_1;
			this.Icon = drawingImage_1;
			this.method_3(action_1);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0001AA42 File Offset: 0x00018C42
		public Type method_0()
		{
			return this.type_0;
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x0001AA4A File Offset: 0x00018C4A
		public void method_1(Type type_1)
		{
			this.type_0 = type_1;
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x0001AA53 File Offset: 0x00018C53
		// (set) Token: 0x0600284F RID: 10319 RVA: 0x0001AA5B File Offset: 0x00018C5B
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x0001AA64 File Offset: 0x00018C64
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x0001AA6C File Offset: 0x00018C6C
		public DrawingImage Icon
		{
			[CompilerGenerated]
			get
			{
				return this.drawingImage_0;
			}
			[CompilerGenerated]
			set
			{
				this.drawingImage_0 = value;
			}
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x0001AA75 File Offset: 0x00018C75
		public Action method_2()
		{
			return this.action_0;
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x0001AA7D File Offset: 0x00018C7D
		public void method_3(Action action_1)
		{
			this.action_0 = action_1;
		}

		// Token: 0x04001A7F RID: 6783
		private Type type_0;

		// Token: 0x04001A80 RID: 6784
		private string string_0;

		// Token: 0x04001A81 RID: 6785
		private DrawingImage drawingImage_0;

		// Token: 0x04001A82 RID: 6786
		private Action action_0;
	}

	// Token: 0x02000633 RID: 1587
	[Serializable]
	private sealed class Class763
	{
		// Token: 0x06002856 RID: 10326 RVA: 0x0009DBF4 File Offset: 0x0009BDF4
		internal void method_0()
		{
			Class761.Class763.Struct429 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class761.Class763.Struct429>(ref @struct);
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x0001AA92 File Offset: 0x00018C92
		internal void method_1()
		{
			Class221.smethod_0(false).RefreshCommand.Execute(null);
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x0009DC24 File Offset: 0x0009BE24
		internal void method_2()
		{
			Class761.Class763.Struct423 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class761.Class763.Struct423>(ref @struct);
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x0001AAA5 File Offset: 0x00018CA5
		internal void method_3()
		{
			Class313.smethod_0(true);
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x0001AAAE File Offset: 0x00018CAE
		internal void method_4()
		{
			Class589.smethod_1(true);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0001AAAE File Offset: 0x00018CAE
		internal void method_5()
		{
			Class589.smethod_1(true);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x0001AAB7 File Offset: 0x00018CB7
		internal void method_6()
		{
			Class335.smethod_2(true);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x0009DC54 File Offset: 0x0009BE54
		internal void method_7()
		{
			Class761.Class763.Struct424 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class761.Class763.Struct424>(ref @struct);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0009DC84 File Offset: 0x0009BE84
		internal void method_8()
		{
			Class761.Class763.Struct428 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class761.Class763.Struct428>(ref @struct);
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		internal void method_9()
		{
			Class362.smethod_0(true);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0001AAC9 File Offset: 0x00018CC9
		internal void method_10()
		{
			Class646.smethod_1(true);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0001AAD2 File Offset: 0x00018CD2
		internal void method_11()
		{
			GClass134.smethod_0(true);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x0009DCB4 File Offset: 0x0009BEB4
		internal void method_12()
		{
			Class761.Class763.Struct425 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class761.Class763.Struct425>(ref @struct);
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0009DCE4 File Offset: 0x0009BEE4
		internal void method_13()
		{
			Class761.Class763.Struct421 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class761.Class763.Struct421>(ref @struct);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0009DD14 File Offset: 0x0009BF14
		internal void method_14()
		{
			Class761.Class763.Struct422 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class761.Class763.Struct422>(ref @struct);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x0009DD44 File Offset: 0x0009BF44
		internal void method_15()
		{
			Class761.Class763.Struct427 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class761.Class763.Struct427>(ref @struct);
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0009DD74 File Offset: 0x0009BF74
		internal void method_16()
		{
			Class761.Class763.Struct426 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class761.Class763.Struct426>(ref @struct);
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0001AADB File Offset: 0x00018CDB
		internal void method_17()
		{
			GClass28.smethod_0(true);
		}

		// Token: 0x04001A83 RID: 6787
		public static readonly Class761.Class763 class763_0 = new Class761.Class763();

		// Token: 0x02000634 RID: 1588
		[StructLayout(LayoutKind.Auto)]
		private struct Struct421 : IAsyncStateMachine
		{
			// Token: 0x06002868 RID: 10344 RVA: 0x0009DDA4 File Offset: 0x0009BFA4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<Class534> awaiter;
					if (num != 0)
					{
						awaiter = Class242.smethod_0(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class534>, Class761.Class763.Struct421>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Class534>);
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

			// Token: 0x06002869 RID: 10345 RVA: 0x0001AAE4 File Offset: 0x00018CE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A84 RID: 6788
			public int int_0;

			// Token: 0x04001A85 RID: 6789
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A86 RID: 6790
			private TaskAwaiter<Class534> taskAwaiter_0;
		}

		// Token: 0x02000635 RID: 1589
		[StructLayout(LayoutKind.Auto)]
		private struct Struct422 : IAsyncStateMachine
		{
			// Token: 0x0600286A RID: 10346 RVA: 0x0009DE50 File Offset: 0x0009C050
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_2(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class761.Class763.Struct422>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
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

			// Token: 0x0600286B RID: 10347 RVA: 0x0001AAF2 File Offset: 0x00018CF2
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A87 RID: 6791
			public int int_0;

			// Token: 0x04001A88 RID: 6792
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A89 RID: 6793
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}

		// Token: 0x02000636 RID: 1590
		[StructLayout(LayoutKind.Auto)]
		private struct Struct423 : IAsyncStateMachine
		{
			// Token: 0x0600286C RID: 10348 RVA: 0x0009DF08 File Offset: 0x0009C108
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_2(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class761.Class763.Struct423>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
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

			// Token: 0x0600286D RID: 10349 RVA: 0x0001AB00 File Offset: 0x00018D00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A8A RID: 6794
			public int int_0;

			// Token: 0x04001A8B RID: 6795
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A8C RID: 6796
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}

		// Token: 0x02000637 RID: 1591
		[StructLayout(LayoutKind.Auto)]
		private struct Struct424 : IAsyncStateMachine
		{
			// Token: 0x0600286E RID: 10350 RVA: 0x0009DFC0 File Offset: 0x0009C1C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_2(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class761.Class763.Struct424>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
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

			// Token: 0x0600286F RID: 10351 RVA: 0x0001AB0E File Offset: 0x00018D0E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A8D RID: 6797
			public int int_0;

			// Token: 0x04001A8E RID: 6798
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A8F RID: 6799
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}

		// Token: 0x02000638 RID: 1592
		[StructLayout(LayoutKind.Auto)]
		private struct Struct425 : IAsyncStateMachine
		{
			// Token: 0x06002870 RID: 10352 RVA: 0x0009E078 File Offset: 0x0009C278
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_2(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class761.Class763.Struct425>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
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

			// Token: 0x06002871 RID: 10353 RVA: 0x0001AB1C File Offset: 0x00018D1C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A90 RID: 6800
			public int int_0;

			// Token: 0x04001A91 RID: 6801
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A92 RID: 6802
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}

		// Token: 0x02000639 RID: 1593
		[StructLayout(LayoutKind.Auto)]
		private struct Struct426 : IAsyncStateMachine
		{
			// Token: 0x06002872 RID: 10354 RVA: 0x0009E130 File Offset: 0x0009C330
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_2(typeof(dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class761.Class763.Struct426>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
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

			// Token: 0x06002873 RID: 10355 RVA: 0x0001AB2A File Offset: 0x00018D2A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A93 RID: 6803
			public int int_0;

			// Token: 0x04001A94 RID: 6804
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A95 RID: 6805
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}

		// Token: 0x0200063A RID: 1594
		[StructLayout(LayoutKind.Auto)]
		private struct Struct427 : IAsyncStateMachine
		{
			// Token: 0x06002874 RID: 10356 RVA: 0x0009E1E8 File Offset: 0x0009C3E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_2(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class761.Class763.Struct427>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
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

			// Token: 0x06002875 RID: 10357 RVA: 0x0001AB38 File Offset: 0x00018D38
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A96 RID: 6806
			public int int_0;

			// Token: 0x04001A97 RID: 6807
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A98 RID: 6808
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}

		// Token: 0x0200063B RID: 1595
		[StructLayout(LayoutKind.Auto)]
		private struct Struct428 : IAsyncStateMachine
		{
			// Token: 0x06002876 RID: 10358 RVA: 0x0009E2A0 File Offset: 0x0009C4A0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_2(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class761.Class763.Struct428>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
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

			// Token: 0x06002877 RID: 10359 RVA: 0x0001AB46 File Offset: 0x00018D46
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A99 RID: 6809
			public int int_0;

			// Token: 0x04001A9A RID: 6810
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A9B RID: 6811
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}

		// Token: 0x0200063C RID: 1596
		[StructLayout(LayoutKind.Auto)]
		private struct Struct429 : IAsyncStateMachine
		{
			// Token: 0x06002878 RID: 10360 RVA: 0x0009E358 File Offset: 0x0009C558
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_2(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class761.Class763.Struct429>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
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

			// Token: 0x06002879 RID: 10361 RVA: 0x0001AB54 File Offset: 0x00018D54
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A9C RID: 6812
			public int int_0;

			// Token: 0x04001A9D RID: 6813
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001A9E RID: 6814
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}
	}
}
