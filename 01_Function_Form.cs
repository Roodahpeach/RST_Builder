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
    public partial class _01_Function_Form : MaterialForm
    {
        #region Public Variable

        StreamWriter RST_File_Writer;
        string object_name;
        string filename;

        MaterialSingleLineTextField[] TF_Param_Name_List = new MaterialSingleLineTextField[9];
        MaterialSingleLineTextField[] TF_Param_DataType_List = new MaterialSingleLineTextField[9];
        RichTextBox[] RT_Param_Description_List = new RichTextBox[9];

        #endregion

        #region RST_Generating_Functions

        public void GenFunc_AddBlank()
        {
            RST_File_Writer.WriteLine();
            RST_File_Writer.WriteLine();
            RST_File_Writer.WriteLine();
        }
        public void GenFunc_Header()
        {
            string object_name = TF_FunctionName.Text;
            string prefix = TF_Prefix.Text;

            RST_File_Writer.WriteLine(".. _" + prefix + "_" + object_name + ":");
            RST_File_Writer.WriteLine();

            RST_File_Writer.WriteLine(object_name);

            foreach (char c in object_name)
            {
                RST_File_Writer.Write("=");
            }
            RST_File_Writer.WriteLine();

            foreach (char c in object_name)
            {
                RST_File_Writer.Write("-");
            }

            GenFunc_AddBlank();

        }
        public void GenFunc_Synopsis()
        {
            string object_name = TF_FunctionName.Text;
            string return_type = TF_Return_Type.Text;
            string header_name = "SYNOPSIS";
            string indent_blank = "  ";

            RST_File_Writer.WriteLine(header_name);

            foreach (char c in header_name)
            {
                RST_File_Writer.Write("-");
            }

            GenFunc_AddBlank();

            RST_File_Writer.WriteLine(".. code-block:: none");
            RST_File_Writer.WriteLine();

            RST_File_Writer.WriteLine(indent_blank + return_type + " " + object_name + "(");

            for (int i = 0; i < 9; i++)
            {
                if (TF_Param_DataType_List[i].Text.Length != 0)
                {
                    RST_File_Writer.Write(indent_blank + indent_blank + TF_Param_DataType_List[i].Text + " " + TF_Param_Name_List[i].Text);

                    if ((i != 8) && (TF_Param_DataType_List[i + 1].Text.Length != 0))
                    {
                        RST_File_Writer.Write(",");
                    }
                    RST_File_Writer.WriteLine();
                }
                else
                {
                    break;
                }
            }
            RST_File_Writer.WriteLine(indent_blank + ")");

            GenFunc_AddBlank();
        }

        public void GenFunc_Parameter()
        {
            string header_name = "PARAMETER";

            RST_File_Writer.WriteLine(header_name);

            foreach (char c in header_name)
            {
                RST_File_Writer.Write("-");
            }

            GenFunc_AddBlank();


            for (int i = 0; i < 9; i++)
            {
                if (TF_Param_DataType_List[i].Text.Length != 0)
                {
                    RST_File_Writer.WriteLine("- " + TF_Param_Name_List[i].Text + " : " + RT_Param_Description_List[i].Text);
                    RST_File_Writer.WriteLine();
                }
                else
                {
                    break;
                }
            }

            GenFunc_AddBlank();
        }

        public void GenFunc_Description()
        {
            string header_name = "DESCRIPTION";

            RST_File_Writer.WriteLine(header_name);

            foreach (char c in header_name)
            {
                RST_File_Writer.Write("-");
            }

            GenFunc_AddBlank();


            if (Checkbox_Description_inputraw.Checked)
            {
                RST_File_Writer.WriteLine(RT_Description_text.Text);
            }
            else
            {
                string[] temp = RT_Description_text.Text.Split('\n');

                foreach (string str in temp)
                {
                    RST_File_Writer.WriteLine("- " + str);
                }
            }

            GenFunc_AddBlank();
        }

        public void GenFunc_ReturnValue()
        {
            string header_name = "RETURN VALUE";

            RST_File_Writer.WriteLine(header_name);

            foreach (char c in header_name)
            {
                RST_File_Writer.Write("-");
            }

            GenFunc_AddBlank();

            if (Checkbox_Return_inputraw.Checked)
            {
                RST_File_Writer.WriteLine(RT_Return_Meaning.Text);
            }
            else
            {
                string[] temp = RT_Return_Meaning.Text.Split('\n');

                foreach (string str in temp)
                {
                    RST_File_Writer.WriteLine("- " + str);
                }
            }

            GenFunc_AddBlank();

        }

        #endregion

        #region Form Init
        public _01_Function_Form()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
      
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; 
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void _01_Function_Form_Load(object sender, EventArgs e)
        {
            TF_Param_Name_List[0] = TF_ParameterName1;
            TF_Param_Name_List[1] = TF_ParameterName2;
            TF_Param_Name_List[2] = TF_ParameterName3;
            TF_Param_Name_List[3] = TF_ParameterName4;
            TF_Param_Name_List[4] = TF_ParameterName5;
            TF_Param_Name_List[5] = TF_ParameterName6;
            TF_Param_Name_List[6] = TF_ParameterName7;
            TF_Param_Name_List[7] = TF_ParameterName8;
            TF_Param_Name_List[8] = TF_ParameterName9;

            TF_Param_DataType_List[0] = TF_DataType1;
            TF_Param_DataType_List[1] = TF_DataType2;
            TF_Param_DataType_List[2] = TF_DataType3;
            TF_Param_DataType_List[3] = TF_DataType4;
            TF_Param_DataType_List[4] = TF_DataType5;
            TF_Param_DataType_List[5] = TF_DataType6;
            TF_Param_DataType_List[6] = TF_DataType7;
            TF_Param_DataType_List[7] = TF_DataType8;
            TF_Param_DataType_List[8] = TF_DataType9;

            RT_Param_Description_List[0] = RT_Paramater_Meaning1;
            RT_Param_Description_List[1] = RT_Paramater_Meaning2;
            RT_Param_Description_List[2] = RT_Paramater_Meaning3;
            RT_Param_Description_List[3] = RT_Paramater_Meaning4;
            RT_Param_Description_List[4] = RT_Paramater_Meaning5;
            RT_Param_Description_List[5] = RT_Paramater_Meaning6;
            RT_Param_Description_List[6] = RT_Paramater_Meaning7;
            RT_Param_Description_List[7] = RT_Paramater_Meaning8;
            RT_Param_Description_List[8] = RT_Paramater_Meaning9;
        }

        #endregion

        #region UI_Event_Handler
        private void BT_Generate_Click(object sender, EventArgs e)
        {
            object_name = TF_FunctionName.Text;

            filename = TF_FolderLocation.Text + "\\" + object_name + ".rst";

            try
            {
                RST_File_Writer = File.CreateText(filename);

                GenFunc_Header();
                GenFunc_Synopsis();
                GenFunc_Description();
                GenFunc_Parameter();
                GenFunc_ReturnValue();

                RST_File_Writer.Close();

                MessageBox.Show(object_name + ".rst 파일 생성 완료");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return;
        }

        private void BT_FolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            if (fld.ShowDialog() == DialogResult.OK)
            {
                TF_FolderLocation.Text = fld.SelectedPath;
            }
        }

        #endregion

        #region StatusTimer
        public bool timer_function_name_status = false;
        public bool timer_return_valus_status = false;


        private void Timer_Status_Tick(object sender, EventArgs e)
        {
            if(TF_FunctionName.Text.Length == 0)
            {
                materialLabel1.BackColor = timer_function_name_status ? Color.Red : Color.Transparent;

                timer_function_name_status = !timer_function_name_status;
            }
            else
            {
                materialLabel1.BackColor = Color.Transparent;
            }

            if(TF_Return_Type.Text.Length == 0) 
            {
                materialLabel5.BackColor = timer_return_valus_status ? Color.Red : Color.Transparent;
                timer_return_valus_status = !timer_return_valus_status;
            }
            else
            {
                materialLabel5.BackColor = Color.Transparent;
            }
        }
        #endregion

    }
}
