using System;

// Token: 0x0200068C RID: 1676
public abstract class GClass282<T> : GInterface7<T>, GInterface16
{
	// Token: 0x06002A5A RID: 10842 RVA: 0x0001B921 File Offset: 0x00019B21
	protected void method_0(Action<GInterface7<T>, T> action_2)
	{
		this.action_0 = action_2;
	}

	// Token: 0x06002A5B RID: 10843 RVA: 0x000A3758 File Offset: 0x000A1958
	public void imethod_3(T gparam_0)
	{
		try
		{
			Action<GInterface7<T>, T> action = this.action_0;
			if (action != null)
			{
				action(this, gparam_0);
			}
		}
		catch (Exception exception_)
		{
			GClass268.smethod_2(exception_, "Tweak error");
		}
	}

	// Token: 0x06002A5C RID: 10844 RVA: 0x0001B92A File Offset: 0x00019B2A
	public void imethod_2(Action<string, GEnum15> action_2)
	{
		this.action_1 = action_2;
	}

	// Token: 0x06002A5D RID: 10845 RVA: 0x0001B933 File Offset: 0x00019B33
	protected void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06002A5E RID: 10846 RVA: 0x0001B93C File Offset: 0x00019B3C
	public string imethod_0()
	{
		return this.string_0;
	}

	// Token: 0x06002A5F RID: 10847 RVA: 0x0001B944 File Offset: 0x00019B44
	public void imethod_1(string string_1, GEnum15 genum15_0 = (GEnum15)1)
	{
		Action<string, GEnum15> action = this.action_1;
		if (action == null)
		{
			return;
		}
		action(string_1, genum15_0);
	}

	// Token: 0x04001BAA RID: 7082
	private Action<GInterface7<T>, T> action_0;

	// Token: 0x04001BAB RID: 7083
	private Action<string, GEnum15> action_1;

	// Token: 0x04001BAC RID: 7084
	private string string_0;
}
