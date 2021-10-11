using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;


namespace ConsultaRapida
{
   public class manutencao
    {
        #region Atachando Banco || 05/10/2021
    
        public static void AtacharDB(string IP, string PORTA, string USER, string SENHA, string NOMEDB, string BANCOMDF, string BANCOLDF)
        {
            string strconexao = "Data Source=" + IP + "," + PORTA + "; User Id=" + USER + " ; pwd=" + SENHA + ";";
            
            try
            {
                
                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();


                    sql.AppendFormat(@"CREATE DATABASE ["+NOMEDB+"] ON (FILENAME = N'"+BANCOMDF+ "'), (FILENAME = N'" + BANCOLDF + "') FOR ATTACH");

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {
                        comm.ExecuteNonQuery();
                        alerta.popup("Confirmação de ação", "Query executada com sucesso!");
                    }
                    con.Close();

                }

            }
            catch (Exception ex)
            {
               //Classe para criar alerta personalizado no software 
               alerta.popup("Alerta de erro!",ex.Message);
                               
            }
        }
        #endregion

        #region Backup FULL Banco || 05/10/2021

        public static void BackupDB(string IP, string PORTA, string USER, string SENHA, string NOMEDB, string PATHBACKUP)
        {
            string strconexao = "Data Source=" + IP + "," + PORTA + "; User Id=" + USER + " ; pwd=" + SENHA + ";";

            try
            {

                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();


                    sql.AppendFormat(@"BACKUP DATABASE ["+NOMEDB+"] TO DISK = N'"+PATHBACKUP+"' WITH NOFORMAT, NOINIT, NAME =N'"+NOMEDB+"', SKIP, NOREWIND, NOUNLOAD, STATS = 10");

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {
                        comm.ExecuteNonQuery();
                        alerta.popup("Confirmação de ação", "Backup do banco efetuado com sucesso!");
                    }
                    con.Close();

                }

            }
            catch (Exception ex)
            {
                //Classe para criar alerta personalizado no software 
                alerta.popup("Alerta de erro!", ex.Message);

            }
        }
        #endregion

        #region Restaurar Banco || 05/10/2021
        public static void RestaurarBD(string IP, string PORTA, string USER, string SENHA, string NOMEDB, string PATHBACKUP)
        {
            string strconexao = "Data Source=" + IP + "," + PORTA + "; User Id=" + USER + " ; pwd=" + SENHA + ";";

            try
            {

                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();


                    sql.AppendFormat(@"RESTORE DATABASE [" + NOMEDB + "] FROM DISK = N'" + PATHBACKUP + "' WITH FILE = 1, NORECOVERY,  NOUNLOAD,  REPLACE,  STATS = 5");

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {
                        comm.ExecuteNonQuery();
                        alerta.popup("Confirmação de ação", "Backup restaurado com sucesso!");
                    }
                    con.Close();

                }

            }
            catch (Exception ex)
            {
                //Classe para criar alerta personalizado no software 
                alerta.popup("Alerta de erro!", ex.Message);

            }
        }
        #endregion

        #region Checando Banco || 05/10/2021

        public static void CheckDB(string IP, string PORTA, string USER, string SENHA, string NOMEDB)
        {
            string strconexao = "Data Source=" + IP + "," + PORTA + "; User Id=" + USER + " ; pwd=" + SENHA + ";";

            try
            {

                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();

                    //Executa primeira query
                    sql.AppendFormat(@"ALTER DATABASE ["+NOMEDB+"] SET EMERGENCY");


                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {
                        comm.ExecuteNonQuery();
                        
                    }
                    con.Close();


                    //executa segunda query
                    sql.AppendFormat(@"ALTER DATABASE ["+NOMEDB+"] SET SINGLE_USER");


                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {
                        comm.ExecuteNonQuery();
                        
                    }
                    


                    //executa terceira query
                    sql.AppendFormat(@"DBCC CHECKDB ('["+NOMEDB+"]', REPAIR_ALLOW_DATA_LOSS)");


                    

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {
                        comm.ExecuteNonQuery();
                       
                    }
                    


                    //exeuta quarta query e finaliza com a mensagem
                    sql.AppendFormat(@"ALTER DATABASE ["+NOMEDB+"] SET MULTI_USER");


                    

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {
                        comm.ExecuteNonQuery();
                        alerta.popup("Confirmação de ação", "A checagem do banco de dados foi efetuada com sucesso!");
                    }
                    con.Close();

                }

            }
            catch (Exception ex)
            {
                //Classe para criar alerta personalizado no software 
                alerta.popup("Alerta de erro!", ex.Message);

            }
        }
        #endregion

        #region Verificar tamanho do banco || 05/10/2021

        public static void ObterTamanhoDB(string IP, string PORTA, string USER, string SENHA, string NOMEDB)
        {
            string strconexao = "Data Source=" + IP + "," + PORTA + "; User Id=" + USER + " ; pwd=" + SENHA + ";";

            try
            {

                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();

                    //Executa primeira query
                    sql.AppendFormat(@" USE [" + NOMEDB + "] SELECT t.NAME AS Entidade, p.rows AS Registros, SUM(a.total_pages) * 8 AS EspacoTotalKB, SUM(a.used_pages) * 8 AS EspacoUsadoKB, (SUM(a.total_pages) -" +
                        " SUM(a.used_pages)) * 8 AS EspacoNaoUsadoKB FROM sys.tables t INNER JOIN sys.indexes i ON t.OBJECT_ID = i.object_id INNER JOIN sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id" +
                        " INNER JOIN sys.allocation_units a ON p.partition_id = a.container_id LEFT OUTER JOIN sys.schemas s ON t.schema_id = s.schema_id WHERE t.NAME NOT LIKE 'dt%' AND t.is_ms_shipped = 0 AND i.OBJECT_ID > 255 GROUP BY t.Name, s.Name, p.Rows ORDER BY");


                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {
                        comm.ExecuteNonQuery();
                        alerta.popup("Confirmação de ação", "Verificação do tamanho do banco realizado com sucesso!");
                    }
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                //Classe para criar alerta personalizado no software 
                alerta.popup("Alerta de erro!", ex.Message);

            }
        }
        #endregion

        #region Compactar Arquivo de Dados || 05/10/2021
        public static void CompactarDados(string IP, string PORTA, string USER, string SENHA, string NOMEDB)
        {
            string strconexao = "Data Source=" + IP + "," + PORTA + "; User Id=" + USER + " ; pwd=" + SENHA + ";";

            try
            {

                using (SqlConnection con = new SqlConnection(strconexao))
                {

                    StringBuilder sql = new StringBuilder();

                    //Executa primeira query
                    sql.AppendFormat(@" USE [" + NOMEDB + "] DBCC SHRINKFILE (N'"+NOMEDB+"', 17)");
                       

                    con.Open();

                    using (SqlCommand comm = new SqlCommand(sql.ToString(), con))
                    {
                        comm.ExecuteNonQuery();
                        alerta.popup("Confirmação de ação", "Arquivos de dados compactados com sucesso!");
                    }
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                //Classe para criar alerta personalizado no software 
                alerta.popup("Alerta de erro!", ex.Message);

            }
        }
        #endregion
        
    }
}
