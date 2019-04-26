using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Geometrical_figures;
using Rectangle = Geometrical_figures.Rectangle;
using System.Collections.Specialized;

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
            //WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            //RectangleCheck.IsChecked = true;
            //TriangleBaseTextBox.Visibility = Visibility.Hidden;
            //TriangleHeightTextBox.Visibility = Visibility.Hidden;
            //CircleRadiusTextBox.Visibility = Visibility.Hidden;
        }

        public NewFigure(ObservableCollection<FigureBase> figureList)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            RectangleCheck.IsChecked = true;
            TriangleBaseTextBox.Visibility = Visibility.Hidden;
            TriangleHeightTextBox.Visibility = Visibility.Hidden;
            CircleRadiusTextBox.Visibility = Visibility.Hidden;            
            this.figureList = figureList;              
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
            HideAll();
            if (TriangleCheck.IsChecked == true)
            {
                TriangleBaseTextBox.Visibility = Visibility.Visible;
                TriangleHeightTextBox.Visibility = Visibility.Visible;
                RectangleCheck.IsChecked = false;
                CircleCheck.IsChecked = false;
            }
        }
        private void CircleCheck_Click(object sender, RoutedEventArgs e)
        {
            CircleCheck.IsChecked = true;
        }
        private void CircleleCheck_Checked(object sender, RoutedEventArgs e)
        {
            HideAll();
            if (CircleCheck.IsChecked == true)
            {
                CircleRadiusTextBox.Visibility = Visibility.Visible;
                RectangleCheck.IsChecked = false;
                TriangleCheck.IsChecked = false;
            }
        }
        private void RectangleCheck_Click(object sender, RoutedEventArgs e)
        {
            RectangleCheck.IsChecked = true;
        }
        private void RectangleCheck_Checked(object sender, RoutedEventArgs e)
        {
            HideAll();
            if (RectangleCheck.IsChecked == true)
            {
                RectangleLengthTextBox.Visibility = Visibility.Visible;
                RectangleWidthTextBox.Visibility = Visibility.Visible;
                TriangleCheck.IsChecked = false;
                CircleCheck.IsChecked = false;
            }
        }
        private void HideAll()
        {
            RectangleLengthTextBox.Visibility = Visibility.Hidden;
            RectangleWidthTextBox.Visibility = Visibility.Hidden;
            TriangleBaseTextBox.Visibility = Visibility.Hidden;
            TriangleHeightTextBox.Visibility = Visibility.Hidden;
            CircleRadiusTextBox.Visibility = Visibility.Hidden;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FigureBase figure=new Rectangle();
            try
            {
                if (RectangleCheck.IsChecked == true)
                {
                    figure = new Rectangle(
                   Convert.ToDouble(RectangleWidthTextBox.Text),
                   Convert.ToDouble(RectangleLengthTextBox.Text)
                   );                                      
                    labelCreatedFigure.Content = LabelContent(figure.GetType().Name);                    
                }
                else if (CircleCheck.IsChecked == true)
                {
                    figure = new Circle(
                        Convert.ToDouble(CircleRadiusTextBox.Text)
                        );                   
                    labelCreatedFigure.Content = LabelContent(figure.GetType().Name);                    
                }
                else if (TriangleCheck.IsChecked == true)
                {
                    figure = new Triangle(
                         Convert.ToDouble(TriangleBaseTextBox.Text),
                         Convert.ToDouble(TriangleHeightTextBox.Text)
                         );                                      
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