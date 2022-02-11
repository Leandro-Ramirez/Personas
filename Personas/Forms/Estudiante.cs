﻿#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    internal class Estudiante : Persona
    {
        #region Variables Globales
        private string Carnet;
        private string Nivel;
        #endregion

        #region Get & Set
        public string Carnets
        {
            get => Carnet;
            set => Carnet = value;
        }
        public string Niveles
        {
            get => Nivel;
            set => Nivel = value;
        }
        #endregion

        #region Public Estudiante
        public Estudiante()
        {
            Carnet = string.Empty;
            Nivel = string.Empty;
        }
        #endregion
    }
}