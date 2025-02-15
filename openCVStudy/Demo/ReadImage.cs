using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openCVStudy.Demo
{
    internal class ReadImage
    {
        public ReadImage() {
            Mat img = Cv2.ImRead("E:\\program\\openCVStudy\\openCVStudy\\Assets\\01.jpeg", ImreadModes.Color);
            Mat gaussinanImg = new Mat();
            int width = img.Width;
            int height = img.Height;
            Console.WriteLine("图像的尺寸信息为" + img.Size());
            Console.WriteLine("图像的宽度信息为" + width);
            Console.WriteLine("图像的高度信息为" + height);
            Cv2.GaussianBlur(img, gaussinanImg, new Size(5,5), 0, 0 ); //高斯滤波
            Cv2.ImShow("原图", img);
            Cv2.ImShow("高斯滤波后图", gaussinanImg);
            Cv2.WaitKey();
            Cv2.ImWrite("E:\\program\\openCVStudy\\openCVStudy\\Assets\\02.jpeg", gaussinanImg);
            Cv2.DestroyAllWindows();
        }
    }
}
