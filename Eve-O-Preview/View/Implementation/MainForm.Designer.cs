using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace EveOPreview.View
{
    partial class MainForm : MetroSetForm
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

        /// <summary>s
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem RestoreWindowMenuItem;
            System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
            System.Windows.Forms.ToolStripMenuItem TitleMenuItem;
            System.Windows.Forms.ToolStripSeparator SeparatorMenuItem;
            MetroSet_UI.Controls.MetroSetTabControl MainTab;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroSetTabPage1 = new MetroSet_UI.Child.MetroSetTabPage();
            this.EnablePerClientThumbnailsLayoutsCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.HideThumbnailsOnLostFocusCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.ShowThumbnailsAlwaysOnTopCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.MinimizeInactiveClientsCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.HideActiveClientThumbnailCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.EnableClientLayoutTrackingCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.MinimizeToTrayCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.metroSetTabPage2 = new MetroSet_UI.Child.MetroSetTabPage();
            this.ThumbnailsHeightNumericEdit = new MetroSet_UI.Controls.MetroSetNumeric();
            this.ThumbnailsWidthNumericEdit = new MetroSet_UI.Controls.MetroSetNumeric();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.ThumbnailOpacityTrackBar = new MetroSet_UI.Controls.MetroSetTrackBar();
            this.Opacity = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTabPage3 = new MetroSet_UI.Child.MetroSetTabPage();
            this.ZoomAnchorPanel = new System.Windows.Forms.Panel();
            this.ZoomAanchorNWRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorNRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorNERadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorWRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorSERadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorCRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorSRadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorERadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomAanchorSWRadioButton = new System.Windows.Forms.RadioButton();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.ThumbnailZoomFactorNumericEdit = new MetroSet_UI.Controls.MetroSetNumeric();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.EnableThumbnailZoomCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.metroSetTabPage4 = new MetroSet_UI.Child.MetroSetTabPage();
            this.ActiveClientHighlightColorButton = new System.Windows.Forms.Panel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.EnableActiveClientHighlightCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.ShowThumbnailFramesCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.ShowThumbnailOverlaysCheckBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.metroSetTabPage5 = new MetroSet_UI.Child.MetroSetTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ThumbnailsList = new System.Windows.Forms.CheckedListBox();
            this.metroSetTabPage6 = new MetroSet_UI.Child.MetroSetTabPage();
            this.DocumentationLink = new MetroSet_UI.Controls.MetroSetLink();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            RestoreWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            TitleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            MainTab = new MetroSet_UI.Controls.MetroSetTabControl();
            MainTab.SuspendLayout();
            this.metroSetTabPage1.SuspendLayout();
            this.metroSetTabPage2.SuspendLayout();
            this.metroSetTabPage3.SuspendLayout();
            this.ZoomAnchorPanel.SuspendLayout();
            this.metroSetTabPage4.SuspendLayout();
            this.metroSetTabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroSetTabPage6.SuspendLayout();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // RestoreWindowMenuItem
            // 
            RestoreWindowMenuItem.Name = "RestoreWindowMenuItem";
            RestoreWindowMenuItem.Size = new System.Drawing.Size(161, 22);
            RestoreWindowMenuItem.Text = "Restore";
            RestoreWindowMenuItem.Click += new System.EventHandler(this.RestoreMainForm_Handler);
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new System.Drawing.Size(161, 22);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItemClick_Handler);
            // 
            // TitleMenuItem
            // 
            TitleMenuItem.Enabled = false;
            TitleMenuItem.Name = "TitleMenuItem";
            TitleMenuItem.Size = new System.Drawing.Size(161, 22);
            TitleMenuItem.Text = "EVE-O Preview";
            // 
            // SeparatorMenuItem
            // 
            SeparatorMenuItem.Name = "SeparatorMenuItem";
            SeparatorMenuItem.Size = new System.Drawing.Size(158, 6);
            // 
            // MainTab
            // 
            MainTab.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            MainTab.AnimateTime = 200;
            MainTab.Controls.Add(this.metroSetTabPage1);
            MainTab.Controls.Add(this.metroSetTabPage2);
            MainTab.Controls.Add(this.metroSetTabPage3);
            MainTab.Controls.Add(this.metroSetTabPage4);
            MainTab.Controls.Add(this.metroSetTabPage5);
            MainTab.Controls.Add(this.metroSetTabPage6);
            MainTab.Cursor = System.Windows.Forms.Cursors.Hand;
            MainTab.ItemSize = new System.Drawing.Size(100, 38);
            MainTab.Location = new System.Drawing.Point(16, 83);
            MainTab.Name = "MainTab";
            MainTab.SelectedIndex = 5;
            MainTab.Size = new System.Drawing.Size(360, 290);
            MainTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            MainTab.Speed = 20;
            MainTab.Style = MetroSet_UI.Design.Style.Dark;
            MainTab.StyleManager = null;
            MainTab.TabIndex = 8;
            MainTab.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            MainTab.ThemeAuthor = "Narwin";
            MainTab.ThemeName = "MetroDark";
            MainTab.UseAnimation = true;
            // 
            // metroSetTabPage1
            // 
            this.metroSetTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabPage1.Controls.Add(this.EnablePerClientThumbnailsLayoutsCheckBox);
            this.metroSetTabPage1.Controls.Add(this.HideThumbnailsOnLostFocusCheckBox);
            this.metroSetTabPage1.Controls.Add(this.ShowThumbnailsAlwaysOnTopCheckBox);
            this.metroSetTabPage1.Controls.Add(this.MinimizeInactiveClientsCheckBox);
            this.metroSetTabPage1.Controls.Add(this.HideActiveClientThumbnailCheckBox);
            this.metroSetTabPage1.Controls.Add(this.EnableClientLayoutTrackingCheckBox);
            this.metroSetTabPage1.Controls.Add(this.MinimizeToTrayCheckBox);
            this.metroSetTabPage1.ImageIndex = 0;
            this.metroSetTabPage1.ImageKey = null;
            this.metroSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage1.Name = "metroSetTabPage1";
            this.metroSetTabPage1.Size = new System.Drawing.Size(352, 244);
            this.metroSetTabPage1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTabPage1.StyleManager = null;
            this.metroSetTabPage1.TabIndex = 0;
            this.metroSetTabPage1.Text = "³£¹æ";
            this.metroSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetTabPage1.ThemeName = "MetroDark";
            this.metroSetTabPage1.ToolTipText = null;
            // 
            // EnablePerClientThumbnailsLayoutsCheckBox
            // 
            this.EnablePerClientThumbnailsLayoutsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnablePerClientThumbnailsLayoutsCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EnablePerClientThumbnailsLayoutsCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.EnablePerClientThumbnailsLayoutsCheckBox.Checked = false;
            this.EnablePerClientThumbnailsLayoutsCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EnablePerClientThumbnailsLayoutsCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.EnablePerClientThumbnailsLayoutsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnablePerClientThumbnailsLayoutsCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.EnablePerClientThumbnailsLayoutsCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.EnablePerClientThumbnailsLayoutsCheckBox.Location = new System.Drawing.Point(9, 185);
            this.EnablePerClientThumbnailsLayoutsCheckBox.Name = "EnablePerClientThumbnailsLayoutsCheckBox";
            this.EnablePerClientThumbnailsLayoutsCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.EnablePerClientThumbnailsLayoutsCheckBox.Size = new System.Drawing.Size(250, 16);
            this.EnablePerClientThumbnailsLayoutsCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.EnablePerClientThumbnailsLayoutsCheckBox.StyleManager = null;
            this.EnablePerClientThumbnailsLayoutsCheckBox.TabIndex = 30;
            this.EnablePerClientThumbnailsLayoutsCheckBox.Text = "ÎªÃ¿¸ö¿Í»§¶ËÆôÓÃ¶ÀÁ¢²¼¾Ö";
            this.EnablePerClientThumbnailsLayoutsCheckBox.ThemeAuthor = "Narwin";
            this.EnablePerClientThumbnailsLayoutsCheckBox.ThemeName = "MetroDark";
            this.EnablePerClientThumbnailsLayoutsCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // HideThumbnailsOnLostFocusCheckBox
            // 
            this.HideThumbnailsOnLostFocusCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.HideThumbnailsOnLostFocusCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HideThumbnailsOnLostFocusCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.HideThumbnailsOnLostFocusCheckBox.Checked = false;
            this.HideThumbnailsOnLostFocusCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.HideThumbnailsOnLostFocusCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.HideThumbnailsOnLostFocusCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideThumbnailsOnLostFocusCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.HideThumbnailsOnLostFocusCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.HideThumbnailsOnLostFocusCheckBox.Location = new System.Drawing.Point(9, 157);
            this.HideThumbnailsOnLostFocusCheckBox.Name = "HideThumbnailsOnLostFocusCheckBox";
            this.HideThumbnailsOnLostFocusCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.HideThumbnailsOnLostFocusCheckBox.Size = new System.Drawing.Size(250, 16);
            this.HideThumbnailsOnLostFocusCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.HideThumbnailsOnLostFocusCheckBox.StyleManager = null;
            this.HideThumbnailsOnLostFocusCheckBox.TabIndex = 29;
            this.HideThumbnailsOnLostFocusCheckBox.Text = "Òþ²ØÎ´¼¤»îEVE¿Í»§¶ËÔ¤ÀÀ";
            this.HideThumbnailsOnLostFocusCheckBox.ThemeAuthor = "Narwin";
            this.HideThumbnailsOnLostFocusCheckBox.ThemeName = "MetroDark";
            this.HideThumbnailsOnLostFocusCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // ShowThumbnailsAlwaysOnTopCheckBox
            // 
            this.ShowThumbnailsAlwaysOnTopCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowThumbnailsAlwaysOnTopCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ShowThumbnailsAlwaysOnTopCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ShowThumbnailsAlwaysOnTopCheckBox.Checked = false;
            this.ShowThumbnailsAlwaysOnTopCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ShowThumbnailsAlwaysOnTopCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.ShowThumbnailsAlwaysOnTopCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowThumbnailsAlwaysOnTopCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ShowThumbnailsAlwaysOnTopCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.ShowThumbnailsAlwaysOnTopCheckBox.Location = new System.Drawing.Point(9, 129);
            this.ShowThumbnailsAlwaysOnTopCheckBox.Name = "ShowThumbnailsAlwaysOnTopCheckBox";
            this.ShowThumbnailsAlwaysOnTopCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.ShowThumbnailsAlwaysOnTopCheckBox.Size = new System.Drawing.Size(250, 16);
            this.ShowThumbnailsAlwaysOnTopCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.ShowThumbnailsAlwaysOnTopCheckBox.StyleManager = null;
            this.ShowThumbnailsAlwaysOnTopCheckBox.TabIndex = 28;
            this.ShowThumbnailsAlwaysOnTopCheckBox.Text = "Ô¤ÀÀ×ÜÔÚ×îÇ°";
            this.ShowThumbnailsAlwaysOnTopCheckBox.ThemeAuthor = "Narwin";
            this.ShowThumbnailsAlwaysOnTopCheckBox.ThemeName = "MetroDark";
            this.ShowThumbnailsAlwaysOnTopCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // MinimizeInactiveClientsCheckBox
            // 
            this.MinimizeInactiveClientsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeInactiveClientsCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MinimizeInactiveClientsCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.MinimizeInactiveClientsCheckBox.Checked = false;
            this.MinimizeInactiveClientsCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MinimizeInactiveClientsCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.MinimizeInactiveClientsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeInactiveClientsCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.MinimizeInactiveClientsCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.MinimizeInactiveClientsCheckBox.Location = new System.Drawing.Point(9, 101);
            this.MinimizeInactiveClientsCheckBox.Name = "MinimizeInactiveClientsCheckBox";
            this.MinimizeInactiveClientsCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.MinimizeInactiveClientsCheckBox.Size = new System.Drawing.Size(250, 16);
            this.MinimizeInactiveClientsCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.MinimizeInactiveClientsCheckBox.StyleManager = null;
            this.MinimizeInactiveClientsCheckBox.TabIndex = 27;
            this.MinimizeInactiveClientsCheckBox.Text = "×îÐ¡»¯·Ç¼¤»îEVE¿Í»§¶ËÕ¼ÓÃ";
            this.MinimizeInactiveClientsCheckBox.ThemeAuthor = "Narwin";
            this.MinimizeInactiveClientsCheckBox.ThemeName = "MetroDark";
            this.MinimizeInactiveClientsCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // HideActiveClientThumbnailCheckBox
            // 
            this.HideActiveClientThumbnailCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.HideActiveClientThumbnailCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.HideActiveClientThumbnailCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.HideActiveClientThumbnailCheckBox.Checked = false;
            this.HideActiveClientThumbnailCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.HideActiveClientThumbnailCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.HideActiveClientThumbnailCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideActiveClientThumbnailCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.HideActiveClientThumbnailCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.HideActiveClientThumbnailCheckBox.Location = new System.Drawing.Point(9, 73);
            this.HideActiveClientThumbnailCheckBox.Name = "HideActiveClientThumbnailCheckBox";
            this.HideActiveClientThumbnailCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.HideActiveClientThumbnailCheckBox.Size = new System.Drawing.Size(250, 16);
            this.HideActiveClientThumbnailCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.HideActiveClientThumbnailCheckBox.StyleManager = null;
            this.HideActiveClientThumbnailCheckBox.TabIndex = 26;
            this.HideActiveClientThumbnailCheckBox.Text = "Òþ²Ø¼¤»îEVE¿Í»§¶ËÔ¤ÀÀ";
            this.HideActiveClientThumbnailCheckBox.ThemeAuthor = "Narwin";
            this.HideActiveClientThumbnailCheckBox.ThemeName = "MetroDark";
            this.HideActiveClientThumbnailCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // EnableClientLayoutTrackingCheckBox
            // 
            this.EnableClientLayoutTrackingCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableClientLayoutTrackingCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EnableClientLayoutTrackingCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.EnableClientLayoutTrackingCheckBox.Checked = false;
            this.EnableClientLayoutTrackingCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EnableClientLayoutTrackingCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.EnableClientLayoutTrackingCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnableClientLayoutTrackingCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.EnableClientLayoutTrackingCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.EnableClientLayoutTrackingCheckBox.Location = new System.Drawing.Point(9, 45);
            this.EnableClientLayoutTrackingCheckBox.Name = "EnableClientLayoutTrackingCheckBox";
            this.EnableClientLayoutTrackingCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.EnableClientLayoutTrackingCheckBox.Size = new System.Drawing.Size(250, 16);
            this.EnableClientLayoutTrackingCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.EnableClientLayoutTrackingCheckBox.StyleManager = null;
            this.EnableClientLayoutTrackingCheckBox.TabIndex = 25;
            this.EnableClientLayoutTrackingCheckBox.Text = "¸ú×Ù´°¿ÚÎ»ÖÃ";
            this.EnableClientLayoutTrackingCheckBox.ThemeAuthor = "Narwin";
            this.EnableClientLayoutTrackingCheckBox.ThemeName = "MetroDark";
            this.EnableClientLayoutTrackingCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // MinimizeToTrayCheckBox
            // 
            this.MinimizeToTrayCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeToTrayCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MinimizeToTrayCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.MinimizeToTrayCheckBox.Checked = false;
            this.MinimizeToTrayCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MinimizeToTrayCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.MinimizeToTrayCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeToTrayCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.MinimizeToTrayCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.MinimizeToTrayCheckBox.Location = new System.Drawing.Point(9, 18);
            this.MinimizeToTrayCheckBox.Name = "MinimizeToTrayCheckBox";
            this.MinimizeToTrayCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.MinimizeToTrayCheckBox.Size = new System.Drawing.Size(250, 16);
            this.MinimizeToTrayCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.MinimizeToTrayCheckBox.StyleManager = null;
            this.MinimizeToTrayCheckBox.TabIndex = 9;
            this.MinimizeToTrayCheckBox.Text = "×îÐ¡»¯µ½ÍÐÅÌ";
            this.MinimizeToTrayCheckBox.ThemeAuthor = "Narwin";
            this.MinimizeToTrayCheckBox.ThemeName = "MetroDark";
            this.MinimizeToTrayCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // metroSetTabPage2
            // 
            this.metroSetTabPage2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabPage2.Controls.Add(this.ThumbnailsHeightNumericEdit);
            this.metroSetTabPage2.Controls.Add(this.ThumbnailsWidthNumericEdit);
            this.metroSetTabPage2.Controls.Add(this.metroSetLabel2);
            this.metroSetTabPage2.Controls.Add(this.metroSetLabel1);
            this.metroSetTabPage2.Controls.Add(this.ThumbnailOpacityTrackBar);
            this.metroSetTabPage2.Controls.Add(this.Opacity);
            this.metroSetTabPage2.ImageIndex = 0;
            this.metroSetTabPage2.ImageKey = null;
            this.metroSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage2.Name = "metroSetTabPage2";
            this.metroSetTabPage2.Size = new System.Drawing.Size(352, 244);
            this.metroSetTabPage2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTabPage2.StyleManager = null;
            this.metroSetTabPage2.TabIndex = 1;
            this.metroSetTabPage2.Text = "Ô¤ÀÀ";
            this.metroSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetTabPage2.ThemeName = "MetroDark";
            this.metroSetTabPage2.ToolTipText = null;
            // 
            // ThumbnailsHeightNumericEdit
            // 
            this.ThumbnailsHeightNumericEdit.BackColor = System.Drawing.Color.Transparent;
            this.ThumbnailsHeightNumericEdit.BackgroundColor = System.Drawing.Color.Empty;
            this.ThumbnailsHeightNumericEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ThumbnailsHeightNumericEdit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ThumbnailsHeightNumericEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ThumbnailsHeightNumericEdit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ThumbnailsHeightNumericEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ThumbnailsHeightNumericEdit.Location = new System.Drawing.Point(246, 42);
            this.ThumbnailsHeightNumericEdit.Maximum = 1080;
            this.ThumbnailsHeightNumericEdit.Minimum = 0;
            this.ThumbnailsHeightNumericEdit.Name = "ThumbnailsHeightNumericEdit";
            this.ThumbnailsHeightNumericEdit.Size = new System.Drawing.Size(89, 26);
            this.ThumbnailsHeightNumericEdit.Style = MetroSet_UI.Design.Style.Dark;
            this.ThumbnailsHeightNumericEdit.StyleManager = null;
            this.ThumbnailsHeightNumericEdit.SymbolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ThumbnailsHeightNumericEdit.TabIndex = 5;
            this.ThumbnailsHeightNumericEdit.Text = "metroSetNumeric2";
            this.ThumbnailsHeightNumericEdit.ThemeAuthor = "Narwin";
            this.ThumbnailsHeightNumericEdit.ThemeName = "MetroDark";
            this.ThumbnailsHeightNumericEdit.Value = 360;
            this.ThumbnailsHeightNumericEdit.Click += new System.EventHandler(this.ThumbnailSizeChanged_Handler);
            // 
            // ThumbnailsWidthNumericEdit
            // 
            this.ThumbnailsWidthNumericEdit.BackColor = System.Drawing.Color.Transparent;
            this.ThumbnailsWidthNumericEdit.BackgroundColor = System.Drawing.Color.Empty;
            this.ThumbnailsWidthNumericEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ThumbnailsWidthNumericEdit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ThumbnailsWidthNumericEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ThumbnailsWidthNumericEdit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ThumbnailsWidthNumericEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ThumbnailsWidthNumericEdit.Location = new System.Drawing.Point(69, 42);
            this.ThumbnailsWidthNumericEdit.Maximum = 1920;
            this.ThumbnailsWidthNumericEdit.Minimum = 0;
            this.ThumbnailsWidthNumericEdit.Name = "ThumbnailsWidthNumericEdit";
            this.ThumbnailsWidthNumericEdit.Size = new System.Drawing.Size(89, 26);
            this.ThumbnailsWidthNumericEdit.Style = MetroSet_UI.Design.Style.Dark;
            this.ThumbnailsWidthNumericEdit.StyleManager = null;
            this.ThumbnailsWidthNumericEdit.SymbolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ThumbnailsWidthNumericEdit.TabIndex = 4;
            this.ThumbnailsWidthNumericEdit.Text = "metroSetNumeric1";
            this.ThumbnailsWidthNumericEdit.ThemeAuthor = "Narwin";
            this.ThumbnailsWidthNumericEdit.ThemeName = "MetroDark";
            this.ThumbnailsWidthNumericEdit.Value = 480;
            this.ThumbnailsWidthNumericEdit.TextChanged += new System.EventHandler(this.ThumbnailSizeChanged_Handler);
            this.ThumbnailsWidthNumericEdit.Click += new System.EventHandler(this.ThumbnailSizeChanged_Handler);
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.metroSetLabel2.Location = new System.Drawing.Point(184, 45);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(66, 18);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 3;
            this.metroSetLabel2.Text = "Ô¤ÀÀ¸ß¶È";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.metroSetLabel1.Location = new System.Drawing.Point(9, 45);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(66, 18);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 2;
            this.metroSetLabel1.Text = "Ô¤ÀÀ¿í¶È";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // ThumbnailOpacityTrackBar
            // 
            this.ThumbnailOpacityTrackBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ThumbnailOpacityTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThumbnailOpacityTrackBar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ThumbnailOpacityTrackBar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.ThumbnailOpacityTrackBar.DisabledHandlerColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ThumbnailOpacityTrackBar.DisabledValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ThumbnailOpacityTrackBar.HandlerColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.ThumbnailOpacityTrackBar.Location = new System.Drawing.Point(56, 18);
            this.ThumbnailOpacityTrackBar.Maximum = 100;
            this.ThumbnailOpacityTrackBar.Minimum = 0;
            this.ThumbnailOpacityTrackBar.Name = "ThumbnailOpacityTrackBar";
            this.ThumbnailOpacityTrackBar.Size = new System.Drawing.Size(281, 16);
            this.ThumbnailOpacityTrackBar.Style = MetroSet_UI.Design.Style.Dark;
            this.ThumbnailOpacityTrackBar.StyleManager = null;
            this.ThumbnailOpacityTrackBar.TabIndex = 0;
            this.ThumbnailOpacityTrackBar.Text = "metroSetTrackBar1";
            this.ThumbnailOpacityTrackBar.ThemeAuthor = "Narwin";
            this.ThumbnailOpacityTrackBar.ThemeName = "MetroDark";
            this.ThumbnailOpacityTrackBar.Value = 10;
            this.ThumbnailOpacityTrackBar.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ThumbnailOpacityTrackBar.Scroll += new MetroSet_UI.Controls.MetroSetTrackBar.ScrollEventHandler(this.scroll);
            // 
            // Opacity
            // 
            this.Opacity.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.Opacity.Location = new System.Drawing.Point(9, 18);
            this.Opacity.Name = "Opacity";
            this.Opacity.Size = new System.Drawing.Size(49, 16);
            this.Opacity.Style = MetroSet_UI.Design.Style.Dark;
            this.Opacity.StyleManager = null;
            this.Opacity.TabIndex = 1;
            this.Opacity.Text = "Í¸Ã÷¶È";
            this.Opacity.ThemeAuthor = "Narwin";
            this.Opacity.ThemeName = "MetroDark";
            // 
            // metroSetTabPage3
            // 
            this.metroSetTabPage3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabPage3.Controls.Add(this.ZoomAnchorPanel);
            this.metroSetTabPage3.Controls.Add(this.metroSetLabel4);
            this.metroSetTabPage3.Controls.Add(this.ThumbnailZoomFactorNumericEdit);
            this.metroSetTabPage3.Controls.Add(this.metroSetLabel3);
            this.metroSetTabPage3.Controls.Add(this.EnableThumbnailZoomCheckBox);
            this.metroSetTabPage3.ImageIndex = 0;
            this.metroSetTabPage3.ImageKey = null;
            this.metroSetTabPage3.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage3.Name = "metroSetTabPage3";
            this.metroSetTabPage3.Size = new System.Drawing.Size(352, 244);
            this.metroSetTabPage3.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTabPage3.StyleManager = null;
            this.metroSetTabPage3.TabIndex = 2;
            this.metroSetTabPage3.Text = "Ëõ·Å";
            this.metroSetTabPage3.ThemeAuthor = "Narwin";
            this.metroSetTabPage3.ThemeName = "MetroDark";
            this.metroSetTabPage3.ToolTipText = null;
            // 
            // ZoomAnchorPanel
            // 
            this.ZoomAnchorPanel.BackColor = System.Drawing.Color.Transparent;
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorNWRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorNRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorNERadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorWRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorSERadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorCRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorSRadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorERadioButton);
            this.ZoomAnchorPanel.Controls.Add(this.ZoomAanchorSWRadioButton);
            this.ZoomAnchorPanel.Location = new System.Drawing.Point(40, 73);
            this.ZoomAnchorPanel.Name = "ZoomAnchorPanel";
            this.ZoomAnchorPanel.Size = new System.Drawing.Size(87, 81);
            this.ZoomAnchorPanel.TabIndex = 38;
            // 
            // ZoomAanchorNWRadioButton
            // 
            this.ZoomAanchorNWRadioButton.AutoSize = true;
            this.ZoomAanchorNWRadioButton.Location = new System.Drawing.Point(6, 5);
            this.ZoomAanchorNWRadioButton.Name = "ZoomAanchorNWRadioButton";
            this.ZoomAanchorNWRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorNWRadioButton.TabIndex = 0;
            this.ZoomAanchorNWRadioButton.TabStop = true;
            this.ZoomAanchorNWRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorNWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorNRadioButton
            // 
            this.ZoomAanchorNRadioButton.AutoSize = true;
            this.ZoomAanchorNRadioButton.Location = new System.Drawing.Point(34, 5);
            this.ZoomAanchorNRadioButton.Name = "ZoomAanchorNRadioButton";
            this.ZoomAanchorNRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorNRadioButton.TabIndex = 1;
            this.ZoomAanchorNRadioButton.TabStop = true;
            this.ZoomAanchorNRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorNRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorNERadioButton
            // 
            this.ZoomAanchorNERadioButton.AutoSize = true;
            this.ZoomAanchorNERadioButton.Location = new System.Drawing.Point(61, 5);
            this.ZoomAanchorNERadioButton.Name = "ZoomAanchorNERadioButton";
            this.ZoomAanchorNERadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorNERadioButton.TabIndex = 2;
            this.ZoomAanchorNERadioButton.TabStop = true;
            this.ZoomAanchorNERadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorNERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorWRadioButton
            // 
            this.ZoomAanchorWRadioButton.AutoSize = true;
            this.ZoomAanchorWRadioButton.Location = new System.Drawing.Point(6, 32);
            this.ZoomAanchorWRadioButton.Name = "ZoomAanchorWRadioButton";
            this.ZoomAanchorWRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorWRadioButton.TabIndex = 3;
            this.ZoomAanchorWRadioButton.TabStop = true;
            this.ZoomAanchorWRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorSERadioButton
            // 
            this.ZoomAanchorSERadioButton.AutoSize = true;
            this.ZoomAanchorSERadioButton.Location = new System.Drawing.Point(61, 61);
            this.ZoomAanchorSERadioButton.Name = "ZoomAanchorSERadioButton";
            this.ZoomAanchorSERadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorSERadioButton.TabIndex = 8;
            this.ZoomAanchorSERadioButton.TabStop = true;
            this.ZoomAanchorSERadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorSERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorCRadioButton
            // 
            this.ZoomAanchorCRadioButton.AutoSize = true;
            this.ZoomAanchorCRadioButton.Location = new System.Drawing.Point(34, 32);
            this.ZoomAanchorCRadioButton.Name = "ZoomAanchorCRadioButton";
            this.ZoomAanchorCRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorCRadioButton.TabIndex = 4;
            this.ZoomAanchorCRadioButton.TabStop = true;
            this.ZoomAanchorCRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorCRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorSRadioButton
            // 
            this.ZoomAanchorSRadioButton.AutoSize = true;
            this.ZoomAanchorSRadioButton.Location = new System.Drawing.Point(34, 61);
            this.ZoomAanchorSRadioButton.Name = "ZoomAanchorSRadioButton";
            this.ZoomAanchorSRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorSRadioButton.TabIndex = 7;
            this.ZoomAanchorSRadioButton.TabStop = true;
            this.ZoomAanchorSRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorSRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorERadioButton
            // 
            this.ZoomAanchorERadioButton.AutoSize = true;
            this.ZoomAanchorERadioButton.Location = new System.Drawing.Point(61, 32);
            this.ZoomAanchorERadioButton.Name = "ZoomAanchorERadioButton";
            this.ZoomAanchorERadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorERadioButton.TabIndex = 5;
            this.ZoomAanchorERadioButton.TabStop = true;
            this.ZoomAanchorERadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorERadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // ZoomAanchorSWRadioButton
            // 
            this.ZoomAanchorSWRadioButton.AutoSize = true;
            this.ZoomAanchorSWRadioButton.Location = new System.Drawing.Point(6, 61);
            this.ZoomAanchorSWRadioButton.Name = "ZoomAanchorSWRadioButton";
            this.ZoomAanchorSWRadioButton.Size = new System.Drawing.Size(14, 13);
            this.ZoomAanchorSWRadioButton.TabIndex = 6;
            this.ZoomAanchorSWRadioButton.TabStop = true;
            this.ZoomAanchorSWRadioButton.UseVisualStyleBackColor = true;
            this.ZoomAanchorSWRadioButton.CheckedChanged += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.metroSetLabel4.Location = new System.Drawing.Point(9, 73);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(66, 18);
            this.metroSetLabel4.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 13;
            this.metroSetLabel4.Text = "Ãª¶¨";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroDark";
            this.metroSetLabel4.Click += new System.EventHandler(this.metroSetLabel4_Click);
            // 
            // ThumbnailZoomFactorNumericEdit
            // 
            this.ThumbnailZoomFactorNumericEdit.BackColor = System.Drawing.Color.Transparent;
            this.ThumbnailZoomFactorNumericEdit.BackgroundColor = System.Drawing.Color.Empty;
            this.ThumbnailZoomFactorNumericEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ThumbnailZoomFactorNumericEdit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ThumbnailZoomFactorNumericEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ThumbnailZoomFactorNumericEdit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ThumbnailZoomFactorNumericEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ThumbnailZoomFactorNumericEdit.Location = new System.Drawing.Point(67, 41);
            this.ThumbnailZoomFactorNumericEdit.Maximum = 5;
            this.ThumbnailZoomFactorNumericEdit.Minimum = 1;
            this.ThumbnailZoomFactorNumericEdit.Name = "ThumbnailZoomFactorNumericEdit";
            this.ThumbnailZoomFactorNumericEdit.Size = new System.Drawing.Size(89, 26);
            this.ThumbnailZoomFactorNumericEdit.Style = MetroSet_UI.Design.Style.Dark;
            this.ThumbnailZoomFactorNumericEdit.StyleManager = null;
            this.ThumbnailZoomFactorNumericEdit.SymbolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ThumbnailZoomFactorNumericEdit.TabIndex = 12;
            this.ThumbnailZoomFactorNumericEdit.Text = "metroSetNumeric1";
            this.ThumbnailZoomFactorNumericEdit.ThemeAuthor = "Narwin";
            this.ThumbnailZoomFactorNumericEdit.ThemeName = "MetroDark";
            this.ThumbnailZoomFactorNumericEdit.Value = 2;
            this.ThumbnailZoomFactorNumericEdit.Click += new System.EventHandler(this.OptionChanged_Handler);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.metroSetLabel3.Location = new System.Drawing.Point(9, 45);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(66, 18);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 11;
            this.metroSetLabel3.Text = "Ô¤ÀÀ¿í¶È";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // EnableThumbnailZoomCheckBox
            // 
            this.EnableThumbnailZoomCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableThumbnailZoomCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EnableThumbnailZoomCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.EnableThumbnailZoomCheckBox.Checked = false;
            this.EnableThumbnailZoomCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EnableThumbnailZoomCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.EnableThumbnailZoomCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnableThumbnailZoomCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.EnableThumbnailZoomCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.EnableThumbnailZoomCheckBox.Location = new System.Drawing.Point(9, 18);
            this.EnableThumbnailZoomCheckBox.Name = "EnableThumbnailZoomCheckBox";
            this.EnableThumbnailZoomCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.EnableThumbnailZoomCheckBox.Size = new System.Drawing.Size(250, 16);
            this.EnableThumbnailZoomCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.EnableThumbnailZoomCheckBox.StyleManager = null;
            this.EnableThumbnailZoomCheckBox.TabIndex = 10;
            this.EnableThumbnailZoomCheckBox.Text = "Ö¸Ïò·Å´ó";
            this.EnableThumbnailZoomCheckBox.ThemeAuthor = "Narwin";
            this.EnableThumbnailZoomCheckBox.ThemeName = "MetroDark";
            this.EnableThumbnailZoomCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // metroSetTabPage4
            // 
            this.metroSetTabPage4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabPage4.Controls.Add(this.ActiveClientHighlightColorButton);
            this.metroSetTabPage4.Controls.Add(this.metroSetLabel5);
            this.metroSetTabPage4.Controls.Add(this.EnableActiveClientHighlightCheckBox);
            this.metroSetTabPage4.Controls.Add(this.ShowThumbnailFramesCheckBox);
            this.metroSetTabPage4.Controls.Add(this.ShowThumbnailOverlaysCheckBox);
            this.metroSetTabPage4.ImageIndex = 0;
            this.metroSetTabPage4.ImageKey = null;
            this.metroSetTabPage4.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage4.Name = "metroSetTabPage4";
            this.metroSetTabPage4.Size = new System.Drawing.Size(352, 244);
            this.metroSetTabPage4.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTabPage4.StyleManager = null;
            this.metroSetTabPage4.TabIndex = 3;
            this.metroSetTabPage4.Text = "¸²¸Ç";
            this.metroSetTabPage4.ThemeAuthor = "Narwin";
            this.metroSetTabPage4.ThemeName = "MetroDark";
            this.metroSetTabPage4.ToolTipText = null;
            // 
            // ActiveClientHighlightColorButton
            // 
            this.ActiveClientHighlightColorButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActiveClientHighlightColorButton.Location = new System.Drawing.Point(41, 101);
            this.ActiveClientHighlightColorButton.Name = "ActiveClientHighlightColorButton";
            this.ActiveClientHighlightColorButton.Size = new System.Drawing.Size(93, 18);
            this.ActiveClientHighlightColorButton.TabIndex = 28;
            this.ActiveClientHighlightColorButton.Click += new System.EventHandler(this.ActiveClientHighlightColorButton_Click);
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.metroSetLabel5.Location = new System.Drawing.Point(9, 101);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(66, 18);
            this.metroSetLabel5.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 30;
            this.metroSetLabel5.Text = "ÑÕÉ«";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroDark";
            // 
            // EnableActiveClientHighlightCheckBox
            // 
            this.EnableActiveClientHighlightCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableActiveClientHighlightCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EnableActiveClientHighlightCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.EnableActiveClientHighlightCheckBox.Checked = false;
            this.EnableActiveClientHighlightCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EnableActiveClientHighlightCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.EnableActiveClientHighlightCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnableActiveClientHighlightCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.EnableActiveClientHighlightCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.EnableActiveClientHighlightCheckBox.Location = new System.Drawing.Point(9, 73);
            this.EnableActiveClientHighlightCheckBox.Name = "EnableActiveClientHighlightCheckBox";
            this.EnableActiveClientHighlightCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.EnableActiveClientHighlightCheckBox.Size = new System.Drawing.Size(250, 16);
            this.EnableActiveClientHighlightCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.EnableActiveClientHighlightCheckBox.StyleManager = null;
            this.EnableActiveClientHighlightCheckBox.TabIndex = 29;
            this.EnableActiveClientHighlightCheckBox.Text = "¼¤»î¿Í»§¶Ë¸ßÁÁ";
            this.EnableActiveClientHighlightCheckBox.ThemeAuthor = "Narwin";
            this.EnableActiveClientHighlightCheckBox.ThemeName = "MetroDark";
            this.EnableActiveClientHighlightCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // ShowThumbnailFramesCheckBox
            // 
            this.ShowThumbnailFramesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowThumbnailFramesCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ShowThumbnailFramesCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ShowThumbnailFramesCheckBox.Checked = false;
            this.ShowThumbnailFramesCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ShowThumbnailFramesCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.ShowThumbnailFramesCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowThumbnailFramesCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ShowThumbnailFramesCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.ShowThumbnailFramesCheckBox.Location = new System.Drawing.Point(9, 45);
            this.ShowThumbnailFramesCheckBox.Name = "ShowThumbnailFramesCheckBox";
            this.ShowThumbnailFramesCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.ShowThumbnailFramesCheckBox.Size = new System.Drawing.Size(250, 16);
            this.ShowThumbnailFramesCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.ShowThumbnailFramesCheckBox.StyleManager = null;
            this.ShowThumbnailFramesCheckBox.TabIndex = 28;
            this.ShowThumbnailFramesCheckBox.Text = "ÏÔÊ¾´°¿Ú±ß¿ò";
            this.ShowThumbnailFramesCheckBox.ThemeAuthor = "Narwin";
            this.ShowThumbnailFramesCheckBox.ThemeName = "MetroDark";
            this.ShowThumbnailFramesCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // ShowThumbnailOverlaysCheckBox
            // 
            this.ShowThumbnailOverlaysCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowThumbnailOverlaysCheckBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ShowThumbnailOverlaysCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ShowThumbnailOverlaysCheckBox.Checked = false;
            this.ShowThumbnailOverlaysCheckBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ShowThumbnailOverlaysCheckBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.ShowThumbnailOverlaysCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowThumbnailOverlaysCheckBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ShowThumbnailOverlaysCheckBox.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.ShowThumbnailOverlaysCheckBox.Location = new System.Drawing.Point(9, 18);
            this.ShowThumbnailOverlaysCheckBox.Name = "ShowThumbnailOverlaysCheckBox";
            this.ShowThumbnailOverlaysCheckBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.ShowThumbnailOverlaysCheckBox.Size = new System.Drawing.Size(250, 16);
            this.ShowThumbnailOverlaysCheckBox.Style = MetroSet_UI.Design.Style.Dark;
            this.ShowThumbnailOverlaysCheckBox.StyleManager = null;
            this.ShowThumbnailOverlaysCheckBox.TabIndex = 27;
            this.ShowThumbnailOverlaysCheckBox.Text = "ÏÔÊ¾µþ¼Ó";
            this.ShowThumbnailOverlaysCheckBox.ThemeAuthor = "Narwin";
            this.ShowThumbnailOverlaysCheckBox.ThemeName = "MetroDark";
            this.ShowThumbnailOverlaysCheckBox.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.Checked_handler);
            // 
            // metroSetTabPage5
            // 
            this.metroSetTabPage5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabPage5.Controls.Add(this.groupBox1);
            this.metroSetTabPage5.ImageIndex = 0;
            this.metroSetTabPage5.ImageKey = null;
            this.metroSetTabPage5.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage5.Name = "metroSetTabPage5";
            this.metroSetTabPage5.Size = new System.Drawing.Size(352, 244);
            this.metroSetTabPage5.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTabPage5.StyleManager = null;
            this.metroSetTabPage5.TabIndex = 4;
            this.metroSetTabPage5.Text = "¼¤»î¿Í»§¶Ë";
            this.metroSetTabPage5.ThemeAuthor = "Narwin";
            this.metroSetTabPage5.ThemeName = "MetroDark";
            this.metroSetTabPage5.ToolTipText = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ThumbnailsList);
            this.groupBox1.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¹´Ñ¡Ç¿ÖÆÒþ²Ø";
            // 
            // ThumbnailsList
            // 
            this.ThumbnailsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ThumbnailsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThumbnailsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ThumbnailsList.FormattingEnabled = true;
            this.ThumbnailsList.HorizontalScrollbar = true;
            this.ThumbnailsList.Location = new System.Drawing.Point(16, 29);
            this.ThumbnailsList.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ThumbnailsList.Name = "ThumbnailsList";
            this.ThumbnailsList.Size = new System.Drawing.Size(298, 144);
            this.ThumbnailsList.TabIndex = 0;
            this.ThumbnailsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ThumbnailsList_ItemCheck_Handler);
            // 
            // metroSetTabPage6
            // 
            this.metroSetTabPage6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabPage6.Controls.Add(this.DocumentationLink);
            this.metroSetTabPage6.Controls.Add(this.metroSetLabel7);
            this.metroSetTabPage6.Controls.Add(this.metroSetLabel6);
            this.metroSetTabPage6.ImageIndex = 0;
            this.metroSetTabPage6.ImageKey = null;
            this.metroSetTabPage6.Location = new System.Drawing.Point(4, 42);
            this.metroSetTabPage6.Name = "metroSetTabPage6";
            this.metroSetTabPage6.Size = new System.Drawing.Size(352, 244);
            this.metroSetTabPage6.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetTabPage6.StyleManager = null;
            this.metroSetTabPage6.TabIndex = 5;
            this.metroSetTabPage6.Text = "¹ØÓÚ";
            this.metroSetTabPage6.ThemeAuthor = "Narwin";
            this.metroSetTabPage6.ThemeName = "MetroDark";
            this.metroSetTabPage6.ToolTipText = null;
            // 
            // DocumentationLink
            // 
            this.DocumentationLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocumentationLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DocumentationLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.DocumentationLink.Location = new System.Drawing.Point(9, 214);
            this.DocumentationLink.Name = "DocumentationLink";
            this.DocumentationLink.Size = new System.Drawing.Size(233, 23);
            this.DocumentationLink.Style = MetroSet_UI.Design.Style.Dark;
            this.DocumentationLink.StyleManager = null;
            this.DocumentationLink.TabIndex = 33;
            this.DocumentationLink.TabStop = true;
            this.DocumentationLink.Text = "https://forum.eveonline.com/t/4202";
            this.DocumentationLink.ThemeAuthor = "Narwin";
            this.DocumentationLink.ThemeName = "MetroLite";
            this.DocumentationLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.DocumentationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DocumentationLinkClicked_Handler);
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.metroSetLabel7.Location = new System.Drawing.Point(9, 45);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(342, 192);
            this.metroSetLabel7.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 32;
            this.metroSetLabel7.Text = resources.GetString("metroSetLabel7.Text");
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroDark";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            this.metroSetLabel6.Location = new System.Drawing.Point(9, 18);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(330, 18);
            this.metroSetLabel6.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 31;
            this.metroSetLabel6.Text = "ºº»¯¼°UIÔÙÉè¼Æ NightCandle";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroDark";
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.TrayMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "EVE-O Preview";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RestoreMainForm_Handler);
            // 
            // TrayMenu
            // 
            this.TrayMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            TitleMenuItem,
            RestoreWindowMenuItem,
            SeparatorMenuItem,
            ExitMenuItem});
            this.TrayMenu.Name = "contextMenuStrip1";
            this.TrayMenu.Size = new System.Drawing.Size(162, 76);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.Location = new System.Drawing.Point(281, 45);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 7;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::EveOPreview.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 415);
            this.ControlBox = false;
            this.Controls.Add(MainTab);
            this.Controls.Add(this.metroSetControlBox1);
            this.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 13F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(11, 80, 11, 14);
            this.Style = MetroSet_UI.Design.Style.Dark;
            this.Text = "EVE-O Preview";
            this.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ThemeName = "MetroDark";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing_Handler);
            this.Load += new System.EventHandler(this.MainFormResize_Handler);
            this.Resize += new System.EventHandler(this.MainFormResize_Handler);
            MainTab.ResumeLayout(false);
            this.metroSetTabPage1.ResumeLayout(false);
            this.metroSetTabPage2.ResumeLayout(false);
            this.metroSetTabPage3.ResumeLayout(false);
            this.ZoomAnchorPanel.ResumeLayout(false);
            this.ZoomAnchorPanel.PerformLayout();
            this.metroSetTabPage4.ResumeLayout(false);
            this.metroSetTabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroSetTabPage6.ResumeLayout(false);
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private NotifyIcon NotifyIcon;
        private ContextMenuStrip TrayMenu;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage6;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage5;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage4;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage3;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage2;
        private MetroSet_UI.Controls.MetroSetTrackBar ThumbnailOpacityTrackBar;
        private new MetroSet_UI.Controls.MetroSetLabel Opacity;
        private MetroSet_UI.Child.MetroSetTabPage metroSetTabPage1;
        private MetroSet_UI.Controls.MetroSetCheckBox EnablePerClientThumbnailsLayoutsCheckBox;
        private MetroSet_UI.Controls.MetroSetCheckBox HideThumbnailsOnLostFocusCheckBox;
        private MetroSet_UI.Controls.MetroSetCheckBox ShowThumbnailsAlwaysOnTopCheckBox;
        private MetroSet_UI.Controls.MetroSetCheckBox MinimizeInactiveClientsCheckBox;
        private MetroSet_UI.Controls.MetroSetCheckBox HideActiveClientThumbnailCheckBox;
        private MetroSet_UI.Controls.MetroSetCheckBox EnableClientLayoutTrackingCheckBox;
        private MetroSet_UI.Controls.MetroSetCheckBox MinimizeToTrayCheckBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetNumeric ThumbnailsWidthNumericEdit;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetNumeric ThumbnailsHeightNumericEdit;
        private MetroSet_UI.Controls.MetroSetCheckBox EnableThumbnailZoomCheckBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetNumeric ThumbnailZoomFactorNumericEdit;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private Panel ZoomAnchorPanel;
        private RadioButton ZoomAanchorNWRadioButton;
        private RadioButton ZoomAanchorNRadioButton;
        private RadioButton ZoomAanchorNERadioButton;
        private RadioButton ZoomAanchorWRadioButton;
        private RadioButton ZoomAanchorSERadioButton;
        private RadioButton ZoomAanchorCRadioButton;
        private RadioButton ZoomAanchorSRadioButton;
        private RadioButton ZoomAanchorERadioButton;
        private RadioButton ZoomAanchorSWRadioButton;
        private MetroSet_UI.Controls.MetroSetCheckBox EnableActiveClientHighlightCheckBox;
        private MetroSet_UI.Controls.MetroSetCheckBox ShowThumbnailFramesCheckBox;
        private MetroSet_UI.Controls.MetroSetCheckBox ShowThumbnailOverlaysCheckBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private Panel ActiveClientHighlightColorButton;
        private GroupBox groupBox1;
        private CheckedListBox ThumbnailsList;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLink DocumentationLink;
    }
}