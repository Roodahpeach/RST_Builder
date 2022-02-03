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
                    
                    String str = TF_Param_Name_List[i].Text;
                    if(str.IndexOf('*') != -1) //* 제거
                    {
                        str = str.Substring(str.IndexOf('*') + 1);  
                    }


                    String[] str2_temp = RT_Param_Description_List[i].Text.Split('\n'); //파라미터 설명쪽에 엔터키 제거
                    String str2 = "";
                    foreach (string temptemp in str2_temp)
                    {
                        string temptemp2 = temptemp.Last() == '.' ? "" : ".";
                        str2 += temptemp +temptemp2 + " ";
                    }
                    

                   
                    RST_File_Writer.WriteLine("- " + str + " : " + str2);
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

        public void GenFunc_Warning()
        {
            string indent_blank = "  ";

            foreach (Class_Additional_Function_Info info in Additional_Info_List)
            {
                if (info.common_note_type == (int)Class_Additional_Function_Info.enum_Common_Note_Type.Warning)
                {
                    RST_File_Writer.WriteLine(".. warning::");
                    
                    string[] temp = info.common_description.Split('\n');

                    foreach (string str in temp)
                    {
                        RST_File_Writer.WriteLine(indent_blank + str);
                        RST_File_Writer.WriteLine();
                    }
                    GenFunc_AddBlank();
                }
                else
                {
                    continue;
                }
            }

            
        }

        public void GenFunc_Note()
        {
            string indent_blank = "  ";

            foreach (Class_Additional_Function_Info info in Additional_Info_List)
            {
                if (info.common_note_type == (int)Class_Additional_Function_Info.enum_Common_Note_Type.Note)
                {
                    RST_File_Writer.WriteLine(".. note::");

                    string[] temp = info.common_description.Split('\n');

                    foreach (string str in temp)
                    {
                        RST_File_Writer.WriteLine(indent_blank + str);
                        RST_File_Writer.WriteLine();
                    }

                    GenFunc_AddBlank();
                }
                else
                {
                    continue;
                }
            }

            

        }

        public void GenFunc_Hint()
        {
            string indent_blank = "  ";

            foreach (Class_Additional_Function_Info info in Additional_Info_List)
            {
                if (info.common_note_type == (int)Class_Additional_Function_Info.enum_Common_Note_Type.Hint)
                {
                    RST_File_Writer.WriteLine(".. hint::");

                    string[] temp = info.common_description.Split('\n');

                    foreach (string str in temp)
                    {
                        RST_File_Writer.WriteLine(indent_blank + str);
                        RST_File_Writer.WriteLine();
                    }
                    
                    GenFunc_AddBlank();

                }
                else
                {
                    continue;
                }
            }   
        }

        public void GenFunc_SeeAlso()
        {
            string indent_blank = "  ";

            foreach (Class_Additional_Function_Info info in Additional_Info_List)
            {
                if (info.Info_type == (int)Class_Additional_Function_Info.enum_Info_Type.SeeAlso)
                {
                    RST_File_Writer.WriteLine(".. seealso::");

                    foreach (string str in info.Seealso_ref_linklist)
                    {
                        RST_File_Writer.WriteLine(indent_blank + str);
                        RST_File_Writer.WriteLine();
                    }
                    GenFunc_AddBlank();
                }
                else
                {
                    continue;
                }
            }
        }

        #endregion

        #region Form Init

        MainForm prev_form;
        public _01_Function_Form()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
      
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; 
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public _01_Function_Form(MainForm formform)
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            prev_form = formform;
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
            if((TF_FunctionName.Text.Length == 0) || (TF_Return_Type.Text.Length == 0))
            {
                MessageBox.Show("함수 이름, 반환값 정보를 입력해주세요");
                return;
            }

            object_name = TF_FunctionName.Text;
            string FolderLocation = TF_FolderLocation.Text.Length == 0 ? "./" : TF_FolderLocation.Text;
            filename = FolderLocation + "\\" + object_name + ".rst";

            try
            {
                RST_File_Writer = File.CreateText(filename);

                GenFunc_Header();
                GenFunc_Warning();
                GenFunc_Hint();
                GenFunc_Synopsis();
                GenFunc_Description();
                GenFunc_Parameter();
                GenFunc_ReturnValue();
                GenFunc_Note();
                GenFunc_SeeAlso();

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

        private void BT_Add_Info_Click(object sender, EventArgs e)
        {
            new Function_Additional_Info_Form(this).Show();
        }

        private void BT_Delete_Info_Click(object sender, EventArgs e)
        {
            if (LB_Additional_Info.SelectedItem != null)
            {
                string temp = LB_Additional_Info.SelectedItem.ToString();

                string[] temp2 = temp.Split('-');

                int target_id = Convert.ToInt32(temp2[0]);

                AddInfo_DeleteID(target_id);
                AddInfo_UpdateList();
            }
            else
            {
                MessageBox.Show("리스트에서 지우고자 하는 데이터를 선택해주세요");
            }


        }
        private void BT_Clear_All_Click(object sender, EventArgs e)
        {
            prev_form.functionform_reload();
            this.Close();
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

        #region Additional_Info_Handler

        public ArrayList Additional_Info_List = new ArrayList();
        public int Additional_Info_ID = 0;
        public int AddInfo_GetID()
        {
            return Additional_Info_ID;
        }
        public void AddInfo_AddData(Class_Additional_Function_Info info)
        {
            Additional_Info_List.Add(info);
            Additional_Info_ID++;
        }

        public void AddInfo_UpdateList()
        {
            LB_Additional_Info.Items.Clear();

            foreach(Class_Additional_Function_Info info in Additional_Info_List)
            {
                string str;
                string info_type = "";

                if(info.Info_type == (int)Class_Additional_Function_Info.enum_Info_Type.Common_Note)
                {
                    info_type = "Common_Note";
                    if(info.common_note_type == (int)Class_Additional_Function_Info.enum_Common_Note_Type.Hint)
                    {
                        info_type += "(Hint)";
                    }
                    else if (info.common_note_type == (int)Class_Additional_Function_Info.enum_Common_Note_Type.Note)
                    {
                        info_type += "(Note)";
                    }
                    else if (info.common_note_type == (int)Class_Additional_Function_Info.enum_Common_Note_Type.Warning)
                    {
                        info_type += "(Warning)";
                    }
                }
                else if(info.Info_type == (int)Class_Additional_Function_Info.enum_Info_Type.SeeAlso)
                {
                    info_type = "SeeAlso";
                }
                else if (info.Info_type == (int)Class_Additional_Function_Info.enum_Info_Type.Example)
                {
                    info_type = "Example";
                }

                str = info.id + "-" + info_type;

                LB_Additional_Info.Items.Add(str);
            }
        }

        public void AddInfo_DeleteID(int target_id)
        {
            for(int i =0;i< Additional_Info_List.Count; i++)
            {
                Class_Additional_Function_Info temp = (Class_Additional_Function_Info)Additional_Info_List[i];
                if(temp.id == target_id)
                {
                    Additional_Info_List.RemoveAt(i);
                }
            }
        }
        private void BT_ClearAll_Click(object sender, EventArgs e)
        {
            Additional_Info_List.Clear();
            Additional_Info_ID = 0;
            LB_Additional_Info.Items.Clear();
        }
        #endregion

        
    }
}
