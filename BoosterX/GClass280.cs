using System;
using System.Windows.Input;

// Token: 0x0200067E RID: 1662
public sealed class GClass280 : ICommand
{
	// Token: 0x06002A15 RID: 10773 RVA: 0x0001B725 File Offset: 0x00019925
	public GClass280(Action<object> action_1, Func<object, bool> func_1 = null)
	{
		this.action_0 = action_1;
		this.func_0 = func_1;
	}

	// Token: 0x06002A16 RID: 10774 RVA: 0x00003332 File Offset: 0x00001532
	public GClass280()
	{
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06002A17 RID: 10775 RVA: 0x0001B73B File Offset: 0x0001993B
	// (remove) Token: 0x06002A18 RID: 10776 RVA: 0x0001B743 File Offset: 0x00019943
	public event EventHandler CanExecuteChanged
	{
		add
		{
			CommandManager.RequerySuggested += value;
		}
		remove
		{
			CommandManager.RequerySuggested -= value;
		}
	}

	// Token: 0x06002A19 RID: 10777 RVA: 0x0001B74B File Offset: 0x0001994B
	public bool CanExecute(object parameter)
	{
		return this.func_0 == null || this.func_0(parameter);
	}

	// Token: 0x06002A1A RID: 10778 RVA: 0x0001B763 File Offset: 0x00019963
	public void Execute(object parameter)
	{
		this.action_0(parameter);
	}

	// Token: 0x04001B8D RID: 7053
	private readonly Action<object> action_0;

	// Token: 0x04001B8E RID: 7054
	private readonly Func<object, bool> func_0;
}
