
namespace SexManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonAboutSlave = new System.Windows.Forms.Button();
            this.buttonKO = new System.Windows.Forms.Button();
            this.buttonHeadshot = new System.Windows.Forms.Button();
            this.sexView = new System.Windows.Forms.ListView();
            this.SlavesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SlavesNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sexMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.headshootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSlaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upD0T3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(401, 420);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Û̸͂̅̍́͑̒͂̿̓̎̏̀̕̚p҈҇̏̂̏̑̃͂̐́̓̐͐̅̚̚D̸͗̇̂̓̅̆̎̓̇̐͠0̶̛͑̂͊͂̀̿͗̀́̊̓̅T̷̀̐͐̆̿̄͗̀̾̔͑́̾͒̇̚͝" +
    "3҉͋̎̈́͂͑̍̏̅̏̊̀̔̀̾͋̚͝";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Location = new System.Drawing.Point(12, 420);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(124, 23);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "Sex Manager";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonAboutSlave
            // 
            this.buttonAboutSlave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAboutSlave.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonAboutSlave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutSlave.Location = new System.Drawing.Point(482, 420);
            this.buttonAboutSlave.Name = "buttonAboutSlave";
            this.buttonAboutSlave.Size = new System.Drawing.Size(75, 23);
            this.buttonAboutSlave.TabIndex = 9;
            this.buttonAboutSlave.Text = "About Slave";
            this.buttonAboutSlave.UseVisualStyleBackColor = true;
            this.buttonAboutSlave.Click += new System.EventHandler(this.buttonAboutSlave_Click);
            // 
            // buttonKO
            // 
            this.buttonKO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKO.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonKO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKO.Location = new System.Drawing.Point(563, 420);
            this.buttonKO.Name = "buttonKO";
            this.buttonKO.Size = new System.Drawing.Size(75, 23);
            this.buttonKO.TabIndex = 8;
            this.buttonKO.Text = "K.O.";
            this.buttonKO.UseVisualStyleBackColor = true;
            this.buttonKO.Click += new System.EventHandler(this.buttonKO_Click);
            // 
            // buttonHeadshot
            // 
            this.buttonHeadshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHeadshot.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonHeadshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHeadshot.Location = new System.Drawing.Point(644, 420);
            this.buttonHeadshot.Name = "buttonHeadshot";
            this.buttonHeadshot.Size = new System.Drawing.Size(75, 23);
            this.buttonHeadshot.TabIndex = 7;
            this.buttonHeadshot.Text = "Headshot";
            this.buttonHeadshot.UseVisualStyleBackColor = true;
            this.buttonHeadshot.Click += new System.EventHandler(this.buttonHeadshot_Click);
            // 
            // sexView
            // 
            this.sexView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sexView.BackColor = System.Drawing.Color.DimGray;
            this.sexView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SlavesName,
            this.SlavesNumber});
            this.sexView.ContextMenuStrip = this.sexMenuStrip;
            this.sexView.ForeColor = System.Drawing.Color.White;
            this.sexView.FullRowSelect = true;
            this.sexView.HideSelection = false;
            this.sexView.Location = new System.Drawing.Point(15, 12);
            this.sexView.Name = "sexView";
            this.sexView.Size = new System.Drawing.Size(704, 402);
            this.sexView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.sexView.TabIndex = 12;
            this.sexView.UseCompatibleStateImageBehavior = false;
            this.sexView.View = System.Windows.Forms.View.Details;
            this.sexView.SelectedIndexChanged += new System.EventHandler(this.sexView_SelectedIndexChanged);
            // 
            // SlavesName
            // 
            this.SlavesName.Text = "Slaves Name";
            this.SlavesName.Width = 150;
            // 
            // SlavesNumber
            // 
            this.SlavesNumber.Text = "Slaves Name ID";
            this.SlavesNumber.Width = 92;
            // 
            // sexMenuStrip
            // 
            this.sexMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headshootToolStripMenuItem,
            this.kOToolStripMenuItem,
            this.aboutSlaveToolStripMenuItem,
            this.upD0T3ToolStripMenuItem});
            this.sexMenuStrip.Name = "sexMenuStrip";
            this.sexMenuStrip.Size = new System.Drawing.Size(138, 92);
            // 
            // headshootToolStripMenuItem
            // 
            this.headshootToolStripMenuItem.Name = "headshootToolStripMenuItem";
            this.headshootToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.headshootToolStripMenuItem.Text = "Headshoot";
            this.headshootToolStripMenuItem.Click += new System.EventHandler(this.buttonHeadshot_Click);
            // 
            // kOToolStripMenuItem
            // 
            this.kOToolStripMenuItem.Name = "kOToolStripMenuItem";
            this.kOToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kOToolStripMenuItem.Text = "K.O.";
            this.kOToolStripMenuItem.Click += new System.EventHandler(this.buttonKO_Click);
            // 
            // aboutSlaveToolStripMenuItem
            // 
            this.aboutSlaveToolStripMenuItem.Name = "aboutSlaveToolStripMenuItem";
            this.aboutSlaveToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aboutSlaveToolStripMenuItem.Text = "About Slave";
            this.aboutSlaveToolStripMenuItem.Click += new System.EventHandler(this.buttonAboutSlave_Click);
            // 
            // upD0T3ToolStripMenuItem
            // 
            this.upD0T3ToolStripMenuItem.Name = "upD0T3ToolStripMenuItem";
            this.upD0T3ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.upD0T3ToolStripMenuItem.Text = "Û̸͂̅̍́͑̒͂̿̓̎̏̀̕̚p҈҇̏̂̏̑̃͂̐́̓̐͐̅̚̚D̸͗̇̂̓̅̆̎̓̇̐͠0̶̛͑̂͊͂̀̿͗̀́̊̓̅T̷̀̐͐̆̿̄͗̀̾̔͑́̾͒̇̚͝" +
    "3҉͋̎̈́͂͑̍̏̅̏̊̀̔̀̾͋̚͝";
            this.upD0T3ToolStripMenuItem.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(731, 455);
            this.Controls.Add(this.sexView);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonAboutSlave);
            this.Controls.Add(this.buttonKO);
            this.Controls.Add(this.buttonHeadshot);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(489, 345);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sex Manager";
            this.sexMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonAboutSlave;
        private System.Windows.Forms.Button buttonKO;
        private System.Windows.Forms.Button buttonHeadshot;
        private System.Windows.Forms.ListView sexView;
        private System.Windows.Forms.ColumnHeader SlavesName;
        private System.Windows.Forms.ColumnHeader SlavesNumber;
        private System.Windows.Forms.ContextMenuStrip sexMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem headshootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSlaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upD0T3ToolStripMenuItem;
    }
}

