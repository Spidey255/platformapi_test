  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TaskExplorerProcessMetadata : ExtensionProcessBase
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
            get { return "7e6b302b-b86e-4442-a995-03bc22d48abc"; }
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
            get {return "7e6b302b-b86e-4442-a995-03bc22d48abc";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "AF23D0EC-36C6-4FB1-8C58-BE89BD0BC74D";	}
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
	  			
			     new Triplet<string, string, string>("1e0abf5a-2c93-8afd-e556-c0e6896bcc29","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("799aca0d-883e-a868-677d-5f43dddca1bf","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("799aca0d-883e-a868-677d-5f43dddca1bf","Load Existing Task Details",
												     @"23E51A25-3499-4878-9320-2D2EC2D75862"),
			
			
			
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
		
	  			
			     new Tuple<string, int>("TastDetails",50),
			
						
			     new Tuple<string, int>("TastDetails",5),
			
						
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
											case "5B035305-E81B-4571-BBE4-724D00438E54":
							virtualInstance=new ISpace5B035305E81B4571BBE4724D00438E54();
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

               
                
                                      case "AF23D0EC-36C6-4FB1-8C58-BE89BD0BC74D":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [AF23D0EC-36C6-4FB1-8C58-BE89BD0BC74D] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [AF23D0EC-36C6-4FB1-8C58-BE89BD0BC74D](InstanceId,ProcessActivityMapId,FormId,M_Total,M_Active,M_InActive,M_Closed,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,M_SearchBy)  
       VALUES( {3}) END ELSE BEGIN UPDATE [AF23D0EC-36C6-4FB1-8C58-BE89BD0BC74D]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,M_Total,M_Active,M_InActive,M_Closed,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,M_SearchBy";
                                    
                     
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

                
                 
                                      case "23E51A25-3499-4878-9320-2D2EC2D75862":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_23E51A253499487893202D2EC2D75862 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w1_task_id] INT	, [MG_w1_task_code] VARCHAR(50)	, [MG_w1_task_name] VARCHAR(50)	, [MG_w1_task_type_code] VARCHAR(50)	, [MG_w1_complexity_code] VARCHAR(50)	, [MG_w1_requirement_id] VARCHAR(50)	, [MG_w1_task_status] VARCHAR(50)	, [MG_w1_is_active] BIT	, [MG_w1_created_at] DATETIME	, [MG_w1_created_by] INT	, [MG_w1_updated_by] INT	, [MG_w1_updated_at] DATETIME){0}INSERT INTO [23E51A25-3499-4878-9320-2D2EC2D75862](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_task_id,MG_w1_task_code,MG_w1_task_name,MG_w1_task_type_code,MG_w1_complexity_code,MG_w1_requirement_id,MG_w1_task_status,MG_w1_is_active,MG_w1_created_at,MG_w1_created_by,MG_w1_updated_by,MG_w1_updated_at)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w1_task_id,TDT.MG_w1_task_code,TDT.MG_w1_task_name,TDT.MG_w1_task_type_code,TDT.MG_w1_complexity_code,TDT.MG_w1_requirement_id,TDT.MG_w1_task_status,TDT.MG_w1_is_active,TDT.MG_w1_created_at,TDT.MG_w1_created_by,TDT.MG_w1_updated_by,TDT.MG_w1_updated_at FROM @TBL_23E51A253499487893202D2EC2D75862 TDT
							LEFT JOIN [23E51A25-3499-4878-9320-2D2EC2D75862] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_task_id,MG_w1_task_code,MG_w1_task_name,MG_w1_task_type_code,MG_w1_complexity_code,MG_w1_requirement_id,MG_w1_task_status,MG_w1_is_active,MG_w1_created_at,MG_w1_created_by,MG_w1_updated_by,MG_w1_updated_at";

                                     tempInsertQuery=@"INSERT INTO @TBL_23E51A253499487893202D2EC2D75862(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_task_id,MG_w1_task_code,MG_w1_task_name,MG_w1_task_type_code,MG_w1_complexity_code,MG_w1_requirement_id,MG_w1_task_status,MG_w1_is_active,MG_w1_created_at,MG_w1_created_by,MG_w1_updated_by,MG_w1_updated_at)VALUES({0});";
                                     

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
                     

                                         case "23E51A25-3499-4878-9320-2D2EC2D75862":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_23E51A253499487893202D2EC2D75862 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w1_task_id] INT	, [MG_w1_task_code] VARCHAR(50)	, [MG_w1_task_name] VARCHAR(50)	, [MG_w1_task_type_code] VARCHAR(50)	, [MG_w1_complexity_code] VARCHAR(50)	, [MG_w1_requirement_id] VARCHAR(50)	, [MG_w1_task_status] VARCHAR(50)	, [MG_w1_is_active] BIT	, [MG_w1_created_at] DATETIME	, [MG_w1_created_by] INT	, [MG_w1_updated_by] INT	, [MG_w1_updated_at] DATETIME){0}INSERT INTO [23E51A25-3499-4878-9320-2D2EC2D75862](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_task_id,MG_w1_task_code,MG_w1_task_name,MG_w1_task_type_code,MG_w1_complexity_code,MG_w1_requirement_id,MG_w1_task_status,MG_w1_is_active,MG_w1_created_at,MG_w1_created_by,MG_w1_updated_by,MG_w1_updated_at)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w1_task_id,TDT.MG_w1_task_code,TDT.MG_w1_task_name,TDT.MG_w1_task_type_code,TDT.MG_w1_complexity_code,TDT.MG_w1_requirement_id,TDT.MG_w1_task_status,TDT.MG_w1_is_active,TDT.MG_w1_created_at,TDT.MG_w1_created_by,TDT.MG_w1_updated_by,TDT.MG_w1_updated_at FROM @TBL_23E51A253499487893202D2EC2D75862 TDT
							LEFT JOIN [23E51A25-3499-4878-9320-2D2EC2D75862] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_task_id,MG_w1_task_code,MG_w1_task_name,MG_w1_task_type_code,MG_w1_complexity_code,MG_w1_requirement_id,MG_w1_task_status,MG_w1_is_active,MG_w1_created_at,MG_w1_created_by,MG_w1_updated_by,MG_w1_updated_at";

                            tempInsertQuery=@"INSERT INTO @TBL_23E51A253499487893202D2EC2D75862(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_task_id,MG_w1_task_code,MG_w1_task_name,MG_w1_task_type_code,MG_w1_complexity_code,MG_w1_requirement_id,MG_w1_task_status,MG_w1_is_active,MG_w1_created_at,MG_w1_created_by,MG_w1_updated_by,MG_w1_updated_at)VALUES({0});";

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
public class ISpace5B035305E81B4571BBE4724D00438E54 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace5B035305E81B4571BBE4724D00438E54 acdataIspace5B035305E81B4571BBE4724D00438E54=new AcDataISpace5B035305E81B4571BBE4724D00438E54();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
Dictionary<short, object> keyValuePairs = null;base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetTaskSummary");

