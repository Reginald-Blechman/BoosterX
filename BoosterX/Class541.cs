using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000466 RID: 1126
internal sealed class Class541<T>
{
	// Token: 0x06001D59 RID: 7513 RVA: 0x000136F9 File Offset: 0x000118F9
	[DebuggerHidden]
	public Class541(T gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	// Token: 0x17000505 RID: 1285
	// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00013708 File Offset: 0x00011908
	public T text
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x00079CB0 File Offset: 0x00077EB0
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class541<T> @class = obj as Class541<T>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0));
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x00013710 File Offset: 0x00011910
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return -1795380579 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x00079CE8 File Offset: 0x00077EE8
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ text = {0} }}";
		object[] array = new object[1];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x0400137D RID: 4989
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;
}
