using Microsoft.SqlServer.Management.Smo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Server server;
        private void connect_Click(object sender, EventArgs e)
        {
             server = new Server(connectionText.Text);
             
            TreeNode root = new TreeNode(server.Name);
            root.ImageIndex = 0;
            foreach (Database database in server.Databases)
            {
                TreeNode node = new TreeNode(database.Name);
                node.Tag = database;
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
                root.Nodes.Add(node);
                autocompleteMenu1.AddItem(database.Name);
            }
            objectExplorer.Nodes.Add(root);  
        }

        private void objectExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null) return;
            e.Node.Nodes.Clear();
            if (e.Node.Tag is Database) getTables(e.Node);
            else getColumns(e.Node);
           
            
        }
        void getTables(TreeNode node)
        {
            Database db = (Database)node.Tag;
            ContextMenuStrip tableRightClickMenu = new ContextMenuStrip();
            ToolStripMenuItem query = new ToolStripMenuItem("New Query");
            ToolStripMenuItem generateClass = new ToolStripMenuItem("Generate Class");
            query.Click += Query_Click;
            generateClass.Click += GenerateClass_Click;
            tableRightClickMenu.Items.Add(query);
            tableRightClickMenu.Items.Add(generateClass);
            
            foreach (Table table in db.Tables)
            {
                TreeNode newTable = new TreeNode(table.Name);
                newTable.Tag = table;
                newTable.ContextMenuStrip = tableRightClickMenu;
                newTable.ImageIndex = 2;
                newTable.SelectedImageIndex = 2;
                node.Nodes.Add(newTable);
                autocompleteMenu1.AddItem(table.Name);
            }
        }
        void getColumns(TreeNode node)
        {
            Table table = (Table)node.Tag;
            foreach (Column column in table.Columns)
            {
                TreeNode newColumn = new TreeNode(column.Name);
                newColumn.Tag = column;
                if (column.InPrimaryKey)
                {
                    newColumn.ImageIndex = 3;
                    newColumn.SelectedImageIndex = 3;
                }
                else if (column.IsForeignKey)
                {
                    newColumn.ImageIndex = 4;
                    newColumn.SelectedImageIndex = 4;
                }
                else
                {
                    newColumn.ImageIndex = 5;
                    newColumn.ImageIndex = 5;
                }
                autocompleteMenu1.AddItem(column.Name);
                node.Nodes.Add(newColumn);
            }
        }
        bool multiTable;
        bool subTable;
        string araTablo;
        bool fkControl(TreeNode node)
        {
            Table tables = (Table)node.Tag;
            TreeNode dbParent = node.Parent;
            foreach (ForeignKey key in tables.ForeignKeys)
            {
                foreach (ForeignKeyColumn column in key.Columns)
                {
                    araTablo = node.Text;
                    multiTable = true;
                    createFkTable(dbParent, key.ReferencedTable);
                }
            }
            return multiTable;
        }
        void createFkTable(TreeNode dbnode, string tableName)
        {

            Database db = (Database)dbnode.Tag;
            foreach (Table tbl in db.Tables)
            {
                if (tbl.Name == tableName)
                {
                    TreeNode t = new TreeNode(tbl.Name);
                    t.Tag = tbl;
                    multiTable = true;
                    subTable = true;
                    generateClass(t, db.Name, multiTable, subTable);
                }
            }
        }
        void generateClass(TreeNode node, string dbName, bool isMultiTable, bool isSubTable)
        {
            TreeNode parent = node.Parent;
            Table table = (Table)node.Tag;
            ClassGenerator cg = new ClassGenerator(parent.Text);
            if (isMultiTable && isSubTable)
            {
                cg.GenerateClass(table,isSubTable,isMultiTable,araTablo);                
            }
            else if (!isMultiTable && isSubTable)
            {
                cg.GenerateClass(table,isSubTable,isMultiTable,araTablo);
            }
            else
            {
                cg.GenerateClass(table, isSubTable, isMultiTable,araTablo);
            }
           
            
            isSubTable = false;
            isMultiTable = false;
        }
        private void GenerateClass_Click(object sender, EventArgs e)
        {
            TreeNode nodes = objectExplorer.SelectedNode;
            Table tables = (Table)nodes.Tag;
            TreeNode db = nodes.Parent;
            if (fkControl(nodes))
            {
                generateClass(nodes, db.Text, true, false);
            }
            else
            {
                generateClass(nodes,db.Text,false,true);
            }
            


            //ClassGenerator cg = new ClassGenerator(nodes.Parent.Text);
            //cg.GenerateClass(tables);

        }

        private void Query_Click(object sender, EventArgs e)
        {
            TreeNode table = objectExplorer.SelectedNode;
            query.Text = "Select * From " + table.Text;
        }

        private void exec_Click(object sender, EventArgs e)
        {

            TreeNode table = (TreeNode)objectExplorer.SelectedNode;           
            DataSet ds =server.Databases[table.Parent.Text].ExecuteWithResults(query.Text);
           
            DataTable dt = ds.Tables[0];
            ResultWiev.DataSource = dt;            
        }

        
    }
}
