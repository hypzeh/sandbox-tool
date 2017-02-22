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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtApplicationPath = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openApplicaitonDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtApplicaitonParam = new System.Windows.Forms.TextBox();
            this.checkUnrestricted = new System.Windows.Forms.CheckBox();
            this.checkIO = new System.Windows.Forms.CheckBox();
            this.groupApplication = new System.Windows.Forms.GroupBox();
            this.tableApplicationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblParam = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLog = new System.Windows.Forms.TableLayoutPanel();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.btnLogToggle = new System.Windows.Forms.CheckBox();
            this.tablePermissions = new System.Windows.Forms.TableLayoutPanel();
            this.tabPermissionsControl = new System.Windows.Forms.TabControl();
            this.tabPermissionsBasic = new System.Windows.Forms.TabPage();
            this.checkTypeDescriptor = new System.Windows.Forms.CheckBox();
            this.checkStore = new System.Windows.Forms.CheckBox();
            this.checkRegistry = new System.Windows.Forms.CheckBox();
            this.checkReflection = new System.Windows.Forms.CheckBox();
            this.checkPrincipal = new System.Windows.Forms.CheckBox();
            this.checkKeyContainer = new System.Windows.Forms.CheckBox();
            this.checkEnvironment = new System.Windows.Forms.CheckBox();
            this.checkIsolatedStorage = new System.Windows.Forms.CheckBox();
            this.checkSecurity = new System.Windows.Forms.CheckBox();
            this.checkUI = new System.Windows.Forms.CheckBox();
            this.checkFileDialog = new System.Windows.Forms.CheckBox();
            this.tableApplication = new System.Windows.Forms.TableLayoutPanel();
            this.checkWeb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupApplication.SuspendLayout();
            this.tableApplicationLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLog.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.tablePermissions.SuspendLayout();
            this.tabPermissionsControl.SuspendLayout();
            this.tabPermissionsBasic.SuspendLayout();
            this.tableApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(772, 157);
            this.txtLog.TabIndex = 10;
            this.txtLog.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(701, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(621, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtApplicationPath
            // 
            this.txtApplicationPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApplicationPath.FormattingEnabled = true;
            this.txtApplicationPath.Location = new System.Drawing.Point(55, 5);
            this.txtApplicationPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtApplicationPath.MaxDropDownItems = 5;
            this.txtApplicationPath.MaxLength = 260;
            this.txtApplicationPath.Name = "txtApplicationPath";
            this.txtApplicationPath.Size = new System.Drawing.Size(706, 21);
            this.txtApplicationPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(541, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(74, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openApplicaitonDialog
            // 
            this.openApplicaitonDialog.FileName = "openApplicaitonDialog";
            this.openApplicaitonDialog.Filter = "Application|*.exe|All|*.*";
            // 
            // txtApplicaitonParam
            // 
            this.txtApplicaitonParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApplicaitonParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplicaitonParam.Location = new System.Drawing.Point(55, 36);
            this.txtApplicaitonParam.Margin = new System.Windows.Forms.Padding(5);
            this.txtApplicaitonParam.Name = "txtApplicaitonParam";
            this.txtApplicaitonParam.Size = new System.Drawing.Size(706, 20);
            this.txtApplicaitonParam.TabIndex = 2;
            // 
            // checkUnrestricted
            // 
            this.checkUnrestricted.AutoSize = true;
            this.checkUnrestricted.Location = new System.Drawing.Point(6, 6);
            this.checkUnrestricted.Name = "checkUnrestricted";
            this.checkUnrestricted.Size = new System.Drawing.Size(83, 17);
            this.checkUnrestricted.TabIndex = 7;
            this.checkUnrestricted.TabStop = false;
            this.checkUnrestricted.Tag = "Determines whether the PermissionSet is Unrestricted.";
            this.checkUnrestricted.Text = "Unrestricted";
            this.checkUnrestricted.UseVisualStyleBackColor = true;
            this.checkUnrestricted.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkUnrestricted.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkIO
            // 
            this.checkIO.AutoSize = true;
            this.checkIO.Location = new System.Drawing.Point(6, 29);
            this.checkIO.Name = "checkIO";
            this.checkIO.Size = new System.Drawing.Size(87, 17);
            this.checkIO.TabIndex = 8;
            this.checkIO.TabStop = false;
            this.checkIO.Tag = "Controls the ability to access files and folders.";
            this.checkIO.Text = "Input/Output";
            this.checkIO.UseVisualStyleBackColor = true;
            this.checkIO.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkIO.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // groupApplication
            // 
            this.groupApplication.AutoSize = true;
            this.groupApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupApplication.Controls.Add(this.tableApplicationLayout);
            this.groupApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupApplication.Location = new System.Drawing.Point(3, 3);
            this.groupApplication.Name = "groupApplication";
            this.groupApplication.Size = new System.Drawing.Size(772, 80);
            this.groupApplication.TabIndex = 9;
            this.groupApplication.TabStop = false;
            this.groupApplication.Text = "Application";
            // 
            // tableApplicationLayout
            // 
            this.tableApplicationLayout.AutoSize = true;
            this.tableApplicationLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableApplicationLayout.ColumnCount = 2;
            this.tableApplicationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableApplicationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableApplicationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableApplicationLayout.Controls.Add(this.lblParam, 0, 1);
            this.tableApplicationLayout.Controls.Add(this.txtApplicationPath, 1, 0);
            this.tableApplicationLayout.Controls.Add(this.lblOpen, 0, 0);
            this.tableApplicationLayout.Controls.Add(this.txtApplicaitonParam, 1, 1);
            this.tableApplicationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableApplicationLayout.Location = new System.Drawing.Point(3, 16);
            this.tableApplicationLayout.Name = "tableApplicationLayout";
            this.tableApplicationLayout.RowCount = 2;
            this.tableApplicationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableApplicationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableApplicationLayout.Size = new System.Drawing.Size(766, 61);
            this.tableApplicationLayout.TabIndex = 0;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParam.Location = new System.Drawing.Point(5, 35);
            this.lblParam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(40, 21);
            this.lblParam.TabIndex = 7;
            this.lblParam.Text = "Param:";
            this.lblParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOpen.Location = new System.Drawing.Point(5, 4);
            this.lblOpen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(40, 22);
            this.lblOpen.TabIndex = 6;
            this.lblOpen.Text = "Open:";
            this.lblOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLog);
            this.panel1.Controls.Add(this.tableButtons);
            this.panel1.Controls.Add(this.tablePermissions);
            this.panel1.Controls.Add(this.tableApplication);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(784, 461);
            this.panel1.TabIndex = 10;
            // 
            // tableLog
            // 
            this.tableLog.AutoSize = true;
            this.tableLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLog.ColumnCount = 1;
            this.tableLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLog.Controls.Add(this.txtLog, 0, 0);
            this.tableLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLog.Location = new System.Drawing.Point(3, 324);
            this.tableLog.Name = "tableLog";
            this.tableLog.RowCount = 1;
            this.tableLog.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLog.Size = new System.Drawing.Size(778, 134);
            this.tableLog.TabIndex = 10;
            // 
            // tableButtons
            // 
            this.tableButtons.AutoSize = true;
            this.tableButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableButtons.ColumnCount = 6;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.Controls.Add(this.btnCancel, 5, 0);
            this.tableButtons.Controls.Add(this.btnOK, 4, 0);
            this.tableButtons.Controls.Add(this.btnBrowse, 3, 0);
            this.tableButtons.Controls.Add(this.btnLogClear, 1, 0);
            this.tableButtons.Controls.Add(this.btnLogToggle, 0, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableButtons.Location = new System.Drawing.Point(3, 295);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableButtons.Size = new System.Drawing.Size(778, 29);
            this.tableButtons.TabIndex = 11;
            // 
            // btnLogClear
            // 
            this.btnLogClear.Location = new System.Drawing.Point(83, 3);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(74, 23);
            this.btnLogClear.TabIndex = 12;
            this.btnLogClear.TabStop = false;
            this.btnLogClear.Text = "Clear Log";
            this.btnLogClear.UseVisualStyleBackColor = true;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // btnLogToggle
            // 
            this.btnLogToggle.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLogToggle.Checked = true;
            this.btnLogToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnLogToggle.Location = new System.Drawing.Point(3, 3);
            this.btnLogToggle.Name = "btnLogToggle";
            this.btnLogToggle.Size = new System.Drawing.Size(74, 23);
            this.btnLogToggle.TabIndex = 13;
            this.btnLogToggle.TabStop = false;
            this.btnLogToggle.Text = "Hide Log";
            this.btnLogToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogToggle.UseVisualStyleBackColor = true;
            this.btnLogToggle.CheckedChanged += new System.EventHandler(this.btnLogToggle_CheckedChanged);
            // 
            // tablePermissions
            // 
            this.tablePermissions.AutoSize = true;
            this.tablePermissions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePermissions.ColumnCount = 1;
            this.tablePermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePermissions.Controls.Add(this.tabPermissionsControl, 0, 0);
            this.tablePermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePermissions.Location = new System.Drawing.Point(3, 89);
            this.tablePermissions.Name = "tablePermissions";
            this.tablePermissions.RowCount = 1;
            this.tablePermissions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePermissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tablePermissions.Size = new System.Drawing.Size(778, 206);
            this.tablePermissions.TabIndex = 12;
            // 
            // tabPermissionsControl
            // 
            this.tabPermissionsControl.Controls.Add(this.tabPermissionsBasic);
            this.tabPermissionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPermissionsControl.Location = new System.Drawing.Point(3, 3);
            this.tabPermissionsControl.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.tabPermissionsControl.Name = "tabPermissionsControl";
            this.tabPermissionsControl.SelectedIndex = 0;
            this.tabPermissionsControl.Size = new System.Drawing.Size(773, 200);
            this.tabPermissionsControl.TabIndex = 0;
            this.tabPermissionsControl.TabStop = false;
            // 
            // tabPermissionsBasic
            // 
            this.tabPermissionsBasic.Controls.Add(this.label1);
            this.tabPermissionsBasic.Controls.Add(this.checkWeb);
            this.tabPermissionsBasic.Controls.Add(this.checkTypeDescriptor);
            this.tabPermissionsBasic.Controls.Add(this.checkStore);
            this.tabPermissionsBasic.Controls.Add(this.checkRegistry);
            this.tabPermissionsBasic.Controls.Add(this.checkReflection);
            this.tabPermissionsBasic.Controls.Add(this.checkPrincipal);
            this.tabPermissionsBasic.Controls.Add(this.checkKeyContainer);
            this.tabPermissionsBasic.Controls.Add(this.checkEnvironment);
            this.tabPermissionsBasic.Controls.Add(this.checkIsolatedStorage);
            this.tabPermissionsBasic.Controls.Add(this.checkSecurity);
            this.tabPermissionsBasic.Controls.Add(this.checkUnrestricted);
            this.tabPermissionsBasic.Controls.Add(this.checkIO);
            this.tabPermissionsBasic.Controls.Add(this.checkUI);
            this.tabPermissionsBasic.Controls.Add(this.checkFileDialog);
            this.tabPermissionsBasic.Location = new System.Drawing.Point(4, 22);
            this.tabPermissionsBasic.Name = "tabPermissionsBasic";
            this.tabPermissionsBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermissionsBasic.Size = new System.Drawing.Size(765, 174);
            this.tabPermissionsBasic.TabIndex = 0;
            this.tabPermissionsBasic.Text = "Permissions Basic";
            this.tabPermissionsBasic.UseVisualStyleBackColor = true;
            // 
            // checkTypeDescriptor
            // 
            this.checkTypeDescriptor.AutoSize = true;
            this.checkTypeDescriptor.Location = new System.Drawing.Point(333, 52);
            this.checkTypeDescriptor.Name = "checkTypeDescriptor";
            this.checkTypeDescriptor.Size = new System.Drawing.Size(101, 17);
            this.checkTypeDescriptor.TabIndex = 19;
            this.checkTypeDescriptor.TabStop = false;
            this.checkTypeDescriptor.Tag = "Defines partial-trust access to the TypeDescriptor class.";
            this.checkTypeDescriptor.Text = "Type Descriptor";
            this.checkTypeDescriptor.UseVisualStyleBackColor = true;
            this.checkTypeDescriptor.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkTypeDescriptor.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkStore
            // 
            this.checkStore.AutoSize = true;
            this.checkStore.Location = new System.Drawing.Point(333, 29);
            this.checkStore.Name = "checkStore";
            this.checkStore.Size = new System.Drawing.Size(51, 17);
            this.checkStore.TabIndex = 18;
            this.checkStore.TabStop = false;
            this.checkStore.Tag = "Controls access to stores containing X.509 certificates.";
            this.checkStore.Text = "Store";
            this.checkStore.UseVisualStyleBackColor = true;
            this.checkStore.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkStore.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkRegistry
            // 
            this.checkRegistry.AutoSize = true;
            this.checkRegistry.Location = new System.Drawing.Point(333, 6);
            this.checkRegistry.Name = "checkRegistry";
            this.checkRegistry.Size = new System.Drawing.Size(64, 17);
            this.checkRegistry.TabIndex = 17;
            this.checkRegistry.TabStop = false;
            this.checkRegistry.Tag = "Controls the ability to access registry variables.";
            this.checkRegistry.Text = "Registry";
            this.checkRegistry.UseVisualStyleBackColor = true;
            this.checkRegistry.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkRegistry.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkReflection
            // 
            this.checkReflection.AutoSize = true;
            this.checkReflection.Location = new System.Drawing.Point(148, 98);
            this.checkReflection.Name = "checkReflection";
            this.checkReflection.Size = new System.Drawing.Size(74, 17);
            this.checkReflection.TabIndex = 16;
            this.checkReflection.TabStop = false;
            this.checkReflection.Tag = "Controls access to non-public types and members through the System.Reflection API" +
    "s. Controls some features of the System.Reflection.Emit APIs.";
            this.checkReflection.Text = "Reflection";
            this.checkReflection.UseVisualStyleBackColor = true;
            this.checkReflection.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkReflection.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkPrincipal
            // 
            this.checkPrincipal.AutoSize = true;
            this.checkPrincipal.Location = new System.Drawing.Point(148, 75);
            this.checkPrincipal.Name = "checkPrincipal";
            this.checkPrincipal.Size = new System.Drawing.Size(66, 17);
            this.checkPrincipal.TabIndex = 15;
            this.checkPrincipal.TabStop = false;
            this.checkPrincipal.Tag = "Allows checks against the active principal using the language constructs defined " +
    "for both declarative and imperative security actions.";
            this.checkPrincipal.Text = "Principal";
            this.checkPrincipal.UseVisualStyleBackColor = true;
            this.checkPrincipal.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkPrincipal.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkKeyContainer
            // 
            this.checkKeyContainer.AutoSize = true;
            this.checkKeyContainer.Location = new System.Drawing.Point(148, 52);
            this.checkKeyContainer.Name = "checkKeyContainer";
            this.checkKeyContainer.Size = new System.Drawing.Size(92, 17);
            this.checkKeyContainer.TabIndex = 14;
            this.checkKeyContainer.TabStop = false;
            this.checkKeyContainer.Tag = "Controls the ability to access key containers.";
            this.checkKeyContainer.Text = "Key Container";
            this.checkKeyContainer.UseVisualStyleBackColor = true;
            this.checkKeyContainer.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkKeyContainer.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkEnvironment
            // 
            this.checkEnvironment.AutoSize = true;
            this.checkEnvironment.Location = new System.Drawing.Point(148, 29);
            this.checkEnvironment.Name = "checkEnvironment";
            this.checkEnvironment.Size = new System.Drawing.Size(85, 17);
            this.checkEnvironment.TabIndex = 13;
            this.checkEnvironment.TabStop = false;
            this.checkEnvironment.Tag = "Controls access to system and user environment variables. ";
            this.checkEnvironment.Text = "Environment";
            this.checkEnvironment.UseVisualStyleBackColor = true;
            this.checkEnvironment.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkEnvironment.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkIsolatedStorage
            // 
            this.checkIsolatedStorage.AutoSize = true;
            this.checkIsolatedStorage.Location = new System.Drawing.Point(148, 6);
            this.checkIsolatedStorage.Name = "checkIsolatedStorage";
            this.checkIsolatedStorage.Size = new System.Drawing.Size(122, 17);
            this.checkIsolatedStorage.TabIndex = 12;
            this.checkIsolatedStorage.TabStop = false;
            this.checkIsolatedStorage.Tag = "Specifies the allowed usage of a private virtual file system. ";
            this.checkIsolatedStorage.Text = "Isolated Storage File";
            this.checkIsolatedStorage.UseVisualStyleBackColor = true;
            this.checkIsolatedStorage.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkIsolatedStorage.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkSecurity
            // 
            this.checkSecurity.AutoSize = true;
            this.checkSecurity.Location = new System.Drawing.Point(6, 98);
            this.checkSecurity.Name = "checkSecurity";
            this.checkSecurity.Size = new System.Drawing.Size(64, 17);
            this.checkSecurity.TabIndex = 11;
            this.checkSecurity.TabStop = false;
            this.checkSecurity.Tag = "Describes a set of security permissions applied to code.";
            this.checkSecurity.Text = "Security";
            this.checkSecurity.UseVisualStyleBackColor = true;
            this.checkSecurity.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkSecurity.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkUI
            // 
            this.checkUI.AutoSize = true;
            this.checkUI.Location = new System.Drawing.Point(6, 52);
            this.checkUI.Name = "checkUI";
            this.checkUI.Size = new System.Drawing.Size(93, 17);
            this.checkUI.TabIndex = 9;
            this.checkUI.TabStop = false;
            this.checkUI.Tag = "Controls the permissions related to user interfaces and the Clipboard.";
            this.checkUI.Text = "User Interface";
            this.checkUI.UseVisualStyleBackColor = true;
            this.checkUI.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkUI.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // checkFileDialog
            // 
            this.checkFileDialog.AutoSize = true;
            this.checkFileDialog.Location = new System.Drawing.Point(6, 75);
            this.checkFileDialog.Name = "checkFileDialog";
            this.checkFileDialog.Size = new System.Drawing.Size(75, 17);
            this.checkFileDialog.TabIndex = 10;
            this.checkFileDialog.TabStop = false;
            this.checkFileDialog.Tag = "Controls the ability to access files or folders through a File dialog box.";
            this.checkFileDialog.Text = "File Dialog";
            this.checkFileDialog.UseVisualStyleBackColor = true;
            this.checkFileDialog.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkFileDialog.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // tableApplication
            // 
            this.tableApplication.AutoSize = true;
            this.tableApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableApplication.ColumnCount = 1;
            this.tableApplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableApplication.Controls.Add(this.groupApplication, 0, 0);
            this.tableApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableApplication.Location = new System.Drawing.Point(3, 3);
            this.tableApplication.Name = "tableApplication";
            this.tableApplication.RowCount = 1;
            this.tableApplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableApplication.Size = new System.Drawing.Size(778, 86);
            this.tableApplication.TabIndex = 13;
            // 
            // checkWeb
            // 
            this.checkWeb.AutoSize = true;
            this.checkWeb.Location = new System.Drawing.Point(333, 75);
            this.checkWeb.Name = "checkWeb";
            this.checkWeb.Size = new System.Drawing.Size(49, 17);
            this.checkWeb.TabIndex = 20;
            this.checkWeb.TabStop = false;
            this.checkWeb.Tag = "Controls the ability to access web services.";
            this.checkWeb.Text = "Web";
            this.checkWeb.UseVisualStyleBackColor = true;
            this.checkWeb.MouseEnter += new System.EventHandler(this.toolTip_MouseEnter);
            this.checkWeb.MouseLeave += new System.EventHandler(this.toolTip_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 41);
            this.label1.TabIndex = 21;
            this.label1.Text = "Info:\r\n...";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 366);
            this.Name = "MainForm";
            this.Text = "Sandbox Tool";
            this.groupApplication.ResumeLayout(false);
            this.groupApplication.PerformLayout();
            this.tableApplicationLayout.ResumeLayout(false);
            this.tableApplicationLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLog.ResumeLayout(false);
            this.tableLog.PerformLayout();
            this.tableButtons.ResumeLayout(false);
            this.tablePermissions.ResumeLayout(false);
            this.tabPermissionsControl.ResumeLayout(false);
            this.tabPermissionsBasic.ResumeLayout(false);
            this.tabPermissionsBasic.PerformLayout();
            this.tableApplication.ResumeLayout(false);
            this.tableApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox txtApplicationPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openApplicaitonDialog;
        private System.Windows.Forms.TextBox txtApplicaitonParam;
        private System.Windows.Forms.CheckBox checkUnrestricted;
        private System.Windows.Forms.CheckBox checkIO;
        private System.Windows.Forms.GroupBox groupApplication;
        private System.Windows.Forms.TableLayoutPanel tableApplicationLayout;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLog;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.TabControl tabPermissionsControl;
        private System.Windows.Forms.TabPage tabPermissionsBasic;
        private System.Windows.Forms.TableLayoutPanel tablePermissions;
        private System.Windows.Forms.TableLayoutPanel tableApplication;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.CheckBox btnLogToggle;
        private System.Windows.Forms.CheckBox checkUI;
        private System.Windows.Forms.CheckBox checkFileDialog;
        private System.Windows.Forms.CheckBox checkSecurity;
        private System.Windows.Forms.CheckBox checkIsolatedStorage;
        private System.Windows.Forms.CheckBox checkEnvironment;
        private System.Windows.Forms.CheckBox checkKeyContainer;
        private System.Windows.Forms.CheckBox checkPrincipal;
        private System.Windows.Forms.CheckBox checkReflection;
        private System.Windows.Forms.CheckBox checkRegistry;
        private System.Windows.Forms.CheckBox checkStore;
        private System.Windows.Forms.CheckBox checkTypeDescriptor;
        private System.Windows.Forms.CheckBox checkWeb;
        private System.Windows.Forms.Label label1;
    }
}

