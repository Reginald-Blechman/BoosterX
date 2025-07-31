using System;

// Token: 0x02000018 RID: 24
internal sealed class Class60 : Class58
{
	// Token: 0x06000099 RID: 153 RVA: 0x00003513 File Offset: 0x00001713
	public Class60() : base(20)
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0000351D File Offset: 0x0000171D
	public UIntPtr method_3()
	{
		return this.uintptr_0;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00003525 File Offset: 0x00001725
	public void method_4(UIntPtr uintptr_1)
	{
		this.uintptr_0 = uintptr_1;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000352E File Offset: 0x0000172E
	public override Class58 vmethod_3()
	{
		Class60 @class = new Class60();
		@class.method_4(this.uintptr_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0000354D File Offset: 0x0000174D
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000355A File Offset: 0x0000175A
	public override void vmethod_1(object object_0)
	{
		this.method_4((UIntPtr)object_0);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00022FA0 File Offset: 0x000211A0
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		int num = class58_0.method_0();
		if (num != 1)
		{
			if (num != 3)
			{
				switch (num)
				{
				case 7:
					this.method_4((UIntPtr)((Class61)class58_0).method_3());
					return this;
				case 8:
					this.method_4((UIntPtr)((ulong)((Class70)class58_0).method_3()));
					return this;
				case 12:
					this.method_4((UIntPtr)((uint)((Class77)class58_0).method_3()));
					return this;
				case 13:
					this.method_4((UIntPtr)((ulong)((Class69)class58_0).method_3()));
					return this;
				case 14:
					this.method_4((UIntPtr)((Class74)class58_0).method_3());
					return this;
				case 16:
					this.method_4((UIntPtr)((uint)((Class66)class58_0).method_3()));
					return this;
				case 19:
					this.method_4(new UIntPtr(Convert.ToUInt64(((Class73)class58_0).method_3())));
					return this;
				case 20:
					this.method_4(((Class60)class58_0).method_3());
					return this;
				case 22:
					this.method_4((UIntPtr)((ulong)((Class67)class58_0).method_3()));
					return this;
				}
				throw new ArgumentOutOfRangeException();
			}
			this.method_4((UIntPtr)((Class65)class58_0).method_3());
		}
		else
		{
			this.method_4((UIntPtr)((ulong)((long)((Class64)class58_0).method_3())));
		}
		return this;
	}

	// Token: 0x04000039 RID: 57
	private UIntPtr uintptr_0;
}
