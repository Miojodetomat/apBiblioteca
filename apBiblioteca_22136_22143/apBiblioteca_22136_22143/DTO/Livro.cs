﻿using System;
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

    public class Livro
    {
        public const int tamanhoCodigo = 10,
                         tamanhoTitulo = 50,
                         tamanhoAutor  = 50;
        int idLivro;
        string codigoLivro;
        string tituloLivro;
        string autorLivro;

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

        public string CodigoLivro
        {
            get => codigoLivro;
            set
            {
                // remove qualquer caracter além do tamanho máximo do campo
                if(value.Length > tamanhoCodigo)
                    value = value.Remove(tamanhoCodigo);
                else
                    // preenche codigo com zeros à esquerda até completar o tamanho mãximo 
                    value = value.PadLeft(tamanhoCodigo, '0');

                // armazena o valor passado no atributo de destino
                codigoLivro = value;
            }
        }

        public string TituloLivro
        {
            get => tituloLivro;
            set
            {
                // remove qualquer caracter além do tamanho máximo do campo
                if (value.Length > tamanhoTitulo)
                    value = value.Remove(tamanhoTitulo);
                else
                    // preenche título com espaços à direita até completar o tamanho mãximo
                    value = value.PadRight(tamanhoTitulo, ' ');

                // armazena o valor passado no atributo de destino
                tituloLivro = value;
            }
        }

        public string AutorLivro
        {
            get
            {
                return autorLivro;
            }
            set
            {
                // remove qualquer caracter além do tamanho máximo do campo
                if (value.Length > tamanhoAutor)
                    value = value.Remove(tamanhoAutor);
                else
                    // preenche título com espaços à direita até completar o tamanho mãximo
                    value = value.PadRight(tamanhoAutor, ' ');

                // armazena o valor passado no atributo de destino
                autorLivro = value;
            }
        }

        public Livro(int id, string codigo, string titulo, string autor)
        {
            IdLivro     = id;
            CodigoLivro = codigo;
            TituloLivro = titulo;
            AutorLivro  = autor;
        }
    }
}