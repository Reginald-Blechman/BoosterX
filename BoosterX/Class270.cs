using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000243 RID: 579
internal sealed class Class270<T, U>
{
	// Token: 0x06000FBE RID: 4030 RVA: 0x0000B81D File Offset: 0x00009A1D
	[DebuggerHidden]
	public Class270(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0000B833 File Offset: 0x00009A33
	public T Key
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0000B83B File Offset: 0x00009A3B
	public U ExistingIds
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x000556C8 File Offset: 0x000538C8
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class270<T, U> @class = obj as Class270<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x0000B843 File Offset: 0x00009A43
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-1112793680 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x00055718 File Offset: 0x00053918
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Key = {0}, ExistingIds = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000A0B RID: 2571
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x04000A0C RID: 2572
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;
}
