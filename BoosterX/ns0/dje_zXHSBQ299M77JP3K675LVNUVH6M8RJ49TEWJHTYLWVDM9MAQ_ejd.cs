using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ns0
{
	// Token: 0x020008CD RID: 2253
	public sealed class dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd : Image
	{
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x0002108C File Offset: 0x0001F28C
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x0002109E File Offset: 0x0001F29E
		public Uri WebpSource
		{
			get
			{
				return (Uri)base.GetValue(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.dependencyProperty_0);
			}
			set
			{
				base.SetValue(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.dependencyProperty_0, value);
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x000210AC File Offset: 0x0001F2AC
		// (set) Token: 0x0600350D RID: 13581 RVA: 0x000210BE File Offset: 0x0001F2BE
		public CornerRadius CornerRadius
		{
			get
			{
				return (CornerRadius)base.GetValue(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.dependencyProperty_1);
			}
			set
			{
				base.SetValue(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.dependencyProperty_1, value);
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x000210D1 File Offset: 0x0001F2D1
		// (set) Token: 0x0600350F RID: 13583 RVA: 0x000210E3 File Offset: 0x0001F2E3
		public int Blur
		{
			get
			{
				return (int)base.GetValue(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.dependencyProperty_2);
			}
			set
			{
				base.SetValue(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.dependencyProperty_2, value);
			}
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x000CF3DC File Offset: 0x000CD5DC
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd = dependencyObject_0 as dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd;
			Uri uri = dependencyPropertyChangedEventArgs_0.NewValue as Uri;
			if (uri == null)
			{
				dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Source = null;
				return;
			}
			if (DesignerProperties.GetIsInDesignMode(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd))
			{
				try
				{
					dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Source = Class307.smethod_1(uri, dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Blur);
					return;
				}
				catch
				{
					dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Source = null;
					return;
				}
			}
			dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.smethod_2(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd);
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x000CF44C File Offset: 0x000CD64C
		private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd = dependencyObject_0 as dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd;
			if (((dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd != null) ? dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.WebpSource : null) != null)
			{
				if (DesignerProperties.GetIsInDesignMode(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd))
				{
					try
					{
						dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Source = Class307.smethod_1(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.WebpSource, dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Blur);
						return;
					}
					catch
					{
						dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Source = null;
						return;
					}
				}
				dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.smethod_2(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd);
			}
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x000CF4B8 File Offset: 0x000CD6B8
		private static Task smethod_2(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0)
		{
			dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Struct712 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0 = dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Struct712>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x000210F6 File Offset: 0x0001F2F6
		private static void smethod_3(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd = dependencyObject_0 as dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd;
			if (dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd == null)
			{
				return;
			}
			dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.method_0();
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x00021108 File Offset: 0x0001F308
		protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
		{
			base.OnRenderSizeChanged(sizeInfo);
			this.method_0();
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x000CF4FC File Offset: 0x000CD6FC
		private void method_0()
		{
			Rect rect = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
			double topLeft = this.CornerRadius.TopLeft;
			base.Clip = new RectangleGeometry(rect, topLeft, topLeft);
		}

		// Token: 0x04002678 RID: 9848
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("WebpSource", typeof(Uri), typeof(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.smethod_0)));

		// Token: 0x04002679 RID: 9849
		public static readonly DependencyProperty dependencyProperty_1 = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd), new FrameworkPropertyMetadata(default(CornerRadius), FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.smethod_3)));

		// Token: 0x0400267A RID: 9850
		public static readonly DependencyProperty dependencyProperty_2 = DependencyProperty.Register("Blur", typeof(int), typeof(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.smethod_1)));

		// Token: 0x020008CE RID: 2254
		[StructLayout(LayoutKind.Auto)]
		private struct Struct712 : IAsyncStateMachine
		{
			// Token: 0x06003516 RID: 13590 RVA: 0x000CF54C File Offset: 0x000CD74C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					Uri webpSource;
					int blur;
					if (num != 0)
					{
						webpSource = this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0.WebpSource;
						blur = this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0.Blur;
						if (!Path.GetExtension(webpSource.ToString()).Equals(".webp", StringComparison.OrdinalIgnoreCase))
						{
							try
							{
								BitmapImage bitmapImage = new BitmapImage();
								bitmapImage.BeginInit();
								bitmapImage.UriSource = webpSource;
								bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
								bitmapImage.EndInit();
								bitmapImage.Freeze();
								this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0.Source = bitmapImage;
								goto IL_101;
							}
							catch
							{
								this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0.Source = null;
								goto IL_101;
							}
						}
					}
					try
					{
						TaskAwaiter<BitmapSource> awaiter;
						if (num != 0)
						{
							awaiter = Class307.smethod_0(webpSource, blur).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapSource>, dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd.Struct712>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<BitmapSource>);
							this.int_0 = -1;
						}
						BitmapSource result = awaiter.GetResult();
						this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0.Source = result;
					}
					catch
					{
						this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0.Source = null;
					}
					IL_101:;
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

			// Token: 0x06003517 RID: 13591 RVA: 0x00021117 File Offset: 0x0001F317
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400267B RID: 9851
			public int int_0;

			// Token: 0x0400267C RID: 9852
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400267D RID: 9853
			public dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0;

			// Token: 0x0400267E RID: 9854
			private TaskAwaiter<BitmapSource> taskAwaiter_0;
		}
	}
}
