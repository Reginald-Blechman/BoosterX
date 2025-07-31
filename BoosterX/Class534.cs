using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Dism;
using ns0;

// Token: 0x020006BF RID: 1727
internal sealed class Class534 : GClass162
{
	// Token: 0x06002B98 RID: 11160 RVA: 0x000A728C File Offset: 0x000A548C
	public Class534()
	{
		this.Tweaks.CollectionChanged += this.method_4;
		this.method_2();
	}

	// Token: 0x1700072D RID: 1837
	// (get) Token: 0x06002B9A RID: 11162 RVA: 0x0001C268 File Offset: 0x0001A468
	// (set) Token: 0x06002B9B RID: 11163 RVA: 0x0001C270 File Offset: 0x0001A470
	public bool FeaturesLoaded
	{
		get
		{
			return this.bool_0;
		}
		private set
		{
			this.bool_0 = value;
			base.method_0("FeaturesLoaded");
		}
	}

	// Token: 0x1700072E RID: 1838
	// (get) Token: 0x06002B9C RID: 11164 RVA: 0x0001C285 File Offset: 0x0001A485
	// (set) Token: 0x06002B9D RID: 11165 RVA: 0x0001C28D File Offset: 0x0001A48D
	public ObservableCollection<Class512> Tweaks
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("Tweaks");
		}
	}

	// Token: 0x06002B9E RID: 11166 RVA: 0x000A72EC File Offset: 0x000A54EC
	public Task method_2()
	{
		Class534.Struct461 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class534_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class534.Struct461>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x000A7330 File Offset: 0x000A5530
	private Class512 method_3(Class785 class785_0, bool bool_1)
	{
		Class534.Class837 @class = new Class534.Class837();
		@class.class785_0 = class785_0;
		if (@class.class785_0 == null)
		{
			return null;
		}
		string string_;
		Class195.dictionary_0.TryGetValue(@class.class785_0.method_0(), out string_);
		List<string> list;
		Class195.dictionary_3.TryGetValue(@class.class785_0.method_0(), out list);
		bool boolean_ = Class195.list_1.Any(new Func<string, bool>(@class.method_0));
		Class512 class2 = new Class512(new Class466
		{
			String_0 = @class.class785_0.method_0(),
			String_3 = string_,
			Boolean_0 = false,
			Int32_0 = 1,
			Boolean_1 = boolean_,
			List_0 = ((list == null) ? new List<string>() : list),
			List_1 = new List<string>
			{
				"LEVEL",
				"NOINSTANTAPPLY"
			},
			String_4 = "DOUBLE",
			List_5 = new List<Class245>
			{
				new Class245
				{
					String_0 = "DISM",
					String_1 = @class.class785_0.method_0(),
					List_0 = Class277.smethod_8(@class.class785_0.method_0())
				}
			}
		}, typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TW4LTJ4MDTW787U8ZU6EPEUUSCU2XC89GWA_ejd), false);
		if (!bool_1)
		{
			this.concurrentDictionary_0[@class.class785_0.method_0()] = class2;
		}
		else
		{
			this.concurrentDictionary_1[@class.class785_0.method_0()] = class2;
		}
		return class2;
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x0001C2A2 File Offset: 0x0001A4A2
	private void method_4(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("Tweaks");
	}

	// Token: 0x06002BA1 RID: 11169 RVA: 0x0001C2B0 File Offset: 0x0001A4B0
	private void method_5()
	{
		this.Tweaks.Clear();
	}

	// Token: 0x06002BA2 RID: 11170 RVA: 0x000A749C File Offset: 0x000A569C
	private void method_6()
	{
		Class534.Class836 @class = new Class534.Class836();
		@class.class534_0 = this;
		this.list_0.Clear();
		this.concurrentDictionary_0.Clear();
		this.concurrentDictionary_1.Clear();
		@class.hashSet_0 = new HashSet<string>();
		foreach (Class785 class785_ in Class277.smethod_0())
		{
			this.method_3(class785_, false);
		}
		ParallelOptions parallelOptions = new ParallelOptions
		{
			MaxDegreeOfParallelism = 4
		};
		Parallel.ForEach<KeyValuePair<string, Class512>>(this.concurrentDictionary_0.ToList<KeyValuePair<string, Class512>>(), parallelOptions, new Action<KeyValuePair<string, Class512>>(@class.method_0));
		Dictionary<string, Class512> dictionary = this.concurrentDictionary_0.Concat(this.concurrentDictionary_1).ToDictionary(new Func<KeyValuePair<string, Class512>, string>(Class534.Class838.class838_0.method_0), new Func<KeyValuePair<string, Class512>, Class512>(Class534.Class838.class838_0.method_1));
		foreach (string text in @class.hashSet_0)
		{
			if (text != null)
			{
				dictionary.Remove(text);
			}
		}
		@class.list_0 = new List<Class512>();
		foreach (string key in Class195.list_2)
		{
			Class512 item;
			if (dictionary.TryGetValue(key, out item))
			{
				@class.list_0.Add(item);
				dictionary.Remove(key);
			}
		}
		@class.list_0.AddRange(dictionary.Values);
		this.list_0.AddRange(@class.list_0.Select(new Func<Class512, string>(Class534.Class838.class838_0.method_2)));
		Application.Current.Dispatcher.Invoke(new Action(@class.method_1));
		base.method_0("Tweaks");
	}

	// Token: 0x04001C54 RID: 7252
	private bool bool_0;

	// Token: 0x04001C55 RID: 7253
	public Exception exception_0;

	// Token: 0x04001C56 RID: 7254
	private ObservableCollection<Class512> observableCollection_0 = new ObservableCollection<Class512>();

	// Token: 0x04001C57 RID: 7255
	private readonly List<string> list_0 = new List<string>();

	// Token: 0x04001C58 RID: 7256
	private readonly ConcurrentDictionary<string, Class512> concurrentDictionary_0 = new ConcurrentDictionary<string, Class512>();

	// Token: 0x04001C59 RID: 7257
	private readonly ConcurrentDictionary<string, Class512> concurrentDictionary_1 = new ConcurrentDictionary<string, Class512>();

	// Token: 0x04001C5A RID: 7258
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x020006C0 RID: 1728
	[StructLayout(LayoutKind.Auto)]
	private struct Struct461 : IAsyncStateMachine
	{
		// Token: 0x06002BA3 RID: 11171 RVA: 0x000A76CC File Offset: 0x000A58CC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class534 @class = this.class534_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_74;
					}
					awaiter = Class534.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class534.Struct461>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IL_74:
				try
				{
					if (num != 1)
					{
						@class.FeaturesLoaded = false;
						GClass279.smethod_0().method_16(@class.list_0);
						Application.Current.Dispatcher.Invoke(new Action(@class.method_5));
						awaiter = Task.Run(new Action(@class.method_6)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 1;
							num = 1;
							this.int_0 = num4;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class534.Struct461>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num5 = -1;
						num = -1;
						this.int_0 = num5;
					}
					awaiter.GetResult();
				}
				catch (Exception exception_)
				{
					@class.exception_0 = exception_;
					GClass268.smethod_1(exception_);
				}
				finally
				{
					if (num < 0)
					{
						@class.FeaturesLoaded = true;
						Class534.semaphoreSlim_0.Release();
					}
				}
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

		// Token: 0x06002BA4 RID: 11172 RVA: 0x0001C2BD File Offset: 0x0001A4BD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001C5B RID: 7259
		public int int_0;

		// Token: 0x04001C5C RID: 7260
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001C5D RID: 7261
		public Class534 class534_0;

		// Token: 0x04001C5E RID: 7262
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006C1 RID: 1729
	private sealed class Class836
	{
		// Token: 0x06002BA6 RID: 11174 RVA: 0x000A788C File Offset: 0x000A5A8C
		internal void method_0(KeyValuePair<string, Class512> keyValuePair_0)
		{
			string key = keyValuePair_0.Key;
			Class512 value = keyValuePair_0.Value;
			DismFeatureCollection dismFeatureCollection = Class277.smethod_5(key);
			if (dismFeatureCollection != null && dismFeatureCollection.Any<DismFeature>())
			{
				foreach (DismFeature dismFeature in dismFeatureCollection)
				{
					if (!string.IsNullOrEmpty(dismFeature.FeatureName))
					{
						Class512 @class;
						if (!this.class534_0.concurrentDictionary_0.TryGetValue(dismFeature.FeatureName, out @class))
						{
							Class785 class2 = new Class785();
							class2.method_1(dismFeature.FeatureName);
							class2.State = dismFeature.State.ToString();
							Class785 class3 = class2;
							Class277.list_0.Add(class3);
							@class = this.class534_0.method_3(class3, true);
						}
						value.list_0.Add(@class);
						@class.Childs.Add(value);
					}
				}
				this.hashSet_0.Add(key);
			}
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x0001C2CB File Offset: 0x0001A4CB
		internal void method_1()
		{
			this.class534_0.Tweaks = new ObservableCollection<Class512>(this.list_0);
		}

		// Token: 0x04001C5F RID: 7263
		public HashSet<string> hashSet_0;

		// Token: 0x04001C60 RID: 7264
		public List<Class512> list_0;

		// Token: 0x04001C61 RID: 7265
		public Class534 class534_0;
	}

	// Token: 0x020006C2 RID: 1730
	private sealed class Class837
	{
		// Token: 0x06002BA9 RID: 11177 RVA: 0x0001C2E3 File Offset: 0x0001A4E3
		internal bool method_0(string string_0)
		{
			return string_0 == this.class785_0.method_0();
		}

		// Token: 0x04001C62 RID: 7266
		public Class785 class785_0;
	}

	// Token: 0x020006C3 RID: 1731
	[Serializable]
	private sealed class Class838
	{
		// Token: 0x06002BAC RID: 11180 RVA: 0x0001C302 File Offset: 0x0001A502
		internal string method_0(KeyValuePair<string, Class512> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x0001C30B File Offset: 0x0001A50B
		internal Class512 method_1(KeyValuePair<string, Class512> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x0001C314 File Offset: 0x0001A514
		internal string method_2(Class512 class512_0)
		{
			return class512_0.method_7();
		}

		// Token: 0x04001C63 RID: 7267
		public static readonly Class534.Class838 class838_0 = new Class534.Class838();

		// Token: 0x04001C64 RID: 7268
		public static Func<KeyValuePair<string, Class512>, string> func_0;

		// Token: 0x04001C65 RID: 7269
		public static Func<KeyValuePair<string, Class512>, Class512> func_1;

		// Token: 0x04001C66 RID: 7270
		public static Func<Class512, string> func_2;
	}
}
