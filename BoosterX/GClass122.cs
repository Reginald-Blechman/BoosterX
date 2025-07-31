using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020005D8 RID: 1496
public sealed class GClass122 : GClass119
{
	// Token: 0x06002673 RID: 9843 RVA: 0x00019A81 File Offset: 0x00017C81
	public GClass122(GClass50 gclass50_1, GClass123 gclass123_1, GClass121 gclass121_1, GClass120 gclass120_2) : base(gclass50_1, null)
	{
		this.gclass123_0 = gclass123_1;
		this.gclass121_0 = gclass121_1;
		this.gclass120_1 = gclass120_2;
	}

	// Token: 0x06002674 RID: 9844 RVA: 0x000930D4 File Offset: 0x000912D4
	public void method_20(string string_0)
	{
		base.method_1(new Action<IntPtr>(new GClass122.Class719
		{
			gclass122_0 = this,
			string_0 = string_0
		}.method_0), false, false);
	}

	// Token: 0x06002675 RID: 9845 RVA: 0x0009310C File Offset: 0x0009130C
	public void method_21(string string_0)
	{
		base.method_1(new Action<IntPtr>(new GClass122.Class722
		{
			gclass122_0 = this,
			string_0 = string_0
		}.method_0), true, true);
	}

	// Token: 0x06002676 RID: 9846 RVA: 0x00093144 File Offset: 0x00091344
	public void method_22(IEnumerable<GClass32> ienumerable_0, string string_0, bool bool_0)
	{
		GClass122.Class714 @class = new GClass122.Class714();
		@class.ienumerable_0 = ienumerable_0;
		@class.gclass122_0 = this;
		@class.bool_0 = bool_0;
		@class.dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0 = new dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd();
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		foreach (dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd in @class.dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0.List_0)
		{
			binaryWriter.Write(dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.String_0);
			binaryWriter.Write(dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_0.Count);
			foreach (string value in dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_0)
			{
				binaryWriter.Write(value);
			}
			binaryWriter.Write(dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_1.Count);
			foreach (dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd in dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_1)
			{
				binaryWriter.Write(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.String_0);
				binaryWriter.Write(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.UInt32_0);
				binaryWriter.Write(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.String_1);
				binaryWriter.Write((byte)dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.Dje_zYUP69W6MGZY5FYTUATS9VDLTFFESDZZ237ZGRWJX_ejd_0);
			}
		}
		byte[] bytes = GClass288.smethod_0(memoryStream.ToArray()).smethod_2(2);
		File.WriteAllBytes(string_0, bytes);
	}

	// Token: 0x06002677 RID: 9847 RVA: 0x000932E4 File Offset: 0x000914E4
	public byte[] method_23(IEnumerable<GClass32> ienumerable_0, bool bool_0)
	{
		GClass122.Class716 @class = new GClass122.Class716();
		@class.ienumerable_0 = ienumerable_0;
		@class.gclass122_0 = this;
		@class.bool_0 = bool_0;
		@class.dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0 = new dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd();
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		foreach (dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd in @class.dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0.List_0)
		{
			binaryWriter.Write(dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.String_0);
			binaryWriter.Write(dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_0.Count);
			foreach (string value in dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_0)
			{
				binaryWriter.Write(value);
			}
			binaryWriter.Write(dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_1.Count);
			foreach (dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd in dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_1)
			{
				binaryWriter.Write(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.String_0);
				binaryWriter.Write(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.UInt32_0);
				binaryWriter.Write(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.String_1);
				binaryWriter.Write((byte)dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.Dje_zYUP69W6MGZY5FYTUATS9VDLTFFESDZZ237ZGRWJX_ejd_0);
			}
		}
		return GClass288.smethod_0(memoryStream.ToArray()).smethod_2(2);
	}

	// Token: 0x06002678 RID: 9848 RVA: 0x0009347C File Offset: 0x0009167C
	private dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd method_24(IntPtr intptr_0, string string_0, bool bool_0)
	{
		dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd = new dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd();
		IntPtr intPtr = base.method_3(intptr_0, string_0);
		if (intPtr != IntPtr.Zero)
		{
			dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.String_0 = string_0;
			foreach (NVDRS_APPLICATION_V3 nvdrs_APPLICATION_V in base.method_16(intptr_0, intPtr))
			{
				dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_0.Add(nvdrs_APPLICATION_V.appName);
			}
			foreach (NVDRS_SETTING nvdrs_SETTING in base.method_15(intptr_0, intPtr))
			{
				bool flag = nvdrs_SETTING.isCurrentPredefined == 1U;
				if (nvdrs_SETTING.settingLocation == 0 && (!flag || bool_0))
				{
					NVDRS_SETTING nvdrs_SETTING_ = nvdrs_SETTING;
					this.gclass120_1.method_23(string_0, ref nvdrs_SETTING_);
					dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd item = GClass154.smethod_1(nvdrs_SETTING_);
					dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_1.Add(item);
				}
			}
		}
		return dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd;
	}

