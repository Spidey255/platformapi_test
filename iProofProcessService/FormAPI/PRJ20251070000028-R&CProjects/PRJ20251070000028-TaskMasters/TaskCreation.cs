  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TaskCreationProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 30241; }
        }

        public override string PackageName
        {
            get { return "PRJ20251070000028 - Task Masters"; }
        }

		public override string PackageDescription
        {
            get { return "Task Masters"; }
        }

        public override string ProcessId
        {
            get { return "3cfe092a-c9df-42bd-bb7a-d4a6e90379fc"; }
        }

        public override string ProcessName
        {
            get { return "TaskCreation"; }
        }

		public override string ProcessDescription
        {
            get { return "Task Creation"; }
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
            get {return "3cfe092a-c9df-42bd-bb7a-d4a6e90379fc";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A";	}
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
	

	public partial class TaskCreationObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TaskCreationProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("A21D03C1-1176-4F35-A734-68BA9A98FF91","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("D2758C07-ECD7-4E4E-9A72-0E59AF0C791B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("B30DE496-533A-48F9-86FD-361791E9522A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("C33143FA-6306-43D4-805B-3B3277053C6F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("25420DB7-4D09-4FEB-8E01-4AF2D8A835BA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("B30DE496-533A-48F9-86FD-361791E9522A","Grid Binding4",
												     @"4EA7F6C5-7148-44C1-A8EF-2BB10145EC09"),
			
						
			     new Triplet<string, string, string>("C33143FA-6306-43D4-805B-3B3277053C6F","Grid BindingC",
												     @"4EA7F6C5-7148-44C1-A8EF-2BB10145EC09"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_w1_complexity_code","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77npyn1aWPGFOCecExdgZwESRUvAQUkQSXMQqGc4bTspeEien72gMAsQ==",
												     @"EXEC GetTaskCombos 1"),
			
						
			     new Triplet<string, string, string>("MF_w1_task_status","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77npyn1aWPGFOCecExdgZwESRUvAQUkQSXMQqGc4bTspeEien72gMAsQ==",
												     @"EXEC GetTaskCombos 4"),
			
						
			     new Triplet<string, string, string>("MF_w1_requirement_id","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77npyn1aWPGFOCecExdgZwESRUvAQUkQSXMQqGc4bTspeEien72gMAsQ==",
												     @"EXEC GetTaskCombos 2"),
			
						
			     new Triplet<string, string, string>("MF_w1_task_type_code","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77npyn1aWPGFOCecExdgZwESRUvAQUkQSXMQqGc4bTspeEien72gMAsQ==",
												     @"EXEC GetTaskCombos 3"),
			
						
			     new Triplet<string, string, string>("MFG_w2_step_state","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77npyn1aWPGFOCecExdgZwESRUvAQUkQSXMQqGc4bTspeEien72gMAsQ==",
												     @"EXEC GetTaskCombos 4"),
			
						
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
		
	  			
			     new Tuple<string, int>("TaskStep",25),
			
						
			     new Tuple<string, int>("TaskStep",5),
			
						
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
											case "5EC89147-2FE2-40AF-8446-350FE5E13C57":
							virtualInstance=new ISpace5EC891472FE240AF8446350FE5E13C57();
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
	

	public partial class TaskCreationDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TaskCreationDataElementFactory()
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

               
                
                                      case "74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A](InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_w1_task_id,MF_w1_task_code,MF_w1_task_name,MF_w1_task_type_code,MF_w1_complexity_code,MF_w1_requirement_id,MF_w1_task_status,MF_w1_is_active,MF_w1_created_at,MF_w1_created_by,MF_w1_updated_by,MF_w1_updated_at,MFG_w2_step_id,MFG_w2_task_description,MFG_w2_task_id,MFG_w2_step_state,MFG_w2_step_sequence,MFG_w2_updated_at,MFG_w2_updated_by,MFG_w2_created_by,MFG_w2_created_at,MFG_w2_is_active,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid)  
       VALUES( {3}) END ELSE BEGIN UPDATE [74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_w1_task_id,MF_w1_task_code,MF_w1_task_name,MF_w1_task_type_code,MF_w1_complexity_code,MF_w1_requirement_id,MF_w1_task_status,MF_w1_is_active,MF_w1_created_at,MF_w1_created_by,MF_w1_updated_by,MF_w1_updated_at,MFG_w2_step_id,MFG_w2_task_description,MFG_w2_task_id,MFG_w2_step_state,MFG_w2_step_sequence,MFG_w2_updated_at,MFG_w2_updated_by,MFG_w2_created_by,MFG_w2_created_at,MFG_w2_is_active,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid";
                                    
                     
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

                
                 
                                      case "4EA7F6C5-7148-44C1-A8EF-2BB10145EC09":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w2_step_id] INT	, [MG_w2_task_description] VARCHAR(50)	, [MG_w2_task_id] INT	, [MG_w2_step_state] VARCHAR(50)	, [MG_w2_updated_at] DATETIME	, [MG_w2_updated_by] INT	, [MG_w2_created_by] INT	, [MG_w2_created_at] DATETIME	, [MG_w2_is_active] BIT){0}INSERT INTO [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w2_step_id,TDT.MG_w2_task_description,TDT.MG_w2_task_id,TDT.MG_w2_step_state,TDT.MG_w2_updated_at,TDT.MG_w2_updated_by,TDT.MG_w2_created_by,TDT.MG_w2_created_at,TDT.MG_w2_is_active FROM @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 TDT
							LEFT JOIN [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active";

                                     tempInsertQuery=@"INSERT INTO @TBL_4EA7F6C5714844C1A8EF2BB10145EC09(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active)VALUES({0});";
                                     

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
                     

                                         case "4EA7F6C5-7148-44C1-A8EF-2BB10145EC09":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w2_step_id] INT	, [MG_w2_task_description] VARCHAR(50)	, [MG_w2_task_id] INT	, [MG_w2_step_state] VARCHAR(50)	, [MG_w2_updated_at] DATETIME	, [MG_w2_updated_by] INT	, [MG_w2_created_by] INT	, [MG_w2_created_at] DATETIME	, [MG_w2_is_active] BIT){0}INSERT INTO [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w2_step_id,TDT.MG_w2_task_description,TDT.MG_w2_task_id,TDT.MG_w2_step_state,TDT.MG_w2_updated_at,TDT.MG_w2_updated_by,TDT.MG_w2_created_by,TDT.MG_w2_created_at,TDT.MG_w2_is_active FROM @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 TDT
							LEFT JOIN [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active";

                            tempInsertQuery=@"INSERT INTO @TBL_4EA7F6C5714844C1A8EF2BB10145EC09(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active)VALUES({0});";

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
public class ISpace5EC891472FE240AF8446350FE5E13C57 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace5EC891472FE240AF8446350FE5E13C57 acdataIspace5EC891472FE240AF8446350FE5E13C57=new AcDataISpace5EC891472FE240AF8446350FE5E13C57();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
Dictionary<short, object> keyValuePairs = null;base.WriteDebugInfo(@"Root-OnAfterFormLoad");

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_w1_task_type_code"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_w1_task_type_code""].Value=="""")");
ISpace["Message"].Value=@"Please select Task Type Code and Proceed";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Task Type Code and Proceed"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_w1_task_name"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_w1_task_name""].Value=="""")");
ISpace["Message"].Value=@"Please fill Task Name and Proceed";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please fill Task Name and Proceed"";");
return;
base.WriteDebugInfo(@"return;");
}
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_3cfe092a-c9df-42bd-bb7a-d4a6e90379fc]  #MF_w1_task_id,'#MF_w1_task_code','#MF_w1_task_name','#MF_w1_task_type_code','#MF_w1_complexity_code','#MF_w1_requirement_id','#MF_w1_task_status',#MF_w1_is_active,'#MF_w1_created_at',#MF_w1_created_by,#MF_w1_updated_by,'#MF_w1_updated_at'");

var querySourceD2758C07ECD74E4E9A720E59AF0C791B =GetQueryExpressionDataSource("D2758C07-ECD7-4E4E-9A72-0E59AF0C791B");
Dictionary<short,object> resultD2758C07ECD74E4E9A720E59AF0C791B=iSpace.ExecuteQuery(querySourceD2758C07ECD74E4E9A720E59AF0C791B,@"EXEC InnovaceNoCode..[FormSave_3cfe092a-c9df-42bd-bb7a-d4a6e90379fc]  " + ISpace["MF_w1_task_id"].Value + @",'" + ISpace["MF_w1_task_code"].Value + @"','" + ISpace["MF_w1_task_name"].Value + @"','" + ISpace["MF_w1_task_type_code"].Value + @"','" + ISpace["MF_w1_complexity_code"].Value + @"','" + ISpace["MF_w1_requirement_id"].Value + @"','" + ISpace["MF_w1_task_status"].Value + @"'," + ISpace["MF_w1_is_active"].Value + @",'" + ISpace["MF_w1_created_at"].Value + @"'," + ISpace["MF_w1_created_by"].Value + @"," + ISpace["MF_w1_updated_by"].Value + @",'" + ISpace["MF_w1_updated_at"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceD2758C07ECD74E4E9A720E59AF0C791B =GetQueryExpressionDataSource(""D2758C07-ECD7-4E4E-9A72-0E59AF0C791B"");Dictionary<short,object> resultD2758C07ECD74E4E9A720E59AF0C791B=iSpace.ExecuteQuery(querySourceD2758C07ECD74E4E9A720E59AF0C791B,@""EXEC InnovaceNoCode..[FormSave_3cfe092a-c9df-42bd-bb7a-d4a6e90379fc]  "" + ISpace[""MF_w1_task_id""].Value + @"",'"" + ISpace[""MF_w1_task_code""].Value + @""','"" + ISpace[""MF_w1_task_name""].Value + @""','"" + ISpace[""MF_w1_task_type_code""].Value + @""','"" + ISpace[""MF_w1_complexity_code""].Value + @""','"" + ISpace[""MF_w1_requirement_id""].Value + @""','"" + ISpace[""MF_w1_task_status""].Value + @""',"" + ISpace[""MF_w1_is_active""].Value + @"",'"" + ISpace[""MF_w1_created_at""].Value + @""',"" + ISpace[""MF_w1_created_by""].Value + @"","" + ISpace[""MF_w1_updated_by""].Value + @"",'"" + ISpace[""MF_w1_updated_at""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultD2758C07ECD74E4E9A720E59AF0C791B!=null) && (resultD2758C07ECD74E4E9A720E59AF0C791B.Count!=0))
{
if(resultD2758C07ECD74E4E9A720E59AF0C791B.ContainsKey(0))
ISpace["Subject"].Value = resultD2758C07ECD74E4E9A720E59AF0C791B[0];
}
else{
ISpace["Subject"].Value = null;
}
base.WriteDebugInfo(@"#TaskStep[Rows]");
iSpace.GetLoopExpressionData("TaskStep",ref ISpace);

foreach(var gridChild in ISpace["TaskStep"].Child)
{foreach(var gridrow in gridChild.Child)

{
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  #MG_w2_step_id,'#MG_w2_task_description',#MG_w2_task_id,'#MG_w2_step_state',#TaskStep_Sequence,'#MG_w2_updated_at',#MG_w2_updated_by,#MG_w2_created_by,'#MG_w2_created_at',#MG_w2_is_active");

var querySource25420DB74D094FEB8E014AF2D8A835BA =GetQueryExpressionDataSource("25420DB7-4D09-4FEB-8E01-4AF2D8A835BA");
Dictionary<short,object> result25420DB74D094FEB8E014AF2D8A835BA=iSpace.ExecuteQuery(querySource25420DB74D094FEB8E014AF2D8A835BA,@"EXEC InnovaceNoCode..[GridSave_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  " + ISpace["MG_w2_step_id"].Value + @",'" + ISpace["MG_w2_task_description"].Value + @"'," + ISpace["MG_w2_task_id"].Value + @",'" + ISpace["MG_w2_step_state"].Value + @"'," + ISpace["TaskStep_Sequence"].Value + @",'" + ISpace["MG_w2_updated_at"].Value + @"'," + ISpace["MG_w2_updated_by"].Value + @"," + ISpace["MG_w2_created_by"].Value + @",'" + ISpace["MG_w2_created_at"].Value + @"'," + ISpace["MG_w2_is_active"].Value + @"",false);

base.WriteDebugInfo(@"var querySource25420DB74D094FEB8E014AF2D8A835BA =GetQueryExpressionDataSource(""25420DB7-4D09-4FEB-8E01-4AF2D8A835BA"");Dictionary<short,object> result25420DB74D094FEB8E014AF2D8A835BA=iSpace.ExecuteQuery(querySource25420DB74D094FEB8E014AF2D8A835BA,@""EXEC InnovaceNoCode..[GridSave_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  "" + ISpace[""MG_w2_step_id""].Value + @"",'"" + ISpace[""MG_w2_task_description""].Value + @""',"" + ISpace[""MG_w2_task_id""].Value + @"",'"" + ISpace[""MG_w2_step_state""].Value + @""',"" + ISpace[""TaskStep_Sequence""].Value + @"",'"" + ISpace[""MG_w2_updated_at""].Value + @""',"" + ISpace[""MG_w2_updated_by""].Value + @"","" + ISpace[""MG_w2_created_by""].Value + @"",'"" + ISpace[""MG_w2_created_at""].Value + @""',"" + ISpace[""MG_w2_is_active""].Value + @"""",false);");
base.WriteDebugInfo(@"");

if((result25420DB74D094FEB8E014AF2D8A835BA!=null) && (result25420DB74D094FEB8E014AF2D8A835BA.Count!=0))
{
if(result25420DB74D094FEB8E014AF2D8A835BA.ContainsKey(0))
ISpace["Subject"].Value = result25420DB74D094FEB8E014AF2D8A835BA[0];
}
else{
ISpace["Subject"].Value = null;
}
}
}
iSpace.SetLoopExpressionData("TaskStep","4EA7F6C5-7148-44C1-A8EF-2BB10145EC09",_objectFactory.GetGridRPP("TaskStep"),_elementBase.GetGridLoopQuery("4EA7F6C5-7148-44C1-A8EF-2BB10145EC09","TaskStep",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""TaskStep"",ref ISpace);

foreach(var gridChild in ISpace[""TaskStep""].Child)
{foreach(var gridrow in gridChild.Child)
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_back (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Back-OnClick");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=5B035305-E81B-4571-BBE4-724D00438E54&frmElementId=AF23D0EC-36C6-4FB1-8C58-BE89BD0BC74D&PkPrMId=7e6b302b-b86e-4442-a995-03bc22d48abc&formVersionId=C75E5B7B-EA0D-42F6-8C53-22D5D2071CCA&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=5B035305-E81B-4571-BBE4-724D00438E54&frmElementId=AF23D0EC-36C6-4FB1-8C58-BE89BD0BC74D&PkPrMId=7e6b302b-b86e-4442-a995-03bc22d48abc&formVersionId=C75E5B7B-EA0D-42F6-8C53-22D5D2071CCA&Ver=0.0000"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_taskstep (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_TaskStep-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceB30DE496533A48F986FD361791E9522A =GetQueryExpressionDataSource("B30DE496-533A-48F9-86FD-361791E9522A");

DataTable resultB30DE496533A48F986FD361791E9522A=iSpace.SetGridDataSource(querySourceB30DE496533A48F986FD361791E9522A, _objectFactory.GetGridRPP("TaskStep"),@"EXEC AddFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["gv_activitymapid"].Value + @"'," + ISpace["MFG_w2_step_id"].Value + @",'" + ISpace["MFG_w2_task_description"].Value + @"'," + ISpace["MFG_w2_task_id"].Value + @",'" + ISpace["MFG_w2_step_state"].Value + @"'," + ISpace["MFG_w2_step_sequence"].Value + @",'" + ISpace["MFG_w2_updated_at"].Value + @"'," + ISpace["MFG_w2_updated_by"].Value + @"," + ISpace["MFG_w2_created_by"].Value + @",'" + ISpace["MFG_w2_created_at"].Value + @"'," + ISpace["MFG_w2_is_active"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TaskStep","11",querySourceB30DE496533A48F986FD361791E9522A,"EXEC AddFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["gv_activitymapid"].Value + @"'," + ISpace["MFG_w2_step_id"].Value + @",'" + ISpace["MFG_w2_task_description"].Value + @"'," + ISpace["MFG_w2_task_id"].Value + @",'" + ISpace["MFG_w2_step_state"].Value + @"'," + ISpace["MFG_w2_step_sequence"].Value + @",'" + ISpace["MFG_w2_updated_at"].Value + @"'," + ISpace["MFG_w2_updated_by"].Value + @"," + ISpace["MFG_w2_created_by"].Value + @",'" + ISpace["MFG_w2_created_at"].Value + @"'," + ISpace["MFG_w2_is_active"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TaskStep"));

base.WriteDebugInfo(@"var querySourceB30DE496533A48F986FD361791E9522A =GetQueryExpressionDataSource(""B30DE496-533A-48F9-86FD-361791E9522A"");DataTable resultB30DE496533A48F986FD361791E9522A=iSpace.SetGridDataSource(querySourceB30DE496533A48F986FD361791E9522A, _objectFactory.GetGridRPP(""TaskStep""),@""EXEC AddFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""gv_activitymapid""].Value + @""',"" + ISpace[""MFG_w2_step_id""].Value + @"",'"" + ISpace[""MFG_w2_task_description""].Value + @""',"" + ISpace[""MFG_w2_task_id""].Value + @"",'"" + ISpace[""MFG_w2_step_state""].Value + @""',"" + ISpace[""MFG_w2_step_sequence""].Value + @"",'"" + ISpace[""MFG_w2_updated_at""].Value + @""',"" + ISpace[""MFG_w2_updated_by""].Value + @"","" + ISpace[""MFG_w2_created_by""].Value + @"",'"" + ISpace[""MFG_w2_created_at""].Value + @""',"" + ISpace[""MFG_w2_is_active""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskStep"",""11"",querySourceB30DE496533A48F986FD361791E9522A,""EXEC AddFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""gv_activitymapid""].Value + @""',"" + ISpace[""MFG_w2_step_id""].Value + @"",'"" + ISpace[""MFG_w2_task_description""].Value + @""',"" + ISpace[""MFG_w2_task_id""].Value + @"",'"" + ISpace[""MFG_w2_step_state""].Value + @""',"" + ISpace[""MFG_w2_step_sequence""].Value + @"",'"" + ISpace[""MFG_w2_updated_at""].Value + @""',"" + ISpace[""MFG_w2_updated_by""].Value + @"","" + ISpace[""MFG_w2_created_by""].Value + @"",'"" + ISpace[""MFG_w2_created_at""].Value + @""',"" + ISpace[""MFG_w2_is_active""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TaskStep""));");
base.WriteDebugInfo(@"EXEC AddFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '@@gv_InstanceId','@@gv_ProcessMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','@@gv_ActivityMapId',#MFG_w2_step_id,'#MFG_w2_task_description',#MFG_w2_task_id,'#MFG_w2_step_state',#MFG_w2_step_sequence,'#MFG_w2_updated_at',#MFG_w2_updated_by,#MFG_w2_created_by,'#MFG_w2_created_at',#MFG_w2_is_active,'#growid'");


List<Triplet<string, short, short?>> resultFC7F6600C3F04DEE976D09EC6B01A1AF=acdataIspace5EC891472FE240AF8446350FE5E13C57.GetQueryExpressionBindings("FC7F6600-C3F0-4DEE-976D-09EC6B01A1AF");
iSpace.SetGridData(resultB30DE496533A48F986FD361791E9522A,resultFC7F6600C3F04DEE976D09EC6B01A1AF,"TaskStep",ref ISpace);
iSpace.UpdateGridBindDetails("TaskStep",resultFC7F6600C3F04DEE976D09EC6B01A1AF);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceC33143FA630643D4805B3B3277053C6F =GetQueryExpressionDataSource("C33143FA-6306-43D4-805B-3B3277053C6F");

DataTable resultC33143FA630643D4805B3B3277053C6F=iSpace.SetGridDataSource(querySourceC33143FA630643D4805B3B3277053C6F, _objectFactory.GetGridRPP("TaskStep"),@"EXEC UpdateFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["gv_activitymapid"].Value + @"'," + ISpace["MFG_w2_step_id"].Value + @",'" + ISpace["MFG_w2_task_description"].Value + @"'," + ISpace["MFG_w2_task_id"].Value + @",'" + ISpace["MFG_w2_step_state"].Value + @"'," + ISpace["MFG_w2_step_sequence"].Value + @",'" + ISpace["MFG_w2_updated_at"].Value + @"'," + ISpace["MFG_w2_updated_by"].Value + @"," + ISpace["MFG_w2_created_by"].Value + @",'" + ISpace["MFG_w2_created_at"].Value + @"'," + ISpace["MFG_w2_is_active"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TaskStep","11",querySourceC33143FA630643D4805B3B3277053C6F,"EXEC UpdateFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["gv_activitymapid"].Value + @"'," + ISpace["MFG_w2_step_id"].Value + @",'" + ISpace["MFG_w2_task_description"].Value + @"'," + ISpace["MFG_w2_task_id"].Value + @",'" + ISpace["MFG_w2_step_state"].Value + @"'," + ISpace["MFG_w2_step_sequence"].Value + @",'" + ISpace["MFG_w2_updated_at"].Value + @"'," + ISpace["MFG_w2_updated_by"].Value + @"," + ISpace["MFG_w2_created_by"].Value + @",'" + ISpace["MFG_w2_created_at"].Value + @"'," + ISpace["MFG_w2_is_active"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TaskStep"));

base.WriteDebugInfo(@"var querySourceC33143FA630643D4805B3B3277053C6F =GetQueryExpressionDataSource(""C33143FA-6306-43D4-805B-3B3277053C6F"");DataTable resultC33143FA630643D4805B3B3277053C6F=iSpace.SetGridDataSource(querySourceC33143FA630643D4805B3B3277053C6F, _objectFactory.GetGridRPP(""TaskStep""),@""EXEC UpdateFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""gv_activitymapid""].Value + @""',"" + ISpace[""MFG_w2_step_id""].Value + @"",'"" + ISpace[""MFG_w2_task_description""].Value + @""',"" + ISpace[""MFG_w2_task_id""].Value + @"",'"" + ISpace[""MFG_w2_step_state""].Value + @""',"" + ISpace[""MFG_w2_step_sequence""].Value + @"",'"" + ISpace[""MFG_w2_updated_at""].Value + @""',"" + ISpace[""MFG_w2_updated_by""].Value + @"","" + ISpace[""MFG_w2_created_by""].Value + @"",'"" + ISpace[""MFG_w2_created_at""].Value + @""',"" + ISpace[""MFG_w2_is_active""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskStep"",""11"",querySourceC33143FA630643D4805B3B3277053C6F,""EXEC UpdateFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""gv_activitymapid""].Value + @""',"" + ISpace[""MFG_w2_step_id""].Value + @"",'"" + ISpace[""MFG_w2_task_description""].Value + @""',"" + ISpace[""MFG_w2_task_id""].Value + @"",'"" + ISpace[""MFG_w2_step_state""].Value + @""',"" + ISpace[""MFG_w2_step_sequence""].Value + @"",'"" + ISpace[""MFG_w2_updated_at""].Value + @""',"" + ISpace[""MFG_w2_updated_by""].Value + @"","" + ISpace[""MFG_w2_created_by""].Value + @"",'"" + ISpace[""MFG_w2_created_at""].Value + @""',"" + ISpace[""MFG_w2_is_active""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TaskStep""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '@@gv_InstanceId','@@gv_ProcessMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','@@gv_ActivityMapId',#MFG_w2_step_id,'#MFG_w2_task_description',#MFG_w2_task_id,'#MFG_w2_step_state',#MFG_w2_step_sequence,'#MFG_w2_updated_at',#MFG_w2_updated_by,#MFG_w2_created_by,'#MFG_w2_created_at',#MFG_w2_is_active,'#growid'");


List<Triplet<string, short, short?>> result27B855696AC54558A98B78155EED36F6=acdataIspace5EC891472FE240AF8446350FE5E13C57.GetQueryExpressionBindings("27B85569-6AC5-4558-A98B-78155EED36F6");
iSpace.SetGridData(resultC33143FA630643D4805B3B3277053C6F,result27B855696AC54558A98B78155EED36F6,"TaskStep",ref ISpace);
iSpace.UpdateGridBindDetails("TaskStep",result27B855696AC54558A98B78155EED36F6);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_w2_step_id"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_step_id""].Value="""";");
ISpace["MFG_w2_task_description"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_task_description""].Value="""";");
ISpace["MFG_w2_task_id"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_task_id""].Value="""";");
ISpace["MFG_w2_step_state"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_step_state""].Value="""";");
ISpace["MFG_w2_step_sequence"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_step_sequence""].Value="""";");
ISpace["MFG_w2_updated_at"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_updated_at""].Value="""";");
ISpace["MFG_w2_updated_by"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_updated_by""].Value="""";");
ISpace["MFG_w2_created_by"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_created_by""].Value="""";");
ISpace["MFG_w2_created_at"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_created_at""].Value="""";");
ISpace["MFG_w2_is_active"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w2_is_active""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_taskstep (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TaskStep-OnClick");
ISpace["growid"].Value=ISpace["TaskStep_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TaskStep_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '@@gv_InstanceId','@@gv_ProcessMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','@@gv_ActivityMapId','#growid'");

var querySourceA21D03C111764F35A73468BA9A98FF91 =GetQueryExpressionDataSource("A21D03C1-1176-4F35-A734-68BA9A98FF91");
Dictionary<short,object> resultA21D03C111764F35A73468BA9A98FF91=iSpace.ExecuteQuery(querySourceA21D03C111764F35A73468BA9A98FF91,@"EXEC LoadFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceA21D03C111764F35A73468BA9A98FF91 =GetQueryExpressionDataSource(""A21D03C1-1176-4F35-A734-68BA9A98FF91"");Dictionary<short,object> resultA21D03C111764F35A73468BA9A98FF91=iSpace.ExecuteQuery(querySourceA21D03C111764F35A73468BA9A98FF91,@""EXEC LoadFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridData4EA7F6C5714844C1A8EF2BB10145EC09 '@@gv_InstanceId','@@gv_ProcessMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','@@gv_ActivityMapId','#growid'");

if((resultA21D03C111764F35A73468BA9A98FF91!=null) && (resultA21D03C111764F35A73468BA9A98FF91.Count!=0))
{
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(8))
ISpace["MFG_w2_created_at"].Value = resultA21D03C111764F35A73468BA9A98FF91[8];
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(5))
ISpace["MFG_w2_updated_at"].Value = resultA21D03C111764F35A73468BA9A98FF91[5];
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(3))
ISpace["MFG_w2_step_state"].Value = resultA21D03C111764F35A73468BA9A98FF91[3];
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(9))
ISpace["MFG_w2_is_active"].Value = resultA21D03C111764F35A73468BA9A98FF91[9];
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(7))
ISpace["MFG_w2_created_by"].Value = resultA21D03C111764F35A73468BA9A98FF91[7];
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(4))
ISpace["MFG_w2_step_sequence"].Value = resultA21D03C111764F35A73468BA9A98FF91[4];
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(0))
ISpace["MFG_w2_step_id"].Value = resultA21D03C111764F35A73468BA9A98FF91[0];
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(6))
ISpace["MFG_w2_updated_by"].Value = resultA21D03C111764F35A73468BA9A98FF91[6];
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(2))
ISpace["MFG_w2_task_id"].Value = resultA21D03C111764F35A73468BA9A98FF91[2];
if(resultA21D03C111764F35A73468BA9A98FF91.ContainsKey(1))
ISpace["MFG_w2_task_description"].Value = resultA21D03C111764F35A73468BA9A98FF91[1];
}
else{
ISpace["MFG_w2_created_at"].Value = null;ISpace["MFG_w2_updated_at"].Value = null;ISpace["MFG_w2_step_state"].Value = null;ISpace["MFG_w2_is_active"].Value = null;ISpace["MFG_w2_created_by"].Value = null;ISpace["MFG_w2_step_sequence"].Value = null;ISpace["MFG_w2_step_id"].Value = null;ISpace["MFG_w2_updated_by"].Value = null;ISpace["MFG_w2_task_id"].Value = null;ISpace["MFG_w2_task_description"].Value = null;
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
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_back"))
{
			SubscribeElementEvents_m_back(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_taskstep"))
{
			SubscribeElementEvents_save_taskstep(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_taskstep"))
{
			SubscribeElementEvents_edit_taskstep(ref dfsParam);
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


	public partial class AcDataISpace5EC891472FE240AF8446350FE5E13C57  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"27B85569-6AC5-4558-A98B-78155EED36F6", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_Sequence",4,
														   -1),
								}
			},
							{"FC7F6600-C3F0-4DEE-976D-09EC6B01A1AF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_Sequence",4,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"430A1903-C481-4EA5-BDD0-0C7F581A5215", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"C245B389-E3FE-42FA-83BD-135282E8F7E8", ""},
							{"0AF81F68-BA4C-4701-B88E-3C83E2147450", ""},
							{"430A1903-C481-4EA5-BDD0-0C7F581A5215", ""},
							{"FB6831FB-4965-4C2C-88AC-781B07645FFD", ""},
							{"A4609C2D-7342-417C-B756-5671404514DA", ""},
							{"096027A3-AB0E-404B-B684-FFF2725AADB7", ""},
							{"D407B11D-6E51-43A2-97B6-84DFA7C00F20", ""},
							{"72FCC5C6-2429-4C28-8667-A253B63AFBBB", ""},
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
		


