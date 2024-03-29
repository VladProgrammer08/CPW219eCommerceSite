﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace CPW219eCommerceSite.Models
{
    /// <summary>
    /// Represents a single game for available for purchase
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The unique identifier for each game product
        /// (Primary Key)
        /// </summary>
        [Key]
        public int GameId { get; set; }

        /// <summary>
        /// The official title of the Video Game
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// The sales price of the game
        /// </summary>
        [Range(0, 1000)]
        public double Price { get; set; }

        // Todo: Add rating
    }

    /// <summary>
    /// A single video game that has been added to the 
    /// users shopping cart cookie
    /// </summary>

    public class CartGameViewModel
    {
        /// <summary>
        /// The unique identifier for each game product
        /// (Primary Key)
        /// </summary>
        [Key]
        public int GameId { get; set; }

        /// <summary>
        /// The official title of the Video Game
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The sales price of the game
        /// </summary>
        public double Price { get; set; }
    }
}
