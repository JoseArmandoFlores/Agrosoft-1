﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agrosoft.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir la marca")]
        public string Marca { get; set; }
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "Es obligatorio seleccionar la unidad de medida")]
        public int UnidadMedida { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir la cantidad minima")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "La cantidad minima debe ser mayor a 1")]
        public int CantidadMinima { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir la cantidad existente")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "La cantidad existente debe ser mayor a 1")]
        public int CantidadExistente { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el precio")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "El precio debe ser mayor a 1")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el costo")]
        [Range(minimum: 1, maximum: double.MaxValue, ErrorMessage = "El costo debe ser mayor a 1")]
        public decimal Costo { get; set; }
    }
}
