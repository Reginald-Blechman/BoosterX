using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

// Token: 0x020002AF RID: 687
internal static class Class320
{
	// Token: 0x0600122B RID: 4651 RVA: 0x0005B318 File Offset: 0x00059518
	// Note: this type is marked as 'beforefieldinit'.
	static Class320()
	{
		Class320.dictionary_3.Add("costura64.libskiasharp.dll", "DCE6E143A5BAAE8A6C0B062F1C975A61861D04AE");
		Class320.dictionary_1.Add("costura", "costura.costura.dll.compressed");
		Class320.dictionary_1.Add("de.microsoft.win32.taskscheduler.resources", "costura.de.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("devicehelper", "costura.devicehelper.dll.compressed");
		Class320.dictionary_1.Add("discordrpc", "costura.discordrpc.dll.compressed");
		Class320.dictionary_1.Add("diskdetector", "costura.diskdetector.dll.compressed");
		Class320.dictionary_1.Add("elevrightsx", "costura.elevrightsx.dll.compressed");
		Class320.dictionary_1.Add("es.microsoft.win32.taskscheduler.resources", "costura.es.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("famfamfam.flags.wpf", "costura.famfamfam.flags.wpf.dll.compressed");
		Class320.dictionary_1.Add("fr.microsoft.win32.taskscheduler.resources", "costura.fr.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("gameloop.vdf", "costura.gameloop.vdf.dll.compressed");
		Class320.dictionary_1.Add("glwpfcontrol", "costura.glwpfcontrol.dll.compressed");
		Class320.dictionary_1.Add("harfbuzzsharp", "costura.harfbuzzsharp.dll.compressed");
		Class320.dictionary_1.Add("hidsharp", "costura.hidsharp.dll.compressed");
		Class320.dictionary_1.Add("iconextractor", "costura.iconextractor.dll.compressed");
		Class320.dictionary_1.Add("igdb", "costura.igdb.dll.compressed");
		Class320.dictionary_1.Add("imageprocessor", "costura.imageprocessor.dll.compressed");
		Class320.dictionary_1.Add("it.microsoft.win32.taskscheduler.resources", "costura.it.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("ja.microsoft.win32.taskscheduler.resources", "costura.ja.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("librehardwaremonitorlib", "costura.librehardwaremonitorlib.dll.compressed");
		Class320.dictionary_1.Add("livechartscore", "costura.livechartscore.dll.compressed");
		Class320.dictionary_1.Add("livechartscore.skiasharpview", "costura.livechartscore.skiasharpview.dll.compressed");
		Class320.dictionary_1.Add("livechartscore.skiasharpview.wpf", "costura.livechartscore.skiasharpview.wpf.dll.compressed");
		Class320.dictionary_1.Add("markdig", "costura.markdig.dll.compressed");
		Class320.dictionary_1.Add("markdig.wpf", "costura.markdig.wpf.dll.compressed");
		Class320.dictionary_1.Add("material.icons", "costura.material.icons.dll.compressed");
		Class320.dictionary_1.Add("material.icons.wpf", "costura.material.icons.wpf.dll.compressed");
		Class320.dictionary_1.Add("microsoft.bcl.asyncinterfaces", "costura.microsoft.bcl.asyncinterfaces.dll.compressed");
		Class320.dictionary_1.Add("microsoft.dism", "costura.microsoft.dism.dll.compressed");
		Class320.dictionary_1.Add("microsoft.expression.drawing", "costura.microsoft.expression.drawing.dll.compressed");
		Class320.dictionary_1.Add("microsoft.extensions.configuration.abstractions", "costura.microsoft.extensions.configuration.abstractions.dll.compressed");
		Class320.dictionary_1.Add("microsoft.extensions.dependencyinjection.abstractions", "costura.microsoft.extensions.dependencyinjection.abstractions.dll.compressed");
		Class320.dictionary_1.Add("microsoft.extensions.dependencyinjection", "costura.microsoft.extensions.dependencyinjection.dll.compressed");
		Class320.dictionary_1.Add("microsoft.extensions.http", "costura.microsoft.extensions.http.dll.compressed");
		Class320.dictionary_1.Add("microsoft.extensions.logging.abstractions", "costura.microsoft.extensions.logging.abstractions.dll.compressed");
		Class320.dictionary_1.Add("microsoft.extensions.logging", "costura.microsoft.extensions.logging.dll.compressed");
		Class320.dictionary_1.Add("microsoft.extensions.options", "costura.microsoft.extensions.options.dll.compressed");
		Class320.dictionary_1.Add("microsoft.extensions.primitives", "costura.microsoft.extensions.primitives.dll.compressed");
		Class320.dictionary_1.Add("microsoft.win32.taskscheduler", "costura.microsoft.win32.taskscheduler.dll.compressed");
		Class320.dictionary_1.Add("microsoft.windowsapicodepack", "costura.microsoft.windowsapicodepack.dll.compressed");
		Class320.dictionary_1.Add("microsoft.windowsapicodepack.shell", "costura.microsoft.windowsapicodepack.shell.dll.compressed");
		Class320.dictionary_1.Add("microsoft.xaml.behaviors", "costura.microsoft.xaml.behaviors.dll.compressed");
		Class320.dictionary_1.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		Class320.dictionary_1.Add("nvnative", "costura.nvnative.dll.compressed");
		Class320.dictionary_1.Add("opentk", "costura.opentk.dll.compressed");
		Class320.dictionary_1.Add("oxyplot", "costura.oxyplot.dll.compressed");
		Class320.dictionary_1.Add("oxyplot.wpf", "costura.oxyplot.wpf.dll.compressed");
		Class320.dictionary_1.Add("oxyplot.wpf.shared", "costura.oxyplot.wpf.shared.dll.compressed");
		Class320.dictionary_1.Add("pimanagerx", "costura.pimanagerx.dll.compressed");
		Class320.dictionary_1.Add("pl.microsoft.win32.taskscheduler.resources", "costura.pl.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("ramspdtoolkit", "costura.ramspdtoolkit.dll.compressed");
		Class320.dictionary_1.Add("rawinput.sharp", "costura.rawinput.sharp.dll.compressed");
		Class320.dictionary_1.Add("restease", "costura.restease.dll.compressed");
		Class320.dictionary_1.Add("ru.microsoft.win32.taskscheduler.resources", "costura.ru.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("skiasharp", "costura.skiasharp.dll.compressed");
		Class320.dictionary_1.Add("skiasharp.harfbuzz", "costura.skiasharp.harfbuzz.dll.compressed");
		Class320.dictionary_1.Add("skiasharp.views.desktop.common", "costura.skiasharp.views.desktop.common.dll.compressed");
		Class320.dictionary_1.Add("skiasharp.views.wpf", "costura.skiasharp.views.wpf.dll.compressed");
		Class320.dictionary_1.Add("sv.microsoft.win32.taskscheduler.resources", "costura.sv.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("system.buffers", "costura.system.buffers.dll.compressed");
		Class320.dictionary_1.Add("system.codedom", "costura.system.codedom.dll.compressed");
		Class320.dictionary_1.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		Class320.dictionary_1.Add("system.io.pipelines", "costura.system.io.pipelines.dll.compressed");
		Class320.dictionary_1.Add("system.management.automation", "costura.system.management.automation.dll.compressed");
		Class320.dictionary_1.Add("system.memory", "costura.system.memory.dll.compressed");
		Class320.dictionary_1.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
		Class320.dictionary_1.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
		Class320.dictionary_1.Add("system.security.principal.windows", "costura.system.security.principal.windows.dll.compressed");
		Class320.dictionary_1.Add("system.text.encodings.web", "costura.system.text.encodings.web.dll.compressed");
		Class320.dictionary_1.Add("system.text.json", "costura.system.text.json.dll.compressed");
		Class320.dictionary_1.Add("system.threading.channels", "costura.system.threading.channels.dll.compressed");
		Class320.dictionary_1.Add("system.threading.tasks.extensions", "costura.system.threading.tasks.extensions.dll.compressed");
		Class320.dictionary_1.Add("system.valuetuple", "costura.system.valuetuple.dll.compressed");
		Class320.dictionary_1.Add("tr.microsoft.win32.taskscheduler.resources", "costura.tr.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("wincopies.util", "costura.wincopies.util.dll.compressed");
		Class320.dictionary_1.Add("wincopies.windowsapicodepack.win32native.consts", "costura.wincopies.windowsapicodepack.win32native.consts.dll.compressed");
		Class320.dictionary_1.Add("wincopies.windowsapicodepack.win32native", "costura.wincopies.windowsapicodepack.win32native.dll.compressed");
		Class320.dictionary_1.Add("winring0driver", "costura.winring0driver.dll.compressed");
		Class320.dictionary_1.Add("xamlanimatedgif", "costura.xamlanimatedgif.dll.compressed");
		Class320.dictionary_1.Add("zh-cn.microsoft.win32.taskscheduler.resources", "costura.zh-cn.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.dictionary_1.Add("zh-hant.microsoft.win32.taskscheduler.resources", "costura.zh-hant.microsoft.win32.taskscheduler.resources.dll.compressed");
		Class320.list_1.Add("costura64.libskiasharp.dll");
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x0000D131 File Offset: 0x0000B331
	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return string.Empty;
		}
		return cultureInfo_0.Name;
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x0005BA74 File Offset: 0x00059C74
	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			AssemblyName name = assembly.GetName();
			if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(Class320.smethod_0(name.CultureInfo), Class320.smethod_0(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
			{
				return assembly;
			}
		}
		return null;
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x0005BAE4 File Offset: 0x00059CE4
	private static Assembly smethod_2(string string_1, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		string path = (IntPtr.Size == 8) ? "64" : "32";
		string path2 = Path.Combine(string_1, text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.Combine(Path.Combine(string_1, path), text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		return null;
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x0005BBCC File Offset: 0x00059DCC
	private static void smethod_3(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x0005BC00 File Offset: 0x00059E00
	private static Stream smethod_4(string string_1)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (string_1.EndsWith(".compressed"))
		{
			Stream result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(string_1))
			{
				DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					Class320.smethod_3(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					result = memoryStream;
				}
				finally
				{
					((IDisposable)deflateStream).Dispose();
				}
			}
			return result;
		}
		return executingAssembly.GetManifestResourceStream(string_1);
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x0005BC8C File Offset: 0x00059E8C
	private static Stream smethod_5(Dictionary<string, string> dictionary_4, string string_1)
	{
		string string_2;
		if (dictionary_4.TryGetValue(string_1, out string_2))
		{
			return Class320.smethod_4(string_2);
		}
		return null;
	}

	// Token: 0x06001232 RID: 4658 RVA: 0x0005BCAC File Offset: 0x00059EAC
	private static byte[] smethod_6(Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, array.Length);
		return array;
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x0005BCD4 File Offset: 0x00059ED4
	private static Assembly smethod_7(Dictionary<string, string> dictionary_4, Dictionary<string, string> dictionary_5, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		byte[] rawAssembly;
		using (Stream stream = Class320.smethod_5(dictionary_4, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = Class320.smethod_6(stream);
		}
		using (Stream stream2 = Class320.smethod_5(dictionary_5, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = Class320.smethod_6(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x0005BD94 File Offset: 0x00059F94
	public static Assembly smethod_8(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		object obj = Class320.object_0;
		lock (obj)
		{
			if (Class320.dictionary_0.ContainsKey(resolveEventArgs_0.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
		Assembly assembly = Class320.smethod_1(assemblyName);
		if (assembly != null)
		{
			return assembly;
		}
		assembly = Class320.smethod_2(Class320.string_0, assemblyName);
		if (assembly != null)
		{
			return assembly;
		}
		assembly = Class320.smethod_7(Class320.dictionary_1, Class320.dictionary_2, assemblyName);
		if (assembly == null)
		{
			object obj2 = Class320.object_0;
			lock (obj2)
			{
				Class320.dictionary_0[resolveEventArgs_0.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x0000D142 File Offset: 0x0000B342
	private static void smethod_9(string string_1)
	{
		if (!Directory.Exists(string_1))
		{
			Directory.CreateDirectory(string_1);
		}
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x0005BE7C File Offset: 0x0005A07C
	private static string smethod_10(string string_1)
	{
		string text = (IntPtr.Size == 8) ? "64" : "32";
		string text2 = string_1;
		if (string_1.StartsWith("costura" + text + "."))
		{
			text2 = Path.Combine(text, string_1.Substring(10));
		}
		else if (string_1.StartsWith("costura."))
		{
			text2 = string_1.Substring(8);
		}
		if (text2.EndsWith(".compressed"))
		{
			text2 = text2.Substring(0, text2.Length - 11);
		}
		return text2;
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x0005BF04 File Offset: 0x0005A104
	private static string smethod_11(string string_1)
	{
		FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read | FileShare.Write | FileShare.Delete);
		string result;
		try
		{
			BufferedStream bufferedStream = new BufferedStream(fileStream);
			try
			{
				SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
				try
				{
					byte[] array = sha1CryptoServiceProvider.ComputeHash(bufferedStream);
					StringBuilder stringBuilder = new StringBuilder(2 * array.Length);
					foreach (byte b in array)
					{
						stringBuilder.AppendFormat("{0:X2}", b);
					}
					result = stringBuilder.ToString();
				}
				finally
				{
					((IDisposable)sha1CryptoServiceProvider).Dispose();
				}
			}
			finally
			{
				((IDisposable)bufferedStream).Dispose();
			}
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
		return result;
	}

	// Token: 0x06001238 RID: 4664
	[DllImport("kernel32.dll")]
	private static extern uint SetErrorMode(uint uint_0);

	// Token: 0x06001239 RID: 4665
	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibraryEx(string string_1, IntPtr intptr_0, uint uint_0);

	// Token: 0x0600123A RID: 4666 RVA: 0x0005BFB8 File Offset: 0x0005A1B8
	private static void smethod_12(string string_1, IList<string> ilist_0, Dictionary<string, string> dictionary_4)
	{
		foreach (string text in ilist_0)
		{
			string text2 = Class320.smethod_10(text);
			string text3 = Path.Combine(string_1, text2);
			if (File.Exists(text3))
			{
				string a = Class320.smethod_11(text3);
				if (a != dictionary_4[text])
				{
					File.Delete(text3);
				}
			}
			if (!File.Exists(text3))
			{
				using (Stream stream = Class320.smethod_4(text))
				{
					using (FileStream fileStream = File.OpenWrite(text3))
					{
						Class320.smethod_3(stream, fileStream);
					}
				}
			}
		}
		uint errorMode = Class320.SetErrorMode(32771U);
		foreach (string string_2 in ilist_0)
		{
			string text2 = Class320.smethod_10(string_2);
			if (text2.EndsWith(".dll"))
			{
				string string_3 = Path.Combine(string_1, text2);
				Class320.LoadLibraryEx(string_3, IntPtr.Zero, 8U);
			}
		}
		Class320.SetErrorMode(errorMode);
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x0005C0FC File Offset: 0x0005A2FC
	private static void smethod_13(string string_1, string string_2, List<string> list_2, Dictionary<string, string> dictionary_4)
	{
		string name = "Costura" + string_1;
		Mutex mutex = new Mutex(false, name);
		try
		{
			bool flag = false;
			try
			{
				try
				{
					if (!(flag = mutex.WaitOne(60000, false)))
					{
						throw new TimeoutException("Timeout waiting for exclusive access");
					}
				}
				catch (AbandonedMutexException)
				{
					flag = true;
				}
				string path = (IntPtr.Size == 8) ? "64" : "32";
				Class320.smethod_9(Path.Combine(string_2, path));
				Class320.smethod_12(string_2, list_2, dictionary_4);
			}
			finally
			{
				if (flag)
				{
					mutex.ReleaseMutex();
				}
			}
		}
		finally
		{
			((IDisposable)mutex).Dispose();
		}
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x0005C1AC File Offset: 0x0005A3AC
	public static void smethod_14()
	{
		if (Interlocked.Exchange(ref Class320.int_0, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Type type = currentDomain.GetType();
		object obj;
		if (type == null)
		{
			obj = null;
		}
		else
		{
			PropertyInfo property = type.GetProperty("SetupInformation");
			obj = ((property != null) ? property.GetValue(currentDomain) : null);
		}
		object obj2 = obj;
		PropertyInfo propertyInfo;
		if (obj2 == null)
		{
			propertyInfo = null;
		}
		else
		{
			Type type2 = obj2.GetType();
			propertyInfo = ((type2 != null) ? type2.GetProperty("TargetFrameworkName") : null);
		}
		PropertyInfo propertyInfo2 = propertyInfo;
		if (propertyInfo2 != null && propertyInfo2.GetValue(obj2) == null)
		{
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			TargetFrameworkAttribute targetFrameworkAttribute = (TargetFrameworkAttribute)((callingAssembly != null) ? callingAssembly.GetCustomAttribute(typeof(TargetFrameworkAttribute)) : null);
			string text = (targetFrameworkAttribute != null) ? targetFrameworkAttribute.FrameworkName : null;
			if (text != null)
			{
				currentDomain.SetData("TargetFrameworkName", text);
			}
		}
		string text2 = "8A2A2C9BEB83F4DBC821FB6D758ED98E";
		string path = Path.Combine(Path.GetTempPath(), "Costura");
		Class320.string_0 = Path.Combine(path, text2);
		List<string> list_ = (IntPtr.Size == 8) ? Class320.list_1 : Class320.list_0;
		Class320.smethod_13(text2, Class320.string_0, list_, Class320.dictionary_3);
		currentDomain.AssemblyResolve += Class320.smethod_8;
	}

	// Token: 0x04000B73 RID: 2931
	private static object object_0 = new object();

	// Token: 0x04000B74 RID: 2932
	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	// Token: 0x04000B75 RID: 2933
	private static string string_0;

	// Token: 0x04000B76 RID: 2934
	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	// Token: 0x04000B77 RID: 2935
	private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	// Token: 0x04000B78 RID: 2936
	private static List<string> list_0 = new List<string>();

	// Token: 0x04000B79 RID: 2937
	private static List<string> list_1 = new List<string>();

	// Token: 0x04000B7A RID: 2938
	private static Dictionary<string, string> dictionary_3 = new Dictionary<string, string>();

	// Token: 0x04000B7B RID: 2939
	private static int int_0;
}
