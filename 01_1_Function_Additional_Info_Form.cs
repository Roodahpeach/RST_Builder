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
        }

        public Function_Additional_Info_Form(_01_Function_Form form)
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            prev_form = form;
        }


        #endregion

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
        }
    }
}
