using System;
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

    public class LeitorBLL
    {
        DAL.LeitorDAL dal = null;
        string banco;
        string senha;
        string usuario;

        public LeitorBLL(string banco, string usuario, string senha)
        {
            this.banco   = banco;
            this.usuario = usuario;
            this.senha   = senha;
        }

        public DataTable SelecionarLeitores()
        {
            DataTable tb = new DataTable();
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                tb = dal.SelectLeitores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public void IncluirLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                dal.InsertLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                dal.UpdateLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                dal.DeleteLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Leitor> ListarLeitores()
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                return dal.SelectListLeitores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Leitor> SelecionarLeitoresPorNome(String nome)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                return dal.SelectListaDeLeitoresPorNome(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarLeitoresPorNome(string nome)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                return dal.SelectLeitoresByNome(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Leitor ListarLeitorPorId(int id)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                return dal.SelectLeitorById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
