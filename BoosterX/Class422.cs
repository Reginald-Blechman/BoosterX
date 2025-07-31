using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Material.Icons;

// Token: 0x02000388 RID: 904
internal sealed class Class422
{
	// Token: 0x06001787 RID: 6023 RVA: 0x0006B5FC File Offset: 0x000697FC
	public static List<Class422.Class511> smethod_0()
	{
		List<Class422.Class511> list = new List<Class422.Class511>();
		Class422.Class511 @class = new Class422.Class511();
		@class.Name = "Panorama";
		@class.Icon = 5111;
		@class.Checker = new Func<bool>(Class422.Class423.class423_0.method_0);
		@class.Unchecked = new Action(Class422.Class423.class423_0.method_1);
		@class.Checked = new Action(Class422.Class423.class423_0.method_2);
		list.Add(@class);
		return list;
	}

	// Token: 0x02000389 RID: 905
	public sealed class Class511 : GClass162
	{
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x000101AA File Offset: 0x0000E3AA
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x000101B2 File Offset: 0x0000E3B2
		public string _Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x000101BB File Offset: 0x0000E3BB
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x000101C8 File Offset: 0x0000E3C8
		public string Name
		{
			get
			{
				return Class298.smethod_2(this._Name);
			}
			set
			{
				this._Name = value;
				base.method_0("Name");
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x000101DD File Offset: 0x0000E3DD
		public string Description
		{
			get
			{
				return Class298.smethod_2(this._Name + "Desc");
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x000101F5 File Offset: 0x0000E3F5
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x000101FD File Offset: 0x0000E3FD
		public bool _IsChecked
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				this.bool_1 = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x00010206 File Offset: 0x0000E406
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x0001020E File Offset: 0x0000E40E
		public bool IsChecked
		{
			get
			{
				return this._IsChecked;
			}
			set
			{
				this._IsChecked = value;
				base.method_0("IsChecked");
				if (this.bool_0)
				{
					this.bool_0 = false;
					return;
				}
				if (value)
				{
					this.Checked();
					return;
				}
				this.Unchecked();
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x0001024D File Offset: 0x0000E44D
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x00010255 File Offset: 0x0000E455
		public Action Checked
		{
			[CompilerGenerated]
			get
			{
				return this.action_0;
			}
			[CompilerGenerated]
			set
			{
				this.action_0 = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x0001025E File Offset: 0x0000E45E
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x00010266 File Offset: 0x0000E466
		public Action Unchecked
		{
			[CompilerGenerated]
			get
			{
				return this.action_1;
			}
			[CompilerGenerated]
			set
			{
				this.action_1 = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x0001026F File Offset: 0x0000E46F
		public Func<bool> Checker
		{
			set
			{
				this.method_2(value);
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00010278 File Offset: 0x0000E478
		public void method_2(Func<bool> func_0)
		{
			this.IsChecked = !func_0();
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00010289 File Offset: 0x0000E489
		private MaterialIconKind method_3()
		{
			return this.materialIconKind_0;
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00010291 File Offset: 0x0000E491
		private void method_4(MaterialIconKind materialIconKind_1)
		{
			this.materialIconKind_0 = materialIconKind_1;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x0001029A File Offset: 0x0000E49A
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x000102A2 File Offset: 0x0000E4A2
		public MaterialIconKind Icon
		{
			get
			{
				return this.method_3();
			}
			set
			{
				this.method_4(value);
				base.method_0("Icon");
			}
		}

		// Token: 0x04000F85 RID: 3973
		private string string_0;

		// Token: 0x04000F86 RID: 3974
		public bool bool_0 = true;

		// Token: 0x04000F87 RID: 3975
		private bool bool_1;

		// Token: 0x04000F88 RID: 3976
		private Action action_0;

		// Token: 0x04000F89 RID: 3977
		private Action action_1;

		// Token: 0x04000F8A RID: 3978
		private MaterialIconKind materialIconKind_0;
	}

	// Token: 0x0200038A RID: 906
	[Serializable]
	private sealed class Class423
	{
		// Token: 0x0600179E RID: 6046 RVA: 0x000102C3 File Offset: 0x0000E4C3
		internal bool method_0()
		{
			return Directory.Exists(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama\\fonts") && Directory.Exists(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama\\videos");
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0006B6A0 File Offset: 0x000698A0
		internal void method_1()
		{
			try
			{
				Class765.smethod_1(Class765.smethod_3(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama", "fonts"), "fonts");
				Class765.smethod_1(Class765.smethod_3(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama", "videos"), "videos");
			}
			catch
			{
			}
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0006B718 File Offset: 0x00069918
		internal void method_2()
		{
			try
			{
				foreach (GClass177 gclass177_ in new GClass190().Profiles)
				{
					new GClass196(gclass177_)
					{
						Param = "-novid"
					}.method_2();
				}
			}
			catch
			{
			}
			try
			{
				Class765.smethod_1(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama\\fonts", "fonts_");
				Class765.smethod_1(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama\\videos", "videos_");
			}
			catch
			{
				try
				{
					Directory.Delete(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama\\fonts_", true);
				}
				catch
				{
				}
				try
				{
					Directory.Delete(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama\\videos_", true);
				}
				catch
				{
				}
				try
				{
					Class765.smethod_1(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama\\fonts", "fonts_");
					Class765.smethod_1(GClass22.smethod_0().method_3() + "\\game\\csgo\\panorama\\videos", "videos_");
				}
				catch
				{
				}
			}
		}

		// Token: 0x04000F8B RID: 3979
		public static readonly Class422.Class423 class423_0 = new Class422.Class423();

		// Token: 0x04000F8C RID: 3980
		public static Func<bool> func_0;

		// Token: 0x04000F8D RID: 3981
		public static Action action_0;

		// Token: 0x04000F8E RID: 3982
		public static Action action_1;
	}
}
