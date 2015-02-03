namespace RedmineTimeManager
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Redmine URL";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(14, 24);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(273, 19);
            this.textBoxURL.TabIndex = 1;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(131, 108);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 2;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(212, 108);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "API Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(13, 71);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(273, 19);
            this.textBoxKey.TabIndex = 5;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 143);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormAPIKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}