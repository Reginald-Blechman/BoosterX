using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using ImageProcessor;

// Token: 0x0200024B RID: 587
public sealed class GClass173 : GClass162
{
	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x06000FED RID: 4077 RVA: 0x0000BA6C File Offset: 0x00009C6C
	// (set) Token: 0x06000FEE RID: 4078 RVA: 0x0000BA74 File Offset: 0x00009C74
	public BitmapSource Background
	{
		get
		{
			return this.bitmapSource_2;
		}
		set
		{
			this.bitmapSource_2 = value;
			base.method_0("Background");
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0000BA89 File Offset: 0x00009C89
	// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x0000BA91 File Offset: 0x00009C91
	public string BackgroundMain
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			this.method_2();
			this.byte_0 = null;
		}
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0000BAA7 File Offset: 0x00009CA7
	// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x0000BAAF File Offset: 0x00009CAF
	public string Stroke
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = "pack://application:,,,/BoosterX;component" + value;
			base.method_0("Stroke");
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0000BACF File Offset: 0x00009CCF
	// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x0000BAD7 File Offset: 0x00009CD7
	public GClass280 NavigateTo
	{
		[CompilerGenerated]
		get
		{
			return this.gclass280_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass280_0 = value;
		}
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x00055A8C File Offset: 0x00053C8C
	public void method_2()
	{
		if (this.bitmapSource_1 != null)
		{
			this.Background = this.bitmapSource_0;
			return;
		}
		this.bitmapSource_0 = new BitmapImage(new Uri("pack://application:,,,/BoosterX;component" + this.string_1));
		this.bitmapSource_0.Freeze();
		this.Background = this.bitmapSource_0;
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x0000BAE0 File Offset: 0x00009CE0
	public void method_3()
	{
		if (this.bitmapSource_1 != null)
		{
			this.Background = this.bitmapSource_1;
			return;
		}
		this.method_4(-80);
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00055AE8 File Offset: 0x00053CE8
	private void method_4(int int_0)
	{
		if (this.byte_0 == null)
		{
			BitmapImage bitmapImage = new BitmapImage(new Uri("pack://application:,,,/BoosterX;component" + this.string_1));
			bitmapImage.Freeze();
			PngBitmapEncoder pngBitmapEncoder = new PngBitmapEncoder();
			pngBitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapImage));
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				pngBitmapEncoder.Save(memoryStream);
				this.byte_0 = memoryStream.ToArray();
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
		}
		MemoryStream memoryStream2 = new MemoryStream(this.byte_0);
		try
		{
			MemoryStream memoryStream3 = new MemoryStream();
			try
			{
				ImageFactory imageFactory = new ImageFactory(true);
				try
				{
					imageFactory.Load(memoryStream2).Saturation(int_0).Save(memoryStream3);
				}
				finally
				{
					imageFactory.Dispose();
				}
				BitmapImage bitmapImage2 = new BitmapImage();
				bitmapImage2.BeginInit();
				bitmapImage2.CacheOption = BitmapCacheOption.OnLoad;
				bitmapImage2.StreamSource = new MemoryStream(memoryStream3.ToArray());
				bitmapImage2.EndInit();
				bitmapImage2.Freeze();
				this.bitmapSource_1 = bitmapImage2;
				this.Background = this.bitmapSource_1;
			}
			finally
			{
				((IDisposable)memoryStream3).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream2).Dispose();
		}
	}

	// Token: 0x04000A1C RID: 2588
	private BitmapSource bitmapSource_0;

	// Token: 0x04000A1D RID: 2589
	private BitmapSource bitmapSource_1;

	// Token: 0x04000A1E RID: 2590
	private BitmapSource bitmapSource_2;

	// Token: 0x04000A1F RID: 2591
	public string string_0;

	// Token: 0x04000A20 RID: 2592
	private string string_1;

	// Token: 0x04000A21 RID: 2593
	public string string_2;

	// Token: 0x04000A22 RID: 2594
	private GClass280 gclass280_0;

	// Token: 0x04000A23 RID: 2595
	private byte[] byte_0;
}
