using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.IO;

using MaterialSkin;
using MaterialSkin.Controls;

namespace RST_File_Generator
{
    public partial class _00_Struct_Enum_Form : MaterialForm
    {
        bool TextFieldFlag;

        MaterialSingleLineTextField[] TF_Header_List;

        public _00_Struct_Enum_Form()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void _00_Struct_Enum_Form_Load(object sender, EventArgs e)
        {
            CB_doctype.SelectedIndex = 0;
            CB_prefix.SelectedIndex = 0;

            TextFieldFlag = false;

            TF_Header_List = new MaterialSingleLineTextField[5];

            TF_Header_List[0] = TF_Header1;
            TF_Header_List[1] = TF_Header2;
            TF_Header_List[2] = TF_Header3;
            TF_Header_List[3] = TF_Header4;
            TF_Header_List[4] = TF_Header5;
        }

        private void BT_Generate_Click(object sender, EventArgs e)
        {
            if(TF_objectname.Text.Length == 0)
            {
                MessageBox.Show("Object 명을 입력해주세요.");
                return;
            }

            string object_name = TF_objectname.Text;
            string filename = object_name + ".rst";

            string Product_Prefix = CB_prefix.Text;
            string Document_Type = CB_doctype.Text;

            StreamWriter RST_File_Writer;
            
            RST_File_Writer = File.CreateText(filename);

            RST_File_Writer.WriteLine(".. _" + Product_Prefix + "_" + Document_Type + "_" + object_name + ":");
            RST_File_Writer.WriteLine();

            RST_File_Writer.WriteLine(object_name);

            foreach (char i in object_name)
            {
                RST_File_Writer.Write("=");
            }
            RST_File_Writer.WriteLine();

            foreach (char i in object_name)
            {
                RST_File_Writer.Write("-");
            }
            RST_File_Writer.WriteLine();
            RST_File_Writer.WriteLine();
            RST_File_Writer.WriteLine();
            RST_File_Writer.WriteLine();

            if (CheckBox_Warning.Checked)
            {
                RST_File_Writer.WriteLine(".. warning::");
                RST_File_Writer.WriteLine("   text");
                RST_File_Writer.WriteLine();
                RST_File_Writer.WriteLine();
                RST_File_Writer.WriteLine();
            }


            foreach (MaterialSingleLineTextField TF in TF_Header_List)
            {
                if (TF.Text.Length != 0)
                {
                    String header = TF.Text;

                    RST_File_Writer.WriteLine(header);
                    
                    foreach (char c in header)
                    {
                        RST_File_Writer.Write("`");
                    }

                    RST_File_Writer.WriteLine();
                    RST_File_Writer.WriteLine();
                    RST_File_Writer.WriteLine();

                    if(header == "SYNOPSIS")
                    {
                        if(Document_Type == "struct" || Document_Type == "union")
                        {
                            RST_File_Writer.WriteLine("+-----------+------+---------+");
                            RST_File_Writer.WriteLine("| Parameter | Type | Meaning |");
                            RST_File_Writer.WriteLine("+===========+======+=========+");
                            RST_File_Writer.WriteLine("|           |      |         |");
                            RST_File_Writer.WriteLine("+-----------+------+---------+");
                        }
                        else if(Document_Type == "enum")
                        {
                            RST_File_Writer.WriteLine("+------+-------+---------+");
                            RST_File_Writer.WriteLine("| name | value | meaning |");
                            RST_File_Writer.WriteLine("+======+=======+=========+");
                            RST_File_Writer.WriteLine("|      |       |         |");
                            RST_File_Writer.WriteLine("+------+-------+---------+");
                        }
                        RST_File_Writer.WriteLine();
                        RST_File_Writer.WriteLine();
                        RST_File_Writer.WriteLine();
                    }

                }
                else
                {
                    continue;
                }
            }

            if (Checkbox_note.Checked)
            {
                RST_File_Writer.WriteLine(".. note::");
                RST_File_Writer.WriteLine("   text");
                RST_File_Writer.WriteLine();
                RST_File_Writer.WriteLine();
                RST_File_Writer.WriteLine();
            }

            if (Checkbox_seealso.Checked)
            {
                RST_File_Writer.WriteLine(".. seealso::");
                RST_File_Writer.WriteLine("   text");
                RST_File_Writer.WriteLine();
                RST_File_Writer.WriteLine();
                RST_File_Writer.WriteLine();
            }

            RST_File_Writer.Close();
            return;

        }

        private void ObjectNameTimer_Tick(object sender, EventArgs e)
        {
            if (TF_objectname.Text.Length == 0)
            {
                materialLabel8.BackColor = TextFieldFlag ? Color.Red : Color.Transparent;
                TextFieldFlag = !TextFieldFlag;
            }
            else
            {
                materialLabel8.BackColor = Color.Transparent;
            }
        }

        private void _00_Struct_Enum_Form_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
