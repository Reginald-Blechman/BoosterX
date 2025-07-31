using System;

// Token: 0x0200009C RID: 156
internal abstract class Class97 : IDisposable
{
	// Token: 0x060004EF RID: 1263
	public abstract bool vmethod_0();

	// Token: 0x060004F0 RID: 1264
	public abstract bool vmethod_1();

	// Token: 0x060004F1 RID: 1265
	public abstract bool vmethod_2();

	// Token: 0x060004F2 RID: 1266
	public abstract long vmethod_3();

	// Token: 0x060004F3 RID: 1267
	public abstract long vmethod_4();

	// Token: 0x060004F4 RID: 1268
	public abstract void vmethod_5(long long_0);

	// Token: 0x060004F5 RID: 1269 RVA: 0x00005561 File Offset: 0x00003761
	public virtual void vmethod_6()
	{
		this.vmethod_7(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00005570 File Offset: 0x00003770
	public void Dispose()
	{
		this.vmethod_6();
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x0000311B File Offset: 0x0000131B
	protected virtual void vmethod_7(bool bool_0)
	{
	}

	// Token: 0x060004F8 RID: 1272
	public abstract void vmethod_8();

	// Token: 0x060004F9 RID: 1273
	public abstract long vmethod_9(long long_0, int int_0);

	// Token: 0x060004FA RID: 1274
	public abstract void vmethod_10(long long_0);

	// Token: 0x060004FB RID: 1275
	public abstract int vmethod_11(byte[] byte_0, int int_0, int int_1);

	// Token: 0x060004FC RID: 1276 RVA: 0x0003788C File Offset: 0x00035A8C
	public virtual int vmethod_12()
	{
		byte[] array = new byte[1];
		if (this.vmethod_11(array, 0, 1) == 0)
		{
			return -1;
		}
		return (int)array[0];
	}

	// Token: 0x060004FD RID: 1277
	public abstract void vmethod_13(byte[] byte_0, int int_0, int int_1);

	// Token: 0x060004FE RID: 1278 RVA: 0x000378B0 File Offset: 0x00035AB0
	public virtual void vmethod_14(byte byte_0)
	{
		this.vmethod_13(new byte[]
		{
			byte_0
		}, 0, 1);
	}
}
