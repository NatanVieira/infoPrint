using System;
using System.IO;
using System.Windows.Forms;
using infoPrint.models;

namespace infoPrint
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            this.adicionaColunasListView();
        }

        private void btn_abrir_arquivo_Click(object sender, EventArgs e)
        {
            String nomeArquivo;
            nomeArquivo = this.abreArquivo();
            if (nomeArquivo != "" && nomeArquivo != null)
            {
                this.txt_local_arquivo.Text = nomeArquivo;
                this.btn_ler_arquivo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erro ao abrir o arquivo!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private string abreArquivo()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = this.txt_local_arquivo.Text;
                ofd.Filter = "Arquivos CSV (*.csv)|*.csv|All files (*.*)|*.*";
                ofd.FilterIndex = 0;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }
                return "";
            }
        }

        private void atualizaTextoBotao(int opcao)
        {
            if(opcao == 1)
            {
                switch (this.btn_abrir_arquivo.Text)
                {
                    case "Ler Arquivo":
                        this.btn_abrir_arquivo.Text = "Lendo .";
                        break;
                    case "Lendo .":
                        this.btn_abrir_arquivo.Text = "Lendo ..";
                        break;
                    case "Lendo ..":
                        this.btn_abrir_arquivo.Text = "Lendo ...";
                        break;
                    case "Lendo ...":
                        this.btn_abrir_arquivo.Text = "Lendo .";
                        break;
                }
            }
            else
            {
                this.btn_abrir_arquivo.Text = "Ler Arquivo";
            }
        }

        private void btn_ler_arquivo_Click(object sender, EventArgs e)
        {
            string nomeArquivo = this.copiaArquivo(this.txt_local_arquivo.Text);
            this.lerArquivo(nomeArquivo);
        }

        private string copiaArquivo(string nomeArquivo)
        {
            try
            {
                File.Copy(nomeArquivo, this.arquivoCopiado, true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            return arquivoCopiado;
        }

        private void lerArquivo(string pathArquivo)
        {
            DateTime data_inicial = new DateTime(9999, 12, 31, 23, 59, 59);
            DateTime data_final = new DateTime(2001, 01, 01, 00, 00, 00);
            try
            {
                using (FileStream fs = new FileStream(pathArquivo, FileMode.Open, FileAccess.Read))
                {
                    var leitura = new StreamReader(fs, System.Text.Encoding.ASCII);
                    while (!leitura.EndOfStream)
                    {
                        var linha = leitura.ReadLine();
                        var valor = linha.Split(',');
                        if (valor.Length == 15 && valor[0] != "Time")
                        {
                            DateTime data_impressao = new DateTime(Int32.Parse(valor[0].ToString().Substring(0, 4)),
                                                                   Int32.Parse(valor[0].ToString().Substring(5, 2)),
                                                                   Int32.Parse(valor[0].ToString().Substring(8, 2)),
                                                                   Int32.Parse(valor[0].ToString().Substring(11, 2)),
                                                                   Int32.Parse(valor[0].ToString().Substring(14, 2)),
                                                                   Int32.Parse(valor[0].ToString().Substring(17, 2)));

                            Impressao impressao = new Impressao(data_impressao,
                                                                valor[1],
                                                                Convert.ToInt32(valor[2]),
                                                                Convert.ToInt32(valor[3]),
                                                                valor[4],
                                                                valor[5],
                                                                valor[6],
                                                                valor[7],
                                                                valor[8],
                                                                valor[9],
                                                                valor[10],
                                                                valor[11],
                                                                valor[12],
                                                                valor[13]);
                            if (impressao.Date < data_inicial)
                                data_inicial = data_impressao;
                            if (impressao.Date > data_final)
                                data_final = data_impressao;
                            this.impressoes.Add(impressao);
                            if (this.impressoras.IndexOf(impressao.Impressora) == -1)
                                this.impressoras.Add(impressao.Impressora);
                            if (this.usuarios.IndexOf(impressao.Usuario) == -1)
                                this.usuarios.Add(impressao.Usuario);
                            if (this.maquinas.IndexOf(impressao.Maquina) == -1)
                                this.maquinas.Add(impressao.Maquina);
                        }
                        this.atualizaTextoBotao(1);
                    }
                    leitura.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (this.impressoes.Count > 0)
            {
                this.impressoras.ForEach(impressora =>
                {
                    this.cb_impressoras.Items.Add(impressora.ToString());
                });
                this.cb_impressoras.SelectedIndex = 0;
                this.dtp_data_inicial.Value = data_inicial;
                this.dtp_data_final.Value = data_final;
                this.btn_buscar.Enabled = true;
            }
            else
                MessageBox.Show("Nenhum dado foi importado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.deletaArquivo(pathArquivo);
        }

        private void deletaArquivo(string nomeArquivo)
        {
            try
            {
                File.Delete(nomeArquivo);
            }
            catch(Exception ex)
            {

            }
        }

        private void adicionaColunasListView()
        {
            this.lv_impressoes.Columns.Add("Data", 120);
            this.lv_impressoes.Columns.Add("Usuário", 120);
            this.lv_impressoes.Columns.Add("Pág.", 40);
            this.lv_impressoes.Columns.Add("Cópias", 50);
            this.lv_impressoes.Columns.Add("Impressora", 100);
            this.lv_impressoes.Columns.Add("Documento", 200);
            this.lv_impressoes.Columns.Add("Máquina", 100);
            this.lv_impressoes.Columns.Add("Papel", 40);
            this.lv_impressoes.Columns.Add("Linguagem", 70);
            this.lv_impressoes.Columns.Add("Altura", 40);
            this.lv_impressoes.Columns.Add("Largura", 50);
            this.lv_impressoes.Columns.Add("Duplex", 60);
            this.lv_impressoes.Columns.Add("Esc. de Cinza", 60);
            this.lv_impressoes.Columns.Add("Tamanho Arquivo", 60);
            this.lv_impressoes.Refresh();
        }

        private void preparaProgressBar(int minimo, int maximo)
        {
            this.pb_carregamento_listview.Visible = true;
            this.pb_carregamento_listview.Minimum = minimo;
            this.pb_carregamento_listview.Maximum = maximo;
            this.pb_carregamento_listview.Value = minimo;
            this.pb_carregamento_listview.Step = 1;
        }

        private void fechaProgressBar()
        {
            this.pb_carregamento_listview.Visible = false;
        }

        private void populaListView()
        {
            this.lv_impressoes.Clear();
            this.adicionaColunasListView();
            this.preparaProgressBar(0, this.impressoes_filtro.Count);

            for (int i = 0; i <= this.impressoes_filtro.Count - 1; i++)
            {
                ListViewItem lvi = this.lv_impressoes.Items.Add("");
                lvi.Text = this.impressoes_filtro[i].Date.ToString();
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, this.impressoes_filtro[i].Usuario));
                lvi.SubItems.Add(this.impressoes_filtro[i].NumeroPaginas.ToString());
                lvi.SubItems.Add(this.impressoes_filtro[i].NumeroCopias.ToString());
                lvi.SubItems.Add(this.impressoes_filtro[i].Impressora);
                lvi.SubItems.Add(this.impressoes_filtro[i].NomeDocumento);
                lvi.SubItems.Add(this.impressoes_filtro[i].Maquina);
                lvi.SubItems.Add(this.impressoes_filtro[i].TamanhoPapel);
                lvi.SubItems.Add(this.impressoes_filtro[i].LinguagemDaImpressora);
                lvi.SubItems.Add(this.impressoes_filtro[i].Altura);
                lvi.SubItems.Add(this.impressoes_filtro[i].Largura);
                lvi.SubItems.Add(this.impressoes_filtro[i].Duplex);
                lvi.SubItems.Add(this.impressoes_filtro[i].EscalaDeCinza);
                lvi.SubItems.Add(this.impressoes_filtro[i].Tamanho);
                this.pb_carregamento_listview.PerformStep();
            }
            this.lv_impressoes.Refresh();
            this.fechaProgressBar();
        }   

        private void btn_buscar_impressoes_Click(object sender, EventArgs e)
        {
            this.impressoes_filtro.Clear();
            this.impressoes.ForEach(impressao =>
            {
                if(impressao.Date >= this.dtp_data_inicial.Value && impressao.Date <= this.dtp_data_final.Value
                   && impressao.Impressora == this.cb_impressoras.SelectedItem.ToString()
                   && (impressao.Usuario == this.txt_usuario.Text || this.txt_usuario.Text == "")
                   && (impressao.Maquina == this.txt_maquina.Text || this.txt_maquina.Text == "")){
                    this.impressoes_filtro.Add(impressao);
                }
            });
            if (this.impressoes_filtro.Count > 0)
            {
                this.populaListView();
            }
            else
                MessageBox.Show("Não foram encontrados registros", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_csv_Click(object sender, EventArgs e)
        {
            string nomeArquivo = this.SalvaArquivo();
            if (nomeArquivo != "" && nomeArquivo != null)
                this.gravarArquivo(nomeArquivo);
        }

        private string SalvaArquivo()
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.InitialDirectory = this.txt_local_arquivo.Text;
                save.Filter = "Arquivos CSV (*.csv)|*.csv";
                save.FilterIndex = 0;
                if (save.ShowDialog() == DialogResult.OK)
                    return save.FileName;
                else
                    return "";
            }
        }

        private void gravarArquivo(string nomeArquivo)
        {
            this.preparaProgressBar(0, this.impressoes_filtro.Count);
            using (StreamWriter sw = new StreamWriter(nomeArquivo))
            {
                sw.WriteLine("Data;Usuário;N. Páginas;N. Cópias;Impressora;Documento;Máquina;Papel;Linguagem;Altura;Largura;Duplex;Escala de Cinza;Tamanho");
                this.impressoes_filtro.ForEach(impressao =>
                {
                    sw.Write(impressao.Date.ToString("dd/MM/yyyy HH:mm:ss") + ";");
                    sw.Write(impressao.Usuario + ";");
                    sw.Write(impressao.NumeroPaginas.ToString() + ";");
                    sw.Write(impressao.NumeroCopias.ToString() + ";");
                    sw.Write(impressao.Impressora + ";");
                    sw.Write(impressao.NomeDocumento + ";");
                    sw.Write(impressao.Maquina + ";");
                    sw.Write(impressao.TamanhoPapel + ";");
                    sw.Write(impressao.LinguagemDaImpressora + ";");
                    sw.Write(impressao.Altura + ";");
                    sw.Write(impressao.Largura + ";");
                    sw.Write(impressao.Duplex + ";");
                    sw.Write(impressao.EscalaDeCinza + ";");
                    sw.Write(impressao.Tamanho + ";\n");
                    this.pb_carregamento_listview.PerformStep();
                });
                sw.Close();
            }
            this.fechaProgressBar();
        }
    }
}
