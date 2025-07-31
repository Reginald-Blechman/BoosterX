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
	// Token: 0x02000887 RID: 2183
	public sealed class dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd : Page, IComponentConnector
	{
		// Token: 0x060033C5 RID: 13253 RVA: 0x00020659 File Offset: 0x0001E859
		public dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x000C998C File Offset: 0x000C7B8C
		private void method_0(bool bool_1)
		{
			dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct677 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct677>(ref @struct);
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x0002066E File Offset: 0x0001E86E
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			this.method_0(true);
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x000C99CC File Offset: 0x000C7BCC
		public void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct676 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct676>(ref @struct);
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x000C9A04 File Offset: 0x000C7C04
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct679 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct679>(ref @struct);
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x000C9A3C File Offset: 0x000C7C3C
		public void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct680 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct680>(ref @struct);
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x000C9A74 File Offset: 0x000C7C74
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/taskspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x000C9AA8 File Offset: 0x000C7CA8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.rowDefinition_0 = (RowDefinition)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
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
				this.checkBox_0 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040024F4 RID: 9460
		internal RowDefinition rowDefinition_0;

		// Token: 0x040024F5 RID: 9461
		internal Button button_0;

		// Token: 0x040024F6 RID: 9462
		internal Button button_1;

		// Token: 0x040024F7 RID: 9463
		internal Button button_2;

		// Token: 0x040024F8 RID: 9464
		internal Button button_3;

		// Token: 0x040024F9 RID: 9465
		internal CheckBox checkBox_0;

		// Token: 0x040024FA RID: 9466
		private bool bool_0;

		// Token: 0x02000888 RID: 2184
		[StructLayout(LayoutKind.Auto)]
		private struct Struct676 : IAsyncStateMachine
		{
			// Token: 0x060033CD RID: 13261 RVA: 0x000C9B88 File Offset: 0x000C7D88
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd = this.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_11(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct676>(ref awaiter, ref this);
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

			// Token: 0x060033CE RID: 13262 RVA: 0x00020677 File Offset: 0x0001E877
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040024FB RID: 9467
			public int int_0;

			// Token: 0x040024FC RID: 9468
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040024FD RID: 9469
			public dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;

			// Token: 0x040024FE RID: 9470
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000889 RID: 2185
		[StructLayout(LayoutKind.Auto)]
		private struct Struct677 : IAsyncStateMachine
		{
			// Token: 0x060033CF RID: 13263 RVA: 0x000C9C40 File Offset: 0x000C7E40
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd = this.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class944_0 = new dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Class944();
						this.class944_0.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0 = this.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;
						this.class944_0.bool_0 = this.bool_0;
						dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.button_3.IsEnabled = false;
						dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.DataContext = null;
						this.class944_0.observableCollection_0 = null;
						awaiter = Task.Run(new Func<Task>(this.class944_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct677>(ref awaiter, ref this);
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
					dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.DataContext = this.class944_0.observableCollection_0;
					dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.button_3.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class944_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class944_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060033D0 RID: 13264 RVA: 0x00020685 File Offset: 0x0001E885
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040024FF RID: 9471
			public int int_0;

			// Token: 0x04002500 RID: 9472
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002501 RID: 9473
			public dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;

			// Token: 0x04002502 RID: 9474
			public bool bool_0;

			// Token: 0x04002503 RID: 9475
			private dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Class944 class944_0;

			// Token: 0x04002504 RID: 9476
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200088A RID: 2186
		private sealed class Class944
		{
			// Token: 0x060033D2 RID: 13266 RVA: 0x000C9D7C File Offset: 0x000C7F7C
			internal Task method_0()
			{
				dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Class944.Struct678 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class944_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Class944.Struct678>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x04002505 RID: 9477
			public dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;

			// Token: 0x04002506 RID: 9478
			public bool bool_0;

			// Token: 0x04002507 RID: 9479
			public ObservableCollection<Class512> observableCollection_0;

			// Token: 0x0200088B RID: 2187
			[StructLayout(LayoutKind.Auto)]
			private struct Struct678 : IAsyncStateMachine
			{
				// Token: 0x060033D3 RID: 13267 RVA: 0x000C9DC0 File Offset: 0x000C7FC0
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Class944 @class = this.class944_0;
					try
					{
						TaskAwaiter<ObservableCollection<Class512>> awaiter;
						if (num != 0)
						{
							awaiter = Class148.smethod_2(@class.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0.GetType(), @class.bool_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Class944.Struct678>(ref awaiter, ref this);
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

				// Token: 0x060033D4 RID: 13268 RVA: 0x00020693 File Offset: 0x0001E893
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x04002508 RID: 9480
				public int int_0;

				// Token: 0x04002509 RID: 9481
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400250A RID: 9482
				public dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Class944 class944_0;

				// Token: 0x0400250B RID: 9483
				private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
			}
		}

		// Token: 0x0200088C RID: 2188
		[StructLayout(LayoutKind.Auto)]
		private struct Struct679 : IAsyncStateMachine
		{
			// Token: 0x060033D5 RID: 13269 RVA: 0x000C9E8C File Offset: 0x000C808C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd = this.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_13(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct679>(ref awaiter, ref this);
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

			// Token: 0x060033D6 RID: 13270 RVA: 0x000206A1 File Offset: 0x0001E8A1
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400250C RID: 9484
			public int int_0;

			// Token: 0x0400250D RID: 9485
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400250E RID: 9486
			public dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;

			// Token: 0x0400250F RID: 9487
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200088D RID: 2189
		[StructLayout(LayoutKind.Auto)]
		private struct Struct680 : IAsyncStateMachine
		{
			// Token: 0x060033D7 RID: 13271 RVA: 0x000C9F44 File Offset: 0x000C8144
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd = this.dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_12(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd.Struct680>(ref awaiter, ref this);
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

			// Token: 0x060033D8 RID: 13272 RVA: 0x000206AF File Offset: 0x0001E8AF
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002510 RID: 9488
			public int int_0;

			// Token: 0x04002511 RID: 9489
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002512 RID: 9490
			public dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd_0;

			// Token: 0x04002513 RID: 9491
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
