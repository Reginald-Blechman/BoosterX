using System;
using System.Security.Cryptography;

// Token: 0x0200003A RID: 58
internal sealed class Class27 : SymmetricAlgorithm
{
	// Token: 0x0600015A RID: 346 RVA: 0x0002584C File Offset: 0x00023A4C
	public Class27()
	{
		this.LegalBlockSizesValue = new KeySizes[]
		{
			new KeySizes(32, 32, 0)
		};
		this.LegalKeySizesValue = new KeySizes[]
		{
			new KeySizes(80, 80, 0)
		};
		this.BlockSizeValue = 32;
		this.KeySizeValue = 80;
		this.ModeValue = CipherMode.ECB;
		this.PaddingValue = PaddingMode.None;
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00003C2E File Offset: 0x00001E2E
	public Class27(byte[] byte_1) : this()
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		this.Key = byte_1;
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00003C63 File Offset: 0x00001E63
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return new Class27.Class28(rgbKey, false);
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00003C6C File Offset: 0x00001E6C
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return new Class27.Class28(rgbKey, true);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00003C75 File Offset: 0x00001E75
	public override void GenerateIV()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00003C75 File Offset: 0x00001E75
	public override void GenerateKey()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06000161 RID: 353 RVA: 0x000258B0 File Offset: 0x00023AB0
	private static ushort smethod_0(byte[] byte_1, int int_0, ushort ushort_0)
	{
		byte b = (byte)(ushort_0 >> 8);
		byte b2 = (byte)ushort_0;
		byte b3 = Class27.byte_0[(int)(b2 ^ byte_1[4 * int_0 % 10])] ^ b;
		byte b4 = Class27.byte_0[(int)(b3 ^ byte_1[(4 * int_0 + 1) % 10])] ^ b2;
		byte b5 = Class27.byte_0[(int)(b4 ^ byte_1[(4 * int_0 + 2) % 10])] ^ b3;
		byte b6 = Class27.byte_0[(int)(b5 ^ byte_1[(4 * int_0 + 3) % 10])] ^ b4;
		return (ushort)(((int)b5 << 8) + (int)b6);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00025928 File Offset: 0x00023B28
	private static void smethod_1(byte[] byte_1, byte[] byte_2, int int_0, byte[] byte_3, int int_1, bool bool_0)
	{
		int num;
		int num2;
		if (bool_0)
		{
			num = 1;
			num2 = 0;
		}
		else
		{
			num = -1;
			num2 = 23;
		}
		ushort num3 = (ushort)(((int)byte_2[int_0] << 8) + (int)byte_2[int_0 + 1]);
		ushort num4 = (ushort)(((int)byte_2[int_0 + 2] << 8) + (int)byte_2[int_0 + 3]);
		for (int i = 0; i < 12; i++)
		{
			num4 ^= (ushort)((int)Class27.smethod_0(byte_1, num2, num3) ^ num2);
			num2 += num;
			num3 ^= (ushort)((int)Class27.smethod_0(byte_1, num2, num4) ^ num2);
			num2 += num;
		}
		byte_3[int_1] = (byte)(num4 >> 8);
		byte_3[int_1 + 1] = (byte)num4;
		byte_3[int_1 + 2] = (byte)(num3 >> 8);
		byte_3[int_1 + 3] = (byte)num3;
	}

	// Token: 0x04000079 RID: 121
	private static byte[] byte_0 = new byte[]
	{
		163,
		215,
		9,
		131,
		248,
		72,
		246,
		244,
		179,
		33,
		21,
		120,
		153,
		177,
		175,
		249,
		231,
		45,
		77,
		138,
		206,
		76,
		202,
		46,
		82,
		149,
		217,
		30,
		78,
		56,
		68,
		40,
		10,
		223,
		2,
		160,
		23,
		241,
		96,
		104,
		18,
		183,
		122,
		195,
		233,
		250,
		61,
		83,
		150,
		132,
		107,
		186,
		242,
		99,
		154,
		25,
		124,
		174,
		229,
		245,
		247,
		22,
		106,
		162,
		57,
		182,
		123,
		15,
		193,
		147,
		129,
		27,
		238,
		180,
		26,
		234,
		208,
		145,
		47,
		184,
		85,
		185,
		218,
		133,
		63,
		65,
		191,
		224,
		90,
		88,
		128,
		95,
		102,
		11,
		216,
		144,
		53,
		213,
		192,
		167,
		51,
		6,
		101,
		105,
		69,
		0,
		148,
		86,
		109,
		152,
		155,
		118,
		151,
		252,
		178,
		194,
		176,
		254,
		219,
		32,
		225,
		235,
		214,
		228,
		221,
		71,
		74,
		29,
		66,
		237,
		158,
		110,
		73,
		60,
		205,
		67,
		39,
		210,
		7,
		212,
		222,
		199,
		103,
		24,
		137,
		203,
		48,
		31,
		141,
		198,
		143,
		170,
		200,
		116,
		220,
		201,
		93,
		92,
		49,
		164,
		112,
		136,
		97,
		44,
		159,
		13,
		43,
		135,
		80,
		130,
		84,
		100,
		38,
		125,
		3,
		64,
		52,
		75,
		28,
		115,
		209,
		196,
		253,
		59,
		204,
		251,
		127,
		171,
		230,
		62,
		91,
		165,
		173,
		4,
		35,
		156,
		20,
		81,
		34,
		240,
		41,
		121,
		113,
		126,
		byte.MaxValue,
		140,
		14,
		226,
		12,
		239,
		188,
		114,
		117,
		111,
		55,
		161,
		236,
		211,
		142,
		98,
		139,
		134,
		16,
		232,
		8,
		119,
		17,
		190,
		146,
		79,
		36,
		197,
		50,
		54,
		157,
		207,
		243,
		166,
		187,
		172,
		94,
		108,
		169,
		19,
		87,
		37,
		181,
		227,
		189,
		168,
		58,
		1,
		5,
		89,
		42,
		70
	};

	// Token: 0x0200003B RID: 59
	private sealed class Class28 : IDisposable, ICryptoTransform
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00003C7C File Offset: 0x00001E7C
		public Class28(byte[] byte_1, bool bool_1)
		{
			this.byte_0 = byte_1;
			this.bool_0 = bool_1;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00003C92 File Offset: 0x00001E92
		public int InputBlockSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00003C92 File Offset: 0x00001E92
		public int OutputBlockSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00003982 File Offset: 0x00001B82
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00003982 File Offset: 0x00001B82
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000311B File Offset: 0x0000131B
		public void Dispose()
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000259BC File Offset: 0x00023BBC
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputCount % 4 != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = 0; i < inputCount; i += 4)
			{
				Class27.smethod_1(this.byte_0, inputBuffer, inputOffset + i, outputBuffer, outputOffset + i, this.bool_0);
			}
			return inputCount;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000259FC File Offset: 0x00023BFC
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x0400007A RID: 122
		private byte[] byte_0;

		// Token: 0x0400007B RID: 123
		private bool bool_0;
	}
}
