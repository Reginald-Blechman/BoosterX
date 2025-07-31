using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

// Token: 0x0200050F RID: 1295
public sealed class GClass224 : IDisposable
{
	// Token: 0x060020C5 RID: 8389 RVA: 0x00083780 File Offset: 0x00081980
	public GClass224(string string_0)
	{
		FileStream stream = new FileStream(string_0, FileMode.Create);
		this.zipArchive_0 = new ZipArchive(stream, ZipArchiveMode.Create);
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x00015A54 File Offset: 0x00013C54
	public void method_0(ValueTuple<string, byte[]>[] valueTuple_0)
	{
		this.method_1(valueTuple_0);
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x000837A8 File Offset: 0x000819A8
	public void method_1(IEnumerable<ValueTuple<string, byte[]>> ienumerable_0)
	{
		foreach (ValueTuple<string, byte[]> valueTuple in ienumerable_0)
		{
			using (Stream stream = this.zipArchive_0.CreateEntry(valueTuple.Item1).Open())
			{
				stream.Write(valueTuple.Item2, 0, valueTuple.Item2.Length);
			}
		}
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x00015A5D File Offset: 0x00013C5D
	public void Dispose()
	{
		ZipArchive zipArchive = this.zipArchive_0;
		if (zipArchive == null)
		{
			return;
		}
		zipArchive.Dispose();
	}

	// Token: 0x040015AE RID: 5550
	private ZipArchive zipArchive_0;
}
