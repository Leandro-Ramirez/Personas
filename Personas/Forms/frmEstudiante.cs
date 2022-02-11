#region
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Forms
{
    public partial class frmEstudiante : Form
    {
        #region Variables Globales
        List<Ingenieria> listaPersona = new List<Ingenieria>();
        Ingenieria ingenieria;
        #endregion

        #region Inicializar COmponente frmEstudiante
        public frmEstudiante()
        {
            InitializeComponent();
            listaPersona = new List<Ingenieria>();
        }
        #endregion

        #region Boton Registrar Click
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            GuardarPersona();
        }
        #endregion

        #region Boton Mostrar Click
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MostrarPersona();
        }
        #endregion

        #region Boton Salir Click
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodo de Guardado
        public void GuardarPersona()
        {
            ingenieria = new Ingenieria(txtNombre.Text, cmbGenero.Text , txtCarnet.Text,
                cmbNivel.Text,cmbUniversidad.Text, cmbCarrera.Text,
                cmbMaterias.Text, int.Parse(txtNotas.Text), txtCUM.Text,
                txtProyecto.Text, int.Parse(txtHoraT.Text), int.Parse(txtHoraC.Text));
        }
        #endregion

        #region Metodo Mostrar Persona
        public void MostrarPersona()
        {
            listaPersona.Add(ingenieria);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = listaPersona;
        }
        #endregion
    }
}