	// Token: 0x06002679 RID: 9849 RVA: 0x0009358C File Offset: 0x0009178C
	internal dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd method_25(string string_0)
	{
		dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd = new dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd();
		if (Path.GetExtension(string_0).Equals(".nip", StringComparison.OrdinalIgnoreCase))
		{
			dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd = GClass257.smethod_0(File.ReadAllText(string_0));
		}
		else
		{
			MemoryStream memoryStream = new MemoryStream(GClass288.smethod_1(File.ReadAllBytes(string_0).smethod_2(2)));
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			while (memoryStream.Position < memoryStream.Length)
			{
				dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd = new dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd
				{
					String_0 = binaryReader.ReadString()
				};
				int num = binaryReader.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_0.Add(binaryReader.ReadString());
				}
				int num2 = binaryReader.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.List_1.Add(new dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd
					{
						String_0 = binaryReader.ReadString(),
						UInt32_0 = binaryReader.ReadUInt32(),
						String_1 = binaryReader.ReadString(),
						Dje_zYUP69W6MGZY5FYTUATS9VDLTFFESDZZ237ZGRWJX_ejd_0 = (dje_zYUP69W6MGZY5FYTUATS9VDLTFFESDZZ237ZGRWJX_ejd)binaryReader.ReadByte()
					});
				}
				dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd.List_0.Add(dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd);
			}
		}
		return dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd;
	}

	// Token: 0x0600267A RID: 9850 RVA: 0x0009369C File Offset: 0x0009189C
	public string method_26(string string_0)
	{
		GClass122.Class720 @class = new GClass122.Class720();
		@class.gclass122_0 = this;
		@class.stringBuilder_0 = new StringBuilder();
		@class.bool_0 = false;
		@class.dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0 = this.method_25(string_0);
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		if (@class.bool_0)
		{
			@class.stringBuilder_0.AppendLine("Hint: If just the profile name has been changed by nvidia, consider to manually modify the profile name inside the import file using a text editor.");
		}
		return @class.stringBuilder_0.ToString();
	}

	// Token: 0x0600267B RID: 9851 RVA: 0x00093710 File Offset: 0x00091910
	private bool method_27(string string_0, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0)
	{
		GClass122.Class721 @class = new GClass122.Class721();
		@class.string_0 = string_0;
		return dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0.List_0.Any(new Func<string, bool>(@class.method_0));
	}

	// Token: 0x0600267C RID: 9852 RVA: 0x00093744 File Offset: 0x00091944
	private void method_28(IntPtr intptr_0, IntPtr intptr_1, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (NVDRS_APPLICATION_V3 nvdrs_APPLICATION_V in base.method_16(intptr_0, intptr_1))
		{
			if (this.method_27(nvdrs_APPLICATION_V.appName, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0) && !hashSet.Contains(nvdrs_APPLICATION_V.appName))
			{
				hashSet.Add(nvdrs_APPLICATION_V.appName);
			}
			else
			{
				NVAPIDrsWrapper.DRS_DeleteApplication.Invoke(intptr_0, intptr_1, new StringBuilder(nvdrs_APPLICATION_V.appName));
			}
		}
		foreach (string text in dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0.List_0)
		{
			if (!hashSet.Contains(text))
			{
				try
				{
					base.method_12(intptr_0, intptr_1, text);
				}
				catch (GException6)
				{
					throw new GException7(text);
				}
			}
		}
	}

	// Token: 0x0600267D RID: 9853 RVA: 0x00093844 File Offset: 0x00091A44
	private uint method_29(uint uint_0, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0)
	{
		GClass122.Class718 @class = new GClass122.Class718();
		@class.uint_0 = uint_0;
		dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd = dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0.List_1.FirstOrDefault(new Func<dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd, bool>(@class.method_0));
		if (dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd != null)
		{
			return uint.Parse(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.String_1);
		}
		return 0U;
	}

	// Token: 0x0600267E RID: 9854 RVA: 0x00093888 File Offset: 0x00091A88
	private dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd method_30(uint uint_0, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0)
	{
		GClass122.Class715 @class = new GClass122.Class715();
		@class.uint_0 = uint_0;
		return dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0.List_1.FirstOrDefault(new Func<dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd, bool>(@class.method_0));
	}

	// Token: 0x0600267F RID: 9855 RVA: 0x000938BC File Offset: 0x00091ABC
	private bool method_31(uint uint_0, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0)
	{
		GClass122.Class717 @class = new GClass122.Class717();
		@class.uint_0 = uint_0;
		return dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0.List_1.Any(new Func<dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd, bool>(@class.method_0));
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x000938F0 File Offset: 0x00091AF0
	private void method_32(IntPtr intptr_0, IntPtr intptr_1, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0, string string_0)
	{
		HashSet<uint> hashSet = new HashSet<uint>();
		foreach (NVDRS_SETTING nvdrs_SETTING in base.method_15(intptr_0, intptr_1))
		{
			bool flag = nvdrs_SETTING.settingLocation == 0;
			bool flag2 = nvdrs_SETTING.isCurrentPredefined == 1U;
			if (flag)
			{
				bool flag3 = this.method_31(nvdrs_SETTING.settingId, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0);
				dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_ = this.method_30(nvdrs_SETTING.settingId, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0);
				NVDRS_SETTING nvdrs_SETTING_ = nvdrs_SETTING;
				this.gclass120_1.method_23(string_0, ref nvdrs_SETTING_);
				if (flag2 && flag3 && GClass154.smethod_0(nvdrs_SETTING_, dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_))
				{
					hashSet.Add(nvdrs_SETTING.settingId);
				}
				else if (flag3)
				{
					NVDRS_SETTING nvdrs_SETTING_2 = GClass154.smethod_4(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_);
					base.method_6(intptr_0, intptr_1, nvdrs_SETTING_2);
					hashSet.Add(nvdrs_SETTING.settingId);
				}
				else if (!flag2)
				{
					NVAPIDrsWrapper.DRS_DeleteProfileSetting.Invoke(intptr_0, intptr_1, nvdrs_SETTING.settingId);
				}
			}
		}
		foreach (dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd in dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd_0.List_1)
		{
			if (!hashSet.Contains(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd.UInt32_0))
			{
				NVDRS_SETTING nvdrs_SETTING_3 = GClass154.smethod_4(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd);
				try
				{
					base.method_6(intptr_0, intptr_1, nvdrs_SETTING_3);
				}
				catch (GException6 gexception)
				{
					if (gexception.nvapi_STATUS_0 != -160)
					{
						throw;
					}
				}
			}
		}
	}

	// Token: 0x0400193A RID: 6458
	private readonly GClass123 gclass123_0;

	// Token: 0x0400193B RID: 6459
	private readonly GClass121 gclass121_0;

	// Token: 0x0400193C RID: 6460
	private readonly GClass120 gclass120_1;

	// Token: 0x020005D9 RID: 1497
	private sealed class Class714
	{
		// Token: 0x06002682 RID: 9858 RVA: 0x00093A6C File Offset: 0x00091C6C
		internal void method_0(IntPtr intptr_0)
		{
			foreach (GClass32 gclass in this.ienumerable_0)
			{
				dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd item = this.gclass122_0.method_24(intptr_0, gclass.ProfileName, this.bool_0);
				this.dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0.List_0.Add(item);
			}
		}

		// Token: 0x0400193D RID: 6461
		public IEnumerable<GClass32> ienumerable_0;

		// Token: 0x0400193E RID: 6462
		public GClass122 gclass122_0;

		// Token: 0x0400193F RID: 6463
		public bool bool_0;

		// Token: 0x04001940 RID: 6464
		public dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0;
	}

	// Token: 0x020005DA RID: 1498
	private sealed class Class715
	{
		// Token: 0x06002684 RID: 9860 RVA: 0x00093AE0 File Offset: 0x00091CE0
		internal bool method_0(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0)
		{
			return dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0.UInt32_0.Equals(this.uint_0);
		}

		// Token: 0x04001941 RID: 6465
		public uint uint_0;
	}

	// Token: 0x020005DB RID: 1499
	private sealed class Class716
	{
		// Token: 0x06002686 RID: 9862 RVA: 0x00093B04 File Offset: 0x00091D04
		internal void method_0(IntPtr intptr_0)
		{
			foreach (GClass32 gclass in this.ienumerable_0)
			{
				dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd item = this.gclass122_0.method_24(intptr_0, gclass.ProfileName, this.bool_0);
				this.dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0.List_0.Add(item);
			}
		}

		// Token: 0x04001942 RID: 6466
		public IEnumerable<GClass32> ienumerable_0;

		// Token: 0x04001943 RID: 6467
		public GClass122 gclass122_0;

		// Token: 0x04001944 RID: 6468
		public bool bool_0;

		// Token: 0x04001945 RID: 6469
		public dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0;
	}

	// Token: 0x020005DC RID: 1500
	private sealed class Class717
	{
		// Token: 0x06002688 RID: 9864 RVA: 0x00093B78 File Offset: 0x00091D78
		internal bool method_0(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0)
		{
			return dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0.UInt32_0.Equals(this.uint_0);
		}

		// Token: 0x04001946 RID: 6470
		public uint uint_0;
	}

	// Token: 0x020005DD RID: 1501
	private sealed class Class718
	{
		// Token: 0x0600268A RID: 9866 RVA: 0x00093B9C File Offset: 0x00091D9C
		internal bool method_0(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0)
		{
			return dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0.UInt32_0.Equals(this.uint_0);
		}

		// Token: 0x04001947 RID: 6471
		public uint uint_0;
	}

	// Token: 0x020005DE RID: 1502
	private sealed class Class719
	{
		// Token: 0x0600268C RID: 9868 RVA: 0x00019AA1 File Offset: 0x00017CA1
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass122_0.method_19(intptr_0, this.string_0);
		}

		// Token: 0x04001948 RID: 6472
		public GClass122 gclass122_0;

		// Token: 0x04001949 RID: 6473
		public string string_0;
	}

	// Token: 0x020005DF RID: 1503
	private sealed class Class720
	{
		// Token: 0x0600268E RID: 9870 RVA: 0x00093BC0 File Offset: 0x00091DC0
		internal void method_0(IntPtr intptr_0)
		{
			foreach (dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd in this.dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0.List_0)
			{
				bool flag = false;
				IntPtr intPtr = this.gclass122_0.method_3(intptr_0, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.String_0);
				if (intPtr == IntPtr.Zero)
				{
					intPtr = this.gclass122_0.method_4(intptr_0, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.String_0);
					NVAPIDrsWrapper.DRS_SaveSettings.Invoke(intptr_0);
					flag = true;
				}
				if (intPtr != IntPtr.Zero)
				{
					bool flag2 = false;
					this.gclass122_0.gclass123_0.method_29(dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.String_0, out flag2);
					try
					{
						this.gclass122_0.method_28(intptr_0, intPtr, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd);
						this.gclass122_0.method_32(intptr_0, intPtr, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd, dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.String_0);
					}
					catch (GException6 gexception)
					{
						if (flag)
						{
							NVAPIDrsWrapper.DRS_DeleteProfile.Invoke(intptr_0, intPtr);
						}
						this.stringBuilder_0.AppendLine(string.Format("Failed to import profile '{0}'", dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd.String_0));
						GException7 gexception2 = gexception as GException7;
						if (gexception2 != null)
						{
							string arg = this.gclass122_0.gclass121_0.method_24(gexception2.string_0);
							this.stringBuilder_0.AppendLine(string.Format("- application '{0}' is already in use by profile '{1}'", gexception2.string_0, arg));
							this.bool_0 = true;
						}
						else
						{
							this.stringBuilder_0.AppendLine(string.Format("- {0}", gexception.Message));
						}
						this.stringBuilder_0.AppendLine();
					}
					NVAPIDrsWrapper.DRS_SaveSettings.Invoke(intptr_0);
				}
			}
		}

		// Token: 0x0400194A RID: 6474
		public dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0;

		// Token: 0x0400194B RID: 6475
		public GClass122 gclass122_0;

		// Token: 0x0400194C RID: 6476
		public StringBuilder stringBuilder_0;

		// Token: 0x0400194D RID: 6477
		public bool bool_0;
	}

	// Token: 0x020005E0 RID: 1504
	private sealed class Class721
	{
		// Token: 0x06002690 RID: 9872 RVA: 0x00019AB5 File Offset: 0x00017CB5
		internal bool method_0(string string_1)
		{
			return string_1.Equals(this.string_0);
		}

		// Token: 0x0400194E RID: 6478
		public string string_0;
	}

	// Token: 0x020005E1 RID: 1505
	private sealed class Class722
	{
		// Token: 0x06002692 RID: 9874 RVA: 0x00019AC3 File Offset: 0x00017CC3
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass122_0.method_18(intptr_0, this.string_0);
			this.gclass122_0.method_17(intptr_0);
		}

		// Token: 0x0400194F RID: 6479
		public GClass122 gclass122_0;

		// Token: 0x04001950 RID: 6480
		public string string_0;
	}
}
