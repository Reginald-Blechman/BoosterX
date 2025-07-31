using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007C0 RID: 1984
	public sealed class dje_zD9H5YRWWZ4CW8CBTSV5XFZWZGYMAUUF2CG8QX76AKAKJ5TWK6FC4D9NNZ7QBGYPWR3_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003051 RID: 12369 RVA: 0x0001EBFD File Offset: 0x0001CDFD
		public dje_zD9H5YRWWZ4CW8CBTSV5XFZWZGYMAUUF2CG8QX76AKAKJ5TWK6FC4D9NNZ7QBGYPWR3_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000B9894 File Offset: 0x000B7A94
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/gamemodexucs/gmxaddgameuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x0001EC0B File Offset: 0x0001CE0B
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040020E4 RID: 8420
		private bool bool_0;
	}
}
