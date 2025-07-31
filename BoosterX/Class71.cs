using System;

// Token: 0x02000070 RID: 112
internal sealed class Class71 : Class58
{
	// Token: 0x060003C8 RID: 968 RVA: 0x00004B5D File Offset: 0x00002D5D
	public Class71() : base(10)
	{
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00004B67 File Offset: 0x00002D67
	public string method_3()
	{
		return this.string_0;
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00004B6F File Offset: 0x00002D6F
	public void method_4(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00004B78 File Offset: 0x00002D78
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00004B80 File Offset: 0x00002D80
	public override void vmethod_1(object object_0)
	{
		this.method_4((string)object_0);
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00034308 File Offset: 0x00032508
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		int num = class58_0.method_0();
		if (num != 7)
		{
			if (num != 10)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.method_4(((Class71)class58_0).method_3());
		}
		else
		{
			this.method_4((string)((Class61)class58_0).method_3());
		}
		return this;
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00004B8E File Offset: 0x00002D8E
	public override Class58 vmethod_3()
	{
		Class71 @class = new Class71();
		@class.method_4(this.string_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x04000287 RID: 647
	private string string_0;
}
