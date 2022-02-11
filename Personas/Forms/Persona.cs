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
        private string Nombre;
        private string Genero;
        #endregion

        #region Get & Set
        public string Nombres
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string Generos
        {
            get => Genero;
            set => Genero = value;
        }
        #endregion

        #region Public Persona
        public Persona()
        {
            Nombre = string.Empty;
            Genero = string.Empty;
        }
        #endregion
    }
}
