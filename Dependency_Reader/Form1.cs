using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dependency_Reader
{
    public partial class DependencyReader : Form
    {
        public DependencyReader()
        {
            InitializeComponent();
        }

        //Courtesy of https://www.c-sharpcorner.com/blogs/drag-and-drop-file-on-windows-forms1
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog dialog = new OpenFileDialog())
            //{
            //    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        inputFilePath.Text = dialog.FileName;
            //    }
            //}

            if (inputFilePath.Text == null || inputFilePath.Text.Length == 0)
            {
                setError("Please set a file path for the .dll");
                return;
            }

            checkDependencies();
        }

        private void inputFilePath_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void inputFilePath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Any())
            {
                inputFilePath.Text = files.First();
            }
        }

        private void setError(string errorText)
        {
            richTextDependencies.ForeColor = Color.Red;
            richTextDependencies.Text = errorText;
        }

        private void setText(string text)
        {
            richTextDependencies.ForeColor = Color.Black;
            richTextDependencies.Text = text;
        }

        private void checkDependencies()
        {
            try
            {
                AssemblyName[] assemblies = Assembly.LoadFile(inputFilePath.Text).GetReferencedAssemblies();

                if (assemblies.GetLength(0) > 0)
                {
                    string dependencies = "";
                    foreach(AssemblyName assembly in assemblies)
                    {
                        dependencies += $"{assembly}\n\n";
                    }
                    setText(dependencies);
                }
                else
                {
                    setText("No dependencies");
                }
            }
            catch (Exception ex)
            {
                setError(ex.Message);
            }
        }
    }
}
