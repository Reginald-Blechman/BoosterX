using System;
using PIManagerX;

// Token: 0x02000697 RID: 1687
internal sealed class Class811
{
	// Token: 0x06002AD2 RID: 10962 RVA: 0x000A4FE0 File Offset: 0x000A31E0
	public static void smethod_0(bool bool_0)
	{
		PManagerX.SystemParametersInfo(4163U, 0U, bool_0, 3U);
		PManagerX.SystemParametersInfo(4159U, 0U, bool_0, 3U);
		PManagerX.SystemParametersInfo(4119U, 0U, bool_0, 3U);
		PManagerX.SystemParametersInfo(4099U, 0U, bool_0, 3U);
		PManagerX.SystemParametersInfo(4101U, 0U, bool_0, 3U);
		PManagerX.ANIMATIONINFO animationinfo;
		animationinfo..ctor(0);
		PManagerX.SystemParametersInfo(73U, animationinfo.cbSize, ref animationinfo, 3U);
	}
}
