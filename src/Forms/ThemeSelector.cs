using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Quad64.src.Forms
{
    public partial class ThemeSelector : Form
    {
        public bool doUpdate = false;
        public string themePath = "";

        public ThemeSelector()
        {
            InitializeComponent();
            updateTheme();
            load_button.Enabled = false;
        }

        private void updateTheme()
        {
            BackColor = Theme.DEFAULT_PANEL_BACKGROUND;
            themes.BackColor = Theme.DEFAULT_BACKGROUND;
            themes.ForeColor = Theme.DEFAULT_TEXT;
            load_button.BackColor = Theme.DEFAULT_BUTTON_BACKGROUND;
            load_button.ForeColor = Theme.DEFAULT_BUTTON_TEXT;
            cancel_button.BackColor = Theme.DEFAULT_BUTTON_BACKGROUND;
            cancel_button.ForeColor = Theme.DEFAULT_BUTTON_TEXT;
        }

        private void ThemeSelector_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = "";
            item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = "Quad64 Light";
            item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[1].Text = "YoshiHack56";
            themes.Items.Add(item);

            string[] files = Directory.GetFiles("./data/themes/");
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(".json"))
                {
                    string json = File.ReadAllText(files[i]);
                    JObject o = JObject.Parse(json);
                    if (o["Info"] != null)
                    {
                        string name = "", author = "";
                        if (o["Info"]["Name"] != null)
                            name = o["Info"]["Name"].ToString();
                        if (o["Info"]["Author"] != null)
                            author = o["Info"]["Author"].ToString();

                        item = new ListViewItem();
                        item.Tag = files[i];
                        item.SubItems.Add(new ListViewItem.ListViewSubItem());
                        item.SubItems[0].Text = name;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem());
                        item.SubItems[1].Text = author;

                        themes.Items.Add(item);
                    }
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            doUpdate = false;
            Hide();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            doUpdate = true;
            themePath = (string)themes.SelectedItems[0].Tag;
            Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (themes.SelectedIndices.Count > 0)
                load_button.Enabled = true;
            else
                load_button.Enabled = false;
        }
    }
}
