using System;

namespace infoPrint.models
{
    internal class Impressao
    {
        private DateTime date ;
        private string usuario ;
        private int numeroPaginas ;
        private int numeroCopias ;
        private string impressora ;
        private string nomeDocumento ;
        private string maquina ;
        private string tamanhoPapel ;
        private string linguagemDaImpressora ;
        private string altura ;
        private string largura ;
        private string duplex ;
        private string escalaDeCinza ;
        private string tamanho ;

        public Impressao(DateTime data, string usuario, int numeroPaginas, int numeroCopias, string impressora, string nomeDocumento, string maquina, string tamanhoPapel, string linguagemDaImpressora, string altura, string largura, string duplex, string escalaDeCinza, string tamanho)
        {
            this.date = data;
            this.usuario = usuario;
            this.numeroPaginas = numeroPaginas;
            this.numeroCopias = numeroCopias;
            this.impressora = impressora;
            this.nomeDocumento = nomeDocumento;
            this.maquina = maquina;
            this.tamanhoPapel = tamanhoPapel;
            this.linguagemDaImpressora = linguagemDaImpressora;
            this.altura = altura;
            this.largura = largura;
            this.duplex = duplex;
            this.escalaDeCinza = escalaDeCinza;
            this.tamanho = tamanho;
        }

        public Impressao()
        {
        }

        public DateTime Date { get { return this.date; } set { this.date = value; } }
        public string Usuario { get { return this.usuario; } set { this.usuario = value; } }
        public int NumeroPaginas { get { return this.numeroPaginas; } set { this.numeroPaginas = value; } }
        public int NumeroCopias { get { return this.numeroCopias; } set { this.numeroCopias = value; } }
        public string NomeDocumento { get { return this.nomeDocumento; } set { this.nomeDocumento = value; } }
        public string Impressora { get { return this.impressora; } set { this.impressora = value; } }
        public string TamanhoPapel { get { return this.tamanhoPapel; } set { this.tamanhoPapel = value; } }
        public string Maquina { get { return this.maquina; } set { this.maquina = value; } }
        public string LinguagemDaImpressora { get { return this.linguagemDaImpressora; } set { this.linguagemDaImpressora = value; } }
        public string Altura { get { return this.altura; } set { this.altura = value; } }
        public string Largura { get { return this.largura; } set { this.largura = value; } }
        public string Duplex { get { return this.duplex; } set { this.duplex = value; } }
        public string EscalaDeCinza { get { return this.escalaDeCinza; } set { this.escalaDeCinza = value; } }
        public string Tamanho { get { return this.tamanho; } set { this.tamanho = value; } }

    }
}
