using System;

// Token: 0x0200008F RID: 143
internal sealed class Class75 : Class58
{
	// Token: 0x06000485 RID: 1157 RVA: 0x000051D7 File Offset: 0x000033D7
	public Class75() : base(0)
	{
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x000051E0 File Offset: 0x000033E0
	public IntPtr method_3()
	{
		return this.intptr_0;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x000051E8 File Offset: 0x000033E8
	public void method_4(IntPtr intptr_1)
	{
		this.intptr_0 = intptr_1;
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x000051F1 File Offset: 0x000033F1
	public override Class58 vmethod_3()
	{
		Class75 @class = new Class75();
		@class.method_4(this.intptr_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00005210 File Offset: 0x00003410
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x0000521D File Offset: 0x0000341D
	public override void vmethod_1(object object_0)
	{
		this.method_4((IntPtr)object_0);
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00036AF4 File Offset: 0x00034CF4
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		switch (class58_0.method_0())
		{
		case 0:
			this.method_4(((Class75)class58_0).method_3());
			return this;
		case 1:
			this.method_4((IntPtr)((Class64)class58_0).method_3());
			return this;
		case 3:
			this.method_4((IntPtr)((long)((ulong)((Class65)class58_0).method_3())));
			return this;
		case 7:
			this.method_4((IntPtr)((Class61)class58_0).method_3());
			return this;
		case 8:
			this.method_4((IntPtr)((long)((Class70)class58_0).method_3()));
			return this;
		case 12:
			this.method_4((IntPtr)((int)((Class77)class58_0).method_3()));
			return this;
		case 13:
			this.method_4((IntPtr)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4((IntPtr)((long)((Class74)class58_0).method_3()));
			return this;
		case 16:
			this.method_4((IntPtr)((int)((Class66)class58_0).method_3()));
			return this;
		case 17:
			this.method_4((IntPtr)((int)((Class68)class58_0).method_3()));
			return this;
		case 19:
			this.method_4(new IntPtr(Convert.ToInt64(((Class73)class58_0).method_3())));
			return this;
		case 21:
		{
			Class59 @class = (Class59)class58_0;
			this.method_4(@class.method_5());
			return this;
		}
		case 22:
			this.method_4((IntPtr)((long)((Class67)class58_0).method_3()));
			return this;
		case 26:
			this.method_4((IntPtr)((int)((Class76)class58_0).method_3()));
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040002C0 RID: 704
	private IntPtr intptr_0;
}
