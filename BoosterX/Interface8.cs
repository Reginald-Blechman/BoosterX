using System;
using System.Windows;
using Material.Icons;

// Token: 0x02000136 RID: 310
internal interface Interface8
{
	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600090C RID: 2316
	string Name { get; }

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x0600090D RID: 2317
	string NameEng { get; }

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x0600090E RID: 2318
	string SearchInfo { get; }

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x0600090F RID: 2319
	MaterialIconKind Icon { get; }

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000910 RID: 2320
	string Description { get; }

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000911 RID: 2321
	GClass280 RunFix { get; }

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06000912 RID: 2322
	bool Possible { get; }

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06000913 RID: 2323
	// (set) Token: 0x06000914 RID: 2324
	Visibility Visibility { get; set; }
}
