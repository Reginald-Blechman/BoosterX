using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// Token: 0x02000500 RID: 1280
public sealed class GClass223
{
	// Token: 0x06002093 RID: 8339 RVA: 0x000158B6 File Offset: 0x00013AB6
	public static string smethod_0(uint uint_0)
	{
		return string.Format("0x{0:X8}", uint_0);
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x00082FF4 File Offset: 0x000811F4
	public static uint smethod_1(string string_1)
	{
		uint result = 0U;
		if (string_1.ToLowerInvariant().StartsWith("0x"))
		{
			try
			{
				int num = string_1.IndexOf(' ');
				int length = (num > 2) ? (num - 2) : (string_1.Length - 2);
				return uint.Parse(string_1.Substring(2, length), NumberStyles.AllowHexSpecifier);
			}
			catch
			{
				return result;
			}
		}
		try
		{
			result = uint.Parse(string_1);
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x06002095 RID: 8341 RVA: 0x00083074 File Offset: 0x00081274
	internal static uint smethod_2(GClass112 gclass112_0, string string_1)
	{
		GClass223.Class612 @class = new GClass223.Class612();
		@class.string_0 = string_1;
		GClass277<uint> gclass = gclass112_0.method_18().FirstOrDefault(new Func<GClass277<uint>, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.method_2();
		}
		return GClass223.smethod_1(@class.string_0);
	}

	// Token: 0x06002096 RID: 8342 RVA: 0x000830BC File Offset: 0x000812BC
	internal static string smethod_3(GClass112 gclass112_0, uint uint_0)
	{
		GClass223.Class613 @class = new GClass223.Class613();
		@class.uint_0 = uint_0;
		GClass277<uint> gclass = gclass112_0.method_18().FirstOrDefault(new Func<GClass277<uint>, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.imethod_1();
		}
		return GClass223.smethod_0(@class.uint_0);
	}

	// Token: 0x06002097 RID: 8343 RVA: 0x00083104 File Offset: 0x00081304
	internal static string smethod_4(GClass112 gclass112_0, string string_1)
	{
		GClass223.Class614 @class = new GClass223.Class614();
		@class.string_0 = string_1;
		List<GClass277<string>> list = gclass112_0.method_16();
		GClass277<string> gclass = (list != null) ? list.FirstOrDefault(new Func<GClass277<string>, bool>(@class.method_0)) : null;
		if (gclass != null)
		{
			return gclass.method_2();
		}
		return @class.string_0;
	}

	// Token: 0x06002098 RID: 8344 RVA: 0x00083150 File Offset: 0x00081350
	internal static string smethod_5(GClass112 gclass112_0, string string_1)
	{
		GClass223.Class610 @class = new GClass223.Class610();
		@class.string_0 = string_1;
		GClass277<string> gclass = gclass112_0.method_16().FirstOrDefault(new Func<GClass277<string>, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.imethod_1();
		}
		return @class.string_0;
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x000158C9 File Offset: 0x00013AC9
	public static string smethod_6(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return string.Empty;
		}
		if (byte_0.Length == 8)
		{
			return string.Format("0x{0:X16}", BitConverter.ToUInt64(byte_0, 0));
		}
		return BitConverter.ToString(byte_0);
	}

	// Token: 0x0600209A RID: 8346 RVA: 0x00083194 File Offset: 0x00081394
	internal static string smethod_7(GClass112 gclass112_0, byte[] byte_0)
	{
		GClass223.Class615 @class = new GClass223.Class615();
		@class.byte_0 = byte_0;
		List<GClass277<byte[]>> list = gclass112_0.method_20();
		GClass277<byte[]> gclass = (list != null) ? list.FirstOrDefault(new Func<GClass277<byte[]>, bool>(@class.method_0)) : null;
		if (gclass != null)
		{
			return gclass.imethod_1();
		}
		return GClass223.smethod_6(@class.byte_0);
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x000831E4 File Offset: 0x000813E4
	internal static byte[] smethod_8(GClass112 gclass112_0, string string_1)
	{
		GClass223.Class611 @class = new GClass223.Class611();
		@class.string_0 = string_1;
		GClass277<byte[]> gclass = gclass112_0.method_20().FirstOrDefault(new Func<GClass277<byte[]>, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.method_2();
		}
		return GClass223.smethod_9(@class.string_0);
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x0008322C File Offset: 0x0008142C
	public static byte[] smethod_9(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			return null;
		}
		if (string_1.StartsWith("0x"))
		{
			int num = string_1.IndexOf(' ');
			int length = (num > 2) ? (num - 2) : (string_1.Length - 2);
			return BitConverter.GetBytes(ulong.Parse(string_1.Substring(2, length), NumberStyles.AllowHexSpecifier));
		}
		if (string_1.Contains("-"))
		{
			return Array.ConvertAll<string, byte>(string_1.Split(new char[]
			{
				'-'
			}), new Converter<string, byte>(GClass223.Class616.class616_0.method_0));
		}
		return null;
	}

	// Token: 0x04001596 RID: 5526
	public static string string_0 = "Text";

	// Token: 0x02000501 RID: 1281
	private sealed class Class610
	{
		// Token: 0x0600209E RID: 8350 RVA: 0x000158F8 File Offset: 0x00013AF8
		internal bool method_0(GClass277<string> gclass277_0)
		{
			return gclass277_0.method_2().Equals(this.string_0);
		}

		// Token: 0x04001597 RID: 5527
		public string string_0;
	}

	// Token: 0x02000502 RID: 1282
	private sealed class Class611
	{
		// Token: 0x060020A0 RID: 8352 RVA: 0x0001590B File Offset: 0x00013B0B
		internal bool method_0(GClass277<byte[]> gclass277_0)
		{
			return gclass277_0.imethod_1() != null && gclass277_0.imethod_1().Equals(this.string_0);
		}

		// Token: 0x04001598 RID: 5528
		public string string_0;
	}

	// Token: 0x02000503 RID: 1283
	private sealed class Class612
	{
		// Token: 0x060020A2 RID: 8354 RVA: 0x00015928 File Offset: 0x00013B28
		internal bool method_0(GClass277<uint> gclass277_0)
		{
			return gclass277_0.imethod_1() != null && gclass277_0.imethod_1().Equals(this.string_0);
		}

		// Token: 0x04001599 RID: 5529
		public string string_0;
	}

	// Token: 0x02000504 RID: 1284
	private sealed class Class613
	{
		// Token: 0x060020A4 RID: 8356 RVA: 0x000832CC File Offset: 0x000814CC
		internal bool method_0(GClass277<uint> gclass277_0)
		{
			return gclass277_0.method_2().Equals(this.uint_0);
		}

		// Token: 0x0400159A RID: 5530
		public uint uint_0;
	}

	// Token: 0x02000505 RID: 1285
	private sealed class Class614
	{
		// Token: 0x060020A6 RID: 8358 RVA: 0x00015945 File Offset: 0x00013B45
		internal bool method_0(GClass277<string> gclass277_0)
		{
			return gclass277_0.imethod_1() != null && gclass277_0.imethod_1().Equals(this.string_0);
		}

		// Token: 0x0400159B RID: 5531
		public string string_0;
	}

	// Token: 0x02000506 RID: 1286
	private sealed class Class615
	{
		// Token: 0x060020A8 RID: 8360 RVA: 0x00015962 File Offset: 0x00013B62
		internal bool method_0(GClass277<byte[]> gclass277_0)
		{
			return gclass277_0.method_2().Equals(this.byte_0);
		}

		// Token: 0x0400159C RID: 5532
		public byte[] byte_0;
	}

	// Token: 0x02000507 RID: 1287
	[Serializable]
	private sealed class Class616
	{
		// Token: 0x060020AB RID: 8363 RVA: 0x00015981 File Offset: 0x00013B81
		internal byte method_0(string string_0)
		{
			return Convert.ToByte(string_0, 16);
		}

		// Token: 0x0400159D RID: 5533
		public static readonly GClass223.Class616 class616_0 = new GClass223.Class616();

		// Token: 0x0400159E RID: 5534
		public static Converter<string, byte> converter_0;
	}
}
