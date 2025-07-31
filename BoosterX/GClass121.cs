using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000121 RID: 289
public sealed class GClass121 : GClass119
{
	// Token: 0x06000878 RID: 2168 RVA: 0x0000741E File Offset: 0x0000561E
	public GClass121(GClass50 gclass50_1, GClass120 gclass120_1) : base(gclass50_1, gclass120_1)
	{
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x0004122C File Offset: 0x0003F42C
	private bool method_20(IntPtr intptr_0, IntPtr intptr_1, NVDRS_PROFILE nvdrs_PROFILE_0, ref int int_0, uint uint_1, bool bool_0, ref List<uint> list_2)
	{
		if ((long)int_0 >= (long)((ulong)nvdrs_PROFILE_0.numOfSettings))
		{
			return false;
		}
		NVDRS_SETTING nvdrs_SETTING = default(NVDRS_SETTING);
		nvdrs_SETTING.version = NVAPIDrsWrapper.NVDRS_SETTING_VER;
		NVDRS_SETTING nvdrs_SETTING2 = nvdrs_SETTING;
		if (NVAPIDrsWrapper.DRS_GetSetting(intptr_0, intptr_1, uint_1, ref nvdrs_SETTING2) != null)
		{
			return false;
		}
		if (nvdrs_SETTING2.settingLocation != null)
		{
			return false;
		}
		if (!bool_0 && nvdrs_SETTING2.isCurrentPredefined == 1U)
		{
			int_0++;
		}
		else
		{
			if (bool_0)
			{
				if (this.gclass120_0 != null)
				{
					this.gclass120_0.method_23(nvdrs_PROFILE_0.profileName, ref nvdrs_SETTING2);
				}
				int_0++;
				this.method_23(nvdrs_PROFILE_0, nvdrs_SETTING2);
				list_2.Add(nvdrs_SETTING2.settingId);
				return nvdrs_SETTING2.isCurrentPredefined != 1U;
			}
			if (nvdrs_SETTING2.isCurrentPredefined != 1U)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00007456 File Offset: 0x00005656
	private int method_21(int int_0, int int_1)
	{
		if (int_0 <= 0)
		{
			return 0;
		}
		return (int)Math.Round((double)((float)int_0 * 100f / (float)int_1));
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x000412E4 File Offset: 0x0003F4E4
	public Task method_22(bool bool_0, IProgress<int> iprogress_0, CancellationToken cancellationToken_0)
	{
		GClass121.Struct44 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass121_0 = this;
		@struct.bool_0 = bool_0;
		@struct.iprogress_0 = iprogress_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass121.Struct44>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00041340 File Offset: 0x0003F540
	private void method_23(NVDRS_PROFILE nvdrs_PROFILE_0, NVDRS_SETTING nvdrs_SETTING_0)
	{
		GClass121.Class174 @class = new GClass121.Class174();
		@class.nvdrs_SETTING_0 = nvdrs_SETTING_0;
		bool flag = (@class.nvdrs_SETTING_0.settingId & 1879048192U) != 1879048192U;
		GClass235 gclass = this.list_0.FirstOrDefault(new Func<GClass235, bool>(@class.method_0));
		bool flag2 = true;
		if (gclass == null)
		{
			flag2 = false;
			gclass = new GClass235(@class.nvdrs_SETTING_0.settingId, @class.nvdrs_SETTING_0.settingType);
		}
		if (@class.nvdrs_SETTING_0.isPredefinedValid == 1U)
		{
			if (flag)
			{
				if (@class.nvdrs_SETTING_0.settingType == 3)
				{
					gclass.method_1(@class.nvdrs_SETTING_0.predefinedValue.stringValue, nvdrs_PROFILE_0.profileName);
				}
				else if (@class.nvdrs_SETTING_0.settingType == null)
				{
					gclass.method_0(@class.nvdrs_SETTING_0.predefinedValue.dwordValue, nvdrs_PROFILE_0.profileName);
				}
				else if (@class.nvdrs_SETTING_0.settingType == 1)
				{
					gclass.method_2(@class.nvdrs_SETTING_0.predefinedValue.binaryValue, nvdrs_PROFILE_0.profileName);
				}
			}
			else
			{
				gclass.uint_1 += 1U;
			}
			if (!flag2)
			{
				this.list_0.Add(gclass);
			}
		}
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00041468 File Offset: 0x0003F668
	public string method_24(string string_0)
	{
		GClass121.Class171 @class = new GClass121.Class171();
		@class.gclass121_0 = this;
		string b = string_0.ToLowerInvariant();
		@class.string_0 = GClass264.smethod_0();
		string result;
		try
		{
			List<string> list = new List<string>();
			base.method_1(new Action<IntPtr>(@class.method_0), false, false);
			if (File.Exists(@class.string_0))
			{
				foreach (object obj in Regex.Matches(File.ReadAllText(@class.string_0), "\\sProfile\\s\\\"(?<profile>.*?)\\\"(?<scope>.*?Executable.*?)EndProfile", RegexOptions.Singleline))
				{
					Match match = (Match)obj;
					using (IEnumerator enumerator2 = Regex.Matches(match.Result("${scope}"), "Executable\\s\\\"(?<app>.*?)\\\"", RegexOptions.Singleline).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (((Match)enumerator2.Current).Result("${app}").ToLowerInvariant() == b)
							{
								list.Add(match.Result("${profile}"));
							}
						}
					}
				}
			}
			result = string.Join(";", list);
		}
		finally
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
		return result;
	}

	// Token: 0x040004C5 RID: 1221
	public List<GClass235> list_0 = new List<GClass235>();

	// Token: 0x040004C6 RID: 1222
	public List<GClass32> list_1;

	// Token: 0x040004C7 RID: 1223
	public HashSet<GClass32> hashSet_0 = new HashSet<GClass32>();

	// Token: 0x040004C8 RID: 1224
	private readonly uint[] uint_0 = new uint[]
	{
		278257400U,
		271834322U,
		271830721U,
		278073158U,
		10512710U,
		283958146U,
		552327096U,
		9821945U,
		13983613U,
		271834323U,
		271830722U,
		544403510U,
		6701881U,
		2916165U,
		546784961U,
		7790948U,
		553612435U,
		541917051U
	};

	// Token: 0x02000122 RID: 290
	private sealed class Class171
	{
		// Token: 0x0600087F RID: 2175 RVA: 0x00007470 File Offset: 0x00005670
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass121_0.method_19(intptr_0, this.string_0);
		}

		// Token: 0x040004C9 RID: 1225
		public GClass121 gclass121_0;

		// Token: 0x040004CA RID: 1226
		public string string_0;
	}

	// Token: 0x02000123 RID: 291
	private sealed class Class172
	{
		// Token: 0x06000881 RID: 2177 RVA: 0x00041600 File Offset: 0x0003F800
		internal void method_0()
		{
			GClass121.Class173 @class = new GClass121.Class173();
			@class.class172_0 = this;
			this.gclass121_0.list_1 = new List<GClass32>();
			this.gclass121_0.hashSet_0 = new HashSet<GClass32>();
			@class.list_0 = new List<uint>(this.gclass121_0.uint_0);
			this.gclass121_0.method_1(new Action<IntPtr>(@class.method_0), false, false);
		}

		// Token: 0x040004CB RID: 1227
		public GClass121 gclass121_0;

		// Token: 0x040004CC RID: 1228
		public CancellationToken cancellationToken_0;

		// Token: 0x040004CD RID: 1229
		public IProgress<int> iprogress_0;

		// Token: 0x040004CE RID: 1230
		public bool bool_0;
	}

	// Token: 0x02000124 RID: 292
	[StructLayout(LayoutKind.Auto)]
	private struct Struct44 : IAsyncStateMachine
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x0004166C File Offset: 0x0003F86C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new GClass121.Class172
					{
						gclass121_0 = this.gclass121_0,
						cancellationToken_0 = this.cancellationToken_0,
						iprogress_0 = this.iprogress_0,
						bool_0 = this.bool_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass121.Struct44>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00007484 File Offset: 0x00005684
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040004CF RID: 1231
		public int int_0;

		// Token: 0x040004D0 RID: 1232
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040004D1 RID: 1233
		public GClass121 gclass121_0;

		// Token: 0x040004D2 RID: 1234
		public CancellationToken cancellationToken_0;

		// Token: 0x040004D3 RID: 1235
		public IProgress<int> iprogress_0;

		// Token: 0x040004D4 RID: 1236
		public bool bool_0;

		// Token: 0x040004D5 RID: 1237
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000125 RID: 293
	private sealed class Class173
	{
		// Token: 0x06000885 RID: 2181 RVA: 0x00041758 File Offset: 0x0003F958
		internal void method_0(IntPtr intptr_0)
		{
			this.class172_0.gclass121_0.method_3(intptr_0, string.Empty);
			List<IntPtr> list = this.class172_0.gclass121_0.method_14(intptr_0);
			int count = list.Count;
			int num = 0;
			foreach (IntPtr intptr_ in list)
			{
				if (this.class172_0.cancellationToken_0.IsCancellationRequested)
				{
					break;
				}
				IProgress<int> iprogress_ = this.class172_0.iprogress_0;
				if (iprogress_ != null)
				{
					iprogress_.Report(this.class172_0.gclass121_0.method_21(num++, count));
				}
				NVDRS_PROFILE nvdrs_PROFILE = this.class172_0.gclass121_0.method_5(intptr_0, intptr_);
				int num2 = 0;
				List<uint> list2 = new List<uint>();
				bool flag = false;
				if (nvdrs_PROFILE.isPredefined == 0U)
				{
					this.class172_0.gclass121_0.list_1.Add(new GClass32(nvdrs_PROFILE));
					this.class172_0.gclass121_0.hashSet_0.Add(new GClass32(nvdrs_PROFILE));
					flag = true;
					if (this.class172_0.bool_0)
					{
						continue;
					}
				}
				foreach (uint uint_ in this.list_0)
				{
					if (this.class172_0.gclass121_0.method_20(intptr_0, intptr_, nvdrs_PROFILE, ref num2, uint_, !this.class172_0.bool_0, ref list2) && !flag)
					{
						flag = true;
						this.class172_0.gclass121_0.list_1.Add(new GClass32(nvdrs_PROFILE));
						if (this.class172_0.bool_0)
						{
							break;
						}
					}
				}
				if (!(flag & this.class172_0.bool_0) && (long)num2 < (long)((ulong)nvdrs_PROFILE.numOfSettings))
				{
					foreach (NVDRS_SETTING nvdrs_SETTING in this.class172_0.gclass121_0.method_15(intptr_0, intptr_))
					{
						if (this.list_0.IndexOf(nvdrs_SETTING.settingId) < 0)
						{
							this.list_0.Add(nvdrs_SETTING.settingId);
						}
						if (!this.class172_0.bool_0 && list2.IndexOf(nvdrs_SETTING.settingId) < 0)
						{
							this.class172_0.gclass121_0.method_23(nvdrs_PROFILE, nvdrs_SETTING);
						}
						if (nvdrs_SETTING.isCurrentPredefined != 1U && !flag)
						{
							flag = true;
							this.class172_0.gclass121_0.list_1.Add(new GClass32(nvdrs_PROFILE));
							if (this.class172_0.bool_0)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x040004D6 RID: 1238
		public List<uint> list_0;

		// Token: 0x040004D7 RID: 1239
		public GClass121.Class172 class172_0;
	}

	// Token: 0x02000126 RID: 294
	private sealed class Class174
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x00007492 File Offset: 0x00005692
		internal bool method_0(GClass235 gclass235_0)
		{
			return gclass235_0.uint_0.Equals(this.nvdrs_SETTING_0.settingId);
		}

		// Token: 0x040004D8 RID: 1240
		public NVDRS_SETTING nvdrs_SETTING_0;
	}
}