var querySource1e0abf5a2c938afde556c0e6896bcc29 =GetQueryExpressionDataSource("1e0abf5a-2c93-8afd-e556-c0e6896bcc29");
Dictionary<short,object> result1e0abf5a2c938afde556c0e6896bcc29=iSpace.ExecuteQuery(querySource1e0abf5a2c938afde556c0e6896bcc29,@"EXEC GetTaskSummary",false);

base.WriteDebugInfo(@"var querySource1e0abf5a2c938afde556c0e6896bcc29 =GetQueryExpressionDataSource(""1e0abf5a-2c93-8afd-e556-c0e6896bcc29"");Dictionary<short,object> result1e0abf5a2c938afde556c0e6896bcc29=iSpace.ExecuteQuery(querySource1e0abf5a2c938afde556c0e6896bcc29,@""EXEC GetTaskSummary"",false);");
base.WriteDebugInfo(@"");

if((result1e0abf5a2c938afde556c0e6896bcc29!=null) && (result1e0abf5a2c938afde556c0e6896bcc29.Count!=0))
{
if(result1e0abf5a2c938afde556c0e6896bcc29.ContainsKey(3))
ISpace["M_Closed"].Value = result1e0abf5a2c938afde556c0e6896bcc29[3];
if(result1e0abf5a2c938afde556c0e6896bcc29.ContainsKey(0))
ISpace["M_Total"].Value = result1e0abf5a2c938afde556c0e6896bcc29[0];
if(result1e0abf5a2c938afde556c0e6896bcc29.ContainsKey(1))
ISpace["M_Active"].Value = result1e0abf5a2c938afde556c0e6896bcc29[1];
if(result1e0abf5a2c938afde556c0e6896bcc29.ContainsKey(2))
ISpace["M_InActive"].Value = result1e0abf5a2c938afde556c0e6896bcc29[2];
}
else{
ISpace["M_Closed"].Value = null;ISpace["M_Total"].Value = null;ISpace["M_Active"].Value = null;ISpace["M_InActive"].Value = null;
}

