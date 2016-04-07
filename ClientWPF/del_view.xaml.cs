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
    /// Logique d'interaction pour del_view.xaml
    /// </summary>
    /// 

    public partial class del_view : Window
    {

        private int objID = 0;

        public del_view(int objID)
        {
            
            InitializeComponent();
        }

        private void Oui_Click(object sender, RoutedEventArgs e)
        {

            using (ServiceAgence.AgenceClient client = new ServiceAgence.AgenceClient())
            {
                client.SupprimerBienImmobilier("3");
                //objID.ToString()
            }

            this.Close();
        }

        private void Non_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
