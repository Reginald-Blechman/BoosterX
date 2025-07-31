using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000462 RID: 1122
public abstract class GClass200
{
	// Token: 0x06001D49 RID: 7497 RVA: 0x00013696 File Offset: 0x00011896
	internal GClass200()
	{
		this.ginterface3_0 = GClass200.smethod_1();
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x00079BB0 File Offset: 0x00077DB0
	private static T smethod_0<T>(ICustomAttributeProvider icustomAttributeProvider_0) where T : Attribute
	{
		try
		{
			object[] customAttributes = icustomAttributeProvider_0.GetCustomAttributes(typeof(T), true);
			if (customAttributes.Length == 0)
			{
				return default(T);
			}
			return (T)((object)customAttributes[0]);
		}
		catch
		{
		}
		return default(T);
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x00079C08 File Offset: 0x00077E08
	public void method_0()
	{
		if (this.ginterface3_0.imethod_4(true, true, GClass200.guid_0, GClass200.guid_1) != 0U)
		{
			throw new Exception("Error saving machine settings");
		}
		if (this.ginterface3_0.imethod_4(false, true, GClass200.guid_0, GClass200.guid_1) != 0U)
		{
			throw new Exception("Error saving user settings");
		}
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x000136A9 File Offset: 0x000118A9
	public void method_1()
	{
		if (this.ginterface3_0.imethod_5() != 0U)
		{
			throw new Exception("Error deleting the GPO");
		}
		this.ginterface3_0 = null;
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x00079C60 File Offset: 0x00077E60
	public RegistryKey method_2(GroupPolicySection groupPolicySection_0)
	{
		IntPtr preexistingHandle;
		if (this.ginterface3_0.imethod_12((uint)groupPolicySection_0, out preexistingHandle) != 0U)
		{
			throw new Exception(string.Format("Unable to get section '{0}'", Enum.GetName(typeof(GroupPolicySection), groupPolicySection_0)));
		}
		return RegistryKey.FromHandle(new SafeRegistryHandle(preexistingHandle, true), RegistryView.Default);
	}

	// Token: 0x06001D4F RID: 7503
	public abstract string vmethod_0(GroupPolicySection groupPolicySection_0);

	// Token: 0x06001D50 RID: 7504 RVA: 0x000136CB File Offset: 0x000118CB
	protected static GInterface3 smethod_1()
	{
		return (GInterface3)new Class198();
	}

	// Token: 0x04001377 RID: 4983
	private static readonly Guid guid_0 = new Guid(892833452, 26687, 4562, 168, 154, 0, 192, 79, 187, 207, 162);

	// Token: 0x04001378 RID: 4984
	private static readonly Guid guid_1 = new Guid(GClass200.smethod_0<GuidAttribute>(Assembly.GetExecutingAssembly()).Value);

	// Token: 0x04001379 RID: 4985
	protected GInterface3 ginterface3_0;
}
