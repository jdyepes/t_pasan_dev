﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranscomaAPI.Comun.Entidades;

namespace TranscomaAPI.Persistencia.Dao.Contrato
{
    public interface IDaoCliente
    {        
        List<Entidad> ConsultarClientes(int idAdminstrador);
        
        Entidad verificarNombreUsuarioCliente(string userName);

    }
}
