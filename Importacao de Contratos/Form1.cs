using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objeto;

namespace Importacao_de_Contratos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        #region Atributos
        private DataTable dtp = null;
        OpenFileDialog ofd = new OpenFileDialog();
        #endregion

        #region Construtor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PersonalizarGridDados(int intColuna)
        {
            DataGridViewColumn x = new DataGridViewColumn();
            x.Name = "";
            x.Width = 300;

            grdDados.Columns.Clear();
            for (int i = 0; i < intColuna; i++)
            {
                grdDados.Columns.AddRange(x);
            }
        }

        private void CarregarGridDados(DataTable dt, string strArq)
        {
            string[] valor = new string[dt.Columns.Count];
            int cont = 0;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow regs in dt.Rows)
                {
                    cont = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        valor[cont] = (regs[col].ToString());
                        cont++;
                    }
                }
            }
            //tslMensagem.Text = dt.Rows.Count + " Produtos Encontrados!";
        }

        private void AbrirDiretorio()
        {

            ofd.Multiselect = true;
            ofd.Title = "Selecionar Arquivo(s)";
            ofd.InitialDirectory = @"C:\Dados\";
            ofd.Filter = "Images (*.txt;)|*.txt;|" + "All files (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            DialogResult resul = ofd.ShowDialog();

            if (resul == DialogResult.OK)
            {
                string strArq = ofd.FileName;
                txtLocal.Text = ofd.FileName;

                grdDados.DataSource = Auxiliar.LerArquivoExcel(strArq, "Sheet1");
                dtp = Auxiliar.LerArquivoExcel(strArq, "Sheet1");
                CarregarGridDados(dtp, strArq);
            }
        }

        #endregion

        #region Eventos      
        private void btnImportar_Click(object sender, EventArgs e)
        {
            AbrirDiretorio();
        }
        #endregion
    }
}
