using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;

namespace Libro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Registro reg = new Registro();
        public void CleanFild()
        {
            txtTitulo.Text = String.Empty;
            txtAutor.Text = String.Empty;
            txtISBN.Text = String.Empty;
            txtPag.Text = String.Empty;
            txtTitulo.Focus();
        }
        String[] datos = new string[4];
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string tit, aut, isbn, np = "";
                int pag;
                tit = txtTitulo.Text;
                aut = txtAutor.Text;
                isbn = txtISBN.Text;
                pag = int.Parse(txtPag.Text);
                if (tit == "" || aut == "" || isbn == "" || pag <= 0 || datos.Contains(isbn) || datos.Contains(tit))
                {
                    MessageBox.Show("No puede ingresar valores negativos o vacios");
                }
                else
                {
                    np = String.Format("{0}", pag);
                    string registro=reg.guardar(tit, aut, pag, isbn);
                    txtLibroReg.Text = registro;
                }
                datos[0] = tit;
                datos[1] = aut;
                datos[2] = np;
                datos[3] = isbn;

                if (tit == "" || aut == "" || isbn == "" || np == "")
                {
                    MessageBox.Show("Los datos actuales no se pueden ingresar");

                }
                else
                {
                    Tabla.Rows.Add(datos);
                    CleanFild();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (chBuscar.Checked == true)
            {
                txtBuscar.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tabla.AllowUserToAddRows=false;
            txtBuscar.Enabled = false;
        }
        public void clean()
        {
            
            int f = Tabla.RowCount;
            for (int i = f - 1; i >= 0; i--)
            {
                Tabla.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }
        int strFila = 0;
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtBuscar.Text == "")
            {
                Tabla.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                foreach (DataGridViewRow Row in Tabla.Rows)
                {
                    strFila = Convert.ToInt32(Row.Index.ToString());
                    string valor = Convert.ToString(Row.Cells["ISBN"].Value);
                    string valor2= Convert.ToString(Row.Cells["Titulo"].Value);
                    if (valor == this.txtBuscar.Text || valor2 == this.txtBuscar.Text)
                    {
                        Tabla.Rows[strFila].DefaultCellStyle.BackColor = Color.Green;
                        chBuscar.Checked = false;
                        txtBuscar.Text = String.Empty;
                        txtBuscar.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Tabla.Sort(this.Tabla.Columns["N_Paginas"], ListSortDirection.Descending);
        }
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private void btnGuardarEx_Click(object sender, EventArgs e)
        {
            objExcel.Application objAplicacion = new objExcel.Application();
            Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

            objAplicacion.Visible = false;

            foreach (DataGridViewColumn columna in Tabla.Columns)
            {
                objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in Tabla.Rows)
                {
                    objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }

            objLibro.SaveAs(ruta + "\\tabla.xlsx");
            objLibro.Close();
            int f;
            f = Tabla.RowCount;
            for (int i = f - 1; i >= 0; i--)
            {
                Tabla.Rows.RemoveAt(i);
            }
            txtTitulo.Focus();
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
