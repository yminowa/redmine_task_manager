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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// save API key to Settings and then close window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.URL = textBoxURL.Text;
            Properties.Settings.Default.Key = textBoxKey.Text;

            Properties.Settings.Default.Save();

            this.Close();
        }

        /// <summary>
        /// load Settings values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAPIKey_Load(object sender, EventArgs e)
        {
            textBoxURL.Text = Properties.Settings.Default.URL;
            textBoxKey.Text = Properties.Settings.Default.Key;
        }

        /// <summary>
        /// validate url and API Key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonValidate_Click(object sender, EventArgs e)
        {
            String url = textBoxURL.Text;
            String key = textBoxKey.Text;
            
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Redmine-API-Key", key);

            HttpResponseMessage response = await client.GetAsync(url + "projects.xml");

            HttpStatusCode status = response.StatusCode;
            MessageBox.Show(status.ToString(), "Result");
        }
    }
}
