using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RST_File_Generator
{
    public partial class TestForm : Form
    {
        _01_Function_Form ParentForm1;
        public TestForm()
        {
            InitializeComponent();
        }

        public TestForm(_01_Function_Form form)
        {         
            InitializeComponent();

            ParentForm1 = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
