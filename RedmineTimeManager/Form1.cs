using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RedmineTimeManager.models;
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
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            comboBoxProjects.Items.Clear();

            Request request = new Request();
            HttpResponseMessage response = request.call("projects.json");

            HttpStatusCode status = response.StatusCode;

            if (status == HttpStatusCode.OK)
            {
                // parse json
                String result = response.Content.ReadAsStringAsync().Result;
                String json = JObject.Parse(result)["projects"].ToString();
                List<Project> projects = JsonConvert.DeserializeObject<List<Project>>(json);

                // setup combo
                foreach(Project project in projects)
                {
                    comboBoxProjects.Items.Add(project);
                    comboBoxProjects.DisplayMember = "Name";
                    comboBoxProjects.ValueMember = "ID";
                }
            }
            else
            {
                // if status is not success, show error dialog
                MessageBox.Show("load error: please check settings.");
            }
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTickets.Items.Clear();

            String projectID = ((Project)comboBoxProjects.SelectedItem).ID;

            Request request = new Request();
            HttpResponseMessage response = request.call("issues.json", "?project_id=" + projectID);

            HttpStatusCode status = response.StatusCode;

            if (status == HttpStatusCode.OK)
            {
                // parse json
                String result = response.Content.ReadAsStringAsync().Result;
                String json = JObject.Parse(result)["issues"].ToString();
                List<Issue> issues = JsonConvert.DeserializeObject<List<Issue>>(json);

                // setup combo
                foreach (Issue issue in issues)
                {
                    comboBoxTickets.Items.Add(issue);
                    comboBoxTickets.DisplayMember = "Subject";
                    comboBoxTickets.ValueMember = "ID";
                }
            }
        }
    }
}
