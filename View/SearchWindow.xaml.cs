using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Geometrical_figures;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Linq;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        private ObservableCollection<FigureBase> searchList = new ObservableCollection<FigureBase>();
        private ObservableCollection<FigureBase> figureListFromMainForm = new ObservableCollection<FigureBase>();

        public SearchWindow(ObservableCollection<FigureBase> figureList)
        {
            InitializeComponent();
            figureListFromMainForm = figureList;
            allFigure.IsChecked = true;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (allFigureWithParam.IsChecked == true)
            {
                allFigure.IsChecked = false;
                figuresWithParam.IsChecked = false;
            }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void AllFigure_Checked(object sender, RoutedEventArgs e)
        {
            if (allFigure.IsChecked == true)
            {
                allFigureWithParam.IsChecked = false;
                figuresWithParam.IsChecked = false;
            }
        }
        private void AllFigure_Click(object sender, RoutedEventArgs e)
        {
            allFigure.IsChecked = true;
        }
        private void AllFigureWithParam_Click(object sender, RoutedEventArgs e)
        {
            allFigureWithParam.IsChecked = true;
        }
        private void FiguresWithParam_Click(object sender, RoutedEventArgs e)
        {
            figuresWithParam.IsChecked = true;
        }
        private void FiguresWithParam_Checked(object sender, RoutedEventArgs e)
        {
            if (figuresWithParam.IsChecked == true)
            {
                allFigure.IsChecked = false;
                allFigureWithParam.IsChecked = false;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            searchList.Clear();
            int countOfFoundFigures = 0;
            searchListBox.ItemsSource = null;            
            var trueIndicator = false;          
            if (allFigure.IsChecked == true)
            {
                foreach (FigureBase elements in figureListFromMainForm.ToArray())
                {
                    if (elements.GetType().Name == figureComboBox.Text)
                    {
                        searchList.Add(elements);
                        countOfFoundFigures++;
                    }
                }
            }
            else if (allFigureWithParam.IsChecked == true)
            {
                foreach (FigureBase elements in figureListFromMainForm.ToArray())
                {
                    trueIndicator = false;
                    PropertyInfo[] propertys = elements.GetType().GetProperties();
                    foreach (var property in propertys)
                    {
                        if (property.GetValue(elements).ToString() == figureParamTextBox.Text)
                        {
                            trueIndicator = true;
                        }
                    }
                    if (trueIndicator == true)
                    {
                        searchList.Add(elements);
                        countOfFoundFigures++;
                    }
                }
            }
            else if (figuresWithParam.IsChecked == true)
            {

                foreach (FigureBase elements in figureListFromMainForm.ToArray())
                {
                    trueIndicator = false;
                    if (elements.GetType().Name == figureTypeComboBox.Text)
                    {
                        PropertyInfo[] propertys = elements.GetType().GetProperties();
                        foreach (var property in propertys)
                        {
                            if (property.GetValue(elements).ToString() == figureParam2TextBox.Text)
                            {
                                trueIndicator = true;
                            }
                        }
                    }
                    if (trueIndicator == true)
                    {
                        searchList.Add(elements);
                        countOfFoundFigures++;
                    }
                }
            }
            searchListBox.ItemsSource = searchList;
            searchListBox.Items.Refresh();
            if (countOfFoundFigures == 0)
            {
                foundFigures.Content = "No matches was found. Change the settings and try again.";
                foundFigures.Foreground = Brushes.Red;
            }
            else
            {
                foundFigures.Content = $"{countOfFoundFigures} figures was found.";
                foundFigures.Foreground = Brushes.Green;
            }
        }
        private void SearchListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            searchDataGrid.ItemsSource = null;
            searchDataGrid.Items.Clear();
            searchDataGrid.ItemsSource = searchListBox.SelectedItems;
        }
        private void SearchDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}