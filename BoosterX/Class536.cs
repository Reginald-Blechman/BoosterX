using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using ns0;

// Token: 0x020006E0 RID: 1760
internal sealed class Class536 : GClass162
{
	// Token: 0x06002C2D RID: 11309 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
	public Class536(dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd_1)
	{
		this.dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd_0 = dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd_1;
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		this.method_2();
	}

	// Token: 0x06002C2E RID: 11310 RVA: 0x0001732E File Offset: 0x0001552E
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("ColChande");
	}

	// Token: 0x17000743 RID: 1859
	// (get) Token: 0x06002C2F RID: 11311 RVA: 0x0001C727 File Offset: 0x0001A927
	// (set) Token: 0x06002C30 RID: 11312 RVA: 0x0001C72F File Offset: 0x0001A92F
	public ObservableCollection<Class523> Models
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("Models");
		}
	}

	// Token: 0x17000744 RID: 1860
	// (get) Token: 0x06002C31 RID: 11313 RVA: 0x0001C744 File Offset: 0x0001A944
	// (set) Token: 0x06002C32 RID: 11314 RVA: 0x0001C74C File Offset: 0x0001A94C
	public Class523 Choosen
	{
		get
		{
			return this.class523_0;
		}
		set
		{
			this.class523_0 = value;
			base.method_0("Choosen");
		}
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x000A96D4 File Offset: 0x000A78D4
	private void method_2()
	{
		Class536.Struct469 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class536_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class536.Struct469>(ref @struct);
	}

	// Token: 0x17000745 RID: 1861
	// (get) Token: 0x06002C34 RID: 11316 RVA: 0x000A970C File Offset: 0x000A790C
	public GClass280 NewTestCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_7), null));
			}
			return result;
		}
	}

	// Token: 0x06002C35 RID: 11317 RVA: 0x000A9740 File Offset: 0x000A7940
	private void method_3()
	{
		if (!Directory.Exists(Class169.string_9))
		{
			Directory.CreateDirectory(Class169.string_9);
		}
		Application.Current.Dispatcher.Invoke(new Action(this.method_4));
		string[] files = Directory.GetFiles(Class169.string_9);
		if (files.Count<string>() == 0)
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_5));
			return;
		}
		List<Class609> list = new List<Class609>();
		foreach (string path in files)
		{
			try
			{
				string text = Class868.smethod_1(File.ReadAllText(path));
				list.Add(JsonConvert.DeserializeObject<Class609>(text));
			}
			catch
			{
			}
		}
		if (list.Count<Class609>() == 0)
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_6));
			return;
		}
		using (List<Class609>.Enumerator enumerator = list.OrderByDescending(new Func<Class609, DateTime>(Class536.Class856.class856_0.method_0)).ToList<Class609>().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class536.Class855 @class = new Class536.Class855();
				@class.class536_0 = this;
				@class.class609_0 = enumerator.Current;
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			}
		}
		this.Models.First<Class523>().IsChoosen = true;
	}

	// Token: 0x06002C36 RID: 11318 RVA: 0x0001C761 File Offset: 0x0001A961
	private void method_4()
	{
		this.Models.Clear();
	}

	// Token: 0x06002C37 RID: 11319 RVA: 0x0001C76E File Offset: 0x0001A96E
	private void method_5()
	{
		this.NewTestCommand.Execute(null);
	}

	// Token: 0x06002C38 RID: 11320 RVA: 0x0001C76E File Offset: 0x0001A96E
	private void method_6()
	{
		this.NewTestCommand.Execute(null);
	}

	// Token: 0x06002C39 RID: 11321 RVA: 0x000A98C0 File Offset: 0x000A7AC0
	private void method_7(object object_0)
	{
		Class523 item = new Class523(this.dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd_0.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0, this, null, "Test " + this.Models.Count<Class523>().ToString());
		this.Models.Add(item);
		List<Class523> list = this.Models.OrderByDescending(new Func<Class523, DateTime>(Class536.Class856.class856_0.method_1)).ToList<Class523>();
		this.Models.Clear();
		foreach (Class523 item2 in list)
		{
			this.Models.Add(item2);
		}
		this.Models.First<Class523>().IsChoosen = true;
	}

	// Token: 0x04001CA9 RID: 7337
	private dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd_0;

	// Token: 0x04001CAA RID: 7338
	public byte byte_0;

	// Token: 0x04001CAB RID: 7339
	private ObservableCollection<Class523> observableCollection_0 = new ObservableCollection<Class523>();

	// Token: 0x04001CAC RID: 7340
	private Class523 class523_0;

	// Token: 0x04001CAD RID: 7341
	private GClass280 gclass280_0;

	// Token: 0x020006E1 RID: 1761
	private sealed class Class855
	{
		// Token: 0x06002C3B RID: 11323 RVA: 0x0001C77C File Offset: 0x0001A97C
		internal void method_0()
		{
			this.class536_0.Models.Add(new Class523(this.class536_0.dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd_0.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0, this.class536_0, this.class609_0, string.Empty));
		}

		// Token: 0x04001CAE RID: 7342
		public Class609 class609_0;

		// Token: 0x04001CAF RID: 7343
		public Class536 class536_0;
	}

	// Token: 0x020006E2 RID: 1762
	[StructLayout(LayoutKind.Auto)]
	private struct Struct469 : IAsyncStateMachine
	{
		// Token: 0x06002C3C RID: 11324 RVA: 0x000A999C File Offset: 0x000A7B9C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class536 @object = this.class536_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_3)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class536.Struct469>(ref awaiter, ref this);
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
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x0001C7B4 File Offset: 0x0001A9B4
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001CB0 RID: 7344
		public int int_0;

		// Token: 0x04001CB1 RID: 7345
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001CB2 RID: 7346
		public Class536 class536_0;

		// Token: 0x04001CB3 RID: 7347
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006E3 RID: 1763
	[Serializable]
	private sealed class Class856
	{
		// Token: 0x06002C40 RID: 11328 RVA: 0x0001C7CE File Offset: 0x0001A9CE
		internal DateTime method_0(Class609 class609_0)
		{
			return class609_0.DateTime_0;
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x0001C7D6 File Offset: 0x0001A9D6
		internal DateTime method_1(Class523 class523_0)
		{
			return class523_0.Date;
		}

		// Token: 0x04001CB4 RID: 7348
		public static readonly Class536.Class856 class856_0 = new Class536.Class856();

		// Token: 0x04001CB5 RID: 7349
		public static Func<Class609, DateTime> func_0;

		// Token: 0x04001CB6 RID: 7350
		public static Func<Class523, DateTime> func_1;
	}
}
