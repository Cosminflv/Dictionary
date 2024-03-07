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
using Tema1.Entities;

namespace Tema1
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private ControllerEntity _controllerEntity;
        public LoginWindow(ControllerEntity controllerEntity)
        {
            _controllerEntity = controllerEntity;
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            bool result = _controllerEntity.performLogin(username, password);

            if (!result)
            {
                //display error message
                ErrorMessageLabel.Visibility = Visibility.Visible; return;
            }

            ErrorMessageLabel.Visibility = Visibility.Collapsed; return;

        }
    }
}
