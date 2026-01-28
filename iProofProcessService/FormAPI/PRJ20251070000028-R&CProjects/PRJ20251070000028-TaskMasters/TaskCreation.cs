  







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
	  			
			     new Triplet<string, string, string>("B23F1A20-0C68-4A59-8A3C-3925BE135CC3","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("6C2C8333-01F1-41FE-9096-8E73EAC10C1D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("E9A4771D-DD36-4665-A288-F67D6ABD15E4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("C87015FF-B159-4FAB-9C06-8EAF958664F2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("6AE3E917-F600-4CE1-B7F8-912886E45308","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
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
			
						
			     new Triplet<string, string, string>("6C2C8333-01F1-41FE-9096-8E73EAC10C1D","Load Grid By IdTaskStep",
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

		
	  			
			     new Triplet<string, string, string>("MF_w1_task_type_code","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77npyn1aWPGFOCecExdgZwESRUvAQUkQSXMQqGc4bTspeEien72gMAsQ==",
												     @"EXEC GetTaskCombos 3"),
			
						
			     new Triplet<string, string, string>("MF_w1_complexity_code","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77npyn1aWPGFOCecExdgZwESRUvAQUkQSXMQqGc4bTspeEien72gMAsQ==",
												     @"EXEC GetTaskCombos 1"),
			
						
			     new Triplet<string, string, string>("MF_w1_requirement_id","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77npyn1aWPGFOCecExdgZwESRUvAQUkQSXMQqGc4bTspeEien72gMAsQ==",
												     @"EXEC GetTaskCombos 2"),
			
						
			     new Triplet<string, string, string>("MF_w1_task_status","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77npyn1aWPGFOCecExdgZwESRUvAQUkQSXMQqGc4bTspeEien72gMAsQ==",
												     @"EXEC GetTaskCombos 4"),
			
						
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

if(ISpace["MF_w1_task_id"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_w1_task_id""].Value==0)");
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC TasKDetails '#MF_w1_task_id'");

var querySource553730377410f09e80aea9378d46dd55 =GetQueryExpressionDataSource("55373037-7410-f09e-80ae-a9378d46dd55");
Dictionary<short,object> result553730377410f09e80aea9378d46dd55=iSpace.ExecuteQuery(querySource553730377410f09e80aea9378d46dd55,@"EXEC TasKDetails '" + ISpace["MF_w1_task_id"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource553730377410f09e80aea9378d46dd55 =GetQueryExpressionDataSource(""55373037-7410-f09e-80ae-a9378d46dd55"");Dictionary<short,object> result553730377410f09e80aea9378d46dd55=iSpace.ExecuteQuery(querySource553730377410f09e80aea9378d46dd55,@""EXEC TasKDetails '"" + ISpace[""MF_w1_task_id""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result553730377410f09e80aea9378d46dd55!=null) && (result553730377410f09e80aea9378d46dd55.Count!=0))
{
if(result553730377410f09e80aea9378d46dd55.ContainsKey(9))
ISpace["MF_w1_task_status"].Value = result553730377410f09e80aea9378d46dd55[9];
if(result553730377410f09e80aea9378d46dd55.ContainsKey(7))
ISpace["MF_w1_requirement_id"].Value = result553730377410f09e80aea9378d46dd55[7];
if(result553730377410f09e80aea9378d46dd55.ContainsKey(3))
ISpace["MF_w1_task_type_code"].Value = result553730377410f09e80aea9378d46dd55[3];
if(result553730377410f09e80aea9378d46dd55.ContainsKey(5))
ISpace["MF_w1_complexity_code"].Value = result553730377410f09e80aea9378d46dd55[5];
if(result553730377410f09e80aea9378d46dd55.ContainsKey(10))
ISpace["MF_w1_is_active"].Value = result553730377410f09e80aea9378d46dd55[10];
if(result553730377410f09e80aea9378d46dd55.ContainsKey(2))
ISpace["MF_w1_task_name"].Value = result553730377410f09e80aea9378d46dd55[2];
if(result553730377410f09e80aea9378d46dd55.ContainsKey(1))
ISpace["MF_w1_task_code"].Value = result553730377410f09e80aea9378d46dd55[1];
}
else{
ISpace["MF_w1_task_status"].Value = null;ISpace["MF_w1_requirement_id"].Value = null;ISpace["MF_w1_task_type_code"].Value = null;ISpace["MF_w1_complexity_code"].Value = null;ISpace["MF_w1_is_active"].Value = null;ISpace["MF_w1_task_name"].Value = null;ISpace["MF_w1_task_code"].Value = null;
}

var querySourceb2309149833c09d35a14f7f64c7e01c9 =GetQueryExpressionDataSource("b2309149-833c-09d3-5a14-f7f64c7e01c9");

DataTable resultb2309149833c09d35a14f7f64c7e01c9=iSpace.SetGridDataSource(querySourceb2309149833c09d35a14f7f64c7e01c9, _objectFactory.GetGridRPP("TaskStep"),@"EXEC TasKstepDetails '" + ISpace["MF_w1_task_id"].Value + @"'");

iSpace.InsertGridBindDetails("TaskStep","11",querySourceb2309149833c09d35a14f7f64c7e01c9,"EXEC TasKstepDetails '" + ISpace["MF_w1_task_id"].Value + @"'",_objectFactory.GetGridRPP("TaskStep"));

base.WriteDebugInfo(@"var querySourceb2309149833c09d35a14f7f64c7e01c9 =GetQueryExpressionDataSource(""b2309149-833c-09d3-5a14-f7f64c7e01c9"");DataTable resultb2309149833c09d35a14f7f64c7e01c9=iSpace.SetGridDataSource(querySourceb2309149833c09d35a14f7f64c7e01c9, _objectFactory.GetGridRPP(""TaskStep""),@""EXEC TasKstepDetails '"" + ISpace[""MF_w1_task_id""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskStep"",""11"",querySourceb2309149833c09d35a14f7f64c7e01c9,""EXEC TasKstepDetails '"" + ISpace[""MF_w1_task_id""].Value + @""'"",_objectFactory.GetGridRPP(""TaskStep""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resulta3993650589b25c321b1d35d92c673bb=acdataIspace5EC891472FE240AF8446350FE5E13C57.GetQueryExpressionBindings("a3993650-589b-25c3-21b1-d35d92c673bb");
iSpace.SetGridData(resultb2309149833c09d35a14f7f64c7e01c9,resulta3993650589b25c321b1d35d92c673bb,"TaskStep",ref ISpace);
iSpace.UpdateGridBindDetails("TaskStep",resulta3993650589b25c321b1d35d92c673bb);
}
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormLoadById_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]  '#MF_w1_task_id'");

var querySourceB23F1A200C684A598A3C3925BE135CC3 =GetQueryExpressionDataSource("B23F1A20-0C68-4A59-8A3C-3925BE135CC3");
Dictionary<short,object> resultB23F1A200C684A598A3C3925BE135CC3=iSpace.ExecuteQuery(querySourceB23F1A200C684A598A3C3925BE135CC3,@"EXEC InnovaceNoCode..[FormLoadById_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]  '" + ISpace["MF_w1_task_id"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceB23F1A200C684A598A3C3925BE135CC3 =GetQueryExpressionDataSource(""B23F1A20-0C68-4A59-8A3C-3925BE135CC3"");Dictionary<short,object> resultB23F1A200C684A598A3C3925BE135CC3=iSpace.ExecuteQuery(querySourceB23F1A200C684A598A3C3925BE135CC3,@""EXEC InnovaceNoCode..[FormLoadById_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]  '"" + ISpace[""MF_w1_task_id""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultB23F1A200C684A598A3C3925BE135CC3!=null) && (resultB23F1A200C684A598A3C3925BE135CC3.Count!=0))
{
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(11))
ISpace["MF_w1_updated_at"].Value = resultB23F1A200C684A598A3C3925BE135CC3[11];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(8))
ISpace["MF_w1_created_at"].Value = resultB23F1A200C684A598A3C3925BE135CC3[8];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(4))
ISpace["MF_w1_complexity_code"].Value = resultB23F1A200C684A598A3C3925BE135CC3[4];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(6))
ISpace["MF_w1_task_status"].Value = resultB23F1A200C684A598A3C3925BE135CC3[6];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(5))
ISpace["MF_w1_requirement_id"].Value = resultB23F1A200C684A598A3C3925BE135CC3[5];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(3))
ISpace["MF_w1_task_type_code"].Value = resultB23F1A200C684A598A3C3925BE135CC3[3];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(7))
ISpace["MF_w1_is_active"].Value = resultB23F1A200C684A598A3C3925BE135CC3[7];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(9))
ISpace["MF_w1_created_by"].Value = resultB23F1A200C684A598A3C3925BE135CC3[9];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(10))
ISpace["MF_w1_updated_by"].Value = resultB23F1A200C684A598A3C3925BE135CC3[10];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(0))
ISpace["MF_w1_task_id"].Value = resultB23F1A200C684A598A3C3925BE135CC3[0];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(1))
ISpace["MF_w1_task_code"].Value = resultB23F1A200C684A598A3C3925BE135CC3[1];
if(resultB23F1A200C684A598A3C3925BE135CC3.ContainsKey(2))
ISpace["MF_w1_task_name"].Value = resultB23F1A200C684A598A3C3925BE135CC3[2];
}
else{
ISpace["MF_w1_updated_at"].Value = null;ISpace["MF_w1_created_at"].Value = null;ISpace["MF_w1_complexity_code"].Value = null;ISpace["MF_w1_task_status"].Value = null;ISpace["MF_w1_requirement_id"].Value = null;ISpace["MF_w1_task_type_code"].Value = null;ISpace["MF_w1_is_active"].Value = null;ISpace["MF_w1_created_by"].Value = null;ISpace["MF_w1_updated_by"].Value = null;ISpace["MF_w1_task_id"].Value = null;ISpace["MF_w1_task_code"].Value = null;ISpace["MF_w1_task_name"].Value = null;
}

