using System;

// Token: 0x020003B9 RID: 953
public sealed class GClass128
{
	// Token: 0x06001910 RID: 6416 RVA: 0x00010F2E File Offset: 0x0000F12E
	public GClass128(Uri uri_1)
	{
		this.method_20(uri_1);
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x00010F3D File Offset: 0x0000F13D
	public string method_0()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Users/Auth";
	}

	// Token: 0x06001912 RID: 6418 RVA: 0x00010F5C File Offset: 0x0000F15C
	public string method_1()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Users/GetUsersAndVer";
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x00010F7B File Offset: 0x0000F17B
	public string method_2()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Pro";
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x00010F9A File Offset: 0x0000F19A
	public string method_3()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Trial";
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x00010FB9 File Offset: 0x0000F1B9
	public string method_4()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Trial/Get";
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x00010FD8 File Offset: 0x0000F1D8
	public string method_5()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "DiscordRole";
	}

	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x06001917 RID: 6423 RVA: 0x00010FF7 File Offset: 0x0000F1F7
	public string News
	{
		get
		{
			Uri uri = this.uri_0;
			return ((uri != null) ? uri.ToString() : null) + "News/Get";
		}
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x00011016 File Offset: 0x0000F216
	public string method_6()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Support/Check";
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x00011035 File Offset: 0x0000F235
	public string method_7()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Support/Unhwid";
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00011054 File Offset: 0x0000F254
	public string method_8()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Support/ResendOD";
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x00011073 File Offset: 0x0000F273
	public string method_9()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "ProBackUp/GetList";
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x00011092 File Offset: 0x0000F292
	public string method_10()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "ProBackUp/Get";
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x000110B1 File Offset: 0x0000F2B1
	public string method_11()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "ProBackUp/Add";
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x000110D0 File Offset: 0x0000F2D0
	public string method_12()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "ProBackUp/Delete";
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x000110EF File Offset: 0x0000F2EF
	public string method_13()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Tweak/Get";
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x0001110E File Offset: 0x0000F30E
	public string method_14()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Tweak/Add";
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x0001112D File Offset: 0x0000F32D
	public string method_15()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Tweak/Delete";
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x0001114C File Offset: 0x0000F34C
	public string method_16()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Tweak/Update";
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x0001116B File Offset: 0x0000F36B
	public string method_17()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "Tweak/Check";
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x0001118A File Offset: 0x0000F38A
	public string method_18()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "ITServers/Get";
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x000111A9 File Offset: 0x0000F3A9
	public string method_19()
	{
		Uri uri = this.uri_0;
		return ((uri != null) ? uri.ToString() : null) + "VectorDB/Search";
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x0006F388 File Offset: 0x0006D588
	private void method_20(Uri uri_1)
	{
		object[] object_ = new object[]
		{
			this,
			uri_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "X0f:AZa-hs", object_);
	}

	// Token: 0x04001083 RID: 4227
	public Uri uri_0;
}
