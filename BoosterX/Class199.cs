using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x0200018B RID: 395
internal sealed class Class199<T>
{
	// Token: 0x06000B03 RID: 2819 RVA: 0x00008BC6 File Offset: 0x00006DC6
	[DebuggerHidden]
	public Class199(T gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00008BD5 File Offset: 0x00006DD5
	public T Id
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x000499CC File Offset: 0x00047BCC
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class199<T> @class = obj as Class199<T>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0));
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x00008BDD File Offset: 0x00006DDD
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -1271893453 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x00049A04 File Offset: 0x00047C04
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Id = {0} }}";
		object[] array = new object[1];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000733 RID: 1843
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;
}
