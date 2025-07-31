using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
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
	// Token: 0x02000797 RID: 1943
	public sealed class dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd : Page, IComponentConnector
	{
		// Token: 0x06002F9F RID: 12191 RVA: 0x0001E5BC File Offset: 0x0001C7BC
		public dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x000B6B68 File Offset: 0x000B4D68
		private void method_0(bool bool_1)
		{
			dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Struct557 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Struct557>(ref @struct);
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x0001E5D1 File Offset: 0x0001C7D1
		private void button_2_Click(object sender, RoutedEventArgs e)
		{
			this.method_0(true);
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x000B6BA8 File Offset: 0x000B4DA8
		public void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Struct556 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Struct556>(ref @struct);
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x000B6BE0 File Offset: 0x000B4DE0
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Struct559 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Struct559>(ref @struct);
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x000B6C18 File Offset: 0x000B4E18
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/telemetrypage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000B6C4C File Offset: 0x000B4E4C
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
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 3:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 4:
				this.checkBox_0 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002036 RID: 8246
		internal Button button_0;

		// Token: 0x04002037 RID: 8247
		internal Button button_1;

		// Token: 0x04002038 RID: 8248
		internal Button button_2;

		// Token: 0x04002039 RID: 8249
		internal CheckBox checkBox_0;

		// Token: 0x0400203A RID: 8250
		private bool bool_0;

		// Token: 0x02000798 RID: 1944
		[StructLayout(LayoutKind.Auto)]
		private struct Struct556 : IAsyncStateMachine
		{
			// Token: 0x06002FA6 RID: 12198 RVA: 0x000B6CF4 File Offset: 0x000B4EF4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd = this.dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_11(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Struct556>(ref awaiter, ref this);
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

			// Token: 0x06002FA7 RID: 12199 RVA: 0x0001E5DA File Offset: 0x0001C7DA
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400203B RID: 8251
			public int int_0;

			// Token: 0x0400203C RID: 8252
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400203D RID: 8253
			public dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0;

			// Token: 0x0400203E RID: 8254
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000799 RID: 1945
		[StructLayout(LayoutKind.Auto)]
		private struct Struct557 : IAsyncStateMachine
		{
			// Token: 0x06002FA8 RID: 12200 RVA: 0x000B6DAC File Offset: 0x000B4FAC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd = this.dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class901_0 = new dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Class901();
						this.class901_0.dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0 = this.dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0;
						this.class901_0.bool_0 = this.bool_0;
						dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.button_2.IsEnabled = false;
						dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.DataContext = null;
						this.class901_0.observableCollection_0 = null;
						awaiter = Task.Run(new Func<Task>(this.class901_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Struct557>(ref awaiter, ref this);
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
					dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.DataContext = this.class901_0.observableCollection_0;
					dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.button_2.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class901_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class901_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002FA9 RID: 12201 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400203F RID: 8255
			public int int_0;

			// Token: 0x04002040 RID: 8256
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002041 RID: 8257
			public dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0;

			// Token: 0x04002042 RID: 8258
			public bool bool_0;

			// Token: 0x04002043 RID: 8259
			private dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Class901 class901_0;

			// Token: 0x04002044 RID: 8260
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200079A RID: 1946
		private sealed class Class901
		{
			// Token: 0x06002FAB RID: 12203 RVA: 0x000B6EE8 File Offset: 0x000B50E8
			internal Task method_0()
			{
				dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Class901.Struct558 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class901_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Class901.Struct558>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x04002045 RID: 8261
			public dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0;

			// Token: 0x04002046 RID: 8262
			public bool bool_0;

			// Token: 0x04002047 RID: 8263
			public ObservableCollection<Class512> observableCollection_0;

			// Token: 0x0200079B RID: 1947
			[StructLayout(LayoutKind.Auto)]
			private struct Struct558 : IAsyncStateMachine
			{
				// Token: 0x06002FAC RID: 12204 RVA: 0x000B6F2C File Offset: 0x000B512C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Class901 @class = this.class901_0;
					try
					{
						TaskAwaiter<ObservableCollection<Class512>> awaiter;
						if (num != 0)
						{
							awaiter = Class148.smethod_2(@class.dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0.GetType(), @class.bool_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Class901.Struct558>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
							this.int_0 = -1;
						}
						ObservableCollection<Class512> result = awaiter.GetResult();
						@class.observableCollection_0 = result;
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

				// Token: 0x06002FAD RID: 12205 RVA: 0x0001E5F6 File Offset: 0x0001C7F6
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04002048 RID: 8264
				public int int_0;

				// Token: 0x04002049 RID: 8265
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400204A RID: 8266
				public dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Class901 class901_0;

				// Token: 0x0400204B RID: 8267
				private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
			}
		}

		// Token: 0x0200079C RID: 1948
		[StructLayout(LayoutKind.Auto)]
		private struct Struct559 : IAsyncStateMachine
		{
			// Token: 0x06002FAE RID: 12206 RVA: 0x000B6FF8 File Offset: 0x000B51F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd = this.dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_13(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd.Struct559>(ref awaiter, ref this);
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

			// Token: 0x06002FAF RID: 12207 RVA: 0x0001E604 File Offset: 0x0001C804
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400204C RID: 8268
			public int int_0;

			// Token: 0x0400204D RID: 8269
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400204E RID: 8270
			public dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd_0;

			// Token: 0x0400204F RID: 8271
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
