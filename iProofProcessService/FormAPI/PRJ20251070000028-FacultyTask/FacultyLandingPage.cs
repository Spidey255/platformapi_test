  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class FacultyLandingPageProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 30254; }
        }

        public override string PackageName
        {
            get { return "PRJ20251070000028-Faculty Task"; }
        }

		public override string PackageDescription
        {
            get { return "The Faculty Task Module is designed to streamline and manage academic and administrative responsibilities assigned to faculty members. This module enables institutions to allocate tasks such as teaching assignments, assessment duties, academic planning, committee work, research activities, and other institutional responsibilities in an organized manner. Faculty members can view assigned tasks, track progress, meet deadlines, and submit required updates or reports through a centralized platform. The module promotes transparency, accountability, and efficient workload management while supporting effective communication between faculty and academic administration."; }
        }

        public override string ProcessId
        {
            get { return "8f1f8561-e4cd-4484-87be-c2264ba41fce"; }
        }

        public override string ProcessName
        {
            get { return "FacultyLandingPage"; }
        }

		public override string ProcessDescription
        {
            get { return "The Faculty Landing Page serves as the central dashboard for faculty members, providing quick access to academic, administrative, and institutional activities. It offers an organized overview of teaching schedules, assigned tasks, courses, student information, assessments, announcements, and pending actions. Designed for ease of use, the landing page helps faculty manage their responsibilities efficiently, stay informed of updates, and navigate key modules seamlessly, supporting effective teachi"; }
        }

        public override ProcessType ProcessType
        {
            get { return ProcessType.RuleBased; }
        }

      

		public override string FileGroupId
        {
            get { return "C8BA2E2C-CB74-4616-9139-B32125B1C0A1"; }
        } 

		public override string FileGroup
        {
            get { return "Default"; }
        } 
		
        public override string PackageProcessMapId
        {
            get {return "8f1f8561-e4cd-4484-87be-c2264ba41fce";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "C17588AD-F62E-4533-85AC-5E0F51664240";	}
        }
			
        public override string Comments => throw new NotImplementedException();
		
		
	}
}
 





namespace CPS.Proof.DFSExtension
{
	using System;
	using System.Collections.Concurrent;
    using System.Collections.Generic;    	
	using CPS.Proof.DFSExtension;
	

	public partial class FacultyLandingPageObjectFactory  : ExtObjectFactoryBase
    {		
       	
		
		
	
		public override Dictionary<string, string> GetQueryExpressionDataSource(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			 return null;
			}

			Dictionary<string, string> data;

            data = new Dictionary<string, string>();
            foreach (Triplet<string, string, string> exp in queryExpressionData)
            {
                if (exp.FirstValue == expressionId)
                {
                    var unknown = new
                    {
                        name = exp.SecondValue, constring = exp.ThirdValue
                    };
                    data.Add(unknown.name, unknown.constring);
                }
            }

			return data;

		}

