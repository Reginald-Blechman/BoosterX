using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x02000583 RID: 1411
internal static class Class682
{
	// Token: 0x0600237A RID: 9082 RVA: 0x000175A9 File Offset: 0x000157A9
	private static bool smethod_0()
	{
		return Class682.smethod_1();
	}

	// Token: 0x0600237B RID: 9083 RVA: 0x0008B788 File Offset: 0x00089988
	private static bool smethod_1()
	{
		StackTrace stackTrace = new StackTrace();
		StackFrame frame = stackTrace.GetFrame(3);
		MethodBase methodBase = (frame == null) ? null : frame.GetMethod();
		Type type = (methodBase == null) ? null : methodBase.DeclaringType;
		return type != typeof(RuntimeMethodHandle) && type != null && type.Assembly == typeof(Class682).Assembly;
	}

	// Token: 0x0600237C RID: 9084 RVA: 0x000175B5 File Offset: 0x000157B5
	internal static void smethod_2()
	{
		AppDomain.CurrentDomain.AssemblyResolve += Class682.smethod_4;
	}

	// Token: 0x0600237D RID: 9085 RVA: 0x0008B7EC File Offset: 0x000899EC
	internal static Assembly smethod_3(string string_0)
	{
		return Class682.smethod_5(string_0);
	}

	// Token: 0x0600237E RID: 9086 RVA: 0x0008B804 File Offset: 0x00089A04
	private static Assembly smethod_4(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Class682.smethod_5(resolveEventArgs_0.Name);
	}

