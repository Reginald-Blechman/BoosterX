using System;
using System.Linq;

// Token: 0x020005D2 RID: 1490
public sealed class GClass255
{
	// Token: 0x06002645 RID: 9797 RVA: 0x000197DC File Offset: 0x000179DC
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06002646 RID: 9798 RVA: 0x000197E4 File Offset: 0x000179E4
	public void method_1(string string_6)
	{
		this.string_0 = string_6;
	}

	// Token: 0x06002647 RID: 9799 RVA: 0x000197ED File Offset: 0x000179ED
	public string method_2()
	{
		return this.string_1;
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x000197F5 File Offset: 0x000179F5
	public void method_3(string string_6)
	{
		this.string_1 = string_6;
	}

	// Token: 0x06002649 RID: 9801 RVA: 0x000197FE File Offset: 0x000179FE
	public string method_4()
	{
		return this.string_2;
	}

	// Token: 0x0600264A RID: 9802 RVA: 0x00019806 File Offset: 0x00017A06
	public void method_5(string string_6)
	{
		this.string_2 = string_6;
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x0001980F File Offset: 0x00017A0F
	public string method_6()
	{
		return this.string_3;
	}

	// Token: 0x0600264C RID: 9804 RVA: 0x00019817 File Offset: 0x00017A17
	public void method_7(string string_6)
	{
		this.string_3 = string_6;
	}

	// Token: 0x0600264D RID: 9805 RVA: 0x00019820 File Offset: 0x00017A20
	public string method_8()
	{
		return this.string_4;
	}

	// Token: 0x0600264E RID: 9806 RVA: 0x00019828 File Offset: 0x00017A28
	public void method_9(string string_6)
	{
		this.string_4 = string_6;
	}

	// Token: 0x0600264F RID: 9807 RVA: 0x00019831 File Offset: 0x00017A31
	public string method_10()
	{
		return this.string_5;
	}

	// Token: 0x06002650 RID: 9808 RVA: 0x00019839 File Offset: 0x00017A39
	public void method_11(string string_6)
	{
		this.string_5 = string_6;
	}

	// Token: 0x06002651 RID: 9809 RVA: 0x00019842 File Offset: 0x00017A42
	public int method_12()
	{
		return this.int_0;
	}

	// Token: 0x06002652 RID: 9810 RVA: 0x0001984A File Offset: 0x00017A4A
	public void method_13(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06002653 RID: 9811 RVA: 0x00019853 File Offset: 0x00017A53
	public long method_14()
	{
		return this.long_0;
	}

	// Token: 0x06002654 RID: 9812 RVA: 0x0001985B File Offset: 0x00017A5B
	public void method_15(long long_2)
	{
		this.long_0 = long_2;
	}

	// Token: 0x06002655 RID: 9813 RVA: 0x00019864 File Offset: 0x00017A64
	public long method_16()
	{
		return this.long_1;
	}

	// Token: 0x06002656 RID: 9814 RVA: 0x0001986C File Offset: 0x00017A6C
	public void method_17(long long_2)
	{
		this.long_1 = long_2;
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x00019875 File Offset: 0x00017A75
	public bool method_18()
	{
		return this.method_12() == 3 || this.method_12() == 0;
	}

	// Token: 0x06002658 RID: 9816 RVA: 0x0001988B File Offset: 0x00017A8B
	public bool method_19()
	{
		return Class620.smethod_0().method_3(this.method_20(), this.method_22(), this.method_21());
	}

	// Token: 0x06002659 RID: 9817 RVA: 0x000198A9 File Offset: 0x00017AA9
	public string method_20()
	{
		return this.method_0().Split(new char[]
		{
			'_'
		})[0];
	}

	// Token: 0x0600265A RID: 9818 RVA: 0x000198C3 File Offset: 0x00017AC3
	public string method_21()
	{
		return this.method_0().Split(new char[]
		{
			'_'
		})[2];
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x000198DD File Offset: 0x00017ADD
	public string method_22()
	{
		return this.method_0().Split(new char[]
		{
			'_'
		})[1];
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x000198F7 File Offset: 0x00017AF7
	public string method_23()
	{
		return string.Concat(new string[]
		{
			this.method_20(),
			"_",
			this.method_22(),
			"_",
			this.method_21()
		});
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x00019931 File Offset: 0x00017B31
	public int method_24()
	{
		return Convert.ToInt32(this.method_0().Split(new char[]
		{
			'_'
		})[1].Split(new char[]
		{
			'.'
		})[0]);
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x00019962 File Offset: 0x00017B62
	public bool method_25()
	{
		return this.method_22().Split(new char[]
		{
			'.'
		}).Last<string>() == "70";
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x0001998A File Offset: 0x00017B8A
	public bool method_26()
	{
		return this.method_21() == "x64";
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x0001999D File Offset: 0x00017B9D
	public bool method_27()
	{
		return this.method_21() == "x86";
	}

	// Token: 0x06002661 RID: 9825 RVA: 0x000199B0 File Offset: 0x00017BB0
	public bool method_28()
	{
		return this.method_21() == "neutral";
	}

	// Token: 0x06002662 RID: 9826 RVA: 0x00092D94 File Offset: 0x00090F94
	public int method_29(GClass255 gclass255_0)
	{
		if (!gclass255_0.method_0().StartsWith("Microsoft.Windows"))
		{
			if (gclass255_0.method_24().ToString().ToCharArray().Length != 4)
			{
				return Version.Parse(this.method_22()).CompareTo(Version.Parse(gclass255_0.method_22()));
			}
		}
		int num = Convert.ToInt32(Class243.smethod_1().Remove(2)) + 2000;
		if (gclass255_0.method_24() < num && (this.method_24() >= num || this.method_24() < gclass255_0.method_24()))
		{
			return -1;
		}
		if (gclass255_0.method_24() == this.method_24())
		{
			return Version.Parse(this.method_22()).CompareTo(Version.Parse(gclass255_0.method_22()));
		}
		return 1;
	}

	// Token: 0x06002663 RID: 9827 RVA: 0x000199C3 File Offset: 0x00017BC3
	public bool method_30()
	{
		return this.method_20().StartsWith("Microsoft.") && this.method_8().ToLower() == "developer tools";
	}

	// Token: 0x04001921 RID: 6433
	private string string_0;

	// Token: 0x04001922 RID: 6434
	private string string_1;

	// Token: 0x04001923 RID: 6435
	private string string_2;

	// Token: 0x04001924 RID: 6436
	private string string_3;

	// Token: 0x04001925 RID: 6437
	private string string_4;

	// Token: 0x04001926 RID: 6438
	private string string_5;

	// Token: 0x04001927 RID: 6439
	private int int_0;

	// Token: 0x04001928 RID: 6440
	private long long_0;

	// Token: 0x04001929 RID: 6441
	private long long_1;
}
