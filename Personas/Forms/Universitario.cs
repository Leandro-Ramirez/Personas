#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    internal class Universitario : Estudiante
    {
        #region Variables Globales
        private string Universidad;
        private string Carrera;
        private string MateriasInscrita;
        private int Nota;
        private string CUM;
        #endregion

        #region Get & Set
        public string Universidades
        {
            get => Universidad;
            set => Universidad = value;
        }
        public string Carreras
        {
            get => Carrera;
            set => Carrera = value;
        }
        public string MateriasInscritas
        {
            get => MateriasInscrita;
            set => MateriasInscrita = value;
        }
        public int Notas
        {
            get => Nota;
            set => Nota = value;
        }
        public string CUMs
        {
            get => CUM;
            set => CUM = value;
        }
        #endregion

        #region Public Universitario
        public Universitario()
        {
            Universidad = string.Empty;
            Carrera = string.Empty;
            MateriasInscrita = string.Empty;
            Nota = 0;
            CUM = string.Empty;
        }
        #endregion
    }
}