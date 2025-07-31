using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008A1 RID: 2209
	public sealed class dje_zVBLU3XA4CS423UGKLQTNX3N9GYKHF2CZ2M59TKKTX6Y2NC3V3FAXE_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003435 RID: 13365 RVA: 0x000208AD File Offset: 0x0001EAAD
		public dje_zVBLU3XA4CS423UGKLQTNX3N9GYKHF2CZ2M59TKKTX6Y2NC3V3FAXE_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x000CC974 File Offset: 0x000CAB74
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/devicepageucs/devicesgroupuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x000CC9A8 File Offset: 0x000CABA8
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
				this.dje_zXNNJLKZGU3XN9MK85ZPHRMHN6QJQ3PZ4M67CWC9PZ9X3X95XSMR63_ejd_0 = (dje_zXNNJLKZGU3XN9MK85ZPHRMHN6QJQ3PZ4M67CWC9PZ9X3X95XSMR63_ejd)target;
				return;
			case 3:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 4:
				this.checkBox_1 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002595 RID: 9621
		internal CheckBox checkBox_0;

		// Token: 0x04002596 RID: 9622
		internal dje_zXNNJLKZGU3XN9MK85ZPHRMHN6QJQ3PZ4M67CWC9PZ9X3X95XSMR63_ejd dje_zXNNJLKZGU3XN9MK85ZPHRMHN6QJQ3PZ4M67CWC9PZ9X3X95XSMR63_ejd_0;

		// Token: 0x04002597 RID: 9623
		internal TextBlock textBlock_0;

		// Token: 0x04002598 RID: 9624
		internal CheckBox checkBox_1;

		// Token: 0x04002599 RID: 9625
		private bool bool_0;
	}
}
