using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Negocio
{
    public class ServAlumno
    {
        AlumnoDatos esAlumno = new AlumnoDatos();
        public int RecuperarIdLogueado(string passUsuario)
        {
            int idUser = esAlumno.BuscarId(passUsuario);
            return idUser;
        }
        public string RecuperaNombreLogueado(string mailu)
        {
            string NameUser = esAlumno.BuscarNombre(mailu);
            return NameUser;
        }
        public string RecuperarApellidoLogueado(string mailu)
        {
            string ApellidoUser = esAlumno.BuscarApellido(mailu);
            return ApellidoUser;
        }
        public int RecuperarDniLogueado(string mailu)
        {
            return esAlumno.BuscarDNI(mailu);
        }

        public string recuperarMailAlumno(int id_p)
        {
            string mailUser = esAlumno.BuscarMail(id_p);
            return mailUser;
        }

        public string recuperarContraseniaActual(int id_p)
        {
            string passUser = esAlumno.BuscarContrasenia(id_p);
            return passUser;
        }


        //Cambiar contraseña:
        public bool CambiarContraseniaAlumno(string mail, string clave, string nueva)
        {
            if (esAlumno.cambiarContrasenia(mail, clave, nueva))
            {
                return true;
            }
            return false;
        }

        public void EditarDatos(int id_p, string p, string p_2, string p_3)
        {
            Int32 dni = Convert.ToInt32(p_3);
            esAlumno.CargarDatos(id_p, p, p_2, dni);
        }

        public bool ConsultarExamenesDisponibles(int id_p)
        {
            bool resulta = esAlumno.BuscarExamenes(id_p);
            return resulta;
        }

    }
}