	// Token: 0x0600237F RID: 9087 RVA: 0x0008B820 File Offset: 0x00089A20
	private static Assembly smethod_5(string string_0)
	{
		Class682.Struct364 @struct = new Class682.Struct364(string_0.ToUpperInvariant());
		Class682.Class685.Class687 @class = null;
		string s = @struct.method_0(false);
		string string_ = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		using (IEnumerator<Class682.Class685.Class687> enumerator = Class682.Class685.smethod_0(string_).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				Class682.Class685.Class687 class2 = enumerator.Current;
				@class = class2;
			}
		}
		if (@class == null)
		{
			return null;
		}
		Dictionary<string, Assembly> dictionary_ = Class682.Class683.dictionary_0;
		Dictionary<string, Assembly> obj = dictionary_;
		Assembly assembly;
		lock (obj)
		{
			if (!dictionary_.TryGetValue(@class.string_3, out assembly))
			{
				byte[] array = Class682.Class685.smethod_1(@class);
				if (array == null)
				{
					return null;
				}
				bool flag;
				if (!(flag = @class.bool_2))
				{
					try
					{
						assembly = Assembly.Load(array);
					}
					catch (FileLoadException)
					{
						flag = true;
					}
					catch (BadImageFormatException)
					{
						flag = true;
					}
				}
				if (flag)
				{
					try
					{
						string assemblyFile = Class682.Class685.smethod_2(@class, true, array);
						assembly = Assembly.LoadFrom(assemblyFile);
					}
					catch
					{
					}
				}
				dictionary_.Add(@class.string_3, assembly);
			}
		}
		return assembly;
	}

	// Token: 0x06002380 RID: 9088 RVA: 0x000175CD File Offset: 0x000157CD
	private static int smethod_6(byte[] byte_0, int int_0)
	{
		return (int)byte_0[int_0] | (int)byte_0[int_0 + 1] << 24 | (int)byte_0[int_0 + 2] << 8 | (int)byte_0[int_0 + 3] << 16;
	}

	// Token: 0x06002381 RID: 9089 RVA: 0x000175EC File Offset: 0x000157EC
	private static int smethod_7(byte[] byte_0, int int_0)
	{
		return (int)byte_0[int_0] << 24 | (int)byte_0[int_0 + 1] | (int)byte_0[int_0 + 2] << 16 | (int)byte_0[int_0 + 3] << 8;
	}

	// Token: 0x06002382 RID: 9090 RVA: 0x0008B958 File Offset: 0x00089B58
	private static byte[] smethod_8(byte[] byte_0)
	{
		int num = Class682.smethod_6(byte_0, 0);
		if (num != -1686991929)
		{
			throw new Exception();
		}
		int num2 = Class682.smethod_7(byte_0, 4);
		Stream input = new DeflateStream(new MemoryStream(byte_0, false)
		{
			Position = 8L
		}, CompressionMode.Decompress);
		BinaryReader binaryReader = new BinaryReader(input);
		byte_0 = binaryReader.ReadBytes(num2);
		binaryReader.Close();
		int num3 = byte_0.Length;
		if (num3 != num2)
		{
			throw new Exception();
		}
		return byte_0;
	}

	// Token: 0x06002383 RID: 9091 RVA: 0x0008B9CC File Offset: 0x00089BCC
	private static byte[] smethod_9(byte[] byte_0)
	{
		string s = "Fr4A5Gk8Dwo0hMdPCnbfBQ4FHVYpPAJHBeMuMaBODWbiqYRtArMqUxYwE1T48aZUuNMIT5nAzcVG0/tYe0WCpG96G7Ewrh6+4ffV";
		byte[] array = Convert.FromBase64String(s);
		Class844.smethod_1(array);
		Class682.Class684 @class = new Class682.Class684(array);
		int num = byte_0.Length;
		byte b = 0;
		byte b2 = 121;
		byte[] array2 = new byte[]
		{
			148,
			68,
			208,
			52,
			241,
			93,
			195,
			220
		};
		for (int num2 = 0; num2 != num; num2++)
		{
			if (b == 0)
			{
				b2 = @class.method_1();
			}
			b += 1;
			if (b == 32)
			{
				b = 0;
			}
			int num3 = num2;
			byte_0[num3] ^= (b2 ^ array2[num2 >> 2 & 3] ^ array2[(int)(b & 3)]);
		}
		return byte_0;
	}

	// Token: 0x06002384 RID: 9092
	[DllImport("kernel32.dll")]
	private static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	// Token: 0x02000584 RID: 1412
	private static class Class683
	{
		// Token: 0x04001768 RID: 5992
		internal static readonly Dictionary<string, Assembly> dictionary_0 = new Dictionary<string, Assembly>(StringComparer.Ordinal);
	}

	// Token: 0x02000585 RID: 1413
	private sealed class Class684
	{
		// Token: 0x06002386 RID: 9094 RVA: 0x0008BA84 File Offset: 0x00089C84
		public Class684(byte[] byte_1)
		{
			int num = byte_1.Length;
			this.int_0 = 0;
			while (this.int_0 < 256)
			{
				this.byte_0[this.int_0] = (byte)this.int_0;
				this.int_0++;
			}
			this.int_1 = 0;
			this.int_0 = 0;
			while (this.int_0 < 256)
			{
				this.int_1 = (this.int_1 + (int)byte_1[this.int_0 % num] + (int)this.byte_0[this.int_0] & 255);
				this.method_0(this.int_0, this.int_1);
				this.int_0++;
			}
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x0008BB4C File Offset: 0x00089D4C
		private void method_0(int int_2, int int_3)
		{
			byte b = this.byte_0[int_2];
			this.byte_0[int_2] = this.byte_0[int_3];
			this.byte_0[int_3] = b;
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x0008BB7C File Offset: 0x00089D7C
		public byte method_1()
		{
			this.int_0 = (this.int_0 + 1 & 255);
			this.int_1 = (this.int_1 + (int)this.byte_0[this.int_0] & 255);
			this.method_0(this.int_0, this.int_1);
			return this.byte_0[(int)(this.byte_0[this.int_0] + this.byte_0[this.int_1])];
		}

		// Token: 0x04001769 RID: 5993
		private byte[] byte_0 = new byte[256];

		// Token: 0x0400176A RID: 5994
		private int int_0;

		// Token: 0x0400176B RID: 5995
		private int int_1;
	}

	// Token: 0x02000586 RID: 1414
	private static class Class685
	{
		// Token: 0x06002389 RID: 9097 RVA: 0x0001761C File Offset: 0x0001581C
		internal static IEnumerable<Class682.Class685.Class687> smethod_0(string string_0)
		{
			return new Class682.Class685.Class686(-2)
			{
				string_1 = string_0
			};
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0008BBF4 File Offset: 0x00089DF4
		internal static byte[] smethod_1(Class682.Class685.Class687 class687_0)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(class687_0.string_3);
			if (manifestResourceStream == null)
			{
				return null;
			}
			int num = (int)manifestResourceStream.Length;
			byte[] array = new byte[num];
			manifestResourceStream.Read(array, 0, num);
			manifestResourceStream.Dispose();
			if (class687_0.bool_0)
			{
				array = Class682.smethod_9(array);
			}
			if (class687_0.bool_1)
			{
				array = Class682.smethod_8(array);
			}
			return array;
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x0008BC58 File Offset: 0x00089E58
		internal static string smethod_2(Class682.Class685.Class687 class687_0, bool bool_0, byte[] byte_0)
		{
			string path = class687_0.bool_5 ? class687_0.string_3 : class687_0.string_2;
			string text = Path.Combine(Path.GetTempPath(), path);
			try
			{
				Directory.CreateDirectory(text);
			}
			catch
			{
				text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				text = Path.Combine(text, "clrldr");
				text = Path.Combine(text, path);
				Directory.CreateDirectory(text);
				if (text == null)
				{
					throw;
				}
			}
			string text2 = Path.Combine(text, class687_0.method_1());
			Class682.Class685.Struct363 @struct = new Class682.Class685.Struct363(text2 + ".lock");
			@struct.method_1();
			try
			{
				if (!File.Exists(text2))
				{
					if (byte_0 == null)
					{
						byte_0 = Class682.Class685.smethod_1(class687_0);
					}
					File.WriteAllBytes(text2, byte_0);
					if (bool_0)
					{
						try
						{
							Class682.MoveFileEx(text2, null, 4);
							Class682.MoveFileEx(text, null, 4);
						}
						catch
						{
						}
					}
				}
			}
			finally
			{
				@struct.method_2();
			}
			return text2;
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x0008BD50 File Offset: 0x00089F50
		internal static void smethod_3(string string_0, bool bool_0)
		{
			bool flag = false;
			try
			{
				File.Delete(string_0);
				flag = true;
			}
			catch
			{
			}
			string directoryName = Path.GetDirectoryName(string_0);
			bool flag2 = false;
			try
			{
				Directory.Delete(directoryName);
				flag = true;
			}
			catch
			{
			}
			if (bool_0)
			{
				if (!flag)
				{
					try
					{
						Class682.MoveFileEx(string_0, null, 4);
					}
					catch
					{
					}
				}
				if (!flag2)
				{
					try
					{
						Class682.MoveFileEx(directoryName, null, 4);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x02000587 RID: 1415
		private sealed class Class686 : IDisposable, IEnumerable<Class682.Class685.Class687>, IEnumerator<Class682.Class685.Class687>, IEnumerable, IEnumerator
		{
			// Token: 0x0600238D RID: 9101 RVA: 0x0001762C File Offset: 0x0001582C
			[DebuggerHidden]
			public Class686(int int_3)
			{
				this.int_0 = int_3;
				this.int_1 = Thread.CurrentThread.ManagedThreadId;
			}

			// Token: 0x0600238E RID: 9102 RVA: 0x0000311B File Offset: 0x0000131B
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0600238F RID: 9103 RVA: 0x0008BDDC File Offset: 0x00089FDC
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
				}
				else
				{
					this.int_0 = -1;
					string text = "cbfed0823c5648db1138d0791a2be87c,WlhfOTczQkUzNUYyMEM3NDUwQ0ZDNTAxNjA2RjI5QzFFMDAsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|b7a0ec2484bc474eefbf706c76222ff6,enhfOTczYmUzNWYyMGM3NDUwY2ZjNTAxNjA2ZjI5YzFlMDAuZGxs,,WlhfM0NDMkQ3NjVDQTA4NDZCMDE3NjU5OTZDQTdFMDY3NTEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|e6ba3042fc8d4136251c94432af7f8d4,enhfM2NjMmQ3NjVjYTA4NDZiMDE3NjU5OTZjYTdlMDY3NTEuZGxs,,WlhfQjczMTc1RkE2QUM3NEFDMDk2RDY0M0FEQzY0RjczOUEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|981ed68c57aa48d26776c0f9ae451e35,enhfYjczMTc1ZmE2YWM3NGFjMDk2ZDY0M2FkYzY0ZjczOWEuZGxs,,WlhfNUMyMTJDQzVEQzE2NEY1MzM5MjlENUIyMjY4MkJBRjIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|3145db26ddfb4d25360c4907b8396f25,enhfNWMyMTJjYzVkYzE2NGY1MzM5MjlkNWIyMjY4MmJhZjIuZGxs,,WlhfQjY5NzZDQjM5REUyNDgyRTJDMDM1QTdFMTNFOEU0NzQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|1ca5baee29914fa8a41b869b4a68db57,enhfYjY5NzZjYjM5ZGUyNDgyZTJjMDM1YTdlMTNlOGU0NzQuZGxs,,WlhfQ0I0QjYzNkU3M0JDNDA0RDM5OTYxNjQ4NzIzMDJCQzQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|4ca32100e1974d2e067dcc5480b5e2e9,enhfY2I0YjYzNmU3M2JjNDA0ZDM5OTYxNjQ4NzIzMDJiYzQuZGxs,,WlhfRkM1QURBNTUzQzEyNDEyOTU0OTNCNTkyRTlEQzZCMkUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|bf9bb461c20a441d794937cca7a3fa0c,enhfZmM1YWRhNTUzYzEyNDEyOTU0OTNiNTkyZTlkYzZiMmUuZGxs,,WlhfM0QzQkE2Q0Y4MzcyNEI2RjkwMzQ3NEU5RTM5QTMyODIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|829f9c9c34f14d936f4e41cb70de39ce,enhfM2QzYmE2Y2Y4MzcyNGI2ZjkwMzQ3NGU5ZTM5YTMyODIuZGxs,,WlhfMzYxNkMzMEJBODY1NDcxM0Y5NDQ1NTk0ODVCMTg1QkQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|5a9aa1340ba14d73793793e61da451ac,enhfMzYxNmMzMGJhODY1NDcxM2Y5NDQ1NTk0ODViMTg1YmQuZGxs,,WlhfMTdBRkZENDRGMzBCNEVGNjJBRjBEODczQTU1MkRCQkEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|85ac2da98c384e45cf4d5f07ed4e6284,enhfMTdhZmZkNDRmMzBiNGVmNjJhZjBkODczYTU1MmRiYmEuZGxs,,WlhfQ0JDNDMxNTdEQjU0NDg2REI4NTA0QzZBQkU0NUM1MDQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|e1c5c5a84de04172f223b5a542bf71c7,enhfY2JjNDMxNTdkYjU0NDg2ZGI4NTA0YzZhYmU0NWM1MDQuZGxs,,WlhfMDI1RTI5OUJFMDgwNEZGRUE3RDJGODZDNTFGQjVFRDIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|57fc41d6ba984a088f01aa038793ddaa,enhfMDI1ZTI5OWJlMDgwNGZmZWE3ZDJmODZjNTFmYjVlZDIuZGxs,,WlhfMDZGNzQ5MzlFNUVGNDU2OTBGRTE4NDk0MzQzOUYzRkMsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|c241c1c51cd1417ff95c0dd80ae1087d,enhfMDZmNzQ5MzllNWVmNDU2OTBmZTE4NDk0MzQzOWYzZmMuZGxs,,WlhfQjBBN0E2MDc4REJBNEMwQzgwNkI3OEE5MzYwRjJFNTMsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|516920086cc143f3a586492c44fa827f,enhfYjBhN2E2MDc4ZGJhNGMwYzgwNmI3OGE5MzYwZjJlNTMuZGxs,,WlhfNkEzOTc0QURDNkUwNDlGNUEyNkUyMzQyMTBEQzhGQTQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|5a8dd41d17434f0db146cf67a0f96845,enhfNmEzOTc0YWRjNmUwNDlmNWEyNmUyMzQyMTBkYzhmYTQuZGxs,,WlhfMDVCRjRBN0UzOUMyNEQyM0EyMDdCNzZFNTI3RDhGNjQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|8abdb9b5949045632d8eaaf026705bfe,enhfMDViZjRhN2UzOWMyNGQyM2EyMDdiNzZlNTI3ZDhmNjQuZGxs,,WlhfMUMwNENGRTY3NUIzNDlCQ0I1OUVDODI4MEY0MzFCREMsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|6b7ed93c0ab74fa4130bea1b40c92add,enhfMWMwNGNmZTY3NWIzNDliY2I1OWVjODI4MGY0MzFiZGMuZGxs,,WlhfMEFCNTZFRDQyODEzNDBDRkE2RkJFOTQyOUUwOTBFNzgsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|5694925577be49768e7de0aa87995435,enhfMGFiNTZlZDQyODEzNDBjZmE2ZmJlOTQyOWUwOTBlNzguZGxs,,WlhfRjVGMTQwQ0EwOTg5NDVFNEVENUI4MjIxREZEMTk2NjQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|9c867668909443fb0daebf09497c221b,enhfZjVmMTQwY2EwOTg5NDVlNGVkNWI4MjIxZGZkMTk2NjQuZGxs,,WlhfOTExMDRGMjMwNjZENEU3MERGOEFBNjNGMDg3NDE3ODksIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|2a05bd4a81e94683da3a1875ab63d3f8,enhfOTExMDRmMjMwNjZkNGU3MGRmOGFhNjNmMDg3NDE3ODkuZGxs,,WlhfRjlCRkVBRkZDQjA1NDZFMTA2NjA5MURDRDE4QUEwMTIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|ea65102bb4e6488d35bd27ae6bd902c5,enhfZjliZmVhZmZjYjA1NDZlMTA2NjA5MWRjZDE4YWEwMTIuZGxs,,WlhfNkE5MTRGQzJDQzhDNDI1QTI3MjRGMENCRTNFODdGRTQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|04c0cae10c9a4bf7e0e4345689f851b7,enhfNmE5MTRmYzJjYzhjNDI1YTI3MjRmMGNiZTNlODdmZTQuZGxs,,WlhfNTA2NjlEQTQwRjMxNDkyNUQ0Rjc2MjY2ODEyMTE0NTEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|bdc3bc276c854e17e595cec0a91a1776,enhfNTA2NjlkYTQwZjMxNDkyNWQ0Zjc2MjY2ODEyMTE0NTEuZGxs,,WlhfQkYxRjZDNjhEMkM5NEJBMjA2QTEwRjhERkIwQTFFMTUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|a8f373493e2e429f9982a4a6aabcd1fa,enhfYmYxZjZjNjhkMmM5NGJhMjA2YTEwZjhkZmIwYTFlMTUuZGxs,,WlhfNjZEREUwMjlGODQ2NEUwQkU1MUE3Qjk5ODU0MzVBMzIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|c622008ffaa44decfbf50b98b7ecce1a,enhfNjZkZGUwMjlmODQ2NGUwYmU1MWE3Yjk5ODU0MzVhMzIuZGxs,,WlhfOTExRDFGNEQ0QTM5NDA3RDVCNTkxQzY1MEQ0MDkyM0YsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|4bf00b7f12d148f2cad684d78dd4af55,enhfOTExZDFmNGQ0YTM5NDA3ZDViNTkxYzY1MGQ0MDkyM2YuZGxs,,WlhfQ0ZGOTlBQTEzRjJDNDg0RjA3NkVCNjg1N0Y0RDc5RTYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|1cc5b2437dfd44a248313fb361c0f379,enhfY2ZmOTlhYTEzZjJjNDg0ZjA3NmViNjg1N2Y0ZDc5ZTYuZGxs,,WlhfODkxNDBCMDY4RjI3NEZDNTU0MjQ3OEE2QkZBQUVEQjgsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|d5134116e58d41b5e4c62bde2ca4787a,enhfODkxNDBiMDY4ZjI3NGZjNTU0MjQ3OGE2YmZhYWVkYjguZGxs,,WlhfMDcwRDUxQ0U5NjVGNEVBOUExMjVFRDc1Nzc4Qzg0MkQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|86f78e78de644d993c31ed0b1129d551,enhfMDcwZDUxY2U5NjVmNGVhOWExMjVlZDc1Nzc4Yzg0MmQuZGxs,,WlhfQjc1NkFFMkI2RTJENDdBRUI4QkY2Q0NCREZENTcwQzYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|e820046a350c4f34267789bd6ce036e4,enhfYjc1NmFlMmI2ZTJkNDdhZWI4YmY2Y2NiZGZkNTcwYzYuZGxs,,WlhfM0NBNzRDNjJGNzU3NENGNEY0RkIyM0IxMzY5NjEzQTUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|a342b5365a324faba6bdecd5ddb42280,enhfM2NhNzRjNjJmNzU3NGNmNGY0ZmIyM2IxMzY5NjEzYTUuZGxs,,WlhfOTUzNTVCRTM3QTUxNEEzQUJCMERBNTkyN0I4OEY5NzQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|c2c8beb7984d43fa4b2e5bc268450262,enhfOTUzNTViZTM3YTUxNGEzYWJiMGRhNTkyN2I4OGY5NzQuZGxs,,WlhfNjI1QTA0OTVBNjFDNEVCNjhCQUI1MTc4Q0I3NjJGOTUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|957e2f6048344cea4ef946f89515947a,enhfNjI1YTA0OTVhNjFjNGViNjhiYWI1MTc4Y2I3NjJmOTUuZGxs,,WlhfMjVDM0M2QjgwNjA5NDA3QkUwNDMyMkNGRjhBODU0OTEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|730e734ae0de4ebedd439dbc26ce3309,enhfMjVjM2M2YjgwNjA5NDA3YmUwNDMyMmNmZjhhODU0OTEuZGxs,,WlhfMzdFMDFDM0ZBM0M0NEU4NDlDNjFERTlEQzhDNDUwOEYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|52369ac3dd884f165d1160cf5ba23bb1,enhfMzdlMDFjM2ZhM2M0NGU4NDljNjFkZTlkYzhjNDUwOGYuZGxs,,WlhfMzJCMUExRThDNUM5NDY1RDQ4RjdCMjExNTlBRjc1NEUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|b7bf1420c40e4da6f04683e7d178c9e2,enhfMzJiMWExZThjNWM5NDY1ZDQ4ZjdiMjExNTlhZjc1NGUuZGxs,,WlhfRkM5Mjc3NTNGRTA2NDM5QkMyMzZCMzRCMjRCQjEzNTgsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|87e404a3a49643eb0a19c3322b786b3f,enhfZmM5Mjc3NTNmZTA2NDM5YmMyMzZiMzRiMjRiYjEzNTguZGxs,,WlhfMDk4RjQzQzAwQzc0NEE4REEzMTc0MDM1ODVFRkI2OTQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|518cddc5a42d4a266b3fc8dac33a3cc1,enhfMDk4ZjQzYzAwYzc0NGE4ZGEzMTc0MDM1ODVlZmI2OTQuZGxs,,WlhfQjlGQzRENUVBNTUxNEM3QzRBQjY3QTcxODkzQ0Y1QzUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|2fd00baab70d428a2c3e07f48f9ea8e9,enhfYjlmYzRkNWVhNTUxNGM3YzRhYjY3YTcxODkzY2Y1YzUuZGxs,,WlhfMTI4QUI1NUMyOTAyNDIzREY4RkVEQ0VDRDA2NDRGNzgsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|72858ceac0c74cb14a32e894c7912018,enhfMTI4YWI1NWMyOTAyNDIzZGY4ZmVkY2VjZDA2NDRmNzguZGxs,,WlhfQjJGRkY3NDU5QzA1NEE1Qjc2ODNGNDRCMDFDQTNFREUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|4b41e4b4b14a43aa7d012fb0e5074605,enhfYjJmZmY3NDU5YzA1NGE1Yjc2ODNmNDRiMDFjYTNlZGUuZGxs,,WlhfNzQwRDkxMzlFQjAxNDYxQjVBNkZGQjM2RkI5MTQ3QkYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|f22de84f0c334ad0b9ea776fff92093e,enhfNzQwZDkxMzllYjAxNDYxYjVhNmZmYjM2ZmI5MTQ3YmYuZGxs,,WlhfRUI3QUU3RDE2REIxNEY5RTFFQjdENzUwRTA4MkIyNDAsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|ad90edca3f1642d5e0d496748f6d682a,enhfZWI3YWU3ZDE2ZGIxNGY5ZTFlYjdkNzUwZTA4MmIyNDAuZGxs,,WlhfNjVDNDE4MzIwOTYyNDM4NzIzOEI2NzU1REIzMzk0NDMsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|02d6aa3cbeb641afce8ad0ca70927ad0,enhfNjVjNDE4MzIwOTYyNDM4NzIzOGI2NzU1ZGIzMzk0NDMuZGxs,,WlhfMEVGN0I4Q0IyNzUxNDk4RjMxQzY3RDA5NzJFQ0VCMzIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|5d407b7903934fce17541a476cdfd399,enhfMGVmN2I4Y2IyNzUxNDk4ZjMxYzY3ZDA5NzJlY2ViMzIuZGxs,,WlhfNEEzQTJEQTVFNjlGNENDMUNBRkVENEIwQzFDMDc1MzEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|52387d946f3a44d2e3cdd7ae4bc92e24,enhfNGEzYTJkYTVlNjlmNGNjMWNhZmVkNGIwYzFjMDc1MzEuZGxs,,WlhfRkZENUE0NzlEOTg5NDkyMzM2MEUyRUJDRjc0NkIzNEEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|0330cc117c9b40d60c5c5570a8b22012,enhfZmZkNWE0NzlkOTg5NDkyMzM2MGUyZWJjZjc0NmIzNGEuZGxs,,WlhfMjNBNjdENTRFNEEzNEIxMjhGODVENzNGNTg2MzdGQTksIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|d6b122baa0ca4803cb73046670a14d33,enhfMjNhNjdkNTRlNGEzNGIxMjhmODVkNzNmNTg2MzdmYTkuZGxs,,WlhfNkI2MzlENDgwMThBNEJGNzREMjI3RjY4Qzk0MzgzQ0MsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|ff417a4c922c4fa74033a7658cdb1343,enhfNmI2MzlkNDgwMThhNGJmNzRkMjI3ZjY4Yzk0MzgzY2MuZGxs,,WlhfM0JERTc2OUY3QUM4NEY2RTUyRkQ0MkRDMTVERDFFRTIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|080889f6128d49b5fa2d11f87a479911,enhfM2JkZTc2OWY3YWM4NGY2ZTUyZmQ0MmRjMTVkZDFlZTIuZGxs,,WlhfQUREN0JBNEJFNTVDNDIyMjU3NjZFMDZCNUVGRUYwQkEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|74a8c166479346b65175ad30b2c6ff4e,enhfYWRkN2JhNGJlNTVjNDIyMjU3NjZlMDZiNWVmZWYwYmEuZGxs,,WlhfRDc0RkJGRjJFRkUwNDA5NkQ0OTQwQjcxOEZFRDk0REIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|8ce002a3dd484cb680d6931e119d915e,enhfZDc0ZmJmZjJlZmUwNDA5NmQ0OTQwYjcxOGZlZDk0ZGIuZGxs,,WlhfMUE1RDQyREJBNDI4NDc3NzY1QTE5NUEzRTUxRjQxMDQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|9be1d2033a954c8899c60172fe9e8ff5,enhfMWE1ZDQyZGJhNDI4NDc3NzY1YTE5NWEzZTUxZjQxMDQuZGxs,,WlhfMTY2MDI1MEI4RDE2NEQzNTUwMDk3ODlBNUUzNjA2RTYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|d476bc5a44cd4d801f4bde00b293f5dd,enhfMTY2MDI1MGI4ZDE2NGQzNTUwMDk3ODlhNWUzNjA2ZTYuZGxs,,WlhfMzhGOUNGOTI2MEI4NEYxNjQ3MkNDODAwQ0EzQjFCRDgsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|94814a0e113f4236424dffe08a77a8d5,enhfMzhmOWNmOTI2MGI4NGYxNjQ3MmNjODAwY2EzYjFiZDguZGxs,,WlhfQ0JGODJCM0MzQzg5NDIxMzhCMjhDRjEyQ0I5NDczMTUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|3ed189c8caa744252d63b4f7546007de,enhfY2JmODJiM2MzYzg5NDIxMzhiMjhjZjEyY2I5NDczMTUuZGxs,,WlhfOEU3OERDNDUzOTNDNEM5ODZDQTQwQTAyRjE4NTI3NkUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|602a83d76e2d4b9c1dd1f479278312d9,enhfOGU3OGRjNDUzOTNjNGM5ODZjYTQwYTAyZjE4NTI3NmUuZGxs,,WlhfRENEQjk2MzUzODk2NDExOUJGQTJDQjFDQzEzM0JGOTQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|966ec74371c04fddef9470ce8e17f929,enhfZGNkYjk2MzUzODk2NDExOWJmYTJjYjFjYzEzM2JmOTQuZGxs,,WlhfNjlDODlGNDBBOTgwNEI1QUI3MTc4MTQ2MENCMTNGRDksIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|928d37e362424436543037717ed2621f,enhfNjljODlmNDBhOTgwNGI1YWI3MTc4MTQ2MGNiMTNmZDkuZGxs,,WlhfOTgwNjlBMDJFQUNBNDdCNjZFMEVBQTgyRjRBNTQyOEEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|49c6b04ccc7641f631b237a28337aead,enhfOTgwNjlhMDJlYWNhNDdiNjZlMGVhYTgyZjRhNTQyOGEuZGxs,,WlhfNzdDNDJDRDlCM0RENDlBREFFQjZBRTRBNDYwMkM1NUQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|8c4deec44c2e46cb11cda6d781ca392d,enhfNzdjNDJjZDliM2RkNDlhZGFlYjZhZTRhNDYwMmM1NWQuZGxs,,WlhfNEQwQkI4QzZENTdCNDc5MDA4NUE2NzNENUM4MEUyMjUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|ef6f7809e5dd46d404cbff8762a178c7,enhfNGQwYmI4YzZkNTdiNDc5MDA4NWE2NzNkNWM4MGUyMjUuZGxs,,WlhfOTU1OTM1N0NENjYyNDMwQUM0REQ1NzBGMzY1NzQ3OEQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|f12f7d9f5d99481615ab1a290ffbaae4,enhfOTU1OTM1N2NkNjYyNDMwYWM0ZGQ1NzBmMzY1NzQ3OGQuZGxs,,WlhfQkJGRTlDRjk0RjI5NDY3QTkzRDg5NDUzQzA1MThCMDgsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|6123b03aefc3454e7101aa2bd1f58bff,enhfYmJmZTljZjk0ZjI5NDY3YTkzZDg5NDUzYzA1MThiMDguZGxs,,WlhfQThDMUI4NUVDOEUwNEE5QzlEMkFFNjRFNDI3NUFENzcsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|f9577a87dc2a43ae04503550f612caa9,enhfYThjMWI4NWVjOGUwNGE5YzlkMmFlNjRlNDI3NWFkNzcuZGxs,,WlhfNDkwOTIyN0I5MkI3NEI0OTFCRTA5NDI2RTFERkUzRjksIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|c40bb74a56b048c01203e022a9744348,enhfNDkwOTIyN2I5MmI3NGI0OTFiZTA5NDI2ZTFkZmUzZjkuZGxs,,WlhfRkFBN0RGNDRBRjgxNDM2MUFCNDQ2NjY5MjQxRkRFRjgsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|74280b195b6f48d67df7023d2f8e9e90,enhfZmFhN2RmNDRhZjgxNDM2MWFiNDQ2NjY5MjQxZmRlZjguZGxs,,WlhfMzMwNTVDQTgyOTJENEQ1QUJEOTRCNjM4NjFGNTQyRTUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|1dc9f2e5117f48f8065947f732bf6642,enhfMzMwNTVjYTgyOTJkNGQ1YWJkOTRiNjM4NjFmNTQyZTUuZGxs,,WlhfMzUzRkZGQzQ5MUU4NENFNDdCN0EyNkQ2REVDNzRCOTIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|48e59298a5bd4a57098c0eff3a279049,enhfMzUzZmZmYzQ5MWU4NGNlNDdiN2EyNmQ2ZGVjNzRiOTIuZGxs,,WlhfQzkyOTFFNEI3QUFBNEJFOTM5NzI5RDQ2RjI5QkI3RTIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|6d5cebb611e74e5746c692534728aceb,enhfYzkyOTFlNGI3YWFhNGJlOTM5NzI5ZDQ2ZjI5YmI3ZTIuZGxs,,WlhfREIwMzAyNjRDRTgxNEQ2QTUxQjQxRjMzODUzOTdBNUUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|7a3e4cb132664fbe5a15d5ed07952aec,enhfZGIwMzAyNjRjZTgxNGQ2YTUxYjQxZjMzODUzOTdhNWUuZGxs,,WlhfMDFDOTFEMDJFQjg1NDRBRTI1NjZDNDdDQkU4MjFGNzcsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|80f368a850d64ba1c8e7e5855bf68a7f,enhfMDFjOTFkMDJlYjg1NDRhZTI1NjZjNDdjYmU4MjFmNzcuZGxs,,WlhfRTEwMzJFMzEzREZFNENFREJBQ0I3MjkxNzk3Mjc1MUYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|16a23f4b1bf443cb29e854c826c9f3d9,enhfZTEwMzJlMzEzZGZlNGNlZGJhY2I3MjkxNzk3Mjc1MWYuZGxs,,WlhfMDU3NjYzMDM4NjEzNEVFOTU5QUI3QzFFRTA0QzlBNjMsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|f2a5590c5f0547b57f2baf1c047f51f2,enhfMDU3NjYzMDM4NjEzNGVlOTU5YWI3YzFlZTA0YzlhNjMuZGxs,,WlhfOURFNzNFMjAyRERDNDQ0M0Q0QTQ4QzQ0MjVGOEVCOTQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|00d6649ae704485a5e67515c899b803b,enhfOWRlNzNlMjAyZGRjNDQ0M2Q0YTQ4YzQ0MjVmOGViOTQuZGxs,,WlhfMEMyNTg4QTU2RjRCNDZGQzUyQ0VGNEJBOTFBQ0QxRTAsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|724cf97901d543ccda61895f5b667442,enhfMGMyNTg4YTU2ZjRiNDZmYzUyY2VmNGJhOTFhY2QxZTAuZGxs,,WlhfNDhBNUJGQzM2MDQ1NDE4M0VBMjg4M0NBRDZERDBCMjEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|e9893b6f7b004ad72cf8e3a04179377c,enhfNDhhNWJmYzM2MDQ1NDE4M2VhMjg4M2NhZDZkZDBiMjEuZGxs,,WlhfNDNBRjE3OEREMEFGNEY4MjBGNUQwQkU1RTM2OTQxQkMsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|4442c8a277e14f488571e7fca58fd61b,enhfNDNhZjE3OGRkMGFmNGY4MjBmNWQwYmU1ZTM2OTQxYmMuZGxs,,WlhfRjQ0MEJGMUE0NUU0NEFEQzg2MkY3OTFGQUEwRjc0MUIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|d5da02dc06bc4c915682f7c4369c4fe3,enhfZjQ0MGJmMWE0NWU0NGFkYzg2MmY3OTFmYWEwZjc0MWIuZGxs,,WlhfNDBCNjVFOENDNkM0NDBDQUM4MkUwQTk2OTM3NDhBMDYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|6c2c744e28c54b4415a31f95324aa155,enhfNDBiNjVlOGNjNmM0NDBjYWM4MmUwYTk2OTM3NDhhMDYuZGxs,,WlhfRkE1NEZGMzEwNjQzNDY2QTU4OUMzOUIxRkM3QzU3OUEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|58eef449891e4788c46673aaf1f4fa32,enhfZmE1NGZmMzEwNjQzNDY2YTU4OWMzOWIxZmM3YzU3OWEuZGxs,,WlhfQzQ3MDY5REYwNEVCNEE1RkFCNjk0NTVGOTc5OTgyNUYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|a54fc8111c2b415d5c6f3a51b0092045,enhfYzQ3MDY5ZGYwNGViNGE1ZmFiNjk0NTVmOTc5OTgyNWYuZGxs,,WlhfOTY3NUM0NjE3REU1NDE0RUM4NjQwNzE0Mzg5QzVDRjAsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|05a3215bc8ae4e126995d1b9c145628b,enhfOTY3NWM0NjE3ZGU1NDE0ZWM4NjQwNzE0Mzg5YzVjZjAuZGxs,,WlhfMjIyMDBCRUIxQjBFNDZBRDQ0OTNGNjA4MENEQjQwMjYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|5f67cbd7a0a0436c8139c551fec76f9c,enhfMjIyMDBiZWIxYjBlNDZhZDQ0OTNmNjA4MGNkYjQwMjYuZGxs,,WlhfMzk5MkU0QjE0MzM4NDQyRDZDRDA4N0VBNDc5QTEyMDQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|dd891adb8add4526647348afab39beb8,enhfMzk5MmU0YjE0MzM4NDQyZDZjZDA4N2VhNDc5YTEyMDQuZGxs,,WlhfNUQzRkVGODg3MDBFNEFDM0JBNzI5QjZGRkQwQUQ0MzUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|8c9ba79787cd4a9fd4264792592580aa,enhfNWQzZmVmODg3MDBlNGFjM2JhNzI5YjZmZmQwYWQ0MzUuZGxs,,WlhfQkEzQTU3MzA2OTgxNDBEQTNDMDM5RkQ2MEYxMDUxQTgsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|1d8345e9b619417ba12e7ee2c48bc707,enhfYmEzYTU3MzA2OTgxNDBkYTNjMDM5ZmQ2MGYxMDUxYTguZGxs,,WlhfN0UxNzJFOEU4RkRGNDlFMUQ5RTIxNTg3Qzk2ODk4QjIsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|872cd9c2575947b91b3b41f3420348d9,enhfN2UxNzJlOGU4ZmRmNDllMWQ5ZTIxNTg3Yzk2ODk4YjIuZGxs,,WlhfNUQ1MEM3MTI0MjQ3NDBGMkUwM0Q2RTIzNzg5NjgzODYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|f0378538484f426e13350b1cdca134ae,enhfNWQ1MGM3MTI0MjQ3NDBmMmUwM2Q2ZTIzNzg5NjgzODYuZGxs,,WlhfNkZGRkNGMTJFQkEyNEEzQzI0OUY5RUQ3MzQ0REZFMTgsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|cf6d8ac3789a4485c511edd31a75d1ec,enhfNmZmZmNmMTJlYmEyNGEzYzI0OWY5ZWQ3MzQ0ZGZlMTguZGxs,,WlhfMkY5NkM3RUE3N0Q5NDRCMUJERUI5NDkzMTg0NTQyMTUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|92429fc299174d185eb006cfa64f0721,enhfMmY5NmM3ZWE3N2Q5NDRiMWJkZWI5NDkzMTg0NTQyMTUuZGxs,,WlhfMUVFMDg5QTY3QzQ2NDQ5MDcxRjdFOEU5MkU3NUU2MEUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|5a077311b99a4b45bdffc7c3c65b6793,enhfMWVlMDg5YTY3YzQ2NDQ5MDcxZjdlOGU5MmU3NWU2MGUuZGxs,,WlhfODhEQTkwRTlDNjlENDUzRjdGNUM3NzJEMTRGRTJBRUQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|06716523689342ce9c69bd01c1465710,enhfODhkYTkwZTljNjlkNDUzZjdmNWM3NzJkMTRmZTJhZWQuZGxs,,WlhfOTNGRjY3N0IxODYyNEY2RTQ2OThERDk1RjVGNDUxNTMsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|bfb45d90d5e54ada515d308dc3c85fe8,enhfOTNmZjY3N2IxODYyNGY2ZTQ2OThkZDk1ZjVmNDUxNTMuZGxs,,WlhfMDI1RUQ2MThCRUM5NDRDMURDQ0RDRjE3NzhBNzZBN0QsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|601d64fddc7b492723e62f3e0ed335b0,enhfMDI1ZWQ2MThiZWM5NDRjMWRjY2RjZjE3NzhhNzZhN2QuZGxs,,WlhfMjEyODBGMDA4NUJGNDhDQTc1NTgwMTU5MUUwN0YwN0YsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|661308aa712241dff3b6e5f499669220,enhfMjEyODBmMDA4NWJmNDhjYTc1NTgwMTU5MWUwN2YwN2YuZGxs,,WlhfQUVDRTM2QTI2MUNDNDk1MEZDQTZGRkY5MUFGMDc5RjcsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|78f27722e10a48bb50e83385349a1d15,enhfYWVjZTM2YTI2MWNjNDk1MGZjYTZmZmY5MWFmMDc5ZjcuZGxs,,WlhfNjZBQzFBREM2ODYxNDdFRTFFM0NGOUREMDU4NTc1MzEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|b5205000103b41f9917f1ad8c4ad849a,enhfNjZhYzFhZGM2ODYxNDdlZTFlM2NmOWRkMDU4NTc1MzEuZGxs,,WlhfRkMwQzY3MEY4OEJENEFDQzI3MDNEOUFGMTA3NDlFRkEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|43a698cdf3f748312baa6523b500ede8,enhfZmMwYzY3MGY4OGJkNGFjYzI3MDNkOWFmMTA3NDllZmEuZGxs,,WlhfRDdERDNGNkRGNTk5NDRBNTMxNEQ1RjBCRjMxQkJCOTUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|09c58a5946894ee9224e4f0845842b45,enhfZDdkZDNmNmRmNTk5NDRhNTMxNGQ1ZjBiZjMxYmJiOTUuZGxs,,WlhfNjA1MkUxM0M4MDg0NDI0NTE1MEM0NjM4REJGN0I3QjUsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|48e6a26daa3548dbe2adc84ca9bc8bef,enhfNjA1MmUxM2M4MDg0NDI0NTE1MGM0NjM4ZGJmN2I3YjUuZGxs,,WlhfREQxQzk5NEM4MkI4NDZFMjY2RkY5OUYwQ0E0N0FFMTYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|a4700da8055f4b05b5c6e0953b5be146,enhfZGQxYzk5NGM4MmI4NDZlMjY2ZmY5OWYwY2E0N2FlMTYuZGxs,,WlhfODZDMTFERTM4QTk5NEI5RTI3NjhGNjZFQ0E1NURDNEYsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|33ffb91e5d5a4e9044693886bbe8a5dc,enhfODZjMTFkZTM4YTk5NGI5ZTI3NjhmNjZlY2E1NWRjNGYuZGxs,,WlhfMkEzRkZBMkIwQzJCNDQyNDg5NDRGNzMwQjdFRDg3REQsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab|2263fce48f2d4e7ebb92adb4407c31ab,enhfMmEzZmZhMmIwYzJiNDQyNDg5NDRmNzMwYjdlZDg3ZGQuZGxs,,WlhfQzhCMjVCMjAyQkUxNDRDMUEyRjk5RTA0RTFGMTVBMEEsIENVTFRVUkU9TkVVVFJBTCwgUFVCTElDS0VZVE9LRU49TlVMTA==,ab[...string is too long...]";
					this.string_2 = text.Split(new char[]
					{
						','
					});
					if (this.string_0 == null && !Class682.smethod_0())
					{
						return false;
					}
					this.string_3 = this.string_2[0];
					this.int_2 = 1;
					goto IL_A0;
				}
				IL_92:
				this.int_2 += 4;
				IL_A0:
				if (this.int_2 >= this.string_2.Length)
				{
					return false;
				}
				string text2 = this.string_2[this.int_2];
				if (this.string_0 != null && !text2.Equals(this.string_0, StringComparison.Ordinal))
				{
					goto IL_92;
				}
				Class682.Class685.Class687 @class = new Class682.Class685.Class687();
				@class.string_2 = this.string_3;
				@class.string_0 = text2;
				string text3 = this.string_2[this.int_2 + 1];
				int num2 = text3.IndexOf('|');
				if (num2 >= 0)
				{
					string text4 = text3.Substring(0, num2);
					text3 = text3.Substring(num2 + 1);
					@class.bool_0 = (text4.IndexOf('a') != -1);
					@class.bool_1 = (text4.IndexOf('b') != -1);
					@class.bool_2 = (text4.IndexOf('c') != -1);
					@class.bool_5 = (text4.IndexOf('f') != -1);
				}
				@class.string_3 = text3;
				@class.string_4 = this.string_2[this.int_2 + 2];
				this.class687_0 = @class;
				this.int_0 = 1;
				return true;
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x06002390 RID: 9104 RVA: 0x0001764B File Offset: 0x0001584B
			Class682.Class685.Class687 IEnumerator<Class682.Class685.Class687>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.class687_0;
				}
			}

			// Token: 0x06002391 RID: 9105 RVA: 0x000031EC File Offset: 0x000013EC
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new NotSupportedException();
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x06002392 RID: 9106 RVA: 0x0001764B File Offset: 0x0001584B
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return this.class687_0;
				}
			}

			// Token: 0x06002393 RID: 9107 RVA: 0x0008BF60 File Offset: 0x0008A160
			[DebuggerHidden]
			IEnumerator<Class682.Class685.Class687> IEnumerable<Class682.Class685.Class687>.GetEnumerator()
			{
				Class682.Class685.Class686 @class;
				if (this.int_0 == -2 && this.int_1 == Thread.CurrentThread.ManagedThreadId)
				{
					this.int_0 = 0;
					@class = this;
				}
				else
				{
					@class = new Class682.Class685.Class686(0);
				}
				@class.string_0 = this.string_1;
				return @class;
			}

			// Token: 0x06002394 RID: 9108 RVA: 0x00017653 File Offset: 0x00015853
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.System.Collections.Generic.IEnumerable<Class682.Class685.Class687>.GetEnumerator();
			}

			// Token: 0x0400176C RID: 5996
			private int int_0;

			// Token: 0x0400176D RID: 5997
			private Class682.Class685.Class687 class687_0;

			// Token: 0x0400176E RID: 5998
			private int int_1;

			// Token: 0x0400176F RID: 5999
			private string string_0;

			// Token: 0x04001770 RID: 6000
			public string string_1;

			// Token: 0x04001771 RID: 6001
			private string[] string_2;

			// Token: 0x04001772 RID: 6002
			private string string_3;

			// Token: 0x04001773 RID: 6003
			private int int_2;
		}

		// Token: 0x02000588 RID: 1416
		private struct Struct363
		{
			// Token: 0x06002395 RID: 9109 RVA: 0x0001765B File Offset: 0x0001585B
			public Struct363(string string_1)
			{
				this = default(Class682.Class685.Struct363);
				this.string_0 = string_1;
			}

			// Token: 0x06002396 RID: 9110 RVA: 0x0008BFA8 File Offset: 0x0008A1A8
			public bool method_0()
			{
				try
				{
					if (this.fileStream_0 != null)
					{
						return false;
					}
					this.fileStream_0 = new FileStream(this.string_0, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, 128, FileOptions.DeleteOnClose);
				}
				catch
				{
					return false;
				}
				return true;
			}

			// Token: 0x06002397 RID: 9111 RVA: 0x0008BFFC File Offset: 0x0008A1FC
			public void method_1()
			{
				Stopwatch stopwatch = null;
				int num = 25;
				int num2 = 250;
				while (!this.method_0())
				{
					if (stopwatch == null)
					{
						stopwatch = Stopwatch.StartNew();
					}
					else
					{
						if (stopwatch.Elapsed.TotalSeconds > 300.0)
						{
							throw new TimeoutException(string.Format("Timeout while acquiring file lock '{0}'.", this.string_0));
						}
						if (num < num2)
						{
							num = Math.Min(num * 2, num2);
						}
					}
					Thread.Sleep(num);
				}
			}

			// Token: 0x06002398 RID: 9112 RVA: 0x0001766B File Offset: 0x0001586B
			public void method_2()
			{
				if (this.fileStream_0 != null)
				{
					this.fileStream_0.Dispose();
					this.fileStream_0 = null;
				}
			}

			// Token: 0x04001774 RID: 6004
			private readonly string string_0;

			// Token: 0x04001775 RID: 6005
			private FileStream fileStream_0;
		}

		// Token: 0x02000589 RID: 1417
		internal sealed class Class687
		{
			// Token: 0x0600239A RID: 9114 RVA: 0x0008C070 File Offset: 0x0008A270
			public string method_0()
			{
				if (this.string_1 == null)
				{
					byte[] array = Convert.FromBase64String(this.string_0);
					this.string_1 = Encoding.UTF8.GetString(array, 0, array.Length);
				}
				return this.string_1;
			}

			// Token: 0x0600239B RID: 9115 RVA: 0x0008C0AC File Offset: 0x0008A2AC
			public string method_1()
			{
				if (this.string_5 == null)
				{
					byte[] array = Convert.FromBase64String(this.string_4);
					this.string_5 = Encoding.UTF8.GetString(array, 0, array.Length);
				}
				return this.string_5;
			}

			// Token: 0x04001776 RID: 6006
			public string string_0;

			// Token: 0x04001777 RID: 6007
			private string string_1;

			// Token: 0x04001778 RID: 6008
			public string string_2;

			// Token: 0x04001779 RID: 6009
			public string string_3;

			// Token: 0x0400177A RID: 6010
			public bool bool_0;

			// Token: 0x0400177B RID: 6011
			public bool bool_1;

			// Token: 0x0400177C RID: 6012
			public bool bool_2;

			// Token: 0x0400177D RID: 6013
			public bool bool_3;

			// Token: 0x0400177E RID: 6014
			public bool bool_4;

			// Token: 0x0400177F RID: 6015
			public bool bool_5;

			// Token: 0x04001780 RID: 6016
			public string string_4;

			// Token: 0x04001781 RID: 6017
			private string string_5;
		}
	}

	// Token: 0x0200058A RID: 1418
	private struct Struct364
	{
		// Token: 0x0600239C RID: 9116 RVA: 0x0008C0E8 File Offset: 0x0008A2E8
		public Struct364(string string_3)
		{
			this = default(Class682.Struct364);
			this.version_0 = new Version();
			this.string_0 = string.Empty;
			foreach (string text in string_3.Split(new char[]
			{
				','
			}))
			{
				string text2 = text.Trim();
				if (text2.StartsWith("Version=", StringComparison.OrdinalIgnoreCase))
				{
					this.version_0 = new Version(text2.Substring("Version=".Length));
					this.bool_0 = true;
				}
				else if (text2.StartsWith("Culture=", StringComparison.OrdinalIgnoreCase))
				{
					this.string_1 = text2.Substring("Culture=".Length);
					if (this.string_1.Equals("neutral", StringComparison.OrdinalIgnoreCase))
					{
						this.string_1 = null;
					}
					this.bool_1 = true;
				}
				else if (text2.StartsWith("PublicKeyToken=", StringComparison.OrdinalIgnoreCase))
				{
					this.string_2 = text2.Substring("PublicKeyToken=".Length);
					if (this.string_2.Equals("null", StringComparison.OrdinalIgnoreCase))
					{
						this.string_2 = null;
					}
					this.bool_2 = true;
				}
				else
				{
					this.string_0 = text2;
				}
			}
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0008C218 File Offset: 0x0008A418
		public string method_0(bool bool_3)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.string_0);
			if (bool_3)
			{
				stringBuilder.Append(", VERSION=").Append(this.version_0);
			}
			stringBuilder.Append(", CULTURE=").Append(this.string_1 ?? "NEUTRAL").Append(", PUBLICKEYTOKEN=").Append(this.string_2 ?? "NULL");
			return stringBuilder.ToString();
		}

		// Token: 0x04001782 RID: 6018
		public Version version_0;

		// Token: 0x04001783 RID: 6019
		public bool bool_0;

		// Token: 0x04001784 RID: 6020
		public string string_0;

		// Token: 0x04001785 RID: 6021
		public string string_1;

		// Token: 0x04001786 RID: 6022
		public bool bool_1;

		// Token: 0x04001787 RID: 6023
		public string string_2;

		// Token: 0x04001788 RID: 6024
		public bool bool_2;
	}
}
