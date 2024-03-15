using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tema1
{
    public partial class DictionaryWindow : Window
    {
        private ControllerEntity _controllerEntity;

        public DictionaryWindow(ControllerEntity controllerEntity)
        {
            InitializeComponent();
            _controllerEntity = controllerEntity;
            _controllerEntity.initDictionary();
            if (_controllerEntity.initDictionary() == true)
            {
                CategoryComboBox.ItemsSource = _controllerEntity.DictionaryEntity!.categories!.Keys;
                SearchTextBox.ItemsSource = _controllerEntity.DictionaryEntity!.wordsNames();
            }
        }

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = CategoryComboBox.SelectedIndex;

            string? selectedCategory = _controllerEntity.DictionaryEntity!.getCategoryByIndex(selectedIndex);

            if (selectedCategory == null) return;

            List<WordEntity> filteredWords = _controllerEntity.searchByCategory(selectedCategory);

            if (filteredWords.Count == 0) return;

            List<string> wordNames = filteredWords.Select(word => word.Name).ToList();

            SearchTextBox.ItemsSource = wordNames;
            SearchTextBox.IsDropDownOpen = true;
        }


        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            int x = 0;
            string searchText = SearchTextBox.Text;
            if (e.Key == Key.Enter)
            {
                string description = _controllerEntity.GetDescriptionForWord(searchText);
                string imagePath = _controllerEntity.GetImageForWord(searchText);
                string category = _controllerEntity.GetCategoryForWord(searchText);

                if (_controllerEntity.checkTextValid(searchText))
                {
                    NameHeadline.Visibility = Visibility.Visible;
                    WordName.Text = searchText;
                    WordName.Visibility = Visibility.Visible;
                    DescriptionHeadLine.Visibility = Visibility.Visible;
                    Description.Text = description;
                    Description.Visibility = Visibility.Visible;
                    CategoryHeadline.Visibility = Visibility.Visible;
                    CategoryName.Text = category;
                    CategoryName.Visibility = Visibility.Visible;
                    ImageContainer.Source = _controllerEntity.ConvertStringToImageSource(imagePath);
                    ImageContainer.Visibility = Visibility.Visible;
                    return;
                }
                NameHeadline.Visibility = Visibility.Hidden;
                WordName.Visibility = Visibility.Hidden;
                DescriptionHeadLine.Visibility = Visibility.Hidden;
                Description.Visibility = Visibility.Hidden;
                CategoryHeadline.Visibility = Visibility.Hidden;
                CategoryName.Visibility = Visibility.Hidden;
                ImageContainer.Visibility = Visibility.Hidden;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