		//public override IExtBaseMetaData GetProcessInstance(string packageProcessMapId)
       // {
        //    return (IExtBaseMetaData)new FacultyLandingPageProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("21045A8D-C3B3-4EB2-A04F-3D78BDF29961","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("049805BA-6D15-4573-8885-3C0C5ADC4F1B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("E90068F8-1DB3-482D-A081-B2CB52A9B50E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("595A4593-D895-4EA8-A718-7F6FE57BAD2A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("21045A8D-C3B3-4EB2-A04F-3D78BDF29961","Purchase LOAD Sp",
												     @"E18438EB-FCDE-49B7-9DB1-B0A82B057C94"),
			
						
			     new Triplet<string, string, string>("049805BA-6D15-4573-8885-3C0C5ADC4F1B","Load Repeater Grid",
												     @"9A6AD4A4-8A9D-4419-ABEE-9E5D860CEA65"),
			
						
			     new Triplet<string, string, string>("E90068F8-1DB3-482D-A081-B2CB52A9B50E","User Details Load",
												     @"B2763A89-5336-441E-95BE-147833F2364F"),
			
						
			     new Triplet<string, string, string>("595A4593-D895-4EA8-A718-7F6FE57BAD2A","MyCourses",
												     @"DE78F655-BE29-4D42-895C-1E8760446E8C"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
		};
		
		public override Tuple<string, string> GetComboDataSource(string ElementName)
		{
			foreach (Triplet<string, string, string> cmbDS in ComboDataSource)
            {
				if(cmbDS.FirstValue==ElementName)
				{
					return new Tuple<string,string>(
							cmbDS.SecondValue,
							cmbDS.ThirdValue
						);
				}
			}
			return null;
		}

	
		private List<Tuple<string, int>> GridRowsPerPage = new List<Tuple< string, int>>
		{
		
	  			
			     new Tuple<string, int>("PurchaseDetails",5),
			
						
			     new Tuple<string, int>("PurchaseDetails",5),
			
						
			     new Tuple<string, int>("MyStudents",5),
			
						
			     new Tuple<string, int>("MyStudents",5),
			
						
			     new Tuple<string, int>("MG_Myprofile",5),
			
						
			     new Tuple<string, int>("MG_Myprofile",5),
			
						
			     new Tuple<string, int>("MyCoursesDetails",5),
			
						
			     new Tuple<string, int>("MyCoursesDetails",5),
			
						
			     new Tuple<string, int>("MyStudents",5),
			
						
			     new Tuple<string, int>("MyStudents",5),
			
						
		};

	   public override int GetGridRPP(string ElementName)
		{
			foreach (Tuple<string, int> grids in GridRowsPerPage)
            {
				if(grids.Item1==ElementName)
				{
					return Convert.ToInt32(grids.Item2);
				}
			}
			return 5;
		}



		public override IVirtualPage GetDfsVirtualInstance(string processActivityMapId)   
		{
			IVirtualPage virtualInstnace = GetVirtualInstnace(processActivityMapId);				

			return virtualInstnace;
		} 

	


		private IVirtualPage GetVirtualInstnace(string processActivityMapId)
		{
				

			
			
			IVirtualPage virtualInstance = null;
			

			switch(processActivityMapId)	
				{
											case "676395B9-A408-4102-B650-297FAB839973":
							virtualInstance=new ISpace676395B9A4084102B650297FAB839973();
							break;
					
					
					default:
						break;
				}
			
			
						

			return virtualInstance;	
		}

	}
}	
  











namespace CPS.Proof.DFSExtension
{
	using System;	
    using System.Collections.Generic;      		
	using System.Transactions;
    using log4net;
    using Newtonsoft.Json.Linq;
	

	public partial class FacultyLandingPageDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public FacultyLandingPageDataElementFactory()
        {
            _sysLog = LogManager.GetLogger(GetType());
        }			

		

