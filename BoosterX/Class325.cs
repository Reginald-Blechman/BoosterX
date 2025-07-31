using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020002B4 RID: 692
internal sealed class Class325<T, U, V>
{
	// Token: 0x06001250 RID: 4688 RVA: 0x0000D212 File Offset: 0x0000B412
	[DebuggerHidden]
	public Class325(T gparam_3, U gparam_4, V gparam_5)
	{
		this.gparam_0 = gparam_3;
		this.gparam_1 = gparam_4;
		this.gparam_2 = gparam_5;
	}

	// Token: 0x17000297 RID: 663
	// (get) Token: 0x06001251 RID: 4689 RVA: 0x0000D22F File Offset: 0x0000B42F
	public T Key
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x06001252 RID: 4690 RVA: 0x0000D237 File Offset: 0x0000B437
	public U Id
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x06001253 RID: 4691 RVA: 0x0000D23F File Offset: 0x0000B43F
	public V Json
	{
		get
		{
			return this.gparam_2;
		}
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x0005C398 File Offset: 0x0005A598
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class325<T, U, V> @class = obj as Class325<T, U, V>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1) && EqualityComparer<V>.Default.Equals(this.gparam_2, @class.gparam_2));
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x0005C400 File Offset: 0x0005A600
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-1690658872 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.gparam_2);
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x0005C454 File Offset: 0x0005A654
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Key = {0}, Id = {1}, Json = {2} }}";
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

	// Token: 0x04000B82 RID: 2946
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x04000B83 RID: 2947
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;

	// Token: 0x04000B84 RID: 2948
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly V gparam_2;
}
