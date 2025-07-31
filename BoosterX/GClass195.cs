using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Gameloop.Vdf;
using Gameloop.Vdf.Linq;

// Token: 0x020006D7 RID: 1751
public sealed class GClass195 : GClass162
{
	// Token: 0x06002BFB RID: 11259 RVA: 0x000A8524 File Offset: 0x000A6724
	public GClass195(string string_1)
	{
		if (!File.Exists(string_1))
		{
			if (!Directory.Exists(Path.GetDirectoryName(string_1)))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(string_1));
			}
			File.Create(string_1).FlushAsync();
		}
		this.FilePath = string_1;
		this.method_8(string_1);
	}

	// Token: 0x17000739 RID: 1849
	// (get) Token: 0x06002BFC RID: 11260 RVA: 0x0001C4DC File Offset: 0x0001A6DC
	// (set) Token: 0x06002BFD RID: 11261 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
	public string FilePath
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		private set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700073A RID: 1850
	// (get) Token: 0x06002BFE RID: 11262 RVA: 0x0001C4ED File Offset: 0x0001A6ED
	// (set) Token: 0x06002BFF RID: 11263 RVA: 0x0001C4F5 File Offset: 0x0001A6F5
	public Encoding Encoding
	{
		[CompilerGenerated]
		get
		{
			return this.encoding_0;
		}
		[CompilerGenerated]
		set
		{
			this.encoding_0 = value;
		}
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x0001C4FE File Offset: 0x0001A6FE
	public void method_2()
	{
		this.list_0.Clear();
		this.method_7();
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x000A8588 File Offset: 0x000A6788
	public void method_3(GClass137 gclass137_0)
	{
		GClass195.Class854 @class = new GClass195.Class854();
		@class.gclass137_0 = gclass137_0;
		if (this.list_0 != null && this.list_0.Any(new Func<GClass137, bool>(@class.method_0)))
		{
			this.list_0.Find(new Predicate<GClass137>(@class.method_1)).method_1(@class.gclass137_0.method_0());
		}
		this.list_0.Add(@class.gclass137_0);
		this.method_9();
	}

	// Token: 0x06002C02 RID: 11266 RVA: 0x000A8604 File Offset: 0x000A6804
	public void method_4(GClass137 gclass137_0)
	{
		GClass195.Class853 @class = new GClass195.Class853();
		@class.gclass137_0 = gclass137_0;
		if (this.list_0 == null || this.list_0.Count == 0)
		{
			return;
		}
		if (this.list_0.Any(new Func<GClass137, bool>(@class.method_0)))
		{
			this.list_0.Remove(this.list_0.Find(new Predicate<GClass137>(@class.method_1)));
			base.method_0("CVars");
			this.method_9();
			return;
		}
		this.list_0.Remove(@class.gclass137_0);
		this.method_9();
	}

	// Token: 0x06002C03 RID: 11267 RVA: 0x0001C511 File Offset: 0x0001A711
	public void method_5(int int_0)
	{
		this.list_0.RemoveAt(int_0);
	}

	// Token: 0x06002C04 RID: 11268 RVA: 0x0001C51F File Offset: 0x0001A71F
	public void method_6<CVars>(CVars gparam_0) where CVars : IEnumerable<GClass137>
	{
		this.list_0 = gparam_0.ToList<GClass137>();
	}

	// Token: 0x06002C05 RID: 11269 RVA: 0x0001C532 File Offset: 0x0001A732
	public void method_7()
	{
		this.method_8(this.FilePath);
	}

	// Token: 0x06002C06 RID: 11270 RVA: 0x0001C540 File Offset: 0x0001A740
	public void method_8(string string_1)
	{
		if (string_1 != this.FilePath)
		{
			this.FilePath = string_1;
		}
		VToken vtoken = VdfConvert.Deserialize(File.ReadAllText(string_1))["config"]["convars"];
	}

	// Token: 0x06002C07 RID: 11271 RVA: 0x0001C579 File Offset: 0x0001A779
	public void method_9()
	{
		this.method_10(this.FilePath);
	}

	// Token: 0x06002C08 RID: 11272 RVA: 0x000A869C File Offset: 0x000A689C
	public void method_10(string string_1)
	{
		FileStream fileStream = new FileStream(string_1, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
		try
		{
			if (fileStream.Length > 0L)
			{
				fileStream.SetLength(0L);
			}
			byte[] array = this.method_11();
			int num = 0;
			int i = array.Length;
			while (i > 0)
			{
				int num2 = (i > 14456) ? 14456 : i;
				fileStream.Write(array, num, num2);
				i -= num2;
				num += num2;
			}
			fileStream.Close();
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
	}

	// Token: 0x06002C09 RID: 11273 RVA: 0x000A872C File Offset: 0x000A692C
	public byte[] method_11()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (GClass137 arg in this.list_0)
		{
			stringBuilder.Append(string.Format("{0}\n", arg));
		}
		return this.Encoding.GetBytes(stringBuilder.ToString());
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x000A87A4 File Offset: 0x000A69A4
	public void method_12()
	{
		if (this.list_0.Count > 0)
		{
			this.list_0.Clear();
		}
		this.list_0 = new List<GClass137>
		{
			new GClass137("viewmodel_fov", 68),
			new GClass137("viewmodel_offset_x", 2.5),
			new GClass137("viewmodel_offset_y", 0),
			new GClass137("viewmodel_offset_z", -1.5),
			new GClass137("viewmodel_recoil", 0),
			new GClass137("viewmodel_presetpos", 3),
			new GClass137("cl_viewmodel_shift_left_amt", 1.5),
			new GClass137("cl_viewmodel_shift_right_amt", 0.75),
			new GClass137("cl_bob_lower_amt", 21),
			new GClass137("cl_bobamt_lat", 0.33),
			new GClass137("cl_bobamt_vert", 0.14),
			new GClass137("cl_bobcycle", 0.98),
			new GClass137("cl_autowepswitch", 0),
			new GClass137("cl_crosshair_outlinethickness", 1),
			new GClass137("cl_autohelp", 0),
			new GClass137("cl_showhelp", 0),
			new GClass137("cl_cmdrate", 128),
			new GClass137("cl_updaterate", 128),
			new GClass137("cl_interp_ratio", 1),
			new GClass137("cl_interp", 0),
			new GClass137("cl_lagcompensation", 1),
			new GClass137("cl_predict", 1),
			new GClass137("cl_predictweapons", 1),
			new GClass137("cl_forcepreload", 1),
			new GClass137("tickrate", 128),
			new GClass137("m_rawinput", 1),
			new GClass137("m_mouseaccel1", 0),
			new GClass137("m_mouseaccel2", 0),
			new GClass137("fps_max", 0),
			new GClass137("r_dynamic", 1),
			new GClass137("r_drawtracers_firstperson", 0),
			new GClass137("r_eyegloss", 0),
			new GClass137("r_eyemove", 0),
			new GClass137("r_eyeshift_x", 0),
			new GClass137("r_eyeshift_y", 0),
			new GClass137("r_eyeshift_z", 0),
			new GClass137("r_eyesize", 0),
			new GClass137("snd_mix_async", 1),
			new GClass137("snd_mixahead", 1),
			new GClass137("snd_stream", 1),
			new GClass137("joystick", 1),
			new GClass137("joystick_force_disabled", 1),
			new GClass137("joystick_force_disabled_set_from_options", 1),
			new GClass137("host_writeconfig", null)
		};
	}

	// Token: 0x04001C85 RID: 7301
	public List<GClass137> list_0 = new List<GClass137>();

	// Token: 0x04001C86 RID: 7302
	private string string_0;

	// Token: 0x04001C87 RID: 7303
	private Encoding encoding_0 = Encoding.UTF8;

	// Token: 0x020006D8 RID: 1752
	private sealed class Class853
	{
		// Token: 0x06002C0C RID: 11276 RVA: 0x0001C587 File Offset: 0x0001A787
		internal bool method_0(GClass137 gclass137_1)
		{
			return gclass137_1.Name == this.gclass137_0.Name;
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x0001C587 File Offset: 0x0001A787
		internal bool method_1(GClass137 gclass137_1)
		{
			return gclass137_1.Name == this.gclass137_0.Name;
		}

		// Token: 0x04001C88 RID: 7304
		public GClass137 gclass137_0;
	}

	// Token: 0x020006D9 RID: 1753
	private sealed class Class854
	{
		// Token: 0x06002C0F RID: 11279 RVA: 0x0001C59F File Offset: 0x0001A79F
		internal bool method_0(GClass137 gclass137_1)
		{
			return gclass137_1.Name == this.gclass137_0.Name;
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x0001C59F File Offset: 0x0001A79F
		internal bool method_1(GClass137 gclass137_1)
		{
			return gclass137_1.Name == this.gclass137_0.Name;
		}

		// Token: 0x04001C89 RID: 7305
		public GClass137 gclass137_0;
	}
}
