using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000258 RID: 600
internal sealed class Class276<T, U>
{
	// Token: 0x06001036 RID: 4150 RVA: 0x0000BDFC File Offset: 0x00009FFC
	[DebuggerHidden]
	public Class276(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06001037 RID: 4151 RVA: 0x0000BE12 File Offset: 0x0000A012
	public T Id
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06001038 RID: 4152 RVA: 0x0000BE1A File Offset: 0x0000A01A
	public U Json
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x00057014 File Offset: 0x00055214
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class276<T, U> @class = obj as Class276<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x0000BE22 File Offset: 0x0000A022
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1584378345 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00057064 File Offset: 0x00055264
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ Id = {0}, Json = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000A38 RID: 2616
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x04000A39 RID: 2617
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;
}
