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
using System.IO;

namespace ChangeLetterSize
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            this.bmp = null;
            this.toolTip1.SetToolTip(this.readTextButton, "Works only under Visual Studio");
            
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
            bmp = new Bitmap(rect.Width, rect.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

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

            this.saveImageButton.Enabled = true;
            
            // use Tessaract

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

        private void readTextButton_Click(object sender, EventArgs e)
        {
            if (this.bmp != null)
            {
                try
                {
                    using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.TesseractOnly))
                    {
                        using (var page = engine.Process(this.bmp))
                        {
                            var text = page.GetText();
                            this.textBoxPicText.Clear();
                            this.textBoxPicText.Text = text;
                        }
                    }
                    //foreach (Word word in result)
                    //{

                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.ToString() + ex.StackTrace);
                }
            }
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if (this.bmp != null)
            {
                SaveFileDialog dial = new SaveFileDialog();
                dial.Filter = "Bitmap (*.bmp)|*.bmp | JPG (*.jpg)|*.jpg | ALL FILES (*.*)|*.*";
                if (dial.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(dial.FileName);
                    switch(fi.Extension)
                    {
                        case ".jpg":
                            {
                                try
                                {
                                    var qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                                    var quality = (long)100;
                                    var ratio = new EncoderParameter(qualityEncoder, quality);
                                    var codecParams = new EncoderParameters(1);
                                    codecParams.Param[0] = ratio;
                                    var jpegCodesc = from codec in ImageCodecInfo.GetImageEncoders()
                                                     where codec.FormatID == System.Drawing.Imaging.ImageFormat.Jpeg.Guid
                                                     select codec;
                                    var jpegCodecInfo = jpegCodesc.ToArray()[0];
                                    using (var tosave = new Bitmap(bmp))
                                    {
                                        bmp.Save(fi.FullName, jpegCodecInfo, codecParams);
                                    }
                                }
                                catch(Exception ex) { MessageBox.Show(ex.Message); }
                                break;
                            }
                        case ".bmp":
                            {
                                try
                                {
                                    using (var toSave = new Bitmap(bmp))
                                    {
                                        bmp.Save(fi.FullName);
                                    }

                                }
                                catch (Exception ex) { MessageBox.Show(ex.Message); }
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Only JPG or BMP allowed");
                                break;
                            }
                    }


                }
            }
        }
    }
}
