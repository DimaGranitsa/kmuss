﻿using System;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
        }

        private void Dobavit_Click(object sender, RoutedEventArgs e)
        {
            model.naprovlenie qwe = new model.naprovlenie()
            {
                IDnaprovlenie = Convert.ToInt32(IDnaprovlenie.Text),
                naprovlenierabot1 = naprovlenierabot1.Text

            };
            conectbd.con.naprovlenie.Add(qwe);
            conectbd.con.SaveChanges();

        }
    }
}
