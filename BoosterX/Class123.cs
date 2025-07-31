using System;
using System.Security.Cryptography;

// Token: 0x020000BF RID: 191
internal sealed class Class123 : SymmetricAlgorithm
{
	// Token: 0x06000593 RID: 1427 RVA: 0x00038A70 File Offset: 0x00036C70
	public Class123(params SymmetricAlgorithm[] symmetricAlgorithm_1)
	{
		symmetricAlgorithm_1 = (SymmetricAlgorithm[])symmetricAlgorithm_1.Clone();
		Array.Sort<SymmetricAlgorithm>(symmetricAlgorithm_1, new Comparison<SymmetricAlgorithm>(Class123.Class125.class125_0.method_0));
		this.symmetricAlgorithm_0 = symmetricAlgorithm_1;
		int num = 0;
		foreach (SymmetricAlgorithm symmetricAlgorithm in symmetricAlgorithm_1)
		{
			num += symmetricAlgorithm.KeySize;
			symmetricAlgorithm.Mode = CipherMode.ECB;
			symmetricAlgorithm.Padding = PaddingMode.None;
		}
		this.BlockSizeValue = symmetricAlgorithm_1[symmetricAlgorithm_1.Length - 1].BlockSize;
		this.LegalBlockSizesValue = new KeySizes[]
		{
			new KeySizes(this.BlockSizeValue, this.BlockSizeValue, 0)
		};
		this.KeySizeValue = num;
		this.LegalKeySizesValue = new KeySizes[]
		{
			new KeySizes(num, num, 0)
		};
		this.int_0 = symmetricAlgorithm_1[0].BlockSize;
		this.Mode = CipherMode.ECB;
		this.Padding = PaddingMode.None;
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00005A09 File Offset: 0x00003C09
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000595 RID: 1429 RVA: 0x00005A11 File Offset: 0x00003C11
	// (set) Token: 0x06000596 RID: 1430 RVA: 0x00005A19 File Offset: 0x00003C19
	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			this.IVValue = (byte[])value.Clone();
		}
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00005A2C File Offset: 0x00003C2C
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return this.method_1(rgbKey, rgbIV, false);
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x00005A37 File Offset: 0x00003C37
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return this.method_1(rgbKey, rgbIV, true);
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00038B64 File Offset: 0x00036D64
	private ICryptoTransform method_1(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		if (byte_0.Length * 8 != this.KeySize)
		{
			throw new ArgumentException("Invalid key size.", "#=zPWibic8=");
		}
		if (byte_1.Length * 8 != this.method_0())
		{
			throw new ArgumentException("Invalid IV size.", "#=z2_sBKLs=");
		}
		return new Class123.Class124(this.symmetricAlgorithm_0, byte_0, byte_1, bool_0);
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x000031EC File Offset: 0x000013EC
	public override void GenerateIV()
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x000031EC File Offset: 0x000013EC
	public override void GenerateKey()
	{
		throw new NotSupportedException();
	}

	// Token: 0x04000310 RID: 784
	private readonly SymmetricAlgorithm[] symmetricAlgorithm_0;

	// Token: 0x04000311 RID: 785
	private readonly int int_0;

	// Token: 0x020000C0 RID: 192
	private sealed class Class124 : IDisposable, ICryptoTransform
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x00005A42 File Offset: 0x00003C42
		public Class124(SymmetricAlgorithm[] symmetricAlgorithm_1, byte[] byte_2, byte[] byte_3, bool bool_1)
		{
			this.byte_0 = byte_2;
			this.byte_1 = byte_3;
			this.symmetricAlgorithm_0 = symmetricAlgorithm_1;
			this.bool_0 = bool_1;
			this.int_0 = symmetricAlgorithm_1[symmetricAlgorithm_1.Length - 1].BlockSize / 8;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00005A7F File Offset: 0x00003C7F
		public int InputBlockSize
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00005A7F File Offset: 0x00003C7F
		public int OutputBlockSize
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00003982 File Offset: 0x00001B82
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00003982 File Offset: 0x00001B82
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00038BC0 File Offset: 0x00036DC0
		public void Dispose()
		{
			if (this.icryptoTransform_0 != null)
			{
				foreach (ICryptoTransform cryptoTransform in this.icryptoTransform_0)
				{
					if (cryptoTransform != null)
					{
						cryptoTransform.Dispose();
					}
				}
				this.icryptoTransform_0 = null;
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00038C04 File Offset: 0x00036E04
		private void method_0()
		{
			SymmetricAlgorithm[] array = this.symmetricAlgorithm_0;
			int num = array.Length;
			if (this.icryptoTransform_0 == null)
			{
				ICryptoTransform[] array2 = new ICryptoTransform[num];
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					SymmetricAlgorithm symmetricAlgorithm = array[i];
					int num3 = symmetricAlgorithm.KeySize / 8;
					byte[] array3 = new byte[num3];
					Buffer.BlockCopy(this.byte_0, num2, array3, 0, num3);
					num2 += num3;
					byte[] rgbIV = new byte[symmetricAlgorithm.BlockSize / 8];
					ICryptoTransform cryptoTransform = this.bool_0 ? symmetricAlgorithm.CreateEncryptor(array3, rgbIV) : symmetricAlgorithm.CreateDecryptor(array3, rgbIV);
					array2[i] = cryptoTransform;
				}
				this.icryptoTransform_0 = array2;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00038CB4 File Offset: 0x00036EB4
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00005A87 File Offset: 0x00003C87
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			Buffer.BlockCopy(inputBuffer, inputOffset, outputBuffer, outputOffset, inputCount);
			this.method_0();
			if (this.bool_0)
			{
				this.method_1(outputBuffer, outputOffset, inputCount);
			}
			else
			{
				this.method_2(outputBuffer, outputOffset, inputCount);
			}
			return inputCount;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00038CD8 File Offset: 0x00036ED8
		private void method_1(byte[] byte_2, int int_1, int int_2)
		{
			byte[] array = new byte[this.byte_1.Length];
			Buffer.BlockCopy(this.byte_1, 0, array, 0, array.Length);
			int num = 0;
			foreach (ICryptoTransform cryptoTransform in this.icryptoTransform_0)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = int_2 - num & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + int_1;
					Class123.Class124.smethod_0(byte_2, num4, array, 0, inputBlockSize);
					cryptoTransform.TransformBlock(byte_2, num4, inputBlockSize, byte_2, num4);
					Buffer.BlockCopy(byte_2, num4, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == int_2)
				{
					break;
				}
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00038D84 File Offset: 0x00036F84
		private void method_2(byte[] byte_2, int int_1, int int_2)
		{
			byte[] array = new byte[this.byte_1.Length];
			Buffer.BlockCopy(this.byte_1, 0, array, 0, array.Length);
			byte[] array2 = new byte[array.Length];
			int num = 0;
			foreach (ICryptoTransform cryptoTransform in this.icryptoTransform_0)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = int_2 - num & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + int_1;
					Buffer.BlockCopy(byte_2, num4, array2, 0, inputBlockSize);
					cryptoTransform.TransformBlock(byte_2, num4, inputBlockSize, byte_2, num4);
					Class123.Class124.smethod_0(byte_2, num4, array, 0, inputBlockSize);
					Buffer.BlockCopy(array2, 0, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == int_2)
				{
					break;
				}
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00038E48 File Offset: 0x00037048
		private static void smethod_0(byte[] byte_2, int int_1, byte[] byte_3, int int_2, int int_3)
		{
			for (int i = 0; i < int_3; i++)
			{
				int num = int_1 + i;
				byte_2[num] ^= byte_3[int_2 + i];
			}
		}

		// Token: 0x04000312 RID: 786
		private readonly byte[] byte_0;

		// Token: 0x04000313 RID: 787
		private readonly byte[] byte_1;

		// Token: 0x04000314 RID: 788
		private readonly SymmetricAlgorithm[] symmetricAlgorithm_0;

		// Token: 0x04000315 RID: 789
		private ICryptoTransform[] icryptoTransform_0;

		// Token: 0x04000316 RID: 790
		private readonly bool bool_0;

		// Token: 0x04000317 RID: 791
		private readonly int int_0;
	}

	// Token: 0x020000C1 RID: 193
	[Serializable]
	private sealed class Class125
	{
		// Token: 0x060005AA RID: 1450 RVA: 0x00038E78 File Offset: 0x00037078
		internal int method_0(SymmetricAlgorithm symmetricAlgorithm_0, SymmetricAlgorithm symmetricAlgorithm_1)
		{
			return symmetricAlgorithm_1.BlockSize.CompareTo(symmetricAlgorithm_0.BlockSize);
		}

		// Token: 0x04000318 RID: 792
		public static readonly Class123.Class125 class125_0 = new Class123.Class125();

		// Token: 0x04000319 RID: 793
		public static Comparison<SymmetricAlgorithm> comparison_0;
	}
}
