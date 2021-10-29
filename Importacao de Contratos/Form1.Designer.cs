namespace Importacao_de_Contratos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnImportar = new MetroFramework.Controls.MetroButton();
            this.txtLocal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.containerPanel1 = new TIPlasutil.Componentes.ContainerPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtVlTotalContratos = new MetroFramework.Controls.MetroTextBox();
            this.btnOutrosContratos = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tableLayoutPanel1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtLocal);
            this.metroPanel1.Controls.Add(this.btnImportar);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(942, 471);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(852, 6);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(65, 6);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(781, 23);
            this.txtLocal.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Local:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.containerPanel1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(936, 340);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // containerPanel1
            // 
            this.containerPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.containerPanel1.CorGradiente = true;
            this.containerPanel1.CorGradienteFinal = System.Drawing.Color.White;
            this.containerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel1.FonteTitulo = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel1.ForeColorTitulo = System.Drawing.SystemColors.HighlightText;
            this.containerPanel1.Icone = ((System.Drawing.Image)(resources.GetObject("containerPanel1.Icone")));
            this.containerPanel1.IconeVisivel = false;
            this.containerPanel1.Location = new System.Drawing.Point(0, 0);
            this.containerPanel1.Name = "containerPanel1";
            this.containerPanel1.PainelCentro = this.metroPanel3;
            this.containerPanel1.PerfilUsuarioVisivel = false;
            this.containerPanel1.RotacaoGradiente = 0F;
            this.containerPanel1.Size = new System.Drawing.Size(936, 340);
            this.containerPanel1.TabIndex = 2;
            this.containerPanel1.Titulo = "Dados Importados";
            // 
            // metroPanel3
            // 
            this.metroPanel3.AutoSize = true;
            this.metroPanel3.Controls.Add(this.grdDados);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(934, 318);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDados.Location = new System.Drawing.Point(0, 0);
            this.grdDados.MultiSelect = false;
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.Size = new System.Drawing.Size(934, 318);
            this.grdDados.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 436);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroTextBox2);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.metroTextBox1);
            this.metroPanel4.Controls.Add(this.metroLabel3);
            this.metroPanel4.Controls.Add(this.btnOutrosContratos);
            this.metroPanel4.Controls.Add(this.txtVlTotalContratos);
            this.metroPanel4.Controls.Add(this.metroLabel2);
            this.metroPanel4.Controls.Add(this.metroTile1);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 349);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(936, 84);
            this.metroPanel4.TabIndex = 6;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(936, 23);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Dados de Contratos";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(2, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(158, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Valor Total dos Contratos:";
            // 
            // txtVlTotalContratos
            // 
            this.txtVlTotalContratos.Location = new System.Drawing.Point(161, 24);
            this.txtVlTotalContratos.Name = "txtVlTotalContratos";
            this.txtVlTotalContratos.Size = new System.Drawing.Size(121, 23);
            this.txtVlTotalContratos.TabIndex = 6;
            this.txtVlTotalContratos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOutrosContratos
            // 
            this.btnOutrosContratos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOutrosContratos.Location = new System.Drawing.Point(861, 23);
            this.btnOutrosContratos.Name = "btnOutrosContratos";
            this.btnOutrosContratos.Size = new System.Drawing.Size(75, 61);
            this.btnOutrosContratos.TabIndex = 7;
            this.btnOutrosContratos.Text = "Outros\r\nContratos";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(358, 26);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(164, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Contrato de Maior Atraso:";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(528, 26);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(327, 23);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(161, 53);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(410, 23);
            this.metroTextBox2.TabIndex = 11;
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(104, 57);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Usuário:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Importação de Contratos";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private TIPlasutil.Componentes.ContainerPanel containerPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.DataGridView grdDados;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLocal;
        private MetroFramework.Controls.MetroButton btnImportar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnOutrosContratos;
        private MetroFramework.Controls.MetroTextBox txtVlTotalContratos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

