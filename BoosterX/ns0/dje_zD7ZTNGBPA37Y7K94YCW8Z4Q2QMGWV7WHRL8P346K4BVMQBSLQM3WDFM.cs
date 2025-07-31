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

namespace ns0
{
	// Token: 0x020007BE RID: 1982
	public sealed class dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd : Page, IComponentConnector, IStyleConnector
	{
		// Token: 0x06003044 RID: 12356 RVA: 0x000B9464 File Offset: 0x000B7664
		public dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd()
		{
			this.InitializeComponent();
			base.DataContext = (this.class536_0 = new Class536(this));
			this.radioButton_0.IsChecked = new bool?(true);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x000B94A4 File Offset: 0x000B76A4
		private void method_0()
		{
			this.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.Opacity = 0.0;
			this.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.Visibility = Visibility.Collapsed;
			this.dje_z4K7AHT6VERGA53N84GEQX3JDJZ2MZ765SJLG83XJQTGC55UULAGYAE5Y8R5Q_ejd_0.Opacity = 0.0;
			this.dje_z4K7AHT6VERGA53N84GEQX3JDJZ2MZ765SJLG83XJQTGC55UULAGYAE5Y8R5Q_ejd_0.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0000311B File Offset: 0x0000131B
		private void radioButton_0_Checked(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x0000311B File Offset: 0x0000131B
		private void radioButton_1_Checked(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x000B94F4 File Offset: 0x000B76F4
		private void method_1(object sender, RoutedEventArgs e)
		{
			dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd.Struct573 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd.Struct573>(ref @struct);
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0000311B File Offset: 0x0000131B
		private void method_2(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x000B952C File Offset: 0x000B772C
		private void method_3(object sender, SizeChangedEventArgs e)
		{
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Visible)
			{
				this.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 0.0, 10.0);
			}
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Collapsed)
			{
				this.stackPanel_0.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
				this.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 10.0, 10.0);
			}
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x000B95F0 File Offset: 0x000B77F0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/internettest/pages/internettestoriginal.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_4(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x000B9624 File Offset: 0x000B7824
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd)target).SizeChanged += this.method_3;
				return;
			case 2:
				this.radioButton_0 = (RadioButton)target;
				this.radioButton_0.Checked += this.radioButton_0_Checked;
				return;
			case 3:
				this.radioButton_1 = (RadioButton)target;
				this.radioButton_1.Checked += this.radioButton_1_Checked;
				return;
			case 4:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 5:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 6:
				((Button)target).Click += this.method_1;
				return;
			case 8:
				this.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0 = (dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd)target;
				return;
			case 9:
				this.dje_z4K7AHT6VERGA53N84GEQX3JDJZ2MZ765SJLG83XJQTGC55UULAGYAE5Y8R5Q_ejd_0 = (dje_z4K7AHT6VERGA53N84GEQX3JDJZ2MZ765SJLG83XJQTGC55UULAGYAE5Y8R5Q_ejd)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x0001EBD2 File Offset: 0x0001CDD2
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 7)
			{
				((Button)target).Click += this.method_1;
			}
		}

		// Token: 0x040020D8 RID: 8408
		private Class536 class536_0;

		// Token: 0x040020D9 RID: 8409
		internal RadioButton radioButton_0;

		// Token: 0x040020DA RID: 8410
		internal RadioButton radioButton_1;

		// Token: 0x040020DB RID: 8411
		internal ScrollViewer scrollViewer_0;

		// Token: 0x040020DC RID: 8412
		internal StackPanel stackPanel_0;

		// Token: 0x040020DD RID: 8413
		internal dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0;

		// Token: 0x040020DE RID: 8414
		internal dje_z4K7AHT6VERGA53N84GEQX3JDJZ2MZ765SJLG83XJQTGC55UULAGYAE5Y8R5Q_ejd dje_z4K7AHT6VERGA53N84GEQX3JDJZ2MZ765SJLG83XJQTGC55UULAGYAE5Y8R5Q_ejd_0;

		// Token: 0x040020DF RID: 8415
		private bool bool_0;

		// Token: 0x020007BF RID: 1983
		[StructLayout(LayoutKind.Auto)]
		private struct Struct573 : IAsyncStateMachine
		{
			// Token: 0x0600304F RID: 12367 RVA: 0x000B9718 File Offset: 0x000B7918
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd = this.dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd.Struct573>(ref awaiter, ref this);
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
					if (dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Visible)
					{
						dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 0.0, 10.0);
					}
					if (dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Collapsed)
					{
						dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd.stackPanel_0.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
						dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 10.0, 10.0);
					}
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

			// Token: 0x06003050 RID: 12368 RVA: 0x0001EBEF File Offset: 0x0001CDEF
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020E0 RID: 8416
			public int int_0;

			// Token: 0x040020E1 RID: 8417
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020E2 RID: 8418
			public dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd_0;

			// Token: 0x040020E3 RID: 8419
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
