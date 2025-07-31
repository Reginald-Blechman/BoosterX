using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Threading;
using SkiaSharp;

// Token: 0x02000295 RID: 661
internal sealed class Class307
{
	// Token: 0x060011B6 RID: 4534 RVA: 0x0005A010 File Offset: 0x00058210
	public static Task<BitmapSource> smethod_0(Uri uri_0, int int_0)
	{
		Class307.Struct146 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<BitmapSource>.Create();
		@struct.uri_0 = uri_0;
		@struct.int_1 = int_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class307.Struct146>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x0005A05C File Offset: 0x0005825C
	public static BitmapSource smethod_1(Uri uri_0, int int_0)
	{
		BitmapSource result;
		try
		{
			SKBitmap skbitmap_ = Class307.smethod_3(uri_0);
			if (int_0 > 0)
			{
				skbitmap_ = Class307.smethod_4(skbitmap_, int_0);
			}
			result = Class307.smethod_5(skbitmap_);
		}
		catch
		{
			result = new BitmapImage();
		}
		return result;
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x0005A0A0 File Offset: 0x000582A0
	public static Task<ImageBrush> smethod_2(Uri uri_0, int int_0)
	{
		Class307.Struct145 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ImageBrush>.Create();
		@struct.uri_0 = uri_0;
		@struct.int_1 = int_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class307.Struct145>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x0005A0EC File Offset: 0x000582EC
	private static SKBitmap smethod_3(Uri uri_0)
	{
		StreamResourceInfo resourceStream = Application.GetResourceStream(uri_0);
		if (resourceStream == null)
		{
			throw new FileNotFoundException(string.Format("Resource not found: {0}", uri_0));
		}
		SKBitmap result;
		using (Stream stream = resourceStream.Stream)
		{
			result = SKBitmap.Decode(stream);
		}
		return result;
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x0005A140 File Offset: 0x00058340
	private static SKBitmap smethod_4(SKBitmap skbitmap_0, int int_0)
	{
		SKBitmap result;
		using (SKSurface sksurface = SKSurface.Create(new SKImageInfo(skbitmap_0.Width, skbitmap_0.Height)))
		{
			SKCanvas canvas = sksurface.Canvas;
			canvas.Clear(SKColors.Transparent);
			SKPaint skpaint = new SKPaint();
			try
			{
				skpaint.ImageFilter = SKImageFilter.CreateBlur((float)int_0, (float)int_0);
				canvas.DrawBitmap(skbitmap_0, new SKPoint(0f, 0f), skpaint);
			}
			finally
			{
				skpaint.Dispose();
			}
			canvas.Flush();
			using (SKImage skimage = sksurface.Snapshot())
			{
				result = SKBitmap.FromImage(skimage);
			}
		}
		return result;
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x0005A200 File Offset: 0x00058400
	private static BitmapSource smethod_5(SKBitmap skbitmap_0)
	{
		Class307.Class310 @class = new Class307.Class310();
		SKImage skimage = SKImage.FromBitmap(skbitmap_0);
		@class.byte_0 = skimage.Encode(4, 100).ToArray();
		Application application = Application.Current;
		Dispatcher dispatcher;
		if (application != null)
		{
			if ((dispatcher = application.Dispatcher) != null)
			{
				goto IL_3B;
			}
		}
		dispatcher = Dispatcher.CurrentDispatcher;
		IL_3B:
		return dispatcher.Invoke<BitmapImage>(new Func<BitmapImage>(@class.method_0));
	}

	// Token: 0x02000296 RID: 662
	[StructLayout(LayoutKind.Auto)]
	private struct Struct145 : IAsyncStateMachine
	{
		// Token: 0x060011BC RID: 4540 RVA: 0x0005A25C File Offset: 0x0005845C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ImageBrush result2;
			try
			{
				Class307.Class308 @class;
				if (num > 1)
				{
					@class = new Class307.Class308();
					@class.uri_0 = this.uri_0;
					@class.int_0 = this.int_1;
				}
				try
				{
					TaskAwaiter<SKBitmap> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<SKBitmap>);
							this.int_0 = -1;
							goto IL_141;
						}
						this.class309_0 = new Class307.Class309();
						this.class309_0.class308_0 = @class;
						awaiter = Task.Run<SKBitmap>(new Func<SKBitmap>(this.class309_0.class308_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<SKBitmap>, Class307.Struct145>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<SKBitmap>);
						this.int_0 = -1;
					}
					SKBitmap result = awaiter.GetResult();
					this.class309_0.skbitmap_0 = result;
					if (this.class309_0.class308_0.int_0 <= 0)
					{
						goto IL_155;
					}
					awaiter = Task.Run<SKBitmap>(new Func<SKBitmap>(this.class309_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<SKBitmap>, Class307.Struct145>(ref awaiter, ref this);
						return;
					}
					IL_141:
					result = awaiter.GetResult();
					this.class309_0.skbitmap_0 = result;
					IL_155:
					result2 = new ImageBrush(Class307.smethod_5(this.class309_0.skbitmap_0));
				}
				catch
				{
					result2 = null;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0000CDAE File Offset: 0x0000AFAE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B02 RID: 2818
		public int int_0;

		// Token: 0x04000B03 RID: 2819
		public AsyncTaskMethodBuilder<ImageBrush> asyncTaskMethodBuilder_0;

		// Token: 0x04000B04 RID: 2820
		public Uri uri_0;

		// Token: 0x04000B05 RID: 2821
		public int int_1;

		// Token: 0x04000B06 RID: 2822
		private Class307.Class309 class309_0;

		// Token: 0x04000B07 RID: 2823
		private TaskAwaiter<SKBitmap> taskAwaiter_0;
	}

	// Token: 0x02000297 RID: 663
	private sealed class Class308
	{
		// Token: 0x060011BF RID: 4543 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		internal SKBitmap method_0()
		{
			return Class307.smethod_3(this.uri_0);
		}

		// Token: 0x04000B08 RID: 2824
		public Uri uri_0;

		// Token: 0x04000B09 RID: 2825
		public int int_0;
	}

	// Token: 0x02000298 RID: 664
	private sealed class Class309
	{
		// Token: 0x060011C1 RID: 4545 RVA: 0x0000CDC9 File Offset: 0x0000AFC9
		internal SKBitmap method_0()
		{
			return Class307.smethod_4(this.skbitmap_0, this.class308_0.int_0);
		}

		// Token: 0x04000B0A RID: 2826
		public SKBitmap skbitmap_0;

		// Token: 0x04000B0B RID: 2827
		public Class307.Class308 class308_0;
	}

	// Token: 0x02000299 RID: 665
	[StructLayout(LayoutKind.Auto)]
	private struct Struct146 : IAsyncStateMachine
	{
		// Token: 0x060011C2 RID: 4546 RVA: 0x0005A440 File Offset: 0x00058640
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			BitmapSource result2;
			try
			{
				Class307.Class312 @class;
				if (num > 1)
				{
					@class = new Class307.Class312();
					@class.uri_0 = this.uri_0;
					@class.int_0 = this.int_1;
					if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
					{
						goto IL_184;
					}
				}
				try
				{
					TaskAwaiter<SKBitmap> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<SKBitmap>);
							this.int_0 = -1;
							goto IL_152;
						}
						this.class311_0 = new Class307.Class311();
						this.class311_0.class312_0 = @class;
						awaiter = Task.Run<SKBitmap>(new Func<SKBitmap>(this.class311_0.class312_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<SKBitmap>, Class307.Struct146>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<SKBitmap>);
						this.int_0 = -1;
					}
					SKBitmap result = awaiter.GetResult();
					this.class311_0.skbitmap_0 = result;
					if (this.class311_0.class312_0.int_0 <= 0)
					{
						goto IL_168;
					}
					awaiter = Task.Run<SKBitmap>(new Func<SKBitmap>(this.class311_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<SKBitmap>, Class307.Struct146>(ref awaiter, ref this);
						return;
					}
					IL_152:
					result = awaiter.GetResult();
					this.class311_0.skbitmap_0 = result;
					IL_168:
					result2 = Class307.smethod_5(this.class311_0.skbitmap_0);
					goto IL_1B1;
				}
				catch
				{
					result2 = new BitmapImage();
					goto IL_1B1;
				}
				IL_184:
				result2 = Class307.smethod_1(@class.uri_0, @class.int_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1B1:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0000CDE1 File Offset: 0x0000AFE1
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B0C RID: 2828
		public int int_0;

		// Token: 0x04000B0D RID: 2829
		public AsyncTaskMethodBuilder<BitmapSource> asyncTaskMethodBuilder_0;

		// Token: 0x04000B0E RID: 2830
		public Uri uri_0;

		// Token: 0x04000B0F RID: 2831
		public int int_1;

		// Token: 0x04000B10 RID: 2832
		private Class307.Class311 class311_0;

		// Token: 0x04000B11 RID: 2833
		private TaskAwaiter<SKBitmap> taskAwaiter_0;
	}

	// Token: 0x0200029A RID: 666
	private sealed class Class310
	{
		// Token: 0x060011C5 RID: 4549 RVA: 0x0000CDEF File Offset: 0x0000AFEF
		internal BitmapImage method_0()
		{
			BitmapImage bitmapImage = new BitmapImage();
			bitmapImage.BeginInit();
			bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
			bitmapImage.StreamSource = new MemoryStream(this.byte_0);
			bitmapImage.EndInit();
			bitmapImage.Freeze();
			return bitmapImage;
		}

		// Token: 0x04000B12 RID: 2834
		public byte[] byte_0;
	}

	// Token: 0x0200029B RID: 667
	private sealed class Class311
	{
		// Token: 0x060011C7 RID: 4551 RVA: 0x0000CE20 File Offset: 0x0000B020
		internal SKBitmap method_0()
		{
			return Class307.smethod_4(this.skbitmap_0, this.class312_0.int_0);
		}

		// Token: 0x04000B13 RID: 2835
		public SKBitmap skbitmap_0;

		// Token: 0x04000B14 RID: 2836
		public Class307.Class312 class312_0;
	}

	// Token: 0x0200029C RID: 668
	private sealed class Class312
	{
		// Token: 0x060011C9 RID: 4553 RVA: 0x0000CE38 File Offset: 0x0000B038
		internal SKBitmap method_0()
		{
			return Class307.smethod_3(this.uri_0);
		}

		// Token: 0x04000B15 RID: 2837
		public Uri uri_0;

		// Token: 0x04000B16 RID: 2838
		public int int_0;
	}
}
