using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Effects;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x02000743 RID: 1859
	public sealed class dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002E49 RID: 11849 RVA: 0x0001DA25 File Offset: 0x0001BC25
		public dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd()
		{
			this.InitializeComponent();
			Class480.smethod_0(new Class480.Delegate30(this.method_2));
			this.method_0();
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x000B14AC File Offset: 0x000AF6AC
		private void method_0()
		{
			try
			{
				Application.Current.MainWindow.StateChanged += this.method_1;
			}
			catch
			{
			}
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000B14EC File Offset: 0x000AF6EC
		private void method_1(object sender, EventArgs e)
		{
			this.method_3(null, default(DependencyPropertyChangedEventArgs));
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x000B150C File Offset: 0x000AF70C
		private void method_2()
		{
			dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd.Struct517 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd.Struct517>(ref @struct);
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x000B1544 File Offset: 0x000AF744
		private void method_3(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (Class551.class753_0.method_56().GetValueOrDefault())
			{
				this.blurEffect_0.Radius = 0.0;
				this.blurEffect_1.Radius = 0.0;
				this.stackPanel_0.Opacity = 1.0;
				this.stackPanel_1.Opacity = 1.0;
				this.textBlock_4.Opacity = 0.0;
				this.textBlock_9.Opacity = 0.0;
				this.textBlock_4.Visibility = Visibility.Collapsed;
				this.textBlock_9.Visibility = Visibility.Collapsed;
			}
			else
			{
				this.blurEffect_0.Radius = 15.0;
				this.blurEffect_1.Radius = 15.0;
				this.stackPanel_0.Opacity = 0.3;
				this.stackPanel_1.Opacity = 0.3;
				this.textBlock_4.Opacity = 1.0;
				this.textBlock_9.Opacity = 1.0;
				this.textBlock_4.Visibility = Visibility.Visible;
				this.textBlock_9.Visibility = Visibility.Visible;
			}
			if (base.IsVisible && Class551.class753_0.method_56().GetValueOrDefault() && Application.Current.MainWindow.WindowState != WindowState.Minimized)
			{
				Class480.smethod_5();
				return;
			}
			Class480.smethod_6();
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x000B16C8 File Offset: 0x000AF8C8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/cpucpuuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_4(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x000B16FC File Offset: 0x000AF8FC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd)target).IsVisibleChanged += this.method_3;
				return;
			case 2:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 3:
				this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0 = (dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd)target;
				return;
			case 4:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_1 = (dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd)target;
				return;
			case 6:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 7:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 8:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 9:
				this.blurEffect_0 = (BlurEffect)target;
				return;
			case 10:
				this.textBlock_4 = (TextBlock)target;
				return;
			case 11:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 12:
				this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_2 = (dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd)target;
				return;
			case 13:
				this.textBlock_5 = (TextBlock)target;
				return;
			case 14:
				this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_3 = (dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd)target;
				return;
			case 15:
				this.textBlock_6 = (TextBlock)target;
				return;
			case 16:
				this.textBlock_7 = (TextBlock)target;
				return;
			case 17:
				this.textBlock_8 = (TextBlock)target;
				return;
			case 18:
				this.blurEffect_1 = (BlurEffect)target;
				return;
			case 19:
				this.textBlock_9 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x000B1868 File Offset: 0x000AFA68
		private void method_5()
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, (double)Class480.float_0 * 3.6);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_33(this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0, Class480.float_0);
			this.textBlock_0.Text = Class480.float_0.ToString();
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_1.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, (double)Class480.float_1 * 3.6);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_33(this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_1, Class480.float_1);
			this.textBlock_1.Text = (Class480.float_1.ToString().Replace(',', '.').Contains(".") ? Class480.float_1.ToString().Substring(0, Class480.float_1.ToString().Replace(',', '.').IndexOf('.')) : Class480.float_1.ToString());
			this.textBlock_3.Text = Class480.float_2.ToString().Replace(',', '.').Split(new char[]
			{
				'.'
			})[0];
			this.textBlock_2.Text = Class480.float_3.ToString().Replace(',', '.').Split(new char[]
			{
				'.'
			})[0];
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_2.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, (double)Class480.float_4 * 3.6);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_33(this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_2, Class480.float_4);
			this.textBlock_5.Text = Class480.float_4.ToString();
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_3.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, (double)Class480.float_5 * 3.6);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_33(this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_3, Class480.float_5);
			this.textBlock_6.Text = (Class480.float_5.ToString().Replace(',', '.').Contains(".") ? Class480.float_5.ToString().Substring(0, Class480.float_5.ToString().Replace(',', '.').IndexOf('.')) : Class480.float_5.ToString());
			this.textBlock_8.Text = Class480.float_7.ToString().Replace(',', '.').Split(new char[]
			{
				'.'
			})[0];
			this.textBlock_7.Text = Class480.float_6.ToString().Replace(',', '.').Split(new char[]
			{
				'.'
			})[0];
		}

		// Token: 0x04001EB0 RID: 7856
		internal StackPanel stackPanel_0;

		// Token: 0x04001EB1 RID: 7857
		internal dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0;

		// Token: 0x04001EB2 RID: 7858
		internal TextBlock textBlock_0;

		// Token: 0x04001EB3 RID: 7859
		internal dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_1;

		// Token: 0x04001EB4 RID: 7860
		internal TextBlock textBlock_1;

		// Token: 0x04001EB5 RID: 7861
		internal TextBlock textBlock_2;

		// Token: 0x04001EB6 RID: 7862
		internal TextBlock textBlock_3;

		// Token: 0x04001EB7 RID: 7863
		internal BlurEffect blurEffect_0;

		// Token: 0x04001EB8 RID: 7864
		internal TextBlock textBlock_4;

		// Token: 0x04001EB9 RID: 7865
		internal StackPanel stackPanel_1;

		// Token: 0x04001EBA RID: 7866
		internal dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_2;

		// Token: 0x04001EBB RID: 7867
		internal TextBlock textBlock_5;

		// Token: 0x04001EBC RID: 7868
		internal dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_3;

		// Token: 0x04001EBD RID: 7869
		internal TextBlock textBlock_6;

		// Token: 0x04001EBE RID: 7870
		internal TextBlock textBlock_7;

		// Token: 0x04001EBF RID: 7871
		internal TextBlock textBlock_8;

		// Token: 0x04001EC0 RID: 7872
		internal BlurEffect blurEffect_1;

		// Token: 0x04001EC1 RID: 7873
		internal TextBlock textBlock_9;

		// Token: 0x04001EC2 RID: 7874
		private bool bool_0;

		// Token: 0x02000744 RID: 1860
		[StructLayout(LayoutKind.Auto)]
		private struct Struct517 : IAsyncStateMachine
		{
			// Token: 0x06002E52 RID: 11858 RVA: 0x000B1B44 File Offset: 0x000AFD44
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd = this.dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!Class551.class753_0.method_56().GetValueOrDefault())
						{
							goto IL_AD;
						}
						awaiter = dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd.Dispatcher.InvokeAsync(new Action(dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd.method_5)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd.Struct517>(ref awaiter, ref this);
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
				IL_AD:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002E53 RID: 11859 RVA: 0x0001DA4A File Offset: 0x0001BC4A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EC3 RID: 7875
			public int int_0;

			// Token: 0x04001EC4 RID: 7876
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001EC5 RID: 7877
			public dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd dje_z55UAJB7UAUNFKTTRW7ZL296DY2WX4T78P3ZJ6LTNTZ4LSACPS4TA9R5ZXSYQ_ejd_0;

			// Token: 0x04001EC6 RID: 7878
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
