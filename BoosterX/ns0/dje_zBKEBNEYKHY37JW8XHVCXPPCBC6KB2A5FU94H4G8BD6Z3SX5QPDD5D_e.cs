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
	// Token: 0x0200079F RID: 1951
	public sealed class dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd : Page, IComponentConnector
	{
		// Token: 0x06002FB6 RID: 12214 RVA: 0x0001E640 File Offset: 0x0001C840
		public dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x000B7118 File Offset: 0x000B5318
		private void method_0(bool bool_1)
		{
			dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct561 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct561>(ref @struct);
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x0001E655 File Offset: 0x0001C855
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			this.method_0(true);
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x000B7158 File Offset: 0x000B5358
		public void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct563 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct563>(ref @struct);
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x000B7190 File Offset: 0x000B5390
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct560 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct560>(ref @struct);
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x000B71C8 File Offset: 0x000B53C8
		public void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct564 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct564>(ref @struct);
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x000B7200 File Offset: 0x000B5400
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/customizationpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x000B7234 File Offset: 0x000B5434
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
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 5:
				this.checkBox_0 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002052 RID: 8274
		internal Button button_0;

		// Token: 0x04002053 RID: 8275
		internal Button button_1;

		// Token: 0x04002054 RID: 8276
		internal Button button_2;

		// Token: 0x04002055 RID: 8277
		internal Button button_3;

		// Token: 0x04002056 RID: 8278
		internal CheckBox checkBox_0;

		// Token: 0x04002057 RID: 8279
		private bool bool_0;

		// Token: 0x020007A0 RID: 1952
		[StructLayout(LayoutKind.Auto)]
		private struct Struct560 : IAsyncStateMachine
		{
			// Token: 0x06002FBE RID: 12222 RVA: 0x000B7304 File Offset: 0x000B5504
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd = this.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_13(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct560>(ref awaiter, ref this);
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

			// Token: 0x06002FBF RID: 12223 RVA: 0x0001E65E File Offset: 0x0001C85E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002058 RID: 8280
			public int int_0;

			// Token: 0x04002059 RID: 8281
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400205A RID: 8282
			public dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;

			// Token: 0x0400205B RID: 8283
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007A1 RID: 1953
		[StructLayout(LayoutKind.Auto)]
		private struct Struct561 : IAsyncStateMachine
		{
			// Token: 0x06002FC0 RID: 12224 RVA: 0x000B73BC File Offset: 0x000B55BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd = this.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class902_0 = new dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Class902();
						this.class902_0.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0 = this.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;
						this.class902_0.bool_0 = this.bool_0;
						dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.button_3.IsEnabled = false;
						dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.DataContext = null;
						this.class902_0.observableCollection_0 = null;
						awaiter = Task.Run(new Func<Task>(this.class902_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct561>(ref awaiter, ref this);
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
					dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.DataContext = this.class902_0.observableCollection_0;
					dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.button_3.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class902_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class902_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002FC1 RID: 12225 RVA: 0x0001E66C File Offset: 0x0001C86C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400205C RID: 8284
			public int int_0;

			// Token: 0x0400205D RID: 8285
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400205E RID: 8286
			public dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;

			// Token: 0x0400205F RID: 8287
			public bool bool_0;

			// Token: 0x04002060 RID: 8288
			private dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Class902 class902_0;

			// Token: 0x04002061 RID: 8289
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007A2 RID: 1954
		private sealed class Class902
		{
			// Token: 0x06002FC3 RID: 12227 RVA: 0x000B74F8 File Offset: 0x000B56F8
			internal Task method_0()
			{
				dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Class902.Struct562 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class902_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Class902.Struct562>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x04002062 RID: 8290
			public dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;

			// Token: 0x04002063 RID: 8291
			public bool bool_0;

			// Token: 0x04002064 RID: 8292
			public ObservableCollection<Class512> observableCollection_0;

			// Token: 0x020007A3 RID: 1955
			[StructLayout(LayoutKind.Auto)]
			private struct Struct562 : IAsyncStateMachine
			{
				// Token: 0x06002FC4 RID: 12228 RVA: 0x000B753C File Offset: 0x000B573C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Class902 @class = this.class902_0;
					try
					{
						TaskAwaiter<ObservableCollection<Class512>> awaiter;
						if (num != 0)
						{
							awaiter = Class148.smethod_2(@class.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0.GetType(), @class.bool_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Class902.Struct562>(ref awaiter, ref this);
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

				// Token: 0x06002FC5 RID: 12229 RVA: 0x0001E67A File Offset: 0x0001C87A
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04002065 RID: 8293
				public int int_0;

				// Token: 0x04002066 RID: 8294
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x04002067 RID: 8295
				public dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Class902 class902_0;

				// Token: 0x04002068 RID: 8296
				private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
			}
		}

		// Token: 0x020007A4 RID: 1956
		[StructLayout(LayoutKind.Auto)]
		private struct Struct563 : IAsyncStateMachine
		{
			// Token: 0x06002FC6 RID: 12230 RVA: 0x000B7608 File Offset: 0x000B5808
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd = this.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_11(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct563>(ref awaiter, ref this);
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

			// Token: 0x06002FC7 RID: 12231 RVA: 0x0001E688 File Offset: 0x0001C888
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002069 RID: 8297
			public int int_0;

			// Token: 0x0400206A RID: 8298
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400206B RID: 8299
			public dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;

			// Token: 0x0400206C RID: 8300
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007A5 RID: 1957
		[StructLayout(LayoutKind.Auto)]
		private struct Struct564 : IAsyncStateMachine
		{
			// Token: 0x06002FC8 RID: 12232 RVA: 0x000B76C0 File Offset: 0x000B58C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd = this.dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_12(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd.Struct564>(ref awaiter, ref this);
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

			// Token: 0x06002FC9 RID: 12233 RVA: 0x0001E696 File Offset: 0x0001C896
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400206D RID: 8301
			public int int_0;

			// Token: 0x0400206E RID: 8302
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400206F RID: 8303
			public dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd_0;

			// Token: 0x04002070 RID: 8304
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
