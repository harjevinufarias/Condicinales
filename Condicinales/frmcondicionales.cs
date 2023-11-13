using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicinales
{
    public partial class frmcondicionales : Form
    {
        public frmcondicionales()
        {
            InitializeComponent();
        }

        private void frmcondicionales_Load(object sender, EventArgs e)
        {

        }

        private void btnedad_Click(object sender, EventArgs e)
        {
            if (this.txtedad.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar la edad.", "Error de entrada");
                this.txtedad.Focus();
                return;
            }
            bool flat = int.TryParse(this.txtedad.Text, out int edad);
            if (!flat)
            {
                MessageBox.Show("La edad ingresada debe ser un valor numerico.");
                this.txtedad.Focus();
                return;
            }

            //condicional simple
            if (edad < 23)
                this.lbledad.Text = "Aprovechar tus estudios";
        }
    }
}
