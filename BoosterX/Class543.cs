using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ns0;

// Token: 0x0200046E RID: 1134
internal sealed class Class543
{
	// Token: 0x06001D80 RID: 7552 RVA: 0x0001387F File Offset: 0x00011A7F
	public Class543(dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_1)
	{
		this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0 = dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_1;
		this.list_0 = Class211.smethod_0();
		this.method_2(true);
	}

	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0007A5A8 File Offset: 0x000787A8
	public GClass280 RedButton
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_15), null));
			}
			return result;
		}
	}

	// Token: 0x1700050B RID: 1291
	// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0007A5DC File Offset: 0x000787DC
	public GClass280 MainButton
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_16), null));
			}
			return result;
		}
	}

	// Token: 0x1700050C RID: 1292
	// (get) Token: 0x06001D83 RID: 7555 RVA: 0x0007A610 File Offset: 0x00078810
	public GClass280 BackButton
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_2) == null)
			{
				result = (this.gclass280_2 = new GClass280(new Action<object>(this.method_17), null));
			}
			return result;
		}
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x0007A644 File Offset: 0x00078844
	public Image method_0()
	{
		if (this.image_0 == null)
		{
			this.image_0 = this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.image_0;
		}
		Image result = this.image_0;
		this.bool_0 = !this.bool_0;
		this.image_0 = (this.bool_0 ? this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.image_1 : this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.image_0);
		return result;
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x0007A6A8 File Offset: 0x000788A8
	public Image method_1()
	{
		if (this.image_1 == null)
		{
			this.image_1 = this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.image_0;
		}
		Image result = this.image_1;
		this.bool_1 = !this.bool_1;
		this.image_1 = (this.bool_1 ? this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.image_1 : this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.image_0);
		return result;
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x0007A70C File Offset: 0x0007890C
	private void method_2(bool bool_3)
	{
		Class543.Struct295 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class543_0 = this;
		@struct.bool_0 = bool_3;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct295>(ref @struct);
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x0007A74C File Offset: 0x0007894C
	private void method_3()
	{
		Class543.Struct294 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class543_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct294>(ref @struct);
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x0007A784 File Offset: 0x00078984
	private void method_4()
	{
		Class543.Struct292 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class543_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct292>(ref @struct);
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x0007A7BC File Offset: 0x000789BC
	private void method_5()
	{
		Class543.Struct300 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class543_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct300>(ref @struct);
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x0007A7F4 File Offset: 0x000789F4
	private void method_6()
	{
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_12(this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.textBlock_4, this.list_0[this.int_0].MainButton, this.timeSpan_0);
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_12(this.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.textBlock_3, this.list_0[this.int_0].RedButton, this.timeSpan_0);
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x0007A85C File Offset: 0x00078A5C
	private void method_7()
	{
		Class543.Struct298 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct298>(ref @struct);
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x0007A88C File Offset: 0x00078A8C
	private void method_8()
	{
		Class543.Struct297 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct297>(ref @struct);
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x0007A8BC File Offset: 0x00078ABC
	private void method_9()
	{
		Class543.Struct293 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class543_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct293>(ref @struct);
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x0007A8F4 File Offset: 0x00078AF4
	private void method_10()
	{
		Class543.Struct299 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class543_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct299>(ref @struct);
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x0007A92C File Offset: 0x00078B2C
	private void method_11()
	{
		Class543.Struct296 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class543_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct296>(ref @struct);
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x0007A964 File Offset: 0x00078B64
	private void method_12()
	{
		Class543.Struct291 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class543_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class543.Struct291>(ref @struct);
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x000138BB File Offset: 0x00011ABB
	private void method_13()
	{
		Class144.class543_0 = this;
		Class144.bool_0 = true;
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x0007A99C File Offset: 0x00078B9C
	public Class521 method_14(string string_0)
	{
		Class543.Class544 @class = new Class543.Class544();
		@class.string_0 = string_0;
		return this.list_0.Find(new Predicate<Class521>(@class.method_0));
	}

	// Token: 0x06001D93 RID: 7571 RVA: 0x000138C9 File Offset: 0x00011AC9
	private void method_15(object object_0)
	{
		if (this.bool_2)
		{
			return;
		}
		this.method_2(false);
	}

	// Token: 0x06001D94 RID: 7572 RVA: 0x000138DB File Offset: 0x00011ADB
	private void method_16(object object_0)
	{
		if (this.bool_2)
		{
			return;
		}
		this.method_2(true);
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x000138ED File Offset: 0x00011AED
	private void method_17(object object_0)
	{
		if (this.bool_2)
		{
			return;
		}
		this.method_3();
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x000138FE File Offset: 0x00011AFE
	private void method_18()
	{
		Application.Current.Dispatcher.Invoke(new Action(this.method_19));
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x0007A9D0 File Offset: 0x00078BD0
	private void method_19()
	{
		Image image = this.method_1();
		image.Source = new BitmapImage(new Uri("pack://application:,,," + this.list_0[this.int_0].Image));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_32(image, TimeSpan.FromSeconds(0.25), new Thickness(320.0, 0.0, 0.0, 0.0), new Thickness(0.0, 0.0, 0.0, 0.0));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_19(image, TimeSpan.FromSeconds(0.25));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(image, TimeSpan.FromSeconds(0.25), FrameworkElement.WidthProperty, 300.0);
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x0007AABC File Offset: 0x00078CBC
	private void method_20()
	{
		Image uielement_ = this.method_0();
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_32(uielement_, TimeSpan.FromSeconds(0.25), new Thickness(0.0, 0.0, 0.0, 0.0), new Thickness(0.0, 0.0, 320.0, 0.0));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_13(uielement_, TimeSpan.FromSeconds(0.25));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(uielement_, TimeSpan.FromSeconds(0.25), FrameworkElement.WidthProperty, 100.0);
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x0001391B File Offset: 0x00011B1B
	private void method_21()
	{
		Application.Current.Dispatcher.Invoke(new Action(this.method_22));
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x0007AB74 File Offset: 0x00078D74
	private void method_22()
	{
		Image image = this.method_1();
		image.Source = new BitmapImage(new Uri("pack://application:,,," + this.list_0[this.int_0].Image));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_32(image, TimeSpan.FromSeconds(0.25), new Thickness(0.0, 0.0, 320.0, 0.0), new Thickness(0.0, 0.0, 0.0, 0.0));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_19(image, TimeSpan.FromSeconds(0.25));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(image, TimeSpan.FromSeconds(0.25), FrameworkElement.WidthProperty, 300.0);
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x0007AC60 File Offset: 0x00078E60
	private void method_23()
	{
		Image uielement_ = this.method_0();
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_32(uielement_, TimeSpan.FromSeconds(0.25), new Thickness(0.0, 0.0, 0.0, 0.0), new Thickness(320.0, 0.0, 0.0, 0.0));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_13(uielement_, TimeSpan.FromSeconds(0.25));
		dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(uielement_, TimeSpan.FromSeconds(0.25), FrameworkElement.WidthProperty, 100.0);
	}

	// Token: 0x0400139F RID: 5023
	private dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0;

	// Token: 0x040013A0 RID: 5024
	private List<Class521> list_0;

	// Token: 0x040013A1 RID: 5025
	private GClass280 gclass280_0;

	// Token: 0x040013A2 RID: 5026
	private GClass280 gclass280_1;

	// Token: 0x040013A3 RID: 5027
	private GClass280 gclass280_2;

	// Token: 0x040013A4 RID: 5028
	private int int_0 = -1;

	// Token: 0x040013A5 RID: 5029
	private bool bool_0;

	// Token: 0x040013A6 RID: 5030
	private Image image_0;

	// Token: 0x040013A7 RID: 5031
	private bool bool_1;

	// Token: 0x040013A8 RID: 5032
	private Image image_1;

	// Token: 0x040013A9 RID: 5033
	private bool bool_2;

	// Token: 0x040013AA RID: 5034
	private TimeSpan timeSpan_0 = TimeSpan.FromSeconds(0.2);

	// Token: 0x0200046F RID: 1135
	[StructLayout(LayoutKind.Auto)]
	private struct Struct291 : IAsyncStateMachine
	{
		// Token: 0x06001D9C RID: 7580 RVA: 0x0007AD18 File Offset: 0x00078F18
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class543 @object = this.class543_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_23)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct291>(ref awaiter, ref this);
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

		// Token: 0x06001D9D RID: 7581 RVA: 0x00013938 File Offset: 0x00011B38
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013AB RID: 5035
		public int int_0;

		// Token: 0x040013AC RID: 5036
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013AD RID: 5037
		public Class543 class543_0;

		// Token: 0x040013AE RID: 5038
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000470 RID: 1136
	[StructLayout(LayoutKind.Auto)]
	private struct Struct292 : IAsyncStateMachine
	{
		// Token: 0x06001D9E RID: 7582 RVA: 0x0007ADD8 File Offset: 0x00078FD8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class543 @class = this.class543_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_129;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1AE;
				default:
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_12(@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.textBlock_0, @class.list_0[@class.int_0].Question, @class.timeSpan_0);
					awaiter = Task.Delay(50).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct292>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_12(@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.textBlock_1, @class.list_0[@class.int_0].Description, @class.timeSpan_0);
				awaiter = Task.Delay(50).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct292>(ref awaiter, ref this);
					return;
				}
				IL_129:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_12(@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.textBlock_2, @class.list_0[@class.int_0].Nuance, @class.timeSpan_0);
				awaiter = Task.Delay(50).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct292>(ref awaiter, ref this);
					return;
				}
				IL_1AE:
				awaiter.GetResult();
				@class.method_6();
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

		// Token: 0x06001D9F RID: 7583 RVA: 0x00013946 File Offset: 0x00011B46
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013AF RID: 5039
		public int int_0;

		// Token: 0x040013B0 RID: 5040
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013B1 RID: 5041
		public Class543 class543_0;

		// Token: 0x040013B2 RID: 5042
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000471 RID: 1137
	[StructLayout(LayoutKind.Auto)]
	private struct Struct293 : IAsyncStateMachine
	{
		// Token: 0x06001DA0 RID: 7584 RVA: 0x0007AFE8 File Offset: 0x000791E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class543 @object = this.class543_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_18)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct293>(ref awaiter, ref this);
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

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00013954 File Offset: 0x00011B54
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013B3 RID: 5043
		public int int_0;

		// Token: 0x040013B4 RID: 5044
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013B5 RID: 5045
		public Class543 class543_0;

		// Token: 0x040013B6 RID: 5046
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000472 RID: 1138
	[StructLayout(LayoutKind.Auto)]
	private struct Struct294 : IAsyncStateMachine
	{
		// Token: 0x06001DA2 RID: 7586 RVA: 0x0007B0A8 File Offset: 0x000792A8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class543 @class = this.class543_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_2 = true;
					@class.int_0--;
					if (@class.int_0 == -1)
					{
						Application.Current.Dispatcher.Invoke(new Action(Class543.Class545.class545_0.method_1));
						goto IL_12E;
					}
					if (!@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.button_1.IsEnabled)
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.button_1, 100);
						@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.button_1.IsEnabled = true;
					}
					@class.method_12();
					@class.method_5();
					@class.method_11();
					@class.method_8();
					awaiter = Task.Delay(400).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct294>(ref awaiter, ref this);
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
				@class.bool_2 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_12E:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00013962 File Offset: 0x00011B62
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013B7 RID: 5047
		public int int_0;

		// Token: 0x040013B8 RID: 5048
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013B9 RID: 5049
		public Class543 class543_0;

		// Token: 0x040013BA RID: 5050
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000473 RID: 1139
	[StructLayout(LayoutKind.Auto)]
	private struct Struct295 : IAsyncStateMachine
	{
		// Token: 0x06001DA4 RID: 7588 RVA: 0x0007B214 File Offset: 0x00079414
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class543 @class = this.class543_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_2 = true;
					if (@class.int_0 == @class.list_0.Count<Class521>() - 1)
					{
						Application.Current.Dispatcher.Invoke(new Action(Class543.Class545.class545_0.method_0));
						goto IL_1C3;
					}
					if (@class.int_0 != -1)
					{
						@class.list_0[@class.int_0].IsChecked = this.bool_0;
					}
					@class.int_0++;
					if (@class.int_0 != @class.list_0.Count<Class521>() - 1 && @class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.button_1.Opacity == 0.0)
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.button_1, 100);
						@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.button_1.IsEnabled = true;
					}
					if (@class.int_0 == @class.list_0.Count<Class521>() - 1)
					{
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_14(@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.button_1, 100);
						@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.button_1.IsEnabled = false;
						@class.method_13();
					}
					if (@class.int_0 != 0)
					{
						@class.method_10();
					}
					@class.method_4();
					@class.method_9();
					@class.method_7();
					awaiter = Task.Delay(400).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct295>(ref awaiter, ref this);
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
				@class.bool_2 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1C3:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00013970 File Offset: 0x00011B70
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013BB RID: 5051
		public int int_0;

		// Token: 0x040013BC RID: 5052
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013BD RID: 5053
		public Class543 class543_0;

		// Token: 0x040013BE RID: 5054
		public bool bool_0;

		// Token: 0x040013BF RID: 5055
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000474 RID: 1140
	[StructLayout(LayoutKind.Auto)]
	private struct Struct296 : IAsyncStateMachine
	{
		// Token: 0x06001DA6 RID: 7590 RVA: 0x0007B414 File Offset: 0x00079614
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class543 @object = this.class543_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_21)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct296>(ref awaiter, ref this);
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

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0001397E File Offset: 0x00011B7E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013C0 RID: 5056
		public int int_0;

		// Token: 0x040013C1 RID: 5057
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013C2 RID: 5058
		public Class543 class543_0;

		// Token: 0x040013C3 RID: 5059
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000475 RID: 1141
	[StructLayout(LayoutKind.Auto)]
	private struct Struct297 : IAsyncStateMachine
	{
		// Token: 0x06001DA8 RID: 7592 RVA: 0x0007B4D4 File Offset: 0x000796D4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class543.Class545.class545_0.method_3)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct297>(ref awaiter, ref this);
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

		// Token: 0x06001DA9 RID: 7593 RVA: 0x0001398C File Offset: 0x00011B8C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013C4 RID: 5060
		public int int_0;

		// Token: 0x040013C5 RID: 5061
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013C6 RID: 5062
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000476 RID: 1142
	[StructLayout(LayoutKind.Auto)]
	private struct Struct298 : IAsyncStateMachine
	{
		// Token: 0x06001DAA RID: 7594 RVA: 0x0007B5A0 File Offset: 0x000797A0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class543.Class545.class545_0.method_2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct298>(ref awaiter, ref this);
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

		// Token: 0x06001DAB RID: 7595 RVA: 0x0001399A File Offset: 0x00011B9A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013C7 RID: 5063
		public int int_0;

		// Token: 0x040013C8 RID: 5064
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013C9 RID: 5065
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000477 RID: 1143
	[StructLayout(LayoutKind.Auto)]
	private struct Struct299 : IAsyncStateMachine
	{
		// Token: 0x06001DAC RID: 7596 RVA: 0x0007B66C File Offset: 0x0007986C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class543 @object = this.class543_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_20)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct299>(ref awaiter, ref this);
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

		// Token: 0x06001DAD RID: 7597 RVA: 0x000139A8 File Offset: 0x00011BA8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013CA RID: 5066
		public int int_0;

		// Token: 0x040013CB RID: 5067
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013CC RID: 5068
		public Class543 class543_0;

		// Token: 0x040013CD RID: 5069
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000478 RID: 1144
	[StructLayout(LayoutKind.Auto)]
	private struct Struct300 : IAsyncStateMachine
	{
		// Token: 0x06001DAE RID: 7598 RVA: 0x0007B72C File Offset: 0x0007992C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class543 @class = this.class543_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_103;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_188;
				default:
					@class.method_6();
					awaiter = Task.Delay(50).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct300>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_12(@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.textBlock_2, @class.list_0[@class.int_0].Nuance, @class.timeSpan_0);
				awaiter = Task.Delay(50).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct300>(ref awaiter, ref this);
					return;
				}
				IL_103:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_12(@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.textBlock_1, @class.list_0[@class.int_0].Description, @class.timeSpan_0);
				awaiter = Task.Delay(50).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class543.Struct300>(ref awaiter, ref this);
					return;
				}
				IL_188:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_12(@class.dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd_0.textBlock_0, @class.list_0[@class.int_0].Question, @class.timeSpan_0);
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

		// Token: 0x06001DAF RID: 7599 RVA: 0x000139B6 File Offset: 0x00011BB6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040013CE RID: 5070
		public int int_0;

		// Token: 0x040013CF RID: 5071
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040013D0 RID: 5072
		public Class543 class543_0;

		// Token: 0x040013D1 RID: 5073
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000479 RID: 1145
	private sealed class Class544
	{
		// Token: 0x06001DB1 RID: 7601 RVA: 0x000139C4 File Offset: 0x00011BC4
		internal bool method_0(Class521 class521_0)
		{
			return class521_0.Name == this.string_0;
		}

		// Token: 0x040013D2 RID: 5074
		public string string_0;
	}

	// Token: 0x0200047A RID: 1146
	[Serializable]
	private sealed class Class545
	{
		// Token: 0x06001DB4 RID: 7604 RVA: 0x000139E3 File Offset: 0x00011BE3
		internal void method_0()
		{
			Class406.smethod_0().method_4(typeof(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00013A03 File Offset: 0x00011C03
		internal void method_1()
		{
			Class406.smethod_0().method_4(typeof(dje_z2U4VFJ976E33722KXX6TXFGEZTMUX3T7ZZ6XDCSJNRTXBAQ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x0000311B File Offset: 0x0000131B
		internal void method_2()
		{
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0000311B File Offset: 0x0000131B
		internal void method_3()
		{
		}

		// Token: 0x040013D3 RID: 5075
		public static readonly Class543.Class545 class545_0 = new Class543.Class545();

		// Token: 0x040013D4 RID: 5076
		public static Action action_0;

		// Token: 0x040013D5 RID: 5077
		public static Action action_1;

		// Token: 0x040013D6 RID: 5078
		public static Action action_2;

		// Token: 0x040013D7 RID: 5079
		public static Action action_3;
	}
}
