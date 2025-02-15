using openCVStudy.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openCVStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("开始执行程序");
            // 读取图片
            // ReadImage readImage =  new ReadImage();

            // 图片颜色转化
            // CvtColor cvtColor = new CvtColor();

            // 尺度变换
            // Transform transform = new Transform();

            // 直方图均衡化
            Histogram histogram = new Histogram();
            Console.ReadKey();
        }
    }
}