var querySource799aca0d883ea868677d5f43dddca1bf =GetQueryExpressionDataSource("799aca0d-883e-a868-677d-5f43dddca1bf");

DataTable result799aca0d883ea868677d5f43dddca1bf=iSpace.SetGridDataSource(querySource799aca0d883ea868677d5f43dddca1bf, _objectFactory.GetGridRPP("TastDetails"),@"EXEC TasKDetails ''");

iSpace.InsertGridBindDetails("TastDetails","11",querySource799aca0d883ea868677d5f43dddca1bf,"EXEC TasKDetails ''",_objectFactory.GetGridRPP("TastDetails"));

base.WriteDebugInfo(@"var querySource799aca0d883ea868677d5f43dddca1bf =GetQueryExpressionDataSource(""799aca0d-883e-a868-677d-5f43dddca1bf"");DataTable result799aca0d883ea868677d5f43dddca1bf=iSpace.SetGridDataSource(querySource799aca0d883ea868677d5f43dddca1bf, _objectFactory.GetGridRPP(""TastDetails""),@""EXEC TasKDetails ''"");iSpace.InsertGridBindDetails(""TastDetails"",""11"",querySource799aca0d883ea868677d5f43dddca1bf,""EXEC TasKDetails ''"",_objectFactory.GetGridRPP(""TastDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result3af47cd6d5ccfa0478e604749ae0b6b1=acdataIspace5B035305E81B4571BBE4724D00438E54.GetQueryExpressionBindings("3af47cd6-d5cc-fa04-78e6-04749ae0b6b1");
iSpace.SetGridData(result799aca0d883ea868677d5f43dddca1bf,result3af47cd6d5ccfa0478e604749ae0b6b1,"TastDetails",ref ISpace);
iSpace.UpdateGridBindDetails("TastDetails",result3af47cd6d5ccfa0478e604749ae0b6b1);
}
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


	public partial class AcDataISpace5B035305E81B4571BBE4724D00438E54  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"3af47cd6-d5cc-fa04-78e6-04749ae0b6b1", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_complexity_code",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_requirement_id",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",4,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"C75E5B7B-EA0D-42F6-8C53-22D5D2071CCA", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"1258F5E9-861B-477F-9ECF-B11DEDCE87E2", ""},
							{"3E07D973-2A62-4A70-ABF4-6D86290F31E2", ""},
							{"C75E5B7B-EA0D-42F6-8C53-22D5D2071CCA", ""},
							{"16B7E381-69C7-448C-AA9A-FCD560C297C7", ""},
							{"F4209E9A-FA1D-4F19-97F0-4F72891FE520", ""},
							{"B2B173CE-BF41-43F3-825A-DC5084ECC6C3", ""},
							{"0A1EBB18-B20D-46EE-819D-AF8FD272E2D9", ""},
							{"5BFA353B-5FBC-45A7-9BD2-CEDD1EAC6D78", ""},
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
		


