using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ScintillaNET;


namespace IDEvon
{
    public partial class Form1 : Form
    {
        private int maxLineNumberCharLength;
        
        String archivo;
        String FileName = null;
        String contenido = null;
        static List<String> tokens = new List<string>();
        static List<Token>  tokens2 =  new List<Token>();
       // private CSharpLexer cSharpLexer = new CSharpLexer("main if then else end do while cin cout real int boolean");
        int TamanoInicial = 0;

        String[] reservadas = new String[] { "main", "if", "then", "else", "end", "do", "while", "cin", "cout", "real", "int", "boolean" };
        public void setTamanoInicial(int x)
        {
            TamanoInicial = x;
            
        }
        public Form1()
        {
            InitializeComponent();
             scintilla1.StyleResetDefault();
             scintilla1.Styles[Style.Default].Font = "Consolas";
             scintilla1.StyleClearAll();

             scintilla1.Styles[Style.Cpp.Comment].ForeColor = Color.Green;
             scintilla1.Styles[Style.Cpp.CommentDoc].ForeColor = Color.Green;
             scintilla1.Styles[Style.Cpp.CommentLine].ForeColor = Color.Green;
             scintilla1.Styles[Style.Cpp.Default].ForeColor = Color.Black;
             scintilla1.Styles[Style.Cpp.Word].ForeColor = Color.Red;
             scintilla1.Lexer = Lexer.Cpp;
/*
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = "Consolas";
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.StyleClearAll();

            scintilla1.Styles[CSharpLexer.StyleDefault].ForeColor = Color.Black;
            scintilla1.Styles[CSharpLexer.StyleKeyword].ForeColor = Color.Red;
            //scintilla1.Styles[CSharpLexer.StyleIdentifier].ForeColor = Color.Teal;
            scintilla1.Styles[CSharpLexer.StyleNumber].ForeColor = Color.Purple;
            scintilla1.Styles[CSharpLexer.StyleString].ForeColor = Color.Green;

            scintilla1.Lexer = Lexer.Container;*/

            scintilla1.SetKeywords(0, "main if then else end do while cin cout real int bool float until");
            
        }
     /*   private void scintilla_StyleNeeded(object sender, StyleNeededEventArgs e)
        {
            var startPos = scintilla1.GetEndStyled();
            var endPos = e.Position;

            cSharpLexer.Style(scintilla1, startPos, endPos);
        }*/
        public void guardarComo()
        {

            //se crea un objeto de tipo savefiledialog que nos servira para guardar el archivo
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            

            //al igual que para abrir el tipo de documentos aqui se especifica en que extenciones se puede guardar el archivo
            Save.Filter = "Text (*.txt)|*.txt";
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog(this);
            try
            {
                //este codigo se utiliza para guardar el archivo de nuestro editor
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(scintilla1.Text);
                myStreamWriter.Flush();
                contenido = scintilla1.Text; // guarda el contenido del richTextBox
                FileName = Save.FileName;
                myStreamWriter.Close();

            }
            catch (Exception) { }

        }
        public void guardar()
        {
            if (FileName == null)
            {
                guardarComo();
            }
            else
            {
                File.WriteAllText(FileName, scintilla1.Text); //sobre escribe el contenido del txt
                contenido = scintilla1.Text; // guardo el contenido del richTextBox

            }
        }
        public void nuevo()
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
            // Si el documento no es nuevo y hay cambios 
            if (FileName != null && contenido != null && contenido != scintilla1.Text)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar los cambios? uno", "Advertencia", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    guardar();
                    scintilla1.ClearAll();
                    archivo = null;
                    FileName = null;
                    Form1.ActiveForm.Text = archivo + " IDE CHIDO";
                }
                else if (dr == DialogResult.Cancel)
                {

                }
                else if (dr == DialogResult.No)
                {
                    scintilla1.ClearAll();
                    archivo = null;
                    FileName = null;
                    Form1.ActiveForm.Text = archivo + " IDE CHIDO";
                }
            }
            // si es un nuevo documento y tiene algo escrito 
            else if (scintilla1.SelectionStart != 0 && FileName == null)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar los cambios? dos", "Advertencia", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    guardarComo();
                    scintilla1.Clear();
                    archivo = null;
                    FileName = null;
                    Form1.ActiveForm.Text = archivo + " IDE CHIDO";
                }
                else if (dr == DialogResult.Cancel)
                {

                }
                else if (dr == DialogResult.No)
                {

                    scintilla1.ClearAll();
                    archivo = null;
                    FileName = null;
                    Form1.ActiveForm.Text = archivo + " IDE CHIDO";
                }
            }
            // si es un nuevo documento esta vacio y es nuevo o viejo sin cambios
            else if ((FileName == null && scintilla1.SelectionStart == 0) || (FileName != null && contenido == scintilla1.Text))
            {
                scintilla1.ClearAll();
                archivo = null;
                FileName = null;
                Form1.ActiveForm.Text = archivo + " IDE CHIDO";
            }
            TamanoInicial = 0;
            contenido = null;
        }
        public void abrir()
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
            // Si el documento no es nuevo y hay cambios 
            if (FileName != null && contenido != null && contenido != scintilla1.Text)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar los cambios? uno", "Advertencia", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //Lo guarda y luego lo abre
                    guardar();
                    OpenFileDialog OpenFile = new OpenFileDialog();
                    if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        archivo = OpenFile.FileName;
                        FileName = archivo;
                        using (StreamReader sr = new StreamReader(FileName))
                        {
                           scintilla1.Text = sr.ReadToEnd();
                        }
                        Form1.ActiveForm.Text = archivo + " IDE CHIDO";
                        int n = scintilla1.SelectionStart;
                        setTamanoInicial(n);
                        contenido = scintilla1.Text;
                    }
                }
                else if (dr == DialogResult.Cancel)
                {

                }
                else if (dr == DialogResult.No)
                {
                    OpenFileDialog OpenFile = new OpenFileDialog();
                    if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        archivo = OpenFile.FileName;
                        FileName = archivo;
                        using (StreamReader sr = new StreamReader(FileName))
                        {
                            scintilla1.Text = sr.ReadToEnd();
                        }
                        Form1.ActiveForm.Text = archivo + " IDE CHIDO";
                        int n = scintilla1.SelectionStart;
                        setTamanoInicial(n);
                        contenido = scintilla1.Text;
                    }
                }
            }
            // si es un nuevo documento y tiene algo escrito 
            else if (scintilla1.SelectionStart != 0 && FileName == null)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar los cambios? dos", "Advertencia", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    guardarComo();
                    OpenFileDialog OpenFile = new OpenFileDialog();
                    if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        archivo = OpenFile.FileName;
                        FileName = archivo;
                        using (StreamReader sr = new StreamReader(FileName))
                        {
                            scintilla1.Text = sr.ReadToEnd();
                        }
                        Form1.ActiveForm.Text = archivo + " IDE CHIDO";
                        contenido = scintilla1.Text;

                    }

                }
                else if (dr == DialogResult.Cancel)
                {

                }
                else if (dr == DialogResult.No)
                {
                    OpenFileDialog OpenFile = new OpenFileDialog();
                    if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        archivo = OpenFile.FileName;
                        FileName = archivo;
                        using (StreamReader sr = new StreamReader(FileName))
                        {
                            scintilla1.Text = sr.ReadToEnd();
                        }
                        Form1.ActiveForm.Text = archivo + " IDE CHIDO";
                        contenido = scintilla1.Text;

                    }
                }
            }
            // si es un nuevo documento esta vacio y es nuevo o viejo sin cambios
            else if ((FileName == null && scintilla1.SelectionStart == 0) || (FileName != null && contenido == scintilla1.Text))
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = OpenFile.FileName;
                    FileName = archivo;
                    using (StreamReader sr = new StreamReader(FileName))
                    {
                        scintilla1.Text = sr.ReadToEnd();
                    }
                    Form1.ActiveForm.Text = archivo + " IDE CHIDO";
                    contenido = scintilla1.Text;


                }
            }
            //richTextBox4.Text = contenido;
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;

            if (FileName != null && contenido != null && contenido != scintilla1.Text)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar los cambios?", "Advertencia", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    guardar();
                    e.Cancel = false;

                }
                else if (dr == DialogResult.Cancel)
                {

                    e.Cancel = true;
                }
                else if (dr == DialogResult.No)
                {
                    e.Cancel = false;
                }
            }

            else if (scintilla1.SelectionStart != 0 && FileName == null)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar el documento?", "Advertencia", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    guardarComo();
                    e.Cancel = false;

                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.No)
                {
                    e.Cancel = false;
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;

            if (FileName != null && contenido != null && contenido != scintilla1.Text)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar los cambios?", "Advertencia", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    guardar();
                    this.Dispose();
                }
                else if (dr == DialogResult.Cancel)
                {


                }
                else if (dr == DialogResult.No)
                {
                    this.Dispose();
                }
            }

            else if (scintilla1.SelectionStart != 0 && FileName == null)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar el documento?", "Advertencia", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    guardarComo();
                    this.Dispose();
                }
                else if (dr == DialogResult.Cancel)
                {

                }
                else if (dr == DialogResult.No)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }

        }
        private void LEXICO()
        {
            if (FileName == null && scintilla1.SelectionStart == 0)
            {

            }
            else
            {
                if (FileName != null && contenido != null && contenido != scintilla1.Text)
                {
                    guardar();
                }
                else if (scintilla1.SelectionStart != 0 && FileName == null)
                {
                    guardarComo();
                }
                richTextBoxLexico.Clear();
                richTextBoxLexico.Focus();
                richTextBoxErrorLexico.Clear();
                richTextBoxErrorLexico.Focus();
                lexico objetoLexico = new lexico();
                objetoLexico.setRuta(FileName);
                objetoLexico.principal();
                String salida = null;
                String errores = null;
                salida = objetoLexico.getSalida();
                errores = objetoLexico.getErrores();
                richTextBoxLexico.Text = salida;
                richTextBoxErrorLexico.Text = errores;
                tokens = objetoLexico.getLista();
                tokens2 = objetoLexico.getList();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void guardarComoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void aToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        private void aToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void lexícoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LEXICO();
        }

        private void lexicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LEXICO();
        }

        public void LineaCaracter()
        {
           // int PosicionColumna = 0;
            //PosicionColumna = (fastColoredTextBox1.SelectionStart - fastColoredTextBox1.GetLineLength()) + 1;

            //label1.Text = "Linea: " + (richTextBox1.GetLineFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine()) + 1).ToString() + ", Columna: " + PosicionColumna.ToString();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = scintilla1.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.

            const int padding = 2;
            scintilla1.Margins[0].Width = scintilla1.TextWidth(maxLineNumberCharLength, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
            posicion();
            //cSharpLexer.Style(scintilla1,0, scintilla1.TextLength);
        }
        public void posicion()
        {
            var currentPos = scintilla1.CurrentPosition;
            var currentLine = scintilla1.LineFromPosition(currentPos);
            var linePos = scintilla1.Lines[currentLine].Position;
            var fauxColumn = (currentPos - linePos);
            var colum = scintilla1.GetColumn(scintilla1.CurrentPosition);
            int x = colum + 1;
            int y = currentLine + 1;
            label1.Text = "linea: " + y.ToString() + " columna: " + x.ToString();
        }


        private void scintilla1_KeyDown(object sender, KeyEventArgs e)
        {
            posicion();
        }

        private void scintilla1_KeyUp(object sender, KeyEventArgs e)
        {
            posicion();
        }

        private void scintilla1_Click(object sender, EventArgs e)
        {
            //posicion();
            
        }

        private void sintacticoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FileName == null && scintilla1.SelectionStart == 0)
            {

            }
            else
            {
                LEXICO();
                Sintactico raiz = new Sintactico(tokens2);
                treeView1.Nodes.Clear();
                TreeNode temp = new TreeNode();
                temp = raiz.main();
                TreeNode tn = new TreeNode("error");
                TreeNode[] nodes = temp.Nodes.Find("error",true);
                if (nodes.Length > 0)
                {
                    temp.Nodes.Remove(nodes[0]);
                }
                treeView1.Nodes.Add(temp);
                treeView1.ExpandAll();
                ErroresSin.Text = raiz.getErrores();
            }
           
        }

        private void sintacticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null && scintilla1.SelectionStart == 0)
            {

            }
            else
            {
                LEXICO();
                Sintactico raiz = new Sintactico(tokens2);
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(raiz.main());
                treeView1.ExpandAll();
                ErroresSin.Text = raiz.getErrores();
            }
        }
    }
}
