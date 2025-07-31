using System;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x020000B7 RID: 183
internal static class Class117
{
	// Token: 0x0600057B RID: 1403 RVA: 0x0000590B File Offset: 0x00003B0B
	public static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		if (Class131.smethod_0())
		{
			int metadataToken = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0).MetadataToken;
		}
		Class117.delegate22_0(array_0, runtimeFieldHandle_0);
	}

	// Token: 0x04000309 RID: 777
	private static readonly Class117.Delegate22 delegate22_0 = new Class117.Delegate22(RuntimeHelpers.InitializeArray);

	// Token: 0x020000B8 RID: 184
	// (Invoke) Token: 0x0600057D RID: 1405
	private delegate void Delegate22(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0);
}
