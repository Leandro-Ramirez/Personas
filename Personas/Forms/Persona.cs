#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    internal class Persona
    {
        #region Variables Globales
        string Nombre;
        string Apellido;
        #endregion

        #region Get & Set
        public string Nombres
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string Apellidos
        {
            get => Apellido;
            set => Apellido = value;
        }
        #endregion

        #region Public Persona
        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
        }
        #endregion
    }
}
