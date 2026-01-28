  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TaskExplorerFinalTestProcessMetadata : ExtensionProcessBase
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
            get { return "326f2ae9-a901-4f09-a24f-975c3089ab28"; }
        }

        public override string ProcessName
        {
            get { return "TaskExplorerFinalTest"; }
        }

		public override string ProcessDescription
        {
            get { return "Task Explorer Final Test"; }
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
            get {return "326f2ae9-a901-4f09-a24f-975c3089ab28";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "F62DB390-173B-42EE-AE1E-6F4A679A2891";	}
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
	

	public partial class TaskExplorerFinalTestObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TaskExplorerFinalTestProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("DF207FF8-1EE9-48DF-B90E-0F787E63CEFB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("99BD5794-D71F-47F5-BA1E-3B89F31E1644","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("07A4CC4B-4223-4887-A63B-89EDD0F1A4F6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("99BD5794-D71F-47F5-BA1E-3B89F31E1644","Grid Binding6",
												     @"41221100-974C-443A-8CAD-BFA77804C77D"),
			
						
			     new Triplet<string, string, string>("07A4CC4B-4223-4887-A63B-89EDD0F1A4F6","Grid Binding6",
												     @"41221100-974C-443A-8CAD-BFA77804C77D"),
			
			
			
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
											case "90D42959-F9CE-4EFD-92A1-FB387AE4DB9F":
							virtualInstance=new ISpace90D42959F9CE4EFD92A1FB387AE4DB9F();
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
	

	public partial class TaskExplorerFinalTestDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TaskExplorerFinalTestDataElementFactory()
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

               
                
                                      case "F62DB390-173B-42EE-AE1E-6F4A679A2891":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [F62DB390-173B-42EE-AE1E-6F4A679A2891] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [F62DB390-173B-42EE-AE1E-6F4A679A2891](InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MFG_w1_task_id,MFG_w1_task_code,MFG_w1_task_name,MFG_w1_task_type_code,MFG_w1_complexity_code,MFG_w1_requirement_id,MFG_w1_task_status,MFG_w1_is_active,MFG_w1_created_at,MFG_w1_created_by,MFG_w1_updated_by,MFG_w1_updated_at,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,CloseMOdal)  
       VALUES( {3}) END ELSE BEGIN UPDATE [F62DB390-173B-42EE-AE1E-6F4A679A2891]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MFG_w1_task_id,MFG_w1_task_code,MFG_w1_task_name,MFG_w1_task_type_code,MFG_w1_complexity_code,MFG_w1_requirement_id,MFG_w1_task_status,MFG_w1_is_active,MFG_w1_created_at,MFG_w1_created_by,MFG_w1_updated_by,MFG_w1_updated_at,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,CloseMOdal";
                                    
                     
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

                
                 
                                      case "41221100-974C-443A-8CAD-BFA77804C77D":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_41221100974C443A8CADBFA77804C77D AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w1_complexity_code] NVARCHAR(12)	, [MG_w1_created_at] DATETIME	, [MG_w1_task_id] BIGINT	, [MG_w1_task_name] NVARCHAR(12)	, [MG_w1_created_by] BIGINT	, [MG_w1_task_code] NVARCHAR(12)	, [MG_w1_task_status] NVARCHAR(12)	, [MG_w1_updated_by] BIGINT	, [MG_w1_is_active] BIT	, [MG_w1_requirement_id] BIGINT	, [MG_w1_task_type_code] NVARCHAR(12)	, [MG_w1_updated_at] DATETIME){0}INSERT INTO [41221100-974C-443A-8CAD-BFA77804C77D](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_at,MG_w1_task_id,MG_w1_task_name,MG_w1_created_by,MG_w1_task_code,MG_w1_task_status,MG_w1_updated_by,MG_w1_is_active,MG_w1_requirement_id,MG_w1_task_type_code,MG_w1_updated_at)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w1_complexity_code,TDT.MG_w1_created_at,TDT.MG_w1_task_id,TDT.MG_w1_task_name,TDT.MG_w1_created_by,TDT.MG_w1_task_code,TDT.MG_w1_task_status,TDT.MG_w1_updated_by,TDT.MG_w1_is_active,TDT.MG_w1_requirement_id,TDT.MG_w1_task_type_code,TDT.MG_w1_updated_at FROM @TBL_41221100974C443A8CADBFA77804C77D TDT
							LEFT JOIN [41221100-974C-443A-8CAD-BFA77804C77D] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_at,MG_w1_task_id,MG_w1_task_name,MG_w1_created_by,MG_w1_task_code,MG_w1_task_status,MG_w1_updated_by,MG_w1_is_active,MG_w1_requirement_id,MG_w1_task_type_code,MG_w1_updated_at";

                                     tempInsertQuery=@"INSERT INTO @TBL_41221100974C443A8CADBFA77804C77D(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_at,MG_w1_task_id,MG_w1_task_name,MG_w1_created_by,MG_w1_task_code,MG_w1_task_status,MG_w1_updated_by,MG_w1_is_active,MG_w1_requirement_id,MG_w1_task_type_code,MG_w1_updated_at)VALUES({0});";
                                     

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
                     

                                         case "41221100-974C-443A-8CAD-BFA77804C77D":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_41221100974C443A8CADBFA77804C77D AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w1_complexity_code] NVARCHAR(12)	, [MG_w1_created_at] DATETIME	, [MG_w1_task_id] BIGINT	, [MG_w1_task_name] NVARCHAR(12)	, [MG_w1_created_by] BIGINT	, [MG_w1_task_code] NVARCHAR(12)	, [MG_w1_task_status] NVARCHAR(12)	, [MG_w1_updated_by] BIGINT	, [MG_w1_is_active] BIT	, [MG_w1_requirement_id] BIGINT	, [MG_w1_task_type_code] NVARCHAR(12)	, [MG_w1_updated_at] DATETIME){0}INSERT INTO [41221100-974C-443A-8CAD-BFA77804C77D](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_at,MG_w1_task_id,MG_w1_task_name,MG_w1_created_by,MG_w1_task_code,MG_w1_task_status,MG_w1_updated_by,MG_w1_is_active,MG_w1_requirement_id,MG_w1_task_type_code,MG_w1_updated_at)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w1_complexity_code,TDT.MG_w1_created_at,TDT.MG_w1_task_id,TDT.MG_w1_task_name,TDT.MG_w1_created_by,TDT.MG_w1_task_code,TDT.MG_w1_task_status,TDT.MG_w1_updated_by,TDT.MG_w1_is_active,TDT.MG_w1_requirement_id,TDT.MG_w1_task_type_code,TDT.MG_w1_updated_at FROM @TBL_41221100974C443A8CADBFA77804C77D TDT
							LEFT JOIN [41221100-974C-443A-8CAD-BFA77804C77D] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_at,MG_w1_task_id,MG_w1_task_name,MG_w1_created_by,MG_w1_task_code,MG_w1_task_status,MG_w1_updated_by,MG_w1_is_active,MG_w1_requirement_id,MG_w1_task_type_code,MG_w1_updated_at";

                            tempInsertQuery=@"INSERT INTO @TBL_41221100974C443A8CADBFA77804C77D(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w1_complexity_code,MG_w1_created_at,MG_w1_task_id,MG_w1_task_name,MG_w1_created_by,MG_w1_task_code,MG_w1_task_status,MG_w1_updated_by,MG_w1_is_active,MG_w1_requirement_id,MG_w1_task_type_code,MG_w1_updated_at)VALUES({0});";

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
public class ISpace90D42959F9CE4EFD92A1FB387AE4DB9F : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace90D42959F9CE4EFD92A1FB387AE4DB9F acdataIspace90D42959F9CE4EFD92A1FB387AE4DB9F=new AcDataISpace90D42959F9CE4EFD92A1FB387AE4DB9F();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

