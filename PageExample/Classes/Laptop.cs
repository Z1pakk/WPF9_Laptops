using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PageExample.Classes
{
    public class Laptop
    {
        public Laptop() {}

        public Laptop(string name, float price, string imagePath)
        {
            this.Name = name;
            this.Price = price;
            string path = Path.Combine(
                Environment.CurrentDirectory, 
                ConfigurationManager.AppSettings["LaptopImages"].ToString());

            string pathImage = Path.Combine(path, imagePath);

            this.Image = new BitmapImage(new Uri(pathImage, UriKind.Absolute));
        }
        public string Name { get; set; }

        public float Price { get; set; }

        public BitmapImage Image { get; set; }
    }
}
