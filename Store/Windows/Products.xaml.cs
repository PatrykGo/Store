using Store.StoreModel;
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
using System.Windows.Shapes;

namespace Store.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        StoreDBEntities db = new StoreDBEntities();
        public Products()
        {
            InitializeComponent();
        }
    }
}
