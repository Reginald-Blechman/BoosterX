using System;
using System.Runtime.CompilerServices;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x0200019A RID: 410
public sealed class GClass32 : IComparable<GClass32>
{
	// Token: 0x06000B9B RID: 2971 RVA: 0x00003332 File Offset: 0x00001532
	public GClass32()
	{
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x0004A494 File Offset: 0x00048694
	public GClass32(NVDRS_PROFILE nvdrs_PROFILE_0)
	{
		this.method_1((int)nvdrs_PROFILE_0.version);
		this.ProfileName = nvdrs_PROFILE_0.profileName;
		this.method_3(nvdrs_PROFILE_0.gpuSupport);
		this.method_5(nvdrs_PROFILE_0.isPredefined == 1U);
		this.method_7((int)nvdrs_PROFILE_0.numOfApps);
		this.method_9((int)nvdrs_PROFILE_0.numOfSettings);
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x0000918B File Offset: 0x0000738B
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x00009193 File Offset: 0x00007393
	public void method_1(int int_3)
	{
		this.int_0 = int_3;
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0000919C File Offset: 0x0000739C
	// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x000091A4 File Offset: 0x000073A4
	public string ProfileName
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x000091AD File Offset: 0x000073AD
	public NVDRS_GPU_SUPPORT method_2()
	{
		return this.nvdrs_GPU_SUPPORT_0;
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x000091B5 File Offset: 0x000073B5
	public void method_3(NVDRS_GPU_SUPPORT nvdrs_GPU_SUPPORT_1)
	{
		this.nvdrs_GPU_SUPPORT_0 = nvdrs_GPU_SUPPORT_1;
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x000091BE File Offset: 0x000073BE
	public bool method_4()
	{
		return this.bool_0;
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x000091C6 File Offset: 0x000073C6
	public void method_5(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x000091CF File Offset: 0x000073CF
	public int method_6()
	{
		return this.int_1;
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x000091D7 File Offset: 0x000073D7
	public void method_7(int int_3)
	{
		this.int_1 = int_3;
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x000091E0 File Offset: 0x000073E0
	public int method_8()
	{
		return this.int_2;
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x000091E8 File Offset: 0x000073E8
	public void method_9(int int_3)
	{
		this.int_2 = int_3;
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x000091F1 File Offset: 0x000073F1
	public override string ToString()
	{
		if (!this.ProfileName.Equals("base profile", StringComparison.OrdinalIgnoreCase))
		{
			return this.ProfileName;
		}
		return Class298.smethod_2("GlobalProfile");
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00009219 File Offset: 0x00007419
	public int CompareTo(GClass32 other)
	{
		if (!this.ProfileName.Equals("base profile", StringComparison.OrdinalIgnoreCase))
		{
			return this.ProfileName.CompareTo(other.ProfileName);
		}
		return 0;
	}

	// Token: 0x0400077D RID: 1917
	private int int_0;

	// Token: 0x0400077E RID: 1918
	private string string_0;

	// Token: 0x0400077F RID: 1919
	private NVDRS_GPU_SUPPORT nvdrs_GPU_SUPPORT_0;

	// Token: 0x04000780 RID: 1920
	private bool bool_0;

	// Token: 0x04000781 RID: 1921
	private int int_1;

	// Token: 0x04000782 RID: 1922
	private int int_2;
}
