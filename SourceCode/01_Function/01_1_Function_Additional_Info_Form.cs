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
    public partial class Function_Additional_Info_Form : MaterialForm
    {
        #region FormInit

        _01_Function_Form prev_form;

        public Function_Additional_Info_Form()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            CB_Example_Language.SelectedIndex = 0;
        }

        public Function_Additional_Info_Form(_01_Function_Form form)
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            prev_form = form;

            CB_Example_Language.SelectedIndex = 0;
        }


        #endregion

        #region Common
        private void BT_Common_Submit_Click(object sender, EventArgs e)
        {
            Class_Additional_Function_Info data = new Class_Additional_Function_Info();

            data.id = prev_form.AddInfo_GetID();
            data.Info_type = (int)Class_Additional_Function_Info.enum_Info_Type.Common_Note;

            if (RB_COMMON_note.Checked)
            {
                data.common_note_type = (int)Class_Additional_Function_Info.enum_Common_Note_Type.Note;
            }
            else if (RB_COMMON_Hint.Checked)
            {
                data.common_note_type = (int)Class_Additional_Function_Info.enum_Common_Note_Type.Hint;
            }
            else if (RB_COMMON_warning.Checked)
            {
                data.common_note_type = (int)Class_Additional_Function_Info.enum_Common_Note_Type.Warning;
            }

            data.common_description = RT_Common_Description.Text;

            prev_form.AddInfo_AddData(data);
            prev_form.AddInfo_UpdateList();
            MessageBox.Show("추가 완료");
        }
        #endregion

        #region SeeAlso
        private void BT_Seealso_add_Click(object sender, EventArgs e)
        {
            string str = ":ref:`";
            if (TF_Seealso_DisplayName.Text.Length == 0)
            {
                str += TF_Seealso_Target.Text + "`";
            }
            else
            {
                str += TF_Seealso_DisplayName.Text + " <" + TF_Seealso_Target.Text + ">`";
            }
            LB_Seealso.Items.Add(str);
        }

        private void BT_Seealso_Delete_Click(object sender, EventArgs e)
        {
            if (LB_Seealso.SelectedIndex == -1)
            {
                MessageBox.Show("삭제할 항목을 선택해주세요");
            }
            else
            {
                LB_Seealso.Items.RemoveAt(LB_Seealso.SelectedIndex);
            }

        }

        private void BT_Seealso_Submit_Click(object sender, EventArgs e)
        {
            Class_Additional_Function_Info data = new Class_Additional_Function_Info();

            data.id = prev_form.AddInfo_GetID();
            data.Info_type = (int)Class_Additional_Function_Info.enum_Info_Type.SeeAlso;

            for(int i =0;i<LB_Seealso.Items.Count;i++)
            {
                data.Seealso_ref_linklist.Add(LB_Seealso.Items[i]);
            }

            prev_form.AddInfo_AddData(data);
            prev_form.AddInfo_UpdateList();
            MessageBox.Show("추가 완료");
        }


        #endregion


        #region Example
        private void timer1_Tick(object sender, EventArgs e)
        {
            var wordWrappedIndex = RT_Example_Examplecode.SelectionStart;

            RichTextBox scratch = new RichTextBox();
            scratch.Lines = RT_Example_Examplecode.Lines;
            scratch.SelectionStart = wordWrappedIndex;
            scratch.SelectionLength = 1;
            scratch.WordWrap = false;

            var selectionStartIndex = scratch.SelectionStart;

            LB_Example_Linenumber.Text = (scratch.GetLineFromCharIndex(selectionStartIndex)+1).ToString();
        }

        #endregion

        private void BT_Example_Import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filepath = openFileDialog.FileName;

                    string text = System.IO.File.ReadAllText(filepath, System.Text.Encoding.GetEncoding(949)); //한글 깨짐 이슈 방지
                    RT_Example_Examplecode.AppendText(text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BT_Example_Submit_Click(object sender, EventArgs e)
        {
            Class_Additional_Function_Info data = new Class_Additional_Function_Info();

            data.id = prev_form.AddInfo_GetID();
            data.Info_type = (int)Class_Additional_Function_Info.enum_Info_Type.Example;

            data.example_code = RT_Example_Examplecode.Text;
            data.example_language = CB_Example_Language.SelectedIndex;

            string temp = TF_Example_Emphasize.Text;

            string[] temp2 = temp.Split(',');
            
            foreach(string str in temp2)
            {
                data.example_emphsizeline.Add(str.Trim());
            }

            prev_form.AddInfo_AddData(data);
            prev_form.AddInfo_UpdateList();
            MessageBox.Show("추가 완료");
        }
    }
}
