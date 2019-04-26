﻿#define rootAccess
using System.Windows;
using System.Windows.Controls;
using Geometrical_figures;
using System.Collections.ObjectModel;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		//TODO:!!! static
        public static ObservableCollection<FigureBase> figureList = new ObservableCollection<FigureBase>();
        
        System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<FigureBase>));
        System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(ObservableCollection<FigureBase>));
        /// <summary>
        /// Инициализация главного окна
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();        
            
#if rootAccess
            randomButton.Visibility = Visibility.Visible;
#else
            randomButton.Visibility=Visibility.Hidden;
#endif
        }
        /// <summary>
        /// Кнопка вызова окна для созданию новой фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newFigure = new NewFigure
            {
                Owner = this
            };
            newFigure.Show();
        }
        /// <summary>
        /// Кнопка удаления фигуры из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (figureListBox.Items.Count > 0)
            {
                figureList.RemoveAt(figureListBox.Items.IndexOf(figureListBox.SelectedItem));
            }
        }
        /// <summary>
        /// Кнопка вызова формы для поиска фигуры в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		/// //TODO: Нарушение инкапсуляции
        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var searchWindow = new SearchWindow
            {
                Owner = this
            };
            searchWindow.Show();
        }
        /// <summary>
        /// Изменение в составе элементов с списке фигур
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FigureListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            figureDataGrid.ItemsSource = null;
            figureDataGrid.Items.Clear();
            figureDataGrid.ItemsSource = figureListBox.SelectedItems;
        }
        /// <summary>
        /// Обновление элемента LIstBox
        /// </summary>
		/// //TODO: Нарушение инкапсуляции
        public void UpdateListBox()
        {
            figureListBox.ItemsSource = figureList;
            figureListBox.Items.Refresh();
        }
        private void FigureDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }      
        
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
#if rootAcces            
            FigureBase figure;
            Random rnd = new Random();

            switch (rnd.Next(1, 4))
            {
                case 1:
                    figure = new Rectangle(rnd.Next(1, 99), rnd.Next(1, 99));
                    figureList.Add(figure);
                    break;
                case 2:
                    figure = new Triangle(rnd.Next(1, 99), rnd.Next(1, 99));
                    figureList.Add(figure);
                    break;
                case 3:
                    figure = new Circle(rnd.Next(1, 99));
                    figureList.Add(figure);
                    break;
            }
            UpdateListBox();
#else
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
            SearchWindow searchWindow = new SearchWindow
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
            MessageBox.Show("Автор: Петров А.А. \nE-mail: artem.petrov11@mail.ru");
        }
        private void OpenMenuItemClick(object sender, RoutedEventArgs e)
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
                    file.Close();
                    UpdateListBox();
                    MessageBox.Show($"Файл {openFile.FileName} успешно сохранен.");
                }
            }
        }
        private void SaveMenuitemClick(object sender, RoutedEventArgs e)
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
    }
}