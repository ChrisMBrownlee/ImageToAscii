using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AsciiArtProject {
    public partial class Form1 : Form {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private FileClass fileClass = new FileClass();
        private BitmapAscii asciiClass = new BitmapAscii();
        
        public Form1() {
            InitializeComponent();
            asciiClass.PixelHeight = 1;
            asciiClass.PixelWidth = 1;
        }

        private void BtnAsciify_Click(object sender, EventArgs e) {
            bool Loaded = fileClass.LoadFile(openFileDialog, PicOriginal);

            if(Loaded) {
                TxtAsciied.Clear();
                TxtAsciied.Text = asciiClass.Asciitize(fileClass.LoadedBitmap);
            }//end if
        }//end method

        private void PixelWidthUpDown_ValueChanged(object sender, EventArgs e) {
            asciiClass.PixelWidth = int.Parse(PixelWidthUpDown.Value.ToString());

            if(fileClass.IsLoaded) {
                TxtAsciied.Text = asciiClass.Asciitize(fileClass.LoadedBitmap);
            }//end if
        }//end method

        private void PixelHeighUpDown_ValueChanged(object sender, EventArgs e) {
            asciiClass.PixelHeight = int.Parse(PixelHeighUpDown.Value.ToString());

            if(fileClass.IsLoaded) {
                TxtAsciied.Text = asciiClass.Asciitize(fileClass.LoadedBitmap);
            }//end if
        }//end method
    }//end class
}//end namespace
