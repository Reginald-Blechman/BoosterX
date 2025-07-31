using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020004C5 RID: 1221
internal sealed class Class580<T, U, V, W, X, Y>
{
	// Token: 0x06001F3D RID: 7997 RVA: 0x00014B63 File Offset: 0x00012D63
	[DebuggerHidden]
	public Class580(T gparam_6, U gparam_7, V gparam_8, W gparam_9, X gparam_10, Y gparam_11)
	{
		this.gparam_0 = gparam_6;
		this.gparam_1 = gparam_7;
		this.gparam_2 = gparam_8;
		this.gparam_3 = gparam_9;
		this.gparam_4 = gparam_10;
		this.gparam_5 = gparam_11;
	}

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00014B98 File Offset: 0x00012D98
	public T PublicIp
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x06001F3F RID: 7999 RVA: 0x00014BA0 File Offset: 0x00012DA0
	public U CoreHash
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00014BA8 File Offset: 0x00012DA8
	public V WindowsGuid
	{
		get
		{
			return this.gparam_2;
		}
	}

	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x06001F41 RID: 8001 RVA: 0x00014BB0 File Offset: 0x00012DB0
	public W SecretHwid
	{
		get
		{
			return this.gparam_3;
		}
	}

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00014BB8 File Offset: 0x00012DB8
	public X BoosterXGuid
	{
		get
		{
			return this.gparam_4;
		}
	}

	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00014BC0 File Offset: 0x00012DC0
	public Y DiscordNick
	{
		get
		{
			return this.gparam_5;
		}
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x0007F6FC File Offset: 0x0007D8FC
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class580<T, U, V, W, X, Y> @class = obj as Class580<T, U, V, W, X, Y>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1) && EqualityComparer<V>.Default.Equals(this.gparam_2, @class.gparam_2) && EqualityComparer<W>.Default.Equals(this.gparam_3, @class.gparam_3) && EqualityComparer<X>.Default.Equals(this.gparam_4, @class.gparam_4) && EqualityComparer<Y>.Default.Equals(this.gparam_5, @class.gparam_5));
	}

	// Token: 0x06001F45 RID: 8005 RVA: 0x0007F7B0 File Offset: 0x0007D9B0
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (((((386006949 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.gparam_2)) * -1521134295 + EqualityComparer<W>.Default.GetHashCode(this.gparam_3)) * -1521134295 + EqualityComparer<X>.Default.GetHashCode(this.gparam_4)) * -1521134295 + EqualityComparer<Y>.Default.GetHashCode(this.gparam_5);
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x0007F848 File Offset: 0x0007DA48
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ PublicIp = {0}, CoreHash = {1}, WindowsGuid = {2}, SecretHwid = {3}, BoosterXGuid = {4}, DiscordNick = {5} }}";
		object[] array = new object[6];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		int num3 = 2;
		V v = this.gparam_2;
		array[num3] = ((v != null) ? v.ToString() : null);
		int num4 = 3;
		W w = this.gparam_3;
		array[num4] = ((w != null) ? w.ToString() : null);
		int num5 = 4;
		X x = this.gparam_4;
		array[num5] = ((x != null) ? x.ToString() : null);
		int num6 = 5;
		Y y = this.gparam_5;
		array[num6] = ((y != null) ? y.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x040014C5 RID: 5317
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x040014C6 RID: 5318
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;

	// Token: 0x040014C7 RID: 5319
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly V gparam_2;

	// Token: 0x040014C8 RID: 5320
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly W gparam_3;

	// Token: 0x040014C9 RID: 5321
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly X gparam_4;

	// Token: 0x040014CA RID: 5322
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Y gparam_5;
}
