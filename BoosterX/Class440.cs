using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Numerics;
using Microsoft.Win32;

// Token: 0x020003C9 RID: 969
internal sealed class Class440
{
	// Token: 0x06001979 RID: 6521 RVA: 0x00070280 File Offset: 0x0006E480
	public static string smethod_0(string string_0)
	{
		string result;
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + string_0 + "\\Device Parameters\\Interrupt Management\\Affinity Policy"))
			{
				if (registryKey == null)
				{
					result = "default";
				}
				else
				{
					byte[] array = registryKey.GetValue("AssignmentSetOverride") as byte[];
					if (array == null)
					{
						result = "default";
					}
					else
					{
						result = Class440.smethod_1(BitConverter.ToString(array));
					}
				}
			}
		}
		catch
		{
			result = "default";
		}
		return result;
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x00070314 File Offset: 0x0006E514
	private static string smethod_1(string string_0)
	{
		ulong num;
		if (!ulong.TryParse((string_0.Length > 2) ? string.Concat(string_0.Split(new char[]
		{
			'-'
		}).Reverse<string>()) : string_0, NumberStyles.HexNumber, null, out num))
		{
			return "ERROR";
		}
		List<string> list = new List<string>();
		uint num2 = 0U;
		while (num > 0UL)
		{
			if ((num & 1UL) == 1UL)
			{
				list.Add(num2.ToString());
			}
			num >>= 1;
			num2 += 1U;
		}
		if (list.Count <= 0)
		{
			return "ERROR";
		}
		return string.Join(", ", list);
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x000703BC File Offset: 0x0006E5BC
	public static string smethod_2(ManagementObject managementObject_0)
	{
		object obj = managementObject_0["PNPDeviceID"];
		string value = (obj != null) ? obj.ToString() : null;
		if (string.IsNullOrEmpty(value))
		{
			return string.Empty;
		}
		string result = string.Empty;
		foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity").Get())
		{
			ManagementObject managementObject = (ManagementObject)managementBaseObject;
			object[] array = new object[2];
			array[0] = new string[]
			{
				"DEVPKEY_Device_InstanceId",
				"DEVPKEY_Device_LastKnownParent"
			};
			object[] array2 = array;
			managementObject.InvokeMethod("GetDeviceProperties", array2);
			ManagementBaseObject[] array3 = array2[1] as ManagementBaseObject[];
			if (array3 != null && array3.Length >= 2)
			{
				ManagementBaseObject managementBaseObject2 = array3[0];
				string text;
				if (managementBaseObject2 == null)
				{
					text = null;
				}
				else
				{
					PropertyData propertyData = managementBaseObject2.Properties["Data"];
					if (propertyData == null)
					{
						text = null;
					}
					else
					{
						object value2 = propertyData.Value;
						text = ((value2 != null) ? value2.ToString() : null);
					}
				}
				string text2 = text;
				if (!string.IsNullOrEmpty(text2) && text2.Contains(value))
				{
					ManagementBaseObject managementBaseObject3 = array3[1];
					object obj2;
					if (managementBaseObject3 == null)
					{
						obj2 = null;
					}
					else
					{
						PropertyData propertyData2 = managementBaseObject3.Properties["Data"];
						obj2 = ((propertyData2 != null) ? propertyData2.Value : null);
					}
					object obj3 = obj2;
					if (obj3 != null)
					{
						result = obj3.ToString();
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600197C RID: 6524 RVA: 0x00070510 File Offset: 0x0006E710
	public static ManagementObject smethod_3(string string_0)
	{
		foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity").Get())
		{
			ManagementObject managementObject = (ManagementObject)managementBaseObject;
			object[] array = new object[2];
			array[0] = new string[]
			{
				"DEVPKEY_Device_InstanceId"
			};
			object[] array2 = array;
			managementObject.InvokeMethod("GetDeviceProperties", array2);
			ManagementBaseObject[] array3 = array2[1] as ManagementBaseObject[];
			if (array3 != null && array3.Length != 0)
			{
				ManagementBaseObject managementBaseObject2 = array3[0];
				string text;
				if (managementBaseObject2 == null)
				{
					text = null;
				}
				else
				{
					PropertyData propertyData = managementBaseObject2.Properties["Data"];
					if (propertyData == null)
					{
						text = null;
					}
					else
					{
						object value = propertyData.Value;
						text = ((value != null) ? value.ToString() : null);
					}
				}
				string text2 = text;
				if (!string.IsNullOrEmpty(text2) && text2.Equals(string_0.ToUpper(), StringComparison.Ordinal))
				{
					return managementObject;
				}
			}
		}
		return null;
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x000705FC File Offset: 0x0006E7FC
	public static string smethod_4(string string_0)
	{
		List<int> list = string_0.Split(new char[]
		{
			','
		}, StringSplitOptions.RemoveEmptyEntries).Select(new Func<string, string>(Class440.Class441.class441_0.method_0)).Select(new Func<string, int?>(Class440.Class441.class441_0.method_1)).Where(new Func<int?, bool>(Class440.Class441.class441_0.method_2)).Select(new Func<int?, int>(Class440.Class441.class441_0.method_3)).ToList<int>();
		if (!Class746.smethod_3<int>(list))
		{
			return string.Empty;
		}
		BigInteger left = BigInteger.Zero;
		foreach (int num in list)
		{
			int num2 = num + 1;
			int exponent = (num2 - 1) / 4;
			int value = Class440.smethod_5(num2);
			left += value * BigInteger.Pow(16, exponent);
		}
		string text = left.ToString("X");
		if (text.Length % 2 != 0)
		{
			text = "0" + text;
		}
		if (text.Length > 2)
		{
			text = Class440.smethod_6(text);
		}
		return text;
	}

	// Token: 0x0600197E RID: 6526 RVA: 0x00070768 File Offset: 0x0006E968
	private static int smethod_5(int int_0)
	{
		int result;
		switch (int_0 % 4)
		{
		case 0:
			result = 8;
			break;
		case 1:
			result = 1;
			break;
		case 2:
			result = 2;
			break;
		case 3:
			result = 4;
			break;
		default:
			result = 0;
			break;
		}
		return result;
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x000707A4 File Offset: 0x0006E9A4
	private static string smethod_6(string string_0)
	{
		int num = string_0.Length / 2;
		string[] array = new string[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = string_0.Substring(i * 2, 2);
		}
		Array.Reverse(array);
		return string.Concat(array);
	}

	// Token: 0x020003CA RID: 970
	[Serializable]
	private sealed class Class441
	{
		// Token: 0x06001982 RID: 6530 RVA: 0x0000C563 File Offset: 0x0000A763
		internal string method_0(string string_0)
		{
			return string_0.Trim();
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x000707E8 File Offset: 0x0006E9E8
		internal int? method_1(string string_0)
		{
			int value;
			if (!int.TryParse(string_0, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000114AC File Offset: 0x0000F6AC
		internal bool method_2(int? nullable_0)
		{
			return nullable_0 != null;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000114B5 File Offset: 0x0000F6B5
		internal int method_3(int? nullable_0)
		{
			return nullable_0.Value;
		}

		// Token: 0x040010CD RID: 4301
		public static readonly Class440.Class441 class441_0 = new Class440.Class441();

		// Token: 0x040010CE RID: 4302
		public static Func<string, string> func_0;

		// Token: 0x040010CF RID: 4303
		public static Func<string, int?> func_1;

		// Token: 0x040010D0 RID: 4304
		public static Func<int?, bool> func_2;

		// Token: 0x040010D1 RID: 4305
		public static Func<int?, int> func_3;
	}
}
