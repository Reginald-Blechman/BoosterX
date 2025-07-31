using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x0200021C RID: 540
internal sealed class Class253<T>
{
	// Token: 0x06000EA4 RID: 3748 RVA: 0x0000AD96 File Offset: 0x00008F96
	[DebuggerHidden]
	public Class253(T Data)
	{
		this.gparam_0 = Data;
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0000ADA5 File Offset: 0x00008FA5
	public T Data
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00052C60 File Offset: 0x00050E60
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class253<T> @class = obj as Class253<T>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0));
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x0000ADAD File Offset: 0x00008FAD
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 1150210300 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00052C98 File Offset: 0x00050E98
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Data = {0} }}";
		object[] array = new object[1];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000976 RID: 2422
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;
}
