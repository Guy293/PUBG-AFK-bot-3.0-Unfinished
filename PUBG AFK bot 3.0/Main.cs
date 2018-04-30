



/*
TODO    Move ToDo list to separate file and show in Github.
TODO    Map choose
TODO    Stop bot if F4 press
TODO    Fix crate after getting
TODO    Change server only first time
TODO    Hide tray
TODO    Remove time between jumps etc...
TODO    Delivery delay when buying crate
*/




using System;
using System.Windows.Forms;

namespace PUBG_AFK_bot
{
    public partial class Main : Form
    {
        private settingsForm settingsFormOpen = new settingsForm();

        public Main()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
        }



        private void Start_Click(object sender, EventArgs e)
        {

            Bot.StartBotThread.Start();

            // Bot.Test();

            // Bot.StartBot();

            // Hide();
            // SystemTrayIcon.Visible = true;
        }


        // Start the settingsForm
        private void Settings_click(object sender, EventArgs e)
        {
            settingsFormOpen.Show();

        }



        private void BotToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        // Start the settingsForm
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsFormOpen.Show();
        }

        // Working on some features with system tray. Will finish it later.
        private void SystemTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            SystemTrayIcon.Visible = false;
        }


    }
}