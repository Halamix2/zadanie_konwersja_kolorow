using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;


namespace Rysowanie
{
    public partial class MainWindow : Window
    {
        enum Tools {line, brush};
        Tools tool = Tools.line;
        Point currentPoint = new Point();
        Point anchorPoint = new Point();
        List<float[,]> filters = new List<float[,]>();
        SolidColorBrush brush = new SolidColorBrush(Colors.Black);
        private int r, g, b;
        Ellipse elipse;

        public MainWindow()
        {
            InitializeComponent();
            this.r = 255;
            this.g = 255;
            this.b = 255;

            //generate Gaussian filter with sigma = 1
            float[,] gauss = GetGaussianKernel(1);
            filters.Add(gauss);
            filters.Add(gauss);
        }

        private void canvasLoaded(object sender, RoutedEventArgs e)
        {
            Rectangle rect = new Rectangle
            {
                Width = myCanvas.ActualWidth,
                Height = myCanvas.ActualHeight,
                Fill = new SolidColorBrush(Colors.Red),
            };
            Canvas.SetLeft(rect, 0);
            Canvas.SetLeft(rect, 0);
            // myCanvas.Children.Add(rect);
        }

        private void Canvas_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(this);

            if (tool == Tools.brush)
            {

                myCanvas.CaptureMouse();

                anchorPoint = e.MouseDevice.GetPosition(myCanvas);
                //Debug.WriteLine(anchorPoint.X);
                elipse = new Ellipse
                {
                    Stroke = brush,

                };
                myCanvas.Children.Add(elipse);
            }
        }

        private void Canvas_MouseMove_1(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && tool == Tools.line)
            {
                Line line = new Line();
                line.Stroke = brush;
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;
                line.X2 = e.GetPosition(this).X;
                line.Y2 = e.GetPosition(this).Y;
                currentPoint = e.GetPosition(this);

                myCanvas.Children.Add(line);
            }

