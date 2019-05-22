using System;
using System.Collections.Generic;
/// <summary>
/// Геометрические фигуры
/// </summary>
namespace Geometrical_figures
{
    /// <summary>
    /// Объект "круг"
    /// </summary>
    public class Circle : FigureBase
    {
        public string Name
        {
            get
            {
                return typeof(Circle).Name;

            }
        }
        /// <summary>
        /// Радиус
        /// </summary>
        private double _radius;

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = LengthValidation(value);
            }
        }

       
        /// <summary>
        /// Вычисленная площадь
        /// </summary>
        public override double CalculateArea
        {
            get
            {
                return (Math.Pow(_radius, 2) * Math.PI);
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(List<double> param)
        {
            Radius = param[0];
        }

        /// <summary>
        /// Конструктор по умолячанию
        /// </summary>
        public Circle() { }
    }
}
