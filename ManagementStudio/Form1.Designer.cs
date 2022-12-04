namespace ManagementStudio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectionText = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.objectExplorer = new System.Windows.Forms.TreeView();
            this.objectImages = new System.Windows.Forms.ImageList(this.components);
            this.query = new System.Windows.Forms.RichTextBox();
            this.exec = new System.Windows.Forms.Button();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.ResultWiev = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultWiev)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionText
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.connectionText, null);
            this.connectionText.Location = new System.Drawing.Point(356, 27);
            this.connectionText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectionText.Name = "connectionText";
            this.connectionText.Size = new System.Drawing.Size(169, 22);
            this.connectionText.TabIndex = 1;
            this.connectionText.Text = "DESKTOP-5E1JL7B";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(573, 15);
            this.connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(132, 34);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // objectExplorer
            // 
            this.objectExplorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.objectExplorer.ImageIndex = 0;
            this.objectExplorer.ImageList = this.objectImages;
            this.objectExplorer.Location = new System.Drawing.Point(0, 0);
            this.objectExplorer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectExplorer.Name = "objectExplorer";
            this.objectExplorer.SelectedImageIndex = 0;
            this.objectExplorer.Size = new System.Drawing.Size(281, 540);
            this.objectExplorer.TabIndex = 3;
            this.objectExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.objectExplorer_AfterSelect);
            // 
            // objectImages
            // 
            this.objectImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("objectImages.ImageStream")));
            this.objectImages.TransparentColor = System.Drawing.Color.Transparent;
            this.objectImages.Images.SetKeyName(0, "dataServer.png");
            this.objectImages.Images.SetKeyName(1, "database.png");
            this.objectImages.Images.SetKeyName(2, "table.png");
            this.objectImages.Images.SetKeyName(3, "primaryKey.png");
            this.objectImages.Images.SetKeyName(4, "ForeignKey.png");
            this.objectImages.Images.SetKeyName(5, "columns.png");
            // 
            // query
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.query, this.autocompleteMenu1);
            this.query.Location = new System.Drawing.Point(311, 104);
            this.query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(671, 159);
            this.query.TabIndex = 4;
            this.query.Text = "";
            // 
            // exec
            // 
            this.exec.Location = new System.Drawing.Point(311, 62);
            this.exec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exec.Name = "exec";
            this.exec.Size = new System.Drawing.Size(75, 23);
            this.exec.TabIndex = 6;
            this.exec.Text = "Exec";
            this.exec.UseVisualStyleBackColor = true;
            this.exec.Click += new System.EventHandler(this.exec_Click);
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.AppearInterval = 1;
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "ADD",
        "EXTERNAL",
        "PROCEDURE",
        "ALL",
        "FETCH",
        "PUBLIC",
        "ALTER",
        "FILE",
        "RAISERROR",
        "AND",
        "FILLFACTOR",
        "READ",
        "ANY",
        "FOR",
        "READTEXT",
        "AS",
        "FOREIGN",
        "RECONFIGURE",
        "ASC",
        "FREETEXT",
        "REFERENCES",
        "AUTHORIZATION",
        "FREETEXTTABL",
        "REPLICATION",
        "BACKUP",
        "FROM",
        "RESTORE",
        "BEGIN",
        "FULL",
        "RESTRICT",
        "BETWEEN",
        "FUNCTION",
        "RETURN",
        "BREAK",
        "GOTO",
        "REVERT",
        "BROWSE",
        "GRANT",
        "REVOKE",
        "BULK",
        "GROUP",
        "RIGHT",
        "BY",
        "HAVING",
        "ROLLBACK",
        "CASCADE",
        "HOLDLOCK",
        "ROWCOUN",
        "CASE",
        "IDENTITY",
        "ROWGUIDCOL",
        "CHECK",
        "IDENTITY_INSERT",
        "RULE",
        "CHECKPOINT",
        "IDENTITYCOL",
        "SAV",
        "CLOSE",
        "IF",
        "SCHEMA",
        "CLUSTERED",
        "IN",
        "SECURITYAUDIT",
        "COALESCE",
        "INDEX",
        "SELECT",
        "COLLATE",
        "INNE",
        "SEMANTICKEYPHRASETABLE",
        "COLUMN",
        "INSERT",
        "SEMANTICSIMILARITYDETAILSTABLE",
        "COMMIT",
        "INTERSECT",
        "SEMANTICSIMILARITYTABLE",
        "COMPUTE",
        "INTO",
        "SESSION_USER",
        "CONSTRAINT",
        "IS",
        "SET",
        "CONTAINS",
        "JOIN",
        "SETUSER",
        "CONTAINSTABLE",
        "KEY",
        "SHUTDOWN",
        "CONTINUE",
        "KILL",
        "SOME",
        "CONVERT",
        "LEFT",
        "STATISTICS",
        "CREATE",
        "LIKE",
        "SYSTEM_USER",
        "CROSS",
        "LINENO",
        "TABLE",
        "CURRENT",
        "LOAD",
        "TABLESAMPLE",
        "CURRENT_DATE",
        "MERGE",
        "TEXTSIZE",
        "CURRENT_TIME",
        "NATIONAL",
        "THEN",
        "CURRENT_TIMESTAMP",
        "NOCHECK",
        "TO",
        "CURRENT_USER",
        "NONCLUSTERED",
        "TOP",
        "CURSOR",
        "NOT",
        "TRAN",
        "DATABASE",
        "NULL",
        "TRANSACTIOn",
        "DBCC",
        "NULLIF",
        "TRIGGER",
        "DEALLOCATE",
        "OF",
        "TRUNCATE",
        "DECLARE",
        "OFF",
        "TRY_CONVERT",
        "DEFAULT",
        "OFFSETS",
        "TSEQUAL",
        "DELETE",
        "ON",
        "UNION",
        "DENY",
        "OPEN",
        "UNIQUE",
        "DESC",
        "OPENDATASOURCE",
        "UNPIVOT",
        "DISK",
        "OPENQUERY",
        "UPDATE",
        "DISTINCT",
        "OPENROWSET",
        "UPDATETEXT",
        "DISTRIBUTED",
        "OPENXML",
        "USE",
        "DOUBLE",
        "OPTION",
        "USER",
        "DROP",
        "OR",
        "VALUES",
        "DUMP",
        "ORDER",
        "VARYING",
        "ELSE",
        "OUTER",
        "VIEW",
        "END",
        "OVER",
        "WAITFOR",
        "ERRLVL",
        "PERCENT",
        "WHEN",
        "ESCAPE",
        "PIVOT",
        "WHERE",
        "EXCEPT",
        "PLAN",
        "WHILE",
        "EXEC",
        "PRECISION",
        "WITH",
        "EXECUTE",
        "PRIMARY",
        "WITHIN GROUP",
        "EXISTS",
        "PRINT",
        "WRITETEXT",
        "EXIT",
        "PROC"};
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // ResultWiev
            // 
            this.ResultWiev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultWiev.Location = new System.Drawing.Point(311, 282);
            this.ResultWiev.Name = "ResultWiev";
            this.ResultWiev.RowHeadersWidth = 51;
            this.ResultWiev.RowTemplate.Height = 24;
            this.ResultWiev.Size = new System.Drawing.Size(671, 217);
            this.ResultWiev.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 540);
            this.Controls.Add(this.ResultWiev);
            this.Controls.Add(this.exec);
            this.Controls.Add(this.query);
            this.Controls.Add(this.objectExplorer);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.connectionText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultWiev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox connectionText;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TreeView objectExplorer;
        private System.Windows.Forms.ImageList objectImages;
        private System.Windows.Forms.RichTextBox query;
        private System.Windows.Forms.Button exec;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.DataGridView ResultWiev;
    }
}

