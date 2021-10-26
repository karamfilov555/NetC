using System;
using NetC.CLI.ScreenView.Contracts;

namespace NetC.CLI.ScreenView
{
    public class NetCScreen : INetCScreen
    {
        public void DisplayLayout()
        {
            Console.SetWindowSize(200, 43);
            Console.ForegroundColor = ConsoleColor.Green;
            
            const string logo = @"$$\      $$\           $$\                                                     $$\                     $$\   $$\            $$\      $$$$$$\  
$$ | $\  $$ |          $$ |                                                    $$ |                    $$$\  $$ |           $$ |    $$  __$$\ 
$$ |$$$\ $$ | $$$$$$\  $$ | $$$$$$$\  $$$$$$\  $$$$$$\$$$$\   $$$$$$\        $$$$$$\    $$$$$$\        $$$$\ $$ | $$$$$$\ $$$$$$\   $$ /  \__|
$$ $$ $$\$$ |$$  __$$\ $$ |$$  _____|$$  __$$\ $$  _$$  _$$\ $$  __$$\       \_$$  _|  $$  __$$\       $$ $$\$$ |$$  __$$\\_$$  _|  $$ |      
$$$$  _$$$$ |$$$$$$$$ |$$ |$$ /      $$ /  $$ |$$ / $$ / $$ |$$$$$$$$ |        $$ |    $$ /  $$ |      $$ \$$$$ |$$$$$$$$ | $$ |    $$ |      
$$$  / \$$$ |$$   ____|$$ |$$ |      $$ |  $$ |$$ | $$ | $$ |$$   ____|        $$ |$$\ $$ |  $$ |      $$ |\$$$ |$$   ____| $$ |$$\ $$ |  $$\ 
$$  /   \$$ |\$$$$$$$\ $$ |\$$$$$$$\ \$$$$$$  |$$ | $$ | $$ |\$$$$$$$\         \$$$$  |\$$$$$$  |      $$ | \$$ |\$$$$$$$\  \$$$$  |\$$$$$$  |
\__/     \__| \_______|\__| \_______| \______/ \__| \__| \__| \_______|         \____/  \______/       \__|  \__| \_______|  \____/  \______/";



           Console.WriteLine(logo);
           Console.WriteLine("(c) 2021 NetC calculator. Created by Yanislav Yordanov. All Rights reserved.");
           Console.WriteLine();
            
        }
    }
}

