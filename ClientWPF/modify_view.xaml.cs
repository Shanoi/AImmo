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

namespace ClientWPF
{
    /// <summary>
    /// Logique d'interaction pour modify_view.xaml
    /// </summary>
    public partial class modify_view : Window
    {
        public modify_view()
        {
            InitializeComponent();
        }

        private void textBox_valider_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
