using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ns0
{
	// Token: 0x0200076A RID: 1898
	public sealed class dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002EE1 RID: 12001 RVA: 0x0001DE99 File Offset: 0x0001C099
		public dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000B4038 File Offset: 0x000B2238
		private void method_0()
		{
			dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct540 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct540>(ref @struct);
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x000B4070 File Offset: 0x000B2270
		private void method_1(object sender, DependencyPropertyChangedEventArgs e)
		{
			dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct537 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct537>(ref @struct);
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x000B40A8 File Offset: 0x000B22A8
		private void method_2()
		{
			dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct539 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct539>(ref @struct);
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x000B40E0 File Offset: 0x000B22E0
		private void method_3(GradientStop gradientStop_3)
		{
			dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct538 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0 = this;
			@struct.gradientStop_0 = gradientStop_3;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct538>(ref @struct);
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x000B4120 File Offset: 0x000B2320
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/loading/loadinguc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x000B4154 File Offset: 0x000B2354
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd)target).IsVisibleChanged += this.method_1;
				return;
			case 2:
				this.gradientStop_0 = (GradientStop)target;
				return;
			case 3:
				this.border_0 = (Border)target;
				return;
			case 4:
				this.gradientStop_1 = (GradientStop)target;
				return;
			case 5:
				this.gradientStop_2 = (GradientStop)target;
				return;
			default:
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x000B41D0 File Offset: 0x000B23D0
		private void method_4()
		{
			dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Class887 @class = new dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Class887();
			@class.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0 = this;
			@class.double_0 = (double)Class379.smethod_3(150, 350);
			base.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x0001DEAD File Offset: 0x0001C0AD
		private void method_5()
		{
			if (base.IsVisible && !this.bool_0)
			{
				this.bool_0 = true;
				this.method_2();
			}
			if (!base.IsVisible)
			{
				this.bool_0 = false;
			}
		}

		// Token: 0x04001F6E RID: 8046
		private bool bool_0;

		// Token: 0x04001F6F RID: 8047
		internal GradientStop gradientStop_0;

		// Token: 0x04001F70 RID: 8048
		internal Border border_0;

		// Token: 0x04001F71 RID: 8049
		internal GradientStop gradientStop_1;

		// Token: 0x04001F72 RID: 8050
		internal GradientStop gradientStop_2;

		// Token: 0x04001F73 RID: 8051
		private bool bool_1;

		// Token: 0x0200076B RID: 1899
		[StructLayout(LayoutKind.Auto)]
		private struct Struct537 : IAsyncStateMachine
		{
			// Token: 0x06002EEA RID: 12010 RVA: 0x000B4218 File Offset: 0x000B2418
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd @object = this.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_5)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct537>(ref awaiter, ref this);
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

			// Token: 0x06002EEB RID: 12011 RVA: 0x0001DEDB File Offset: 0x0001C0DB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F74 RID: 8052
			public int int_0;

			// Token: 0x04001F75 RID: 8053
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F76 RID: 8054
			public dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0;

			// Token: 0x04001F77 RID: 8055
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200076C RID: 1900
		[StructLayout(LayoutKind.Auto)]
		private struct Struct538 : IAsyncStateMachine
		{
			// Token: 0x06002EEC RID: 12012 RVA: 0x000B42D8 File Offset: 0x000B24D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd = this.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Class888 @class = new dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Class888();
						@class.gradientStop_0 = this.gradientStop_0;
						awaiter = dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Dispatcher.InvokeAsync(new Action(@class.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct538>(ref awaiter, ref this);
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

			// Token: 0x06002EED RID: 12013 RVA: 0x0001DEE9 File Offset: 0x0001C0E9
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F78 RID: 8056
			public int int_0;

			// Token: 0x04001F79 RID: 8057
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F7A RID: 8058
			public GradientStop gradientStop_0;

			// Token: 0x04001F7B RID: 8059
			public dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0;

			// Token: 0x04001F7C RID: 8060
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200076D RID: 1901
		private sealed class Class887
		{
			// Token: 0x06002EEF RID: 12015 RVA: 0x0001DEF7 File Offset: 0x0001C0F7
			internal void method_0()
			{
				this.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0.border_0.Width = this.double_0;
			}

			// Token: 0x04001F7D RID: 8061
			public double double_0;

			// Token: 0x04001F7E RID: 8062
			public dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0;
		}

		// Token: 0x0200076E RID: 1902
		[StructLayout(LayoutKind.Auto)]
		private struct Struct539 : IAsyncStateMachine
		{
			// Token: 0x06002EF0 RID: 12016 RVA: 0x000B43B0 File Offset: 0x000B25B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd = this.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_74;
					}
					IL_2F:
					if (!dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.bool_0)
					{
						goto IL_B6;
					}
					dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.method_3(dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.gradientStop_0);
					dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.method_3(dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.gradientStop_1);
					dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.method_3(dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.gradientStop_2);
					awaiter = Task.Delay(1500).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct539>(ref awaiter, ref this);
						return;
					}
					IL_74:
					awaiter.GetResult();
					goto IL_2F;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_B6:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002EF1 RID: 12017 RVA: 0x0001DF0F File Offset: 0x0001C10F
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F7F RID: 8063
			public int int_0;

			// Token: 0x04001F80 RID: 8064
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F81 RID: 8065
			public dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0;

			// Token: 0x04001F82 RID: 8066
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200076F RID: 1903
		[StructLayout(LayoutKind.Auto)]
		private struct Struct540 : IAsyncStateMachine
		{
			// Token: 0x06002EF2 RID: 12018 RVA: 0x000B4498 File Offset: 0x000B2698
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd @object = this.dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_4)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd.Struct540>(ref awaiter, ref this);
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

			// Token: 0x06002EF3 RID: 12019 RVA: 0x0001DF1D File Offset: 0x0001C11D
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F83 RID: 8067
			public int int_0;

			// Token: 0x04001F84 RID: 8068
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F85 RID: 8069
			public dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd dje_z8KE4Q3J29T2VV4CKAXXUTUV9Z5P2A6TCX9PKSCGFF3HW2RZ_ejd_0;

			// Token: 0x04001F86 RID: 8070
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000770 RID: 1904
		private sealed class Class888
		{
			// Token: 0x06002EF5 RID: 12021 RVA: 0x000B4558 File Offset: 0x000B2758
			internal void method_0()
			{
				ColorAnimationUsingKeyFrames colorAnimationUsingKeyFrames = new ColorAnimationUsingKeyFrames();
				colorAnimationUsingKeyFrames.KeyFrames.Add(new LinearColorKeyFrame((Color)ColorConverter.ConvertFromString("#BF20263B"), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));
				colorAnimationUsingKeyFrames.KeyFrames.Add(new LinearColorKeyFrame((Color)ColorConverter.ConvertFromString("#BF20263B"), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.2))));
				colorAnimationUsingKeyFrames.KeyFrames.Add(new LinearColorKeyFrame((Color)ColorConverter.ConvertFromString("#BF5766A1"), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.8))));
				colorAnimationUsingKeyFrames.KeyFrames.Add(new LinearColorKeyFrame((Color)ColorConverter.ConvertFromString("#BF20263B"), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.2))));
				DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames();
				doubleAnimationUsingKeyFrames.KeyFrames.Add(new LinearDoubleKeyFrame(0.999, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));
				doubleAnimationUsingKeyFrames.KeyFrames.Add(new LinearDoubleKeyFrame(0.999, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.4))));
				doubleAnimationUsingKeyFrames.KeyFrames.Add(new LinearDoubleKeyFrame(0.001, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.0))));
				this.gradientStop_0.BeginAnimation(GradientStop.ColorProperty, colorAnimationUsingKeyFrames);
				this.gradientStop_0.BeginAnimation(GradientStop.OffsetProperty, doubleAnimationUsingKeyFrames);
			}

			// Token: 0x04001F87 RID: 8071
			public GradientStop gradientStop_0;
		}
	}
}
