using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200081F RID: 2079
	public sealed class dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd : Page, IComponentConnector
	{
		// Token: 0x060031FF RID: 12799 RVA: 0x0001F774 File Offset: 0x0001D974
		public dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd_Loaded;
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x0001F794 File Offset: 0x0001D994
		private void dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			if (Class787.bool_1)
			{
				Class787.bool_1 = false;
			}
			base.DataContext = new Class516();
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x0001F7AE File Offset: 0x0001D9AE
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			this.method_0();
			Class784.dictionary_0.Clear();
			Application.Current.Dispatcher.Invoke(new Action(dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd.Class930.class930_0.method_0));
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x000C1F10 File Offset: 0x000C0110
		private void method_0()
		{
			dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd.Struct628 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd.Struct628>(ref @struct);
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000C1F40 File Offset: 0x000C0140
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/backupchoose.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_1(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000C1F74 File Offset: 0x000C0174
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.itemsControl_0 = (ItemsControl)target;
		}

		// Token: 0x04002303 RID: 8963
		internal Button button_0;

		// Token: 0x04002304 RID: 8964
		internal ItemsControl itemsControl_0;

		// Token: 0x04002305 RID: 8965
		private bool bool_0;

		// Token: 0x02000820 RID: 2080
		[StructLayout(LayoutKind.Auto)]
		private struct Struct628 : IAsyncStateMachine
		{
			// Token: 0x06003206 RID: 12806 RVA: 0x000C1FC4 File Offset: 0x000C01C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class144.smethod_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd.Struct628>(ref awaiter, ref this);
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

			// Token: 0x06003207 RID: 12807 RVA: 0x0001F7EE File Offset: 0x0001D9EE
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002306 RID: 8966
			public int int_0;

			// Token: 0x04002307 RID: 8967
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002308 RID: 8968
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000821 RID: 2081
		[Serializable]
		private sealed class Class930
		{
			// Token: 0x0600320A RID: 12810 RVA: 0x000C2070 File Offset: 0x000C0270
			internal void method_0()
			{
				Page page = Class406.smethod_0().list_2.FirstOrDefault(new Func<Page, bool>(dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd.Class930.class930_0.method_1));
				(((page != null) ? page.DataContext : null) as Class495).method_4();
				Class406.smethod_0().method_4(typeof(dje_zNSNRFVQUMVAUHL755A6AUDYMMNJH23EVJCGPYZ2RUJFWZZTMJCPX4_ejd), Class406.smethod_0().frame_0);
			}

			// Token: 0x0600320B RID: 12811 RVA: 0x000148E1 File Offset: 0x00012AE1
			internal bool method_1(Page page_0)
			{
				return page_0.GetType() == typeof(dje_zNSNRFVQUMVAUHL755A6AUDYMMNJH23EVJCGPYZ2RUJFWZZTMJCPX4_ejd);
			}

			// Token: 0x04002309 RID: 8969
			public static readonly dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd.Class930 class930_0 = new dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd.Class930();

			// Token: 0x0400230A RID: 8970
			public static Func<Page, bool> func_0;

			// Token: 0x0400230B RID: 8971
			public static Action action_0;
		}
	}
}
