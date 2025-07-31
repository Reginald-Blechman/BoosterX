using System;
using System.Diagnostics;
using System.Threading;

// Token: 0x0200033E RID: 830
internal static class Class393
{
	// Token: 0x0200033F RID: 831
	internal sealed class Class394 : Interface14<int>, Interface19<int>, Interface7, Interface12, Interface13
	{
		// Token: 0x0600157B RID: 5499 RVA: 0x0000EC9F File Offset: 0x0000CE9F
		[DebuggerHidden]
		public Class394(int int_4)
		{
			this.int_0 = int_4;
			this.int_2 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0000ECBE File Offset: 0x0000CEBE
		[DebuggerHidden]
		void Interface12.imethod_0()
		{
			this.int_0 = -2;
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00065750 File Offset: 0x00063950
		bool Interface13.imethod_1()
		{
			int num = this.int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				this.int_3 += this.int_3;
				if (this.int_3 == 64)
				{
					this.int_3 = 5;
				}
			}
			else
			{
				this.int_0 = -1;
				this.int_3 = 1;
			}
			this.int_1 = this.int_3;
			this.int_0 = 1;
			return true;
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
		[DebuggerHidden]
		int Interface19<int>.imethod_3()
		{
			return this.int_1;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000031EC File Offset: 0x000013EC
		[DebuggerHidden]
		void Interface13.imethod_2()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		[DebuggerHidden]
		object Interface13.imethod_0()
		{
			return this.int_1;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000657BC File Offset: 0x000639BC
		[DebuggerHidden]
		Interface19<int> Interface14<int>.GetEnumerator()
		{
			Class393.Class394 result;
			if (this.int_0 == -2 && this.int_2 == Thread.CurrentThread.ManagedThreadId)
			{
				this.int_0 = 0;
				result = this;
			}
			else
			{
				result = new Class393.Class394(0);
			}
			return result;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0000ECDD File Offset: 0x0000CEDD
		[DebuggerHidden]
		Interface13 Interface7.imethod_0()
		{
			return this.Interface14<System.Int32>.GetEnumerator();
		}

		// Token: 0x04000E4D RID: 3661
		private int int_0;

		// Token: 0x04000E4E RID: 3662
		private int int_1;

		// Token: 0x04000E4F RID: 3663
		private int int_2;

		// Token: 0x04000E50 RID: 3664
		private int int_3;
	}

	// Token: 0x02000340 RID: 832
	internal sealed class Class395 : Interface14<int>, Interface19<int>, Interface7, Interface12, Interface13
	{
		// Token: 0x06001583 RID: 5507 RVA: 0x0000ECE5 File Offset: 0x0000CEE5
		[DebuggerHidden]
		public Class395(int int_6)
		{
			this.int_0 = int_6;
			this.int_2 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000657F8 File Offset: 0x000639F8
		[DebuggerHidden]
		void Interface12.imethod_0()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.interface19_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00065840 File Offset: 0x00063A40
		bool Interface13.imethod_1()
		{
			bool result;
			try
			{
				int num = this.int_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
					if (this.int_5 == 0)
					{
						result = false;
						this.method_0();
						return result;
					}
				}
				else
				{
					this.int_0 = -1;
					this.int_5 = 7;
					int num2 = this.int_3;
					this.interface19_0 = ((Interface14<int>)new Class393.Class396(-2)
					{
						int_4 = num2
					}).GetEnumerator();
					this.int_0 = -3;
				}
				if (!this.interface19_0.imethod_1())
				{
					this.method_0();
					this.interface19_0 = null;
					result = false;
				}
				else
				{
					int num3 = this.interface19_0.imethod_3() ^ this.int_3;
					if ((num3 & 3) == 0)
					{
						num3 ^= 2005660044;
					}
					int num4 = this.int_5 - 1;
					this.int_5 = num4;
					if ((num3 & 15) == 0)
					{
						num3 ^= -1189707964;
					}
					this.int_1 = num3;
					this.int_0 = 1;
					result = true;
				}
			}
			catch
			{
				this.Interface12.imethod_0();
				throw;
			}
			return result;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0000ED04 File Offset: 0x0000CF04
		private void method_0()
		{
			this.int_0 = -1;
			if (this.interface19_0 != null)
			{
				this.interface19_0.imethod_0();
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0000ED20 File Offset: 0x0000CF20
		[DebuggerHidden]
		int Interface19<int>.imethod_3()
		{
			return this.int_1;
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x000031EC File Offset: 0x000013EC
		[DebuggerHidden]
		void Interface13.imethod_2()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0000ED28 File Offset: 0x0000CF28
		[DebuggerHidden]
		object Interface13.imethod_0()
		{
			return this.int_1;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00065940 File Offset: 0x00063B40
		[DebuggerHidden]
		Interface19<int> Interface14<int>.GetEnumerator()
		{
			Class393.Class395 @class;
			if (this.int_0 == -2 && this.int_2 == Thread.CurrentThread.ManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class393.Class395(0);
			}
			@class.int_3 = this.int_4;
			return @class;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0000ED35 File Offset: 0x0000CF35
		[DebuggerHidden]
		Interface13 Interface7.imethod_0()
		{
			return this.Interface14<System.Int32>.GetEnumerator();
		}

		// Token: 0x04000E51 RID: 3665
		private int int_0;

		// Token: 0x04000E52 RID: 3666
		private int int_1;

		// Token: 0x04000E53 RID: 3667
		private int int_2;

		// Token: 0x04000E54 RID: 3668
		private int int_3;

		// Token: 0x04000E55 RID: 3669
		public int int_4;

		// Token: 0x04000E56 RID: 3670
		private int int_5;

		// Token: 0x04000E57 RID: 3671
		private Interface19<int> interface19_0;
	}

	// Token: 0x02000341 RID: 833
	internal sealed class Class396 : Interface14<int>, Interface19<int>, Interface7, Interface12, Interface13
	{
		// Token: 0x0600158C RID: 5516 RVA: 0x0000ED3D File Offset: 0x0000CF3D
		[DebuggerHidden]
		public Class396(int int_8)
		{
			this.int_0 = int_8;
			this.int_2 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00065988 File Offset: 0x00063B88
		[DebuggerHidden]
		void Interface12.imethod_0()
		{
			int num = this.int_0;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.method_0();
				}
			}
			this.interface19_0 = null;
			this.int_0 = -2;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000659D0 File Offset: 0x00063BD0
		bool Interface13.imethod_1()
		{
			bool result;
			try
			{
				int num = this.int_0;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.int_0 = -3;
					int num2 = this.int_3;
					this.int_3 = num2 - 1;
					if (this.int_3 == 0)
					{
						result = false;
						this.method_0();
						return result;
					}
					int num3 = this.int_6;
					this.int_6 = (num3 + this.int_5 + this.int_3 ^ -1358275320 + this.int_7);
					this.int_5 = num3;
				}
				else
				{
					this.int_0 = -1;
					this.int_5 = 0;
					this.int_6 = 1;
					this.interface19_0 = ((Interface14<int>)new Class393.Class394(-2)).GetEnumerator();
					this.int_0 = -3;
				}
				if (!this.interface19_0.imethod_1())
				{
					this.method_0();
					this.interface19_0 = null;
					result = false;
				}
				else
				{
					this.int_7 = this.interface19_0.imethod_3();
					this.int_1 = this.int_6;
					this.int_0 = 1;
					result = true;
				}
			}
			catch
			{
				this.Interface12.imethod_0();
				throw;
			}
			return result;
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0000ED5C File Offset: 0x0000CF5C
		private void method_0()
		{
			this.int_0 = -1;
			if (this.interface19_0 != null)
			{
				this.interface19_0.imethod_0();
			}
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[DebuggerHidden]
		int Interface19<int>.imethod_3()
		{
			return this.int_1;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x000031EC File Offset: 0x000013EC
		[DebuggerHidden]
		void Interface13.imethod_2()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x0000ED80 File Offset: 0x0000CF80
		[DebuggerHidden]
		object Interface13.imethod_0()
		{
			return this.int_1;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00065AE0 File Offset: 0x00063CE0
		[DebuggerHidden]
		Interface19<int> Interface14<int>.GetEnumerator()
		{
			Class393.Class396 @class;
			if (this.int_0 == -2 && this.int_2 == Thread.CurrentThread.ManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class393.Class396(0);
			}
			@class.int_3 = this.int_4;
			return @class;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0000ED8D File Offset: 0x0000CF8D
		[DebuggerHidden]
		Interface13 Interface7.imethod_0()
		{
			return this.Interface14<System.Int32>.GetEnumerator();
		}

		// Token: 0x04000E58 RID: 3672
		private int int_0;

		// Token: 0x04000E59 RID: 3673
		private int int_1;

		// Token: 0x04000E5A RID: 3674
		private int int_2;

		// Token: 0x04000E5B RID: 3675
		private int int_3;

		// Token: 0x04000E5C RID: 3676
		public int int_4;

		// Token: 0x04000E5D RID: 3677
		private int int_5;

		// Token: 0x04000E5E RID: 3678
		private int int_6;

		// Token: 0x04000E5F RID: 3679
		private Interface19<int> interface19_0;

		// Token: 0x04000E60 RID: 3680
		private int int_7;
	}
}
