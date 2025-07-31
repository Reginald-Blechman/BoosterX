using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000747 RID: 1863
	public sealed class dje_z5PRQENNBQNA2SXVKJGDE2SCZR2CYLNBS733CGJ72C9WMNDESNRAW8JAU8Z5M3RC25VWD68N4_ejd : Page, IComponentConnector
	{
		// Token: 0x06002E5C RID: 11868 RVA: 0x0001DAB2 File Offset: 0x0001BCB2
		public dje_z5PRQENNBQNA2SXVKJGDE2SCZR2CYLNBS733CGJ72C9WMNDESNRAW8JAU8Z5M3RC25VWD68N4_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new Class485();
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00007C85 File Offset: 0x00005E85
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000B1D0C File Offset: 0x000AFF0C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/usefulcmds/usefulcmdspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x0001DACB File Offset: 0x0001BCCB
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
			this.bool_0 = true;
		}

		// Token: 0x04001ECB RID: 7883
		internal Button button_0;

		// Token: 0x04001ECC RID: 7884
		private bool bool_0;
	}
}
