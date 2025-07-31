using System;
using System.Collections.Generic;
using System.Text;

// Token: 0x02000564 RID: 1380
internal sealed class Class661
{
	// Token: 0x0600228B RID: 8843 RVA: 0x000898F0 File Offset: 0x00087AF0
	public static string smethod_0(string string_0)
	{
		int i = 0;
		int num = 0;
		int j = 0;
		int num2 = 0;
		foreach (char c in string_0)
		{
			if (c == '{')
			{
				i++;
			}
			if (c == '}')
			{
				num++;
			}
			if (c == '[')
			{
				j++;
			}
			if (c == ']')
			{
				num2++;
			}
		}
		while (i > num)
		{
			string_0 += "}";
			num++;
		}
		while (j > num2)
		{
			string_0 += "]";
			num2++;
		}
		return string_0;
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x00089980 File Offset: 0x00087B80
	public static string smethod_1(string string_0)
	{
		Stack<char> stack = new Stack<char>();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		char c = '\0';
		int i = 0;
		while (i < string_0.Length)
		{
			char c2 = string_0[i];
			if (c2 == '"' && (i == 0 || string_0[i - 1] != '\\'))
			{
				flag = !flag;
			}
			if (!flag)
			{
				if (c2 == '{')
				{
					goto IL_8E;
				}
				if (c2 == '[')
				{
					goto IL_8E;
				}
				if ((c2 == '}' && (stack.Count == 0 || stack.Peek() != '{')) || (c2 == ']' && (stack.Count == 0 || stack.Peek() != '[')))
				{
					goto IL_CC;
				}
				if (c2 == '}' || c2 == ']')
				{
					stack.Pop();
				}
				IL_95:
				if ((c == '}' || c == ']') && (c2 == '{' || c2 == '[' || c2 == '"'))
				{
					stringBuilder.Append(',');
					goto IL_B9;
				}
				goto IL_B9;
				IL_8E:
				stack.Push(c2);
				goto IL_95;
			}
			goto IL_B9;
			IL_CC:
			i++;
			continue;
			IL_B9:
			stringBuilder.Append(c2);
			if (!char.IsWhiteSpace(c2))
			{
				c = c2;
				goto IL_CC;
			}
			goto IL_CC;
		}
		while (stack.Count > 0)
		{
			char c3 = stack.Pop();
			stringBuilder.Append((c3 == '{') ? '}' : ']');
		}
		return stringBuilder.ToString();
	}
}
