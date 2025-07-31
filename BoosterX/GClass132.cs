using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Threading;

// Token: 0x020003D3 RID: 979
public sealed class GClass132 : IDisposable
{
	// Token: 0x060019A2 RID: 6562 RVA: 0x00070DE0 File Offset: 0x0006EFE0
	private GClass132()
	{
		this.powerShell_0 = PowerShell.Create();
		this.powerShell_0.AddScript("Write-Verbose 'Initialized'");
		this.powerShell_0.Invoke();
		this.powerShell_0.Commands.Clear();
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x00011562 File Offset: 0x0000F762
	public static GClass132 smethod_0()
	{
		return GClass132.lazy_0.Value;
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x00070E38 File Offset: 0x0006F038
	public Collection<PSObject> method_0(string string_0)
	{
		object obj = this.object_0;
		Collection<PSObject> result2;
		lock (obj)
		{
			try
			{
				this.powerShell_0.Commands.Clear();
				this.powerShell_0.AddScript(string_0);
				Collection<PSObject> result = this.powerShell_0.Invoke();
				if (this.powerShell_0.Streams.Error.Count > 0)
				{
					string str = string.Join(Environment.NewLine, this.powerShell_0.Streams.Error.Select(new Func<ErrorRecord, string>(GClass132.Class444.class444_0.method_0)));
					this.powerShell_0.Streams.Error.Clear();
					throw new InvalidOperationException("PowerShell errors occurred: " + str);
				}
				return result;
			}
			catch (Exception exception_)
			{
				GClass268.smethod_1(exception_);
			}
			result2 = null;
		}
		return result2;
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x00070F34 File Offset: 0x0006F134
	public void Dispose()
	{
		object obj = this.object_0;
		lock (obj)
		{
			PowerShell powerShell = this.powerShell_0;
			if (powerShell != null)
			{
				powerShell.Dispose();
			}
			this.powerShell_0 = null;
		}
	}

	// Token: 0x040010E7 RID: 4327
	private static readonly Lazy<GClass132> lazy_0 = new Lazy<GClass132>(new Func<GClass132>(GClass132.Class444.class444_0.method_1), LazyThreadSafetyMode.ExecutionAndPublication);

	// Token: 0x040010E8 RID: 4328
	private PowerShell powerShell_0;

	// Token: 0x040010E9 RID: 4329
	private readonly object object_0 = new object();

	// Token: 0x020003D4 RID: 980
	[Serializable]
	private sealed class Class444
	{
		// Token: 0x060019A9 RID: 6569 RVA: 0x0001157A File Offset: 0x0000F77A
		internal string method_0(ErrorRecord errorRecord_0)
		{
			return errorRecord_0.ToString();
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00011582 File Offset: 0x0000F782
		internal GClass132 method_1()
		{
			return new GClass132();
		}

		// Token: 0x040010EA RID: 4330
		public static readonly GClass132.Class444 class444_0 = new GClass132.Class444();

		// Token: 0x040010EB RID: 4331
		public static Func<ErrorRecord, string> func_0;
	}
}
