using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GoldApple
{
    /// <summary>
    /// Информация о товаре
    /// </summary>
    public class ProductRequestDto
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }

        /// <summary>
        /// Название бренда
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Описание продукта
        /// </summary>
        public List<Description> Description { get; set; }
        /// <summary>
        /// Стоимость и валюта
        /// </summary>
        public double Price { get; set; }
        public Currency Currency { get; set; }
        /// <summary>
        /// Требования к продукту
        /// </summary>
        public ProductRequirements Product { get; set; }
    }


    public enum Currency
    {
        Rubles,
        Dollars
    }
    

    /// <summary>
    /// Требования к продукту
    /// </summary>
    public class ProductRequirements
    {
        /// <summary>
        /// Водостойкое средство
        /// </summary>
        public bool WaterproofProduct { get; set; }
        /// <summary>
        /// Солнцезащитное средсто
        /// </summary>
        public List<SunscreenRequirements> SunscreenProduct { get; set; }
    }

    /// <summary>
    /// Требования к защите от солнца
    /// </summary>
    public class SunscreenRequirements
    {
        /// <summary>
        /// Степень защиты
        /// </summary>
        public int SPF { get; set; }
    }
    /// <summary>
    /// Описание
    /// </summary>
    public class Description
    {
        /// <summary>
        /// Бренд
        /// </summary>
        public string Brend { get; set; }
        /// <summary>
        /// Цвет
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Объем
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// Код товара
        /// </summary>
        public double Code { get; set; }
        /// <summary>
        /// Тип кожи
        /// </summary>
        public SkinType Type { get; set; }

    }

    /// <summary>
    /// Тип кожи
    /// </summary>
    public enum SkinType
    {
        Any,
        Dry,
        Oily,
        Problem,
    }
}
