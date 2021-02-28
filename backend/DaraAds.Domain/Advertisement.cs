﻿using DaraAds.Domain.Shared;

namespace DaraAds.Domain
{

    /// <summary>
    /// Сущность объявление
    /// </summary>
    public sealed class Advertisement : MutableEntity<int>
    {
        /// <summary>
        /// Статусы объявления
        /// </summary>
        public enum Statuses
        {
            Created,
            Payed,
            Closed
        }
            
        /// <summary>
        /// Заголовок объявления
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание объявления
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public Statuses Status { get; set; }
        
        /// <summary>
        /// Обложка объявления
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// Автор объявления
        /// </summary>
        public User OwnerUser { get; set; }

        /// <summary>
        /// Id автора объявления
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Категория объявления
        /// </summary>
        public Category Category { get; set; }
    }
}
