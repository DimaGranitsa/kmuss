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

namespace kmuss.рабочий_стол.рабстол
{
    /// <summary>
    /// Логика взаимодействия для rabstol.xaml
    /// </summary>
    public partial class rabstol : Page
    {


        public rabstol()
        {
            InitializeComponent();
            //DGrid.ItemsSource = conectbd.con.naprovlenie.ToList();
            //DGrid2.ItemsSource = conectbd.con.kc1.ToList();
            //DGrid4.ItemsSource = conectbd.con.oplatarabota.ToList();
            //DGrid5.ItemsSource = conectbd.con.platamaterial.ToList();
            //DGrid1.ItemsSource = conectbd.con.rabota.ToList();
            //DGrid3.ItemsSource = conectbd.con.vr1.ToList();
        }


        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void TcSample_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void YdalitiztablTab_Click(object sender, RoutedEventArgs e)
        {
            //var a = DGrid.SelectedItem as model.naprovlenie;
            //DGrid.SelectedItems.Remove(a);
            //conectbd.con.SaveChanges();

            //var q = DGrid.SelectedItems as model.naprovlenie;
            //DGrid.SelectedItems.Remove(q);
            //conectbd.con.SaveChanges();

            //var w = DGrid2.SelectedItems as model.kc1;
            //DGrid2.SelectedItems.Remove(w);
            //conectbd.con.SaveChanges();
            //var r = DGrid4.SelectedItems as model.oplatarabota;
            //DGrid4.SelectedItems.Remove(r);
            //conectbd.con.SaveChanges();
            //var t = DGrid1.SelectedItems as model.rabota;
            //DGrid1.SelectedItems.Remove(t);
            //conectbd.con.SaveChanges();
            //var y = DGrid3.SelectedItems as model.vr1;
            //DGrid3.SelectedItems.Remove(y);
            //conectbd.con.SaveChanges();

            //DGrid.ItemsSource = conectbd.con.naprovlenie.ToList();
            //DGrid2.ItemsSource = conectbd.con.kc1.ToList();
            //DGrid4.ItemsSource = conectbd.con.oplatarabota.ToList();
            //DGrid5.ItemsSource = conectbd.con.platamaterial.ToList();
            //DGrid1.ItemsSource = conectbd.con.rabota.ToList();
            //DGrid3.ItemsSource = conectbd.con.vr1.ToList();
        }








        private void Prosmotretifoni1Tab_Click_1(object sender, RoutedEventArgs e)
        {

            DGAg1.ItemsSource = conectbd.con.naprovlenie.ToList();
        }

        private void Prosmotretifoni2Tab_Click_2(object sender, RoutedEventArgs e)
        {
            DGAg2.ItemsSource = conectbd.con.rabota.ToList();


        }

        private void Prosmotretifoni3Tab_Click_1(object sender, RoutedEventArgs e)
        {
            DGAg3.ItemsSource = conectbd.con.kc1.ToList();
        }

        private void Prosmotretifoni4Tab_Click_1(object sender, RoutedEventArgs e)
        {
            DGAg4.ItemsSource = conectbd.con.vr1.ToList();
        }

        private void Prosmotretifoni5Tab_Click_1(object sender, RoutedEventArgs e)
        {
            DGAg6.ItemsSource = conectbd.con.oplatarabota.ToList();
        }

        private void Prosmotretifoni6Tab_Click_1(object sender, RoutedEventArgs e)
        {
            DGAg7.ItemsSource = conectbd.con.platamaterial.ToList();
        }

        private void BtnPreviousTab_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Prosmotretifoni7Tab_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete1_Click(object sender, RoutedEventArgs e)
        {
            var b = DGAg1.SelectedItem as model.naprovlenie;
            if (b != null)
            {
                conectbd.con.naprovlenie.Remove(b);
                conectbd.con.SaveChanges();

            }
            else { MessageBox.Show("Такой записи нет"); }
        }

        private void Dobavit1_Click(object sender, RoutedEventArgs e)
        {
            Window qw = new Window1();
            qw.Show();
        }

        private void Obnovlenie1_Click(object sender, RoutedEventArgs e)
        {
            DGAg1.ItemsSource = conectbd.con.naprovlenie.ToList();
        }

        private void Obnovlenie2_Click(object sender, RoutedEventArgs e)
        {
            DGAg2.ItemsSource = conectbd.con.rabota.ToList();
        }

        private void Dobavit2_Click(object sender, RoutedEventArgs e)
        {
            Window qw = new rabota();
            qw.Show();
           
        }

        private void Obnovlenie3_Click(object sender, RoutedEventArgs e)
        {
            DGAg3.ItemsSource = conectbd.con.kc1.ToList();
        }

        private void Dobavit3_Click(object sender, RoutedEventArgs e)
        {
            Window qw = new dobovlenie1.ks1();
            qw.Show();
        }

        private void Obnovlenie4_Click(object sender, RoutedEventArgs e)
        {
            DGAg4.ItemsSource = conectbd.con.vr1.ToList();
        }

        private void Dobavit4_Click(object sender, RoutedEventArgs e)
        {
            Window qw = new dobovlenie1.vr1();
            qw.Show();
        }

        private void Obnovlenie5_Click(object sender, RoutedEventArgs e)
        {
            DGAg6.ItemsSource = conectbd.con.oplatarabota.ToList();
        }

        private void Dobavit5_Click(object sender, RoutedEventArgs e)
        {
            Window qw = new dobovlenie1.oplatarabota();
            qw.Show();
        }

        private void Obnovlenie7_Click(object sender, RoutedEventArgs e)
        {
            DGAg7.ItemsSource = conectbd.con.platamaterial.ToList();
        }

        private void Dobavit6_Click(object sender, RoutedEventArgs e)
        {
            Window qw = new dobovlenie1.oplatamateriala();
            qw.Show();
        }

        private void Delete6_Click(object sender, RoutedEventArgs e)
        {
            var b = DGAg7.SelectedItem as model.platamaterial;
            if (b != null)
            {
                conectbd.con.platamaterial.Remove(b);
                conectbd.con.SaveChanges();

            }
            else { MessageBox.Show("Такой записи нет"); }

        }

        private void Delete5_Click(object sender, RoutedEventArgs e)
        {
            var b = DGAg6.SelectedItem as model.oplatarabota;
            if (b != null)
            {
                conectbd.con.oplatarabota.Remove(b);
                conectbd.con.SaveChanges();

            }
            else { MessageBox.Show("Такой записи нет"); }
        }

        private void Delete4_Click(object sender, RoutedEventArgs e)
        {
            var b = DGAg4.SelectedItem as model.vr1;
            if (b != null)
            {
                conectbd.con.vr1.Remove(b);
                conectbd.con.SaveChanges();

            }
            else { MessageBox.Show("Такой записи нет"); }
        }

        private void Delete3_Click(object sender, RoutedEventArgs e)
        {
            var b = DGAg3.SelectedItem as model.kc1;
            if (b != null)
            {
                conectbd.con.kc1.Remove(b);
                conectbd.con.SaveChanges();

            }
            else { MessageBox.Show("Такой записи нет"); }
        }

        private void Delete2_Click(object sender, RoutedEventArgs e)
        {
            var b = DGAg2.SelectedItem as model.rabota;
            if (b != null)
            {
                conectbd.con.rabota.Remove(b);
                conectbd.con.SaveChanges();

            }
            else { MessageBox.Show("Такой записи нет"); }
        }

        private void DGAg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

   
}
    

