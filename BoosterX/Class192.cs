using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using Microsoft.CSharp.RuntimeBinder;

// Token: 0x02000169 RID: 361
internal sealed class Class192
{
	// Token: 0x06000A22 RID: 2594 RVA: 0x000081EB File Offset: 0x000063EB
	public Class192(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x000081FA File Offset: 0x000063FA
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x000467B0 File Offset: 0x000449B0
	public Class192 method_1()
	{
		VdfSerializerSettings vdfSerializerSettings = new VdfSerializerSettings
		{
			UsesEscapeSequences = true,
			UsesConditionals = true,
			MaximumTokenSize = 8192
		};
		string text = File.ReadAllText(this.string_0);
		this.vproperty_0 = VdfConvert.Deserialize(text, vdfSerializerSettings);
		return this;
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x000467F8 File Offset: 0x000449F8
	public VToken method_2(List<string> list_0)
	{
		VToken vtoken = null;
		if (list_0.Count < 1)
		{
			return this.vproperty_0;
		}
		if (list_0 == null)
		{
			throw new ArgumentException("argument count must be more than 0");
		}
		foreach (string text in list_0)
		{
			if (vtoken == null)
			{
				vtoken = this.vproperty_0.Value[text];
			}
			else
			{
				vtoken = vtoken[text];
			}
			if (vtoken == null)
			{
				return null;
			}
		}
		return vtoken;
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00008202 File Offset: 0x00006402
	public string method_3(List<string> list_0, string string_1)
	{
		if (list_0.Count < 1)
		{
			VToken vtoken = this.method_2(new List<string>
			{
				string_1
			});
			if (vtoken == null)
			{
				return null;
			}
			return vtoken.ToString();
		}
		else
		{
			VToken vtoken2 = this.method_2(list_0);
			if (vtoken2 == null)
			{
				return null;
			}
			return vtoken2.Value<string>(string_1);
		}
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x0004688C File Offset: 0x00044A8C
	public Class192 method_4(List<string> list_0, string string_1, string string_2)
	{
		if (list_0.Count < 1)
		{
			object arg = this.method_2(list_0);
			if (Class192.Class193.callSite_1 == null)
			{
				Class192.Class193.callSite_1 = CallSite<Func<CallSite, object, string, VValue, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(Class192), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Func<CallSite, object, string, VValue, object> target = Class192.Class193.callSite_1.Target;
			CallSite callSite_ = Class192.Class193.callSite_1;
			if (Class192.Class193.callSite_0 == null)
			{
				Class192.Class193.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "Value", typeof(Class192), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target(callSite_, Class192.Class193.callSite_0.Target(Class192.Class193.callSite_0, arg), string_1, new VValue(string_2));
		}
		else
		{
			object arg = this.method_2(list_0);
			if (Class192.Class193.callSite_2 == null)
			{
				Class192.Class193.callSite_2 = CallSite<Func<CallSite, object, string, VValue, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(Class192), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Class192.Class193.callSite_2.Target(Class192.Class193.callSite_2, arg, string_1, new VValue(string_2));
		}
		return this;
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x0000823E File Offset: 0x0000643E
	public void method_5()
	{
		File.WriteAllText(this.string_0, VdfConvert.Serialize(this.vproperty_0));
	}

	// Token: 0x040006C2 RID: 1730
	private readonly string string_0;

	// Token: 0x040006C3 RID: 1731
	private VProperty vproperty_0;

	// Token: 0x0200016A RID: 362
	private static class Class193
	{
		// Token: 0x040006C4 RID: 1732
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		// Token: 0x040006C5 RID: 1733
		public static CallSite<Func<CallSite, object, string, VValue, object>> callSite_1;

		// Token: 0x040006C6 RID: 1734
		public static CallSite<Func<CallSite, object, string, VValue, object>> callSite_2;
	}
}
