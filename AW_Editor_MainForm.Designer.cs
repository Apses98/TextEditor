namespace TextEditor
{
    partial class AW_Editor_MainForm
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
            this.main_richTextBox = new System.Windows.Forms.RichTextBox();
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.zOOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.documentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAWEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSaveModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomBar_menuStrip = new System.Windows.Forms.MenuStrip();
            this.wordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.charactersExcludingSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.numberOfLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menuStrip.SuspendLayout();
            this.bottomBar_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_richTextBox
            // 
            this.main_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_richTextBox.Location = new System.Drawing.Point(0, 24);
            this.main_richTextBox.Name = "main_richTextBox";
            this.main_richTextBox.Size = new System.Drawing.Size(484, 357);
            this.main_richTextBox.TabIndex = 0;
            this.main_richTextBox.Text = "";
            this.main_richTextBox.TextChanged += new System.EventHandler(this.Event_richtextbox_event_textChanged);
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.autoSaveModeToolStripMenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Size = new System.Drawing.Size(484, 24);
            this.main_menuStrip.TabIndex = 1;
            this.main_menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "New ";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenModeToolStripMenuItem,
            this.darkModeToolStripMenuItem,
            this.toolStripMenuItem3,
            this.zOOMToolStripMenuItem,
            this.toolStripMenuItem4,
            this.documentInformationToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // fullscreenModeToolStripMenuItem
            // 
            this.fullscreenModeToolStripMenuItem.Name = "fullscreenModeToolStripMenuItem";
            this.fullscreenModeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.fullscreenModeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.fullscreenModeToolStripMenuItem.Text = "Fullscreen Mode";
            this.fullscreenModeToolStripMenuItem.Click += new System.EventHandler(this.fullscreenModeToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.darkModeToolStripMenuItem.Text = "Enable Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(209, 6);
            // 
            // zOOMToolStripMenuItem
            // 
            this.zOOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.zOOMToolStripMenuItem.Name = "zOOMToolStripMenuItem";
            this.zOOMToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.zOOMToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Plus";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom in";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Minus";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(209, 6);
            // 
            // documentInformationToolStripMenuItem
            // 
            this.documentInformationToolStripMenuItem.Checked = true;
            this.documentInformationToolStripMenuItem.CheckOnClick = true;
            this.documentInformationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.documentInformationToolStripMenuItem.Name = "documentInformationToolStripMenuItem";
            this.documentInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.documentInformationToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.documentInformationToolStripMenuItem.Text = "Hide info bar";
            this.documentInformationToolStripMenuItem.Click += new System.EventHandler(this.documentInformationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAWEditorToolStripMenuItem,
            this.toolStripMenuItem5,
            this.feedbackToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutAWEditorToolStripMenuItem
            // 
            this.aboutAWEditorToolStripMenuItem.Name = "aboutAWEditorToolStripMenuItem";
            this.aboutAWEditorToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aboutAWEditorToolStripMenuItem.Text = "About AW-Editor.";
            this.aboutAWEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutAWEditorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(164, 6);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // autoSaveModeToolStripMenuItem
            // 
            this.autoSaveModeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.autoSaveModeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.autoSaveModeToolStripMenuItem.Name = "autoSaveModeToolStripMenuItem";
            this.autoSaveModeToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.autoSaveModeToolStripMenuItem.Text = "AutoSave Mode: off";
            this.autoSaveModeToolStripMenuItem.Click += new System.EventHandler(this.autoSaveModeToolStripMenuItem_Click);
            // 
            // bottomBar_menuStrip
            // 
            this.bottomBar_menuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordsToolStripMenuItem});
            this.bottomBar_menuStrip.Location = new System.Drawing.Point(0, 381);
            this.bottomBar_menuStrip.Name = "bottomBar_menuStrip";
            this.bottomBar_menuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 50, 2);
            this.bottomBar_menuStrip.Size = new System.Drawing.Size(484, 24);
            this.bottomBar_menuStrip.TabIndex = 2;
            this.bottomBar_menuStrip.Text = "menuStrip1";
            // 
            // wordsToolStripMenuItem
            // 
            this.wordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordsToolStripMenuItem1,
            this.toolStripMenuItem8,
            this.charactersExcludingSpacesToolStripMenuItem,
            this.toolStripMenuItem7,
            this.charactersToolStripMenuItem,
            this.toolStripMenuItem6,
            this.numberOfLinesToolStripMenuItem});
            this.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem";
            this.wordsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.wordsToolStripMenuItem.Size = new System.Drawing.Size(250, 20);
            this.wordsToolStripMenuItem.Text = "0 Word(s) <-- Press here to show more info.";
            // 
            // wordsToolStripMenuItem1
            // 
            this.wordsToolStripMenuItem1.Name = "wordsToolStripMenuItem1";
            this.wordsToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.wordsToolStripMenuItem1.Text = "0 Word(s)";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(216, 6);
            // 
            // charactersExcludingSpacesToolStripMenuItem
            // 
            this.charactersExcludingSpacesToolStripMenuItem.Name = "charactersExcludingSpacesToolStripMenuItem";
            this.charactersExcludingSpacesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.charactersExcludingSpacesToolStripMenuItem.Text = "0 Character(s)";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(216, 6);
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.charactersToolStripMenuItem.Text = "0 Character(s) (with spaces)";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(216, 6);
            // 
            // numberOfLinesToolStripMenuItem
            // 
            this.numberOfLinesToolStripMenuItem.Name = "numberOfLinesToolStripMenuItem";
            this.numberOfLinesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.numberOfLinesToolStripMenuItem.Text = "0 Line(s)";
            // 
            // AW_Editor_MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 405);
            this.Controls.Add(this.main_richTextBox);
            this.Controls.Add(this.main_menuStrip);
            this.Controls.Add(this.bottomBar_menuStrip);
            this.MainMenuStrip = this.main_menuStrip;
            this.Name = "AW_Editor_MainForm";
            this.Text = "Nameless.txt - AW-Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AW_Editor_MainForm_FormClosing);
            this.Load += new System.EventHandler(this.AW_Editor_MainForm_Load);
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            this.bottomBar_menuStrip.ResumeLayout(false);
            this.bottomBar_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox main_richTextBox;
        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem zOOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem documentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAWEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem fullscreenModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSaveModeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip bottomBar_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem charactersExcludingSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem numberOfLinesToolStripMenuItem;
    }
}

