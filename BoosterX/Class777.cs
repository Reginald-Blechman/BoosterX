using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ns0;

// Token: 0x02000668 RID: 1640
internal sealed class Class777
{
	// Token: 0x06002977 RID: 10615 RVA: 0x000A169C File Offset: 0x0009F89C
	public static Task<string> smethod_0(string string_0)
	{
		Class777.Struct449 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class777.Struct449>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x000A16E0 File Offset: 0x0009F8E0
	public static Task<List<string>> smethod_1()
	{
		Class777.Struct450 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<string>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class777.Struct450>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001B3C RID: 6972
	public static List<string> list_0 = new List<string>();

	// Token: 0x02000669 RID: 1641
	[StructLayout(LayoutKind.Auto)]
	private struct Struct449 : IAsyncStateMachine
	{
		// Token: 0x06002979 RID: 10617 RVA: 0x000A171C File Offset: 0x0009F91C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result;
			try
			{
				TaskAwaiter<List<string>> awaiter;
				if (num != 0)
				{
					Class777.Class779 @class = new Class777.Class779();
					@class.string_0 = this.string_0.ToLower();
					this.ienumerable_0 = Class725.list_12.Where(new Func<string, bool>(@class.method_0));
					if (this.ienumerable_0.Count<string>() == 0)
					{
						result = string.Empty;
						goto IL_1A2;
					}
					if (Class777.list_0.Count != 0)
					{
						goto IL_C5;
					}
					awaiter = Class777.smethod_1().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, Class777.Struct449>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<string>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IL_C5:
				List<string> list = new List<string>();
				List<string>.Enumerator enumerator = Class777.list_0.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class777.Class778 class2 = new Class777.Class778();
						class2.string_0 = enumerator.Current;
						if (this.ienumerable_0.Where(new Func<string, bool>(class2.method_0)).Count<string>() > 0)
						{
							list.Add(class2.string_0);
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				List<string> list2 = list.Distinct<string>().ToList<string>();
				if (list2.Count == 0)
				{
					result = string.Empty;
				}
				else
				{
					string text = string.Join(" | ", list2);
					if (text.Length > 2000)
					{
						text = text.Substring(0, 2000);
					}
					result = text;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.ienumerable_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1A2:
			this.int_0 = -2;
			this.ienumerable_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0001B26A File Offset: 0x0001946A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B3D RID: 6973
		public int int_0;

		// Token: 0x04001B3E RID: 6974
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04001B3F RID: 6975
		public string string_0;

		// Token: 0x04001B40 RID: 6976
		private IEnumerable<string> ienumerable_0;

		// Token: 0x04001B41 RID: 6977
		private TaskAwaiter<List<string>> taskAwaiter_0;
	}

	// Token: 0x0200066A RID: 1642
	private sealed class Class778
	{
		// Token: 0x0600297C RID: 10620 RVA: 0x0001B278 File Offset: 0x00019478
		internal bool method_0(string string_1)
		{
			return Regex.IsMatch(this.string_0, "(^|\\s)" + string_1, RegexOptions.IgnoreCase);
		}

		// Token: 0x04001B42 RID: 6978
		public string string_0;
	}

	// Token: 0x0200066B RID: 1643
	private sealed class Class779
	{
		// Token: 0x0600297E RID: 10622 RVA: 0x0001B292 File Offset: 0x00019492
		internal bool method_0(string string_1)
		{
			return Regex.IsMatch(this.string_0, "(^|\\s)" + string_1, RegexOptions.IgnoreCase);
		}

		// Token: 0x04001B43 RID: 6979
		public string string_0;
	}

	// Token: 0x0200066C RID: 1644
	[StructLayout(LayoutKind.Auto)]
	private struct Struct450 : IAsyncStateMachine
	{
		// Token: 0x0600297F RID: 10623 RVA: 0x000A191C File Offset: 0x0009FB1C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<string> list_;
			try
			{
				TaskAwaiter<ObservableCollection<Class512>> awaiter;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_1AB;
				}
				case 2:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					goto IL_2B7;
				}
				case 3:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
					int num5 = -1;
					num = -1;
					this.int_0 = num5;
					goto IL_3C3;
				}
				case 4:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
					int num6 = -1;
					num = -1;
					this.int_0 = num6;
					goto IL_4CF;
				}
				case 5:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
					int num7 = -1;
					num = -1;
					this.int_0 = num7;
					goto IL_5DB;
				}
				case 6:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
					int num8 = -1;
					num = -1;
					this.int_0 = num8;
					goto IL_6E7;
				}
				default:
					if (Class777.list_0.Count<string>() > 0)
					{
						list_ = Class777.list_0;
						goto IL_9A3;
					}
					awaiter = Class148.smethod_2(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd), false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num9 = 0;
						num = 0;
						this.int_0 = num9;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class777.Struct450>(ref awaiter, ref this);
						return;
					}
					break;
				}
				IEnumerator<Class512> enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 @class = enumerator.Current;
						Class777.list_0.Add(string.Concat(new string[]
						{
							Class298.smethod_2("Vkladka"),
							" \"",
							Class298.smethod_2("Privacy"),
							"\" (",
							Class298.smethod_2("Vkladka2"),
							"): ",
							@class.method_7(),
							" * ",
							@class.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				awaiter = Class148.smethod_2(typeof(dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd), false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num10 = 1;
					num = 1;
					this.int_0 = num10;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class777.Struct450>(ref awaiter, ref this);
					return;
				}
				IL_1AB:
				enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 class2 = enumerator.Current;
						Class777.list_0.Add(string.Concat(new string[]
						{
							Class298.smethod_2("Vkladka"),
							" \"",
							Class298.smethod_2("Depreciated"),
							"\" (",
							Class298.smethod_2("Vkladka2"),
							"): ",
							class2.method_7(),
							" * ",
							class2.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				awaiter = Class148.smethod_2(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd), false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num11 = 2;
					num = 2;
					this.int_0 = num11;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class777.Struct450>(ref awaiter, ref this);
					return;
				}
				IL_2B7:
				enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 class3 = enumerator.Current;
						Class777.list_0.Add(string.Concat(new string[]
						{
							Class298.smethod_2("Vkladka"),
							" \"",
							Class298.smethod_2("Security"),
							"\" (",
							Class298.smethod_2("Vkladka2"),
							"): ",
							class3.method_7(),
							" * ",
							class3.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				awaiter = Class148.smethod_2(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd), false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num12 = 3;
					num = 3;
					this.int_0 = num12;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class777.Struct450>(ref awaiter, ref this);
					return;
				}
				IL_3C3:
				enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 class4 = enumerator.Current;
						Class777.list_0.Add(string.Concat(new string[]
						{
							Class298.smethod_2("Vkladka"),
							" \"",
							Class298.smethod_2("registrytweaksexp"),
							"\" (",
							Class298.smethod_2("Vkladka2"),
							"): ",
							class4.method_7(),
							" * ",
							class4.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				awaiter = Class148.smethod_2(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd), false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num13 = 4;
					num = 4;
					this.int_0 = num13;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class777.Struct450>(ref awaiter, ref this);
					return;
				}
				IL_4CF:
				enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 class5 = enumerator.Current;
						Class777.list_0.Add(string.Concat(new string[]
						{
							Class298.smethod_2("Vkladka"),
							" \"",
							Class298.smethod_2("settingsexp"),
							"\" (",
							Class298.smethod_2("Vkladka2"),
							"): ",
							class5.method_7(),
							" * ",
							class5.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				awaiter = Class148.smethod_2(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd), false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num14 = 5;
					num = 5;
					this.int_0 = num14;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class777.Struct450>(ref awaiter, ref this);
					return;
				}
				IL_5DB:
				enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 class6 = enumerator.Current;
						Class777.list_0.Add(string.Concat(new string[]
						{
							Class298.smethod_2("Vkladka"),
							" \"",
							Class298.smethod_2("powermgmtexp"),
							"\" (",
							Class298.smethod_2("Vkladka2"),
							"): ",
							class6.method_7(),
							" * ",
							class6.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				awaiter = Class148.smethod_2(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd), false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num15 = 6;
					num = 6;
					this.int_0 = num15;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class777.Struct450>(ref awaiter, ref this);
					return;
				}
				IL_6E7:
				enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 class7 = enumerator.Current;
						Class777.list_0.Add(string.Concat(new string[]
						{
							Class298.smethod_2("Vkladka"),
							" \"",
							Class298.smethod_2("Tasks"),
							"\" (",
							Class298.smethod_2("Vkladka2"),
							"): ",
							class7.method_7(),
							" * ",
							class7.Description
						}));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				Class777.list_0.Add(string.Concat(new string[]
				{
					Class298.smethod_2("Vkladka"),
					" \"",
					Class298.smethod_2("powermgmtexp"),
					"\" ",
					Class298.smethod_2("PowerAddition")
				}));
				Class777.list_0.Add(string.Concat(new string[]
				{
					Class298.smethod_2("Vkladka"),
					" \"",
					Class298.smethod_2("uwpappsexp"),
					"\" ",
					Class298.smethod_2("DebloadAddition")
				}));
				Class725.list_11.ForEach(new Action<string>(Class777.Class780.class780_0.method_0));
				Class777.list_0.Add(string.Concat(new string[]
				{
					Class298.smethod_2("Vkladka"),
					" \"",
					Class298.smethod_2("uwpappsexp"),
					"\" ",
					Class298.smethod_2("ServisesAdditon")
				}));
				Class335.smethod_4(false).ToList<Class513>().ForEach(new Action<Class513>(Class777.Class780.class780_0.method_1));
				Class777.list_0.Add(string.Concat(new string[]
				{
					Class298.smethod_2("Vkladka"),
					" \"",
					Class298.smethod_2("affinityexp"),
					"\" ",
					Class298.smethod_2("InterruptAddition")
				}));
				Class777.list_0.Add(string.Concat(new string[]
				{
					Class298.smethod_2("Vkladka"),
					" \"",
					Class298.smethod_2("autorunsexp"),
					"\" ",
					Class298.smethod_2("AutorunsAddition")
				}));
				list_ = Class777.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_9A3:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0001B2AC File Offset: 0x000194AC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B44 RID: 6980
		public int int_0;

		// Token: 0x04001B45 RID: 6981
		public AsyncTaskMethodBuilder<List<string>> asyncTaskMethodBuilder_0;

		// Token: 0x04001B46 RID: 6982
		private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
	}

	// Token: 0x0200066D RID: 1645
	[Serializable]
	private sealed class Class780
	{
		// Token: 0x06002983 RID: 10627 RVA: 0x000A23A4 File Offset: 0x000A05A4
		internal void method_0(string string_0)
		{
			Class777.list_0.Add(string.Concat(new string[]
			{
				Class298.smethod_2("Vkladka"),
				" \"",
				Class298.smethod_2("servicesexp"),
				"\" (",
				Class298.smethod_2("Vkladka3"),
				"): ",
				Class298.smethod_2(string_0),
				" * ",
				Class298.smethod_2(string_0 + "Desc")
			}));
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000A2434 File Offset: 0x000A0634
		internal void method_1(Class513 class513_0)
		{
			Class777.list_0.Add(string.Concat(new string[]
			{
				Class298.smethod_2("Vkladka"),
				" \"",
				Class298.smethod_2("cleanupexp"),
				"\" (",
				Class298.smethod_2("Vkladka3"),
				"): ",
				class513_0.Name,
				" * ",
				class513_0.Description
			}));
		}

		// Token: 0x04001B47 RID: 6983
		public static readonly Class777.Class780 class780_0 = new Class777.Class780();

		// Token: 0x04001B48 RID: 6984
		public static Action<string> action_0;

		// Token: 0x04001B49 RID: 6985
		public static Action<Class513> action_1;
	}
}
