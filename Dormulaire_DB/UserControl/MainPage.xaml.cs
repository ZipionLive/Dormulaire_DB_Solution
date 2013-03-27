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
using Dormulaire_DB.Web;
using System.IO;
using System.Windows.Media.Imaging;
namespace Dormulaire_DB
{
    public partial class MainPage : UserControl
    {
        byte[] TabB = null;
        TherenceDomain tDomain = new TherenceDomain();
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_Envoyer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO : ajoutez ici l’implémentation du gestionnaire d’événements.

            tDomain.Utilisateurs.Add(
            new Utilisateur() 
            { nom = txtNom.Text , 
              prenom=txtPrenom.Text , 
              age = dtNaiss.SelectedDate , 
              email = txtEmail.Text, 
              peuso = txtPseudo.Text, 
              avatar=TabB     
            }
            );

            tDomain.SubmitChanges();  

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG | *.jpg | GIF | *.gif | PNG | *.png";
            if (ofd.ShowDialog() == true)
            {
                //Image to byte[]
                fileToByteArr(ofd.File);
                //Image to screen
                ByteArrToImage(TabB, this.ImgAvatar  );
            }
        }

        private void fileToByteArr(FileInfo f)
        {
            using (FileStream str = f.OpenRead())
            {
                TabB = new byte[str.Length];
                
                str.Read(TabB, 0, TabB.Length);

  
            }
        }

        private void ByteArrToImage(byte[] paramByte, Image dest)
        {
            BitmapImage BI = new BitmapImage();
            BI.SetSource(new MemoryStream(paramByte));
            dest.Source = BI;

        }
    }
}
