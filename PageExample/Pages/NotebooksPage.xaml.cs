using PageExample.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace PageExample.Pages
{
    /// <summary>
    /// Interaction logic for NotebooksPage.xaml
    /// </summary>
    public partial class NotebooksPage : Page
    {
        public NotebooksPage()
        {
            InitializeComponent();
            List<Laptop> laptops = new List<Laptop>
            {
                new Laptop("Супер ноутбук 3000", 3000 , "dog.jpg"),
                new Laptop("Супер ноутбук 3", 6000 , "notebook1.webp"),
                new Laptop("Супер ноутбук 4", 4000 , "dog.jpg"),
                new Laptop("Супер ноутбук 5", 3000 , "dog.jpg")
            };

            lvNotebooks.ItemsSource = laptops;
        }
    }
}
