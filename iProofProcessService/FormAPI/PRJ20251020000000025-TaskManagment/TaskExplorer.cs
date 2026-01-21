  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TaskExplorerProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 30252; }
        }

        public override string PackageName
        {
            get { return "PRJ20251020000000025-Task Managment"; }
        }

		public override string PackageDescription
        {
            get { return "Task management is the systematic process of planning, organizing, prioritizing, and tracking tasks from inception to completion. It goes beyond a simple to-do list, aiming to improve efficiency, productivity, and communication by overseeing the entire lifecycle of tasks, including deadlines, resource allocation, and dependencies. "; }
        }

        public override string ProcessId
        {
            get { return "c3e03d70-482e-412c-ab11-9ee7cdbc9d71"; }
        }

        public override string ProcessName
        {
            get { return "TaskExplorer"; }
        }

		public override string ProcessDescription
        {
            get { return "Task Explorer"; }
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
            get {return "c3e03d70-482e-412c-ab11-9ee7cdbc9d71";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "A75658B9-B9FA-4E77-813F-7F1CBE9B5399";	}
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
	

	public partial class TaskExplorerObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TaskExplorerProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("10C5DF13-44B6-4B4C-90A8-AFE3AF9F45EF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("7c7169a9-e40f-f76a-533e-a141d2b9dada","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("B27E0830-054F-4B32-9B2C-E0E52BB05407","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("42D763EB-4336-4340-949A-CF732202B305","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("F1D26DED-A1B9-40DC-84EB-9421944A13EE","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("7c7169a9-e40f-f76a-533e-a141d2b9dada","Load Existing Task Details",
												     @"D7398AE6-9E08-4A2D-AE91-E8268871D660"),
			
						
			     new Triplet<string, string, string>("42D763EB-4336-4340-949A-CF732202B305","Grid BindingE",
												     @"D7398AE6-9E08-4A2D-AE91-E8268871D660"),
			
						
			     new Triplet<string, string, string>("F1D26DED-A1B9-40DC-84EB-9421944A13EE","Grid Binding0",
												     @"D7398AE6-9E08-4A2D-AE91-E8268871D660"),
			
			
			
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
		
	  			
			     new Tuple<string, int>("TaskList",5),
			
						
			     new Tuple<string, int>("TaskList",5),
			
						
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
											case "DB97F08F-3848-4F72-9604-F0992998747E":
							virtualInstance=new ISpaceDB97F08F38484F729604F0992998747E();
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
	

	public partial class TaskExplorerDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TaskExplorerDataElementFactory()
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

               
                
                                      case "A75658B9-B9FA-4E77-813F-7F1CBE9B5399":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [A75658B9-B9FA-4E77-813F-7F1CBE9B5399] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [A75658B9-B9FA-4E77-813F-7F1CBE9B5399](InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MFG_w1_task_id,MFG_w1_task_code,MFG_w1_task_name,MFG_w1_task_type_code,MFG_w1_complexity_code,MFG_w1_requirement_id,MFG_w1_task_status,MFG_w1_is_active,MFG_w1_created_at,MFG_w1_created_by,MFG_w1_updated_by,MFG_w1_updated_at,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,M_Total,M_Active,M_InActive,M_Closed)  
       VALUES( {3}) END ELSE BEGIN UPDATE [A75658B9-B9FA-4E77-813F-7F1CBE9B5399]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MFG_w1_task_id,MFG_w1_task_code,MFG_w1_task_name,MFG_w1_task_type_code,MFG_w1_complexity_code,MFG_w1_requirement_id,MFG_w1_task_status,MFG_w1_is_active,MFG_w1_created_at,MFG_w1_created_by,MFG_w1_updated_by,MFG_w1_updated_at,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,M_Total,M_Active,M_InActive,M_Closed";
                                    
                     
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

                
                 
                                      case "D7398AE6-9E08-4A2D-AE91-E8268871D660":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D7398AE69E084A2DAE91E8268871D660 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w1_complexity_code] NVARCHAR(12)	, [MG_w1_created_by] BIGINT	, [MG_w1_created_at] DATETIME	, [MG_w1_task_name] NVARCHAR(12)	, [MG_w1_task_id] BIGINT	, [MG_w1_task_type_code] NVARCHAR(12)	, [MG_w1_task_code] NVARCHAR(12)	, [MG_w1_requirement_id] BIGINT	, [MG_w1_updated_by] BIGINT	, [MG_w1_is_active] BIT	, [MG_w1_task_status] NVARCHAR(12)	, [MG_w1_updated_at] DATETIME){0}INSERT INTO [D7398AE6-9E08-4A2D-AE91-E8268871D660](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_by,MG_w1_created_at,MG_w1_task_name,MG_w1_task_id,MG_w1_task_type_code,MG_w1_task_code,MG_w1_requirement_id,MG_w1_updated_by,MG_w1_is_active,MG_w1_task_status,MG_w1_updated_at)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w1_complexity_code,TDT.MG_w1_created_by,TDT.MG_w1_created_at,TDT.MG_w1_task_name,TDT.MG_w1_task_id,TDT.MG_w1_task_type_code,TDT.MG_w1_task_code,TDT.MG_w1_requirement_id,TDT.MG_w1_updated_by,TDT.MG_w1_is_active,TDT.MG_w1_task_status,TDT.MG_w1_updated_at FROM @TBL_D7398AE69E084A2DAE91E8268871D660 TDT
							LEFT JOIN [D7398AE6-9E08-4A2D-AE91-E8268871D660] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_by,MG_w1_created_at,MG_w1_task_name,MG_w1_task_id,MG_w1_task_type_code,MG_w1_task_code,MG_w1_requirement_id,MG_w1_updated_by,MG_w1_is_active,MG_w1_task_status,MG_w1_updated_at";

                                     tempInsertQuery=@"INSERT INTO @TBL_D7398AE69E084A2DAE91E8268871D660(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_by,MG_w1_created_at,MG_w1_task_name,MG_w1_task_id,MG_w1_task_type_code,MG_w1_task_code,MG_w1_requirement_id,MG_w1_updated_by,MG_w1_is_active,MG_w1_task_status,MG_w1_updated_at)VALUES({0});";
                                     

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
                     

                                         case "D7398AE6-9E08-4A2D-AE91-E8268871D660":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D7398AE69E084A2DAE91E8268871D660 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w1_complexity_code] NVARCHAR(12)	, [MG_w1_created_by] BIGINT	, [MG_w1_created_at] DATETIME	, [MG_w1_task_name] NVARCHAR(12)	, [MG_w1_task_id] BIGINT	, [MG_w1_task_type_code] NVARCHAR(12)	, [MG_w1_task_code] NVARCHAR(12)	, [MG_w1_requirement_id] BIGINT	, [MG_w1_updated_by] BIGINT	, [MG_w1_is_active] BIT	, [MG_w1_task_status] NVARCHAR(12)	, [MG_w1_updated_at] DATETIME){0}INSERT INTO [D7398AE6-9E08-4A2D-AE91-E8268871D660](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_by,MG_w1_created_at,MG_w1_task_name,MG_w1_task_id,MG_w1_task_type_code,MG_w1_task_code,MG_w1_requirement_id,MG_w1_updated_by,MG_w1_is_active,MG_w1_task_status,MG_w1_updated_at)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w1_complexity_code,TDT.MG_w1_created_by,TDT.MG_w1_created_at,TDT.MG_w1_task_name,TDT.MG_w1_task_id,TDT.MG_w1_task_type_code,TDT.MG_w1_task_code,TDT.MG_w1_requirement_id,TDT.MG_w1_updated_by,TDT.MG_w1_is_active,TDT.MG_w1_task_status,TDT.MG_w1_updated_at FROM @TBL_D7398AE69E084A2DAE91E8268871D660 TDT
							LEFT JOIN [D7398AE6-9E08-4A2D-AE91-E8268871D660] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_by,MG_w1_created_at,MG_w1_task_name,MG_w1_task_id,MG_w1_task_type_code,MG_w1_task_code,MG_w1_requirement_id,MG_w1_updated_by,MG_w1_is_active,MG_w1_task_status,MG_w1_updated_at";

                            tempInsertQuery=@"INSERT INTO @TBL_D7398AE69E084A2DAE91E8268871D660(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_by,MG_w1_created_at,MG_w1_task_name,MG_w1_task_id,MG_w1_task_type_code,MG_w1_task_code,MG_w1_requirement_id,MG_w1_updated_by,MG_w1_is_active,MG_w1_task_status,MG_w1_updated_at)VALUES({0});";

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
public class ISpaceDB97F08F38484F729604F0992998747E : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceDB97F08F38484F729604F0992998747E acdataIspaceDB97F08F38484F729604F0992998747E=new AcDataISpaceDB97F08F38484F729604F0992998747E();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetTaskSummary");