if(ISpace["FormVersionId"].Value=="2137A87A-E941-4EBB-91BA-18D6676EFE51")
{
iSpace.SetUIControlProperty("290e50fa-a28a-516e-d0e1-4c5f4225d1b4","ShowModal","true",ref  ISpace);;
}

base.WriteDebugInfo(@"
if(ISpace[""FormVersionId""].Value==""2137A87A-E941-4EBB-91BA-18D6676EFE51"")
{
iSpace.SetUIControlProperty(""290e50fa-a28a-516e-d0e1-4c5f4225d1b4"",""ShowModal"",""true"",ref  ISpace);;
}
");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_taskset (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_Taskset-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource99BD5794D71F47F5BA1E3B89F31E1644 =GetQueryExpressionDataSource("99BD5794-D71F-47F5-BA1E-3B89F31E1644");

DataTable result99BD5794D71F47F5BA1E3B89F31E1644=iSpace.SetGridDataSource(querySource99BD5794D71F47F5BA1E3B89F31E1644, _objectFactory.GetGridRPP("Taskset"),@"EXEC [AddFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','41221100-974C-443A-8CAD-BFA77804C77D','" + ISpace["growid"].Value + @"'," + ISpace["Taskset_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"'," + ISpace["MFG_w1_requirement_id"].Value + @",'" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'");

iSpace.InsertGridBindDetails("Taskset","11",querySource99BD5794D71F47F5BA1E3B89F31E1644,"EXEC [AddFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','41221100-974C-443A-8CAD-BFA77804C77D','" + ISpace["growid"].Value + @"'," + ISpace["Taskset_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"'," + ISpace["MFG_w1_requirement_id"].Value + @",'" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'",_objectFactory.GetGridRPP("Taskset"));

base.WriteDebugInfo(@"var querySource99BD5794D71F47F5BA1E3B89F31E1644 =GetQueryExpressionDataSource(""99BD5794-D71F-47F5-BA1E-3B89F31E1644"");DataTable result99BD5794D71F47F5BA1E3B89F31E1644=iSpace.SetGridDataSource(querySource99BD5794D71F47F5BA1E3B89F31E1644, _objectFactory.GetGridRPP(""Taskset""),@""EXEC [AddFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','41221100-974C-443A-8CAD-BFA77804C77D','"" + ISpace[""growid""].Value + @""',"" + ISpace[""Taskset_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""',"" + ISpace[""MFG_w1_requirement_id""].Value + @"",'"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"");iSpace.InsertGridBindDetails(""Taskset"",""11"",querySource99BD5794D71F47F5BA1E3B89F31E1644,""EXEC [AddFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','41221100-974C-443A-8CAD-BFA77804C77D','"" + ISpace[""growid""].Value + @""',"" + ISpace[""Taskset_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""',"" + ISpace[""MFG_w1_requirement_id""].Value + @"",'"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"",_objectFactory.GetGridRPP(""Taskset""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '@@gv_InstanceId','@@gv_ActivityMapId','41221100-974C-443A-8CAD-BFA77804C77D','#growid',#Taskset_Sequence,#MFG_w1_task_id,'#MFG_w1_task_code','#MFG_w1_task_name','#MFG_w1_task_type_code','#MFG_w1_complexity_code',#MFG_w1_requirement_id,'#MFG_w1_task_status',#MFG_w1_is_active,'#MFG_w1_created_at',#MFG_w1_created_by,#MFG_w1_updated_by,'#MFG_w1_updated_at'");


List<Triplet<string, short, short?>> result58A1F496E2C14AA89DC71CB75C20058D=acdataIspace90D42959F9CE4EFD92A1FB387AE4DB9F.GetQueryExpressionBindings("58A1F496-E2C1-4AA8-9DC7-1CB75C20058D");
iSpace.SetGridData(result99BD5794D71F47F5BA1E3B89F31E1644,result58A1F496E2C14AA89DC71CB75C20058D,"Taskset",ref ISpace);
iSpace.UpdateGridBindDetails("Taskset",result58A1F496E2C14AA89DC71CB75C20058D);
}
else
{
base.WriteDebugInfo(@"else");

var querySource07A4CC4B42234887A63B89EDD0F1A4F6 =GetQueryExpressionDataSource("07A4CC4B-4223-4887-A63B-89EDD0F1A4F6");

DataTable result07A4CC4B42234887A63B89EDD0F1A4F6=iSpace.SetGridDataSource(querySource07A4CC4B42234887A63B89EDD0F1A4F6, _objectFactory.GetGridRPP("Taskset"),@"EXEC [UpdateFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','41221100-974C-443A-8CAD-BFA77804C77D','" + ISpace["growid"].Value + @"'," + ISpace["Taskset_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"'," + ISpace["MFG_w1_requirement_id"].Value + @",'" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'");

iSpace.InsertGridBindDetails("Taskset","11",querySource07A4CC4B42234887A63B89EDD0F1A4F6,"EXEC [UpdateFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','41221100-974C-443A-8CAD-BFA77804C77D','" + ISpace["growid"].Value + @"'," + ISpace["Taskset_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"'," + ISpace["MFG_w1_requirement_id"].Value + @",'" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'",_objectFactory.GetGridRPP("Taskset"));

base.WriteDebugInfo(@"var querySource07A4CC4B42234887A63B89EDD0F1A4F6 =GetQueryExpressionDataSource(""07A4CC4B-4223-4887-A63B-89EDD0F1A4F6"");DataTable result07A4CC4B42234887A63B89EDD0F1A4F6=iSpace.SetGridDataSource(querySource07A4CC4B42234887A63B89EDD0F1A4F6, _objectFactory.GetGridRPP(""Taskset""),@""EXEC [UpdateFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','41221100-974C-443A-8CAD-BFA77804C77D','"" + ISpace[""growid""].Value + @""',"" + ISpace[""Taskset_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""',"" + ISpace[""MFG_w1_requirement_id""].Value + @"",'"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"");iSpace.InsertGridBindDetails(""Taskset"",""11"",querySource07A4CC4B42234887A63B89EDD0F1A4F6,""EXEC [UpdateFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','41221100-974C-443A-8CAD-BFA77804C77D','"" + ISpace[""growid""].Value + @""',"" + ISpace[""Taskset_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""',"" + ISpace[""MFG_w1_requirement_id""].Value + @"",'"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"",_objectFactory.GetGridRPP(""Taskset""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '@@gv_InstanceId','@@gv_ActivityMapId','41221100-974C-443A-8CAD-BFA77804C77D','#growid',#Taskset_Sequence,#MFG_w1_task_id,'#MFG_w1_task_code','#MFG_w1_task_name','#MFG_w1_task_type_code','#MFG_w1_complexity_code',#MFG_w1_requirement_id,'#MFG_w1_task_status',#MFG_w1_is_active,'#MFG_w1_created_at',#MFG_w1_created_by,#MFG_w1_updated_by,'#MFG_w1_updated_at'");


List<Triplet<string, short, short?>> result07930F8045FD46D2BDD4B64E85B30CAB=acdataIspace90D42959F9CE4EFD92A1FB387AE4DB9F.GetQueryExpressionBindings("07930F80-45FD-46D2-BDD4-B64E85B30CAB");
iSpace.SetGridData(result07A4CC4B42234887A63B89EDD0F1A4F6,result07930F8045FD46D2BDD4B64E85B30CAB,"Taskset",ref ISpace);
iSpace.UpdateGridBindDetails("Taskset",result07930F8045FD46D2BDD4B64E85B30CAB);
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
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_326f2ae9-a901-4f09-a24f-975c3089ab28] ");

var querySourceB2D4C3FFEE00489883CCEA6F40BB2F1F =GetQueryExpressionDataSource("B2D4C3FF-EE00-4898-83CC-EA6F40BB2F1F");
Dictionary<short,object> resultB2D4C3FFEE00489883CCEA6F40BB2F1F=iSpace.ExecuteQuery(querySourceB2D4C3FFEE00489883CCEA6F40BB2F1F,@"EXEC InnovaceNoCode..[FormSave_326f2ae9-a901-4f09-a24f-975c3089ab28] ",false);

base.WriteDebugInfo(@"var querySourceB2D4C3FFEE00489883CCEA6F40BB2F1F =GetQueryExpressionDataSource(""B2D4C3FF-EE00-4898-83CC-EA6F40BB2F1F"");Dictionary<short,object> resultB2D4C3FFEE00489883CCEA6F40BB2F1F=iSpace.ExecuteQuery(querySourceB2D4C3FFEE00489883CCEA6F40BB2F1F,@""EXEC InnovaceNoCode..[FormSave_326f2ae9-a901-4f09-a24f-975c3089ab28] "",false);");
base.WriteDebugInfo(@"");

if((resultB2D4C3FFEE00489883CCEA6F40BB2F1F!=null) && (resultB2D4C3FFEE00489883CCEA6F40BB2F1F.Count!=0))
{
if(resultB2D4C3FFEE00489883CCEA6F40BB2F1F.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultB2D4C3FFEE00489883CCEA6F40BB2F1F[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_41221100-974C-443A-8CAD-BFA77804C77D]   '@@gv_InstanceId','@@gv_ActivityMapId','41221100-974C-443A-8CAD-BFA77804C77D'");

var querySource832C2E3C464F4DB08EF24565C89A1704 =GetQueryExpressionDataSource("832C2E3C-464F-4DB0-8EF2-4565C89A1704");
Dictionary<short,object> result832C2E3C464F4DB08EF24565C89A1704=iSpace.ExecuteQuery(querySource832C2E3C464F4DB08EF24565C89A1704,@"EXEC InnovaceNoCode..[GridSave_41221100-974C-443A-8CAD-BFA77804C77D]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','41221100-974C-443A-8CAD-BFA77804C77D'",false);

base.WriteDebugInfo(@"var querySource832C2E3C464F4DB08EF24565C89A1704 =GetQueryExpressionDataSource(""832C2E3C-464F-4DB0-8EF2-4565C89A1704"");Dictionary<short,object> result832C2E3C464F4DB08EF24565C89A1704=iSpace.ExecuteQuery(querySource832C2E3C464F4DB08EF24565C89A1704,@""EXEC InnovaceNoCode..[GridSave_41221100-974C-443A-8CAD-BFA77804C77D]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','41221100-974C-443A-8CAD-BFA77804C77D'"",false);");
base.WriteDebugInfo(@"");

if((result832C2E3C464F4DB08EF24565C89A1704!=null) && (result832C2E3C464F4DB08EF24565C89A1704.Count!=0))
{
if(result832C2E3C464F4DB08EF24565C89A1704.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result832C2E3C464F4DB08EF24565C89A1704[0];
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
private void SubscribeElementEvents_edit_taskset (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_Taskset-OnClick");
ISpace["growid"].Value=ISpace["Taskset_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""Taskset_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '@@gv_InstanceId','@@gv_ActivityMapId','41221100-974C-443A-8CAD-BFA77804C77D','#growid',#Taskset_Sequence");

var querySourceDF207FF81EE948DFB90E0F787E63CEFB =GetQueryExpressionDataSource("DF207FF8-1EE9-48DF-B90E-0F787E63CEFB");
Dictionary<short,object> resultDF207FF81EE948DFB90E0F787E63CEFB=iSpace.ExecuteQuery(querySourceDF207FF81EE948DFB90E0F787E63CEFB,@"EXEC [LoadFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','41221100-974C-443A-8CAD-BFA77804C77D','" + ISpace["growid"].Value + @"'," + ISpace["Taskset_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySourceDF207FF81EE948DFB90E0F787E63CEFB =GetQueryExpressionDataSource(""DF207FF8-1EE9-48DF-B90E-0F787E63CEFB"");Dictionary<short,object> resultDF207FF81EE948DFB90E0F787E63CEFB=iSpace.ExecuteQuery(querySourceDF207FF81EE948DFB90E0F787E63CEFB,@""EXEC [LoadFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','41221100-974C-443A-8CAD-BFA77804C77D','"" + ISpace[""growid""].Value + @""',"" + ISpace[""Taskset_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData41221100-974C-443A-8CAD-BFA77804C77D] '@@gv_InstanceId','@@gv_ActivityMapId','41221100-974C-443A-8CAD-BFA77804C77D','#growid',#Taskset_Sequence");

if((resultDF207FF81EE948DFB90E0F787E63CEFB!=null) && (resultDF207FF81EE948DFB90E0F787E63CEFB.Count!=0))
{
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(8))
ISpace["MFG_w1_created_at"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[8];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(11))
ISpace["MFG_w1_updated_at"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[11];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(7))
ISpace["MFG_w1_is_active"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[7];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(0))
ISpace["MFG_w1_task_id"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[0];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(10))
ISpace["MFG_w1_updated_by"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[10];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(9))
ISpace["MFG_w1_created_by"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[9];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(5))
ISpace["MFG_w1_requirement_id"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[5];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(3))
ISpace["MFG_w1_task_type_code"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[3];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(1))
ISpace["MFG_w1_task_code"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[1];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(4))
ISpace["MFG_w1_complexity_code"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[4];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(2))
ISpace["MFG_w1_task_name"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[2];
if(resultDF207FF81EE948DFB90E0F787E63CEFB.ContainsKey(6))
ISpace["MFG_w1_task_status"].Value = resultDF207FF81EE948DFB90E0F787E63CEFB[6];
}
else{
ISpace["MFG_w1_created_at"].Value = null;ISpace["MFG_w1_updated_at"].Value = null;ISpace["MFG_w1_is_active"].Value = null;ISpace["MFG_w1_task_id"].Value = null;ISpace["MFG_w1_updated_by"].Value = null;ISpace["MFG_w1_created_by"].Value = null;ISpace["MFG_w1_requirement_id"].Value = null;ISpace["MFG_w1_task_type_code"].Value = null;ISpace["MFG_w1_task_code"].Value = null;ISpace["MFG_w1_complexity_code"].Value = null;ISpace["MFG_w1_task_name"].Value = null;ISpace["MFG_w1_task_status"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_openmodal (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"OpenModal-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

if(ISpace["FormVersionId"].Value=="2137A87A-E941-4EBB-91BA-18D6676EFE51")
{
iSpace.SetUIControlProperty("290e50fa-a28a-516e-d0e1-4c5f4225d1b4","ShowModal","true",ref  ISpace);;
}

base.WriteDebugInfo(@"
if(ISpace[""FormVersionId""].Value==""2137A87A-E941-4EBB-91BA-18D6676EFE51"")
{
iSpace.SetUIControlProperty(""290e50fa-a28a-516e-d0e1-4c5f4225d1b4"",""ShowModal"",""true"",ref  ISpace);;
}
");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_closemodal (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"CloseMOdal-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

if(ISpace["FormVersionId"].Value=="2137A87A-E941-4EBB-91BA-18D6676EFE51")
{
iSpace.SetUIControlProperty("290e50fa-a28a-516e-d0e1-4c5f4225d1b4","ShowModal","false",ref  ISpace);;
}

base.WriteDebugInfo(@"
if(ISpace[""FormVersionId""].Value==""2137A87A-E941-4EBB-91BA-18D6676EFE51"")
{
iSpace.SetUIControlProperty(""290e50fa-a28a-516e-d0e1-4c5f4225d1b4"",""ShowModal"",""false"",ref  ISpace);;
}
");
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
		if(elementName.ToLower().Equals("closemodal"))
    {
    			SubscribeElementEvents_closemodal(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("save_taskset"))
{
			SubscribeElementEvents_save_taskset(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_taskset"))
{
			SubscribeElementEvents_edit_taskset(ref dfsParam);
}
		if(elementName.ToLower().Equals("openmodal"))
{
			SubscribeElementEvents_openmodal(ref dfsParam);
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


	public partial class AcDataISpace90D42959F9CE4EFD92A1FB387AE4DB9F  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"07930F80-45FD-46D2-BDD4-B64E85B30CAB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_requirement_id",5,
														   -1),
								   new Triplet<string, short, short?>("Taskset_RowId",12,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_is_active",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_by",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_by",10,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_at",11,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_complexity_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",6,
														   -1),
								}
			},
							{"58A1F496-E2C1-4AA8-9DC7-1CB75C20058D", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_requirement_id",5,
														   -1),
								   new Triplet<string, short, short?>("Taskset_RowId",12,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_by",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_by",10,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_complexity_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_at",11,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_is_active",7,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"2137A87A-E941-4EBB-91BA-18D6676EFE51", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5AEFA1B1-63E8-4B73-9BAF-6845507A902D", ""},
							{"560871CD-66F8-49C7-BE4B-63F4E6D6AC5E", ""},
							{"2137A87A-E941-4EBB-91BA-18D6676EFE51", ""},
							{"A74E176C-07F2-4935-91B0-794554D478F0", ""},
							{"892CF7CD-C015-4CB5-9AED-C605221C3E08", ""},
							{"C0968930-8261-4738-9359-2000AD2CE634", ""},
							{"D0B92CC9-D399-4385-A9A6-6403F51B1620", ""},
							{"FEC2EA3C-61BA-4848-BEEB-5DFC68B8AA3E", ""},
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
		