var querySource6C2C833301F141FE90968E73EAC10C1D =GetQueryExpressionDataSource("6C2C8333-01F1-41FE-9096-8E73EAC10C1D");

DataTable result6C2C833301F141FE90968E73EAC10C1D=iSpace.SetGridDataSource(querySource6C2C833301F141FE90968E73EAC10C1D, _objectFactory.GetGridRPP("TaskStep"),@"EXEC InnovaceNoCode..[GridLoadById_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  '" + ISpace["MF_w1_task_id"].Value + @"'");

iSpace.InsertGridBindDetails("TaskStep","11",querySource6C2C833301F141FE90968E73EAC10C1D,"EXEC InnovaceNoCode..[GridLoadById_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  '" + ISpace["MF_w1_task_id"].Value + @"'",_objectFactory.GetGridRPP("TaskStep"));

base.WriteDebugInfo(@"var querySource6C2C833301F141FE90968E73EAC10C1D =GetQueryExpressionDataSource(""6C2C8333-01F1-41FE-9096-8E73EAC10C1D"");DataTable result6C2C833301F141FE90968E73EAC10C1D=iSpace.SetGridDataSource(querySource6C2C833301F141FE90968E73EAC10C1D, _objectFactory.GetGridRPP(""TaskStep""),@""EXEC InnovaceNoCode..[GridLoadById_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  '"" + ISpace[""MF_w1_task_id""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskStep"",""11"",querySource6C2C833301F141FE90968E73EAC10C1D,""EXEC InnovaceNoCode..[GridLoadById_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]  '"" + ISpace[""MF_w1_task_id""].Value + @""'"",_objectFactory.GetGridRPP(""TaskStep""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultD2EE331FF76A4A20B06B0AF22F82395E=acdataIspace5EC891472FE240AF8446350FE5E13C57.GetQueryExpressionBindings("D2EE331F-F76A-4A20-B06B-0AF22F82395E");
iSpace.SetGridData(result6C2C833301F141FE90968E73EAC10C1D,resultD2EE331FF76A4A20B06B0AF22F82395E,"TaskStep",ref ISpace);
iSpace.UpdateGridBindDetails("TaskStep",resultD2EE331FF76A4A20B06B0AF22F82395E);
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
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]  @InstanceId VARCHAR(36),@ProcessActivityMapId VARCHAR(36),@FormId  VARCHAR(36),#MF_w1_task_id,'#MF_w1_task_code','#MF_w1_task_name','#MF_w1_task_type_code','#MF_w1_complexity_code','#MF_w1_requirement_id','#MF_w1_task_status',#MF_w1_is_active,'#MF_w1_created_at',#MF_w1_created_by,#MF_w1_updated_by,'#MF_w1_updated_at'");

