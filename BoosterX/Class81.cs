using System;
using System.Reflection;

// Token: 0x02000028 RID: 40
internal sealed class Class81 : Class79
{
	// Token: 0x060000EA RID: 234 RVA: 0x0000386A File Offset: 0x00001A6A
	public Class81(FieldInfo fieldInfo_1, object object_1) : this()
	{
		this.method_6(fieldInfo_1);
		this.method_4(object_1);
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00003880 File Offset: 0x00001A80
	public Class81(FieldInfo fieldInfo_1, object object_1, Class79 class79_1) : this(fieldInfo_1, object_1)
	{
		this.method_8(class79_1);
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00003891 File Offset: 0x00001A91
	private Class81() : base(18)
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0000389B File Offset: 0x00001A9B
	public object method_3()
	{
		return this.object_0;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x000038A3 File Offset: 0x00001AA3
	private void method_4(object object_1)
	{
		this.object_0 = object_1;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x000038AC File Offset: 0x00001AAC
	public FieldInfo method_5()
	{
		return this.fieldInfo_0;
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x000038B4 File Offset: 0x00001AB4
	private void method_6(FieldInfo fieldInfo_1)
	{
		this.fieldInfo_0 = fieldInfo_1;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x000038BD File Offset: 0x00001ABD
	public Class79 method_7()
	{
		return this.class79_0;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000038C5 File Offset: 0x00001AC5
	private void method_8(Class79 class79_1)
	{
		this.class79_0 = class79_1;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00024AD0 File Offset: 0x00022CD0
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		if (class58_0.method_0() == 18)
		{
			Class81 @class = (Class81)class58_0;
			this.method_4(@class.method_3());
			this.method_6(@class.method_5());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x000038CE File Offset: 0x00001ACE
	public override Class58 vmethod_3()
	{
		Class81 @class = new Class81();
		@class.method_4(this.method_3());
		@class.method_6(this.method_5());
		@class.method_8(this.method_7());
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0400004E RID: 78
	private object object_0;

	// Token: 0x0400004F RID: 79
	private FieldInfo fieldInfo_0;

	// Token: 0x04000050 RID: 80
	private Class79 class79_0;
}
