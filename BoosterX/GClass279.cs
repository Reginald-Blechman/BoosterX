using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ns0;

// Token: 0x02000678 RID: 1656
public sealed class GClass279 : GInterface8
{
	// Token: 0x060029E2 RID: 10722 RVA: 0x0001B648 File Offset: 0x00019848
	private GClass279()
	{
	}

	// Token: 0x060029E4 RID: 10724 RVA: 0x000A2B7C File Offset: 0x000A0D7C
	public static GClass279 smethod_0()
	{
		object obj = GClass279.object_0;
		GClass279 result;
		lock (obj)
		{
			GClass279 gclass;
			if ((gclass = GClass279.gclass279_0) == null)
			{
				gclass = (GClass279.gclass279_0 = new GClass279());
			}
			result = gclass;
		}
		return result;
	}

	// Token: 0x060029E5 RID: 10725 RVA: 0x000A2BCC File Offset: 0x000A0DCC
	public void method_0(GClass279.GDelegate1 gdelegate1_1)
	{
		GClass279.GDelegate1 gdelegate = this.gdelegate1_0;
		GClass279.GDelegate1 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass279.GDelegate1 value = (GClass279.GDelegate1)Delegate.Combine(gdelegate2, gdelegate1_1);
			gdelegate = Interlocked.CompareExchange<GClass279.GDelegate1>(ref this.gdelegate1_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060029E6 RID: 10726 RVA: 0x000A2C04 File Offset: 0x000A0E04
	public void method_1(GClass279.GDelegate1 gdelegate1_1)
	{
		GClass279.GDelegate1 gdelegate = this.gdelegate1_0;
		GClass279.GDelegate1 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass279.GDelegate1 value = (GClass279.GDelegate1)Delegate.Remove(gdelegate2, gdelegate1_1);
			gdelegate = Interlocked.CompareExchange<GClass279.GDelegate1>(ref this.gdelegate1_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060029E7 RID: 10727 RVA: 0x000A2C3C File Offset: 0x000A0E3C
	public void method_2(GClass279.GDelegate3 gdelegate3_1)
	{
		GClass279.GDelegate3 gdelegate = this.gdelegate3_0;
		GClass279.GDelegate3 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass279.GDelegate3 value = (GClass279.GDelegate3)Delegate.Combine(gdelegate2, gdelegate3_1);
			gdelegate = Interlocked.CompareExchange<GClass279.GDelegate3>(ref this.gdelegate3_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060029E8 RID: 10728 RVA: 0x000A2C74 File Offset: 0x000A0E74
	public void method_3(GClass279.GDelegate3 gdelegate3_1)
	{
		GClass279.GDelegate3 gdelegate = this.gdelegate3_0;
		GClass279.GDelegate3 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass279.GDelegate3 value = (GClass279.GDelegate3)Delegate.Remove(gdelegate2, gdelegate3_1);
			gdelegate = Interlocked.CompareExchange<GClass279.GDelegate3>(ref this.gdelegate3_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060029E9 RID: 10729 RVA: 0x000A2CAC File Offset: 0x000A0EAC
	public void method_4(GClass279.GDelegate2 gdelegate2_1)
	{
		GClass279.GDelegate2 gdelegate = this.gdelegate2_0;
		GClass279.GDelegate2 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass279.GDelegate2 value = (GClass279.GDelegate2)Delegate.Combine(gdelegate2, gdelegate2_1);
			gdelegate = Interlocked.CompareExchange<GClass279.GDelegate2>(ref this.gdelegate2_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060029EA RID: 10730 RVA: 0x000A2CE4 File Offset: 0x000A0EE4
	public void method_5(GClass279.GDelegate2 gdelegate2_1)
	{
		GClass279.GDelegate2 gdelegate = this.gdelegate2_0;
		GClass279.GDelegate2 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass279.GDelegate2 value = (GClass279.GDelegate2)Delegate.Remove(gdelegate2, gdelegate2_1);
			gdelegate = Interlocked.CompareExchange<GClass279.GDelegate2>(ref this.gdelegate2_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x060029EB RID: 10731 RVA: 0x00003C75 File Offset: 0x00001E75
	public bool imethod_0<T>() where T : GInterface16, new()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060029EC RID: 10732 RVA: 0x00003C75 File Offset: 0x00001E75
	public bool imethod_1<T>() where T : GInterface16, new()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060029ED RID: 10733 RVA: 0x00003C75 File Offset: 0x00001E75
	public bool imethod_2<T>(string string_1) where T : GInterface16, new()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060029EE RID: 10734 RVA: 0x00003C75 File Offset: 0x00001E75
	public void imethod_3()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060029EF RID: 10735 RVA: 0x0001B688 File Offset: 0x00019888
	public T imethod_4<T>() where T : class, GInterface16, new()
	{
		return this.method_6<T>();
	}

	// Token: 0x060029F0 RID: 10736 RVA: 0x0001B690 File Offset: 0x00019890
	public T method_6<T>() where T : class, GInterface16, new()
	{
		return this.method_12<T>(GClass279.string_0);
	}

	// Token: 0x060029F1 RID: 10737 RVA: 0x0001B69D File Offset: 0x0001989D
	public T method_7<T>(Func<T> func_0, string string_1) where T : class, GInterface16
	{
		return this.method_9<T>(GClass279.string_0, func_0, string_1);
	}

	// Token: 0x060029F2 RID: 10738 RVA: 0x0001B6AC File Offset: 0x000198AC
	public bool method_8<T>() where T : class, GInterface16
	{
		return this.method_14<T>(GClass279.string_0);
	}

	// Token: 0x060029F3 RID: 10739 RVA: 0x000A2D1C File Offset: 0x000A0F1C
	public T method_9<T>(string string_1, Func<T> func_0, object object_3) where T : class, GInterface16
	{
		Type typeFromHandle = typeof(T);
		object obj = this.object_1;
		T result;
		lock (obj)
		{
			if (!this.dictionary_0.ContainsKey(typeFromHandle))
			{
				this.dictionary_0.Add(typeFromHandle, new Dictionary<string, GClass279.GStruct2>());
			}
			Dictionary<string, GClass279.GStruct2> dictionary = this.dictionary_0[typeFromHandle];
			GClass279.GStruct2 value = default(GClass279.GStruct2);
			value.method_1(func_0());
			value.method_3(object_3);
			dictionary[string_1] = value;
			result = (this.dictionary_0[typeFromHandle][string_1].method_0() as T);
		}
		this.method_10();
		this.method_18(typeFromHandle, string_1, true);
		return result;
	}

	// Token: 0x060029F4 RID: 10740 RVA: 0x000A2DEC File Offset: 0x000A0FEC
	public void method_10()
	{
		object obj = this.object_2;
		lock (obj)
		{
			GClass279.GDelegate3 gdelegate = this.gdelegate3_0;
			if (gdelegate != null)
			{
				gdelegate();
			}
		}
	}

	// Token: 0x060029F5 RID: 10741 RVA: 0x000A2E38 File Offset: 0x000A1038
	public GClass279.GStruct2? method_11<T>(string string_1) where T : class, GInterface16
	{
		object obj = this.object_1;
		GClass279.GStruct2 value;
		lock (obj)
		{
			Type typeFromHandle = typeof(T);
			if (!this.dictionary_0.ContainsKey(typeFromHandle))
			{
				return null;
			}
			if (!this.dictionary_0[typeFromHandle].ContainsKey(string_1))
			{
				return null;
			}
			value = this.dictionary_0[typeFromHandle][string_1];
		}
		return new GClass279.GStruct2?(value);
	}

	// Token: 0x060029F6 RID: 10742 RVA: 0x000A2ED8 File Offset: 0x000A10D8
	public T method_12<T>(string string_1) where T : class, GInterface16
	{
		object obj = this.object_1;
		T result;
		lock (obj)
		{
			GClass279.GStruct2? gstruct = this.method_11<T>(string_1);
			result = (((gstruct != null) ? gstruct.GetValueOrDefault().method_0() : null) as T);
		}
		return result;
	}

	// Token: 0x060029F7 RID: 10743 RVA: 0x000A2F44 File Offset: 0x000A1144
	public object method_13<T>(string string_1) where T : class, GInterface16
	{
		object obj = this.object_1;
		object result;
		lock (obj)
		{
			GClass279.GStruct2? gstruct = this.method_11<T>(string_1);
			result = ((gstruct != null) ? gstruct.GetValueOrDefault().method_2() : null);
		}
		return result;
	}

	// Token: 0x060029F8 RID: 10744 RVA: 0x0001B6B9 File Offset: 0x000198B9
	public bool method_14<T>(string string_1) where T : class, GInterface16
	{
		return this.method_15(typeof(T), string_1);
	}

	// Token: 0x060029F9 RID: 10745 RVA: 0x000A2FA4 File Offset: 0x000A11A4
	public bool method_15(Type type_0, string string_1)
	{
		object obj = this.object_1;
		bool result;
		lock (obj)
		{
			if (!this.dictionary_0.ContainsKey(type_0))
			{
				return false;
			}
			Dictionary<string, GClass279.GStruct2> dictionary = this.dictionary_0[type_0];
			if (!dictionary.ContainsKey(string_1))
			{
				return false;
			}
			result = dictionary.Remove(string_1);
			if (dictionary.Count == 0)
			{
				this.dictionary_0.Remove(type_0);
			}
		}
		this.method_10();
		this.method_18(type_0, string_1, true);
		return result;
	}

	// Token: 0x060029FA RID: 10746 RVA: 0x000A303C File Offset: 0x000A123C
	public void method_16(List<string> list_0)
	{
		if (list_0 != null && list_0.Count<string>() == 0)
		{
			return;
		}
		Type typeFromHandle = typeof(Class803);
		foreach (string text in list_0)
		{
			object obj = this.object_1;
			lock (obj)
			{
				if (!this.dictionary_0.ContainsKey(typeFromHandle))
				{
					continue;
				}
				Dictionary<string, GClass279.GStruct2> dictionary = this.dictionary_0[typeFromHandle];
				if (!dictionary.ContainsKey(text))
				{
					continue;
				}
				dictionary.Remove(text);
				if (dictionary.Count == 0)
				{
					this.dictionary_0.Remove(typeFromHandle);
				}
			}
			this.method_18(typeFromHandle, text, true);
		}
		this.method_10();
	}

	// Token: 0x060029FB RID: 10747 RVA: 0x000A311C File Offset: 0x000A131C
	public void method_17<T>()
	{
		Type typeFromHandle = typeof(T);
		object obj = this.object_1;
		lock (obj)
		{
			this.dictionary_0.Remove(typeFromHandle);
		}
		this.method_10();
	}

	// Token: 0x060029FC RID: 10748 RVA: 0x0001B6CC File Offset: 0x000198CC
	private void method_18(Type type_0, string string_1, bool bool_0)
	{
		GClass279.GDelegate1 gdelegate = this.gdelegate1_0;
		if (gdelegate == null)
		{
			return;
		}
		gdelegate(type_0, string_1, bool_0);
	}

	// Token: 0x060029FD RID: 10749 RVA: 0x000A3174 File Offset: 0x000A1374
	public Dictionary<Type, Dictionary<string, GClass279.GStruct2>> method_19()
	{
		object obj = this.object_1;
		Dictionary<Type, Dictionary<string, GClass279.GStruct2>> result;
		lock (obj)
		{
			result = new Dictionary<Type, Dictionary<string, GClass279.GStruct2>>(this.dictionary_0);
		}
		return result;
	}

	// Token: 0x060029FE RID: 10750 RVA: 0x000A31BC File Offset: 0x000A13BC
	public void method_20()
	{
		dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_5.Clear();
		dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_2.Clear();
		dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.string_1 = string.Empty;
		object obj = this.object_1;
		lock (obj)
		{
			this.dictionary_0.Clear();
		}
		GClass279.GDelegate2 gdelegate = this.gdelegate2_0;
		if (gdelegate != null)
		{
			gdelegate();
		}
		this.method_10();
	}

	// Token: 0x060029FF RID: 10751 RVA: 0x000A3238 File Offset: 0x000A1438
	public bool method_21()
	{
		object obj = this.object_1;
		bool result;
		lock (obj)
		{
			result = (this.dictionary_0.Count > 0);
		}
		return result;
	}

	// Token: 0x04001B80 RID: 7040
	private static readonly object object_0 = new object();

	// Token: 0x04001B81 RID: 7041
	private static GClass279 gclass279_0;

	// Token: 0x04001B82 RID: 7042
	private readonly Dictionary<Type, Dictionary<string, GClass279.GStruct2>> dictionary_0 = new Dictionary<Type, Dictionary<string, GClass279.GStruct2>>();

	// Token: 0x04001B83 RID: 7043
	public readonly object object_1 = new object();

	// Token: 0x04001B84 RID: 7044
	private static readonly string string_0 = "default";

	// Token: 0x04001B85 RID: 7045
	private GClass279.GDelegate1 gdelegate1_0;

	// Token: 0x04001B86 RID: 7046
	private GClass279.GDelegate3 gdelegate3_0;

	// Token: 0x04001B87 RID: 7047
	private GClass279.GDelegate2 gdelegate2_0;

	// Token: 0x04001B88 RID: 7048
	private object object_2 = new object();

	// Token: 0x02000679 RID: 1657
	public struct GStruct2
	{
		// Token: 0x06002A00 RID: 10752 RVA: 0x0001B6E1 File Offset: 0x000198E1
		public readonly GInterface16 method_0()
		{
			return this.ginterface16_0;
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x0001B6E9 File Offset: 0x000198E9
		public void method_1(GInterface16 ginterface16_1)
		{
			this.ginterface16_0 = ginterface16_1;
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x0001B6F2 File Offset: 0x000198F2
		public readonly object method_2()
		{
			return this.object_0;
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x0001B6FA File Offset: 0x000198FA
		public void method_3(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x04001B89 RID: 7049
		private GInterface16 ginterface16_0;

		// Token: 0x04001B8A RID: 7050
		private object object_0;
	}

	// Token: 0x0200067A RID: 1658
	// (Invoke) Token: 0x06002A05 RID: 10757
	public delegate void GDelegate1(Type type_0, string string_0, bool bool_0);

	// Token: 0x0200067B RID: 1659
	// (Invoke) Token: 0x06002A09 RID: 10761
	public delegate void GDelegate2();

	// Token: 0x0200067C RID: 1660
	// (Invoke) Token: 0x06002A0D RID: 10765
	public delegate void GDelegate3();
}
