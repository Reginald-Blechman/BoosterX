using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020006B8 RID: 1720
internal sealed class Class833<T, U, V>
{
	// Token: 0x06002B67 RID: 11111 RVA: 0x0001C0C4 File Offset: 0x0001A2C4
	[DebuggerHidden]
	public Class833(T gparam_3, U gparam_4, V gparam_5)
	{
		this.gparam_0 = gparam_3;
		this.gparam_1 = gparam_4;
		this.gparam_2 = gparam_5;
	}

	// Token: 0x17000722 RID: 1826
	// (get) Token: 0x06002B68 RID: 11112 RVA: 0x0001C0E1 File Offset: 0x0001A2E1
	public T Email
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x17000723 RID: 1827
	// (get) Token: 0x06002B69 RID: 11113 RVA: 0x0001C0E9 File Offset: 0x0001A2E9
	public U Key
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x17000724 RID: 1828
	// (get) Token: 0x06002B6A RID: 11114 RVA: 0x0001C0F1 File Offset: 0x0001A2F1
	public V HWID
	{
		get
		{
			return this.gparam_2;
		}
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x000A6E04 File Offset: 0x000A5004
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class833<T, U, V> @class = obj as Class833<T, U, V>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1) && EqualityComparer<V>.Default.Equals(this.gparam_2, @class.gparam_2));
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x000A6E6C File Offset: 0x000A506C
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-1567634123 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.gparam_2);
	}

	// Token: 0x06002B6D RID: 11117 RVA: 0x000A6EC0 File Offset: 0x000A50C0
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Email = {0}, Key = {1}, HWID = {2} }}";
		object[] array = new object[3];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		int num3 = 2;
		V v = this.gparam_2;
		array[num3] = ((v != null) ? v.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04001C37 RID: 7223
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x04001C38 RID: 7224
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;

	// Token: 0x04001C39 RID: 7225
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly V gparam_2;
}
