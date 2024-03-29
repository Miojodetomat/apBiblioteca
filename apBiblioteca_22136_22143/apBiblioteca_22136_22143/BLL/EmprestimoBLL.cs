﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BLL
{
    /*
        A Camada de Lógica de Negócio (BLL) conterá uma classe para cada uma das tabela TableAdapter
        da camada DAL. Cada uma dessas classes da BLL terão métodos para recuperar, inserir, atualizar
        e remover registros da respectiva TableAdapter da DAL, aplicando as regras de negócio apropriadas
        para que o funcionamento correto do programa seja garantido.
    */

    public class EmprestimoBLL
    {
        DAL.EmprestimoDAL dal = null;
        string banco;
        string senha;
        string usuario;

        public EmprestimoBLL(string banco, string usuario, string senha)
        {
            this.banco   = banco;
            this.usuario = usuario;
            this.senha   = senha;
        }

        public DataTable SelecionarEmprestimos()
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                tb = dal.SelectEmprestimos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public DataTable SelecionarEmprestimosPorLeitor(int idLeitor)
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                tb = dal.SelectEmprestimosByLeitor(idLeitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public DataTable SelecionarEmprestimosPorLivro(int idLivro)
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                tb = dal.SelectEmprestimoByLivro(idLivro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public DataTable SelecionarEmprestimosPendentes()
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                tb = dal.SelectEmprestimosPendentes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public DataTable SelecionarEmprestimosDevolvidos()
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                tb = dal.SelectEmprestimosDevolvidos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public void IncluirEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                dal.InsertEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                dal.UpdateEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarDevolucao(Emprestimo emprestimo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                dal.UpdateDevolucao(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                dal.DeleteEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Emprestimo> ListarEmprestimos()
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectListEmprestimos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Emprestimo ListarEmprestimoPorId(int id)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectEmprestimoById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Emprestimo> SelecionarEmprestimosPorId(int id)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectListaDeEmprestimosPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
