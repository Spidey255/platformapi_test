  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class SaveformandGridModeandDFSTriggersCheckProcessMetadata : ExtensionProcessBase
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
            get { return "538a803e-6c06-4c27-93cc-70c799929208"; }
        }

        public override string ProcessName
        {
            get { return "SaveformandGridModeandDFSTriggersCheck"; }
        }

		public override string ProcessDescription
        {
            get { return "Save form and Grid Mode and DFS Triggers Check"; }
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
            get {return "538a803e-6c06-4c27-93cc-70c799929208";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "88722729-8C60-4820-9795-B12AC6250CDD";	}
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
	

	public partial class SaveformandGridModeandDFSTriggersCheckObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new SaveformandGridModeandDFSTriggersCheckProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("35CCCB69-E43C-472F-A949-421C3A93AE37","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("C31B0865-13F0-4684-8CB0-3CDABB8440C0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("EE86D584-B371-405F-9A51-A4E3E8D70A46","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("C31B0865-13F0-4684-8CB0-3CDABB8440C0","Grid BindingA",
												     @"C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70"),
			
						
			     new Triplet<string, string, string>("EE86D584-B371-405F-9A51-A4E3E8D70A46","Grid Binding0",
												     @"C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70"),
			
			
			
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
											case "A9AB7216-BBDF-4809-99E0-287241FB0152":
							virtualInstance=new ISpaceA9AB7216BBDF480999E0287241FB0152();
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
	

	public partial class SaveformandGridModeandDFSTriggersCheckDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public SaveformandGridModeandDFSTriggersCheckDataElementFactory()
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

               
                
                                      case "88722729-8C60-4820-9795-B12AC6250CDD":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [88722729-8C60-4820-9795-B12AC6250CDD] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [88722729-8C60-4820-9795-B12AC6250CDD](InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MFG_w1_task_id,MFG_w1_task_code,MFG_w1_task_name,MFG_w1_task_type_code,MFG_w1_complexity_code,MFG_w1_requirement_id,MFG_w1_task_status,MFG_w1_is_active,MFG_w1_created_at,MFG_w1_created_by,MFG_w1_updated_by,MFG_w1_updated_at,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid)  
       VALUES( {3}) END ELSE BEGIN UPDATE [88722729-8C60-4820-9795-B12AC6250CDD]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MFG_w1_task_id,MFG_w1_task_code,MFG_w1_task_name,MFG_w1_task_type_code,MFG_w1_complexity_code,MFG_w1_requirement_id,MFG_w1_task_status,MFG_w1_is_active,MFG_w1_created_at,MFG_w1_created_by,MFG_w1_updated_by,MFG_w1_updated_at,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid";
                                    
                     
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

                
                 
                                      case "C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_C14A3E981FFE493BBDD6F64CDD3A3C70 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w1_complexity_code] NVARCHAR(12)	, [MG_w1_updated_at] DATETIME	, [MG_w1_requirement_id] BIGINT	, [MG_w1_is_active] BIT	, [MG_w1_task_id] BIGINT	, [MG_w1_updated_by] BIGINT	, [MG_w1_task_code] NVARCHAR(12)	, [MG_w1_created_at] DATETIME	, [MG_w1_task_name] NVARCHAR(12)	, [MG_w1_task_status] NVARCHAR(12)	, [MG_w1_created_by] BIGINT	, [MG_w1_task_type_code] NVARCHAR(12)){0}INSERT INTO [C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_updated_at,MG_w1_requirement_id,MG_w1_is_active,MG_w1_task_id,MG_w1_updated_by,MG_w1_task_code,MG_w1_created_at,MG_w1_task_name,MG_w1_task_status,MG_w1_created_by,MG_w1_task_type_code)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w1_complexity_code,TDT.MG_w1_updated_at,TDT.MG_w1_requirement_id,TDT.MG_w1_is_active,TDT.MG_w1_task_id,TDT.MG_w1_updated_by,TDT.MG_w1_task_code,TDT.MG_w1_created_at,TDT.MG_w1_task_name,TDT.MG_w1_task_status,TDT.MG_w1_created_by,TDT.MG_w1_task_type_code FROM @TBL_C14A3E981FFE493BBDD6F64CDD3A3C70 TDT
							LEFT JOIN [C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_updated_at,MG_w1_requirement_id,MG_w1_is_active,MG_w1_task_id,MG_w1_updated_by,MG_w1_task_code,MG_w1_created_at,MG_w1_task_name,MG_w1_task_status,MG_w1_created_by,MG_w1_task_type_code";

                                     tempInsertQuery=@"INSERT INTO @TBL_C14A3E981FFE493BBDD6F64CDD3A3C70(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_updated_at,MG_w1_requirement_id,MG_w1_is_active,MG_w1_task_id,MG_w1_updated_by,MG_w1_task_code,MG_w1_created_at,MG_w1_task_name,MG_w1_task_status,MG_w1_created_by,MG_w1_task_type_code)VALUES({0});";
                                     

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
                     

                                         case "C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_C14A3E981FFE493BBDD6F64CDD3A3C70 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w1_complexity_code] NVARCHAR(12)	, [MG_w1_updated_at] DATETIME	, [MG_w1_requirement_id] BIGINT	, [MG_w1_is_active] BIT	, [MG_w1_task_id] BIGINT	, [MG_w1_updated_by] BIGINT	, [MG_w1_task_code] NVARCHAR(12)	, [MG_w1_created_at] DATETIME	, [MG_w1_task_name] NVARCHAR(12)	, [MG_w1_task_status] NVARCHAR(12)	, [MG_w1_created_by] BIGINT	, [MG_w1_task_type_code] NVARCHAR(12)){0}INSERT INTO [C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_updated_at,MG_w1_requirement_id,MG_w1_is_active,MG_w1_task_id,MG_w1_updated_by,MG_w1_task_code,MG_w1_created_at,MG_w1_task_name,MG_w1_task_status,MG_w1_created_by,MG_w1_task_type_code)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w1_complexity_code,TDT.MG_w1_updated_at,TDT.MG_w1_requirement_id,TDT.MG_w1_is_active,TDT.MG_w1_task_id,TDT.MG_w1_updated_by,TDT.MG_w1_task_code,TDT.MG_w1_created_at,TDT.MG_w1_task_name,TDT.MG_w1_task_status,TDT.MG_w1_created_by,TDT.MG_w1_task_type_code FROM @TBL_C14A3E981FFE493BBDD6F64CDD3A3C70 TDT
							LEFT JOIN [C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_updated_at,MG_w1_requirement_id,MG_w1_is_active,MG_w1_task_id,MG_w1_updated_by,MG_w1_task_code,MG_w1_created_at,MG_w1_task_name,MG_w1_task_status,MG_w1_created_by,MG_w1_task_type_code";

                            tempInsertQuery=@"INSERT INTO @TBL_C14A3E981FFE493BBDD6F64CDD3A3C70(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_updated_at,MG_w1_requirement_id,MG_w1_is_active,MG_w1_task_id,MG_w1_updated_by,MG_w1_task_code,MG_w1_created_at,MG_w1_task_name,MG_w1_task_status,MG_w1_created_by,MG_w1_task_type_code)VALUES({0});";

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
public class ISpaceA9AB7216BBDF480999E0287241FB0152 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceA9AB7216BBDF480999E0287241FB0152 acdataIspaceA9AB7216BBDF480999E0287241FB0152=new AcDataISpaceA9AB7216BBDF480999E0287241FB0152();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
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

var querySourceC31B086513F046848CB03CDABB8440C0 =GetQueryExpressionDataSource("C31B0865-13F0-4684-8CB0-3CDABB8440C0");

DataTable resultC31B086513F046848CB03CDABB8440C0=iSpace.SetGridDataSource(querySourceC31B086513F046848CB03CDABB8440C0, _objectFactory.GetGridRPP("TaskList"),@"EXEC [AddFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"'," + ISpace["MFG_w1_requirement_id"].Value + @",'" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'");

iSpace.InsertGridBindDetails("TaskList","11",querySourceC31B086513F046848CB03CDABB8440C0,"EXEC [AddFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"'," + ISpace["MFG_w1_requirement_id"].Value + @",'" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'",_objectFactory.GetGridRPP("TaskList"));

base.WriteDebugInfo(@"var querySourceC31B086513F046848CB03CDABB8440C0 =GetQueryExpressionDataSource(""C31B0865-13F0-4684-8CB0-3CDABB8440C0"");DataTable resultC31B086513F046848CB03CDABB8440C0=iSpace.SetGridDataSource(querySourceC31B086513F046848CB03CDABB8440C0, _objectFactory.GetGridRPP(""TaskList""),@""EXEC [AddFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""',"" + ISpace[""MFG_w1_requirement_id""].Value + @"",'"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskList"",""11"",querySourceC31B086513F046848CB03CDABB8440C0,""EXEC [AddFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""',"" + ISpace[""MFG_w1_requirement_id""].Value + @"",'"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"",_objectFactory.GetGridRPP(""TaskList""));");
base.WriteDebugInfo(@"EXEC [AddFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '@@gv_InstanceId','@@gv_ActivityMapId','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','#growid',#TaskList_Sequence,#MFG_w1_task_id,'#MFG_w1_task_code','#MFG_w1_task_name','#MFG_w1_task_type_code','#MFG_w1_complexity_code',#MFG_w1_requirement_id,'#MFG_w1_task_status',#MFG_w1_is_active,'#MFG_w1_created_at',#MFG_w1_created_by,#MFG_w1_updated_by,'#MFG_w1_updated_at'");


List<Triplet<string, short, short?>> resultC52E867F55ED451081F602C57616FEFB=acdataIspaceA9AB7216BBDF480999E0287241FB0152.GetQueryExpressionBindings("C52E867F-55ED-4510-81F6-02C57616FEFB");
iSpace.SetGridData(resultC31B086513F046848CB03CDABB8440C0,resultC52E867F55ED451081F602C57616FEFB,"TaskList",ref ISpace);
iSpace.UpdateGridBindDetails("TaskList",resultC52E867F55ED451081F602C57616FEFB);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceEE86D584B371405F9A51A4E3E8D70A46 =GetQueryExpressionDataSource("EE86D584-B371-405F-9A51-A4E3E8D70A46");

DataTable resultEE86D584B371405F9A51A4E3E8D70A46=iSpace.SetGridDataSource(querySourceEE86D584B371405F9A51A4E3E8D70A46, _objectFactory.GetGridRPP("TaskList"),@"EXEC [UpdateFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"'," + ISpace["MFG_w1_requirement_id"].Value + @",'" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'");

iSpace.InsertGridBindDetails("TaskList","11",querySourceEE86D584B371405F9A51A4E3E8D70A46,"EXEC [UpdateFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"'," + ISpace["MFG_w1_requirement_id"].Value + @",'" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'",_objectFactory.GetGridRPP("TaskList"));

base.WriteDebugInfo(@"var querySourceEE86D584B371405F9A51A4E3E8D70A46 =GetQueryExpressionDataSource(""EE86D584-B371-405F-9A51-A4E3E8D70A46"");DataTable resultEE86D584B371405F9A51A4E3E8D70A46=iSpace.SetGridDataSource(querySourceEE86D584B371405F9A51A4E3E8D70A46, _objectFactory.GetGridRPP(""TaskList""),@""EXEC [UpdateFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""',"" + ISpace[""MFG_w1_requirement_id""].Value + @"",'"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskList"",""11"",querySourceEE86D584B371405F9A51A4E3E8D70A46,""EXEC [UpdateFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""',"" + ISpace[""MFG_w1_requirement_id""].Value + @"",'"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"",_objectFactory.GetGridRPP(""TaskList""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '@@gv_InstanceId','@@gv_ActivityMapId','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','#growid',#TaskList_Sequence,#MFG_w1_task_id,'#MFG_w1_task_code','#MFG_w1_task_name','#MFG_w1_task_type_code','#MFG_w1_complexity_code',#MFG_w1_requirement_id,'#MFG_w1_task_status',#MFG_w1_is_active,'#MFG_w1_created_at',#MFG_w1_created_by,#MFG_w1_updated_by,'#MFG_w1_updated_at'");


List<Triplet<string, short, short?>> resultD42AA63F720B423580BDC613EBFF6EF3=acdataIspaceA9AB7216BBDF480999E0287241FB0152.GetQueryExpressionBindings("D42AA63F-720B-4235-80BD-C613EBFF6EF3");
iSpace.SetGridData(resultEE86D584B371405F9A51A4E3E8D70A46,resultD42AA63F720B423580BDC613EBFF6EF3,"TaskList",ref ISpace);
iSpace.UpdateGridBindDetails("TaskList",resultD42AA63F720B423580BDC613EBFF6EF3);
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
private void SubscribeElementEvents_edit_tasklist (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TaskList-OnClick");
ISpace["growid"].Value=ISpace["TaskList_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TaskList_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '@@gv_InstanceId','@@gv_ActivityMapId','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','#growid',#TaskList_Sequence");

var querySource35CCCB69E43C472FA949421C3A93AE37 =GetQueryExpressionDataSource("35CCCB69-E43C-472F-A949-421C3A93AE37");
Dictionary<short,object> result35CCCB69E43C472FA949421C3A93AE37=iSpace.ExecuteQuery(querySource35CCCB69E43C472FA949421C3A93AE37,@"EXEC [LoadFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','" + ISpace["growid"].Value + @"'," + ISpace["TaskList_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource35CCCB69E43C472FA949421C3A93AE37 =GetQueryExpressionDataSource(""35CCCB69-E43C-472F-A949-421C3A93AE37"");Dictionary<short,object> result35CCCB69E43C472FA949421C3A93AE37=iSpace.ExecuteQuery(querySource35CCCB69E43C472FA949421C3A93AE37,@""EXEC [LoadFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskList_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataC14A3E98-1FFE-493B-BDD6-F64CDD3A3C70] '@@gv_InstanceId','@@gv_ActivityMapId','C14A3E98-1FFE-493B-BDD6-F64CDD3A3C70','#growid',#TaskList_Sequence");

if((result35CCCB69E43C472FA949421C3A93AE37!=null) && (result35CCCB69E43C472FA949421C3A93AE37.Count!=0))
{
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(8))
ISpace["MFG_w1_created_at"].Value = result35CCCB69E43C472FA949421C3A93AE37[8];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(11))
ISpace["MFG_w1_updated_at"].Value = result35CCCB69E43C472FA949421C3A93AE37[11];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(7))
ISpace["MFG_w1_is_active"].Value = result35CCCB69E43C472FA949421C3A93AE37[7];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(10))
ISpace["MFG_w1_updated_by"].Value = result35CCCB69E43C472FA949421C3A93AE37[10];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(5))
ISpace["MFG_w1_requirement_id"].Value = result35CCCB69E43C472FA949421C3A93AE37[5];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(0))
ISpace["MFG_w1_task_id"].Value = result35CCCB69E43C472FA949421C3A93AE37[0];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(9))
ISpace["MFG_w1_created_by"].Value = result35CCCB69E43C472FA949421C3A93AE37[9];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(3))
ISpace["MFG_w1_task_type_code"].Value = result35CCCB69E43C472FA949421C3A93AE37[3];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(4))
ISpace["MFG_w1_complexity_code"].Value = result35CCCB69E43C472FA949421C3A93AE37[4];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(6))
ISpace["MFG_w1_task_status"].Value = result35CCCB69E43C472FA949421C3A93AE37[6];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(1))
ISpace["MFG_w1_task_code"].Value = result35CCCB69E43C472FA949421C3A93AE37[1];
if(result35CCCB69E43C472FA949421C3A93AE37.ContainsKey(2))
ISpace["MFG_w1_task_name"].Value = result35CCCB69E43C472FA949421C3A93AE37[2];
}
else{
ISpace["MFG_w1_created_at"].Value = null;ISpace["MFG_w1_updated_at"].Value = null;ISpace["MFG_w1_is_active"].Value = null;ISpace["MFG_w1_updated_by"].Value = null;ISpace["MFG_w1_requirement_id"].Value = null;ISpace["MFG_w1_task_id"].Value = null;ISpace["MFG_w1_created_by"].Value = null;ISpace["MFG_w1_task_type_code"].Value = null;ISpace["MFG_w1_complexity_code"].Value = null;ISpace["MFG_w1_task_status"].Value = null;ISpace["MFG_w1_task_code"].Value = null;ISpace["MFG_w1_task_name"].Value = null;
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
		if(elementName.ToLower().Equals("save_tasklist"))
{
			SubscribeElementEvents_save_tasklist(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_tasklist"))
{
			SubscribeElementEvents_edit_tasklist(ref dfsParam);
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


	public partial class AcDataISpaceA9AB7216BBDF480999E0287241FB0152  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"C52E867F-55ED-4510-81F6-02C57616FEFB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_complexity_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_by",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_is_active",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_requirement_id",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_at",11,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_by",10,
														   -1),
								   new Triplet<string, short, short?>("TaskList_RowId",12,
														   -1),
								}
			},
							{"D42AA63F-720B-4235-80BD-C613EBFF6EF3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_complexity_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_by",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_is_active",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_requirement_id",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_at",11,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_by",10,
														   -1),
								   new Triplet<string, short, short?>("TaskList_RowId",12,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"D3F6A2DC-1291-48D8-BC5E-BF48895B1AFB", ""},
							{"328B16C7-F37E-4470-8D65-187AE53D2EB4", ""},
							{"E5146821-D6C5-4AD6-BF08-F8BBE05AABAB", ""},
							{"3B005A71-3C2F-4294-94BE-D6918558FF3F", ""},
							{"468FB8E9-6972-43FA-ACFA-26F5D2570A96", ""},
							{"DAC41031-9B7B-4A37-8A01-94F9FDA759A9", ""},
							{"D1E397D4-C0E2-4DD0-8452-ECB56D2D0619", ""},
							{"A6D2965E-6373-4EEF-B04B-DDDDB77C9275", ""},
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
		


