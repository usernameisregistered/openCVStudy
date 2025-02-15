using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openCVStudy.Demo
{
    internal class Transform
    {
        public Transform() {
            Mat img = Cv2.ImRead("E:\\program\\openCVStudy\\openCVStudy\\Assets\\01.jpeg", ImreadModes.Color);

            #region 尺度变换
            /*Cv2.ImShow("原图", img);
            float fx = 2.0F;
            float fy = 2.0F;
            Mat img_resize = new Mat();
            Mat img_resize2 = new Mat();
            Cv2.Resize(img, img_resize, new Size(0,0), fx, fy, InterpolationFlags.Linear);
            Cv2.ImShow("线性插值", img_resize);
            Cv2.Resize(img, img_resize2, new Size(0, 0), fx, fy, InterpolationFlags.Nearest);
            Cv2.ImShow("最临近插值", img_resize2);*/
            #endregion

            #region 放射变换
            /*Cv2.ImShow("原图", img);
            float fx = 1.5F;
            float fy = 1.75F;
            Mat img_resize = new Mat();
            Mat img_resize2 = new Mat();
            Cv2.Resize(img, img_resize, new Size(0, 0), fx, fy, InterpolationFlags.Linear);
            Cv2.ImShow("线性插值", img_resize);
            Mat warp_matrix_resize = new Mat(2, 3, MatType.CV_32F);
            warp_matrix_resize.At<float>(0,0) = fx;
            warp_matrix_resize.At<float>(1,1) = fy;
            Size size = new Size();
            size.Width = (int)(img.Width * fx);
            size.Height = (int)(img.Height * fy);
            Cv2.WarpAffine(img, img_resize2, warp_matrix_resize ,size, InterpolationFlags.Linear, BorderTypes.Constant);
            Cv2.ImShow("放射变换", img_resize2);*/
            #endregion

            #region 平移变换
            Cv2.ImShow("原图", img);
            int tx = 40;
            int ty = 20;
            Mat warp_matrix_resize = new Mat(2, 3, MatType.CV_32F);
            warp_matrix_resize.SetIdentity();
            warp_matrix_resize.At<int>(0, 2) = tx;
            warp_matrix_resize.At<int>(1, 2) = ty;
            Mat img_resize = new Mat();
            // int top = 0, bottom = ty, left = 0, right = tx ;
            // Cv2.CopyMakeBorder(img, img, top, bottom, left, right, BorderTypes.Constant, new Scalar(200));
            Cv2.WarpAffine(img, img_resize, warp_matrix_resize, img.Size(), InterpolationFlags.Linear, BorderTypes.Transparent);
            Cv2.ImShow("平移变换", img_resize);
            #endregion
            Cv2.WaitKey();
        }
    }
}
