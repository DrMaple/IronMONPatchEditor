using System.Windows.Forms;

namespace IronMONPatchEditor
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadROM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReadme = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLoadedROM = new System.Windows.Forms.Label();
            this.fileInfoBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.genderChoiceGroup = new System.Windows.Forms.GroupBox();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.rivalNameTextBox = new System.Windows.Forms.TextBox();
            this.rivalNameLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerNameSizeWarning = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.stepItemsBox = new System.Windows.Forms.GroupBox();
            this.radioItemsRNG = new System.Windows.Forms.RadioButton();
            this.radioItemsOn = new System.Windows.Forms.RadioButton();
            this.instaPCBox = new System.Windows.Forms.GroupBox();
            this.instaPCOff = new System.Windows.Forms.RadioButton();
            this.instaPCOn = new System.Windows.Forms.RadioButton();
            this.speechSkipBox = new System.Windows.Forms.GroupBox();
            this.speechSkipButtonOn = new System.Windows.Forms.RadioButton();
            this.speechSkipButtonOff = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.fileInfoBox.SuspendLayout();
            this.genderChoiceGroup.SuspendLayout();
            this.nameGroupBox.SuspendLayout();
            this.stepItemsBox.SuspendLayout();
            this.instaPCBox.SuspendLayout();
            this.speechSkipBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(315, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadROM,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnLoadROM
            // 
            this.btnLoadROM.Name = "btnLoadROM";
            this.btnLoadROM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnLoadROM.Size = new System.Drawing.Size(173, 22);
            this.btnLoadROM.Text = "Load ROM";
            this.btnLoadROM.Click += new System.EventHandler(this.BtnLoadROM_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(173, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.btnExit.Size = new System.Drawing.Size(173, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout,
            this.btnReadme});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(136, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnReadme
            // 
            this.btnReadme.Name = "btnReadme";
            this.btnReadme.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.btnReadme.Size = new System.Drawing.Size(136, 22);
            this.btnReadme.Text = "Readme";
            this.btnReadme.Click += new System.EventHandler(this.BtnReadme_Click);
            // 
            // labelLoadedROM
            // 
            this.labelLoadedROM.AutoSize = true;
            this.labelLoadedROM.Location = new System.Drawing.Point(6, 16);
            this.labelLoadedROM.Name = "labelLoadedROM";
            this.labelLoadedROM.Size = new System.Drawing.Size(64, 13);
            this.labelLoadedROM.TabIndex = 1;
            this.labelLoadedROM.Text = "ROM: None";
            // 
            // fileInfoBox
            // 
            this.fileInfoBox.Controls.Add(this.labelLoadedROM);
            this.fileInfoBox.Location = new System.Drawing.Point(12, 28);
            this.fileInfoBox.Name = "fileInfoBox";
            this.fileInfoBox.Size = new System.Drawing.Size(288, 39);
            this.fileInfoBox.TabIndex = 2;
            this.fileInfoBox.TabStop = false;
            this.fileInfoBox.Text = "File Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Created by DrMaple | ";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(114, 228);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(38, 13);
            this.linkLabelGithub.TabIndex = 16;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "Github";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGithub_LinkClicked);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 20);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 17;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(6, 44);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 18;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // genderChoiceGroup
            // 
            this.genderChoiceGroup.Controls.Add(this.radioButtonMale);
            this.genderChoiceGroup.Controls.Add(this.radioButtonFemale);
            this.genderChoiceGroup.Enabled = false;
            this.genderChoiceGroup.Location = new System.Drawing.Point(225, 74);
            this.genderChoiceGroup.Name = "genderChoiceGroup";
            this.genderChoiceGroup.Size = new System.Drawing.Size(74, 73);
            this.genderChoiceGroup.TabIndex = 19;
            this.genderChoiceGroup.TabStop = false;
            this.genderChoiceGroup.Text = "Gender";
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.rivalNameTextBox);
            this.nameGroupBox.Controls.Add(this.rivalNameLabel);
            this.nameGroupBox.Controls.Add(this.playerNameLabel);
            this.nameGroupBox.Controls.Add(this.playerNameSizeWarning);
            this.nameGroupBox.Controls.Add(this.playerNameTextBox);
            this.nameGroupBox.Enabled = false;
            this.nameGroupBox.Location = new System.Drawing.Point(92, 152);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(208, 73);
            this.nameGroupBox.TabIndex = 20;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Names";
            // 
            // rivalNameTextBox
            // 
            this.rivalNameTextBox.Location = new System.Drawing.Point(106, 32);
            this.rivalNameTextBox.MaxLength = 7;
            this.rivalNameTextBox.Name = "rivalNameTextBox";
            this.rivalNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.rivalNameTextBox.TabIndex = 4;
            // 
            // rivalNameLabel
            // 
            this.rivalNameLabel.AutoSize = true;
            this.rivalNameLabel.Location = new System.Drawing.Point(103, 16);
            this.rivalNameLabel.Name = "rivalNameLabel";
            this.rivalNameLabel.Size = new System.Drawing.Size(62, 13);
            this.rivalNameLabel.TabIndex = 3;
            this.rivalNameLabel.Text = "Rival Name";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(6, 16);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.playerNameLabel.TabIndex = 2;
            this.playerNameLabel.Text = "Player Name";
            // 
            // playerNameSizeWarning
            // 
            this.playerNameSizeWarning.AutoSize = true;
            this.playerNameSizeWarning.Location = new System.Drawing.Point(3, 55);
            this.playerNameSizeWarning.Name = "playerNameSizeWarning";
            this.playerNameSizeWarning.Size = new System.Drawing.Size(175, 13);
            this.playerNameSizeWarning.TabIndex = 1;
            this.playerNameSizeWarning.Text = "Names must be 7 or less characters";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(6, 32);
            this.playerNameTextBox.MaxLength = 7;
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.playerNameTextBox.TabIndex = 0;
            // 
            // stepItemsBox
            // 
            this.stepItemsBox.Controls.Add(this.radioItemsRNG);
            this.stepItemsBox.Controls.Add(this.radioItemsOn);
            this.stepItemsBox.Enabled = false;
            this.stepItemsBox.Location = new System.Drawing.Point(12, 152);
            this.stepItemsBox.Name = "stepItemsBox";
            this.stepItemsBox.Size = new System.Drawing.Size(74, 73);
            this.stepItemsBox.TabIndex = 21;
            this.stepItemsBox.TabStop = false;
            this.stepItemsBox.Text = "Step Items";
            // 
            // radioItemsRNG
            // 
            this.radioItemsRNG.AutoSize = true;
            this.radioItemsRNG.Location = new System.Drawing.Point(6, 42);
            this.radioItemsRNG.Name = "radioItemsRNG";
            this.radioItemsRNG.Size = new System.Drawing.Size(65, 17);
            this.radioItemsRNG.TabIndex = 1;
            this.radioItemsRNG.TabStop = true;
            this.radioItemsRNG.Text = "Random";
            this.radioItemsRNG.UseVisualStyleBackColor = true;
            // 
            // radioItemsOn
            // 
            this.radioItemsOn.AutoSize = true;
            this.radioItemsOn.Location = new System.Drawing.Point(6, 19);
            this.radioItemsOn.Name = "radioItemsOn";
            this.radioItemsOn.Size = new System.Drawing.Size(58, 17);
            this.radioItemsOn.TabIndex = 0;
            this.radioItemsOn.TabStop = true;
            this.radioItemsOn.Text = "Always";
            this.radioItemsOn.UseVisualStyleBackColor = true;
            // 
            // instaPCBox
            // 
            this.instaPCBox.Controls.Add(this.instaPCOff);
            this.instaPCBox.Controls.Add(this.instaPCOn);
            this.instaPCBox.Enabled = false;
            this.instaPCBox.Location = new System.Drawing.Point(12, 73);
            this.instaPCBox.Name = "instaPCBox";
            this.instaPCBox.Size = new System.Drawing.Size(112, 73);
            this.instaPCBox.TabIndex = 22;
            this.instaPCBox.TabStop = false;
            this.instaPCBox.Text = "Instant PokeCenter";
            // 
            // instaPCOff
            // 
            this.instaPCOff.AutoSize = true;
            this.instaPCOff.Location = new System.Drawing.Point(9, 44);
            this.instaPCOff.Name = "instaPCOff";
            this.instaPCOff.Size = new System.Drawing.Size(58, 17);
            this.instaPCOff.TabIndex = 1;
            this.instaPCOff.TabStop = true;
            this.instaPCOff.Text = "Normal";
            this.instaPCOff.UseVisualStyleBackColor = true;
            // 
            // instaPCOn
            // 
            this.instaPCOn.AutoSize = true;
            this.instaPCOn.Location = new System.Drawing.Point(9, 20);
            this.instaPCOn.Name = "instaPCOn";
            this.instaPCOn.Size = new System.Drawing.Size(96, 17);
            this.instaPCOn.TabIndex = 0;
            this.instaPCOn.TabStop = true;
            this.instaPCOn.Text = "Instant Healing";
            this.instaPCOn.UseVisualStyleBackColor = true;
            // 
            // speechSkipBox
            // 
            this.speechSkipBox.Controls.Add(this.speechSkipButtonOn);
            this.speechSkipBox.Controls.Add(this.speechSkipButtonOff);
            this.speechSkipBox.Enabled = false;
            this.speechSkipBox.Location = new System.Drawing.Point(130, 74);
            this.speechSkipBox.Name = "speechSkipBox";
            this.speechSkipBox.Size = new System.Drawing.Size(89, 72);
            this.speechSkipBox.TabIndex = 23;
            this.speechSkipBox.TabStop = false;
            this.speechSkipBox.Text = "Speech Skip";
            // 
            // speechSkipButtonOn
            // 
            this.speechSkipButtonOn.AutoSize = true;
            this.speechSkipButtonOn.Location = new System.Drawing.Point(6, 19);
            this.speechSkipButtonOn.Name = "speechSkipButtonOn";
            this.speechSkipButtonOn.Size = new System.Drawing.Size(46, 17);
            this.speechSkipButtonOn.TabIndex = 1;
            this.speechSkipButtonOn.TabStop = true;
            this.speechSkipButtonOn.Text = "Skip";
            this.speechSkipButtonOn.UseVisualStyleBackColor = true;
            // 
            // speechSkipButtonOff
            // 
            this.speechSkipButtonOff.AutoSize = true;
            this.speechSkipButtonOff.Location = new System.Drawing.Point(6, 43);
            this.speechSkipButtonOff.Name = "speechSkipButtonOff";
            this.speechSkipButtonOff.Size = new System.Drawing.Size(58, 17);
            this.speechSkipButtonOff.TabIndex = 0;
            this.speechSkipButtonOff.TabStop = true;
            this.speechSkipButtonOff.Text = "Normal";
            this.speechSkipButtonOff.UseVisualStyleBackColor = true;
            this.speechSkipButtonOff.CheckedChanged += new System.EventHandler(this.SpeechSkipButtonOff_CheckedChanged);
            // 
            // MainScreen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 246);
            this.Controls.Add(this.speechSkipBox);
            this.Controls.Add(this.instaPCBox);
            this.Controls.Add(this.stepItemsBox);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.genderChoiceGroup);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileInfoBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "IronMON Patch Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fileInfoBox.ResumeLayout(false);
            this.fileInfoBox.PerformLayout();
            this.genderChoiceGroup.ResumeLayout(false);
            this.genderChoiceGroup.PerformLayout();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.stepItemsBox.ResumeLayout(false);
            this.stepItemsBox.PerformLayout();
            this.instaPCBox.ResumeLayout(false);
            this.instaPCBox.PerformLayout();
            this.speechSkipBox.ResumeLayout(false);
            this.speechSkipBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLoadROM;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Label labelLoadedROM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.GroupBox fileInfoBox;
        private System.Windows.Forms.ToolStripMenuItem btnReadme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.GroupBox genderChoiceGroup;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameSizeWarning;
        private System.Windows.Forms.TextBox rivalNameTextBox;
        private System.Windows.Forms.Label rivalNameLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.GroupBox stepItemsBox;
        private System.Windows.Forms.RadioButton radioItemsRNG;
        private System.Windows.Forms.RadioButton radioItemsOn;
        private System.Windows.Forms.GroupBox instaPCBox;
        private System.Windows.Forms.RadioButton instaPCOff;
        private System.Windows.Forms.RadioButton instaPCOn;
        private GroupBox speechSkipBox;
        private RadioButton speechSkipButtonOn;
        private RadioButton speechSkipButtonOff;
    }
}

