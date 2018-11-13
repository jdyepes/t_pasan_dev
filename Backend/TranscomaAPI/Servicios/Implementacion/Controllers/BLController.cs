﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TranscomaAPI.Comun.Entidades;
using TranscomaAPI.Comun.Entidades.Fabrica;
using TranscomaAPI.Logica_de_Negocio.Implementacion.Comando;
using TranscomaAPI.Logica_de_Negocio.Implementacion.Fabrica;
using Microsoft.AspNetCore.Cors;
using TranscomaAPI.Comun.Excepciones;
using NLog;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TranscomaAPI.Servicios.Implementacion.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAllHeaders")]
    public class BLController : Controller
    {
        Logger logger = LogManager.GetLogger("fileLogger");

        [HttpGet("ObtenerBLsCliente/{id}")]
        public ActionResult<List<Comun.Entidades.Entidad>> ObtenerBLCliente(int id)
        {
            try
            {
                Entidad cliente = FabricaEntidades.CrearCliente();
                cliente.Id = id;
                Comando comando = FabricaComando.CrearComandoObtenerBLsCLiente(cliente);
                comando.Ejecutar();
                List<Entidad> bls = comando.GetEntidades();
                
                return bls;
            } 
            catch(LogicaException e)
            {
                logger.Error(e, e.Message);
                return BadRequest(e);
            }
            catch(Exception e)
            {
                logger.Error(e, e.Message);
                return BadRequest(e);
            }
           
        }

        [HttpPost("AgregarBL")]
        public ActionResult AgregarBL([FromBody]BL bl)
        {
            try
            {
                Comando comando = FabricaComando.CrearComandoAgregarBL(bl);
                comando.Ejecutar();
                return Ok();
            }
            catch(LogicaException e)
            {
                logger.Error(e, e.Message);
                return BadRequest(e);
            }
            catch(Exception e)
            {
                logger.Error(e, e.Message);
                return BadRequest(e);
            }
            
        }


    }
}
