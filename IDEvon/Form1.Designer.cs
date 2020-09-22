namespace IDEvon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lexicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sintacticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semanticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoIntermedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lexícoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sintacticoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.semanticoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.Lexico = new System.Windows.Forms.TabPage();
            this.richTextBoxLexico = new System.Windows.Forms.RichTextBox();
            this.sintactico = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.semantico = new System.Windows.Forms.TabPage();
            this.hashtable = new System.Windows.Forms.TabPage();
            this.codigoInter = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxErrorLexico = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ErroresSin = new System.Windows.Forms.RichTextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabcontrol1.SuspendLayout();
            this.Lexico.SuspendLayout();
            this.sintactico.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.compilarToolStripMenuItem,
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.aToolStripMenuItem2,
            this.aToolStripMenuItem3,
            this.lexícoToolStripMenuItem,
            this.sintacticoToolStripMenuItem1,
            this.semanticoToolStripMenuItem1,
            this.compilarToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.guardarComoToolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem1
            // 
            this.guardarComoToolStripMenuItem1.Name = "guardarComoToolStripMenuItem1";
            this.guardarComoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem1.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem1.Click += new System.EventHandler(this.guardarComoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Cerrar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // compilarToolStripMenuItem
            // 
            this.compilarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lexicoToolStripMenuItem,
            this.sintacticoToolStripMenuItem,
            this.semanticoToolStripMenuItem,
            this.codigoIntermedioToolStripMenuItem});
            this.compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            this.compilarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.compilarToolStripMenuItem.Text = "Compilar";
            // 
            // lexicoToolStripMenuItem
            // 
            this.lexicoToolStripMenuItem.Name = "lexicoToolStripMenuItem";
            this.lexicoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.lexicoToolStripMenuItem.Text = "Léxico";
            this.lexicoToolStripMenuItem.Click += new System.EventHandler(this.lexicoToolStripMenuItem_Click);
            // 
            // sintacticoToolStripMenuItem
            // 
            this.sintacticoToolStripMenuItem.Name = "sintacticoToolStripMenuItem";
            this.sintacticoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.sintacticoToolStripMenuItem.Text = "Sintáctico";
            this.sintacticoToolStripMenuItem.Click += new System.EventHandler(this.sintacticoToolStripMenuItem_Click);
            // 
            // semanticoToolStripMenuItem
            // 
            this.semanticoToolStripMenuItem.Name = "semanticoToolStripMenuItem";
            this.semanticoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.semanticoToolStripMenuItem.Text = "Semántico";
            // 
            // codigoIntermedioToolStripMenuItem
            // 
            this.codigoIntermedioToolStripMenuItem.Name = "codigoIntermedioToolStripMenuItem";
            this.codigoIntermedioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.codigoIntermedioToolStripMenuItem.Text = "Código Intermedio";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem.Image")));
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.aToolStripMenuItem.ToolTipText = "Guardar";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem1.Image")));
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.aToolStripMenuItem1.ToolTipText = "Nuevo";
            this.aToolStripMenuItem1.Click += new System.EventHandler(this.aToolStripMenuItem1_Click);
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem2.Image")));
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(28, 20);
            this.aToolStripMenuItem2.ToolTipText = "Guardar como";
            this.aToolStripMenuItem2.Click += new System.EventHandler(this.aToolStripMenuItem2_Click);
            // 
            // aToolStripMenuItem3
            // 
            this.aToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("aToolStripMenuItem3.Image")));
            this.aToolStripMenuItem3.Name = "aToolStripMenuItem3";
            this.aToolStripMenuItem3.Size = new System.Drawing.Size(28, 20);
            this.aToolStripMenuItem3.ToolTipText = "Abrir";
            this.aToolStripMenuItem3.Click += new System.EventHandler(this.aToolStripMenuItem3_Click);
            // 
            // lexícoToolStripMenuItem
            // 
            this.lexícoToolStripMenuItem.Name = "lexícoToolStripMenuItem";
            this.lexícoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.lexícoToolStripMenuItem.Text = "Lexíco";
            this.lexícoToolStripMenuItem.Click += new System.EventHandler(this.lexícoToolStripMenuItem_Click);
            // 
            // sintacticoToolStripMenuItem1
            // 
            this.sintacticoToolStripMenuItem1.Name = "sintacticoToolStripMenuItem1";
            this.sintacticoToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.sintacticoToolStripMenuItem1.Text = "Sintáctico";
            this.sintacticoToolStripMenuItem1.Click += new System.EventHandler(this.sintacticoToolStripMenuItem1_Click);
            // 
            // semanticoToolStripMenuItem1
            // 
            this.semanticoToolStripMenuItem1.Name = "semanticoToolStripMenuItem1";
            this.semanticoToolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.semanticoToolStripMenuItem1.Text = "Semántico";
            // 
            // compilarToolStripMenuItem1
            // 
            this.compilarToolStripMenuItem1.Name = "compilarToolStripMenuItem1";
            this.compilarToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.compilarToolStripMenuItem1.Text = "Compilar";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.01182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.98818F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 423);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.scintilla1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabcontrol1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 268);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // scintilla1
            // 
            this.scintilla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintilla1.AutoCMaxHeight = 9;
            this.scintilla1.Location = new System.Drawing.Point(3, 3);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(391, 262);
            this.scintilla1.TabIndex = 1;
            this.scintilla1.TextChanged += new System.EventHandler(this.scintilla1_TextChanged);
            this.scintilla1.Click += new System.EventHandler(this.scintilla1_Click);
            this.scintilla1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scintilla1_KeyDown);
            this.scintilla1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.scintilla1_KeyUp);
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcontrol1.Controls.Add(this.Lexico);
            this.tabcontrol1.Controls.Add(this.sintactico);
            this.tabcontrol1.Controls.Add(this.semantico);
            this.tabcontrol1.Controls.Add(this.hashtable);
            this.tabcontrol1.Controls.Add(this.codigoInter);
            this.tabcontrol1.Location = new System.Drawing.Point(400, 3);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(391, 262);
            this.tabcontrol1.TabIndex = 13;
            // 
            // Lexico
            // 
            this.Lexico.Controls.Add(this.richTextBoxLexico);
            this.Lexico.Location = new System.Drawing.Point(4, 22);
            this.Lexico.Name = "Lexico";
            this.Lexico.Padding = new System.Windows.Forms.Padding(3);
            this.Lexico.Size = new System.Drawing.Size(383, 236);
            this.Lexico.TabIndex = 0;
            this.Lexico.Text = "Lexíco";
            this.Lexico.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLexico
            // 
            this.richTextBoxLexico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLexico.Location = new System.Drawing.Point(-4, 0);
            this.richTextBoxLexico.Name = "richTextBoxLexico";
            this.richTextBoxLexico.ReadOnly = true;
            this.richTextBoxLexico.ShowSelectionMargin = true;
            this.richTextBoxLexico.Size = new System.Drawing.Size(387, 236);
            this.richTextBoxLexico.TabIndex = 0;
            this.richTextBoxLexico.Text = "";
            // 
            // sintactico
            // 
            this.sintactico.Controls.Add(this.treeView1);
            this.sintactico.Location = new System.Drawing.Point(4, 22);
            this.sintactico.Name = "sintactico";
            this.sintactico.Padding = new System.Windows.Forms.Padding(3);
            this.sintactico.Size = new System.Drawing.Size(383, 236);
            this.sintactico.TabIndex = 1;
            this.sintactico.Text = "Sintáctico";
            this.sintactico.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(-4, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(387, 240);
            this.treeView1.TabIndex = 0;
            // 
            // semantico
            // 
            this.semantico.Location = new System.Drawing.Point(4, 22);
            this.semantico.Name = "semantico";
            this.semantico.Padding = new System.Windows.Forms.Padding(3);
            this.semantico.Size = new System.Drawing.Size(383, 236);
            this.semantico.TabIndex = 2;
            this.semantico.Text = "Semántico";
            this.semantico.UseVisualStyleBackColor = true;
            // 
            // hashtable
            // 
            this.hashtable.Location = new System.Drawing.Point(4, 22);
            this.hashtable.Name = "hashtable";
            this.hashtable.Padding = new System.Windows.Forms.Padding(3);
            this.hashtable.Size = new System.Drawing.Size(383, 236);
            this.hashtable.TabIndex = 3;
            this.hashtable.Text = "Hash Table";
            this.hashtable.UseVisualStyleBackColor = true;
            // 
            // codigoInter
            // 
            this.codigoInter.Location = new System.Drawing.Point(4, 22);
            this.codigoInter.Name = "codigoInter";
            this.codigoInter.Padding = new System.Windows.Forms.Padding(3);
            this.codigoInter.Size = new System.Drawing.Size(383, 236);
            this.codigoInter.TabIndex = 4;
            this.codigoInter.Text = "Codigo Intermedio";
            this.codigoInter.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tabControl2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 277);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.7767F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.223301F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 143);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(788, 123);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBoxErrorLexico);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 97);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Errores Lexícos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxErrorLexico
            // 
            this.richTextBoxErrorLexico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxErrorLexico.Location = new System.Drawing.Point(-1, 0);
            this.richTextBoxErrorLexico.Name = "richTextBoxErrorLexico";
            this.richTextBoxErrorLexico.ReadOnly = true;
            this.richTextBoxErrorLexico.Size = new System.Drawing.Size(781, 101);
            this.richTextBoxErrorLexico.TabIndex = 0;
            this.richTextBoxErrorLexico.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ErroresSin);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(780, 97);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Errores Sintácticos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ErroresSin
            // 
            this.ErroresSin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErroresSin.Location = new System.Drawing.Point(0, 0);
            this.ErroresSin.Name = "ErroresSin";
            this.ErroresSin.ReadOnly = true;
            this.ErroresSin.Size = new System.Drawing.Size(780, 155);
            this.ErroresSin.TabIndex = 0;
            this.ErroresSin.Text = "";
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(780, 97);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Errores Semánticos";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(780, 97);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Resultados";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabcontrol1.ResumeLayout(false);
            this.Lexico.ResumeLayout(false);
            this.sintactico.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lexicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sintacticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semanticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoIntermedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem lexícoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sintacticoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem semanticoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage Lexico;
        private System.Windows.Forms.RichTextBox richTextBoxLexico;
        private System.Windows.Forms.TabPage sintactico;
        private System.Windows.Forms.TabPage semantico;
        private System.Windows.Forms.TabPage hashtable;
        private System.Windows.Forms.TabPage codigoInter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBoxErrorLexico;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label1;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox ErroresSin;
    }
}

