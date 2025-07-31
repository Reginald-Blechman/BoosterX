using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Newtonsoft.Json;
using PIManagerX;

// Token: 0x0200059D RID: 1437
public static class GClass250
{
	// Token: 0x060024A8 RID: 9384 RVA: 0x0008D080 File Offset: 0x0008B280
	public static string smethod_0()
	{
		string str = GClass250.smethod_6();
		string text = Path.Combine(Class169.string_4, "BackUpPower.pow");
		Class808.smethod_27("powercfg /export \"" + text + "\" " + str);
		string result = JsonConvert.SerializeObject(new Class253<byte[]>(File.ReadAllBytes(text).smethod_0()));
		File.Delete(text);
		return result;
	}

	// Token: 0x060024A9 RID: 9385 RVA: 0x0008D0D8 File Offset: 0x0008B2D8
	public static byte[] smethod_1()
	{
		string text = GClass250.smethod_6();
		if (text.smethod_9())
		{
			return null;
		}
		string text2 = Path.Combine(Class169.string_4, "BackUpPower.pow");
		Class808.smethod_27("powercfg /export \"" + text2 + "\" " + text);
		if (!File.Exists(text2))
		{
			return null;
		}
		byte[] result = File.ReadAllBytes(text2).smethod_0();
		try
		{
			File.Delete(text2);
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x060024AA RID: 9386 RVA: 0x0001881D File Offset: 0x00016A1D
	public static string smethod_2()
	{
		return GClass250.smethod_3(Guid.Parse(GClass250.smethod_6()));
	}

	// Token: 0x060024AB RID: 9387 RVA: 0x0008D150 File Offset: 0x0008B350
	public static string smethod_3(Guid guid_0)
	{
		uint num = 1024U;
		IntPtr intPtr = Marshal.AllocHGlobal(1024);
		string result;
		try
		{
			PManagerX.PowerReadFriendlyName(IntPtr.Zero, ref guid_0, IntPtr.Zero, IntPtr.Zero, intPtr, ref num);
			result = Marshal.PtrToStringUni(intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	// Token: 0x060024AC RID: 9388 RVA: 0x0001882E File Offset: 0x00016A2E
	public static IEnumerable<Guid> smethod_4()
	{
		return new GClass250.Class695(-2);
	}

	// Token: 0x060024AD RID: 9389 RVA: 0x0008D1AC File Offset: 0x0008B3AC
	public static string[] smethod_5()
	{
		IEnumerable<Guid> enumerable = GClass250.smethod_4();
		string[] array = new string[50];
		int num = 0;
		foreach (Guid guid in enumerable)
		{
			array[num] = guid.ToString();
			num++;
		}
		return array;
	}

	// Token: 0x060024AE RID: 9390 RVA: 0x0008D214 File Offset: 0x0008B414
	public static string smethod_6()
	{
		string result;
		try
		{
			result = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes").GetValue("ActivePowerScheme");
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060024AF RID: 9391 RVA: 0x0008D25C File Offset: 0x0008B45C
	public static string smethod_7()
	{
		string result;
		try
		{
			string str = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes").GetValue("ActivePowerScheme");
			result = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes\\" + str).GetValue("FriendlyName");
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060024B0 RID: 9392 RVA: 0x0008D2CC File Offset: 0x0008B4CC
	public static bool smethod_8()
	{
		bool result;
		try
		{
			string str = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes").GetValue("ActivePowerScheme");
			string text = (string)Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\User\\PowerSchemes\\" + str).GetValue("FriendlyName");
			if (!text.Contains("Balanced") && !text.Contains("High") && !text.Contains("Saver"))
			{
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch
		{
			result = true;
		}
		return result;
	}

	// Token: 0x040017D3 RID: 6099
	private static readonly Regex regex_0 = new Regex("\\(([a-fA-F0-9-]+)\\)", RegexOptions.Compiled);

	// Token: 0x040017D4 RID: 6100
	private static readonly Regex regex_1 = new Regex("(.*?) \\(", RegexOptions.Compiled);

	// Token: 0x0200059E RID: 1438
	private sealed class Class695 : IDisposable, IEnumerable<Guid>, IEnumerator<Guid>, IEnumerable, IEnumerator
	{
		// Token: 0x060024B1 RID: 9393 RVA: 0x00018837 File Offset: 0x00016A37
		[DebuggerHidden]
		public Class695(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00018851 File Offset: 0x00016A51
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x0008D36C File Offset: 0x0008B56C
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				uint num2 = this.uint_1;
				this.uint_1 = num2 + 1U;
			}
			else
			{
				this.int_0 = -1;
				this.guid_1 = Guid.Empty;
				this.uint_0 = (uint)Marshal.SizeOf(typeof(Guid));
				this.uint_1 = 0U;
			}
			if (PManagerX.PowerEnumerate(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, 16U, this.uint_1, ref this.guid_1, ref this.uint_0) != 0U)
			{
				return false;
			}
			this.guid_0 = this.guid_1;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x0001885B File Offset: 0x00016A5B
		Guid IEnumerator<Guid>.Current
		{
			[DebuggerHidden]
			get
			{
				return this.guid_0;
			}
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000031EC File Offset: 0x000013EC
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x00018863 File Offset: 0x00016A63
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.guid_0;
			}
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0008D410 File Offset: 0x0008B610
		[DebuggerHidden]
		IEnumerator<Guid> IEnumerable<Guid>.GetEnumerator()
		{
			GClass250.Class695 result;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				result = this;
			}
			else
			{
				result = new GClass250.Class695(0);
			}
			return result;
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00018870 File Offset: 0x00016A70
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.System.Collections.Generic.IEnumerable<System.Guid>.GetEnumerator();
		}

		// Token: 0x040017D5 RID: 6101
		private int int_0;

		// Token: 0x040017D6 RID: 6102
		private Guid guid_0;

		// Token: 0x040017D7 RID: 6103
		private int int_1;

		// Token: 0x040017D8 RID: 6104
		private Guid guid_1;

		// Token: 0x040017D9 RID: 6105
		private uint uint_0;

		// Token: 0x040017DA RID: 6106
		private uint uint_1;
	}

	// Token: 0x0200059F RID: 1439
	public sealed class GClass251
	{
		// Token: 0x060024BA RID: 9402 RVA: 0x00018878 File Offset: 0x00016A78
		public Guid method_0()
		{
			return this.guid_0;
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00018880 File Offset: 0x00016A80
		public void method_1(Guid guid_1)
		{
			this.guid_0 = guid_1;
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x00018889 File Offset: 0x00016A89
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x00018891 File Offset: 0x00016A91
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x040017DB RID: 6107
		private Guid guid_0;

		// Token: 0x040017DC RID: 6108
		private string string_0;
	}

	// Token: 0x020005A0 RID: 1440
	public enum GEnum13 : uint
	{

	}
}
