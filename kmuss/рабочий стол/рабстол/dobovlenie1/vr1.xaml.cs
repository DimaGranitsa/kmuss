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
    /// Логика взаимодействия для vr1.xaml
    /// </summary>
    public partial class vr1 : Window
    {
        public vr1()
        {
            InitializeComponent();
        }

        private void Dobavit1_Click(object sender, RoutedEventArgs e)
        {
            model.vr1 qwe2 = new model.vr1()
            {

                naprovlenierabot = naprovlenierabot.Text,
                vidwork = vidwork.Text,
                ed = ed.Text,
                
            };
            conectbd.con.vr1.Add(qwe2);
            conectbd.con.SaveChanges();
        }

        private void Ed_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
