using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openCVStudy.Demo
{
    internal class CvtColor
    {
        public CvtColor() {
            Mat img_rgb = Cv2.ImRead("E:\\program\\openCVStudy\\openCVStudy\\Assets\\01.jpeg", ImreadModes.Color);
            Mat img_gray = new Mat();
            Mat img_hsv = new Mat();
            Mat img_gray2rgb = new Mat();
            Mat img_hsv2rgb = new Mat();
            Cv2.CvtColor(img_rgb, img_hsv, ColorConversionCodes.RGB2HSV);
            Cv2.CvtColor(img_rgb, img_gray, ColorConversionCodes.RGB2GRAY);
            Cv2.CvtColor(img_gray, img_gray2rgb, ColorConversionCodes.GRAY2RGB);
            Cv2.CvtColor(img_hsv, img_hsv2rgb, ColorConversionCodes.HSV2BGR);
            Console.WriteLine("rgb的通道数为" + img_rgb.Channels());
            Console.WriteLine("hsv的通道数为" + img_hsv.Channels());
            Console.WriteLine("gray的通道数为" + img_gray.Channels());
            Cv2.ImShow("rgb", img_rgb);
            Cv2.ImShow("gray", img_gray);
            Cv2.ImShow("hsv", img_hsv);
            Cv2.ImShow("gray2rgb", img_gray2rgb);
            Cv2.ImShow("hsv2rgb", img_hsv2rgb);
            Cv2.WaitKey();
        }
    }
}