var querySourceB27E0830054F4B329B2CE0E52BB05407 =GetQueryExpressionDataSource("B27E0830-054F-4B32-9B2C-E0E52BB05407");
Dictionary<short,object> resultB27E0830054F4B329B2CE0E52BB05407=iSpace.ExecuteQuery(querySourceB27E0830054F4B329B2CE0E52BB05407,@"EXEC GetTaskSummary",false);

base.WriteDebugInfo(@"var querySourceB27E0830054F4B329B2CE0E52BB05407 =GetQueryExpressionDataSource(""B27E0830-054F-4B32-9B2C-E0E52BB05407"");Dictionary<short,object> resultB27E0830054F4B329B2CE0E52BB05407=iSpace.ExecuteQuery(querySourceB27E0830054F4B329B2CE0E52BB05407,@""EXEC GetTaskSummary"",false);");
base.WriteDebugInfo(@"");

if((resultB27E0830054F4B329B2CE0E52BB05407!=null) && (resultB27E0830054F4B329B2CE0E52BB05407.Count!=0))
{
if(resultB27E0830054F4B329B2CE0E52BB05407.ContainsKey(1))
ISpace["M_Active"].Value = resultB27E0830054F4B329B2CE0E52BB05407[1];
if(resultB27E0830054F4B329B2CE0E52BB05407.ContainsKey(0))
ISpace["M_Total"].Value = resultB27E0830054F4B329B2CE0E52BB05407[0];
if(resultB27E0830054F4B329B2CE0E52BB05407.ContainsKey(2))
ISpace["M_InActive"].Value = resultB27E0830054F4B329B2CE0E52BB05407[2];
if(resultB27E0830054F4B329B2CE0E52BB05407.ContainsKey(3))
ISpace["M_Closed"].Value = resultB27E0830054F4B329B2CE0E52BB05407[3];
}
else{
ISpace["M_Active"].Value = null;ISpace["M_Total"].Value = null;ISpace["M_InActive"].Value = null;ISpace["M_Closed"].Value = null;
}
}
base.WriteDebugInfo(@"Root-OnAfterFormLoad");

