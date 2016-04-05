using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ClientWPF
{
    /// <summary>
    /// Logique d'interaction pour add_view.xaml
    /// </summary>
    public partial class add_view : Window
    {
        List<ServiceAgence.BienImmobilierBase> liste = null;

        public add_view()
        {
            InitializeComponent();
            LoadListBox<ServiceAgence.BienImmobilierBase.eTypeTransaction>(comboBox_typeTransaction, true);
            LoadListBox<ServiceAgence.BienImmobilierBase.eTypeBien>(comboBox_typeBien, true);
            LoadListBox<ServiceAgence.BienImmobilierBase.eTypeChauffage>(comboBox_typeChauffage, true);
            LoadListBox<ServiceAgence.BienImmobilierBase.eEnergieChauffage>(comboBox_energieChauffage, true);
        }


        public void LoadListBox<T>(ComboBox cb, bool ajouterTous = false)
        {
            cb.Items.Clear();

            foreach (int value in Enum.GetValues(typeof(T)))
            {
                cb.Items.Add(value.ToString());
            }
        }

        private void textBox_valider_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
