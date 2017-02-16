using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ChangeLetterSize
{
    public partial class Marker : Form
    {
        private Form1 parent;
        // private Timer timer;
        // private bool move;
        private ContextMenu cm;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        // private Point currentCursorPosition;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Marker()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.cm = new ContextMenu();
            MenuItem closeItem = new MenuItem("Close");
            closeItem.Click += CloseItem_Click;
            cm.MenuItems.Add(closeItem);
            this.ContextMenu = cm;
        }

        private void CloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Marker(Form1 parent) : this()
        {
            this.parent = parent;
            //this.move = true;
            //timer = new Timer();
            //timer.Interval = 25;
            //timer.Tick += Timer_Tick;
            // timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //if (move)
            //{
            //    this.Top = Cursor.Position.Y + this.currentCursorPosition.Y - SystemInformation.BorderSize.Width;
            //    this.Left = Cursor.Position.X + this.currentCursorPosition.X - SystemInformation.BorderSize.Width;
            //}
            // this.textBox1.Text = Cursor.Position.X.ToString() + " " + Cursor.Position.Y.ToString();
        }

        private void Marker_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                //MessageBox.Show(":test");
                this.ContextMenu.Show(this, new Point(e.X, e.Y));
            }
        }


        private void Marker_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            parent.MakeScreenShot(this.Top, this.Left, this.Width, this.Height);
            this.Visible = true;
        }

        private void Marker_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                //this.timer.Start();
            }
        }

        private void buttonScreenShot_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            parent.MakeScreenShot(this.Top, this.Left, this.Width, this.Height);
            this.Visible = true;
        }
    }
}
