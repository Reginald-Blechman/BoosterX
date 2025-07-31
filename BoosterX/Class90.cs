using System;
using System.Reflection;
using System.Security.Cryptography;

// Token: 0x02000093 RID: 147
internal sealed class Class90 : IDisposable
{
	// Token: 0x060004AD RID: 1197 RVA: 0x0000537D File Offset: 0x0000357D
	public Class90()
	{
		this.method_1((Enum2)1);
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x0003710C File Offset: 0x0003530C
	public void Dispose()
	{
		IDisposable disposable = this.symmetricAlgorithm_0;
		if (disposable != null)
		{
			disposable.Dispose();
		}
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x0000538C File Offset: 0x0000358C
	public Enum2 method_0()
	{
		return this.enum2_0;
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00005394 File Offset: 0x00003594
	public void method_1(Enum2 enum2_1)
	{
		if (this.enum2_0 == enum2_1)
		{
			return;
		}
		this.enum2_0 = enum2_1;
		this.bool_1 = true;
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x000053AE File Offset: 0x000035AE
	public Enum0 method_2()
	{
		return this.enum0_0;
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x000053B6 File Offset: 0x000035B6
	public void method_3(Enum0 enum0_1)
	{
		if (this.enum0_0 == enum0_1)
		{
			return;
		}
		this.enum0_0 = enum0_1;
		this.bool_1 = true;
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x000053D0 File Offset: 0x000035D0
	public byte[] method_4()
	{
		return this.byte_0;
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x000053D8 File Offset: 0x000035D8
	public void method_5(byte[] byte_2)
	{
		this.byte_0 = byte_2;
		this.bool_1 = true;
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x000053E8 File Offset: 0x000035E8
	public byte[] method_6()
	{
		return this.byte_1;
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x000053F0 File Offset: 0x000035F0
	public void method_7(byte[] byte_2)
	{
		this.byte_1 = byte_2;
		this.bool_1 = true;
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x0003712C File Offset: 0x0003532C
	private static SymmetricAlgorithm smethod_0()
	{
		if (Class90.type_0 != null)
		{
			if (Class90.type_0 == typeof(Class90.Class91))
			{
				return null;
			}
			return Activator.CreateInstance(Class90.type_0) as SymmetricAlgorithm;
		}
		else
		{
			Class90.type_0 = typeof(Class90.Class91);
			Assembly assembly = null;
			try
			{
				assembly = Assembly.Load("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
			}
			catch
			{
			}
			if (assembly == null)
			{
				return null;
			}
			try
			{
				Type type = assembly.GetType("System.Security.Cryptography.AesCryptoServiceProvider");
				if (type != null)
				{
					SymmetricAlgorithm result = Activator.CreateInstance(type) as SymmetricAlgorithm;
					Class90.type_0 = type;
					return result;
				}
			}
			catch
			{
			}
			try
			{
				Type type2 = assembly.GetType("System.Security.Cryptography.AesManaged");
				if (type2 != null)
				{
					SymmetricAlgorithm result2 = Activator.CreateInstance(type2) as SymmetricAlgorithm;
					Class90.type_0 = type2;
					return result2;
				}
			}
			catch
			{
			}
			return null;
		}
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00005400 File Offset: 0x00003600
	private static CipherMode smethod_1(Enum2 enum2_1)
	{
		if (enum2_1 == (Enum2)1)
		{
			return CipherMode.CBC;
		}
		throw new InvalidOperationException("Cipher mode is not supported");
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00005415 File Offset: 0x00003615
	private static PaddingMode smethod_2(Enum0 enum0_1)
	{
		if (enum0_1 == (Enum0)1)
		{
			return PaddingMode.None;
		}
		if (enum0_1 != (Enum0)2)
		{
			throw new InvalidOperationException("Padding mode is not supported");
		}
		return PaddingMode.PKCS7;
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x0000542E File Offset: 0x0000362E
	public Class114 method_8()
	{
		return this.method_10(true);
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00005437 File Offset: 0x00003637
	public Class114 method_9()
	{
		return this.method_10(false);
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00037234 File Offset: 0x00035434
	private Class114 method_10(bool bool_2)
	{
		if (!this.bool_0)
		{
			bool flag = this.bool_1 || this.symmetricAlgorithm_0 == null;
			if (this.symmetricAlgorithm_0 == null)
			{
				this.symmetricAlgorithm_0 = Class90.smethod_0();
				if (this.symmetricAlgorithm_0 == null)
				{
					this.bool_0 = true;
				}
			}
			if (this.symmetricAlgorithm_0 != null)
			{
				if (flag)
				{
					this.symmetricAlgorithm_0.Key = this.method_4();
					this.symmetricAlgorithm_0.IV = this.method_6();
					this.symmetricAlgorithm_0.Mode = Class90.smethod_1(this.method_0());
					this.symmetricAlgorithm_0.Padding = Class90.smethod_2(this.method_2());
				}
				return new Class116(bool_2 ? this.symmetricAlgorithm_0.CreateEncryptor() : this.symmetricAlgorithm_0.CreateDecryptor());
			}
		}
		Class1 interface3_ = new Class1(new Class21());
		Class55 @class;
		if (this.method_2() != (Enum0)1)
		{
			@class = new Class56(interface3_, Class90.smethod_3(this.method_2()));
		}
		else
		{
			@class = new Class55(interface3_);
		}
		Class20 interface2_ = new Class20(new Class120(this.method_4()), this.method_6());
		@class.imethod_1(bool_2, interface2_);
		return new Class115(@class);
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00005440 File Offset: 0x00003640
	private static Interface0 smethod_3(Enum0 enum0_1)
	{
		if (enum0_1 == (Enum0)1)
		{
			return null;
		}
		if (enum0_1 != (Enum0)2)
		{
			throw new InvalidOperationException("Padding mode is not supported");
		}
		return new Class104();
	}

	// Token: 0x040002C5 RID: 709
	private Enum2 enum2_0;

	// Token: 0x040002C6 RID: 710
	private Enum0 enum0_0;

	// Token: 0x040002C7 RID: 711
	private byte[] byte_0;

	// Token: 0x040002C8 RID: 712
	private byte[] byte_1;

	// Token: 0x040002C9 RID: 713
	private static volatile Type type_0;

	// Token: 0x040002CA RID: 714
	private bool bool_0;

	// Token: 0x040002CB RID: 715
	private bool bool_1;

	// Token: 0x040002CC RID: 716
	private SymmetricAlgorithm symmetricAlgorithm_0;

	// Token: 0x02000094 RID: 148
	private sealed class Class91
	{
	}
}
