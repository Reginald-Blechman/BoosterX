using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200083C RID: 2108
	public sealed class dje_zKEQVN852JL84LRJYUDK45F9AHA9KTSL5RHH8HGEJREFHAGFAPVXWZ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003288 RID: 12936 RVA: 0x0001FBB1 File Offset: 0x0001DDB1
		public dje_zKEQVN852JL84LRJYUDK45F9AHA9KTSL5RHH8HGEJREFHAGFAPVXWZ_ejd()
		{
			this.InitializeComponent();
			base.DataContextChanged += this.dje_zKEQVN852JL84LRJYUDK45F9AHA9KTSL5RHH8HGEJREFHAGFAPVXWZ_ejd_DataContextChanged;
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000C363C File Offset: 0x000C183C
		private void dje_zKEQVN852JL84LRJYUDK45F9AHA9KTSL5RHH8HGEJREFHAGFAPVXWZ_ejd_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			GClass77 gclass = e.NewValue as GClass77;
			if (gclass != null)
			{
				this.gclass77_0 = gclass;
			}
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000C3660 File Offset: 0x000C1860
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicesgroupcontroller/servicesgroupcontroller.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000C3694 File Offset: 0x000C1894
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 2:
				this.grid_0 = (Grid)target;
				return;
			case 3:
				this.checkBox_1 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x0400237B RID: 9083
		private GClass77 gclass77_0;

		// Token: 0x0400237C RID: 9084
		internal CheckBox checkBox_0;

		// Token: 0x0400237D RID: 9085
		internal Grid grid_0;

		// Token: 0x0400237E RID: 9086
		internal CheckBox checkBox_1;

		// Token: 0x0400237F RID: 9087
		private bool bool_0;
	}
}
