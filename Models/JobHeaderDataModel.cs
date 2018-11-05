using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SOViewer3.Models
{
    public class JobHeaderDataModel
    {
        public JobHeaderDataModel() { }
        public string ReferenceNo { get; set; } //
        public string Production_Schedule { get; set; } //
        public string Brand { get; set; }  //Not yet found
        public string Mfg_Plants { get; set; } //
        public string TX_MFG_Date { get; set; }// 
        public string TX_Ship_Date { get; set; } 
        public string Customer_Code { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Phone { get; set; }
        public string Job_Contact { get; set; }
        public string Shipping_Contact { get; set; }
        public string Shipping_Address { get; set; }
        public string Addendum_No { get; set; }
        public string Alternate_UPS_Shipment { get; set; }
        public string Architect_Address_2 { get; set; }
        public string Architect_Address {get; set;}
        public string Architect_City {get; set;}
        public string Architect_Code {get; set;}
        public string Architect_Contact_Code {get; set;}
        public string Architect_Contact_Email {get; set;}
        public string Architect_Contact_Fax_No {get; set;}
        public string Architect_Contact_Phone_No {get; set;}
        public string Architect_Country_Code {get; set;}
        public string Architect_Post_Code {get; set;}
        public string Architect {get; set;}
        public string Call_Before_Contact {get; set;}
        public string Call_Before_Email {get; set;}
        public string Call_Before_Phone_No{get; set;}
        public string Call_Before {get; set;}
        public string Contractor {get; set;}
        public string Customer_Quote_No { get; set; }
        public string Data_Version { get; set; }
        public string Date_Modified { get; set; }
        public string Document_Type { get; set; }
        public string Edit_Status { get; set; }
        public string Engineer_Address_2 { get; set; }
        public string Engineer_Address { get; set; }
        public string Engineer_City { get; set; }
        public string Engineer_Code { get; set; }
        public string Engineer_Contact_Email { get; set; }
        public string Engineer_Contact_Fax_No { get; set; }
        public string Engineer_Contact_Name { get; set; }
        public string Engineer_Contact_Phone_No { get; set; }
        public string Engineer_Country_Code { get; set; }
        public string Engineer_Post_Code { get; set; }
        public string Engineer { get; set; }
        public string FieldBool01 { get; set; }
        public string FieldBool02 { get; set; }
        public string FieldBool03 { get; set; }
        public string FieldBool04 { get; set; }
        public string FieldBool05 { get; set; }
        public string FieldDate01 { get; set; }
        public string FieldDate02 { get; set; }
        public string FieldDate03 { get; set; }
        public string FieldDate04 { get; set; }
        public string FieldDate05 { get; set; }
        public string FieldDec01 { get; set; }
        public string FieldDec02 { get; set; }
        public string FieldDec03 { get; set; }
        public string FieldDec04 { get; set; }
        public string FieldDec05 { get; set; }
        public string FieldDec06 { get; set; }
        public string FieldDec07 { get; set; }
        public string FieldDec08 { get; set; }
        public string FieldDec09 { get; set; }
        public string FieldDec10 { get; set; }
        public string FieldMemo01 { get; set; }
        public string FieldMemo02 { get; set; }
        public string FieldStr01 { get; set; }
        public string FieldStr02 { get; set; }
        public string FieldStr03 { get; set; }
        public string FieldStr04 { get; set; }
        public string FieldStr05 { get; set; }
        public string FieldStr06 { get; set; }
        public string FieldStr07 { get; set; }
        public string FieldStr08 { get; set; }
        public string FieldStr09 { get; set; }
        public string FieldStr10 { get; set; }
        public string Job_Markup { get; set; }
        public string Job_Value { get; set; }
        public string Load_Status { get; set; }
        public string LQN { get; set; }
        public string Markup_Multiplier { get; set; }
        public string Markup_Type { get; set; }
        public string Markup_Value { get; set; }
        public string Modified_By { get; set; }
        public string No { get; set; }
        public string Not_Before_Date { get; set; }
        public string Original_Reference_No { get; set; }
        public string PIP_ID { get; set; }
        public string Project_Location { get; set; }
        public string QSP_Priority { get; set; }
        public string QSP_Rate { get; set; }
        public string Release_No { get; set; }
        public string Release_Value { get; set; }
        public string Sell_to_Address2 { get; set; }
        public string Sell_to_Address { get; set; }
        public string Sell_to_City { get; set; }
        public string Sell_to_Contact_Email { get; set; }
        public string Sell_to_Contact_Fax_No { get; set; }
        public string Sell_to_Contact { get; set; }
        public string Sell_to_Country_Code { get; set; }
        public string Sell_to_Post_Code { get; set; }
        public string Shipping_Notes { get; set; }
        public string Ship_to_Address { get; set; }
        public string Ship_to_City { get; set; }
        public string Ship_to_Code { get; set; }
        public string Ship_to_Contact_Phone { get; set; }
        public string Ship_to_Contact { get; set; }
        public string Ship_to_Country_Code { get; set; }
        public string Ship_to_Post_Code { get; set; }
        public string Special_QSP_Amount_Percent { get; set; }
        public string Special_QSP_Amount { get; set; }
        public string Specification { get; set; }
        public string Status { get; set; }
        public string Unit_System { get; set; }
        public string version { get; set; }
        public string Jobname { get; set; }
        public string Ship_to_County { get; set; }
        public string System { get; set; }
        public string External_Document_No { get; set; }
        public string SpecsVersion { get; set; }
        /*Non Database items*/
        public List<File_Metadata> Invoice { get; set; }
        public List<File_Metadata> Packing_List { get; set; }
        public List<File_Metadata> BOL { get; set; }
        public List<File_Metadata> Credit_Memos { get; set; }
        public List<Cutsheet> Cutsheets { get; set; }
        public List<PullList> PullLists { get; set; }
        public List<File_Metadata> Labels { get; set; }
        public List<File_Metadata> Work_Order { get; set; }
        public List<File_Metadata> Pick_List { get; set; }
        public List<File_Metadata> Engineering_Document_Request { get; set; }
        public List<File_Metadata> Enginnering_Documents { get; set; }
        public List<File_Metadata> XML_Files { get; set; }
        public List<File_Metadata> PDF_Files { get; set; }
    }

    public class JobHeaderContext : DbContext
    {
        public JobHeaderContext()
            :base("name=JobHeaderContextConnection")
        {
        }
        public List<JobHeaderDataModel> JobHeaders { get; set; }
    }
    public class PullList
    {
        public string fileName { get; set; }
        public string fileDate { get; set; }
        public string filePath { get; set; }
        public string hyperlink { get; set; }

    }
    public class Cutsheet
    {
        public string fileName { get; set; }
        public string Model { get; set; }
        public string fileDate { get; set; }
        public string filePath { get; set; }
        public string hyperlink { get; set; }
    }
    public class File_Metadata
    {
        public string fileName { get; set; }
        public string fileDate { get; set; }
        public string filePath { get; set; }
    }
}