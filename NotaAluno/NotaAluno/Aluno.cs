using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotaAluno
{
    class Aluno
    {
        //Declaração de Variáveis
        private String nome;
        private double n1;
        private double n2;
        private double media;

        //Método Construtor Vazio
        public Aluno()
        {
            this.nome = "";
            this.n1 = 0.0;
            this.n2 = 0.0;
            this.media = 0.0;
        }
        public Aluno(String nome, double n1, double n2, double media)
        {
            this.nome = nome;
            this.n1 = n1;
            this.n2 = n2;
            this.media = media;
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public double N1
        {
            get { return this.n1; }
            set { this.n1 = value; }
        }
        public double N2
        {
            get { return this.n2; }
            set { this.n2 = value; }
        }
        public double Media
        {
            get { return this.media; }
            set { this.media = value; }
        }
        public void CalcularMedia(double n1, double n2)
        {
            this.Media = (n1 * n2) / 2;

        }
        public double MostrarMedia()
        {
            return this.Media;
        }
    }
}
