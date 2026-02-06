using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace dctool
{
	// Token: 0x02000003 RID: 3
	internal class Program
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002088 File Offset: 0x00000288
		private static void Main(string[] args)
		{
			Console.Title = "whtool";
			for (;;)
			{
				Console.Clear();
				Program.Banner();
				Program.Menu();
				char keyChar = Console.ReadKey().KeyChar;
				Console.WriteLine(keyChar);
				char c = keyChar;
				char c2 = c;
				if (c2 != '1')
				{
					if (c2 == '2')
					{
						break;
					}
				}
				else
				{
					Program.webhookMessage();
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020ED File Offset: 0x000002ED
		private static void Banner()
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("\r\n\r\n                                                            \r\n                                                            \r\n                 █████       █████                      ████ \r\n                ▒▒███       ▒▒███                      ▒▒███ \r\n █████ ███ █████ ▒███████   ███████    ██████   ██████  ▒███ \r\n▒▒███ ▒███▒▒███  ▒███▒▒███ ▒▒▒███▒    ███▒▒███ ███▒▒███ ▒███ \r\n ▒███ ▒███ ▒███  ▒███ ▒███   ▒███    ▒███ ▒███▒███ ▒███ ▒███ \r\n ▒▒███████████   ▒███ ▒███   ▒███ ███▒███ ▒███▒███ ▒███ ▒███ \r\n  ▒▒████▒████    ████ █████  ▒▒█████ ▒▒██████ ▒▒██████  █████\r\n   ▒▒▒▒ ▒▒▒▒    ▒▒▒▒ ▒▒▒▒▒    ▒▒▒▒▒   ▒▒▒▒▒▒   ▒▒▒▒▒▒  ▒▒▒▒▒ \r\n                                           \r\n                                            whtool - hovamack            \r\n                                                             \r\n                                                                                                                        \r\n");
			Console.ResetColor();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002108 File Offset: 0x00000308
		private static void Menu()
		{
			Console.WriteLine("\n1. Send webhook message");
			Console.WriteLine("2. Exit");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002124 File Offset: 0x00000324
		[DebuggerStepThrough]
		private static void webhookMessage()
		{
			Program.<webhookMessage>d__3 <webhookMessage>d__ = new Program.<webhookMessage>d__3();
			<webhookMessage>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<webhookMessage>d__.<>1__state = -1;
			<webhookMessage>d__.<>t__builder.Start<Program.<webhookMessage>d__3>(ref <webhookMessage>d__);
		}
	}
}
