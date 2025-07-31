using System;
using System.Reflection;

// Token: 0x02000014 RID: 20
internal sealed class Class59 : Class58
{
	// Token: 0x06000082 RID: 130 RVA: 0x00003402 File Offset: 0x00001602
	public Class59() : base(21)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0000340C File Offset: 0x0000160C
	public MethodBase method_3()
	{
		return this.methodBase_0;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00003414 File Offset: 0x00001614
	public void method_4(MethodBase methodBase_1)
	{
		this.methodBase_0 = methodBase_1;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00022EF4 File Offset: 0x000210F4
	public IntPtr method_5()
	{
		return this.method_3().MethodHandle.GetFunctionPointer();
	}

	// Token: 0x06000086 RID: 134 RVA: 0x0000341D File Offset: 0x0000161D
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00003425 File Offset: 0x00001625
	public override void vmethod_1(object object_0)
	{
		this.method_4((MethodBase)object_0);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00003433 File Offset: 0x00001633
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		if (class58_0.method_0() == 21)
		{
			this.method_4(((Class59)class58_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00003465 File Offset: 0x00001665
	public override Class58 vmethod_3()
	{
		Class59 @class = new Class59();
		@class.method_4(this.methodBase_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x04000034 RID: 52
	private MethodBase methodBase_0;
}
