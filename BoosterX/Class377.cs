using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x0200031B RID: 795
internal sealed class Class377<T, U, V, W, X>
{
	// Token: 0x0600147A RID: 5242 RVA: 0x0000E45D File Offset: 0x0000C65D
	[DebuggerHidden]
	public Class377(T gparam_5, U gparam_6, V gparam_7, W gparam_8, X gparam_9)
	{
		this.gparam_0 = gparam_5;
		this.gparam_1 = gparam_6;
		this.gparam_2 = gparam_7;
		this.gparam_3 = gparam_8;
		this.gparam_4 = gparam_9;
	}

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x0600147B RID: 5243 RVA: 0x0000E48A File Offset: 0x0000C68A
	public T Key
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x0600147C RID: 5244 RVA: 0x0000E492 File Offset: 0x0000C692
	public U Name
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x0600147D RID: 5245 RVA: 0x0000E49A File Offset: 0x0000C69A
	public V CreationDate
	{
		get
		{
			return this.gparam_2;
		}
	}

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x0600147E RID: 5246 RVA: 0x0000E4A2 File Offset: 0x0000C6A2
	public W Id
	{
		get
		{
			return this.gparam_3;
		}
	}

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x0600147F RID: 5247 RVA: 0x0000E4AA File Offset: 0x0000C6AA
	public X Data
	{
		get
		{
			return this.gparam_4;
		}
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x00064634 File Offset: 0x00062834
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class377<T, U, V, W, X> @class = obj as Class377<T, U, V, W, X>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1) && EqualityComparer<V>.Default.Equals(this.gparam_2, @class.gparam_2) && EqualityComparer<W>.Default.Equals(this.gparam_3, @class.gparam_3) && EqualityComparer<X>.Default.Equals(this.gparam_4, @class.gparam_4));
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x000646CC File Offset: 0x000628CC
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((((-1554103958 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(this.gparam_2)) * -1521134295 + EqualityComparer<W>.Default.GetHashCode(this.gparam_3)) * -1521134295 + EqualityComparer<X>.Default.GetHashCode(this.gparam_4);
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x0006474C File Offset: 0x0006294C
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Key = {0}, Name = {1}, CreationDate = {2}, Id = {3}, Data = {4} }}";
		object[] array = new object[5];
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
		return string.Format(provider, format, array);
	}

	// Token: 0x04000DBC RID: 3516
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x04000DBD RID: 3517
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;

	// Token: 0x04000DBE RID: 3518
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly V gparam_2;

	// Token: 0x04000DBF RID: 3519
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly W gparam_3;

	// Token: 0x04000DC0 RID: 3520
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly X gparam_4;
}
