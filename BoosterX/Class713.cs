using System;

// Token: 0x020005D3 RID: 1491
internal sealed class Class713
{
	// Token: 0x06002665 RID: 9829 RVA: 0x00019A0C File Offset: 0x00017C0C
	internal void method_0()
	{
		this.string_0 = this.method_7();
		this.int_0 = 1;
		this.bool_0 = true;
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x0000F50B File Offset: 0x0000D70B
	protected static int smethod_0(Class713.Enum19 enum19_0)
	{
		return (int)enum19_0;
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x00092E50 File Offset: 0x00091050
	private bool method_1()
	{
		int num = (int)Math.Floor(Math.Log10((double)this.int_0) + 1.0);
		return this.string_0.Length + 1 + num + 1 + 1 <= Class713.smethod_0((Class713.Enum19)12);
	}

	// Token: 0x06002668 RID: 9832 RVA: 0x00092E9C File Offset: 0x0009109C
	private bool method_2(int int_2)
	{
		if (int_2 - 1 == 2147483647)
		{
			return false;
		}
		int num = (int)Math.Floor(Math.Log10((double)int_2) + 1.0);
		return this.string_0.Length + num + 1 <= Class713.smethod_0((Class713.Enum19)12);
	}

	// Token: 0x06002669 RID: 9833 RVA: 0x00019A28 File Offset: 0x00017C28
	internal string method_3()
	{
		if (!this.bool_0)
		{
			this.method_0();
		}
		if (this.method_1())
		{
			this.string_0 = this.method_4();
			this.int_0 = 1;
		}
		return this.method_4();
	}

	// Token: 0x0600266A RID: 9834 RVA: 0x00019A59 File Offset: 0x00017C59
	internal string method_4()
	{
		if (!this.bool_0)
		{
			return null;
		}
		return this.string_0 + "." + this.int_0.ToString();
	}

	// Token: 0x0600266B RID: 9835 RVA: 0x00092EE8 File Offset: 0x000910E8
	internal string method_5()
	{
		if (!this.bool_0)
		{
			this.method_0();
		}
		int int_ = this.int_0 + 1;
		if (this.method_2(int_))
		{
			this.int_0 = int_;
		}
		return this.method_4();
	}

	// Token: 0x0600266C RID: 9836 RVA: 0x00092F24 File Offset: 0x00091124
	private bool method_6(string string_2)
	{
		if (string_2.Length > Class713.smethod_0((Class713.Enum19)12))
		{
			return false;
		}
		string b = "^[" + this.string_1 + "]{16}(.[0-9]+)+$";
		return !(string_2 != b);
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x00092F68 File Offset: 0x00091168
	private string method_7()
	{
		string text = string.Empty;
		Random random = new Random();
		for (int i = 0; i < this.int_1; i++)
		{
			text += this.string_1[random.Next(this.string_1.Length)].ToString();
		}
		return text;
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x00092FC0 File Offset: 0x000911C0
	internal void method_8(string string_2)
	{
		if (!this.method_6(string_2))
		{
			throw new Exception("Cannot set invalid correlation vector value");
		}
		int num = string_2.LastIndexOf(".");
		this.string_0 = string_2.Substring(0, num);
		this.int_0 = int.Parse(string_2.Substring(num + 1));
		this.bool_0 = true;
	}

	// Token: 0x0400192A RID: 6442
	private string string_0;

	// Token: 0x0400192B RID: 6443
	private int int_0;

	// Token: 0x0400192C RID: 6444
	private readonly string string_1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

	// Token: 0x0400192D RID: 6445
	private readonly int int_1 = 16;

	// Token: 0x0400192E RID: 6446
	private bool bool_0;

	// Token: 0x020005D4 RID: 1492
	internal enum Enum19
	{

	}
}
