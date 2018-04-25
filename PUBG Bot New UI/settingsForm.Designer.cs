namespace PUBG_Bot_New_UI
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buycrate = new System.Windows.Forms.CheckBox();
            this.serverSettings = new System.Windows.Forms.ComboBox();
            this.fpp = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.crateChoise = new System.Windows.Forms.ComboBox();
            this.TimeDelayText = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.clickwaitimetext = new System.Windows.Forms.TextBox();
            this.ErorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buycrate
            // 
            this.buycrate.AutoSize = true;
            this.buycrate.Location = new System.Drawing.Point(204, 32);
            this.buycrate.Name = "buycrate";
            this.buycrate.Size = new System.Drawing.Size(72, 17);
            this.buycrate.TabIndex = 0;
            this.buycrate.Text = "Buy Crate";
            this.buycrate.UseVisualStyleBackColor = true;
            // 
            // serverSettings
            // 
            this.serverSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverSettings.FormattingEnabled = true;
            this.serverSettings.Items.AddRange(new object[] {
            "North America",
            "Europe",
            "Korea",
            "Asia",
            "Oceania",
            "South and central america",
            "South east asia"});
            this.serverSettings.Location = new System.Drawing.Point(12, 30);
            this.serverSettings.Name = "serverSettings";
            this.serverSettings.Size = new System.Drawing.Size(118, 21);
            this.serverSettings.TabIndex = 1;
            // 
            // fpp
            // 
            this.fpp.AutoSize = true;
            this.fpp.Checked = true;
            this.fpp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fpp.Location = new System.Drawing.Point(12, 77);
            this.fpp.Name = "fpp";
            this.fpp.Size = new System.Drawing.Size(185, 17);
            this.fpp.TabIndex = 2;
            this.fpp.Text = "Fpp (Recommended more money)";
            this.fpp.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(252, 278);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(35, 278);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // crateChoise
            // 
            this.crateChoise.BackColor = System.Drawing.Color.White;
            this.crateChoise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crateChoise.FormattingEnabled = true;
            this.crateChoise.Items.AddRange(new object[] {
            "Fever Crate #2",
            "Random Crate #1"});
            this.crateChoise.Location = new System.Drawing.Point(203, 55);
            this.crateChoise.Name = "crateChoise";
            this.crateChoise.Size = new System.Drawing.Size(103, 21);
            this.crateChoise.TabIndex = 5;
            // 
            // TimeDelayText
            // 
            this.TimeDelayText.AutoSize = true;
            this.TimeDelayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDelayText.Location = new System.Drawing.Point(3, 148);
            this.TimeDelayText.Name = "TimeDelayText";
            this.TimeDelayText.Size = new System.Drawing.Size(167, 91);
            this.TimeDelayText.TabIndex = 7;
            this.TimeDelayText.Text = "Time Delay between\r\nclicks In milliseconds\r\n(1 sec = 1000 milliseconds)\r\nTry to p" +
    "lay with this if PUBG\r\n is missing clicks.\r\nAnd try to lower the number \r\nas lon" +
    "g as PUBG don\'t miss clicks\r\n";
            this.TimeDelayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clickwaitimetext
            // 
            this.clickwaitimetext.AutoCompleteCustomSource.AddRange(new string[] {
            "300",
            "500",
            "700",
            "1000"});
            this.clickwaitimetext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clickwaitimetext.Location = new System.Drawing.Point(12, 125);
            this.clickwaitimetext.MaxLength = 4;
            this.clickwaitimetext.Name = "clickwaitimetext";
            this.clickwaitimetext.Size = new System.Drawing.Size(75, 20);
            this.clickwaitimetext.TabIndex = 8;
            this.clickwaitimetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErorProvider
            // 
            this.ErorProvider.ContainerControl = this;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(385, 333);
            this.Controls.Add(this.clickwaitimetext);
            this.Controls.Add(this.TimeDelayText);
            this.Controls.Add(this.crateChoise);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.fpp);
            this.Controls.Add(this.serverSettings);
            this.Controls.Add(this.buycrate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.settingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox serverSettings;
        private System.Windows.Forms.CheckBox fpp;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox crateChoise;
        private System.Windows.Forms.CheckBox buycrate;
        private System.Windows.Forms.Label TimeDelayText;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox clickwaitimetext;
        private System.Windows.Forms.ErrorProvider ErorProvider;
    }
}