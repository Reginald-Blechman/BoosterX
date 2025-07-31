using System;
using System.Collections.Generic;

// Token: 0x02000088 RID: 136
internal sealed class Class87
{
	// Token: 0x06000465 RID: 1125 RVA: 0x00036710 File Offset: 0x00034910
	internal Class110 method_0(Class130 class130_0)
	{
		if (class130_0 == null)
		{
			throw new ArgumentNullException();
		}
		object obj = this.object_0;
		Class110 result;
		lock (obj)
		{
			if (this.dictionary_0 == null)
			{
				this.dictionary_0 = new Dictionary<Class130, Class110>();
			}
			Class110 @class;
			if (!this.dictionary_0.TryGetValue(class130_0, out @class))
			{
				@class = new Class110(class130_0);
				this.dictionary_0[class130_0] = @class;
			}
			result = @class;
		}
		return result;
	}

	// Token: 0x040002B8 RID: 696
	private object object_0 = new object();

	// Token: 0x040002B9 RID: 697
	private Dictionary<Class130, Class110> dictionary_0;
}
