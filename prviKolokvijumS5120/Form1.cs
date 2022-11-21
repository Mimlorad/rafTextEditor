using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prviKolokvijumS5120
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file_open = new OpenFileDialog();

                //Podesavanje filtera za rtf i txt
                file_open.Filter = "Rich Text File (*.rtf)|*.rtf| Plain Text File (*.txt)|*.txt";
                file_open.FilterIndex = 1;
                file_open.Title = "Odaberi txt ili rtf fajl za otvaranje";

                RichTextBoxStreamType stream_type = RichTextBoxStreamType.RichText;
                if (DialogResult.OK == file_open.ShowDialog())
                {
                    if (string.IsNullOrEmpty(file_open.FileName))
                    {
                        MessageBox.Show("Fajl ne postoji");
                        return;
                    }
                    if (file_open.FilterIndex == 2)
                        stream_type = RichTextBoxStreamType.PlainText;
                    rtbGlavni.LoadFile(file_open.FileName, stream_type);
                }
            }
            catch
            {
                MessageBox.Show("Greska u otvaranju dijaloga!");
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            string filename = "";

            saveDlg.Filter = "Rich Text File (*.rtf)|*.rtf";
            saveDlg.FilterIndex = 1;
            saveDlg.Title = "Sacuvaj fajl";

            DialogResult retval = saveDlg.ShowDialog();
            if (retval == DialogResult.OK)
                filename = saveDlg.FileName;
            else
                return;

            rtbGlavni.SaveFile(filename, RichTextBoxStreamType.RichText);
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontBoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = rtbGlavni.SelectionFont;
            if (SelectedText_Font != null)
                rtbGlavni.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
        }

        private void fontItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = rtbGlavni.SelectionFont;
            if (SelectedText_Font != null)
                rtbGlavni.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dijalogBoja = new ColorDialog();
            //dijalogBoja.ShowDialog();
            if (dijalogBoja.ShowDialog() == DialogResult.OK)
                rtbGlavni.SelectionColor = dijalogBoja.Color;
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dijalogFont = new FontDialog();
            //dijalogFont.ShowDialog();
            if (dijalogFont.ShowDialog() == DialogResult.OK)
            {
                string fontIme = dijalogFont.Font.Name;
                float fontVelicina = dijalogFont.Font.Size;
                Font SelectedText_Font = rtbGlavni.SelectionFont;
                if (SelectedText_Font != null)
                    rtbGlavni.SelectionFont = new Font(fontIme, fontVelicina);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnZameni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPronadji.Text) && String.IsNullOrEmpty(tbZameni.Text))
            {
                MessageBox.Show("Niste uneli ni tekst za pretragu ni tekst za zamenu!");
                return;
            }

            if (String.IsNullOrEmpty(tbPronadji.Text))
            {
                MessageBox.Show("Niste uneli tekst za pretragu!");
                return;
            }

            if (String.IsNullOrEmpty(tbZameni.Text))
            {
                MessageBox.Show("Niste uneli tekst za zamenu!");
                return;
            }

            rtbGlavni.Text = rtbGlavni.Text.Replace(tbPronadji.Text, tbZameni.Text);
        }
    }
}