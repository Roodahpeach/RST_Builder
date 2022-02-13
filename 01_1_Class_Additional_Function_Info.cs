using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RST_File_Generator
{
    public class Class_Additional_Function_Info
    {
        #region General
        public const int NO_DATA = -99;

        public int id = NO_DATA;
        public int Info_type = NO_DATA;

        public enum enum_Info_Type
        {
            Common_Note,
            SeeAlso,
            Example,
            Image
        }
        #endregion

        #region CommonNotes
        public enum enum_Common_Note_Type{
            Note,
            Warning,
            Hint
        }

        public int common_note_type = NO_DATA;
        public string common_description;

        #endregion

        #region SeeAlso

        public ArrayList Seealso_ref_linklist = new ArrayList();

        #endregion

        #region Example
        public enum enum_Example_Language
        {
            CPP,
            CSharp,
            Delphi,
            VB
        }

        public string example_code;
        public int example_language = NO_DATA;
        public ArrayList example_emphsizeline = new ArrayList();
        #endregion
    }
}
