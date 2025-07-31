using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x020007BC RID: 1980
	public sealed class dje_zCZLXJ8BUMUPBA7GD2P6GQUVCQBRKD79BLREV3XRP3MB6V9MPXHVLGS44QKTA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600303D RID: 12349 RVA: 0x0001EB72 File Offset: 0x0001CD72
		public dje_zCZLXJ8BUMUPBA7GD2P6GQUVCQBRKD79BLREV3XRP3MB6V9MPXHVLGS44QKTA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x0001EB80 File Offset: 0x0001CD80
		public void method_0(TimeSpan timeSpan_0, double double_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.arc_0, timeSpan_0, Arc.EndAngleProperty, double_0);
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000B9378 File Offset: 0x000B7578
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/internettest/usercontrols/speedtestuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x0001EB99 File Offset: 0x0001CD99
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.arc_0 = (Arc)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x040020CF RID: 8399
		internal Arc arc_0;

		// Token: 0x040020D0 RID: 8400
		private bool bool_0;
	}
}
