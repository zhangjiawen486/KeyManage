using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using IniFile;
using System.ComponentModel;
using System.Windows.Forms;


namespace SqlFile
{
    public class clsSql
    {
        private SqlConnection sqlCon;//声明一个SqlConnection对象
        private SqlCommand sqlCmd;//声明一个SqlCommand对象
        private SqlDataAdapter sqlDa;//声明SqlDataAdapter对象

        //数据库连接测试
        public String sqlOpen1(String sServer1)
        {
            String sServer = Convert.ToString(sServer1);
            String strServer = new clsIni().IniReadValue("Server", sServer);
            String strDatabase = new clsIni().IniReadValue("Database", sServer);
            String strUserID = new clsIni().IniReadValue("UserName", sServer);
            String strPassword = new clsIni().IniReadValue("Password", sServer);
            String strCon = "server=" + strServer + ";database=" + strDatabase + ";uid=" + strUserID + ";pwd=" + new clsSqlPassword().OutPassword(strPassword);
            sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();//打开连接
                sqlCon.Close();//关闭连接
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //数据库连接
        public bool sqlOpen(object sServer1)
        {
            String sServer = Convert.ToString(sServer1);
            String strServer = new clsIni().IniReadValue("Server", sServer);
            String strDatabase = new clsIni().IniReadValue("Database", sServer);
            String strUserID = new clsIni().IniReadValue("UserName", sServer);
            String strPassword = new clsIni().IniReadValue("Password", sServer);
            String strCon = "server=" + strServer + ";database=" + strDatabase + ";uid=" + strUserID + ";pwd=" + new clsSqlPassword().OutPassword(strPassword);
            sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();//打开连接
                return true;
            }
            catch (Exception ex)
            {
                DialogResult r = MessageBox.Show("数据库连接失败！是否重新配置服务器！\n" + ex.Message, "提示！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    SqlFile.frmConfig frmConfig1 = new frmConfig();
                    frmConfig1.sServer = sServer;
                    frmConfig1.ShowDialog();
                }
                return false;
            }
        }

        //数据库查询，返回查询结果
        public DataSet sql1(String sServer, String strSql)
        {
            DataSet ds = new DataSet();
            if (!sqlOpen(sServer))
                return null;
            sqlDa = new SqlDataAdapter(strSql, sqlCon);
            sqlDa.Fill(ds, "xTable");
            try
            {
                sqlCon.Close();//关闭连接
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库关闭异常！\n" + e, "提示");
            }
            return ds;
        }

        //对数据进行操作，返回数据是否受到影响
        public bool sql2(String sServer, String strSql)
        {
            bool b = false;
            if (!sqlOpen(sServer))
                return false;
            sqlCmd = new SqlCommand(strSql, sqlCon);
            if (sqlCmd.ExecuteNonQuery() > 0)
                b = true;
            try
            {
                sqlCon.Close();//关闭连接
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库关闭异常！\n" + e, "提示");
            }
            return b;
        }

        //全表查询，返回查询结果
        //输入表名，返回ds值
        public DataSet sqlSelect1(String sServer, String strTable)
        {
            DataSet ds = new DataSet();
            if (!sqlOpen(sServer))
                return null;
            sqlDa = new SqlDataAdapter("select * from " + strTable + "", sqlCon);
            sqlDa.Fill(ds, "xTable");
            try
            {
                sqlCon.Close();//关闭连接
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库异常！\n" + e, "提示");
            }
            return ds;
        }

        //指定目标查询，返回是否查询到结果
        //输入表名，列名，目标名称
        public bool sqlSelect2(String sServer, String strTable, String strList, String strName)
        {
            DataSet ds = new clsSql().sql1(sServer, "select * from " + strTable + " where " + strList + " = '" + strName + "' ");
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        //指定目标查询，返回查询结果
        //输入表名，列名，目标名称
        public DataSet sqlSelect3(String sServer, String strTable, String strList, String strName)
        {
            DataSet ds = new clsSql().sql1(sServer, "select * from " + strTable + " where " + strList + " = '" + strName + "' ");

            return ds;
        }

        //数据库删除指令，返回是否删除成功
        //输入表名，列名，目标名称
        public bool sqlDelete(String sServer, String strTable, String strList, String strName)
        {
            if (sqlSelect2(sServer, strTable, strList, strName) == true)
                return sql2(sServer, "delete from " + strTable + " where " + strList + " = '" + strName + "' ");
            else
                return false;
        }

        //数据库修改指令，返回是否修改成功
        //适用于两列数据
        //输入表名，ID列，列名，旧别名，新别名
        public bool sqlUpdate(String sServer, String strTable, String strList1, String strList2, String strName1, String strName2)
        {
            if (sqlSelect2(sServer, strTable, strList2, strName1) == true)
            {
                DataSet ds = new clsSql().sql1(sServer, "select * from " + strTable + " where " + strList2 + " = '" + strName1 + "' ");
                String strId = ds.Tables[0].Rows[0][0].ToString();
                return sql2(sServer, "update " + strTable + " set " + strList2 + " = '" + strName2 + "' where " + strList1 + " = '" + strId + "'");
            }
            else
                return false;
        }


        private SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }

        // <summary>
        // 执行存储过程
        // </summary>
        // <param name="storedProcName">存储过程名</param>
        // <param name="parameters">存储过程参数</param>
        // <param name="tableName">DataSet结果中的表名</param>
        // <returns>DataSet</returns>
        public DataSet RunProcedure(string sServer, string storedProcName, IDataParameter[] parameters, string tableName)
        {
            sqlOpen(sServer);
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = BuildQueryCommand(sqlCon, storedProcName, parameters);
            sqlDA.Fill(dataSet, tableName);
            sqlCon.Close();
            return dataSet;
        }

        // <summary>
        // 执行存储过程，返回影响的行数        
        // </summary>
        // <param name="storedProcName">存储过程名</param>
        // <param name="parameters">存储过程参数</param>
        // <param name="rowsAffected">影响的行数</param>
        // <returns></returns>

        public int RunProcedure(string storedProcName, IDataParameter[] parameters)
        {

            int result = 1;
            SqlCommand command = BuildIntCommand(sqlCon, storedProcName, parameters);
            command.ExecuteNonQuery();
            //  result = (int)command.Parameters["ReturnValue"].Value;

            sqlCon.Close();
            return result;

        }

        // <summary>
        // 创建 SqlCommand 对象实例(用来返回一个整数值)    
        // </summary>
        // <param name="storedProcName">存储过程名</param>
        // <param name="parameters">存储过程参数</param>
        // <returns>SqlCommand 对象实例</returns>
        private SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }
    }
}
