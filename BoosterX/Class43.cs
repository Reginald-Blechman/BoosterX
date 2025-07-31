using System;
using System.Security.Cryptography;

// Token: 0x02000072 RID: 114
internal abstract class Class43
{
	// Token: 0x060003D4 RID: 980 RVA: 0x00004BD1 File Offset: 0x00002DD1
	public Class43(byte[] byte_0, long long_0) : this(byte_0, Class43.smethod_2(long_0))
	{
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00034558 File Offset: 0x00032758
	public Class43(byte[] byte_0, byte[] byte_1)
	{
		Class2 @class = new Class2(byte_0, byte_1, 1);
		SymmetricAlgorithm[] array = new SymmetricAlgorithm[5];
		for (int i = 0; i < 5; i++)
		{
			Class123 class2 = new Class123(new SymmetricAlgorithm[]
			{
				new Class27()
			});
			class2.Key = @class.GetBytes(class2.KeySize / 8);
			class2.IV = @class.GetBytes(class2.method_0() / 8);
			array[i] = class2;
		}
		this.symmetricAlgorithm_0 = array;
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00004BE0 File Offset: 0x00002DE0
	protected static int smethod_0(int int_0)
	{
		return (int_0 + 3) / 4 * 4;
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00004BE9 File Offset: 0x00002DE9
	public static int smethod_1(int int_0)
	{
		return Class43.smethod_0(int_0 + 4);
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x000345D4 File Offset: 0x000327D4
	protected static byte[] smethod_2(long long_0)
	{
		byte[] array = new byte[8];
		Class43.smethod_3(long_0, array, 0);
		return array;
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x0002313C File Offset: 0x0002133C
	protected static void smethod_3(long long_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)long_0;
		byte_0[int_0 + 1] = (byte)(long_0 >> 8);
		byte_0[int_0 + 2] = (byte)(long_0 >> 16);
		byte_0[int_0 + 3] = (byte)(long_0 >> 24);
		byte_0[int_0 + 4] = (byte)(long_0 >> 32);
		byte_0[int_0 + 5] = (byte)(long_0 >> 40);
		byte_0[int_0 + 6] = (byte)(long_0 >> 48);
		byte_0[int_0 + 7] = (byte)(long_0 >> 56);
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00004BF3 File Offset: 0x00002DF3
	protected static int smethod_4(byte[] byte_0, int int_0)
	{
		return (int)byte_0[int_0] | (int)byte_0[int_0 + 1] << 8 | (int)byte_0[int_0 + 2] << 16 | (int)byte_0[int_0 + 3] << 24;
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00003570 File Offset: 0x00001770
	protected static void smethod_5(int int_0, byte[] byte_0, int int_1)
	{
		byte_0[int_1] = (byte)int_0;
		byte_0[int_1 + 1] = (byte)(int_0 >> 8);
		byte_0[int_1 + 2] = (byte)(int_0 >> 16);
		byte_0[int_1 + 3] = (byte)(int_0 >> 24);
	}

	// Token: 0x060003DC RID: 988 RVA: 0x000345F4 File Offset: 0x000327F4
	protected byte[] method_0(byte[] byte_0, bool bool_0)
	{
		if (bool_0)
		{
			SymmetricAlgorithm[] array = this.symmetricAlgorithm_0;
			int i = 0;
			while (i < array.Length)
			{
				SymmetricAlgorithm symmetricAlgorithm = array[i];
				if (bool_0)
				{
					using (ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateEncryptor())
					{
						byte_0 = cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
						goto IL_6A;
					}
					goto IL_47;
				}
				goto IL_47;
				IL_6A:
				bool_0 = !bool_0;
				i++;
				continue;
				IL_47:
				using (ICryptoTransform cryptoTransform2 = symmetricAlgorithm.CreateDecryptor())
				{
					byte_0 = cryptoTransform2.TransformFinalBlock(byte_0, 0, byte_0.Length);
				}
				goto IL_6A;
			}
		}
		else
		{
			int j = 4;
			while (j >= 0)
			{
				SymmetricAlgorithm symmetricAlgorithm2 = this.symmetricAlgorithm_0[j];
				if (bool_0)
				{
					using (ICryptoTransform cryptoTransform3 = symmetricAlgorithm2.CreateEncryptor())
					{
						byte_0 = cryptoTransform3.TransformFinalBlock(byte_0, 0, byte_0.Length);
						goto IL_DD;
					}
					goto IL_B6;
				}
				goto IL_B6;
				IL_DD:
				bool_0 = !bool_0;
				j--;
				continue;
				IL_B6:
				using (ICryptoTransform cryptoTransform4 = symmetricAlgorithm2.CreateDecryptor())
				{
					byte_0 = cryptoTransform4.TransformFinalBlock(byte_0, 0, byte_0.Length);
				}
				goto IL_DD;
			}
		}
		return byte_0;
	}

	// Token: 0x04000288 RID: 648
	private readonly SymmetricAlgorithm[] symmetricAlgorithm_0;
}
