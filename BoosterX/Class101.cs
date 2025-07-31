using System;

// Token: 0x020000A0 RID: 160
internal static class Class101
{
	// Token: 0x0600050F RID: 1295 RVA: 0x00037B98 File Offset: 0x00035D98
	public static bool smethod_0(Type type_0, Type type_1, out int int_0)
	{
		int_0 = 0;
		if (type_0 == type_1)
		{
			int_0 = 1;
			return true;
		}
		if (type_0 == null || type_1 == null)
		{
			return false;
		}
		if (type_0.IsByRef)
		{
			return type_1.IsByRef && Class101.smethod_0(type_0.GetElementType(), type_1.GetElementType(), out int_0);
		}
		if (type_1.IsByRef)
		{
			return false;
		}
		if (type_0.IsPointer)
		{
			return type_1.IsPointer && Class101.smethod_0(type_0.GetElementType(), type_1.GetElementType(), out int_0);
		}
		if (type_1.IsPointer)
		{
			return false;
		}
		if (type_0.IsArray)
		{
			return type_1.IsArray && type_0.GetArrayRank() == type_1.GetArrayRank() && Class101.smethod_0(type_0.GetElementType(), type_1.GetElementType(), out int_0);
		}
		if (type_1.IsArray)
		{
			return false;
		}
		if (type_0.IsGenericType != type_1.IsGenericType)
		{
			return false;
		}
		if (type_0.IsGenericType)
		{
			Type left = type_0.IsGenericTypeDefinition ? type_0 : type_0.GetGenericTypeDefinition();
			Type right = type_1.IsGenericTypeDefinition ? type_1 : type_1.GetGenericTypeDefinition();
			if (left != right)
			{
				return false;
			}
			Type[] genericArguments = type_0.GetGenericArguments();
			Type[] genericArguments2 = type_1.GetGenericArguments();
			if (genericArguments.Length != genericArguments2.Length)
			{
				return false;
			}
			for (int i = 0; i < genericArguments.Length; i++)
			{
				int num;
				if (Class101.smethod_0(genericArguments[i], genericArguments2[i], out num))
				{
					int_0 += num;
				}
			}
		}
		else if (type_0 != type_1)
		{
			return false;
		}
		int_0++;
		return true;
	}
}
