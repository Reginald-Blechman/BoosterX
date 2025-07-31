using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000240 RID: 576
public sealed class GClass172 : GClass162
{
	// Token: 0x06000FA8 RID: 4008 RVA: 0x00054F04 File Offset: 0x00053104
	public GClass172(string string_1)
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

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0000B77B File Offset: 0x0000997B
	// (set) Token: 0x06000FAA RID: 4010 RVA: 0x0000B783 File Offset: 0x00009983
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

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06000FAB RID: 4011 RVA: 0x0000B78C File Offset: 0x0000998C
	// (set) Token: 0x06000FAC RID: 4012 RVA: 0x0000B794 File Offset: 0x00009994
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

	// Token: 0x06000FAD RID: 4013 RVA: 0x0000B79D File Offset: 0x0000999D
	public void method_2()
	{
		this.list_0.Clear();
		this.method_7();
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00054F68 File Offset: 0x00053168
	public void method_3(GClass137 gclass137_0)
	{
		GClass172.Class269 @class = new GClass172.Class269();
		@class.gclass137_0 = gclass137_0;
		if (this.list_0 != null && this.list_0.Any(new Func<GClass137, bool>(@class.method_0)))
		{
			this.list_0.Find(new Predicate<GClass137>(@class.method_1)).method_1(@class.gclass137_0.method_0());
		}
		this.list_0.Add(@class.gclass137_0);
		this.method_9();
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00054FE4 File Offset: 0x000531E4
	public void method_4(GClass137 gclass137_0)
	{
		GClass172.Class268 @class = new GClass172.Class268();
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

	// Token: 0x06000FB0 RID: 4016 RVA: 0x0000B7B0 File Offset: 0x000099B0
	public void method_5(int int_0)
	{
		this.list_0.RemoveAt(int_0);
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x0000B7BE File Offset: 0x000099BE
	public void method_6<CVars>(CVars gparam_0) where CVars : IEnumerable<GClass137>
	{
		this.list_0 = gparam_0.ToList<GClass137>();
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x0000B7D1 File Offset: 0x000099D1
	public void method_7()
	{
		this.method_8(this.FilePath);
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0005507C File Offset: 0x0005327C
	public void method_8(string string_1)
	{
		if (string_1 != this.FilePath)
		{
			this.FilePath = string_1;
		}
		FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		try
		{
			byte[] array = new byte[fileStream.Length];
			int num = 0;
			int i = array.Length;
			while (i > 0)
			{
				int num2;
				if ((num2 = fileStream.Read(array, 0, array.Length)) > 0)
				{
					num += num2;
					i -= num2;
				}
			}
			foreach (string string_2 in this.Encoding.GetString(array, 0, num).Split(new string[]
			{
				"\n"
			}, StringSplitOptions.RemoveEmptyEntries))
			{
				this.list_0.Add(new GClass137(string_2));
				base.method_0("CVars");
			}
			fileStream.Close();
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x0000B7DF File Offset: 0x000099DF
	public void method_9()
	{
		this.method_10(this.FilePath);
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x00055158 File Offset: 0x00053358
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

	// Token: 0x06000FB6 RID: 4022 RVA: 0x000551E8 File Offset: 0x000533E8
	public byte[] method_11()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (GClass137 arg in this.list_0)
		{
			stringBuilder.Append(string.Format("{0}\n", arg));
		}
		return this.Encoding.GetBytes(stringBuilder.ToString());
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x00055260 File Offset: 0x00053460
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

	// Token: 0x04000A06 RID: 2566
	public List<GClass137> list_0 = new List<GClass137>();

	// Token: 0x04000A07 RID: 2567
	private string string_0;

	// Token: 0x04000A08 RID: 2568
	private Encoding encoding_0 = Encoding.UTF8;

	// Token: 0x02000241 RID: 577
	private sealed class Class268
	{
		// Token: 0x06000FB9 RID: 4025 RVA: 0x0000B7ED File Offset: 0x000099ED
		internal bool method_0(GClass137 gclass137_1)
		{
			return gclass137_1.Name == this.gclass137_0.Name;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0000B7ED File Offset: 0x000099ED
		internal bool method_1(GClass137 gclass137_1)
		{
			return gclass137_1.Name == this.gclass137_0.Name;
		}

		// Token: 0x04000A09 RID: 2569
		public GClass137 gclass137_0;
	}

	// Token: 0x02000242 RID: 578
	private sealed class Class269
	{
		// Token: 0x06000FBC RID: 4028 RVA: 0x0000B805 File Offset: 0x00009A05
		internal bool method_0(GClass137 gclass137_1)
		{
			return gclass137_1.Name == this.gclass137_0.Name;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0000B805 File Offset: 0x00009A05
		internal bool method_1(GClass137 gclass137_1)
		{
			return gclass137_1.Name == this.gclass137_0.Name;
		}

		// Token: 0x04000A0A RID: 2570
		public GClass137 gclass137_0;
	}
}
