using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordpad
{
    public partial class Form_1079_1 : Form
    {
        public Form_1079_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.Text = @"Home";
 

            foreach(FontFamily font in FontFamily.Families)
            {
                comboBox_1079_1.Items.Add(font.Name.ToString());
                
            }
            comboBox_1079_1.Text = this.richTextBox_1079_1.Font.Name.ToString();
            comboBox_1079_2.Text = this.richTextBox_1079_1.Font.Size.ToString();
        }

        

        private void fontDialog_1079_1_Apply(object sender, EventArgs e)
        {

        }

  

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(fontDialog_1079_1.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(richTextBox_1079_1.Text))
            {
                richTextBox_1079_1.SelectionFont = fontDialog_1079_1.Font;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_1079_6_Click(object sender, EventArgs e)
        {
            richTextBox_1079_1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void richTextBox_1079_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_1079_11_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1079_1.Text))
            {
                if(colorDialog_1079_1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox_1079_1.SelectionColor = colorDialog_1079_1.Color;
                }
            }
        }

        private void fontDialog_1079_1_Apply_2(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox_1079_1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton_1079_2_Click(object sender, EventArgs e)
        {
            richTextBox_1079_1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton_1079_3_Click(object sender, EventArgs e)
        {
            richTextBox_1079_1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton_1079_4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1079_1.Text))
            {
                if (!richTextBox_1079_1.SelectionFont.Bold)
                {

                    richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Bold);

                }
                else
                {

                    richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Regular);
                }
            }
        }

        private void toolStripButto_1079_5_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1079_1.Text))
            {
                if (!richTextBox_1079_1.SelectionFont.Italic)
                {

                    richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Italic);

                }
                else
                {

                    richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Regular);
                }
            }
        }

        private void toolStripButton_1079_6_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1079_1.Text))
            {
                if (!richTextBox_1079_1.SelectionFont.Underline)
                {

                    richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Underline);

                }
                else
                {

                    richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Regular);

                }
            }
        }

        private void toolStripButton_1079_7_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1079_1.Text))
            {
                if (!richTextBox_1079_1.SelectionFont.Strikeout)
                {

                    richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Strikeout);
                }
                else
                {

                    richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Regular);
                }
            }
        }

        private void toolStripButton_1079_8_Click(object sender, EventArgs e)
        {
            
                openFileDialog_1079_1.Title = "Choose Image";
                openFileDialog_1079_1.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif";

                if (openFileDialog_1079_1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = openFileDialog_1079_1.FileName;
                    Bitmap bitmap = new Bitmap(fileName);
                    Clipboard.SetDataObject(bitmap);

                    DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);

                    if (richTextBox_1079_1.CanPaste(myFormat))
                    {
                        richTextBox_1079_1.Paste(myFormat);
                    }
                }
            
        }

        private void comboBox_1079_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Regular);
            } catch(Exception ex)
            {

            }
        }

        private void comboBox_1079_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox_1079_1.SelectionFont = new Font(comboBox_1079_1.Text.ToString(), float.Parse(comboBox_1079_2.Text), FontStyle.Regular);

            } catch(Exception ex)
            {

            }

        }
    }
}
