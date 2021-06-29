namespace People.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;


    public class Person : IEntity
    {

        public int Id { get; set; }

        [Display(Name = "No. Documento")]
        [Required(ErrorMessage = "El atributo {0} es requerido")]
        [MaxLength(15, ErrorMessage = "El atributo {0} solo puede contener {1} caracteres")]
        public string DocumentNumber { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El atributo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El atributo {0} solo puede contener {1} caracteres")]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El atributo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El atributo {0} solo puede contener {1} caracteres")]
        public string LastName { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "El atributo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "El atributo {0} solo puede contener {1} caracteres")]
        public string Address { get; set; }

        [Display(Name = "Número Teléfono")]
        [Required(ErrorMessage = "El atributo {0} es requerido")]
        [MaxLength(10, ErrorMessage = "El atributo {0} solo puede contener {1} caracteres")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [MaxLength(100, ErrorMessage = "El atributo {0} solo puede contener {1} caracteres")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Nombres y Apellidos")]
        public string FullName => $"{Name} {LastName}";
    }
}
