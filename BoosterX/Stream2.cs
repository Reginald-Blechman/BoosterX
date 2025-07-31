using System;
using System.IO;

// Token: 0x02000043 RID: 67
internal sealed class Stream2 : Stream
{
	// Token: 0x06000198 RID: 408 RVA: 0x00026454 File Offset: 0x00024654
	public Stream2(Stream stream_1, Class130 class130_1 = null, Class87 class87_1 = null, bool bool_2 = false)
	{
		this.stream_0 = stream_1;
		this.bool_0 = bool_2;
		this.class87_0 = class87_1;
		this.class130_0 = class130_1;
		if (this.class130_0 == null)
		{
			this.class130_0 = Class130.smethod_0();
		}
		if (this.class130_0.method_2() == 0)
		{
			throw new ArgumentException("parameters");
		}
		if (this.class130_0.method_4() == 0)
		{
			throw new ArgumentException("parameters");
		}
		if (!this.stream_0.CanRead)
		{
			throw new ArgumentException("stream");
		}
		if (!this.stream_0.CanSeek)
		{
			throw new ArgumentException("stream");
		}
	}

	// Token: 0x06000199 RID: 409 RVA: 0x000264FC File Offset: 0x000246FC
	private void method_0()
	{
		if (!this.bool_1)
		{
			this.class112_0 = new Class112[this.class130_0.method_2()];
			for (int i = 0; i < this.class130_0.method_2(); i++)
			{
				this.class112_0[i] = new Class112();
			}
			if (this.class87_0 != null)
			{
				this.class110_0 = this.class87_0.method_0(this.class130_0);
			}
			this.bool_1 = true;
		}
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00026574 File Offset: 0x00024774
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && !this.bool_0)
			{
				this.stream_0.Close();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600019B RID: 411 RVA: 0x00003982 File Offset: 0x00001B82
	public override bool CanRead
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600019C RID: 412 RVA: 0x00003982 File Offset: 0x00001B82
	public override bool CanSeek
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600019D RID: 413 RVA: 0x00003056 File Offset: 0x00001256
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600019E RID: 414 RVA: 0x00003E86 File Offset: 0x00002086
	public override long Length
	{
		get
		{
			return this.stream_0.Length;
		}
	}

	// Token: 0x0600019F RID: 415 RVA: 0x000031EC File Offset: 0x000013EC
	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x000031EC File Offset: 0x000013EC
	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0000311B File Offset: 0x0000131B
	public override void Flush()
	{
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x00003E93 File Offset: 0x00002093
	// (set) Token: 0x060001A3 RID: 419 RVA: 0x00003EAF File Offset: 0x000020AF
	public override long Position
	{
		get
		{
			return this.stream_0.Position + (long)(this.int_0 - this.int_1);
		}
		set
		{
			this.Seek(value, SeekOrigin.Begin);
		}
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x000265B4 File Offset: 0x000247B4
	private int method_1(byte[] byte_1, int int_2, int int_3)
	{
		int num = this.int_1 - this.int_0;
		if (num <= 0)
		{
			return 0;
		}
		if (num > int_3)
		{
			num = int_3;
		}
		Buffer.BlockCopy(this.byte_0, this.int_0, byte_1, int_2, num);
		this.int_0 += num;
		return num;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00026600 File Offset: 0x00024800
	private void method_2(int int_2)
	{
		int num = (int)this.stream_0.Position;
		if ((long)num >= this.stream_0.Length)
		{
			return;
		}
		int num2 = num + int_2;
		foreach (Class112 @class in this.class112_0)
		{
			if (@class.int_0 <= num && @class.int_1 >= num2)
			{
				this.byte_0 = @class.byte_0;
				this.int_1 = @class.int_1 - @class.int_0;
				this.int_0 = num - @class.int_0;
				this.stream_0.Position = (long)@class.int_1;
				@class.dateTime_0 = DateTime.UtcNow;
				return;
			}
		}
		int num3 = 0;
		DateTime dateTime_ = this.class112_0[0].dateTime_0;
		for (int j = 1; j < this.class112_0.Length; j++)
		{
			if (this.class112_0[j].dateTime_0 < dateTime_)
			{
				num3 = j;
			}
		}
		Class112 class2 = this.class112_0[num3];
		if (class2.byte_0 == null)
		{
			class2.byte_0 = new byte[this.class130_0.method_0()];
		}
		int num4 = num;
		num = this.method_3(num);
		if (num < 0)
		{
			num = 0;
		}
		num2 = num + this.class130_0.method_0();
		if (this.class110_0 != null && this.class110_0.method_3(num, ref class2))
		{
			this.byte_0 = class2.byte_0;
			this.int_1 = class2.int_1 - num;
			this.stream_0.Position = (long)class2.int_1;
			this.int_0 = num4 - num;
		}
		else
		{
			class2.int_0 = num;
			class2.dateTime_0 = DateTime.UtcNow;
			this.byte_0 = class2.byte_0;
			this.stream_0.Position = (long)num;
			this.int_1 = this.stream_0.Read(this.byte_0, 0, num2 - num);
			this.int_0 = num4 - num;
			class2.int_1 = num + this.int_1;
			if (this.class110_0 != null)
			{
				this.class110_0.method_1(class2);
				return;
			}
		}
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x00003EBA File Offset: 0x000020BA
	private int method_3(int int_2)
	{
		return int_2 - int_2 % this.class130_0.method_0();
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x0002680C File Offset: 0x00024A0C
	public override int Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("#=zPWibic8=");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("#=z2_sBKLs=");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("#=z7VBd7Zo=");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException();
		}
		int int_ = offset;
		int num = this.method_1(buffer, offset, count);
		if (num == count)
		{
			return num;
		}
		int num2 = num;
		if (num > 0)
		{
			count -= num;
			offset += num;
		}
		this.int_1 = 0;
		this.int_0 = 0;
		this.method_0();
		if (count < this.class130_0.method_0())
		{
			this.method_2(count);
			num = this.method_1(buffer, offset, count);
			return num + num2;
		}
		if (this.class110_0 == null)
		{
			return this.stream_0.Read(buffer, offset, count) + num2;
		}
		int int_2 = (int)this.stream_0.Position - num2;
		int num3;
		if (this.class110_0.method_8(int_2, buffer, int_, count + num2, out num3))
		{
			this.stream_0.Seek((long)(num3 - num2), SeekOrigin.Current);
			return num3;
		}
		num3 = this.stream_0.Read(buffer, offset, count);
		if (num3 != 0)
		{
			this.class110_0.method_7(int_2, buffer, int_, num3 + num2, num3 < count);
		}
		return num3 + num2;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00026930 File Offset: 0x00024B30
	public override long Seek(long offset, SeekOrigin origin)
	{
		if (this.int_1 - this.int_0 > 0 && origin == SeekOrigin.Current)
		{
			offset -= (long)(this.int_1 - this.int_0);
		}
		long position = this.Position;
		long num = this.stream_0.Seek(offset, origin);
		this.int_0 = (int)(num - (position - (long)this.int_0));
		if (0 <= this.int_0 && this.int_0 < this.int_1)
		{
			this.stream_0.Seek((long)(this.int_1 - this.int_0), SeekOrigin.Current);
		}
		else
		{
			this.int_1 = 0;
			this.int_0 = 0;
		}
		return num;
	}

	// Token: 0x0400008E RID: 142
	private bool bool_0;

	// Token: 0x0400008F RID: 143
	private Stream stream_0;

	// Token: 0x04000090 RID: 144
	private Class112[] class112_0;

	// Token: 0x04000091 RID: 145
	private Class130 class130_0;

	// Token: 0x04000092 RID: 146
	private Class87 class87_0;

	// Token: 0x04000093 RID: 147
	private Class110 class110_0;

	// Token: 0x04000094 RID: 148
	private bool bool_1;

	// Token: 0x04000095 RID: 149
	private byte[] byte_0;

	// Token: 0x04000096 RID: 150
	private int int_0;

	// Token: 0x04000097 RID: 151
	private int int_1;
}
