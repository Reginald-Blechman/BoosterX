using System;
using System.Threading;

// Token: 0x0200055A RID: 1370
internal sealed class Class657
{
	// Token: 0x06002262 RID: 8802 RVA: 0x000894F4 File Offset: 0x000876F4
	public static void smethod_0(Class657.Delegate31 delegate31_1)
	{
		Class657.Delegate31 @delegate = Class657.delegate31_0;
		Class657.Delegate31 delegate2;
		do
		{
			delegate2 = @delegate;
			Class657.Delegate31 value = (Class657.Delegate31)Delegate.Combine(delegate2, delegate31_1);
			@delegate = Interlocked.CompareExchange<Class657.Delegate31>(ref Class657.delegate31_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x00089528 File Offset: 0x00087728
	public static void smethod_1(Class657.Delegate31 delegate31_1)
	{
		Class657.Delegate31 @delegate = Class657.delegate31_0;
		Class657.Delegate31 delegate2;
		do
		{
			delegate2 = @delegate;
			Class657.Delegate31 value = (Class657.Delegate31)Delegate.Remove(delegate2, delegate31_1);
			@delegate = Interlocked.CompareExchange<Class657.Delegate31>(ref Class657.delegate31_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06002264 RID: 8804 RVA: 0x000168BD File Offset: 0x00014ABD
	public static void smethod_2()
	{
		Class657.Delegate31 @delegate = Class657.delegate31_0;
		if (@delegate == null)
		{
			return;
		}
		@delegate();
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x0008955C File Offset: 0x0008775C
	public static void smethod_3(GClass181 gclass181_0)
	{
		Class808.smethod_27(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\",
			gclass181_0.Name,
			"\" /v \"ExeName\" /t REG_SZ /d \"",
			gclass181_0.ExeName,
			"\" /f"
		}));
		Class808.smethod_27(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\",
			gclass181_0.Name,
			"\" /v \"GamePath\" /t REG_SZ /d \"",
			gclass181_0.ExeDir,
			"\" /f"
		}));
		Class808.smethod_27(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\",
			gclass181_0.Name,
			"\" /v \"FoundIn\" /t REG_SZ /d \"",
			gclass181_0.FoundIn,
			"\" /f"
		}));
		Class808.smethod_27("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + gclass181_0.Name + "\" /v \"Affinity\" /t REG_SZ /d \"\" /f");
		Class808.smethod_27("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + gclass181_0.Name + "\" /v \"DisableDWM\" /t REG_SZ /d \"False\" /f");
		Class808.smethod_27("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + gclass181_0.Name + "\" /v \"DisableExplorer\" /t REG_SZ /d \"False\" /f");
		Class808.smethod_27("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + gclass181_0.Name + "\" /v \"UseGlobalProfile\" /t REG_SZ /d \"True\" /f");
		Class808.smethod_27("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + gclass181_0.Name + "\" /v \"ThreadCompatibility\" /t REG_SZ /d \"False\" /f");
		Class808.smethod_27("Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + gclass181_0.Name + "\" /v \"LaunchDelay\" /t REG_SZ /d \"0\" /f");
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x000168CE File Offset: 0x00014ACE
	public static void smethod_4(Class499 class499_0)
	{
		Class808.smethod_27("Reg.exe delete \"HKCU\\SOFTWARE\\GameModeX\\Games\\" + class499_0.Name + "\" /f");
	}

	// Token: 0x06002267 RID: 8807 RVA: 0x000896C8 File Offset: 0x000878C8
	public static void smethod_5(GClass167 gclass167_0)
	{
		Class808.smethod_27(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Apps\\",
			gclass167_0.Name,
			"\" /v \"ExeName\" /t REG_SZ /d \"",
			gclass167_0.ExeName,
			"\" /f"
		}));
		Class808.smethod_27(string.Concat(new string[]
		{
			"Reg.exe add \"HKCU\\SOFTWARE\\GameModeX\\Apps\\",
			gclass167_0.Name,
			"\" /v \"ExeDir\" /t REG_SZ /d \"",
			gclass167_0.ExeDir,
			"\" /f"
		}));
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x000168EC File Offset: 0x00014AEC
	public static void smethod_6(Class500 class500_0)
	{
		Class808.smethod_27("Reg.exe delete \"HKCU\\SOFTWARE\\GameModeX\\Apps\\" + class500_0.Name + "\" /f");
	}

	// Token: 0x040016EB RID: 5867
	private static Class657.Delegate31 delegate31_0;

	// Token: 0x0200055B RID: 1371
	// (Invoke) Token: 0x0600226A RID: 8810
	public delegate void Delegate31();
}
