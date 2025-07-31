using System;
using System.IO;
using System.IO.Compression;

// Token: 0x020002F1 RID: 753
public static class GClass96
{
	// Token: 0x060013A9 RID: 5033 RVA: 0x00062080 File Offset: 0x00060280
	public static byte[] smethod_0(this byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("#=zE8d3WmI=");
		}
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress);
			try
			{
				gzipStream.Write(byte_0, 0, byte_0.Length);
			}
			finally
			{
				((IDisposable)gzipStream).Dispose();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x000620F0 File Offset: 0x000602F0
	public static byte[] smethod_1(this byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("#=zJ_1_slU=");
		}
		MemoryStream memoryStream = new MemoryStream(byte_0);
		byte[] result;
		try
		{
			GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
			try
			{
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					byte[] array = new byte[8192];
					int count;
					while ((count = gzipStream.Read(array, 0, array.Length)) != 0)
					{
						memoryStream2.Write(array, 0, count);
					}
					result = memoryStream2.ToArray();
				}
				finally
				{
					((IDisposable)memoryStream2).Dispose();
				}
			}
			finally
			{
				((IDisposable)gzipStream).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}
}
