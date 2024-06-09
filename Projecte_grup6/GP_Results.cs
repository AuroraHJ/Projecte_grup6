using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projecte_grup6
{
    public partial class GP_Results : Form
    {
        public GP_Results()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void GP_Results_Load(object sender, EventArgs e)
        {

        }

        private void GetElementName(object sender, EventArgs e)
        {

        }

        private void FileLoad_btn_Click(object sender, EventArgs e)
        {
            var fileStream = OrigenArxiu_ofd.OpenFile();

            if (!string.IsNullOrEmpty(Fichero_txt.Text))
            {
                try
                {
                    File.ReadAllText(Fichero_txt.Text);

                    Missatges_lbl.Text = "El archivo XML se ha cargado correctamente.";
                }
                catch (Exception ex)
                {
                    Missatges_lbl.Text = "Error al cargar el archivo XML: " + ex.Message;
                }
            }
            else
            {
                Missatges_lbl.Text = "No se ha seleccionado ningún archivo XML.";
            }

        }

        private void OrigenArxiu_ofd_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FileSearch_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OrigenArxiu_ofd = new OpenFileDialog())
            {
                OrigenArxiu_ofd.Filter = "XML files |*.xml";
                if (OrigenArxiu_ofd.ShowDialog() == DialogResult.OK)
                {
                    Fichero_txt.Text = OrigenArxiu_ofd.FileName;
                }
            }

        }
        
        private void Search_btn_Click(object sender, EventArgs e)
        {

        }

        private void Informacion_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Missatges_lbl_Click(object sender, EventArgs e)
        {

        }

        public static string GetElementValue(string FilePath, string ElementName)
        {
         
            using (StreamReader sr = new StreamReader(FilePath))
            {
  
                string line;
                while ((line = sr.ReadLine()) != null)
                {
              
                    string openingTag = "<" + ElementName + ">";

                    if (line.Contains(openingTag))
                    {
               
                        int startIndex = line.IndexOf(openingTag) + openingTag.Length;
                        int endIndex = line.IndexOf("</" + ElementName + ">");
                        if (endIndex > startIndex)
                        {
                            string elementValue = line.Substring(startIndex, endIndex - startIndex);
                            return elementValue;
                        }
                    }
                }


                return null;
            }
        }
        public static string GetElementData(string FilePath, string ElementName)
        {
           
            using (StreamReader sr = new StreamReader(FilePath))
            {
     
                string line;
                while ((line = sr.ReadLine()) != null)
                {
           
                    string openingTag = "<" + ElementName + ">";

                    if (line.Contains(openingTag))
                    {
        
                        int startIndex = line.IndexOf("<");
                        int endIndex = line.IndexOf(">");
                        if (endIndex > startIndex)
                        {
                            string elementValue = line.Substring(startIndex + 1, endIndex - startIndex - 1);
                            return elementValue;
                        }
                    }
                }

                return null;
            }
        }
    }
}
