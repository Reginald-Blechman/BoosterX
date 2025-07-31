using System;
using System.Reflection;

// Token: 0x02000022 RID: 34
internal sealed class Class63 : Class58
{
	// Token: 0x060000C5 RID: 197 RVA: 0x000036CF File Offset: 0x000018CF
	public Class63(object object_1) : base(25)
	{
		if (object_1 != null && !(object_1 is ValueType))
		{
			throw new ArgumentException();
		}
		this.object_0 = object_1;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x000036F1 File Offset: 0x000018F1
	public object method_3()
	{
		return this.object_0;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000036F9 File Offset: 0x000018F9
	public void method_4(object object_1)
	{
		if (object_1 != null && !(object_1 is ValueType))
		{
			throw new ArgumentException();
		}
		this.object_0 = object_1;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00003713 File Offset: 0x00001913
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x0000371B File Offset: 0x0000191B
	public override void vmethod_1(object object_1)
	{
		this.method_4(object_1);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00023590 File Offset: 0x00021790
	private static bool smethod_1(Type type_1)
	{
		if (type_1.IsGenericType && type_1.Namespace == "System")
		{
			string name = type_1.Name;
			if (name == "Span`1" || name == "ReadOnlySpan`1")
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x000235E0 File Offset: 0x000217E0
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		int num = class58_0.method_0();
		if (num != 7)
		{
			if (num == 25)
			{
				object obj = ((Class63)class58_0).method_3();
				object obj2 = this.method_3();
				if (obj2 != null && obj != null)
				{
					Type type = obj2.GetType();
					if (!type.IsPrimitive && !type.IsEnum && type == obj.GetType() && Class63.smethod_1(type))
					{
						foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
						{
							fieldInfo.SetValue(obj2, fieldInfo.GetValue(obj));
						}
						return this;
					}
				}
				this.method_4(obj);
			}
			else
			{
				this.method_4(class58_0.vmethod_0());
			}
		}
		else
		{
			this.method_4(((Class61)class58_0).method_3());
		}
		return this;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00003724 File Offset: 0x00001924
	public override Class58 vmethod_3()
	{
		Class63 @class = new Class63(this.object_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0400003D RID: 61
	private object object_0;
}
