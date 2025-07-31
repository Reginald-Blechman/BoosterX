using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.XPath;

// Token: 0x02000565 RID: 1381
internal sealed class Class662
{
	// Token: 0x0600228F RID: 8847 RVA: 0x00089A98 File Offset: 0x00087C98
	internal static void smethod_0(string string_1)
	{
		if (string_1.StartsWith("\\"))
		{
			GClass290.smethod_0("schtasks /Change /TN \"" + string_1 + "\" /Enable", false);
			return;
		}
		GClass290.smethod_0("schtasks /Change /TN \"\\" + string_1 + "\" /Enable", false);
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x00089AE8 File Offset: 0x00087CE8
	internal static void smethod_1(string string_1)
	{
		if (string_1.StartsWith("\\"))
		{
			GClass290.smethod_0("schtasks /Change /TN \"" + string_1 + "\" /Disable", false);
			return;
		}
		GClass290.smethod_0("schtasks /Change /TN \"\\" + string_1 + "\" /Disable", false);
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x00089B38 File Offset: 0x00087D38
	public static List<Class662.Class663> smethod_2()
	{
		List<Class662.Class663> list = new List<Class662.Class663>();
		foreach (string string_ in Directory.EnumerateFiles(Class662.string_0, "*", SearchOption.AllDirectories))
		{
			string string_2 = Class662.smethod_7(string_);
			Class662.Class663 @class = Class662.smethod_4(string_, string_2);
			if (@class != null)
			{
				list.Add(@class);
			}
		}
		return list;
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x00089BA8 File Offset: 0x00087DA8
	public static bool smethod_3(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			return false;
		}
		string_1 = Class662.smethod_5(string_1);
		Class662.Class663 @class = Class662.smethod_4(Class662.smethod_6(string_1), string_1);
		return @class != null && @class.IsEnabled;
	}

	// Token: 0x06002293 RID: 8851 RVA: 0x00089BE4 File Offset: 0x00087DE4
	private static Class662.Class663 smethod_4(string string_1, string string_2)
	{
		if (!File.Exists(string_1))
		{
			return null;
		}
		Class662.Class663 result;
		try
		{
			using (FileStream fileStream = File.OpenRead(string_1))
			{
				XmlReaderSettings settings = new XmlReaderSettings
				{
					DtdProcessing = DtdProcessing.Prohibit,
					IgnoreComments = true,
					IgnoreWhitespace = true
				};
				using (XmlReader xmlReader = XmlReader.Create(fileStream, settings))
				{
					XPathNavigator xpathNavigator = new XPathDocument(xmlReader).CreateNavigator();
					XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xpathNavigator.NameTable);
					xmlNamespaceManager.AddNamespace("t", "http://schemas.microsoft.com/windows/2004/02/mit/task");
					string fileName = Path.GetFileName(string_2);
					XPathNavigator xpathNavigator2 = xpathNavigator.SelectSingleNode("/t:Task/t:RegistrationInfo/t:Description", xmlNamespaceManager);
					string description = (xpathNavigator2 != null) ? xpathNavigator2.Value : null;
					bool isEnabled = true;
					XPathNavigator xpathNavigator3 = xpathNavigator.SelectSingleNode("/t:Task/t:Settings/t:Enabled", xmlNamespaceManager);
					bool flag;
					if (xpathNavigator3 != null && bool.TryParse(xpathNavigator3.Value, out flag))
					{
						isEnabled = flag;
					}
					XPathNavigator xpathNavigator4 = xpathNavigator.SelectSingleNode("/t:Task/t:Actions/t:Exec/t:Command", xmlNamespaceManager);
					string command = (xpathNavigator4 != null) ? xpathNavigator4.Value : null;
					XPathNavigator xpathNavigator5 = xpathNavigator.SelectSingleNode("/t:Task/t:Actions/t:Exec/t:Arguments", xmlNamespaceManager);
					string string_3 = (xpathNavigator5 != null) ? xpathNavigator5.Value : null;
					Class662.Class663 @class = new Class662.Class663();
					@class.Path = string_2;
					@class.Name = fileName;
					@class.Description = description;
					@class.IsEnabled = isEnabled;
					@class.Command = command;
					@class.method_1(string_3);
					result = @class;
				}
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x00016AA2 File Offset: 0x00014CA2
	private static string smethod_5(string string_1)
	{
		if (!string_1.StartsWith("\\"))
		{
			return "\\" + string_1;
		}
		return string_1;
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x00089D7C File Offset: 0x00087F7C
	private static string smethod_6(string string_1)
	{
		string path = string_1.TrimStart(new char[]
		{
			'\\'
		}).Replace('\\', Path.DirectorySeparatorChar);
		return Path.Combine(Class662.string_0, path);
	}

	// Token: 0x06002296 RID: 8854 RVA: 0x00089DB4 File Offset: 0x00087FB4
	private static string smethod_7(string string_1)
	{
		string text;
		if (string_1.StartsWith(Class662.string_0, StringComparison.OrdinalIgnoreCase))
		{
			text = string_1.Substring(Class662.string_0.Length).TrimStart(new char[]
			{
				'\\',
				'/'
			});
		}
		else
		{
			text = string_1;
		}
		text = text.Replace(Path.DirectorySeparatorChar, '\\');
		if (!text.StartsWith("\\"))
		{
			text = "\\" + text;
		}
		return text;
	}

	// Token: 0x06002297 RID: 8855 RVA: 0x00089E24 File Offset: 0x00088024
	private static string smethod_8()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
		string text = Path.Combine(folderPath, "System32", "Tasks");
		if (Directory.Exists(text))
		{
			return text;
		}
		string text2 = Path.Combine(folderPath, "Sysnative", "Tasks");
		if (Directory.Exists(text2))
		{
			return text2;
		}
		return text;
	}

	// Token: 0x040016F7 RID: 5879
	private static readonly string string_0 = Class662.smethod_8();

	// Token: 0x02000566 RID: 1382
	public sealed class Class663
	{
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x00016AC0 File Offset: 0x00014CC0
		// (set) Token: 0x0600229A RID: 8858 RVA: 0x00016AC8 File Offset: 0x00014CC8
		public string Path
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

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x00016AD1 File Offset: 0x00014CD1
		// (set) Token: 0x0600229C RID: 8860 RVA: 0x00016AD9 File Offset: 0x00014CD9
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x00016AE2 File Offset: 0x00014CE2
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x00016AEA File Offset: 0x00014CEA
		public string Description
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00016AF3 File Offset: 0x00014CF3
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x00016AFB File Offset: 0x00014CFB
		public bool IsEnabled
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x00016B04 File Offset: 0x00014D04
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x00016B0C File Offset: 0x00014D0C
		public string Command
		{
			[CompilerGenerated]
			get
			{
				return this.string_3;
			}
			[CompilerGenerated]
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00016B15 File Offset: 0x00014D15
		public string method_0()
		{
			return this.string_4;
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00016B1D File Offset: 0x00014D1D
		public void method_1(string string_5)
		{
			this.string_4 = string_5;
		}

		// Token: 0x040016F8 RID: 5880
		private string string_0;

		// Token: 0x040016F9 RID: 5881
		private string string_1;

		// Token: 0x040016FA RID: 5882
		private string string_2;

		// Token: 0x040016FB RID: 5883
		private bool bool_0;

		// Token: 0x040016FC RID: 5884
		private string string_3;

		// Token: 0x040016FD RID: 5885
		private string string_4;
	}
}
