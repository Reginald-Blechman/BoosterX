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
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;

// Token: 0x02000578 RID: 1400
internal sealed class Class522 : GClass162
{
	// Token: 0x06002333 RID: 9011 RVA: 0x0008ACD4 File Offset: 0x00088ED4
	public Class522(dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd_1)
	{
		this.dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd_0 = dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd_1;
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		this.method_2();
	}

	// Token: 0x06002334 RID: 9012 RVA: 0x0001732E File Offset: 0x0001552E
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("ColChande");
	}

	// Token: 0x170005E4 RID: 1508
	// (get) Token: 0x06002335 RID: 9013 RVA: 0x0001733C File Offset: 0x0001553C
	// (set) Token: 0x06002336 RID: 9014 RVA: 0x00017344 File Offset: 0x00015544
	public ObservableCollection<Class529> Models
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

	// Token: 0x170005E5 RID: 1509
	// (get) Token: 0x06002337 RID: 9015 RVA: 0x00017359 File Offset: 0x00015559
	// (set) Token: 0x06002338 RID: 9016 RVA: 0x00017361 File Offset: 0x00015561
	public Class529 Choosen
	{
		get
		{
			return this.class529_0;
		}
		set
		{
			this.class529_0 = value;
			base.method_0("Choosen");
		}
	}

	// Token: 0x06002339 RID: 9017 RVA: 0x0008AD24 File Offset: 0x00088F24
	private void method_2()
	{
		Class522.Struct361 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class522_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class522.Struct361>(ref @struct);
	}

	// Token: 0x170005E6 RID: 1510
	// (get) Token: 0x0600233A RID: 9018 RVA: 0x0008AD5C File Offset: 0x00088F5C
	public GClass280 NewTestCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_11), null));
			}
			return result;
		}
	}

	// Token: 0x170005E7 RID: 1511
	// (get) Token: 0x0600233B RID: 9019 RVA: 0x0008AD90 File Offset: 0x00088F90
	// (set) Token: 0x0600233C RID: 9020 RVA: 0x00017376 File Offset: 0x00015576
	public PlotModel BarChartModel
	{
		get
		{
			if (this.plotModel_0 == null)
			{
				this.plotModel_0 = new PlotModel
				{
					DefaultFontSize = 16.0,
					IsLegendVisible = true,
					PlotAreaBorderThickness = new OxyThickness(0.0)
				};
			}
			return this.plotModel_0;
		}
		set
		{
			this.plotModel_0 = value;
			base.method_0("BarChartModel");
		}
	}

	// Token: 0x0600233D RID: 9021 RVA: 0x0008ADE0 File Offset: 0x00088FE0
	private void method_3()
	{
		this.BarChartModel.Axes.Clear();
		this.BarChartModel.Series.Clear();
		BarSeries barSeries = new BarSeries
		{
			Title = "Avg",
			IsStacked = false,
			LabelPlacement = 1,
			LabelMargin = 10.0,
			FillColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_6(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRFTDSNNMSNMN6WA_ejd),
			LabelFormatString = "{0:.00} ms",
			FontWeight = 700.0
		};
		BarSeries barSeries2 = new BarSeries
		{
			Title = "Min",
			IsStacked = false,
			LabelPlacement = 1,
			LabelMargin = 10.0,
			FillColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_6(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zH2C6P3HHD4TV29CYHNS73_ejd),
			LabelFormatString = "{0:.00} ms",
			FontWeight = 700.0
		};
		BarSeries barSeries3 = new BarSeries
		{
			Title = "Max",
			IsStacked = false,
			LabelPlacement = 1,
			LabelMargin = 10.0,
			FillColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_6(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zKUGX8VZG8GQJ6GA_ejd),
			LabelFormatString = "{0:.00} ms",
			FontWeight = 700.0
		};
		CategoryAxis categoryAxis = new CategoryAxis
		{
			Position = 1,
			TextColor = OxyColors.White,
			FontWeight = 700.0,
			Font = "Jost",
			FontSize = 16.0,
			MinorTickSize = 0.0,
			MajorTickSize = 0.0
		};
		LinearAxis linearAxis = new LinearAxis
		{
			Position = 4,
			MinimumPadding = 0.0,
			MaximumPadding = 0.0,
			TextColor = OxyColors.White,
			FontWeight = 700.0,
			Font = "Jost",
			FontSize = 16.0,
			MinorTickSize = 0.0,
			MajorTickSize = 0.0,
			IsAxisVisible = false
		};
		foreach (Class529 @class in this.list_0)
		{
			categoryAxis.Labels.Add(@class.Name);
			barSeries.Items.Add(new BarItem(@class.Average, -1));
			barSeries2.Items.Add(new BarItem(@class.Min, -1));
			barSeries3.Items.Add(new BarItem(@class.Max, -1));
		}
		this.BarChartModel.Series.Add(barSeries3);
		this.BarChartModel.Series.Add(barSeries2);
		this.BarChartModel.Series.Add(barSeries);
		this.BarChartModel.Axes.Add(categoryAxis);
		this.BarChartModel.Axes.Add(linearAxis);
		this.BarChartModel.Legends.Add(new Legend
		{
			IsLegendVisible = true,
			LegendPosition = 1,
			LegendOrientation = 0
		});
		this.BarChartModel.DefaultFont = "Jost";
		this.BarChartModel.TextColor = OxyColors.White;
		this.BarChartModel.InvalidatePlot(true);
	}

	// Token: 0x0600233E RID: 9022 RVA: 0x0001738B File Offset: 0x0001558B
	public void method_4(Class529 class529_1)
	{
		this.list_0.Add(class529_1);
		this.method_3();
	}

	// Token: 0x0600233F RID: 9023 RVA: 0x0001739F File Offset: 0x0001559F
	public void method_5(Class529 class529_1)
	{
		this.list_0.Remove(class529_1);
		this.method_3();
	}

	// Token: 0x06002340 RID: 9024 RVA: 0x000173B4 File Offset: 0x000155B4
	public void method_6()
	{
		this.list_0.Clear();
	}

	// Token: 0x06002341 RID: 9025 RVA: 0x0008B148 File Offset: 0x00089348
	private void method_7()
	{
		if (!Directory.Exists(Class169.string_8))
		{
			Directory.CreateDirectory(Class169.string_8);
		}
		Application.Current.Dispatcher.Invoke(new Action(this.method_8));
		string[] files = Directory.GetFiles(Class169.string_8);
		if (files.Count<string>() == 0)
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_9));
			return;
		}
		List<Class669> list = new List<Class669>();
		foreach (string path in files)
		{
			try
			{
				string text = Class868.smethod_1(File.ReadAllText(path));
				list.Add(JsonConvert.DeserializeObject<Class669>(text));
			}
			catch
			{
				File.Delete(path);
			}
		}
		if (list.Count<Class669>() == 0)
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_10));
			return;
		}
		using (List<Class669>.Enumerator enumerator = list.OrderByDescending(new Func<Class669, DateTime>(Class522.Class679.class679_0.method_0)).ToList<Class669>().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class522.Class678 @class = new Class522.Class678();
				@class.class522_0 = this;
				@class.class669_0 = enumerator.Current;
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			}
		}
		this.Models.First<Class529>().IsChoosen = true;
	}

	// Token: 0x06002342 RID: 9026 RVA: 0x000173C1 File Offset: 0x000155C1
	private void method_8()
	{
		this.Models.Clear();
	}

	// Token: 0x06002343 RID: 9027 RVA: 0x000173CE File Offset: 0x000155CE
	private void method_9()
	{
		this.NewTestCommand.Execute(null);
	}

	// Token: 0x06002344 RID: 9028 RVA: 0x000173CE File Offset: 0x000155CE
	private void method_10()
	{
		this.NewTestCommand.Execute(null);
	}

	// Token: 0x06002345 RID: 9029 RVA: 0x0008B2D0 File Offset: 0x000894D0
	private void method_11(object object_0)
	{
		Class529 item = new Class529(this.dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd_0.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0, this, null, "Test " + this.Models.Count<Class529>().ToString());
		this.Models.Add(item);
		List<Class529> list = this.Models.OrderByDescending(new Func<Class529, DateTime>(Class522.Class679.class679_0.method_1)).ToList<Class529>();
		this.Models.Clear();
		foreach (Class529 item2 in list)
		{
			this.Models.Add(item2);
		}
		this.Models.First<Class529>().IsChoosen = true;
	}

	// Token: 0x04001744 RID: 5956
	private dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd_0;

	// Token: 0x04001745 RID: 5957
	public byte byte_0;

	// Token: 0x04001746 RID: 5958
	private ObservableCollection<Class529> observableCollection_0 = new ObservableCollection<Class529>();

	// Token: 0x04001747 RID: 5959
	private Class529 class529_0;

	// Token: 0x04001748 RID: 5960
	private GClass280 gclass280_0;

	// Token: 0x04001749 RID: 5961
	public PlotModel plotModel_0;

	// Token: 0x0400174A RID: 5962
	public List<Class529> list_0 = new List<Class529>();

	// Token: 0x02000579 RID: 1401
	private sealed class Class678
	{
		// Token: 0x06002347 RID: 9031 RVA: 0x000173DC File Offset: 0x000155DC
		internal void method_0()
		{
			this.class522_0.Models.Add(new Class529(this.class522_0.dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd_0.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0, this.class522_0, this.class669_0, string.Empty));
		}

		// Token: 0x0400174B RID: 5963
		public Class669 class669_0;

		// Token: 0x0400174C RID: 5964
		public Class522 class522_0;
	}

	// Token: 0x0200057A RID: 1402
	[StructLayout(LayoutKind.Auto)]
	private struct Struct361 : IAsyncStateMachine
	{
		// Token: 0x06002348 RID: 9032 RVA: 0x0008B3AC File Offset: 0x000895AC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class522 @object = this.class522_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_7)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class522.Struct361>(ref awaiter, ref this);
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

		// Token: 0x06002349 RID: 9033 RVA: 0x00017414 File Offset: 0x00015614
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400174D RID: 5965
		public int int_0;

		// Token: 0x0400174E RID: 5966
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400174F RID: 5967
		public Class522 class522_0;

		// Token: 0x04001750 RID: 5968
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200057B RID: 1403
	[Serializable]
	private sealed class Class679
	{
		// Token: 0x0600234C RID: 9036 RVA: 0x0001742E File Offset: 0x0001562E
		internal DateTime method_0(Class669 class669_0)
		{
			return class669_0.DateTime_0;
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00017436 File Offset: 0x00015636
		internal DateTime method_1(Class529 class529_0)
		{
			return class529_0.Date;
		}

		// Token: 0x04001751 RID: 5969
		public static readonly Class522.Class679 class679_0 = new Class522.Class679();

		// Token: 0x04001752 RID: 5970
		public static Func<Class669, DateTime> func_0;

		// Token: 0x04001753 RID: 5971
		public static Func<Class529, DateTime> func_1;
	}
}
