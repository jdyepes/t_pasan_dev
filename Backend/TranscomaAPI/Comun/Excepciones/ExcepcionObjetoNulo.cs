﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TranscomaAPI.Comun.Excepciones
{
    /// <summary>
    /// Excepcion para el manejo de objetos nulos
    /// </summary>
    public class ExcepcionObjetoNulo : Exception
    {
        private DateTime _fecha; //Hora y fecha de cuando se genero la excepción.
        private string _mensaje; //Breve descripción de la excepción genereda.
        private NullReferenceException _excepcion; //Tipo de excepcion que se genero.

        public ExcepcionObjetoNulo(NullReferenceException excepcion, string mensaje)
        {
            _fecha = DateTime.Now;
            _mensaje = mensaje;
            _excepcion = excepcion;
        }

        /// <summary>
        /// Getters y Setters del atributo _fecha
        /// </summary>
        public DateTime Fecha { get => _fecha; set => _fecha = value; }

        /// <summary>
        /// Getters y Setters del atributo _mensaje
        /// </summary>
        public string Mensaje { get => _mensaje; set => _mensaje = value; }

        /// <summary>
        /// Getters y Setters del atributo _excepcion
        /// </summary>
        public NullReferenceException Excepcion { get => _excepcion; set => _excepcion = value; }

    }
}
