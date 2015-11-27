using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace QuerySerializeCodeGenerator
{
    public class QueryDAOViewSerializer
    {
        string path = @"D:\Project File\OTCDerivativesCalculatorModule\QuerySerializeCodeGenerator\QuerySerializer\baseCodeTemplate\DAO\";

        private string className_ = "TEST_Class_Name";
        private string viewName_ = "TEST_View_Name";

        public QueryDAOViewSerializer(QueryBuilder qm)
        {
            this.qm_ = qm;
            this.className_ = qm.ViewName_ + "_View_DAO";
            this.viewName_ = qm.ViewName_;
        }

        private QueryBuilder qm_;

        public string build()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.usingCode());

            sb.AppendLine("namespace QuerySerializeCodeGenerator");
            sb.AppendLine("{");
            sb.AppendLine("public class " + className_);
            sb.AppendLine("{");

            sb.Append(this.constructor());
            sb.Append(this.property());
            //sb.Append(this.staticQueryProperty());
            sb.Append(this.loadFromDataRow_Method());
            //sb.Append(this.selectMethod());
            //sb.Append(this.insertMethod());
            //sb.Append(this.updateMethod());
            //sb.Append(this.deleteMethod());

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

        private string constructor()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public "+ this.className_ +"() { }");
            sb.AppendLine();

            return sb.ToString();
        }

        private string property()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("#region Properties");

            sb.AppendLine("public string KeyColumn_ { get; set; }");
            sb.AppendLine();

            foreach (var item in this.qm_.ColumnList_)
            {
                sb.AppendLine("public string " + this.FirstUpperStr(item) + "_" + " { get; set; }");
            }

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

        private string loadFromDataRow_Method()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public void loadFromDataRow(System.Data.DataRow dataRow)");
            sb.AppendLine("{");

            foreach (string item in qm_.ColumnList_)
            {
                StringBuilder UpperStr = new StringBuilder(item);
                UpperStr[0] = item.ToUpper()[0];
                UpperStr.Append("_");

                sb.AppendLine("this." + UpperStr + " = dataRow[\"" + item.ToUpper() + "\"].ToString();");
            }

            sb.AppendLine("}");
            sb.AppendLine();

            return sb.ToString();
        }
        
        #region Not Use in View Query

        private string staticQueryProperty()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("#region built-in-Query");
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

            selectQuery_SB.AppendLine(" \"FROM " + this.viewName_ + " WHERE KeyColumn = '@KeyColumnValue@'" + "\";");

            selectQuery_SB.AppendLine();

            #endregion

            #region Not Use

            //#region InsertQueryStr

            //StringBuilder insertQuery_SB = new StringBuilder();

            //insertQuery_SB.AppendLine("private static string InsertQuery_");
            //insertQuery_SB.Append("= \"INSERT INTO " + this.viewName_ + " (");

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
            //updateQuery_SB.Append("= \"UPDATE " + this.viewName_ + " SET ");

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

            //#region deleteQueryStr

            //StringBuilder deleteQuery_SB = new StringBuilder();

            //deleteQuery_SB.AppendLine("private static string DeleteQuery_");
            //deleteQuery_SB.Append("= \"DELETE FROM " + this.viewName_);

            //deleteQuery_SB.Append(" WHERE KeyColumn = '@KeyColumnValue@'\";");

            //deleteQuery_SB.AppendLine();

            //#endregion

            #endregion

            sb.Append(selectQuery_SB.ToString());
            //insertQuery_SB.ToString() +
            //updateQuery_SB.ToString() +
            //deleteQuery_SB.ToString());

            sb.AppendLine("#endregion");
            sb.AppendLine();

            return sb.ToString();
        }

        private string selectMethod()
        {
            StringBuilder sb = new StringBuilder();

            #region selectMethod

            string selectMethodCode = System.IO.File.ReadAllText(path + "selectMethodCode.txt");

            selectMethodCode = selectMethodCode.Replace("@DAOCLASSNAME@", this.className_);

            StringBuilder selectForLoop_SB = new StringBuilder();

            selectForLoop_SB.AppendLine("foreach (DataRow item in dr)");
            selectForLoop_SB.AppendLine("{");

            int i = 0;

            foreach (var item in this.qm_.ColumnList_)
            {
                selectForLoop_SB.AppendLine("this." + this.FirstUpperStr(item) + "_" + " = item[" + i + "].ToString();");
                i = i + 1;
            }

            selectForLoop_SB.AppendLine("}");

            selectMethodCode = selectMethodCode.Replace("@FORLOOPCODE@", selectForLoop_SB.ToString());

            #endregion

            sb.AppendLine(selectMethodCode);
            sb.AppendLine();

            return sb.ToString();
        }

        private string insertMethod()
        {
            StringBuilder sb = new StringBuilder();

            #region insertMethod

            string insertMethodCode = System.IO.File.ReadAllText(path + "insertMethodCode.txt");

            insertMethodCode = insertMethodCode.Replace("@DAOCLASSNAME@", this.className_);
                                      
            StringBuilder insertReplace_SB = new StringBuilder();

            foreach (var item in this.qm_.ColumnList_)
            {
                insertReplace_SB.AppendLine("insertQuery = insertQuery.Replace(\"@" + item.ToUpper() + "VALUE" + "@\", " + this.FirstUpperStr(item) + "_" + ");");
            }

            insertMethodCode = insertMethodCode.Replace("@INSERTREPLACECODE@", insertReplace_SB.ToString());

            #endregion

            sb.AppendLine(insertMethodCode);
            sb.AppendLine();

            return sb.ToString();
        }

        private string updateMethod()
        {
            StringBuilder sb = new StringBuilder();

            #region updateMethod

            string updateMethodCode = System.IO.File.ReadAllText(path + "updateMethodCode.txt");

            updateMethodCode = updateMethodCode.Replace("@DAOCLASSNAME@", this.className_);

            StringBuilder updateReplace_SB = new StringBuilder();

            foreach (var item in this.qm_.ColumnList_)
            {
                updateReplace_SB.AppendLine("updateQuery = updateQuery.Replace(\"@" + item.ToUpper() + "VALUE" + "@\", " + this.FirstUpperStr(item) + "_" + ");");
            }

            updateMethodCode = updateMethodCode.Replace("@UPDATEREPLACECODE@", updateReplace_SB.ToString());

            #endregion

            sb.AppendLine(updateMethodCode);
            sb.AppendLine();

            return sb.ToString();
        }

        private string deleteMethod()
        {
            StringBuilder sb = new StringBuilder();

            #region deleteMethod

            string deleteMethodCode = System.IO.File.ReadAllText(path + "deleteMethodCode.txt");

            deleteMethodCode = deleteMethodCode.Replace("@DAOCLASSNAME@", this.className_);

            #endregion

            sb.AppendLine(deleteMethodCode);
            sb.AppendLine();

            return sb.ToString();
        }

        #endregion



    }
}
