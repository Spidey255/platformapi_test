  







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
	  			
			     new Triplet<string, string, string>("BBF5E024-90BD-4DC9-A45B-35FFD75C9A15","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("EC2BB596-4226-4183-A10E-783D4893D9A1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("E9A4771D-DD36-4665-A288-F67D6ABD15E4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("1834E3D3-E5C2-4D37-A5E3-B8A71174298F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("34010088-6787-4574-8663-AFF6C9729749","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("b2309149-833c-09d3-5a14-f7f64c7e01c9","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("55373037-7410-f09e-80ae-a9378d46dd55","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("4e76790c-498e-d019-8925-4e9649018b61","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("EAACDC1B-8182-4872-A191-AB93A613F5AD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("9CA8575F-75FF-476F-98D5-7FD593103EE4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("1834E3D3-E5C2-4D37-A5E3-B8A71174298F","Load Grid By IdTaskStep",
												     @"4EA7F6C5-7148-44C1-A8EF-2BB10145EC09"),
			
						
			     new Triplet<string, string, string>("b2309149-833c-09d3-5a14-f7f64c7e01c9","Load Task Grid",
												     @"4EA7F6C5-7148-44C1-A8EF-2BB10145EC09"),
			
						
			     new Triplet<string, string, string>("EAACDC1B-8182-4872-A191-AB93A613F5AD","Grid Binding1",
												     @"4EA7F6C5-7148-44C1-A8EF-2BB10145EC09"),
			
						
			     new Triplet<string, string, string>("9CA8575F-75FF-476F-98D5-7FD593103EE4","Grid Binding6",
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
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A](InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_w1_task_id,MF_w1_task_code,MF_w1_task_name,MF_w1_task_type_code,MF_w1_complexity_code,MF_w1_requirement_id,MF_w1_task_status,MF_w1_is_active,MF_w1_created_at,MF_w1_created_by,MF_w1_updated_by,MF_w1_updated_at,MFG_w2_step_id,MFG_w2_task_description,MFG_w2_task_id,MFG_w2_step_state,MFG_w2_step_sequence,MFG_w2_updated_at,MFG_w2_updated_by,MFG_w2_created_by,MFG_w2_created_at,MFG_w2_is_active,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,M_StepId)  
       VALUES( {3}) END ELSE BEGIN UPDATE [74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_w1_task_id,MF_w1_task_code,MF_w1_task_name,MF_w1_task_type_code,MF_w1_complexity_code,MF_w1_requirement_id,MF_w1_task_status,MF_w1_is_active,MF_w1_created_at,MF_w1_created_by,MF_w1_updated_by,MF_w1_updated_at,MFG_w2_step_id,MFG_w2_task_description,MFG_w2_task_id,MFG_w2_step_state,MFG_w2_step_sequence,MFG_w2_updated_at,MFG_w2_updated_by,MFG_w2_created_by,MFG_w2_created_at,MFG_w2_is_active,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,M_StepId";
                                    
                     
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
		
		DECLARE  @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w2_step_id] INT	, [MG_w2_task_description] VARCHAR(50)	, [MG_w2_task_id] INT	, [MG_w2_step_state] VARCHAR(50)	, [MG_w2_updated_at] DATETIME	, [MG_w2_updated_by] INT	, [MG_w2_created_by] INT	, [MG_w2_created_at] DATETIME	, [MG_w2_is_active] BIT	, [MG_w2_step_sequence] INT){0}INSERT INTO [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active,MG_w2_step_sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w2_step_id,TDT.MG_w2_task_description,TDT.MG_w2_task_id,TDT.MG_w2_step_state,TDT.MG_w2_updated_at,TDT.MG_w2_updated_by,TDT.MG_w2_created_by,TDT.MG_w2_created_at,TDT.MG_w2_is_active,TDT.MG_w2_step_sequence FROM @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 TDT
							LEFT JOIN [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active,MG_w2_step_sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_4EA7F6C5714844C1A8EF2BB10145EC09(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active,MG_w2_step_sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w2_step_id] INT	, [MG_w2_task_description] VARCHAR(50)	, [MG_w2_task_id] INT	, [MG_w2_step_state] VARCHAR(50)	, [MG_w2_updated_at] DATETIME	, [MG_w2_updated_by] INT	, [MG_w2_created_by] INT	, [MG_w2_created_at] DATETIME	, [MG_w2_is_active] BIT	, [MG_w2_step_sequence] INT){0}INSERT INTO [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active,MG_w2_step_sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w2_step_id,TDT.MG_w2_task_description,TDT.MG_w2_task_id,TDT.MG_w2_step_state,TDT.MG_w2_updated_at,TDT.MG_w2_updated_by,TDT.MG_w2_created_by,TDT.MG_w2_created_at,TDT.MG_w2_is_active,TDT.MG_w2_step_sequence FROM @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 TDT
							LEFT JOIN [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active,MG_w2_step_sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_4EA7F6C5714844C1A8EF2BB10145EC09(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active,MG_w2_step_sequence)VALUES({0});";

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
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(ISpace["MF_w1_task_id"].Value!=0 )
{
base.WriteDebugInfo(@"if(ISpace[""MF_w1_task_id""].Value!=0 )");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormLoadById_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]  '#MF_w1_task_id'");

var querySource34010088678745748663AFF6C9729749 =GetQueryExpressionDataSource("34010088-6787-4574-8663-AFF6C9729749");
Dictionary<short,object> result34010088678745748663AFF6C9729749=iSpace.ExecuteQuery(querySource34010088678745748663AFF6C9729749,@"EXEC InnovaceNoCode..[FormLoadById_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]  '" + ISpace["MF_w1_task_id"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource34010088678745748663AFF6C9729749 =GetQueryExpressionDataSource(""34010088-6787-4574-8663-AFF6C9729749"");Dictionary<short,object> result34010088678745748663AFF6C9729749=iSpace.ExecuteQuery(querySource34010088678745748663AFF6C9729749,@""EXEC InnovaceNoCode..[FormLoadById_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]  '"" + ISpace[""MF_w1_task_id""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result34010088678745748663AFF6C9729749!=null) && (result34010088678745748663AFF6C9729749.Count!=0))
{
if(result34010088678745748663AFF6C9729749.ContainsKey(11))
ISpace["MF_w1_updated_at"].Value = result34010088678745748663AFF6C9729749[11];
if(result34010088678745748663AFF6C9729749.ContainsKey(8))
ISpace["MF_w1_created_at"].Value = result34010088678745748663AFF6C9729749[8];
if(result34010088678745748663AFF6C9729749.ContainsKey(4))
ISpace["MF_w1_complexity_code"].Value = result34010088678745748663AFF6C9729749[4];
if(result34010088678745748663AFF6C9729749.ContainsKey(6))
ISpace["MF_w1_task_status"].Value = result34010088678745748663AFF6C9729749[6];
if(result34010088678745748663AFF6C9729749.ContainsKey(5))
ISpace["MF_w1_requirement_id"].Value = result34010088678745748663AFF6C9729749[5];
if(result34010088678745748663AFF6C9729749.ContainsKey(3))
ISpace["MF_w1_task_type_code"].Value = result34010088678745748663AFF6C9729749[3];
if(result34010088678745748663AFF6C9729749.ContainsKey(7))
ISpace["MF_w1_is_active"].Value = result34010088678745748663AFF6C9729749[7];
if(result34010088678745748663AFF6C9729749.ContainsKey(9))
ISpace["MF_w1_created_by"].Value = result34010088678745748663AFF6C9729749[9];
if(result34010088678745748663AFF6C9729749.ContainsKey(10))
ISpace["MF_w1_updated_by"].Value = result34010088678745748663AFF6C9729749[10];
if(result34010088678745748663AFF6C9729749.ContainsKey(0))
ISpace["MF_w1_task_id"].Value = result34010088678745748663AFF6C9729749[0];
if(result34010088678745748663AFF6C9729749.ContainsKey(1))
ISpace["MF_w1_task_code"].Value = result34010088678745748663AFF6C9729749[1];
if(result34010088678745748663AFF6C9729749.ContainsKey(2))
ISpace["MF_w1_task_name"].Value = result34010088678745748663AFF6C9729749[2];
}
else{
ISpace["MF_w1_updated_at"].Value = null;ISpace["MF_w1_created_at"].Value = null;ISpace["MF_w1_complexity_code"].Value = null;ISpace["MF_w1_task_status"].Value = null;ISpace["MF_w1_requirement_id"].Value = null;ISpace["MF_w1_task_type_code"].Value = null;ISpace["MF_w1_is_active"].Value = null;ISpace["MF_w1_created_by"].Value = null;ISpace["MF_w1_updated_by"].Value = null;ISpace["MF_w1_task_id"].Value = null;ISpace["MF_w1_task_code"].Value = null;ISpace["MF_w1_task_name"].Value = null;
}

var querySource1834E3D3E5C24D37A5E3B8A71174298F =GetQueryExpressionDataSource("1834E3D3-E5C2-4D37-A5E3-B8A71174298F");

DataTable result1834E3D3E5C24D37A5E3B8A71174298F=iSpace.SetGridDataSource(querySource1834E3D3E5C24D37A5E3B8A71174298F, _objectFactory.GetGridRPP("TaskStep"),@"EXEC InnovaceNoCode..[GridLoadById_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  '" + ISpace["MF_w1_task_id"].Value + @"'");

iSpace.InsertGridBindDetails("TaskStep","11",querySource1834E3D3E5C24D37A5E3B8A71174298F,"EXEC InnovaceNoCode..[GridLoadById_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  '" + ISpace["MF_w1_task_id"].Value + @"'",_objectFactory.GetGridRPP("TaskStep"));

base.WriteDebugInfo(@"var querySource1834E3D3E5C24D37A5E3B8A71174298F =GetQueryExpressionDataSource(""1834E3D3-E5C2-4D37-A5E3-B8A71174298F"");DataTable result1834E3D3E5C24D37A5E3B8A71174298F=iSpace.SetGridDataSource(querySource1834E3D3E5C24D37A5E3B8A71174298F, _objectFactory.GetGridRPP(""TaskStep""),@""EXEC InnovaceNoCode..[GridLoadById_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  '"" + ISpace[""MF_w1_task_id""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskStep"",""11"",querySource1834E3D3E5C24D37A5E3B8A71174298F,""EXEC InnovaceNoCode..[GridLoadById_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  '"" + ISpace[""MF_w1_task_id""].Value + @""'"",_objectFactory.GetGridRPP(""TaskStep""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultC8A21868E8BD46CA9102DBA971EF6435=acdataIspace5EC891472FE240AF8446350FE5E13C57.GetQueryExpressionBindings("C8A21868-E8BD-46CA-9102-DBA971EF6435");
iSpace.SetGridData(result1834E3D3E5C24D37A5E3B8A71174298F,resultC8A21868E8BD46CA9102DBA971EF6435,"TaskStep",ref ISpace);
iSpace.UpdateGridBindDetails("TaskStep",resultC8A21868E8BD46CA9102DBA971EF6435);
}

if(ISpace["MF_w1_task_id"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_w1_task_id""].Value==0)");
ISpace["MF_w1_task_id"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_w1_task_id""].Value=0;");
ISpace["MF_w1_task_code"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_w1_task_code""].Value="""";");
ISpace["MF_w1_task_type_code"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_w1_task_type_code""].Value="""";");
ISpace["MF_w1_task_name"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_w1_task_name""].Value="""";");
ISpace["MF_w1_complexity_code"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_w1_complexity_code""].Value="""";");
ISpace["MF_w1_requirement_id"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_w1_requirement_id""].Value="""";");
ISpace["MF_w1_task_status"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_w1_task_status""].Value="""";");
ISpace["TaskStep"].Value=null;
base.WriteDebugInfo(@"ISpace[""TaskStep""].Value=null;");
base.WriteDebugInfo(@"EXEC [GetTaskSeq] 1");

var querySource4e76790c498ed01989254e9649018b61 =GetQueryExpressionDataSource("4e76790c-498e-d019-8925-4e9649018b61");
Dictionary<short,object> result4e76790c498ed01989254e9649018b61=iSpace.ExecuteQuery(querySource4e76790c498ed01989254e9649018b61,@"EXEC [GetTaskSeq] 1",false);

base.WriteDebugInfo(@"var querySource4e76790c498ed01989254e9649018b61 =GetQueryExpressionDataSource(""4e76790c-498e-d019-8925-4e9649018b61"");Dictionary<short,object> result4e76790c498ed01989254e9649018b61=iSpace.ExecuteQuery(querySource4e76790c498ed01989254e9649018b61,@""EXEC [GetTaskSeq] 1"",false);");
base.WriteDebugInfo(@"");

if((result4e76790c498ed01989254e9649018b61!=null) && (result4e76790c498ed01989254e9649018b61.Count!=0))
{
if(result4e76790c498ed01989254e9649018b61.ContainsKey(0))
ISpace["MF_w1_task_id"].Value = result4e76790c498ed01989254e9649018b61[0];
}
else{
ISpace["MF_w1_task_id"].Value = null;
}
}
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
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]   '@@gv_InstanceId','@@gv_ActivityMapId','3cfe092a-c9df-42bd-bb7a-d4a6e90379fc',#MF_w1_task_id,'#MF_w1_task_code','#MF_w1_task_name','#MF_w1_task_type_code','#MF_w1_complexity_code','#MF_w1_requirement_id','#MF_w1_task_status',#MF_w1_is_active,'#MF_w1_created_at',#MF_w1_created_by,#MF_w1_updated_by,'#MF_w1_updated_at'");

var querySourceBBF5E02490BD4DC9A45B35FFD75C9A15 =GetQueryExpressionDataSource("BBF5E024-90BD-4DC9-A45B-35FFD75C9A15");
Dictionary<short,object> resultBBF5E02490BD4DC9A45B35FFD75C9A15=iSpace.ExecuteQuery(querySourceBBF5E02490BD4DC9A45B35FFD75C9A15,@"EXEC InnovaceNoCode..[FormSave_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','3cfe092a-c9df-42bd-bb7a-d4a6e90379fc'," + ISpace["MF_w1_task_id"].Value + @",'" + ISpace["MF_w1_task_code"].Value + @"','" + ISpace["MF_w1_task_name"].Value + @"','" + ISpace["MF_w1_task_type_code"].Value + @"','" + ISpace["MF_w1_complexity_code"].Value + @"','" + ISpace["MF_w1_requirement_id"].Value + @"','" + ISpace["MF_w1_task_status"].Value + @"'," + ISpace["MF_w1_is_active"].Value + @",'" + ISpace["MF_w1_created_at"].Value + @"'," + ISpace["MF_w1_created_by"].Value + @"," + ISpace["MF_w1_updated_by"].Value + @",'" + ISpace["MF_w1_updated_at"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBBF5E02490BD4DC9A45B35FFD75C9A15 =GetQueryExpressionDataSource(""BBF5E024-90BD-4DC9-A45B-35FFD75C9A15"");Dictionary<short,object> resultBBF5E02490BD4DC9A45B35FFD75C9A15=iSpace.ExecuteQuery(querySourceBBF5E02490BD4DC9A45B35FFD75C9A15,@""EXEC InnovaceNoCode..[FormSave_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','3cfe092a-c9df-42bd-bb7a-d4a6e90379fc',"" + ISpace[""MF_w1_task_id""].Value + @"",'"" + ISpace[""MF_w1_task_code""].Value + @""','"" + ISpace[""MF_w1_task_name""].Value + @""','"" + ISpace[""MF_w1_task_type_code""].Value + @""','"" + ISpace[""MF_w1_complexity_code""].Value + @""','"" + ISpace[""MF_w1_requirement_id""].Value + @""','"" + ISpace[""MF_w1_task_status""].Value + @""',"" + ISpace[""MF_w1_is_active""].Value + @"",'"" + ISpace[""MF_w1_created_at""].Value + @""',"" + ISpace[""MF_w1_created_by""].Value + @"","" + ISpace[""MF_w1_updated_by""].Value + @"",'"" + ISpace[""MF_w1_updated_at""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBBF5E02490BD4DC9A45B35FFD75C9A15!=null) && (resultBBF5E02490BD4DC9A45B35FFD75C9A15.Count!=0))
{
if(resultBBF5E02490BD4DC9A45B35FFD75C9A15.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultBBF5E02490BD4DC9A45B35FFD75C9A15[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]   '@@gv_InstanceId','@@gv_ActivityMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09'");

var querySourceEC2BB59642264183A10E783D4893D9A1 =GetQueryExpressionDataSource("EC2BB596-4226-4183-A10E-783D4893D9A1");
Dictionary<short,object> resultEC2BB59642264183A10E783D4893D9A1=iSpace.ExecuteQuery(querySourceEC2BB59642264183A10E783D4893D9A1,@"EXEC InnovaceNoCode..[GridSave_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09'",false);

base.WriteDebugInfo(@"var querySourceEC2BB59642264183A10E783D4893D9A1 =GetQueryExpressionDataSource(""EC2BB596-4226-4183-A10E-783D4893D9A1"");Dictionary<short,object> resultEC2BB59642264183A10E783D4893D9A1=iSpace.ExecuteQuery(querySourceEC2BB59642264183A10E783D4893D9A1,@""EXEC InnovaceNoCode..[GridSave_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09'"",false);");
base.WriteDebugInfo(@"");

if((resultEC2BB59642264183A10E783D4893D9A1!=null) && (resultEC2BB59642264183A10E783D4893D9A1.Count!=0))
{
if(resultEC2BB59642264183A10E783D4893D9A1.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultEC2BB59642264183A10E783D4893D9A1[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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

var querySourceEAACDC1B81824872A191AB93A613F5AD =GetQueryExpressionDataSource("EAACDC1B-8182-4872-A191-AB93A613F5AD");

DataTable resultEAACDC1B81824872A191AB93A613F5AD=iSpace.SetGridDataSource(querySourceEAACDC1B81824872A191AB93A613F5AD, _objectFactory.GetGridRPP("TaskStep"),@"EXEC [AddFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["growid"].Value + @"'," + ISpace["TaskStep_Sequence"].Value + @"," + ISpace["MFG_w2_step_id"].Value + @",'" + ISpace["MFG_w2_task_description"].Value + @"'," + ISpace["MFG_w2_task_id"].Value + @",'" + ISpace["MFG_w2_step_state"].Value + @"'," + ISpace["MFG_w2_step_sequence"].Value + @",'" + ISpace["MFG_w2_updated_at"].Value + @"'," + ISpace["MFG_w2_updated_by"].Value + @"," + ISpace["MFG_w2_created_by"].Value + @",'" + ISpace["MFG_w2_created_at"].Value + @"'," + ISpace["MFG_w2_is_active"].Value + @"");

iSpace.InsertGridBindDetails("TaskStep","11",querySourceEAACDC1B81824872A191AB93A613F5AD,"EXEC [AddFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["growid"].Value + @"'," + ISpace["TaskStep_Sequence"].Value + @"," + ISpace["MFG_w2_step_id"].Value + @",'" + ISpace["MFG_w2_task_description"].Value + @"'," + ISpace["MFG_w2_task_id"].Value + @",'" + ISpace["MFG_w2_step_state"].Value + @"'," + ISpace["MFG_w2_step_sequence"].Value + @",'" + ISpace["MFG_w2_updated_at"].Value + @"'," + ISpace["MFG_w2_updated_by"].Value + @"," + ISpace["MFG_w2_created_by"].Value + @",'" + ISpace["MFG_w2_created_at"].Value + @"'," + ISpace["MFG_w2_is_active"].Value + @"",_objectFactory.GetGridRPP("TaskStep"));

base.WriteDebugInfo(@"var querySourceEAACDC1B81824872A191AB93A613F5AD =GetQueryExpressionDataSource(""EAACDC1B-8182-4872-A191-AB93A613F5AD"");DataTable resultEAACDC1B81824872A191AB93A613F5AD=iSpace.SetGridDataSource(querySourceEAACDC1B81824872A191AB93A613F5AD, _objectFactory.GetGridRPP(""TaskStep""),@""EXEC [AddFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskStep_Sequence""].Value + @"","" + ISpace[""MFG_w2_step_id""].Value + @"",'"" + ISpace[""MFG_w2_task_description""].Value + @""',"" + ISpace[""MFG_w2_task_id""].Value + @"",'"" + ISpace[""MFG_w2_step_state""].Value + @""',"" + ISpace[""MFG_w2_step_sequence""].Value + @"",'"" + ISpace[""MFG_w2_updated_at""].Value + @""',"" + ISpace[""MFG_w2_updated_by""].Value + @"","" + ISpace[""MFG_w2_created_by""].Value + @"",'"" + ISpace[""MFG_w2_created_at""].Value + @""',"" + ISpace[""MFG_w2_is_active""].Value + @"""");iSpace.InsertGridBindDetails(""TaskStep"",""11"",querySourceEAACDC1B81824872A191AB93A613F5AD,""EXEC [AddFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskStep_Sequence""].Value + @"","" + ISpace[""MFG_w2_step_id""].Value + @"",'"" + ISpace[""MFG_w2_task_description""].Value + @""',"" + ISpace[""MFG_w2_task_id""].Value + @"",'"" + ISpace[""MFG_w2_step_state""].Value + @""',"" + ISpace[""MFG_w2_step_sequence""].Value + @"",'"" + ISpace[""MFG_w2_updated_at""].Value + @""',"" + ISpace[""MFG_w2_updated_by""].Value + @"","" + ISpace[""MFG_w2_created_by""].Value + @"",'"" + ISpace[""MFG_w2_created_at""].Value + @""',"" + ISpace[""MFG_w2_is_active""].Value + @"""",_objectFactory.GetGridRPP(""TaskStep""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '@@gv_InstanceId','@@gv_ActivityMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','#growid',#TaskStep_Sequence,#MFG_w2_step_id,'#MFG_w2_task_description',#MFG_w2_task_id,'#MFG_w2_step_state',#MFG_w2_step_sequence,'#MFG_w2_updated_at',#MFG_w2_updated_by,#MFG_w2_created_by,'#MFG_w2_created_at',#MFG_w2_is_active");


List<Triplet<string, short, short?>> result23592F89C9E8487D9C30DFA825299E44=acdataIspace5EC891472FE240AF8446350FE5E13C57.GetQueryExpressionBindings("23592F89-C9E8-487D-9C30-DFA825299E44");
iSpace.SetGridData(resultEAACDC1B81824872A191AB93A613F5AD,result23592F89C9E8487D9C30DFA825299E44,"TaskStep",ref ISpace);
iSpace.UpdateGridBindDetails("TaskStep",result23592F89C9E8487D9C30DFA825299E44);
}
else
{
base.WriteDebugInfo(@"else");

var querySource9CA8575F75FF476F98D57FD593103EE4 =GetQueryExpressionDataSource("9CA8575F-75FF-476F-98D5-7FD593103EE4");

DataTable result9CA8575F75FF476F98D57FD593103EE4=iSpace.SetGridDataSource(querySource9CA8575F75FF476F98D57FD593103EE4, _objectFactory.GetGridRPP("TaskStep"),@"EXEC [UpdateFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["growid"].Value + @"'," + ISpace["TaskStep_Sequence"].Value + @"," + ISpace["MFG_w2_step_id"].Value + @",'" + ISpace["MFG_w2_task_description"].Value + @"'," + ISpace["MFG_w2_task_id"].Value + @",'" + ISpace["MFG_w2_step_state"].Value + @"'," + ISpace["MFG_w2_step_sequence"].Value + @",'" + ISpace["MFG_w2_updated_at"].Value + @"'," + ISpace["MFG_w2_updated_by"].Value + @"," + ISpace["MFG_w2_created_by"].Value + @",'" + ISpace["MFG_w2_created_at"].Value + @"'," + ISpace["MFG_w2_is_active"].Value + @"");

iSpace.InsertGridBindDetails("TaskStep","11",querySource9CA8575F75FF476F98D57FD593103EE4,"EXEC [UpdateFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["growid"].Value + @"'," + ISpace["TaskStep_Sequence"].Value + @"," + ISpace["MFG_w2_step_id"].Value + @",'" + ISpace["MFG_w2_task_description"].Value + @"'," + ISpace["MFG_w2_task_id"].Value + @",'" + ISpace["MFG_w2_step_state"].Value + @"'," + ISpace["MFG_w2_step_sequence"].Value + @",'" + ISpace["MFG_w2_updated_at"].Value + @"'," + ISpace["MFG_w2_updated_by"].Value + @"," + ISpace["MFG_w2_created_by"].Value + @",'" + ISpace["MFG_w2_created_at"].Value + @"'," + ISpace["MFG_w2_is_active"].Value + @"",_objectFactory.GetGridRPP("TaskStep"));

base.WriteDebugInfo(@"var querySource9CA8575F75FF476F98D57FD593103EE4 =GetQueryExpressionDataSource(""9CA8575F-75FF-476F-98D5-7FD593103EE4"");DataTable result9CA8575F75FF476F98D57FD593103EE4=iSpace.SetGridDataSource(querySource9CA8575F75FF476F98D57FD593103EE4, _objectFactory.GetGridRPP(""TaskStep""),@""EXEC [UpdateFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskStep_Sequence""].Value + @"","" + ISpace[""MFG_w2_step_id""].Value + @"",'"" + ISpace[""MFG_w2_task_description""].Value + @""',"" + ISpace[""MFG_w2_task_id""].Value + @"",'"" + ISpace[""MFG_w2_step_state""].Value + @""',"" + ISpace[""MFG_w2_step_sequence""].Value + @"",'"" + ISpace[""MFG_w2_updated_at""].Value + @""',"" + ISpace[""MFG_w2_updated_by""].Value + @"","" + ISpace[""MFG_w2_created_by""].Value + @"",'"" + ISpace[""MFG_w2_created_at""].Value + @""',"" + ISpace[""MFG_w2_is_active""].Value + @"""");iSpace.InsertGridBindDetails(""TaskStep"",""11"",querySource9CA8575F75FF476F98D57FD593103EE4,""EXEC [UpdateFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskStep_Sequence""].Value + @"","" + ISpace[""MFG_w2_step_id""].Value + @"",'"" + ISpace[""MFG_w2_task_description""].Value + @""',"" + ISpace[""MFG_w2_task_id""].Value + @"",'"" + ISpace[""MFG_w2_step_state""].Value + @""',"" + ISpace[""MFG_w2_step_sequence""].Value + @"",'"" + ISpace[""MFG_w2_updated_at""].Value + @""',"" + ISpace[""MFG_w2_updated_by""].Value + @"","" + ISpace[""MFG_w2_created_by""].Value + @"",'"" + ISpace[""MFG_w2_created_at""].Value + @""',"" + ISpace[""MFG_w2_is_active""].Value + @"""",_objectFactory.GetGridRPP(""TaskStep""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '@@gv_InstanceId','@@gv_ActivityMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','#growid',#TaskStep_Sequence,#MFG_w2_step_id,'#MFG_w2_task_description',#MFG_w2_task_id,'#MFG_w2_step_state',#MFG_w2_step_sequence,'#MFG_w2_updated_at',#MFG_w2_updated_by,#MFG_w2_created_by,'#MFG_w2_created_at',#MFG_w2_is_active");


List<Triplet<string, short, short?>> result149EBD68946D477895BDBB5D3C13D434=acdataIspace5EC891472FE240AF8446350FE5E13C57.GetQueryExpressionBindings("149EBD68-946D-4778-95BD-BB5D3C13D434");
iSpace.SetGridData(result9CA8575F75FF476F98D57FD593103EE4,result149EBD68946D477895BDBB5D3C13D434,"TaskStep",ref ISpace);
iSpace.UpdateGridBindDetails("TaskStep",result149EBD68946D477895BDBB5D3C13D434);
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
base.WriteDebugInfo(@"EXEC [LoadFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '@@gv_InstanceId','@@gv_ActivityMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','#growid',#TaskStep_Sequence");

var querySourceE9A4771DDD364665A288F67D6ABD15E4 =GetQueryExpressionDataSource("E9A4771D-DD36-4665-A288-F67D6ABD15E4");
Dictionary<short,object> resultE9A4771DDD364665A288F67D6ABD15E4=iSpace.ExecuteQuery(querySourceE9A4771DDD364665A288F67D6ABD15E4,@"EXEC [LoadFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','" + ISpace["growid"].Value + @"'," + ISpace["TaskStep_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySourceE9A4771DDD364665A288F67D6ABD15E4 =GetQueryExpressionDataSource(""E9A4771D-DD36-4665-A288-F67D6ABD15E4"");Dictionary<short,object> resultE9A4771DDD364665A288F67D6ABD15E4=iSpace.ExecuteQuery(querySourceE9A4771DDD364665A288F67D6ABD15E4,@""EXEC [LoadFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskStep_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] '@@gv_InstanceId','@@gv_ActivityMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09','#growid',#TaskStep_Sequence");

if((resultE9A4771DDD364665A288F67D6ABD15E4!=null) && (resultE9A4771DDD364665A288F67D6ABD15E4.Count!=0))
{
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(8))
ISpace["MFG_w2_created_at"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[8];
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(5))
ISpace["MFG_w2_updated_at"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[5];
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(3))
ISpace["MFG_w2_step_state"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[3];
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(9))
ISpace["MFG_w2_is_active"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[9];
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(7))
ISpace["MFG_w2_created_by"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[7];
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(4))
ISpace["MFG_w2_step_sequence"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[4];
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(0))
ISpace["MFG_w2_step_id"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[0];
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(6))
ISpace["MFG_w2_updated_by"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[6];
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(2))
ISpace["MFG_w2_task_id"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[2];
if(resultE9A4771DDD364665A288F67D6ABD15E4.ContainsKey(1))
ISpace["MFG_w2_task_description"].Value = resultE9A4771DDD364665A288F67D6ABD15E4[1];
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
							{"C8A21868-E8BD-46CA-9102-DBA971EF6435", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("TaskStep_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								}
			},
							{"23592F89-C9E8-487D-9C30-DFA825299E44", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_Sequence",4,
														   -1),
								}
			},
							{"149EBD68-946D-4778-95BD-BB5D3C13D434", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
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
		


