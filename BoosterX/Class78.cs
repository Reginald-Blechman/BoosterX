using System;

// Token: 0x020000A8 RID: 168
internal sealed class Class78 : Class58
{
	// Token: 0x06000528 RID: 1320 RVA: 0x00005678 File Offset: 0x00003878
	public Class78() : base(9)
	{
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x00005682 File Offset: 0x00003882
	public Array method_3()
	{
		return this.array_0;
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0000568A File Offset: 0x0000388A
	public void method_4(Array array_1)
	{
		this.array_0 = array_1;
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00005693 File Offset: 0x00003893
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0000569B File Offset: 0x0000389B
	public override void vmethod_1(object object_0)
	{
		this.method_4((Array)object_0);
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x000056A9 File Offset: 0x000038A9
	public override Class58 vmethod_3()
	{
		Class78 @class = new Class78();
		@class.method_4(this.array_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00037DA8 File Offset: 0x00035FA8
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		int num = class58_0.method_0();
		if (num != 7)
		{
			if (num != 9)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.method_4(((Class78)class58_0).method_3());
		}
		else
		{
			this.method_4((Array)((Class61)class58_0).method_3());
		}
		return this;
	}

	// Token: 0x040002EB RID: 747
	private Array array_0;
}
