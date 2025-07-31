using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

// Token: 0x020005F5 RID: 1525
public static class GClass261
{
	// Token: 0x0600270F RID: 9999 RVA: 0x00098D34 File Offset: 0x00096F34
	public static string smethod_0(this string string_0, string string_1, string string_2, StringComparison stringComparison_0)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			int num2;
			while ((num2 = string_0.IndexOf(string_1, num, stringComparison_0)) != -1)
			{
				stringBuilder.Append(string_0, num, num2 - num).Append(string_2);
				num = num2 + string_1.Length;
			}
			stringBuilder.Append(string_0, num, string_0.Length - num);
			return stringBuilder.ToString();
		}
		return string_0;
	}

	// Token: 0x06002710 RID: 10000 RVA: 0x00098DA0 File Offset: 0x00096FA0
	public static string smethod_1(this string string_0, string string_1)
	{
		GClass261.Class730 @class = new GClass261.Class730();
		@class.string_0 = string_1;
		string text = string.Empty;
		try
		{
			text = string_0.Split(new char[]
			{
				'\n'
			}).ToList<string>().First(new Func<string, bool>(@class.method_0)).Split(new char[]
			{
				':'
			}).Last<string>();
			int i;
			for (i = 0; i < text.Length; i++)
			{
				if (text[i] != ' ')
				{
					break;
				}
			}
			text = text.Substring(i);
		}
		catch
		{
		}
		return text.Replace("\r", string.Empty);
	}

	// Token: 0x06002711 RID: 10001 RVA: 0x00019FF9 File Offset: 0x000181F9
	public static string smethod_2(this string string_0, int int_0)
	{
		return string_0.Split(new char[]
		{
			'\n'
		})[int_0].Replace("\r", string.Empty);
	}

	// Token: 0x06002712 RID: 10002 RVA: 0x0001A01E File Offset: 0x0001821E
	public static bool smethod_3(this string string_0, string string_1)
	{
		return string_0.IndexOf(string_1, StringComparison.OrdinalIgnoreCase) >= 0;
	}

	// Token: 0x06002713 RID: 10003 RVA: 0x00098E4C File Offset: 0x0009704C
	public static string smethod_4(this string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("#=zV_1WA5o=");
		}
		if (string_0 == string.Empty)
		{
			throw new ArgumentException("input cannot be empty", "#=zV_1WA5o=");
		}
		return string_0[0].ToString().ToUpper() + string_0.Substring(1);
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x0001A02E File Offset: 0x0001822E
	public static IEnumerable<string> smethod_5(this string string_0, int int_0)
	{
		return new GClass261.Class729(-2)
		{
			string_2 = string_0,
			int_3 = int_0
		};
	}

	// Token: 0x020005F6 RID: 1526
	private sealed class Class729 : IDisposable, IEnumerable<string>, IEnumerator<string>, IEnumerable, IEnumerator
	{
		// Token: 0x06002715 RID: 10005 RVA: 0x0001A045 File Offset: 0x00018245
		[DebuggerHidden]
		public Class729(int int_5)
		{
			this.int_0 = int_5;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0001A05F File Offset: 0x0001825F
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			this.int_0 = -2;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00098EAC File Offset: 0x000970AC
		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				this.int_4 += this.int_2;
			}
			else
			{
				this.int_0 = -1;
				if (this.string_1 == null)
				{
					throw new ArgumentNullException("s");
				}
				if (this.int_2 <= 0)
				{
					throw new ArgumentException("Part length has to be positive.", "partLength");
				}
				this.int_4 = 0;
			}
			if (this.int_4 >= this.string_1.Length)
			{
				return false;
			}
			this.string_0 = this.string_1.Substring(this.int_4, Math.Min(this.int_2, this.string_1.Length - this.int_4));
			this.int_0 = 1;
			return true;
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x0001A069 File Offset: 0x00018269
		string IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000031EC File Offset: 0x000013EC
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x0001A069 File Offset: 0x00018269
		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x00098F74 File Offset: 0x00097174
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			GClass261.Class729 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new GClass261.Class729(0);
			}
			@class.string_1 = this.string_2;
			@class.int_2 = this.int_3;
			return @class;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x0001A071 File Offset: 0x00018271
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
		}

		// Token: 0x040019C1 RID: 6593
		private int int_0;

		// Token: 0x040019C2 RID: 6594
		private string string_0;

		// Token: 0x040019C3 RID: 6595
		private int int_1;

		// Token: 0x040019C4 RID: 6596
		private string string_1;

		// Token: 0x040019C5 RID: 6597
		public string string_2;

		// Token: 0x040019C6 RID: 6598
		private int int_2;

		// Token: 0x040019C7 RID: 6599
		public int int_3;

		// Token: 0x040019C8 RID: 6600
		private int int_4;
	}

	// Token: 0x020005F7 RID: 1527
	private sealed class Class730
	{
		// Token: 0x0600271E RID: 10014 RVA: 0x0001A079 File Offset: 0x00018279
		internal bool method_0(string string_1)
		{
			return string_1.StartsWith(this.string_0);
		}

		// Token: 0x040019C9 RID: 6601
		public string string_0;
	}
}
