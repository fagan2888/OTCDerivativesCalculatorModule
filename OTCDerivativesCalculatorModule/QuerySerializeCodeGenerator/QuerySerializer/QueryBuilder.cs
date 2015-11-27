using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuerySerializeCodeGenerator
{
    // query 만들 때 alias 사용 권장
    public class QueryBuilder
    {
        public QueryBuilder()
        {
            this.conditionFlag_ = false;
            this.needAnd_ = false;

            this.setQueryInfo();
        }

        public QueryBuilder(string query)
        {
            this.conditionFlag_ = false;
            this.needAnd_ = false;

            this.initialQuery_ = query;
            this.query_ = query;

            this.setQueryInfo();
        }

        private int keyMaxNum_ = 5;

        public string ViewName_;
        public string TableName_;

        public List<string> ColumnList_;
        public List<string> KeyList_;
        public List<string> TableList_;
        public List<string> ConditionList_;
        

        private string initialQuery_;
        private string query_;

        private void setQueryInfo()
        {
            string toUpperQuery = this.query_.ToUpper();
            string eleminateEnter = toUpperQuery.Replace(Environment.NewLine, " ");
            string eleminateTabEnter = eleminateEnter.Replace("\t", " ");

            int selectIndex = eleminateTabEnter.IndexOf("SELECT ");
            int fromIndex = eleminateTabEnter.IndexOf(" FROM ");
            
            
            //#region Table

            //string remainSubStr = eleminateTabEnter.Substring(fromIndex + 6, eleminateTabEnter.Length - (fromIndex + 6));
            //int endTableNameLength = remainSubStr.IndexOf(" ");
            //remainSubStr = remainSubStr.Trim();
            
            //string[] tableList = remainSubStr.Split(' ');

            //this.TableName_ = tableList[0].Replace(";", "");

            //#endregion

            #region Column

            this.ColumnList_ = new List<string>();

            string subColumnList = eleminateTabEnter.Substring(selectIndex + 6, fromIndex - 6);

            string[] columnList = subColumnList.Split(',');

            bool parenthesisOpened = false;
            int parenthesisOpenNum = 0;
            int parenthesisCloseNum = 0;
            string columnResult = "";

            foreach (string s in columnList)
            {
                if (parenthesisOpened)
                {
                    columnResult = columnResult + "," + s;
                }
                else
                {
                    columnResult = columnResult + s;
                }

                columnResult = columnResult.Trim();
                int k = columnResult.IndexOf(" AS ");

                parenthesisOpenNum = parenthesisOpenNum + this.containStrNum(s, "(");
                parenthesisCloseNum = parenthesisCloseNum + this.containStrNum(s, ")");

                if (parenthesisOpenNum == parenthesisCloseNum)
                {

                    if (k == -1)
                    {
                        int pointIndex = columnResult.IndexOf(".");
                        string columnName = columnResult.Substring(pointIndex + 1, columnResult.Length - (pointIndex + 1));

                        this.ColumnList_.Add(columnName);
                        parenthesisOpened = false;
                        columnResult = "";
                    }
                    else
                    {
                        string columnName = columnResult.Substring(k + 4, columnResult.Length - ( k + 4));

                        this.ColumnList_.Add(columnName);
                        parenthesisOpened = false;
                        columnResult = "";
                    }
                }
            }

            #endregion

            #region FindKeyCondi

            this.KeyList_ = new List<string>();

            for (int i = 0; i < this.keyMaxNum_; i++)
            {
                string keyString = "@KEYCOLUMN" + (i + 1).ToString() + "@";

                if (eleminateTabEnter.Contains(keyString))
                {
                    this.KeyList_.Add(keyString.Replace("@",""));    
                }
            }

            #endregion
        }

        private int containStrNum(string s, string findStr)
        { 
            int count = 0;
            
            string str = s;
            int checkIndex = 0;
            int stringLength = s.Length;

            while (checkIndex != -1)
	        {
                checkIndex = str.IndexOf(findStr);
                if (checkIndex != -1)
                {
                    str = str.Substring(checkIndex +1 , stringLength - (checkIndex +1));
                    stringLength = stringLength - (checkIndex + 1);
                    count = count + 1; 
                }
	        }

            return count;

        }

        public void build(string q)
        {
            String query = q;
            //String columnStr = 
        }

        public string query()
        {
            return this.query_;
        }

        private bool conditionFlag_;
        private bool needAnd_;

        public void addCondition(string condColName, string condValue)
        {
            if (this.existColumn(condColName))
                throw new Exception("invalid columnName");

            StringBuilder sb = new StringBuilder();

            if ( !this.conditionFlag_ )
            {
                sb.AppendLine("SELECT ");

                foreach (var item in this.ColumnList_)
                {
                    sb.AppendLine(item.ToUpper() + " as " + item.ToUpper());
                }

                sb.AppendLine(" FROM ( ");
                sb.AppendLine(this.query_);
                sb.AppendLine(" ) WHERE ");

                this.conditionFlag_ = true;
            }

            if (this.needAnd_)
            {
                this.query_ = this.query_ + "AND ";
            }

            this.query_ = this.query_ + condColName + " ='" + condValue + "'";
            this.needAnd_ = true;
        }

        public void clearCondition()
        {
            this.conditionFlag_ = false;
            this.needAnd_ = false;
            this.query_ = this.initialQuery_;
        }

        public bool existColumn(string colName)
        {
            return this.ColumnList_.Contains(colName);
        }
        
        //public void addSelectColumn(string selecteColName)
        //{
        //    if (this.existColumn(selecteColName))
        //        throw new Exception("invalid columnName");

        //    if (compositeTableFlag_)
        //    { 
            
        //    }


        //}

        //public void addSelectColumn(string selectColName, string aliase)
        //{
        //    if (this.existColumn(selectColName))
        //        throw new Exception("invalid columnName");

        //}

        public string getQuery()
        {
            return query_;
        }
    }
}
