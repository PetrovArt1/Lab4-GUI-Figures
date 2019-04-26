using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Serialization;
/// <summary>
/// Геометричекие фигуры
/// </summary>
namespace Geometrical_figures
{
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Triangle))]
    [XmlInclude(typeof(Circle))]
    [Serializable]

    /// <summary>
    /// Базовый абстрактный класс фигур
    /// </summary>
    public abstract class FigureBase
    {        
        /// <summary>
        /// Проверка параметров фигур на значения меньше или равных нулю
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>Корректное значение</returns>
        protected double LengthValidation(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Используйте значения больше нуля.");
            }
            return value;
        }    

        /// <summary>
        /// Вычисленная площадь фигуры
        /// </summary>
        public abstract double CalculateArea { get; }

        public static implicit operator ObservableCollection<object>(FigureBase v)
        {
            throw new NotImplementedException();
        }
    }
}
