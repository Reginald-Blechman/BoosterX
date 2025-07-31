using System;
using System.Collections.Generic;

// Token: 0x020000AD RID: 173
internal sealed class Class110
{
	// Token: 0x06000552 RID: 1362 RVA: 0x000057B3 File Offset: 0x000039B3
	public Class110(Class130 class130_1)
	{
		this.class130_0 = class130_1;
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x000381CC File Offset: 0x000363CC
	private void method_0()
	{
		if (this.bool_0)
		{
			return;
		}
		object obj = this.object_0;
		lock (obj)
		{
			if (!this.bool_0)
			{
				this.class112_0 = new Class112[this.class130_0.method_4()];
				for (int i = 0; i < this.class130_0.method_4(); i++)
				{
					this.class112_0[i] = new Class112();
				}
				this.dictionary_0 = new Dictionary<int, Class112>();
				this.dictionary_1 = new Dictionary<int, WeakReference>();
				this.object_1 = new object();
				this.int_0 = this.class130_0.method_6();
				this.object_2 = new object[this.class130_0.method_8()];
				this.bool_0 = true;
			}
		}
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x000382B0 File Offset: 0x000364B0
	public void method_1(Class112 class112_1)
	{
		this.method_0();
		object obj = this.object_0;
		lock (obj)
		{
			Class112 @class;
			if (this.dictionary_0.TryGetValue(class112_1.int_0, out @class) && @class != null)
			{
				@class.dateTime_0 = class112_1.dateTime_0;
			}
			else
			{
				int num = 0;
				DateTime dateTime_ = this.class112_0[0].dateTime_0;
				for (int i = 1; i < this.class130_0.method_4(); i++)
				{
					if (this.class112_0[i].dateTime_0 < dateTime_)
					{
						num = i;
					}
				}
				@class = this.class112_0[num];
				if (@class.byte_0 == null)
				{
					@class.byte_0 = new byte[this.class130_0.method_0()];
				}
				else
				{
					this.dictionary_0[@class.int_0] = null;
				}
				this.method_4(class112_1, @class);
				this.dictionary_0[@class.int_0] = @class;
				if (this.dictionary_0.Count > this.class130_0.method_4() * 2)
				{
					this.method_2();
				}
			}
		}
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x000383DC File Offset: 0x000365DC
	private void method_2()
	{
		Dictionary<int, Class112> dictionary = this.dictionary_0;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, Class112> keyValuePair in dictionary)
		{
			if (keyValuePair.Value == null)
			{
				list.Add(keyValuePair.Key);
			}
		}
		foreach (int key in list)
		{
			dictionary.Remove(key);
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00038488 File Offset: 0x00036688
	public bool method_3(int int_2, ref Class112 class112_1)
	{
		if (!this.bool_0)
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			Class112 @class;
			if (this.dictionary_0.TryGetValue(int_2, out @class) && @class != null)
			{
				this.method_4(@class, class112_1);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x000384F4 File Offset: 0x000366F4
	private void method_4(Class112 class112_1, Class112 class112_2)
	{
		class112_1.dateTime_0 = DateTime.UtcNow;
		class112_2.int_0 = class112_1.int_0;
		class112_2.int_1 = class112_1.int_1;
		class112_2.dateTime_0 = class112_1.dateTime_0;
		Buffer.BlockCopy(class112_1.byte_0, 0, class112_2.byte_0, 0, this.class130_0.method_0());
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00038550 File Offset: 0x00036750
	private void method_5(object object_3)
	{
		for (int i = 0; i < this.object_2.Length; i++)
		{
			if (this.object_2[i] == object_3)
			{
				return;
			}
		}
		this.object_2[this.int_1] = object_3;
		this.int_1++;
		if (this.int_1 == this.object_2.Length)
		{
			this.int_1 = 0;
		}
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x000385B4 File Offset: 0x000367B4
	private void method_6()
	{
		if (this.dictionary_1.Count >= this.int_0)
		{
			Dictionary<int, WeakReference> dictionary = new Dictionary<int, WeakReference>();
			foreach (KeyValuePair<int, WeakReference> keyValuePair in this.dictionary_1)
			{
				if (keyValuePair.Value.IsAlive)
				{
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			this.dictionary_1 = dictionary;
			this.int_0 = Math.Max(dictionary.Count * 2, 10);
		}
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00038658 File Offset: 0x00036858
	public void method_7(int int_2, byte[] byte_0, int int_3, int int_4, bool bool_1)
	{
		this.method_0();
		object obj = this.object_1;
		lock (obj)
		{
			WeakReference weakReference;
			Class110.Class111 @class;
			if (this.dictionary_1.TryGetValue(int_2, out weakReference))
			{
				@class = (weakReference.Target as Class110.Class111);
				if (@class != null)
				{
					if (@class.byte_0.Length < int_4)
					{
						@class.method_0(byte_0, int_3, int_4, bool_1);
						goto IL_74;
					}
					goto IL_74;
				}
			}
			this.method_6();
			@class = new Class110.Class111(byte_0, int_3, int_4, bool_1);
			this.dictionary_1[int_2] = new WeakReference(@class);
			IL_74:
			this.method_5(@class);
		}
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x000386FC File Offset: 0x000368FC
	public bool method_8(int int_2, byte[] byte_0, int int_3, int int_4, out int int_5)
	{
		int_5 = 0;
		if (!this.bool_0)
		{
			return false;
		}
		object obj = this.object_1;
		bool result;
		lock (obj)
		{
			WeakReference weakReference;
			if (!this.dictionary_1.TryGetValue(int_2, out weakReference))
			{
				result = false;
			}
			else
			{
				Class110.Class111 @class = weakReference.Target as Class110.Class111;
				if (@class == null)
				{
					result = false;
				}
				else
				{
					int num = @class.byte_0.Length;
					int_5 = int_4;
					if (num < int_4)
					{
						if (!@class.bool_0)
						{
							return false;
						}
						int_5 = num;
					}
					Buffer.BlockCopy(@class.byte_0, 0, byte_0, int_3, int_5);
					this.method_5(@class);
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x040002F2 RID: 754
	private readonly object object_0 = new object();

	// Token: 0x040002F3 RID: 755
	private Class112[] class112_0;

	// Token: 0x040002F4 RID: 756
	private Dictionary<int, Class112> dictionary_0;

	// Token: 0x040002F5 RID: 757
	private volatile bool bool_0;

	// Token: 0x040002F6 RID: 758
	private Class130 class130_0;

	// Token: 0x040002F7 RID: 759
	private Dictionary<int, WeakReference> dictionary_1;

	// Token: 0x040002F8 RID: 760
	private object object_1;

	// Token: 0x040002F9 RID: 761
	private int int_0;

	// Token: 0x040002FA RID: 762
	private object[] object_2;

	// Token: 0x040002FB RID: 763
	private int int_1;

	// Token: 0x020000AE RID: 174
	private sealed class Class111
	{
		// Token: 0x0600055C RID: 1372 RVA: 0x00003332 File Offset: 0x00001532
		public Class111()
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000057CD File Offset: 0x000039CD
		public Class111(byte[] byte_1, int int_0, int int_1, bool bool_1)
		{
			this.method_0(byte_1, int_0, int_1, bool_1);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000057E0 File Offset: 0x000039E0
		public void method_0(byte[] byte_1, int int_0, int int_1, bool bool_1)
		{
			this.byte_0 = new byte[int_1];
			Buffer.BlockCopy(byte_1, int_0, this.byte_0, 0, int_1);
			this.bool_0 = bool_1;
		}

		// Token: 0x040002FC RID: 764
		public byte[] byte_0;

		// Token: 0x040002FD RID: 765
		public bool bool_0;
	}
}
