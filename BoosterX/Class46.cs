using System;
using System.IO;

// Token: 0x02000077 RID: 119
internal static class Class46
{
	// Token: 0x060003E7 RID: 999 RVA: 0x00034940 File Offset: 0x00032B40
	public static byte[] smethod_0(string string_0)
	{
		if (string_0 == null)
		{
			throw new Exception();
		}
		MemoryStream memoryStream = new MemoryStream(string_0.Length * 4 / 5);
		byte[] result;
		try
		{
			int num = 0;
			uint num2 = 0U;
			foreach (char c in string_0)
			{
				if (c == 'z' && num == 0)
				{
					Class46.smethod_1(memoryStream, num2, 0);
				}
				else
				{
					if (c < '!' || c > 'u')
					{
						throw new Exception();
					}
					checked
					{
						num2 += (uint)(unchecked((ulong)Class46.uint_0[num]) * (ulong)(unchecked((long)(checked(c - '!')))));
					}
					num++;
					if (num == 5)
					{
						Class46.smethod_1(memoryStream, num2, 0);
						num = 0;
						num2 = 0U;
					}
				}
			}
			if (num == 1)
			{
				throw new Exception();
			}
			if (num > 1)
			{
				for (int j = num; j < 5; j++)
				{
					checked
					{
						num2 += 84U * Class46.uint_0[j];
					}
				}
				Class46.smethod_1(memoryStream, num2, 5 - num);
			}
			result = memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00004C8E File Offset: 0x00002E8E
	private static void smethod_1(Stream stream_0, uint uint_1, int int_0)
	{
		stream_0.WriteByte((byte)(uint_1 >> 24));
		if (int_0 == 3)
		{
			return;
		}
		stream_0.WriteByte((byte)(uint_1 >> 16));
		if (int_0 == 2)
		{
			return;
		}
		stream_0.WriteByte((byte)(uint_1 >> 8));
		if (int_0 == 1)
		{
			return;
		}
		stream_0.WriteByte((byte)uint_1);
	}

	// Token: 0x0400028B RID: 651
	private static readonly uint[] uint_0 = new uint[]
	{
		52200625U,
		614125U,
		7225U,
		85U,
		1U
	};
}
