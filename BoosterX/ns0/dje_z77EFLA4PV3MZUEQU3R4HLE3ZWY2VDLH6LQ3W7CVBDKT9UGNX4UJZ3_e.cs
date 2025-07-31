using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200074A RID: 1866
	public sealed class dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd : Page, IComponentConnector
	{
		// Token: 0x06002E66 RID: 11878 RVA: 0x000B1DA8 File Offset: 0x000AFFA8
		public dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd()
		{
			this.InitializeComponent();
			base.DataContext = (this.class491_0 = new Class491(this));
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x0001DB46 File Offset: 0x0001BD46
		private void textBox_0_GotFocus(object sender, RoutedEventArgs e)
		{
			this.textBox_0.Text = string.Empty;
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x0001DB58 File Offset: 0x0001BD58
		private void textBox_0_LostFocus(object sender, RoutedEventArgs e)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = Class298.smethod_2("SearchAllStore");
			}
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x000B1DD8 File Offset: 0x000AFFD8
		private void textBox_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				textBox.SelectAll();
			}
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x0001DB87 File Offset: 0x0001BD87
		private void textBox_0_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				this.class491_0.SearchCommand.Execute(null);
			}
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000B1DF8 File Offset: 0x000AFFF8
		private void method_0(object sender, RoutedEventArgs e)
		{
			dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd.Struct518 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd.Struct518>(ref @struct);
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000B1E28 File Offset: 0x000B0028
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/storex/storexpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000B1E5C File Offset: 0x000B005C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.KeyUp += this.textBox_0_KeyUp;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				this.textBox_0.MouseLeftButtonUp += this.textBox_0_MouseLeftButtonUp;
				return;
			case 2:
				this.button_0 = (Button)target;
				return;
			case 3:
				this.button_1 = (Button)target;
				return;
			case 4:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 5:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 6:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001ED0 RID: 7888
		private Class491 class491_0;

		// Token: 0x04001ED1 RID: 7889
		internal TextBox textBox_0;

		// Token: 0x04001ED2 RID: 7890
		internal Button button_0;

		// Token: 0x04001ED3 RID: 7891
		internal Button button_1;

		// Token: 0x04001ED4 RID: 7892
		internal ItemsControl itemsControl_0;

		// Token: 0x04001ED5 RID: 7893
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001ED6 RID: 7894
		internal ItemsControl itemsControl_1;

		// Token: 0x04001ED7 RID: 7895
		private bool bool_0;

		// Token: 0x0200074B RID: 1867
		[StructLayout(LayoutKind.Auto)]
		private struct Struct518 : IAsyncStateMachine
		{
			// Token: 0x06002E6E RID: 11886 RVA: 0x000B1F3C File Offset: 0x000B013C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						((dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)Window.GetWindow(Class406.smethod_0().list_2.First(new Func<Page, bool>(dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd.Class881.class881_0.method_0)))).radioButton_1.IsChecked = new bool?(true);
						awaiter = Task.Delay(300).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd.Struct518>(ref awaiter, ref this);
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
					(Class406.smethod_0().list_2.First(new Func<Page, bool>(dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd.Class881.class881_0.method_1)) as dje_z2SW9K68CZJT7BJDWKSPPNMQ44RNJ2KLKFHD9DFWKM3TQCW5SKPUBPRE6E4DQ_ejd).radioButton_6.IsChecked = new bool?(true);
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

			// Token: 0x06002E6F RID: 11887 RVA: 0x0001DBA3 File Offset: 0x0001BDA3
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001ED8 RID: 7896
			public int int_0;

			// Token: 0x04001ED9 RID: 7897
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001EDA RID: 7898
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200074C RID: 1868
		[Serializable]
		private sealed class Class881
		{
			// Token: 0x06002E72 RID: 11890 RVA: 0x0001DBBD File Offset: 0x0001BDBD
			internal bool method_0(Page page_0)
			{
				return page_0.GetType() == typeof(dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd);
			}

			// Token: 0x06002E73 RID: 11891 RVA: 0x0001DBD4 File Offset: 0x0001BDD4
			internal bool method_1(Page page_0)
			{
				return page_0.GetType() == typeof(dje_z2SW9K68CZJT7BJDWKSPPNMQ44RNJ2KLKFHD9DFWKM3TQCW5SKPUBPRE6E4DQ_ejd);
			}

			// Token: 0x04001EDB RID: 7899
			public static readonly dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd.Class881 class881_0 = new dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd.Class881();

			// Token: 0x04001EDC RID: 7900
			public static Func<Page, bool> func_0;

			// Token: 0x04001EDD RID: 7901
			public static Func<Page, bool> func_1;
		}
	}
}
