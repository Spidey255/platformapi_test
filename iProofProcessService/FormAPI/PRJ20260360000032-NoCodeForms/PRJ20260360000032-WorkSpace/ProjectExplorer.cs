  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectExplorerProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 30256; }
        }

        public override string PackageName
        {
            get { return "PRJ20260360000032-WorkSpace"; }
        }

		public override string PackageDescription
        {
            get { return "WorkSpace"; }
        }

        public override string ProcessId
        {
            get { return "9A6BA2F8-BA9C-4B47-AA7B-3D3DBF97702F"; }
        }

        public override string ProcessName
        {
            get { return "ProjectExplorer"; }
        }

		public override string ProcessDescription
        {
            get { return "Project Explorer"; }
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
            get {return "9A6BA2F8-BA9C-4B47-AA7B-3D3DBF97702F";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "315654B7-01E3-4596-85CB-689C63D2550B";	}
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
	

	public partial class ProjectExplorerObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectExplorerProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("D969BE24-DCBC-40E8-9E85-2173A3059E67","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2C3E6AF8-ED91-4182-A4C4-478C8DB4B2A3"),
			
						
			     new Triplet<string, string, string>("336200EB-340A-4700-9AE5-ADB2066E0768","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2C3E6AF8-ED91-4182-A4C4-478C8DB4B2A3"),
			
						
			     new Triplet<string, string, string>("7B93032A-B467-4DF5-B5D0-33F26800D392","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2C3E6AF8-ED91-4182-A4C4-478C8DB4B2A3"),
			
						
			     new Triplet<string, string, string>("6537A662-FCE4-4DBC-B8DD-2EB8A5773A48","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("D969BE24-DCBC-40E8-9E85-2173A3059E67","Load Project Expected Outcomes",
												     @"5C4EC8C2-EAE6-4831-B233-7AD53A6CEC63"),
			
						
			     new Triplet<string, string, string>("336200EB-340A-4700-9AE5-ADB2066E0768","Grid Binding",
												     @"6EA8BDDF-9677-4141-8044-DD8A27F4FB75"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MGG_P1_ProjectCatId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"Exec GetPRojectCategory"),
			
						
			     new Triplet<string, string, string>("MF_P1_ProjectTypeId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"Exec GetPRojectType"),
			
						
			     new Triplet<string, string, string>("MGG_P1_ProjectTypeId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"Exec GetPRojectType"),
			
						
			     new Triplet<string, string, string>("MF_P1_ProjectSubCatId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"EXEC GetProjectSubCategory '@MF_P1_ProjectCatId'"),
			
						
			     new Triplet<string, string, string>("MGG_P1_ProjectSectorId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"Exec GetPRojectSector"),
			
						
			     new Triplet<string, string, string>("MGG_P1_ClientId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"exec GetClientDetails"),
			
						
			     new Triplet<string, string, string>("MF_ProjectDetails_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77q8ayfct700fBGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
			     new Triplet<string, string, string>("MF_P1_ProjectSectorId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"Exec GetPRojectSector"),
			
						
			     new Triplet<string, string, string>("MF_P1_ProjectCatId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"Exec GetPRojectCategory"),
			
						
			     new Triplet<string, string, string>("AI_Model","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"exec GetAIModels"),
			
						
			     new Triplet<string, string, string>("MF_P1_ClientId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77ahivmy33DF7BGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"Exec GetClientDetails"),
			
						
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
		
	  			
			     new Tuple<string, int>("ProjectDetails",5),
			
						
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
											case "E59BA35B-2DD0-48A9-A081-570CB37D862A":
							virtualInstance=new ISpaceE59BA35B2DD048A9A081570CB37D862A();
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
	

	public partial class ProjectExplorerDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectExplorerDataElementFactory()
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

               
                
                                      case "315654B7-01E3-4596-85CB-689C63D2550B":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [315654B7-01E3-4596-85CB-689C63D2550B] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [315654B7-01E3-4596-85CB-689C63D2550B](InstanceId,ProcessActivityMapId,FormId,MF_P1_ProjectSubCatId,MF_P1_Tags,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectDetails_GridRows,MF_ProjectDetails_RecordsRange,MF_ProjectDetails_PageIndex,MF_ProjectDetails_TotalPages,MF_ProjectCode,MF_P1_ProjectName,MF_P1_Description,MF_P1_ClientId,MF_P1_ProjectTypeId,MF_P1_ProjectSectorId,MF_P1_ProjectCatId,MF_P1_ProjectKickOffDate,MF_P1_TotalPlanedDays,MF_P1_StatusCode,MF_P1_UpdatedBy,MF_P1_UpdatedOn,F_ProjectName,MF_Option,MF_ProjectTypeId,RedirectUrl,MFM_ProjectName,AI_UserConcated,AI_IsLastPrompt,AI_ModuleId,AI_PMID,AI_ProcessesId,AI_PromptLevelId,AI_Request,AI_Response,AI_Model,AI_Temperature,AI_Max_Tokens,AI_Bearer,MF_ProjectImg,MF_Projectoverview,MF_BackFlag,AI_ContentType,AI_System,AI_User,MF_Status,M_ErrId,M_ErrMsg,M_Total,M_Active,M_InActive,M_Closed)  
       VALUES( {3}) END ELSE BEGIN UPDATE [315654B7-01E3-4596-85CB-689C63D2550B]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,MF_P1_ProjectSubCatId,MF_P1_Tags,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectDetails_GridRows,MF_ProjectDetails_RecordsRange,MF_ProjectDetails_PageIndex,MF_ProjectDetails_TotalPages,MF_ProjectCode,MF_P1_ProjectName,MF_P1_Description,MF_P1_ClientId,MF_P1_ProjectTypeId,MF_P1_ProjectSectorId,MF_P1_ProjectCatId,MF_P1_ProjectKickOffDate,MF_P1_TotalPlanedDays,MF_P1_StatusCode,MF_P1_UpdatedBy,MF_P1_UpdatedOn,F_ProjectName,MF_Option,MF_ProjectTypeId,RedirectUrl,MFM_ProjectName,AI_UserConcated,AI_IsLastPrompt,AI_ModuleId,AI_PMID,AI_ProcessesId,AI_PromptLevelId,AI_Request,AI_Response,AI_Model,AI_Temperature,AI_Max_Tokens,AI_Bearer,MF_ProjectImg,MF_Projectoverview,MF_BackFlag,AI_ContentType,AI_System,AI_User,MF_Status,M_ErrId,M_ErrMsg,M_Total,M_Active,M_InActive,M_Closed";
                                    
                     
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

                
                 
                                      case "5C4EC8C2-EAE6-4831-B233-7AD53A6CEC63":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_5C4EC8C2EAE64831B2337AD53A6CEC63 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [5C4EC8C2-EAE6-4831-B233-7AD53A6CEC63](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_5C4EC8C2EAE64831B2337AD53A6CEC63 TDT
							LEFT JOIN [5C4EC8C2-EAE6-4831-B233-7AD53A6CEC63] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_5C4EC8C2EAE64831B2337AD53A6CEC63(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "6EA8BDDF-9677-4141-8044-DD8A27F4FB75":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_6EA8BDDF967741418044DD8A27F4FB75 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [6EA8BDDF-9677-4141-8044-DD8A27F4FB75](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_6EA8BDDF967741418044DD8A27F4FB75 TDT
							LEFT JOIN [6EA8BDDF-9677-4141-8044-DD8A27F4FB75] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_6EA8BDDF967741418044DD8A27F4FB75(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "32A77387-4583-486F-A3E2-7A70CEBF35CC":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_32A773874583486FA3E27A70CEBF35CC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [32A77387-4583-486F-A3E2-7A70CEBF35CC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_32A773874583486FA3E27A70CEBF35CC TDT
							LEFT JOIN [32A77387-4583-486F-A3E2-7A70CEBF35CC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_32A773874583486FA3E27A70CEBF35CC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     

                                         case "5C4EC8C2-EAE6-4831-B233-7AD53A6CEC63":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_5C4EC8C2EAE64831B2337AD53A6CEC63 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [5C4EC8C2-EAE6-4831-B233-7AD53A6CEC63](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_5C4EC8C2EAE64831B2337AD53A6CEC63 TDT
							LEFT JOIN [5C4EC8C2-EAE6-4831-B233-7AD53A6CEC63] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_5C4EC8C2EAE64831B2337AD53A6CEC63(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "6EA8BDDF-9677-4141-8044-DD8A27F4FB75":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_6EA8BDDF967741418044DD8A27F4FB75 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [6EA8BDDF-9677-4141-8044-DD8A27F4FB75](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_6EA8BDDF967741418044DD8A27F4FB75 TDT
							LEFT JOIN [6EA8BDDF-9677-4141-8044-DD8A27F4FB75] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_6EA8BDDF967741418044DD8A27F4FB75(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "32A77387-4583-486F-A3E2-7A70CEBF35CC":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_32A773874583486FA3E27A70CEBF35CC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [32A77387-4583-486F-A3E2-7A70CEBF35CC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_32A773874583486FA3E27A70CEBF35CC TDT
							LEFT JOIN [32A77387-4583-486F-A3E2-7A70CEBF35CC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_32A773874583486FA3E27A70CEBF35CC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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
public class ISpaceE59BA35B2DD048A9A081570CB37D862A : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceE59BA35B2DD048A9A081570CB37D862A acdataIspaceE59BA35B2DD048A9A081570CB37D862A=new AcDataISpaceE59BA35B2DD048A9A081570CB37D862A();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetTaskSummary");

var querySource6537A662FCE44DBCB8DD2EB8A5773A48 =GetQueryExpressionDataSource("6537A662-FCE4-4DBC-B8DD-2EB8A5773A48");
Dictionary<short,object> result6537A662FCE44DBCB8DD2EB8A5773A48=iSpace.ExecuteQuery(querySource6537A662FCE44DBCB8DD2EB8A5773A48,@"EXEC GetTaskSummary",false);

base.WriteDebugInfo(@"var querySource6537A662FCE44DBCB8DD2EB8A5773A48 =GetQueryExpressionDataSource(""6537A662-FCE4-4DBC-B8DD-2EB8A5773A48"");Dictionary<short,object> result6537A662FCE44DBCB8DD2EB8A5773A48=iSpace.ExecuteQuery(querySource6537A662FCE44DBCB8DD2EB8A5773A48,@""EXEC GetTaskSummary"",false);");
base.WriteDebugInfo(@"");

if((result6537A662FCE44DBCB8DD2EB8A5773A48!=null) && (result6537A662FCE44DBCB8DD2EB8A5773A48.Count!=0))
{
if(result6537A662FCE44DBCB8DD2EB8A5773A48.ContainsKey(3))
ISpace["M_Closed"].Value = result6537A662FCE44DBCB8DD2EB8A5773A48[3];
if(result6537A662FCE44DBCB8DD2EB8A5773A48.ContainsKey(2))
ISpace["M_InActive"].Value = result6537A662FCE44DBCB8DD2EB8A5773A48[2];
if(result6537A662FCE44DBCB8DD2EB8A5773A48.ContainsKey(1))
ISpace["M_Active"].Value = result6537A662FCE44DBCB8DD2EB8A5773A48[1];
if(result6537A662FCE44DBCB8DD2EB8A5773A48.ContainsKey(0))
ISpace["M_Total"].Value = result6537A662FCE44DBCB8DD2EB8A5773A48[0];
}
else{
ISpace["M_Closed"].Value = null;ISpace["M_InActive"].Value = null;ISpace["M_Active"].Value = null;ISpace["M_Total"].Value = null;
}
}
if(ISpace["MF_ProjectCode"].Value!="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_ProjectCode""].Value!="""")");
base.WriteDebugInfo(@"EXEC GetProjectMasterDetails 0,'','#MF_ProjectCode'");

var querySource7B93032AB4674DF5B5D033F26800D392 =GetQueryExpressionDataSource("7B93032A-B467-4DF5-B5D0-33F26800D392");
Dictionary<short,object> result7B93032AB4674DF5B5D033F26800D392=iSpace.ExecuteQuery(querySource7B93032AB4674DF5B5D033F26800D392,@"EXEC GetProjectMasterDetails 0,'','" + ISpace["MF_ProjectCode"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7B93032AB4674DF5B5D033F26800D392 =GetQueryExpressionDataSource(""7B93032A-B467-4DF5-B5D0-33F26800D392"");Dictionary<short,object> result7B93032AB4674DF5B5D033F26800D392=iSpace.ExecuteQuery(querySource7B93032AB4674DF5B5D033F26800D392,@""EXEC GetProjectMasterDetails 0,'','"" + ISpace[""MF_ProjectCode""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT ProjectMaster.[ProjectCode], ProjectMaster.[ProjectName], ProjectMaster.[Description], ProjectMaster.[ClientId], ProjectMaster.[ProjectTypeId], ProjectMaster.[ProjectSectorId], ProjectMaster.[ProjectCatId], ProjectMaster.[ProjectKickOffDate], ProjectMaster.[TotalPlanedDays], ProjectMaster.[StatusCode], ProjectMaster.[UpdatedBy], ProjectMaster.[UpdatedOn] FROM  PRJDR..ProjectMaster  WHERE ProjectMaster.ProjectCode= '#MGG_P1_ProjectCode'");

if((result7B93032AB4674DF5B5D033F26800D392!=null) && (result7B93032AB4674DF5B5D033F26800D392.Count!=0))
{
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(17))
ISpace["MF_P1_Description"].Value = result7B93032AB4674DF5B5D033F26800D392[17];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(2))
ISpace["MF_Projectoverview"].Value = result7B93032AB4674DF5B5D033F26800D392[2];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(16))
ISpace["MF_ProjectImg"].Value = result7B93032AB4674DF5B5D033F26800D392[16];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(15))
ISpace["MF_P1_UpdatedOn"].Value = result7B93032AB4674DF5B5D033F26800D392[15];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(11))
ISpace["MF_P1_ProjectKickOffDate"].Value = result7B93032AB4674DF5B5D033F26800D392[11];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(7))
ISpace["MF_P1_ProjectSectorId"].Value = result7B93032AB4674DF5B5D033F26800D392[7];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(9))
ISpace["MF_P1_ProjectCatId"].Value = result7B93032AB4674DF5B5D033F26800D392[9];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(3))
ISpace["MF_P1_ClientId"].Value = result7B93032AB4674DF5B5D033F26800D392[3];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(5))
ISpace["MF_P1_ProjectTypeId"].Value = result7B93032AB4674DF5B5D033F26800D392[5];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(20))
ISpace["MF_P1_ProjectSubCatId"].Value = result7B93032AB4674DF5B5D033F26800D392[20];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(12))
ISpace["MF_P1_TotalPlanedDays"].Value = result7B93032AB4674DF5B5D033F26800D392[12];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(13))
ISpace["MF_P1_StatusCode"].Value = result7B93032AB4674DF5B5D033F26800D392[13];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(19))
ISpace["MF_P1_Tags"].Value = result7B93032AB4674DF5B5D033F26800D392[19];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(1))
ISpace["MF_P1_ProjectName"].Value = result7B93032AB4674DF5B5D033F26800D392[1];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(0))
ISpace["MF_ProjectCode"].Value = result7B93032AB4674DF5B5D033F26800D392[0];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(14))
ISpace["MF_P1_UpdatedBy"].Value = result7B93032AB4674DF5B5D033F26800D392[14];
}
else{
ISpace["MF_P1_Description"].Value = null;ISpace["MF_Projectoverview"].Value = null;ISpace["MF_ProjectImg"].Value = null;ISpace["MF_P1_UpdatedOn"].Value = null;ISpace["MF_P1_ProjectKickOffDate"].Value = null;ISpace["MF_P1_ProjectSectorId"].Value = null;ISpace["MF_P1_ProjectCatId"].Value = null;ISpace["MF_P1_ClientId"].Value = null;ISpace["MF_P1_ProjectTypeId"].Value = null;ISpace["MF_P1_ProjectSubCatId"].Value = null;ISpace["MF_P1_TotalPlanedDays"].Value = null;ISpace["MF_P1_StatusCode"].Value = null;ISpace["MF_P1_Tags"].Value = null;ISpace["MF_P1_ProjectName"].Value = null;ISpace["MF_ProjectCode"].Value = null;ISpace["MF_P1_UpdatedBy"].Value = null;
}
}

var querySourceD969BE24DCBC40E89E852173A3059E67 =GetQueryExpressionDataSource("D969BE24-DCBC-40E8-9E85-2173A3059E67");

DataTable resultD969BE24DCBC40E89E852173A3059E67=iSpace.SetGridDataSource(querySourceD969BE24DCBC40E89E852173A3059E67, _objectFactory.GetGridRPP("MG_ExpectedBenefits"),@"EXEC GetProjectBenefits '" + ISpace["MF_ProjectCode"].Value + @"'");

iSpace.InsertGridBindDetails("MG_ExpectedBenefits","11",querySourceD969BE24DCBC40E89E852173A3059E67,"EXEC GetProjectBenefits '" + ISpace["MF_ProjectCode"].Value + @"'",_objectFactory.GetGridRPP("MG_ExpectedBenefits"));

base.WriteDebugInfo(@"var querySourceD969BE24DCBC40E89E852173A3059E67 =GetQueryExpressionDataSource(""D969BE24-DCBC-40E8-9E85-2173A3059E67"");DataTable resultD969BE24DCBC40E89E852173A3059E67=iSpace.SetGridDataSource(querySourceD969BE24DCBC40E89E852173A3059E67, _objectFactory.GetGridRPP(""MG_ExpectedBenefits""),@""EXEC GetProjectBenefits '"" + ISpace[""MF_ProjectCode""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_ExpectedBenefits"",""11"",querySourceD969BE24DCBC40E89E852173A3059E67,""EXEC GetProjectBenefits '"" + ISpace[""MF_ProjectCode""].Value + @""'"",_objectFactory.GetGridRPP(""MG_ExpectedBenefits""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultC15E5B4A16F04AF49ECD396B51052190=acdataIspaceE59BA35B2DD048A9A081570CB37D862A.GetQueryExpressionBindings("C15E5B4A-16F0-4AF4-9ECD-396B51052190");
iSpace.SetGridData(resultD969BE24DCBC40E89E852173A3059E67,resultC15E5B4A16F04AF49ECD396B51052190,"MG_ExpectedBenefits",ref ISpace);
iSpace.UpdateGridBindDetails("MG_ExpectedBenefits",resultC15E5B4A16F04AF49ECD396B51052190);
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource336200EB340A47009AE5ADB2066E0768 =GetQueryExpressionDataSource("336200EB-340A-4700-9AE5-ADB2066E0768");

DataTable result336200EB340A47009AE5ADB2066E0768=iSpace.SetGridDataSource(querySource336200EB340A47009AE5ADB2066E0768, _objectFactory.GetGridRPP("ProjectDetails"),@"EXEC GetProjectMasterDetails 0,'',''");

iSpace.InsertGridBindDetails("ProjectDetails","11",querySource336200EB340A47009AE5ADB2066E0768,"EXEC GetProjectMasterDetails 0,'',''",_objectFactory.GetGridRPP("ProjectDetails"));

base.WriteDebugInfo(@"var querySource336200EB340A47009AE5ADB2066E0768 =GetQueryExpressionDataSource(""336200EB-340A-4700-9AE5-ADB2066E0768"");DataTable result336200EB340A47009AE5ADB2066E0768=iSpace.SetGridDataSource(querySource336200EB340A47009AE5ADB2066E0768, _objectFactory.GetGridRPP(""ProjectDetails""),@""EXEC GetProjectMasterDetails 0,'',''"");iSpace.InsertGridBindDetails(""ProjectDetails"",""11"",querySource336200EB340A47009AE5ADB2066E0768,""EXEC GetProjectMasterDetails 0,'',''"",_objectFactory.GetGridRPP(""ProjectDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_536f7a54-a2db-4800-8c79-4ee8f526183d_FilterData] 1,'#F_ProjectName','',#MF_ProjectDetails_PageIndex,'#MF_ProjectDetails_GridRows'");


List<Triplet<string, short, short?>> result34336948FEFB4027B1D04EC90F00919D=acdataIspaceE59BA35B2DD048A9A081570CB37D862A.GetQueryExpressionBindings("34336948-FEFB-4027-B1D0-4EC90F00919D");
iSpace.SetGridData(result336200EB340A47009AE5ADB2066E0768,result34336948FEFB4027B1D04EC90F00919D,"ProjectDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectDetails",result34336948FEFB4027B1D04EC90F00919D);

}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_back (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Back-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=59CFD5CE-04C3-40B8-B1AE-F709CF4C07C2&frmElementId=9302F258-223D-4232-97D9-30E6A8506B7C&PkPrMId=002BF3D2-F7FB-4EC1-BE21-5755727CB7D4&formVersionId=41CA950A-9FE3-4C8E-B6EE-166EF2ABA149&Ver=0.0000&IsDesignStudio=1";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=59CFD5CE-04C3-40B8-B1AE-F709CF4C07C2&frmElementId=9302F258-223D-4232-97D9-30E6A8506B7C&PkPrMId=002BF3D2-F7FB-4EC1-BE21-5755727CB7D4&formVersionId=41CA950A-9FE3-4C8E-B6EE-166EF2ABA149&Ver=0.0000&IsDesignStudio=1"";");
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

var querySource336200EB340A47009AE5ADB2066E0768 =GetQueryExpressionDataSource("336200EB-340A-4700-9AE5-ADB2066E0768");

DataTable result336200EB340A47009AE5ADB2066E0768=iSpace.SetGridDataSource(querySource336200EB340A47009AE5ADB2066E0768, _objectFactory.GetGridRPP("ProjectDetails"),@"EXEC GetProjectMasterDetails 0,'',''");

iSpace.InsertGridBindDetails("ProjectDetails","11",querySource336200EB340A47009AE5ADB2066E0768,"EXEC GetProjectMasterDetails 0,'',''",_objectFactory.GetGridRPP("ProjectDetails"));

base.WriteDebugInfo(@"var querySource336200EB340A47009AE5ADB2066E0768 =GetQueryExpressionDataSource(""336200EB-340A-4700-9AE5-ADB2066E0768"");DataTable result336200EB340A47009AE5ADB2066E0768=iSpace.SetGridDataSource(querySource336200EB340A47009AE5ADB2066E0768, _objectFactory.GetGridRPP(""ProjectDetails""),@""EXEC GetProjectMasterDetails 0,'',''"");iSpace.InsertGridBindDetails(""ProjectDetails"",""11"",querySource336200EB340A47009AE5ADB2066E0768,""EXEC GetProjectMasterDetails 0,'',''"",_objectFactory.GetGridRPP(""ProjectDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_536f7a54-a2db-4800-8c79-4ee8f526183d_FilterData] 1,'#F_ProjectName','',#MF_ProjectDetails_PageIndex,'#MF_ProjectDetails_GridRows'");


List<Triplet<string, short, short?>> result34336948FEFB4027B1D04EC90F00919D=acdataIspaceE59BA35B2DD048A9A081570CB37D862A.GetQueryExpressionBindings("34336948-FEFB-4027-B1D0-4EC90F00919D");
iSpace.SetGridData(result336200EB340A47009AE5ADB2066E0768,result34336948FEFB4027B1D04EC90F00919D,"ProjectDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectDetails",result34336948FEFB4027B1D04EC90F00919D);

}
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
ISpace["MF_ProjectCode"].Value=ISpace["MGG_P1_ProjectCode"].Value;
base.WriteDebugInfo(@"ISpace[""MF_ProjectCode""].Value=ISpace[""MGG_P1_ProjectCode""].Value;");
}
if(ISpace["MF_ProjectCode"].Value!="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_ProjectCode""].Value!="""")");
base.WriteDebugInfo(@"EXEC GetProjectMasterDetails 0,'','#MF_ProjectCode'");

var querySource7B93032AB4674DF5B5D033F26800D392 =GetQueryExpressionDataSource("7B93032A-B467-4DF5-B5D0-33F26800D392");
Dictionary<short,object> result7B93032AB4674DF5B5D033F26800D392=iSpace.ExecuteQuery(querySource7B93032AB4674DF5B5D033F26800D392,@"EXEC GetProjectMasterDetails 0,'','" + ISpace["MF_ProjectCode"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7B93032AB4674DF5B5D033F26800D392 =GetQueryExpressionDataSource(""7B93032A-B467-4DF5-B5D0-33F26800D392"");Dictionary<short,object> result7B93032AB4674DF5B5D033F26800D392=iSpace.ExecuteQuery(querySource7B93032AB4674DF5B5D033F26800D392,@""EXEC GetProjectMasterDetails 0,'','"" + ISpace[""MF_ProjectCode""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT ProjectMaster.[ProjectCode], ProjectMaster.[ProjectName], ProjectMaster.[Description], ProjectMaster.[ClientId], ProjectMaster.[ProjectTypeId], ProjectMaster.[ProjectSectorId], ProjectMaster.[ProjectCatId], ProjectMaster.[ProjectKickOffDate], ProjectMaster.[TotalPlanedDays], ProjectMaster.[StatusCode], ProjectMaster.[UpdatedBy], ProjectMaster.[UpdatedOn] FROM  PRJDR..ProjectMaster  WHERE ProjectMaster.ProjectCode= '#MGG_P1_ProjectCode'");

if((result7B93032AB4674DF5B5D033F26800D392!=null) && (result7B93032AB4674DF5B5D033F26800D392.Count!=0))
{
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(17))
ISpace["MF_P1_Description"].Value = result7B93032AB4674DF5B5D033F26800D392[17];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(2))
ISpace["MF_Projectoverview"].Value = result7B93032AB4674DF5B5D033F26800D392[2];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(16))
ISpace["MF_ProjectImg"].Value = result7B93032AB4674DF5B5D033F26800D392[16];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(15))
ISpace["MF_P1_UpdatedOn"].Value = result7B93032AB4674DF5B5D033F26800D392[15];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(11))
ISpace["MF_P1_ProjectKickOffDate"].Value = result7B93032AB4674DF5B5D033F26800D392[11];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(7))
ISpace["MF_P1_ProjectSectorId"].Value = result7B93032AB4674DF5B5D033F26800D392[7];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(9))
ISpace["MF_P1_ProjectCatId"].Value = result7B93032AB4674DF5B5D033F26800D392[9];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(3))
ISpace["MF_P1_ClientId"].Value = result7B93032AB4674DF5B5D033F26800D392[3];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(5))
ISpace["MF_P1_ProjectTypeId"].Value = result7B93032AB4674DF5B5D033F26800D392[5];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(20))
ISpace["MF_P1_ProjectSubCatId"].Value = result7B93032AB4674DF5B5D033F26800D392[20];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(12))
ISpace["MF_P1_TotalPlanedDays"].Value = result7B93032AB4674DF5B5D033F26800D392[12];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(13))
ISpace["MF_P1_StatusCode"].Value = result7B93032AB4674DF5B5D033F26800D392[13];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(19))
ISpace["MF_P1_Tags"].Value = result7B93032AB4674DF5B5D033F26800D392[19];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(1))
ISpace["MF_P1_ProjectName"].Value = result7B93032AB4674DF5B5D033F26800D392[1];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(0))
ISpace["MF_ProjectCode"].Value = result7B93032AB4674DF5B5D033F26800D392[0];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(14))
ISpace["MF_P1_UpdatedBy"].Value = result7B93032AB4674DF5B5D033F26800D392[14];
}
else{
ISpace["MF_P1_Description"].Value = null;ISpace["MF_Projectoverview"].Value = null;ISpace["MF_ProjectImg"].Value = null;ISpace["MF_P1_UpdatedOn"].Value = null;ISpace["MF_P1_ProjectKickOffDate"].Value = null;ISpace["MF_P1_ProjectSectorId"].Value = null;ISpace["MF_P1_ProjectCatId"].Value = null;ISpace["MF_P1_ClientId"].Value = null;ISpace["MF_P1_ProjectTypeId"].Value = null;ISpace["MF_P1_ProjectSubCatId"].Value = null;ISpace["MF_P1_TotalPlanedDays"].Value = null;ISpace["MF_P1_StatusCode"].Value = null;ISpace["MF_P1_Tags"].Value = null;ISpace["MF_P1_ProjectName"].Value = null;ISpace["MF_ProjectCode"].Value = null;ISpace["MF_P1_UpdatedBy"].Value = null;
}
}

var querySourceD969BE24DCBC40E89E852173A3059E67 =GetQueryExpressionDataSource("D969BE24-DCBC-40E8-9E85-2173A3059E67");

DataTable resultD969BE24DCBC40E89E852173A3059E67=iSpace.SetGridDataSource(querySourceD969BE24DCBC40E89E852173A3059E67, _objectFactory.GetGridRPP("MG_ExpectedBenefits"),@"EXEC GetProjectBenefits '" + ISpace["MF_ProjectCode"].Value + @"'");

iSpace.InsertGridBindDetails("MG_ExpectedBenefits","11",querySourceD969BE24DCBC40E89E852173A3059E67,"EXEC GetProjectBenefits '" + ISpace["MF_ProjectCode"].Value + @"'",_objectFactory.GetGridRPP("MG_ExpectedBenefits"));

base.WriteDebugInfo(@"var querySourceD969BE24DCBC40E89E852173A3059E67 =GetQueryExpressionDataSource(""D969BE24-DCBC-40E8-9E85-2173A3059E67"");DataTable resultD969BE24DCBC40E89E852173A3059E67=iSpace.SetGridDataSource(querySourceD969BE24DCBC40E89E852173A3059E67, _objectFactory.GetGridRPP(""MG_ExpectedBenefits""),@""EXEC GetProjectBenefits '"" + ISpace[""MF_ProjectCode""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_ExpectedBenefits"",""11"",querySourceD969BE24DCBC40E89E852173A3059E67,""EXEC GetProjectBenefits '"" + ISpace[""MF_ProjectCode""].Value + @""'"",_objectFactory.GetGridRPP(""MG_ExpectedBenefits""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultC15E5B4A16F04AF49ECD396B51052190=acdataIspaceE59BA35B2DD048A9A081570CB37D862A.GetQueryExpressionBindings("C15E5B4A-16F0-4AF4-9ECD-396B51052190");
iSpace.SetGridData(resultD969BE24DCBC40E89E852173A3059E67,resultC15E5B4A16F04AF49ECD396B51052190,"MG_ExpectedBenefits",ref ISpace);
iSpace.UpdateGridBindDetails("MG_ExpectedBenefits",resultC15E5B4A16F04AF49ECD396B51052190);
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

var querySource336200EB340A47009AE5ADB2066E0768 =GetQueryExpressionDataSource("336200EB-340A-4700-9AE5-ADB2066E0768");

DataTable result336200EB340A47009AE5ADB2066E0768=iSpace.SetGridDataSource(querySource336200EB340A47009AE5ADB2066E0768, _objectFactory.GetGridRPP("ProjectDetails"),@"EXEC GetProjectMasterDetails 0,'',''");

iSpace.InsertGridBindDetails("ProjectDetails","11",querySource336200EB340A47009AE5ADB2066E0768,"EXEC GetProjectMasterDetails 0,'',''",_objectFactory.GetGridRPP("ProjectDetails"));

base.WriteDebugInfo(@"var querySource336200EB340A47009AE5ADB2066E0768 =GetQueryExpressionDataSource(""336200EB-340A-4700-9AE5-ADB2066E0768"");DataTable result336200EB340A47009AE5ADB2066E0768=iSpace.SetGridDataSource(querySource336200EB340A47009AE5ADB2066E0768, _objectFactory.GetGridRPP(""ProjectDetails""),@""EXEC GetProjectMasterDetails 0,'',''"");iSpace.InsertGridBindDetails(""ProjectDetails"",""11"",querySource336200EB340A47009AE5ADB2066E0768,""EXEC GetProjectMasterDetails 0,'',''"",_objectFactory.GetGridRPP(""ProjectDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_536f7a54-a2db-4800-8c79-4ee8f526183d_FilterData] 1,'#F_ProjectName','',#MF_ProjectDetails_PageIndex,'#MF_ProjectDetails_GridRows'");


List<Triplet<string, short, short?>> result34336948FEFB4027B1D04EC90F00919D=acdataIspaceE59BA35B2DD048A9A081570CB37D862A.GetQueryExpressionBindings("34336948-FEFB-4027-B1D0-4EC90F00919D");
iSpace.SetGridData(result336200EB340A47009AE5ADB2066E0768,result34336948FEFB4027B1D04EC90F00919D,"ProjectDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectDetails",result34336948FEFB4027B1D04EC90F00919D);

}
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
if(ISpace["MF_ProjectCode"].Value!="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_ProjectCode""].Value!="""")");
base.WriteDebugInfo(@"EXEC GetProjectMasterDetails 0,'','#MF_ProjectCode'");

var querySource7B93032AB4674DF5B5D033F26800D392 =GetQueryExpressionDataSource("7B93032A-B467-4DF5-B5D0-33F26800D392");
Dictionary<short,object> result7B93032AB4674DF5B5D033F26800D392=iSpace.ExecuteQuery(querySource7B93032AB4674DF5B5D033F26800D392,@"EXEC GetProjectMasterDetails 0,'','" + ISpace["MF_ProjectCode"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7B93032AB4674DF5B5D033F26800D392 =GetQueryExpressionDataSource(""7B93032A-B467-4DF5-B5D0-33F26800D392"");Dictionary<short,object> result7B93032AB4674DF5B5D033F26800D392=iSpace.ExecuteQuery(querySource7B93032AB4674DF5B5D033F26800D392,@""EXEC GetProjectMasterDetails 0,'','"" + ISpace[""MF_ProjectCode""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT ProjectMaster.[ProjectCode], ProjectMaster.[ProjectName], ProjectMaster.[Description], ProjectMaster.[ClientId], ProjectMaster.[ProjectTypeId], ProjectMaster.[ProjectSectorId], ProjectMaster.[ProjectCatId], ProjectMaster.[ProjectKickOffDate], ProjectMaster.[TotalPlanedDays], ProjectMaster.[StatusCode], ProjectMaster.[UpdatedBy], ProjectMaster.[UpdatedOn] FROM  PRJDR..ProjectMaster  WHERE ProjectMaster.ProjectCode= '#MGG_P1_ProjectCode'");

if((result7B93032AB4674DF5B5D033F26800D392!=null) && (result7B93032AB4674DF5B5D033F26800D392.Count!=0))
{
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(17))
ISpace["MF_P1_Description"].Value = result7B93032AB4674DF5B5D033F26800D392[17];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(2))
ISpace["MF_Projectoverview"].Value = result7B93032AB4674DF5B5D033F26800D392[2];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(16))
ISpace["MF_ProjectImg"].Value = result7B93032AB4674DF5B5D033F26800D392[16];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(15))
ISpace["MF_P1_UpdatedOn"].Value = result7B93032AB4674DF5B5D033F26800D392[15];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(11))
ISpace["MF_P1_ProjectKickOffDate"].Value = result7B93032AB4674DF5B5D033F26800D392[11];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(7))
ISpace["MF_P1_ProjectSectorId"].Value = result7B93032AB4674DF5B5D033F26800D392[7];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(9))
ISpace["MF_P1_ProjectCatId"].Value = result7B93032AB4674DF5B5D033F26800D392[9];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(3))
ISpace["MF_P1_ClientId"].Value = result7B93032AB4674DF5B5D033F26800D392[3];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(5))
ISpace["MF_P1_ProjectTypeId"].Value = result7B93032AB4674DF5B5D033F26800D392[5];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(20))
ISpace["MF_P1_ProjectSubCatId"].Value = result7B93032AB4674DF5B5D033F26800D392[20];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(12))
ISpace["MF_P1_TotalPlanedDays"].Value = result7B93032AB4674DF5B5D033F26800D392[12];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(13))
ISpace["MF_P1_StatusCode"].Value = result7B93032AB4674DF5B5D033F26800D392[13];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(19))
ISpace["MF_P1_Tags"].Value = result7B93032AB4674DF5B5D033F26800D392[19];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(1))
ISpace["MF_P1_ProjectName"].Value = result7B93032AB4674DF5B5D033F26800D392[1];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(0))
ISpace["MF_ProjectCode"].Value = result7B93032AB4674DF5B5D033F26800D392[0];
if(result7B93032AB4674DF5B5D033F26800D392.ContainsKey(14))
ISpace["MF_P1_UpdatedBy"].Value = result7B93032AB4674DF5B5D033F26800D392[14];
}
else{
ISpace["MF_P1_Description"].Value = null;ISpace["MF_Projectoverview"].Value = null;ISpace["MF_ProjectImg"].Value = null;ISpace["MF_P1_UpdatedOn"].Value = null;ISpace["MF_P1_ProjectKickOffDate"].Value = null;ISpace["MF_P1_ProjectSectorId"].Value = null;ISpace["MF_P1_ProjectCatId"].Value = null;ISpace["MF_P1_ClientId"].Value = null;ISpace["MF_P1_ProjectTypeId"].Value = null;ISpace["MF_P1_ProjectSubCatId"].Value = null;ISpace["MF_P1_TotalPlanedDays"].Value = null;ISpace["MF_P1_StatusCode"].Value = null;ISpace["MF_P1_Tags"].Value = null;ISpace["MF_P1_ProjectName"].Value = null;ISpace["MF_ProjectCode"].Value = null;ISpace["MF_P1_UpdatedBy"].Value = null;
}
}

var querySourceD969BE24DCBC40E89E852173A3059E67 =GetQueryExpressionDataSource("D969BE24-DCBC-40E8-9E85-2173A3059E67");

DataTable resultD969BE24DCBC40E89E852173A3059E67=iSpace.SetGridDataSource(querySourceD969BE24DCBC40E89E852173A3059E67, _objectFactory.GetGridRPP("MG_ExpectedBenefits"),@"EXEC GetProjectBenefits '" + ISpace["MF_ProjectCode"].Value + @"'");

iSpace.InsertGridBindDetails("MG_ExpectedBenefits","11",querySourceD969BE24DCBC40E89E852173A3059E67,"EXEC GetProjectBenefits '" + ISpace["MF_ProjectCode"].Value + @"'",_objectFactory.GetGridRPP("MG_ExpectedBenefits"));

base.WriteDebugInfo(@"var querySourceD969BE24DCBC40E89E852173A3059E67 =GetQueryExpressionDataSource(""D969BE24-DCBC-40E8-9E85-2173A3059E67"");DataTable resultD969BE24DCBC40E89E852173A3059E67=iSpace.SetGridDataSource(querySourceD969BE24DCBC40E89E852173A3059E67, _objectFactory.GetGridRPP(""MG_ExpectedBenefits""),@""EXEC GetProjectBenefits '"" + ISpace[""MF_ProjectCode""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_ExpectedBenefits"",""11"",querySourceD969BE24DCBC40E89E852173A3059E67,""EXEC GetProjectBenefits '"" + ISpace[""MF_ProjectCode""].Value + @""'"",_objectFactory.GetGridRPP(""MG_ExpectedBenefits""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultC15E5B4A16F04AF49ECD396B51052190=acdataIspaceE59BA35B2DD048A9A081570CB37D862A.GetQueryExpressionBindings("C15E5B4A-16F0-4AF4-9ECD-396B51052190");
iSpace.SetGridData(resultD969BE24DCBC40E89E852173A3059E67,resultC15E5B4A16F04AF49ECD396B51052190,"MG_ExpectedBenefits",ref ISpace);
iSpace.UpdateGridBindDetails("MG_ExpectedBenefits",resultC15E5B4A16F04AF49ECD396B51052190);
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
		if(elementName.ToLower().Equals("mf_back"))
{
			SubscribeElementEvents_mf_back(ref dfsParam);
}
		if(elementName.ToLower().Equals("save"))
{
			SubscribeElementEvents_save(ref dfsParam);
}
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


	public partial class AcDataISpaceE59BA35B2DD048A9A081570CB37D862A  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"34336948-FEFB-4027-B1D0-4EC90F00919D", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MGG_P1_ClientId",4,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_Description",17,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ProjectCatId",10,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ProjectCode",0,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ProjectImage",16,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ProjectKickOffDate",11,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ProjectName",1,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ProjectSectorId",8,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ProjectTypeId",6,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_StatusCode",13,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_TotalPlanedDays",12,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_UpdatedOn",15,
														   -1),
								}
			},
							{"C15E5B4A-16F0-4AF4-9ECD-396B51052190", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("EB_BenefitId",0,
														   -1),
								   new Triplet<string, short, short?>("EB_Comments",4,
														   -1),
								   new Triplet<string, short, short?>("EB_DimensionId",1,
														   -1),
								   new Triplet<string, short, short?>("EB_Dimensions",2,
														   -1),
								   new Triplet<string, short, short?>("EB_ExpectedOutcome",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"C9237A1E-C4E4-47F8-9FFA-0183797B6FDF", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"B7CDD11B-2536-4572-9CCA-DC00187DC85F", ""},
							{"DFD9DD3C-5A36-4C7C-AED8-245B6EBB9281", ""},
							{"C9237A1E-C4E4-47F8-9FFA-0183797B6FDF", ""},
							{"D8E53297-6607-41AE-83BD-7F5D75E71594", ""},
							{"82919FFF-2C7B-44EC-A66A-DFAD6B5F69C1", ""},
							{"950A7842-E710-4B1D-91AD-5ADE399C6DA5", ""},
							{"BC0CD790-FA4B-47EA-8CD9-B953179BB841", ""},
							{"6B95D6E5-B579-4899-BDCA-3BDBBFCF54BC", ""},
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
		


