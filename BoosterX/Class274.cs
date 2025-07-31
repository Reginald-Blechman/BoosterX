using System;
using System.Diagnostics;

// Token: 0x02000255 RID: 597
internal sealed class Class274
{
	// Token: 0x06001019 RID: 4121 RVA: 0x0000BC12 File Offset: 0x00009E12
	public static void smethod_0(string string_0)
	{
		Class808.smethod_27("wevtutil sl " + string_0 + " /e:false /q");
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x0000BC2B File Offset: 0x00009E2B
	public static void smethod_1(string string_0)
	{
		Class808.smethod_27("wevtutil sl " + string_0 + " /e:true /q");
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00056F5C File Offset: 0x0005515C
	public static bool smethod_2(string string_0)
	{
		bool result;
		try
		{
			string text = string.Empty;
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.FileName = "wevtutil.exe";
			process.StartInfo.Arguments = "gl " + string_0;
			process.Start();
			text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			result = text.ToLower().Contains("enabled: true");
		}
		catch (Exception exception_)
		{
			GClass268.smethod_1(exception_);
			result = false;
		}
		return result;
	}
}
