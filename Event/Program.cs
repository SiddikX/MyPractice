using Event;

ImageProcessor imageProcessor  = new ImageProcessor();
imageProcessor.ProcessEnd += ImageProcessor_ProcessEnd;
imageProcessor.ProcessEnd += ImageProcessor_ProcessEnd2;
imageProcessor.ProcessImageSize();

void ImageProcessor_ProcessEnd()
{
    Console.WriteLine("%%%% Image Processed %%%%%");
}

void ImageProcessor_ProcessEnd2()
{
    Console.WriteLine("**** Download Now *****");
}