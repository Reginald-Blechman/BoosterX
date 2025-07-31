using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x02000186 RID: 390
public sealed class GClass27
{
	// Token: 0x06000AC1 RID: 2753 RVA: 0x00008782 File Offset: 0x00006982
	public GClass27(string string_5)
	{
		this.String_0 = string_5;
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x0000879C File Offset: 0x0000699C
	public GClass27()
	{
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000087D9 File Offset: 0x000069D9
	// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x000087E1 File Offset: 0x000069E1
	[JsonProperty("id")]
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

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000087EA File Offset: 0x000069EA
	// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x000087F2 File Offset: 0x000069F2
	[JsonProperty("owned_by")]
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

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000087FB File Offset: 0x000069FB
	// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00008803 File Offset: 0x00006A03
	[JsonProperty("object")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00049750 File Offset: 0x00047950
	[JsonIgnore]
	public DateTime? Nullable_0
	{
		get
		{
			if (this.Nullable_1 == null)
			{
				return null;
			}
			return new DateTime?(DateTimeOffset.FromUnixTimeSeconds(this.Nullable_1.Value).DateTime);
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0000880C File Offset: 0x00006A0C
	// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00008814 File Offset: 0x00006A14
	[JsonProperty("created")]
	public long? Nullable_1
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0000881D File Offset: 0x00006A1D
	// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00008825 File Offset: 0x00006A25
	[JsonProperty("permission")]
	public List<GClass158> List_0
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

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0000882E File Offset: 0x00006A2E
	// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00008836 File Offset: 0x00006A36
	[JsonProperty("root")]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0000883F File Offset: 0x00006A3F
	// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00008847 File Offset: 0x00006A47
	[JsonProperty("parent")]
	public string String_4
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00008850 File Offset: 0x00006A50
	public static implicit operator string(GClass27 gclass27_4)
	{
		if (gclass27_4 == null)
		{
			return null;
		}
		return gclass27_4.String_0;
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x0000885D File Offset: 0x00006A5D
	public static implicit operator GClass27(string string_5)
	{
		return new GClass27(string_5);
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x00008865 File Offset: 0x00006A65
	public static GClass27 smethod_0()
	{
		return GClass27.gclass27_0;
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x0000886C File Offset: 0x00006A6C
	public static void smethod_1(GClass27 gclass27_4)
	{
		GClass27.gclass27_0 = gclass27_4;
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x00008874 File Offset: 0x00006A74
	public static GClass27 smethod_2()
	{
		return GClass27.gclass27_1;
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0000887B File Offset: 0x00006A7B
	public static void smethod_3(GClass27 gclass27_4)
	{
		GClass27.gclass27_1 = gclass27_4;
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00008883 File Offset: 0x00006A83
	public static GClass27 smethod_4()
	{
		return GClass27.gclass27_2;
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x0000888A File Offset: 0x00006A8A
	public static void smethod_5(GClass27 gclass27_4)
	{
		GClass27.gclass27_2 = gclass27_4;
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00008892 File Offset: 0x00006A92
	public static GClass27 smethod_6()
	{
		return GClass27.gclass27_3;
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x00008899 File Offset: 0x00006A99
	public static void smethod_7(GClass27 gclass27_4)
	{
		GClass27.gclass27_3 = gclass27_4;
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00049798 File Offset: 0x00047998
	public Task<GClass27> method_0(GClass11 gclass11_0)
	{
		GClass27.Struct79 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass27>.Create();
		@struct.gclass27_0 = this;
		@struct.gclass11_0 = gclass11_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass27.Struct79>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x000088A1 File Offset: 0x00006AA1
	public static GClass27 smethod_8()
	{
		return new GClass27("gpt-4")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x000088BA File Offset: 0x00006ABA
	public static GClass27 smethod_9()
	{
		return new GClass27("gpt-4-32k")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x000088D3 File Offset: 0x00006AD3
	public static GClass27 smethod_10()
	{
		return new GClass27("gpt-4-vision-preview")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x000088EC File Offset: 0x00006AEC
	public static GClass27 smethod_11()
	{
		return new GClass27("gpt-4-1106-preview")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x00008905 File Offset: 0x00006B05
	public static GClass27 smethod_12()
	{
		return new GClass27("gpt-4-0125-preview")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0000891E File Offset: 0x00006B1E
	public static GClass27 smethod_13()
	{
		return new GClass27("gpt-3.5-turbo")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x00008937 File Offset: 0x00006B37
	public static GClass27 smethod_14()
	{
		return new GClass27("gpt-4o-mini")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00008950 File Offset: 0x00006B50
	public static GClass27 smethod_15()
	{
		return new GClass27("gpt-4.1-nano")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00008969 File Offset: 0x00006B69
	public static GClass27 smethod_16()
	{
		return new GClass27("gpt-4o")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00008982 File Offset: 0x00006B82
	public static GClass27 smethod_17()
	{
		return new GClass27("gpt-3.5-turbo-1106")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x0000899B File Offset: 0x00006B9B
	public static GClass27 smethod_18()
	{
		return new GClass27("gpt-3.5-turbo-0125")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x000089B4 File Offset: 0x00006BB4
	public static GClass27 smethod_19()
	{
		return new GClass27("gpt-3.5-turbo-16k")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x000089CD File Offset: 0x00006BCD
	public static GClass27 smethod_20()
	{
		return new GClass27("gpt-3.5-turbo-instruct")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x000089E6 File Offset: 0x00006BE6
	public static GClass27 smethod_21()
	{
		return new GClass27("babbage-002")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x000089FF File Offset: 0x00006BFF
	public static GClass27 smethod_22()
	{
		return new GClass27("davinci-002")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00008A18 File Offset: 0x00006C18
	public static GClass27 smethod_23()
	{
		return new GClass27("text-ada-001")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00008A31 File Offset: 0x00006C31
	public static GClass27 smethod_24()
	{
		return new GClass27("text-babbage-001")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x00008A4A File Offset: 0x00006C4A
	public static GClass27 smethod_25()
	{
		return new GClass27("text-curie-001")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00008A63 File Offset: 0x00006C63
	public static GClass27 smethod_26()
	{
		return new GClass27("text-davinci-003")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x00008A7C File Offset: 0x00006C7C
	public static GClass27 smethod_27()
	{
		return new GClass27("code-cushman-001")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00008A95 File Offset: 0x00006C95
	public static GClass27 smethod_28()
	{
		return new GClass27("code-davinci-002")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00008AAE File Offset: 0x00006CAE
	public static GClass27 smethod_29()
	{
		return new GClass27("text-embedding-ada-002")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x00008AC7 File Offset: 0x00006CC7
	public static GClass27 smethod_30()
	{
		return new GClass27("text-moderation-stable")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00008AE0 File Offset: 0x00006CE0
	public static GClass27 smethod_31()
	{
		return new GClass27("text-moderation-latest")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00008AF9 File Offset: 0x00006CF9
	public static GClass27 smethod_32()
	{
		return new GClass27("dall-e-2")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00008B12 File Offset: 0x00006D12
	public static GClass27 smethod_33()
	{
		return new GClass27("dall-e-3")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00008B2B File Offset: 0x00006D2B
	public static GClass27 smethod_34()
	{
		return new GClass27("tts-1")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00008B44 File Offset: 0x00006D44
	public static GClass27 smethod_35()
	{
		return new GClass27("tts-1-hd")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x00008B5D File Offset: 0x00006D5D
	public static GClass27 smethod_36()
	{
		return new GClass27("whisper-1")
		{
			String_1 = "openai"
		};
	}

	// Token: 0x0400071D RID: 1821
	private string string_0;

	// Token: 0x0400071E RID: 1822
	private string string_1;

	// Token: 0x0400071F RID: 1823
	private string string_2;

	// Token: 0x04000720 RID: 1824
	private long? nullable_0;

	// Token: 0x04000721 RID: 1825
	private List<GClass158> list_0 = new List<GClass158>();

	// Token: 0x04000722 RID: 1826
	private string string_3;

	// Token: 0x04000723 RID: 1827
	private string string_4;

	// Token: 0x04000724 RID: 1828
	private static GClass27 gclass27_0 = GClass27.smethod_20();

	// Token: 0x04000725 RID: 1829
	private static GClass27 gclass27_1 = GClass27.smethod_13();

	// Token: 0x04000726 RID: 1830
	private static GClass27 gclass27_2 = GClass27.smethod_34();

	// Token: 0x04000727 RID: 1831
	private static GClass27 gclass27_3 = GClass27.smethod_36();

	// Token: 0x02000187 RID: 391
	[StructLayout(LayoutKind.Auto)]
	private struct Struct79 : IAsyncStateMachine
	{
		// Token: 0x06000AFB RID: 2811 RVA: 0x000497E4 File Offset: 0x000479E4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass27 gclass = this.gclass27_0;
			GClass27 result;
			try
			{
				TaskAwaiter<GClass27> awaiter;
				if (num != 0)
				{
					awaiter = this.gclass11_0.Models.imethod_0(gclass.String_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass27>, GClass27.Struct79>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass27>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00008B76 File Offset: 0x00006D76
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000728 RID: 1832
		public int int_0;

		// Token: 0x04000729 RID: 1833
		public AsyncTaskMethodBuilder<GClass27> asyncTaskMethodBuilder_0;

		// Token: 0x0400072A RID: 1834
		public GClass11 gclass11_0;

		// Token: 0x0400072B RID: 1835
		public GClass27 gclass27_0;

		// Token: 0x0400072C RID: 1836
		private TaskAwaiter<GClass27> taskAwaiter_0;
	}
}
