using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000794 RID: 1940
	public sealed class dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd : Page, IComponentConnector
	{
		// Token: 0x06002F97 RID: 12183 RVA: 0x0001E52C File Offset: 0x0001C72C
		public dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_Loaded;
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x0001E54C File Offset: 0x0001C74C
		private void dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			base.DataContext = new Class543(this);
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x0001E55A File Offset: 0x0001C75A
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Dispatcher.Invoke(new Action(dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd.Class900.class900_0.method_0));
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x000B6A68 File Offset: 0x000B4C68
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/questionare/questionpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x000B6A9C File Offset: 0x000B4C9C
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
				this.image_0 = (Image)target;
				return;
			case 3:
				this.image_1 = (Image)target;
				return;
			case 4:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 6:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 7:
				this.button_1 = (Button)target;
				return;
			case 8:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 9:
				this.textBlock_4 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002025 RID: 8229
		internal Button button_0;

		// Token: 0x04002026 RID: 8230
		internal Image image_0;

		// Token: 0x04002027 RID: 8231
		internal Image image_1;

		// Token: 0x04002028 RID: 8232
		internal TextBlock textBlock_0;

		// Token: 0x04002029 RID: 8233
		internal TextBlock textBlock_1;

		// Token: 0x0400202A RID: 8234
		internal TextBlock textBlock_2;

		// Token: 0x0400202B RID: 8235
		internal Button button_1;

		// Token: 0x0400202C RID: 8236
		internal TextBlock textBlock_3;

		// Token: 0x0400202D RID: 8237
		internal TextBlock textBlock_4;

		// Token: 0x0400202E RID: 8238
		private bool bool_0;

		// Token: 0x02000795 RID: 1941
		[Serializable]
		private sealed class Class900
		{
			// Token: 0x06002F9E RID: 12190 RVA: 0x0001E596 File Offset: 0x0001C796
			internal void method_0()
			{
				Class144.bool_0 = false;
				Class406.smethod_0().method_4(typeof(dje_z2U4VFJ976E33722KXX6TXFGEZTMUX3T7ZZ6XDCSJNRTXBAQ_ejd), Class406.smethod_0().frame_0);
			}

			// Token: 0x0400202F RID: 8239
			public static readonly dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd.Class900 class900_0 = new dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd.Class900();

			// Token: 0x04002030 RID: 8240
			public static Action action_0;
		}
	}
}
