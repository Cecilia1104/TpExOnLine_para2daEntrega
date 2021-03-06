﻿using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using System.Web;

namespace Negocio
{
    public class ServProfesor
    {
        ProfesorDatos esProfesor = new ProfesorDatos();

        public int RecuperarIdLogueado(string passUsuario)
        {
            int idUser = esProfesor.BuscarId(passUsuario);
            return idUser;
        }

        public string RecuperaNombreLogueado(string mailUsuario)
        {
            string NameUser = esProfesor.BuscarNombre(mailUsuario);
            return NameUser;
        }

        //llamamos a Store Procedure listarExamenes
        public object mostrarExamenes(int id_p)
        {
            var resulta = esProfesor.ListarLosExamenes(id_p);
            return resulta;
        }

        public object LlenarDdlConCursos(int id_p)
        {
            var resulta = esProfesor.ListarLosCursosEnCombo(id_p);
            return resulta;
        }


        public void crearNuevoExamen(string nombre, string descripcion, int duracion, DateTime tiempotope, DateTime horatope,  int idcurso)
        {
           // string Nombre = p;
           // string Descripcion = p_2;
           // int Duracion = Convert.ToInt32(p_3);
           // DateTime fechatope = Convert.ToDateTime(p_4);
           //// DateTime horatope = Convert.ToDateTime(p_5);
           // int curso = idcurso;
            //int porcentaje = Convert.ToInt32(p_6);
            esProfesor.altaExamen(nombre, descripcion, duracion, tiempotope,horatope, idcurso);
        }
    }
}
