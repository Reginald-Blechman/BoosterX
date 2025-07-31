using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using TsudaKageyu;

// Token: 0x02000645 RID: 1605
internal sealed class Class765
{
	// Token: 0x060028B6 RID: 10422 RVA: 0x0009EBA8 File Offset: 0x0009CDA8
	public static bool smethod_0(string string_0)
	{
		return !new Regex("[" + Regex.Escape(new string(Path.GetInvalidPathChars())) + "]").IsMatch(string_0) && !Regex.IsMatch(string_0, "([\\*\\?\\|\\\\/<>:]+)|([\\. ]+$)|^(CON|PRN|AUX|NUL|COM[1-9]|LPT[1-9])(\\.|$)", RegexOptions.IgnoreCase);
	}

	// Token: 0x060028B7 RID: 10423 RVA: 0x0001AD89 File Offset: 0x00018F89
	public static void smethod_1(string string_0, string string_1)
	{
		FileInfo fileInfo = new FileInfo(string_0);
		fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + string_1);
	}

	// Token: 0x060028B8 RID: 10424 RVA: 0x0009EBF4 File Offset: 0x0009CDF4
	public static string smethod_2(string string_0, string string_1)
	{
		foreach (string text in Directory.GetFiles(string_0))
		{
			if (text.Split(new char[]
			{
				'\\'
			}).Last<string>().Contains(string_1))
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x060028B9 RID: 10425 RVA: 0x0009EC3C File Offset: 0x0009CE3C
	public static string smethod_3(string string_0, string string_1)
	{
		foreach (string text in Directory.GetDirectories(string_0))
		{
			if (text.Split(new char[]
			{
				'\\'
			}).Last<string>().Contains(string_1))
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x060028BA RID: 10426 RVA: 0x0009EC84 File Offset: 0x0009CE84
	public static void smethod_4(string string_0, string string_1, string string_2, string string_3, bool bool_0)
	{
		using (Stream manifestResourceStream = Assembly.GetCallingAssembly().GetManifestResourceStream(string_0 + "." + ((string_2 == string.Empty) ? string.Empty : (string_2 + ".")) + string_3))
		{
			BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
			try
			{
				FileStream fileStream = new FileStream(string_1 + "\\" + string_3, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
				try
				{
					BinaryWriter binaryWriter = new BinaryWriter(fileStream);
					try
					{
						binaryWriter.Write(binaryReader.ReadBytes((int)manifestResourceStream.Length));
					}
					finally
					{
						((IDisposable)binaryWriter).Dispose();
					}
				}
				finally
				{
					((IDisposable)fileStream).Dispose();
				}
			}
			finally
			{
				((IDisposable)binaryReader).Dispose();
			}
		}
		if (bool_0)
		{
			string path = Path.Combine(string_1, string_3);
			File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);
		}
	}

	// Token: 0x060028BB RID: 10427 RVA: 0x0005F6D0 File Offset: 0x0005D8D0
	public static BitmapImage smethod_5(string string_0)
	{
		BitmapImage result;
		try
		{
			result = new BitmapImage(new Uri(string_0));
		}
		catch (Exception exception_)
		{
			GClass268.smethod_1(exception_);
			result = new BitmapImage();
		}
		return result;
	}

	// Token: 0x060028BC RID: 10428 RVA: 0x0009ED70 File Offset: 0x0009CF70
	public static Task<BitmapSource> smethod_6(string string_0)
	{
		Class765.Struct437 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<BitmapSource>.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class765.Struct437>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060028BD RID: 10429 RVA: 0x0009EDB4 File Offset: 0x0009CFB4
	public static Task<BitmapImage> smethod_7(string string_0)
	{
		Class765.Struct435 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<BitmapImage>.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class765.Struct435>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060028BE RID: 10430 RVA: 0x0009EDF8 File Offset: 0x0009CFF8
	public static BitmapSource smethod_8()
	{
		if (Class765.bitmapSource_0 != null)
		{
			return Class765.bitmapSource_0;
		}
		try
		{
			Class765.Class768 @class = new Class765.Class768();
			@class.bitmapSource_0 = null;
			Process currentProcess = Process.GetCurrentProcess();
			@class.icon_0 = Icon.ExtractAssociatedIcon(currentProcess.MainModule.FileName);
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			Class765.bitmapSource_0 = @class.bitmapSource_0;
		}
		catch
		{
			Application.Current.Dispatcher.Invoke(new Action(Class765.Class771.class771_0.method_0));
		}
		return Class765.bitmapSource_0;
	}

	// Token: 0x060028BF RID: 10431 RVA: 0x0009EEAC File Offset: 0x0009D0AC
	public static string smethod_9(string string_0)
	{
		Class765.Class769 @class = new Class765.Class769();
		((Class765.Interface16)@class).imethod_3(string_0, 0U);
		StringBuilder stringBuilder = new StringBuilder(260);
		Class765.Struct436 @struct = default(Class765.Struct436);
		((Class765.Interface17)@class).imethod_0(stringBuilder, stringBuilder.Capacity, out @struct, (Class765.Enum21)0);
		return stringBuilder.ToString();
	}

	// Token: 0x060028C0 RID: 10432 RVA: 0x0009EEF8 File Offset: 0x0009D0F8
	public static void smethod_10(bool bool_0, string string_0, string string_1, string string_2)
	{
		try
		{
			string[] array = File.ReadAllLines(string_2);
			int num = 0;
			if (bool_0)
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] == string_0)
					{
						break;
					}
					num++;
				}
			}
			else
			{
				string[] array2 = array;
				int i = 0;
				while (i < array2.Length && !array2[i].Contains(string_0))
				{
					num++;
					i++;
				}
			}
			array[num] = string_1;
			File.Delete(string_2);
			FileStream fileStream = new FileStream(string_2, FileMode.Create);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream);
				try
				{
					foreach (string value in array)
					{
						streamWriter.WriteLine(value);
					}
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		catch
		{
		}
	}

	// Token: 0x060028C1 RID: 10433 RVA: 0x0009EFCC File Offset: 0x0009D1CC
	public static void smethod_11(int int_0, string string_0, string string_1)
	{
		try
		{
			string[] array = File.ReadAllLines(string_1);
			array[int_0] = string_0;
			File.Delete(string_1);
			FileStream fileStream = new FileStream(string_1, FileMode.Create);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream);
				try
				{
					foreach (string value in array)
					{
						streamWriter.WriteLine(value);
					}
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		catch
		{
		}
	}

	// Token: 0x060028C2 RID: 10434 RVA: 0x0009F058 File Offset: 0x0009D258
	public static void smethod_12(bool bool_0, string string_0, string string_1)
	{
		try
		{
			string[] array = File.ReadAllLines(string_1);
			int num = 0;
			if (bool_0)
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] == string_0)
					{
						break;
					}
					num++;
				}
			}
			else
			{
				string[] array2 = array;
				int i = 0;
				while (i < array2.Length && !array2[i].Contains(string_0))
				{
					num++;
					i++;
				}
			}
			File.Delete(string_1);
			FileStream fileStream = new FileStream(string_1, FileMode.Create);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream);
				try
				{
					for (int j = 0; j < array.Length; j++)
					{
						if (j != num)
						{
							streamWriter.WriteLine(array[j]);
						}
					}
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		catch
		{
		}
	}

	// Token: 0x060028C3 RID: 10435 RVA: 0x0009F12C File Offset: 0x0009D32C
	public static long smethod_13(List<string> list_0, string string_0, bool bool_0)
	{
		long num = 0L;
		try
		{
			foreach (string text in list_0)
			{
				if (text.StartsWith("?:\\"))
				{
					foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
					{
						num += Class765.smethod_14(text.Replace("?:\\", driveInfo.Name), string_0, bool_0);
					}
				}
				else
				{
					num += Class765.smethod_14(text, string_0, bool_0);
				}
			}
		}
		catch
		{
		}
		return num;
	}

	// Token: 0x060028C4 RID: 10436 RVA: 0x0009F1E4 File Offset: 0x0009D3E4
	public static long smethod_14(string string_0, string string_1, bool bool_0)
	{
		long num = 0L;
		string[] array = string_1.Split(new char[]
		{
			'|'
		});
		try
		{
			string text = string_0.Replace("%username%", Environment.UserName);
			if (Directory.Exists(text))
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (bool_0)
					{
						num += Class808.smethod_15(text);
					}
					else
					{
						foreach (string fileName in Class765.smethod_15(text, string_1))
						{
							try
							{
								num += new FileInfo(fileName).Length;
							}
							catch
							{
							}
						}
					}
				}
			}
		}
		catch
		{
		}
		return num;
	}

	// Token: 0x060028C5 RID: 10437 RVA: 0x0009F2BC File Offset: 0x0009D4BC
	private static List<string> smethod_15(string string_0, string string_1)
	{
		Class765.Class770 @class = new Class765.Class770();
		@class.list_0 = new List<string>();
		try
		{
			Directory.GetFiles(string_0, string_1).ToList<string>().ForEach(new Action<string>(@class.method_0));
		}
		catch
		{
		}
		return @class.list_0;
	}

	// Token: 0x060028C6 RID: 10438 RVA: 0x0009F314 File Offset: 0x0009D514
	public static string smethod_16(string string_0)
	{
		string text = string.Empty;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache");
			foreach (string text2 in registryKey.GetValueNames())
			{
				if (text2.Contains(string_0.Split(new char[]
				{
					'\\'
				}).Last<string>()) && text2.Contains("FriendlyAppName"))
				{
					text = registryKey.GetValue(text2).ToString();
				}
			}
		}
		catch
		{
		}
		if (text == string.Empty || text == null)
		{
			try
			{
				text = FileVersionInfo.GetVersionInfo(string_0).ProductName;
			}
			catch
			{
			}
		}
		if (text == string.Empty || text == null)
		{
			try
			{
				foreach (string str in Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall").GetSubKeyNames())
				{
					RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + str);
					if (string_0.Contains(registryKey2.GetValue("InstallLocation").ToString().Replace('/', '\\')))
					{
						text = registryKey2.GetValue("DisplayName").ToString();
					}
				}
			}
			catch
			{
			}
		}
		if (text == string.Empty || text == null)
		{
			text = string_0.Split(new char[]
			{
				'\\'
			}).Last<string>();
		}
		return text;
	}

	// Token: 0x060028C7 RID: 10439 RVA: 0x0009F498 File Offset: 0x0009D698
	public static void smethod_17(string string_0, string string_1, Encoding encoding_0)
	{
		Encoding encoding = encoding_0 ?? new UTF8Encoding(false);
		try
		{
			if (!File.Exists(string_0))
			{
				FileSecurity fileSecurity = new FileSecurity();
				fileSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, AccessControlType.Allow));
				using (File.Create(string_0, 1024, FileOptions.None, fileSecurity))
				{
				}
			}
			FileStream fileStream2 = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream2, encoding);
				try
				{
					streamWriter.WriteLine(string_1);
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream2).Dispose();
			}
		}
		catch
		{
		}
	}

	// Token: 0x060028C8 RID: 10440 RVA: 0x0009F558 File Offset: 0x0009D758
	public static void smethod_18(string string_0, string string_1, Encoding encoding_0)
	{
		Encoding encoding = encoding_0 ?? Encoding.Default;
		try
		{
			if (!File.Exists(string_0))
			{
				FileSecurity fileSecurity = new FileSecurity();
				fileSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, AccessControlType.Allow));
				using (File.Create(string_0, 1024, FileOptions.None, fileSecurity))
				{
				}
			}
			FileStream fileStream2 = new FileStream(string_0, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream2, encoding);
				try
				{
					streamWriter.WriteLine(string_1);
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream2).Dispose();
			}
		}
		catch
		{
		}
	}

	// Token: 0x060028C9 RID: 10441 RVA: 0x0001ADAD File Offset: 0x00018FAD
	public static void smethod_19(string string_0)
	{
		Class808.smethod_27("takeown /f \"" + string_0 + "\"");
		Class808.smethod_27("icacls \"" + string_0 + "\" /grant *S-1-5-32-544:F");
	}

	// Token: 0x04001AC3 RID: 6851
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x04001AC4 RID: 6852
	private static readonly SemaphoreSlim semaphoreSlim_1 = new SemaphoreSlim(1, 1);

	// Token: 0x04001AC5 RID: 6853
	private static BitmapSource bitmapSource_0 = null;

	// Token: 0x02000646 RID: 1606
	private sealed class Class766
	{
		// Token: 0x060028CB RID: 10443 RVA: 0x0001ADDD File Offset: 0x00018FDD
		internal BitmapImage method_0()
		{
			BitmapImage bitmapImage = new BitmapImage();
			bitmapImage.BeginInit();
			bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
			bitmapImage.UriSource = new Uri(this.string_0, UriKind.RelativeOrAbsolute);
			bitmapImage.EndInit();
			bitmapImage.Freeze();
			return bitmapImage;
		}

		// Token: 0x04001AC6 RID: 6854
		public string string_0;
	}

	// Token: 0x02000647 RID: 1607
	[StructLayout(LayoutKind.Auto)]
	private struct Struct435 : IAsyncStateMachine
	{
		// Token: 0x060028CC RID: 10444 RVA: 0x0009F618 File Offset: 0x0009D818
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			BitmapImage result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.class766_0 = new Class765.Class766();
					this.class766_0.string_0 = this.string_0;
					awaiter = Class765.semaphoreSlim_1.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						goto IL_9C;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
				}
				awaiter.GetResult();
				try
				{
					result = Application.Current.Dispatcher.Invoke<BitmapImage>(new Func<BitmapImage>(this.class766_0.method_0));
					goto IL_DA;
				}
				catch
				{
					result = null;
					goto IL_DA;
				}
				finally
				{
					if (num < 0)
					{
						Class765.semaphoreSlim_1.Release();
					}
				}
				IL_9C:
				int num3 = 0;
				num = 0;
				this.int_0 = num3;
				this.taskAwaiter_0 = awaiter;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class765.Struct435>(ref awaiter, ref this);
				return;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class766_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_DA:
			this.int_0 = -2;
			this.class766_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0001AE0F File Offset: 0x0001900F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001AC7 RID: 6855
		public int int_0;

		// Token: 0x04001AC8 RID: 6856
		public AsyncTaskMethodBuilder<BitmapImage> asyncTaskMethodBuilder_0;

		// Token: 0x04001AC9 RID: 6857
		public string string_0;

		// Token: 0x04001ACA RID: 6858
		private Class765.Class766 class766_0;

		// Token: 0x04001ACB RID: 6859
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000648 RID: 1608
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct Struct436
	{
		// Token: 0x04001ACC RID: 6860
		public uint uint_0;

		// Token: 0x04001ACD RID: 6861
		public long long_0;

		// Token: 0x04001ACE RID: 6862
		public long long_1;

		// Token: 0x04001ACF RID: 6863
		public long long_2;

		// Token: 0x04001AD0 RID: 6864
		public uint uint_1;

		// Token: 0x04001AD1 RID: 6865
		public uint uint_2;

		// Token: 0x04001AD2 RID: 6866
		public uint uint_3;

		// Token: 0x04001AD3 RID: 6867
		public uint uint_4;

		// Token: 0x04001AD4 RID: 6868
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		// Token: 0x04001AD5 RID: 6869
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string string_1;
	}

	// Token: 0x02000649 RID: 1609
	[StructLayout(LayoutKind.Auto)]
	private struct Struct437 : IAsyncStateMachine
	{
		// Token: 0x060028CE RID: 10446 RVA: 0x0009F744 File Offset: 0x0009D944
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			BitmapSource result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.class767_0 = new Class765.Class767();
					awaiter = Class765.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class765.Struct437>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				if (this.string_0.smethod_9())
				{
					result = Class765.smethod_8();
				}
				else
				{
					this.class767_0.bitmapSource_0 = new BitmapImage();
					try
					{
						IconExtractor iconExtractor = new IconExtractor(this.string_0.smethod_3());
						string fileName = iconExtractor.FileName;
						Icon[] array = IconUtil.Split(iconExtractor.GetAllIcons()[0]);
						Icon icon = array[0];
						int num4 = array[0].Width * array[0].Height;
						foreach (Icon icon2 in array)
						{
							int num5 = icon2.Width * icon2.Height;
							if (num5 > num4)
							{
								num4 = num5;
								icon = icon2;
							}
						}
						this.class767_0.bitmap_0 = IconUtil.ToBitmap(icon);
						Application.Current.Dispatcher.Invoke(new Action(this.class767_0.method_0));
					}
					catch
					{
						result = Class765.smethod_8();
						goto IL_18F;
					}
					finally
					{
						if (num < 0)
						{
							Class765.semaphoreSlim_0.Release();
						}
					}
					result = this.class767_0.bitmapSource_0;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class767_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_18F:
			this.int_0 = -2;
			this.class767_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0001AE1D File Offset: 0x0001901D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001AD6 RID: 6870
		public int int_0;

		// Token: 0x04001AD7 RID: 6871
		public AsyncTaskMethodBuilder<BitmapSource> asyncTaskMethodBuilder_0;

		// Token: 0x04001AD8 RID: 6872
		public string string_0;

		// Token: 0x04001AD9 RID: 6873
		private Class765.Class767 class767_0;

		// Token: 0x04001ADA RID: 6874
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200064A RID: 1610
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[ComImport]
	internal interface Interface15
	{
		// Token: 0x060028D0 RID: 10448
		void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out IntPtr intptr_0, int int_1);

		// Token: 0x060028D1 RID: 10449
		void imethod_1(out IntPtr intptr_0);

		// Token: 0x060028D2 RID: 10450
		void imethod_2(IntPtr intptr_0);

		// Token: 0x060028D3 RID: 10451
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x060028D4 RID: 10452
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x060028D5 RID: 10453
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x060028D6 RID: 10454
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x060028D7 RID: 10455
		void imethod_7([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x060028D8 RID: 10456
		void imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x060028D9 RID: 10457
		void imethod_9(out short short_0);

		// Token: 0x060028DA RID: 10458
		void imethod_10(short short_0);

		// Token: 0x060028DB RID: 10459
		void imethod_11(out int int_0);

		// Token: 0x060028DC RID: 10460
		void imethod_12(int int_0);

		// Token: 0x060028DD RID: 10461
		void imethod_13([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out int int_1);

		// Token: 0x060028DE RID: 10462
		void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x060028DF RID: 10463
		void imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x060028E0 RID: 10464
		void imethod_16(IntPtr intptr_0, int int_0);

		// Token: 0x060028E1 RID: 10465
		void imethod_17([MarshalAs(UnmanagedType.LPWStr)] string string_0);
	}

	// Token: 0x0200064B RID: 1611
	private sealed class Class767
	{
		// Token: 0x060028E3 RID: 10467 RVA: 0x0001AE2B File Offset: 0x0001902B
		internal void method_0()
		{
			this.bitmapSource_0 = Imaging.CreateBitmapSourceFromHBitmap(this.bitmap_0.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
		}

		// Token: 0x04001ADB RID: 6875
		public BitmapSource bitmapSource_0;

		// Token: 0x04001ADC RID: 6876
		public Bitmap bitmap_0;
	}

	// Token: 0x0200064C RID: 1612
	private enum Enum21
	{

	}

	// Token: 0x0200064D RID: 1613
	[Guid("0000010b-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface Interface16 : Class765.Interface18
	{
		// Token: 0x060028E4 RID: 10468
		void imethod_1(out Guid guid_0);

		// Token: 0x060028E5 RID: 10469
		[PreserveSig]
		int imethod_2();

		// Token: 0x060028E6 RID: 10470
		[PreserveSig]
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, uint uint_0);

		// Token: 0x060028E7 RID: 10471
		[PreserveSig]
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

		// Token: 0x060028E8 RID: 10472
		[PreserveSig]
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

		// Token: 0x060028E9 RID: 10473
		[PreserveSig]
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);
	}

	// Token: 0x0200064E RID: 1614
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[ComImport]
	private interface Interface17
	{
		// Token: 0x060028EA RID: 10474
		void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out Class765.Struct436 struct436_0, Class765.Enum21 enum21_0);

		// Token: 0x060028EB RID: 10475
		void imethod_1(out IntPtr intptr_0);

		// Token: 0x060028EC RID: 10476
		void imethod_2(IntPtr intptr_0);

		// Token: 0x060028ED RID: 10477
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x060028EE RID: 10478
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x060028EF RID: 10479
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x060028F0 RID: 10480
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x060028F1 RID: 10481
		void imethod_7([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x060028F2 RID: 10482
		void imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x060028F3 RID: 10483
		void imethod_9(out short short_0);

		// Token: 0x060028F4 RID: 10484
		void imethod_10(short short_0);

		// Token: 0x060028F5 RID: 10485
		void imethod_11(out int int_0);

		// Token: 0x060028F6 RID: 10486
		void imethod_12(int int_0);

		// Token: 0x060028F7 RID: 10487
		void imethod_13([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out int int_1);

		// Token: 0x060028F8 RID: 10488
		void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x060028F9 RID: 10489
		void imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x060028FA RID: 10490
		void imethod_16(IntPtr intptr_0, Class765.Enum22 enum22_0);

		// Token: 0x060028FB RID: 10491
		void imethod_17([MarshalAs(UnmanagedType.LPWStr)] string string_0);
	}

	// Token: 0x0200064F RID: 1615
	[Guid("0000010c-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface Interface18
	{
		// Token: 0x060028FC RID: 10492
		[PreserveSig]
		void imethod_0(out Guid guid_0);
	}

	// Token: 0x02000650 RID: 1616
	private sealed class Class768
	{
		// Token: 0x060028FE RID: 10494 RVA: 0x0001AE52 File Offset: 0x00019052
		internal void method_0()
		{
			this.bitmapSource_0 = Imaging.CreateBitmapSourceFromHIcon(this.icon_0.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
		}

		// Token: 0x04001ADE RID: 6878
		public BitmapSource bitmapSource_0;

		// Token: 0x04001ADF RID: 6879
		public Icon icon_0;
	}

	// Token: 0x02000651 RID: 1617
	[Guid("00021401-0000-0000-C000-000000000046")]
	[ComImport]
	internal sealed class Class769
	{
		// Token: 0x060028FF RID: 10495
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Class769();
	}

	// Token: 0x02000652 RID: 1618
	private sealed class Class770
	{
		// Token: 0x06002901 RID: 10497 RVA: 0x0001AE74 File Offset: 0x00019074
		internal void method_0(string string_0)
		{
			this.list_0.Add(string_0);
		}

		// Token: 0x04001AE0 RID: 6880
		public List<string> list_0;
	}

	// Token: 0x02000653 RID: 1619
	private enum Enum22
	{

	}

	// Token: 0x02000654 RID: 1620
	[Serializable]
	private sealed class Class771
	{
		// Token: 0x06002904 RID: 10500 RVA: 0x0001AE8E File Offset: 0x0001908E
		internal void method_0()
		{
			Class765.bitmapSource_0 = new BitmapImage();
		}

		// Token: 0x04001AE2 RID: 6882
		public static readonly Class765.Class771 class771_0 = new Class765.Class771();

		// Token: 0x04001AE3 RID: 6883
		public static Action action_0;
	}
}
