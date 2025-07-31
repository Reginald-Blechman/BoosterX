using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x0200056B RID: 1387
internal static class Class667
{
	// Token: 0x060022CE RID: 8910 RVA: 0x00016DF3 File Offset: 0x00014FF3
	internal static void smethod_0()
	{
		AppDomain.CurrentDomain.ResourceResolve += Class667.smethod_1;
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x00016E0B File Offset: 0x0001500B
	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (resolveEventArgs_0.RequestingAssembly != Class667.assembly_0)
		{
			return null;
		}
		if (Class667.bool_0)
		{
			return null;
		}
		return Class667.smethod_2(resolveEventArgs_0.Name);
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x0008A0E8 File Offset: 0x000882E8
	private static Assembly smethod_2(string string_0)
	{
		Class667.bool_0 = true;
		Assembly result;
		try
		{
			Class667.smethod_3();
			Class667.Class668 @class;
			if (!Class667.dictionary_0.TryGetValue(string_0, out @class))
			{
				result = null;
			}
			else
			{
				result = @class.method_0();
			}
		}
		finally
		{
			Class667.bool_0 = false;
		}
		return result;
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x0008A138 File Offset: 0x00088338
	private static void smethod_3()
	{
		if (Class667.dictionary_0 == null)
		{
			Assembly obj = Class667.assembly_0;
			lock (obj)
			{
				if (Class667.dictionary_0 == null)
				{
					string text = "zx_973be35f20c7450cfc501606f29c1e00, PublicKeyToken=null|BoosterX.g.resources:zx_3cc2d765ca0846b01765996ca7e06751, PublicKeyToken=null|BoosterX.Properties.Resources.resources:zx_b73175fa6ac74ac096d643adc64f739a, PublicKeyToken=null|BoosterX.Services.NvidiaX.CustomSettingNames.json:zx_5c212cc5dc164f533929d5b22682baf2, PublicKeyToken=null|BoosterX.Resources.Json.BasicSettingsTweaks.json:zx_b6976cb39de2482e2c035a7e13e8e474, PublicKeyToken=null|BoosterX.Resources.Json.PowerSettings.json:zx_cb4b636e73bc404d3996164872302bc4, PublicKeyToken=null|BoosterX.Resources.Json.RegistryTweaks.json:zx_fc5ada553c1241295493b592e9dc6b2e, PublicKeyToken=null|BoosterX.Resources.Json.CleanUp.json:zx_3d3ba6cf83724b6f903474e9e39a3282, PublicKeyToken=null|BoosterX.Resources.Json.WindowsTelemetry.json:zx_3616c30ba8654713f944559485b185bd, PublicKeyToken=null|BoosterX.Resources.Json.Debloat.json:zx_17affd44f30b4ef62af0d873a552dbba, PublicKeyToken=null|BoosterX.Resources.Json.Tasks.json:zx_cbc43157db54486db8504c6abe45c504, PublicKeyToken=null|BoosterX.Resources.Json.Customization.json:zx_025e299be0804ffea7d2f86c51fb5ed2, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Debloat.edge.json:zx_06f74939e5ef45690fe184943439f3fc, PublicKeyToken=null|BoosterX.Resources.Json.Security.json:zx_b0a7a6078dba4c0c806b78a9360f2e53, PublicKeyToken=null|BoosterX.Resources.Json.Placebo.json:zx_6a3974adc6e049f5a26e234210dc8fa4, PublicKeyToken=null|BoosterX.Resources.Json.Interrupts.json:zx_05bf4a7e39c24d23a207b76e527d8f64, PublicKeyToken=null|BoosterX.Resources.Json.allServices.json:zx_1c04cfe675b349bcb59ec8280f431bdc, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Defender.enable.bat:zx_0ab56ed4281340cfa6fbe9429e090e78, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Updates.disable.bat:zx_f5f140ca098945e4ed5b8221dfd19664, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Updates.enable.bat:zx_91104f23066d4e70df8aa63f08741789, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Debloat.DeleteOneDrive.bat:zx_f9bfeaffcb0546e1066091dcd18aa012, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Debloat.RemoveEgde.bat:zx_6a914fc2cc8c425a2724f0cbe3e87fe4, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Defender.RemoveDefenderRegs.bat:zx_50669da40f314925d4f7626681211451, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Defender.disable.bat:zx_bf1f6c68d2c94ba206a10f8dfb0a1e15, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Debloat.EdgeRemover2.bat:zx_66dde029f8464e0be51a7b9985435a32, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Fixes.BlueLightDefault.bat:zx_911d1f4d4a39407d5b591c650d40923f, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Fixes.FixDefenderUI.bat:zx_cff99aa13f2c484f076eb6857f4d79e6, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Fixes.NightLightFix.bat:zx_89140b068f274fc5542478a6bfaaedb8, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Smartscreen.disable.bat:zx_070d51ce965f4ea9a125ed75778c842d, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Smartscreen.enable.bat:zx_b756ae2b6e2d47aeb8bf6ccbdfd570c6, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Updates.pause.bat:zx_3ca74c62f7574cf4f4fb23b1369613a5, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Checkers.pincode.bat:zx_95355be37a514a3abb0da5927b88f974, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.balance.pow:zx_625a0495a61c4eb68bab5178cb762f95, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.high.pow:zx_25c3c6b80609407be04322cff8a85491, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.save.pow:zx_37e01c3fa3c44e849c61de9dc8c4508f, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.ultra.pow:zx_32b1a1e8c5c9465d48f7b21159af754e, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.PowerXv1.pow:zx_fc927753fe06439bc236b34b24bb1358, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.PowerXv2.pow:zx_098f43c00c744a8da317403585efb694, PublicKeyToken=null|BoosterX.Resources.EmbedRes.PowerPlans.PowerXv3.pow:zx_b9fc4d5ea5514c7c4ab67a71893cf5c5, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Nvidia.BestProfile.nvx:zx_128ab55c2902423df8fedcecd0644f78, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.Pnp.pnputil.exe.mui:zx_b2fff7459c054a5b7683f44b01ca3ede, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Tweaks.Fixes.appxfixer.ps1:zx_740d9139eb01461b5a6ffb36fb9147bf, PublicKeyToken=null|BoosterX.App.config:zx_eb7ae7d16db14f9e1eb7d750e082b240, PublicKeyToken=null|BoosterX.Services.StoreLib.Xml.FE3FileUrl.xml:zx_65c4183209624387238b6755db339443, PublicKeyToken=null|BoosterX.Services.StoreLib.Xml.GetCookie.xml:zx_0ef7b8cb2751498f31c67d0972eceb32, PublicKeyToken=null|BoosterX.Services.StoreLib.Xml.WUIDRequest.xml:zx_4a3a2da5e69f4cc1cafed4b0c1c07531, PublicKeyToken=null|costura64.libskiasharp.dll:zx_ffd5a479d9894923360e2ebcf746b34a, PublicKeyToken=null|BoosterX.Resources.EmbedRes.CabFiles.Windows10.BX-NoDefender-Package31bf3856ad364e35amd641.0.0.0.cab:zx_23a67d54e4a34b128f85d73f58637fa9, PublicKeyToken=null|BoosterX.Resources.EmbedRes.CabFiles.BX-NoSmartScreen-Package31bf3856ad364e35amd641.0.0.0.cab:zx_6b639d48018a4bf74d227f68c94383cc, PublicKeyToken=null|BoosterX.Resources.EmbedRes.CabFiles.Windows11.BX-NoDefender-Package31bf3856ad364e35amd641.0.0.0.cab:zx_3bde769f7ac84f6e52fd42dc15dd1ee2, PublicKeyToken=null|BoosterX.Resources.Icon.Logo.ico:zx_add7ba4be55c42225766e06b5efef0ba, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.Updater.exe:zx_d74fbff2efe04096d4940b718fed94db, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.Pnp.pnputil.exe:zx_1a5d42dba428477765a195a3e51f4104, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.ServiceX.exe:zx_1660250b8d164d355009789a5e3606e6, PublicKeyToken=null|BoosterX.Resources.EmbedRes.Exes.GameModeX.exe:zx_38f9cf9260b84f16472cc800ca3b1bd8, PublicKeyToken=null|costura.costura.dll.compressed:zx_cbf82b3c3c8942138b28cf12cb947315, PublicKeyToken=null|costura.discordrpc.dll.compressed:zx_8e78dc45393c4c986ca40a02f185276e, PublicKeyToken=null|costura.famfamfam.flags.wpf.dll.compressed:zx_dcdb963538964119bfa2cb1cc133bf94, PublicKeyToken=null|costura.gameloop.vdf.dll.compressed:zx_69c89f40a9804b5ab71781460cb13fd9, PublicKeyToken=null|costura.harfbuzzsharp.dll.compressed:zx_98069a02eaca47b66e0eaa82f4a5428a, PublicKeyToken=null|costura.hidsharp.dll.compressed:zx_77c42cd9b3dd49adaeb6ae4a4602c55d, PublicKeyToken=null|costura.igdb.dll.compressed:zx_4d0bb8c6d57b4790085a673d5c80e225, PublicKeyToken=null|costura.imageprocessor.dll.compressed:zx_9559357cd662430ac4dd570f3657478d, PublicKeyToken=null|costura.livechartscore.dll.compressed:zx_bbfe9cf94f29467a93d89453c0518b08, PublicKeyToken=null|costura.livechartscore.skiasharpview.dll.compressed:zx_a8c1b85ec8e04a9c9d2ae64e4275ad77, PublicKeyToken=null|costura.livechartscore.skiasharpview.wpf.dll.compressed:zx_4909227b92b74b491be09426e1dfe3f9, PublicKeyToken=null|costura.markdig.dll.compressed:zx_faa7df44af814361ab446669241fdef8, PublicKeyToken=null|costura.markdig.wpf.dll.compressed:zx_33055ca8292d4d5abd94b63861f542e5, PublicKeyToken=null|costura.material.icons.dll.compressed:zx_353fffc491e84ce47b7a26d6dec74b92, PublicKeyToken=null|costura.material.icons.wpf.dll.compressed:zx_c9291e4b7aaa4be939729d46f29bb7e2, PublicKeyToken=null|costura.microsoft.windowsapicodepack.dll.compressed:zx_db030264ce814d6a51b41f3385397a5e, PublicKeyToken=null|costura.microsoft.windowsapicodepack.shell.dll.compressed:zx_01c91d02eb8544ae2566c47cbe821f77, PublicKeyToken=null|costura.microsoft.bcl.asyncinterfaces.dll.compressed:zx_e1032e313dfe4cedbacb72917972751f, PublicKeyToken=null|costura.microsoft.dism.dll.compressed:zx_0576630386134ee959ab7c1ee04c9a63, PublicKeyToken=null|costura.microsoft.extensions.configuration.abstractions.dll.compressed:zx_9de73e202ddc4443d4a48c4425f8eb94, PublicKeyToken=null|costura.microsoft.extensions.dependencyinjection.dll.compressed:zx_0c2588a56f4b46fc52cef4ba91acd1e0, PublicKeyToken=null|costura.microsoft.extensions.dependencyinjection.abstractions.dll.compressed:zx_48a5bfc360454183ea2883cad6dd0b21, PublicKeyToken=null|costura.microsoft.extensions.http.dll.compressed:zx_43af178dd0af4f820f5d0be5e36941bc, PublicKeyToken=null|costura.microsoft.extensions.logging.dll.compressed:zx_f440bf1a45e44adc862f791faa0f741b, PublicKeyToken=null|costura.microsoft.extensions.logging.abstractions.dll.compressed:zx_40b65e8cc6c440cac82e0a9693748a06, PublicKeyToken=null|costura.microsoft.extensions.options.dll.compressed:zx_fa54ff310643466a589c39b1fc7c579a, PublicKeyToken=null|costura.microsoft.extensions.primitives.dll.compressed:zx_c47069df04eb4a5fab69455f9799825f, PublicKeyToken=null|costura.microsoft.xaml.behaviors.dll.compressed:zx_9675c4617de5414ec8640714389c5cf0, PublicKeyToken=null|costura.newtonsoft.json.dll.compressed:zx_22200beb1b0e46ad4493f6080cdb4026, PublicKeyToken=null|costura.opentk.dll.compressed:zx_3992e4b14338442d6cd087ea479a1204, PublicKeyToken=null|costura.glwpfcontrol.dll.compressed:zx_5d3fef88700e4ac3ba729b6ffd0ad435, PublicKeyToken=null|costura.oxyplot.dll.compressed:zx_ba3a5730698140da3c039fd60f1051a8, PublicKeyToken=null|costura.oxyplot.wpf.dll.compressed:zx_7e172e8e8fdf49e1d9e21587c96898b2, PublicKeyToken=null|costura.oxyplot.wpf.shared.dll.compressed:zx_5d50c712424740f2e03d6e2378968386, PublicKeyToken=null|costura.ramspdtoolkit.dll.compressed:zx_6fffcf12eba24a3c249f9ed7344dfe18, PublicKeyToken=null|costura.rawinput.sharp.dll.compressed:zx_2f96c7ea77d944b1bdeb949318454215, PublicKeyToken=null|costura.restease.dll.compressed:zx_1ee089a67c46449071f7e8e92e75e60e, PublicKeyToken=null|costura.skiasharp.dll.compressed:zx_88da90e9c69d453f7f5c772d14fe2aed, PublicKeyToken=null|costura.skiasharp.harfbuzz.dll.compressed:zx_93ff677b18624f6e4698dd95f5f45153, PublicKeyToken=null|costura.skiasharp.views.desktop.common.dll.compressed:zx_025ed618bec944c1dccdcf1778a76a7d, PublicKeyToken=null|costura.skiasharp.views.wpf.dll.compressed:zx_21280f0085bf48ca755801591e07f07f, PublicKeyToken=null|costura.system.buffers.dll.compressed:zx_aece36a261cc4950fca6fff91af079f7, PublicKeyToken=null|costura.system.codedom.dll.compressed:zx_66ac1adc686147ee1e3cf9dd05857531, PublicKeyToken=null|costura.system.diagnostics.diagnosticsource.dll.compressed:zx_fc0c670f88bd4acc2703d9af10749efa, PublicKeyToken=null|costura.system.io.pipelines.dll.compressed:zx_d7dd3f6df59944a5314d5f0bf31bbb95, PublicKeyToken=null|costura.system.memory.dll.compressed:zx_6052e13c80844245150c4638dbf7b7b5, PublicKeyToken=null|costura.system.numerics.vectors.dll.compressed:zx_dd1c994c82b846e266ff99f0ca47ae16, PublicKeyToken=null|costura.system.runtime.compilerservices.unsafe.dll.compressed:zx_86c11de38a994b9e2768f66eca55dc4f, PublicKeyToken=null|costura.system.security.principal.windows.dll.compressed:zx_2a3ffa2b0c2b44248944f730b7ed87dd, PublicKeyToken=null|costura.system.text.encodings.web.dll.compressed:zx_c8b25b202be144c1a2f99e04e1f15a0a, PublicKeyToken=null|costura.system.text.json.dll.compressed:zx_76009a30e62b491662bfc9048094d014, PublicKeyToken=null|costura.system.threading.channels.dll.compressed:zx_c63229aed8f540410f572997b258acf5, PublicKeyToken=null|costura.system.threading.tasks.extensions.dll.compressed:zx_afa30f80c49843886431c089676c9dbd, PublicKeyToken=null|costura.system.valuetuple.dll.compressed:zx_3cdf83a58a04468d90b13ce6cac35874, PublicKeyToken=null|costura.microsoft.win32.taskscheduler.dll.compressed:zx_4fe9a718e23a4a0531e87935acc2f9c8, PublicKeyToken=null|costura.de.microsoft.win32.taskscheduler.resources.dll.compressed:zx_16f6359ee7324462f7cf204cda5e0338, PublicKeyToken=null|costura.es.microsoft.win32.taskscheduler.resources.dll.compressed:zx_d9accaae41c74881d2e1445ae57cbca0, PublicKeyToken=null|costura.fr.microsoft.win32.taskscheduler.resources.dll.compressed:zx_8315711b75d1415f8020a1fb739da111, PublicKeyToken=null|costura.it.microsoft.win32.taskscheduler.resources.dll.compressed:zx_1780259c39514d7b50df75973090bf50, PublicKeyToken=null|costura.ja.microsoft.win32.taskscheduler.resources.dll.compressed:zx_fc7da308c1d947308f7e5dd7591bfb96, PublicKeyToken=null|costura.pl.microsoft.win32.taskscheduler.resources.dll.compressed:zx_5f5c5a7853b94e0ac44080fe6321a8cd, PublicKeyToken=null|costura.ru.microsoft.win32.taskscheduler.resources.dll.compressed:zx_98d331cd93b0498bc40be90f00b1c6e8, PublicKeyToken=null|costura.sv.microsoft.win32.taskscheduler.resources.dll.compressed:zx_6b2df0fa18f747ca0eaffea1bdcf7195, PublicKeyToken=null|costura.tr.microsoft.win32.taskscheduler.resources.dll.compressed:zx_6fb0d88320c84fa4ef656c454188c0e8, PublicKeyToken=null|costura.zh-cn.microsoft.win32.taskscheduler.resources.dll.compressed:zx_9287db69df90445277520dc3e84e64f6, PublicKeyToken=null|costura.zh-hant.microsoft.win32.taskscheduler.resources.dll.compressed:zx_a9ceeaa0dd2e4dc14f8ee1744edf27f6, PublicKeyToken=null|costura.iconextractor.dll.compressed:zx_ded0ffb41b704cdb006907446a4c5906, PublicKeyToken=null|costura.wincopies.util.dll.compressed:zx_7c16e406dc9a4af721904b70ffe8abce, PublicKeyToken=null|costura.wincopies.windowsapicodepack.win32native.dll.compressed:zx_47e0f2b8ce5840e90a23232f2c022a62, PublicKeyToken=null|costura.wincopies.windowsapicodepack.win32native.consts.dll.compressed:zx_b6012c8cfb8d42293190ba56e148044b, PublicKeyToken=null|costura.winring0driver.dll.compressed:zx_acd8337047e5483358d68773e00cc05e, PublicKeyToken=null|costura.xamlanimatedgif.dll.compressed:zx_eba79ee6d7394c669320b07eec5376f7, PublicKeyToken=null|costura.devicehelper.dll.compressed:zx_1b2777e191e646b24e1e0e0732869aa4, PublicKeyToken=null|costura.diskdetector.dll.compressed:zx_55f4ef79d46d41f4d447f25f7cf6516a, PublicKeyToken=null|costura.elevrightsx.dll.compressed:zx_c4fd28d0467447e12dd91953bc7ea682, PublicKeyToken=null|costura.librehardwaremonitorlib.dll.compressed:zx_3729e7c7b9f24f7ad957fc7f33013946, PublicKeyToken=null|costura.microsoft.expression.drawing.dll.compressed:zx_cc789fe9ea4e4762f758b14989d07512, PublicKeyToken=null|costura.nvnative.dll.compressed:zx_a7f2b3b366a04e24d5e2ceeb25bb52c3, PublicKeyToken=null|costura.pimanagerx.dll.compressed:zx_b361760e70564d0bdc89f54044383e47, PublicKeyToken=null|costura.system.management.automation.dll.compressed|costura.metadata";
					string[] array = text.Split(new char[]
					{
						':'
					});
					int num = array.Length;
					Dictionary<string, Class667.Class668> dictionary = new Dictionary<string, Class667.Class668>(135, StringComparer.Ordinal);
					for (int num2 = 0; num2 != num; num2++)
					{
						string text2 = array[num2];
						string[] array2 = text2.Split(new char[]
						{
							'|'
						});
						Class667.Class668 value = new Class667.Class668(array2[0]);
						int num3 = array2.Length;
						for (int num4 = 1; num4 != num3; num4++)
						{
							string key = array2[num4];
							dictionary.Add(key, value);
						}
					}
					Class667.dictionary_0 = dictionary;
				}
			}
		}
	}

	// Token: 0x04001704 RID: 5892
	private static readonly Assembly assembly_0 = typeof(Class667).Assembly;

	// Token: 0x04001705 RID: 5893
	private static volatile Dictionary<string, Class667.Class668> dictionary_0;

	// Token: 0x04001706 RID: 5894
	[ThreadStatic]
	private static bool bool_0;

	// Token: 0x0200056C RID: 1388
	private sealed class Class668
	{
		// Token: 0x060022D2 RID: 8914 RVA: 0x00016E30 File Offset: 0x00015030
		internal Class668(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x0008A210 File Offset: 0x00088410
		internal Assembly method_0()
		{
			if (this.assembly_0 == null)
			{
				lock (this)
				{
					if (this.assembly_0 == null)
					{
						this.assembly_0 = Class667.Class668.smethod_0(this.string_0);
					}
				}
			}
			return this.assembly_0;
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00016E3F File Offset: 0x0001503F
		private static Assembly smethod_0(string string_1)
		{
			return Class682.smethod_3(string_1) ?? Assembly.Load(string_1);
		}

		// Token: 0x04001707 RID: 5895
		private readonly string string_0;

		// Token: 0x04001708 RID: 5896
		private volatile Assembly assembly_0;
	}
}
