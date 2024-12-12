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

namespace products
{
    /// <summary>
    /// Логика взаимодействия для producttpl.xaml
    /// </summary>
    public partial class producttpl : UserControl
    {


        public string Imgsource
        {
            get { return (string)GetValue(ImgsourceProperty); }
            set { SetValue(ImgsourceProperty, value); }
        }

        public static readonly DependencyProperty ImgsourceProperty =
            DependencyProperty.Register(nameof(Imgsource), typeof(string), typeof(producttpl), new PropertyMetadata("https://www.creativefabrica.com/wp-content/uploads/2021/06/28/Image-photo-icon-Graphics-13989898-1.jpg"));

        public string Productname
        {
            get { return (string)GetValue(ProductnameProperty); }
            set { SetValue(ProductnameProperty, value); }
        }

        public static readonly DependencyProperty ProductnameProperty =
            DependencyProperty.Register(nameof(Productname), typeof(string), typeof(producttpl), new PropertyMetadata("Product"));

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register(nameof(Productname), typeof(string), typeof(producttpl), new PropertyMetadata("..."));

        public producttpl()
        {
            InitializeComponent();
        }
    }
}
