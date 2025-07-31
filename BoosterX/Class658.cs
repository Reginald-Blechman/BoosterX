using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

// Token: 0x0200055C RID: 1372
internal sealed class Class658
{
	// Token: 0x0600226E RID: 8814 RVA: 0x00089750 File Offset: 0x00087950
	public static IPAddress smethod_0()
	{
		foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				foreach (GatewayIPAddressInformation gatewayIPAddressInformation in networkInterface.GetIPProperties().GatewayAddresses)
				{
					if (gatewayIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
					{
						return gatewayIPAddressInformation.Address;
					}
				}
			}
		}
		return null;
	}
}
