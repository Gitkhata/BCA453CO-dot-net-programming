using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Add these file names to the ImageList on load.
            string[] files = {
        "image.png",
        "logo.jpg"
      };
            var images = imageList1.Images;
            foreach (string file in files)
            {
                // Use Image.FromFile to load the file.
                images.Add(Image.FromFile(file));
            }
        }
    }
}