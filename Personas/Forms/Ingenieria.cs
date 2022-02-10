#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    internal class Ingenieria : Universitario
    {
        #region Variables Globales
        string NombreProyecto;
        int HoraTotal;
        int HoraCompletada;
        #endregion

        #region Get & Set
        public string NombreProyectos
        {
            get => NombreProyecto;
            set => NombreProyecto = value;
        }
        public int HoraTotales
        {
            get => HoraTotal;
            set => HoraTotal = value;
        }
        public int HoraCompletadas
        {
            get => HoraCompletada;
            set => HoraCompletada = value;
        }
        #endregion

        #region Public Ingenieria
        public Ingenieria()
        {
            NombreProyecto = string.Empty;
            HoraTotal = 0;
            HoraCompletada = 0;
        }
        #endregion
    }
}