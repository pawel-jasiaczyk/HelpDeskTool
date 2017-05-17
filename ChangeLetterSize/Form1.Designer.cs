namespace ChangeLetterSize
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonToLuwer = new System.Windows.Forms.Button();
            this.buttonToUpper = new System.Windows.Forms.Button();
            this.textBoxCharacterCounter = new System.Windows.Forms.TextBox();
            this.labelCharacterCounter = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonTest = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonTest2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelPicureBox = new System.Windows.Forms.Panel();
            this.listViewWords = new System.Windows.Forms.ListView();
            this.readTextButton = new System.Windows.Forms.Button();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.tabControlPicText = new System.Windows.Forms.TabControl();
            this.tabPagePicText = new System.Windows.Forms.TabPage();
            this.tabPageWordList = new System.Windows.Forms.TabPage();
            this.textBoxPicText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelPicureBox.SuspendLayout();
            this.tabControlPicText.SuspendLayout();
            this.tabPagePicText.SuspendLayout();
            this.tabPageWordList.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSource.Location = new System.Drawing.Point(6, 6);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(389, 20);
            this.textBoxSource.TabIndex = 0;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(6, 61);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(389, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // buttonToLuwer
            // 
            this.buttonToLuwer.Location = new System.Drawing.Point(6, 32);
            this.buttonToLuwer.Name = "buttonToLuwer";
            this.buttonToLuwer.Size = new System.Drawing.Size(75, 23);
            this.buttonToLuwer.TabIndex = 2;
            this.buttonToLuwer.Text = "ToLower( )";
            this.buttonToLuwer.UseVisualStyleBackColor = true;
            this.buttonToLuwer.Click += new System.EventHandler(this.buttonToLower_Click);
            // 
            // buttonToUpper
            // 
            this.buttonToUpper.Location = new System.Drawing.Point(87, 32);
            this.buttonToUpper.Name = "buttonToUpper";
            this.buttonToUpper.Size = new System.Drawing.Size(75, 23);
            this.buttonToUpper.TabIndex = 3;
            this.buttonToUpper.Text = "ToUpper( )";
            this.buttonToUpper.UseVisualStyleBackColor = true;
            this.buttonToUpper.Click += new System.EventHandler(this.buttonToUpper_Click);
            // 
            // textBoxCharacterCounter
            // 
            this.textBoxCharacterCounter.Location = new System.Drawing.Point(289, 32);
            this.textBoxCharacterCounter.Name = "textBoxCharacterCounter";
            this.textBoxCharacterCounter.ReadOnly = true;
            this.textBoxCharacterCounter.Size = new System.Drawing.Size(35, 20);
            this.textBoxCharacterCounter.TabIndex = 4;
            // 
            // labelCharacterCounter
            // 
            this.labelCharacterCounter.AutoSize = true;
            this.labelCharacterCounter.Location = new System.Drawing.Point(168, 37);
            this.labelCharacterCounter.Name = "labelCharacterCounter";
            this.labelCharacterCounter.Size = new System.Drawing.Size(115, 13);
            this.labelCharacterCounter.TabIndex = 5;
            this.labelCharacterCounter.Text = "Number of characters :";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "StringOperator";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // buttonTest
            // 
            this.buttonTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTest.Location = new System.Drawing.Point(671, 7);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 6;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Visible = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(511, 367);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // buttonTest2
            // 
            this.buttonTest2.Location = new System.Drawing.Point(6, 6);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(75, 23);
            this.buttonTest2.TabIndex = 8;
            this.buttonTest2.Text = "Marker";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 439);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxSource);
            this.tabPage1.Controls.Add(this.buttonToLuwer);
            this.tabPage1.Controls.Add(this.buttonToUpper);
            this.tabPage1.Controls.Add(this.labelCharacterCounter);
            this.tabPage1.Controls.Add(this.textBoxResult);
            this.tabPage1.Controls.Add(this.textBoxCharacterCounter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Strings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.saveImageButton);
            this.tabPage2.Controls.Add(this.readTextButton);
            this.tabPage2.Controls.Add(this.splitContainer);
            this.tabPage2.Controls.Add(this.buttonTest);
            this.tabPage2.Controls.Add(this.buttonTest2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(3, 35);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelPicureBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControlPicText);
            this.splitContainer.Size = new System.Drawing.Size(748, 375);
            this.splitContainer.SplitterDistance = 551;
            this.splitContainer.TabIndex = 10;
            // 
            // panelPicureBox
            // 
            this.panelPicureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPicureBox.AutoScroll = true;
            this.panelPicureBox.Controls.Add(this.pictureBox);
            this.panelPicureBox.Location = new System.Drawing.Point(3, 3);
            this.panelPicureBox.Name = "panelPicureBox";
            this.panelPicureBox.Size = new System.Drawing.Size(511, 367);
            this.panelPicureBox.TabIndex = 9;
            // 
            // listViewWords
            // 
            this.listViewWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewWords.Location = new System.Drawing.Point(3, 3);
            this.listViewWords.Name = "listViewWords";
            this.listViewWords.Size = new System.Drawing.Size(196, 299);
            this.listViewWords.TabIndex = 0;
            this.listViewWords.UseCompatibleStateImageBehavior = false;
            // 
            // readTextButton
            // 
            this.readTextButton.Enabled = false;
            this.readTextButton.Location = new System.Drawing.Point(87, 6);
            this.readTextButton.Name = "readTextButton";
            this.readTextButton.Size = new System.Drawing.Size(75, 23);
            this.readTextButton.TabIndex = 11;
            this.readTextButton.Text = "Read Text";
            this.readTextButton.UseVisualStyleBackColor = true;
            this.readTextButton.Click += new System.EventHandler(this.readTextButton_Click);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Enabled = false;
            this.saveImageButton.Location = new System.Drawing.Point(168, 6);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(75, 23);
            this.saveImageButton.TabIndex = 12;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // tabControlPicText
            // 
            this.tabControlPicText.Controls.Add(this.tabPagePicText);
            this.tabControlPicText.Controls.Add(this.tabPageWordList);
            this.tabControlPicText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPicText.Location = new System.Drawing.Point(0, 0);
            this.tabControlPicText.Name = "tabControlPicText";
            this.tabControlPicText.SelectedIndex = 0;
            this.tabControlPicText.Size = new System.Drawing.Size(191, 373);
            this.tabControlPicText.TabIndex = 1;
            // 
            // tabPagePicText
            // 
            this.tabPagePicText.Controls.Add(this.textBoxPicText);
            this.tabPagePicText.Location = new System.Drawing.Point(4, 22);
            this.tabPagePicText.Name = "tabPagePicText";
            this.tabPagePicText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePicText.Size = new System.Drawing.Size(183, 347);
            this.tabPagePicText.TabIndex = 0;
            this.tabPagePicText.Text = "Readed  Text";
            this.tabPagePicText.UseVisualStyleBackColor = true;
            // 
            // tabPageWordList
            // 
            this.tabPageWordList.Controls.Add(this.listViewWords);
            this.tabPageWordList.Location = new System.Drawing.Point(4, 22);
            this.tabPageWordList.Name = "tabPageWordList";
            this.tabPageWordList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWordList.Size = new System.Drawing.Size(202, 305);
            this.tabPageWordList.TabIndex = 1;
            this.tabPageWordList.Text = "Word List";
            this.tabPageWordList.UseVisualStyleBackColor = true;
            // 
            // textBoxPicText
            // 
            this.textBoxPicText.BackColor = System.Drawing.Color.White;
            this.textBoxPicText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPicText.Location = new System.Drawing.Point(3, 3);
            this.textBoxPicText.Multiline = true;
            this.textBoxPicText.Name = "textBoxPicText";
            this.textBoxPicText.ReadOnly = true;
            this.textBoxPicText.Size = new System.Drawing.Size(177, 341);
            this.textBoxPicText.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 439);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "StringOperator";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelPicureBox.ResumeLayout(false);
            this.panelPicureBox.PerformLayout();
            this.tabControlPicText.ResumeLayout(false);
            this.tabPagePicText.ResumeLayout(false);
            this.tabPagePicText.PerformLayout();
            this.tabPageWordList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonToLuwer;
        private System.Windows.Forms.Button buttonToUpper;
        private System.Windows.Forms.TextBox textBoxCharacterCounter;
        private System.Windows.Forms.Label labelCharacterCounter;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonTest2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelPicureBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView listViewWords;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button readTextButton;
        private System.Windows.Forms.TabControl tabControlPicText;
        private System.Windows.Forms.TabPage tabPagePicText;
        private System.Windows.Forms.TextBox textBoxPicText;
        private System.Windows.Forms.TabPage tabPageWordList;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

