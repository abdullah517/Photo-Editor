using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTPRACTICE
{
    class HelperClass
    {


        public static Image<Bgr, byte> HConcatenateImages(List<Image<Bgr, byte>> images)
        {
            try
            {
                int MaxRows = images.Max(x => x.Rows);
                int totalCols = images.Sum(x => x.Cols);

                Image<Bgr, byte> imgOutput = new Image<Bgr, byte>(totalCols, MaxRows, new Bgr(0, 0, 0));

                int xcord = 0;
                for (int i = 0; i < images.Count; i++)
                {
                    imgOutput.ROI = new Rectangle(xcord, 0, images[i].Width, images[i].Height);
                    images[i].CopyTo(imgOutput);
                    imgOutput.ROI = Rectangle.Empty;
                    xcord += images[i].Width;
                }
                return imgOutput;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Image<Bgr, byte> HConcatenateImages(Image<Bgr, byte> img1, Image<Bgr, byte> img2)
        {
            try
            {
                int MaxRows = img1.Rows > img2.Rows ? img1.Rows : img2.Rows;
                int totalCols = img1.Cols + img2.Cols;

                Image<Bgr, byte> imgOutput = new Image<Bgr, byte>(totalCols, MaxRows, new Bgr(0, 0, 0));


                imgOutput.ROI = new Rectangle(0, 0, img1.Width, img1.Height);
                img1.CopyTo(imgOutput);
                imgOutput.ROI = Rectangle.Empty;

                imgOutput.ROI = new Rectangle(img1.Width, 0, img2.Width, img2.Height);
                img2.CopyTo(imgOutput);
                imgOutput.ROI = Rectangle.Empty;
                return imgOutput;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Image<Bgr, byte> VConcatenateImages(Image<Bgr, byte> img1, Image<Bgr, byte> img2)
        {
            try
            {
                int MaxCols = img1.Cols > img2.Cols ? img1.Cols : img2.Cols;
                int totalRows = img1.Rows + img2.Rows;

                Image<Bgr, byte> imgOutput = new Image<Bgr, byte>(MaxCols, totalRows, new Bgr(0, 0, 0));


                imgOutput.ROI = new Rectangle(0, 0, img1.Width, img1.Height);
                img1.CopyTo(imgOutput);
                imgOutput.ROI = Rectangle.Empty;

                imgOutput.ROI = new Rectangle(0, img1.Height, img2.Width, img2.Height);
                img2.CopyTo(imgOutput);
                imgOutput.ROI = Rectangle.Empty;
                return imgOutput;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Image<Bgr, byte> VConcatenateImages(List<Image<Bgr, byte>> images)
        {
            try
            {
                int MaxCols = images.Max(x => x.Cols);
                int totalRows = images.Sum(x => x.Rows);

                Image<Bgr, byte> imgOutput = new Image<Bgr, byte>(MaxCols, totalRows, new Bgr(0, 0, 0));

                int ycord = 0;
                for (int i = 0; i < images.Count; i++)
                {
                    imgOutput.ROI = new Rectangle(0, ycord, images[i].Width, images[i].Height);
                    images[i].CopyTo(imgOutput);
                    imgOutput.ROI = Rectangle.Empty;
                    ycord += images[i].Height;
                }

                return imgOutput;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
