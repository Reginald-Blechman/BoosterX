using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x02000429 RID: 1065
internal sealed class Class475
{
	// Token: 0x06001BBE RID: 7102 RVA: 0x000128C8 File Offset: 0x00010AC8
	public static Class475 smethod_0()
	{
		Class475 result;
		if ((result = Class475.class475_0) == null)
		{
			result = (Class475.class475_0 = new Class475());
		}
		return result;
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x00076D3C File Offset: 0x00074F3C
	public MaterialIconKind method_0(string string_0)
	{
		MaterialIconKind result = 0;
		try
		{
			if (string_0 != null && string_0 != string.Empty && string_0 != "CHANGE")
			{
				Class475.Class476 @class = new Class475.Class476();
				@class.string_0 = string.Empty;
				string_0.Split(new char[]
				{
					'-'
				}).ToList<string>().ForEach(new Action<string>(@class.method_0));
				MaterialIconKind materialIconKind;
				if (Enum.TryParse<MaterialIconKind>(@class.string_0, out materialIconKind))
				{
					result = materialIconKind;
				}
			}
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x00076DC8 File Offset: 0x00074FC8
	public string method_1(List<string> list_0)
	{
		if (!Class551.class753_0.method_88().GetValueOrDefault())
		{
			return string.Empty;
		}
		List<string> list = new List<string>();
		if (list_0.Contains("W11") && dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_3)
		{
			list.Add(Class298.smethod_2("W11Warn"));
		}
		if (list_0.Contains("W10") && dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_4)
		{
			list.Add(Class298.smethod_2("W10Warn"));
		}
		if (list_0.Contains("LAPTOP") && dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_5)
		{
			list.Add(Class298.smethod_2("LAPTOPWarn"));
		}
		if (list_0.Contains("PC") && !dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_5)
		{
			list.Add(Class298.smethod_2("PCWarn"));
		}
		if (list_0.Contains("AMD") && !dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_7)
		{
			list.Add(Class298.smethod_2("AMDWarn"));
		}
		if (list_0.Contains("HAGS") && !dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_6)
		{
			list.Add(Class298.smethod_2("HAGSWarn"));
		}
		if (list_0.Contains("22H2+") && !dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_10)
		{
			list.Add(Class298.smethod_2("22H2PlusWarn"));
		}
		return string.Join("\n\n", list);
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x00076F0C File Offset: 0x0007510C
	internal ObservableCollection<GClass176> method_2(List<Class275> list_0)
	{
		ObservableCollection<GClass176> observableCollection = new ObservableCollection<GClass176>();
		foreach (GClass176 item in list_0.Select(new Func<Class275, GClass176>(this.method_6)))
		{
			observableCollection.Add(item);
		}
		return observableCollection;
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x000128DE File Offset: 0x00010ADE
	private GClass176 method_3(Class275 class275_0)
	{
		return new GClass176
		{
			NameRaw = ((!class275_0.String_1.smethod_9()) ? class275_0.String_1 : this.method_5(class275_0)),
			Foreground = this.method_4(class275_0)
		};
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x00012914 File Offset: 0x00010B14
	private SolidColorBrush method_4(Class275 class275_0)
	{
		if (class275_0.Boolean_4)
		{
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;
		}
		if (class275_0.method_1())
		{
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGR5QHU2M7DAPA2_ejd;
		}
		return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
	}

	// Token: 0x06001BC4 RID: 7108 RVA: 0x00012937 File Offset: 0x00010B37
	private string method_5(Class275 class275_0)
	{
		if (class275_0.Boolean_4)
		{
			return "bestest";
		}
		if (class275_0.method_1())
		{
			return "optimal";
		}
		return "default";
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x0001295D File Offset: 0x00010B5D
	private GClass176 method_6(Class275 class275_0)
	{
		return this.method_3(class275_0);
	}

	// Token: 0x04001287 RID: 4743
	private static Class475 class475_0;

	// Token: 0x0200042A RID: 1066
	private sealed class Class476
	{
		// Token: 0x06001BC7 RID: 7111 RVA: 0x00012966 File Offset: 0x00010B66
		internal void method_0(string string_1)
		{
			this.string_0 += string_1.smethod_4();
		}

		// Token: 0x04001288 RID: 4744
		public string string_0;
	}
}
