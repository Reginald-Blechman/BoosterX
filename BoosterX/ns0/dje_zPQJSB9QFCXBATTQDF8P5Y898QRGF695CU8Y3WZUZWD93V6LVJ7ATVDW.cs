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
using System.Windows.Media.Effects;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x0200085F RID: 2143
	public sealed class dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600332E RID: 13102 RVA: 0x000201E7 File Offset: 0x0001E3E7
		public dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_Loaded;
			base.DataContext = Class585.list_0;
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x000C6448 File Offset: 0x000C4648
		private void dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct657 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct657>(ref @struct);
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x000C6480 File Offset: 0x000C4680
		private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			try
			{
				this.method_0(this.comboBox_0.SelectedIndex);
			}
			catch
			{
			}
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x000C64B4 File Offset: 0x000C46B4
		private void method_0(int int_0)
		{
			dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct655 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0 = this;
			@struct.int_1 = int_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct655>(ref @struct);
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x000C64F4 File Offset: 0x000C46F4
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct656 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct656>(ref @struct);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x000C652C File Offset: 0x000C472C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/diskreviewandcleantrash.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x000C6560 File Offset: 0x000C4760
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				return;
			case 2:
				this.comboBox_0 = (ComboBox)target;
				this.comboBox_0.SelectionChanged += this.comboBox_0_SelectionChanged;
				return;
			case 3:
				this.arc_0 = (Arc)target;
				return;
			case 4:
				this.arc_1 = (Arc)target;
				return;
			case 5:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 6:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 7:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 8:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 9:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 10:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 11:
				this.blurEffect_0 = (BlurEffect)target;
				return;
			case 12:
				this.textBlock_4 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002424 RID: 9252
		internal Grid grid_0;

		// Token: 0x04002425 RID: 9253
		internal ComboBox comboBox_0;

		// Token: 0x04002426 RID: 9254
		internal Arc arc_0;

		// Token: 0x04002427 RID: 9255
		internal Arc arc_1;

		// Token: 0x04002428 RID: 9256
		internal StackPanel stackPanel_0;

		// Token: 0x04002429 RID: 9257
		internal TextBlock textBlock_0;

		// Token: 0x0400242A RID: 9258
		internal TextBlock textBlock_1;

		// Token: 0x0400242B RID: 9259
		internal TextBlock textBlock_2;

		// Token: 0x0400242C RID: 9260
		internal TextBlock textBlock_3;

		// Token: 0x0400242D RID: 9261
		internal Button button_0;

		// Token: 0x0400242E RID: 9262
		internal BlurEffect blurEffect_0;

		// Token: 0x0400242F RID: 9263
		internal TextBlock textBlock_4;

		// Token: 0x04002430 RID: 9264
		private bool bool_0;

		// Token: 0x02000860 RID: 2144
		private sealed class Class941
		{
			// Token: 0x06003336 RID: 13110 RVA: 0x000C6678 File Offset: 0x000C4878
			internal void method_0()
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.textBlock_1, string.Format("{0:0.## GB}", Class585.list_0[this.int_0].method_2()), null);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.textBlock_3, string.Format("{0:0.## GB}", Class585.list_0[this.int_0].method_4()), null);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.textBlock_0, (100.0 - Class585.list_0[this.int_0].method_4() / Class585.list_0[this.int_0].method_2() * 100.0).ToString().Replace('.', ',').Split(new char[]
				{
					','
				})[0] + "%", null);
				if (this.int_0 == 0)
				{
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.textBlock_2, string.Format("{0:0.## GB}", Class585.list_0[this.int_0].method_6()), null);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.arc_0, TimeSpan.FromSeconds(0.2), Arc.EndAngleProperty, Class585.list_0[this.int_0].method_4() / Class585.list_0[this.int_0].method_2() * 100.0 * 3.6);
				}
				else
				{
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.textBlock_2, string.Format("{0:0.## GB}", 0), null);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.textBlock_3, "0 GB", null);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.arc_0, TimeSpan.FromSeconds(0.2), Arc.EndAngleProperty, 0.0);
				}
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.arc_1, TimeSpan.FromSeconds(0.2), Arc.EndAngleProperty, Class585.list_0[this.int_0].method_4() / Class585.list_0[this.int_0].method_2() * 100.0 * 3.6);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0.arc_1, TimeSpan.FromSeconds(0.2), Arc.EndAngleProperty, Class585.list_0[this.int_0].method_4() / Class585.list_0[this.int_0].method_2() * 100.0 * 3.6);
			}

			// Token: 0x04002431 RID: 9265
			public dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0;

			// Token: 0x04002432 RID: 9266
			public int int_0;
		}

		// Token: 0x02000861 RID: 2145
		[StructLayout(LayoutKind.Auto)]
		private struct Struct655 : IAsyncStateMachine
		{
			// Token: 0x06003337 RID: 13111 RVA: 0x000C6954 File Offset: 0x000C4B54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd = this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class941_0 = new dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Class941();
						this.class941_0.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0 = this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0;
						this.class941_0.int_0 = this.int_1;
						awaiter = Class585.smethod_2(this.class941_0.int_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct655>(ref awaiter, ref this);
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
					dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Dispatcher.Invoke(new Action(this.class941_0.method_0));
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class941_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class941_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003338 RID: 13112 RVA: 0x00020212 File Offset: 0x0001E412
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002433 RID: 9267
			public int int_0;

			// Token: 0x04002434 RID: 9268
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002435 RID: 9269
			public dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0;

			// Token: 0x04002436 RID: 9270
			public int int_1;

			// Token: 0x04002437 RID: 9271
			private dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Class941 class941_0;

			// Token: 0x04002438 RID: 9272
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000862 RID: 2146
		[StructLayout(LayoutKind.Auto)]
		private struct Struct656 : IAsyncStateMachine
		{
			// Token: 0x06003339 RID: 13113 RVA: 0x000C6A68 File Offset: 0x000C4C68
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd = this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_F4;
						}
						dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.button_0.IsEnabled = false;
						awaiter = Task.Run(new Func<Task>(dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Class942.class942_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct656>(ref awaiter, ref this);
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
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct656>(ref awaiter, ref this);
						return;
					}
					IL_F4:
					awaiter.GetResult();
					dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.button_0.IsEnabled = true;
					dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.method_0(dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.comboBox_0.SelectedIndex);
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

			// Token: 0x0600333A RID: 13114 RVA: 0x00020220 File Offset: 0x0001E420
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002439 RID: 9273
			public int int_0;

			// Token: 0x0400243A RID: 9274
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400243B RID: 9275
			public dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0;

			// Token: 0x0400243C RID: 9276
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000863 RID: 2147
		[Serializable]
		private sealed class Class942
		{
			// Token: 0x0600333D RID: 13117 RVA: 0x0002023A File Offset: 0x0001E43A
			internal Task method_0()
			{
				return Class605.smethod_0();
			}

			// Token: 0x0400243D RID: 9277
			public static readonly dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Class942 class942_0 = new dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Class942();

			// Token: 0x0400243E RID: 9278
			public static Func<Task> func_0;
		}

		// Token: 0x02000864 RID: 2148
		[StructLayout(LayoutKind.Auto)]
		private struct Struct657 : IAsyncStateMachine
		{
			// Token: 0x0600333E RID: 13118 RVA: 0x000C6BD8 File Offset: 0x000C4DD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd = this.dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!Class551.class753_0.method_70().GetValueOrDefault())
						{
							dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.blurEffect_0.Radius = 15.0;
							dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.grid_0.Opacity = 0.3;
							dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.textBlock_4.Opacity = 1.0;
							dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.grid_0.IsEnabled = false;
							dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.textBlock_4.Visibility = Visibility.Visible;
							goto IL_158;
						}
						dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.blurEffect_0.Radius = 0.0;
						dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.grid_0.Opacity = 1.0;
						dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.textBlock_4.Opacity = 0.0;
						dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.grid_0.IsEnabled = true;
						dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.textBlock_4.Visibility = Visibility.Collapsed;
						awaiter = Class585.smethod_1().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.Struct657>(ref awaiter, ref this);
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
					dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd.comboBox_0.SelectedIndex = 0;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_158:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600333F RID: 13119 RVA: 0x00020241 File Offset: 0x0001E441
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400243F RID: 9279
			public int int_0;

			// Token: 0x04002440 RID: 9280
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002441 RID: 9281
			public dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd dje_zPQJSB9QFCXBATTQDF8P5Y898QRGF695CU8Y3WZUZWD93V6LVJ7ATVDWF6QC8T73MPQ_ejd_0;

			// Token: 0x04002442 RID: 9282
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
