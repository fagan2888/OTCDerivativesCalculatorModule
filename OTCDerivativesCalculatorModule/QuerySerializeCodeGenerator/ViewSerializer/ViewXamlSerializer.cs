using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuerySerializeCodeGenerator
{
    public class ViewXamlSerializer
    {
        private QueryBuilder qm_;

        public ViewXamlSerializer(QueryBuilder qm)
        {
            // TODO: Complete member initialization
            this.qm_ = qm;
        }

        public string build()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.propertyXaml());
            sb.Append(this.dataGridXaml());
            sb.Append(this.listViewXaml());

            return sb.ToString();

        }

        private string propertyXaml()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<StackPanel  Orientation=\"Vertical\">");

            foreach (var item in this.qm_.ColumnList_)
            {
                string lowerItem = item.ToLower();
                string upperItem = item.ToUpper();
                string fus = this.FirstUpperStr(lowerItem);
                string s = (item.Substring ( item.Length - 4 , 4)).ToUpper();

                if (s == "DATE")
                {
                    sb.AppendLine("    <StackPanel Name=\"bindingPanel_\" Orientation=\"Horizontal\">");
                    sb.AppendLine("        <Label Content=\"" + fus + " : \" />");
                    sb.AppendLine("        <DatePicker Name=\"" + lowerItem + "Picker_\" SelectedDate=\"{Binding Path=" + fus + "_, Mode=TwoWay}\" />");
                    sb.AppendLine("    </StackPanel>");
                }
                else
                {
                    sb.AppendLine("    <StackPanel Orientation=\"Horizontal\">");
                    sb.AppendLine("        <Label Content=\"" + fus + " : \" />");
                    sb.AppendLine("        <TextBox Text=\"{Binding Path=" + fus + "_}\" Width=\"100\" />");
                    sb.AppendLine("    </StackPanel>");
                }

            }
            
            sb.AppendLine("</StackPanel>");

            sb.AppendLine();

            return sb.ToString();
        }

        private string dataGridXaml()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<DataGrid Name=\"" + qm_.TableName_ + "DataGrid_\" LoadingRow=\"DataGrid_LoadingRow_\" ");
            sb.AppendLine("          AutoGenerateColumns=\"False\"");
            sb.AppendLine("          ScrollViewer.CanContentScroll=\"True\" ");
            sb.AppendLine("          ScrollViewer.VerticalScrollBarVisibility=\"Auto\"");
            sb.AppendLine("          ScrollViewer.HorizontalScrollBarVisibility=\"Auto\">");
            sb.AppendLine("    <DataGrid.Columns>");

            foreach (var item in this.qm_.ColumnList_)
            {
                string lowerItem = item.ToLower();
                string upperItem = item.ToUpper();
                string fus = this.FirstUpperStr(lowerItem);
                string s = (item.Substring(item.Length - 4, 4)).ToUpper();

                if (s == "DATE")
                {
                    sb.AppendLine("        <DataGridTextColumn Header=\"" + fus + "\" Binding=\"{Binding Path=" + fus + "_,StringFormat=yyyy-MM-dd}\"/>");
                }
                else
                {
                    sb.AppendLine("        <DataGridTextColumn Header=\"" + fus + "\" Binding=\"{Binding Path=" + fus + "_}\"/>");
                }
                
                //sb.AppendLine("        <DataGridTemplateColumn Header=\"Type\">");
                //sb.AppendLine("            <DataGridTemplateColumn.CellTemplate>");
                //sb.AppendLine("                <DataTemplate>");
                //sb.AppendLine("                    <Button Content=\"{Binding Path=Type_}\" Click=\"typeEditBtn_Click\"/>");
                //sb.AppendLine("                </DataTemplate>");
                //sb.AppendLine("            </DataGridTemplateColumn.CellTemplate>");
                //sb.AppendLine("        </DataGridTemplateColumn>");

                
            }

            sb.AppendLine("    </DataGrid.Columns>");
            sb.AppendLine("</DataGrid>");

            sb.AppendLine();

            return sb.ToString();
        }

        private string listViewXaml()
        {
            StringBuilder sb = new StringBuilder();



            sb.AppendLine("<ListView Name=\"" + qm_.TableName_ + "ListListView_\" ");
            sb.AppendLine("          HorizontalAlignment=\"Stretch\"");
            sb.AppendLine("          VerticalAlignment=\"Stretch\">");

            sb.AppendLine("    <ListView.ItemTemplate >");
            sb.AppendLine("        <DataTemplate >");
            sb.AppendLine("            <StackPanel Orientation=\"Vertical\">");
            sb.AppendLine("                <StackPanel Orientation=\"Horizontal\">");


            foreach (var item in this.qm_.ColumnList_)
            {
                string lowerItem = item.ToLower();
                string upperItem = item.ToUpper();
                string fus = this.FirstUpperStr(lowerItem);
                string s = (item.Substring(item.Length - 4, 4)).ToUpper();

                if (s == "DATE")
                {
                    sb.AppendLine("                    <TextBlock Text=\"{Binding " + fus + "_,  StringFormat=yyyy-MM-dd}\" Margin=\"0,0,10,0\" />");
                }
                else
                {
                    sb.AppendLine("                    <TextBlock Text=\"{Binding " + fus + "_}\" Margin=\"0,0,10,0\" />");
                }
            }

            sb.AppendLine("                </StackPanel>");
            sb.AppendLine("            </StackPanel>");
            sb.AppendLine("        </DataTemplate>");
            sb.AppendLine("    </ListView.ItemTemplate>");

            sb.AppendLine("    <ListView.ContextMenu>");
            sb.AppendLine("        <ContextMenu>");
            sb.AppendLine("            <MenuItem Header=\"Trade\">");
            sb.AppendLine("                <MenuItem Header=\"test\"/>");
            sb.AppendLine("            </MenuItem>");
            sb.AppendLine("        </ContextMenu>");
            sb.AppendLine("    </ListView.ContextMenu>");
            sb.AppendLine("</ListView>");

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
