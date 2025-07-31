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
	// Token: 0x02000850 RID: 2128
	public sealed class dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd : Page, IComponentConnector
	{
		// Token: 0x060032FA RID: 13050 RVA: 0x00020058 File Offset: 0x0001E258
		public dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x000C5758 File Offset: 0x000C3958
		private void method_0(bool bool_1)
		{
			dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Struct649 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Struct649>(ref @struct);
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x0002006D File Offset: 0x0001E26D
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			this.method_0(true);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000C5798 File Offset: 0x000C3998
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Struct651 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Struct651>(ref @struct);
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x000C57D0 File Offset: 0x000C39D0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/placebopage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x000C5804 File Offset: 0x000C3A04
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
				this.checkBox_0 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040023EE RID: 9198
		internal Button button_0;

		// Token: 0x040023EF RID: 9199
		internal Button button_1;

		// Token: 0x040023F0 RID: 9200
		internal CheckBox checkBox_0;

		// Token: 0x040023F1 RID: 9201
		private bool bool_0;

		// Token: 0x02000851 RID: 2129
		[StructLayout(LayoutKind.Auto)]
		private struct Struct649 : IAsyncStateMachine
		{
			// Token: 0x06003300 RID: 13056 RVA: 0x000C5884 File Offset: 0x000C3A84
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd = this.dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class939_0 = new dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Class939();
						this.class939_0.dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0 = this.dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0;
						this.class939_0.bool_0 = this.bool_0;
						dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.button_1.IsEnabled = false;
						dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.DataContext = null;
						this.class939_0.observableCollection_0 = null;
						awaiter = Task.Run(new Func<Task>(this.class939_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Struct649>(ref awaiter, ref this);
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
					dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.DataContext = this.class939_0.observableCollection_0;
					dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.button_1.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class939_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class939_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003301 RID: 13057 RVA: 0x00020076 File Offset: 0x0001E276
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040023F2 RID: 9202
			public int int_0;

			// Token: 0x040023F3 RID: 9203
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040023F4 RID: 9204
			public dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0;

			// Token: 0x040023F5 RID: 9205
			public bool bool_0;

			// Token: 0x040023F6 RID: 9206
			private dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Class939 class939_0;

			// Token: 0x040023F7 RID: 9207
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000852 RID: 2130
		private sealed class Class939
		{
			// Token: 0x06003303 RID: 13059 RVA: 0x000C59C0 File Offset: 0x000C3BC0
			internal Task method_0()
			{
				dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Class939.Struct650 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class939_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Class939.Struct650>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x040023F8 RID: 9208
			public dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0;

			// Token: 0x040023F9 RID: 9209
			public bool bool_0;

			// Token: 0x040023FA RID: 9210
			public ObservableCollection<Class512> observableCollection_0;

			// Token: 0x02000853 RID: 2131
			[StructLayout(LayoutKind.Auto)]
			private struct Struct650 : IAsyncStateMachine
			{
				// Token: 0x06003304 RID: 13060 RVA: 0x000C5A04 File Offset: 0x000C3C04
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Class939 @class = this.class939_0;
					try
					{
						TaskAwaiter<ObservableCollection<Class512>> awaiter;
						if (num != 0)
						{
							awaiter = Class148.smethod_2(@class.dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0.GetType(), @class.bool_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Class939.Struct650>(ref awaiter, ref this);
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

				// Token: 0x06003305 RID: 13061 RVA: 0x00020084 File Offset: 0x0001E284
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x040023FB RID: 9211
				public int int_0;

				// Token: 0x040023FC RID: 9212
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x040023FD RID: 9213
				public dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Class939 class939_0;

				// Token: 0x040023FE RID: 9214
				private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
			}
		}

		// Token: 0x02000854 RID: 2132
		[StructLayout(LayoutKind.Auto)]
		private struct Struct651 : IAsyncStateMachine
		{
			// Token: 0x06003306 RID: 13062 RVA: 0x000C5AD0 File Offset: 0x000C3CD0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd = this.dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class148.smethod_13(dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.GetType()).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd.Struct651>(ref awaiter, ref this);
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

			// Token: 0x06003307 RID: 13063 RVA: 0x00020092 File Offset: 0x0001E292
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040023FF RID: 9215
			public int int_0;

			// Token: 0x04002400 RID: 9216
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002401 RID: 9217
			public dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd_0;

			// Token: 0x04002402 RID: 9218
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
