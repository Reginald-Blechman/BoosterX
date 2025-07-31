using System;

// Token: 0x020000A3 RID: 163
internal sealed class Class104 : Interface0
{
	// Token: 0x06000519 RID: 1305 RVA: 0x0000311B File Offset: 0x0000131B
	public void imethod_0()
	{
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00005645 File Offset: 0x00003845
	public string imethod_1()
	{
		return "PKCS7";
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00037D0C File Offset: 0x00035F0C
	public int imethod_2(byte[] byte_0, int int_0)
	{
		byte b = (byte)(byte_0.Length - int_0);
		while (int_0 < byte_0.Length)
		{
			byte_0[int_0] = b;
			int_0++;
		}
		return (int)b;
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x00037D34 File Offset: 0x00035F34
	public int imethod_3(byte[] byte_0)
	{
		int num = (int)byte_0[byte_0.Length - 1];
		if (num >= 1 && num <= byte_0.Length)
		{
			for (int i = 1; i <= num; i++)
			{
				if ((int)byte_0[byte_0.Length - i] != num)
				{
					throw new Exception2("pad block corrupted");
				}
			}
			return num;
		}
		throw new Exception2("pad block corrupted");
	}
}
