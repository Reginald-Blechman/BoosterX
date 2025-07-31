using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x0200050B RID: 1291
internal sealed class Class617<T, U>
{
	// Token: 0x060020B4 RID: 8372 RVA: 0x000159AF File Offset: 0x00013BAF
	[DebuggerHidden]
	public Class617(T gparam_2, U gparam_3)
	{
		this.gparam_0 = gparam_2;
		this.gparam_1 = gparam_3;
	}

	// Token: 0x1700059F RID: 1439
	// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000159C5 File Offset: 0x00013BC5
	public T DiscordUserName
	{
		get
		{
			return this.gparam_0;
		}
	}

	// Token: 0x170005A0 RID: 1440
	// (get) Token: 0x060020B6 RID: 8374 RVA: 0x000159CD File Offset: 0x00013BCD
	public U Key
	{
		get
		{
			return this.gparam_1;
		}
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x00083524 File Offset: 0x00081724
	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class617<T, U> @class = obj as Class617<T, U>;
		return this == @class || (@class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1));
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x000159D5 File Offset: 0x00013BD5
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1886838585 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x00083574 File Offset: 0x00081774
	[DebuggerHidden]
	[return: Attribute10(1)]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ DiscordUserName = {0}, Key = {1} }}";
		object[] array = new object[2];
		int num = 0;
		T t = this.gparam_0;
		array[num] = ((t != null) ? t.ToString() : null);
		int num2 = 1;
		U u = this.gparam_1;
		array[num2] = ((u != null) ? u.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x040015AA RID: 5546
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	// Token: 0x040015AB RID: 5547
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;
}
