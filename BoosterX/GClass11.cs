using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

// Token: 0x0200011F RID: 287
public sealed class GClass11 : GInterface15
{
	// Token: 0x0600085C RID: 2140 RVA: 0x00041114 File Offset: 0x0003F314
	public GClass11(GClass30 gclass30_1 = null)
	{
		this.imethod_5(gclass30_1.smethod_0());
		this.ginterface1_0 = new GClass145(this);
		this.ginterface10_0 = new GClass147(this);
		this.ginterface6_0 = new GClass144(this);
		this.ginterface13_0 = new GClass149(this);
		this.ginterface14_0 = new GClass150(this);
		this.ginterface5_0 = new GClass148(this);
		this.ginterface2_0 = new GClass151(this);
		this.ginterface17_0 = new GClass146(this);
		this.ginterface4_0 = new GClass152(this, false);
		this.ginterface4_1 = new GClass152(this, true);
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00007343 File Offset: 0x00005543
	[CompilerGenerated]
	public string imethod_0()
	{
		return this.string_0;
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x0000734B File Offset: 0x0000554B
	[CompilerGenerated]
	public void imethod_1(string string_3)
	{
		this.string_0 = string_3;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00007354 File Offset: 0x00005554
	public string method_0()
	{
		return this.string_1;
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0000735C File Offset: 0x0000555C
	public void method_1(string string_3)
	{
		this.string_1 = string_3;
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00007365 File Offset: 0x00005565
	[CompilerGenerated]
	public string imethod_2()
	{
		return this.string_2;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x0000736D File Offset: 0x0000556D
	[CompilerGenerated]
	public void imethod_3(string string_3)
	{
		this.string_2 = string_3;
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00007376 File Offset: 0x00005576
	[CompilerGenerated]
	public GClass30 imethod_4()
	{
		return this.gclass30_0;
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x0000737E File Offset: 0x0000557E
	[CompilerGenerated]
	public void imethod_5(GClass30 gclass30_1)
	{
		this.gclass30_0 = gclass30_1;
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00007387 File Offset: 0x00005587
	public IHttpClientFactory method_2()
	{
		return this.ihttpClientFactory_0;
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x0000738F File Offset: 0x0000558F
	public void method_3(IHttpClientFactory ihttpClientFactory_1)
	{
		this.ihttpClientFactory_0 = ihttpClientFactory_1;
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x000411D4 File Offset: 0x0003F3D4
	public static GClass11 smethod_0(string string_3, string string_4, GClass30 gclass30_1)
	{
		GClass11 gclass = new GClass11(gclass30_1);
		gclass.imethod_3("2023-05-15");
		gclass.imethod_1(string.Concat(new string[]
		{
			"https://",
			string_3,
			".openai.azure.com/openai/deployments/",
			string_4,
			"/{1}?api-version={0}"
		}));
		return gclass;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00007398 File Offset: 0x00005598
	[CompilerGenerated]
	public GInterface1 imethod_8()
	{
		return this.ginterface1_0;
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x000073A0 File Offset: 0x000055A0
	[CompilerGenerated]
	public GInterface13 imethod_9()
	{
		return this.ginterface13_0;
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x000073A8 File Offset: 0x000055A8
	[CompilerGenerated]
	public GInterface14 imethod_6()
	{
		return this.ginterface14_0;
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x000073B0 File Offset: 0x000055B0
	[CompilerGenerated]
	public GInterface5 imethod_7()
	{
		return this.ginterface5_0;
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x0600086C RID: 2156 RVA: 0x000073B8 File Offset: 0x000055B8
	public GInterface10 Models
	{
		[CompilerGenerated]
		get
		{
			return this.ginterface10_0;
		}
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x000073C0 File Offset: 0x000055C0
	[CompilerGenerated]
	public GInterface6 imethod_10()
	{
		return this.ginterface6_0;
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x000073C8 File Offset: 0x000055C8
	[CompilerGenerated]
	public GInterface2 imethod_11()
	{
		return this.ginterface2_0;
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x000073D0 File Offset: 0x000055D0
	[CompilerGenerated]
	public GInterface17 imethod_12()
	{
		return this.ginterface17_0;
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x000073D8 File Offset: 0x000055D8
	[CompilerGenerated]
	public GInterface4 imethod_13()
	{
		return this.ginterface4_0;
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x000073E0 File Offset: 0x000055E0
	[CompilerGenerated]
	public GInterface4 imethod_14()
	{
		return this.ginterface4_1;
	}

	// Token: 0x040004B4 RID: 1204
	private string string_0 = "https://api.openai.com/{0}/{1}";

	// Token: 0x040004B5 RID: 1205
	private string string_1 = "https://api.openai-365pro.com/{0}/{1}";

	// Token: 0x040004B6 RID: 1206
	private string string_2 = "v1";

	// Token: 0x040004B7 RID: 1207
	private GClass30 gclass30_0;

	// Token: 0x040004B8 RID: 1208
	private IHttpClientFactory ihttpClientFactory_0;

	// Token: 0x040004B9 RID: 1209
	private readonly GInterface1 ginterface1_0;

	// Token: 0x040004BA RID: 1210
	private readonly GInterface13 ginterface13_0;

	// Token: 0x040004BB RID: 1211
	private readonly GInterface14 ginterface14_0;

	// Token: 0x040004BC RID: 1212
	private readonly GInterface5 ginterface5_0;

	// Token: 0x040004BD RID: 1213
	private readonly GInterface10 ginterface10_0;

	// Token: 0x040004BE RID: 1214
	private readonly GInterface6 ginterface6_0;

	// Token: 0x040004BF RID: 1215
	private readonly GInterface2 ginterface2_0;

	// Token: 0x040004C0 RID: 1216
	private readonly GInterface17 ginterface17_0;

	// Token: 0x040004C1 RID: 1217
	private readonly GInterface4 ginterface4_0;

	// Token: 0x040004C2 RID: 1218
	private readonly GInterface4 ginterface4_1;
}
