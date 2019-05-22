using System.Collections.Generic;
/// <summary>
/// Геометрические фигуры
/// </summary>
namespace Geometrical_figures
{
    /// <summary>
    ///  Объект "Прямоугольник"
    /// </summary>
    public class Rectangle : FigureBase
    {
        public string Name
        {
            get
            {
                return typeof(Rectangle).Name;
            }
        }
        /// <summary>
        /// Ширина
        /// </summary>
        private double _width;

        /// <summary>
        /// Длина
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = LengthValidation(value);
            }
        }

        /// <summary>
        /// Длина
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = LengthValidation(value);
            }
        }
      

        /// <summary>
        /// Расчет площади фигуры
        /// </summary>
        public override double CalculateArea
        {
            get
            {
                return _width * _length;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="length">Длина</param>
        public Rectangle(List<double> param)
        {            
            Width = param[0];
            Length = param[1];
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Rectangle() { }
    }
}
