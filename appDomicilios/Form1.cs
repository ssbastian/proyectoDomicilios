using System;
using System.Data;
using System.Windows.Forms;
using appDomicilios.logica;

namespace appDomicilios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*creo el objeto que me permite comunicarme con la clase
        Animal que está en la capa de la logica*/
        Animal ani = new Animal();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*paso 1: guardo en variables lo que el usuario
             * ingresó o seleccionó de la interfaz*/
            int codigo, resultado;
            string nombre, genero="", tipo;
            codigo = int.Parse(txtCod.Text);
            nombre = txtNombre.Text;
            if(rbHembra.Checked)
            {
                genero = "hembra";
            }
            else if(rbMacho.Checked)
            {
                genero = "macho";                
            }
            tipo = cbxTipo.SelectedItem.ToString();
            /*paso 2: envio las variables a la capa
             * de la  logica*/
            resultado = ani.ingresarAnimal(codigo, nombre, genero, tipo);
            if(resultado > 0)
            {
                MessageBox.Show("Animal Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Animal No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCod.Text = "";
        }

        private void btnConsultarAnimales_Click(object sender, EventArgs e)
        {
            //creo un dataset vacio
            DataSet dsResultado = new DataSet();
            dsResultado = ani.consultarAnimales();
            dgvDatos.DataSource = dsResultado;
            dgvDatos.DataMember = "ResultadoDatos";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //capturo el codigo a buscar
            int cod = int.Parse(txtBuscarCod.Text);
            //creo un dataset vacio
            DataSet dsResultado = new DataSet();
            dsResultado = ani.buscarAnimalXCod(cod);
            //valido si el data set tiene un registro o tupla
            if(dsResultado.Tables[0].Rows.Count > 0)
            {
                lbNombreAnimal.Text = dsResultado.Tables[0].Rows[0]["aniNombre"].ToString();
            }
            else 
            {
                MessageBox.Show("Animal No Encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
