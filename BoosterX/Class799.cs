using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using ns0;

// Token: 0x020001BE RID: 446
internal sealed class Class799 : GClass283
{
	// Token: 0x06000C70 RID: 3184 RVA: 0x00009888 File Offset: 0x00007A88
	public Class799(GClass165 gclass165_1)
	{
		this.gclass165_0 = gclass165_1;
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00009897 File Offset: 0x00007A97
	public string ServiceName
	{
		get
		{
			return this.gclass165_0.ServiceName;
		}
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x0004C204 File Offset: 0x0004A404
	protected override void vmethod_0(object object_0)
	{
		object object_ = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.object_1;
		lock (object_)
		{
			this.method_6(object_0.ToString());
			base.imethod_1(string.Concat(new string[]
			{
				Class298.smethod_2("Changing"),
				" ",
				Class298.smethod_2("Service"),
				" ",
				this.ServiceName
			}), (GEnum15)1);
			if (this.NewStartMode != null)
			{
				string text = GClass219.smethod_3(this.NewStartMode);
				if (GClass219.smethod_25(this.ServiceName, text))
				{
					return;
				}
				GClass219.smethod_24(this.ServiceName, text);
				if (this.ServiceName.Contains(Class546.smethod_0().method_0()))
				{
					string text2 = this.ServiceName.Split(new char[]
					{
						'_'
					})[0];
					dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_4.Add(string.Concat(new string[]
					{
						"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\",
						text2,
						"\" /v \"Start\" /t REG_DWORD /d \"",
						text,
						"\" /f"
					}));
				}
				dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_4.Add(string.Concat(new string[]
				{
					"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\",
					this.ServiceName,
					"\" /v \"Start\" /t REG_DWORD /d \"",
					text,
					"\" /f"
				}));
			}
			if (this.method_11() != null)
			{
				string str = GClass219.smethod_6(this.method_11());
				dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_4.Add("sc " + str + " " + this.ServiceName);
			}
		}
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x0004C3C4 File Offset: 0x0004A5C4
	public void method_6(string string_1)
	{
		if (string_1 != null)
		{
			this.method_8(string_1.Split(new char[]
			{
				'|'
			}).ElementAtOrDefault(0) ?? string.Empty);
			this.method_10(string_1.Split(new char[]
			{
				'|'
			}).ElementAtOrDefault(1) ?? string.Empty);
		}
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x0004C420 File Offset: 0x0004A620
	private string method_7()
	{
		if (this.NewStartMode == null)
		{
			return null;
		}
		ServiceStartMode? serviceStartMode;
		return serviceStartMode.GetValueOrDefault().ToString();
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x0004C454 File Offset: 0x0004A654
	private void method_8(string string_1)
	{
		ServiceStartMode value;
		this.NewStartMode = (Enum.TryParse<ServiceStartMode>(string_1, out value) ? new ServiceStartMode?(value) : null);
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06000C76 RID: 3190 RVA: 0x000098A4 File Offset: 0x00007AA4
	// (set) Token: 0x06000C77 RID: 3191 RVA: 0x000098AC File Offset: 0x00007AAC
	public ServiceStartMode? NewStartMode
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x0004C484 File Offset: 0x0004A684
	private string method_9()
	{
		if (this.method_11() == null)
		{
			return null;
		}
		ServiceControllerStatus? serviceControllerStatus;
		return serviceControllerStatus.GetValueOrDefault().ToString();
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x0004C4B8 File Offset: 0x0004A6B8
	private void method_10(string string_1)
	{
		ServiceControllerStatus value;
		this.method_12(Enum.TryParse<ServiceControllerStatus>(string_1, out value) ? new ServiceControllerStatus?(value) : null);
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x000098B5 File Offset: 0x00007AB5
	private ServiceControllerStatus? method_11()
	{
		return this.nullable_1;
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x000098BD File Offset: 0x00007ABD
	private void method_12(ServiceControllerStatus? nullable_2)
	{
		this.nullable_1 = nullable_2;
	}

	// Token: 0x040007FF RID: 2047
	private GClass165 gclass165_0;

	// Token: 0x04000800 RID: 2048
	private ServiceStartMode? nullable_0;

	// Token: 0x04000801 RID: 2049
	private ServiceControllerStatus? nullable_1;
}