            if (e.LeftButton == MouseButtonState.Pressed && tool == Tools.brush)
            {
                if (!myCanvas.IsMouseCaptured)
                    return;

                Point location = e.MouseDevice.GetPosition(myCanvas);

                double minX = Math.Min(location.X, anchorPoint.X);
                double minY = Math.Min(location.Y, anchorPoint.Y);
                double maxX = Math.Max(location.X, anchorPoint.X);
                double maxY = Math.Max(location.Y, anchorPoint.Y);

                Canvas.SetTop(elipse, minY);
                Canvas.SetLeft(elipse, minX);

                double height = maxY - minY;
                double width = maxX - minX;

                elipse.Height = Math.Abs(height);
                elipse.Width = Math.Abs(width);
            }
        }

        private void Canvas_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            myCanvas.ReleaseMouseCapture();
        }

        private void OnChangeTool(object sender, RoutedEventArgs e)
        {
            if(tool==Tools.brush)
            {
                tool_name.Text = "Points";
                tool = Tools.line;
            }
            else if(tool==Tools.line)
            {
                tool_name.Text = "Ellipses";
                tool = Tools.brush;
            }
        }

        private void OnColorPaletteClick(object sender, RoutedEventArgs e)
        {
            ColorDialog colorPalette = new ColorDialog();
            colorPalette.Color = System.Drawing.Color.FromArgb(brush.Color.R, brush.Color.G, brush.Color.B);

            if (colorPalette.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                brush = new SolidColorBrush(Color.FromRgb(colorPalette.Color.R, colorPalette.Color.G, colorPalette.Color.B));
                r = colorPalette.Color.R;
                g = colorPalette.Color.G;
                b = colorPalette.Color.B;
            }
        }

        private void OnComboFilterChanged(object sender, SelectionChangedEventArgs e)
        {
            System.Windows.Controls.ComboBox box = (System.Windows.Controls.ComboBox)sender;
            if(box.SelectedIndex  >= box.Items.Count - 1)
            {
                // last index
                filter_apply.Content = "Edit & apply filter";
            }
            else
            {
                filter_apply.Content = "Apply filter";
            }
        }

        private void OnComboFilterLoaded(object sender, RoutedEventArgs e)
        {
            // ugly hack, I know
            OnComboFilterChanged(filter_combo, null);
        }

        private void OnOpenColorsConverterClick(object sender, RoutedEventArgs e)
        {
//            myCanvas.ReleaseMouseCapture();


            ColorConverter colorConverter = new ColorConverter(r, g, b);
            colorConverter.TopMost = true;

            var result = colorConverter.ShowDialog();
            
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                r = colorConverter.r;
                g = colorConverter.g;
                b = colorConverter.b;
                brush = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            }
        }

        private float[,] GetGaussianKernel(float sigma)
        {
            float[,] kernel = new float[5, 5];
            float s = 2 * sigma * sigma;
            float sum = 0;
            for(int x = -2; x <= 2; x++)
            {
                for (int y = -2; y <= 2; y++)
                {
                    float r = (float)Math.Sqrt(x*x + y*y);
                    float tmp = (float)(Math.Exp(-(r*r) / s) / (Math.PI * s));
                    kernel[x + 2, y + 2] = tmp;
                    sum += tmp;
                }
            }

            //normalize stuff if neccesary
            for (int i = 0; i < kernel.GetLength(0); i++) // rows
            {
                for (int j = 0; j < kernel.GetLength(1); j++) // columns?
                {
                    kernel[i, j] = kernel[i, j] / sum;
                }
            }
            
            return kernel;
        }
        

        private void OnFilter(object sender, RoutedEventArgs e)
        {
            // Note tat this operation will flatten the image
            // convert canvas to flat writable bitmap
            float[,] kernel = new float[5,5];
            if (filter_combo.SelectedIndex == 1 )
            {
                Debug.WriteLine("custom filter!");
                KernelDialog kernelDialog = new KernelDialog(filters[1]);
                kernelDialog.TopMost = true;

                var result = kernelDialog.ShowDialog();
                Debug.WriteLine(result);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    filters[1] = kernelDialog.kernel;
                    kernel = filters[1];
                    Debug.WriteLine(kernel[1,1]);
                }
                else
                {
                    kernel = new float[5, 5] {   {0,0,0,0,0},
                                                 {0,0,0,0,0},
                                                 {0,0,1,0,0},
                                                 {0,0,0,0,0},
                                                 {0,0,0,0,0}};
                }
            }
            else
            {
                kernel = filters[filter_combo.SelectedIndex];
            }


            System.Windows.Size size = new System.Windows.Size(myCanvas.ActualWidth, myCanvas.ActualHeight);
            myCanvas.Measure(size);
            myCanvas.Arrange(new Rect(size));
            RenderTargetBitmap rendered = new RenderTargetBitmap((int)size.Width, (int)size.Height, 96d, 96d, PixelFormats.Pbgra32);
            rendered.Render(myCanvas);
            // WriteableBitmap image = new WriteableBitmap(rendered);
            MemoryStream stream = new MemoryStream();
            BitmapEncoder encoder = new BmpBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(rendered));
            encoder.Save(stream);
            System.Drawing.Bitmap image = new System.Drawing.Bitmap(stream);

            // now we can apply filter
            image = ApplyFilter(image , kernel);

            //copy data back
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            ms.Position = 0;

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = ms;
            bi.CacheOption = BitmapCacheOption.OnLoad;
            bi.EndInit();

            Image flattened = new Image
            {
                Source = bi
            };
            myCanvas.Children.Clear();
            myCanvas.Children.Add(flattened);
        }

        private System.Drawing.Bitmap ApplyFilter(System.Drawing.Bitmap image, float[,] kernel)
        {
            System.Drawing.Bitmap tmp = new System.Drawing.Bitmap(image);

            System.Drawing.Imaging.BitmapData tmpLock =  tmp.LockBits(new System.Drawing.Rectangle(0, 0, tmp.Width, image.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            System.Drawing.Imaging.BitmapData imageLock = image.LockBits(new System.Drawing.Rectangle(0, 0, image.Width, image.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            IntPtr tmpPointer = tmpLock.Scan0;
            IntPtr imagePointer = imageLock.Scan0;
            int imageBytes = Math.Abs(imageLock.Stride) * image.Height;
            byte[] argbValues = new byte[imageBytes];
            System.Runtime.InteropServices.Marshal.Copy(imagePointer, argbValues, 0, imageBytes);


            int tmpBytes = Math.Abs(tmpLock.Stride) * tmp.Height;
            byte[] tmpArgbValues = new byte[tmpBytes];
            System.Runtime.InteropServices.Marshal.Copy(tmpPointer, tmpArgbValues, 0, tmpBytes);


            int width = image.Width;
            int height = image.Height;
            int kernelWidth = kernel.GetLength(0);
            int kernelHeight = kernel.GetLength(1);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    float red = 0;
                    float green = 0;
                    float blue = 0;
                    float alpha = 255;

                    for(int kernelX = 0; kernelX < kernelWidth; kernelX++)
                    {
                        for (int kernelY = 0; kernelY < kernelHeight; kernelY++)
                        {
                            // calculate from which pixel should kernel take next
                            var calculatedX = x + kernelX - 2;
                            var calculatedY = y + kernelY - 2;

                            //clamp that to image size, a.k.a extend edges
                            calculatedX = Math.Min(Math.Max(calculatedX, 0), width - 2);
                            calculatedY = Math.Min(Math.Max(calculatedY, 0), height - 2);
                            float currentMaskValue = kernel[kernelX, kernelY];

                            int location = 4* (calculatedX + calculatedY * image.Width);

                            red += argbValues[location] * currentMaskValue;
                            green += argbValues[location + 1] * currentMaskValue;
                            blue += argbValues[location + 2] * currentMaskValue;
                            //alpha += (int)argbValues[location + 3] * currentMaskValue;
                        }
                    }
                    int locationDst = 4 * (x + y * width);
                    tmpArgbValues[locationDst] = (byte)red;
                    tmpArgbValues[locationDst + 1] = (byte)green;
                    tmpArgbValues[locationDst + 2] = (byte)blue;
                    tmpArgbValues[locationDst + 3] = (byte)alpha;

                }
            }
            System.Runtime.InteropServices.Marshal.Copy(tmpArgbValues, 0, tmpPointer, tmpBytes);

            tmp.UnlockBits(tmpLock);
            image.UnlockBits(imageLock);

            return tmp;
        }
    }
}
