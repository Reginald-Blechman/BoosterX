using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020005C9 RID: 1481
internal sealed class Class710<T, U>
{
	// Token: 0x0600260B RID: 9739 RVA: 0x00019521 File Offset: 0x00017721
	[DebuggerHidden]
	public Class710(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x1700066B RID: 1643
	// (get) Token: 0x0600260C RID: 9740 RVA: 0x00019537 File Offset: 0x00017737
	public T Email
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x0600260D RID: 9741 RVA: 0x0001953F File Offset: 0x0001773F
	public U Key
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x000924EC File Offset: 0x000906EC
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class710<T, U> @class = obj as Class710<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x00019547 File Offset: 0x00017747
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (319815229 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x0009253C File Offset: 0x0009073C
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Email = {0}, Key = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x040018F5 RID: 6389
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x040018F6 RID: 6390
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;
}
