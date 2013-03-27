using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Dormulaire_DB.Web;
using System.Collections;
namespace Dormulaire_DB.Views
{
    public partial class Details : Page
    {
        TherenceDomain Tdom = new TherenceDomain(); 

        public Details()
        {
            InitializeComponent();

            IEnumerable<Utilisateur>  MesUsers = Tdom.Load(Tdom.GetUtilisateurQuery()).Entities;
            this.DataUser.ItemsSource  = MesUsers  ;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
}
