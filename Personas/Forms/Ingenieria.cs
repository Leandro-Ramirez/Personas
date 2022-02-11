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
        private string NombreProyecto;
        private int HoraTotal;
        private int HoraCompletada;
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
        public Ingenieria(string Nombre, string Genero, string Carnet,
            string Nivel, string Universidad, string Carrera, 
            string MateriasInscrita, int Nota, string CUM,
            string NombreProyecto, int HoraTotal, int HoraCompletada)
        {
            this.Nombres = Nombre ;
            this.Generos = Genero ;
            this.Carnets = Carnet ;
            this.Niveles = Nivel ;
            this.Universidades = Universidad ;
            this.Carreras = Carrera ;
            this.MateriasInscritas = MateriasInscrita ;
            this.Notas = Nota ;
            this.CUMs = CUM ;
            this.NombreProyectos = NombreProyecto;
            this.HoraTotales = HoraTotal;
            this.HoraCompletadas = HoraCompletada;
        }
        #endregion
    }
}