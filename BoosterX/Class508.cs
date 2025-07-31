using System;
using System.Collections.ObjectModel;

// Token: 0x0200031F RID: 799
internal sealed class Class508 : GClass162
{
	// Token: 0x060014C6 RID: 5318 RVA: 0x0000E705 File Offset: 0x0000C905
	public Class508()
	{
		this.method_2();
	}

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x060014C7 RID: 5319 RVA: 0x0000E713 File Offset: 0x0000C913
	// (set) Token: 0x060014C8 RID: 5320 RVA: 0x0000E71B File Offset: 0x0000C91B
	public ObservableCollection<Class485> Cmds
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("Cmds");
		}
	}

	// Token: 0x060014C9 RID: 5321 RVA: 0x000648F4 File Offset: 0x00062AF4
	private void method_2()
	{
		this.Cmds = new ObservableCollection<Class485>
		{
			new Class485
			{
				Name = "BIOSReload",
				Cmd = "shutdown /r /fw",
				Icon = 0
			},
			new Class485
			{
				Name = "ShutdownPC",
				Cmd = "shutdown -r -t CUSTOMTIME",
				Icon = 0
			}
		};
	}

	// Token: 0x04000DE2 RID: 3554
	private ObservableCollection<Class485> observableCollection_0;
}
