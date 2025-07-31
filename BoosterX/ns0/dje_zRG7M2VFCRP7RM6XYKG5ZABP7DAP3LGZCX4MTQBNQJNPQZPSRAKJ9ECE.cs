using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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

namespace ns0
{
	// Token: 0x0200086D RID: 2157
	public sealed class dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd : Page, IComponentConnector
	{
		// Token: 0x0600335D RID: 13149 RVA: 0x000C7828 File Offset: 0x000C5A28
		public dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_Loaded;
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x00020392 File Offset: 0x0001E592
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x0002039A File Offset: 0x0001E59A
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000203A3 File Offset: 0x0001E5A3
		private void dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			base.DataContext = this.gclass190_0;
			this.radioButton_0.IsChecked = new bool?(true);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x000203C2 File Offset: 0x0001E5C2
		private void textBox_0_KeyUp(object sender, KeyEventArgs e)
		{
			this.button_0.IsEnabled = (this.textBox_0.Text != this.method_0());
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x000C788C File Offset: 0x000C5A8C
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				FileStream fileStream = new FileStream(this.gclass190_0.SelectedProfile.Autoexec.FilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
				try
				{
					StreamWriter streamWriter = new StreamWriter(fileStream);
					try
					{
						streamWriter.Write(this.textBox_0.Text);
					}
					finally
					{
						((IDisposable)streamWriter).Dispose();
					}
				}
				finally
				{
					((IDisposable)fileStream).Dispose();
				}
			}
			catch
			{
			}
			this.button_0.IsEnabled = false;
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x000C791C File Offset: 0x000C5B1C
		private Task method_2()
		{
			dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct660 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct660>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x000C7960 File Offset: 0x000C5B60
		private void radioButton_0_Checked(object sender, RoutedEventArgs e)
		{
			dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct662 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct662>(ref @struct);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000C7998 File Offset: 0x000C5B98
		private void method_3(object sender, RoutedEventArgs e)
		{
			dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct661 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct661>(ref @struct);
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x000C79D0 File Offset: 0x000C5BD0
		private void method_4()
		{
			if (this.list_1.Count == 0)
			{
				this.list_1 = dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.gclass46_0.method_2<List<Class326>>("BoosterX.Resources.Json.CSGOJsons.CsgoRunCvars.json");
			}
			foreach (Class326 class326_ in this.list_1)
			{
				this.list_0.Add(new Class519(class326_));
			}
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x000C7A54 File Offset: 0x000C5C54
		private void method_5()
		{
			if (this.list_3.Count == 0)
			{
				this.list_3 = dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.gclass46_0.method_2<List<Class745>>("BoosterX.Resources.Json.CSGOJsons.CsgoSettingsCvars.json");
			}
			foreach (Class745 class745_ in this.list_3)
			{
				this.list_2.Add(new Class618(class745_));
			}
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x000C7AD8 File Offset: 0x000C5CD8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/cs2/views/autoexeceditor/autoexeceditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x000C7B0C File Offset: 0x000C5D0C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.radioButton_0 = (RadioButton)target;
				this.radioButton_0.Checked += this.radioButton_0_Checked;
				return;
			case 2:
				((RadioButton)target).Checked += this.method_3;
				return;
			case 3:
				this.grid_0 = (Grid)target;
				return;
			case 4:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 5:
				this.grid_1 = (Grid)target;
				return;
			case 6:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 7:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.KeyUp += this.textBox_0_KeyUp;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x000C7BF0 File Offset: 0x000C5DF0
		private Task method_6()
		{
			dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct663 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct663>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04002468 RID: 9320
		private GClass190 gclass190_0 = new GClass190();

		// Token: 0x04002469 RID: 9321
		private string string_0;

		// Token: 0x0400246A RID: 9322
		private List<Class519> list_0 = new List<Class519>();

		// Token: 0x0400246B RID: 9323
		private List<Class326> list_1 = new List<Class326>();

		// Token: 0x0400246C RID: 9324
		private List<Class618> list_2 = new List<Class618>();

		// Token: 0x0400246D RID: 9325
		private List<Class745> list_3 = new List<Class745>();

		// Token: 0x0400246E RID: 9326
		private static GClass46 gclass46_0 = new GClass46();

		// Token: 0x0400246F RID: 9327
		internal RadioButton radioButton_0;

		// Token: 0x04002470 RID: 9328
		internal Grid grid_0;

		// Token: 0x04002471 RID: 9329
		internal ItemsControl itemsControl_0;

		// Token: 0x04002472 RID: 9330
		internal Grid grid_1;

		// Token: 0x04002473 RID: 9331
		internal Button button_0;

		// Token: 0x04002474 RID: 9332
		internal TextBox textBox_0;

		// Token: 0x04002475 RID: 9333
		private bool bool_0;

		// Token: 0x0200086E RID: 2158
		[StructLayout(LayoutKind.Auto)]
		private struct Struct660 : IAsyncStateMachine
		{
			// Token: 0x0600336C RID: 13164 RVA: 0x000C7C34 File Offset: 0x000C5E34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd = this.dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Dispatcher.Invoke<Task>(new Func<Task>(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.method_6)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct660>(ref awaiter, ref this);
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
					catch
					{
					}
					dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_0.Visibility = Visibility.Collapsed;
					dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_1.Visibility = Visibility.Collapsed;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x0600336D RID: 13165 RVA: 0x000203E5 File Offset: 0x0001E5E5
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002476 RID: 9334
			public int int_0;

			// Token: 0x04002477 RID: 9335
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04002478 RID: 9336
			public dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0;

			// Token: 0x04002479 RID: 9337
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200086F RID: 2159
		[StructLayout(LayoutKind.Auto)]
		private struct Struct661 : IAsyncStateMachine
		{
			// Token: 0x0600336E RID: 13166 RVA: 0x000C7D20 File Offset: 0x000C5F20
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd = this.dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0;
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
							goto IL_11A;
						}
						awaiter = dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.method_2().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct661>(ref awaiter, ref this);
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
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_1);
					dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.button_0.IsEnabled = false;
					try
					{
						dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.method_1(File.ReadAllText(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.gclass190_0.SelectedProfile.Autoexec.FilePath));
						dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.textBox_0.Text = dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.method_0();
					}
					catch
					{
					}
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_1, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct661>(ref awaiter, ref this);
						return;
					}
					IL_11A:
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

			// Token: 0x0600336F RID: 13167 RVA: 0x000203F3 File Offset: 0x0001E5F3
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400247A RID: 9338
			public int int_0;

			// Token: 0x0400247B RID: 9339
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400247C RID: 9340
			public dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0;

			// Token: 0x0400247D RID: 9341
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000870 RID: 2160
		[StructLayout(LayoutKind.Auto)]
		private struct Struct662 : IAsyncStateMachine
		{
			// Token: 0x06003370 RID: 13168 RVA: 0x000C7EB0 File Offset: 0x000C60B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd = this.dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0;
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
							goto IL_D5;
						}
						awaiter = dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.method_2().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct662>(ref awaiter, ref this);
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
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_0);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct662>(ref awaiter, ref this);
						return;
					}
					IL_D5:
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

			// Token: 0x06003371 RID: 13169 RVA: 0x00020401 File Offset: 0x0001E601
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400247E RID: 9342
			public int int_0;

			// Token: 0x0400247F RID: 9343
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002480 RID: 9344
			public dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0;

			// Token: 0x04002481 RID: 9345
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000871 RID: 2161
		[StructLayout(LayoutKind.Auto)]
		private struct Struct663 : IAsyncStateMachine
		{
			// Token: 0x06003372 RID: 13170 RVA: 0x000C7FD8 File Offset: 0x000C61D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd = this.dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0;
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
							goto IL_EE;
						}
						if (dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_0.Visibility != Visibility.Visible)
						{
							goto IL_A5;
						}
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct663>(ref awaiter, ref this);
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
					IL_A5:
					if (dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_1.Visibility != Visibility.Visible)
					{
						goto IL_F5;
					}
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.grid_1, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd.Struct663>(ref awaiter, ref this);
						return;
					}
					IL_EE:
					awaiter.GetResult();
					IL_F5:;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06003373 RID: 13171 RVA: 0x0002040F File Offset: 0x0001E60F
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002482 RID: 9346
			public int int_0;

			// Token: 0x04002483 RID: 9347
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04002484 RID: 9348
			public dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd_0;

			// Token: 0x04002485 RID: 9349
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
