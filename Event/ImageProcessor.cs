using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class ImageProcessor
    {
        public delegate void ImageProcessingEndTrigger();
        public event ImageProcessingEndTrigger ProcessEnd;
        public void ProcessImageSize()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Processing Images: {i}");
            }

            ProcessEnd.Invoke();
        }
    }
}
