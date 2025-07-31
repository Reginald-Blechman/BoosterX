using System;
using System.Collections.Generic;
using System.Windows.Media;
using ns0;

// Token: 0x020001AB RID: 427
internal sealed class Class211
{
	// Token: 0x06000BFF RID: 3071 RVA: 0x0004B4C8 File Offset: 0x000496C8
	public static List<Class521> smethod_0()
	{
		List<Class521> list = new List<Class521>
		{
			new Class521
			{
				Name = "QVisuals2",
				Grad1 = (Color)ColorConverter.ConvertFromString("#231463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#48359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#6E58D5"),
				MainButton = "IDontCare",
				RedButton = "ICare",
				Image = "/BoosterX;component/Resources/Images/Questions/Visuals.png"
			},
			new Class521
			{
				Name = "QUpdates2",
				Grad1 = (Color)ColorConverter.ConvertFromString("#531463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#62359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#7958D5"),
				MainButton = "dodisable",
				RedButton = "Dont",
				Image = "/BoosterX;component/Resources/Images/Questions/Update.png"
			},
			new Class521
			{
				Name = "QBluetooth",
				Grad1 = (Color)ColorConverter.ConvertFromString("#141C63"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#35399B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#5874D5"),
				MainButton = "NotUsing",
				RedButton = "IUse",
				Image = "/BoosterX;component/Resources/Images/Questions/Bluetooth.png"
			},
			new Class521
			{
				Name = "QXBOX",
				Grad1 = (Color)ColorConverter.ConvertFromString("#531463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#62359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#7958D5"),
				MainButton = "IDontPlay",
				RedButton = "IDoPlay",
				Image = "/BoosterX;component/Resources/Images/Questions/XBOX.png"
			},
			new Class521
			{
				Name = "QGameBar",
				Grad1 = (Color)ColorConverter.ConvertFromString("#141C63"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#35399B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#5874D5"),
				MainButton = "no",
				RedButton = "yes",
				Image = "/BoosterX;component/Resources/Images/Questions/GameBar.png"
			},
			new Class521
			{
				Name = "QPrinter",
				Grad1 = (Color)ColorConverter.ConvertFromString("#231463"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#48359B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#6E58D5"),
				MainButton = "NotUsing",
				RedButton = "IUse",
				Image = "/BoosterX;component/Resources/Images/Questions/Printer.png"
			}
		};
		if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_18)
		{
			list.Add(new Class521
			{
				Name = "QNvidia2",
				Grad1 = (Color)ColorConverter.ConvertFromString("#141C63"),
				Grad2 = (Color)ColorConverter.ConvertFromString("#35399B"),
				Grad3 = (Color)ColorConverter.ConvertFromString("#5874D5"),
				MainButton = "DoSetUp",
				RedButton = "Dont",
				Image = "/BoosterX;component/Resources/Images/Questions/Nvidia.png"
			});
		}
		list.Add(new Class521
		{
			Name = "QFinal",
			Grad1 = (Color)ColorConverter.ConvertFromString("#231463"),
			Grad2 = (Color)ColorConverter.ConvertFromString("#48359B"),
			Grad3 = (Color)ColorConverter.ConvertFromString("#6E58D5"),
			MainButton = "apply",
			RedButton = string.Empty,
			Image = "/BoosterX;component/Resources/Images/Questions/Final.png"
		});
		return list;
	}
}
