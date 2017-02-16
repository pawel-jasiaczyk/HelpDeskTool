namespace ChangeLetterSize
{
    partial class Marker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marker));
            this.buttonScreenShot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonScreenShot
            // 
            this.buttonScreenShot.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonScreenShot.Image = ((System.Drawing.Image)(resources.GetObject("buttonScreenShot.Image")));
            this.buttonScreenShot.Location = new System.Drawing.Point(326, 0);
            this.buttonScreenShot.Name = "buttonScreenShot";
            this.buttonScreenShot.Size = new System.Drawing.Size(75, 312);
            this.buttonScreenShot.TabIndex = 0;
            this.buttonScreenShot.UseVisualStyleBackColor = true;
            this.buttonScreenShot.Click += new System.EventHandler(this.buttonScreenShot_Click);
            // 
            // Marker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 312);
            this.ControlBox = false;
            this.Controls.Add(this.buttonScreenShot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Marker";
            this.Opacity = 0.6D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Marker";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Marker_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Marker_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Marker_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScreenShot;
    }
}