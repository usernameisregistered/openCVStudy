using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openCVStudy.Demo
{
    internal class Histogram
    {
       
        public Histogram() {
            Mat img = Cv2.ImRead("E:\\program\\openCVStudy\\openCVStudy\\Assets\\03.jpeg", ImreadModes.Grayscale);
            Mat dest = new Mat();
            Cv2.EqualizeHist(img, dest);
            DrawHist(img, "均衡化前直方图");
            DrawHist(dest, "均衡化后直方图");
            Cv2.ImShow("均衡化前", img);
            Cv2.ImShow("均衡化后", dest);
            Cv2.WaitKey();

        }

        public void DrawHist(Mat src, string name = "均衡化直方图") {
            int[] channels = new int[1] { 0 };
            int[] histSize = new int[1] { 256 };
            Rangef range = new Rangef(0f, 256f);
            Rangef[] ranges = new Rangef[1] { range };
            Mat[] mats = new Mat[1] {src };

            Mat hist_data = new Mat();
            Cv2.CalcHist(mats, channels, new Mat(), hist_data, 1, histSize, ranges);

            Mat drawImage = new Mat(256, 256, MatType.CV_8UC3, Scalar.All(255));
            double maxValue = 0;
            double minValue = 0;
            Cv2.MinMaxLoc(hist_data, out minValue,out maxValue);

            for (int i= 0; i < 256; i++) {
                int value = (int)(256 * 0.9 * (hist_data.At<float>(i) / maxValue));
                Cv2.Line(drawImage, new Point(i, drawImage.Rows - 1), new Point(i, drawImage.Rows - 1 - value), new Scalar(255, 0, 0));
            }
            Cv2.ImShow(name, drawImage);
        }
    }
}
