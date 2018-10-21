﻿using NLog;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranscomaAPI.Comun.Entidades;
using TranscomaAPI.Comun.Excepciones;
using TranscomaAPI.Persistencia.Dao.Contrato;
using TranscomaAPI.Persistencia.Fabrica;
using System.Reflection;

namespace TranscomaAPI.Logica_de_Negocio.Implementacion.Comando.Carga
{
    public class ComandoConsultarTodasEntradas : Comando
    {
        private List<Entidad> _entradas;
        Logger logger = LogManager.GetLogger("fileLogger");//logger
        private IDaoEntrada _dao; //Dao

        public ComandoConsultarTodasEntradas()
        {
            _entradas = new List<Entidad>();
            _dao = FabricaDao.CrearDaoEntrada();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entradas">Instancia la entrada que se desea obtener</param>
        public ComandoConsultarTodasEntradas(Entidad entradas)
        {
            Entidad = entradas;
        }

        /// <summary>
        /// Metodo que ejecuta la accion del comando
        /// </summary>
        public override void Ejecutar()
        {
            try
            {
                _entradas = _dao.ConsultarTodos();
            }
            catch (NullReferenceException e)
            {
                logger.Error(e, e.Message);
                throw new ExcepcionObjetoNulo(e, "Parametros nulos en: " + GetType().FullName + "." + MethodBase.GetCurrentMethod().Name + ". " + e.Message);
            }
            catch (InvalidCastException e)
            {
                logger.Error(e, e.Message);
                throw new ExcepcionCasteoIncorrecto(e, "Casteo no correcto en: " + GetType().FullName + "." + MethodBase.GetCurrentMethod().Name + ". " + e.Message);
            }
            catch (NpgsqlException e)
            {
                logger.Error(e, e.Message);
                throw new ExcepcionBaseDeDatos(e, "Error en la base de datos en: " + GetType().FullName + "." + MethodBase.GetCurrentMethod().Name + ". " + e.Message);
            }
            catch (Exception e)
            {
                logger.Error(e, e.Message);
                throw new ExcepcionGeneral(e, DateTime.Now);
            }
        }

        /// <summary>
        /// Metodo que retorna una instancia de tipo Entidad de la respuesta del metodo ejecutar().
        /// </summary>
        /// <returns>Una instacia de tipo Entidad</returns>
        /// <exception cref="System.NotImplementedException">Metodo No implementado</exception>
        public override Entidad GetEntidad()
        {
            return Entidad;
        }

        /// <summary>
        /// Metodo que retorna una lista de tipo Entidad de la respuesta del metodo ejecutar().
        /// </summary>
        /// <returns>Una lista de tipo Entidad</returns>
        public override List<Entidad> GetEntidades()
        {
            return _entradas;
        }
    }
}
