using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x0200018E RID: 398
public sealed class GClass30
{
	// Token: 0x06000B1C RID: 2844 RVA: 0x00008CDF File Offset: 0x00006EDF
	public GClass30(string string_2)
	{
		this.method_1(string_2);
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00008CEE File Offset: 0x00006EEE
	public GClass30(string string_2, string string_3)
	{
		this.method_1(string_2);
		this.method_3(string_3);
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00008D04 File Offset: 0x00006F04
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00008D0C File Offset: 0x00006F0C
	public void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x00008D15 File Offset: 0x00006F15
	public string method_2()
	{
		return this.string_1;
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x00008D1D File Offset: 0x00006F1D
	public void method_3(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x00008D26 File Offset: 0x00006F26
	public static implicit operator GClass30(string string_2)
	{
		return new GClass30(string_2);
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x00049A4C File Offset: 0x00047C4C
	public static GClass30 smethod_0()
	{
		if (GClass30.gclass30_0 != null)
		{
			return GClass30.gclass30_0;
		}
		GClass30 gclass = GClass30.smethod_2();
		if (gclass == null)
		{
			gclass = GClass30.smethod_3(null, ".openai", true);
		}
		if (gclass == null)
		{
			gclass = GClass30.smethod_3(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".openai", true);
		}
		GClass30.gclass30_0 = gclass;
		return gclass;
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x00008D2E File Offset: 0x00006F2E
	public static void smethod_1(GClass30 gclass30_1)
	{
		GClass30.gclass30_0 = gclass30_1;
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x00049A9C File Offset: 0x00047C9C
	public static GClass30 smethod_2()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("OPENAI_KEY");
		if (string.IsNullOrEmpty(environmentVariable))
		{
			environmentVariable = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
			if (string.IsNullOrEmpty(environmentVariable))
			{
				return null;
			}
		}
		string environmentVariable2 = Environment.GetEnvironmentVariable("OPENAI_ORGANIZATION");
		return new GClass30(environmentVariable, environmentVariable2);
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x00049AE8 File Offset: 0x00047CE8
	public static GClass30 smethod_3(string string_2, string string_3, bool bool_0)
	{
		if (string_2 == null)
		{
			string_2 = Environment.CurrentDirectory;
		}
		string text = null;
		string string_4 = null;
		DirectoryInfo directoryInfo = new DirectoryInfo(string_2);
		while (text == null && directoryInfo.Parent != null)
		{
			if (File.Exists(Path.Combine(directoryInfo.FullName, string_3)))
			{
				string[] array = File.ReadAllLines(Path.Combine(directoryInfo.FullName, string_3));
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(new char[]
					{
						'=',
						':'
					});
					if (array2.Length == 2)
					{
						string a = array2[0].ToUpper();
						if (!(a == "OPENAI_KEY"))
						{
							if (!(a == "OPENAI_API_KEY"))
							{
								if (a == "OPENAI_ORGANIZATION")
								{
									string_4 = array2[1].Trim();
								}
							}
							else
							{
								text = array2[1].Trim();
							}
						}
						else
						{
							text = array2[1].Trim();
						}
					}
				}
			}
			if (!bool_0)
			{
				break;
			}
			directoryInfo = directoryInfo.Parent;
		}
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return new GClass30(text, string_4);
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00049BF4 File Offset: 0x00047DF4
	public Task<bool> method_4()
	{
		GClass30.Struct81 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@struct.gclass30_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass30.Struct81>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400073D RID: 1853
	private string string_0;

	// Token: 0x0400073E RID: 1854
	private string string_1;

	// Token: 0x0400073F RID: 1855
	private static GClass30 gclass30_0;

	// Token: 0x0200018F RID: 399
	[StructLayout(LayoutKind.Auto)]
	private struct Struct81 : IAsyncStateMachine
	{
		// Token: 0x06000B28 RID: 2856 RVA: 0x00049C38 File Offset: 0x00047E38
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass30 gclass = this.gclass30_0;
			bool result;
			try
			{
				GClass11 gclass2;
				if (num != 0)
				{
					if (string.IsNullOrEmpty(gclass.method_0()))
					{
						result = false;
						goto IL_BE;
					}
					gclass2 = new GClass11(gclass);
				}
				List<GClass27> result2;
				try
				{
					TaskAwaiter<List<GClass27>> awaiter;
					if (num != 0)
					{
						awaiter = gclass2.Models.imethod_2().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<GClass27>>, GClass30.Struct81>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<GClass27>>);
						this.int_0 = -1;
					}
					result2 = awaiter.GetResult();
				}
				catch (Exception)
				{
					result = false;
					goto IL_BE;
				}
				result = (result2.Count > 0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_BE:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00008D36 File Offset: 0x00006F36
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000740 RID: 1856
		public int int_0;

		// Token: 0x04000741 RID: 1857
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x04000742 RID: 1858
		public GClass30 gclass30_0;

		// Token: 0x04000743 RID: 1859
		private TaskAwaiter<List<GClass27>> taskAwaiter_0;
	}
}
