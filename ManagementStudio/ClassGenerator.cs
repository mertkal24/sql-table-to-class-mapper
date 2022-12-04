using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStudio
{
    class ClassGenerator
    {
        public ClassGenerator(string databaseName)
        {
            this.ClassTemplate = new StringBuilder();
            this.properties = new StringBuilder();
            StreamReader sr = new StreamReader(@"C:\Users\Casper\source\repos\ManagementStudio\ManagementStudio\RuntimeClassTemplate.txt");
            ClassTemplate.Append(sr.ReadToEnd());
            this.Field = "asad";
            this.DatabaseName = databaseName;
        }
        public StringBuilder ClassTemplate { get; set; }       
        public StringBuilder newClass { get; set; }
        public string Field { get; set; }
        public StringBuilder properties { get; set;}
        public StringBuilder Methods { get; set; }
        public string DatabaseName { get; set; }
        public void GenerateClass(Table table,bool isSubTable,bool araTabloControl,string aratablo)
        {
            List<Column> clmn = new List<Column>();
            foreach (Column column in table.Columns)
            {                
                clmn.Add(column);
                string propType = column.DataType.ToString();
                string propName = column.Name;                
                propType = TypeControl(propType);
                this.properties.Append(propType + " " + propName + ";\n\n");
            }
            if (isSubTable && araTabloControl)
            {
                //ilişkili ara tablo
                GenerateCRUDMethods(clmn, table.Name);
                getRelationship(aratablo);
            }  
             else if(isSubTable && !araTabloControl)
            {
                GenerateCRUDMethods(clmn,table.Name);
            }
            else if(!isSubTable && araTabloControl)
            {
                this.ClassTemplate.Replace("public void Insert(#InsertParameters#){#Insert#}", " ");
                this.ClassTemplate.Replace("public void Update(#UpdateParameters#){#Update#}", " ");
                this.ClassTemplate.Replace("public void Delete(#DeleteParameters#){#Delete#}", " ");

            }
                
            this.ClassTemplate.Replace("#ClassName#", table.Name);
            this.ClassTemplate.Replace("#Properties#", this.properties.ToString());
            StreamWriter swriter = new StreamWriter(@"C:\Users\Casper\source\repos\ManagementStudio\ManagementStudio\bin\Debug\newClass\" + table.Name + ".cs");
             swriter.Write(ClassTemplate);
             swriter.Close();
        }
        private string TypeControl(string propType)
        {
            switch (propType)
            {
                default:
                    propType = "public " + propType;
                    break;
                case "varchar":
                    propType = "public string";
                    break;
                case "decimal":
                    propType = "public decimal";
                    break;
                case "money":
                    propType = "public decimal";
                    break;
                case "char":
                    propType = "public string";
                    break;
                case "nchar":
                    propType = "public string";
                    break;
                case "nvarchar":
                    propType = "public string";
                    break;
                case "uniqueidentifier":
                    propType = "public Guid";
                    break;
                case "date":
                    propType = "public DateTime";
                    break;
                case "bit":
                    propType = "public bool";
                    break;
                case "ntext":
                    propType = "public string";
                    break;
                case "image":
                    propType = "public byte[]";
                    break;
                case "binary":
                    propType = "public byte[]";
                    break;
                case "datetime":
                    propType = "public DateTime";
                    break;
                case "datetime2":
                    propType = "public DateTime";
                    break;
                case "datetimeoffset":
                    propType = "public DateTimeOffset";
                    break;
                case "float":
                    propType = "public double";
                    break;
                case "int":
                    propType = "public int";
                    break;
                case "text":
                    propType = "public string";
                    break;
                case "timestamp":
                    propType = "public long";
                    break;
                case "tinyint":
                    propType = "public byte";
                    break;
                case "smallint":
                    propType = "public byte";
                    break;
            }
            return propType;
        }
        private void GenerateCRUDMethods(List <Column> columns,string tableName)
        {
            StringBuilder sqlColumns = new StringBuilder();
            StringBuilder parameters = new StringBuilder();
            StringBuilder sqlParameters = new StringBuilder();
            List<string> prm = new List<string>();           
            sqlColumns.Append("(");
            int isLastcolumn = 1;
            foreach (Column column in columns)
            {
                   if(!column.Identity)
                    {
                        string type = TypeControl(column.DataType.ToString());
                        type = type.Replace("public", " ");
                        string name = column.Name;
                        parameters.Append(type + " " + name + ",");
                        prm.Add(name);                       
                        if (columns.Count != isLastcolumn)
                        {
                            sqlColumns.Append(name + ",");
                            sqlParameters.Append("@" + column.Name + ", ");

                        }
                        else
                        {
                            sqlColumns.Append(name + " ");
                            sqlParameters.Append("@" + column.Name);
                        }
                    }
                isLastcolumn++;
            }
            sqlColumns.Append(")");            
            parameters.Append("Server server");            
            this.ClassTemplate.Replace("#InsertParameters#", parameters.ToString());
            StringBuilder insertCode = new StringBuilder();          
            string sqlValues = "";
            isLastcolumn = 1;            
            insertCode.Append("server.Databases[" + "\"" + this.DatabaseName + "\"" + "].ExecuteNonQuery(\"Insert Into " + tableName + " " + sqlColumns + " Values(#sqLValues#)" + "\");\n");
            foreach (string parametre in prm)
            {
                if (isLastcolumn != prm.Count)
                {
                    sqlValues += "'\"+" + parametre + "+\"',";
                }
                else
                {
                    sqlValues += "'\"+" + parametre + "+\"'";
                }
               
                isLastcolumn++;
                
            }            
            insertCode.Replace("#sqLValues#", sqlValues);
            this.ClassTemplate.Replace("#Insert#",insertCode.ToString());          
            string functionParameters = "string sorgu , Server server";
            string code = "server.Databases[\""+DatabaseName+"\"].ExecuteNonQuery(sorgu);";
            this.ClassTemplate.Replace("#UpdateParameters#", functionParameters);
            this.ClassTemplate.Replace("#Update#", code);
            this.ClassTemplate.Replace("#DeleteParameters#",functionParameters);
            this.ClassTemplate.Replace("#Delete#", code);
            
            
        }
        public void getRelationship(String araTablo)
        {
           this.properties.Append("public List<" + araTablo + "> " + araTablo.ToLower() + " ;\n");
         
        }


    }
}
