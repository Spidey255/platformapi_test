  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TaskCreationforDemoProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 20150; }
        }

        public override string PackageName
        {
            get { return "PRJ20251070000028 - R&C Projects"; }
        }

		public override string PackageDescription
        {
            get { return "The Research & Consultancy (R&C) Projects Module is designed to manage the complete lifecycle of institutional research and consultancy projects, from proposal submission to project closure. It enables faculty, research scholars, and departments to create, submit, and track project proposals, budgets, approvals, funding sources, and progress reports within a structured digital workflow. The module supports collaboration across departments, monitors financial utilization against sanctioned budgets, and ensures compliance with institutional and external funding guidelines."; }
        }

        public override string ProcessId
        {
            get { return "5ac5e0d5-e08b-4008-a105-1edbbe51665c"; }
        }

        public override string ProcessName
        {
            get { return "TaskCreationforDemo"; }
        }

		public override string ProcessDescription
        {
            get { return "Task Creation for Demo"; }
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
            get {return "5ac5e0d5-e08b-4008-a105-1edbbe51665c";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "C0A0BDE6-D7FA-48F4-B6D6-0965321A4683";	}
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
	

	public partial class TaskCreationforDemoObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TaskCreationforDemoProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("987C4F1D-2531-4816-9FD1-4D6B46506CFF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("7F312816-F4DE-4249-8DAE-C507220E94F1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("4DAF853B-B41C-4D78-8A2D-A0376743C8E5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("5B5B8CED-3210-4DE2-A914-4A1CE12098B8","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("98863D24-9CAD-4581-A101-CFC08EBB7583","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("8976DE12-A30A-4800-A709-BF675C5FE7CA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("A9759836-26CF-47CE-A46C-A9754FB77B84","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("7F312816-F4DE-4249-8DAE-C507220E94F1","Load Grid By IdTaskSteps",
												     @"D9867A0D-35C0-47A8-96B8-2518FFA9E7DB"),
			
						
			     new Triplet<string, string, string>("8976DE12-A30A-4800-A709-BF675C5FE7CA","Grid Binding6",
												     @"D9867A0D-35C0-47A8-96B8-2518FFA9E7DB"),
			
						
			     new Triplet<string, string, string>("A9759836-26CF-47CE-A46C-A9754FB77B84","Grid Binding4",
												     @"D9867A0D-35C0-47A8-96B8-2518FFA9E7DB"),
			
			
			
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
											case "D9F846DE-FEBE-4184-BD13-92A41DD18FF7":
							virtualInstance=new ISpaceD9F846DEFEBE4184BD1392A41DD18FF7();
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
	

	public partial class TaskCreationforDemoDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TaskCreationforDemoDataElementFactory()
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

               
                
                                      case "C0A0BDE6-D7FA-48F4-B6D6-0965321A4683":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [C0A0BDE6-D7FA-48F4-B6D6-0965321A4683] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [C0A0BDE6-D7FA-48F4-B6D6-0965321A4683](InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_w1_task_id,MF_w1_task_code,MF_w1_task_name,MF_w1_task_type_code,MF_w1_complexity_code,MF_w1_requirement_id,MF_w1_task_status,MF_w1_is_active,MF_w1_created_at,MF_w1_created_by,MF_w1_updated_by,MF_w1_updated_at,MFG_w2_step_id,MFG_w2_task_description,MFG_w2_task_id,MFG_w2_step_state,MFG_w2_step_sequence,MFG_w2_updated_at,MFG_w2_updated_by,MFG_w2_created_by,MFG_w2_created_at,MFG_w2_is_active,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid)  
       VALUES( {3}) END ELSE BEGIN UPDATE [C0A0BDE6-D7FA-48F4-B6D6-0965321A4683]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

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

                
                 
                                      case "D9867A0D-35C0-47A8-96B8-2518FFA9E7DB":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D9867A0D35C047A896B82518FFA9E7DB AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w2_updated_at] DATETIME	, [MG_w2_created_at] DATETIME	, [MG_w2_step_state] NVARCHAR(12)	, [MG_w2_step_id] BIGINT	, [MG_w2_created_by] BIGINT	, [MG_w2_task_id] BIGINT	, [MG_w2_step_sequence] INT	, [MG_w2_updated_by] BIGINT	, [MG_w2_task_description] NVARCHAR(12)	, [MG_w2_is_active] BIT){0}INSERT INTO [D9867A0D-35C0-47A8-96B8-2518FFA9E7DB](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_updated_at,MG_w2_created_at,MG_w2_step_state,MG_w2_step_id,MG_w2_created_by,MG_w2_task_id,MG_w2_step_sequence,MG_w2_updated_by,MG_w2_task_description,MG_w2_is_active)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w2_updated_at,TDT.MG_w2_created_at,TDT.MG_w2_step_state,TDT.MG_w2_step_id,TDT.MG_w2_created_by,TDT.MG_w2_task_id,TDT.MG_w2_step_sequence,TDT.MG_w2_updated_by,TDT.MG_w2_task_description,TDT.MG_w2_is_active FROM @TBL_D9867A0D35C047A896B82518FFA9E7DB TDT
							LEFT JOIN [D9867A0D-35C0-47A8-96B8-2518FFA9E7DB] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_updated_at,MG_w2_created_at,MG_w2_step_state,MG_w2_step_id,MG_w2_created_by,MG_w2_task_id,MG_w2_step_sequence,MG_w2_updated_by,MG_w2_task_description,MG_w2_is_active";

                                     tempInsertQuery=@"INSERT INTO @TBL_D9867A0D35C047A896B82518FFA9E7DB(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_updated_at,MG_w2_created_at,MG_w2_step_state,MG_w2_step_id,MG_w2_created_by,MG_w2_task_id,MG_w2_step_sequence,MG_w2_updated_by,MG_w2_task_description,MG_w2_is_active)VALUES({0});";
                                     

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
                     

                                         case "D9867A0D-35C0-47A8-96B8-2518FFA9E7DB":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D9867A0D35C047A896B82518FFA9E7DB AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w2_updated_at] DATETIME	, [MG_w2_created_at] DATETIME	, [MG_w2_step_state] NVARCHAR(12)	, [MG_w2_step_id] BIGINT	, [MG_w2_created_by] BIGINT	, [MG_w2_task_id] BIGINT	, [MG_w2_step_sequence] INT	, [MG_w2_updated_by] BIGINT	, [MG_w2_task_description] NVARCHAR(12)	, [MG_w2_is_active] BIT){0}INSERT INTO [D9867A0D-35C0-47A8-96B8-2518FFA9E7DB](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_updated_at,MG_w2_created_at,MG_w2_step_state,MG_w2_step_id,MG_w2_created_by,MG_w2_task_id,MG_w2_step_sequence,MG_w2_updated_by,MG_w2_task_description,MG_w2_is_active)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w2_updated_at,TDT.MG_w2_created_at,TDT.MG_w2_step_state,TDT.MG_w2_step_id,TDT.MG_w2_created_by,TDT.MG_w2_task_id,TDT.MG_w2_step_sequence,TDT.MG_w2_updated_by,TDT.MG_w2_task_description,TDT.MG_w2_is_active FROM @TBL_D9867A0D35C047A896B82518FFA9E7DB TDT
							LEFT JOIN [D9867A0D-35C0-47A8-96B8-2518FFA9E7DB] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_updated_at,MG_w2_created_at,MG_w2_step_state,MG_w2_step_id,MG_w2_created_by,MG_w2_task_id,MG_w2_step_sequence,MG_w2_updated_by,MG_w2_task_description,MG_w2_is_active";

                            tempInsertQuery=@"INSERT INTO @TBL_D9867A0D35C047A896B82518FFA9E7DB(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_updated_at,MG_w2_created_at,MG_w2_step_state,MG_w2_step_id,MG_w2_created_by,MG_w2_task_id,MG_w2_step_sequence,MG_w2_updated_by,MG_w2_task_description,MG_w2_is_active)VALUES({0});";

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
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceD9F846DEFEBE4184BD1392A41DD18FF7  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"7E729F8D-9822-4B2A-91CF-4B2913312565", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("TaskSteps_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
														   -1),
								   new Triplet<string, short, short?>("TaskSteps_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								}
			},
							{"9322425E-2EE3-40FC-8AE1-8D28C9744AF3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("TaskSteps_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("TaskSteps_Sequence",4,
														   -1),
								}
			},
							{"C03641F4-B0AE-4B1A-918C-EB6E71F5F592", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w2_is_active",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_state",3,
														   -1),
								   new Triplet<string, short, short?>("TaskSteps_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_step_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_description",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_at",5,
														   -1),
								   new Triplet<string, short, short?>("TaskSteps_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_updated_by",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_task_id",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w2_created_by",7,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"75A3D57C-A8D5-4476-89F6-63628B1E2D67", ""},
							{"7F07DBB6-E723-41E4-9DB5-464AC1755924", ""},
							{"2FC7F724-739D-4142-93AA-12C0893F48C2", ""},
							{"577F784E-0BEC-4A68-B1BA-C48716DB0124", ""},
							{"34C30672-FB28-4FD3-9743-27C4C9E21C87", ""},
							{"505F4F79-9868-49E0-83DD-29ADB35E6BA8", ""},
							{"DE7AF568-DEF2-4739-A9F0-C72BC829DBEB", ""},
							{"9C07C7E0-5307-4D9D-BFF6-078419CFF614", ""},
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
		


