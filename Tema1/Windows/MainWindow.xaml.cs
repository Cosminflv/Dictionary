﻿using System.Text;
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

namespace Tema1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ControllerEntity controllerEntity;
        public MainWindow()
        {
            controllerEntity = new ControllerEntity();
            InitializeComponent();

            //List<WordEntity> words = new List<WordEntity>() {
            //    new WordEntity("Minge", "Obiect sportiv", "Sport", null),
            //    new WordEntity("Laptop", "Obiect electronic", "Electronice", null),
            //    new WordEntity("Aspirina", "Obiect medicinal", "Sanatate", null),
            //    new WordEntity("Racheta", "Obiect sportiv pentru badminton", "Sport", null),
            //    new WordEntity("Manusa", "Obiect sportiv pentru baseball", "Sport", null),
            //};
            //JsonHandlerEntity jsonHandlerEntity = new JsonHandlerEntity();
            //jsonHandlerEntity.serializeWords(words, "D:\\Informatica\\ANUL II\\MAP\\Tema1\\Tema1\\Json\\Words.json");
        }

        private void Admin_Button_Click(object sender, RoutedEventArgs e)
        {
          var loginWindow = new LoginWindow(controllerEntity);
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