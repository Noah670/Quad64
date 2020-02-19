using System;
using System.Drawing;
using System.Windows.Forms;
using Quad64.src.JSON;
using Quad64.src;
using System.IO;

namespace Quad64
{
    partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            SettingsFile.LoadGlobalSettings("default");
            updateTheme();
        }

        private void updateTheme()
        {
            if (Path.GetFileNameWithoutExtension(Theme.lastThemePath) == "dark")
            {
                BackgroundImage = Properties.Resources.StartupBG_Black;
                noROMsOpenedLabel.ForeColor = Color.White;
                openROMButton.BackColor = Color.Black;
                openROMButton.ForeColor = Color.White;
            }
        }

        private void closeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void openROMButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Z64 ROM|*.z64|V64 ROM|*.v64|N64 ROM|*.n64|All Files|*";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Hide();
                ROM.Instance.readFile(openFileDialog1.FileName);
                Globals.pathToAutoLoadROM = openFileDialog1.FileName;
                Globals.autoLoadROMOnStartup = true;

                MainForm m = new MainForm();
                m.Show();
            }
        }
    }
}
