using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using SOViewer3.Models;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SOViewer3.Controllers
{

    public class HomeController : Controller
    {
        const string SERVER_Literal = "Server";
        const string DATABASE_Literal = "Database";
        const string UID_Literal = "Uid";
        const string PWD_Literal = "Pwd";
        const string SEMI_COLON = ";";
        const string WHITESPACE = " ";
        const string EQUAL = "=";
        string[] databases =
        {
            "dbo.AssignedDacNumber",
            "dbo.Company",
            "dbo.Contact",
            "dbo.DACDetail",
            "dbo.DACHeader",
            "dbo.DACHistory",
            "dbo.DACMultiplier",
            "dbo.DACOption",
            "dbo.GenerateDistributeFile",
            "dbo.GeneratedPDFDistribution",
            "dbo.JobDetail",
            "dbo.JobDetailHistory",
            "dbo.JobHeader",
            "dbo.JobHeaderHistory",
            "dbo.JobMultiplier",
            "dbo.JobMultiplierHIstory",
            "dbo.JobOption",
            "dbo.JobOptionHistory",
            "dbo.JobHeader",
            "dbo.JobHeaderHistory",
            "dbo.JobMultiplier",
            "dbo.JobMulitiplierHistory",
            "dbo.JobOption",
            "dbo.JobOptionHistory",
            "dbo.OptionDefault",
            "dbo.OrderNote",
            "dbo.ShipToAddress",
            "dbo.UserDefault"
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public virtual JsonResult Search2(string id)
        {
            string ServerName = "", Database = "", UID = "", PWD = "", connectionstr = "", table = "", Databases = "";
            ServerName = "pcidb1";
            Database = "pcidb";
            UID = "sa";
            PWD = "S1t2a3r4";
            Databases = "pcidb";
            table = "dbo.JobHeader";
            List<JobHeaderDataModel> model = new List<JobHeaderDataModel>();
            var jobheader = new JobHeaderDataModel();

            //Connection_setup(ref ServerName, ref Database, ref UID, ref PWD, ref Databases, ref table);
            connectionstr = SERVER_Literal + EQUAL + ServerName + SEMI_COLON + WHITESPACE +
                                   DATABASE_Literal + EQUAL + Database + SEMI_COLON + WHITESPACE +
                                   UID_Literal + EQUAL + UID + SEMI_COLON + WHITESPACE+
                                   PWD_Literal + EQUAL  + PWD + SEMI_COLON + WHITESPACE;
            SqlConnection sqlConnection = new SqlConnection(connectionstr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "[dbo].[SEARCH_ORDER]";
            cmd.Parameters.AddWithValue("@OrderNo", id);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                jobheader.ReferenceNo = reader["ReferenceNo"].ToString();
                jobheader.Production_Schedule = reader["Production_Schedule"].ToString();
                jobheader.Brand = "Pottorff";
                jobheader.Mfg_Plants = "Pottorff Texas";
                jobheader.TX_MFG_Date = reader["TX_MFG_Date"].ToString();
                jobheader.Customer_Code = reader["Customer_Code"].ToString();
                jobheader.Customer_Name = reader["Customer_Name"].ToString();
                jobheader.Customer_Phone = reader["Customer_Phone"].ToString();
                jobheader.Job_Contact = reader["Job_Contact"].ToString();
                jobheader.Shipping_Contact   = reader["Shipping_Contact"].ToString();
                jobheader.Shipping_Address = reader["Shipping_Address"].ToString();
                jobheader.Addendum_No = reader["Addendum_No"].ToString();
                jobheader.Alternate_UPS_Shipment = reader["Alternate_UPS_Shipment"].ToString();
                jobheader.Architect_Address_2 = reader["Architect_Address_2"].ToString();
                jobheader.Architect_Address = reader["Architect_Address"].ToString();
                jobheader.Architect_City = reader["Architect_City"].ToString();
                jobheader.Architect_Code = reader["Architect_Code"].ToString();
                jobheader.Architect_Contact_Code = reader["Architect_Contact_Code"].ToString();
                jobheader.Architect_Contact_Email = reader["Architect_Contact_Email"].ToString();
                jobheader.Architect_Contact_Fax_No = reader["Architect_Contact_Fax_No"].ToString();
                jobheader.Architect_Contact_Phone_No = reader["Architect_Contact_Phone_No"].ToString();
                jobheader.Architect_Country_Code = reader["Architect_Country_Code"].ToString();
                jobheader.Architect_Post_Code = reader["Architect_Post_Code"].ToString();
                jobheader.Architect = reader["Architect"].ToString();
                jobheader.Call_Before_Contact = reader["Call_Before_Contact"].ToString();
                jobheader.Call_Before_Email = reader["Call_Before_Email"].ToString();
                jobheader.Call_Before_Phone_No = reader["Call_Before_Phone_No"].ToString();
                jobheader.Call_Before = reader["Call_Before"].ToString();
                jobheader.Contractor = reader["Contractor"].ToString();
                jobheader.Customer_Quote_No = reader["Customer_Quote_No"].ToString();
                jobheader.Data_Version = reader["Data_Version"].ToString();
                jobheader.Date_Modified = reader["Date_Modified"].ToString();
                jobheader.Document_Type = reader["Document_Type"].ToString();
                jobheader.Edit_Status = reader["Edit_Status"].ToString();
                jobheader.Engineer_Address_2 = reader["Engineer_Address_2"].ToString();
                jobheader.Engineer_Address = reader["Engineer_Address"].ToString();
                jobheader.Engineer_City = reader["Engineer_City"].ToString();
                jobheader.Engineer_Code = reader["Engineer_Code"].ToString();
                jobheader.Engineer_Contact_Email = reader["Engineer_Contact_Email"].ToString();
                jobheader.Engineer_Contact_Fax_No = reader["Engineer_Contact_Fax_No"].ToString();
                jobheader.Engineer_Contact_Name = reader["Engineer_Contact_Name"].ToString();
                jobheader.Engineer_Contact_Phone_No = reader["Engineer_Contact_Phone_No"].ToString();
                jobheader.Engineer_Country_Code = reader["Engineer_Country_Code"].ToString();
                jobheader.Engineer_Post_Code = reader["Engineer_Post_Code"].ToString();
                jobheader.Engineer = reader["Engineer"].ToString();
                jobheader.FieldBool01 = reader["FieldBool01"].ToString();
                jobheader.FieldBool02 = reader["FieldBool02"].ToString();
                jobheader.FieldBool03 = reader["FieldBool03"].ToString();
                jobheader.FieldBool04 = reader["FieldBool04"].ToString();
                jobheader.FieldBool05 = reader["FieldBool05"].ToString();
                jobheader.FieldDate01 = reader["FieldDate01"].ToString();
                jobheader.FieldDate02 = reader["FieldDate02"].ToString();
                jobheader.FieldDate03 = reader["FieldDate03"].ToString();
                jobheader.FieldDate04 = reader["FieldDate04"].ToString();
                jobheader.FieldDate05 = reader["FieldDate05"].ToString();
                jobheader.FieldDec01 = reader["FieldDec01"].ToString();
                jobheader.FieldDec02 = reader["FieldDec02"].ToString();
                jobheader.FieldDec03 = reader["FieldDec03"].ToString();
                jobheader.FieldDec04 = reader["FieldDec04"].ToString();
                jobheader.FieldDec05 = reader["FieldDec05"].ToString();
                jobheader.FieldDec06 = reader["FieldDec06"].ToString();
                jobheader.FieldDec07 = reader["FieldDec07"].ToString();
                jobheader.FieldDec08 = reader["FieldDec08"].ToString();
                jobheader.FieldDec09 = reader["FieldDec09"].ToString();
                jobheader.FieldDec10 = reader["FieldDec10"].ToString();
                jobheader.FieldMemo01 = reader["FieldMemo01"].ToString();
                jobheader.FieldMemo02 = reader["FieldMemo02"].ToString();
                jobheader.FieldStr01 = reader["FieldStr01"].ToString();
                jobheader.FieldStr02 = reader["FieldStr02"].ToString();
                jobheader.FieldStr03 = reader["FieldStr03"].ToString();
                jobheader.FieldStr04 = reader["FieldStr04"].ToString();
                jobheader.FieldStr05 = reader["FieldStr05"].ToString();
                jobheader.FieldStr06 = reader["FieldStr06"].ToString();
                jobheader.FieldStr07 = reader["FieldStr07"].ToString();
                jobheader.FieldStr08 = reader["FieldStr08"].ToString();
                jobheader.FieldStr09 = reader["FieldStr09"].ToString();
                jobheader.FieldStr10 = reader["FieldStr10"].ToString();
                jobheader.Job_Markup = reader["Job_Markup"].ToString();
                jobheader.Job_Value = reader["Job_Value"].ToString();
                jobheader.Load_Status = reader["Load_Status"].ToString();
                jobheader.LQN = reader["LQN"].ToString();
                jobheader.Markup_Multiplier = reader["Markup_Multiplier"].ToString();
                jobheader.Markup_Type = reader["Markup_Type"].ToString();
                jobheader.Markup_Value = reader["Markup_Value"].ToString();
                jobheader.Modified_By = reader["Modified_By"].ToString();
                jobheader.No = reader["No"].ToString();
                jobheader.Not_Before_Date = reader["Not_Before_Date"].ToString();
                jobheader.Original_Reference_No = reader["Original_Reference_No"].ToString();
                jobheader.PIP_ID = reader["PIP_ID"].ToString();
                jobheader.Project_Location = reader["Project_Location"].ToString();
                jobheader.QSP_Priority = reader["QSP_Priority"].ToString();
                jobheader.QSP_Rate = reader["QSP_Rate"].ToString();
                jobheader.Release_No = reader["Release_No"].ToString();
                jobheader.Release_Value = reader["Release_Value"].ToString();
                jobheader.Sell_to_Address2 = reader["Sell_to_Address2"].ToString();
                jobheader.Sell_to_Address = reader["Sell_to_Address"].ToString();
                jobheader.Sell_to_City = reader["Sell_to_City"].ToString();
                jobheader.Sell_to_Contact_Email = reader["Sell_to_Contact_Email"].ToString();
                jobheader.Sell_to_Contact_Fax_No = reader["Sell_to_Contact_Fax_No"].ToString();
                jobheader.Sell_to_Contact = reader["Sell_to_Contact"].ToString();
                jobheader.Sell_to_Country_Code = reader["Sell_to_Country_Code"].ToString();
                jobheader.Sell_to_Post_Code = reader["Sell_to_Post_Code"].ToString();
                jobheader.Shipping_Notes = reader["Shipping_Notes"].ToString();
                jobheader.Ship_to_Address = reader["Ship_to_Address"].ToString();
                jobheader.Ship_to_City = reader["Ship_to_City"].ToString();
                jobheader.Ship_to_Code = reader["Ship_to_Code"].ToString();
                jobheader.Ship_to_Contact_Phone = reader["Ship_to_Contact_Phone"].ToString();
                jobheader.Ship_to_Contact = reader["Ship_to_Contact"].ToString();
                jobheader.Ship_to_Country_Code = reader["Ship_to_Country_Code"].ToString();
                jobheader.Ship_to_Post_Code = reader["Ship_to_Post_Code"].ToString();
                jobheader.Special_QSP_Amount_Percent = reader["Special_QSP_Amount_Percent"].ToString();
                jobheader.Special_QSP_Amount = reader["Special_QSP_Amount"].ToString();
                jobheader.Specification = reader["Specification"].ToString();
                jobheader.Status = reader["Status"].ToString();
                jobheader.Unit_System = reader["Unit_System"].ToString();
                jobheader.version = reader["version"].ToString();
                jobheader.Jobname = reader["Jobname"].ToString();
                jobheader.Ship_to_County = reader["Ship_to_County"].ToString();
                jobheader.System = reader["System"].ToString();
                jobheader.External_Document_No = reader["External_Document_No"].ToString();
                jobheader.SpecsVersion = reader["SpecsVersion"].ToString();
            }
            sqlConnection.Close();
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Task getxmlfiles = Task.Factory.StartNew(() => Get_XMLFiles(id, ref jobheader));
            Task getcutsheets = Task.Factory.StartNew(() => Get_Cutsheets(id, ref jobheader));
            Task getpulllist = Task.Factory.StartNew(() => Get_PullList(id, ref jobheader));
            Task.WaitAll(getxmlfiles, getcutsheets, getpulllist);
            //Get_XMLFiles(id, ref jobheader);
            //Get_Cutsheets(id, ref jobheader);
            //Get_PullList(id, ref jobheader);
            watch.Stop();
            var x = watch.ElapsedMilliseconds;


            //Get_XMLFiles(id, ref jobheader);
            //Get_Cutsheets(id, ref jobheader);
            //Task.WaitAll(xmlfiles_Task, get_Cutsheets_Task);
            model.Add(jobheader);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        //public void Get_ShopOrders(string SalesNumber, ref JobHeaderDataModel jobheader)
        //{
        //    string lstrTXLink = "http://pcinet/ShopOrders/GetOrder.aspx?TX=true&SpecsCS=true&SalesOrder=" + SalesNumber; //Link number 1
        //    string lstrTALink = "http://pcinet/ShopOrders/GetOrder.aspx?TA=true&SpecsCS=true&SalesOrder=" + SalesNumber;
        //    string lstrCALink = "http://pcinet/ShopOrders/GetOrder.aspx?CA=true&SpecsCS=true&SalesOrder=" + SalesNumber;
        //    string lstrLVRLink = "http://pcinet/ShopOrders/GetOrder.aspx?SalesOrder=" + SalesNumber + "&SpecsCS=true";
        //}
       
        public void Get_PullList(string SalesNumber, ref JobHeaderDataModel jobheader)
        {
            string dir = @"\\pcinet\wwwroot\ShopOrders\CSFiles\ICS\Cutsheets";
            System.IO.DirectoryInfo path1 = new System.IO.DirectoryInfo(dir);
            List<PullList> PullLists = new List<PullList>();
            PullList singlepulllist= new PullList();
            foreach (System.IO.FileInfo fi in path1.GetFiles(SalesNumber + "*.pdf").Where(x => x.Extension == "PullList.pdf"))
            {
                singlepulllist.fileName = Convert.ToString(fi.Name);
                singlepulllist.fileDate = Convert.ToString(fi.CreationTime);
                singlepulllist.filePath = Convert.ToString(fi.DirectoryName);
                singlepulllist.hyperlink = "http://pcinet/ShopOrders/CSFiles/ICS/Cutsheets/" + fi.Name;
                PullLists.Add(singlepulllist);
            }
            jobheader.PullLists = PullLists;
        }


        public void Get_Cutsheets (string SalesNumber, ref JobHeaderDataModel jobheader )
        {
            string dir = @"\\pcinet\wwwroot\ShopOrders\CSFiles\ICS\Cutsheets";
            //string dir = @"\\pcinet\wwwroot\ShopOrders\CSFiles\SO\";
            System.IO.DirectoryInfo path1 = new System.IO.DirectoryInfo(dir);
            List<Cutsheet> Cutsheets = new List<Cutsheet>();
            //Cutsheet singleCutsheet = new Cutsheet();
            string vendorList = "VendorList";
            string pulllist = "PullList";
            string prepsheet = "Prepsheet";
            string filename = "";
            string fileCreationTime = "";
            string fileDirectoryName = "";
            string link = "http://pcinet/ShopOrders/CSFiles/ICS/Cutsheets/";
            foreach (System.IO.FileInfo fi in path1.GetFiles(SalesNumber + "*.pdf")) //.Where(x => (!(x.Name.EndsWith("PullList.pdf")) ))) //&& !(x.Name.EndsWith("VendorList.pdf")) && !(x.Name.EndsWith("Prepsheet.pdf"))))  )
            {
                filename = Convert.ToString(fi.Name);
                fileCreationTime = Convert.ToString(fi.CreationTime);
                fileDirectoryName = Convert.ToString(fi.DirectoryName);
                if( (filename.Contains(vendorList)) || (filename.Contains(pulllist)) || (filename.Contains(prepsheet)) )
                {
                }
                else
                {
                    Cutsheet singleCutsheet = new Cutsheet();
                    singleCutsheet.fileName = Convert.ToString(filename);
                    singleCutsheet.Model = GetModel(filename);
                    singleCutsheet.fileDate = Convert.ToString(fileCreationTime);
                    singleCutsheet.filePath = Convert.ToString(fileDirectoryName);
                    singleCutsheet.hyperlink = link + filename;
                    Cutsheets.Add(singleCutsheet);
                }
                
                //singleCutsheet.fileName = Convert.ToString(fi.Name);
                //singleCutsheet.fileDate = Convert.ToString(fi.CreationTime);
                //singleCutsheet.filePath = Convert.ToString(fi.DirectoryName);
                //singleCutsheet.hyperlink = "http://pcinet/ShopOrders/CSFiles/ICS/Cutsheets/" + fi.Name;
                //singleCutsheet.hyperlink = "http://pcinet/ShopOrders/CSFiles/SO/" + fi.Name;
                //Cutsheets.Add(singleCutsheet);
            }
            jobheader.Cutsheets = Cutsheets;
            
        }
        public string GetModel(string fileName)
        {
            string[] chunks = fileName.Split('.');
            return chunks[1]; 
        }
        public void Get_XMLFiles (  string SalesNumber, 
                                    ref JobHeaderDataModel jobheader
                                 )
        {
            string dir1 = @"\\skywalker\skyc\";
            string dir2 = @"\\pcidb2\C\";
            string dir3 = @"\\websvcs\SuccessedRelease\";
            string dir4 = @"\\server06\xmlArchive$\";


            System.IO.DirectoryInfo path1 = new System.IO.DirectoryInfo(dir1);
            System.IO.DirectoryInfo path2 = new System.IO.DirectoryInfo(dir2);
            System.IO.DirectoryInfo path3 = new System.IO.DirectoryInfo(dir3);
            System.IO.DirectoryInfo path4 = new System.IO.DirectoryInfo(dir4);

            List<string> files = new List<string>();
            List<File_Metadata> thisxmlfile = new List<File_Metadata>();
            foreach (System.IO.FileInfo fi in path1.GetFiles("*" + SalesNumber + "*.xml"))
            {
                File_Metadata single = new File_Metadata();
                single.fileName = Convert.ToString(fi.Name);
                single.fileDate = Convert.ToString(fi.CreationTime);
                single.filePath = Convert.ToString(fi.DirectoryName);
                thisxmlfile.Add(single);
            }

            foreach (System.IO.FileInfo fi in path2.GetFiles("*" + SalesNumber + "*.xml"))
            {
                File_Metadata single = new File_Metadata();
                single.fileName = Convert.ToString(fi.Name);
                single.fileDate = Convert.ToString(fi.CreationTime);
                single.filePath = Convert.ToString(fi.DirectoryName);
                thisxmlfile.Add(single);
            }
            foreach (System.IO.FileInfo fi in path3.GetFiles("DAC-DATA*" + "-" + "*" + "-" + "*" + SalesNumber + "*.xml"))
            {
                File_Metadata single = new File_Metadata();
                single.fileName = Convert.ToString(fi.Name);
                single.fileDate = Convert.ToString(fi.CreationTime);
                single.filePath = Convert.ToString(fi.DirectoryName);
                thisxmlfile.Add(single);
            }
            foreach (System.IO.FileInfo fi in path4.GetFiles("*" + SalesNumber + "*.xml"))
            {
                File_Metadata single = new File_Metadata();
                single.fileName = Convert.ToString(fi.Name);
                single.fileDate = Convert.ToString(fi.CreationTime);
                single.filePath = Convert.ToString(fi.DirectoryName);
                thisxmlfile.Add(single);
            }
            jobheader.XML_Files = thisxmlfile;  
        } 
        public ActionResult GetXMLDownload( string fileName, 
                                            string Dir
                                          )
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Dir + fileName);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        private static void Connection_setup( ref string ServerName, 
                                              ref string Database,
                                              ref string UID, 
                                              ref string PWD, 
                                              ref string Databases, 
                                              ref string table
                                            )
        {
            ServerName = "pcidb1"; 
            Database = "SPECs3DB";
            UID = "sa";
            PWD = "S1t2a3r4"; 
            Databases = "SPECs3DB";
            table = "dbo.JobHeader";

        }
    }
}