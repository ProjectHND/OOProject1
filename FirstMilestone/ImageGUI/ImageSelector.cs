using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGUI
{
    public partial class GUI : Form, IModel
    {
        public IList<string> imageCollection;

        public GUI()
        {
            InitializeComponent();
            imageCollection = new List<string>();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            load(imageCollection);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void previousImage_Click(object sender, EventArgs e)
        {

        }

        private void nextImage_Click(object sender, EventArgs e)
        {

        }

        public IList<string> load(IList<string> imageCollection)
        {
            string[] assetFolder = Directory.GetFiles("C:/Users/cank1_17/source/repos/FirstMilestone/ImageGUI/FishAssets");
            foreach(string filename in assetFolder)
            {
                Console.WriteLine(filename);
                imageCollection.Add(filename);
                Image image = Image.FromFile();
            }

            return imageCollection;
        }

        public Image getImage(string filename, int width, int height)
        {
            return imageCollection[1];
        }
    }
}
