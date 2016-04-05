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
            LoadListBox<ServiceAgence.BienImmobilierBase.eTypeTransaction>(listBox_typeTransaction, true);
            LoadListBox<ServiceAgence.BienImmobilierBase.eTypeBien>(listBox_typeBien, true);
            LoadListBox<ServiceAgence.BienImmobilierBase.eTypeChauffage>(listBox_typeChauffage, true);
            LoadListBox<ServiceAgence.BienImmobilierBase.eEnergieChauffage>(listBox_energieChauffage, true);
        }


        public void LoadListBox<T>(ListBox cb, bool ajouterTous = false)
        {

            cb.Items.Clear();

            if (ajouterTous)
               // cb.Items.Add(new ListItem("Tous", ""));

            foreach (int value in Enum.GetValues(typeof(T)))
            {

                //cb.Items.Add(new ListItem(Enum.GetName(typeof(T), value), value.ToString()));

            }
        }
    }
}
