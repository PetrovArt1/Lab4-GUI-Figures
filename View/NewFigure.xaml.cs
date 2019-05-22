using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Geometrical_figures;
using Rectangle = Geometrical_figures.Rectangle;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для NewFigure.xaml
    /// </summary>
    public partial class NewFigure : Window
    {
        private ObservableCollection<FigureBase> figureList;  

        public NewFigure()
        {            
            InitializeComponent();           
        }

        public NewFigure(ObservableCollection<FigureBase> figureList)
        {
            InitializeComponent();           
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            RectangleCheck.IsChecked = true;                      
            this.figureList = figureList;
            dataGridWithParameters.ColumnWidth = (dataGridWithParameters.Width / 2) - 4;  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void TriangleCheck_Click(object sender, RoutedEventArgs e)
        {
            TriangleCheck.IsChecked = true;
        }
        private void TriangleCheck_Checked(object sender, RoutedEventArgs e)
        {            
            if (TriangleCheck.IsChecked == true)
            {
                var dt = new DataTable();
                RectangleCheck.IsChecked = false;
                CircleCheck.IsChecked = false;
                PropertyInfo[] myPropertyInfo;
                Type myType = typeof(Triangle);
                myPropertyInfo = myType.GetProperties();
                dt.Columns.Add("Parameter");
                dt.Columns.Add("Value");                
                foreach (var property in myPropertyInfo)
                {
                    if (property.CanWrite)
                    {
                        dt.Rows.Add(property.Name);
                    }
                }
                dataGridWithParameters.ItemsSource = dt.AsDataView();                
            }
        }
        private void CircleCheck_Click(object sender, RoutedEventArgs e)
        {
            CircleCheck.IsChecked = true;
        }
        private void CircleleCheck_Checked(object sender, RoutedEventArgs e)
        {
            var dt = new DataTable();
            if (CircleCheck.IsChecked == true)
            {                
                dataGridWithParameters.Columns.Clear();
                dt.Columns.Clear();                
                RectangleCheck.IsChecked = false;
                TriangleCheck.IsChecked = false;
                PropertyInfo[] myPropertyInfo;
                Type myType = typeof(Circle);
                myPropertyInfo = myType.GetProperties();
                dt.Columns.Add("Parameter");
                dt.Columns.Add("Value");                
                foreach (var property in myPropertyInfo)
                {
                    if (property.CanWrite)
                    {
                        dt.Rows.Add(property.Name);
                    }
                }
                dataGridWithParameters.ItemsSource = dt.AsDataView();
            }
        }
        private void RectangleCheck_Click(object sender, RoutedEventArgs e)
        {
            RectangleCheck.IsChecked = true;
        }
        private void RectangleCheck_Checked(object sender, RoutedEventArgs e)
        {
            var dt = new DataTable(); 
           
            if (RectangleCheck.IsChecked == true)
            {                 
                TriangleCheck.IsChecked = false;
                CircleCheck.IsChecked = false;
                PropertyInfo[] myPropertyInfo;
                Type myType = typeof(Rectangle);
                myPropertyInfo = myType.GetProperties();
                dt.Columns.Add("Parameter");
                dt.Columns.Add("Value");                   
                foreach (var property in myPropertyInfo)
                {
                    if (property.CanWrite)
                    {                       
                        dt.Rows.Add(property.Name);                        
                    }
                }
                dataGridWithParameters.ItemsSource = dt.AsDataView();            
            }
        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<double> arr = new List<double>();
            FigureBase figure=new Rectangle();
            try
            {
                if (RectangleCheck.IsChecked == true)
                {
                    for (int i = 0; i < dataGridWithParameters.Items.Count; i++)
                    {
                        var ci = new DataGridCellInfo(dataGridWithParameters.Items[i], dataGridWithParameters.Columns[1]);
                        var content = ci.Column.GetCellContent(ci.Item) as TextBlock;
                        arr.Add(Convert.ToDouble(content.Text));
                    }

                    figure = new Rectangle(arr);
                    labelCreatedFigure.Content = LabelContent(figure.GetType().Name);
                }
                else if (CircleCheck.IsChecked == true)
                {                 
                    for (int i = 0; i < dataGridWithParameters.Items.Count; i++)
                    {                       
                        var ci = new DataGridCellInfo(dataGridWithParameters.Items[i], dataGridWithParameters.Columns[1]);                      
                        var content = ci.Column.GetCellContent(ci.Item) as TextBlock;
                        arr.Add(Convert.ToDouble(content.Text));
                    }
                    figure = new Circle(arr);
                    labelCreatedFigure.Content = LabelContent(figure.GetType().Name);
                }
                else if (TriangleCheck.IsChecked == true)
                {
                    for (int i = 0; i < dataGridWithParameters.Items.Count; i++)
                    {
                        var ci = new DataGridCellInfo(dataGridWithParameters.Items[i], dataGridWithParameters.Columns[1]);
                        var content = ci.Column.GetCellContent(ci.Item) as TextBlock;
                        arr.Add(Convert.ToDouble(content.Text));
                    }
                    figure = new Triangle(arr);
                    labelCreatedFigure.Content = LabelContent(figure.GetType().Name);                    
                }
                figureList.Add(figure);                
                labelCreatedFigure.Foreground = Brushes.Green;               
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Используйте только числовые значения.");
            }
        }
        /// <summary>
        /// Редактор надписи
        /// </summary>
        /// <param name="name">название фигуры</param>
        /// <returns>сообщение с информацией о созданной фигуре</returns>
        private object LabelContent(string name)
        {
            return $"Figure {name} was created";
        }       
    }
}