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

namespace kmuss.registracia
{
    /// <summary>
    /// Логика взаимодействия для regostracoa.xaml
    /// </summary>
    public partial class regostracoa : Page
    {
      
        public regostracoa()
        {
            InitializeComponent();
        }

        private void Vhodvkobinet_Click(object sender, RoutedEventArgs e)
        {
            var a = conectbd.con.admin.Where(z => z.Name == txtUsername.Text && z.pass == txtpassword.Password).FirstOrDefault();
            if (a !=null)
            {
                MessageBox.Show("ok");
                NavigationService.Navigate(new рабочий_стол.рабстол.rabstol());
               
            }
            else
            {

                MessageBox.Show("incorect");
            }
            




        
            
            

           
        }
    }
}
