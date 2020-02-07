using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace AsciiArtProject {
    class FileClass {
        private Bitmap _loadedBitmap;
        private bool _isLoaded;

        //properties
        public Bitmap LoadedBitmap {
            get { return _loadedBitmap; }
        }//end property

        public bool IsLoaded {
            get { return _isLoaded; }
        }
        
        //constructors
        public FileClass() {

        }//end constructor

        //METHODS
        public bool LoadFile(OpenFileDialog openFileDialog, PictureBox OriginalPic) {
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Image Selector";
            if(openFileDialog.ShowDialog() == DialogResult.OK) {
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                _loadedBitmap = bitmap;
                OriginalPic.Image = bitmap;
                _isLoaded = true;
                return true;
            }//end if
            _isLoaded = false;
            return false;
        }//end method
    }//end class
}//end namespace
