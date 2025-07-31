using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Material.Icons;

// Token: 0x02000327 RID: 807
public sealed class GClass179 : GClass162
{
	// Token: 0x060014EA RID: 5354 RVA: 0x00064CFC File Offset: 0x00062EFC
	public GClass179(GClass293 gclass293_1)
	{
		GClass179.Class383 @class = new GClass179.Class383();
		@class.gclass293_0 = gclass293_1;
		base..ctor();
		this.gclass293_0 = @class.gclass293_0;
		this.method_2(@class.gclass293_0.method_6());
		this.observableCollection_0 = new ObservableCollection<GClass171>(@class.gclass293_0.method_8().Select(new Func<GClass86, GClass171>(@class.method_0)));
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x060014EB RID: 5355 RVA: 0x0000E825 File Offset: 0x0000CA25
	public GClass293 Model
	{
		[CompilerGenerated]
		get
		{
			return this.gclass293_0;
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x060014EC RID: 5356 RVA: 0x0000E82D File Offset: 0x0000CA2D
	// (set) Token: 0x060014ED RID: 5357 RVA: 0x0000E835 File Offset: 0x0000CA35
	public MaterialIconKind Icon
	{
		[CompilerGenerated]
		get
		{
			return this.materialIconKind_0;
		}
		[CompilerGenerated]
		set
		{
			this.materialIconKind_0 = value;
		}
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x060014EE RID: 5358 RVA: 0x0000E83E File Offset: 0x0000CA3E
	public string Name
	{
		get
		{
			return this.Model.Name;
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x060014EF RID: 5359 RVA: 0x0000E84B File Offset: 0x0000CA4B
	public ObservableCollection<GClass171> Settings
	{
		[CompilerGenerated]
		get
		{
			return this.observableCollection_0;
		}
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0000E853 File Offset: 0x0000CA53
	public ICommand ApplyCommand
	{
		[CompilerGenerated]
		get
		{
			return this.icommand_0;
		}
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x00064D60 File Offset: 0x00062F60
	private void method_2(string string_0)
	{
		GClass179.Struct174 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass179_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass179.Struct174>(ref @struct);
	}

	// Token: 0x04000DF1 RID: 3569
	private readonly GClass293 gclass293_0;

	// Token: 0x04000DF2 RID: 3570
	private MaterialIconKind materialIconKind_0;

	// Token: 0x04000DF3 RID: 3571
	private readonly ObservableCollection<GClass171> observableCollection_0;

	// Token: 0x04000DF4 RID: 3572
	private readonly ICommand icommand_0;

	// Token: 0x02000328 RID: 808
	[StructLayout(LayoutKind.Auto)]
	private struct Struct174 : IAsyncStateMachine
	{
		// Token: 0x060014F2 RID: 5362 RVA: 0x00064DA0 File Offset: 0x00062FA0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new GClass179.Class385
					{
						string_0 = this.string_0,
						gclass179_0 = this.gclass179_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass179.Struct174>(ref awaiter, ref this);
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

		// Token: 0x060014F3 RID: 5363 RVA: 0x0000E85B File Offset: 0x0000CA5B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000DF5 RID: 3573
		public int int_0;

		// Token: 0x04000DF6 RID: 3574
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000DF7 RID: 3575
		public string string_0;

		// Token: 0x04000DF8 RID: 3576
		public GClass179 gclass179_0;

		// Token: 0x04000DF9 RID: 3577
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000329 RID: 809
	private sealed class Class383
	{
		// Token: 0x060014F5 RID: 5365 RVA: 0x0000E869 File Offset: 0x0000CA69
		internal GClass171 method_0(GClass86 gclass86_0)
		{
			return new GClass171(gclass86_0, this.gclass293_0);
		}

		// Token: 0x04000DFA RID: 3578
		public GClass293 gclass293_0;
	}

	// Token: 0x0200032A RID: 810
	private sealed class Class384
	{
		// Token: 0x060014F7 RID: 5367 RVA: 0x0000E877 File Offset: 0x0000CA77
		internal void method_0(string string_1)
		{
			this.string_0 += string_1.smethod_4();
		}

		// Token: 0x04000DFB RID: 3579
		public string string_0;
	}

	// Token: 0x0200032B RID: 811
	private sealed class Class385
	{
		// Token: 0x060014F9 RID: 5369 RVA: 0x00064E74 File Offset: 0x00063074
		internal void method_0()
		{
			MaterialIconKind icon = 4823;
			try
			{
				if (this.string_0 != null && this.string_0 != string.Empty && this.string_0 != "CHANGE")
				{
					GClass179.Class384 @class = new GClass179.Class384();
					@class.string_0 = string.Empty;
					this.string_0.Split(new char[]
					{
						'-'
					}).ToList<string>().ForEach(new Action<string>(@class.method_0));
					MaterialIconKind materialIconKind;
					if (Enum.TryParse<MaterialIconKind>(@class.string_0, out materialIconKind))
					{
						icon = materialIconKind;
					}
				}
			}
			catch
			{
			}
			this.gclass179_0.Icon = icon;
			this.gclass179_0.method_0("Icon");
		}

		// Token: 0x04000DFC RID: 3580
		public string string_0;

		// Token: 0x04000DFD RID: 3581
		public GClass179 gclass179_0;
	}
}
