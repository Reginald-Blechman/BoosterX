using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x0200031D RID: 797
internal sealed class Class378<T, U>
{
	// Token: 0x06001483 RID: 5251 RVA: 0x0000E4B2 File Offset: 0x0000C6B2
	[DebuggerHidden]
	public Class378(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x170002FD RID: 765
	// (get) Token: 0x06001484 RID: 5252 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
	public T Email
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x170002FE RID: 766
	// (get) Token: 0x06001485 RID: 5253 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
	public U Lang
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00064834 File Offset: 0x00062A34
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class378<T, U> @class = obj as Class378<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (2087975370 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00064884 File Offset: 0x00062A84
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Email = {0}, Lang = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000DC2 RID: 3522
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x04000DC3 RID: 3523
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;
}
