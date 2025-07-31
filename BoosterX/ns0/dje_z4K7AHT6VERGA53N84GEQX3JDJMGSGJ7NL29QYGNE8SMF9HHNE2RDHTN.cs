using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ns0
{
	// Token: 0x0200073F RID: 1855
	public sealed class dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002E34 RID: 11828 RVA: 0x0001D940 File Offset: 0x0001BB40
		public dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd_Loaded;
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x0001D96D File Offset: 0x0001BB6D
		// (set) Token: 0x06002E37 RID: 11831 RVA: 0x0001D97F File Offset: 0x0001BB7F
		public double PercentLevel
		{
			get
			{
				return (double)base.GetValue(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.dependencyProperty_0);
			}
			set
			{
				base.SetValue(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.dependencyProperty_0, value);
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x0001D992 File Offset: 0x0001BB92
		// (set) Token: 0x06002E39 RID: 11833 RVA: 0x0001D9A4 File Offset: 0x0001BBA4
		public string LevelName
		{
			get
			{
				return (string)base.GetValue(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.dependencyProperty_1);
			}
			set
			{
				base.SetValue(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.dependencyProperty_1, value);
			}
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x0001D9B2 File Offset: 0x0001BBB2
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			((dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd)dependencyObject_0).method_1((double)dependencyPropertyChangedEventArgs_0.NewValue);
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x0001D9CB File Offset: 0x0001BBCB
		private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			((dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd)dependencyObject_0).method_0((string)dependencyPropertyChangedEventArgs_0.NewValue);
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x000B073C File Offset: 0x000AE93C
		private void method_0(string string_0)
		{
			try
			{
				this.textBlock_0.Text = Class298.smethod_2(string_0);
				this.image_0.ToolTip = Class298.smethod_2(string_0 + "Desc");
			}
			catch
			{
				this.textBlock_0.Text = "Loading";
				this.image_0.ToolTip = string.Empty;
			}
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x000B07AC File Offset: 0x000AE9AC
		private void method_1(double double_0)
		{
			dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd_0 = this;
			@struct.double_0 = double_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref @struct);
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x000B07EC File Offset: 0x000AE9EC
		private void method_2(UIElement uielement_0, UIElement uielement_1, TimeSpan timeSpan_0, Color color_0, double double_0)
		{
			dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct516 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd_0 = this;
			@struct.uielement_0 = uielement_0;
			@struct.uielement_1 = uielement_1;
			@struct.timeSpan_0 = timeSpan_0;
			@struct.color_0 = color_0;
			@struct.double_0 = double_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct516>(ref @struct);
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000B0850 File Offset: 0x000AEA50
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/firstanalyze/pages/famain/usercontrols/coolleveluc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x000B0884 File Offset: 0x000AEA84
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
				this.textBlock_0 = (TextBlock)target;
				return;
			case 3:
				this.image_0 = (Image)target;
				return;
			case 4:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 5:
				this.border_0 = (Border)target;
				return;
			case 6:
				this.border_1 = (Border)target;
				return;
			case 7:
				this.border_2 = (Border)target;
				return;
			case 8:
				this.border_3 = (Border)target;
				return;
			case 9:
				this.border_4 = (Border)target;
				return;
			case 10:
				this.border_5 = (Border)target;
				return;
			case 11:
				this.textBlock_2 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x0001D9E4 File Offset: 0x0001BBE4
		private void dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			this.method_0(this.LevelName);
		}

		// Token: 0x04001E8D RID: 7821
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("PercentLevel", typeof(double), typeof(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.smethod_0)));

		// Token: 0x04001E8E RID: 7822
		public static readonly DependencyProperty dependencyProperty_1 = DependencyProperty.Register("LevelName", typeof(string), typeof(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.smethod_1)));

		// Token: 0x04001E8F RID: 7823
		private readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

		// Token: 0x04001E90 RID: 7824
		internal Grid grid_0;

		// Token: 0x04001E91 RID: 7825
		internal TextBlock textBlock_0;

		// Token: 0x04001E92 RID: 7826
		internal Image image_0;

		// Token: 0x04001E93 RID: 7827
		internal TextBlock textBlock_1;

		// Token: 0x04001E94 RID: 7828
		internal Border border_0;

		// Token: 0x04001E95 RID: 7829
		internal Border border_1;

		// Token: 0x04001E96 RID: 7830
		internal Border border_2;

		// Token: 0x04001E97 RID: 7831
		internal Border border_3;

		// Token: 0x04001E98 RID: 7832
		internal Border border_4;

		// Token: 0x04001E99 RID: 7833
		internal Border border_5;

		// Token: 0x04001E9A RID: 7834
		internal TextBlock textBlock_2;

		// Token: 0x04001E9B RID: 7835
		private bool bool_0;

		// Token: 0x02000740 RID: 1856
		[StructLayout(LayoutKind.Auto)]
		private struct Struct515 : IAsyncStateMachine
		{
			// Token: 0x06002E42 RID: 11842 RVA: 0x000B095C File Offset: 0x000AEB5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd = this.dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						break;
					}
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
						IL_AA:
						try
						{
							try
							{
								switch (num)
								{
								case 1:
									awaiter = this.taskAwaiter_0;
									this.taskAwaiter_0 = default(TaskAwaiter);
									this.int_0 = -1;
									break;
								case 2:
									awaiter = this.taskAwaiter_0;
									this.taskAwaiter_0 = default(TaskAwaiter);
									this.int_0 = -1;
									goto IL_2AF;
								case 3:
									awaiter = this.taskAwaiter_0;
									this.taskAwaiter_0 = default(TaskAwaiter);
									this.int_0 = -1;
									goto IL_401;
								case 4:
									awaiter = this.taskAwaiter_0;
									this.taskAwaiter_0 = default(TaskAwaiter);
									this.int_0 = -1;
									goto IL_48E;
								case 5:
									awaiter = this.taskAwaiter_0;
									this.taskAwaiter_0 = default(TaskAwaiter);
									this.int_0 = -1;
									goto IL_4E4;
								case 6:
									awaiter = this.taskAwaiter_0;
									this.taskAwaiter_0 = default(TaskAwaiter);
									this.int_0 = -1;
									goto IL_571;
								case 7:
									awaiter = this.taskAwaiter_0;
									this.taskAwaiter_0 = default(TaskAwaiter);
									this.int_0 = -1;
									goto IL_5FE;
								case 8:
									awaiter = this.taskAwaiter_0;
									this.taskAwaiter_0 = default(TaskAwaiter);
									this.int_0 = -1;
									goto IL_68B;
								default:
									dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_37(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.textBlock_1, this.double_0);
									dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_1, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_0, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd, 8.0);
									dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_3, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_2, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd, 8.0);
									dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_5, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_4, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd, 8.0);
									awaiter = Task.Delay(400).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										this.int_0 = 1;
										this.taskAwaiter_0 = awaiter;
										this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
										return;
									}
									break;
								}
								awaiter.GetResult();
								dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_1, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_0, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd, 5.0);
								dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_3, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_2, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd, 5.0);
								dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_5, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_4, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd, 5.0);
								awaiter = Task.Delay(400).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 2;
									this.taskAwaiter_0 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
									return;
								}
								IL_2AF:
								awaiter.GetResult();
								if (this.double_0 < 40.0)
								{
									dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_1, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_0, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zKUGX8VZG8GQJ6GA_ejd, 8.0);
									goto IL_6C0;
								}
								if (this.double_0 < 80.0)
								{
									dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_1, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_0, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zKUGX8VZG8GQJ6GA_ejd, 8.0);
									awaiter = Task.Delay(400).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										this.int_0 = 3;
										this.taskAwaiter_0 = awaiter;
										this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
										return;
									}
								}
								else
								{
									dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_1, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_0, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zKUGX8VZG8GQJ6GA_ejd, 8.0);
									awaiter = Task.Delay(400).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										this.int_0 = 5;
										this.taskAwaiter_0 = awaiter;
										this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
										return;
									}
									goto IL_4E4;
								}
								IL_401:
								awaiter.GetResult();
								dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_1, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_0, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd, 5.0);
								awaiter = Task.Delay(400).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 4;
									this.taskAwaiter_0 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
									return;
								}
								IL_48E:
								awaiter.GetResult();
								dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_3, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_2, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zH2C6P3HHD4TV29CYHNS73_ejd, 8.0);
								goto IL_6C0;
								IL_4E4:
								awaiter.GetResult();
								dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_1, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_0, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd, 5.0);
								awaiter = Task.Delay(400).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 6;
									this.taskAwaiter_0 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
									return;
								}
								IL_571:
								awaiter.GetResult();
								dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_3, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_2, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zH2C6P3HHD4TV29CYHNS73_ejd, 8.0);
								awaiter = Task.Delay(400).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 7;
									this.taskAwaiter_0 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
									return;
								}
								IL_5FE:
								awaiter.GetResult();
								dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_3, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_2, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd, 5.0);
								awaiter = Task.Delay(400).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 8;
									this.taskAwaiter_0 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
									return;
								}
								IL_68B:
								awaiter.GetResult();
								dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.method_2(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_5, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.border_4, TimeSpan.FromSeconds(0.3), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRFTDSNNMSNMN6WA_ejd, 8.0);
								IL_6C0:
								dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_36(dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.textBlock_2, this.double_0);
							}
							catch
							{
							}
						}
						catch (object obj)
						{
							this.object_0 = obj;
						}
						awaiter = Task.Delay(400).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 9;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
							return;
						}
						goto IL_73C;
					case 9:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_73C;
					default:
						awaiter = dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.semaphoreSlim_0.WaitAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct515>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					this.object_0 = null;
					this.int_1 = 0;
					goto IL_AA;
					IL_73C:
					awaiter.GetResult();
					dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.semaphoreSlim_0.Release();
					object obj = this.object_0;
					if (obj != null)
					{
						Exception ex = obj as Exception;
						if (ex == null)
						{
							throw obj;
						}
						ExceptionDispatchInfo.Capture(ex).Throw();
					}
					this.object_0 = null;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002E43 RID: 11843 RVA: 0x0001D9F2 File Offset: 0x0001BBF2
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001E9C RID: 7836
			public int int_0;

			// Token: 0x04001E9D RID: 7837
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001E9E RID: 7838
			public dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd_0;

			// Token: 0x04001E9F RID: 7839
			public double double_0;

			// Token: 0x04001EA0 RID: 7840
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04001EA1 RID: 7841
			private object object_0;

			// Token: 0x04001EA2 RID: 7842
			private int int_1;
		}

		// Token: 0x02000741 RID: 1857
		[StructLayout(LayoutKind.Auto)]
		private struct Struct516 : IAsyncStateMachine
		{
			// Token: 0x06002E44 RID: 11844 RVA: 0x000B1158 File Offset: 0x000AF358
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd = this.dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_260;
					}
					DoubleAnimation animation = new DoubleAnimation
					{
						To = new double?(this.double_0),
						Duration = this.timeSpan_0,
						EasingFunction = new QuadraticEase
						{
							EasingMode = EasingMode.EaseOut
						}
					};
					this.uielement_0.BeginAnimation(FrameworkElement.HeightProperty, animation);
					DoubleAnimation doubleAnimation = new DoubleAnimation
					{
						To = new double?((double)1f),
						Duration = this.timeSpan_0,
						EasingFunction = new QuadraticEase
						{
							EasingMode = EasingMode.EaseOut
						}
					};
					if (this.color_0 == dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd)
					{
						((Storyboard)dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.FindResource("AnimateLevelBackgroundInactive")).Begin(this.uielement_0 as Border);
						doubleAnimation.To = new double?(0.0);
					}
					else if (this.color_0 == dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zKUGX8VZG8GQJ6GA_ejd)
					{
						((Storyboard)dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.FindResource("AnimateLevelBackgroundRed")).Begin(this.uielement_0 as Border);
					}
					else if (this.color_0 == dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zH2C6P3HHD4TV29CYHNS73_ejd)
					{
						((Storyboard)dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.FindResource("AnimateLevelBackgroundYellow")).Begin(this.uielement_0 as Border);
					}
					else
					{
						((Storyboard)dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.FindResource("AnimateLevelBackgroundMain")).Begin(this.uielement_0 as Border);
					}
					this.uielement_1.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
					this.border_0 = (this.uielement_0 as Border);
					this.double_1 = this.border_0.CornerRadius.TopLeft;
					this.stopwatch_0 = Stopwatch.StartNew();
					IL_1DB:
					if (!(this.stopwatch_0.Elapsed < this.timeSpan_0))
					{
						this.border_0.CornerRadius = new CornerRadius(this.double_0 / 2.0);
						goto IL_2D5;
					}
					double num2 = this.stopwatch_0.Elapsed.TotalMilliseconds / this.timeSpan_0.TotalMilliseconds;
					double uniformRadius = this.double_1 + (this.double_0 / 2.0 - this.double_1) * num2;
					this.border_0.CornerRadius = new CornerRadius(uniformRadius);
					awaiter = Task.Delay(16).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd.Struct516>(ref awaiter, ref this);
						return;
					}
					IL_260:
					awaiter.GetResult();
					goto IL_1DB;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.border_0 = null;
					this.stopwatch_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_2D5:
				this.int_0 = -2;
				this.border_0 = null;
				this.stopwatch_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002E45 RID: 11845 RVA: 0x0001DA00 File Offset: 0x0001BC00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001EA3 RID: 7843
			public int int_0;

			// Token: 0x04001EA4 RID: 7844
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001EA5 RID: 7845
			public double double_0;

			// Token: 0x04001EA6 RID: 7846
			public TimeSpan timeSpan_0;

			// Token: 0x04001EA7 RID: 7847
			public UIElement uielement_0;

			// Token: 0x04001EA8 RID: 7848
			public Color color_0;

			// Token: 0x04001EA9 RID: 7849
			public dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd dje_z4K7AHT6VERGA53N84GEQX3JDJMGSGJ7NL29QYGNE8SMF9HHNE2RDHTN6XQ6VJ5VQTYQWK47YQX3B44Z_ejd_0;

			// Token: 0x04001EAA RID: 7850
			public UIElement uielement_1;

			// Token: 0x04001EAB RID: 7851
			private Border border_0;

			// Token: 0x04001EAC RID: 7852
			private double double_1;

			// Token: 0x04001EAD RID: 7853
			private Stopwatch stopwatch_0;

			// Token: 0x04001EAE RID: 7854
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
