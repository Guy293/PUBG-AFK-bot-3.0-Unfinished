using System.Diagnostics;
using System.Drawing;
using static PUBG_AFK_bot.BotFunctions;

// Start PUBG
// Process.Start("steam://rungameid/578080");

namespace PUBG_AFK_bot
{
    static class Bot
    {

        //  public static Thread _t = new Thread(new ThreadStart(StartBot));

        // Waits for lobby by start button color
        private static void WaitForLobby()
        {
            while (!CheckColor(172, 995, Color.FromArgb(255, 255, 255, 255))) ;
        }


        // Check from all Processes if PUBG Process is open by name and returns true/false
        public static bool IsProcessOpen()
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains("PLAYERUNKNOWN'S BATTLEGROUNDS ")) return true;
            }
            //  Process.Start("steam://rungameid/578080");
            return false;
        }



        // Starts the bot
        public static void StartBot()
        {
            // while (IsProcessOpen())
            while (true)
            {
                WaitForLobby(); // Waits for lobby by settings button color and if true do lobby tasks

                // Checks the ToBuyCrateSettingFiled settings and buy if true
                if (Properties.Settings.Default.ToBuyCrateSettingFiled)
                {
                    BuyCrate();
                }

                // ChangeServer();  // Change region by settings

                JoinGame();  // Join game by settings

                InGame();  // In game tasks

                LeaveMatch();  // Leaves the match
            }
        }


        // Buy crate if settings
        private static void BuyCrate()
        {


            // Clicks untill rewards tab open
            while (!CheckColor(633, 44, Color.FromArgb(255, 255, 199, 0)))
            {
                Click(634, 52);
            }

            // Buy crate by settings
            Click(Properties.Settings.Default.CrateToBuyFiled == "Fever Crate #2" ? 1301 : 619, 452);

            // Get Crate button
            Click(958, 718);


            // System.Threading.Thread.Sleep(500);
            // if ()


            // If yes wait (end)
            while (!CheckColor(965, 315, Color.FromArgb(255, 255, 255, 255)))


                // Get back to Play menu
                Click(226, 51);

            // Waits for lobby by start button color
            WaitForLobby();
        }


        // Changes Server
        public static void ChangeServer()
        {
            // Server selection
            Click(1772, 1025);

            // Select server by settings
            switch (Properties.Settings.Default.ServerFiled)
            {
                case "North America":
                    Click(957, 413);
                    break;

                case "Europe":
                    Click(957, 508);
                    break;

                case "Korea":
                    Click(957, 462);
                    break;

                case "Asia":
                    Click(954, 554);
                    break;

                case "Oceania":
                    Click(951, 599);
                    break;

                case "South and central america":
                    Click(961, 644);
                    break;

                case "South east asia":
                    Click(960, 690);
                    break;
            }
            Click(960, 749);  // Close region

            // Waits for lobby by start button color
            WaitForLobby();

        }


        // Join game by settings choise
        static void JoinGame()
        {
            Click(166, 784);  // Team 1-Man Squad

            Click(166, 894);  // Perspective FPP

            Click(167, 1007);  // Start

            // Waits for loading color
            while (!CheckColor(964, 500, Color.FromArgb(255, 252, 252, 252))) ;

            // Waits for end loading color
            while (CheckColor(964, 500, Color.FromArgb(255, 252, 252, 252))) ;
        }



        // Leave the match
        private static void LeaveMatch()
        {
            Click(1718, 951);  // Leave match
            Click(844, 573);  // Confirm
        }


        // Tasks In Game
        private static void InGame()
        {
            // Clicks '=' for auto run
            KeyBoard(0xBB);

            // Waits for die and clicks 'F'
            while (!CheckColor(1692, 956, Color.FromArgb(255, 255, 255, 255))) KeyBoard(0x46);
        }



        // For Testing
        public static void Test()
        {
        }
    }
}