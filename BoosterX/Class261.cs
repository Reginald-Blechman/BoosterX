using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using ns0;

// Token: 0x0200022B RID: 555
internal sealed class Class261
{
	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06000F26 RID: 3878 RVA: 0x0000B202 File Offset: 0x00009402
	// (set) Token: 0x06000F27 RID: 3879 RVA: 0x0000B20A File Offset: 0x0000940A
	[JsonProperty("D")]
	public DateTime DateTime_0
	{
		get
		{
			return this.dateTime_0;
		}
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000F28 RID: 3880 RVA: 0x0000B213 File Offset: 0x00009413
	// (set) Token: 0x06000F29 RID: 3881 RVA: 0x0000B21B File Offset: 0x0000941B
	[JsonProperty("P")]
	public List<Class265> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x000535CC File Offset: 0x000517CC
	public Class265 method_0(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0, string string_0)
	{
		Class261.Class264 @class = new Class261.Class264();
		@class.dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0 = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0;
		@class.string_0 = string_0;
		return this.List_0.FirstOrDefault(new Func<Class265, bool>(@class.method_0)) ?? null;
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0005360C File Offset: 0x0005180C
	public List<Class265> method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0)
	{
		Class261.Class262 @class = new Class261.Class262();
		@class.dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0 = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0;
		return this.List_0.FindAll(new Predicate<Class265>(@class.method_0)) ?? null;
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00053644 File Offset: 0x00051844
	public bool method_2(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0)
	{
		Class261.Class263 @class = new Class261.Class263();
		@class.dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0 = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0;
		return this.List_0.Any(new Func<Class265, bool>(@class.method_0));
	}

	// Token: 0x040009B1 RID: 2481
	private DateTime dateTime_0;

	// Token: 0x040009B2 RID: 2482
	private List<Class265> list_0 = new List<Class265>();

	// Token: 0x0200022C RID: 556
	private sealed class Class262
	{
		// Token: 0x06000F2E RID: 3886 RVA: 0x0000B224 File Offset: 0x00009424
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Type == this.dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0;
		}

		// Token: 0x040009B3 RID: 2483
		public dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0;
	}

	// Token: 0x0200022D RID: 557
	private sealed class Class263
	{
		// Token: 0x06000F30 RID: 3888 RVA: 0x0000B234 File Offset: 0x00009434
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Type == this.dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0;
		}

		// Token: 0x040009B4 RID: 2484
		public dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0;
	}

	// Token: 0x0200022E RID: 558
	private sealed class Class264
	{
		// Token: 0x06000F32 RID: 3890 RVA: 0x0000B244 File Offset: 0x00009444
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Type == this.dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0 && class265_0.Name == this.string_0;
		}

		// Token: 0x040009B5 RID: 2485
		public dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd_0;

		// Token: 0x040009B6 RID: 2486
		public string string_0;
	}
}
