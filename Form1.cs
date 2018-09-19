using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace INFOIBV
{
    public partial class INFOIBV : Form
    {
        private Bitmap InputImage;
        private Bitmap OutputImage;

        public INFOIBV()
        {
            InitializeComponent();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
           if (openImageDialog.ShowDialog() == DialogResult.OK)             // Open File Dialog
            {
                string file = openImageDialog.FileName;                     // Get the file name
                imageFileName.Text = file;                                  // Show file name
                if (InputImage != null) InputImage.Dispose();               // Reset image
                InputImage = new Bitmap(file);                              // Create new Bitmap from file
                if (InputImage.Size.Height <= 0 || InputImage.Size.Width <= 0 ||
                    InputImage.Size.Height > 512 || InputImage.Size.Width > 512) // Dimension check
                    MessageBox.Show("Error in image dimensions (have to be > 0 and <= 512)");
                else
                    pictureBox1.Image = (Image) InputImage;                 // Display input image
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (InputImage == null) return;                                 // Get out if no input image
            if (OutputImage != null) OutputImage.Dispose();                 // Reset output image
            OutputImage = new Bitmap(InputImage.Size.Width, InputImage.Size.Height); // Create new output image
            Color[,] Image = new Color[InputImage.Size.Width, InputImage.Size.Height]; // Create array to speed-up operations (Bitmap functions are very slow)

            // Setup progress bar
            progressBar.Visible = true;
            progressBar.Minimum = 1;
            progressBar.Maximum = InputImage.Size.Width * InputImage.Size.Height;
            progressBar.Value = 1;
            progressBar.Step = 1;

            //Create Textbox List for easy Iteration
            List<TextBox> boxes = new List<TextBox>();
            boxes.Add(matrix1);
            boxes.Add(matrix2);
            boxes.Add(matrix3);
            boxes.Add(matrix4);
            boxes.Add(matrix5);
            boxes.Add(matrix6);
            boxes.Add(matrix7);
            boxes.Add(matrix8);
            boxes.Add(matrix9);
            boxes.Add(matrix10);
            boxes.Add(matrix11);
            boxes.Add(matrix12);
            boxes.Add(matrix13);
            boxes.Add(matrix14);
            boxes.Add(matrix15);
            boxes.Add(matrix16);
            boxes.Add(matrix17);
            boxes.Add(matrix18);
            boxes.Add(matrix19);
            boxes.Add(matrix20);
            boxes.Add(matrix21);
            boxes.Add(matrix22);
            boxes.Add(matrix23);
            boxes.Add(matrix24);
            boxes.Add(matrix25);

            // Copy input Bitmap to array            
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Image[x, y] = InputImage.GetPixel(x, y);                // Set pixel color in array at (x,y)
                }
            }

            //==========================================================================================
            // TODO: include here your own code
            // example: create a negative image
            switch (comboBox1.Text)
            {
                case "grayscale":
                    Image = conversionGrayscale(Image);
                    break;
                case "negative":
                    Image = conversionNegative(Image);
                    break;
                case "contrastadjustment":
                    double percentage = Convert.ToDouble(textBox1.Text);
                    if (percentage >= 0.50)
                    {
                        MessageBox.Show("Percentage selected is too high");
                        return;
                    }
                    else
                    {
                        Image = conversionContrastAdjustment(Image, Convert.ToDouble(textBox1.Text));
                    }
                    break;
                case "gaussian":
                    if (textBox2.Text.Equals("") || textBox3.Equals("")) return;
                    Image = conversionGaussian(Image, Convert.ToDouble(textBox2.Text), Convert.ToInt16(textBox3.Text));
                    break;
                case "threshold":
                    Image = conversionThreshold(Image, Convert.ToInt16(textBox1.Text));
                    break;
                case "linear":
                    Image = conversionLinear(Image, boxes);
                    break;
                case "median":
                    Image = conversionMedian(Image, Convert.ToInt16(textBox1.Text));
                    break;
                case "edge detection":
                    Image = conversionEdgeDetection(Image);
                    break;
                default:
                    Console.WriteLine("Nothing matched");
                    break;
            }
           

            // Copy array to output Bitmap
            for (int x = 0; x < Image.GetLength(0); x++)
            {
                for (int y = 0; y < Image.GetLength(1); y++)
                {
                    OutputImage.SetPixel(x, y, Image[x, y]);               // Set the pixel color at coordinate (x,y)
                }
            }
            
            pictureBox2.Image = (Image)OutputImage;                         // Display output image
            progressBar.Visible = false;                                    // Hide progress bar
        }

        private Color[,] conversionEdgeDetection(Color[,] image)
        {
            int size = 3;
            int halfSize = (size - 1)/ 2;
            int[,] sobelFilterX = {{-1, 0, 1}, { -1, 0, 1 }, { -1, 0, 1 } };
            int[,] sobelFilterY = {{ -1, -2, -1 }, {0, 0, 0 }, { 1, 2, 1 } };
            Color[,] imageSobelX = new Color[InputImage.Size.Width, InputImage.Size.Height];
            for (int x = halfSize; x < (InputImage.Size.Width - halfSize); x++)
            {
                for (int y = halfSize; y < (InputImage.Size.Height - halfSize); y++)
                {
                    double newColor = 0.0;
                    for (int xFilter = -halfSize; xFilter <= halfSize; xFilter++)
                    {
                        for (int yFilter = -halfSize; yFilter <= halfSize; yFilter++)
                        {
                            Color filterColor = image[x - xFilter, y - yFilter];
                            newColor += sobelFilterX[(xFilter + halfSize), (yFilter + halfSize)] * filterColor.R;

                        }
                    }

                    newColor = newColor * 0.25;
                    if (newColor > 255)
                    {
                        newColor = 255;
                    }
                    else if(newColor < 0)
                    {
                        newColor = 0;
                    }

                    int convertedNewColor = Convert.ToInt16(newColor);
                    Color updatedColor = Color.FromArgb(convertedNewColor, convertedNewColor, convertedNewColor);
                    imageSobelX[x - halfSize, y - halfSize] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }

            progressBar.Value = 1;
            Color[,] imageSobelY = new Color[InputImage.Size.Width, InputImage.Size.Height];
            for (int x = halfSize; x < (InputImage.Size.Width - halfSize); x++)
            {
                for (int y = halfSize; y < (InputImage.Size.Height - halfSize); y++)
                {
                    double newColor = 0.0;
                    for (int xFilter = -halfSize; xFilter <= halfSize; xFilter++)
                    {
                        for (int yFilter = -halfSize; yFilter <= halfSize; yFilter++)
                        {
                            Color filterColor = image[x - xFilter, y - yFilter];
                            newColor += sobelFilterY[(xFilter + halfSize), (yFilter + halfSize)] * filterColor.R;

                        }
                    }

                    newColor = newColor * 0.25;
                    if (newColor > 255)
                    {
                        newColor = 255;
                    }
                    else if (newColor < 0)
                    {
                        newColor = 0;
                    }

                    int convertedNewColor = Convert.ToInt16(newColor);
                    Color updatedColor = Color.FromArgb(convertedNewColor, convertedNewColor, convertedNewColor);
                    imageSobelY[x - halfSize, y - halfSize] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                }

            }

            progressBar.Value = 1;
            Color[,] newImage = new Color[InputImage.Size.Width, InputImage.Size.Height];
            for (int x = halfSize; x < (InputImage.Size.Width - halfSize); x++)
            {
                for (int y = halfSize; y < (InputImage.Size.Height - halfSize); y++)
                {
                    double newColor = imageSobelX[x, y].R + imageSobelY[x, y].R;
                    if (newColor > 255)
                    {
                        newColor = 255;
                    }
                    else if (newColor < 0)
                    {
                        newColor = 0;
                    }

                    int convertedNewColor = Convert.ToInt16(newColor);
                    Color updatedColor = Color.FromArgb(convertedNewColor, convertedNewColor, convertedNewColor);
                    newImage[x - halfSize, y - halfSize] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                }

            }
            return newImage;
        }

        private Color[,] conversionThreshold(Color[,] image, int threshold)
        {
            image = conversionGrayscale(image); // Convert image to grayscale, even though it already is a grayscale image.
            progressBar.Value = 1;
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];                         // Get the pixel color at coordinate (x,y)
                    int newColor = pixelColor.R > threshold ? 255 : 0;      //Uses the red color to calculate the threshold, since all channels are the same.
                    Color updatedColor = Color.FromArgb(newColor, newColor, newColor); // Pixel is either 255 or 0, depending on the threshold.
                    image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return image;
        }
        private Color[,] conversionGrayscale(Color[,] image)
        {
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];                         // Get the pixel color at coordinate (x,y)
                    int convertedRedColor = (int)(pixelColor.R * 0.299);
                    int convertedGreenColor = (int)(pixelColor.G * 0.587);
                    int convertedBlueColor = (int)(pixelColor.B * 0.114);
                    int Y = convertedRedColor + convertedGreenColor + convertedBlueColor;
                    if (Y < 0)
                    {
                        Y = 0;
                    }

                    if (Y > 255)
                    {
                        Y = 255;
                    }

                    Color updatedColor = Color.FromArgb(Y, Y, Y);
                    image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return image;
        }

        private Color[,] conversionNegative(Color[,] image)
        {
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];                         // Get the pixel color at coordinate (x,y)
                    Color updatedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B); // Negative image
                    image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return image;
        }

        private Color[,] conversionContrastAdjustment(Color[,] image, double percentage)
        {
            int low_R;
            int low_G;
            int low_B;
            int high_R;
            int high_G;
            int high_B;

            int[] histogram_red = new int[256];
            int[] histogram_green = new int[256];
            int[] histogram_blue = new int[256];
            int amount_of_pixels = InputImage.Size.Width * InputImage.Size.Height;
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];                         // Get the pixel color at coordinate (x,y)
                    histogram_red[pixelColor.R]++;
                    histogram_green[pixelColor.G]++;
                    histogram_blue[pixelColor.B]++;
                }

            }

            int percentile = (int) (percentage * amount_of_pixels);
            Console.Out.WriteLine("the percentile is set at: " + percentile);

            low_R = getColorAtPercentileLowFromHistogram(histogram_red, percentile);
            high_R = getColorAtPercentileHighFromHistogram(histogram_red, percentile);

            low_G = getColorAtPercentileLowFromHistogram(histogram_blue, percentile);
            high_G = getColorAtPercentileHighFromHistogram(histogram_blue, percentile);

            low_B = getColorAtPercentileLowFromHistogram(histogram_blue, percentile);
            high_B = getColorAtPercentileHighFromHistogram(histogram_blue, percentile);

            double kR = 255 / (high_R - low_R);
            double kG = 255 / (high_G - low_G);
            double kB = 255 / (high_B - low_B);


            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];
                    int updatedRed = (int) (kR * (pixelColor.R - low_R));
                    int updatedGreen = (int) (kG * (pixelColor.G - low_G));
                    int updatedBlue = (int) (kG * (pixelColor.B - low_B));
                    if (updatedRed > 255) updatedRed = 255;
                    if (updatedGreen > 255) updatedGreen = 255;
                    if (updatedBlue > 255) updatedBlue = 255;
                    if (updatedRed < 0) updatedRed = 0;
                    if (updatedGreen < 0) updatedGreen = 0;
                    if (updatedBlue < 0) updatedBlue = 0;
                    Color updatedColor = Color.FromArgb(updatedRed, updatedGreen, updatedBlue);
                    image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }
            }
            return image;
        }

        private Color[,] conversionGaussian(Color[,] image, double sigma, int size)
        {
            double[,] gaussianFilter = createGaussianFilter(sigma, size);
            return applyFilterToImage(image, gaussianFilter);
        }

        private Color[,] conversionLinear(Color[,] image, List<TextBox> boxes)
        {
            double[,] linearFilter = createLinearFilter(boxes);
            return applyFilterToImage(image, linearFilter);
        }

        private Color[,] conversionMedian(Color[,] image, int size)
        {
            int halfSize = (size - 1) / 2;
            Color[,] newImage = new Color[InputImage.Size.Width, InputImage.Size.Height];
            for (int x = halfSize; x < (InputImage.Size.Width - halfSize); x++)
            {
                for (int y = halfSize; y < (InputImage.Size.Height - halfSize); y++)
                {
                    int[] pixelVector = new int[size * size];
                    int pixelVectorIndex = 0;
                    for (int xFilter = -halfSize; xFilter <= halfSize; xFilter++)
                    {
                        for (int yFilter = -halfSize; yFilter <= halfSize; yFilter++)
                        {
                            Color filterColor = image[x - xFilter, y - yFilter];
                            pixelVector[pixelVectorIndex] = filterColor.R;
                            pixelVectorIndex++;
                        }
                    }
                    Array.Sort(pixelVector);
                    int newColor = pixelVector[(pixelVector.Length + 1) / 2];
                    Color updatedColor = Color.FromArgb(newColor,newColor,newColor);
                    newImage[x - halfSize, y - halfSize] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return newImage;
        }

        private double[,] createGaussianFilter(double sigma, int size)
        {
            double[,] gaussianFilter = new double[size, size];
            double r;
            double s = 2.0 * sigma * sigma;

            //This is used later for normalization
            double sum = 0.0;
            int halfSize = (size - 1) / 2;
            for (int x = -halfSize; x <= halfSize; x++)
            {
                for (int y = -halfSize; y <= halfSize; y++)
                {
                    r = Math.Sqrt(x * x + y * y);
                    int xIndice = x + halfSize;
                    int yIndice = y + halfSize;
                    double resultGaussian = (Math.Exp(-(r * r) / s)) / (Math.PI * s);
                    gaussianFilter[xIndice, yIndice] = resultGaussian;
                    sum += resultGaussian;
                }
            }

            //Normalization
            for (int i = 0; i < size; ++i)
            { 
                for (int j = 0; j < size; ++j)
                {
                    gaussianFilter[i, j] /= sum;
                }
            }
            return gaussianFilter;
        }

        private double[,] createLinearFilter(List<TextBox> boxes)
        {
            int i = 0, j = 0;
            double sum = 0;
            int kernel = 5;
            double[,] linearFilter = new double[kernel, kernel];
            foreach(TextBox box in boxes)
            {
                linearFilter[i, j] = Convert.ToDouble(box.Text);
                sum += linearFilter[i, j];
                if (i < kernel - 1)
                {
                    i++;
                } 
                else
                {
                    i = 0;
                    j++;
                }
            }

            for (int x = 0; x < kernel; ++x)
            {
                for (int y = 0; y < kernel; ++y)
                {
                    linearFilter[x, y] /= sum;
                }
            }
            return linearFilter;
        }



        private Color[,] applyFilterToImage(Color[,] image, double[,] filter)
        {
            int halfSize = (filter.GetLength(0) - 1) / 2;
            int xBorder = (filter.GetLength(0) - 1) / 2;
            int yBorder = (filter.GetLength(1) - 1) / 2;
            Color[,] newImage = new Color[InputImage.Size.Width, InputImage.Size.Height];
            for (int x = xBorder; x < (InputImage.Size.Width - xBorder); x++)
            {
                for (int y = yBorder; y < (InputImage.Size.Height - yBorder); y++)
                {
                    double updatedRed = 0.0;
                    double updatedGreen = 0.0;
                    double updatedBlue = 0.0;
                    for (int xFilter = -halfSize; xFilter <= halfSize; xFilter++)
                    {
                        for (int yFilter = -halfSize; yFilter <= halfSize; yFilter++)
                        {
                            Color filterColor = image[x - xFilter, y - yFilter];
                            updatedRed += filter[(xFilter + halfSize), (yFilter + halfSize)] * filterColor.R;
                            updatedGreen += filter[(xFilter + halfSize), (yFilter + halfSize)] * filterColor.G;
                            updatedBlue += filter[(xFilter + halfSize), (yFilter + halfSize)] * filterColor.B;
                        }
                    }
                    Color updatedColor = Color.FromArgb(Convert.ToInt32(updatedRed), Convert.ToInt32(updatedGreen), Convert.ToInt32(updatedBlue));
                    newImage[x-xBorder, y-yBorder] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return newImage;
        }
        private int getColorAtPercentileLowFromHistogram(int[] histogram_array, int percentile)
        {
            for (int i = 0; i < 255; i++)
            {
                percentile = percentile - histogram_array[i];
                if (percentile < 0)
                {
                    return i;
                }
            }

            return 255;
        }

        private int getColorAtPercentileHighFromHistogram(int[] histogram_array, int percentile)
        {
            for (int i = 255; 0 < i; i--)
            {
                percentile = percentile - histogram_array[i];
                if (percentile < 0)
                {
                    return i;
                }
            }

            return 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (OutputImage == null) return;                                // Get out if no output image
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
                OutputImage.Save(saveImageDialog.FileName);                 // Save the output image
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("gaussian"))
            {
                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
        }

        private void INFOIBV_Load(object sender, EventArgs e)
        {

        }
    }
}
