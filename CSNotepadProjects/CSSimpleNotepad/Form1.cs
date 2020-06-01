using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSimpleNotepad
{
    public partial class frmSimpleNotepad : Form
    {
        public frmSimpleNotepad()
        {
            InitializeComponent();
        }

        private RichTextBox GetRichTextBox()// to return
        {
            RichTextBox rtb = null;
            TabPage tp = tabControl1.SelectedTab;

            if (tp!=null) // if a tab is selected
            {
                rtb = tp.Controls[0] as RichTextBox; // rtb is the first control
            }
            return rtb;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // to open new document
            TabPage tp = new TabPage("New Document");
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            tp.Controls.Add(rtb);
            tabControl1.TabPages.Add(tp);
        }

        // to open an existing document
        private void openToolStripMenuItem_Click(object sender, EventArgs e) // needed to be create new document in application before open an existing file from the directory
        {
            //Stream myStream;
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //if (openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            //{
            //    if ((myStream = openFileDialog1.OpenFile()) != null)
            //    {
            //        string strfilename = openFileDialog1.FileName;
            //        string filetext = File.ReadAllText(strfilename);
            //        GetRichTextBox().Text = filetext;
            //    }
            //}

            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.Filter = "Text Files|*.txt";
            
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                GetRichTextBox().LoadFile(openFile1.FileName,
                RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut(); // cut text from richtextbox
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy(); // copy text from richtextbox
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste(); // paste text from richtextbox
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Notepad Application");
        }

        // find text button
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int index = 0;
            String temp = GetRichTextBox().Text;
            GetRichTextBox().Text = "";
            GetRichTextBox().Text = temp;

            while (index < GetRichTextBox().Text.LastIndexOf(toolStripTextBox1.Text))
            {
                GetRichTextBox().Find(toolStripTextBox1.Text, index, GetRichTextBox().TextLength, RichTextBoxFinds.None);
                GetRichTextBox().SelectionBackColor = Color.Cyan;
                index = GetRichTextBox().Text.IndexOf(toolStripTextBox1.Text, index) + 1;
            }
        }
    }
}
