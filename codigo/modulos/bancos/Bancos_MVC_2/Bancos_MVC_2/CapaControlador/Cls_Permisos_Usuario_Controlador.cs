﻿using System;
using Capa_Modelo_Bancos;

namespace Capa_Controlador_Bancos
{
    public class Cls_Permiso_Usuario_Controlador
    {
        private Cls_Permiso_Usuario permisoUsuario = new Cls_Permiso_Usuario();


        public (bool ingresar, bool consultar, bool modificar, bool eliminar, bool imprimir)? ConsultarPermisos(int iIdUsuario, int iIdAplicacion, int iIdModulo)
        {
            return permisoUsuario.ConsultarPermisos(iIdUsuario, iIdAplicacion, iIdModulo);
        }


        public int ObtenerIdAplicacionPorNombre(string nombreAplicacion)
        {
            return permisoUsuario.ObtenerIdAplicacionPorNombre(nombreAplicacion);
        }

        public int ObtenerIdModuloPorNombre(string nombreModulo)
        {
            return permisoUsuario.ObtenerIdModuloPorNombre(nombreModulo);
        }
    }
}