using Microsoft.VisualBasic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tema1.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace Tema1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ControllerEntity controllerEntity;
        private JsonHandlerEntity jsonHandlerEntity;

        public MainWindow()
        {
            jsonHandlerEntity = new JsonHandlerEntity();
            controllerEntity = new ControllerEntity();
            InitializeComponent();

        //    List<WordEntity> words = new List<WordEntity>() {
        //    new WordEntity("Minge", "Obiect sportiv", "Sport", "D:\\Informatica\\ANUL II\\MAP\\MAPTema1\\Tema1\\images\\minge.JPG"),
        //    new WordEntity("Laptop", "Obiect electronic", "Electronice", "D:\\Informatica\\ANUL II\\MAP\\MAPTema1\\Tema1\\images\\laptop.JPG"),
        //    new WordEntity("Aspirina", "Obiect medicinal", "Sanatate", "D:\\Informatica\\ANUL II\\MAP\\MAPTema1\\Tema1\\images\\aspirina.JPG"),
        //    new WordEntity("Racheta", "Obiect sportiv pentru badminton", "Sport", "D:\\Informatica\\ANUL II\\MAP\\MAPTema1\\Tema1\\images\\racheta.JPG"),
        //    new WordEntity("Manusa", "Obiect sportiv pentru baseball", "Sport", "D:\\Informatica\\ANUL II\\MAP\\MAPTema1\\Tema1\\images\\manusa.JPG"),
        //};
        //    jsonHandlerEntity.serializeWords(words, "D:\\Informatica\\ANUL II\\MAP\\MAPTema1\\Tema1\\Json\\Words.json");
        }

        private void Admin_Button_Click(object sender, RoutedEventArgs e)
        {
          var loginWindow = new LoginWindow(jsonHandlerEntity);
            loginWindow.Show();
            this.Close();
        }

        private void Dictionary_Button_Click(object sender, RoutedEventArgs e)
        {
           var dictionaryWindow = new DictionaryWindow(controllerEntity);
            dictionaryWindow.Show();
            this.Close();   
     

        }

        private void Game_Button_Click(object sender, RoutedEventArgs e)
        {
            var gameWindow = new GameWindow();
            gameWindow.Show();
            this.Close();   
            
        }
    }
}