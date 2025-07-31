using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x0200067F RID: 1663
internal sealed class Class786<T, U>
{
	// Token: 0x06002A1B RID: 10779 RVA: 0x0001B771 File Offset: 0x00019971
	[DebuggerHidden]
	public Class786(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x06002A1C RID: 10780 RVA: 0x0001B787 File Offset: 0x00019987
	public T method_0()
	{
		return this.gparam_0;
	}

	// Token: 0x06002A1D RID: 10781 RVA: 0x0001B78F File Offset: 0x0001998F
	public U method_1()
	{
		return this.gparam_1;
	}

	// Token: 0x06002A1E RID: 10782 RVA: 0x000A3284 File Offset: 0x000A1484
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class786<T, U> @class = obj as Class786<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x06002A1F RID: 10783 RVA: 0x0001B797 File Offset: 0x00019997
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (610295608 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x06002A20 RID: 10784 RVA: 0x000A32D4 File Offset: 0x000A14D4
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ rec = {0}, dist = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04001B8F RID: 7055
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x04001B90 RID: 7056
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;
}
