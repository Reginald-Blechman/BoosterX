using System;
using System.Text;
using System.Threading;
using Microsoft.Win32;

// Token: 0x02000459 RID: 1113
public sealed class GClass201 : GClass200
{
	// Token: 0x06001D1A RID: 7450 RVA: 0x0001339F File Offset: 0x0001159F
	public GClass201(GClass270 gclass270_0 = null)
	{
		gclass270_0 = (gclass270_0 ?? new GClass270(true, false));
		if (this.ginterface3_0.imethod_2(gclass270_0.method_0()) != 0U)
		{
			throw new Exception("Unable to open local machine GPO");
		}
		this.bool_0 = true;
	}

	// Token: 0x06001D1B RID: 7451 RVA: 0x0007909C File Offset: 0x0007729C
	public GClass201(string string_0, GClass270 gclass270_0 = null)
	{
		gclass270_0 = (gclass270_0 ?? new GClass270(true, false));
		if (this.ginterface3_0.imethod_3(string_0, gclass270_0.method_0()) != 0U)
		{
			throw new Exception(string.Format("Unable to open GPO on remote machine '{0}'", string_0));
		}
		this.bool_0 = false;
	}

	// Token: 0x06001D1C RID: 7452 RVA: 0x000790EC File Offset: 0x000772EC
	public static void smethod_2(string string_0, string string_1, RegistryValueKind registryValueKind_0)
	{
		GClass201.Class538 @class = new GClass201.Class538();
		@class.string_0 = string_1;
		@class.registryValueKind_0 = registryValueKind_0;
		@class.string_1 = GClass201.smethod_4(string_0, out @class.string_2, out @class.groupPolicySection_0);
		@class.exception_0 = null;
		Thread thread = new Thread(new ThreadStart(@class.method_0));
		if (@class.exception_0 != null)
		{
			return;
		}
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
	}

	// Token: 0x06001D1D RID: 7453 RVA: 0x0007915C File Offset: 0x0007735C
	public static object smethod_3(string string_0)
	{
		GClass201.Class539 @class = new GClass201.Class539();
		@class.string_0 = GClass201.smethod_4(string_0, out @class.string_1, out @class.groupPolicySection_0);
		@class.object_0 = null;
		Thread thread = new Thread(new ThreadStart(@class.method_0));
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
		return @class.object_0;
	}

	// Token: 0x06001D1E RID: 7454 RVA: 0x000791B8 File Offset: 0x000773B8
	private static string smethod_4(string string_0, out string string_1, out GroupPolicySection groupPolicySection_0)
	{
		string[] array = string_0.Split(new char[]
		{
			'!'
		});
		string text = array[0];
		string text2 = text.Substring(0, text.IndexOf('\\'));
		text = text.Substring(text.IndexOf('\\') + 1);
		string_1 = array[1];
		if (!text2.Equals("HKLM", StringComparison.OrdinalIgnoreCase) && !text2.Equals("HKEY_LOCAL_MACHINE", StringComparison.OrdinalIgnoreCase))
		{
			groupPolicySection_0 = GroupPolicySection.User;
		}
		else
		{
			groupPolicySection_0 = GroupPolicySection.Machine;
		}
		return text;
	}

	// Token: 0x06001D1F RID: 7455 RVA: 0x00079228 File Offset: 0x00077428
	public override string vmethod_0(GroupPolicySection groupPolicySection_0)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		if (this.ginterface3_0.imethod_11((uint)groupPolicySection_0, stringBuilder, 1024) != 0U)
		{
			throw new Exception(string.Format("Unable to retrieve path to section '{0}'", Enum.GetName(typeof(GroupPolicySection), groupPolicySection_0)));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0400134A RID: 4938
	public readonly bool bool_0;

	// Token: 0x0200045A RID: 1114
	private sealed class Class538
	{
		// Token: 0x06001D21 RID: 7457 RVA: 0x00079280 File Offset: 0x00077480
		internal void method_0()
		{
			try
			{
				GClass201 gclass = new GClass201(null);
				using (RegistryKey registryKey = gclass.method_2(this.groupPolicySection_0))
				{
					if (this.string_0 == null)
					{
						using (RegistryKey registryKey2 = registryKey.OpenSubKey(this.string_1, true))
						{
							if (registryKey2 != null)
							{
								registryKey2.DeleteValue(this.string_2);
							}
							goto IL_76;
						}
					}
					using (RegistryKey registryKey3 = registryKey.CreateSubKey(this.string_1))
					{
						registryKey3.SetValue(this.string_2, this.string_0, this.registryValueKind_0);
					}
					IL_76:;
				}
				gclass.method_0();
			}
			catch (Exception ex)
			{
				this.exception_0 = ex;
			}
		}

		// Token: 0x0400134B RID: 4939
		public GroupPolicySection groupPolicySection_0;

		// Token: 0x0400134C RID: 4940
		public string string_0;

		// Token: 0x0400134D RID: 4941
		public string string_1;

		// Token: 0x0400134E RID: 4942
		public string string_2;

		// Token: 0x0400134F RID: 4943
		public RegistryValueKind registryValueKind_0;

		// Token: 0x04001350 RID: 4944
		public Exception exception_0;
	}

	// Token: 0x0200045B RID: 1115
	private sealed class Class539
	{
		// Token: 0x06001D23 RID: 7459 RVA: 0x00079358 File Offset: 0x00077558
		internal void method_0()
		{
			using (RegistryKey registryKey = new GClass201(null).method_2(this.groupPolicySection_0))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(this.string_0, true))
				{
					if (registryKey2 == null)
					{
						this.object_0 = null;
					}
					else
					{
						this.object_0 = registryKey2.GetValue(this.string_1);
					}
				}
			}
		}

		// Token: 0x04001351 RID: 4945
		public GroupPolicySection groupPolicySection_0;

		// Token: 0x04001352 RID: 4946
		public string string_0;

		// Token: 0x04001353 RID: 4947
		public object object_0;

		// Token: 0x04001354 RID: 4948
		public string string_1;
	}
}