var querySource7c7169a9e40ff76a533ea141d2b9dada =GetQueryExpressionDataSource("7c7169a9-e40f-f76a-533e-a141d2b9dada");

DataTable result7c7169a9e40ff76a533ea141d2b9dada=iSpace.SetGridDataSource(querySource7c7169a9e40ff76a533ea141d2b9dada, _objectFactory.GetGridRPP("TaskList"),@"EXEC TasKDetails ''");

iSpace.InsertGridBindDetails("TaskList","11",querySource7c7169a9e40ff76a533ea141d2b9dada,"EXEC TasKDetails ''",_objectFactory.GetGridRPP("TaskList"));

base.WriteDebugInfo(@"var querySource7c7169a9e40ff76a533ea141d2b9dada =GetQueryExpressionDataSource(""7c7169a9-e40f-f76a-533e-a141d2b9dada"");DataTable result7c7169a9e40ff76a533ea141d2b9dada=iSpace.SetGridDataSource(querySource7c7169a9e40ff76a533ea141d2b9dada, _objectFactory.GetGridRPP(""TaskList""),@""EXEC TasKDetails ''"");iSpace.InsertGridBindDetails(""TaskList"",""11"",querySource7c7169a9e40ff76a533ea141d2b9dada,""EXEC TasKDetails ''"",_objectFactory.GetGridRPP(""TaskList""));");

base.WriteDebugInfo(@"");

