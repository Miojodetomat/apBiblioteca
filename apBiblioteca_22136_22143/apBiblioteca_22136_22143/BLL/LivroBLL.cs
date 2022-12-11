using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    /*
        A Camada de Lógica de Negócio (BLL) conterá uma classe para cada uma das tabela TableAdapter
        da camada DAL. Cada uma dessas classes da BLL terão métodos para recuperar, inserir, atualizar
        e remover registros da respectiva TableAdapter da DAL, aplicando as regras de negócio apropriadas
        para que o funcionamento correto do programa seja garantido.
    */

    public class LivroBLL
    {
        DAL.LivroDAL dal = null;
        string banco;
        string usuario;
        string senha;

        public LivroBLL(string banco, string usuario, string senha)
        {
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;
        }

        public DataTable SelecionarLivros() {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                tb = dal.SelectLivros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public void IncluirLivro(Livro livro) 
        {
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                dal.InsertLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarLivro(Livro livro) 
        {
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                dal.UpdateLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirLivro(Livro livro) 
        {
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                dal.DeleteLivro(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Livro> ListarLivros() 
        {
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                return dal.SelectListLivros();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Livro ListarLivroPorId(int id) {
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                return dal.SelectLivroById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Livro> SelecionarLivrosPorCodigo(string codigo)
        {
            try
            {
                dal = new DAL.LivroDAL(banco, usuario, senha);
                return dal.SelectListaDeLivrosByCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

