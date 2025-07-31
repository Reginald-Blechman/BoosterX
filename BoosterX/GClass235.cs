using System;
using System.Collections.Generic;
using System.Linq;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x0200053D RID: 1341
public sealed class GClass235
{
	// Token: 0x060021EA RID: 8682 RVA: 0x0001641A File Offset: 0x0001461A
	public GClass235()
	{
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x0001642D File Offset: 0x0001462D
	public GClass235(uint uint_2, NVDRS_SETTING_TYPE nvdrs_SETTING_TYPE_1)
	{
		this.uint_0 = uint_2;
		this.nvdrs_SETTING_TYPE_0 = nvdrs_SETTING_TYPE_1;
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x00088220 File Offset: 0x00086420
	public void method_0(uint uint_2, string string_0)
	{
		GClass235.Class640 @class = new GClass235.Class640();
		@class.uint_0 = uint_2;
		GClass231 gclass = this.list_0.FirstOrDefault(new Func<GClass231, bool>(@class.method_0));
		if (gclass == null)
		{
			this.list_0.Add(new GClass231(@class.uint_0, string_0));
		}
		else
		{
			gclass.stringBuilder_0.Append(", " + string_0);
			gclass.uint_1 += 1U;
		}
		this.uint_1 += 1U;
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x000882A4 File Offset: 0x000864A4
	public void method_1(string string_0, string string_1)
	{
		GClass235.Class641 @class = new GClass235.Class641();
		@class.string_0 = string_0;
		GClass231 gclass = this.list_0.FirstOrDefault(new Func<GClass231, bool>(@class.method_0));
		if (gclass == null)
		{
			this.list_0.Add(new GClass231(@class.string_0, string_1));
		}
		else
		{
			gclass.stringBuilder_0.Append(", " + string_1);
			gclass.uint_1 += 1U;
		}
		this.uint_1 += 1U;
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x00088328 File Offset: 0x00086528
	public void method_2(byte[] byte_0, string string_0)
	{
		GClass235.Class642 @class = new GClass235.Class642();
		@class.byte_0 = byte_0;
		GClass231 gclass = this.list_0.FirstOrDefault(new Func<GClass231, bool>(@class.method_0));
		if (gclass == null)
		{
			this.list_0.Add(new GClass231(@class.byte_0, string_0));
		}
		else
		{
			gclass.stringBuilder_0.Append(", " + string_0);
			gclass.uint_1 += 1U;
		}
		this.uint_1 += 1U;
	}

	// Token: 0x040016A3 RID: 5795
	public uint uint_0;

	// Token: 0x040016A4 RID: 5796
	public List<GClass231> list_0 = new List<GClass231>();

	// Token: 0x040016A5 RID: 5797
	public uint uint_1;

	// Token: 0x040016A6 RID: 5798
	public NVDRS_SETTING_TYPE nvdrs_SETTING_TYPE_0;

	// Token: 0x0200053E RID: 1342
	private sealed class Class640
	{
		// Token: 0x060021F0 RID: 8688 RVA: 0x0001644E File Offset: 0x0001464E
		internal bool method_0(GClass231 gclass231_0)
		{
			return gclass231_0.uint_0 == this.uint_0;
		}

		// Token: 0x040016A7 RID: 5799
		public uint uint_0;
	}

	// Token: 0x0200053F RID: 1343
	private sealed class Class641
	{
		// Token: 0x060021F2 RID: 8690 RVA: 0x0001645E File Offset: 0x0001465E
		internal bool method_0(GClass231 gclass231_0)
		{
			return gclass231_0.string_0 == this.string_0;
		}

		// Token: 0x040016A8 RID: 5800
		public string string_0;
	}

	// Token: 0x02000540 RID: 1344
	private sealed class Class642
	{
		// Token: 0x060021F4 RID: 8692 RVA: 0x00016471 File Offset: 0x00014671
		internal bool method_0(GClass231 gclass231_0)
		{
			return Class746.smethod_1(gclass231_0.byte_0, this.byte_0);
		}

		// Token: 0x040016A9 RID: 5801
		public byte[] byte_0;
	}
}
