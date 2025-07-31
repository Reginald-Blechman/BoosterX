using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

// Token: 0x0200020B RID: 523
internal sealed class Class245
{
	// Token: 0x17000190 RID: 400
	// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0000A861 File Offset: 0x00008A61
	// (set) Token: 0x06000E23 RID: 3619 RVA: 0x0000A869 File Offset: 0x00008A69
	[JsonProperty("TweakType")]
	internal string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0000A872 File Offset: 0x00008A72
	// (set) Token: 0x06000E25 RID: 3621 RVA: 0x0000A87A File Offset: 0x00008A7A
	[JsonProperty("Path")]
	internal string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000E26 RID: 3622 RVA: 0x0000A883 File Offset: 0x00008A83
	// (set) Token: 0x06000E27 RID: 3623 RVA: 0x0000A88B File Offset: 0x00008A8B
	[JsonProperty("Key")]
	internal string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0000A894 File Offset: 0x00008A94
	// (set) Token: 0x06000E29 RID: 3625 RVA: 0x0000A89C File Offset: 0x00008A9C
	[JsonProperty("ValueFormat")]
	internal string String_3
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0000A8A5 File Offset: 0x00008AA5
	// (set) Token: 0x06000E2B RID: 3627 RVA: 0x0000A8AD File Offset: 0x00008AAD
	[JsonProperty("Values")]
	internal List<Class275> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00003056 File Offset: 0x00001256
	[JsonIgnore]
	internal bool Boolean_0
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00050FB4 File Offset: 0x0004F1B4
	[JsonIgnore]
	internal string String_4
	{
		get
		{
			string text = this.String_0;
			if (text != null)
			{
				switch (text.Length)
				{
				case 3:
				{
					char c = text[0];
					if (c != 'B')
					{
						if (c == 'R')
						{
							if (text == "REG")
							{
								return "REG";
							}
						}
					}
					else if (text == "BAT")
					{
						return "BAT";
					}
					break;
				}
				case 4:
					if (text == "TASK")
					{
						return "TASK";
					}
					break;
				case 6:
				{
					char c = text[0];
					if (c <= 'I')
					{
						if (c != 'D')
						{
							if (c == 'I')
							{
								if (text == "IMPORT")
								{
									return "IMPORT";
								}
							}
						}
						else if (text == "DEVICE")
						{
							return "DEVICE";
						}
					}
					else if (c != 'R')
					{
						if (c == 'S')
						{
							if (text == "SCRIPT")
							{
								return "SCRIPT";
							}
						}
					}
					else if (text == "REG_SZ")
					{
						return "REG";
					}
					break;
				}
				case 7:
					if (text == "BCDEDIT")
					{
						return "BCDEDIT";
					}
					break;
				case 8:
					if (text == "WEVTUTIL")
					{
						return "WEVTUTIL";
					}
					break;
				case 10:
					if (text == "REG_BINARY")
					{
						return "REG";
					}
					break;
				case 13:
					if (text == "REG_EXPAND_SZ")
					{
						return "REG";
					}
					break;
				}
			}
			return "UNKNOWN";
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00051180 File Offset: 0x0004F380
	// (set) Token: 0x06000E2F RID: 3631 RVA: 0x0000A8B6 File Offset: 0x00008AB6
	[JsonIgnore]
	internal string String_5
	{
		get
		{
			string a = this.String_0;
			string result;
			if (!(a == "REG"))
			{
				if (!(a == "REG_SZ"))
				{
					if (!(a == "REG_BINARY"))
					{
						if (!(a == "REG_EXPAND_SZ"))
						{
							result = "HIDE";
						}
						else
						{
							result = "REG_EXPAND_SZ";
						}
					}
					else
					{
						result = "REG_BINARY";
					}
				}
				else
				{
					result = "REG_SZ";
				}
			}
			else
			{
				result = "REG_DWORD";
			}
			return result;
		}
		set
		{
			if (value == "REG_DWORD")
			{
				this.String_0 = "REG";
				return;
			}
			this.String_0 = value;
		}
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x0000A8DA File Offset: 0x00008ADA
	internal bool method_0()
	{
		return this.String_3 == "HEX";
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x0000A8ED File Offset: 0x00008AED
	internal bool method_1()
	{
		return this.List_0.Any(new Func<Class275, bool>(Class245.Class246.class246_0.method_0));
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x0000A919 File Offset: 0x00008B19
	internal bool method_2()
	{
		return this.List_0.Any(new Func<Class275, bool>(Class245.Class246.class246_0.method_1));
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x0000A945 File Offset: 0x00008B45
	internal bool method_3()
	{
		return this.List_0.Any(new Func<Class275, bool>(Class245.Class246.class246_0.method_2));
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x0000A971 File Offset: 0x00008B71
	internal bool method_4()
	{
		return this.List_0.Any(new Func<Class275, bool>(Class245.Class246.class246_0.method_3));
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x0000A99D File Offset: 0x00008B9D
	internal bool method_5()
	{
		return this.List_0.Any(new Func<Class275, bool>(Class245.Class246.class246_0.method_4));
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x0000A9C9 File Offset: 0x00008BC9
	internal bool method_6()
	{
		return this.List_0.Any(new Func<Class275, bool>(Class245.Class246.class246_0.method_5));
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x0000A9F5 File Offset: 0x00008BF5
	internal bool method_7()
	{
		return this.List_0.Any(new Func<Class275, bool>(Class245.Class246.class246_0.method_6));
	}

	// Token: 0x0400091B RID: 2331
	private string string_0;

	// Token: 0x0400091C RID: 2332
	private string string_1;

	// Token: 0x0400091D RID: 2333
	private string string_2;

	// Token: 0x0400091E RID: 2334
	private string string_3 = "Null";

	// Token: 0x0400091F RID: 2335
	private List<Class275> list_0;

	// Token: 0x0200020C RID: 524
	[Serializable]
	private sealed class Class246
	{
		// Token: 0x06000E3A RID: 3642 RVA: 0x0000AA2D File Offset: 0x00008C2D
		internal bool method_0(Class275 class275_0)
		{
			return class275_0.method_0();
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0000AA35 File Offset: 0x00008C35
		internal bool method_1(Class275 class275_0)
		{
			return class275_0.method_1();
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0000AA3D File Offset: 0x00008C3D
		internal bool method_2(Class275 class275_0)
		{
			return class275_0.Boolean_4;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0000AA45 File Offset: 0x00008C45
		internal bool method_3(Class275 class275_0)
		{
			return class275_0.method_2();
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0000AA4D File Offset: 0x00008C4D
		internal bool method_4(Class275 class275_0)
		{
			return class275_0.method_3();
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0000AA55 File Offset: 0x00008C55
		internal bool method_5(Class275 class275_0)
		{
			return class275_0.method_4();
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0000AA5D File Offset: 0x00008C5D
		internal bool method_6(Class275 class275_0)
		{
			return class275_0.method_5();
		}

		// Token: 0x04000920 RID: 2336
		public static readonly Class245.Class246 class246_0 = new Class245.Class246();

		// Token: 0x04000921 RID: 2337
		public static Func<Class275, bool> func_0;

		// Token: 0x04000922 RID: 2338
		public static Func<Class275, bool> func_1;

		// Token: 0x04000923 RID: 2339
		public static Func<Class275, bool> func_2;

		// Token: 0x04000924 RID: 2340
		public static Func<Class275, bool> func_3;

		// Token: 0x04000925 RID: 2341
		public static Func<Class275, bool> func_4;

		// Token: 0x04000926 RID: 2342
		public static Func<Class275, bool> func_5;

		// Token: 0x04000927 RID: 2343
		public static Func<Class275, bool> func_6;
	}
}
