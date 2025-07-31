using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x0200001C RID: 28
internal sealed class Class12 : IDisposable, Interface5
{
	// Token: 0x060000AB RID: 171 RVA: 0x000035D5 File Offset: 0x000017D5
	public int imethod_0()
	{
		return this.secureString_0.Length;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x000035E2 File Offset: 0x000017E2
	public Interface5 imethod_4()
	{
		return new Class12();
	}

	// Token: 0x060000AD RID: 173 RVA: 0x000232D4 File Offset: 0x000214D4
	public void imethod_1(int int_0, out byte byte_0)
	{
		if (int_0 >= 0 && int_0 < this.imethod_0())
		{
			IntPtr intPtr = IntPtr.Zero;
			char char_ = '\0';
			try
			{
				intPtr = Marshal.SecureStringToGlobalAllocUnicode(this.secureString_0);
				char_ = (char)Marshal.ReadInt16(intPtr, int_0 * 2);
				byte_0 = Class12.smethod_1(char_, int_0);
				return;
			}
			finally
			{
				Class113.smethod_3(ref char_);
				if (intPtr != IntPtr.Zero)
				{
					Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
				}
			}
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060000AE RID: 174 RVA: 0x0002334C File Offset: 0x0002154C
	public void imethod_2(int int_0, ref byte byte_0)
	{
		for (int i = this.secureString_0.Length; i <= int_0; i++)
		{
			if (i == int_0)
			{
				this.secureString_0.AppendChar(Class12.smethod_0(byte_0, i));
				return;
			}
			this.secureString_0.AppendChar(Class12.smethod_0(0, i));
		}
		this.secureString_0.SetAt(int_0, Class12.smethod_0(byte_0, int_0));
	}

	// Token: 0x060000AF RID: 175 RVA: 0x000035E9 File Offset: 0x000017E9
	private static char smethod_0(byte byte_0, int int_0)
	{
		return (char)(byte_0 + 1);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x000035EF File Offset: 0x000017EF
	private static byte smethod_1(char char_0, int int_0)
	{
		return (byte)(char_0 - '\u0001');
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x000035F5 File Offset: 0x000017F5
	public void imethod_3()
	{
		this.secureString_0.Clear();
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00003602 File Offset: 0x00001802
	public void Dispose()
	{
		this.secureString_0.Dispose();
		this.secureString_0 = null;
	}

	// Token: 0x0400003A RID: 58
	private SecureString secureString_0 = new SecureString();
}