base.WriteDebugInfo(@"");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultfa77bea9024c2d44bd3ed5a4ff4f3566=acdataIspaceDB97F08F38484F729604F0992998747E.GetQueryExpressionBindings("fa77bea9-024c-2d44-bd3e-d5a4ff4f3566");
iSpace.SetGridData(result7c7169a9e40ff76a533ea141d2b9dada,resultfa77bea9024c2d44bd3ed5a4ff4f3566,"TaskList",ref ISpace);
iSpace.UpdateGridBindDetails("TaskList",resultfa77bea9024c2d44bd3ed5a4ff4f3566);
base.WriteDebugInfo(@"");
base.WriteDebugInfo(@"");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_add (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Add-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=5EC89147-2FE2-40AF-8446-350FE5E13C57&frmElementId=74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A&PkPrMId=3cfe092a-c9df-42bd-bb7a-d4a6e90379fc&formVersionId=430A1903-C481-4EA5-BDD0-0C7F581A5215&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=5EC89147-2FE2-40AF-8446-350FE5E13C57&frmElementId=74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A&PkPrMId=3cfe092a-c9df-42bd-bb7a-d4a6e90379fc&formVersionId=430A1903-C481-4EA5-BDD0-0C7F581A5215&Ver=0.0000"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_tasklist (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TaskList-OnClick");
ISpace["growid"].Value=ISpace["TaskList_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TaskList_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '@@gv_InstanceId','@@gv_ActivityMapId','D7398AE6-9E08-4A2D-AE91-E8268871D660','#growid',#TaskList_Sequence");

var querySource10C5DF1344B64B4C90A8AFE3AF9F45EF =GetQueryExpressionDataSource("10C5DF13-44B6-4B4C-90A8-AFE3AF9F45EF");
Dictionary<short,object> result10C5DF1344B64B4C90A8AFE3AF9F45EF=iSpace.ExecuteQuery(querySource10C5DF1344B64B4C90A8AFE3AF9F45EF,@"EXEC [LoadFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','D7398AE6-9E08-4A2D-AE91-E8268871D660','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource10C5DF1344B64B4C90A8AFE3AF9F45EF =GetQueryExpressionDataSource(""10C5DF13-44B6-4B4C-90A8-AFE3AF9F45EF"");Dictionary<short,object> result10C5DF1344B64B4C90A8AFE3AF9F45EF=iSpace.ExecuteQuery(querySource10C5DF1344B64B4C90A8AFE3AF9F45EF,@""EXEC [LoadFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','D7398AE6-9E08-4A2D-AE91-E8268871D660','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '@@gv_InstanceId','@@gv_ActivityMapId','D7398AE6-9E08-4A2D-AE91-E8268871D660','#growid',#TaskList_Sequence");

if((result10C5DF1344B64B4C90A8AFE3AF9F45EF!=null) && (result10C5DF1344B64B4C90A8AFE3AF9F45EF.Count!=0))
{
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(8))
ISpace["MFG_w1_created_at"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[8];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(11))
ISpace["MFG_w1_updated_at"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[11];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(7))
ISpace["MFG_w1_is_active"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[7];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(10))
ISpace["MFG_w1_updated_by"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[10];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(0))
ISpace["MFG_w1_task_id"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[0];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(9))
ISpace["MFG_w1_created_by"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[9];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(4))
ISpace["MFG_w1_complexity_code"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[4];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(2))
ISpace["MFG_w1_task_name"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[2];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(3))
ISpace["MFG_w1_task_type_code"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[3];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(6))
ISpace["MFG_w1_task_status"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[6];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(5))
ISpace["MFG_w1_requirement_id"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[5];
if(result10C5DF1344B64B4C90A8AFE3AF9F45EF.ContainsKey(1))
ISpace["MFG_w1_task_code"].Value = result10C5DF1344B64B4C90A8AFE3AF9F45EF[1];
}
else{
ISpace["MFG_w1_created_at"].Value = null;ISpace["MFG_w1_updated_at"].Value = null;ISpace["MFG_w1_is_active"].Value = null;ISpace["MFG_w1_updated_by"].Value = null;ISpace["MFG_w1_task_id"].Value = null;ISpace["MFG_w1_created_by"].Value = null;ISpace["MFG_w1_complexity_code"].Value = null;ISpace["MFG_w1_task_name"].Value = null;ISpace["MFG_w1_task_type_code"].Value = null;ISpace["MFG_w1_task_status"].Value = null;ISpace["MFG_w1_requirement_id"].Value = null;ISpace["MFG_w1_task_code"].Value = null;
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
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_c3e03d70-482e-412c-ab11-9ee7cdbc9d71] ");

