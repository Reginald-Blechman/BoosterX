using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000510 RID: 1296
internal sealed class Class620
{
	// Token: 0x060020C9 RID: 8393 RVA: 0x00015A6F File Offset: 0x00013C6F
	private Class620()
	{
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x00015A8D File Offset: 0x00013C8D
	public static Class620 smethod_0()
	{
		if (Class620.class620_0 == null)
		{
			Class620.class620_0 = new Class620();
		}
		return Class620.class620_0;
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x00083830 File Offset: 0x00081A30
	public void method_0()
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.list_0 = GClass4.smethod_0();
		}
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x00083878 File Offset: 0x00081A78
	public bool method_1(string string_0, bool bool_0)
	{
		Class620.Class622 @class = new Class620.Class622();
		@class.string_0 = string_0;
		if (bool_0)
		{
			return this.list_0.Any(new Func<GClass4.GClass5, bool>(@class.method_0));
		}
		return this.list_0.Any(new Func<GClass4.GClass5, bool>(@class.method_1));
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x000838C4 File Offset: 0x00081AC4
	public bool method_2(string string_0)
	{
		Class620.Class623 @class = new Class620.Class623();
		@class.string_0 = string_0;
		return this.list_0.Any(new Func<GClass4.GClass5, bool>(@class.method_0));
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x000838F8 File Offset: 0x00081AF8
	public bool method_3(string string_0, string string_1, string string_2)
	{
		Class620.Class621 @class = new Class620.Class621();
		@class.string_0 = string_0;
		@class.string_1 = string_1;
		@class.string_2 = string_2;
		return this.list_0.Any(new Func<GClass4.GClass5, bool>(@class.method_0));
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x00015AA5 File Offset: 0x00013CA5
	public List<GClass4.GClass5> method_4()
	{
		this.method_0();
		return this.list_0;
	}

	// Token: 0x040015AF RID: 5551
	private static Class620 class620_0;

	// Token: 0x040015B0 RID: 5552
	private List<GClass4.GClass5> list_0 = new List<GClass4.GClass5>();

	// Token: 0x040015B1 RID: 5553
	private object object_0 = new object();

	// Token: 0x02000511 RID: 1297
	private sealed class Class621
	{
		// Token: 0x060020D1 RID: 8401 RVA: 0x00083938 File Offset: 0x00081B38
		internal bool method_0(GClass4.GClass5 gclass5_0)
		{
			return gclass5_0.Name == this.string_0 && gclass5_0.method_6() == this.string_1 && gclass5_0.method_2().ToLower() == this.string_2.ToLower();
		}

		// Token: 0x040015B2 RID: 5554
		public string string_0;

		// Token: 0x040015B3 RID: 5555
		public string string_1;

		// Token: 0x040015B4 RID: 5556
		public string string_2;
	}

	// Token: 0x02000512 RID: 1298
	private sealed class Class622
	{
		// Token: 0x060020D3 RID: 8403 RVA: 0x00015AB3 File Offset: 0x00013CB3
		internal bool method_0(GClass4.GClass5 gclass5_0)
		{
			return gclass5_0.DisplayName == this.string_0;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00015AC6 File Offset: 0x00013CC6
		internal bool method_1(GClass4.GClass5 gclass5_0)
		{
			return gclass5_0.method_8() == this.string_0;
		}

		// Token: 0x040015B5 RID: 5557
		public string string_0;
	}

	// Token: 0x02000513 RID: 1299
	private sealed class Class623
	{
		// Token: 0x060020D6 RID: 8406 RVA: 0x00083988 File Offset: 0x00081B88
		internal bool method_0(GClass4.GClass5 gclass5_0)
		{
			return gclass5_0.method_8().Split(new char[]
			{
				'_'
			})[0] + "_" + gclass5_0.method_8().Split(new char[]
			{
				'_'
			})[1] == this.string_0;
		}

		// Token: 0x040015B6 RID: 5558
		public string string_0;
	}
}
