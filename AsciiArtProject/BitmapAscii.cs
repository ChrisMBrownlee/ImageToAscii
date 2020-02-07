using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiArtProject {
    class BitmapAscii {
        List<Color> colors = new List<Color>();
        private string _fullString;
        private int _pixelWidth;
        private int _pixelHeight;

        //PROPERTIES
        private string Ascii {
            set { _fullString = value; }
            get { return _fullString; }
        }//end property

        public int PixelWidth {
            get { return _pixelWidth; }
            set { _pixelWidth = value; }
        }//end property

        public int PixelHeight {
            get { return _pixelHeight; }
            set { _pixelHeight = value; }
        }//end property

        //METHODS
        public string Asciitize(Bitmap bitmap) {
            Ascii = "";

            for(int Y = 0; Y < bitmap.Height; Y+= PixelHeight) {
                for(int X = 0; X < bitmap.Width; X+= PixelWidth) {
                    if(X >= bitmap.Width - PixelWidth) {
                        Ascii += $"{GreyToString(AverageKernel(bitmap, X, Y))}\r\n";
                    } else {
                        Ascii += $"{GreyToString(AverageKernel(bitmap, X, Y))}";
                    }//end if
                }//end for
            }//end for

            return Ascii;
        }//end method

        private static double AveragePixel(int red, int grn, int blu) {
            return (((red + grn + blu) / 3.0) / 255.0 );
        }//end method

        private static double AveragePixel(Color color) {
            return (((color.R + color.G + color.B) / 3.0) / 255.0);
        }//end method

        //private double AverageColor(List<Color> colors) {
        //    return 0;
        //}//end method

        private double AverageKernel(Bitmap bitmap, int X, int Y) {
            double color = 0.0;
            for(int kernY = Y; kernY < Y + PixelHeight; kernY++) {
                for(int kernX = X; kernX < X + PixelWidth; kernX++) {
                    color += AveragePixel(bitmap.GetPixel(X, Y));
                }//end for
            }//end for

            return color / (PixelHeight * PixelWidth);
        }//end method

        private string GreyToString(double grey) {
            if(grey < 0.166) {
                return "█";
            } else if (grey < 0.332) {
                return "▓";
            } else if (grey < 0.498) {
                return "▒";
            } else if (grey < 0.664) {
                return "░";
            } else if (grey < 0.830) {
                return ".";
            } else {
                return " ";
            }//end if
        }//end method

        //private static string ToString() {
        //    return "0";
        //}//end method
    }//end class
}//end namespace
