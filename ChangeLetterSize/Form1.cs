using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ChangeLetterSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonToLower_Click(object sender, EventArgs e)
        {
            this.textBoxResult.Text = this.textBoxSource.Text.ToLower();
        }

        private void buttonToUpper_Click(object sender, EventArgs e)
        {
            this.textBoxResult.Text = this.textBoxSource.Text.ToUpper();
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            this.textBoxCharacterCounter.Text = this.textBoxSource.Text.Length.ToString();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.textBoxSource.Focus();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
            {
                this.Show();
                this.Activate();
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            this.TestTesseract();
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {
            Marker marker = new Marker(this);
            marker.Show();
        }
        

        // sux - make it in few external methods
        public void MakeScreenShot(int top, int left, int width, int height)
        {
            Rectangle rect = new Rectangle(left, top, width, height);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            // resize bmp
            Rectangle destRectangle = new Rectangle(0, 0, rect.Width, rect.Height);
            Bitmap destImage = new Bitmap(rect.Width * 2, rect.Height * 2);

            destImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    gr.DrawImage(bmp, destRectangle, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, wrapMode);
                }
           
            }


            // prepare for imagebox
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            this.pictureBox.Width = width;
            this.pictureBox.Height = height;
            this.pictureBox.Image = bmp;
            // use Tessaract
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.TesseractOnly))
                {
                    using (var page = engine.Process(bmp))
                    {
                        var text = page.GetText();
                        MessageBox.Show(text);
                    }
                }
                //foreach (Word word in result)
                //{

                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString() + ex.StackTrace);
            }
        }

        public void TestTesseract()
        {
        //    var testImagePath = "./phototest.tif";
        //    StringBuilder stb = new StringBuilder();
        //    try
        //    {
        //        using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
        //        {
        //            using (var img = Pix.LoadFromFile(testImagePath))
        //            {
        //                using (var page = engine.Process(img))
        //                {
        //                    var text = page.GetText();
        //                    stb.AppendLine(string.Format("Mean confidence: {0}", page.GetMeanConfidence()));

        //                    stb.AppendLine(string.Format("Text (GetText): \r\n{0}", text));
        //                    stb.AppendLine("Text (iterator):");
        //                    using (var iter = page.GetIterator())
        //                    {
        //                        iter.Begin();

        //                        do
        //                        {
        //                            do
        //                            {
        //                                do
        //                                {
        //                                    do
        //                                    {
        //                                        if (iter.IsAtBeginningOf(PageIteratorLevel.Block))
        //                                        {
        //                                            stb.Append("<BLOCK>");
        //                                        }

        //                                        stb.Append(iter.GetText(PageIteratorLevel.Word));
        //                                        stb.Append(" ");

        //                                        if (iter.IsAtFinalOf(PageIteratorLevel.TextLine, PageIteratorLevel.Word))
        //                                        {
        //                                            stb.Append("\n\r");
        //                                        }
        //                                    } while (iter.Next(PageIteratorLevel.TextLine, PageIteratorLevel.Word));

        //                                    if (iter.IsAtFinalOf(PageIteratorLevel.Para, PageIteratorLevel.TextLine))
        //                                    {
        //                                        stb.Append("\n\r");
        //                                    }
        //                                } while (iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine));
        //                            } while (iter.Next(PageIteratorLevel.Block, PageIteratorLevel.Para));
        //                        } while (iter.Next(PageIteratorLevel.Block));
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        //Trace.TraceError(e.ToString());
        //        stb.AppendLine("Unexpected Error: " + e.Message);
        //        stb.AppendLine("Details: ");
        //        stb.AppendLine(e.ToString());
        //    }
        //    stb.Append("Press any key to continue . . . ");
        //    MessageBox.Show(stb.ToString());
        }
    }
}
