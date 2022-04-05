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

namespace kmuss.рабочий_стол.рабстол.dobovlenie1
{
    /// <summary>
    /// Логика взаимодействия для oplatamateriala.xaml
    /// </summary>
    public partial class oplatamateriala : Window
    {
        public oplatamateriala()
        {
            InitializeComponent();
        }

        private void Dobavit1_Click(object sender, RoutedEventArgs e)
        {
            model.platamaterial qwe2 = new model.platamaterial()
            {

                ID = Convert.ToInt32(ID.Text),
                name = name.Text,
                ed = Convert.ToInt32(ed.Text),
                price = Convert.ToInt32(price.Text),
                theamount = Convert.ToInt32(theamount.Text),
                intotal = Convert.ToInt32(intotal.Text),
            };
            conectbd.con.platamaterial.Add(qwe2);
            conectbd.con.SaveChanges();
        }
    }
}
