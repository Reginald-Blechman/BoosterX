using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007D6 RID: 2006
	public sealed class dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd : Page, IComponentConnector, IStyleConnector
	{
		// Token: 0x060030C8 RID: 12488 RVA: 0x000BB48C File Offset: 0x000B968C
		public dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd()
		{
			this.InitializeComponent();
			base.DataContext = (this.class522_0 = new Class522(this));
			this.radioButton_0.IsChecked = new bool?(true);
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x000BB4CC File Offset: 0x000B96CC
		private void method_0()
		{
			this.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.Opacity = 0.0;
			this.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.Visibility = Visibility.Collapsed;
			this.dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd_0.Opacity = 0.0;
			this.dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd_0.Visibility = Visibility.Collapsed;
			this.dje_zASTEA68QV9JLMYGZ2N6CNG8R7CWBMT8QWNJYKUX8PA47XJSL3WE5TMPA7MQEHCC3FW_ejd_0.Opacity = 0.0;
			this.dje_zASTEA68QV9JLMYGZ2N6CNG8R7CWBMT8QWNJYKUX8PA47XJSL3WE5TMPA7MQEHCC3FW_ejd_0.Visibility = Visibility.Collapsed;
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000BB53C File Offset: 0x000B973C
		private void radioButton_0_Checked(object sender, RoutedEventArgs e)
		{
			this.class522_0.byte_0 = 0;
			this.method_0();
			this.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.Visibility = Visibility.Visible;
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(this.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0, 100);
			if (this.class522_0.Models.Count == 0)
			{
				return;
			}
			if (this.class522_0.Models.All(new Func<Class529, bool>(dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.Class911.class911_0.method_0)))
			{
				this.class522_0.Models.First<Class529>().IsChoosen = true;
				return;
			}
			if (this.class522_0.Models.Where(new Func<Class529, bool>(dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.Class911.class911_0.method_1)).Count<Class529>() >= 2)
			{
				this.class522_0.Models.First<Class529>().IsChoosen = true;
				return;
			}
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000BB620 File Offset: 0x000B9820
		private void radioButton_1_Checked(object sender, RoutedEventArgs e)
		{
			this.class522_0.byte_0 = 1;
			this.class522_0.method_6();
			this.class522_0.Models.smethod_0(new Action<Class529>(this.method_4));
			this.method_0();
			this.dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd_0.Visibility = Visibility.Visible;
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(this.dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd_0, 100);
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x0001EEED File Offset: 0x0001D0ED
		private void radioButton_2_Checked(object sender, RoutedEventArgs e)
		{
			this.class522_0.byte_0 = 2;
			this.method_0();
			this.dje_zASTEA68QV9JLMYGZ2N6CNG8R7CWBMT8QWNJYKUX8PA47XJSL3WE5TMPA7MQEHCC3FW_ejd_0.Visibility = Visibility.Visible;
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(this.dje_zASTEA68QV9JLMYGZ2N6CNG8R7CWBMT8QWNJYKUX8PA47XJSL3WE5TMPA7MQEHCC3FW_ejd_0, 100);
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x000BB680 File Offset: 0x000B9880
		private void method_1(object sender, RoutedEventArgs e)
		{
			dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.Struct585 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.Struct585>(ref @struct);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000BB6B8 File Offset: 0x000B98B8
		private void method_2(object sender, SizeChangedEventArgs e)
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

		// Token: 0x060030CF RID: 12495 RVA: 0x000BB77C File Offset: 0x000B997C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/pages/originaltest.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_3(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000BB7B0 File Offset: 0x000B99B0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd)target).SizeChanged += this.method_2;
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
				this.radioButton_2 = (RadioButton)target;
				this.radioButton_2.Checked += this.radioButton_2_Checked;
				return;
			case 5:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 6:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 7:
				((Button)target).Click += this.method_1;
				return;
			case 9:
				this.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0 = (dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd)target;
				return;
			case 10:
				this.dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd_0 = (dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd)target;
				return;
			case 11:
				this.dje_zASTEA68QV9JLMYGZ2N6CNG8R7CWBMT8QWNJYKUX8PA47XJSL3WE5TMPA7MQEHCC3FW_ejd_0 = (dje_zASTEA68QV9JLMYGZ2N6CNG8R7CWBMT8QWNJYKUX8PA47XJSL3WE5TMPA7MQEHCC3FW_ejd)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x0001EF1A File Offset: 0x0001D11A
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 8)
			{
				((Button)target).Click += this.method_1;
			}
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0001EF37 File Offset: 0x0001D137
		private void method_4(Class529 class529_0)
		{
			if (class529_0.IsChoosen)
			{
				this.class522_0.method_4(class529_0);
			}
		}

		// Token: 0x04002168 RID: 8552
		private Class522 class522_0;

		// Token: 0x04002169 RID: 8553
		internal RadioButton radioButton_0;

		// Token: 0x0400216A RID: 8554
		internal RadioButton radioButton_1;

		// Token: 0x0400216B RID: 8555
		internal RadioButton radioButton_2;

		// Token: 0x0400216C RID: 8556
		internal ScrollViewer scrollViewer_0;

		// Token: 0x0400216D RID: 8557
		internal StackPanel stackPanel_0;

		// Token: 0x0400216E RID: 8558
		internal dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0;

		// Token: 0x0400216F RID: 8559
		internal dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd_0;

		// Token: 0x04002170 RID: 8560
		internal dje_zASTEA68QV9JLMYGZ2N6CNG8R7CWBMT8QWNJYKUX8PA47XJSL3WE5TMPA7MQEHCC3FW_ejd dje_zASTEA68QV9JLMYGZ2N6CNG8R7CWBMT8QWNJYKUX8PA47XJSL3WE5TMPA7MQEHCC3FW_ejd_0;

		// Token: 0x04002171 RID: 8561
		private bool bool_0;

		// Token: 0x020007D7 RID: 2007
		[StructLayout(LayoutKind.Auto)]
		private struct Struct585 : IAsyncStateMachine
		{
			// Token: 0x060030D4 RID: 12500 RVA: 0x000BB8DC File Offset: 0x000B9ADC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd = this.dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd_0;
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
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.Struct585>(ref awaiter, ref this);
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
					if (dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Visible)
					{
						dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 0.0, 10.0);
					}
					if (dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Collapsed)
					{
						dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.stackPanel_0.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
						dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.scrollViewer_0.Margin = new Thickness(10.0, 10.0, 10.0, 10.0);
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

			// Token: 0x060030D5 RID: 12501 RVA: 0x0001EF4D File Offset: 0x0001D14D
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002172 RID: 8562
			public int int_0;

			// Token: 0x04002173 RID: 8563
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002174 RID: 8564
			public dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd_0;

			// Token: 0x04002175 RID: 8565
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007D8 RID: 2008
		[Serializable]
		private sealed class Class911
		{
			// Token: 0x060030D8 RID: 12504 RVA: 0x0001EF67 File Offset: 0x0001D167
			internal bool method_0(Class529 class529_0)
			{
				return !class529_0.IsChoosen;
			}

			// Token: 0x060030D9 RID: 12505 RVA: 0x0001B228 File Offset: 0x00019428
			internal bool method_1(Class529 class529_0)
			{
				return class529_0.IsChoosen;
			}

			// Token: 0x04002176 RID: 8566
			public static readonly dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.Class911 class911_0 = new dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd.Class911();

			// Token: 0x04002177 RID: 8567
			public static Func<Class529, bool> func_0;

			// Token: 0x04002178 RID: 8568
			public static Func<Class529, bool> func_1;
		}
	}
}
