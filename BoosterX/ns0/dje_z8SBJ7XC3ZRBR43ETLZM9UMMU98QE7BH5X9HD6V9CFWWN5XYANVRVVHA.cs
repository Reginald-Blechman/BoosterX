using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000772 RID: 1906
	public sealed class dje_z8SBJ7XC3ZRBR43ETLZM9UMMU98QE7BH5X9HD6V9CFWWN5XYANVRVVHAQ99JGWTNN5X_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002EFD RID: 12029 RVA: 0x0001DF9D File Offset: 0x0001C19D
		public dje_z8SBJ7XC3ZRBR43ETLZM9UMMU98QE7BH5X9HD6V9CFWWN5XYANVRVVHAQ99JGWTNN5X_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x000B479C File Offset: 0x000B299C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/usercontrols/pinggraph.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x0001DFAB File Offset: 0x0001C1AB
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.dje_zUX97QH34M89HYK965WSZ4_ejd_0 = (dje_zUX97QH34M89HYK965WSZ4_ejd)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04001F8A RID: 8074
		internal dje_zUX97QH34M89HYK965WSZ4_ejd dje_zUX97QH34M89HYK965WSZ4_ejd_0;

		// Token: 0x04001F8B RID: 8075
		private bool bool_0;
	}
}
