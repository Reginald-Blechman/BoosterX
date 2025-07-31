using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media.Effects;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x02000867 RID: 2151
	public sealed class dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd : dje_zVGT2N9TB7Q62V6YSDV9M2FULS7H9PFYS2XYQUK8NZC65PX2_ejd, IComponentConnector
	{
		// Token: 0x06003349 RID: 13129 RVA: 0x000202BE File Offset: 0x0001E4BE
		public dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x000C7234 File Offset: 0x000C5434
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/customprogressbar/circleuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x000C7268 File Offset: 0x000C5468
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0 = (dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd)target;
				return;
			case 2:
				this.arc_0 = (Arc)target;
				return;
			case 3:
				this.dropShadowEffect_0 = (DropShadowEffect)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x0400244F RID: 9295
		internal dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0;

		// Token: 0x04002450 RID: 9296
		internal Arc arc_0;

		// Token: 0x04002451 RID: 9297
		internal DropShadowEffect dropShadowEffect_0;

		// Token: 0x04002452 RID: 9298
		private bool bool_0;
	}
}
