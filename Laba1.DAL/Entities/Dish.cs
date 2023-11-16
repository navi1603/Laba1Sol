﻿namespace Laba1.DAL.Entities
{
    public class Dish
    {
        public int DishId { get; set; } // id блюда
        public string DishName { get; set; } // название блюда
        public string Description { get; set; } // описание блюда
        public int Calories { get; set; } // кол. калорий на порцию
        public string Image { get; set; } // имя файла изображения 

        // Навигационные свойства
        /// <summary>
        /// группа блюд (например, супы, напитки и т.д.)
        /// </summary>
        public int DishGroupId { get; set; }
        public DishGroup Group { get; set; }
    }
}
