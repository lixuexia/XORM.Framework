﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace XORM.NBase.Data
{
    internal class SQLServerImpl : IDbExecute
    {
        public DbDataReader ExecDataReader(string cmdText)
        {
            return ExecDataReader(cmdText, null);
        }
        public DbDataReader ExecDataReader(string cmdText, params object[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                CommonPreCmd(cmdText, cmd, null, CommandType.Text, cmdParams);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public DataSet ExecDataSet(DbCommand cmd)
        {
            try
            {
                cmd.Connection = this.SQLConn;
                this.Open();
                SqlDataAdapter adp = new SqlDataAdapter((SqlCommand)cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                this.Close();
                return ds;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public DataTable ExecDataTable(DbCommand cmd)
        {
            try
            {
                cmd.Connection = this.SQLConn;
                this.Open();
                SqlDataAdapter adp = new SqlDataAdapter((SqlCommand)cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                this.Close();
                return dt;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public int ExecNonQuery(DbCommand cmd)
        {
            try
            {
                cmd.Connection = this.SQLConn;
                this.Open();
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                this.Close();
                return val;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public DataSet ExecProcDataSet(string ProcName)
        {
            return ExecProcDataSet(ProcName, null);
        }

        public DataSet ExecProcDataSet(string ProcName, params object[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                CommonPreCmd(ProcName, cmd, null, CommandType.StoredProcedure, cmdParams);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.Parameters.Clear();
                this.Close();
                return ds;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public DataTable ExecProcDataTable(string ProcName)
        {
            return ExecProcDataTable(ProcName);
        }

        public DataTable ExecProcDataTable(string ProcName, params object[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                CommonPreCmd(ProcName, cmd, null, CommandType.StoredProcedure, cmdParams);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Parameters.Clear();
                this.Close();
                return dt;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public int ExecProcNonQuery(string ProcName)
        {
            return ExecProcNonQuery(ProcName, null);
        }

        public int ExecProcNonQuery(string ProcName, params object[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                CommonPreCmd(ProcName, cmd, null, CommandType.StoredProcedure, cmdParams);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                this.Close();
                return val;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public object ExecProcScalar(string ProcName)
        {
            return ExecProcScalar(ProcName, null);
        }

        public object ExecProcScalar(string ProcName, params object[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                CommonPreCmd(ProcName, cmd, null, CommandType.StoredProcedure, cmdParams);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                this.Close();
                return val;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public object ExecScalar(string cmdText)
        {
            return ExecTextScalar(cmdText);
        }

        public object ExecScalar(DbCommand cmd)
        {
            try
            {
                cmd.Connection = this.SQLConn;
                this.Open();
                object obj = cmd.ExecuteScalar();
                this.Close();
                return obj;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public DataSet ExecTextDataSet(string SQLText)
        {
            return ExecTextDataSet(SQLText,null);
        }

        public DataSet ExecTextDataSet(string SQLText, params object[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                CommonPreCmd(SQLText, cmd, null, CommandType.Text, cmdParams);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.Parameters.Clear();
                this.Close();
                return ds;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public DataTable ExecTextDataTable(string SQLText)
        {
            return ExecTextDataTable(SQLText, null);
        }

        public DataTable ExecTextDataTable(string SQLText, params object[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                CommonPreCmd(SQLText, cmd, null, CommandType.Text, cmdParams);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Parameters.Clear();
                this.Close();
                return dt;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public int ExecTextNonQuery(string SQLText)
        {
            return ExecTextNonQuery(SQLText, null);
        }

        public int ExecTextNonQuery(string SQLText, params object[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                CommonPreCmd(SQLText, cmd, null, CommandType.Text, cmdParams);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                this.Close();
                return val;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public object ExecTextScalar(string SQLText)
        {
            return ExecTextScalar(SQLText,null);
        }

        public object ExecTextScalar(string SQLText, params object[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                CommonPreCmd(SQLText, cmd, null, CommandType.Text, cmdParams);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                this.Close();
                return val;
            }
            catch (Exception e)
            {
                this.Close();
                throw e;
            }
        }

        public bool Initialize(string ConnectionString)
        {
            try
            {
                this.SQLConn = new SqlConnection(ConnectionString);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 当前线程工作链接
        /// </summary>
        private SqlConnection SQLConn = null;
        /// <summary>
        /// 参数缓存哈希表
        /// </summary>
        private Hashtable parmCache = Hashtable.Synchronized(new Hashtable());

        #region 外部公共方法
        /// <summary>
        /// 打开连接
        /// </summary>
        public void Open()
        {
            if (this.SQLConn == null)
            {
                throw new Exception("链接尚未初始化!");
            }
            if (this.SQLConn != null && this.SQLConn.State == ConnectionState.Closed)
            {
                this.SQLConn.Open();
            }
        }
        /// <summary>
        /// 关闭连接
        /// </summary>
        public void Close()
        {
            if (this.SQLConn != null && this.SQLConn.State == ConnectionState.Open)
            {
                this.SQLConn.Close();
                this.SQLConn.Dispose();
            }
        }
        #endregion

        #region 内部公共方法
        /// <summary>
        /// 对命令属性进行初始化
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="cmdParms"></param>
        void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, object[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                BuildCommand(cmd, cmdText, cmdParms);
            }
        }

        /// <summary>
        /// 对命令属性进行初始化（重载，无parms参数）
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;
        }
        /// <summary>
        /// 初始化各项数据
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="cmd"></param>
        /// <param name="trans"></param>
        /// <param name="cmdType"></param>
        /// <param name="commandParameters"></param>
        void CommonPreCmd(string cmdText, SqlCommand cmd, SqlTransaction trans, CommandType cmdType, params object[] commandParameters)
        {
            if (commandParameters != null)
            {
                PrepareCommand(cmd, SQLConn, trans, cmdType, cmdText, commandParameters);
            }
            else
            {
                PrepareCommand(cmd, SQLConn, trans, cmdType, cmdText);
            }
        }
        #endregion

        #region 查询命令构造
        /// <summary>
        /// 查询命令构造
        /// </summary>
        /// <param name="sqlPart">部分SQL语句</param>
        /// <param name="ParamsList">可选参数列表</param>
        /// <returns></returns>
        private SqlCommand BuildCommand(SqlCommand MyCmd, string sqlPart, object[] ParamsList = null)
        {
            if (!string.IsNullOrEmpty(sqlPart))
            {
                sqlPart = sqlPart.ToUpper().Replace("@@IDENTITY", "");
                List<string> ParameterList = new List<string>();
                Regex reg = new Regex("(@[0-9a-zA-Z_]{1,30})", RegexOptions.IgnoreCase);
                MatchCollection mc = reg.Matches(sqlPart);
                if (mc != null && mc.Count > 0)
                {
                    foreach (Match m in mc)
                    {
                        if (!ParameterList.Contains(m.Groups[1].Value))
                        {
                            ParameterList.Add(m.Groups[1].Value);
                        }
                    }
                }
                if (ParameterList.Count > 0)
                {
                    int i = 0;
                    foreach (string ParameterName in ParameterList)
                    {
                        if (!MyCmd.Parameters.Contains(ParameterName))
                        {
                            MyCmd.Parameters.AddWithValue(ParameterName, ParamsList[i]);
                        }
                        i++;
                    }
                }
            }
            return MyCmd;
        }
        #endregion
    }
}