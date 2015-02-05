namespace RedmineTimeManager
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemOther = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTickets = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOther});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemOther
            // 
            this.ToolStripMenuItemOther.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripMenuItemOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettings});
            this.ToolStripMenuItemOther.Name = "ToolStripMenuItemOther";
            this.ToolStripMenuItemOther.Size = new System.Drawing.Size(52, 20);
            this.ToolStripMenuItemOther.Text = "Other";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemSettings.Text = "Settings";
            this.ToolStripMenuItemSettings.Click += new System.EventHandler(this.ToolStripMenuItemSettings_Click);
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(14, 75);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(260, 20);
            this.comboBoxProjects.TabIndex = 1;
            this.comboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projects (Displayed only assained projetcts.)";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(197, 27);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tickets";
            // 
            // comboBoxTickets
            // 
            this.comboBoxTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTickets.FormattingEnabled = true;
            this.comboBoxTickets.Location = new System.Drawing.Point(14, 122);
            this.comboBoxTickets.Name = "comboBoxTickets";
            this.comboBoxTickets.Size = new System.Drawing.Size(260, 20);
            this.comboBoxTickets.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxTickets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Redmine Time Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOther;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTickets;

    }
}

