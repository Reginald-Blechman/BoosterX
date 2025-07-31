using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Drawing;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Newtonsoft.Json;
using ns0;
using SkiaSharp;
using SkiaSharp.Views.WPF;

// Token: 0x020005A3 RID: 1443
internal sealed class Class523 : GClass162
{
	// Token: 0x060024C1 RID: 9409 RVA: 0x0008D7C8 File Offset: 0x0008B9C8
	public Class523(dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_1, Class536 class536_1, Class609 class609_0 = null, string string_34 = "")
	{
		this.method_7();
		this.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0 = dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_1;
		this.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.SizeChanged += this.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0_SizeChanged;
		this.class536_0 = class536_1;
		this.method_11();
		if (!string_34.smethod_9())
		{
			this.Name = string_34;
		}
		this.gclass3_0.method_0(new EventHandler<GClass41>(this.method_4));
		this.gclass139_0.method_0(new EventHandler<double>(this.method_2));
		if (class609_0 != null)
		{
			this.method_12(class609_0);
		}
	}

	// Token: 0x060024C2 RID: 9410 RVA: 0x0000311B File Offset: 0x0000131B
	private void dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0_SizeChanged(object sender, SizeChangedEventArgs e)
	{
	}

	// Token: 0x17000618 RID: 1560
	// (get) Token: 0x060024C3 RID: 9411 RVA: 0x000188A8 File Offset: 0x00016AA8
	// (set) Token: 0x060024C4 RID: 9412 RVA: 0x000188B0 File Offset: 0x00016AB0
	public string SpeedText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("SpeedText");
		}
	}

	// Token: 0x17000619 RID: 1561
	// (get) Token: 0x060024C5 RID: 9413 RVA: 0x000188C5 File Offset: 0x00016AC5
	// (set) Token: 0x060024C6 RID: 9414 RVA: 0x000188CD File Offset: 0x00016ACD
	public bool IsDownloading
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsDownloading");
		}
	}

	// Token: 0x1700061A RID: 1562
	// (get) Token: 0x060024C7 RID: 9415 RVA: 0x000188E2 File Offset: 0x00016AE2
	// (set) Token: 0x060024C8 RID: 9416 RVA: 0x000188EA File Offset: 0x00016AEA
	public string FinalDownloadSpeed
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("FinalDownloadSpeed");
		}
	}

	// Token: 0x1700061B RID: 1563
	// (get) Token: 0x060024C9 RID: 9417 RVA: 0x000188FF File Offset: 0x00016AFF
	// (set) Token: 0x060024CA RID: 9418 RVA: 0x00018907 File Offset: 0x00016B07
	public string FinalUploadSpeed
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("FinalUploadSpeed");
		}
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x0008D8F4 File Offset: 0x0008BAF4
	private void method_2(object object_1, double double_1)
	{
		Class523.Class703 @class = new Class523.Class703();
		@class.class523_0 = this;
		@class.double_0 = double_1;
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x0001891C File Offset: 0x00016B1C
	private void method_3(TimeSpan timeSpan_0, double double_1)
	{
		this.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.dje_zCZLXJ8BUMUPBA7GD2P6GQUVCQBRKD79BLREV3XRP3MB6V9MPXHVLGS44QKTA_ejd_0.method_0(timeSpan_0, double_1);
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x0008D930 File Offset: 0x0008BB30
	private void method_4(object object_1, GClass41 gclass41_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.method_5(this.int_7, gclass41_0);
			this.method_16(this.int_7);
		}
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x0008D984 File Offset: 0x0008BB84
	private void method_5(int int_8, GClass41 gclass41_0)
	{
		List<GClass41> list;
		switch (int_8)
		{
		case 0:
			list = this.Results.List_0;
			break;
		case 1:
			list = this.Results.List_1;
			break;
		case 2:
			list = this.Results.List_2;
			break;
		default:
			list = null;
			break;
		}
		List<GClass41> list2 = list;
		ISeries[] array;
		switch (int_8)
		{
		case 0:
			array = this.UnloadedSeries;
			break;
		case 1:
			array = this.DownloadSeries;
			break;
		case 2:
			array = this.UploadSeries;
			break;
		default:
			array = null;
			break;
		}
		ISeries[] array2 = array;
		if (list2 != null && array2 != null)
		{
			if (gclass41_0 != null)
			{
				list2.Add(gclass41_0);
			}
			double[] values = list2.OrderBy(new Func<GClass41, long>(Class523.Class704.class704_0.method_0)).Select(new Func<GClass41, double>(Class523.Class704.class704_0.method_1)).ToArray<double>();
			array2.First<ISeries>().Values = values;
			return;
		}
	}

	// Token: 0x060024CF RID: 9423 RVA: 0x0008DA70 File Offset: 0x0008BC70
	private void method_6()
	{
		this.UnloadedSeries.First<ISeries>().Values = new double[]
		{
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0
		};
		this.DownloadSeries.First<ISeries>().Values = new double[]
		{
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0
		};
		this.UploadSeries.First<ISeries>().Values = new double[]
		{
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0,
			1.0
		};
		this.UnloadedSeries.Last<ISeries>().Values = new ObservableCollection<ObservablePoint>();
		this.DownloadSeries.Last<ISeries>().Values = new ObservableCollection<ObservablePoint>();
		this.UploadSeries.Last<ISeries>().Values = new ObservableCollection<ObservablePoint>();
	}

	// Token: 0x1700061C RID: 1564
	// (get) Token: 0x060024D0 RID: 9424 RVA: 0x00018930 File Offset: 0x00016B30
	// (set) Token: 0x060024D1 RID: 9425 RVA: 0x00018938 File Offset: 0x00016B38
	public Axis[] XAxes
	{
		[CompilerGenerated]
		get
		{
			return this.axis_0;
		}
		[CompilerGenerated]
		set
		{
			this.axis_0 = value;
		}
	}

	// Token: 0x1700061D RID: 1565
	// (get) Token: 0x060024D2 RID: 9426 RVA: 0x00018941 File Offset: 0x00016B41
	// (set) Token: 0x060024D3 RID: 9427 RVA: 0x00018949 File Offset: 0x00016B49
	public Axis[] YAxes
	{
		[CompilerGenerated]
		get
		{
			return this.axis_1;
		}
		[CompilerGenerated]
		set
		{
			this.axis_1 = value;
		}
	}

	// Token: 0x1700061E RID: 1566
	// (get) Token: 0x060024D4 RID: 9428 RVA: 0x00018952 File Offset: 0x00016B52
	// (set) Token: 0x060024D5 RID: 9429 RVA: 0x0001895A File Offset: 0x00016B5A
	public ISeries[] UnloadedSeries
	{
		[CompilerGenerated]
		get
		{
			return this.iseries_0;
		}
		[CompilerGenerated]
		set
		{
			this.iseries_0 = value;
		}
	}

	// Token: 0x1700061F RID: 1567
	// (get) Token: 0x060024D6 RID: 9430 RVA: 0x00018963 File Offset: 0x00016B63
	// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0001896B File Offset: 0x00016B6B
	public ISeries[] DownloadSeries
	{
		[CompilerGenerated]
		get
		{
			return this.iseries_1;
		}
		[CompilerGenerated]
		set
		{
			this.iseries_1 = value;
		}
	}

	// Token: 0x17000620 RID: 1568
	// (get) Token: 0x060024D8 RID: 9432 RVA: 0x00018974 File Offset: 0x00016B74
	// (set) Token: 0x060024D9 RID: 9433 RVA: 0x0001897C File Offset: 0x00016B7C
	public ISeries[] UploadSeries
	{
		[CompilerGenerated]
		get
		{
			return this.iseries_2;
		}
		[CompilerGenerated]
		set
		{
			this.iseries_2 = value;
		}
	}

	// Token: 0x060024DA RID: 9434 RVA: 0x0008DB24 File Offset: 0x0008BD24
	public void method_7()
	{
		this.method_10();
		LinearGradientPaint linearGradientPaint_ = new LinearGradientPaint(new SKColor[]
		{
			WPFExtensions.ToSKColor(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_5(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRFTDSNNMSNMN6WA_ejd, 0.3f)),
			new SKColor(0, 0, 0, 0)
		}, new SKPoint(0f, 0.49f), new SKPoint(0f, 0.51f), null, 0);
		LinearGradientPaint linearGradientPaint_2 = new LinearGradientPaint(new SKColor[]
		{
			WPFExtensions.ToSKColor(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zH2C6P3HHD4TV29CYHNS73_ejd),
			WPFExtensions.ToSKColor(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRFTDSNNMSNMN6WA_ejd)
		}, new SKPoint(0f, 0f), new SKPoint(0f, 1f), new float[]
		{
			0f,
			0.05f
		}, 0)
		{
			StrokeCap = 1,
			StrokeThickness = 2f
		};
		this.UnloadedSeries = new ISeries[]
		{
			this.method_8(linearGradientPaint_2, linearGradientPaint_),
			this.method_9()
		};
		this.DownloadSeries = new ISeries[]
		{
			this.method_8(linearGradientPaint_2, linearGradientPaint_),
			this.method_9()
		};
		this.UploadSeries = new ISeries[]
		{
			this.method_8(linearGradientPaint_2, linearGradientPaint_),
			this.method_9()
		};
		base.method_0("CreateSeries");
	}

	// Token: 0x060024DB RID: 9435 RVA: 0x0008DC68 File Offset: 0x0008BE68
	private ISeries method_8(LinearGradientPaint linearGradientPaint_0, LinearGradientPaint linearGradientPaint_1)
	{
		return new LineSeries<double>
		{
			Stroke = linearGradientPaint_0,
			Values = new Class412<double>(new double[]
			{
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0,
				1.0
			}),
			Fill = linearGradientPaint_1,
			GeometrySize = 0.0,
			DataLabelsSize = 0.0
		};
	}

	// Token: 0x060024DC RID: 9436 RVA: 0x0008DCC8 File Offset: 0x0008BEC8
	private ISeries method_9()
	{
		return new ScatterSeries<ObservablePoint>
		{
			Values = new ObservableCollection<ObservablePoint>(),
			GeometrySize = 2.0,
			Stroke = new SolidColorPaint(WPFExtensions.ToSKColor(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zKUGX8VZG8GQJ6GA_ejd))
			{
				StrokeThickness = 2f
			},
			Fill = null
		};
	}

	// Token: 0x060024DD RID: 9437 RVA: 0x0008DD1C File Offset: 0x0008BF1C
	public void method_10()
	{
		this.XAxes = new Axis[]
		{
			new Axis
			{
				TextSize = 0.0,
				TicksPaint = null,
				ShowSeparatorLines = false,
				IsVisible = false,
				Padding = new Padding(0.0, 0.0, 0.0, 0.0)
			}
		};
		this.YAxes = new Axis[]
		{
			new Axis
			{
				Padding = new Padding(0.0, 0.0, 0.0, 0.0),
				IsVisible = false,
				TextSize = 0.0,
				TicksPaint = null,
				ShowSeparatorLines = false
			}
		};
	}

	// Token: 0x060024DE RID: 9438 RVA: 0x0008DDF8 File Offset: 0x0008BFF8
	private void method_11()
	{
		Class523.Struct372 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct372>(ref @struct);
	}

	// Token: 0x060024DF RID: 9439 RVA: 0x0008DE30 File Offset: 0x0008C030
	private void method_12(Class609 class609_0)
	{
		Class523.Class698 @class = new Class523.Class698();
		@class.class609_0 = class609_0;
		this.Name = @class.class609_0.Name;
		this.Date = @class.class609_0.DateTime_0;
		if (this.TestingTickrates.Any(new Func<Class859, bool>(@class.method_0)))
		{
			this.ChoosenTickrate = this.TestingTickrates.First(new Func<Class859, bool>(@class.method_1));
		}
		else
		{
			this.ChoosenTickrate = this.TestingTickrates[0];
		}
		this.IsAdvancedTest = @class.class609_0.Boolean_0;
		this.ATickRate = @class.class609_0.ATickRate;
		this.APacketSize = @class.class609_0.String_1;
		this.IsRandomPacket = @class.class609_0.Boolean_1;
		this.AMaxPacketSize = @class.class609_0.String_2;
		this.AMinPacketSize = @class.class609_0.String_3;
		this.ATestTime = @class.class609_0.ATestTime;
		this.AChunkSize = @class.class609_0.String_4;
		this.FinalDownloadSpeed = @class.class609_0.String_6;
		this.FinalUploadSpeed = @class.class609_0.String_5;
		this.Results = @class.class609_0.Class688_0;
		this.method_5(0, null);
		this.method_5(1, null);
		this.method_5(2, null);
		this.method_13(@class.class609_0);
	}

	// Token: 0x060024E0 RID: 9440 RVA: 0x0008DF98 File Offset: 0x0008C198
	private void method_13(Class609 class609_0)
	{
		Class523.Struct381 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.class609_0 = class609_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct381>(ref @struct);
	}

	// Token: 0x060024E1 RID: 9441 RVA: 0x0008DFD8 File Offset: 0x0008C1D8
	private void method_14(bool bool_4)
	{
		Class523.Struct369 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.bool_0 = bool_4;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct369>(ref @struct);
	}

	// Token: 0x060024E2 RID: 9442 RVA: 0x00018985 File Offset: 0x00016B85
	private void method_15()
	{
		this.method_16(0);
		this.method_16(1);
		this.method_16(2);
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x0001899C File Offset: 0x00016B9C
	private void method_16(int int_8)
	{
		Task.Run(new Action(new Class523.Class696
		{
			int_0 = int_8,
			class523_0 = this
		}.method_0));
		base.method_0("Calculate");
	}

	// Token: 0x060024E4 RID: 9444 RVA: 0x0008E018 File Offset: 0x0008C218
	private Class523.Class701 method_17(List<GClass41> list_2)
	{
		List<double> source = list_2.Select(new Func<GClass41, double>(Class523.Class704.class704_0.method_4)).ToList<double>();
		double num = Class379.smethod_0(source);
		double double_ = Class379.smethod_1(source);
		double num2 = source.Min();
		double num3 = source.Max();
		double double_2 = Class379.smethod_2(source);
		int num4 = list_2.Count(new Func<GClass41, bool>(Class523.Class704.class704_0.method_5));
		bool flag = num3 - num2 > 40.0;
		double num5 = this.IsAdvancedTest ? (1000.0 / (double)this.int_1) : (1000.0 / (double)this.ChoosenTickrate.method_0());
		double num6 = -num5;
		int num7 = 0;
		for (int i = 0; i < list_2.Count; i++)
		{
			double num8 = (i > 0) ? (list_2[i].Ping - list_2[i - 1].Ping) : 0.0;
			double num9 = list_2[i].Ping - num;
			if ((num8 >= num5 || num8 <= num6 || num9 >= num5 || num9 <= num6 || !list_2[i].Success) && (num8 >= num5 || num8 <= num6))
			{
				num7++;
			}
		}
		return new Class523.Class701(num, double_, num2, num3, double_2, num4, num7, flag);
	}

	// Token: 0x060024E5 RID: 9445 RVA: 0x0008E180 File Offset: 0x0008C380
	private void method_18(int int_8, Class523.Class701 class701_0)
	{
		switch (int_8)
		{
		case 0:
			this.UnloadedMeanPing = ((int)class701_0.method_0()).ToString();
			this.UnloadedMedianPing = ((int)class701_0.method_1()).ToString();
			this.UnloadedMaxPing = ((int)class701_0.method_3()).ToString();
			this.UnloadedMinPing = ((int)class701_0.method_2()).ToString();
			this.UnloadedJitterPing = Class249.smethod_16(class701_0.method_4().ToString(), 2);
			this.UnloadedLostPing = class701_0.method_5().ToString();
			this.UnloadedOverSyncCountPing = class701_0.method_6().ToString();
			return;
		case 1:
			this.DownloadMeanPing = ((int)class701_0.method_0()).ToString();
			this.DownloadMedianPing = ((int)class701_0.method_1()).ToString();
			this.DownloadMaxPing = ((int)class701_0.method_3()).ToString();
			this.DownloadMinPing = ((int)class701_0.method_2()).ToString();
			this.DownloadJitterPing = Class249.smethod_16(class701_0.method_4().ToString(), 2);
			this.DownloadLostPing = class701_0.method_5().ToString();
			this.DownloadOverSyncCountPing = class701_0.method_6().ToString();
			return;
		case 2:
			this.UploadMeanPing = ((int)class701_0.method_0()).ToString();
			this.UploadMedianPing = ((int)class701_0.method_1()).ToString();
			this.UploadMaxPing = ((int)class701_0.method_3()).ToString();
			this.UploadMinPing = ((int)class701_0.method_2()).ToString();
			this.UploadJitterPing = Class249.smethod_16(class701_0.method_4().ToString(), 2);
			this.UploadLostPing = class701_0.method_5().ToString();
			this.UploadOverSyncCountPing = class701_0.method_6().ToString();
			return;
		default:
			return;
		}
	}

	// Token: 0x17000621 RID: 1569
	// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000189CE File Offset: 0x00016BCE
	// (set) Token: 0x060024E7 RID: 9447 RVA: 0x000189D6 File Offset: 0x00016BD6
	public Class688 Results
	{
		[CompilerGenerated]
		get
		{
			return this.class688_0;
		}
		[CompilerGenerated]
		set
		{
			this.class688_0 = value;
		}
	}

	// Token: 0x17000622 RID: 1570
	// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000189DF File Offset: 0x00016BDF
	// (set) Token: 0x060024E9 RID: 9449 RVA: 0x0008E364 File Offset: 0x0008C564
	public bool IsChoosen
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			if (!value)
			{
				if (this.class536_0.Models.Where(new Func<Class523, bool>(Class523.Class704.class704_0.method_6)).Count<Class523>() > 1)
				{
					this.bool_1 = value;
					if (this.class536_0.byte_0 == 1)
					{
					}
				}
			}
			else
			{
				this.bool_1 = value;
				if (this.class536_0.byte_0 == 0)
				{
					foreach (Class523 @class in this.class536_0.Models)
					{
						if (@class != this)
						{
							@class.IsChoosen = false;
						}
					}
					this.class536_0.Choosen = this;
					this.method_14(false);
				}
			}
			base.method_0("IsChoosen");
		}
	}

	// Token: 0x17000623 RID: 1571
	// (get) Token: 0x060024EA RID: 9450 RVA: 0x0008E440 File Offset: 0x0008C640
	public List<Class859> TestingTickrates
	{
		get
		{
			if (this.list_0 == null)
			{
				List<Class859> list = new List<Class859>();
				Class859 @class = new Class859();
				@class.Name = "APEX, Fortnite, Dota2";
				@class.method_1(30);
				@class.Icon = new BitmapImage(new Uri("pack://application:,,,/BoosterX;component/Resources/Images/Games/GameLogo.png"));
				list.Add(@class);
				Class859 class2 = new Class859();
				class2.Name = "PUBG";
				class2.method_1(60);
				class2.Icon = new BitmapImage(new Uri("pack://application:,,,/BoosterX;component/Resources/Images/Games/CS2Logo.png"));
				list.Add(class2);
				Class859 class3 = new Class859();
				class3.Name = "CS2";
				class3.method_1(64);
				class3.Icon = new BitmapImage(new Uri("pack://application:,,,/BoosterX;component/Resources/Images/Games/CS2Logo.png"));
				list.Add(class3);
				Class859 class4 = new Class859();
				class4.Name = "Valorant";
				class4.method_1(128);
				class4.Icon = new BitmapImage(new Uri("pack://application:,,,/BoosterX;component/Resources/Images/Games/GameLogo.png"));
				list.Add(class4);
				this.list_0 = list;
			}
			return this.list_0;
		}
	}

	// Token: 0x17000624 RID: 1572
	// (get) Token: 0x060024EB RID: 9451 RVA: 0x000189E7 File Offset: 0x00016BE7
	// (set) Token: 0x060024EC RID: 9452 RVA: 0x0008E540 File Offset: 0x0008C740
	public Class859 ChoosenTickrate
	{
		get
		{
			if (this.class859_0 == null)
			{
				this.class859_0 = this.TestingTickrates[Convert.ToInt32(Class551.class753_0.method_14())];
			}
			return this.class859_0;
		}
		set
		{
			for (int i = 0; i < 3; i++)
			{
				if (this.TestingTickrates[i] == value)
				{
					Class551.class753_0.method_15(new int?(i));
					IL_2F:
					this.class859_0 = value;
					base.method_0("ChoosenTickrate");
					return;
				}
			}
			goto IL_2F;
		}
	}

	// Token: 0x17000625 RID: 1573
	// (get) Token: 0x060024ED RID: 9453 RVA: 0x0008E590 File Offset: 0x0008C790
	// (set) Token: 0x060024EE RID: 9454 RVA: 0x00018A1C File Offset: 0x00016C1C
	public int CustomTickrate
	{
		get
		{
			if (this.int_0 == 0)
			{
				Class753 class753_ = Class551.class753_0;
				int? num = class753_.method_16();
				int valueOrDefault = num.GetValueOrDefault();
				int num2;
				if (num == null)
				{
					Class753 @class = class753_;
					int? nullable_ = new int?(50);
					@class.method_17(nullable_);
					num2 = 50;
				}
				else
				{
					num2 = valueOrDefault;
				}
				this.int_0 = num2;
			}
			if (this.int_0 < 10)
			{
				return 10;
			}
			if (this.int_0 > 128)
			{
				return 128;
			}
			return this.int_0;
		}
		set
		{
			Class551.class753_0.method_17(new int?(value));
			this.int_0 = value;
			base.method_0("CustomTickrate");
		}
	}

	// Token: 0x17000626 RID: 1574
	// (get) Token: 0x060024EF RID: 9455 RVA: 0x0008E608 File Offset: 0x0008C808
	// (set) Token: 0x060024F0 RID: 9456 RVA: 0x00018A41 File Offset: 0x00016C41
	public List<Class533> Servers
	{
		get
		{
			if (this.list_1 == null)
			{
				this.list_1 = new List<Class533>
				{
					new Class533
					{
						City = Class298.smethod_2("Loading"),
						Country = "eu",
						IP = "172.104.129.111",
						Port = 27015
					}
				};
			}
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
			base.method_0("Servers");
		}
	}

	// Token: 0x17000627 RID: 1575
	// (get) Token: 0x060024F1 RID: 9457 RVA: 0x00018A56 File Offset: 0x00016C56
	// (set) Token: 0x060024F2 RID: 9458 RVA: 0x00018A77 File Offset: 0x00016C77
	public Class533 ChoosenServer
	{
		get
		{
			if (this.class533_0 == null)
			{
				this.class533_0 = this.Servers.First<Class533>();
			}
			return this.class533_0;
		}
		set
		{
			if (value != null)
			{
				Class551.class753_0.method_5(value.City);
				this.class533_0 = value;
			}
			base.method_0("ChoosenServer");
		}
	}

	// Token: 0x17000628 RID: 1576
	// (get) Token: 0x060024F3 RID: 9459 RVA: 0x00018A9F File Offset: 0x00016C9F
	// (set) Token: 0x060024F4 RID: 9460 RVA: 0x00018AA7 File Offset: 0x00016CA7
	public string Name
	{
		get
		{
			return this.string_4;
		}
		set
		{
			if (this.string_3 == null)
			{
				this.string_3 = value;
			}
			this.string_4 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000629 RID: 1577
	// (get) Token: 0x060024F5 RID: 9461 RVA: 0x00018ACB File Offset: 0x00016CCB
	// (set) Token: 0x060024F6 RID: 9462 RVA: 0x00018AD3 File Offset: 0x00016CD3
	public DateTime Date
	{
		[CompilerGenerated]
		get
		{
			return this.dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x1700062A RID: 1578
	// (get) Token: 0x060024F7 RID: 9463 RVA: 0x0008E670 File Offset: 0x0008C870
	public string DateString
	{
		get
		{
			return this.Date.ToString("dd.MM.yyyy HH:mm");
		}
	}

	// Token: 0x1700062B RID: 1579
	// (get) Token: 0x060024F8 RID: 9464 RVA: 0x0008E694 File Offset: 0x0008C894
	// (set) Token: 0x060024F9 RID: 9465 RVA: 0x0008E6CC File Offset: 0x0008C8CC
	public bool IsAdvancedTest
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "+L/>]Za-iQ", object_);
		}
		set
		{
			object[] object_ = new object[]
			{
				this,
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "D6^LUZa-iQ", object_);
		}
	}

	// Token: 0x1700062C RID: 1580
	// (get) Token: 0x060024FA RID: 9466 RVA: 0x00018ADC File Offset: 0x00016CDC
	// (set) Token: 0x060024FB RID: 9467 RVA: 0x0008E704 File Offset: 0x0008C904
	public string ATickRate
	{
		get
		{
			return this.int_1.ToString();
		}
		set
		{
			int num = Class379.smethod_6(value);
			this.int_1 = ((num < 0) ? 1 : num);
			base.method_0("ATickRate");
		}
	}

	// Token: 0x1700062D RID: 1581
	// (get) Token: 0x060024FC RID: 9468 RVA: 0x00018AE9 File Offset: 0x00016CE9
	// (set) Token: 0x060024FD RID: 9469 RVA: 0x0008E734 File Offset: 0x0008C934
	public string APacketSize
	{
		get
		{
			return this.int_2.ToString();
		}
		set
		{
			int num = Class379.smethod_6(value);
			this.int_2 = ((num < 0) ? 1 : num);
			base.method_0("APacketSize");
		}
	}

	// Token: 0x1700062E RID: 1582
	// (get) Token: 0x060024FE RID: 9470 RVA: 0x00018AF6 File Offset: 0x00016CF6
	// (set) Token: 0x060024FF RID: 9471 RVA: 0x00018AFE File Offset: 0x00016CFE
	public bool IsRandomPacket
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
			base.method_0("IsRandomPacket");
		}
	}

	// Token: 0x1700062F RID: 1583
	// (get) Token: 0x06002500 RID: 9472 RVA: 0x00018B13 File Offset: 0x00016D13
	// (set) Token: 0x06002501 RID: 9473 RVA: 0x0008E764 File Offset: 0x0008C964
	public string AMaxPacketSize
	{
		get
		{
			return this.int_3.ToString();
		}
		set
		{
			int num = Class379.smethod_6(value);
			this.int_3 = ((num < 0) ? 1 : num);
			base.method_0("AMaxPacketSize");
		}
	}

	// Token: 0x17000630 RID: 1584
	// (get) Token: 0x06002502 RID: 9474 RVA: 0x00018B20 File Offset: 0x00016D20
	// (set) Token: 0x06002503 RID: 9475 RVA: 0x0008E794 File Offset: 0x0008C994
	public string AMinPacketSize
	{
		get
		{
			return this.int_4.ToString();
		}
		set
		{
			int num = Class379.smethod_6(value);
			this.int_4 = ((num < 0) ? 1 : num);
			base.method_0("AMinPacketSize");
		}
	}

	// Token: 0x17000631 RID: 1585
	// (get) Token: 0x06002504 RID: 9476 RVA: 0x00018B2D File Offset: 0x00016D2D
	// (set) Token: 0x06002505 RID: 9477 RVA: 0x0008E7C4 File Offset: 0x0008C9C4
	public string AChunkSize
	{
		get
		{
			return this.int_5.ToString();
		}
		set
		{
			int num = Class379.smethod_6(value);
			this.int_5 = ((num < 0) ? 1 : num);
			base.method_0("AChunkSize");
		}
	}

	// Token: 0x17000632 RID: 1586
	// (get) Token: 0x06002506 RID: 9478 RVA: 0x00018B3A File Offset: 0x00016D3A
	// (set) Token: 0x06002507 RID: 9479 RVA: 0x0008E7F4 File Offset: 0x0008C9F4
	public string ATestTime
	{
		get
		{
			return this.int_6.ToString();
		}
		set
		{
			int num = Class379.smethod_6(value);
			this.int_6 = ((num < 0) ? 1 : num);
			base.method_0("ATestTime");
		}
	}

	// Token: 0x17000633 RID: 1587
	// (get) Token: 0x06002508 RID: 9480 RVA: 0x00018B47 File Offset: 0x00016D47
	// (set) Token: 0x06002509 RID: 9481 RVA: 0x00018B4F File Offset: 0x00016D4F
	public string UploadLostPing
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
			base.method_0("UploadLostPing");
		}
	}

	// Token: 0x17000634 RID: 1588
	// (get) Token: 0x0600250A RID: 9482 RVA: 0x00018B64 File Offset: 0x00016D64
	// (set) Token: 0x0600250B RID: 9483 RVA: 0x00018B6C File Offset: 0x00016D6C
	public string DownloadLostPing
	{
		get
		{
			return this.string_6;
		}
		set
		{
			this.string_6 = value;
			base.method_0("DownloadLostPing");
		}
	}

	// Token: 0x17000635 RID: 1589
	// (get) Token: 0x0600250C RID: 9484 RVA: 0x00018B81 File Offset: 0x00016D81
	// (set) Token: 0x0600250D RID: 9485 RVA: 0x00018B89 File Offset: 0x00016D89
	public string UnloadedLostPing
	{
		get
		{
			return this.string_7;
		}
		set
		{
			this.string_7 = value;
			base.method_0("UnloadedLostPing");
		}
	}

	// Token: 0x17000636 RID: 1590
	// (get) Token: 0x0600250E RID: 9486 RVA: 0x00018B9E File Offset: 0x00016D9E
	// (set) Token: 0x0600250F RID: 9487 RVA: 0x00018BA6 File Offset: 0x00016DA6
	public string UnloadedMeanPing
	{
		get
		{
			return this.string_8;
		}
		set
		{
			this.string_8 = value;
			base.method_0("UnloadedMeanPing");
		}
	}

	// Token: 0x17000637 RID: 1591
	// (get) Token: 0x06002510 RID: 9488 RVA: 0x00018BBB File Offset: 0x00016DBB
	// (set) Token: 0x06002511 RID: 9489 RVA: 0x00018BC3 File Offset: 0x00016DC3
	public string UnloadedMedianPing
	{
		get
		{
			return this.string_9;
		}
		set
		{
			this.string_9 = value;
			base.method_0("UnloadedMedianPing");
		}
	}

	// Token: 0x17000638 RID: 1592
	// (get) Token: 0x06002512 RID: 9490 RVA: 0x00018BD8 File Offset: 0x00016DD8
	// (set) Token: 0x06002513 RID: 9491 RVA: 0x00018BE0 File Offset: 0x00016DE0
	public string UnloadedMaxPing
	{
		get
		{
			return this.string_10;
		}
		set
		{
			this.string_10 = value;
			base.method_0("UnloadedMaxPing");
		}
	}

	// Token: 0x17000639 RID: 1593
	// (get) Token: 0x06002514 RID: 9492 RVA: 0x00018BF5 File Offset: 0x00016DF5
	// (set) Token: 0x06002515 RID: 9493 RVA: 0x00018BFD File Offset: 0x00016DFD
	public string UnloadedMinPing
	{
		get
		{
			return this.string_11;
		}
		set
		{
			this.string_11 = value;
			base.method_0("UnloadedMinPing");
		}
	}

	// Token: 0x1700063A RID: 1594
	// (get) Token: 0x06002516 RID: 9494 RVA: 0x00018C12 File Offset: 0x00016E12
	// (set) Token: 0x06002517 RID: 9495 RVA: 0x00018C1A File Offset: 0x00016E1A
	public string UnloadedJitterPing
	{
		get
		{
			return this.string_12;
		}
		set
		{
			this.string_12 = value;
			base.method_0("UnloadedJitterPing");
		}
	}

	// Token: 0x1700063B RID: 1595
	// (get) Token: 0x06002518 RID: 9496 RVA: 0x00018C2F File Offset: 0x00016E2F
	// (set) Token: 0x06002519 RID: 9497 RVA: 0x00018C37 File Offset: 0x00016E37
	public string UnloadedOverSyncCountPing
	{
		get
		{
			return this.string_13;
		}
		set
		{
			this.string_13 = value;
			base.method_0("UnloadedOverSyncCountPing");
		}
	}

	// Token: 0x1700063C RID: 1596
	// (get) Token: 0x0600251A RID: 9498 RVA: 0x00018C4C File Offset: 0x00016E4C
	// (set) Token: 0x0600251B RID: 9499 RVA: 0x00018C54 File Offset: 0x00016E54
	public string DownloadMeanPing
	{
		get
		{
			return this.string_14;
		}
		set
		{
			this.string_14 = value;
			base.method_0("DownloadMeanPing");
		}
	}

	// Token: 0x1700063D RID: 1597
	// (get) Token: 0x0600251C RID: 9500 RVA: 0x00018C69 File Offset: 0x00016E69
	// (set) Token: 0x0600251D RID: 9501 RVA: 0x00018C71 File Offset: 0x00016E71
	public string DownloadMedianPing
	{
		get
		{
			return this.string_15;
		}
		set
		{
			this.string_15 = value;
			base.method_0("DownloadMedianPing");
		}
	}

	// Token: 0x1700063E RID: 1598
	// (get) Token: 0x0600251E RID: 9502 RVA: 0x00018C86 File Offset: 0x00016E86
	// (set) Token: 0x0600251F RID: 9503 RVA: 0x00018C8E File Offset: 0x00016E8E
	public string DownloadMaxPing
	{
		get
		{
			return this.string_16;
		}
		set
		{
			this.string_16 = value;
			base.method_0("DownloadMaxPing");
		}
	}

	// Token: 0x1700063F RID: 1599
	// (get) Token: 0x06002520 RID: 9504 RVA: 0x00018CA3 File Offset: 0x00016EA3
	// (set) Token: 0x06002521 RID: 9505 RVA: 0x00018CAB File Offset: 0x00016EAB
	public string DownloadMinPing
	{
		get
		{
			return this.string_17;
		}
		set
		{
			this.string_17 = value;
			base.method_0("DownloadMinPing");
		}
	}

	// Token: 0x17000640 RID: 1600
	// (get) Token: 0x06002522 RID: 9506 RVA: 0x00018CC0 File Offset: 0x00016EC0
	// (set) Token: 0x06002523 RID: 9507 RVA: 0x00018CC8 File Offset: 0x00016EC8
	public string DownloadJitterPing
	{
		get
		{
			return this.string_18;
		}
		set
		{
			this.string_18 = value;
			base.method_0("DownloadJitterPing");
		}
	}

	// Token: 0x17000641 RID: 1601
	// (get) Token: 0x06002524 RID: 9508 RVA: 0x00018CDD File Offset: 0x00016EDD
	// (set) Token: 0x06002525 RID: 9509 RVA: 0x00018CE5 File Offset: 0x00016EE5
	public string DownloadOverSyncCountPing
	{
		get
		{
			return this.string_19;
		}
		set
		{
			this.string_19 = value;
			base.method_0("DownloadOverSyncCountPing");
		}
	}

	// Token: 0x17000642 RID: 1602
	// (get) Token: 0x06002526 RID: 9510 RVA: 0x00018CFA File Offset: 0x00016EFA
	// (set) Token: 0x06002527 RID: 9511 RVA: 0x00018D02 File Offset: 0x00016F02
	public string UploadMeanPing
	{
		get
		{
			return this.string_20;
		}
		set
		{
			this.string_20 = value;
			base.method_0("UploadMeanPing");
		}
	}

	// Token: 0x17000643 RID: 1603
	// (get) Token: 0x06002528 RID: 9512 RVA: 0x00018D17 File Offset: 0x00016F17
	// (set) Token: 0x06002529 RID: 9513 RVA: 0x00018D1F File Offset: 0x00016F1F
	public string UploadMedianPing
	{
		get
		{
			return this.string_21;
		}
		set
		{
			this.string_21 = value;
			base.method_0("UploadMedianPing");
		}
	}

	// Token: 0x17000644 RID: 1604
	// (get) Token: 0x0600252A RID: 9514 RVA: 0x00018D34 File Offset: 0x00016F34
	// (set) Token: 0x0600252B RID: 9515 RVA: 0x00018D3C File Offset: 0x00016F3C
	public string UploadMaxPing
	{
		get
		{
			return this.string_22;
		}
		set
		{
			this.string_22 = value;
			base.method_0("UploadMaxPing");
		}
	}

	// Token: 0x17000645 RID: 1605
	// (get) Token: 0x0600252C RID: 9516 RVA: 0x00018D51 File Offset: 0x00016F51
	// (set) Token: 0x0600252D RID: 9517 RVA: 0x00018D59 File Offset: 0x00016F59
	public string UploadMinPing
	{
		get
		{
			return this.string_23;
		}
		set
		{
			this.string_23 = value;
			base.method_0("UploadMinPing");
		}
	}

	// Token: 0x17000646 RID: 1606
	// (get) Token: 0x0600252E RID: 9518 RVA: 0x00018D6E File Offset: 0x00016F6E
	// (set) Token: 0x0600252F RID: 9519 RVA: 0x00018D76 File Offset: 0x00016F76
	public string UploadJitterPing
	{
		get
		{
			return this.string_24;
		}
		set
		{
			this.string_24 = value;
			base.method_0("UploadJitterPing");
		}
	}

	// Token: 0x17000647 RID: 1607
	// (get) Token: 0x06002530 RID: 9520 RVA: 0x00018D8B File Offset: 0x00016F8B
	// (set) Token: 0x06002531 RID: 9521 RVA: 0x00018D93 File Offset: 0x00016F93
	public string UploadOverSyncCountPing
	{
		get
		{
			return this.string_25;
		}
		set
		{
			this.string_25 = value;
			base.method_0("UploadOverSyncCountPing");
		}
	}

	// Token: 0x06002532 RID: 9522 RVA: 0x0008E824 File Offset: 0x0008CA24
	private void method_19(CancellationToken cancellationToken_0, TimeSpan timeSpan_0)
	{
		Class523.Struct376 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.timeSpan_0 = timeSpan_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct376>(ref @struct);
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x0008E86C File Offset: 0x0008CA6C
	private void method_20(CancellationToken cancellationToken_0, TimeSpan timeSpan_0)
	{
		Class523.Struct379 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.timeSpan_0 = timeSpan_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct379>(ref @struct);
	}

	// Token: 0x17000648 RID: 1608
	// (get) Token: 0x06002534 RID: 9524 RVA: 0x0008E8B4 File Offset: 0x0008CAB4
	public GClass280 Start
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_25), null));
			}
			return result;
		}
	}

	// Token: 0x17000649 RID: 1609
	// (get) Token: 0x06002535 RID: 9525 RVA: 0x0008E8E8 File Offset: 0x0008CAE8
	public GClass280 ShowAdvancedSettings
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(Class523.Class704.class704_0.method_7), null));
			}
			return result;
		}
	}

	// Token: 0x1700064A RID: 1610
	// (get) Token: 0x06002536 RID: 9526 RVA: 0x0008E930 File Offset: 0x0008CB30
	public GClass280 StartAdv
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_2) == null)
			{
				result = (this.gclass280_2 = new GClass280(new Action<object>(this.method_26), null));
			}
			return result;
		}
	}

	// Token: 0x1700064B RID: 1611
	// (get) Token: 0x06002537 RID: 9527 RVA: 0x0008E964 File Offset: 0x0008CB64
	public GClass280 ForceStop
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_3) == null)
			{
				result = (this.gclass280_3 = new GClass280(new Action<object>(this.method_27), null));
			}
			return result;
		}
	}

	// Token: 0x1700064C RID: 1612
	// (get) Token: 0x06002538 RID: 9528 RVA: 0x0008E998 File Offset: 0x0008CB98
	public GClass280 Restart
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_4) == null)
			{
				result = (this.gclass280_4 = new GClass280(new Action<object>(this.method_28), null));
			}
			return result;
		}
	}

	// Token: 0x1700064D RID: 1613
	// (get) Token: 0x06002539 RID: 9529 RVA: 0x00018DA8 File Offset: 0x00016FA8
	public GClass280 Rename
	{
		get
		{
			return new GClass280(new Action<object>(this.method_29), null);
		}
	}

	// Token: 0x1700064E RID: 1614
	// (get) Token: 0x0600253A RID: 9530 RVA: 0x0008E9CC File Offset: 0x0008CBCC
	public GClass280 DeleteCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_5) == null)
			{
				result = (this.gclass280_5 = new GClass280(new Action<object>(this.method_30), null));
			}
			return result;
		}
	}

	// Token: 0x1700064F RID: 1615
	// (get) Token: 0x0600253B RID: 9531 RVA: 0x0008EA00 File Offset: 0x0008CC00
	public GClass280 BackToPageCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_6) == null)
			{
				result = (this.gclass280_6 = new GClass280(new Action<object>(this.method_31), null));
			}
			return result;
		}
	}

	// Token: 0x17000650 RID: 1616
	// (get) Token: 0x0600253C RID: 9532 RVA: 0x0008EA34 File Offset: 0x0008CC34
	public GClass280 ResultsCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_7) == null)
			{
				result = (this.gclass280_7 = new GClass280(new Action<object>(this.method_32), null));
			}
			return result;
		}
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x0008EA68 File Offset: 0x0008CC68
	private void method_21()
	{
		string path = Path.Combine(Class169.string_9, this.string_3 + ".ix");
		if (File.Exists(path))
		{
			File.Delete(path);
			this.string_3 = this.Name;
		}
		string contents = Class868.smethod_0(JsonConvert.SerializeObject(new Class609
		{
			Name = this.Name,
			DateTime_0 = this.Date,
			Boolean_0 = this.IsAdvancedTest,
			ChoosenServer = this.ChoosenServer.City,
			ATickRate = this.ATickRate,
			String_2 = this.AMaxPacketSize,
			String_3 = this.AMinPacketSize,
			String_1 = this.APacketSize,
			ATestTime = this.ATestTime,
			String_4 = this.AChunkSize,
			String_0 = this.ChoosenTickrate.Name,
			Boolean_1 = this.IsRandomPacket,
			Class688_0 = this.Results,
			String_5 = this.FinalUploadSpeed,
			String_6 = this.FinalDownloadSpeed
		}, 1));
		path = Path.Combine(Class169.string_9, this.Name + ".ix");
		File.WriteAllText(path, contents);
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x00018DBC File Offset: 0x00016FBC
	private void method_22()
	{
		File.Delete(Path.Combine(Class169.string_9, this.Name + ".ix"));
	}

	// Token: 0x17000651 RID: 1617
	// (get) Token: 0x0600253F RID: 9535 RVA: 0x00018DDE File Offset: 0x00016FDE
	// (set) Token: 0x06002540 RID: 9536 RVA: 0x00018DE6 File Offset: 0x00016FE6
	public string MainRes
	{
		get
		{
			return this.string_26;
		}
		set
		{
			this.string_26 = value;
			base.method_0("MainRes");
		}
	}

	// Token: 0x17000652 RID: 1618
	// (get) Token: 0x06002541 RID: 9537 RVA: 0x00018DFB File Offset: 0x00016FFB
	// (set) Token: 0x06002542 RID: 9538 RVA: 0x00018E03 File Offset: 0x00017003
	public SolidColorBrush MainResColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("MainResColor");
		}
	}

	// Token: 0x17000653 RID: 1619
	// (get) Token: 0x06002543 RID: 9539 RVA: 0x00018E18 File Offset: 0x00017018
	// (set) Token: 0x06002544 RID: 9540 RVA: 0x00018E20 File Offset: 0x00017020
	public string MainResDesc
	{
		get
		{
			return this.string_27;
		}
		set
		{
			this.string_27 = value;
			base.method_0("MainResDesc");
		}
	}

	// Token: 0x17000654 RID: 1620
	// (get) Token: 0x06002545 RID: 9541 RVA: 0x00018E35 File Offset: 0x00017035
	// (set) Token: 0x06002546 RID: 9542 RVA: 0x00018E3D File Offset: 0x0001703D
	public string MainPingDesc
	{
		get
		{
			return this.string_28;
		}
		set
		{
			this.string_28 = value;
			base.method_0("MainPingDesc");
		}
	}

	// Token: 0x17000655 RID: 1621
	// (get) Token: 0x06002547 RID: 9543 RVA: 0x00018E52 File Offset: 0x00017052
	// (set) Token: 0x06002548 RID: 9544 RVA: 0x00018E5A File Offset: 0x0001705A
	public string BufferBloatMain
	{
		get
		{
			return this.string_29;
		}
		set
		{
			this.string_29 = value;
			base.method_0("BufferBloatMain");
		}
	}

	// Token: 0x17000656 RID: 1622
	// (get) Token: 0x06002549 RID: 9545 RVA: 0x00018E6F File Offset: 0x0001706F
	// (set) Token: 0x0600254A RID: 9546 RVA: 0x00018E77 File Offset: 0x00017077
	public SolidColorBrush BufferBloatMainColor
	{
		get
		{
			return this.solidColorBrush_1;
		}
		set
		{
			this.solidColorBrush_1 = value;
			base.method_0("BufferBloatMainColor");
		}
	}

	// Token: 0x17000657 RID: 1623
	// (get) Token: 0x0600254B RID: 9547 RVA: 0x00018E8C File Offset: 0x0001708C
	// (set) Token: 0x0600254C RID: 9548 RVA: 0x00018E94 File Offset: 0x00017094
	public string BufferBloatMain2
	{
		get
		{
			return this.string_30;
		}
		set
		{
			this.string_30 = value;
			base.method_0("BufferBloatMain2");
		}
	}

	// Token: 0x17000658 RID: 1624
	// (get) Token: 0x0600254D RID: 9549 RVA: 0x00018EA9 File Offset: 0x000170A9
	// (set) Token: 0x0600254E RID: 9550 RVA: 0x00018EB1 File Offset: 0x000170B1
	public SolidColorBrush BufferBloatMain2Color
	{
		get
		{
			return this.solidColorBrush_2;
		}
		set
		{
			this.solidColorBrush_2 = value;
			base.method_0("BufferBloatMain2Color");
		}
	}

	// Token: 0x17000659 RID: 1625
	// (get) Token: 0x0600254F RID: 9551 RVA: 0x00018EC6 File Offset: 0x000170C6
	// (set) Token: 0x06002550 RID: 9552 RVA: 0x00018ECE File Offset: 0x000170CE
	public string DownloadResDesc
	{
		get
		{
			return this.string_31;
		}
		set
		{
			this.string_31 = value;
			base.method_0("DownloadResDesc");
		}
	}

	// Token: 0x1700065A RID: 1626
	// (get) Token: 0x06002551 RID: 9553 RVA: 0x00018EE3 File Offset: 0x000170E3
	// (set) Token: 0x06002552 RID: 9554 RVA: 0x00018EEB File Offset: 0x000170EB
	public string UploadResDesc
	{
		get
		{
			return this.string_32;
		}
		set
		{
			this.string_32 = value;
			base.method_0("UploadResDesc");
		}
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x0008EBA0 File Offset: 0x0008CDA0
	public void method_23()
	{
		Class523.Struct373 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct373>(ref @struct);
	}

	// Token: 0x1700065B RID: 1627
	// (get) Token: 0x06002554 RID: 9556 RVA: 0x00018F00 File Offset: 0x00017100
	// (set) Token: 0x06002555 RID: 9557 RVA: 0x00018F08 File Offset: 0x00017108
	public string StatusText
	{
		get
		{
			return this.string_33;
		}
		set
		{
			this.string_33 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x1700065C RID: 1628
	// (get) Token: 0x06002556 RID: 9558 RVA: 0x00018F1D File Offset: 0x0001711D
	// (set) Token: 0x06002557 RID: 9559 RVA: 0x00018F25 File Offset: 0x00017125
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_3;
		}
		set
		{
			this.solidColorBrush_3 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x1700065D RID: 1629
	// (get) Token: 0x06002558 RID: 9560 RVA: 0x00018F3A File Offset: 0x0001713A
	// (set) Token: 0x06002559 RID: 9561 RVA: 0x00018F42 File Offset: 0x00017142
	public double StatusOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x0008EBD8 File Offset: 0x0008CDD8
	private void method_24(string string_34, SolidColorBrush solidColorBrush_4)
	{
		Class523.Struct371 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.string_0 = string_34;
		@struct.solidColorBrush_0 = solidColorBrush_4;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct371>(ref @struct);
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x0008EC20 File Offset: 0x0008CE20
	private void method_25(object object_1)
	{
		Class523.Struct377 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct377>(ref @struct);
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x0008EC58 File Offset: 0x0008CE58
	private void method_26(object object_1)
	{
		Class523.Struct380 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct380>(ref @struct);
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x00018F57 File Offset: 0x00017157
	private void method_27(object object_1)
	{
		if (this.cancellationTokenSource_0 != null)
		{
			this.gclass3_0.method_3();
			this.cancellationTokenSource_0.Cancel();
			this.method_24(Class298.smethod_2("InetTestStatusCancel"), Brushes.Red);
		}
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x0008EC90 File Offset: 0x0008CE90
	private void method_28(object object_1)
	{
		Class523.Struct375 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct375>(ref @struct);
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x00018F8D File Offset: 0x0001718D
	private void method_29(object object_1)
	{
		this.method_21();
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x0008ECC8 File Offset: 0x0008CEC8
	private void method_30(object object_1)
	{
		this.Results.List_2.Clear();
		this.Results.List_1.Clear();
		this.Results.List_2.Clear();
		this.method_22();
		this.class536_0.Models.Remove(this);
		if (this.class536_0.Models.Count == 0)
		{
			this.class536_0.NewTestCommand.Execute(null);
			return;
		}
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x00018F95 File Offset: 0x00017195
	private void method_31(object object_1)
	{
		this.method_14(true);
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x0008ED44 File Offset: 0x0008CF44
	private void method_32(object object_1)
	{
		Class523.Struct378 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class523_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class523.Struct378>(ref @struct);
	}

	// Token: 0x040017EA RID: 6122
	private dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0;

	// Token: 0x040017EB RID: 6123
	private Class536 class536_0;

	// Token: 0x040017EC RID: 6124
	private GClass3 gclass3_0 = new GClass3();

	// Token: 0x040017ED RID: 6125
	private GClass139 gclass139_0 = new GClass139();

	// Token: 0x040017EE RID: 6126
	private string string_0 = "0";

	// Token: 0x040017EF RID: 6127
	private bool bool_0 = true;

	// Token: 0x040017F0 RID: 6128
	private string string_1 = "0 Mbps";

	// Token: 0x040017F1 RID: 6129
	private string string_2 = "0 Mbps";

	// Token: 0x040017F2 RID: 6130
	private object object_0 = new object();

	// Token: 0x040017F3 RID: 6131
	private Axis[] axis_0;

	// Token: 0x040017F4 RID: 6132
	private Axis[] axis_1;

	// Token: 0x040017F5 RID: 6133
	private ISeries[] iseries_0;

	// Token: 0x040017F6 RID: 6134
	private ISeries[] iseries_1;

	// Token: 0x040017F7 RID: 6135
	private ISeries[] iseries_2;

	// Token: 0x040017F8 RID: 6136
	private Class688 class688_0 = new Class688();

	// Token: 0x040017F9 RID: 6137
	public bool bool_1;

	// Token: 0x040017FA RID: 6138
	private List<Class859> list_0;

	// Token: 0x040017FB RID: 6139
	private Class859 class859_0;

	// Token: 0x040017FC RID: 6140
	private int int_0;

	// Token: 0x040017FD RID: 6141
	private List<Class533> list_1;

	// Token: 0x040017FE RID: 6142
	private Class533 class533_0;

	// Token: 0x040017FF RID: 6143
	private string string_3;

	// Token: 0x04001800 RID: 6144
	private string string_4;

	// Token: 0x04001801 RID: 6145
	private DateTime dateTime_0 = DateTime.Now;

	// Token: 0x04001802 RID: 6146
	private Struct14 struct14_0;

	// Token: 0x04001803 RID: 6147
	private int int_1;

	// Token: 0x04001804 RID: 6148
	private int int_2 = 1;

	// Token: 0x04001805 RID: 6149
	public bool bool_2;

	// Token: 0x04001806 RID: 6150
	private int int_3 = 1;

	// Token: 0x04001807 RID: 6151
	private int int_4 = 1;

	// Token: 0x04001808 RID: 6152
	private int int_5 = 1301;

	// Token: 0x04001809 RID: 6153
	private int int_6 = 1;

	// Token: 0x0400180A RID: 6154
	private string string_5;

	// Token: 0x0400180B RID: 6155
	private string string_6;

	// Token: 0x0400180C RID: 6156
	private string string_7;

	// Token: 0x0400180D RID: 6157
	private string string_8;

	// Token: 0x0400180E RID: 6158
	private string string_9;

	// Token: 0x0400180F RID: 6159
	private string string_10;

	// Token: 0x04001810 RID: 6160
	private string string_11;

	// Token: 0x04001811 RID: 6161
	private string string_12;

	// Token: 0x04001812 RID: 6162
	private string string_13;

	// Token: 0x04001813 RID: 6163
	private string string_14;

	// Token: 0x04001814 RID: 6164
	private string string_15;

	// Token: 0x04001815 RID: 6165
	private string string_16;

	// Token: 0x04001816 RID: 6166
	private string string_17;

	// Token: 0x04001817 RID: 6167
	private string string_18;

	// Token: 0x04001818 RID: 6168
	private string string_19;

	// Token: 0x04001819 RID: 6169
	private string string_20;

	// Token: 0x0400181A RID: 6170
	private string string_21;

	// Token: 0x0400181B RID: 6171
	private string string_22;

	// Token: 0x0400181C RID: 6172
	private string string_23;

	// Token: 0x0400181D RID: 6173
	private string string_24;

	// Token: 0x0400181E RID: 6174
	private string string_25;

	// Token: 0x0400181F RID: 6175
	private int int_7;

	// Token: 0x04001820 RID: 6176
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x04001821 RID: 6177
	private bool bool_3;

	// Token: 0x04001822 RID: 6178
	private GClass280 gclass280_0;

	// Token: 0x04001823 RID: 6179
	private GClass280 gclass280_1;

	// Token: 0x04001824 RID: 6180
	private GClass280 gclass280_2;

	// Token: 0x04001825 RID: 6181
	private GClass280 gclass280_3;

	// Token: 0x04001826 RID: 6182
	private GClass280 gclass280_4;

	// Token: 0x04001827 RID: 6183
	private GClass280 gclass280_5;

	// Token: 0x04001828 RID: 6184
	private GClass280 gclass280_6;

	// Token: 0x04001829 RID: 6185
	private GClass280 gclass280_7;

	// Token: 0x0400182A RID: 6186
	private string string_26;

	// Token: 0x0400182B RID: 6187
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x0400182C RID: 6188
	private string string_27;

	// Token: 0x0400182D RID: 6189
	private string string_28;

	// Token: 0x0400182E RID: 6190
	private string string_29;

	// Token: 0x0400182F RID: 6191
	private SolidColorBrush solidColorBrush_1;

	// Token: 0x04001830 RID: 6192
	private string string_30;

	// Token: 0x04001831 RID: 6193
	private SolidColorBrush solidColorBrush_2;

	// Token: 0x04001832 RID: 6194
	private string string_31;

	// Token: 0x04001833 RID: 6195
	private string string_32;

	// Token: 0x04001834 RID: 6196
	private string string_33 = string.Empty;

	// Token: 0x04001835 RID: 6197
	private SolidColorBrush solidColorBrush_3 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04001836 RID: 6198
	private double double_0;

	// Token: 0x020005A4 RID: 1444
	private sealed class Class696
	{
		// Token: 0x06002564 RID: 9572 RVA: 0x0008ED7C File Offset: 0x0008CF7C
		internal void method_0()
		{
			Class523.Class699 @class = new Class523.Class699();
			@class.class696_0 = this;
			List<GClass41> list;
			switch (this.int_0)
			{
			case 0:
				list = this.class523_0.Results.List_0;
				break;
			case 1:
				list = this.class523_0.Results.List_1;
				break;
			case 2:
				list = this.class523_0.Results.List_2;
				break;
			default:
				list = null;
				break;
			}
			List<GClass41> list2 = list;
			if (list2 != null && list2.Count >= 2)
			{
				@class.class701_0 = this.class523_0.method_17(list2);
				this.class523_0.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.Dispatcher.Invoke(new Action(@class.method_0));
				return;
			}
		}

		// Token: 0x04001837 RID: 6199
		public int int_0;

		// Token: 0x04001838 RID: 6200
		public Class523 class523_0;
	}

	// Token: 0x020005A5 RID: 1445
	[StructLayout(LayoutKind.Auto)]
	private struct Struct369 : IAsyncStateMachine
	{
		// Token: 0x06002565 RID: 9573 RVA: 0x0008EE2C File Offset: 0x0008D02C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
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
					goto IL_FB;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_162;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_226;
				case 4:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_31D;
				case 5:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_348;
				case 6:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_373;
				case 7:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_3EF;
				default:
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_2, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct369>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_1, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct369>(ref awaiter, ref this);
					return;
				}
				IL_FB:
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_0, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct369>(ref awaiter, ref this);
					return;
				}
				IL_162:
				awaiter.GetResult();
				if (@class.Results.List_0.Count > 0)
				{
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_1, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct369>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_2, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 6;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct369>(ref awaiter, ref this);
						return;
					}
					goto IL_373;
				}
				IL_226:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_2);
				@class.method_24(Class298.smethod_2("InetTestResultsDesc"), Brushes.White);
				if (Class551.class753_0.method_64().GetValueOrDefault() && !this.bool_0)
				{
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_25(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_2, 200).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 4;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct369>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_25(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_1, 200).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 5;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct369>(ref awaiter, ref this);
						return;
					}
					goto IL_348;
				}
				IL_31D:
				awaiter.GetResult();
				@class.method_23();
				goto IL_39A;
				IL_348:
				awaiter.GetResult();
				@class.method_15();
				goto IL_39A;
				IL_373:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_1);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_0);
				IL_39A:
				awaiter = Task.Delay(300).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 7;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct369>(ref awaiter, ref this);
					return;
				}
				IL_3EF:
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

		// Token: 0x06002566 RID: 9574 RVA: 0x00018F9E File Offset: 0x0001719E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001839 RID: 6201
		public int int_0;

		// Token: 0x0400183A RID: 6202
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400183B RID: 6203
		public Class523 class523_0;

		// Token: 0x0400183C RID: 6204
		public bool bool_0;

		// Token: 0x0400183D RID: 6205
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005A6 RID: 1446
	private sealed class Class697
	{
		// Token: 0x06002568 RID: 9576 RVA: 0x0008F278 File Offset: 0x0008D478
		internal Task<double> method_0()
		{
			Class523.Class697.Struct370 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<double>.Create();
			@struct.class697_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class523.Class697.Struct370>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400183E RID: 6206
		public Class523 class523_0;

		// Token: 0x0400183F RID: 6207
		public CancellationToken cancellationToken_0;

		// Token: 0x04001840 RID: 6208
		public TimeSpan timeSpan_0;

		// Token: 0x020005A7 RID: 1447
		[StructLayout(LayoutKind.Auto)]
		private struct Struct370 : IAsyncStateMachine
		{
			// Token: 0x06002569 RID: 9577 RVA: 0x0008F2BC File Offset: 0x0008D4BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class523.Class697 @class = this.class697_0;
				double result;
				try
				{
					TaskAwaiter<double> awaiter;
					if (num != 0)
					{
						awaiter = @class.class523_0.gclass139_0.method_3(@class.cancellationToken_0, @class.timeSpan_0, 5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<double>, Class523.Class697.Struct370>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<double>);
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

			// Token: 0x0600256A RID: 9578 RVA: 0x00018FAC File Offset: 0x000171AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001841 RID: 6209
			public int int_0;

			// Token: 0x04001842 RID: 6210
			public AsyncTaskMethodBuilder<double> asyncTaskMethodBuilder_0;

			// Token: 0x04001843 RID: 6211
			public Class523.Class697 class697_0;

			// Token: 0x04001844 RID: 6212
			private TaskAwaiter<double> taskAwaiter_0;
		}
	}

	// Token: 0x020005A8 RID: 1448
	private sealed class Class698
	{
		// Token: 0x0600256C RID: 9580 RVA: 0x00018FBA File Offset: 0x000171BA
		internal bool method_0(Class859 class859_0)
		{
			return class859_0.Name == this.class609_0.String_0;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00018FBA File Offset: 0x000171BA
		internal bool method_1(Class859 class859_0)
		{
			return class859_0.Name == this.class609_0.String_0;
		}

		// Token: 0x04001845 RID: 6213
		public Class609 class609_0;
	}

	// Token: 0x020005A9 RID: 1449
	private sealed class Class699
	{
		// Token: 0x0600256F RID: 9583 RVA: 0x00018FD2 File Offset: 0x000171D2
		internal void method_0()
		{
			this.class696_0.class523_0.method_18(this.class696_0.int_0, this.class701_0);
		}

		// Token: 0x04001846 RID: 6214
		public Class523.Class701 class701_0;

		// Token: 0x04001847 RID: 6215
		public Class523.Class696 class696_0;
	}

	// Token: 0x020005AA RID: 1450
	[StructLayout(LayoutKind.Auto)]
	private struct Struct371 : IAsyncStateMachine
	{
		// Token: 0x06002570 RID: 9584 RVA: 0x0008F38C File Offset: 0x0008D58C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_B8;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_127;
				}
				IL_56:
				if (@class.StatusOpacity == 0.0)
				{
					@class.StatusColor = this.solidColorBrush_0;
					@class.StatusText = this.string_0;
					goto IL_12E;
				}
				@class.StatusOpacity -= 0.1;
				if (@class.StatusOpacity < 0.05)
				{
					@class.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct371>(ref awaiter, ref this);
					return;
				}
				IL_B8:
				awaiter.GetResult();
				goto IL_56;
				IL_127:
				awaiter.GetResult();
				IL_12E:
				if (@class.StatusOpacity != 1.0)
				{
					@class.StatusOpacity += 0.13333333333333333;
					if (@class.StatusOpacity > 0.95)
					{
						@class.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_127;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct371>(ref awaiter, ref this);
					return;
				}
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

		// Token: 0x06002571 RID: 9585 RVA: 0x00018FF5 File Offset: 0x000171F5
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001848 RID: 6216
		public int int_0;

		// Token: 0x04001849 RID: 6217
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400184A RID: 6218
		public Class523 class523_0;

		// Token: 0x0400184B RID: 6219
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x0400184C RID: 6220
		public string string_0;

		// Token: 0x0400184D RID: 6221
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005AB RID: 1451
	[StructLayout(LayoutKind.Auto)]
	private struct Struct372 : IAsyncStateMachine
	{
		// Token: 0x06002572 RID: 9586 RVA: 0x0008F560 File Offset: 0x0008D760
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
			try
			{
				TaskAwaiter<List<Class533>> awaiter;
				if (num != 0)
				{
					awaiter = Class184.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class533>>, Class523.Struct372>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<Class533>>);
					this.int_0 = -1;
				}
				List<Class533> result = awaiter.GetResult();
				@class.Servers = result;
				if (!Class551.class753_0.method_4().smethod_9())
				{
					if (@class.Servers.Any(new Func<Class533, bool>(Class523.Class704.class704_0.method_2)))
					{
						@class.ChoosenServer = @class.Servers.First(new Func<Class533, bool>(Class523.Class704.class704_0.method_3));
					}
				}
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

		// Token: 0x06002573 RID: 9587 RVA: 0x00019003 File Offset: 0x00017203
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400184E RID: 6222
		public int int_0;

		// Token: 0x0400184F RID: 6223
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001850 RID: 6224
		public Class523 class523_0;

		// Token: 0x04001851 RID: 6225
		private TaskAwaiter<List<Class533>> taskAwaiter_0;
	}

	// Token: 0x020005AC RID: 1452
	[StructLayout(LayoutKind.Auto)]
	private struct Struct373 : IAsyncStateMachine
	{
		// Token: 0x06002574 RID: 9588 RVA: 0x0008F68C File Offset: 0x0008D88C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_5E;
				}
				@class.method_15();
				this.int_1 = 0;
				IL_3F:
				if (@class.UploadMeanPing != null)
				{
					goto IL_A6;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct373>(ref awaiter, ref this);
					return;
				}
				IL_5E:
				awaiter.GetResult();
				int num2 = this.int_1;
				this.int_1 = num2 + 1;
				if (num2 <= 250)
				{
					goto IL_3F;
				}
				IL_A6:
				int num3 = Convert.ToInt32(@class.UnloadedOverSyncCountPing);
				int num4 = Convert.ToInt32(@class.UnloadedLostPing);
				int num5 = Convert.ToInt32(@class.UnloadedMeanPing);
				int num6 = Convert.ToInt32(@class.UnloadedMinPing);
				int num7 = Convert.ToInt32(@class.UnloadedMaxPing);
				bool flag = Math.Abs(num5 - num6) > 30 || Math.Abs(num5 - num7) > 30;
				int num8 = Convert.ToInt32(@class.DownloadOverSyncCountPing);
				int num9 = Convert.ToInt32(@class.DownloadLostPing);
				int num10 = Convert.ToInt32(@class.DownloadMeanPing);
				int num11 = Convert.ToInt32(@class.DownloadMinPing);
				int num12 = Convert.ToInt32(@class.DownloadMaxPing);
				bool flag2 = Math.Abs(num10 - num11) > 30 || Math.Abs(num10 - num12) > 30;
				int num13 = Convert.ToInt32(@class.UploadOverSyncCountPing);
				int num14 = Convert.ToInt32(@class.UploadLostPing);
				int num15 = Convert.ToInt32(@class.UploadMeanPing);
				int num16 = Convert.ToInt32(@class.UploadMinPing);
				int num17 = Convert.ToInt32(@class.UploadMaxPing);
				bool flag3 = Math.Abs(num15 - num16) > 30 || Math.Abs(num15 - num17) > 30;
				@class.MainResDesc = string.Concat(new string[]
				{
					Class298.smethod_2("CurrentMoment"),
					@class.DateString,
					" ",
					Class298.smethod_2("InternetFor"),
					" ",
					@class.ChoosenTickrate.Name,
					" "
				});
				if (num3 < 5 && num4 == 0 && !flag)
				{
					@class.MainRes = Class298.smethod_2("godlike");
					@class.MainResColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;
					@class.MainResDesc += Class298.smethod_2("INETperfect");
				}
				else if (num3 < 40 && num4 < 2)
				{
					@class.MainRes = Class298.smethod_2("Optimall");
					@class.MainResColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z52HQ7LJ6MG7CVYQ_ejd;
					@class.MainResDesc += Class298.smethod_2("INETnormal");
				}
				else
				{
					@class.MainRes = Class298.smethod_2("Bad");
					@class.MainResColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
					@class.MainResDesc += Class298.smethod_2("INETbad");
				}
				if (num3 > 40)
				{
					@class.MainPingDesc = Class298.smethod_2("PingHighNotStable") + @class.ChoosenServer.City + ".";
				}
				else if (num5 < 50)
				{
					@class.MainPingDesc = Class298.smethod_2("PingPerfect") + @class.ChoosenServer.City + ".";
				}
				else if (num5 < 100)
				{
					@class.MainPingDesc = Class298.smethod_2("PingNormal") + @class.ChoosenServer.City + ".";
				}
				else
				{
					@class.MainPingDesc = Class298.smethod_2("PingHighStable") + @class.ChoosenServer.City + ". " + Class298.smethod_2("PingHighStable2");
				}
				if (num8 < 5 && num9 == 0 && !flag2 && num5 - num10 < 30)
				{
					@class.BufferBloatMain = Class298.smethod_2("godlike");
					@class.BufferBloatMainColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;
					@class.DownloadResDesc = Class298.smethod_2("BufferbloatPerfectDownload");
				}
				else if (num8 < 40 && num9 < 2 && num5 - num10 < 30)
				{
					@class.BufferBloatMain = Class298.smethod_2("Optimall");
					@class.BufferBloatMainColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z52HQ7LJ6MG7CVYQ_ejd;
					@class.DownloadResDesc = Class298.smethod_2("BufferbloatNormalDownload");
				}
				else
				{
					@class.BufferBloatMain = Class298.smethod_2("Bad");
					@class.BufferBloatMainColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
					@class.DownloadResDesc = Class298.smethod_2("BufferbloatBadDownload");
				}
				if (num13 == 0 && num14 == 0 && !flag3)
				{
					@class.BufferBloatMain2 = Class298.smethod_2("godlike");
					@class.BufferBloatMain2Color = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;
					@class.UploadResDesc = Class298.smethod_2("BufferbloatPerfectUpload");
				}
				else if (num13 < 40 && num14 < 2 && num5 - num15 < 30)
				{
					@class.BufferBloatMain2 = Class298.smethod_2("Optimall");
					@class.BufferBloatMain2Color = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z52HQ7LJ6MG7CVYQ_ejd;
					@class.UploadResDesc = Class298.smethod_2("BufferbloatNormalUpload");
				}
				else
				{
					@class.BufferBloatMain2 = Class298.smethod_2("Bad");
					@class.BufferBloatMain2Color = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
					@class.UploadResDesc = Class298.smethod_2("BufferbloatBadUpload");
				}
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

		// Token: 0x06002575 RID: 9589 RVA: 0x00019011 File Offset: 0x00017211
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001852 RID: 6226
		public int int_0;

		// Token: 0x04001853 RID: 6227
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001854 RID: 6228
		public Class523 class523_0;

		// Token: 0x04001855 RID: 6229
		private int int_1;

		// Token: 0x04001856 RID: 6230
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005AD RID: 1453
	private sealed class Class700
	{
		// Token: 0x06002577 RID: 9591 RVA: 0x0008FBEC File Offset: 0x0008DDEC
		internal Task<double> method_0()
		{
			Class523.Class700.Struct374 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<double>.Create();
			@struct.class700_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class523.Class700.Struct374>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001857 RID: 6231
		public Class523 class523_0;

		// Token: 0x04001858 RID: 6232
		public CancellationToken cancellationToken_0;

		// Token: 0x04001859 RID: 6233
		public TimeSpan timeSpan_0;

		// Token: 0x020005AE RID: 1454
		[StructLayout(LayoutKind.Auto)]
		private struct Struct374 : IAsyncStateMachine
		{
			// Token: 0x06002578 RID: 9592 RVA: 0x0008FC30 File Offset: 0x0008DE30
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class523.Class700 @class = this.class700_0;
				double result;
				try
				{
					TaskAwaiter<double> awaiter;
					if (num != 0)
					{
						awaiter = @class.class523_0.gclass139_0.method_2(@class.cancellationToken_0, @class.timeSpan_0, 5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<double>, Class523.Class700.Struct374>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<double>);
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

			// Token: 0x06002579 RID: 9593 RVA: 0x0001901F File Offset: 0x0001721F
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400185A RID: 6234
			public int int_0;

			// Token: 0x0400185B RID: 6235
			public AsyncTaskMethodBuilder<double> asyncTaskMethodBuilder_0;

			// Token: 0x0400185C RID: 6236
			public Class523.Class700 class700_0;

			// Token: 0x0400185D RID: 6237
			private TaskAwaiter<double> taskAwaiter_0;
		}
	}

	// Token: 0x020005AF RID: 1455
	private sealed class Class701
	{
		// Token: 0x0600257A RID: 9594 RVA: 0x0008FD00 File Offset: 0x0008DF00
		public Class701(double double_5, double double_6, double double_7, double double_8, double double_9, int int_2, int int_3, bool bool_1)
		{
			this.double_0 = double_5;
			this.double_1 = double_6;
			this.double_2 = double_7;
			this.double_3 = double_8;
			this.double_4 = double_9;
			this.int_0 = int_2;
			this.int_1 = int_3;
			this.bool_0 = bool_1;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x0001902D File Offset: 0x0001722D
		public double method_0()
		{
			return this.double_0;
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00019035 File Offset: 0x00017235
		public double method_1()
		{
			return this.double_1;
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x0001903D File Offset: 0x0001723D
		public double method_2()
		{
			return this.double_2;
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00019045 File Offset: 0x00017245
		public double method_3()
		{
			return this.double_3;
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x0001904D File Offset: 0x0001724D
		public double method_4()
		{
			return this.double_4;
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00019055 File Offset: 0x00017255
		public int method_5()
		{
			return this.int_0;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x0001905D File Offset: 0x0001725D
		public int method_6()
		{
			return this.int_1;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00019065 File Offset: 0x00017265
		public bool method_7()
		{
			return this.bool_0;
		}

		// Token: 0x0400185E RID: 6238
		private readonly double double_0;

		// Token: 0x0400185F RID: 6239
		private readonly double double_1;

		// Token: 0x04001860 RID: 6240
		private readonly double double_2;

		// Token: 0x04001861 RID: 6241
		private readonly double double_3;

		// Token: 0x04001862 RID: 6242
		private readonly double double_4;

		// Token: 0x04001863 RID: 6243
		private readonly int int_0;

		// Token: 0x04001864 RID: 6244
		private readonly int int_1;

		// Token: 0x04001865 RID: 6245
		private readonly bool bool_0;
	}

	// Token: 0x020005B0 RID: 1456
	private sealed class Class702
	{
		// Token: 0x06002584 RID: 9604 RVA: 0x0001906D File Offset: 0x0001726D
		internal bool method_0(Class533 class533_0)
		{
			return class533_0.City == this.class609_0.ChoosenServer;
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0001906D File Offset: 0x0001726D
		internal bool method_1(Class533 class533_0)
		{
			return class533_0.City == this.class609_0.ChoosenServer;
		}

		// Token: 0x04001866 RID: 6246
		public Class609 class609_0;
	}

	// Token: 0x020005B1 RID: 1457
	[StructLayout(LayoutKind.Auto)]
	private struct Struct375 : IAsyncStateMachine
	{
		// Token: 0x06002586 RID: 9606 RVA: 0x0008FD50 File Offset: 0x0008DF50
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_13B;
					}
					if (@class.cancellationTokenSource_0 != null)
					{
						@class.gclass3_0.method_3();
						@class.cancellationTokenSource_0.Cancel();
					}
					@class.Results.List_2.Clear();
					@class.Results.List_1.Clear();
					@class.Results.List_2.Clear();
					@class.method_6();
					@class.method_22();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_2, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct375>(ref awaiter, ref this);
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
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_1, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct375>(ref awaiter, ref this);
					return;
				}
				IL_13B:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_0);
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

		// Token: 0x06002587 RID: 9607 RVA: 0x00019085 File Offset: 0x00017285
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001867 RID: 6247
		public int int_0;

		// Token: 0x04001868 RID: 6248
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001869 RID: 6249
		public Class523 class523_0;

		// Token: 0x0400186A RID: 6250
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005B2 RID: 1458
	[StructLayout(LayoutKind.Auto)]
	private struct Struct376 : IAsyncStateMachine
	{
		// Token: 0x06002588 RID: 9608 RVA: 0x0008FEF8 File Offset: 0x0008E0F8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
			try
			{
				TaskAwaiter<double> awaiter;
				if (num != 0)
				{
					Class523.Class700 class2 = new Class523.Class700();
					class2.class523_0 = this.class523_0;
					class2.cancellationToken_0 = this.cancellationToken_0;
					class2.timeSpan_0 = this.timeSpan_0;
					@class.IsDownloading = true;
					awaiter = Task.Run<double>(new Func<Task<double>>(class2.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<double>, Class523.Struct376>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<double>);
					this.int_0 = -1;
				}
				@class.FinalDownloadSpeed = Class249.smethod_16(awaiter.GetResult().ToString(), 2) + " Mbps";
				@class.SpeedText = "0";
				@class.method_3(TimeSpan.FromSeconds(0.5), 180.0);
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

		// Token: 0x06002589 RID: 9609 RVA: 0x00019093 File Offset: 0x00017293
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400186B RID: 6251
		public int int_0;

		// Token: 0x0400186C RID: 6252
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400186D RID: 6253
		public Class523 class523_0;

		// Token: 0x0400186E RID: 6254
		public CancellationToken cancellationToken_0;

		// Token: 0x0400186F RID: 6255
		public TimeSpan timeSpan_0;

		// Token: 0x04001870 RID: 6256
		private TaskAwaiter<double> taskAwaiter_0;
	}

	// Token: 0x020005B3 RID: 1459
	private sealed class Class703
	{
		// Token: 0x0600258B RID: 9611 RVA: 0x00090030 File Offset: 0x0008E230
		internal void method_0()
		{
			this.class523_0.SpeedText = Class249.smethod_16(this.double_0.ToString(), 2);
			int num = ((int)this.double_0 > 100) ? 100 : ((int)this.double_0);
			this.class523_0.method_3(TimeSpan.FromMilliseconds(50.0), (double)num * 1.8);
		}

		// Token: 0x04001871 RID: 6257
		public Class523 class523_0;

		// Token: 0x04001872 RID: 6258
		public double double_0;
	}

	// Token: 0x020005B4 RID: 1460
	[StructLayout(LayoutKind.Auto)]
	private struct Struct377 : IAsyncStateMachine
	{
		// Token: 0x0600258C RID: 9612 RVA: 0x00090098 File Offset: 0x0008E298
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
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
					goto IL_150;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_247;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_319;
				case 4:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_3C8;
				case 5:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_480;
				case 6:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_53C;
				case 7:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_61C;
				case 8:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_6D4;
				case 9:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_783;
				case 10:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_813;
				default:
					if (@class.bool_3)
					{
						goto IL_874;
					}
					@class.bool_3 = true;
					@class.cancellationTokenSource_0 = new CancellationTokenSource();
					this.cancellationToken_0 = @class.cancellationTokenSource_0.Token;
					@class.method_24(Class298.smethod_2("StartOptim"), Brushes.White);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_25(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_1, 200).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
					return;
				}
				IL_150:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_17(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_2);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_1);
				@class.method_24(Class298.smethod_2("InetTestStatus1"), Brushes.White);
				@class.FinalDownloadSpeed = "0 Mbps";
				@class.FinalUploadSpeed = "0 Mbps";
				@class.int_7 = 0;
				@class.Results.List_0.Clear();
				@class.gclass3_0.method_2(@class.ChoosenServer.IP, @class.ChoosenServer.Port, 12, @class.ChoosenTickrate.method_0(), 200);
				awaiter = Task.Delay(13000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
					return;
				}
				IL_247:
				awaiter.GetResult();
				@class.gclass3_0.method_3();
				@class.Results.List_0 = @class.gclass3_0.method_5();
				@class.method_15();
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					@class.bool_3 = false;
					goto IL_874;
				}
				@class.method_24(Class298.smethod_2("InetTestStatus2"), Brushes.White);
				@class.method_3(TimeSpan.FromSeconds(0.5), 0.0);
				awaiter = Task.Delay(1000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
					return;
				}
				IL_319:
				awaiter.GetResult();
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					@class.bool_3 = false;
					goto IL_874;
				}
				@class.method_24(Class298.smethod_2("InetTestStatus3"), Brushes.White);
				@class.int_7 = 1;
				@class.method_19(this.cancellationToken_0, TimeSpan.FromSeconds(14.0));
				awaiter = Task.Delay(2000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 4;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
					return;
				}
				IL_3C8:
				awaiter.GetResult();
				@class.method_24(Class298.smethod_2("InetTestStatus4"), Brushes.White);
				@class.Results.List_1.Clear();
				@class.gclass3_0.method_2(@class.ChoosenServer.IP, @class.ChoosenServer.Port, 12, @class.ChoosenTickrate.method_0(), 200);
				awaiter = Task.Delay(13000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 5;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
					return;
				}
				IL_480:
				awaiter.GetResult();
				@class.gclass3_0.method_3();
				@class.Results.List_1 = @class.gclass3_0.method_5();
				@class.method_15();
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					@class.bool_3 = false;
					goto IL_874;
				}
				this.int_1 = 0;
				IL_4EE:
				if (@class.FinalDownloadSpeed == "0 Mbps")
				{
					if (this.cancellationToken_0.IsCancellationRequested)
					{
						@class.bool_3 = false;
						goto IL_874;
					}
					int num2 = this.int_1;
					this.int_1 = num2 + 1;
					if (num2 <= 500)
					{
						awaiter = Task.Delay(20).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_53C;
						}
						this.int_0 = 6;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
						return;
					}
				}
				@class.method_24(Class298.smethod_2("InetTestStatus5"), Brushes.White);
				@class.int_7 = 2;
				@class.method_20(this.cancellationToken_0, TimeSpan.FromSeconds(14.0));
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					@class.bool_3 = false;
					goto IL_874;
				}
				awaiter = Task.Delay(2000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 7;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
					return;
				}
				goto IL_61C;
				IL_53C:
				awaiter.GetResult();
				goto IL_4EE;
				IL_61C:
				awaiter.GetResult();
				@class.method_24(Class298.smethod_2("InetTestStatus6"), Brushes.White);
				@class.Results.List_2.Clear();
				@class.gclass3_0.method_2(@class.ChoosenServer.IP, @class.ChoosenServer.Port, 12, @class.ChoosenTickrate.method_0(), 200);
				awaiter = Task.Delay(13000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 8;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
					return;
				}
				IL_6D4:
				awaiter.GetResult();
				@class.gclass3_0.method_3();
				@class.Results.List_2 = @class.gclass3_0.method_5();
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					@class.bool_3 = false;
					goto IL_874;
				}
				@class.method_15();
				this.int_2 = 0;
				IL_742:
				if (@class.FinalUploadSpeed == "0 Mbps")
				{
					int num2 = this.int_2;
					this.int_2 = num2 + 1;
					if (num2 < 600)
					{
						awaiter = Task.Delay(20).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_783;
						}
						this.int_0 = 9;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
						return;
					}
				}
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_1, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 10;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct377>(ref awaiter, ref this);
					return;
				}
				goto IL_813;
				IL_783:
				awaiter.GetResult();
				goto IL_742;
				IL_813:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_2);
				@class.method_24(Class298.smethod_2("InetTestResultsDesc"), Brushes.White);
				@class.method_21();
				@class.bool_3 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.cancellationToken_0 = default(CancellationToken);
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_874:
			this.int_0 = -2;
			this.cancellationToken_0 = default(CancellationToken);
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x000190A1 File Offset: 0x000172A1
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001873 RID: 6259
		public int int_0;

		// Token: 0x04001874 RID: 6260
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001875 RID: 6261
		public Class523 class523_0;

		// Token: 0x04001876 RID: 6262
		private CancellationToken cancellationToken_0;

		// Token: 0x04001877 RID: 6263
		private int int_1;

		// Token: 0x04001878 RID: 6264
		private int int_2;

		// Token: 0x04001879 RID: 6265
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005B5 RID: 1461
	[StructLayout(LayoutKind.Auto)]
	private struct Struct378 : IAsyncStateMachine
	{
		// Token: 0x0600258E RID: 9614 RVA: 0x00090954 File Offset: 0x0008EB54
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
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
					goto IL_E7;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_14E;
				default:
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct378>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_1, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct378>(ref awaiter, ref this);
					return;
				}
				IL_E7:
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_25(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_2, 200).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct378>(ref awaiter, ref this);
					return;
				}
				IL_14E:
				awaiter.GetResult();
				@class.method_23();
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

		// Token: 0x0600258F RID: 9615 RVA: 0x000190AF File Offset: 0x000172AF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400187A RID: 6266
		public int int_0;

		// Token: 0x0400187B RID: 6267
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400187C RID: 6268
		public Class523 class523_0;

		// Token: 0x0400187D RID: 6269
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005B6 RID: 1462
	[StructLayout(LayoutKind.Auto)]
	private struct Struct379 : IAsyncStateMachine
	{
		// Token: 0x06002590 RID: 9616 RVA: 0x00090B04 File Offset: 0x0008ED04
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
			try
			{
				TaskAwaiter<double> awaiter;
				if (num != 0)
				{
					Class523.Class697 class2 = new Class523.Class697();
					class2.class523_0 = this.class523_0;
					class2.cancellationToken_0 = this.cancellationToken_0;
					class2.timeSpan_0 = this.timeSpan_0;
					@class.IsDownloading = false;
					awaiter = Task.Run<double>(new Func<Task<double>>(class2.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<double>, Class523.Struct379>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<double>);
					this.int_0 = -1;
				}
				@class.FinalUploadSpeed = Class249.smethod_16(awaiter.GetResult().ToString(), 2) + " Mbps";
				@class.SpeedText = "0";
				@class.method_3(TimeSpan.FromSeconds(0.5), 180.0);
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

		// Token: 0x06002591 RID: 9617 RVA: 0x000190BD File Offset: 0x000172BD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400187E RID: 6270
		public int int_0;

		// Token: 0x0400187F RID: 6271
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001880 RID: 6272
		public Class523 class523_0;

		// Token: 0x04001881 RID: 6273
		public CancellationToken cancellationToken_0;

		// Token: 0x04001882 RID: 6274
		public TimeSpan timeSpan_0;

		// Token: 0x04001883 RID: 6275
		private TaskAwaiter<double> taskAwaiter_0;
	}

	// Token: 0x020005B7 RID: 1463
	[StructLayout(LayoutKind.Auto)]
	private struct Struct380 : IAsyncStateMachine
	{
		// Token: 0x06002592 RID: 9618 RVA: 0x00090C3C File Offset: 0x0008EE3C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
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
					goto IL_126;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_207;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_2CB;
				case 4:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_350;
				case 5:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_3F5;
				default:
					if (@class.bool_3)
					{
						goto IL_440;
					}
					@class.bool_3 = true;
					@class.cancellationTokenSource_0 = new CancellationTokenSource();
					this.cancellationToken_0 = @class.cancellationTokenSource_0.Token;
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct380>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_25(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.grid_1, 200).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct380>(ref awaiter, ref this);
					return;
				}
				IL_126:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_17(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_2);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd_0.button_1);
				@class.FinalDownloadSpeed = "0 Mbps";
				@class.FinalUploadSpeed = "0 Mbps";
				@class.int_7 = 0;
				@class.Results.List_0.Clear();
				@class.gclass3_0.method_2(@class.ChoosenServer.IP, @class.ChoosenServer.Port, 12, @class.ChoosenTickrate.method_0(), 200);
				awaiter = Task.Delay(13000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct380>(ref awaiter, ref this);
					return;
				}
				IL_207:
				awaiter.GetResult();
				@class.gclass3_0.method_3();
				@class.Results.List_0 = @class.gclass3_0.method_5();
				@class.method_15();
				@class.method_3(TimeSpan.FromSeconds(0.5), 0.0);
				@class.int_7 = 1;
				@class.method_19(this.cancellationToken_0, TimeSpan.FromSeconds((double)(@class.int_6 + 2)));
				awaiter = Task.Delay(1000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct380>(ref awaiter, ref this);
					return;
				}
				IL_2CB:
				awaiter.GetResult();
				@class.Results.List_1.Clear();
				@class.method_15();
				this.int_1 = 0;
				IL_30F:
				if (@class.FinalDownloadSpeed == "0 Mbps")
				{
					int num2 = this.int_1;
					this.int_1 = num2 + 1;
					if (num2 <= 500)
					{
						awaiter = Task.Delay(20).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_350;
						}
						this.int_0 = 4;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct380>(ref awaiter, ref this);
						return;
					}
				}
				@class.int_7 = 2;
				@class.method_20(this.cancellationToken_0, TimeSpan.FromSeconds((double)(@class.int_6 + 2)));
				awaiter = Task.Delay(1000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 5;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct380>(ref awaiter, ref this);
					return;
				}
				goto IL_3F5;
				IL_350:
				awaiter.GetResult();
				goto IL_30F;
				IL_3F5:
				awaiter.GetResult();
				@class.Results.List_2.Clear();
				@class.method_15();
				@class.bool_3 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.cancellationToken_0 = default(CancellationToken);
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_440:
			this.int_0 = -2;
			this.cancellationToken_0 = default(CancellationToken);
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x000190CB File Offset: 0x000172CB
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001884 RID: 6276
		public int int_0;

		// Token: 0x04001885 RID: 6277
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001886 RID: 6278
		public Class523 class523_0;

		// Token: 0x04001887 RID: 6279
		private CancellationToken cancellationToken_0;

		// Token: 0x04001888 RID: 6280
		private int int_1;

		// Token: 0x04001889 RID: 6281
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005B8 RID: 1464
	[StructLayout(LayoutKind.Auto)]
	private struct Struct381 : IAsyncStateMachine
	{
		// Token: 0x06002594 RID: 9620 RVA: 0x000910C4 File Offset: 0x0008F2C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class523 @class = this.class523_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_7A;
				}
				this.class702_0 = new Class523.Class702();
				this.class702_0.class609_0 = this.class609_0;
				this.int_1 = 0;
				IL_54:
				if (@class.Servers.Count != 1)
				{
					goto IL_BB;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class523.Struct381>(ref awaiter, ref this);
					return;
				}
				IL_7A:
				awaiter.GetResult();
				int num2 = this.int_1;
				this.int_1 = num2 + 1;
				if (num2 <= 100)
				{
					goto IL_54;
				}
				IL_BB:
				if (@class.Servers.Any(new Func<Class533, bool>(this.class702_0.method_0)))
				{
					@class.ChoosenServer = @class.Servers.First(new Func<Class533, bool>(this.class702_0.method_1));
				}
				else
				{
					@class.ChoosenTickrate = @class.TestingTickrates[0];
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class702_0 = null;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class702_0 = null;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000190D9 File Offset: 0x000172D9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400188A RID: 6282
		public int int_0;

		// Token: 0x0400188B RID: 6283
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400188C RID: 6284
		public Class609 class609_0;

		// Token: 0x0400188D RID: 6285
		public Class523 class523_0;

		// Token: 0x0400188E RID: 6286
		private Class523.Class702 class702_0;

		// Token: 0x0400188F RID: 6287
		private int int_1;

		// Token: 0x04001890 RID: 6288
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005B9 RID: 1465
	[Serializable]
	private sealed class Class704
	{
		// Token: 0x06002598 RID: 9624 RVA: 0x000190F3 File Offset: 0x000172F3
		internal long method_0(GClass41 gclass41_0)
		{
			return gclass41_0.SendTime;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000190FB File Offset: 0x000172FB
		internal double method_1(GClass41 gclass41_0)
		{
			return gclass41_0.Ping;
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00019103 File Offset: 0x00017303
		internal bool method_2(Class533 class533_0)
		{
			return class533_0.City == Class551.class753_0.method_4();
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00019103 File Offset: 0x00017303
		internal bool method_3(Class533 class533_0)
		{
			return class533_0.City == Class551.class753_0.method_4();
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000190FB File Offset: 0x000172FB
		internal double method_4(GClass41 gclass41_0)
		{
			return gclass41_0.Ping;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x0001911A File Offset: 0x0001731A
		internal bool method_5(GClass41 gclass41_0)
		{
			return !gclass41_0.Success;
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00019125 File Offset: 0x00017325
		internal bool method_6(Class523 class523_0)
		{
			return class523_0.IsChoosen;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0000311B File Offset: 0x0000131B
		internal void method_7(object object_0)
		{
		}

		// Token: 0x04001891 RID: 6289
		public static readonly Class523.Class704 class704_0 = new Class523.Class704();

		// Token: 0x04001892 RID: 6290
		public static Func<GClass41, long> func_0;

		// Token: 0x04001893 RID: 6291
		public static Func<GClass41, double> func_1;

		// Token: 0x04001894 RID: 6292
		public static Func<Class533, bool> func_2;

		// Token: 0x04001895 RID: 6293
		public static Func<Class533, bool> func_3;

		// Token: 0x04001896 RID: 6294
		public static Func<GClass41, double> func_4;

		// Token: 0x04001897 RID: 6295
		public static Func<GClass41, bool> func_5;

		// Token: 0x04001898 RID: 6296
		public static Func<Class523, bool> func_6;

		// Token: 0x04001899 RID: 6297
		public static Action<object> action_0;
	}
}
