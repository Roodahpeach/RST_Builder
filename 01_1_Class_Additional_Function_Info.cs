using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RST_File_Generator
{
    public class Class_Additional_Function_Info
    {
        #region General
        public int id = -1;
        public int Info_type = -1;

        public enum enum_Info_Type
        {
            Common_Note,
            SeeAlso,
            Example
        }
        #endregion

        #region CommonNotes
        public enum enum_Common_Note_Type{
            Note,
            Warning,
            Hint
        }

        public int common_note_type = -1;
        public string common_description;

        #endregion



    }
}
