using solucaoData.Connection;
using solucaoDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace solucaoData.RepositoriesDAO
{
    public class RepositoryClassificado
    {
        public Classificado ObterPorID(int IDClassificado)
        {

            Conexao cnn = new Conexao();
            Classificado model = new Classificado();
            SqlDataReader rdr = null;

            try
            {
                SqlCommand cmd = new SqlCommand("proc_ClassificadoObterPorID");
                cmd.Connection = cnn.openConnection();
                cmd.Parameters.AddWithValue("@IDClassificado", IDClassificado);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    try { model.Titulo = rdr.GetString(rdr.GetOrdinal("Titulo")); } catch (Exception e) { throw; }
                    try { model.Descricao = rdr.GetString(rdr.GetOrdinal("Descricao")); } catch (Exception e) { throw; }
                    try { model.DataCadastro = Convert.ToDateTime(rdr.GetString(rdr.GetOrdinal("DataCadastro"))); } catch (Exception e) { throw; }
                    try { model.Preco = rdr.GetDecimal(rdr.GetOrdinal("Preco")); } catch (Exception e) { throw; }
                    try { model.Status = rdr.GetBoolean(rdr.GetOrdinal("Titulo")); } catch (Exception e) { throw; }
                }
            }
            catch (Exception e) { }
            finally
            {
                if (cnn != null) { cnn.closeConnection(); }
                if (rdr != null) { rdr.Close(); }
            }

            return model;
        }
        public List<Classificado> ObterTodos()
        {
            Conexao cnn = new Conexao();
            Classificado model = new Classificado();
            List<Classificado> lista = new List<Classificado>();
            SqlDataReader rdr = null;

            try
            {
                SqlCommand cmd = new SqlCommand("proc_ClassificadoObterTodos");
                cmd.Connection = cnn.openConnection();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    try { model.Titulo = rdr.GetString(rdr.GetOrdinal("Titulo")); } catch (Exception e) { throw; }
                    try { model.Descricao = rdr.GetString(rdr.GetOrdinal("Descricao")); } catch (Exception e) { throw; }
                    try { model.DataCadastro = Convert.ToDateTime(rdr.GetString(rdr.GetOrdinal("DataCadastro"))); } catch (Exception e) { throw; }
                    try { model.Preco = rdr.GetDecimal(rdr.GetOrdinal("Preco")); } catch (Exception e) { throw; }
                    try { model.Status = rdr.GetBoolean(rdr.GetOrdinal("Titulo")); } catch (Exception e) { throw; }

                    lista.Add(model);
                }
            }
            catch (Exception e) { }
            finally
            {
                if (cnn != null) { cnn.closeConnection(); }
                if (rdr != null) { rdr.Close(); }
            }

            return lista;
        }
    }
}
