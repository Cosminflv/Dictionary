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
using Tema1.Windows;

namespace Tema1
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private AdminController _adminController;
        public LoginWindow(Tema1.Entities.JsonHandlerEntity jsonHandlerEntity)
        {
            _adminController = new AdminController(jsonHandlerEntity);

            InitializeComponent();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            bool result = _adminController.performLogin(username, password);

            if (!result)
            {
                //display error message
                ErrorMessageLabel.Visibility = Visibility.Visible; return;
            }

            AdminWindow adminWindow = new AdminWindow(_adminController.JsonHandlerEntity);
            adminWindow.Show();
            this.Close(); 
            ErrorMessageLabel.Visibility = Visibility.Collapsed;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
