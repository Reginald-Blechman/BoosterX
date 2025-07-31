using System;
using System.Collections.Generic;
using ns0;

// Token: 0x020002B7 RID: 695
public sealed class GClass90 : GInterface8
{
	// Token: 0x0600128B RID: 4747 RVA: 0x0000D3F0 File Offset: 0x0000B5F0
	public GClass90(List<string> list_1)
	{
		this.list_0 = list_1;
		this.method_3();
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x0000D410 File Offset: 0x0000B610
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x0000D418 File Offset: 0x0000B618
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x0000D421 File Offset: 0x0000B621
	public void imethod_3()
	{
		if (this.list_0.Count != 0)
		{
			this.list_0.ForEach(new Action<string>(this.method_6));
		}
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x0000D447 File Offset: 0x0000B647
	public void method_2()
	{
		dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_5.Clear();
		this.method_1(string.Empty);
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x0005C4EC File Offset: 0x0005A6EC
	public bool imethod_0<T>() where T : GInterface16, new()
	{
		Struct403 @struct;
		return this.dictionary_0.TryGetValue(typeof(T), out @struct) && @struct.string_0 != null && this.method_0().Contains(@struct.string_0);
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x0005C530 File Offset: 0x0005A730
	public bool imethod_1<T>() where T : GInterface16, new()
	{
		Struct403 @struct;
		return this.dictionary_0.TryGetValue(typeof(T), out @struct) && @struct.string_1 != null && this.method_0().Contains(@struct.string_1);
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x0005C574 File Offset: 0x0005A774
	public bool imethod_2<T>(string string_1) where T : GInterface16, new()
	{
		GClass90.Class327<T> @class = new GClass90.Class327<T>();
		@class.string_0 = string_1;
		@class.gclass90_0 = this;
		Struct403 @struct;
		return this.dictionary_0.TryGetValue(typeof(T), out @struct) && new List<Struct388>(@struct.struct388_0).Exists(new Predicate<Struct388>(@class.method_0));
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x0005C5CC File Offset: 0x0005A7CC
	private void method_3()
	{
		this.dictionary_0 = new Dictionary<Type, Struct403>();
		this.method_5<GClass287>(new Struct388[]
		{
			new Struct388
			{
				string_0 = GClass287.string_1,
				string_1 = GClass287.string_1
			},
			new Struct388
			{
				string_0 = GClass287.string_2,
				string_1 = GClass287.string_2
			}
		});
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x0005C640 File Offset: 0x0005A840
	private void method_4<T>(string string_1, string string_2) where T : GInterface16, new()
	{
		this.dictionary_0.Add(typeof(T), new Struct403
		{
			string_0 = string_1,
			string_1 = string_2
		});
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x0005C67C File Offset: 0x0005A87C
	private void method_5<T>(Struct388[] struct388_0) where T : GInterface16, new()
	{
		this.dictionary_0.Add(typeof(T), new Struct403
		{
			struct388_0 = struct388_0
		});
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x0000BB8D File Offset: 0x00009D8D
	public T imethod_4<T>() where T : class, GInterface16, new()
	{
		return Activator.CreateInstance<T>();
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x0000D45E File Offset: 0x0000B65E
	private void method_6(string string_1)
	{
		this.method_1(this.method_0() + string_1);
	}

	// Token: 0x04000B9E RID: 2974
	private readonly List<string> list_0;

	// Token: 0x04000B9F RID: 2975
	private string string_0 = string.Empty;

	// Token: 0x04000BA0 RID: 2976
	private Dictionary<Type, Struct403> dictionary_0;

	// Token: 0x020002B8 RID: 696
	private sealed class Class327<T> where T : GInterface16, new()
	{
		// Token: 0x06001299 RID: 4761 RVA: 0x0000D472 File Offset: 0x0000B672
		internal bool method_0(Struct388 struct388_0)
		{
			return (struct388_0.string_1 == null || struct388_0.string_1 == this.string_0) && this.gclass90_0.method_0().Contains(struct388_0.string_0);
		}

		// Token: 0x04000BA1 RID: 2977
		public string string_0;

		// Token: 0x04000BA2 RID: 2978
		public GClass90 gclass90_0;
	}
}
