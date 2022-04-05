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
    /// Логика взаимодействия для ks1.xaml
    /// </summary>
    public partial class ks1 : Window
    {
        public ks1()
        {
            InitializeComponent();
        }

        private void Dobavit1_Click(object sender, RoutedEventArgs e)
        {
            model.kc1 qwe2 = new model.kc1()
            {

                naprovlenierabot = naprovlenierabot.Text,
                ed = ed.Text,
                price = Convert.ToInt32(price.Text),
                costwithvat = Convert.ToInt32(costwithvat.Text),
            };
            conectbd.con.kc1.Add(qwe2);
            conectbd.con.SaveChanges();
        }
    }
}
