using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Token: 0x020004D3 RID: 1235
internal sealed class Class585
{
	// Token: 0x06001F8B RID: 8075 RVA: 0x000808C0 File Offset: 0x0007EAC0
	private static double smethod_0()
	{
		double result;
		try
		{
			double num = 0.0;
			foreach (string string_2 in Class169.string_18)
			{
				num += Class808.smethod_14(string_2);
			}
			result = num;
		}
		catch
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x06001F8C RID: 8076 RVA: 0x00014E56 File Offset: 0x00013056
	public static Task smethod_1()
	{
		return Task.Run(new Action(Class585.Class588.class588_0.method_0));
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x00014E7C File Offset: 0x0001307C
	public static Task smethod_2(int int_0)
	{
		return Task.Run(new Action(new Class585.Class587
		{
			int_0 = int_0
		}.method_0));
	}

	// Token: 0x0400150C RID: 5388
	public static List<Class585.Class586> list_0 = new List<Class585.Class586>();

	// Token: 0x020004D4 RID: 1236
	public sealed class Class586
	{
		// Token: 0x06001F8E RID: 8078 RVA: 0x00014E9A File Offset: 0x0001309A
		public Class586(string string_2, string string_3, double double_3, double double_4, double double_5)
		{
			this.DiskName = string_2;
			this.method_1(string_3);
			this.method_3(double_3);
			this.method_5(double_4);
			this.method_7(double_5);
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00014EC7 File Offset: 0x000130C7
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x00014ECF File Offset: 0x000130CF
		public string DiskName
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

		// Token: 0x06001F91 RID: 8081 RVA: 0x00014ED8 File Offset: 0x000130D8
		public string method_0()
		{
			return this.string_1;
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00014EE0 File Offset: 0x000130E0
		public void method_1(string string_2)
		{
			this.string_1 = string_2;
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00014EE9 File Offset: 0x000130E9
		public double method_2()
		{
			return this.double_0;
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00014EF1 File Offset: 0x000130F1
		public void method_3(double double_3)
		{
			this.double_0 = double_3;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00014EFA File Offset: 0x000130FA
		public double method_4()
		{
			return this.double_1;
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00014F02 File Offset: 0x00013102
		public void method_5(double double_3)
		{
			this.double_1 = double_3;
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00014F0B File Offset: 0x0001310B
		public double method_6()
		{
			return this.double_2;
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00014F13 File Offset: 0x00013113
		public void method_7(double double_3)
		{
			this.double_2 = double_3;
		}

		// Token: 0x0400150D RID: 5389
		private string string_0;

		// Token: 0x0400150E RID: 5390
		private string string_1;

		// Token: 0x0400150F RID: 5391
		private double double_0;

		// Token: 0x04001510 RID: 5392
		private double double_1;

		// Token: 0x04001511 RID: 5393
		private double double_2;
	}

	// Token: 0x020004D5 RID: 1237
	private sealed class Class587
	{
		// Token: 0x06001F9A RID: 8090 RVA: 0x0008091C File Offset: 0x0007EB1C
		internal void method_0()
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			try
			{
				Class585.list_0[this.int_0].method_5((double)(drives[this.int_0].AvailableFreeSpace / 1073741824L));
				Class585.list_0[this.int_0].method_7(drives[this.int_0].Name.Remove(drives[this.int_0].Name.Length - 2).Contains("C") ? Class585.smethod_0() : 0.0);
			}
			catch
			{
			}
		}

		// Token: 0x04001512 RID: 5394
		public int int_0;
	}

	// Token: 0x020004D6 RID: 1238
	[Serializable]
	private sealed class Class588
	{
		// Token: 0x06001F9D RID: 8093 RVA: 0x000809CC File Offset: 0x0007EBCC
		internal void method_0()
		{
			Class585.list_0.Clear();
			try
			{
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
				{
					if (driveInfo.IsReady)
					{
						Class585.list_0.Add(new Class585.Class586(driveInfo.Name.Remove(driveInfo.Name.Length - 2), driveInfo.DriveType.ToString(), (double)driveInfo.TotalSize / 1073741824.0, (double)driveInfo.AvailableFreeSpace / 1073741824.0, driveInfo.Name.Remove(driveInfo.Name.Length - 2).Contains("C") ? Class585.smethod_0() : 0.0));
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x04001513 RID: 5395
		public static readonly Class585.Class588 class588_0 = new Class585.Class588();

		// Token: 0x04001514 RID: 5396
		public static Action action_0;
	}
}
