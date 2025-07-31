using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x020005E5 RID: 1509
public sealed class GClass258
{
	// Token: 0x0600269F RID: 9887 RVA: 0x00019B19 File Offset: 0x00017D19
	public GClass258()
	{
		this.GClass54_0 = GClass54.smethod_2();
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x00019B37 File Offset: 0x00017D37
	public GClass258(GClass54 gclass54_0, string string_3)
	{
		this.GClass54_0 = gclass54_0;
		this.String_1 = string_3;
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x00019B58 File Offset: 0x00017D58
	public GClass258(GClass54 gclass54_0, string string_3, params GClass258.GClass259[] gclass259_0)
	{
		this.GClass54_0 = gclass54_0;
		this.String_1 = string_3;
		this.List_0.AddRange(gclass259_0);
	}

	// Token: 0x1700067E RID: 1662
	// (get) Token: 0x060026A2 RID: 9890 RVA: 0x00019B85 File Offset: 0x00017D85
	// (set) Token: 0x060026A3 RID: 9891 RVA: 0x00019B8D File Offset: 0x00017D8D
	[JsonProperty("role")]
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

	// Token: 0x1700067F RID: 1663
	// (get) Token: 0x060026A4 RID: 9892 RVA: 0x00019B96 File Offset: 0x00017D96
	// (set) Token: 0x060026A5 RID: 9893 RVA: 0x00019BA3 File Offset: 0x00017DA3
	[JsonIgnore]
	public GClass54 GClass54_0
	{
		get
		{
			return GClass54.smethod_0(this.String_0);
		}
		set
		{
			this.String_0 = value.ToString();
		}
	}

	// Token: 0x17000680 RID: 1664
	// (get) Token: 0x060026A6 RID: 9894 RVA: 0x00019BB1 File Offset: 0x00017DB1
	// (set) Token: 0x060026A7 RID: 9895 RVA: 0x00019BB9 File Offset: 0x00017DB9
	[JsonIgnore]
	public string String_1
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

	// Token: 0x17000681 RID: 1665
	// (get) Token: 0x060026A8 RID: 9896 RVA: 0x00019BC2 File Offset: 0x00017DC2
	// (set) Token: 0x060026A9 RID: 9897 RVA: 0x00019BCA File Offset: 0x00017DCA
	[Obsolete("This property has been renamed to TextContent.")]
	[JsonIgnore]
	public string Content
	{
		get
		{
			return this.String_1;
		}
		set
		{
			this.String_1 = value;
		}
	}

	// Token: 0x17000682 RID: 1666
	// (get) Token: 0x060026AA RID: 9898 RVA: 0x00097358 File Offset: 0x00095558
	// (set) Token: 0x060026AB RID: 9899 RVA: 0x000973EC File Offset: 0x000955EC
	[JsonProperty("content")]
	[JsonConverter(typeof(GClass258.Class726))]
	internal IList<GClass258.Class727> IList_0
	{
		get
		{
			List<GClass258.Class727> list = new List<GClass258.Class727>();
			if (!string.IsNullOrEmpty(this.String_1))
			{
				list.Add(new GClass258.Class727(this.String_1));
			}
			if (this.List_0 != null && this.List_0.Count > 0)
			{
				foreach (GClass258.GClass259 gclass259_ in this.List_0)
				{
					list.Add(new GClass258.Class727(gclass259_));
				}
			}
			return list;
		}
		set
		{
			foreach (GClass258.Class727 @class in value)
			{
				if (@class.Type == "text")
				{
					this.String_1 = @class.Text;
				}
				else if (@class.Type == "image_url")
				{
					this.List_0.Add(@class.GClass259_0);
				}
			}
		}
	}

	// Token: 0x17000683 RID: 1667
	// (get) Token: 0x060026AC RID: 9900 RVA: 0x00019BD3 File Offset: 0x00017DD3
	// (set) Token: 0x060026AD RID: 9901 RVA: 0x00019BDB File Offset: 0x00017DDB
	[JsonProperty("name")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000684 RID: 1668
	// (get) Token: 0x060026AE RID: 9902 RVA: 0x00019BE4 File Offset: 0x00017DE4
	// (set) Token: 0x060026AF RID: 9903 RVA: 0x00019BEC File Offset: 0x00017DEC
	[JsonIgnore]
	public List<GClass258.GClass259> List_0
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

	// Token: 0x04001961 RID: 6497
	private string string_0;

	// Token: 0x04001962 RID: 6498
	private string string_1;

	// Token: 0x04001963 RID: 6499
	private string string_2;

	// Token: 0x04001964 RID: 6500
	private List<GClass258.GClass259> list_0 = new List<GClass258.GClass259>();

	// Token: 0x020005E6 RID: 1510
	internal sealed class Class726 : JsonConverter
	{
		// Token: 0x060026B1 RID: 9905 RVA: 0x00003982 File Offset: 0x00001B82
		public override bool CanConvert(Type type_0)
		{
			return true;
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x00097474 File Offset: 0x00095674
		public override object ReadJson(JsonReader jsonReader_0, Type type_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			JToken jtoken = JToken.Load(jsonReader_0);
			if (jtoken.Type == 1)
			{
				return jtoken.ToObject<IList<GClass258.Class727>>();
			}
			if (jtoken.Type == 8)
			{
				return new List<GClass258.Class727>
				{
					new GClass258.Class727(jtoken.ToObject<string>())
				};
			}
			return null;
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00019BFD File Offset: 0x00017DFD
		public override void WriteJson(JsonWriter jsonWriter_0, object object_0, JsonSerializer jsonSerializer_0)
		{
			jsonSerializer_0.Serialize(jsonWriter_0, object_0);
		}
	}

	// Token: 0x020005E7 RID: 1511
	public sealed class GClass259
	{
		// Token: 0x060026B4 RID: 9908 RVA: 0x00019C07 File Offset: 0x00017E07
		public GClass259(string string_2, string string_3 = "auto")
		{
			this.String_0 = string_2;
			this.String_1 = string_3;
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00019C29 File Offset: 0x00017E29
		public GClass259(byte[] byte_0, string string_2 = "auto")
		{
			this.String_0 = "data:image/jpeg;base64," + Convert.ToBase64String(byte_0);
			this.String_1 = string_2;
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00019C5B File Offset: 0x00017E5B
		public GClass259()
		{
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x00019C6F File Offset: 0x00017E6F
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x00019C77 File Offset: 0x00017E77
		[JsonProperty("url")]
		public string String_0
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

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x00019C80 File Offset: 0x00017E80
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x00019C88 File Offset: 0x00017E88
		[JsonProperty("detail")]
		public string String_1
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

		// Token: 0x060026BB RID: 9915 RVA: 0x00019C91 File Offset: 0x00017E91
		public static GClass258.GClass259 smethod_0(string string_2, string string_3)
		{
			return new GClass258.GClass259(File.ReadAllBytes(string_2), string_3);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00019C9F File Offset: 0x00017E9F
		public static GClass258.GClass259 smethod_1(byte[] byte_0, string string_2)
		{
			return new GClass258.GClass259(byte_0, string_2);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00019CA8 File Offset: 0x00017EA8
		public static GClass258.GClass259 smethod_2(string string_2, string string_3)
		{
			return new GClass258.GClass259(string_2, string_3);
		}

		// Token: 0x04001965 RID: 6501
		private string string_0;

		// Token: 0x04001966 RID: 6502
		private string string_1 = "auto";
	}

	// Token: 0x020005E8 RID: 1512
	internal sealed class Class727
	{
		// Token: 0x060026BE RID: 9918 RVA: 0x00019CB1 File Offset: 0x00017EB1
		public Class727()
		{
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00019CC5 File Offset: 0x00017EC5
		public Class727(string string_2)
		{
			this.Text = string_2;
			this.Type = "text";
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00019CEC File Offset: 0x00017EEC
		public Class727(GClass258.GClass259 gclass259_1)
		{
			this.GClass259_0 = gclass259_1;
			this.Type = "image_url";
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x00019D13 File Offset: 0x00017F13
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x00019D1B File Offset: 0x00017F1B
		[JsonProperty("type")]
		public string Type
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x00019D24 File Offset: 0x00017F24
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x00019D41 File Offset: 0x00017F41
		[JsonProperty("text")]
		public string Text
		{
			get
			{
				if (this.Type == "text")
				{
					return this.string_0;
				}
				return null;
			}
			set
			{
				this.string_0 = value;
				this.gclass259_0 = null;
				this.Type = "text";
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x00019D5D File Offset: 0x00017F5D
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x00019D7A File Offset: 0x00017F7A
		[JsonProperty("image_url")]
		public GClass258.GClass259 GClass259_0
		{
			get
			{
				if (this.Type == "image_url")
				{
					return this.gclass259_0;
				}
				return null;
			}
			set
			{
				this.gclass259_0 = value;
				this.string_0 = null;
				this.Type = "image_url";
			}
		}

		// Token: 0x04001967 RID: 6503
		private string string_0;

		// Token: 0x04001968 RID: 6504
		private GClass258.GClass259 gclass259_0;

		// Token: 0x04001969 RID: 6505
		private string string_1 = "text";
	}
}
