using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    /*
        A camada Data Access Layer (DAL) claramente separa a lógica de
        acesso aos dados da lógica de apresentação (formulário Windows,
        Formulário Web ou dispositivo móvel).
    */

    public class EmprestimoDAL
    {
        string _conexaoSQLServer = "";
        SqlConnection _conexao = null;

        public EmprestimoDAL(string banco, string usuario, string senha)
        {
            _conexaoSQLServer = $"Data Source=regulus.cotuca.unicamp.br; Initial Catalog={banco};" +
                                $"User id={usuario}; Password={senha}";
        }

        public List<Emprestimo> SelectListEmprestimos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using (SqlCommand command =
                    new SqlCommand("Select * from bibEmprestimo", conn))
                    {
                        conn.Open();
                        List<Emprestimo> listaEmprestimos = new List<Emprestimo>();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo(
                                (int)dr["idEmprestimo"],
                                (int)dr["idLivro"],
                                (int)dr["idLeitor"],
                                Convert.ToDateTime(dr["dataEmprestimo"]),
                                Convert.ToDateTime(dr["dataDevolucaoPrevista"]),
                                Convert.ToDateTime(dr["dataDevolucaoReal"])
                                );
                                listaEmprestimos.Add(emprestimo);
                            }
                        }
                        return listaEmprestimos;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar emprestimos " + ex.Message);
            }
        }

        public DataTable SelectEmprestimos()
        {
            try
            {
                String sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo,dataDevolucaoPrevista,dataDevolucaoReal " +
                             "FROM bibEmprestimo";

                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectEmprestimosByLeitor(int idLeitor)
        {
            try
            {
                String sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo,dataDevolucaoPrevista,dataDevolucaoReal " +
                             "FROM bibEmprestimo " +
                             "Where idLeitor = @id";

                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idLeitor);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectEmprestimoByLivro(int idLivro)
        {
            try
            {
                String sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo,dataDevolucaoPrevista " +
                             "FROM bibEmprestimo " +
                             "Where idLivro = @id";

                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idLivro);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Emprestimo SelectEmprestimoById(int idDesejado)
        {
            try
            {
                String sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo,dataDevolucaoPrevista,dataDevolucaoReal " +
                             " FROM bibEmprestimo WHERE idEmprestimo = @id";

                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Emprestimo emprestimo = null;

                if (dr.Read())
                {
                    emprestimo = new Emprestimo(
                                Convert.ToInt32(dr["idEmprestimo"]),
                                Convert.ToInt32(dr["idLivro"]),
                                Convert.ToInt32(dr["idLeitor"]),
                                Convert.ToDateTime(dr["dataEmprestimo"]),
                                Convert.ToDateTime(dr["dataDevolucaoPrevista"]),
                                Convert.ToDateTime(dr["dataDevolucaoReal"])
                                );
                }
                return emprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Emprestimo> SelectListaDeEmprestimosPorId(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using (SqlCommand command =
                    new SqlCommand("SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo,dataDevolucaoPrevista,dataDevolucaoReal " +
                                   " FROM bibEmprestimo WHERE idEmprestimo LIKE @id ", conn))
                    {
                        conn.Open();
                        command.Parameters.AddWithValue("@id", '%'+id+'%');
                        List<Emprestimo> listaEmprestimos = new List<Emprestimo>();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo(
                                (int)dr["idEmprestimo"],
                                (int)dr["idLivro"],
                                (int)dr["idLeitor"],
                                Convert.ToDateTime(dr["dataEmprestimo"]),
                                Convert.ToDateTime(dr["dataDevolucaoPrevista"]),
                                Convert.ToDateTime(dr["dataDevolucaoReal"])
                                );
                                listaEmprestimos.Add(emprestimo);
                            }
                        }
                        return listaEmprestimos;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar emprestimos " + ex.Message);
            }
        }

        public DataTable SelectEmprestimosPendentes()
        {
            try
            {
                String sql = "SELECT idEmprestimo, nomeLeitor, tituloLivro," +
                             " dataEmprestimo, dataDevolucaoPrevista FROM " +
                             " (bibEmprestimo E JOIN bibLivro L on E.idLivro = L.idLivro) JOIN " +
                             " bibLeitor T on idLeitor = T.idLeitor WHERE dataDevoucaoReal IS NULL";

                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectEmprestimosDevolvidos()
        {
            try
            {
                String sql = "SELECT idEmprestimo, nomeLeitor, tituloLivro," +
                             " dataEmprestimo, dataDevolucaoPrevista FROM " +
                             " (bibEmprestimo E JOIN bibLivro L on E.idLivro = L.idLivro) JOIN " +
                             " bibLeitor T on E.idLeitor = T.idLeitor WHERE dataDevoucaoReal IS NOT NULL";

                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "INSERT INTO bibEmprestimo " +
                             " (idLivro,idLeitor,dataEmprestimo,dataDevolucaoPrevista,dataDevolucaoReal) " +
                             " VALUES (@idLiv, @idLei, @dE, @dDP, @dDR) ";

                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLiv", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@idLei", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@dE", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dDP", qualEmprestimo.DataDevolucaoPrevista);
                cmd.Parameters.AddWithValue("@dDR", qualEmprestimo.DataDevolucaoReal);
                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)   
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void DeleteEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "DELETE FROM bibEmprestimo WHERE idEmprestimo = @idEmprestimo ";

                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idEmprestimo", qualEmprestimo.IdEmprestimo);
                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public void UpdateEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "UPDATE bibEmprestimo " +
                             " SET idLeitor= @idLei ," +
                             " idLivro=@idLiv," +
                             " dataEmprestimo=@dE, " +
                             " dataDevolucaoPrevista=@dDP, " +
                             " dataDevolucaoReal=@dDR" +
                             " WHERE idEmprestimo = @idEmprestimo ";

                _conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLei", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@idLiv", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@dE", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dDP", qualEmprestimo.DataDevolucaoPrevista);
                cmd.Parameters.AddWithValue("@dDR", qualEmprestimo.DataDevolucaoReal);
                cmd.Parameters.AddWithValue("@idEmprestimo", qualEmprestimo.IdEmprestimo);
                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }
    }
}

