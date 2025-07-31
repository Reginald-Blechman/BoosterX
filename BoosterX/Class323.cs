using System;
using DiscordRPC;
using DiscordRPC.Logging;

// Token: 0x020002B2 RID: 690
internal sealed class Class323
{
	// Token: 0x06001246 RID: 4678 RVA: 0x0005C2C4 File Offset: 0x0005A4C4
	public static void smethod_0()
	{
		Class323.discordRpcClient_0 = new DiscordRpcClient("1146177568672850101")
		{
			Logger = new ConsoleLogger
			{
				Level = 3
			}
		};
		Class323.discordRpcClient_0.Initialize();
		Class323.discordRpcClient_0.SetPresence(new RichPresence
		{
			State = Class298.smethod_2("BoostingFPS"),
			Assets = new Assets
			{
				LargeImageKey = "logox"
			},
			Timestamps = new Timestamps(DateTime.UtcNow),
			Buttons = new Button[]
			{
				new Button
				{
					Label = Class298.smethod_2("download"),
					Url = "https://boosterx.org/"
				},
				new Button
				{
					Label = "Discord Server",
					Url = "https://discord.gg/boosterx"
				}
			}
		});
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x0000D18D File Offset: 0x0000B38D
	public static void smethod_1()
	{
		Class323.discordRpcClient_0.Dispose();
	}

	// Token: 0x04000B7F RID: 2943
	public static DiscordRpcClient discordRpcClient_0;
}
