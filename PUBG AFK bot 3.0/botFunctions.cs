using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

// Use this to get color:
//    ColorSystem.CheckColor(X, Y, Color.FromArgb(A, R, G, B))





namespace PUBG_AFK_bot
{
    class BotFunctions
    {




        /*
                                        Functions:
            <------------------------------------------------------------>
            
            |    Click (Two overloads):
            |     -----------------------------
            |                     Click(int x, int y) for (Move to pos (x,y) , wait, click) (ClickWaitTime from settings)
            |                     Click() for just clicking
            |
            |                     Left Click & Release key code:
            |                           MOUSEEVENTF_LEFTDOWN = 0x02
            |                           MOUSEEVENTF_LEFTUP = 0x04




            
            |    Keyboard:
            |    -------------- 
            |                     KeyBoard(byte key) for Keyboard single click
            |                       
            |                     Hold & Release key
            |                          HoldKeyBoard(byte key)
            |                          ReleaseKeyBoard(byte Key)
        
            


            |    Color:
            |    --------
            |                     CompareColor (int x, int y, Color.FromArgb(A, R, G, B)) For checking if color on (x,y) and Color from parameter is same and return true/false
            |                       
            |                     GetColor (Two overloads)
            |                          GetColor() Print to console current Cursor (x,y) and color
            |                          PrintColor(int x, int y) Print to console current color on (x,y) from parameter




            |     Misc:
            |     -----
            |
            |           WaitForLobby() - waits for lobby to load (by start color)
            |           IsProcessOpen() - Return boolean is pubg process open
           */











        // ----------------------- Keyboard And Mouse Functions ---------------------- \\

        // Dll for keyboard click
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);


        // Dlls and setups for mouse clicks and movement
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);



        // Overload for Simulates a left mouse click on x,y - (Move to pos (x,y), wait, click) (ClickWaitTime from settings)
        public static void Click(int xposclick, int yposclick)
        {
            SetCursorPos(xposclick, yposclick);
            //Thread.Sleep(100);

            mouse_event(0x02, 0, 0, 0, 0);
            mouse_event(0x04, 0, 0, 0, 0);
        }



        // Overload for Simulates a left mouse click only
        public static void Click()
        {
            mouse_event(0x02, 0, 0, 0, 0);
            mouse_event(0x04, 0, 0, 0, 0);
            //Thread.Sleep(Settings.Default.ClickWaitTimeFiled);
        }


        // KeyBoard click from parameter
        public static void KeyBoard(byte key)
        {
            keybd_event(key, 0, 0x0001, 0);
            keybd_event(key, 0, 0x0002, 0);
        }




        // Hold KeyBoard click from parameter
        public static void HoldKeyBoard(byte key)
        {
            keybd_event(key, 0, 0x0001, 0);
        }



        // Release KeyBoard click from parameter
        public static void ReleaseKeyBoard(byte key)
        {
            keybd_event(key, 0, 0x0002, 0);
        }















        // ------------------------ Color Functions ------------------------ \\




        // Color Get DLL Imports
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);



        // Get Pixel Color By x,y
        public static Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
            (int)(pixel & 0x0000FF00) >> 8,
            (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }

        //TODO    Make it more easy to use by making it to WaitForColor
        // Checks for match (Pixel color from x,y) and parameter and returns true/false
        public static bool CompareColor(int xCheck, int yCheck, Color colorCheck)
        {
            Thread.Sleep(200);
            while (GetPixelColor(xCheck, yCheck).A == colorCheck.A && GetPixelColor(xCheck, yCheck).R == colorCheck.R && GetPixelColor(xCheck, yCheck).G == colorCheck.G && GetPixelColor(xCheck, yCheck).B == colorCheck.B)
                return true;

            return false;
        }


        // Comment Out on release
        public static string GetColor(int xPrint, int yPrint)
        {
            return GetPixelColor(xPrint, yPrint).ToString();
        }

        //TODO    Method to return string like above
        public static void PrintColor()
        {
            Thread.Sleep(2000);
            System.Diagnostics.Debug.WriteLine(GetPixelColor(Cursor.Position.X, Cursor.Position.Y));
            System.Diagnostics.Debug.WriteLine("X: {0} Y: {1}", Cursor.Position.X, Cursor.Position.Y);

        }













        // --------------------------------- Misc --------------------------------- \\



        // Waits for lobby by start button color And Settings
        public static void WaitForLobby()
        {
            while (!CompareColor(222, 981, Color.FromArgb(255, 0, 0, 0)) && (!CompareColor(108, 841, Color.FromArgb(255, 211, 211, 211)))) ;
        }


        /*
        // Check from all Processes if PUBG Process is open by name and returns true/false and starts PUBG
        public static void CheckProcess()
        {
            do
            {
                Thread.Sleep(10000);
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.Contains("PLAYERUNKNOWN'S BATTLEGROUNDS "))
                    {
                        return;
                    }
                }

                Process.Start("steam://rungameid/578080");
            } while (true);

        }
        */
    }
}