using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BHANSA_FrqMgmt
{
    public static class Shared_Data
    {
        // General Settings
        public static string Position_Name = "N/A";
        public static bool I_Am_Server = true;

        public static bool Is_Connected = false;

        public static bool Server_Client_Mode_Changed = false;

        public static bool New_Distribution_Requested = false;

        public static bool Update_Log_Window = false;
        public static bool Update_Main_Data_Display = false;
        public static bool Notify_Main_Display_Updated = false;

        public static List<string> Received_Data_List_From_CWP1 = new List<string>();
        public static List<string> Received_Data_List_From_CWP2 = new List<string>();
        public static List<string> Received_Data_List_From_CWP3 = new List<string>();

        public static List<string> Received_Data_List_From_Server = new List<string>();

        public static string Last_Data_Out = "";

        public static void Data_To_Distribute(string Data_String)
        {
            Last_Data_Out = Data_String;
        }

        public static bool CWP1_Connected = false;
        public static bool CWP2_Connected = false;
        public static bool CWP3_Connected = false;

        public static bool Initiate_Data_Distribution = false;

        //public enum CWP_Type { CWP1, CWP2, CWP3, Unknown };
        //public static CWP_Type Determine_CWP_Position(string Port_In)
        //{
        //    CWP_Type CWP_Out = CWP_Type.Unknown;

        //    if (Port_In == Properties.Settings.Default.CWP1_Port)
        //        CWP_Out = CWP_Type.CWP1;
        //    else if (Port_In == Properties.Settings.Default.CWP2_Port)
        //        CWP_Out = CWP_Type.CWP2;
        //    else if (Port_In == Properties.Settings.Default.CWP3_Port)
        //        CWP_Out = CWP_Type.CWP3;

        //    return CWP_Out;
        //}

        public class CWP_Update_Pair
        {
            public bool Updated_Succefully = false;
            public DateTime Last_Succefull_Update = DateTime.Now;
        }

        public static CWP_Update_Pair CWP1_Update_Status = new CWP_Update_Pair();
        public static CWP_Update_Pair CWP2_Update_Status = new CWP_Update_Pair();
        public static CWP_Update_Pair CWP3_Update_Status = new CWP_Update_Pair();
    }
}
