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
using System.Windows.Threading;
using Tema1.Entities;

namespace Tema1
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private string guessedWord;
        private int score;
        private bool guessed;

        private GameController _gameController;

        private DispatcherTimer statusLabelDisplayTimer;
        public GameWindow(JsonHandlerEntity jsonHandlerEntity)
        {
            score = 0;
            guessed = false;
            guessedWord = "";
            InitializeComponent();

            InitializeTimer();

            _gameController = new GameController(jsonHandlerEntity);
            _gameController.initDictionary();
            _gameController.startGame();

            DisplayNextWord();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            guessedWord = GuessBox.Text;
        }

        private void CheckWordButton_Click(object sender, RoutedEventArgs e)
        {
            if (guessed) return;

            if (guessedWord == "")
            {
                DisplayTakeAGuess();
                return;
            }

            if (_gameController.CheckEnteredWord(guessedWord))
            {
                score++;
                StatusLabel.Content = "Correct";
                StatusLabel.Visibility = Visibility.Visible;
                StatusLabel.Foreground = Brushes.Green;
            }
            else
            {
                StatusLabel.Content = "Wrong";
                StatusLabel.Visibility = Visibility.Visible;
                StatusLabel.Foreground = Brushes.Red;
            }
            guessed = true;
            NextWordButton.Visibility = Visibility.Visible;
        }

        private void NextWordButton_Click(object sender, RoutedEventArgs e)
        {
            NextWordButton.Visibility = Visibility.Hidden;

            if(_gameController.IsGameFinished())
            {
                RestartGame();
                return;
            }

            ClearScreen();

            if (_gameController.consumeWord())
            {
                DisplayNextWord();
                guessed = false;
                return;
            }

            DisplayResults();
        }

        private void Error_Timer_Tick(object sender, EventArgs e)
        {
            StatusLabel.Visibility = Visibility.Collapsed;
            statusLabelDisplayTimer.Stop();
        }

        private void InitializeTimer()
        {
            statusLabelDisplayTimer = new DispatcherTimer();
            statusLabelDisplayTimer.Interval = TimeSpan.FromSeconds(2);
            statusLabelDisplayTimer.Tick += Error_Timer_Tick!;
        }

        private void DisplayNextWord()
        {
            string wordInfo = _gameController.GetRandomDescriptionOrImagePath();
            if (wordInfo.Contains('/') || wordInfo.Contains('\\'))
            {
                ImageContainer.Source = _gameController.ConvertStringToImageSource(wordInfo);
                ImageContainer.Visibility = Visibility.Visible;
                DescriptionLabel.Visibility = Visibility.Hidden;
            }
            else
            {
                DescriptionLabel.Content = wordInfo;
                DescriptionLabel.Visibility = Visibility.Visible;
                ImageContainer.Visibility = Visibility.Hidden;
            }
        }

        private void ClearScreen()
        {

            StatusLabel.Visibility = Visibility.Visible;
            statusLabelDisplayTimer.Start();
            StatusLabel.Content = "Check Word First";

            StatusLabel.Visibility = Visibility.Hidden;
            DescriptionLabel.Visibility = Visibility.Hidden;
            ImageContainer.Visibility = Visibility.Hidden;
        }

        private void DisplayTakeAGuess()
        {
            StatusLabel.Content = "Take a guess";
            StatusLabel.Visibility = Visibility.Visible;
            StatusLabel.Foreground = Brushes.Red;
            statusLabelDisplayTimer.Start();
        }

        private void DisplayResults()
        {
            StatusLabel.Content = $"{score}/5 Correct";
            StatusLabel.Foreground = Brushes.Black;
            StatusLabel.Visibility = Visibility.Visible;
            NextWordButton.Content = "Start Game";
            NextWordButton.Visibility = Visibility.Visible;
        }

        private void RestartGame()
        {
            _gameController.startGame();
            DisplayNextWord();
            guessed = false;
            NextWordButton.Content = "Next Word";
        }
    }
}
