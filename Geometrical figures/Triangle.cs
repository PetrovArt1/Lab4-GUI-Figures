using System.Collections.Generic;
/// <summary>
/// Геометрические фигуры
/// </summary>
namespace Geometrical_figures
{
    /// <summary>
    /// Объект "треугольник"
    /// </summary>
    public class Triangle : FigureBase
    {
        public string Name
        {
            get
            {
                return typeof(Triangle).Name;

            }
        }
        /// <summary>
        /// Основание треугольника
        /// </summary>
        private double _triangleBase;

        /// <summary>
        /// Высота
        /// </summary>
        private double _heigth;

        /// <summary>
        /// Основание трегуольника
        /// </summary>
        public double TriangleBase
        {
            get
            {
                return _triangleBase;
            }
            set
            {
                _triangleBase = LengthValidation(value);
            }
        }       

        /// <summary>
        /// Высота
        /// </summary>
        public double Heigth
        {
            get
            {
                return _heigth;
            }
            set
            {
                _heigth = LengthValidation(value);
            }
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        public override double CalculateArea
        {
            get
            {
                return (_triangleBase * _heigth) / 2;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="triangleBase">Основание треугольника</param>
        /// <param name="heigth">Высота</param>
        public Triangle(List<double> parametres)
        {
            TriangleBase = parametres[0];
            Heigth = parametres[1];
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Triangle() { }
    }
}
