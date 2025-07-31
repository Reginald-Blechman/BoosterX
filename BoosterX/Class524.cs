using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

// Token: 0x020005CA RID: 1482
internal sealed class Class524 : GClass162
{
	// Token: 0x06002611 RID: 9745 RVA: 0x00019576 File Offset: 0x00017776
	public Class524()
	{
		this.method_2();
	}

	// Token: 0x1700066D RID: 1645
	// (get) Token: 0x06002612 RID: 9746 RVA: 0x000195B2 File Offset: 0x000177B2
	// (set) Token: 0x06002613 RID: 9747 RVA: 0x000195BA File Offset: 0x000177BA
	public bool IsUser
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			if (!value)
			{
				this.method_3();
			}
			base.method_0("IsUser");
		}
	}

	// Token: 0x1700066E RID: 1646
	// (get) Token: 0x06002614 RID: 9748 RVA: 0x000195D8 File Offset: 0x000177D8
	// (set) Token: 0x06002615 RID: 9749 RVA: 0x000195E0 File Offset: 0x000177E0
	public bool IsGenerating
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			if (value)
			{
				this.method_5();
			}
			else
			{
				this.method_6();
			}
			base.method_0("IsGenerating");
		}
	}

	// Token: 0x1700066F RID: 1647
	// (get) Token: 0x06002616 RID: 9750 RVA: 0x00019606 File Offset: 0x00017806
	// (set) Token: 0x06002617 RID: 9751 RVA: 0x0001960E File Offset: 0x0001780E
	public bool IsSystemMessage
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
			base.method_0("IsSystemMessage");
		}
	}

	// Token: 0x17000670 RID: 1648
	// (get) Token: 0x06002618 RID: 9752 RVA: 0x00019623 File Offset: 0x00017823
	// (set) Token: 0x06002619 RID: 9753 RVA: 0x0001962B File Offset: 0x0001782B
	public bool IsMessageOnWrite
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
			base.method_0("IsMessageOnWrite");
		}
	}

	// Token: 0x17000671 RID: 1649
	// (get) Token: 0x0600261A RID: 9754 RVA: 0x00019640 File Offset: 0x00017840
	// (set) Token: 0x0600261B RID: 9755 RVA: 0x00019648 File Offset: 0x00017848
	public string Message
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("Message");
		}
	}

	// Token: 0x17000672 RID: 1650
	// (get) Token: 0x0600261C RID: 9756 RVA: 0x0001965D File Offset: 0x0001785D
	// (set) Token: 0x0600261D RID: 9757 RVA: 0x00019665 File Offset: 0x00017865
	public BitmapImage MessageImage
	{
		get
		{
			return this.bitmapImage_0;
		}
		set
		{
			this.bitmapImage_0 = value;
			base.method_0("MessageImage");
		}
	}

	// Token: 0x17000673 RID: 1651
	// (get) Token: 0x0600261E RID: 9758 RVA: 0x0001967A File Offset: 0x0001787A
	// (set) Token: 0x0600261F RID: 9759 RVA: 0x00019682 File Offset: 0x00017882
	public Visibility HasMessageImage
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("HasMessageImage");
		}
	}

	// Token: 0x17000674 RID: 1652
	// (get) Token: 0x06002620 RID: 9760 RVA: 0x00019697 File Offset: 0x00017897
	// (set) Token: 0x06002621 RID: 9761 RVA: 0x0001969F File Offset: 0x0001789F
	public Visibility HasTweak
	{
		get
		{
			return this.visibility_1;
		}
		set
		{
			this.visibility_1 = value;
			base.method_0("HasTweak");
		}
	}

	// Token: 0x17000675 RID: 1653
	// (get) Token: 0x06002622 RID: 9762 RVA: 0x000196B4 File Offset: 0x000178B4
	// (set) Token: 0x06002623 RID: 9763 RVA: 0x000196BC File Offset: 0x000178BC
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

	// Token: 0x17000676 RID: 1654
	// (get) Token: 0x06002624 RID: 9764 RVA: 0x000196D1 File Offset: 0x000178D1
	// (set) Token: 0x06002625 RID: 9765 RVA: 0x000196D9 File Offset: 0x000178D9
	public Visibility TypingVisiblity
	{
		get
		{
			return this.visibility_2;
		}
		set
		{
			this.visibility_2 = value;
			base.method_0("TypingVisiblity");
		}
	}

	// Token: 0x17000677 RID: 1655
	// (get) Token: 0x06002626 RID: 9766 RVA: 0x000196EE File Offset: 0x000178EE
	// (set) Token: 0x06002627 RID: 9767 RVA: 0x000196F6 File Offset: 0x000178F6
	public double TypingOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("TypingOpacity");
		}
	}

	// Token: 0x17000678 RID: 1656
	// (get) Token: 0x06002628 RID: 9768 RVA: 0x0001970B File Offset: 0x0001790B
	// (set) Token: 0x06002629 RID: 9769 RVA: 0x00019713 File Offset: 0x00017913
	public Visibility GenVisiblity
	{
		get
		{
			return this.visibility_3;
		}
		set
		{
			this.visibility_3 = value;
			base.method_0("GenVisiblity");
		}
	}

	// Token: 0x17000679 RID: 1657
	// (get) Token: 0x0600262A RID: 9770 RVA: 0x00019728 File Offset: 0x00017928
	// (set) Token: 0x0600262B RID: 9771 RVA: 0x00019730 File Offset: 0x00017930
	public double GenOpacity
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("GenOpacity");
		}
	}

	// Token: 0x1700067A RID: 1658
	// (get) Token: 0x0600262C RID: 9772 RVA: 0x00019745 File Offset: 0x00017945
	// (set) Token: 0x0600262D RID: 9773 RVA: 0x0001974D File Offset: 0x0001794D
	public double MainOpacity
	{
		get
		{
			return this.double_2;
		}
		set
		{
			this.double_2 = value;
			base.method_0("MainOpacity");
		}
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x000925AC File Offset: 0x000907AC
	private void method_2()
	{
		Class524.Struct391 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class524_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class524.Struct391>(ref @struct);
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x000925E4 File Offset: 0x000907E4
	private void method_3()
	{
		Class524.Struct389 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class524_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class524.Struct389>(ref @struct);
	}

	// Token: 0x06002630 RID: 9776 RVA: 0x0009261C File Offset: 0x0009081C
	private void method_4()
	{
		Class524.Struct394 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class524_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class524.Struct394>(ref @struct);
	}

	// Token: 0x06002631 RID: 9777 RVA: 0x00092654 File Offset: 0x00090854
	private void method_5()
	{
		Class524.Struct395 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class524_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class524.Struct395>(ref @struct);
	}

	// Token: 0x06002632 RID: 9778 RVA: 0x00019762 File Offset: 0x00017962
	private void method_6()
	{
		this.GenVisiblity = Visibility.Collapsed;
		this.GenOpacity = 0.0;
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x0009268C File Offset: 0x0009088C
	private Task method_7()
	{
		Class524.Struct393 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class524_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class524.Struct393>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002634 RID: 9780 RVA: 0x000926D0 File Offset: 0x000908D0
	private Task method_8()
	{
		Class524.Struct392 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class524_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class524.Struct392>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002635 RID: 9781 RVA: 0x00092714 File Offset: 0x00090914
	private Task method_9()
	{
		Class524.Struct390 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class524_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class524.Struct390>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x040018F7 RID: 6391
	private bool bool_0;

	// Token: 0x040018F8 RID: 6392
	private bool bool_1;

	// Token: 0x040018F9 RID: 6393
	private bool bool_2;

	// Token: 0x040018FA RID: 6394
	private bool bool_3 = true;

	// Token: 0x040018FB RID: 6395
	private string string_0;

	// Token: 0x040018FC RID: 6396
	private BitmapImage bitmapImage_0;

	// Token: 0x040018FD RID: 6397
	private Visibility visibility_0 = Visibility.Collapsed;

	// Token: 0x040018FE RID: 6398
	private Visibility visibility_1 = Visibility.Collapsed;

	// Token: 0x040018FF RID: 6399
	private ObservableCollection<Class512> observableCollection_0 = new ObservableCollection<Class512>();

	// Token: 0x04001900 RID: 6400
	private Visibility visibility_2 = Visibility.Collapsed;

	// Token: 0x04001901 RID: 6401
	private double double_0;

	// Token: 0x04001902 RID: 6402
	private Visibility visibility_3 = Visibility.Collapsed;

	// Token: 0x04001903 RID: 6403
	private double double_1;

	// Token: 0x04001904 RID: 6404
	private double double_2;

	// Token: 0x020005CB RID: 1483
	[StructLayout(LayoutKind.Auto)]
	private struct Struct389 : IAsyncStateMachine
	{
		// Token: 0x06002636 RID: 9782 RVA: 0x00092758 File Offset: 0x00090958
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class524 @object = this.class524_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_7)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class524.Struct389>(ref awaiter, ref this);
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

		// Token: 0x06002637 RID: 9783 RVA: 0x0001977A File Offset: 0x0001797A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001905 RID: 6405
		public int int_0;

		// Token: 0x04001906 RID: 6406
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001907 RID: 6407
		public Class524 class524_0;

		// Token: 0x04001908 RID: 6408
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005CC RID: 1484
	[StructLayout(LayoutKind.Auto)]
	private struct Struct390 : IAsyncStateMachine
	{
		// Token: 0x06002638 RID: 9784 RVA: 0x00092818 File Offset: 0x00090A18
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class524 @class = this.class524_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_97;
				}
				@class.GenVisiblity = Visibility.Visible;
				IL_38:
				if (@class.GenOpacity == 1.0)
				{
					goto IL_D9;
				}
				@class.GenOpacity += 0.13333333333333333;
				if (@class.GenOpacity > 0.95)
				{
					@class.GenOpacity = 1.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class524.Struct390>(ref awaiter, ref this);
					return;
				}
				IL_97:
				awaiter.GetResult();
				goto IL_38;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_D9:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00019788 File Offset: 0x00017988
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001909 RID: 6409
		public int int_0;

		// Token: 0x0400190A RID: 6410
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400190B RID: 6411
		public Class524 class524_0;

		// Token: 0x0400190C RID: 6412
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005CD RID: 1485
	[StructLayout(LayoutKind.Auto)]
	private struct Struct391 : IAsyncStateMachine
	{
		// Token: 0x0600263A RID: 9786 RVA: 0x00092924 File Offset: 0x00090B24
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class524 @class = this.class524_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_8E;
				}
				IL_2F:
				if (@class.MainOpacity == 1.0)
				{
					goto IL_D0;
				}
				@class.MainOpacity += 0.13333333333333333;
				if (@class.MainOpacity > 0.95)
				{
					@class.MainOpacity = 1.0;
				}
				awaiter = Task.Delay(40).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class524.Struct391>(ref awaiter, ref this);
					return;
				}
				IL_8E:
				awaiter.GetResult();
				goto IL_2F;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_D0:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00019796 File Offset: 0x00017996
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400190D RID: 6413
		public int int_0;

		// Token: 0x0400190E RID: 6414
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400190F RID: 6415
		public Class524 class524_0;

		// Token: 0x04001910 RID: 6416
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005CE RID: 1486
	[StructLayout(LayoutKind.Auto)]
	private struct Struct392 : IAsyncStateMachine
	{
		// Token: 0x0600263C RID: 9788 RVA: 0x00092A24 File Offset: 0x00090C24
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class524 @class = this.class524_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_8E;
				}
				IL_2F:
				if (@class.TypingOpacity == 1.0)
				{
					goto IL_D0;
				}
				@class.TypingOpacity += 0.13333333333333333;
				if (@class.TypingOpacity > 0.95)
				{
					@class.TypingOpacity = 1.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class524.Struct392>(ref awaiter, ref this);
					return;
				}
				IL_8E:
				awaiter.GetResult();
				goto IL_2F;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_D0:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000197A4 File Offset: 0x000179A4
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001911 RID: 6417
		public int int_0;

		// Token: 0x04001912 RID: 6418
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001913 RID: 6419
		public Class524 class524_0;

		// Token: 0x04001914 RID: 6420
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005CF RID: 1487
	[StructLayout(LayoutKind.Auto)]
	private struct Struct393 : IAsyncStateMachine
	{
		// Token: 0x0600263E RID: 9790 RVA: 0x00092B24 File Offset: 0x00090D24
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class524 @class = this.class524_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_62;
				}
				@class.method_4();
				IL_37:
				if (!@class.Message.smethod_9())
				{
					@class.TypingVisiblity = Visibility.Collapsed;
					@class.TypingOpacity = 0.0;
					goto IL_BC;
				}
				if (@class.IsGenerating)
				{
					goto IL_BC;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class524.Struct393>(ref awaiter, ref this);
					return;
				}
				IL_62:
				awaiter.GetResult();
				goto IL_37;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_BC:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000197B2 File Offset: 0x000179B2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001915 RID: 6421
		public int int_0;

		// Token: 0x04001916 RID: 6422
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001917 RID: 6423
		public Class524 class524_0;

		// Token: 0x04001918 RID: 6424
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005D0 RID: 1488
	[StructLayout(LayoutKind.Auto)]
	private struct Struct394 : IAsyncStateMachine
	{
		// Token: 0x06002640 RID: 9792 RVA: 0x00092C10 File Offset: 0x00090E10
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class524 @class = this.class524_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.TypingVisiblity = Visibility.Visible;
					awaiter = Task.Run(new Func<Task>(@class.method_8)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class524.Struct394>(ref awaiter, ref this);
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

		// Token: 0x06002641 RID: 9793 RVA: 0x000197C0 File Offset: 0x000179C0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001919 RID: 6425
		public int int_0;

		// Token: 0x0400191A RID: 6426
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400191B RID: 6427
		public Class524 class524_0;

		// Token: 0x0400191C RID: 6428
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005D1 RID: 1489
	[StructLayout(LayoutKind.Auto)]
	private struct Struct395 : IAsyncStateMachine
	{
		// Token: 0x06002642 RID: 9794 RVA: 0x00092CD4 File Offset: 0x00090ED4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class524 @object = this.class524_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_9)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class524.Struct395>(ref awaiter, ref this);
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

		// Token: 0x06002643 RID: 9795 RVA: 0x000197CE File Offset: 0x000179CE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400191D RID: 6429
		public int int_0;

		// Token: 0x0400191E RID: 6430
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400191F RID: 6431
		public Class524 class524_0;

		// Token: 0x04001920 RID: 6432
		private TaskAwaiter taskAwaiter_0;
	}
}
