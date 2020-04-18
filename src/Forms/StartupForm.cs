using System;
using System.Drawing;
using System.Windows.Forms;
using Quad64.src.JSON;
using Quad64.src;
using System.IO;
using System.Xml;

namespace Quad64
{
    partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            SettingsFile.LoadGlobalSettings("default");
            UpdateTheme();
            
            if (Globals.lastUsedROMs.Count > 0)
            {
                noROMsOpenedLabel.Visible = false;
                int x = noROMsOpenedLabel.Location.X;
                int y = noROMsOpenedLabel.Location.Y;

                foreach (string romPath in Globals.lastUsedROMs)
                {
                    string romFileName = Path.GetFileNameWithoutExtension(romPath);
                    
                    if (romFileName.EndsWith(".ext"))
                    {
                        romFileName = romFileName.Substring(0, romFileName.Length - 4);
                    }

                    LinkLabel romLink = new LinkLabel();
                    romLink.Font = new Font("Microsoft Sans Serif", 10);
                    romLink.AutoSize = true;
                    romLink.Text = romFileName;

                    if (Path.GetFileNameWithoutExtension(Theme.lastThemePath) == "dark") 
                        romLink.LinkColor = Color.White;
                    else
                        romLink.LinkColor = Color.Black;

                    romLink.BackColor = Color.Transparent;
                    romLink.Location = new Point(x, y);
                    y = y + 15;

                    romLink.Click += (s, e) =>
                    {
                        OpenROM(romPath);
                    };

                    Controls.Add(romLink);
                }
            }
        }

        private void UpdateTheme()
        {
            if (Theme.START_DARK)
            {
                BackgroundImage = Properties.Resources.StartupBG_Black;
            }

            noROMsOpenedLabel.ForeColor = Theme.START_TEXT;
            versionLabel.ForeColor = Theme.START_TEXT;

            quad64Label.ForeColor = Theme.START_TITLE_TEXT;
            recentROMsLabel.ForeColor = Theme.START_TITLE_TEXT;
            closeLink.LinkColor = Theme.START_TITLE_TEXT;

            openROMButton.BackColor = Theme.START_CONTROLS_BUTTON_BACKGROUND;
            openROMButton.ForeColor = Theme.START_CONTROLS_BUTTON_TEXT;
        }

        private void CloseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void OpenROMButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Z64 ROM|*.z64|V64 ROM|*.v64|N64 ROM|*.n64|All Files|*";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                OpenROM(openFileDialog1.FileName);
            }
        }

        private void OpenROM(string path)
        {
            Hide();
            ROM.Instance.readFile(path);
            Globals.pathToAutoLoadROM = path;
            Globals.autoLoadROMOnStartup = true;

            if (!Globals.lastUsedROMs.Contains(path))
            {
                if (Globals.lastUsedROMs.Count > 5)
                {
                    Globals.lastUsedROMs.Pop();
                }
                Globals.lastUsedROMs.Push(path);
                SettingsFile.SaveGlobalSettings("default");
            }

            MainForm m = new MainForm();
            m.Show();
        }
    }
}
