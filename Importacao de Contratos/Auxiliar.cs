
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Objeto
{
    #region ENUMERADORES

    /// <summary>
    /// INICIA OS VALORES DA COLUNA COM CARACTERES DO TIPO PASSWORD CHAR
    /// </summary>
    public enum DefaultValueCellPasswordChar
    {
        NO = 0,
        YES = 1
    }

    #endregion    

    /// <summary>
    /// Classe que contem eventos estaticos de utilidade do sistema
    /// </summary>
    public static class Auxiliar
    {
        public static DataTable LerArquivoExcel(string arquivo, string nomePlanilha = "Plan1", bool colunaCheckBox = false)
        {
            DataTable dt = null;
            string ext = VerificarExtensaoExcel(arquivo);
            if (ext != string.Empty)
            {
                if (ext == ".csv")
                {
                    if (colunaCheckBox)
                        dt = LerArquivoCSVCheckBox(arquivo);
                    else
                        dt = LerArquivoCSV(arquivo);
                }
                else if (ext == ".xls")
                {
                    dt = LerArquivoXls(arquivo, nomePlanilha, colunaCheckBox, dt);
                }
            }

            return dt;
        }


        private static string VerificarExtensaoExcel(string arquivo)
        {
            string[] ext = { ".csv", ".xls", ".xlsx" };

            foreach (string e in ext)
            {
                if (arquivo.EndsWith(e)) { return e; }
            }

            return string.Empty;
        }

        public static DataTable LerArquivoCSVCheckBox(string arquivo)
        {
            DataTable dt = new DataTable();

            if (arquivo != string.Empty)
            {
                //carrega arquivo
                string conteudo = LerArquivo(arquivo).ToString();
                //separa as linhas
                string[] linha = conteudo.Split('\n');
                //percorre as linhas
                for (int i = 0; i < linha.Length; i++)
                {
                    //separa as colunas
                    string[] celula = linha[i].Split(';');

                    //cria colunas no DataTable
                    if (i == 0)
                    {
                        //coluna para o checkbox
                        dt.Columns.Add("checkbox");

                        //para cada coluna do arquivo, cria uma coluna no DataTable
                        for (int j = 0; j < celula.Length; j++)
                        {
                            dt.Columns.Add("coluna" + Convert.ToString(j + 1));
                        }
                    }

                    //alimenta DataTable
                    object[] obj = new object[celula.Length + 1];

                    obj[0] = true;
                    bool vaziu = true;
                    for (int k = 0; k < celula.Length; k++)
                    {
                        obj[k + 1] = celula[k];
                        if (celula[k].ToString() != string.Empty)
                        {
                            vaziu = false;
                        }
                    }
                    if (!vaziu)
                    {
                        dt.Rows.Add(obj);
                    }
                }
            }
            return dt;
        }

        public static StringBuilder LerArquivo(string arquivo)
        {
            StringBuilder texto;
            StreamReader input;

            FileInfo file = new FileInfo(arquivo);

            if (!file.Exists)
            {
                throw new FileNotFoundException();
            }
            input = new StreamReader(arquivo, Encoding.GetEncoding(12000));
            texto = new StringBuilder();

            while (!input.EndOfStream)
            {
                texto.Append(input.ReadLine() + "\n");
            }

            input.Close();

            return texto;
        }

        public static DataTable LerArquivoCSV(string strArquivo, char chDelimitadorDeColuna = ';', char chDelimitadorDeLinha = '\n')
        {
            DataTable dt = new DataTable();

            if (strArquivo != string.Empty)
            {
                //carrega arquivo
                string conteudo = LerArquivo(strArquivo).ToString();
                //separa as linhas
                string[] linha = conteudo.Split(chDelimitadorDeLinha);
                //percorre as linhas
                for (int i = 0; i < linha.Length; i++)
                {
                    //separa as colunas
                    string[] celula = linha[i].Split(chDelimitadorDeColuna);

                    //cria colunas no DataTable
                    if (i == 0)
                    {
                        //para cada coluna do arquivo, cria uma coluna no DataTable
                        for (int j = 0; j < celula.Length; j++)
                        {
                            dt.Columns.Add();
                        }
                    }

                    //alimenta DataTable
                    dt.Rows.Add(celula);
                }
            }
            return dt;
        }

        public static DataTable LerArquivoXls(string pathName, string sheetName, bool colunaCheckBox, DataTable dt)//ok
        {
            dt = new DataTable();
            string strConn = string.Empty;
            if (string.IsNullOrEmpty(sheetName)) { sheetName = "Sheet1"; }
            FileInfo file = new FileInfo(pathName);
            if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
            string extension = file.Extension;
            switch (extension)
            {
                case ".xls":
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0 Xml; HDR = YES; IMEX = 1;'";
                    //strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    break;
            }
            OleDbConnection cnnxls = new OleDbConnection(strConn);
            OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
            DataSet ds = new DataSet();
            oda.Fill(dt);
            if (colunaCheckBox)
            {
                DataColumn col = dt.Columns.Add("checkbox", Type.GetType("System.Boolean"));
                col.SetOrdinal(0);
            }
            return dt;
        }

    }
}