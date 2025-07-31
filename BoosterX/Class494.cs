using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000196 RID: 406
internal sealed class Class494 : GClass162
{
	// Token: 0x06000B85 RID: 2949 RVA: 0x00009041 File Offset: 0x00007241
	public Class494(Class487 class487_1)
	{
		this.class487_0 = class487_1;
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0000907D File Offset: 0x0000727D
	// (set) Token: 0x06000B87 RID: 2951 RVA: 0x00009085 File Offset: 0x00007285
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0000909A File Offset: 0x0000729A
	// (set) Token: 0x06000B89 RID: 2953 RVA: 0x000090A2 File Offset: 0x000072A2
	public string Keys
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			this.method_2();
			base.method_0("Keys");
		}
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x0004A1E4 File Offset: 0x000483E4
	private void method_2()
	{
		if (!this.bool_0 || this.string_2 == Class298.smethod_2("Only2Keys"))
		{
			return;
		}
		if (this.bool_0)
		{
			if (this.string_2.Split(new char[]
			{
				'+'
			}).Any(new Func<string, bool>(Class494.Class200.class200_0.method_0)))
			{
				return;
			}
		}
		if (Class551.class752_0.method_2().smethod_9())
		{
			Class551.class752_0.method_3(this.string_2);
			this.bool_0 = false;
			return;
		}
		if (!Class551.class752_0.method_2().Contains(this.string_2))
		{
			List<string> list = Class551.class752_0.method_2().Split(new char[]
			{
				';'
			}).ToList<string>();
			if (this.string_1 != Class298.smethod_2("Click2Keys") && this.string_1.Split(new char[]
			{
				'+'
			}).Count<string>() == 2 && Class551.class752_0.method_2().Contains(this.string_1))
			{
				list.Remove(this.string_1);
			}
			list.Add(this.Keys);
			Class551.class752_0.method_3(string.Join(";", list));
		}
		this.class487_0.method_2();
		this.bool_0 = false;
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0004A350 File Offset: 0x00048550
	public GClass280 EditCmd
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_3), null));
			}
			return result;
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0004A384 File Offset: 0x00048584
	public GClass280 DeleteCmd
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_4), null));
			}
			return result;
		}
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x0004A3B8 File Offset: 0x000485B8
	private void method_3(object object_0)
	{
		this.string_1 = this.Keys;
		this.Keys = Class298.smethod_2("Click2Keys");
		this.bool_0 = true;
		this.class487_0.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0.class494_0 = this;
		this.class487_0.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0.bool_1 = true;
		this.class487_0.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0.int_0 = 2;
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x000090BD File Offset: 0x000072BD
	private void method_4(object object_0)
	{
		this.class487_0.method_4(this);
	}

	// Token: 0x0400076E RID: 1902
	private Class487 class487_0;

	// Token: 0x0400076F RID: 1903
	public bool bool_0;

	// Token: 0x04000770 RID: 1904
	private string string_0 = Class298.smethod_2("KeyPair");

	// Token: 0x04000771 RID: 1905
	private string string_1 = string.Empty;

	// Token: 0x04000772 RID: 1906
	private string string_2 = Class298.smethod_2("Click2Keys");

	// Token: 0x04000773 RID: 1907
	private GClass280 gclass280_0;

	// Token: 0x04000774 RID: 1908
	private GClass280 gclass280_1;

	// Token: 0x02000197 RID: 407
	[Serializable]
	private sealed class Class200
	{
		// Token: 0x06000B91 RID: 2961 RVA: 0x000090D7 File Offset: 0x000072D7
		internal bool method_0(string string_0)
		{
			return string_0.smethod_9();
		}

		// Token: 0x04000775 RID: 1909
		public static readonly Class494.Class200 class200_0 = new Class494.Class200();

		// Token: 0x04000776 RID: 1910
		public static Func<string, bool> func_0;
	}
}
