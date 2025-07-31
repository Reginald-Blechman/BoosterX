using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Material.Icons.WPF;

namespace ns0
{
	// Token: 0x020007A8 RID: 1960
	public sealed class dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002FD6 RID: 12246 RVA: 0x000B7960 File Offset: 0x000B5B60
		public dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd()
		{
			this.InitializeComponent();
			Class374.smethod_0().method_0(new Class374.Delegate27(this.method_0));
			base.DataContext = GClass292.smethod_0();
			base.MouseWheel += this.dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd_MouseWheel;
			this.method_1();
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x0001E6EB File Offset: 0x0001C8EB
		private void method_0(CultureInfo cultureInfo_0)
		{
			this.materialIcon_0.Kind = ((Class374.smethod_0().method_2() == FlowDirection.LeftToRight) ? 1724 : 1719);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x000B79D4 File Offset: 0x000B5BD4
		private void method_1()
		{
			GClass292.GClass194 gclass = base.DataContext as GClass292.GClass194;
			if (gclass == null)
			{
				return;
			}
			int num = (gclass.AppsX.Count<GClass173>() < 6) ? 2 : 1;
			for (int i = 0; i < num; i++)
			{
				foreach (GClass173 dataContext in gclass.AppsX)
				{
					dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd = new dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd
					{
						DataContext = dataContext
					};
					this.list_0.Add(dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd);
					this.canvas_0.Children.Add(dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd);
				}
			}
			try
			{
				if (!Class551.class753_0.method_2().smethod_9())
				{
					dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd2 = null;
					foreach (dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd3 in this.list_0)
					{
						if ((dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd3.DataContext as GClass173).string_0 == Class551.class753_0.method_2())
						{
							dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd2 = dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd3;
							break;
						}
					}
					if (dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd2 != null)
					{
						this.int_0 = this.list_0.IndexOf(dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd2);
					}
				}
			}
			catch
			{
			}
			this.method_2(this.int_0);
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x000B7B28 File Offset: 0x000B5D28
		private void method_2(int int_2)
		{
			dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.Struct566 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd_0 = this;
			@struct.int_1 = int_2;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.Struct566>(ref @struct);
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x0001E710 File Offset: 0x0001C910
		private void dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd_MouseWheel(object sender, MouseWheelEventArgs e)
		{
			if (e.Delta > 0)
			{
				this.method_3(null, null);
				return;
			}
			this.method_4(null, null);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x000B7B68 File Offset: 0x000B5D68
		public void method_3(object sender, RoutedEventArgs e)
		{
			this.int_1++;
			this.int_0 = (this.int_0 - 1 + this.list_0.Count) % this.list_0.Count;
			this.method_2(this.int_0);
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x0001E72C File Offset: 0x0001C92C
		public void method_4(object sender, RoutedEventArgs e)
		{
			this.int_1++;
			this.int_0 = (this.int_0 + 1) % this.list_0.Count;
			this.method_2(this.int_0);
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000B7BB8 File Offset: 0x000B5DB8
		private void canvas_0_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.Struct565 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.Struct565>(ref @struct);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x0001E762 File Offset: 0x0001C962
		private void method_5(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_7().radioButton_2.IsChecked = new bool?(true);
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x000B7BF0 File Offset: 0x000B5DF0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/appsshowcase.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x000B7C24 File Offset: 0x000B5E24
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
				this.geometryDrawing_0 = (GeometryDrawing)target;
				return;
			case 3:
				((Button)target).Click += this.method_5;
				return;
			case 4:
				this.materialIcon_0 = (MaterialIcon)target;
				return;
			case 5:
				this.canvas_0 = (Canvas)target;
				this.canvas_0.SizeChanged += this.canvas_0_SizeChanged;
				return;
			case 6:
				((Button)target).Click += this.method_3;
				return;
			case 7:
				this.materialIcon_1 = (MaterialIcon)target;
				return;
			case 8:
				((Button)target).Click += this.method_4;
				return;
			case 9:
				this.materialIcon_2 = (MaterialIcon)target;
				return;
			default:
				this.bool_2 = true;
				return;
			}
		}

		// Token: 0x04002076 RID: 8310
		private List<dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd> list_0 = new List<dje_zGT4UHYGTELKVM67RST8485D8ZPEKN5KC57D8CEUBY89DJ98NDUUR6M7ANSQA_ejd>();

		// Token: 0x04002077 RID: 8311
		private int int_0;

		// Token: 0x04002078 RID: 8312
		private int int_1 = 1;

		// Token: 0x04002079 RID: 8313
		private SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

		// Token: 0x0400207A RID: 8314
		private bool bool_0;

		// Token: 0x0400207B RID: 8315
		private bool bool_1;

		// Token: 0x0400207C RID: 8316
		internal Grid grid_0;

		// Token: 0x0400207D RID: 8317
		internal GeometryDrawing geometryDrawing_0;

		// Token: 0x0400207E RID: 8318
		internal MaterialIcon materialIcon_0;

		// Token: 0x0400207F RID: 8319
		internal Canvas canvas_0;

		// Token: 0x04002080 RID: 8320
		internal MaterialIcon materialIcon_1;

		// Token: 0x04002081 RID: 8321
		internal MaterialIcon materialIcon_2;

		// Token: 0x04002082 RID: 8322
		private bool bool_2;

		// Token: 0x020007A9 RID: 1961
		[StructLayout(LayoutKind.Auto)]
		private struct Struct565 : IAsyncStateMachine
		{
			// Token: 0x06002FE1 RID: 12257 RVA: 0x000B7D14 File Offset: 0x000B5F14
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd = this.dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.bool_0 || !dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.bool_1)
						{
							goto IL_C0;
						}
						dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.bool_0 = true;
						awaiter = Task.Delay(201).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.Struct565>(ref awaiter, ref this);
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
					dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.int_1++;
					dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.method_2(dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.int_0);
					dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.bool_0 = false;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_C0:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002FE2 RID: 12258 RVA: 0x0001E77E File Offset: 0x0001C97E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002083 RID: 8323
			public int int_0;

			// Token: 0x04002084 RID: 8324
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002085 RID: 8325
			public dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd_0;

			// Token: 0x04002086 RID: 8326
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007AA RID: 1962
		[StructLayout(LayoutKind.Auto)]
		private struct Struct566 : IAsyncStateMachine
		{
			// Token: 0x06002FE3 RID: 12259 RVA: 0x000B7E04 File Offset: 0x000B6004
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd = this.dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num - 1 <= 1)
						{
							goto IL_77;
						}
						awaiter = dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.semaphoreSlim_0.WaitAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.Struct566>(ref awaiter, ref this);
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
					IL_77:
					try
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.int_0 = num4;
							goto IL_10F;
						}
						if (num == 2)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
							goto IL_4F8;
						}
						this.int_2 = 0;
						IL_C8:
						if (dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.canvas_0.ActualWidth != 0.0)
						{
							goto IL_153;
						}
						if (dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.canvas_0.ActualHeight != 0.0)
						{
							goto IL_153;
						}
						awaiter = Task.Delay(200).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num6 = 1;
							num = 1;
							this.int_0 = num6;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.Struct566>(ref awaiter, ref this);
							return;
						}
						IL_10F:
						awaiter.GetResult();
						int num7 = this.int_2;
						this.int_2 = num7 + 1;
						if (num7 <= 10)
						{
							goto IL_C8;
						}
						IL_153:
						double num8 = dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.canvas_0.ActualWidth;
						double num9 = dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.canvas_0.ActualHeight;
						if (dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.canvas_0.ActualWidth == 0.0 || dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.canvas_0.ActualHeight == 0.0)
						{
							num8 = 476.0;
							num9 = 180.0;
						}
						double num10 = 306.0;
						double num11 = num8 / 2.0 - (double)153f;
						double num12 = num9 / 2.0 - (double)95.5f;
						int count = dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.list_0.Count;
						int num13 = count / 2;
						double num14 = 250.0;
						dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd2 = dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd;
						num7 = dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.int_1;
						dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd2.int_1 = num7 - 1;
						TimeSpan timeSpan = TimeSpan.FromMilliseconds(num14 / ((double)num7 * 1.5));
						Duration duration = new Duration(timeSpan);
						for (int i = 0; i < count; i++)
						{
							int num15 = (i - this.int_1 + count) % count;
							if (count % 2 == 0)
							{
								if (num15 == num13)
								{
									num15 = -num13;
								}
								else if (num15 > num13)
								{
									num15 -= count;
								}
							}
							else if (num15 > num13)
							{
								num15 -= count;
							}
							double num16 = 1.0;
							double toValue = num12;
							double toValue2;
							int value;
							if (num15 == 0)
							{
								num16 = 0.8;
								toValue2 = num11;
								value = 10;
							}
							else if (Math.Abs(num15) == 1)
							{
								num16 = 0.6;
								double num17 = num10 * num16 * 1.2;
								toValue2 = ((num15 < 0) ? (num11 - num17) : (num11 + num17));
								value = 8;
							}
							else if (Math.Abs(num15) == 2)
							{
								num16 = 0.6;
								double num18 = num10 * num16 * 2.4;
								toValue2 = ((num15 < 0) ? (num11 - num18) : (num11 + num18));
								value = 6;
							}
							else
							{
								double num19 = num10 * num16 * 4.0;
								toValue2 = ((num15 < 0) ? (num11 - num19) : (num11 + num19));
								num16 = 0.6;
								value = 0;
							}
							dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.list_0[i].Visibility = ((num15 > 2 || num15 < -2) ? Visibility.Collapsed : Visibility.Visible);
							Panel.SetZIndex(dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.list_0[i], value);
							TransformGroup transformGroup = dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.list_0[i].RenderTransform as TransformGroup;
							ScaleTransform scaleTransform;
							TranslateTransform translateTransform;
							if (transformGroup == null)
							{
								scaleTransform = new ScaleTransform(1.0, 1.0);
								translateTransform = new TranslateTransform(0.0, 0.0);
								transformGroup = new TransformGroup();
								transformGroup.Children.Add(scaleTransform);
								transformGroup.Children.Add(translateTransform);
								dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.list_0[i].RenderTransform = transformGroup;
							}
							else
							{
								scaleTransform = (transformGroup.Children.OfType<ScaleTransform>().FirstOrDefault<ScaleTransform>() ?? new ScaleTransform(1.0, 1.0));
								translateTransform = (transformGroup.Children.OfType<TranslateTransform>().FirstOrDefault<TranslateTransform>() ?? new TranslateTransform(0.0, 0.0));
							}
							DoubleAnimation animation = new DoubleAnimation(num16, duration);
							scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, animation);
							scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, animation);
							DoubleAnimation animation2 = new DoubleAnimation(toValue2, duration);
							translateTransform.BeginAnimation(TranslateTransform.XProperty, animation2);
							DoubleAnimation animation3 = new DoubleAnimation(toValue, duration);
							translateTransform.BeginAnimation(TranslateTransform.YProperty, animation3);
						}
						awaiter = Task.Delay(timeSpan).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num20 = 2;
							num = 2;
							this.int_0 = num20;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.Struct566>(ref awaiter, ref this);
							return;
						}
						IL_4F8:
						awaiter.GetResult();
					}
					catch
					{
					}
					finally
					{
						if (num < 0)
						{
							dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.bool_1 = true;
							dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd.semaphoreSlim_0.Release();
						}
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

			// Token: 0x06002FE4 RID: 12260 RVA: 0x0001E78C File Offset: 0x0001C98C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002087 RID: 8327
			public int int_0;

			// Token: 0x04002088 RID: 8328
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002089 RID: 8329
			public dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd dje_zBR7K73SNADX8WXGVD32ZQBYH47N26FKK8ZBZWPZPM87A5FWJCGUKX_ejd_0;

			// Token: 0x0400208A RID: 8330
			public int int_1;

			// Token: 0x0400208B RID: 8331
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x0400208C RID: 8332
			private int int_2;
		}
	}
}
