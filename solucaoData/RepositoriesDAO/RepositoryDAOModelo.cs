namespace solucaoData.RepositoriesDAO
{
    //public List<Processo> localizarProcessosMalhaFina(String numeroProcesso, String numeroAlvara, String cpf, String cnpj, String cep, String codLogradouro, String logradouro
    //          , String bairro, String numeroPorta, String dataEntradaMin, String dataEntradaMax, String statusId, String itemServico, String zona, String grupo_servico, Int32 usu_id, String grupoStatus, String grupoTramitacao)
    //{
    //    Connection conn = new Connection();
    //    Processo model = new Processo();
    //    List<Processo> listaProcessos = new List<Processo>();
    //    SqlDataReader rdr = null;
    //    try
    //    {
    //        SqlCommand cmd = new SqlCommand("STb_ListarProcessoMalhaFinaWeb");
    //        cmd.Connection = conn.openConnection();
    //        cmd.Parameters.AddWithValue("@numeroProcesso", numeroProcesso);
    //        cmd.Parameters.AddWithValue("@numeroAlvara", numeroAlvara);
    //        cmd.Parameters.AddWithValue("@CPF", cpf);
    //        cmd.Parameters.AddWithValue("@CNPJ", cnpj);
    //        cmd.Parameters.AddWithValue("@CEP", cep);
    //        cmd.Parameters.AddWithValue("@codLogradouro", codLogradouro);
    //        cmd.Parameters.AddWithValue("@logradouro", logradouro);
    //        cmd.Parameters.AddWithValue("@bairro", bairro);
    //        cmd.Parameters.AddWithValue("@numeroPorta", numeroPorta);
    //        cmd.Parameters.AddWithValue("@dataEntradaMin", dataEntradaMax.Trim().Equals("") ? "" : FormatUtil.FormatarData(dataEntradaMin));
    //        cmd.Parameters.AddWithValue("@dataEntradaMax", dataEntradaMax.Trim().Equals("") ? DateTime.Now.ToString("dd/MM/yyyy") : FormatUtil.FormatarData(dataEntradaMax.Trim()));
    //        cmd.Parameters.AddWithValue("@statusId", statusId);
    //        cmd.Parameters.AddWithValue("@itemServico", itemServico);
    //        cmd.Parameters.AddWithValue("@zona", zona);
    //        cmd.Parameters.AddWithValue("@grupo_servico", grupo_servico);
    //        cmd.Parameters.AddWithValue("@usu_id", usu_id);
    //        cmd.Parameters.AddWithValue("@grupoStatus", grupoStatus);
    //        cmd.Parameters.AddWithValue("@grupoTramitacao", grupoTramitacao);

    //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
    //        rdr = cmd.ExecuteReader();
    //        while (rdr.Read())
    //        {
    //            model = new Processo();
    //            model.existeSemiExpresso = false;
    //            model.existeMalhaFina = false;
    //            model.pro_data_criacao = "";
    //            model.requerente = "";
    //            model.responsavel_tecnico = "";

    //            model.processo = rdr.GetString(rdr.GetOrdinal("PROCESSO"));
    //            if (!rdr.IsDBNull(rdr.GetOrdinal("PRO_DATA_CRIACAO")))
    //                model.pro_data_criacao = rdr.GetString(rdr.GetOrdinal("PRO_DATA_CRIACAO"));
    //            if (!rdr.IsDBNull(rdr.GetOrdinal("REQUERENTE")))
    //                model.requerente = rdr.GetString(rdr.GetOrdinal("REQUERENTE"));
    //            if (!rdr.IsDBNull(rdr.GetOrdinal("RESPONSAVEL_TECNICO")))
    //                model.responsavel_tecnico = rdr.GetString(rdr.GetOrdinal("RESPONSAVEL_TECNICO"));
    //            if (rdr.GetString(rdr.GetOrdinal("existeMalhaFina")) != "")
    //                model.existeMalhaFina = true;
    //            if (rdr.GetString(rdr.GetOrdinal("existeSemiExpresso")) != "")
    //                model.existeSemiExpresso = true;

    //            try { model.servico = FormatUtil.StripHTML(rdr.GetString(rdr.GetOrdinal("SERVICO"))); } catch (Exception) { model.servico = ""; }
    //            try { model.status = rdr.GetString(rdr.GetOrdinal("STATUS")); } catch (Exception) { model.status = ""; }
    //            try { model.fimDeObra = rdr.GetDecimal(rdr.GetOrdinal("ANDAMENTO")); } catch (Exception) { }

    //            listaProcessos.Add(model);
    //        }
    //    }
    //    catch (Exception e) { }
    //    finally
    //    {
    //        if (conn != null) { conn.closeConnection(); }
    //        if (rdr != null) { rdr.Close(); }
    //    }
    //    return listaProcessos;
    //}
}
