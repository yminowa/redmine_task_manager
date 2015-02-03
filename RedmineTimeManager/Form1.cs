using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedmineTimeManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// show settings menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            Form form = new FormSettings();
            form.Show();
        }

        /// <summary>
        /// load projects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonLoad_Click(object sender, EventArgs e)
        {
            String url = Properties.Settings.Default.URL;
            String key = Properties.Settings.Default.Key;

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Redmine-API-Key", key);

            HttpResponseMessage response = await client.GetAsync(url + "projects.json");

            HttpStatusCode status = response.StatusCode;

            if (status == HttpStatusCode.OK)
            {
                // parse json
                String result = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(result);

                JToken projects = json["projects"];

                // setup select
                foreach(var project in projects)
                {
                    comboBoxProjects.Items.Add(project["name"]);
                }
            }
            else
            {
                // if status is not success, show error dialog
                MessageBox.Show("load error: please check settings.");
            }
        }
    }
}
