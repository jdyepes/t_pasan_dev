﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranscomaAPI.Comun.Entidades;

namespace TranscomaAPI.Comun.Entidades.Fabrica
{
    public static class FabricaEntidades
    {
        /// <summary>
        /// Fabrica para consultar las entradas de un cliente en especifico
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fechaEntrada"></param>
        /// <param name="producto"></param>
        /// <param name="almacen"></param>
        /// <returns></returns>
        public static Entrada CrearEntrada(int id, DateTime fechaEntrada, Producto producto, Almacen almacen)
        {
            return new Entrada(id, fechaEntrada, producto, almacen);
        }

        /// <summary>
        /// Fabrica para consultar todas las entradas
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fechaEntrada"></param>
        /// <param name="producto"></param>
        /// <param name="almacen"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static Entrada CrearEntrada(int id, DateTime fechaEntrada, Producto producto, Almacen almacen, Cliente cliente)
        {
            return new Entrada(id, fechaEntrada, producto, almacen, cliente);
        }

        /// <summary>
        /// Fabrica para consultar las Salidas de un cliente en especifico
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fechaEntrada"></param>
        /// <param name="producto"></param>
        /// <param name="almacen"></param>
        /// <returns></returns>
        public static Salida CrearSalida(int id, DateTime fechaEntrada, Producto producto, Almacen almacen)
        {
            return new Salida(id, fechaEntrada, producto, almacen);
        }

        /// <summary>
        /// Fabrica para consultar todas las Salidas
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fechaEntrada"></param>
        /// <param name="producto"></param>
        /// <param name="almacen"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static Salida CrearSalida(int id, DateTime fechaEntrada, Producto producto, Almacen almacen, Cliente cliente)
        {
            return new Salida(id, fechaEntrada, producto, almacen, cliente);
        }
    }
}