using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CutImage
{
    public partial class Background : Form
    {
        private int width = -1, height = -1, length = -1;
        private Image openImage;

        public Background()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "ImageFile(*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                openImage = Image.FromFile(dialog.FileName);
                PictureBox.Image = openImage;
            }
        }

        private void TextBoxW_TextChanged(object sender, EventArgs e)
        {
            width = int.Parse(TextBoxW.Text);
        }

        private void TextBoxH_TextChanged(object sender, EventArgs e)
        {
            height = int.Parse(TextBoxH.Text);
        }

        private void TextBoxL_TextChanged(object sender, EventArgs e)
        {
            length = int.Parse(TextBoxL.Text);
        }
   
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(width <=0  || length <= 0 || height <= 0)
            {
                MessageBox.Show("长宽高输入有误", "错误提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }

            int targetValue;
            int averagePixel;
            //在一张图片上扣出一个矩形盒子
            //Back&Fron => W:H || Top&Button => W:L || Left&Right => H:L 
            if (openImage.Width > openImage.Height)
            {
                targetValue = openImage.Height;
                averagePixel = targetValue / (2 * length + 2 * height);
            }
            else
            {
                targetValue = openImage.Width;
                averagePixel = targetValue / (2 * length + width);
            }
            ////left&Right
            //CutFromImage(openImage, length * averagePixel, height * averagePixel, 0, (length + height) * averagePixel).Save(@"D:\left.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //CutFromImage(openImage, length * averagePixel, height * averagePixel, (length + width) * averagePixel, (length + height) * averagePixel).Save(@"D:\right.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            ////Top&Buttom
            //CutFromImage(openImage, width * averagePixel, length * averagePixel, length * averagePixel, height * averagePixel).Save(@"D:\top.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //CutFromImage(openImage, width * averagePixel, length * averagePixel, length * averagePixel, (height * 2 + length) * averagePixel).Save(@"D:\Buttom.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            ////Front&Back
            //CutFromImage(openImage, width * averagePixel, height * averagePixel, length * averagePixel, (height + length) * averagePixel).Save(@"D:\Front.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //CutFromImage(openImage, width * averagePixel, height * averagePixel, length * averagePixel, 0).Save(@"D:\Back.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            averagePixel = (openImage.Height + openImage.Width) / (width + height + length);
            //left&Right
            CutFromImage(openImage, length * averagePixel, height * averagePixel, 0, 0).Save(@"D:\left.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            CutFromImage(openImage, length * averagePixel, height * averagePixel, 0, 0).Save(@"D:\right.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //Top&Buttom
            CutFromImage(openImage, width * averagePixel, length * averagePixel, 0, 0).Save(@"D:\top.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            CutFromImage(openImage, width * averagePixel, length * averagePixel, 0, 0).Save(@"D:\Buttom.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //Front&Back
            CutFromImage(openImage, width * averagePixel, height * averagePixel, 0, 0).Save(@"D:\Front.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            CutFromImage(openImage, width * averagePixel, height * averagePixel, 0, 0).Save(@"D:\Back.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private Image CutFromImage(Image sourceImage,int width, int height, int offsetX, int offsetY)
        {
            Image resultImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resultImage))
            {
                Rectangle resultRectangle = new Rectangle(0, 0, width, height);
                Rectangle sourceRectangle = new Rectangle(offsetX, offsetY, width, height);
                g.DrawImage(sourceImage, resultRectangle, sourceRectangle, GraphicsUnit.Pixel);
            }
            return resultImage;
        }
    }
}
