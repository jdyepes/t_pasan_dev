﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TranscomaAPI.Comun.Entidades
{
    public class Almacen : Entidad
    {
        private string _nombre;
        private string _direccion;      
        private Entrada _entrada;
        private Salida _salida;
        private Pedido _pedido;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public Almacen(int id)
        {
            Id = id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="direccion"></param>
        public Almacen(int id, string nombre, string direccion)
        {
            Id = id;
            _nombre = nombre;
            _direccion = direccion;
        }

        /// <summary>
        /// Getters y Setters
        /// </summary>
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string DireccionAlmacen { get => _direccion; set => _direccion = value; }
        public Entrada Entradas { get => _entrada; set => _entrada = value; }
        public Salida Salidas { get => _salida; set => _salida = value; }
        public Pedido Pedidos { get => _pedido; set => _pedido = value; }
    }
}