var querySource6AE3E917F6004CE1B7F8912886E45308 =GetQueryExpressionDataSource("6AE3E917-F600-4CE1-B7F8-912886E45308");
Dictionary<short,object> result6AE3E917F6004CE1B7F8912886E45308=iSpace.ExecuteQuery(querySource6AE3E917F6004CE1B7F8912886E45308,@"EXEC InnovaceNoCode..[FormSave_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]  " + ISpace["InstanceId"].Value + @" VARCHAR(36)," + ISpace["ProcessActivityMapId"].Value + @" VARCHAR(36)," + ISpace["FormId"].Value + @"  VARCHAR(36)," + ISpace["MF_w1_task_id"].Value + @",'" + ISpace["MF_w1_task_code"].Value + @"','" + ISpace["MF_w1_task_name"].Value + @"','" + ISpace["MF_w1_task_type_code"].Value + @"','" + ISpace["MF_w1_complexity_code"].Value + @"','" + ISpace["MF_w1_requirement_id"].Value + @"','" + ISpace["MF_w1_task_status"].Value + @"'," + ISpace["MF_w1_is_active"].Value + @",'" + ISpace["MF_w1_created_at"].Value + @"'," + ISpace["MF_w1_created_by"].Value + @"," + ISpace["MF_w1_updated_by"].Value + @",'" + ISpace["MF_w1_updated_at"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource6AE3E917F6004CE1B7F8912886E45308 =GetQueryExpressionDataSource(""6AE3E917-F600-4CE1-B7F8-912886E45308"");Dictionary<short,object> result6AE3E917F6004CE1B7F8912886E45308=iSpace.ExecuteQuery(querySource6AE3E917F6004CE1B7F8912886E45308,@""EXEC InnovaceNoCode..[FormSave_74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]  "" + ISpace[""InstanceId""].Value + @"" VARCHAR(36),"" + ISpace[""ProcessActivityMapId""].Value + @"" VARCHAR(36),"" + ISpace[""FormId""].Value + @""  VARCHAR(36),"" + ISpace[""MF_w1_task_id""].Value + @"",'"" + ISpace[""MF_w1_task_code""].Value + @""','"" + ISpace[""MF_w1_task_name""].Value + @""','"" + ISpace[""MF_w1_task_type_code""].Value + @""','"" + ISpace[""MF_w1_complexity_code""].Value + @""','"" + ISpace[""MF_w1_requirement_id""].Value + @""','"" + ISpace[""MF_w1_task_status""].Value + @""',"" + ISpace[""MF_w1_is_active""].Value + @"",'"" + ISpace[""MF_w1_created_at""].Value + @""',"" + ISpace[""MF_w1_created_by""].Value + @"","" + ISpace[""MF_w1_updated_by""].Value + @"",'"" + ISpace[""MF_w1_updated_at""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result6AE3E917F6004CE1B7F8912886E45308!=null) && (result6AE3E917F6004CE1B7F8912886E45308.Count!=0))
{
if(result6AE3E917F6004CE1B7F8912886E45308.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result6AE3E917F6004CE1B7F8912886E45308[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]   '@@gv_InstanceId','@@gv_ActivityMapId','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09'");

var querySourceC87015FFB1594FAB9C068EAF958664F2 =GetQueryExpressionDataSource("C87015FF-B159-4FAB-9C06-8EAF958664F2");
Dictionary<short,object> resultC87015FFB1594FAB9C068EAF958664F2=iSpace.ExecuteQuery(querySourceC87015FFB1594FAB9C068EAF958664F2,@"EXEC InnovaceNoCode..[GridSave_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09'",false);

base.WriteDebugInfo(@"var querySourceC87015FFB1594FAB9C068EAF958664F2 =GetQueryExpressionDataSource(""C87015FF-B159-4FAB-9C06-8EAF958664F2"");Dictionary<short,object> resultC87015FFB1594FAB9C068EAF958664F2=iSpace.ExecuteQuery(querySourceC87015FFB1594FAB9C068EAF958664F2,@""EXEC InnovaceNoCode..[GridSave_4EA7F6C5-7148-44C1-A8EF-2BB10145EC09]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','4EA7F6C5-7148-44C1-A8EF-2BB10145EC09'"",false);");
base.WriteDebugInfo(@"");

if((resultC87015FFB1594FAB9C068EAF958664F2!=null) && (resultC87015FFB1594FAB9C068EAF958664F2.Count!=0))
{
if(resultC87015FFB1594FAB9C068EAF958664F2.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultC87015FFB1594FAB9C068EAF958664F2[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
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
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_Sequence",4,
														   -1),
								}
			},
							{"a3993650-589b-25c3-21b1-d35d92c673bb", 
				
				new List<Triplet<string, short, short?>> {

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
								}
			},
							{"D2EE331F-F76A-4A20-B06B-0AF22F82395E", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
														   -1),
								}
			},
							{"149EBD68-946D-4778-95BD-BB5D3C13D434", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("TaskStep_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
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
		


