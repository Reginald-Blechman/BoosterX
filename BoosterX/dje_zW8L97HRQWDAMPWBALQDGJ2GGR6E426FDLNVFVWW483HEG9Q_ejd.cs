using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

// Token: 0x020008FF RID: 2303
[XmlRoot("Profile")]
[JsonObject]
[Serializable]
internal sealed class dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd
{
	// Token: 0x1700078D RID: 1933
	// (get) Token: 0x060035ED RID: 13805 RVA: 0x000217F1 File Offset: 0x0001F9F1
	// (set) Token: 0x060035EE RID: 13806 RVA: 0x000217F9 File Offset: 0x0001F9F9
	[XmlElement("ProfileName")]
	[JsonProperty("P")]
	internal string String_0
	{
		get
		{
			return this.dje_zP65C8UPX4FJ9Q33XYDXDW_ejd;
		}
		set
		{
			this.dje_zP65C8UPX4FJ9Q33XYDXDW_ejd = value;
		}
	}

	// Token: 0x1700078E RID: 1934
	// (get) Token: 0x060035EF RID: 13807 RVA: 0x00021802 File Offset: 0x0001FA02
	// (set) Token: 0x060035F0 RID: 13808 RVA: 0x0002180A File Offset: 0x0001FA0A
	[XmlArray("Executeables")]
	[XmlArrayItem("string")]
	[JsonProperty("EX")]
	internal List<string> List_0
	{
		get
		{
			return this.dje_zXLJWDLL7DAJ4JHMYHDGMUXKDVB272NU7J9TJXWVH_ejd;
		}
		set
		{
			this.dje_zXLJWDLL7DAJ4JHMYHDGMUXKDVB272NU7J9TJXWVH_ejd = value;
		}
	}

	// Token: 0x1700078F RID: 1935
	// (get) Token: 0x060035F1 RID: 13809 RVA: 0x00021813 File Offset: 0x0001FA13
	// (set) Token: 0x060035F2 RID: 13810 RVA: 0x0002181B File Offset: 0x0001FA1B
	[XmlArray("Settings")]
	[XmlArrayItem("ProfileSetting")]
	[JsonProperty("S")]
	internal List<dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd> List_1
	{
		get
		{
			return this.dje_zFGHWJCRR28PPUB6L9SNNA_ejd;
		}
		set
		{
			this.dje_zFGHWJCRR28PPUB6L9SNNA_ejd = value;
		}
	}

	// Token: 0x04002761 RID: 10081
	private string dje_zP65C8UPX4FJ9Q33XYDXDW_ejd = string.Empty;

	// Token: 0x04002762 RID: 10082
	private List<string> dje_zXLJWDLL7DAJ4JHMYHDGMUXKDVB272NU7J9TJXWVH_ejd = new List<string>();

	// Token: 0x04002763 RID: 10083
	private List<dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd> dje_zFGHWJCRR28PPUB6L9SNNA_ejd = new List<dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd>();
}
