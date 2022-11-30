using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Emprestimo
    {
        int idEmprestimo;
        int idLivro;
        int idLeitor;
        DateTime dataEmprestimo;
        DateTime dataDevolucaoPrevista;
        DateTime dataDevolucaoReal;

        public int IdEmprestimo
        {
            get => idEmprestimo;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idEmprestimo = value; // armazena o valor passado no atributo de destino
            }
        }

        public int IdLeitor
        {
            get => idLeitor;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idLeitor = value; // armazena o valor passado no atributo de destino
            }
        }

        public int IdLivro
        {
            get => idLivro;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idLivro = value; // armazena o valor passado no atributo de destino
            }
        }

        public DateTime DataEmprestimo
        {
            get => dataEmprestimo;
            set
            {
                dataEmprestimo = value;
            }
        }

        public DateTime DataDevolucaoPrevista
        {
            get => dataDevolucaoPrevista;
            set
            {
                dataDevolucaoPrevista = value;
            }
        }

        public DateTime DataDevolucaoReal
        {
            get
            {
                return dataDevolucaoReal;
            }
            set
            {
                dataDevolucaoReal = value;
            }
        }

        public Emprestimo(int idEmprestimo, int idLivro, int idLeitor, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista, DateTime dataDevolucaoReal)
        {
            IdEmprestimo = idEmprestimo;
            IdLivro = idLivro;
            IdLeitor = idLeitor;
            DataEmprestimo = dataEmprestimo;
            DataDevolucaoPrevista = dataDevolucaoPrevista;
            DataDevolucaoReal = dataDevolucaoReal;
        }
    }
}