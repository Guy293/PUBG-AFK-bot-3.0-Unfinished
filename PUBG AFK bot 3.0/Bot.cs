using System.Drawing;
using System.Threading;
using static PUBG_AFK_bot.BotFunctions;

// Start PUBG
// Process.Start("steam://rungameid/578080");

namespace PUBG_AFK_bot
{
    static class Bot
    {
        public static Thread StartBotThread = new Thread(new ThreadStart(Bot.StartBot));

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
            while (!CompareColor(633, 44, Color.FromArgb(255, 255, 199, 0)))
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
            while (!CompareColor(965, 315, Color.FromArgb(255, 255, 255, 255)))


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
            Click(226, 835);  // Team Tab
            Click(1043, 863); // 1-Man-Squad
            Click(166, 894);  // Perspective
            Click(688, 862); // FPP
            Click(167, 1007);  // Start

            // Waits for loading color
            while (!CompareColor(964, 500, Color.FromArgb(255, 252, 252, 252))) ;

            // Waits for end loading color
            while (CompareColor(964, 500, Color.FromArgb(255, 252, 252, 252))) ;
        }



        // Leave the match
        private static void LeaveMatch()
        {
            // Spam leave match until confirm open
            while (!CompareColor(936, 496, Color.FromArgb(255, 255, 255)))
            {
                Click(1718, 951);  // Leave match
            }
            Click(844, 573);  // Confirm
        }


        // Tasks In Game
        private static void InGame()
        {
            // Clicks '=' for auto run
            KeyBoard(0xBB);

            // Waits for die and clicks 'F'
            while (!CompareColor(1692, 956, Color.FromArgb(255, 255, 255, 255))) KeyBoard(0x46);
        }



        // For Testing
        public static void Test()
        {
        }
    }
}