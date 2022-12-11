using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /*
        DTO é uma sigla para Data Transfer Object (Objeto de Transferência de Dados).
        DTO é um padrão de projeto de software usado para transferir dados entre subsistemas de um
        software. DTOs são frequentemente usados em conjunção com objetos da camada de acesso a dados
        para obter e armazenar dados de um banco de dados.
    */

    public class Leitor
    {
        public const int tamanhoNome     = 50,
                         tamanhoTelefone = 20,
                         tamanhoEmail    = 50,
                         tamanhoEndereco = 100;
        int idLeitor;
        string nomeLeitor;
        string telefoneLeitor;
        string emailLeitor;
        string enderecoLeitor;

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

        public string NomeLeitor
        {
            get => nomeLeitor;
            set
            {
                // remove qualquer caracter além do tamanho máximo do campo
                if (value.Length > tamanhoNome)
                    value = value.Remove(tamanhoNome);
                else
                    value = value.PadRight(tamanhoNome, ' ');

                // armazena o valor passado no atributo de destino
                nomeLeitor = value;
            }
        }

        public string TelefoneLeitor
        {
            get => telefoneLeitor;
            set
            {
                // remove qualquer caracter além do tamanho máximo do campo
                if (value.Length > tamanhoTelefone)
                    value = value.Remove(tamanhoTelefone);
                else
                    // preenche título com espaços à direita até completar o tamanho mãximo
                    value = value.PadRight(tamanhoTelefone, ' ');

                // armazena o valor passado no atributo de destino
                telefoneLeitor = value;
            }
        }

        public string EmailLeitor
        {
            get
            {
                return emailLeitor;
            }
            set
            {
                // remove qualquer caracter além do tamanho máximo do campo
                if (value.Length > tamanhoEmail)
                    value = value.Remove(tamanhoEmail);
                else
                    // preenche título com espaços à direita até completar o tamanho mãximo
                    value = value.PadRight(tamanhoEmail, ' ');

                // armazena o valor passado no atributo de destino
                emailLeitor = value;
            }
        }

        public string EnderecoLeitor
        {
            get
            {
                return enderecoLeitor;
            }
            set
            {
                // remove qualquer caracter além do tamanho máximo do campo
                if (value.Length > tamanhoEndereco)
                    value = value.Remove(tamanhoEndereco);
                else
                    // preenche título com espaços à direita até completar o tamanho mãximo
                    value = value.PadRight(tamanhoEndereco, ' ');

                // armazena o valor passado no atributo de destino
                enderecoLeitor = value;
            }
        }

        public Leitor(int id, string nome, string telefone, string email, string endereco)
        {
            IdLeitor       = id;
            EmailLeitor    = email;
            TelefoneLeitor = telefone;
            NomeLeitor     = nome;
            EnderecoLeitor = endereco;
        }
    }
}
