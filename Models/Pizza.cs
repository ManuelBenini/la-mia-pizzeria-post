﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_post.Models
{
    [Table("Pizzas")]
    public class Pizza
    {
        public int PizzaId { get; set; }

        [Required(ErrorMessage = "Il campo nome è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il nome non può avere più di 50 caratteri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo descrizione è obbligatorio")]
        [MoreThanFiveWordsValidation]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il campo immagine è obbligatorio")]
        [Url(ErrorMessage = "L'immagine inserita non è valida")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Il campo prezzo è obbligatorio")]
        [MoreThanZeroValidation]
        public double Price { get; set; }

        public Pizza()
        {

        }

        public Pizza(string name, string description, string image, double price)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}