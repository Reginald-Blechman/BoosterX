using System;
using System.Management;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using ns0;

// Token: 0x0200070B RID: 1803
internal sealed class Class805 : GClass283
{
	// Token: 0x06002D04 RID: 11524 RVA: 0x0001CF16 File Offset: 0x0001B116
	internal Class805(GClass171 gclass171_1, GClass293 gclass293_1)
	{
		this.gclass171_0 = gclass171_1;
		this.gclass293_0 = gclass293_1;
	}

	// Token: 0x06002D05 RID: 11525 RVA: 0x000AB9F0 File Offset: 0x000A9BF0
	protected override void vmethod_0(object object_0)
	{
		base.imethod_1(Class298.smethod_2("Changing") + " \"" + Class298.smethod_2(this.gclass171_0.DisplayName) + "\"", (GEnum15)0);
		string text = (this.gclass171_0.Values != null) ? this.gclass171_0.SelectedRaw : this.gclass171_0.CustomValue;
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		if (!string.IsNullOrEmpty(this.gclass293_0.method_4()))
		{
			string text2 = "HKEY_LOCAL_MACHINE\\" + this.gclass293_0.method_4();
			string text3 = "REG_SZ";
			Class808.smethod_27(string.Concat(new string[]
			{
				"reg add \"",
				text2,
				"\" /v \"",
				this.gclass171_0.Name,
				"\" /t ",
				text3,
				" /d \"",
				text,
				"\" /f"
			}));
		}
		else
		{
			try
			{
				string pathString = string.Concat(new string[]
				{
					"MSFT_NetAdapterAdvancedPropertySettingData.InstanceID=\"",
					this.gclass293_0.method_0(),
					"\",RegistryKeyword=\"",
					this.gclass171_0.Name,
					"\""
				});
				object arg = new ManagementObject("root/StandardCimv2", pathString, null);
				if (Class805.Class869.callSite_2 == null)
				{
					Class805.Class869.callSite_2 = CallSite<Func<CallSite, object, IDisposable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IDisposable), typeof(Class805)));
				}
				using (Class805.Class869.callSite_2.Target(Class805.Class869.callSite_2, arg))
				{
					if (Class805.Class869.callSite_0 == null)
					{
						Class805.Class869.callSite_0 = CallSite<Func<CallSite, object, string, string, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(Class805), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Class805.Class869.callSite_0.Target(Class805.Class869.callSite_0, arg, "RegistryValue", text);
					if (Class805.Class869.callSite_1 == null)
					{
						Class805.Class869.callSite_1 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Put", null, typeof(Class805), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Class805.Class869.callSite_1.Target(Class805.Class869.callSite_1, arg);
				}
			}
			catch
			{
			}
		}
		object object_ = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.object_0;
		lock (object_)
		{
			if (!dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_3.Contains(this.gclass293_0.method_0()))
			{
				dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_3.Add(this.gclass293_0.method_0());
			}
		}
	}

	// Token: 0x04001D52 RID: 7506
	private GClass171 gclass171_0;

	// Token: 0x04001D53 RID: 7507
	private GClass293 gclass293_0;

	// Token: 0x0200070C RID: 1804
	private static class Class869
	{
		// Token: 0x04001D54 RID: 7508
		public static CallSite<Func<CallSite, object, string, string, object>> callSite_0;

		// Token: 0x04001D55 RID: 7509
		public static CallSite<Action<CallSite, object>> callSite_1;

		// Token: 0x04001D56 RID: 7510
		public static CallSite<Func<CallSite, object, IDisposable>> callSite_2;
	}
}
