using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Microsoft.Xaml.Behaviors;

// Token: 0x02000315 RID: 789
public sealed class GClass104 : Behavior<ScrollViewer>
{
	// Token: 0x06001457 RID: 5207 RVA: 0x0000E32E File Offset: 0x0000C52E
	protected override void OnAttached()
	{
		base.OnAttached();
		base.AssociatedObject.Loaded += this.method_0;
	}

	// Token: 0x06001458 RID: 5208 RVA: 0x00063E84 File Offset: 0x00062084
	private void method_0(object sender, RoutedEventArgs e)
	{
		PropertyInfo property = base.AssociatedObject.GetType().GetProperty("ScrollInfo", BindingFlags.Instance | BindingFlags.NonPublic);
		property.SetValue(base.AssociatedObject, new Class413((IScrollInfo)property.GetValue(base.AssociatedObject)));
	}
}
