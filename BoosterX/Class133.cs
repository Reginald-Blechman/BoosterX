using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Token: 0x020000CA RID: 202
internal sealed class Class133 : IDisposable, Interface1
{
	// Token: 0x06000607 RID: 1543 RVA: 0x0003A468 File Offset: 0x00038668
	public Class133(bool bool_3, Class100 class100_1, bool bool_4 = false)
	{
		this.bool_0 = bool_3;
		this.class100_0 = class100_1;
		this.bool_1 = bool_4;
		this.bool_1 = true;
		int int_ = class100_1.method_1().method_1();
		this.int_0 = Class133.smethod_0(int_, bool_3);
		this.int_1 = Class133.smethod_1(int_, bool_3);
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00005D4B File Offset: 0x00003F4B
	public bool method_0()
	{
		return this.bool_0;
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00005D53 File Offset: 0x00003F53
	[CompilerGenerated]
	public int imethod_0()
	{
		return this.int_0;
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00005D5B File Offset: 0x00003F5B
	[CompilerGenerated]
	public int imethod_1()
	{
		return this.int_1;
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x000034AF File Offset: 0x000016AF
	private static int smethod_0(int int_2, bool bool_3)
	{
		if (!bool_3)
		{
			return (int_2 + 7) / 8;
		}
		return (int_2 - 1) / 8;
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x000034BF File Offset: 0x000016BF
	private static int smethod_1(int int_2, bool bool_3)
	{
		if (!bool_3)
		{
			return (int_2 - 1) / 8;
		}
		return (int_2 + 7) / 8;
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0003A4C8 File Offset: 0x000386C8
	public int imethod_2(byte[] byte_0, int int_2, int int_3, byte[] byte_1, int int_4, RandomNumberGenerator randomNumberGenerator_0)
	{
		this.method_2();
		Class133.Class134 @class = this.class134_0;
		int result;
		try
		{
			result = @class.interface1_0.imethod_2(byte_0, int_2, int_3, byte_1, int_4, randomNumberGenerator_0);
		}
		catch when (endfilter(@class.bool_0 > false))
		{
			this.method_1();
			@class = this.class134_0;
			result = @class.interface1_0.imethod_2(byte_0, int_2, int_3, byte_1, int_4, randomNumberGenerator_0);
		}
		return result;
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x0003A53C File Offset: 0x0003873C
	private void method_1()
	{
		object obj = this.object_0;
		lock (obj)
		{
			Class133.Class134 @class = this.class134_0;
			if (@class.bool_0)
			{
				try
				{
					IDisposable disposable = @class.interface1_0 as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				catch
				{
				}
				Interface1 @interface = this.vmethod_0(this.bool_0, this.class100_0);
				if (@interface == null)
				{
					throw new InvalidOperationException();
				}
				this.class134_0 = new Class133.Class134
				{
					bool_0 = false,
					interface1_0 = @interface
				};
			}
		}
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0003A5E8 File Offset: 0x000387E8
	private void method_2()
	{
		if (this.bool_2)
		{
			return;
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (!this.bool_2)
			{
				Interface1 @interface;
				if (!this.bool_1 && (@interface = this.vmethod_1(this.bool_0, this.class100_0)) != null)
				{
					this.class134_0 = new Class133.Class134
					{
						bool_0 = true,
						interface1_0 = @interface
					};
				}
				else
				{
					@interface = this.vmethod_0(this.bool_0, this.class100_0);
					if (@interface == null)
					{
						throw new InvalidOperationException();
					}
					this.class134_0 = new Class133.Class134
					{
						bool_0 = false,
						interface1_0 = @interface
					};
				}
				this.bool_2 = true;
			}
		}
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00005D63 File Offset: 0x00003F63
	protected Interface1 vmethod_0(bool bool_3, Class100 class100_1)
	{
		return new Class52(bool_3, class100_1);
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00005D6C File Offset: 0x00003F6C
	protected Interface1 vmethod_1(bool bool_3, Class100 class100_1)
	{
		return Class132.smethod_0(bool_3, class100_1);
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x0003A6B0 File Offset: 0x000388B0
	public void Dispose()
	{
		Class133.Class134 @class = this.class134_0;
		IDisposable disposable = ((@class != null) ? @class.interface1_0 : null) as IDisposable;
		if (disposable != null)
		{
			disposable.Dispose();
			this.class134_0 = null;
		}
	}

	// Token: 0x04000337 RID: 823
	private readonly Class100 class100_0;

	// Token: 0x04000338 RID: 824
	private readonly bool bool_0;

	// Token: 0x04000339 RID: 825
	private readonly bool bool_1;

	// Token: 0x0400033A RID: 826
	private readonly int int_0;

	// Token: 0x0400033B RID: 827
	private readonly int int_1;

	// Token: 0x0400033C RID: 828
	private Class133.Class134 class134_0;

	// Token: 0x0400033D RID: 829
	private bool bool_2;

	// Token: 0x0400033E RID: 830
	private readonly object object_0 = new object();

	// Token: 0x020000CB RID: 203
	private sealed class Class134
	{
		// Token: 0x0400033F RID: 831
		public bool bool_0;

		// Token: 0x04000340 RID: 832
		public Interface1 interface1_0;
	}
}
