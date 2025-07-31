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
	// Token: 0x02000822 RID: 2082
	public sealed class dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd : Page, IComponentConnector
	{
		// Token: 0x0600320C RID: 12812 RVA: 0x0001F808 File Offset: 0x0001DA08
		public dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x000C20E0 File Offset: 0x000C02E0
		private void method_0(bool bool_1)
		{
			dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct630 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct630>(ref @struct);
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x0001F81D File Offset: 0x0001DA1D
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			this.method_0(true);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x000C2120 File Offset: 0x000C0320
		public void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct629 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct629>(ref @struct);
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x000C2158 File Offset: 0x000C0358
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct632 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct632>(ref @struct);
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x000C2190 File Offset: 0x000C0390
		public void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct633 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct633>(ref @struct);
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000C21C8 File Offset: 0x000C03C8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/securitypage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000C21FC File Offset: 0x000C03FC
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

		// Token: 0x0400230C RID: 8972
		internal Button button_0;

		// Token: 0x0400230D RID: 8973
		internal Button button_1;

		// Token: 0x0400230E RID: 8974
		internal Button button_2;

		// Token: 0x0400230F RID: 8975
		internal Button button_3;

		// Token: 0x04002310 RID: 8976
		internal CheckBox checkBox_0;

		// Token: 0x04002311 RID: 8977
		private bool bool_0;

		// Token: 0x02000823 RID: 2083
		[StructLayout(LayoutKind.Auto)]
		private struct Struct629 : IAsyncStateMachine
		{
			// Token: 0x06003214 RID: 12820 RVA: 0x000C22CC File Offset: 0x000C04CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd = this.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_11(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct629>(ref awaiter, ref this);
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

			// Token: 0x06003215 RID: 12821 RVA: 0x0001F826 File Offset: 0x0001DA26
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002312 RID: 8978
			public int int_0;

			// Token: 0x04002313 RID: 8979
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002314 RID: 8980
			public dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;

			// Token: 0x04002315 RID: 8981
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000824 RID: 2084
		[StructLayout(LayoutKind.Auto)]
		private struct Struct630 : IAsyncStateMachine
		{
			// Token: 0x06003216 RID: 12822 RVA: 0x000C2384 File Offset: 0x000C0584
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd = this.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class931_0 = new dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Class931();
						this.class931_0.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0 = this.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;
						this.class931_0.bool_0 = this.bool_0;
						dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.button_3.IsEnabled = false;
						dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.DataContext = null;
						this.class931_0.observableCollection_0 = null;
						awaiter = Task.Run(new Func<Task>(this.class931_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct630>(ref awaiter, ref this);
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
					dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.DataContext = this.class931_0.observableCollection_0;
					dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.button_3.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class931_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class931_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003217 RID: 12823 RVA: 0x0001F834 File Offset: 0x0001DA34
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002316 RID: 8982
			public int int_0;

			// Token: 0x04002317 RID: 8983
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002318 RID: 8984
			public dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;

			// Token: 0x04002319 RID: 8985
			public bool bool_0;

			// Token: 0x0400231A RID: 8986
			private dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Class931 class931_0;

			// Token: 0x0400231B RID: 8987
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000825 RID: 2085
		private sealed class Class931
		{
			// Token: 0x06003219 RID: 12825 RVA: 0x000C24C0 File Offset: 0x000C06C0
			internal Task method_0()
			{
				dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Class931.Struct631 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class931_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Class931.Struct631>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x0400231C RID: 8988
			public dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;

			// Token: 0x0400231D RID: 8989
			public bool bool_0;

			// Token: 0x0400231E RID: 8990
			public ObservableCollection<Class512> observableCollection_0;

			// Token: 0x02000826 RID: 2086
			[StructLayout(LayoutKind.Auto)]
			private struct Struct631 : IAsyncStateMachine
			{
				// Token: 0x0600321A RID: 12826 RVA: 0x000C2504 File Offset: 0x000C0704
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Class931 @class = this.class931_0;
					try
					{
						TaskAwaiter<ObservableCollection<Class512>> awaiter;
						if (num != 0)
						{
							awaiter = Class148.smethod_2(@class.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0.GetType(), @class.bool_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Class931.Struct631>(ref awaiter, ref this);
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

				// Token: 0x0600321B RID: 12827 RVA: 0x0001F842 File Offset: 0x0001DA42
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x0400231F RID: 8991
				public int int_0;

				// Token: 0x04002320 RID: 8992
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x04002321 RID: 8993
				public dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Class931 class931_0;

				// Token: 0x04002322 RID: 8994
				private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
			}
		}

		// Token: 0x02000827 RID: 2087
		[StructLayout(LayoutKind.Auto)]
		private struct Struct632 : IAsyncStateMachine
		{
			// Token: 0x0600321C RID: 12828 RVA: 0x000C25D0 File Offset: 0x000C07D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd = this.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_13(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct632>(ref awaiter, ref this);
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

			// Token: 0x0600321D RID: 12829 RVA: 0x0001F850 File Offset: 0x0001DA50
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002323 RID: 8995
			public int int_0;

			// Token: 0x04002324 RID: 8996
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002325 RID: 8997
			public dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;

			// Token: 0x04002326 RID: 8998
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000828 RID: 2088
		[StructLayout(LayoutKind.Auto)]
		private struct Struct633 : IAsyncStateMachine
		{
			// Token: 0x0600321E RID: 12830 RVA: 0x000C2688 File Offset: 0x000C0888
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd = this.dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_12(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd.Struct633>(ref awaiter, ref this);
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

			// Token: 0x0600321F RID: 12831 RVA: 0x0001F85E File Offset: 0x0001DA5E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002327 RID: 8999
			public int int_0;

			// Token: 0x04002328 RID: 9000
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002329 RID: 9001
			public dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd_0;

			// Token: 0x0400232A RID: 9002
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