          public override string GetInsertFormDataQuery(string instanceId, string packageProcessMapId, string processActivityMapId,
          string formId, long usermapid, string formJsonData)
        {
            _sysLog.Debug("Entering  GetInsertFormDataQuery");

            try
            {


                string colValues = string.Empty;

                string UpdatecolValues = string.Empty;

                string[] splitcols = null;

                string colList = string.Empty;

                string fInsertQuery = string.Empty;            

                switch(formId)
                {

               
                
                                      case "C17588AD-F62E-4533-85AC-5E0F51664240":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [C17588AD-F62E-4533-85AC-5E0F51664240] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [C17588AD-F62E-4533-85AC-5E0F51664240](InstanceId,ProcessActivityMapId,FormId,uname,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,M_MyCourseCount,M_MyMenteesCount,M_MyProfileCount,M_MyProjectCount,M_MyPurchaseCount,M_MyStudents,M_TaskCount)  
       VALUES( {3}) END ELSE BEGIN UPDATE [C17588AD-F62E-4533-85AC-5E0F51664240]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,uname,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,M_MyCourseCount,M_MyMenteesCount,M_MyProfileCount,M_MyProjectCount,M_MyPurchaseCount,M_MyStudents,M_TaskCount";
                                    
                     
                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData);


                            foreach (var fcol in splitcols)
                            {
                                if (fcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (fcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                                }

                                else if (fcol == "FormId")
                                {
                                    colValues += "'" + formId + "',";
                                    continue;
                                }

                                bool isFound = false;

                                foreach(var childObject in (JArray)parentObject["Child"])
                                {

                                    if (childObject["ElementName"].ToString() == fcol)
                                    {
                                        isFound = true;

                                         if (childObject["Value"] == null)
                                        {
                                          
                                            colValues += "null,";
                                            UpdatecolValues += fcol + "=" + "null,";
                                            break;
                                        }

                                        switch (Convert.ToInt32(childObject["EDT"]))
                                        {
                                            case 8:
                                            case 9:
                                                colValues += "'" + childObject["Value"].ToString() + "',";
                                                UpdatecolValues+=fcol+"="+"'" + childObject["Value"].ToString() + "',";
                                                break;

                                            default:
                                                if (childObject["Value"] != null)
                                                {
                                                    colValues += childObject["Value"].ToString() + ",";
                                                    UpdatecolValues += fcol + "=" + childObject["Value"].ToString() + ",";
                                                }
                                                else
                                                {
                                                    colValues += "null,";
                                                    UpdatecolValues += fcol + "=" + "null,";
                                                }
                                                 break;
                                        }

                                       
                                    }
                                }

                                 if(!isFound)
                                {
                                    colValues += "null,";
                                    UpdatecolValues += fcol + "=" + "null,";
                                }

                            }
                            colValues = colValues.Remove(colValues.Length - 1);
                            UpdatecolValues = UpdatecolValues.Remove(colValues.Length - 1);

                            fInsertQuery =  string.Format(fInsertQuery,instanceId,processActivityMapId,formId, colValues,UpdatecolValues);

                            colValues = string.Empty;

                            break;
                        }
                
                       
                               

                 }
                return fInsertQuery;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  GetInsertFormDataQuery", ex);

                return null;
            }
            _sysLog.Debug("Exiting GetInsertFormDataQuery");
        }

           public override string GetInsertGridDataQuery(string instanceId,string packageProcessMapId,string processActivityMapId,
            string gridId,long usermapid,string formJsonData)
      {
        _sysLog.Debug("Entering  InsertGridData");
        
        try
        {                
                  

                     string colValues = string.Empty;

                     string[] splitcols=null;

                     string colList=string.Empty;

                     string gInsertQuery=string.Empty;

                     string tempInsertQuery=string.Empty;

                     string bulkInsertQuery = string.Empty;

                      switch(gridId)
                {

                
                 
                                      case "B2763A89-5336-441E-95BE-147833F2364F":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_B2763A895336441E95BE147833F2364F AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [B2763A89-5336-441E-95BE-147833F2364F](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_B2763A895336441E95BE147833F2364F TDT
							LEFT JOIN [B2763A89-5336-441E-95BE-147833F2364F] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_B2763A895336441E95BE147833F2364F(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                            colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "9A6AD4A4-8A9D-4419-ABEE-9E5D860CEA65":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_9A6AD4A48A9D4419ABEE9E5D860CEA65 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [9A6AD4A4-8A9D-4419-ABEE-9E5D860CEA65](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_9A6AD4A48A9D4419ABEE9E5D860CEA65 TDT
							LEFT JOIN [9A6AD4A4-8A9D-4419-ABEE-9E5D860CEA65] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_9A6AD4A48A9D4419ABEE9E5D860CEA65(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                            colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "E18438EB-FCDE-49B7-9DB1-B0A82B057C94":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_E18438EBFCDE49B79DB1B0A82B057C94 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [E18438EB-FCDE-49B7-9DB1-B0A82B057C94](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_E18438EBFCDE49B79DB1B0A82B057C94 TDT
							LEFT JOIN [E18438EB-FCDE-49B7-9DB1-B0A82B057C94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_E18438EBFCDE49B79DB1B0A82B057C94(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                            colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "DE78F655-BE29-4D42-895C-1E8760446E8C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_DE78F655BE294D42895C1E8760446E8C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [DE78F655-BE29-4D42-895C-1E8760446E8C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_DE78F655BE294D42895C1E8760446E8C TDT
							LEFT JOIN [DE78F655-BE29-4D42-895C-1E8760446E8C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_DE78F655BE294D42895C1E8760446E8C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                            colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                 
                 }       
                

                 return string.Format(gInsertQuery, bulkInsertQuery);

        }
        catch(Exception ex)
        {
            _sysLog.Error("Error in  InsertGridData",ex);

            return null;
        }
        _sysLog.Debug("Exiting InsertGridData");
      }


      public override string GetGridLoopQuery(string gridId,string gridName,Dictionary<string,ServiceElementData> gridData)
        {
            _sysLog.Debug("Entering GetGridLoopQuery");

            try
            {

                string colValues = string.Empty;

                string[] splitcols = null;

                string colList = string.Empty;

                string gInsertQuery = string.Empty;

                string tempInsertQuery = string.Empty;

                string bulkInsertQuery = string.Empty;

                string instanceId = gridData["InstanceId"].Value;

                string processActivityMapId = gridData["gv_activitymapid"].Value;

             
                switch (gridId)
                {
                     

                                         case "B2763A89-5336-441E-95BE-147833F2364F":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_B2763A895336441E95BE147833F2364F AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [B2763A89-5336-441E-95BE-147833F2364F](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_B2763A895336441E95BE147833F2364F TDT
							LEFT JOIN [B2763A89-5336-441E-95BE-147833F2364F] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_B2763A895336441E95BE147833F2364F(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "9A6AD4A4-8A9D-4419-ABEE-9E5D860CEA65":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_9A6AD4A48A9D4419ABEE9E5D860CEA65 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [9A6AD4A4-8A9D-4419-ABEE-9E5D860CEA65](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_9A6AD4A48A9D4419ABEE9E5D860CEA65 TDT
							LEFT JOIN [9A6AD4A4-8A9D-4419-ABEE-9E5D860CEA65] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_9A6AD4A48A9D4419ABEE9E5D860CEA65(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "E18438EB-FCDE-49B7-9DB1-B0A82B057C94":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_E18438EBFCDE49B79DB1B0A82B057C94 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [E18438EB-FCDE-49B7-9DB1-B0A82B057C94](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_E18438EBFCDE49B79DB1B0A82B057C94 TDT
							LEFT JOIN [E18438EB-FCDE-49B7-9DB1-B0A82B057C94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_E18438EBFCDE49B79DB1B0A82B057C94(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "DE78F655-BE29-4D42-895C-1E8760446E8C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_DE78F655BE294D42895C1E8760446E8C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [DE78F655-BE29-4D42-895C-1E8760446E8C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_DE78F655BE294D42895C1E8760446E8C TDT
							LEFT JOIN [DE78F655-BE29-4D42-895C-1E8760446E8C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_DE78F655BE294D42895C1E8760446E8C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                          }

                         

                return bulkInsertQuery;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  GetGridLoopQuery", ex);

                return null;
            }
           
        }


	}
}

namespace CPS.Proof.DFSExtension
{

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpace676395B9A4084102B650297FAB839973 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace676395B9A4084102B650297FAB839973 acdataIspace676395B9A4084102B650297FAB839973=new AcDataISpace676395B9A4084102B650297FAB839973();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_MyCourseCount"].Value=10;
base.WriteDebugInfo(@"ISpace[""M_MyCourseCount""].Value=10;");
ISpace["M_MyMenteesCount"].Value=9;
base.WriteDebugInfo(@"ISpace[""M_MyMenteesCount""].Value=9;");
ISpace["M_MyProfileCount"].Value=2;
base.WriteDebugInfo(@"ISpace[""M_MyProfileCount""].Value=2;");
ISpace["M_MyProjectCount"].Value=15;
base.WriteDebugInfo(@"ISpace[""M_MyProjectCount""].Value=15;");
ISpace["M_MyPurchaseCount"].Value=10;
base.WriteDebugInfo(@"ISpace[""M_MyPurchaseCount""].Value=10;");
ISpace["M_MyStudents"].Value=16;
base.WriteDebugInfo(@"ISpace[""M_MyStudents""].Value=16;");
ISpace["M_TaskCount"].Value=1000;
base.WriteDebugInfo(@"ISpace[""M_TaskCount""].Value=1000;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource049805BA6D15457388853C0C5ADC4F1B =GetQueryExpressionDataSource("049805BA-6D15-4573-8885-3C0C5ADC4F1B");

DataTable result049805BA6D15457388853C0C5ADC4F1B=iSpace.SetGridDataSource(querySource049805BA6D15457388853C0C5ADC4F1B, _objectFactory.GetGridRPP("MyStudents"),@"EXEC GetFL_MyStudents '" + ISpace["uname"].Value + @"'");

iSpace.InsertGridBindDetails("MyStudents","11",querySource049805BA6D15457388853C0C5ADC4F1B,"EXEC GetFL_MyStudents '" + ISpace["uname"].Value + @"'",_objectFactory.GetGridRPP("MyStudents"));

base.WriteDebugInfo(@"var querySource049805BA6D15457388853C0C5ADC4F1B =GetQueryExpressionDataSource(""049805BA-6D15-4573-8885-3C0C5ADC4F1B"");DataTable result049805BA6D15457388853C0C5ADC4F1B=iSpace.SetGridDataSource(querySource049805BA6D15457388853C0C5ADC4F1B, _objectFactory.GetGridRPP(""MyStudents""),@""EXEC GetFL_MyStudents '"" + ISpace[""uname""].Value + @""'"");iSpace.InsertGridBindDetails(""MyStudents"",""11"",querySource049805BA6D15457388853C0C5ADC4F1B,""EXEC GetFL_MyStudents '"" + ISpace[""uname""].Value + @""'"",_objectFactory.GetGridRPP(""MyStudents""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result51C633D528A147E4B21BAC5324D2286A=acdataIspace676395B9A4084102B650297FAB839973.GetQueryExpressionBindings("51C633D5-28A1-47E4-B21B-AC5324D2286A");
iSpace.SetGridData(result049805BA6D15457388853C0C5ADC4F1B,result51C633D528A147E4B21BAC5324D2286A,"MyStudents",ref ISpace);
iSpace.UpdateGridBindDetails("MyStudents",result51C633D528A147E4B21BAC5324D2286A);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource595A4593D8954EA8A7187F6FE57BAD2A =GetQueryExpressionDataSource("595A4593-D895-4EA8-A718-7F6FE57BAD2A");

DataTable result595A4593D8954EA8A7187F6FE57BAD2A=iSpace.SetGridDataSource(querySource595A4593D8954EA8A7187F6FE57BAD2A, _objectFactory.GetGridRPP("MyCoursesDetails"),@"exec GetFL_MyCourses '" + ISpace["uname"].Value + @"'");

iSpace.InsertGridBindDetails("MyCoursesDetails","11",querySource595A4593D8954EA8A7187F6FE57BAD2A,"exec GetFL_MyCourses '" + ISpace["uname"].Value + @"'",_objectFactory.GetGridRPP("MyCoursesDetails"));

base.WriteDebugInfo(@"var querySource595A4593D8954EA8A7187F6FE57BAD2A =GetQueryExpressionDataSource(""595A4593-D895-4EA8-A718-7F6FE57BAD2A"");DataTable result595A4593D8954EA8A7187F6FE57BAD2A=iSpace.SetGridDataSource(querySource595A4593D8954EA8A7187F6FE57BAD2A, _objectFactory.GetGridRPP(""MyCoursesDetails""),@""exec GetFL_MyCourses '"" + ISpace[""uname""].Value + @""'"");iSpace.InsertGridBindDetails(""MyCoursesDetails"",""11"",querySource595A4593D8954EA8A7187F6FE57BAD2A,""exec GetFL_MyCourses '"" + ISpace[""uname""].Value + @""'"",_objectFactory.GetGridRPP(""MyCoursesDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultF5F1BBAC4DF44ADBA2BF41821E1B1C83=acdataIspace676395B9A4084102B650297FAB839973.GetQueryExpressionBindings("F5F1BBAC-4DF4-4ADB-A2BF-41821E1B1C83");
iSpace.SetGridData(result595A4593D8954EA8A7187F6FE57BAD2A,resultF5F1BBAC4DF44ADBA2BF41821E1B1C83,"MyCoursesDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MyCoursesDetails",resultF5F1BBAC4DF44ADBA2BF41821E1B1C83);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceE90068F81DB3482DA081B2CB52A9B50E =GetQueryExpressionDataSource("E90068F8-1DB3-482D-A081-B2CB52A9B50E");

DataTable resultE90068F81DB3482DA081B2CB52A9B50E=iSpace.SetGridDataSource(querySourceE90068F81DB3482DA081B2CB52A9B50E, _objectFactory.GetGridRPP("MG_Myprofile"),@"EXEC GetEmployeeATOMDetailsbyEmployeeId 'AR12'");

iSpace.InsertGridBindDetails("MG_Myprofile","11",querySourceE90068F81DB3482DA081B2CB52A9B50E,"EXEC GetEmployeeATOMDetailsbyEmployeeId 'AR12'",_objectFactory.GetGridRPP("MG_Myprofile"));

base.WriteDebugInfo(@"var querySourceE90068F81DB3482DA081B2CB52A9B50E =GetQueryExpressionDataSource(""E90068F8-1DB3-482D-A081-B2CB52A9B50E"");DataTable resultE90068F81DB3482DA081B2CB52A9B50E=iSpace.SetGridDataSource(querySourceE90068F81DB3482DA081B2CB52A9B50E, _objectFactory.GetGridRPP(""MG_Myprofile""),@""EXEC GetEmployeeATOMDetailsbyEmployeeId 'AR12'"");iSpace.InsertGridBindDetails(""MG_Myprofile"",""11"",querySourceE90068F81DB3482DA081B2CB52A9B50E,""EXEC GetEmployeeATOMDetailsbyEmployeeId 'AR12'"",_objectFactory.GetGridRPP(""MG_Myprofile""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result74944699B350441490C9B3F794CCF37F=acdataIspace676395B9A4084102B650297FAB839973.GetQueryExpressionBindings("74944699-B350-4414-90C9-B3F794CCF37F");
iSpace.SetGridData(resultE90068F81DB3482DA081B2CB52A9B50E,result74944699B350441490C9B3F794CCF37F,"MG_Myprofile",ref ISpace);
iSpace.UpdateGridBindDetails("MG_Myprofile",result74944699B350441490C9B3F794CCF37F);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
}

var querySource21045A8DC3B34EB2A04F3D78BDF29961 =GetQueryExpressionDataSource("21045A8D-C3B3-4EB2-A04F-3D78BDF29961");

DataTable result21045A8DC3B34EB2A04F3D78BDF29961=iSpace.SetGridDataSource(querySource21045A8DC3B34EB2A04F3D78BDF29961, _objectFactory.GetGridRPP("PurchaseDetails"),@"EXEC GetFL_MyPurchases '" + ISpace["uname"].Value + @"'");

iSpace.InsertGridBindDetails("PurchaseDetails","11",querySource21045A8DC3B34EB2A04F3D78BDF29961,"EXEC GetFL_MyPurchases '" + ISpace["uname"].Value + @"'",_objectFactory.GetGridRPP("PurchaseDetails"));

base.WriteDebugInfo(@"var querySource21045A8DC3B34EB2A04F3D78BDF29961 =GetQueryExpressionDataSource(""21045A8D-C3B3-4EB2-A04F-3D78BDF29961"");DataTable result21045A8DC3B34EB2A04F3D78BDF29961=iSpace.SetGridDataSource(querySource21045A8DC3B34EB2A04F3D78BDF29961, _objectFactory.GetGridRPP(""PurchaseDetails""),@""EXEC GetFL_MyPurchases '"" + ISpace[""uname""].Value + @""'"");iSpace.InsertGridBindDetails(""PurchaseDetails"",""11"",querySource21045A8DC3B34EB2A04F3D78BDF29961,""EXEC GetFL_MyPurchases '"" + ISpace[""uname""].Value + @""'"",_objectFactory.GetGridRPP(""PurchaseDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultAE0EFDF05A8447DF856E7639E15D68B3=acdataIspace676395B9A4084102B650297FAB839973.GetQueryExpressionBindings("AE0EFDF0-5A84-47DF-856E-7639E15D68B3");
iSpace.SetGridData(result21045A8DC3B34EB2A04F3D78BDF29961,resultAE0EFDF05A8447DF856E7639E15D68B3,"PurchaseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("PurchaseDetails",resultAE0EFDF05A8447DF856E7639E15D68B3);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
public override void ExecuteMethod
	(string methodName, string elementName,
		ref Dictionary<string, ServiceElementData> dfsParam)
{
	if(methodName.ToLower().Equals("formonload"))
{
			SubscribeFormEvents_root(ref dfsParam);
}
	if(methodName.ToLower().Equals("onchange"))
{
}
	if(methodName.ToLower().Equals("onclick"))
{
}
}
}
}

  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace676395B9A4084102B650297FAB839973  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"51C633D5-28A1-47E4-B21B-AC5324D2286A", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MGM_ProgramName",2,
														   -1),
								   new Triplet<string, short, short?>("MGM_CGPA",5,
														   -1),
								   new Triplet<string, short, short?>("MGM_Semester",4,
														   -1),
								   new Triplet<string, short, short?>("MGM_StudentName",1,
														   -1),
								   new Triplet<string, short, short?>("MGM_Batch",3,
														   -1),
								   new Triplet<string, short, short?>("MGM_RollNo",0,
														   -1),
								}
			},
							{"74944699-B350-4414-90C9-B3F794CCF37F", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_EmpDesigantion",2,
														   -1),
								   new Triplet<string, short, short?>("MG_EmpEmail",6,
														   -1),
								   new Triplet<string, short, short?>("MG_EmpID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_Empname",1,
														   -1),
								   new Triplet<string, short, short?>("MG_EmpDepartment",3,
														   -1),
								}
			},
							{"F5F1BBAC-4DF4-4ADB-A2BF-41821E1B1C83", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ClassRoom",5,
														   -1),
								   new Triplet<string, short, short?>("Slot",4,
														   -1),
								   new Triplet<string, short, short?>("CourseName",1,
														   -1),
								   new Triplet<string, short, short?>("Credits",2,
														   -1),
								   new Triplet<string, short, short?>("CourseCode",0,
														   -1),
								   new Triplet<string, short, short?>("RegisteredStudentCount",3,
														   -1),
								}
			},
							{"AE0EFDF0-5A84-47DF-856E-7639E15D68B3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MF_Status",4,
														   -1),
								   new Triplet<string, short, short?>("MF_PO",0,
														   -1),
								   new Triplet<string, short, short?>("MF_POValue",2,
														   -1),
								   new Triplet<string, short, short?>("MF_PODate",1,
														   -1),
								   new Triplet<string, short, short?>("MF_PurchaseType",3,
														   -1),
								}
			},
							{"492FDEC8-CE7D-43DC-9945-659A18208260", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MGM_ThesisName",5,
														   -1),
								   new Triplet<string, short, short?>("MGM_ProgramName",3,
														   -1),
								   new Triplet<string, short, short?>("MGM_RollNo",1,
														   -1),
								   new Triplet<string, short, short?>("MGM_StudentName",2,
														   -1),
								   new Triplet<string, short, short?>("MGM_Batch",4,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"8E28E3EA-BBF3-4949-82DA-A2D76C215685", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"AD71AD43-B709-416B-9894-724B0E84EA54", ""},
							{"6FC272AD-9697-46FA-BB65-BB2C576C093C", ""},
							{"8E28E3EA-BBF3-4949-82DA-A2D76C215685", ""},
							{"1211EAE3-5B71-4904-93E5-C76B98BD9E03", ""},
							{"1CC97C28-854F-40F5-B081-3475B4636FE7", ""},
							{"9C97DC48-C801-4302-9AE8-F4E5122ED5DE", ""},
							{"44DBDD0A-C6BE-47A4-BC4B-D70D438CB161", ""},
							{"3BC858A2-DAD7-467B-B711-DD7806B0C9F4", ""},
					};	

		

	
	
		
		
		public override  List<Triplet<string, short, short?>> GetQueryExpressionBindings(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			  return null;				
            }


			if(queryExpressionBindings == null || queryExpressionBindings.Count <= 0)
				return null;

			return queryExpressionBindings[expressionId];
		}

		public override string GetValidFormVersionId(string formVersionId,ViewportTypes viewPort)
		{	
					
			 if(formVersionList == null || formVersionList.Count <= 0)
				return formVersionId;

			if (formVersionList.Count == 1)
                return formVersionList.FirstOrDefault().Key;  

			

			if ( !string.IsNullOrEmpty(formVersionId) &&  formVersionList.ContainsKey(formVersionId))
            {
                if (formVersionList.Any(x => x.Key == formVersionId && x.Value == viewPort.ToString()))
                    return formVersionId;
            }

			var fallback= new List<string>{"Mobile","Tab","Medium","Large"};

           switch (viewPort)
            {
                case ViewportTypes.Tab:
                    fallback = new List<string> { "Tab", "Mobile", "Medium", "Large" };
                    break;

                case ViewportTypes.Medium:
                    fallback = new List<string> { "Medium", "Tab", "Large", "Mobile" };
                    break;

                case ViewportTypes.Large:
                    fallback = new List<string> { "Large", "Medium", "Tab", "Mobile" };
                    break;
            }

           for (int i = 0; i < fallback.Count; i++)
           {
               if (formVersionList.Any(x => x.Value == fallback[i]))
                   return formVersionList.Where(x => x.Value == fallback[i]).Select(y => y.Key).FirstOrDefault();
           }

		   return formVersionId;
		}

	

		
		
		
		
		


	}

}
		


