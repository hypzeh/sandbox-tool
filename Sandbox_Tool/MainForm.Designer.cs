namespace Sandbox_Tool
{
    partial class MainForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnToggleAdvanced = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupPermissions = new System.Windows.Forms.GroupBox();
            this.tablePermissions = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupApplication = new System.Windows.Forms.GroupBox();
            this.tableApplication = new System.Windows.Forms.TableLayoutPanel();
            this.txtApplicationPath = new System.Windows.Forms.TextBox();
            this.btnApplicationBrowse = new System.Windows.Forms.Button();
            this.lblApplicationOpen = new System.Windows.Forms.Label();
            this.lblApplicationParam = new System.Windows.Forms.Label();
            this.txtApplicationParam = new System.Windows.Forms.TextBox();
            this.openApplicationDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelMain.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.groupPermissions.SuspendLayout();
            this.tablePermissions.SuspendLayout();
            this.groupApplication.SuspendLayout();
            this.tableApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableButtons);
            this.panelMain.Controls.Add(this.groupPermissions);
            this.panelMain.Controls.Add(this.groupApplication);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(5);
            this.panelMain.Size = new System.Drawing.Size(714, 191);
            this.panelMain.TabIndex = 0;
            // 
            // tableButtons
            // 
            this.tableButtons.AutoSize = true;
            this.tableButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableButtons.ColumnCount = 5;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.Controls.Add(this.btnToggleAdvanced, 1, 0);
            this.tableButtons.Controls.Add(this.btnOK, 3, 0);
            this.tableButtons.Controls.Add(this.btnCancel, 4, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableButtons.Location = new System.Drawing.Point(5, 154);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.Size = new System.Drawing.Size(704, 32);
            this.tableButtons.TabIndex = 3;
            // 
            // btnToggleAdvanced
            // 
            this.btnToggleAdvanced.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToggleAdvanced.AutoSize = true;
            this.btnToggleAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleAdvanced.Location = new System.Drawing.Point(449, 3);
            this.btnToggleAdvanced.Name = "btnToggleAdvanced";
            this.btnToggleAdvanced.Size = new System.Drawing.Size(80, 26);
            this.btnToggleAdvanced.TabIndex = 0;
            this.btnToggleAdvanced.Text = "Advanced";
            this.btnToggleAdvanced.UseVisualStyleBackColor = true;
            this.btnToggleAdvanced.CheckedChanged += new System.EventHandler(this.btnToggleAdvanced_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(545, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(626, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupPermissions
            // 
            this.groupPermissions.AutoSize = true;
            this.groupPermissions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupPermissions.Controls.Add(this.tablePermissions);
            this.groupPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPermissions.Location = new System.Drawing.Point(5, 84);
            this.groupPermissions.Name = "groupPermissions";
            this.groupPermissions.Size = new System.Drawing.Size(704, 71);
            this.groupPermissions.TabIndex = 2;
            this.groupPermissions.TabStop = false;
            this.groupPermissions.Text = "Permissions";
            // 
            // tablePermissions
            // 
            this.tablePermissions.AutoSize = true;
            this.tablePermissions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePermissions.ColumnCount = 2;
            this.tablePermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePermissions.Controls.Add(this.checkBox2, 0, 0);
            this.tablePermissions.Controls.Add(this.checkBox3, 1, 0);
            this.tablePermissions.Controls.Add(this.checkBox4, 0, 1);
            this.tablePermissions.Controls.Add(this.checkBox5, 1, 1);
            this.tablePermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePermissions.Location = new System.Drawing.Point(3, 16);
            this.tablePermissions.Name = "tablePermissions";
            this.tablePermissions.RowCount = 2;
            this.tablePermissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePermissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePermissions.Size = new System.Drawing.Size(698, 52);
            this.tablePermissions.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 20);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(352, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(93, 20);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(3, 29);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 20);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(352, 29);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(93, 20);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupApplication
            // 
            this.groupApplication.AutoSize = true;
            this.groupApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupApplication.Controls.Add(this.tableApplication);
            this.groupApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupApplication.Location = new System.Drawing.Point(5, 5);
            this.groupApplication.Name = "groupApplication";
            this.groupApplication.Size = new System.Drawing.Size(704, 79);
            this.groupApplication.TabIndex = 0;
            this.groupApplication.TabStop = false;
            this.groupApplication.Text = "Application";
            // 
            // tableApplication
            // 
            this.tableApplication.AutoSize = true;
            this.tableApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableApplication.ColumnCount = 3;
            this.tableApplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableApplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableApplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableApplication.Controls.Add(this.txtApplicationPath, 1, 0);
            this.tableApplication.Controls.Add(this.btnApplicationBrowse, 2, 0);
            this.tableApplication.Controls.Add(this.lblApplicationOpen, 0, 0);
            this.tableApplication.Controls.Add(this.lblApplicationParam, 0, 1);
            this.tableApplication.Controls.Add(this.txtApplicationParam, 1, 1);
            this.tableApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableApplication.Location = new System.Drawing.Point(3, 16);
            this.tableApplication.Name = "tableApplication";
            this.tableApplication.RowCount = 2;
            this.tableApplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableApplication.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableApplication.Size = new System.Drawing.Size(698, 60);
            this.tableApplication.TabIndex = 0;
            // 
            // txtApplicationPath
            // 
            this.txtApplicationPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApplicationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplicationPath.Location = new System.Drawing.Point(60, 3);
            this.txtApplicationPath.Name = "txtApplicationPath";
            this.txtApplicationPath.Size = new System.Drawing.Size(603, 24);
            this.txtApplicationPath.TabIndex = 0;
            // 
            // btnApplicationBrowse
            // 
            this.btnApplicationBrowse.AutoSize = true;
            this.btnApplicationBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApplicationBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplicationBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationBrowse.Location = new System.Drawing.Point(669, 3);
            this.btnApplicationBrowse.Name = "btnApplicationBrowse";
            this.btnApplicationBrowse.Size = new System.Drawing.Size(26, 23);
            this.btnApplicationBrowse.TabIndex = 1;
            this.btnApplicationBrowse.Text = "...";
            this.btnApplicationBrowse.UseVisualStyleBackColor = true;
            this.btnApplicationBrowse.Click += new System.EventHandler(this.btnApplicationBrowse_Click);
            // 
            // lblApplicationOpen
            // 
            this.lblApplicationOpen.AutoSize = true;
            this.lblApplicationOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicationOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationOpen.Location = new System.Drawing.Point(3, 0);
            this.lblApplicationOpen.Name = "lblApplicationOpen";
            this.lblApplicationOpen.Size = new System.Drawing.Size(51, 30);
            this.lblApplicationOpen.TabIndex = 2;
            this.lblApplicationOpen.Text = "Open:";
            this.lblApplicationOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplicationParam
            // 
            this.lblApplicationParam.AutoSize = true;
            this.lblApplicationParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicationParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationParam.Location = new System.Drawing.Point(3, 30);
            this.lblApplicationParam.Name = "lblApplicationParam";
            this.lblApplicationParam.Size = new System.Drawing.Size(51, 30);
            this.lblApplicationParam.TabIndex = 3;
            this.lblApplicationParam.Text = "Param:";
            this.lblApplicationParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplicationParam.Visible = false;
            // 
            // txtApplicationParam
            // 
            this.txtApplicationParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApplicationParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplicationParam.Location = new System.Drawing.Point(60, 33);
            this.txtApplicationParam.Name = "txtApplicationParam";
            this.txtApplicationParam.Size = new System.Drawing.Size(603, 24);
            this.txtApplicationParam.TabIndex = 4;
            this.txtApplicationParam.Visible = false;
            // 
            // openApplicationDialog
            // 
            this.openApplicationDialog.FileName = "openApplicationDialog";
            this.openApplicationDialog.Filter = "Application|*.exe|All|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 191);
            this.Controls.Add(this.panelMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 230);
            this.Name = "MainForm";
            this.Text = "Sandbox Tool";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tableButtons.ResumeLayout(false);
            this.tableButtons.PerformLayout();
            this.groupPermissions.ResumeLayout(false);
            this.groupPermissions.PerformLayout();
            this.tablePermissions.ResumeLayout(false);
            this.tablePermissions.PerformLayout();
            this.groupApplication.ResumeLayout(false);
            this.groupApplication.PerformLayout();
            this.tableApplication.ResumeLayout(false);
            this.tableApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupApplication;
        private System.Windows.Forms.TableLayoutPanel tableApplication;
        private System.Windows.Forms.TextBox txtApplicationPath;
        private System.Windows.Forms.Button btnApplicationBrowse;
        private System.Windows.Forms.Label lblApplicationOpen;
        private System.Windows.Forms.Label lblApplicationParam;
        private System.Windows.Forms.TextBox txtApplicationParam;
        private System.Windows.Forms.CheckBox btnToggleAdvanced;
        private System.Windows.Forms.GroupBox groupPermissions;
        private System.Windows.Forms.TableLayoutPanel tablePermissions;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openApplicationDialog;
    }
}

