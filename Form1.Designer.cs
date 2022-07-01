using System.Windows.Forms;
using System.Collections.Generic;
using infoPrint.models;

namespace infoPrint
{
    partial class form_main
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.lbl_dt_inicial = new System.Windows.Forms.Label();
            this.lbl_dt_final = new System.Windows.Forms.Label();
            this.lbl_impressoras = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_arq_log = new System.Windows.Forms.Label();
            this.txt_local_arquivo = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.dtp_data_inicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_data_final = new System.Windows.Forms.DateTimePicker();
            this.cb_impressoras = new System.Windows.Forms.ComboBox();
            this.txt_maquina = new System.Windows.Forms.TextBox();
            this.lbl_maquina = new System.Windows.Forms.Label();
            this.lv_impressoes = new System.Windows.Forms.ListView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_ler_arquivo = new System.Windows.Forms.Button();
            this.pb_carregamento_listview = new System.Windows.Forms.ProgressBar();
            this.btn_csv = new System.Windows.Forms.Button();
            this.btn_abrir_arquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dt_inicial
            // 
            this.lbl_dt_inicial.AutoSize = true;
            this.lbl_dt_inicial.Location = new System.Drawing.Point(13, 41);
            this.lbl_dt_inicial.Name = "lbl_dt_inicial";
            this.lbl_dt_inicial.Size = new System.Drawing.Size(51, 13);
            this.lbl_dt_inicial.TabIndex = 13;
            this.lbl_dt_inicial.Text = "Dt. Inicial";
            // 
            // lbl_dt_final
            // 
            this.lbl_dt_final.AutoSize = true;
            this.lbl_dt_final.Location = new System.Drawing.Point(303, 41);
            this.lbl_dt_final.Name = "lbl_dt_final";
            this.lbl_dt_final.Size = new System.Drawing.Size(46, 13);
            this.lbl_dt_final.TabIndex = 14;
            this.lbl_dt_final.Text = "Dt. Final";
            // 
            // lbl_impressoras
            // 
            this.lbl_impressoras.AutoSize = true;
            this.lbl_impressoras.Location = new System.Drawing.Point(588, 41);
            this.lbl_impressoras.Name = "lbl_impressoras";
            this.lbl_impressoras.Size = new System.Drawing.Size(63, 13);
            this.lbl_impressoras.TabIndex = 15;
            this.lbl_impressoras.Text = "Impressoras";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(783, 41);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 16;
            this.lbl_usuario.Text = "Usuário";
            // 
            // lbl_arq_log
            // 
            this.lbl_arq_log.AutoSize = true;
            this.lbl_arq_log.Location = new System.Drawing.Point(13, 12);
            this.lbl_arq_log.Name = "lbl_arq_log";
            this.lbl_arq_log.Size = new System.Drawing.Size(79, 13);
            this.lbl_arq_log.TabIndex = 4;
            this.lbl_arq_log.Text = "Arquivo de Log";
            // 
            // txt_local_arquivo
            // 
            this.txt_local_arquivo.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.txt_local_arquivo.Location = new System.Drawing.Point(98, 9);
            this.txt_local_arquivo.Name = "txt_local_arquivo";
            this.txt_local_arquivo.Size = new System.Drawing.Size(748, 20);
            this.txt_local_arquivo.TabIndex = 1;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txt_usuario.Location = new System.Drawing.Point(832, 38);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(125, 20);
            this.txt_usuario.TabIndex = 7;
            // 
            // dtp_data_inicial
            // 
            this.dtp_data_inicial.Location = new System.Drawing.Point(70, 38);
            this.dtp_data_inicial.Name = "dtp_data_inicial";
            this.dtp_data_inicial.Size = new System.Drawing.Size(227, 20);
            this.dtp_data_inicial.TabIndex = 4;
            this.dtp_data_inicial.Value = new System.DateTime(2022, 6, 3, 8, 9, 15, 0);
            // 
            // dtp_data_final
            // 
            this.dtp_data_final.Location = new System.Drawing.Point(355, 38);
            this.dtp_data_final.Name = "dtp_data_final";
            this.dtp_data_final.Size = new System.Drawing.Size(227, 20);
            this.dtp_data_final.TabIndex = 5;
            // 
            // cb_impressoras
            // 
            this.cb_impressoras.FormattingEnabled = true;
            this.cb_impressoras.Location = new System.Drawing.Point(648, 38);
            this.cb_impressoras.Name = "cb_impressoras";
            this.cb_impressoras.Size = new System.Drawing.Size(129, 21);
            this.cb_impressoras.TabIndex = 6;
            // 
            // txt_maquina
            // 
            this.txt_maquina.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txt_maquina.Location = new System.Drawing.Point(1018, 38);
            this.txt_maquina.Name = "txt_maquina";
            this.txt_maquina.Size = new System.Drawing.Size(125, 20);
            this.txt_maquina.TabIndex = 8;
            // 
            // lbl_maquina
            // 
            this.lbl_maquina.AutoSize = true;
            this.lbl_maquina.Location = new System.Drawing.Point(964, 41);
            this.lbl_maquina.Name = "lbl_maquina";
            this.lbl_maquina.Size = new System.Drawing.Size(48, 13);
            this.lbl_maquina.TabIndex = 17;
            this.lbl_maquina.Text = "Máquina";
            // 
            // lv_impressoes
            // 
            this.lv_impressoes.HideSelection = false;
            this.lv_impressoes.Location = new System.Drawing.Point(12, 93);
            this.lv_impressoes.Name = "lv_impressoes";
            this.lv_impressoes.Size = new System.Drawing.Size(1131, 347);
            this.lv_impressoes.TabIndex = 10;
            this.lv_impressoes.UseCompatibleStateImageBehavior = false;
            this.lv_impressoes.View = System.Windows.Forms.View.Details;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Enabled = false;
            this.btn_buscar.Location = new System.Drawing.Point(12, 64);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(1131, 23);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_impressoes_Click);
            // 
            // btn_ler_arquivo
            // 
            this.btn_ler_arquivo.Enabled = false;
            this.btn_ler_arquivo.Location = new System.Drawing.Point(887, 8);
            this.btn_ler_arquivo.Name = "btn_ler_arquivo";
            this.btn_ler_arquivo.Size = new System.Drawing.Size(70, 23);
            this.btn_ler_arquivo.TabIndex = 3;
            this.btn_ler_arquivo.Text = "Ler Arquivo";
            this.btn_ler_arquivo.UseVisualStyleBackColor = true;
            this.btn_ler_arquivo.Click += new System.EventHandler(this.btn_ler_arquivo_Click);
            // 
            // pb_carregamento_listview
            // 
            this.pb_carregamento_listview.Location = new System.Drawing.Point(70, 446);
            this.pb_carregamento_listview.Name = "pb_carregamento_listview";
            this.pb_carregamento_listview.Size = new System.Drawing.Size(1073, 23);
            this.pb_carregamento_listview.TabIndex = 12;
            this.pb_carregamento_listview.Visible = false;
            // 
            // btn_csv
            // 
            this.btn_csv.Image = global::infoPrint.Properties.Resources.csv;
            this.btn_csv.Location = new System.Drawing.Point(12, 446);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(38, 33);
            this.btn_csv.TabIndex = 11;
            this.btn_csv.UseVisualStyleBackColor = true;
            this.btn_csv.Click += new System.EventHandler(this.btn_csv_Click);
            // 
            // btn_abrir_arquivo
            // 
            this.btn_abrir_arquivo.Image = global::infoPrint.Properties.Resources.aberto_menor;
            this.btn_abrir_arquivo.Location = new System.Drawing.Point(853, 8);
            this.btn_abrir_arquivo.Name = "btn_abrir_arquivo";
            this.btn_abrir_arquivo.Size = new System.Drawing.Size(28, 23);
            this.btn_abrir_arquivo.TabIndex = 2;
            this.btn_abrir_arquivo.UseVisualStyleBackColor = true;
            this.btn_abrir_arquivo.Click += new System.EventHandler(this.btn_abrir_arquivo_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 481);
            this.Controls.Add(this.pb_carregamento_listview);
            this.Controls.Add(this.btn_ler_arquivo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_csv);
            this.Controls.Add(this.lv_impressoes);
            this.Controls.Add(this.btn_abrir_arquivo);
            this.Controls.Add(this.lbl_maquina);
            this.Controls.Add(this.txt_maquina);
            this.Controls.Add(this.cb_impressoras);
            this.Controls.Add(this.dtp_data_final);
            this.Controls.Add(this.dtp_data_inicial);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_local_arquivo);
            this.Controls.Add(this.lbl_arq_log);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_impressoras);
            this.Controls.Add(this.lbl_dt_final);
            this.Controls.Add(this.lbl_dt_inicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.Text = "Consulta de impressões PapperCut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dt_inicial;
        private System.Windows.Forms.Label lbl_dt_final;
        private System.Windows.Forms.Label lbl_impressoras;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_arq_log;
        private System.Windows.Forms.TextBox txt_local_arquivo;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.DateTimePicker dtp_data_inicial;
        private System.Windows.Forms.DateTimePicker dtp_data_final;
        private System.Windows.Forms.ComboBox cb_impressoras;
        private System.Windows.Forms.TextBox txt_maquina;
        private System.Windows.Forms.Label lbl_maquina;
        private System.Windows.Forms.Button btn_abrir_arquivo;
        private System.Windows.Forms.ListView lv_impressoes;
        private System.Windows.Forms.Button btn_csv;
        private System.Windows.Forms.Button btn_buscar;
        private Button btn_ler_arquivo;

        private List<Impressao> impressoes = new List<Impressao>();
        private List<Impressao> impressoes_filtro = new List<Impressao>();
        private List<string> impressoras = new List<string>();
        private List<string> usuarios = new List<string>();
        private List<string> maquinas = new List<string>();
        private ProgressBar pb_carregamento_listview;
        private string arquivoCopiado = @"C:\Temp\impressoes.csv";
        private AutoCompleteStringCollection listaNomes = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection listaMaquinas = new AutoCompleteStringCollection();
    }
}

