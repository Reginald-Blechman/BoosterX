using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x020007D9 RID: 2009
	public sealed class dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd : Page, IComponentConnector
	{
		// Token: 0x060030DA RID: 12506 RVA: 0x0001EF72 File Offset: 0x0001D172
		public dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_Loaded;
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x000BBA58 File Offset: 0x000B9C58
		private void dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			this.bool_0 = false;
			this.grid_1.Visibility = Visibility.Collapsed;
			this.grid_3.Visibility = Visibility.Collapsed;
			this.grid_4.Visibility = Visibility.Collapsed;
			this.grid_1.Opacity = 0.0;
			this.grid_3.Opacity = 0.0;
			this.grid_4.Opacity = 0.0;
			this.grid_0.Visibility = Visibility.Visible;
			this.grid_0.Opacity = 1.0;
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0001EF92 File Offset: 0x0001D192
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			this.bool_0 = false;
			Class406.smethod_0().method_4(typeof(dje_zEJ26DQG765ZVYW22ZK8PXVYG84BZZZL3GKVB2MWU7QT697A_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000BBAEC File Offset: 0x000B9CEC
		private void method_0(object sender, RoutedEventArgs e)
		{
			dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct588 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct588>(ref @struct);
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x000BBB24 File Offset: 0x000B9D24
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct589 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct589>(ref @struct);
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x000BBB5C File Offset: 0x000B9D5C
		private void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct593 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct593>(ref @struct);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x000BBB94 File Offset: 0x000B9D94
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct591 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct591>(ref @struct);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x000BBBCC File Offset: 0x000B9DCC
		private void button_4_Click(object sender, RoutedEventArgs e)
		{
			dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct590 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct590>(ref @struct);
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x000BBC04 File Offset: 0x000B9E04
		private void button_5_Click(object sender, RoutedEventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "HEjlbZa-i4", object_);
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x000BBC3C File Offset: 0x000B9E3C
		private void button_6_Click(object sender, RoutedEventArgs e)
		{
			dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct587 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct587>(ref @struct);
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000BBC74 File Offset: 0x000B9E74
		private void method_1()
		{
			dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct592 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct592>(ref @struct);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0001EFB9 File Offset: 0x0001D1B9
		private void textBox_0_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{
			this.textBox_0.SelectAll();
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x000BBCAC File Offset: 0x000B9EAC
		private void button_7_Click(object sender, RoutedEventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "-*akbZa-i=", object_);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000BBCE4 File Offset: 0x000B9EE4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/activate/supportpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x000BBD18 File Offset: 0x000B9F18
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 2:
				this.grid_0 = (Grid)target;
				return;
			case 3:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 4:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 5:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 6:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.PreviewMouseUp += this.textBox_0_PreviewMouseUp;
				return;
			case 7:
				this.grid_1 = (Grid)target;
				return;
			case 8:
				((Button)target).Click += this.method_0;
				return;
			case 9:
				this.textBox_1 = (TextBox)target;
				return;
			case 10:
				this.textBox_2 = (TextBox)target;
				return;
			case 11:
				this.button_4 = (Button)target;
				this.button_4.Click += this.button_4_Click;
				return;
			case 12:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 13:
				this.grid_2 = (Grid)target;
				return;
			case 14:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 15:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 16:
				this.button_5 = (Button)target;
				this.button_5.Click += this.button_5_Click;
				return;
			case 17:
				this.grid_3 = (Grid)target;
				return;
			case 18:
				((Button)target).Click += this.method_0;
				return;
			case 19:
				this.textBox_3 = (TextBox)target;
				return;
			case 20:
				this.button_6 = (Button)target;
				this.button_6.Click += this.button_6_Click;
				return;
			case 21:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 22:
				this.grid_4 = (Grid)target;
				return;
			case 23:
				((Button)target).Click += this.method_0;
				return;
			case 24:
				this.button_7 = (Button)target;
				this.button_7.Click += this.button_7_Click;
				return;
			case 25:
				this.textBlock_4 = (TextBlock)target;
				return;
			default:
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0001EFC6 File Offset: 0x0001D1C6
		private static void smethod_0(ref dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct586 struct586_0)
		{
			struct586_0.asyncVoidMethodBuilder_0.Start<dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct586>(ref struct586_0);
		}

		// Token: 0x04002179 RID: 8569
		private bool bool_0;

		// Token: 0x0400217A RID: 8570
		internal Button button_0;

		// Token: 0x0400217B RID: 8571
		internal Grid grid_0;

		// Token: 0x0400217C RID: 8572
		internal Button button_1;

		// Token: 0x0400217D RID: 8573
		internal Button button_2;

		// Token: 0x0400217E RID: 8574
		internal Button button_3;

		// Token: 0x0400217F RID: 8575
		internal TextBox textBox_0;

		// Token: 0x04002180 RID: 8576
		internal Grid grid_1;

		// Token: 0x04002181 RID: 8577
		internal TextBox textBox_1;

		// Token: 0x04002182 RID: 8578
		internal TextBox textBox_2;

		// Token: 0x04002183 RID: 8579
		internal Button button_4;

		// Token: 0x04002184 RID: 8580
		internal TextBlock textBlock_0;

		// Token: 0x04002185 RID: 8581
		internal Grid grid_2;

		// Token: 0x04002186 RID: 8582
		internal TextBlock textBlock_1;

		// Token: 0x04002187 RID: 8583
		internal TextBlock textBlock_2;

		// Token: 0x04002188 RID: 8584
		internal Button button_5;

		// Token: 0x04002189 RID: 8585
		internal Grid grid_3;

		// Token: 0x0400218A RID: 8586
		internal TextBox textBox_3;

		// Token: 0x0400218B RID: 8587
		internal Button button_6;

		// Token: 0x0400218C RID: 8588
		internal TextBlock textBlock_3;

		// Token: 0x0400218D RID: 8589
		internal Grid grid_4;

		// Token: 0x0400218E RID: 8590
		internal Button button_7;

		// Token: 0x0400218F RID: 8591
		internal TextBlock textBlock_4;

		// Token: 0x04002190 RID: 8592
		private bool bool_1;

		// Token: 0x020007DA RID: 2010
		[StructLayout(LayoutKind.Auto)]
		private struct Struct586 : IAsyncStateMachine
		{
			// Token: 0x060030EA RID: 12522 RVA: 0x000BBFD0 File Offset: 0x000BA1D0
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
					@class.method_64(stream_, "kHVG%Za-i7", array);
				}
				finally
				{
					this = (dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct586)array[0];
				}
			}

			// Token: 0x060030EB RID: 12523 RVA: 0x0001EFD4 File Offset: 0x0001D1D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x060030EC RID: 12524 RVA: 0x0001EFE2 File Offset: 0x0001D1E2
			private static void MoveNext(ref TaskAwaiter taskAwaiter_2, ref dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct586 struct586_0)
			{
				struct586_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct586>(ref taskAwaiter_2, ref struct586_0);
			}

			// Token: 0x060030ED RID: 12525 RVA: 0x0001EFE2 File Offset: 0x0001D1E2
			private static void MoveNext_1(ref TaskAwaiter taskAwaiter_2, ref dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct586 struct586_0)
			{
				struct586_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct586>(ref taskAwaiter_2, ref struct586_0);
			}

			// Token: 0x060030EE RID: 12526 RVA: 0x0001EFF1 File Offset: 0x0001D1F1
			private static void MoveNext_2(ref TaskAwaiter<Class723> taskAwaiter_2, ref dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct586 struct586_0)
			{
				struct586_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct586>(ref taskAwaiter_2, ref struct586_0);
			}

			// Token: 0x04002191 RID: 8593
			public int int_0;

			// Token: 0x04002192 RID: 8594
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002193 RID: 8595
			public dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;

			// Token: 0x04002194 RID: 8596
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04002195 RID: 8597
			private TaskAwaiter<Class723> taskAwaiter_1;
		}

		// Token: 0x020007DB RID: 2011
		[StructLayout(LayoutKind.Auto)]
		private struct Struct587 : IAsyncStateMachine
		{
			// Token: 0x060030EF RID: 12527 RVA: 0x000BC038 File Offset: 0x000BA238
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd = this.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;
				try
				{
					TaskAwaiter<Class723> awaiter;
					if (num != 0)
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_14(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3, 100);
						dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3.Text = string.Empty;
						if (dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBox_3.Text.smethod_9())
						{
							dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3, Class298.smethod_2("EnterEmailRequired"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
							goto IL_191;
						}
						dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_6.IsEnabled = false;
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3, Class298.smethod_2("SendingRequest"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
						dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.bool_0 = true;
						dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.method_1();
						Class378<string, string> object_ = new Class378<string, string>(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBox_3.Text, Class298.smethod_2("CurrentLocalization"));
						awaiter = Class215.smethod_1("ResendOD", object_).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct587>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Class723>);
						this.int_0 = -1;
					}
					Class723 result = awaiter.GetResult();
					dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.bool_0 = false;
					if (!result.Success)
					{
						dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_6.IsEnabled = true;
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3, Class298.smethod_2(result.Message), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
					}
					else
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3, Class298.smethod_2("SuccessfullyResendOrders"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
						dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_6.IsEnabled = true;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_191:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060030F0 RID: 12528 RVA: 0x0001F000 File Offset: 0x0001D200
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002196 RID: 8598
			public int int_0;

			// Token: 0x04002197 RID: 8599
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002198 RID: 8600
			public dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;

			// Token: 0x04002199 RID: 8601
			private TaskAwaiter<Class723> taskAwaiter_0;
		}

		// Token: 0x020007DC RID: 2012
		[StructLayout(LayoutKind.Auto)]
		private struct Struct588 : IAsyncStateMachine
		{
			// Token: 0x060030F1 RID: 12529 RVA: 0x000BC208 File Offset: 0x000BA408
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd = this.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_E4;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_143;
					default:
						dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.bool_0 = false;
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_3, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct588>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_1, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct588>(ref awaiter, ref this);
						return;
					}
					IL_E4:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_4, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct588>(ref awaiter, ref this);
						return;
					}
					IL_143:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_24(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_0, 100);
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

			// Token: 0x060030F2 RID: 12530 RVA: 0x0001F00E File Offset: 0x0001D20E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400219A RID: 8602
			public int int_0;

			// Token: 0x0400219B RID: 8603
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400219C RID: 8604
			public dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;

			// Token: 0x0400219D RID: 8605
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007DD RID: 2013
		[StructLayout(LayoutKind.Auto)]
		private struct Struct589 : IAsyncStateMachine
		{
			// Token: 0x060030F3 RID: 12531 RVA: 0x000BC3B4 File Offset: 0x000BA5B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd = this.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct589>(ref awaiter, ref this);
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
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_24(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_1, 100);
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

			// Token: 0x060030F4 RID: 12532 RVA: 0x0001F01C File Offset: 0x0001D21C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400219E RID: 8606
			public int int_0;

			// Token: 0x0400219F RID: 8607
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040021A0 RID: 8608
			public dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;

			// Token: 0x040021A1 RID: 8609
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007DE RID: 2014
		[StructLayout(LayoutKind.Auto)]
		private struct Struct590 : IAsyncStateMachine
		{
			// Token: 0x060030F5 RID: 12533 RVA: 0x000BC47C File Offset: 0x000BA67C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd = this.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<Class723> awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_DD;
					case 2:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<Class723>);
						this.int_0 = -1;
						goto IL_259;
					default:
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_5, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct590>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_2, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct590>(ref awaiter, ref this);
						return;
					}
					IL_DD:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_14(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0, 100);
					dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0.Text = string.Empty;
					dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_1.Text = string.Empty;
					dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_2.Text = string.Empty;
					if (dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBox_1.Text.smethod_9())
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0, Class298.smethod_2("EnterEmailRequired"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
						goto IL_47C;
					}
					if (dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBox_2.Text.smethod_9())
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0, Class298.smethod_2("EnterKeyRequired"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
						goto IL_47C;
					}
					if (!dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBox_1.Text.smethod_8())
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0, Class298.smethod_2("WrongEmail"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
						goto IL_47C;
					}
					dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_4.IsEnabled = false;
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0, Class298.smethod_2("CheckingHwidStatus"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
					Class710<string, string> object_ = new Class710<string, string>(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBox_1.Text, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBox_2.Text);
					awaiter2 = Class215.smethod_1("UnhwidCheck", object_).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_1 = awaiter2;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct590>(ref awaiter2, ref this);
						return;
					}
					IL_259:
					Class723 result = awaiter2.GetResult();
					if (!result.Success)
					{
						dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_4.IsEnabled = true;
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0, Class298.smethod_2(result.Message), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
					}
					else
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0, Class298.smethod_2("MessageReceived"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
						Class748 @class = JsonConvert.DeserializeObject<Class748>(result.Message);
						if (@class.KeyExpiry < TimeSpan.FromDays(200.0))
						{
							dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_4.IsEnabled = true;
							dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0, Class298.smethod_2("unknownerror"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
						}
						else
						{
							dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_0, string.Empty, null);
							dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_1.Text = (@class.IsAvailable ? Class298.smethod_2("UnhwidAvailable") : Class298.smethod_2("UnhwidUnAvailable"));
							dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_1.Foreground = (@class.IsAvailable ? dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd : dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
							if (@class.IsAvailable)
							{
								if (@class.KeyExpiry < TimeSpan.FromDays(400.0))
								{
									dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_2.Text = Class298.smethod_2("UnhwidWillNotBeAvailableAnymore");
								}
								if (@class.KeyExpiry > TimeSpan.FromDays(1000.0))
								{
									dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_2.Text = Class298.smethod_2("UnhwidWillBeAvailableIn") + 182.ToString() + " " + Class298.smethod_2("days");
								}
								dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_5);
							}
							else
							{
								dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_2.Text = Class298.smethod_2("NextUnhidWillBeAvailableIn") + @class.NextUnhwidDaysCount.ToString() + " " + Class298.smethod_2("days");
							}
							dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_24(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_5, 100);
							dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_24(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_2, 100);
							dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.button_4.IsEnabled = true;
						}
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_47C:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060030F6 RID: 12534 RVA: 0x0001F02A File Offset: 0x0001D22A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040021A2 RID: 8610
			public int int_0;

			// Token: 0x040021A3 RID: 8611
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040021A4 RID: 8612
			public dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;

			// Token: 0x040021A5 RID: 8613
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x040021A6 RID: 8614
			private TaskAwaiter<Class723> taskAwaiter_1;
		}

		// Token: 0x020007DF RID: 2015
		[StructLayout(LayoutKind.Auto)]
		private struct Struct591 : IAsyncStateMachine
		{
			// Token: 0x060030F7 RID: 12535 RVA: 0x000BC934 File Offset: 0x000BAB34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd = this.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct591>(ref awaiter, ref this);
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
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_24(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_4, 100);
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

			// Token: 0x060030F8 RID: 12536 RVA: 0x0001F038 File Offset: 0x0001D238
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040021A7 RID: 8615
			public int int_0;

			// Token: 0x040021A8 RID: 8616
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040021A9 RID: 8617
			public dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;

			// Token: 0x040021AA RID: 8618
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007E0 RID: 2016
		[StructLayout(LayoutKind.Auto)]
		private struct Struct592 : IAsyncStateMachine
		{
			// Token: 0x060030F9 RID: 12537 RVA: 0x000BC9FC File Offset: 0x000BABFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd = this.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_F8;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_14A;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_19C;
					case 3:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1EB;
					}
					IL_C8:
					if (!dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.bool_0)
					{
						goto IL_285;
					}
					awaiter = Task.Delay(TimeSpan.FromSeconds(10.0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct592>(ref awaiter, ref this);
						return;
					}
					IL_F8:
					awaiter.GetResult();
					if (!dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.bool_0)
					{
						goto IL_285;
					}
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3, Class298.smethod_2("ResendKeys1"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
					awaiter = Task.Delay(TimeSpan.FromSeconds(10.0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct592>(ref awaiter, ref this);
						return;
					}
					IL_14A:
					awaiter.GetResult();
					if (!dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.bool_0)
					{
						goto IL_285;
					}
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3, Class298.smethod_2("ResendKeys2"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
					awaiter = Task.Delay(TimeSpan.FromSeconds(10.0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct592>(ref awaiter, ref this);
						return;
					}
					IL_19C:
					awaiter.GetResult();
					if (!dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.bool_0)
					{
						goto IL_285;
					}
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3, Class298.smethod_2("ResendKeys3"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
					awaiter = Task.Delay(TimeSpan.FromSeconds(10.0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct592>(ref awaiter, ref this);
						return;
					}
					IL_1EB:
					awaiter.GetResult();
					if (dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.bool_0)
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.textBlock_3, Class298.smethod_2("SendingRequest"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
						goto IL_C8;
					}
					IL_285:;
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

			// Token: 0x060030FA RID: 12538 RVA: 0x0001F046 File Offset: 0x0001D246
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040021AB RID: 8619
			public int int_0;

			// Token: 0x040021AC RID: 8620
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040021AD RID: 8621
			public dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;

			// Token: 0x040021AE RID: 8622
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007E1 RID: 2017
		[StructLayout(LayoutKind.Auto)]
		private struct Struct593 : IAsyncStateMachine
		{
			// Token: 0x060030FB RID: 12539 RVA: 0x000BCCD8 File Offset: 0x000BAED8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd = this.dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.Struct593>(ref awaiter, ref this);
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
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_24(dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd.grid_3, 100);
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

			// Token: 0x060030FC RID: 12540 RVA: 0x0001F054 File Offset: 0x0001D254
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040021AF RID: 8623
			public int int_0;

			// Token: 0x040021B0 RID: 8624
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040021B1 RID: 8625
			public dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd dje_zEBWWSR64M99SHPRPSWU2FNWX42XBP65RT89UA2G34E8A2GBTF4RWR_ejd_0;

			// Token: 0x040021B2 RID: 8626
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