var querySourceED2E57810CDB460B9AE469ABBC71529B =GetQueryExpressionDataSource("ED2E5781-0CDB-460B-9AE4-69ABBC71529B");
Dictionary<short,object> resultED2E57810CDB460B9AE469ABBC71529B=iSpace.ExecuteQuery(querySourceED2E57810CDB460B9AE469ABBC71529B,@"EXEC InnovaceNoCode..[FormSave_c3e03d70-482e-412c-ab11-9ee7cdbc9d71] ",false);

base.WriteDebugInfo(@"var querySourceED2E57810CDB460B9AE469ABBC71529B =GetQueryExpressionDataSource(""ED2E5781-0CDB-460B-9AE4-69ABBC71529B"");Dictionary<short,object> resultED2E57810CDB460B9AE469ABBC71529B=iSpace.ExecuteQuery(querySourceED2E57810CDB460B9AE469ABBC71529B,@""EXEC InnovaceNoCode..[FormSave_c3e03d70-482e-412c-ab11-9ee7cdbc9d71] "",false);");
base.WriteDebugInfo(@"");

if((resultED2E57810CDB460B9AE469ABBC71529B!=null) && (resultED2E57810CDB460B9AE469ABBC71529B.Count!=0))
{
if(resultED2E57810CDB460B9AE469ABBC71529B.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultED2E57810CDB460B9AE469ABBC71529B[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_D7398AE6-9E08-4A2D-AE91-E8268871D660]   '@@gv_InstanceId','@@gv_ActivityMapId','D7398AE6-9E08-4A2D-AE91-E8268871D660'");

var querySource861172762A8E45D9BC15A71B04842A87 =GetQueryExpressionDataSource("86117276-2A8E-45D9-BC15-A71B04842A87");
Dictionary<short,object> result861172762A8E45D9BC15A71B04842A87=iSpace.ExecuteQuery(querySource861172762A8E45D9BC15A71B04842A87,@"EXEC InnovaceNoCode..[GridSave_D7398AE6-9E08-4A2D-AE91-E8268871D660]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','D7398AE6-9E08-4A2D-AE91-E8268871D660'",false);

base.WriteDebugInfo(@"var querySource861172762A8E45D9BC15A71B04842A87 =GetQueryExpressionDataSource(""86117276-2A8E-45D9-BC15-A71B04842A87"");Dictionary<short,object> result861172762A8E45D9BC15A71B04842A87=iSpace.ExecuteQuery(querySource861172762A8E45D9BC15A71B04842A87,@""EXEC InnovaceNoCode..[GridSave_D7398AE6-9E08-4A2D-AE91-E8268871D660]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','D7398AE6-9E08-4A2D-AE91-E8268871D660'"",false);");
base.WriteDebugInfo(@"");

if((result861172762A8E45D9BC15A71B04842A87!=null) && (result861172762A8E45D9BC15A71B04842A87.Count!=0))
{
if(result861172762A8E45D9BC15A71B04842A87.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result861172762A8E45D9BC15A71B04842A87[0];
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
private void SubscribeElementEvents_save_tasklist (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_TaskList-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceF1D26DEDA1B940DC84EB9421944A13EE =GetQueryExpressionDataSource("F1D26DED-A1B9-40DC-84EB-9421944A13EE");

DataTable resultF1D26DEDA1B940DC84EB9421944A13EE=iSpace.SetGridDataSource(querySourceF1D26DEDA1B940DC84EB9421944A13EE, _objectFactory.GetGridRPP("TaskList"),@"EXEC [AddFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','D7398AE6-9E08-4A2D-AE91-E8268871D660','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"','" + ISpace["MFG_w1_requirement_id"].Value + @"','" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'");

iSpace.InsertGridBindDetails("TaskList","11",querySourceF1D26DEDA1B940DC84EB9421944A13EE,"EXEC [AddFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','D7398AE6-9E08-4A2D-AE91-E8268871D660','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"','" + ISpace["MFG_w1_requirement_id"].Value + @"','" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'",_objectFactory.GetGridRPP("TaskList"));

base.WriteDebugInfo(@"var querySourceF1D26DEDA1B940DC84EB9421944A13EE =GetQueryExpressionDataSource(""F1D26DED-A1B9-40DC-84EB-9421944A13EE"");DataTable resultF1D26DEDA1B940DC84EB9421944A13EE=iSpace.SetGridDataSource(querySourceF1D26DEDA1B940DC84EB9421944A13EE, _objectFactory.GetGridRPP(""TaskList""),@""EXEC [AddFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','D7398AE6-9E08-4A2D-AE91-E8268871D660','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""','"" + ISpace[""MFG_w1_requirement_id""].Value + @""','"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskList"",""11"",querySourceF1D26DEDA1B940DC84EB9421944A13EE,""EXEC [AddFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','D7398AE6-9E08-4A2D-AE91-E8268871D660','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""','"" + ISpace[""MFG_w1_requirement_id""].Value + @""','"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"",_objectFactory.GetGridRPP(""TaskList""));");
base.WriteDebugInfo(@"EXEC [AddFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '@@gv_InstanceId','@@gv_ActivityMapId','D7398AE6-9E08-4A2D-AE91-E8268871D660','#growid',#TaskList_Sequence,#MFG_w1_task_id,'#MFG_w1_task_code','#MFG_w1_task_name','#MFG_w1_task_type_code','#MFG_w1_complexity_code','#MFG_w1_requirement_id','#MFG_w1_task_status',#MFG_w1_is_active,'#MFG_w1_created_at',#MFG_w1_created_by,#MFG_w1_updated_by,'#MFG_w1_updated_at'");


List<Triplet<string, short, short?>> resultB84A2E331ABB42358E972621E99F4124=acdataIspaceDB97F08F38484F729604F0992998747E.GetQueryExpressionBindings("B84A2E33-1ABB-4235-8E97-2621E99F4124");
iSpace.SetGridData(resultF1D26DEDA1B940DC84EB9421944A13EE,resultB84A2E331ABB42358E972621E99F4124,"TaskList",ref ISpace);
iSpace.UpdateGridBindDetails("TaskList",resultB84A2E331ABB42358E972621E99F4124);
}
else
{
base.WriteDebugInfo(@"else");

var querySource42D763EB43364340949ACF732202B305 =GetQueryExpressionDataSource("42D763EB-4336-4340-949A-CF732202B305");

DataTable result42D763EB43364340949ACF732202B305=iSpace.SetGridDataSource(querySource42D763EB43364340949ACF732202B305, _objectFactory.GetGridRPP("TaskList"),@"EXEC [UpdateFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','D7398AE6-9E08-4A2D-AE91-E8268871D660','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"','" + ISpace["MFG_w1_requirement_id"].Value + @"','" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'");

iSpace.InsertGridBindDetails("TaskList","11",querySource42D763EB43364340949ACF732202B305,"EXEC [UpdateFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','D7398AE6-9E08-4A2D-AE91-E8268871D660','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"','" + ISpace["MFG_w1_requirement_id"].Value + @"','" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'",_objectFactory.GetGridRPP("TaskList"));

base.WriteDebugInfo(@"var querySource42D763EB43364340949ACF732202B305 =GetQueryExpressionDataSource(""42D763EB-4336-4340-949A-CF732202B305"");DataTable result42D763EB43364340949ACF732202B305=iSpace.SetGridDataSource(querySource42D763EB43364340949ACF732202B305, _objectFactory.GetGridRPP(""TaskList""),@""EXEC [UpdateFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','D7398AE6-9E08-4A2D-AE91-E8268871D660','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""','"" + ISpace[""MFG_w1_requirement_id""].Value + @""','"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskList"",""11"",querySource42D763EB43364340949ACF732202B305,""EXEC [UpdateFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','D7398AE6-9E08-4A2D-AE91-E8268871D660','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""','"" + ISpace[""MFG_w1_requirement_id""].Value + @""','"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"",_objectFactory.GetGridRPP(""TaskList""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridDataD7398AE6-9E08-4A2D-AE91-E8268871D660] '@@gv_InstanceId','@@gv_ActivityMapId','D7398AE6-9E08-4A2D-AE91-E8268871D660','#growid',#TaskList_Sequence,#MFG_w1_task_id,'#MFG_w1_task_code','#MFG_w1_task_name','#MFG_w1_task_type_code','#MFG_w1_complexity_code','#MFG_w1_requirement_id','#MFG_w1_task_status',#MFG_w1_is_active,'#MFG_w1_created_at',#MFG_w1_created_by,#MFG_w1_updated_by,'#MFG_w1_updated_at'");


List<Triplet<string, short, short?>> result6E54403F349E464A8C4D07EF8B36B21E=acdataIspaceDB97F08F38484F729604F0992998747E.GetQueryExpressionBindings("6E54403F-349E-464A-8C4D-07EF8B36B21E");
iSpace.SetGridData(result42D763EB43364340949ACF732202B305,result6E54403F349E464A8C4D07EF8B36B21E,"TaskList",ref ISpace);
iSpace.UpdateGridBindDetails("TaskList",result6E54403F349E464A8C4D07EF8B36B21E);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_w1_task_id"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_task_id""].Value="""";");
ISpace["MFG_w1_task_code"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_task_code""].Value="""";");
ISpace["MFG_w1_task_name"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_task_name""].Value="""";");
ISpace["MFG_w1_task_type_code"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_task_type_code""].Value="""";");
ISpace["MFG_w1_complexity_code"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_complexity_code""].Value="""";");
ISpace["MFG_w1_requirement_id"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_requirement_id""].Value="""";");
ISpace["MFG_w1_task_status"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_task_status""].Value="""";");
ISpace["MFG_w1_is_active"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_is_active""].Value="""";");
ISpace["MFG_w1_created_at"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_created_at""].Value="""";");
ISpace["MFG_w1_created_by"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_created_by""].Value="""";");
ISpace["MFG_w1_updated_by"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_updated_by""].Value="""";");
ISpace["MFG_w1_updated_at"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_w1_updated_at""].Value="""";");
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
		if(elementName.ToLower().Equals("m_add"))
{
			SubscribeElementEvents_m_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_tasklist"))
{
			SubscribeElementEvents_edit_tasklist(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_tasklist"))
{
			SubscribeElementEvents_save_tasklist(ref dfsParam);
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


	public partial class AcDataISpaceDB97F08F38484F729604F0992998747E  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"6E54403F-349E-464A-8C4D-07EF8B36B21E", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_by",10,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_requirement_id",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_by",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("TaskList_RowId",12,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_complexity_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_at",11,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_is_active",7,
														   -1),
								}
			},
							{"B84A2E33-1ABB-4235-8E97-2621E99F4124", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_updated_at",11,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_complexity_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_is_active",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_by",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_by",10,
														   -1),
								   new Triplet<string, short, short?>("TaskList_RowId",12,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_requirement_id",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								}
			},
							{"fa77bea9-024c-2d44-bd3e-d5a4ff4f3566", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_requirement_id",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_complexity_code",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"A0143487-7893-4E57-855C-5304AB135279", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"562CC389-55AF-4EF6-BAC1-0F87B353A283", ""},
							{"7C7D1BFE-0CBE-4E23-B5C1-5F22EB5FD9A6", ""},
							{"A0143487-7893-4E57-855C-5304AB135279", ""},
							{"D789654F-B098-43F4-922D-0B19A6AF6D0D", ""},
							{"BE2F1075-4410-421C-9095-2F46F936BC57", ""},
							{"0E6A4520-3126-47D2-9D18-434DD57398A3", ""},
							{"7D88DF8C-DB32-4A69-9EBE-2359B56D3340", ""},
							{"E2CC482D-28F3-4738-9F55-432995FFD740", ""},
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
		


