#define rootAccess
using System;
using System.Windows;
using System.Windows.Controls;
using Geometrical_figures;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {           
        private ObservableCollection<FigureBase> figureList = new ObservableCollection<FigureBase>();
        System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<FigureBase>));
        System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<FigureBase>));

        private void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            FigureListUpdate();          
        }
        /// <summary>
        /// Инициализация главного окна
        /// </summary>
        public MainWindow()
        {            
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            figureList.CollectionChanged += Users_CollectionChanged;
#if rootAccess
            randomButton.Visibility = Visibility.Visible;
#else
            randomButton.Visibility=Visibility.Hidden;
#endif
        }
        
        private void AddFigureButton(object sender, RoutedEventArgs e)
        {
            var newFigure = new NewFigure(figureList)
            {
                Owner = this
            };
            newFigure.Show(); 
        }
        
        private void RemoveFigureButton(object sender, RoutedEventArgs e)
        {
            try
            {
                if (figureListBox.Items.Count > 0)
                {
                    figureList.RemoveAt(figureListBox.Items.IndexOf(figureListBox.SelectedItem));
                }
            }
            catch
            {
                MessageBox.Show("Выберите фигуру в списке");
            }
        }
        
        private void SearchFigureButton(object sender, RoutedEventArgs e)
        {
            var searchWindow = new SearchWindow(figureList)
            {
                Owner = this
            };
            searchWindow.Show();
        }
        
        private void FigureListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            figureDataGrid.ItemsSource = null;
            figureDataGrid.Items.Clear();
            figureDataGrid.ItemsSource = figureListBox.SelectedItems;
        }

        private void FigureDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ExitButton(object sender, RoutedEventArgs e)
        {
            Close();
        }           
        
        private void AddRandomFigureButton(object sender, RoutedEventArgs e)
        {
#if rootAcces           
#else
            FigureBase figure;
            Random rnd = new Random();
            List<double> rand = new List<double>();
            switch (rnd.Next(1, 4))
            {                
                case 1:
                    rand.Add(rnd.Next(1, 99));
                    rand.Add(rnd.Next(1, 99));
                    figure = new Rectangle(rand);
                    figureList.Add(figure);
                    break;
                case 2:
                    rand.Add(rnd.Next(1, 99));
                    rand.Add(rnd.Next(1, 99));
                    figure = new Triangle(rand);
                    figureList.Add(figure);
                    break;
                case 3:
                    rand.Add(rnd.Next(1, 99));                    
                    figure = new Circle(rand);
                    figureList.Add(figure);
                    break;
            }          
#endif
        }       
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void AddFigure_Click(object sender, RoutedEventArgs e)
        {
            NewFigure newFigure = new NewFigure
            {
                Owner = this
            };
            newFigure.Show();
        }
        private void RemoveFigure_Click(object sender, RoutedEventArgs e)
        {
            if (figureListBox.Items.Count > 0)
            {
                figureList.RemoveAt(figureListBox.Items.IndexOf(figureListBox.SelectedItem));
            }
        }
        private void SearchFigure_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow(figureList)
            {
                Owner = this
            };
            searchWindow.Show();
        }
        private void License_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы пользуетесь демо-версией. Лицензия не требуется.");
        }
        private void Contacts_Click(object sender, RoutedEventArgs e)
        {
            Contacts contacts = new Contacts();
            contacts.Show();    
        }
        private void OpenFileMenuItemClick(object sender, RoutedEventArgs e)
        {
            var openFile = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Text documents (*.lol)|*.lol|All files (*.*)|*.*"
            };
            openFile.ShowDialog();
            if (string.IsNullOrWhiteSpace(openFile.FileName) == false)
            {               
                using (var file = System.IO.File.OpenRead(openFile.FileName))
                {
                    figureList = (ObservableCollection<FigureBase>)reader.Deserialize(file);
                    FigureListUpdate();                  
                    file.Close();                    
                    MessageBox.Show($"Файл {openFile.FileName} успешно открыт.");
                }
            }
        }
        private void SaveFileMenuitemClick(object sender, RoutedEventArgs e)
        {           
            var saveFile = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "Text documents (*.lol)|*.lol|All files (*.*)|*.*"
            };
            saveFile.ShowDialog();
            if (string.IsNullOrWhiteSpace(saveFile.FileName) == false)
            {                
                using (var file = System.IO.File.Create(saveFile.FileName))
                {
                    writer.Serialize(file, figureList);
                    file.Close();
                    MessageBox.Show($"Файл {saveFile.FileName} успешно сохранен.");
                }
            }
        } 
        private void FigureListUpdate()
        {
            figureListBox.ItemsSource = figureList;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}