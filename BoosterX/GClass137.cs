using System;
using System.Runtime.CompilerServices;

// Token: 0x02000400 RID: 1024
public sealed class GClass137
{
	// Token: 0x06001A61 RID: 6753 RVA: 0x00011C04 File Offset: 0x0000FE04
	public GClass137(string string_2, object object_0)
	{
		this.Name = string_2;
		this.method_1((object_0 != null) ? object_0.ToString() : null);
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x00073D6C File Offset: 0x00071F6C
	public GClass137(string string_2)
	{
		bool flag = string_2[0] == '/' && string_2[1] == '/';
		string[] array = string_2.Split(new string[]
		{
			" "
		}, flag ? 1 : 3, StringSplitOptions.RemoveEmptyEntries);
		int num = array.Length - 1;
		this.Name = ((array.Length == 3) ? (array[0] + " " + array[1]) : array[0]);
		this.method_1((array.Length > 1) ? array[num].Replace("\"", null) : null);
	}

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x06001A63 RID: 6755 RVA: 0x00011C25 File Offset: 0x0000FE25
	// (set) Token: 0x06001A64 RID: 6756 RVA: 0x00011C2D File Offset: 0x0000FE2D
	public string Name
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

	// Token: 0x06001A65 RID: 6757 RVA: 0x00011C36 File Offset: 0x0000FE36
	public string method_0()
	{
		return this.string_1;
	}

	// Token: 0x06001A66 RID: 6758 RVA: 0x00011C3E File Offset: 0x0000FE3E
	public void method_1(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x06001A67 RID: 6759 RVA: 0x00011C47 File Offset: 0x0000FE47
	public static bool operator ==(GClass137 gclass137_0, GClass137 gclass137_1)
	{
		return gclass137_0.Name == gclass137_1.Name && gclass137_0.method_0() == gclass137_1.method_0();
	}

	// Token: 0x06001A68 RID: 6760 RVA: 0x00011C6F File Offset: 0x0000FE6F
	public static bool operator !=(GClass137 gclass137_0, GClass137 gclass137_1)
	{
		return gclass137_0 != gclass137_1;
	}

	// Token: 0x06001A69 RID: 6761 RVA: 0x00011C78 File Offset: 0x0000FE78
	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x00011C81 File Offset: 0x0000FE81
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x00011C89 File Offset: 0x0000FE89
	public override string ToString()
	{
		return this.Name + " " + ((!string.IsNullOrEmpty(this.method_0())) ? ("\"" + this.method_0() + "\"") : null);
	}

	// Token: 0x0400119D RID: 4509
	private string string_0;

	// Token: 0x0400119E RID: 4510
	private string string_1;
}
