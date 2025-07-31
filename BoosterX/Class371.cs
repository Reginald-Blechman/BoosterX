using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using ImageProcessor;

// Token: 0x02000310 RID: 784
internal sealed class Class371
{
	// Token: 0x06001439 RID: 5177 RVA: 0x000638DC File Offset: 0x00061ADC
	public static Bitmap smethod_0(string string_0)
	{
		BitmapImage bitmapImage = new BitmapImage();
		bitmapImage.BeginInit();
		bitmapImage.UriSource = new Uri(string_0, UriKind.RelativeOrAbsolute);
		bitmapImage.EndInit();
		MemoryStream memoryStream = new MemoryStream();
		Bitmap result;
		try
		{
			new PngBitmapEncoder
			{
				Frames = 
				{
					BitmapFrame.Create(bitmapImage)
				}
			}.Save(memoryStream);
			result = new Bitmap(memoryStream);
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x0006394C File Offset: 0x00061B4C
	public static byte[] smethod_1(string string_0)
	{
		BitmapImage bitmapImage = new BitmapImage();
		bitmapImage.BeginInit();
		bitmapImage.UriSource = new Uri(string_0, UriKind.RelativeOrAbsolute);
		bitmapImage.EndInit();
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			new PngBitmapEncoder
			{
				Frames = 
				{
					BitmapFrame.Create(bitmapImage)
				}
			}.Save(memoryStream);
			result = memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x000639BC File Offset: 0x00061BBC
	private static ValueTuple<double, double, double> smethod_2(double double_0, double double_1, double double_2)
	{
		double_0 /= 255.0;
		double_1 /= 255.0;
		double_2 /= 255.0;
		double num = Math.Max(double_0, Math.Max(double_1, double_2));
		double num2 = Math.Min(double_0, Math.Min(double_1, double_2));
		double num3 = (num + num2) / 2.0;
		double item;
		double num5;
		if (num == num2)
		{
			double num4 = 0.0;
			item = (double)0f;
			num5 = num4;
		}
		else
		{
			double num6 = num - num2;
			item = ((num3 > 0.5) ? (num6 / (2.0 - num - num2)) : (num6 / (num + num2)));
			if (num == double_0)
			{
				num5 = (double_1 - double_2) / num6 + (double)((double_1 < double_2) ? 6 : 0);
			}
			else if (num == double_1)
			{
				num5 = (double_2 - double_0) / num6 + 2.0;
			}
			else
			{
				num5 = (double_0 - double_1) / num6 + 4.0;
			}
			num5 /= 6.0;
		}
		return new ValueTuple<double, double, double>(num5 * 360.0, item, num3 * 255.0);
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x00063AC8 File Offset: 0x00061CC8
	private static ValueTuple<byte, byte, byte> smethod_3(double double_0, double double_1, double double_2)
	{
		double num;
		double num2;
		double num3;
		if (double_1 == 0.0)
		{
			num = double_2;
			num2 = double_2;
			num3 = double_2;
		}
		else
		{
			object obj = new Func<double, double, double, double>(Class371.Class373.class373_0.method_0);
			double num4 = (double_2 < 128.0) ? (double_2 * (1.0 + double_1)) : (double_2 + double_1 - double_2 * double_1);
			double arg = 2.0 * double_2 - num4;
			object obj2 = obj;
			num3 = obj2(arg, num4, double_0 / 360.0 + 0.3333333333333333);
			num2 = obj2(arg, num4, double_0 / 360.0);
			num = obj2(arg, num4, double_0 / 360.0 - 0.3333333333333333);
		}
		return new ValueTuple<byte, byte, byte>((byte)(num3 * 255.0), (byte)(num2 * 255.0), (byte)(num * 255.0));
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x00063BB8 File Offset: 0x00061DB8
	public static Task<BitmapImage> smethod_4(BitmapImage bitmapImage_0, int int_0, int int_1, int int_2)
	{
		Class371.Struct173 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<BitmapImage>.Create();
		@struct.bitmapImage_0 = bitmapImage_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class371.Struct173>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x02000311 RID: 785
	private sealed class Class372
	{
		// Token: 0x0600143F RID: 5183 RVA: 0x00063BFC File Offset: 0x00061DFC
		internal BitmapImage method_0()
		{
			PngBitmapEncoder pngBitmapEncoder = new PngBitmapEncoder();
			pngBitmapEncoder.Frames.Add(BitmapFrame.Create(this.bitmapImage_0));
			MemoryStream memoryStream = new MemoryStream();
			byte[] buffer;
			try
			{
				pngBitmapEncoder.Save(memoryStream);
				buffer = memoryStream.ToArray();
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
			MemoryStream memoryStream2 = new MemoryStream(buffer);
			BitmapImage result;
			try
			{
				MemoryStream memoryStream3 = new MemoryStream();
				try
				{
					ImageFactory imageFactory = new ImageFactory(true);
					try
					{
						imageFactory.Load(memoryStream2).Saturation(100).Contrast(-10).ReplaceColor(Color.Black, Color.FromArgb(0, 0, 0, 0), 100).ReplaceColor(Color.White, Color.FromArgb(0, 0, 0, 0), 100).Save(memoryStream3);
					}
					finally
					{
						imageFactory.Dispose();
					}
					BitmapImage bitmapImage = new BitmapImage();
					bitmapImage.BeginInit();
					bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
					bitmapImage.StreamSource = new MemoryStream(memoryStream3.ToArray());
					bitmapImage.EndInit();
					bitmapImage.Freeze();
					result = bitmapImage;
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
			return result;
		}

		// Token: 0x04000DA2 RID: 3490
		public BitmapImage bitmapImage_0;
	}

	// Token: 0x02000312 RID: 786
	[StructLayout(LayoutKind.Auto)]
	private struct Struct173 : IAsyncStateMachine
	{
		// Token: 0x06001440 RID: 5184 RVA: 0x00063D24 File Offset: 0x00061F24
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			BitmapImage result;
			try
			{
				TaskAwaiter<BitmapImage> awaiter;
				if (num != 0)
				{
					awaiter = Task.Run<BitmapImage>(new Func<BitmapImage>(new Class371.Class372
					{
						bitmapImage_0 = this.bitmapImage_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapImage>, Class371.Struct173>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<BitmapImage>);
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

		// Token: 0x06001441 RID: 5185 RVA: 0x0000E284 File Offset: 0x0000C484
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000DA3 RID: 3491
		public int int_0;

		// Token: 0x04000DA4 RID: 3492
		public AsyncTaskMethodBuilder<BitmapImage> asyncTaskMethodBuilder_0;

		// Token: 0x04000DA5 RID: 3493
		public BitmapImage bitmapImage_0;

		// Token: 0x04000DA6 RID: 3494
		private TaskAwaiter<BitmapImage> taskAwaiter_0;
	}

	// Token: 0x02000313 RID: 787
	[Serializable]
	private sealed class Class373
	{
		// Token: 0x06001444 RID: 5188 RVA: 0x00063DEC File Offset: 0x00061FEC
		internal double method_0(double double_0, double double_1, double double_2)
		{
			if (double_2 < 0.0)
			{
				double_2 += 1.0;
			}
			if (double_2 > 1.0)
			{
				double_2 -= 1.0;
			}
			if (double_2 < 0.16666666666666666)
			{
				return double_0 + (double_1 - double_0) * 6.0 * double_2;
			}
			if (double_2 < 0.5)
			{
				return double_1;
			}
			if (double_2 < 0.6666666666666666)
			{
				return double_0 + (double_1 - double_0) * (0.6666666666666666 - double_2) * 6.0;
			}
			return double_0;
		}

		// Token: 0x04000DA7 RID: 3495
		public static readonly Class371.Class373 class373_0 = new Class371.Class373();

		// Token: 0x04000DA8 RID: 3496
		public static Func<double, double, double, double> func_0;
	}
}
