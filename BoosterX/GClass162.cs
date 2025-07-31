using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000454 RID: 1108
public class GClass162 : INotifyPropertyChanged
{
	// Token: 0x14000004 RID: 4
	// (add) Token: 0x06001CD2 RID: 7378 RVA: 0x0007902C File Offset: 0x0007722C
	// (remove) Token: 0x06001CD3 RID: 7379 RVA: 0x00079064 File Offset: 0x00077264
	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	// Token: 0x06001CD4 RID: 7380 RVA: 0x00013131 File Offset: 0x00011331
	protected void method_0([CallerMemberName] string string_0)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_0));
	}

	// Token: 0x06001CD5 RID: 7381 RVA: 0x0001314A File Offset: 0x0001134A
	protected bool method_1<T>(ref T gparam_0, T gparam_1, [CallerMemberName] string string_0, Action action_0)
	{
		if (EqualityComparer<T>.Default.Equals(gparam_0, gparam_1))
		{
			return false;
		}
		gparam_0 = gparam_1;
		this.method_0(string_0);
		if (action_0 != null)
		{
			action_0();
		}
		return true;
	}

	// Token: 0x04001328 RID: 4904
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
