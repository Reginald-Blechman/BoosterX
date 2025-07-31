using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ns0;
using WinCopies.Util;

// Token: 0x02000104 RID: 260
internal sealed class Class487 : GClass162
{
	// Token: 0x0600078E RID: 1934 RVA: 0x0003ED18 File Offset: 0x0003CF18
	public Class487(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_1)
	{
		this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_1;
		this.class752_0 = Class551.class752_0;
		this.GMXAddGameVMs.CollectionChanged += this.method_8;
		this.GMXStoredSettingsGamesVMs.CollectionChanged += this.method_9;
		this.method_2();
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x0003ED94 File Offset: 0x0003CF94
	public void method_2()
	{
		if (!Class551.class752_0.method_2().smethod_9())
		{
			this.observableCollection_2.Clear();
			ICollection<Class494> collection = this.observableCollection_2;
			IEnumerable<Class494> enumerable = this.method_5();
			Extensions.AddRange<Class494>(collection, ref enumerable);
		}
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00006AC5 File Offset: 0x00004CC5
	private void method_3(string string_0)
	{
		base.method_0(string_0);
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000791 RID: 1937 RVA: 0x00006ACE File Offset: 0x00004CCE
	public ObservableCollection<GClass181> GMXAddGameVMs
	{
		get
		{
			if (this.observableCollection_0.Count == 0 && !this.bool_1)
			{
				this.method_7();
			}
			return this.observableCollection_0;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000792 RID: 1938 RVA: 0x00006AF1 File Offset: 0x00004CF1
	public ObservableCollection<GClass167> GMXAddAppsVMs
	{
		get
		{
			if (this.observableCollection_1.Count == 0 && !this.bool_0)
			{
				this.method_6();
			}
			return this.observableCollection_1;
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000793 RID: 1939 RVA: 0x00006B14 File Offset: 0x00004D14
	// (set) Token: 0x06000794 RID: 1940 RVA: 0x00006B1C File Offset: 0x00004D1C
	public ObservableCollection<Class494> STPairs
	{
		get
		{
			return this.observableCollection_2;
		}
		set
		{
			this.observableCollection_2 = value;
			base.method_0("STPairs");
		}
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x0003EDD4 File Offset: 0x0003CFD4
	public void method_4(Class494 class494_0)
	{
		List<string> list = Class551.class752_0.method_2().Split(new char[]
		{
			';'
		}).ToList<string>();
		list.Remove(class494_0.Keys);
		Class551.class752_0.method_3(string.Join(";", list));
		this.method_2();
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x0003EE2C File Offset: 0x0003D02C
	public List<Class494> method_5()
	{
		List<Class494> list = new List<Class494>();
		if (string.IsNullOrEmpty(Class551.class752_0.method_2()))
		{
			Class494 item = new Class494(this)
			{
				bool_0 = true,
				Keys = "A+D"
			};
			list.Add(item);
			return list;
		}
		if (Class551.class752_0.method_2().Split(new char[]
		{
			';'
		}).Count<string>() >= 1)
		{
			List<string> list2 = new List<string>();
			foreach (string text in Class551.class752_0.method_2().Split(new char[]
			{
				';'
			}).Distinct<string>().ToList<string>())
			{
				if (!text.smethod_9() && text.Split(new char[]
				{
					'+'
				}).Count<string>() == 2)
				{
					list2.Add(text);
				}
			}
			if (list2.Count<string>() >= 5)
			{
				list2.RemoveRange(5, list2.Count - 5);
			}
			Class551.class752_0.method_3(string.Join(";", list2));
		}
		foreach (string keys in Class551.class752_0.method_2().Split(new char[]
		{
			';'
		}, StringSplitOptions.RemoveEmptyEntries))
		{
			list.Add(new Class494(this)
			{
				Keys = keys
			});
		}
		return list;
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x0003EF9C File Offset: 0x0003D19C
	private void method_6()
	{
		Class487.Struct42 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class487_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class487.Struct42>(ref @struct);
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0003EFD4 File Offset: 0x0003D1D4
	public void method_7()
	{
		Class487.Struct43 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class487_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class487.Struct43>(ref @struct);
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000799 RID: 1945 RVA: 0x00006B31 File Offset: 0x00004D31
	public ObservableCollection<Class499> GMXStoredSettingsGamesVMs
	{
		get
		{
			return this.class752_0.method_0();
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x0600079A RID: 1946 RVA: 0x00006B3E File Offset: 0x00004D3E
	public ObservableCollection<Class500> GMXStoredSettingsAppsVMs
	{
		get
		{
			return this.class752_0.method_1();
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x0600079B RID: 1947 RVA: 0x00006B4B File Offset: 0x00004D4B
	// (set) Token: 0x0600079C RID: 1948 RVA: 0x00006B58 File Offset: 0x00004D58
	public string OnOffShortcut
	{
		get
		{
			return this.class752_0.OnOffShortcut;
		}
		set
		{
			this.class752_0.OnOffShortcut = value;
			base.method_0("OnOffShortcut");
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x0600079D RID: 1949 RVA: 0x00006B72 File Offset: 0x00004D72
	// (set) Token: 0x0600079E RID: 1950 RVA: 0x00006B7F File Offset: 0x00004D7F
	public bool? DisableDWM
	{
		get
		{
			return this.class752_0.DisableDWM;
		}
		set
		{
			if (value.GetValueOrDefault())
			{
				this.DisableExplorer = new bool?(true);
			}
			this.class752_0.DisableDWM = value;
			base.method_0("DisableDWM");
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x0600079F RID: 1951 RVA: 0x00006BAE File Offset: 0x00004DAE
	// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00006BBB File Offset: 0x00004DBB
	public bool? DisableExplorer
	{
		get
		{
			return this.class752_0.DisableExplorer;
		}
		set
		{
			this.class752_0.DisableExplorer = value;
			base.method_0("DisableExplorer");
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00006BD5 File Offset: 0x00004DD5
	// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00006BE2 File Offset: 0x00004DE2
	public bool? DisableMouseHooks
	{
		get
		{
			return this.class752_0.DisableMouseHooks;
		}
		set
		{
			this.class752_0.DisableMouseHooks = value;
			base.method_0("DisableMouseHooks");
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00006BFC File Offset: 0x00004DFC
	// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00006C09 File Offset: 0x00004E09
	public string CleanCacheShortcut
	{
		get
		{
			return this.class752_0.CleanCacheShortcut;
		}
		set
		{
			this.class752_0.CleanCacheShortcut = value;
			base.method_0("CleanCacheShortcut");
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00006C23 File Offset: 0x00004E23
	// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00006C30 File Offset: 0x00004E30
	public bool? CleanCacheAtStart
	{
		get
		{
			return this.class752_0.CleanCacheAtStart;
		}
		set
		{
			this.class752_0.CleanCacheAtStart = value;
			base.method_0("CleanCacheAtStart");
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00006C4A File Offset: 0x00004E4A
	// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00006C57 File Offset: 0x00004E57
	public bool? SnapTap
	{
		get
		{
			return this.class752_0.SnapTap;
		}
		set
		{
			this.class752_0.SnapTap = value;
			base.method_0("SnapTap");
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00006C71 File Offset: 0x00004E71
	public List<Class752.Class664> PowerSchemes
	{
		get
		{
			return this.class752_0.PowerSchemes;
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060007AA RID: 1962 RVA: 0x00006C7E File Offset: 0x00004E7E
	// (set) Token: 0x060007AB RID: 1963 RVA: 0x00006C8B File Offset: 0x00004E8B
	public Class752.Class664 PSGaming
	{
		get
		{
			return this.class752_0.PSGaming;
		}
		set
		{
			this.class752_0.PSGaming = value;
			base.method_0("PSGaming");
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060007AC RID: 1964 RVA: 0x00006CA5 File Offset: 0x00004EA5
	// (set) Token: 0x060007AD RID: 1965 RVA: 0x00006CB2 File Offset: 0x00004EB2
	public Class752.Class664 PSGameOff
	{
		get
		{
			return this.class752_0.PSGameOff;
		}
		set
		{
			this.class752_0.PSGameOff = value;
			base.method_0("PSGameOff");
		}
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00006CCC File Offset: 0x00004ECC
	private void method_8(object sender, NotifyCollectionChangedEventArgs e)
	{
		this.method_3("GMXAddGameVMs");
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00006CDA File Offset: 0x00004EDA
	private void method_9(object sender, NotifyCollectionChangedEventArgs e)
	{
		this.method_3("GMXStoredSettingsGamesVMs");
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x0003F00C File Offset: 0x0003D20C
	private void method_10()
	{
		List<string> list = new List<string>();
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length; i++)
		{
			Class487.Class161 @class = new Class487.Class161();
			@class.class487_0 = this;
			@class.process_0 = processes[i];
			bool flag = false;
			using (List<string>.Enumerator enumerator = Class725.list_2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ToLower() == @class.process_0.ProcessName.ToLower())
					{
						flag = true;
					}
				}
			}
			foreach (string b in list)
			{
				if (@class.process_0.ProcessName == b)
				{
					flag = true;
				}
			}
			foreach (Class500 class2 in this.GMXStoredSettingsAppsVMs)
			{
				if (@class.process_0.ProcessName.ToLower() == class2.ExeName.ToLower())
				{
					flag = true;
				}
			}
			if (!flag)
			{
				try
				{
					Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
					list.Add(@class.process_0.ProcessName);
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x0003F1A0 File Offset: 0x0003D3A0
	private void method_11()
	{
		Class487.Class162 @class = new Class487.Class162();
		@class.class487_0 = this;
		List<string> list = new List<string>();
		@class.observableCollection_0 = new ObservableCollection<GClass181>();
		try
		{
			@class.registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam");
			string str = @class.registryKey_0.GetValue("InstallPath").ToString();
			List<string> list2 = new List<string>();
			string pattern = "[A-Z]:\\\\";
			if (File.Exists(str + "\\steamapps\\libraryfolders.vdf"))
			{
				foreach (string text in File.ReadAllLines(str + "\\steamapps\\libraryfolders.vdf"))
				{
					Match match = Regex.Match(text, pattern);
					if (text != string.Empty && match.Success)
					{
						string value = match.ToString();
						string text2 = text.Substring(text.IndexOf(value));
						text2 = text2.Replace("\\\\", "\\");
						text2 = text2.Replace("\"", "\\steamapps\\common\\");
						list2.Add(text2);
					}
				}
			}
			foreach (string path in list2)
			{
				if (Directory.Exists(path))
				{
					string[] array = Directory.GetDirectories(path);
					for (int i = 0; i < array.Length; i++)
					{
						string[] files = Directory.GetFiles(array[i], "*.exe", SearchOption.AllDirectories);
						for (int j = 0; j < files.Length; j++)
						{
							Class487.Class164 class2 = new Class487.Class164();
							class2.class162_0 = @class;
							class2.string_0 = files[j];
							bool flag = false;
							bool flag2 = false;
							foreach (string b in Class725.list_1)
							{
								if (class2.string_0.Split(new char[]
								{
									'\\'
								}).Last<string>() == b)
								{
									flag = true;
								}
							}
							foreach (string b2 in list)
							{
								if (class2.string_0.Split(new char[]
								{
									'\\'
								}).Last<string>() == b2)
								{
									flag2 = true;
								}
							}
							if (flag && !flag2)
							{
								class2.string_1 = class2.string_0.Split(new char[]
								{
									'\\'
								});
								class2.int_0 = 0;
								for (int k = 0; k < class2.string_1.Length; k++)
								{
									if (class2.string_1[k] == "common")
									{
										class2.int_0 = k + 1;
									}
								}
								Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
								list.Add(class2.string_0.Split(new char[]
								{
									'\\'
								}).Last<string>());
							}
						}
					}
				}
			}
		}
		catch
		{
		}
		try
		{
			List<string> list3 = new List<string>();
			string pattern2 = "[A-Z]:\\\\";
			if (File.Exists("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
			{
				foreach (string text3 in File.ReadAllLines("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
				{
					Match match2 = Regex.Match(text3, pattern2);
					if (text3 != string.Empty && match2.Success)
					{
						string value2 = match2.ToString();
						string text4 = text3.Substring(text3.IndexOf(value2));
						text4 = text4.Replace("\\\\", "\\");
						text4 = text4.Replace("\",", string.Empty);
						list3.Add(text4);
					}
				}
				using (List<string>.Enumerator enumerator = list3.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class487.Class159 class3 = new Class487.Class159();
						class3.class162_0 = @class;
						class3.string_0 = enumerator.Current;
						Directory.GetDirectories(class3.string_0);
						string[] array = Directory.GetFiles(class3.string_0, "*.exe", SearchOption.AllDirectories);
						for (int i = 0; i < array.Length; i++)
						{
							Class487.Class163 class4 = new Class487.Class163();
							class4.class159_0 = class3;
							class4.string_0 = array[i];
							bool flag3 = false;
							bool flag4 = false;
							foreach (string b3 in Class725.list_1)
							{
								if (class4.string_0.Split(new char[]
								{
									'\\'
								}).Last<string>() == b3)
								{
									flag3 = true;
								}
							}
							foreach (string b4 in list)
							{
								if (class4.string_0.Split(new char[]
								{
									'\\'
								}).Last<string>() == b4)
								{
									flag4 = true;
								}
							}
							if (flag3 && !flag4)
							{
								Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
								list.Add(class4.string_0.Split(new char[]
								{
									'\\'
								}).Last<string>());
							}
						}
					}
				}
			}
		}
		catch
		{
		}
		try
		{
			List<string> list4 = new List<string>();
			if (File.Exists("C:\\ProgramData\\Riot Games\\RiotClientInstalls.json"))
			{
				new JsonSerializer();
				foreach (JToken jtoken in ((IEnumerable<JToken>)JObject.Parse(File.ReadAllText("C:\\ProgramData\\Riot Games\\RiotClientInstalls.json"))["associated_client"].Children().ToList<JToken>()))
				{
					list4.Add(jtoken.ToString().Split(new char[]
					{
						'"'
					})[1].Replace('/', '\\'));
				}
				foreach (string path2 in list4)
				{
					string[] array = Directory.GetFiles(path2, "*.exe", SearchOption.AllDirectories);
					for (int i = 0; i < array.Length; i++)
					{
						Class487.Class158 class5 = new Class487.Class158();
						class5.class162_0 = @class;
						class5.string_0 = array[i];
						bool flag5 = false;
						bool flag6 = false;
						foreach (string b5 in Class725.list_1)
						{
							if (class5.string_0.Split(new char[]
							{
								'\\'
							}).Last<string>() == b5)
							{
								flag5 = true;
							}
						}
						foreach (string b6 in list)
						{
							if (class5.string_0.Split(new char[]
							{
								'\\'
							}).Last<string>() == b6)
							{
								flag6 = true;
							}
						}
						if (flag5 && !flag6)
						{
							class5.string_1 = Class765.smethod_16(class5.string_0);
							Application.Current.Dispatcher.Invoke(new Action(class5.method_0));
							list.Add(class5.string_0.Split(new char[]
							{
								'\\'
							}).Last<string>());
						}
					}
				}
			}
		}
		catch
		{
		}
		try
		{
			@class.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache");
			string[] array = @class.registryKey_0.GetValueNames();
			for (int i = 0; i < array.Length; i++)
			{
				Class487.Class160 class6 = new Class487.Class160();
				class6.class162_0 = @class;
				class6.string_0 = array[i];
				if (class6.string_0.EndsWith("exe.FriendlyAppName") && class6.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>() != ".exe.FriendlyAppName")
				{
					string a = class6.string_0.Split(new char[]
					{
						'\\'
					}).Last<string>().Replace(".FriendlyAppName", string.Empty);
					bool flag7 = false;
					bool flag8 = false;
					foreach (string b7 in Class725.list_1)
					{
						if (a == b7)
						{
							flag7 = true;
						}
					}
					foreach (string b8 in list)
					{
						if (a == b8)
						{
							flag8 = true;
						}
					}
					if (flag7 && !flag8)
					{
						Application.Current.Dispatcher.Invoke(new Action(class6.method_0));
						list.Add(class6.string_0.Split(new char[]
						{
							'\\'
						}).Last<string>().Replace(".FriendlyAppName", string.Empty));
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0400043D RID: 1085
	public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

	// Token: 0x0400043E RID: 1086
	private Class752 class752_0;

	// Token: 0x0400043F RID: 1087
	private bool bool_0;

	// Token: 0x04000440 RID: 1088
	private bool bool_1;

	// Token: 0x04000441 RID: 1089
	private ObservableCollection<GClass181> observableCollection_0 = new ObservableCollection<GClass181>();

	// Token: 0x04000442 RID: 1090
	private ObservableCollection<GClass167> observableCollection_1 = new ObservableCollection<GClass167>();

	// Token: 0x04000443 RID: 1091
	private ObservableCollection<Class494> observableCollection_2 = new ObservableCollection<Class494>();

	// Token: 0x02000105 RID: 261
	[StructLayout(LayoutKind.Auto)]
	private struct Struct42 : IAsyncStateMachine
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x0003FC48 File Offset: 0x0003DE48
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class487 @class = this.class487_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_0 = true;
					awaiter = Task.Run(new Action(@class.method_10)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class487.Struct42>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				@class.bool_0 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00006CE8 File Offset: 0x00004EE8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000444 RID: 1092
		public int int_0;

		// Token: 0x04000445 RID: 1093
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000446 RID: 1094
		public Class487 class487_0;

		// Token: 0x04000447 RID: 1095
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000106 RID: 262
	[StructLayout(LayoutKind.Auto)]
	private struct Struct43 : IAsyncStateMachine
	{
		// Token: 0x060007B4 RID: 1972 RVA: 0x0003FD14 File Offset: 0x0003DF14
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class487 @class = this.class487_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_1 = true;
					awaiter = Task.Run(new Action(@class.method_11)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class487.Struct43>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				@class.bool_1 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00006CF6 File Offset: 0x00004EF6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000448 RID: 1096
		public int int_0;

		// Token: 0x04000449 RID: 1097
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400044A RID: 1098
		public Class487 class487_0;

		// Token: 0x0400044B RID: 1099
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000107 RID: 263
	private sealed class Class158
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x0003FDE0 File Offset: 0x0003DFE0
		internal void method_0()
		{
			GClass181 item = new GClass181
			{
				Name = this.string_1.Replace("-Win64-Shipping.exe", string.Empty).Replace(".exe", string.Empty),
				ExeDir = this.string_0,
				FoundIn = "Riot Games",
				ExeName = this.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>().Replace(".exe", string.Empty)
			};
			this.class162_0.class487_0.observableCollection_0.Add(item);
			this.class162_0.observableCollection_0.Add(item);
		}

		// Token: 0x0400044C RID: 1100
		public string string_0;

		// Token: 0x0400044D RID: 1101
		public string string_1;

		// Token: 0x0400044E RID: 1102
		public Class487.Class162 class162_0;
	}

	// Token: 0x02000108 RID: 264
	private sealed class Class159
	{
		// Token: 0x0400044F RID: 1103
		public string string_0;

		// Token: 0x04000450 RID: 1104
		public Class487.Class162 class162_0;
	}

	// Token: 0x02000109 RID: 265
	private sealed class Class160
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x0003FE94 File Offset: 0x0003E094
		internal void method_0()
		{
			GClass181 item = new GClass181
			{
				Name = this.class162_0.registryKey_0.GetValue(this.string_0).ToString().Replace("-Win64-Shipping.exe", string.Empty).Replace(".exe", string.Empty),
				ExeDir = this.class162_0.registryKey_0.GetValue(this.string_0).ToString(),
				FoundIn = Class298.smethod_2("GMXFoundInCache"),
				ExeName = this.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>().Replace(".FriendlyAppName", string.Empty).Replace(".exe", string.Empty)
			};
			this.class162_0.class487_0.observableCollection_0.Add(item);
			this.class162_0.observableCollection_0.Add(item);
		}

		// Token: 0x04000451 RID: 1105
		public string string_0;

		// Token: 0x04000452 RID: 1106
		public Class487.Class162 class162_0;
	}

	// Token: 0x0200010A RID: 266
	private sealed class Class161
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x0003FF84 File Offset: 0x0003E184
		internal void method_0()
		{
			GClass167 item = new GClass167
			{
				Name = this.process_0.ProcessName,
				ExeName = this.process_0.ProcessName,
				ExeDir = this.process_0.MainModule.FileName,
				FoundIn = string.Empty
			};
			this.class487_0.GMXAddAppsVMs.Add(item);
		}

		// Token: 0x04000453 RID: 1107
		public Process process_0;

		// Token: 0x04000454 RID: 1108
		public Class487 class487_0;
	}

	// Token: 0x0200010B RID: 267
	private sealed class Class162
	{
		// Token: 0x04000455 RID: 1109
		public ObservableCollection<GClass181> observableCollection_0;

		// Token: 0x04000456 RID: 1110
		public RegistryKey registryKey_0;

		// Token: 0x04000457 RID: 1111
		public Class487 class487_0;
	}

	// Token: 0x0200010C RID: 268
	private sealed class Class163
	{
		// Token: 0x060007BF RID: 1983 RVA: 0x0003FFEC File Offset: 0x0003E1EC
		internal void method_0()
		{
			GClass181 item = new GClass181
			{
				Name = this.class159_0.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>().Replace("-Win64-Shipping.exe", string.Empty).Replace(".exe", string.Empty),
				ExeDir = this.string_0,
				FoundIn = "Epic Games",
				ExeName = this.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>().Replace(".exe", string.Empty)
			};
			this.class159_0.class162_0.class487_0.observableCollection_0.Add(item);
			this.class159_0.class162_0.observableCollection_0.Add(item);
		}

		// Token: 0x04000458 RID: 1112
		public string string_0;

		// Token: 0x04000459 RID: 1113
		public Class487.Class159 class159_0;
	}

	// Token: 0x0200010D RID: 269
	private sealed class Class164
	{
		// Token: 0x060007C1 RID: 1985 RVA: 0x000400C4 File Offset: 0x0003E2C4
		internal void method_0()
		{
			GClass181 item = new GClass181
			{
				Name = this.string_1[this.int_0].Replace("-Win64-Shipping.exe", string.Empty).Replace(".exe", string.Empty),
				ExeDir = this.string_0,
				FoundIn = "Steam",
				ExeName = this.string_0.Split(new char[]
				{
					'\\'
				}).Last<string>().Replace(".exe", string.Empty)
			};
			this.class162_0.class487_0.observableCollection_0.Add(item);
			this.class162_0.observableCollection_0.Add(item);
		}

		// Token: 0x0400045A RID: 1114
		public string string_0;

		// Token: 0x0400045B RID: 1115
		public string[] string_1;

		// Token: 0x0400045C RID: 1116
		public int int_0;

		// Token: 0x0400045D RID: 1117
		public Class487.Class162 class162_0;
	}
}
