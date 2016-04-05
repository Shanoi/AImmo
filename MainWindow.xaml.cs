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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

//Machine

namespace ClientWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private Dictionary<string, object> _propertyValues = new Dictionary<string, object>();

        public event PropertyChangedEventHandler PropertyChanged;

        private object GetProperty([CallerMemberName] string propertyName = null)
        {

            if (_propertyValues.ContainsKey(propertyName)) return _propertyValues[propertyName];

            return null;

        }

        private bool SetProperty<T>(T newValue, [CallerMemberName] string propertyName = null)
        {

            T current = (T)GetProperty(propertyName);

            if (!EqualityComparer<T>.Default.Equals(current, newValue))
            {

                _propertyValues[propertyName] = newValue;
                if (PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

                }

                return true;

            }

            return false;

        }

        public ObservableCollection<ServiceAgence.BienImmobilierBase> _ListeBiens { get; set; }

        public ObservableCollection<ServiceAgence.BienImmobilierBase> ListeBiens
        {

            get
            {

                return (ObservableCollection<ServiceAgence.BienImmobilierBase>)GetProperty();

            }
            set
            {

                SetProperty(value);

            }

        }

        public MainWindow()
        {

            this.DataContext = this;


            InitializeComponent();

        }

        private void btn_change_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {



            }    


        }


        protected void Page_Load(object sender, EventArgs e)
        {
            this.ListeBiens = new ObservableCollection<ServiceAgence.BienImmobilierBase>();

            using (ServiceAgence.AgenceClient _service = new ServiceAgence.AgenceClient())
            {

                ServiceAgence.CriteresRechercheBiensImmobiliers criteres = new ServiceAgence.CriteresRechercheBiensImmobiliers();
                criteres.DateMiseEnTransaction1 = null;
                criteres.DateMiseEnTransaction2 = null;
                criteres.DateTransaction1 = null;
                criteres.DateTransaction2 = null;
                criteres.EnergieChauffage = null;
                criteres.MontantCharges1 = -1;
                criteres.MontantCharges2 = -1;
                criteres.NbEtages1 = -1;
                criteres.NbEtages2 = -1;
                criteres.NbPieces1 = -1;
                criteres.NbPieces2 = -1;
                criteres.NumEtage1 = -1;
                criteres.NumEtage2 = -1;
                criteres.Prix1 = -1;
                criteres.Prix2 = -1;
                criteres.Surface1 = -1;
                criteres.Surface2 = -1;
                criteres.TransactionEffectuee = null;

                ServiceAgence.ResultatListeBiensImmobiliers resultat;
                resultat = _service.LireListeBiensImmobiliers(criteres, null, null);

                // ListeBiens = resultat.Liste;

                if (resultat.SuccesExecution)
                {
                   
                        //ListeBiens = resultat.Liste.List;
                }
                else
                {
                    ListeBiens = new ObservableCollection<ServiceAgence.BienImmobilierBase>();
                    //this.lblErreurs.Text = resultat.ErreursBloquantes.ToString();
                }


            }

        }

    }
}
