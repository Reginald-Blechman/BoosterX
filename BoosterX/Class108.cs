using System;

// Token: 0x020000AA RID: 170
internal sealed class Class108
{
	// Token: 0x06000550 RID: 1360 RVA: 0x00005796 File Offset: 0x00003996
	public Class108(string string_1, Class102 class102_1, Class23 class23_1)
	{
		this.string_0 = string_1;
		this.class102_0 = class102_1;
		this.class23_0 = class23_1;
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00038140 File Offset: 0x00036340
	protected override void Finalize()
	{
		try
		{
			object object_ = this.class23_0.object_0;
			lock (object_)
			{
				if (!this.class23_0.bool_1)
				{
					this.class23_0.byte_0 = Class126.smethod_1(this.string_0);
					this.class23_0.bool_1 = true;
					Class126.smethod_3(this.string_0);
				}
			}
		}
		finally
		{
			base.Finalize();
		}
	}

	// Token: 0x040002ED RID: 749
	public readonly string string_0;

	// Token: 0x040002EE RID: 750
	public readonly Class102 class102_0;

	// Token: 0x040002EF RID: 751
	public readonly Class23 class23_0;
}
