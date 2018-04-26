using System;
using System.Windows.Forms;

namespace PUBG_AFK_bot
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }


        private void settingsForm_Load(object sender, EventArgs e)
        {
            // Loads from saved settings
            this.buycrate.Checked = Properties.Settings.Default.ToBuyCrateSettingFiled;
            this.crateChoise.Text = Properties.Settings.Default.CrateToBuyFiled;
            this.fpp.Checked = Properties.Settings.Default.ToFppFiled;
            this.serverSettings.Text = Properties.Settings.Default.ServerFiled;
            this.clickwaitimetext.Text = Properties.Settings.Default.ClickWaitTimeFiled.ToString();
        }



        private void save_Click(object sender, EventArgs e)
        {
            // Sets the Defult settings
            Properties.Settings.Default.CrateToBuyFiled = crateChoise.Text;
            Properties.Settings.Default.ToBuyCrateSettingFiled = buycrate.Checked;
            Properties.Settings.Default.ToFppFiled = fpp.Checked;
            Properties.Settings.Default.ServerFiled = serverSettings.Text;
            Properties.Settings.Default.ClickWaitTimeFiled = Convert.ToInt32(clickwaitimetext.Text);



            // Save settings
            Properties.Settings.Default.Save();


            // Close the form
            this.Close();
        }



        private void cancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }


    }
}
