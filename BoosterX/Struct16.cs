using System;
using System.Threading;

// Token: 0x020000A9 RID: 169
internal struct Struct16
{
	// Token: 0x0600052F RID: 1327 RVA: 0x000056C8 File Offset: 0x000038C8
	public Struct16(string string_0)
	{
		this.nullable_0 = new long?(Class88.smethod_1(Class88.smethod_0(string_0)));
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x000056E0 File Offset: 0x000038E0
	public Struct16(long long_0)
	{
		this.nullable_0 = new long?(Class88.smethod_1(new TimeSpan(long_0)));
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x000056F8 File Offset: 0x000038F8
	public Struct16(int int_0, int int_1, int int_2)
	{
		this.nullable_0 = new long?(Class88.smethod_1(new TimeSpan(int_0, int_1, int_2)));
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00005712 File Offset: 0x00003912
	public Struct16(int int_0, int int_1, int int_2, int int_3)
	{
		this.nullable_0 = new long?(Class88.smethod_1(new TimeSpan(int_0, int_1, int_2, int_3)));
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0000572E File Offset: 0x0000392E
	public Struct16(int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		this.nullable_0 = new long?(Class88.smethod_1(new TimeSpan(int_0, int_1, int_2, int_3, int_4)));
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0000574C File Offset: 0x0000394C
	public TimeSpan method_0()
	{
		return Class88.smethod_2(this.nullable_0);
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00005759 File Offset: 0x00003959
	public void method_1(TimeSpan timeSpan_0)
	{
		this.nullable_0 = new long?(Class88.smethod_1(timeSpan_0));
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0000576C File Offset: 0x0000396C
	public TimeSpan method_2()
	{
		TimeSpan result = Class88.smethod_2(this.nullable_0);
		Thread.MemoryBarrier();
		return result;
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0000577E File Offset: 0x0000397E
	public void method_3(TimeSpan timeSpan_0)
	{
		Thread.MemoryBarrier();
		this.nullable_0 = new long?(Class88.smethod_1(timeSpan_0));
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00037E04 File Offset: 0x00036004
	public void method_4()
	{
		this.nullable_0 = new long?(Class88.smethod_1(default(TimeSpan)));
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x00037E2C File Offset: 0x0003602C
	public int method_5()
	{
		return Class88.smethod_2(this.nullable_0).GetHashCode();
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00037E54 File Offset: 0x00036054
	public bool method_6(TimeSpan timeSpan_0)
	{
		return Class88.smethod_2(this.nullable_0).Equals(timeSpan_0);
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x00037E78 File Offset: 0x00036078
	public bool method_7(object object_0)
	{
		return Class88.smethod_2(this.nullable_0).Equals(object_0);
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00037EA0 File Offset: 0x000360A0
	public int method_8(TimeSpan timeSpan_0)
	{
		return Class88.smethod_2(this.nullable_0).CompareTo(timeSpan_0);
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00037EC4 File Offset: 0x000360C4
	public int method_9(object object_0)
	{
		return Class88.smethod_2(this.nullable_0).CompareTo(object_0);
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00037EE8 File Offset: 0x000360E8
	public string method_10()
	{
		return Class88.smethod_2(this.nullable_0).ToString();
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00037F10 File Offset: 0x00036110
	public string method_11(string string_0)
	{
		return Class88.smethod_2(this.nullable_0).ToString(string_0);
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00037F34 File Offset: 0x00036134
	public string method_12(string string_0, IFormatProvider iformatProvider_0)
	{
		return Class88.smethod_2(this.nullable_0).ToString(string_0, iformatProvider_0);
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00037F58 File Offset: 0x00036158
	public TimeSpan method_13(TimeSpan timeSpan_0)
	{
		return Class88.smethod_2(this.nullable_0).Add(timeSpan_0);
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00037F7C File Offset: 0x0003617C
	public TimeSpan method_14(TimeSpan timeSpan_0)
	{
		return Class88.smethod_2(this.nullable_0).Subtract(timeSpan_0);
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00037FA0 File Offset: 0x000361A0
	public TimeSpan method_15()
	{
		return Class88.smethod_2(this.nullable_0).Duration();
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00037FC0 File Offset: 0x000361C0
	public TimeSpan method_16()
	{
		return Class88.smethod_2(this.nullable_0).Negate();
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00037FE0 File Offset: 0x000361E0
	public long method_17()
	{
		return Class88.smethod_2(this.nullable_0).Ticks;
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00038000 File Offset: 0x00036200
	public int method_18()
	{
		return Class88.smethod_2(this.nullable_0).Days;
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00038020 File Offset: 0x00036220
	public int method_19()
	{
		return Class88.smethod_2(this.nullable_0).Hours;
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00038040 File Offset: 0x00036240
	public int method_20()
	{
		return Class88.smethod_2(this.nullable_0).Minutes;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00038060 File Offset: 0x00036260
	public int method_21()
	{
		return Class88.smethod_2(this.nullable_0).Seconds;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00038080 File Offset: 0x00036280
	public int method_22()
	{
		return Class88.smethod_2(this.nullable_0).Milliseconds;
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x000380A0 File Offset: 0x000362A0
	public double method_23()
	{
		return Class88.smethod_2(this.nullable_0).TotalDays;
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x000380C0 File Offset: 0x000362C0
	public double method_24()
	{
		return Class88.smethod_2(this.nullable_0).TotalHours;
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x000380E0 File Offset: 0x000362E0
	public double method_25()
	{
		return Class88.smethod_2(this.nullable_0).TotalMinutes;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00038100 File Offset: 0x00036300
	public double method_26()
	{
		return Class88.smethod_2(this.nullable_0).TotalSeconds;
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00038120 File Offset: 0x00036320
	public double method_27()
	{
		return Class88.smethod_2(this.nullable_0).TotalMilliseconds;
	}

	// Token: 0x040002EC RID: 748
	private long? nullable_0;
}
