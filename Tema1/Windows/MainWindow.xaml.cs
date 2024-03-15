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
        //    new WordEntity("Minge", "Obiect sportiv", "Sport", "/images/minge.JPG"),
        //    new WordEntity("Laptop", "Obiect electronic", "Electronice", "/images/laptop.JPG"),
        //    new WordEntity("Aspirina", "Obiect medicinal", "Sanatate", "/images/aspirina.JPG"),
        //    new WordEntity("Racheta", "Obiect sportiv pentru badminton", "Sport", "/images/racheta.JPG"),
        //    new WordEntity("Manusa", "Obiect sportiv pentru baseball", "Sport", "/images/manusa.JPG"),
        //};
        //    jsonHandlerEntity.serializeWords(words, @"..\..\..\Json\Words.json");
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
            var gameWindow = new GameWindow(jsonHandlerEntity);
            gameWindow.Show();
            this.Close();   
            
        }
    }
}