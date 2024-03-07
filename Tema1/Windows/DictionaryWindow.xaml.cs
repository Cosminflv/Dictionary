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
                CategoryComboBox.ItemsSource = _controllerEntity.DictionaryEntity!.categories!.Keys;
        }

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = CategoryComboBox.SelectedIndex;

            string? selectedCategory = _controllerEntity.DictionaryEntity!.getCategoryByIndex(selectedIndex);

            if (selectedCategory == null) return;

            List<WordEntity> filteredWords = _controllerEntity.searchByCategory(selectedCategory);

            if (filteredWords.Count == 0) return;

            // Clear existing items
            SearchTextBox.Items.Clear();

            // Add matching words to the ComboBox
            foreach (var word in filteredWords)
            {
                SearchTextBox.Items.Add(word.Name);
            }

            // Open the ComboBox dropdown
            SearchTextBox.IsDropDownOpen = true;
            
        }


        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchTextBox.Text.ToLower();

            if (string.IsNullOrEmpty(searchText)) { return; }

            int selectedIndex = CategoryComboBox.SelectedIndex;

            string? selectedCategory = _controllerEntity.DictionaryEntity!.getCategoryByIndex(selectedIndex);

            List<WordEntity> matchingWords = _controllerEntity.search(searchText, selectedCategory);

            if(matchingWords.Count == 0) { SearchTextBox.IsDropDownOpen = false; return; }

            // Clear existing items
            SearchTextBox.Items.Clear();

            // Add matching words to the ComboBox
            foreach (var word in matchingWords)
            {
                SearchTextBox.Items.Add(word.Name);
            }

            // Open the ComboBox dropdown
            SearchTextBox.IsDropDownOpen = true;
            
        }


        private void SearchTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            return;
        }
    }
}
