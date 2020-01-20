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

namespace Login
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool isValidPassword = tbPassword.Password.Any(char.IsDigit)
                                   && tbPassword.Password.Any(char.IsLetter)
                                   && tbPassword.Password.Length >= 6;
            bool leng = tbPassword.Password.Length >= 6;
            bool inte = tbPassword.Password.Any(char.IsLetter);
            bool chara = tbPassword.Password.Any(char.IsDigit);
            if (isValidPassword == true)
            {
                MessageBox.Show("Zadali jste správně heslo!!!!");
            }
            else
            {
                if (leng)
                {
                    if (chara)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Musí obsahovat alespoň 1 číslici");
                    }
                }
                else
                {
                    MessageBox.Show("Musíš zadat alespoň 6 znaků");
                }
            }
        }
    }
}
