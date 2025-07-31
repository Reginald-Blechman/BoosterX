using System;
using System.IO;
using ns0;

// Token: 0x0200058D RID: 1421
internal sealed class Class689
{
	// Token: 0x060023CF RID: 9167 RVA: 0x0008C400 File Offset: 0x0008A600
	public static byte[] smethod_0(Class261 class261_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		long value = class261_0.DateTime_0.smethod_0();
		binaryWriter.Write(value);
		foreach (Class265 @class in class261_0.List_0)
		{
			if (@class != null && @class.State != null && @class.Name != null)
			{
				binaryWriter.Write(@class.State);
				binaryWriter.Write(@class.Name);
				binaryWriter.Write((byte)@class.Type);
			}
		}
		return GClass288.smethod_0(memoryStream.ToArray()).smethod_2(2);
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x0008C4B8 File Offset: 0x0008A6B8
	public static Class261 smethod_1(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(GClass288.smethod_1(byte_0.smethod_2(2)));
		BinaryReader binaryReader = new BinaryReader(memoryStream);
		Class261 @class = new Class261();
		DateTime dateTime_ = binaryReader.ReadInt64().smethod_1();
		@class.DateTime_0 = dateTime_;
		while (memoryStream.Position < memoryStream.Length)
		{
			@class.List_0.Add(new Class265
			{
				State = binaryReader.ReadString(),
				Name = binaryReader.ReadString(),
				Type = (dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd)binaryReader.ReadByte()
			});
		}
		return @class;
	}
}
