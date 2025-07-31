using System;
using System.Runtime.CompilerServices;

// Token: 0x02000049 RID: 73
internal struct Struct9
{
	// Token: 0x060001D9 RID: 473 RVA: 0x000040E6 File Offset: 0x000022E6
	public Struct9(string string_0)
	{
		this.class6_0 = new Class6
		{
			class102_0 = Class126.smethod_0(string_0)
		};
	}

	// Token: 0x060001DB RID: 475 RVA: 0x000270DC File Offset: 0x000252DC
	private bool method_0(out string string_0)
	{
		string_0 = null;
		Class6 @class = this.class6_0;
		Class102 class2 = (@class != null) ? @class.class102_0 : null;
		if (class2 == null)
		{
			return true;
		}
		WeakReference weakReference_ = class2.weakReference_0;
		string_0 = (((weakReference_ != null) ? weakReference_.Target : null) as string);
		return string_0 != null;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00027124 File Offset: 0x00025324
	public string method_1()
	{
		string text;
		if (this.method_0(out text))
		{
			return text;
		}
		object obj = Struct9.object_0;
		lock (obj)
		{
			if (this.method_0(out text))
			{
				return text;
			}
			Class23 class23_ = this.class6_0.class102_0.class23_0;
			object obj2 = class23_.object_0;
			byte[] byte_;
			bool bool_;
			lock (obj2)
			{
				byte_ = class23_.byte_0;
				bool_ = class23_.bool_0;
				if (class23_.bool_1)
				{
					if (byte_ == null)
					{
						throw new Exception("Unable to decrypt string data: encrypted value is null");
					}
				}
				else
				{
					WeakReference weakReference_ = this.class6_0.class102_0.weakReference_1;
					string text2 = ((weakReference_ != null) ? weakReference_.Target : null) as string;
					if (text2 == null)
					{
						throw new Exception("Unable to obtain original string data");
					}
					text = string.Copy(text2);
					Class126.smethod_3(text2);
				}
				class23_.bool_1 = true;
			}
			if (text == null)
			{
				text = Class126.smethod_2(byte_, bool_);
			}
			this.method_3(text);
		}
		return text;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00004115 File Offset: 0x00002315
	public string method_2()
	{
		return this.method_1();
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0002723C File Offset: 0x0002543C
	private void method_3(string string_0)
	{
		Class108 @class;
		if (!Struct9.conditionalWeakTable_0.TryGetValue(string_0, out @class))
		{
			Class102 class2 = new Class102
			{
				class23_0 = new Class23(),
				weakReference_0 = new WeakReference(string_0),
				weakReference_1 = new WeakReference(string_0, true)
			};
			@class = new Class108(string_0, class2, class2.class23_0);
			Struct9.conditionalWeakTable_0.Add(string_0, @class);
		}
		this.class6_0.class102_0 = @class.class102_0;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x000272B0 File Offset: 0x000254B0
	public void method_4(string string_0)
	{
		object obj = Struct9.object_0;
		lock (obj)
		{
			if (string_0 == null)
			{
				this.class6_0 = null;
			}
			else
			{
				this.class6_0 = new Class6();
				this.method_3(string_0);
			}
		}
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0000411D File Offset: 0x0000231D
	public void method_5(string string_0)
	{
		this.method_4(string_0);
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00004126 File Offset: 0x00002326
	public void method_6()
	{
		this.method_4(null);
	}

	// Token: 0x040000A3 RID: 163
	private static readonly ConditionalWeakTable<string, Class108> conditionalWeakTable_0 = new ConditionalWeakTable<string, Class108>();

	// Token: 0x040000A4 RID: 164
	private static readonly object object_0 = new object();

	// Token: 0x040000A5 RID: 165
	private Class6 class6_0;
}
