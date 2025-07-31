using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x020000D4 RID: 212
internal sealed class Class139
{
	// Token: 0x06000690 RID: 1680 RVA: 0x000061B5 File Offset: 0x000043B5
	public Class139()
	{
		Class139.smethod_0(ref this.struct9_0, ref this.struct9_1);
		base..ctor();
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000691 RID: 1681 RVA: 0x0003AEAC File Offset: 0x000390AC
	// (set) Token: 0x06000692 RID: 1682 RVA: 0x0003AEE4 File Offset: 0x000390E4
	public TimeSpan ExpiryLeft
	{
		[CompilerGenerated]
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (TimeSpan)Class392.smethod_3().method_105(Class392.smethod_1(), "$+.+IZa-ih", object_);
		}
		[CompilerGenerated]
		set
		{
			object[] object_ = new object[]
			{
				this,
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "9!l\"5Za-ih", object_);
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000693 RID: 1683 RVA: 0x0003AF1C File Offset: 0x0003911C
	// (set) Token: 0x06000694 RID: 1684 RVA: 0x0003AF50 File Offset: 0x00039150
	public string DiscordNick
	{
		[CompilerGenerated]
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "ca:*eZa-ii", object_);
		}
		[CompilerGenerated]
		set
		{
			object[] object_ = new object[]
			{
				this,
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "\\?rZNZa-ij", object_);
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000695 RID: 1685 RVA: 0x0003AF84 File Offset: 0x00039184
	// (set) Token: 0x06000696 RID: 1686 RVA: 0x0003AFB8 File Offset: 0x000391B8
	public string Key
	{
		[CompilerGenerated]
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "@'m>KZa-ii", object_);
		}
		[CompilerGenerated]
		set
		{
			object[] object_ = new object[]
			{
				this,
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "e$QNiZa-ij", object_);
		}
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x0003AFEC File Offset: 0x000391EC
	private static void smethod_0(ref Struct9 struct9_2, ref Struct9 struct9_3)
	{
		object[] array = new object[]
		{
			struct9_2,
			struct9_3
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "OgMO'Za-ih", array);
		}
		finally
		{
			struct9_2 = (Struct9)array[0];
			struct9_3 = (Struct9)array[1];
		}
	}

	// Token: 0x04000380 RID: 896
	private Struct16 struct16_0;

	// Token: 0x04000381 RID: 897
	private Struct9 struct9_0;

	// Token: 0x04000382 RID: 898
	private Struct9 struct9_1;
}
