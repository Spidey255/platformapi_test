  







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
	  			
			     new Triplet<string, string, string>("F6D8A0EA-D75F-4546-8CFD-07AEA1B39FD7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("CBE7C902-D88D-4FFA-9AC9-368B0666326A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("CBE7C902-D88D-4FFA-9AC9-368B0666326A","MyCourses",
												     @"10E58727-BEE9-476F-80A2-6E33288B9AB2"),
			
			
			
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
		
	  			
			     new Tuple<string, int>("NewRepeater",5),
			
						
			     new Tuple<string, int>("MyCoursesDetails",5),
			
						
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

                
                 
                                      case "FC12214A-7A71-4567-A9F2-EE229BBC220B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_FC12214A7A714567A9F2EE229BBC220B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [FC12214A-7A71-4567-A9F2-EE229BBC220B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_FC12214A7A714567A9F2EE229BBC220B TDT
							LEFT JOIN [FC12214A-7A71-4567-A9F2-EE229BBC220B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_FC12214A7A714567A9F2EE229BBC220B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "E514A61F-AC1B-4441-933D-5DA3FDE1F9AB":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_E514A61FAC1B4441933D5DA3FDE1F9AB AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [E514A61F-AC1B-4441-933D-5DA3FDE1F9AB](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_E514A61FAC1B4441933D5DA3FDE1F9AB TDT
							LEFT JOIN [E514A61F-AC1B-4441-933D-5DA3FDE1F9AB] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_E514A61FAC1B4441933D5DA3FDE1F9AB(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "10E58727-BEE9-476F-80A2-6E33288B9AB2":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_10E58727BEE9476F80A26E33288B9AB2 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [10E58727-BEE9-476F-80A2-6E33288B9AB2](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_10E58727BEE9476F80A26E33288B9AB2 TDT
							LEFT JOIN [10E58727-BEE9-476F-80A2-6E33288B9AB2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_10E58727BEE9476F80A26E33288B9AB2(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     

                                         case "FC12214A-7A71-4567-A9F2-EE229BBC220B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_FC12214A7A714567A9F2EE229BBC220B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [FC12214A-7A71-4567-A9F2-EE229BBC220B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_FC12214A7A714567A9F2EE229BBC220B TDT
							LEFT JOIN [FC12214A-7A71-4567-A9F2-EE229BBC220B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_FC12214A7A714567A9F2EE229BBC220B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "E514A61F-AC1B-4441-933D-5DA3FDE1F9AB":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_E514A61FAC1B4441933D5DA3FDE1F9AB AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [E514A61F-AC1B-4441-933D-5DA3FDE1F9AB](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_E514A61FAC1B4441933D5DA3FDE1F9AB TDT
							LEFT JOIN [E514A61F-AC1B-4441-933D-5DA3FDE1F9AB] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_E514A61FAC1B4441933D5DA3FDE1F9AB(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "10E58727-BEE9-476F-80A2-6E33288B9AB2":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_10E58727BEE9476F80A26E33288B9AB2 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [10E58727-BEE9-476F-80A2-6E33288B9AB2](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_10E58727BEE9476F80A26E33288B9AB2 TDT
							LEFT JOIN [10E58727-BEE9-476F-80A2-6E33288B9AB2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_10E58727BEE9476F80A26E33288B9AB2(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

var querySourceCBE7C902D88D4FFA9AC9368B0666326A =GetQueryExpressionDataSource("CBE7C902-D88D-4FFA-9AC9-368B0666326A");

DataTable resultCBE7C902D88D4FFA9AC9368B0666326A=iSpace.SetGridDataSource(querySourceCBE7C902D88D4FFA9AC9368B0666326A, _objectFactory.GetGridRPP("MyCoursesDetails"),@"exec GetFL_MyCourses '" + ISpace["uname"].Value + @"'");

iSpace.InsertGridBindDetails("MyCoursesDetails","11",querySourceCBE7C902D88D4FFA9AC9368B0666326A,"exec GetFL_MyCourses '" + ISpace["uname"].Value + @"'",_objectFactory.GetGridRPP("MyCoursesDetails"));

base.WriteDebugInfo(@"var querySourceCBE7C902D88D4FFA9AC9368B0666326A =GetQueryExpressionDataSource(""CBE7C902-D88D-4FFA-9AC9-368B0666326A"");DataTable resultCBE7C902D88D4FFA9AC9368B0666326A=iSpace.SetGridDataSource(querySourceCBE7C902D88D4FFA9AC9368B0666326A, _objectFactory.GetGridRPP(""MyCoursesDetails""),@""exec GetFL_MyCourses '"" + ISpace[""uname""].Value + @""'"");iSpace.InsertGridBindDetails(""MyCoursesDetails"",""11"",querySourceCBE7C902D88D4FFA9AC9368B0666326A,""exec GetFL_MyCourses '"" + ISpace[""uname""].Value + @""'"",_objectFactory.GetGridRPP(""MyCoursesDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCB1E142F15974488A9A402FEAA29CC38=acdataIspace676395B9A4084102B650297FAB839973.GetQueryExpressionBindings("CB1E142F-1597-4488-A9A4-02FEAA29CC38");
iSpace.SetGridData(resultCBE7C902D88D4FFA9AC9368B0666326A,resultCB1E142F15974488A9A402FEAA29CC38,"MyCoursesDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MyCoursesDetails",resultCB1E142F15974488A9A402FEAA29CC38);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetTaskSummary");

var querySourceF6D8A0EAD75F45468CFD07AEA1B39FD7 =GetQueryExpressionDataSource("F6D8A0EA-D75F-4546-8CFD-07AEA1B39FD7");
Dictionary<short,object> resultF6D8A0EAD75F45468CFD07AEA1B39FD7=iSpace.ExecuteQuery(querySourceF6D8A0EAD75F45468CFD07AEA1B39FD7,@"EXEC GetTaskSummary",false);

base.WriteDebugInfo(@"var querySourceF6D8A0EAD75F45468CFD07AEA1B39FD7 =GetQueryExpressionDataSource(""F6D8A0EA-D75F-4546-8CFD-07AEA1B39FD7"");Dictionary<short,object> resultF6D8A0EAD75F45468CFD07AEA1B39FD7=iSpace.ExecuteQuery(querySourceF6D8A0EAD75F45468CFD07AEA1B39FD7,@""EXEC GetTaskSummary"",false);");
base.WriteDebugInfo(@"");

if((resultF6D8A0EAD75F45468CFD07AEA1B39FD7!=null) && (resultF6D8A0EAD75F45468CFD07AEA1B39FD7.Count!=0))
{
if(resultF6D8A0EAD75F45468CFD07AEA1B39FD7.ContainsKey(0))
ISpace["M_Total"].Value = resultF6D8A0EAD75F45468CFD07AEA1B39FD7[0];
if(resultF6D8A0EAD75F45468CFD07AEA1B39FD7.ContainsKey(2))
ISpace["M_InActive"].Value = resultF6D8A0EAD75F45468CFD07AEA1B39FD7[2];
if(resultF6D8A0EAD75F45468CFD07AEA1B39FD7.ContainsKey(3))
ISpace["M_Closed"].Value = resultF6D8A0EAD75F45468CFD07AEA1B39FD7[3];
if(resultF6D8A0EAD75F45468CFD07AEA1B39FD7.ContainsKey(1))
ISpace["M_Active"].Value = resultF6D8A0EAD75F45468CFD07AEA1B39FD7[1];
}
else{
ISpace["M_Total"].Value = null;ISpace["M_InActive"].Value = null;ISpace["M_Closed"].Value = null;ISpace["M_Active"].Value = null;
}
}
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
							{"CB1E142F-1597-4488-A9A4-02FEAA29CC38", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("Slot",4,
														   -1),
								   new Triplet<string, short, short?>("RegisteredStudentCount",3,
														   -1),
								   new Triplet<string, short, short?>("Credits",2,
														   -1),
								   new Triplet<string, short, short?>("CourseCode",0,
														   -1),
								   new Triplet<string, short, short?>("ClassRoom",5,
														   -1),
								   new Triplet<string, short, short?>("CourseName",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
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
		


