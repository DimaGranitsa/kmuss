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

namespace kmuss.рабочий_стол.рабстол
{
    /// <summary>
    /// Логика взаимодействия для rabota.xaml
    /// </summary>
    public partial class rabota : Window
    {
        public rabota()
        {
            InitializeComponent();
        }

        private void Dobavit1_Click(object sender, RoutedEventArgs e)
        {
            model.rabota qwe1 = new model.rabota()
            {
                ID = Convert.ToInt32(ID.Text),
                naprovlenierabot = naprovlenierabot.Text

            };
            conectbd.con.rabota.Add(qwe1);
            conectbd.con.SaveChanges();
        }
    }
}
