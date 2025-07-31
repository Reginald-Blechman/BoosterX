using System;

// Token: 0x02000256 RID: 598
public interface GInterface8
{
	// Token: 0x0600101C RID: 4124
	bool imethod_0<T>() where T : GInterface16, new();

	// Token: 0x0600101D RID: 4125
	bool imethod_1<T>() where T : GInterface16, new();

	// Token: 0x0600101E RID: 4126
	bool imethod_2<T>(string string_0) where T : GInterface16, new();

	// Token: 0x0600101F RID: 4127
	void imethod_3();

	// Token: 0x06001020 RID: 4128
	T imethod_4<T>() where T : class, GInterface16, new();
}
