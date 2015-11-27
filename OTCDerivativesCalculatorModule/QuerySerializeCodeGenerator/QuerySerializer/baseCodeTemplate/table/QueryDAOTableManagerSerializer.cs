using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace QuerySerializeCodeGenerator
{
    public class QueryDAOTableManagerSerializer
    {
        private string path = @"D:\Project File\OTCDerivativesCalculatorModule\QuerySerializeCodeGenerator\QuerySerializer\baseCodeTemplate\codeTemplate\";

        private QueryBuilder qm_;

        private string tableManagerClassName_;
        private string tableName_;
        private string daoClassName_;

        public QueryDAOTableManagerSerializer(QueryBuilder qm)
        {
            this.qm_ = qm;
            
            this.tableManagerClassName_ = qm.TableName_+ "_Table_DAOManager";
            this.daoClassName_ = qm.TableName_ + "_Table_DAO";
            this.tableName_ = qm.TableName_;
        }

        public string build()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.usingCode());

            sb.AppendLine("namespace QuerySerializeCodeGenerator");
            sb.AppendLine("{");
            sb.AppendLine("public class " + this.tableManagerClassName_);
            sb.AppendLine("{");

            sb.Append(this.constructor());
            sb.Append(this.property());
            sb.Append(this.staticQueryProperty());
            sb.Append(this.selectCode());

            //sb.Append(this.insertCode());
            //sb.Append(this.updateCode());
            sb.Append(this.deleteCode());

            sb.AppendLine("}");
            sb.AppendLine("}");

            return sb.ToString();
        }



        private string usingCode()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Data;");
            sb.AppendLine("using System.Data.Common;");
            sb.AppendLine();

            return sb.ToString();
        }

        private string staticQueryProperty()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("#region Query");
            sb.AppendLine();

            #region SelectQueryStr

            StringBuilder selectQuery_SB = new StringBuilder();

            selectQuery_SB.AppendLine("private static string SelectQuery_");
            selectQuery_SB.Append("= \"SELECT ");

            for (int i = 0; i < qm_.ColumnList_.Count - 1; i++)
            {
                string upperItem = qm_.ColumnList_[i].ToUpper();
                selectQuery_SB.Append(upperItem + ", ");
            }

            selectQuery_SB.AppendLine(qm_.ColumnList_[qm_.ColumnList_.Count - 1].ToUpper() + " \" + ");

            selectQuery_SB.AppendLine(" \"FROM " + this.tableName_ + " WHERE KeyColumn = '@KeyColumnValue@'" + "\";");

            selectQuery_SB.AppendLine();

            #endregion

            #region Not Use

            //#region InsertQueryStr

            //StringBuilder insertQuery_SB = new StringBuilder();

            //insertQuery_SB.AppendLine("private static string InsertQuery_");
            //insertQuery_SB.Append("= \"INSERT INTO " + this.tableName_ + " (");

            //string upperItem_insertColumn = "";

            //for (int i = 0; i < qm_.ColumnList_.Count - 1; i++)
            //{
            //    upperItem_insertColumn = qm_.ColumnList_[i].ToUpper();
            //    insertQuery_SB.Append(upperItem_insertColumn + "_, ");
            //}

            //upperItem_insertColumn = qm_.ColumnList_[qm_.ColumnList_.Count - 1].ToUpper();

            //insertQuery_SB.AppendLine(upperItem_insertColumn + "_ )\" +");

            //insertQuery_SB.Append("\"VALUES (");

            //string upperItem_insertValue = "";

            //for (int i = 0; i < qm_.ColumnList_.Count - 1; i++)
            //{
            //    upperItem_insertValue = qm_.ColumnList_[i].ToUpper();
            //    insertQuery_SB.Append("'@" + upperItem_insertValue + "VALUE@', ");
            //}

            //upperItem_insertValue = qm_.ColumnList_[qm_.ColumnList_.Count - 1].ToUpper();

            //insertQuery_SB.AppendLine("'@" + upperItem_insertValue + "VALUE@' )\";");

            //insertQuery_SB.AppendLine();

            //#endregion

            //#region updateQueryStr

            //StringBuilder updateQuery_SB = new StringBuilder();

            //updateQuery_SB.AppendLine("private static string UpdateQuery_");
            //updateQuery_SB.Append("= \"UPDATE " + this.tableName_ + " SET ");

            //string upperItem_updateColumn = "";

            //for (int i = 0; i < qm_.ColumnList_.Count - 1; i++)
            //{
            //    upperItem_updateColumn = qm_.ColumnList_[i].ToUpper();
            //    updateQuery_SB.Append(upperItem_updateColumn + "=" + "'@" + upperItem_updateColumn + "VALUE@'");
            //}

            //upperItem_updateColumn = qm_.ColumnList_[qm_.ColumnList_.Count - 1].ToUpper();

            //updateQuery_SB.Append(upperItem_updateColumn + "=" + "'@" + upperItem_updateColumn + "VALUE@'");

            //updateQuery_SB.AppendLine("WHERE KeyColumn = '@KeyColumnValue@'\";");

            //updateQuery_SB.AppendLine();

            //#endregion

            #endregion

            #region deleteQueryStr

            StringBuilder deleteQuery_SB = new StringBuilder();

            deleteQuery_SB.AppendLine("private static string DeleteQuery_");
            deleteQuery_SB.Append("= \"DELETE FROM " + this.tableName_);

            deleteQuery_SB.Append(" WHERE KeyColumn = '@KeyColumnValue@'\";");

            deleteQuery_SB.AppendLine();

            #endregion

            sb.Append(selectQuery_SB.ToString() +
                      //insertQuery_SB.ToString() +
                      //updateQuery_SB.ToString() +
                      deleteQuery_SB.ToString());
            
            sb.AppendLine();

            sb.AppendLine("#endregion");

            sb.AppendLine();

            return sb.ToString();
        }

        private string selectCode()
        {
            StringBuilder sb = new StringBuilder();

            #region selectMethod

            string manager_selectMethodCode = System.IO.File.ReadAllText(path + "manager_selectMethodCode.txt");

            manager_selectMethodCode = manager_selectMethodCode.Replace("@MANAGERDAOCLASSNAME@", this.tableManagerClassName_);
            manager_selectMethodCode = manager_selectMethodCode.Replace("@DAOCLASSNAME@", this.daoClassName_);
            
            //이건 View에서만 사용함. table은 그냥 하나의 key만 사용해서 add한거는 addCondtion으로 사용.
            manager_selectMethodCode = manager_selectMethodCode.Replace("@FORLOOPKEYCODE@", "");

            StringBuilder selectForLoop_SB = new StringBuilder();

            selectForLoop_SB.AppendLine("foreach (DataRow item in dr)");
            selectForLoop_SB.AppendLine("{");

            int i = 0;

            selectForLoop_SB.AppendLine(this.daoClassName_ + " dao = new " + this.daoClassName_ + "();");
            selectForLoop_SB.AppendLine();

            foreach (var item in this.qm_.ColumnList_)
            {
                selectForLoop_SB.AppendLine("dao." + this.FirstUpperStr(item) + "_" + " = item[" + i + "].ToString();");
                i = i + 1;
            }
            
            selectForLoop_SB.AppendLine();
            selectForLoop_SB.AppendLine("this.DAOList_.Add(dao);");
            selectForLoop_SB.AppendLine("}");

            manager_selectMethodCode = manager_selectMethodCode.Replace("@FORLOOPCODE@", selectForLoop_SB.ToString());

            #endregion

            sb.AppendLine(manager_selectMethodCode);
            sb.AppendLine();

            return sb.ToString();

            
        }

        //private string insertCode()
        //{
        //    string DAO_ViewName = this.qm_.ViewName_;

        //    string sampleDAOClassName = this.qm_.ViewName_ + "List_";
        //    string sampleDaoListName = this.qm_.ViewName_ + "List_";

        //    StreamReader sr = new StreamReader("insertCode.txt");

        //    string result = sr.ToString();

        //    result.Replace("@sampleDAOClassName@", sampleDAOClassName);
        //    result.Replace("@sampleDaoListName@", sampleDaoListName);

        //    return result;
        //}

        //private string updateCode()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    string DAO_ViewName = this.qm_.ViewName_;
        //    sb.AppendLine("public void update(dbConnection conn, " + DAO_ViewName + " dao)");
        //    sb.AppendLine("{");

        //    DbConnection conn = new DbConnection();

        //    if (conn.State != ConnectionState.Open)
        //        conn.Open();

        //    string updateQuery = qm_.updateQuery();

        //    DbCommand dbCommand = conn.CreateCommand();

        //    dbCommand.CommandText = updateQuery;

        //    dbCommand.ExecuteNonQuery();

        //    sb.AppendLine("}");

        //    return sb.ToString();
        //}

        private string deleteCode()
        {
            StringBuilder sb = new StringBuilder();

            #region deleteMethod

            string deleteMethodCode = System.IO.File.ReadAllText(path + "manager_deleteMethodCode.txt");

            deleteMethodCode = deleteMethodCode.Replace("@DAOCLASSNAME@", this.tableManagerClassName_);

            #endregion

            sb.AppendLine(deleteMethodCode);
            sb.AppendLine();

            return sb.ToString();
        }


        private string constructor()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        private string property()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public string KeyColumn_ { get; set; }");
            sb.AppendLine();

            sb.AppendLine("public List<" + this.daoClassName_ + "> DAOList_ { get; set; }");
            sb.AppendLine();

            sb.AppendLine("#region Properties");
            sb.AppendLine();

            foreach (string item in qm_.ColumnList_)
            {
                StringBuilder UpperStr = new StringBuilder(item);
                UpperStr[0] = item.ToUpper()[0];

                sb.AppendLine("public string " + UpperStr + "_;");
            }
            
            sb.AppendLine();    

            sb.AppendLine("#endregion");

            sb.AppendLine();    


            return sb.ToString();
        }

        private string FirstUpperStr(string s)
        {
            StringBuilder UpperStr = new StringBuilder(s);
            UpperStr[0] = s.ToUpper()[0];

            return UpperStr.ToString();
        }
    }
}
