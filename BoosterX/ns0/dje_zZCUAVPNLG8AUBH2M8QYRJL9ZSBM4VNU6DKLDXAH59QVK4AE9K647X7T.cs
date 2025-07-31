using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Effects;

namespace ns0
{
	// Token: 0x020008F9 RID: 2297
	public sealed class dje_zZCUAVPNLG8AUBH2M8QYRJL9ZSBM4VNU6DKLDXAH59QVK4AE9K647X7TKNRGQ_ejd : Page, IComponentConnector
	{
		// Token: 0x060035D1 RID: 13777 RVA: 0x000D2064 File Offset: 0x000D0264
		public dje_zZCUAVPNLG8AUBH2M8QYRJL9ZSBM4VNU6DKLDXAH59QVK4AE9K647X7TKNRGQ_ejd()
		{
			this.InitializeComponent();
			Class406.smethod_0().frame_1 = this.frame_0;
			if (Class551.class753_0.method_60().GetValueOrDefault())
			{
				Class406.smethod_0().method_4(typeof(dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd), Class406.smethod_0().frame_1);
				return;
			}
			Class406.smethod_0().method_4(typeof(dje_z9DL9HRJ5NJS2KUNGS9G5P7PUH4NWFDYGS7DJ2RQ8TR4A3V748LWUYZQ38EGP4HKRK3_ejd), Class406.smethod_0().frame_1);
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x000D20E0 File Offset: 0x000D02E0
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			if (this.frame_0.Content.GetType() == typeof(dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd) && !Class551.class753_0.method_60().GetValueOrDefault())
			{
				Class406.smethod_0().method_4(typeof(dje_z9DL9HRJ5NJS2KUNGS9G5P7PUH4NWFDYGS7DJ2RQ8TR4A3V748LWUYZQ38EGP4HKRK3_ejd), Class406.smethod_0().frame_1);
				return;
			}
			if (this.frame_0.Content.GetType() == typeof(dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FXAPG9NMXDBFG2XK73CRK7V37GKQKABJZ549PMDY4X_ejd))
			{
				Class406.smethod_0().method_4(typeof(dje_z9DL9HRJ5NJS2KUNGS9G5P7PUH4NWFDYGS7DJ2RQ8TR4A3V748LWUYZQ38EGP4HKRK3_ejd), Class406.smethod_0().frame_1);
				return;
			}
			Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x000D21A0 File Offset: 0x000D03A0
		public void method_0()
		{
			BlurEffect effect = new BlurEffect
			{
				KernelType = KernelType.Gaussian,
				RenderingBias = RenderingBias.Quality,
				Radius = 0.0
			};
			this.grid_0.Effect = effect;
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x000216D0 File Offset: 0x0001F8D0
		public void method_1()
		{
			this.grid_0.Effect = null;
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x000D21DC File Offset: 0x000D03DC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/iltpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x000D2210 File Offset: 0x000D0410
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 3:
				this.frame_0 = (Frame)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002753 RID: 10067
		internal Grid grid_0;

		// Token: 0x04002754 RID: 10068
		internal Button button_0;

		// Token: 0x04002755 RID: 10069
		internal Frame frame_0;

		// Token: 0x04002756 RID: 10070
		private bool bool_0;
	}
}
