using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x0200073E RID: 1854
	public sealed class dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd : Border, IComponentConnector
	{
		// Token: 0x06002E30 RID: 11824 RVA: 0x0001D932 File Offset: 0x0001BB32
		public dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000B05AC File Offset: 0x000AE7AC
		private void dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd_0_MouseMove(object sender, MouseEventArgs e)
		{
			Point position = e.GetPosition(this.dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd_0);
			double x = position.X;
			double y = position.Y;
			this.radialGradientBrush_0.GradientOrigin = new Point(x, y);
			this.radialGradientBrush_0.Center = new Point(x, y);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000B05FC File Offset: 0x000AE7FC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/customborderstyle/gradientbackgroundborderstyle.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x000B0630 File Offset: 0x000AE830
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd_0 = (dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd)target;
				this.dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd_0.MouseMove += this.dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd_0_MouseMove;
				return;
			case 2:
				this.radialGradientBrush_0 = (RadialGradientBrush)target;
				return;
			case 3:
				this.gradientStop_0 = (GradientStop)target;
				return;
			case 4:
				this.gradientStop_1 = (GradientStop)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001E88 RID: 7816
		internal dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd dje_z3ZWHU8U3B8TZ4YKPMS7Z6HMSGKKMYLS5FKB5AGBA4GLJXHE5ZL59XFXU3Y7A_ejd_0;

		// Token: 0x04001E89 RID: 7817
		internal RadialGradientBrush radialGradientBrush_0;

		// Token: 0x04001E8A RID: 7818
		internal GradientStop gradientStop_0;

		// Token: 0x04001E8B RID: 7819
		internal GradientStop gradientStop_1;

		// Token: 0x04001E8C RID: 7820
		private bool bool_0;
	}
}
