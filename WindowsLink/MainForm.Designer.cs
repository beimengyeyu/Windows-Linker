namespace SymbolicLink
{
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SymbolicLink.MainForm));
			this.targetPickButton_ = new global::System.Windows.Forms.Button();
			this.linkPickButton_ = new global::System.Windows.Forms.Button();
			this.targetBox_ = new global::System.Windows.Forms.TextBox();
			this.targetGroup_ = new global::System.Windows.Forms.GroupBox();
			this.linkGroup_ = new global::System.Windows.Forms.GroupBox();
			this.linkBox_ = new global::System.Windows.Forms.TextBox();
			this.doCreateLink_ = new global::System.Windows.Forms.Button();
			this.linkType_File_ = new global::System.Windows.Forms.RadioButton();
			this.linkType_Folder_ = new global::System.Windows.Forms.RadioButton();
			this.linkTypeGroup_ = new global::System.Windows.Forms.GroupBox();
			this.isHardLinkBox_ = new global::System.Windows.Forms.CheckBox();
			this.targetGroup_.SuspendLayout();
			this.linkGroup_.SuspendLayout();
			this.linkTypeGroup_.SuspendLayout();
			base.SuspendLayout();
			this.targetPickButton_.Location = new global::System.Drawing.Point(425, 16);
			this.targetPickButton_.Name = "targetPickButton_";
			this.targetPickButton_.Size = new global::System.Drawing.Size(90, 23);
			this.targetPickButton_.TabIndex = 0;
			this.targetPickButton_.Text = "Select &Target";
			this.targetPickButton_.UseVisualStyleBackColor = true;
			this.targetPickButton_.Click += new global::System.EventHandler(this.fileTargetPickButton__Click);
			this.linkPickButton_.Location = new global::System.Drawing.Point(425, 16);
			this.linkPickButton_.Name = "linkPickButton_";
			this.linkPickButton_.Size = new global::System.Drawing.Size(90, 23);
			this.linkPickButton_.TabIndex = 1;
			this.linkPickButton_.Text = "Select &File";
			this.linkPickButton_.UseVisualStyleBackColor = true;
			this.linkPickButton_.Click += new global::System.EventHandler(this.fileLinkPickButton__Click);
			this.targetBox_.Location = new global::System.Drawing.Point(6, 19);
			this.targetBox_.Name = "targetBox_";
			this.targetBox_.ReadOnly = true;
			this.targetBox_.Size = new global::System.Drawing.Size(413, 20);
			this.targetBox_.TabIndex = 2;
			this.targetBox_.TextChanged += new global::System.EventHandler(this.targetBox__TextChanged);
			this.targetGroup_.Controls.Add(this.targetBox_);
			this.targetGroup_.Controls.Add(this.targetPickButton_);
			this.targetGroup_.Location = new global::System.Drawing.Point(12, 55);
			this.targetGroup_.Name = "targetGroup_";
			this.targetGroup_.Size = new global::System.Drawing.Size(521, 45);
			this.targetGroup_.TabIndex = 3;
			this.targetGroup_.TabStop = false;
			this.targetGroup_.Text = "Link Target :";
			this.linkGroup_.Controls.Add(this.linkBox_);
			this.linkGroup_.Controls.Add(this.linkPickButton_);
			this.linkGroup_.Location = new global::System.Drawing.Point(12, 106);
			this.linkGroup_.Name = "linkGroup_";
			this.linkGroup_.Size = new global::System.Drawing.Size(521, 45);
			this.linkGroup_.TabIndex = 4;
			this.linkGroup_.TabStop = false;
			this.linkGroup_.Text = "Link File:";
			this.linkBox_.Location = new global::System.Drawing.Point(6, 19);
			this.linkBox_.Name = "linkBox_";
			this.linkBox_.ReadOnly = true;
			this.linkBox_.Size = new global::System.Drawing.Size(413, 20);
			this.linkBox_.TabIndex = 2;
			this.linkBox_.TextChanged += new global::System.EventHandler(this.linkBox__TextChanged);
			this.doCreateLink_.Enabled = false;
			this.doCreateLink_.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.doCreateLink_.Location = new global::System.Drawing.Point(233, 157);
			this.doCreateLink_.Name = "doCreateLink_";
			this.doCreateLink_.Size = new global::System.Drawing.Size(90, 23);
			this.doCreateLink_.TabIndex = 5;
			this.doCreateLink_.Text = "Make Link";
			this.doCreateLink_.UseVisualStyleBackColor = true;
			this.doCreateLink_.Click += new global::System.EventHandler(this.doCreateLink__Click);
			this.linkType_File_.AutoSize = true;
			this.linkType_File_.Checked = true;
			this.linkType_File_.Location = new global::System.Drawing.Point(6, 19);
			this.linkType_File_.Name = "linkType_File_";
			this.linkType_File_.Size = new global::System.Drawing.Size(64, 17);
			this.linkType_File_.TabIndex = 7;
			this.linkType_File_.TabStop = true;
			this.linkType_File_.Text = "File Link";
			this.linkType_File_.UseVisualStyleBackColor = true;
			this.linkType_File_.CheckedChanged += new global::System.EventHandler(this.linkType__CheckedChanged);
			this.linkType_Folder_.AutoSize = true;
			this.linkType_Folder_.Location = new global::System.Drawing.Point(85, 19);
			this.linkType_Folder_.Name = "linkType_Folder_";
			this.linkType_Folder_.Size = new global::System.Drawing.Size(95, 17);
			this.linkType_Folder_.TabIndex = 8;
			this.linkType_Folder_.Text = "Directory Link";
			this.linkType_Folder_.UseVisualStyleBackColor = true;
			this.linkType_Folder_.CheckedChanged += new global::System.EventHandler(this.linkType__CheckedChanged);
			this.linkTypeGroup_.Controls.Add(this.linkType_File_);
			this.linkTypeGroup_.Controls.Add(this.linkType_Folder_);
			this.linkTypeGroup_.Location = new global::System.Drawing.Point(12, 7);
			this.linkTypeGroup_.Name = "linkTypeGroup_";
			this.linkTypeGroup_.Size = new global::System.Drawing.Size(200, 42);
			this.linkTypeGroup_.TabIndex = 9;
			this.linkTypeGroup_.TabStop = false;
			this.linkTypeGroup_.Text = "LinkType";
			this.isHardLinkBox_.AutoSize = true;
			this.isHardLinkBox_.Location = new global::System.Drawing.Point(218, 26);
			this.isHardLinkBox_.Name = "isHardLinkBox_";
			this.isHardLinkBox_.Size = new global::System.Drawing.Size(72, 17);
			this.isHardLinkBox_.TabIndex = 10;
			this.isHardLinkBox_.Text = "Hard Link";
			this.isHardLinkBox_.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(557, 187);
			base.Controls.Add(this.isHardLinkBox_);
			base.Controls.Add(this.linkTypeGroup_);
			base.Controls.Add(this.targetGroup_);
			base.Controls.Add(this.doCreateLink_);
			base.Controls.Add(this.linkGroup_);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "MainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Windows Linker";
			this.targetGroup_.ResumeLayout(false);
			this.targetGroup_.PerformLayout();
			this.linkGroup_.ResumeLayout(false);
			this.linkGroup_.PerformLayout();
			this.linkTypeGroup_.ResumeLayout(false);
			this.linkTypeGroup_.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		
		private global::System.Windows.Forms.Button targetPickButton_;

		private global::System.Windows.Forms.Button linkPickButton_;

		private global::System.Windows.Forms.TextBox targetBox_;

		private global::System.Windows.Forms.GroupBox targetGroup_;

		private global::System.Windows.Forms.GroupBox linkGroup_;

		private global::System.Windows.Forms.TextBox linkBox_;

		private global::System.Windows.Forms.Button doCreateLink_;

		private global::System.Windows.Forms.RadioButton linkType_File_;
		
		private global::System.Windows.Forms.RadioButton linkType_Folder_;
		
		private global::System.Windows.Forms.GroupBox linkTypeGroup_;
		
		private global::System.Windows.Forms.CheckBox isHardLinkBox_;
	}
}
