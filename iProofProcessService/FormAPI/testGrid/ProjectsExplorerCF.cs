  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectsExplorerCFProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 20126; }
        }

        public override string PackageName
        {
            get { return "testGrid"; }
        }

		public override string PackageDescription
        {
            get { return "for testing purpose"; }
        }

        public override string ProcessId
        {
            get { return "3A7935C9-D8A6-4D6E-B274-7F9D55385FBF"; }
        }

        public override string ProcessName
        {
            get { return "ProjectsExplorerCF"; }
        }

		public override string ProcessDescription
        {
            get { return "Projects Explorer Latest Smart UI"; }
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
            get {return "3A7935C9-D8A6-4D6E-B274-7F9D55385FBF";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "DE2C7BF1-BA90-4AB8-853A-765F349ABF38";	}
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
	

	public partial class ProjectsExplorerCFObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectsExplorerCFProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("1D7A6BB4-3081-4274-B951-3EF175E7D9ED","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("8634FCBE-C424-425B-9124-32FDC5A63093","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("CBBC0F85-44E5-4494-A6E0-6B12B6328FA6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("F4B3E783-509F-4B44-961B-E04F3836FFC6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("1D7A6BB4-3081-4274-B951-3EF175E7D9ED","Grid Binding",
												     @"07BBE576-3E3B-4CAE-B75D-4A8FEF92C0AF"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_ProjectListActiveProjectspr_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77q8ayfct700fBGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
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
		
	  			
			     new Tuple<string, int>("ProjectListActiveProjectspr",5),
			
						
			     new Tuple<string, int>("ProjectListActiveProjectspr",5),
			
						
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
											case "241BCCC0-C68C-4EFE-8E69-4E620A010097":
							virtualInstance=new ISpace241BCCC0C68C4EFE8E694E620A010097();
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
	

	public partial class ProjectsExplorerCFDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectsExplorerCFDataElementFactory()
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

               
                
                                      case "DE2C7BF1-BA90-4AB8-853A-765F349ABF38":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [DE2C7BF1-BA90-4AB8-853A-765F349ABF38] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [DE2C7BF1-BA90-4AB8-853A-765F349ABF38](InstanceId,ProcessActivityMapId,FormId,MF_V1_SanctionedValue,F_ProjectDetailsId,MF_ActiveCount,MF_ProposalCount,MF_CompletedCount,MF_SanctionedCount,MF_ActiveAmount,MF_ProjectListActiveProjectspr_PageIndex,MF_ProjectListActiveProjectspr_TotalPages,MF_V1_ProjectDetailsID,MF_V1_ProjectTitle,MF_V1_ProjectNo,MF_V1_Department,MF_V1_PI,MF_V1_CoPI,MF_V1_ProjectType,MF_V1_Agency,MF_V1_StartDate,MF_V1_EndDate,MF_V1_Duration,MF_V1_FinancialYear,MF_Option,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectListActiveProjectspr_GridRows,MF_ProjectListActiveProjectspr_RecordsRange,MF_CompletedAmount,MF_ProposalAmount,MF_SanctionedAmount,RedirectUrl,MF_URL)  
       VALUES( {3}) END ELSE BEGIN UPDATE [DE2C7BF1-BA90-4AB8-853A-765F349ABF38]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,MF_V1_SanctionedValue,F_ProjectDetailsId,MF_ActiveCount,MF_ProposalCount,MF_CompletedCount,MF_SanctionedCount,MF_ActiveAmount,MF_ProjectListActiveProjectspr_PageIndex,MF_ProjectListActiveProjectspr_TotalPages,MF_V1_ProjectDetailsID,MF_V1_ProjectTitle,MF_V1_ProjectNo,MF_V1_Department,MF_V1_PI,MF_V1_CoPI,MF_V1_ProjectType,MF_V1_Agency,MF_V1_StartDate,MF_V1_EndDate,MF_V1_Duration,MF_V1_FinancialYear,MF_Option,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectListActiveProjectspr_GridRows,MF_ProjectListActiveProjectspr_RecordsRange,MF_CompletedAmount,MF_ProposalAmount,MF_SanctionedAmount,RedirectUrl,MF_URL";
                                    
                     
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

                
                 
                                      case "07BBE576-3E3B-4CAE-B75D-4A8FEF92C0AF":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_07BBE5763E3B4CAEB75D4A8FEF92C0AF AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ProjectDetailsID] VARCHAR(50)	, [MGG_V1_ProjectNo] VARCHAR(50)	, [MGG_V1_Department] VARCHAR(50)	, [MGG_V1_PI] VARCHAR(50)	, [MGG_V1_CoPI] VARCHAR(50)	, [MGG_V1_ProjectType] VARCHAR(50)	, [MGG_V1_Agency] VARCHAR(50)	, [MGG_V1_StartDate] DATETIME	, [MGG_V1_EndDate] DATETIME	, [MGG_V1_Duration] VARCHAR(50)	, [MGG_V1_FinancialYear] VARCHAR(50)	, [MGG_V1_Type] VARCHAR(50)){0}INSERT INTO [07BBE576-3E3B-4CAE-B75D-4A8FEF92C0AF](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_ProjectNo,TDT.MGG_V1_Department,TDT.MGG_V1_PI,TDT.MGG_V1_CoPI,TDT.MGG_V1_ProjectType,TDT.MGG_V1_Agency,TDT.MGG_V1_StartDate,TDT.MGG_V1_EndDate,TDT.MGG_V1_Duration,TDT.MGG_V1_FinancialYear,TDT.MGG_V1_SanctionedValue,TDT.MGG_V1_Type FROM @TBL_07BBE5763E3B4CAEB75D4A8FEF92C0AF TDT
							LEFT JOIN [07BBE576-3E3B-4CAE-B75D-4A8FEF92C0AF] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type";

                                     tempInsertQuery=@"INSERT INTO @TBL_07BBE5763E3B4CAEB75D4A8FEF92C0AF(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)VALUES({0});";
                                     

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


      public override Status GetGridLoopQuery(string gridId,string gridName,Dictionary<string,ServiceElementData> gridData)
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
                     

                                         case "07BBE576-3E3B-4CAE-B75D-4A8FEF92C0AF":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_07BBE5763E3B4CAEB75D4A8FEF92C0AF AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ProjectDetailsID] VARCHAR(50)	, [MGG_V1_ProjectNo] VARCHAR(50)	, [MGG_V1_Department] VARCHAR(50)	, [MGG_V1_PI] VARCHAR(50)	, [MGG_V1_CoPI] VARCHAR(50)	, [MGG_V1_ProjectType] VARCHAR(50)	, [MGG_V1_Agency] VARCHAR(50)	, [MGG_V1_StartDate] DATETIME	, [MGG_V1_EndDate] DATETIME	, [MGG_V1_Duration] VARCHAR(50)	, [MGG_V1_FinancialYear] VARCHAR(50)	, [MGG_V1_Type] VARCHAR(50)){0}INSERT INTO [07BBE576-3E3B-4CAE-B75D-4A8FEF92C0AF](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_ProjectNo,TDT.MGG_V1_Department,TDT.MGG_V1_PI,TDT.MGG_V1_CoPI,TDT.MGG_V1_ProjectType,TDT.MGG_V1_Agency,TDT.MGG_V1_StartDate,TDT.MGG_V1_EndDate,TDT.MGG_V1_Duration,TDT.MGG_V1_FinancialYear,TDT.MGG_V1_SanctionedValue,TDT.MGG_V1_Type FROM @TBL_07BBE5763E3B4CAEB75D4A8FEF92C0AF TDT
							LEFT JOIN [07BBE576-3E3B-4CAE-B75D-4A8FEF92C0AF] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type";

                            tempInsertQuery=@"INSERT INTO @TBL_07BBE5763E3B4CAEB75D4A8FEF92C0AF(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                         

                return Status.Success;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  GetGridLoopQuery", ex);

                return Status.Failure;
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
public class ISpace241BCCC0C68C4EFE8E694E620A010097 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace241BCCC0C68C4EFE8E694E620A010097 acdataIspace241BCCC0C68C4EFE8E694E620A010097=new AcDataISpace241BCCC0C68C4EFE8E694E620A010097();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
Dictionary<short, object> keyValuePairs = null;base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource("1D7A6BB4-3081-4274-B951-3EF175E7D9ED");

DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP("ProjectListActiveProjectspr"),@"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectListActiveProjectspr","11",querySource1D7A6BB430814274B9513EF175E7D9ED,"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'",_objectFactory.GetGridRPP("ProjectListActiveProjectspr"));

base.WriteDebugInfo(@"var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource(""1D7A6BB4-3081-4274-B951-3EF175E7D9ED"");DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP(""ProjectListActiveProjectspr""),@""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectListActiveProjectspr"",""11"",querySource1D7A6BB430814274B9513EF175E7D9ED,""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectListActiveProjectspr""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bccb6bb6-39f0-4863-8a17-2efdffe2a45b_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectListActiveProjectspr_PageIndex,'#MF_ProjectListActiveProjectspr_GridRows'");


List<Triplet<string, short, short?>> result73F7289D3EAA4F8ABE26AB75389E53DC=acdataIspace241BCCC0C68C4EFE8E694E620A010097.GetQueryExpressionBindings("73F7289D-3EAA-4F8A-BE26-AB75389E53DC");
iSpace.SetGridData(result1D7A6BB430814274B9513EF175E7D9ED,result73F7289D3EAA4F8ABE26AB75389E53DC,"ProjectListActiveProjectspr",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectListActiveProjectspr",result73F7289D3EAA4F8ABE26AB75389E53DC);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetProjectStatistics ' @@gv_UserName'");

var querySourceF4B3E783509F4B44961BE04F3836FFC6 =GetQueryExpressionDataSource("F4B3E783-509F-4B44-961B-E04F3836FFC6");
Dictionary<short,object> resultF4B3E783509F4B44961BE04F3836FFC6=iSpace.ExecuteQuery(querySourceF4B3E783509F4B44961BE04F3836FFC6,@"EXEC GetProjectStatistics ' " + ISpace["gv_username"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF4B3E783509F4B44961BE04F3836FFC6 =GetQueryExpressionDataSource(""F4B3E783-509F-4B44-961B-E04F3836FFC6"");Dictionary<short,object> resultF4B3E783509F4B44961BE04F3836FFC6=iSpace.ExecuteQuery(querySourceF4B3E783509F4B44961BE04F3836FFC6,@""EXEC GetProjectStatistics ' "" + ISpace[""gv_username""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF4B3E783509F4B44961BE04F3836FFC6!=null) && (resultF4B3E783509F4B44961BE04F3836FFC6.Count!=0))
{
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(0))
ISpace["MF_ActiveCount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[0];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(6))
ISpace["MF_SanctionedCount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[6];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(1))
ISpace["MF_ActiveAmount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[1];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(3))
ISpace["MF_CompletedAmount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[3];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(5))
ISpace["MF_ProposalAmount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[5];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(7))
ISpace["MF_SanctionedAmount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[7];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(2))
ISpace["MF_CompletedCount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[2];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(4))
ISpace["MF_ProposalCount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[4];
}
else{
ISpace["MF_ActiveCount"].Value = null;ISpace["MF_SanctionedCount"].Value = null;ISpace["MF_ActiveAmount"].Value = null;ISpace["MF_CompletedAmount"].Value = null;ISpace["MF_ProposalAmount"].Value = null;ISpace["MF_SanctionedAmount"].Value = null;ISpace["MF_CompletedCount"].Value = null;ISpace["MF_ProposalCount"].Value = null;
}
}
ISpace["MF_URL"].Value="http://210.18.135.72/Default/Pages/DynamicPage/ISpace.html?PkActMId=6B5E748F-516A-4136-8016-3464FB30137D&frmElementId=97FE9653-E760-4DDE-B22E-5247CBB725F3&PkPrMId=B0EDBC7F-E6F9-4F68-92D1-C2D70DA0933A&formVersionId=770944B9-E280-449C-AE7E-B27EB1909CF1&Ver=0.0000";
base.WriteDebugInfo(@"ISpace[""MF_URL""].Value=""http://210.18.135.72/Default/Pages/DynamicPage/ISpace.html?PkActMId=6B5E748F-516A-4136-8016-3464FB30137D&frmElementId=97FE9653-E760-4DDE-B22E-5247CBB725F3&PkPrMId=B0EDBC7F-E6F9-4F68-92D1-C2D70DA0933A&formVersionId=770944B9-E280-449C-AE7E-B27EB1909CF1&Ver=0.0000"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

ISpace["MF_V1_ProjectDetailsID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectDetailsID""].Value=null;");
ISpace["MF_V1_ProjectTitle"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectTitle""].Value=null;");
ISpace["MF_V1_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectNo""].Value=null;");
ISpace["MF_V1_Department"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Department""].Value=null;");
ISpace["MF_V1_PI"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_PI""].Value=null;");
ISpace["MF_V1_CoPI"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_CoPI""].Value=null;");
ISpace["MF_V1_ProjectType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectType""].Value=null;");
ISpace["MF_V1_Agency"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Agency""].Value=null;");
ISpace["MF_V1_StartDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_StartDate""].Value=null;");
ISpace["MF_V1_EndDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_EndDate""].Value=null;");
ISpace["MF_V1_Duration"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Duration""].Value=null;");
ISpace["MF_V1_FinancialYear"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_FinancialYear""].Value=null;");
ISpace["MF_V1_SanctionedValue"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_SanctionedValue""].Value=null;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT VW_MyProjects_1.[ProjectDetailsID], VW_MyProjects_1.[ProjectTitle], VW_MyProjects_1.[ProjectNo], VW_MyProjects_1.[Department], VW_MyProjects_1.[PI], VW_MyProjects_1.[CoPI], VW_MyProjects_1.[ProjectType], VW_MyProjects_1.[Agency], VW_MyProjects_1.[StartDate], VW_MyProjects_1.[EndDate], VW_MyProjects_1.[Duration], VW_MyProjects_1.[FinancialYear], VW_MyProjects_1.[SanctionedValue] FROM  Projects..VW_MyProjects_1  WHERE VW_MyProjects_1.ProjectDetailsID= '#MGG_V1_ProjectDetailsID'");

var querySourceCBBC0F8544E54494A6E06B12B6328FA6 =GetQueryExpressionDataSource("CBBC0F85-44E5-4494-A6E0-6B12B6328FA6");
Dictionary<short,object> resultCBBC0F8544E54494A6E06B12B6328FA6=iSpace.ExecuteQuery(querySourceCBBC0F8544E54494A6E06B12B6328FA6,@"SELECT VW_MyProjects_1.[ProjectDetailsID], VW_MyProjects_1.[ProjectTitle], VW_MyProjects_1.[ProjectNo], VW_MyProjects_1.[Department], VW_MyProjects_1.[PI], VW_MyProjects_1.[CoPI], VW_MyProjects_1.[ProjectType], VW_MyProjects_1.[Agency], VW_MyProjects_1.[StartDate], VW_MyProjects_1.[EndDate], VW_MyProjects_1.[Duration], VW_MyProjects_1.[FinancialYear], VW_MyProjects_1.[SanctionedValue] FROM  Projects..VW_MyProjects_1  WHERE VW_MyProjects_1.ProjectDetailsID= '" + ISpace["MGG_V1_ProjectDetailsID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceCBBC0F8544E54494A6E06B12B6328FA6 =GetQueryExpressionDataSource(""CBBC0F85-44E5-4494-A6E0-6B12B6328FA6"");Dictionary<short,object> resultCBBC0F8544E54494A6E06B12B6328FA6=iSpace.ExecuteQuery(querySourceCBBC0F8544E54494A6E06B12B6328FA6,@""SELECT VW_MyProjects_1.[ProjectDetailsID], VW_MyProjects_1.[ProjectTitle], VW_MyProjects_1.[ProjectNo], VW_MyProjects_1.[Department], VW_MyProjects_1.[PI], VW_MyProjects_1.[CoPI], VW_MyProjects_1.[ProjectType], VW_MyProjects_1.[Agency], VW_MyProjects_1.[StartDate], VW_MyProjects_1.[EndDate], VW_MyProjects_1.[Duration], VW_MyProjects_1.[FinancialYear], VW_MyProjects_1.[SanctionedValue] FROM  Projects..VW_MyProjects_1  WHERE VW_MyProjects_1.ProjectDetailsID= '"" + ISpace[""MGG_V1_ProjectDetailsID""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT VW_MyProjects_1.[ProjectDetailsID], VW_MyProjects_1.[ProjectTitle], VW_MyProjects_1.[ProjectNo], VW_MyProjects_1.[Department], VW_MyProjects_1.[PI], VW_MyProjects_1.[CoPI], VW_MyProjects_1.[ProjectType], VW_MyProjects_1.[Agency], VW_MyProjects_1.[StartDate], VW_MyProjects_1.[EndDate], VW_MyProjects_1.[Duration], VW_MyProjects_1.[FinancialYear], VW_MyProjects_1.[SanctionedValue] FROM  Projects..VW_MyProjects_1  WHERE VW_MyProjects_1.ProjectDetailsID= '#MGG_V1_ProjectDetailsID'");

if((resultCBBC0F8544E54494A6E06B12B6328FA6!=null) && (resultCBBC0F8544E54494A6E06B12B6328FA6.Count!=0))
{
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(8))
ISpace["MF_V1_StartDate"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[8];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(9))
ISpace["MF_V1_EndDate"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[9];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(12))
ISpace["MF_V1_SanctionedValue"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[12];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(5))
ISpace["MF_V1_CoPI"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[5];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(2))
ISpace["MF_V1_ProjectNo"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[2];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(3))
ISpace["MF_V1_Department"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[3];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(1))
ISpace["MF_V1_ProjectTitle"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[1];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(7))
ISpace["MF_V1_Agency"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[7];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(6))
ISpace["MF_V1_ProjectType"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[6];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(11))
ISpace["MF_V1_FinancialYear"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[11];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(0))
ISpace["MF_V1_ProjectDetailsID"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[0];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(10))
ISpace["MF_V1_Duration"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[10];
if(resultCBBC0F8544E54494A6E06B12B6328FA6.ContainsKey(4))
ISpace["MF_V1_PI"].Value = resultCBBC0F8544E54494A6E06B12B6328FA6[4];
}
else{
ISpace["MF_V1_StartDate"].Value = null;ISpace["MF_V1_EndDate"].Value = null;ISpace["MF_V1_SanctionedValue"].Value = null;ISpace["MF_V1_CoPI"].Value = null;ISpace["MF_V1_ProjectNo"].Value = null;ISpace["MF_V1_Department"].Value = null;ISpace["MF_V1_ProjectTitle"].Value = null;ISpace["MF_V1_Agency"].Value = null;ISpace["MF_V1_ProjectType"].Value = null;ISpace["MF_V1_FinancialYear"].Value = null;ISpace["MF_V1_ProjectDetailsID"].Value = null;ISpace["MF_V1_Duration"].Value = null;ISpace["MF_V1_PI"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_apply (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Apply-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource("1D7A6BB4-3081-4274-B951-3EF175E7D9ED");

DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP("ProjectListActiveProjectspr"),@"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectListActiveProjectspr","11",querySource1D7A6BB430814274B9513EF175E7D9ED,"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'",_objectFactory.GetGridRPP("ProjectListActiveProjectspr"));

base.WriteDebugInfo(@"var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource(""1D7A6BB4-3081-4274-B951-3EF175E7D9ED"");DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP(""ProjectListActiveProjectspr""),@""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectListActiveProjectspr"",""11"",querySource1D7A6BB430814274B9513EF175E7D9ED,""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectListActiveProjectspr""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bccb6bb6-39f0-4863-8a17-2efdffe2a45b_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectListActiveProjectspr_PageIndex,'#MF_ProjectListActiveProjectspr_GridRows'");


List<Triplet<string, short, short?>> result73F7289D3EAA4F8ABE26AB75389E53DC=acdataIspace241BCCC0C68C4EFE8E694E620A010097.GetQueryExpressionBindings("73F7289D-3EAA-4F8A-BE26-AB75389E53DC");
iSpace.SetGridData(result1D7A6BB430814274B9513EF175E7D9ED,result73F7289D3EAA4F8ABE26AB75389E53DC,"ProjectListActiveProjectspr",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectListActiveProjectspr",result73F7289D3EAA4F8ABE26AB75389E53DC);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetProjectStatistics ' @@gv_UserName'");

var querySourceF4B3E783509F4B44961BE04F3836FFC6 =GetQueryExpressionDataSource("F4B3E783-509F-4B44-961B-E04F3836FFC6");
Dictionary<short,object> resultF4B3E783509F4B44961BE04F3836FFC6=iSpace.ExecuteQuery(querySourceF4B3E783509F4B44961BE04F3836FFC6,@"EXEC GetProjectStatistics ' " + ISpace["gv_username"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF4B3E783509F4B44961BE04F3836FFC6 =GetQueryExpressionDataSource(""F4B3E783-509F-4B44-961B-E04F3836FFC6"");Dictionary<short,object> resultF4B3E783509F4B44961BE04F3836FFC6=iSpace.ExecuteQuery(querySourceF4B3E783509F4B44961BE04F3836FFC6,@""EXEC GetProjectStatistics ' "" + ISpace[""gv_username""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF4B3E783509F4B44961BE04F3836FFC6!=null) && (resultF4B3E783509F4B44961BE04F3836FFC6.Count!=0))
{
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(0))
ISpace["MF_ActiveCount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[0];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(6))
ISpace["MF_SanctionedCount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[6];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(1))
ISpace["MF_ActiveAmount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[1];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(3))
ISpace["MF_CompletedAmount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[3];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(5))
ISpace["MF_ProposalAmount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[5];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(7))
ISpace["MF_SanctionedAmount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[7];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(2))
ISpace["MF_CompletedCount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[2];
if(resultF4B3E783509F4B44961BE04F3836FFC6.ContainsKey(4))
ISpace["MF_ProposalCount"].Value = resultF4B3E783509F4B44961BE04F3836FFC6[4];
}
else{
ISpace["MF_ActiveCount"].Value = null;ISpace["MF_SanctionedCount"].Value = null;ISpace["MF_ActiveAmount"].Value = null;ISpace["MF_CompletedAmount"].Value = null;ISpace["MF_ProposalAmount"].Value = null;ISpace["MF_SanctionedAmount"].Value = null;ISpace["MF_CompletedCount"].Value = null;ISpace["MF_ProposalCount"].Value = null;
}
}
ISpace["MF_URL"].Value="http://210.18.135.72/Default/Pages/DynamicPage/ISpace.html?PkActMId=6B5E748F-516A-4136-8016-3464FB30137D&frmElementId=97FE9653-E760-4DDE-B22E-5247CBB725F3&PkPrMId=B0EDBC7F-E6F9-4F68-92D1-C2D70DA0933A&formVersionId=770944B9-E280-449C-AE7E-B27EB1909CF1&Ver=0.0000";
base.WriteDebugInfo(@"ISpace[""MF_URL""].Value=""http://210.18.135.72/Default/Pages/DynamicPage/ISpace.html?PkActMId=6B5E748F-516A-4136-8016-3464FB30137D&frmElementId=97FE9653-E760-4DDE-B22E-5247CBB725F3&PkPrMId=B0EDBC7F-E6F9-4F68-92D1-C2D70DA0933A&formVersionId=770944B9-E280-449C-AE7E-B27EB1909CF1&Ver=0.0000"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_add (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Add-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

ISpace["MF_V1_ProjectDetailsID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectDetailsID""].Value=null;");
ISpace["MF_V1_ProjectTitle"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectTitle""].Value=null;");
ISpace["MF_V1_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectNo""].Value=null;");
ISpace["MF_V1_Department"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Department""].Value=null;");
ISpace["MF_V1_PI"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_PI""].Value=null;");
ISpace["MF_V1_CoPI"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_CoPI""].Value=null;");
ISpace["MF_V1_ProjectType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectType""].Value=null;");
ISpace["MF_V1_Agency"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Agency""].Value=null;");
ISpace["MF_V1_StartDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_StartDate""].Value=null;");
ISpace["MF_V1_EndDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_EndDate""].Value=null;");
ISpace["MF_V1_Duration"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Duration""].Value=null;");
ISpace["MF_V1_FinancialYear"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_FinancialYear""].Value=null;");
ISpace["MF_V1_SanctionedValue"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_SanctionedValue""].Value=null;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_6D679FD7-C357-433A-81A5-3FC3AD3E9AAA_Save] '#MF_V1_ProjectDetailsID', '#MF_V1_ProjectTitle', '#MF_V1_ProjectNo', '#MF_V1_Department', '#MF_V1_PI', '#MF_V1_CoPI', '#MF_V1_ProjectType', '#MF_V1_Agency', '#MF_V1_StartDate', '#MF_V1_EndDate', '#MF_V1_Duration', '#MF_V1_FinancialYear', '#MF_V1_SanctionedValue'");

var querySource8634FCBEC424425B912432FDC5A63093 =GetQueryExpressionDataSource("8634FCBE-C424-425B-9124-32FDC5A63093");
Dictionary<short,object> result8634FCBEC424425B912432FDC5A63093=iSpace.ExecuteQuery(querySource8634FCBEC424425B912432FDC5A63093,@"EXEC dbo.[Dsp_6D679FD7-C357-433A-81A5-3FC3AD3E9AAA_Save] '" + ISpace["MF_V1_ProjectDetailsID"].Value + @"', '" + ISpace["MF_V1_ProjectTitle"].Value + @"', '" + ISpace["MF_V1_ProjectNo"].Value + @"', '" + ISpace["MF_V1_Department"].Value + @"', '" + ISpace["MF_V1_PI"].Value + @"', '" + ISpace["MF_V1_CoPI"].Value + @"', '" + ISpace["MF_V1_ProjectType"].Value + @"', '" + ISpace["MF_V1_Agency"].Value + @"', '" + ISpace["MF_V1_StartDate"].Value + @"', '" + ISpace["MF_V1_EndDate"].Value + @"', '" + ISpace["MF_V1_Duration"].Value + @"', '" + ISpace["MF_V1_FinancialYear"].Value + @"', '" + ISpace["MF_V1_SanctionedValue"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8634FCBEC424425B912432FDC5A63093 =GetQueryExpressionDataSource(""8634FCBE-C424-425B-9124-32FDC5A63093"");Dictionary<short,object> result8634FCBEC424425B912432FDC5A63093=iSpace.ExecuteQuery(querySource8634FCBEC424425B912432FDC5A63093,@""EXEC dbo.[Dsp_6D679FD7-C357-433A-81A5-3FC3AD3E9AAA_Save] '"" + ISpace[""MF_V1_ProjectDetailsID""].Value + @""', '"" + ISpace[""MF_V1_ProjectTitle""].Value + @""', '"" + ISpace[""MF_V1_ProjectNo""].Value + @""', '"" + ISpace[""MF_V1_Department""].Value + @""', '"" + ISpace[""MF_V1_PI""].Value + @""', '"" + ISpace[""MF_V1_CoPI""].Value + @""', '"" + ISpace[""MF_V1_ProjectType""].Value + @""', '"" + ISpace[""MF_V1_Agency""].Value + @""', '"" + ISpace[""MF_V1_StartDate""].Value + @""', '"" + ISpace[""MF_V1_EndDate""].Value + @""', '"" + ISpace[""MF_V1_Duration""].Value + @""', '"" + ISpace[""MF_V1_FinancialYear""].Value + @""', '"" + ISpace[""MF_V1_SanctionedValue""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_6D679FD7-C357-433A-81A5-3FC3AD3E9AAA_Save] '#MF_V1_ProjectDetailsID', '#MF_V1_ProjectTitle', '#MF_V1_ProjectNo', '#MF_V1_Department', '#MF_V1_PI', '#MF_V1_CoPI', '#MF_V1_ProjectType', '#MF_V1_Agency', '#MF_V1_StartDate', '#MF_V1_EndDate', '#MF_V1_Duration', '#MF_V1_FinancialYear', '#MF_V1_SanctionedValue'");

if((result8634FCBEC424425B912432FDC5A63093!=null) && (result8634FCBEC424425B912432FDC5A63093.Count!=0))
{
if(result8634FCBEC424425B912432FDC5A63093.ContainsKey(0))
ISpace["Subject"].Value = result8634FCBEC424425B912432FDC5A63093[0];
}
else{
ISpace["Subject"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource("1D7A6BB4-3081-4274-B951-3EF175E7D9ED");

DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP("ProjectListActiveProjectspr"),@"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectListActiveProjectspr","11",querySource1D7A6BB430814274B9513EF175E7D9ED,"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'",_objectFactory.GetGridRPP("ProjectListActiveProjectspr"));

base.WriteDebugInfo(@"var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource(""1D7A6BB4-3081-4274-B951-3EF175E7D9ED"");DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP(""ProjectListActiveProjectspr""),@""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectListActiveProjectspr"",""11"",querySource1D7A6BB430814274B9513EF175E7D9ED,""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectListActiveProjectspr""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bccb6bb6-39f0-4863-8a17-2efdffe2a45b_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectListActiveProjectspr_PageIndex,'#MF_ProjectListActiveProjectspr_GridRows'");


List<Triplet<string, short, short?>> result73F7289D3EAA4F8ABE26AB75389E53DC=acdataIspace241BCCC0C68C4EFE8E694E620A010097.GetQueryExpressionBindings("73F7289D-3EAA-4F8A-BE26-AB75389E53DC");
iSpace.SetGridData(result1D7A6BB430814274B9513EF175E7D9ED,result73F7289D3EAA4F8ABE26AB75389E53DC,"ProjectListActiveProjectspr",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectListActiveProjectspr",result73F7289D3EAA4F8ABE26AB75389E53DC);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_cancel (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Cancel-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mgg_v1_projecttitle (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MGG_V1_ProjectTitle-OnClick");
ISpace["MF_URL"].Value="http://210.18.135.72/frameportal/#/ProjectView/3/"+ISpace["MGG_V1_ProjectDetailsID"].Value;
base.WriteDebugInfo(@"ISpace[""MF_URL""].Value=""http://210.18.135.72/frameportal/#/ProjectView/3/""+ISpace[""MGG_V1_ProjectDetailsID""].Value;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value=ISpace["MF_URL"].Value;
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=ISpace[""MF_URL""].Value;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectlistactiveprojectspr_pageindex (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectListActiveProjectspr_PageIndex-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource("1D7A6BB4-3081-4274-B951-3EF175E7D9ED");

DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP("ProjectListActiveProjectspr"),@"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectListActiveProjectspr","11",querySource1D7A6BB430814274B9513EF175E7D9ED,"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'",_objectFactory.GetGridRPP("ProjectListActiveProjectspr"));

base.WriteDebugInfo(@"var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource(""1D7A6BB4-3081-4274-B951-3EF175E7D9ED"");DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP(""ProjectListActiveProjectspr""),@""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectListActiveProjectspr"",""11"",querySource1D7A6BB430814274B9513EF175E7D9ED,""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectListActiveProjectspr""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bccb6bb6-39f0-4863-8a17-2efdffe2a45b_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectListActiveProjectspr_PageIndex,'#MF_ProjectListActiveProjectspr_GridRows'");


List<Triplet<string, short, short?>> result73F7289D3EAA4F8ABE26AB75389E53DC=acdataIspace241BCCC0C68C4EFE8E694E620A010097.GetQueryExpressionBindings("73F7289D-3EAA-4F8A-BE26-AB75389E53DC");
iSpace.SetGridData(result1D7A6BB430814274B9513EF175E7D9ED,result73F7289D3EAA4F8ABE26AB75389E53DC,"ProjectListActiveProjectspr",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectListActiveProjectspr",result73F7289D3EAA4F8ABE26AB75389E53DC);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectlistactiveprojectspr_gridrows (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectListActiveProjectspr_GridRows-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource("1D7A6BB4-3081-4274-B951-3EF175E7D9ED");

DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP("ProjectListActiveProjectspr"),@"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectListActiveProjectspr","11",querySource1D7A6BB430814274B9513EF175E7D9ED,"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"','',0,'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'",_objectFactory.GetGridRPP("ProjectListActiveProjectspr"));

base.WriteDebugInfo(@"var querySource1D7A6BB430814274B9513EF175E7D9ED =GetQueryExpressionDataSource(""1D7A6BB4-3081-4274-B951-3EF175E7D9ED"");DataTable result1D7A6BB430814274B9513EF175E7D9ED=iSpace.SetGridDataSource(querySource1D7A6BB430814274B9513EF175E7D9ED, _objectFactory.GetGridRPP(""ProjectListActiveProjectspr""),@""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectListActiveProjectspr"",""11"",querySource1D7A6BB430814274B9513EF175E7D9ED,""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',0,'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectListActiveProjectspr""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bccb6bb6-39f0-4863-8a17-2efdffe2a45b_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectListActiveProjectspr_PageIndex,'#MF_ProjectListActiveProjectspr_GridRows'");


List<Triplet<string, short, short?>> result73F7289D3EAA4F8ABE26AB75389E53DC=acdataIspace241BCCC0C68C4EFE8E694E620A010097.GetQueryExpressionBindings("73F7289D-3EAA-4F8A-BE26-AB75389E53DC");
iSpace.SetGridData(result1D7A6BB430814274B9513EF175E7D9ED,result73F7289D3EAA4F8ABE26AB75389E53DC,"ProjectListActiveProjectspr",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectListActiveProjectspr",result73F7289D3EAA4F8ABE26AB75389E53DC);
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
		if(elementName.ToLower().Equals("mf_projectlistactiveprojectspr_pageindex"))
    {
    			SubscribeElementEvents_mf_projectlistactiveprojectspr_pageindex(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectlistactiveprojectspr_gridrows"))
    {
    			SubscribeElementEvents_mf_projectlistactiveprojectspr_gridrows(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("edit"))
{
			SubscribeElementEvents_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("apply"))
{
			SubscribeElementEvents_apply(ref dfsParam);
}
		if(elementName.ToLower().Equals("add"))
{
			SubscribeElementEvents_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("save"))
{
			SubscribeElementEvents_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("cancel"))
{
			SubscribeElementEvents_cancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("mgg_v1_projecttitle"))
{
			SubscribeElementEvents_mgg_v1_projecttitle(ref dfsParam);
}
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


	public partial class AcDataISpace241BCCC0C68C4EFE8E694E620A010097  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"73F7289D-3EAA-4F8A-BE26-AB75389E53DC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MGG_V1_ProjectType",6,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_Duration",10,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ProjectDetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_PI",4,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_SanctionedValue",12,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_FinancialYear",11,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_Agency",7,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_EndDate",9,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_StartDate",8,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_Type",14,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ProjectTitle",1,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_CoPI",5,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_Department",3,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ProjectNo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"E8FBB04E-9AEE-43DA-BE29-6BCD8ACC6191", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"AFF3655B-3499-4535-98AE-BDCC545E8B7C", ""},
							{"A76EEF4D-5A15-4BCC-9DF8-97816A60E1BB", ""},
							{"E8FBB04E-9AEE-43DA-BE29-6BCD8ACC6191", ""},
							{"4ADA35F7-F1E6-4A61-9FBA-770C428D260D", ""},
							{"CF51AF4D-04CD-4A41-8FE6-116FBBACB018", ""},
							{"D6691ED3-7E2E-4C97-A609-8FDA2DC3B30D", ""},
							{"AEB62CF1-46EF-4862-99E4-3A1C939F7187", ""},
							{"BF5B1026-A178-41A8-A720-55E6D2019A3D", ""},
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
		


