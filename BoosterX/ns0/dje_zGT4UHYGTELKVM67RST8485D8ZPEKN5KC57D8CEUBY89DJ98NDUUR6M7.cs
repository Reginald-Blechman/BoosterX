using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x0200081A RID: 2074
	public sealed class dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060031E0 RID: 12768 RVA: 0x0001F5F9 File Offset: 0x0001D7F9
		public dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x000C16C0 File Offset: 0x000BF8C0
		private void method_0(object sender, MouseEventArgs e)
		{
			dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.Struct627 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd_0 = this;
			@struct.mouseEventArgs_0 = e;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.Struct627>(ref @struct);
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x000C1700 File Offset: 0x000BF900
		private void method_1(object sender, DependencyPropertyChangedEventArgs e)
		{
			GClass173 gclass = base.DataContext as GClass173;
			if (base.IsEnabled)
			{
				gclass.method_2();
				return;
			}
			gclass.method_3();
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x000C1730 File Offset: 0x000BF930
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/appspageucs/bignicebutton.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x000C1764 File Offset: 0x000BF964
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd)target).IsEnabledChanged += this.method_1;
				return;
			case 2:
				((Grid)target).MouseMove += this.method_0;
				return;
			case 3:
				this.border_0 = (Border)target;
				return;
			case 4:
				this.radialGradientBrush_0 = (RadialGradientBrush)target;
				return;
			case 5:
				this.button_0 = (Button)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040022E4 RID: 8932
		private readonly object object_0 = new object();

		// Token: 0x040022E5 RID: 8933
		private DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x040022E6 RID: 8934
		internal Border border_0;

		// Token: 0x040022E7 RID: 8935
		internal RadialGradientBrush radialGradientBrush_0;

		// Token: 0x040022E8 RID: 8936
		internal Button button_0;

		// Token: 0x040022E9 RID: 8937
		private bool bool_0;

		// Token: 0x0200081B RID: 2075
		[StructLayout(LayoutKind.Auto)]
		private struct Struct627 : IAsyncStateMachine
		{
			// Token: 0x060031E5 RID: 12773 RVA: 0x000C17EC File Offset: 0x000BF9EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd = this.dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						object object_ = dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.object_0;
						bool flag = false;
						try
						{
							Monitor.Enter(object_, ref flag);
							DateTime now = DateTime.Now;
							if ((now - dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.dateTime_0).TotalMilliseconds < 16.0)
							{
								goto IL_148;
							}
							dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.dateTime_0 = now;
						}
						finally
						{
							if (num < 0 && flag)
							{
								Monitor.Exit(object_);
							}
						}
						Point position = this.mouseEventArgs_0.GetPosition(dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.button_0);
						double x = position.X;
						double y = position.Y;
						double x2 = x / dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.border_0.Width;
						double y2 = y / dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.border_0.Height;
						dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.radialGradientBrush_0.GradientOrigin = new Point(x2, y2);
						dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.radialGradientBrush_0.Center = new Point(x2, y2);
						awaiter = Task.Delay(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd.Struct627>(ref awaiter, ref this);
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
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_148:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060031E6 RID: 12774 RVA: 0x0001F61D File Offset: 0x0001D81D
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022EA RID: 8938
			public int int_0;

			// Token: 0x040022EB RID: 8939
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040022EC RID: 8940
			public dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd_0;

			// Token: 0x040022ED RID: 8941
			public MouseEventArgs mouseEventArgs_0;

			// Token: 0x040022EE RID: 8942
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
