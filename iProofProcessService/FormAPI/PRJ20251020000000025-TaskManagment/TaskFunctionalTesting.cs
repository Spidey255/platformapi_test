  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TaskFunctionalTestingProcessMetadata : ExtensionProcessBase
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
            get { return "74bf8517-74c6-4b98-970f-0ad595b13f64"; }
        }

        public override string ProcessName
        {
            get { return "TaskFunctionalTesting"; }
        }

		public override string ProcessDescription
        {
            get { return "Task Functional Testing"; }
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
            get {return "74bf8517-74c6-4b98-970f-0ad595b13f64";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "307BB34C-1AB3-4570-822B-7AC26935CDAF";	}
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
	

	public partial class TaskFunctionalTestingObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TaskFunctionalTestingProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("777a386c-d068-363d-b716-3d024e037932","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("CF5AEFC3-207B-4AA3-B1C5-0E2BB0F80F7B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("7375EB40-CA31-4FD7-8E4B-DDB3DA7376E7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"38C753DC-ED33-454B-85AF-DD4DF536B530"),
			
						
			     new Triplet<string, string, string>("1398AE27-CF1C-4C8F-9483-2198EB83EBF8","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("282460BA-480A-4F52-9217-43BC39FDB8CF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("777a386c-d068-363d-b716-3d024e037932","Load Existing Task Details",
												     @"5C0FC3F3-C652-466E-931C-2F3797DB6328"),
			
						
			     new Triplet<string, string, string>("1398AE27-CF1C-4C8F-9483-2198EB83EBF8","Grid Binding5",
												     @"5C0FC3F3-C652-466E-931C-2F3797DB6328"),
			
						
			     new Triplet<string, string, string>("282460BA-480A-4F52-9217-43BC39FDB8CF","Grid Binding1",
												     @"5C0FC3F3-C652-466E-931C-2F3797DB6328"),
			
			
			
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
		
	  			
			     new Tuple<string, int>("TaskDetails",5),
			
						
			     new Tuple<string, int>("TaskDetails",5),
			
						
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
											case "91001EA5-B506-4228-8107-E8201462FFC1":
							virtualInstance=new ISpace91001EA5B50642288107E8201462FFC1();
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
	

	public partial class TaskFunctionalTestingDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TaskFunctionalTestingDataElementFactory()
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

               
                
                                      case "307BB34C-1AB3-4570-822B-7AC26935CDAF":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [307BB34C-1AB3-4570-822B-7AC26935CDAF] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [307BB34C-1AB3-4570-822B-7AC26935CDAF](InstanceId,ProcessActivityMapId,FormId,M_Total,M_Active,M_InActive,M_Closed,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MFG_w1_task_id,MFG_w1_task_code,MFG_w1_task_name,MFG_w1_task_type_code,MFG_w1_complexity_code,MFG_w1_requirement_id,MFG_w1_task_status,MFG_w1_is_active,MFG_w1_created_at,MFG_w1_created_by,MFG_w1_updated_by,MFG_w1_updated_at,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid)  
       VALUES( {3}) END ELSE BEGIN UPDATE [307BB34C-1AB3-4570-822B-7AC26935CDAF]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,M_Total,M_Active,M_InActive,M_Closed,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MFG_w1_task_id,MFG_w1_task_code,MFG_w1_task_name,MFG_w1_task_type_code,MFG_w1_complexity_code,MFG_w1_requirement_id,MFG_w1_task_status,MFG_w1_is_active,MFG_w1_created_at,MFG_w1_created_by,MFG_w1_updated_by,MFG_w1_updated_at,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid";
                                    
                     
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

                
                 
                                      case "5C0FC3F3-C652-466E-931C-2F3797DB6328":
                    {
                     
                                     gInsertQuery=@"";

                                     colList=@"";

                                     tempInsertQuery=@"INSERT INTO @TBL_5C0FC3F3C652466E931C2F3797DB6328()VALUES({0});";
                                     

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
                     

                                         case "5C0FC3F3-C652-466E-931C-2F3797DB6328":
                    {
                     
                            gInsertQuery=@"";

                            colList=@"";

                            tempInsertQuery=@"INSERT INTO @TBL_5C0FC3F3C652466E931C2F3797DB6328()VALUES({0});";

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
public class ISpace91001EA5B50642288107E8201462FFC1 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace91001EA5B50642288107E8201462FFC1 acdataIspace91001EA5B50642288107E8201462FFC1=new AcDataISpace91001EA5B50642288107E8201462FFC1();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
Dictionary<short, object> keyValuePairs = null;base.WriteDebugInfo(@"Root-OnAfterFormLoad");

var querySource777a386cd068363db7163d024e037932 =GetQueryExpressionDataSource("777a386c-d068-363d-b716-3d024e037932");

DataTable result777a386cd068363db7163d024e037932=iSpace.SetGridDataSource(querySource777a386cd068363db7163d024e037932, _objectFactory.GetGridRPP("TaskDetails"),@"EXEC TasKDetails ''");

iSpace.InsertGridBindDetails("TaskDetails","11",querySource777a386cd068363db7163d024e037932,"EXEC TasKDetails ''",_objectFactory.GetGridRPP("TaskDetails"));

base.WriteDebugInfo(@"var querySource777a386cd068363db7163d024e037932 =GetQueryExpressionDataSource(""777a386c-d068-363d-b716-3d024e037932"");DataTable result777a386cd068363db7163d024e037932=iSpace.SetGridDataSource(querySource777a386cd068363db7163d024e037932, _objectFactory.GetGridRPP(""TaskDetails""),@""EXEC TasKDetails ''"");iSpace.InsertGridBindDetails(""TaskDetails"",""11"",querySource777a386cd068363db7163d024e037932,""EXEC TasKDetails ''"",_objectFactory.GetGridRPP(""TaskDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultd42533195ef63c1c187132348108d90a=acdataIspace91001EA5B50642288107E8201462FFC1.GetQueryExpressionBindings("d4253319-5ef6-3c1c-1871-32348108d90a");
iSpace.SetGridData(result777a386cd068363db7163d024e037932,resultd42533195ef63c1c187132348108d90a,"TaskDetails",ref ISpace);
iSpace.UpdateGridBindDetails("TaskDetails",resultd42533195ef63c1c187132348108d90a);
Dictionary<short, object> keyValuePairs = null;base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetTaskSummary");

var querySource7375EB40CA314FD78E4BDDB3DA7376E7 =GetQueryExpressionDataSource("7375EB40-CA31-4FD7-8E4B-DDB3DA7376E7");
Dictionary<short,object> result7375EB40CA314FD78E4BDDB3DA7376E7=iSpace.ExecuteQuery(querySource7375EB40CA314FD78E4BDDB3DA7376E7,@"EXEC GetTaskSummary",false);

base.WriteDebugInfo(@"var querySource7375EB40CA314FD78E4BDDB3DA7376E7 =GetQueryExpressionDataSource(""7375EB40-CA31-4FD7-8E4B-DDB3DA7376E7"");Dictionary<short,object> result7375EB40CA314FD78E4BDDB3DA7376E7=iSpace.ExecuteQuery(querySource7375EB40CA314FD78E4BDDB3DA7376E7,@""EXEC GetTaskSummary"",false);");
base.WriteDebugInfo(@"");

if((result7375EB40CA314FD78E4BDDB3DA7376E7!=null) && (result7375EB40CA314FD78E4BDDB3DA7376E7.Count!=0))
{
if(result7375EB40CA314FD78E4BDDB3DA7376E7.ContainsKey(3))
ISpace["M_Closed"].Value = result7375EB40CA314FD78E4BDDB3DA7376E7[3];
if(result7375EB40CA314FD78E4BDDB3DA7376E7.ContainsKey(1))
ISpace["M_Active"].Value = result7375EB40CA314FD78E4BDDB3DA7376E7[1];
if(result7375EB40CA314FD78E4BDDB3DA7376E7.ContainsKey(2))
ISpace["M_InActive"].Value = result7375EB40CA314FD78E4BDDB3DA7376E7[2];
if(result7375EB40CA314FD78E4BDDB3DA7376E7.ContainsKey(0))
ISpace["M_Total"].Value = result7375EB40CA314FD78E4BDDB3DA7376E7[0];
}
else{
ISpace["M_Closed"].Value = null;ISpace["M_Active"].Value = null;ISpace["M_InActive"].Value = null;ISpace["M_Total"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_taskdetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TaskDetails-OnClick");
ISpace["growid"].Value=ISpace["TaskDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TaskDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '@@gv_InstanceId','@@gv_ActivityMapId','5C0FC3F3-C652-466E-931C-2F3797DB6328','#growid',#TaskDetails_Sequence");

var querySourceCF5AEFC3207B4AA3B1C50E2BB0F80F7B =GetQueryExpressionDataSource("CF5AEFC3-207B-4AA3-B1C5-0E2BB0F80F7B");
Dictionary<short,object> resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B=iSpace.ExecuteQuery(querySourceCF5AEFC3207B4AA3B1C50E2BB0F80F7B,@"EXEC [LoadFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','5C0FC3F3-C652-466E-931C-2F3797DB6328','" + ISpace["growid"].Value + @"'," + ISpace["TaskDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySourceCF5AEFC3207B4AA3B1C50E2BB0F80F7B =GetQueryExpressionDataSource(""CF5AEFC3-207B-4AA3-B1C5-0E2BB0F80F7B"");Dictionary<short,object> resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B=iSpace.ExecuteQuery(querySourceCF5AEFC3207B4AA3B1C50E2BB0F80F7B,@""EXEC [LoadFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','5C0FC3F3-C652-466E-931C-2F3797DB6328','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '@@gv_InstanceId','@@gv_ActivityMapId','5C0FC3F3-C652-466E-931C-2F3797DB6328','#growid',#TaskDetails_Sequence");

if((resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B!=null) && (resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.Count!=0))
{
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(8))
ISpace["MFG_w1_created_at"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[8];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(11))
ISpace["MFG_w1_updated_at"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[11];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(7))
ISpace["MFG_w1_is_active"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[7];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(9))
ISpace["MFG_w1_created_by"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[9];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(10))
ISpace["MFG_w1_updated_by"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[10];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(0))
ISpace["MFG_w1_task_id"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[0];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(5))
ISpace["MFG_w1_requirement_id"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[5];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(4))
ISpace["MFG_w1_complexity_code"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[4];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(2))
ISpace["MFG_w1_task_name"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[2];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(3))
ISpace["MFG_w1_task_type_code"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[3];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(6))
ISpace["MFG_w1_task_status"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[6];
if(resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B.ContainsKey(1))
ISpace["MFG_w1_task_code"].Value = resultCF5AEFC3207B4AA3B1C50E2BB0F80F7B[1];
}
else{
ISpace["MFG_w1_created_at"].Value = null;ISpace["MFG_w1_updated_at"].Value = null;ISpace["MFG_w1_is_active"].Value = null;ISpace["MFG_w1_created_by"].Value = null;ISpace["MFG_w1_updated_by"].Value = null;ISpace["MFG_w1_task_id"].Value = null;ISpace["MFG_w1_requirement_id"].Value = null;ISpace["MFG_w1_complexity_code"].Value = null;ISpace["MFG_w1_task_name"].Value = null;ISpace["MFG_w1_task_type_code"].Value = null;ISpace["MFG_w1_task_status"].Value = null;ISpace["MFG_w1_task_code"].Value = null;
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
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_74bf8517-74c6-4b98-970f-0ad595b13f64] ");

var querySource41D81356A0B744EAB0C91A8888B43F01 =GetQueryExpressionDataSource("41D81356-A0B7-44EA-B0C9-1A8888B43F01");
Dictionary<short,object> result41D81356A0B744EAB0C91A8888B43F01=iSpace.ExecuteQuery(querySource41D81356A0B744EAB0C91A8888B43F01,@"EXEC InnovaceNoCode..[FormSave_74bf8517-74c6-4b98-970f-0ad595b13f64] ",false);

base.WriteDebugInfo(@"var querySource41D81356A0B744EAB0C91A8888B43F01 =GetQueryExpressionDataSource(""41D81356-A0B7-44EA-B0C9-1A8888B43F01"");Dictionary<short,object> result41D81356A0B744EAB0C91A8888B43F01=iSpace.ExecuteQuery(querySource41D81356A0B744EAB0C91A8888B43F01,@""EXEC InnovaceNoCode..[FormSave_74bf8517-74c6-4b98-970f-0ad595b13f64] "",false);");
base.WriteDebugInfo(@"");

if((result41D81356A0B744EAB0C91A8888B43F01!=null) && (result41D81356A0B744EAB0C91A8888B43F01.Count!=0))
{
if(result41D81356A0B744EAB0C91A8888B43F01.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result41D81356A0B744EAB0C91A8888B43F01[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_5C0FC3F3-C652-466E-931C-2F3797DB6328]   '@@gv_InstanceId','@@gv_ActivityMapId','5C0FC3F3-C652-466E-931C-2F3797DB6328'");

var querySource1901A8645FD24B54B3E08E1FDC50DC14 =GetQueryExpressionDataSource("1901A864-5FD2-4B54-B3E0-8E1FDC50DC14");
Dictionary<short,object> result1901A8645FD24B54B3E08E1FDC50DC14=iSpace.ExecuteQuery(querySource1901A8645FD24B54B3E08E1FDC50DC14,@"EXEC InnovaceNoCode..[GridSave_5C0FC3F3-C652-466E-931C-2F3797DB6328]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','5C0FC3F3-C652-466E-931C-2F3797DB6328'",false);

base.WriteDebugInfo(@"var querySource1901A8645FD24B54B3E08E1FDC50DC14 =GetQueryExpressionDataSource(""1901A864-5FD2-4B54-B3E0-8E1FDC50DC14"");Dictionary<short,object> result1901A8645FD24B54B3E08E1FDC50DC14=iSpace.ExecuteQuery(querySource1901A8645FD24B54B3E08E1FDC50DC14,@""EXEC InnovaceNoCode..[GridSave_5C0FC3F3-C652-466E-931C-2F3797DB6328]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','5C0FC3F3-C652-466E-931C-2F3797DB6328'"",false);");
base.WriteDebugInfo(@"");

if((result1901A8645FD24B54B3E08E1FDC50DC14!=null) && (result1901A8645FD24B54B3E08E1FDC50DC14.Count!=0))
{
if(result1901A8645FD24B54B3E08E1FDC50DC14.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result1901A8645FD24B54B3E08E1FDC50DC14[0];
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
private void SubscribeElementEvents_save_taskdetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_TaskDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource282460BA480A4F52921743BC39FDB8CF =GetQueryExpressionDataSource("282460BA-480A-4F52-9217-43BC39FDB8CF");

DataTable result282460BA480A4F52921743BC39FDB8CF=iSpace.SetGridDataSource(querySource282460BA480A4F52921743BC39FDB8CF, _objectFactory.GetGridRPP("TaskDetails"),@"EXEC [AddFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','5C0FC3F3-C652-466E-931C-2F3797DB6328','" + ISpace["growid"].Value + @"'," + ISpace["TaskDetails_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"','" + ISpace["MFG_w1_requirement_id"].Value + @"','" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'");

iSpace.InsertGridBindDetails("TaskDetails","11",querySource282460BA480A4F52921743BC39FDB8CF,"EXEC [AddFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','5C0FC3F3-C652-466E-931C-2F3797DB6328','" + ISpace["growid"].Value + @"'," + ISpace["TaskDetails_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"','" + ISpace["MFG_w1_requirement_id"].Value + @"','" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'",_objectFactory.GetGridRPP("TaskDetails"));

base.WriteDebugInfo(@"var querySource282460BA480A4F52921743BC39FDB8CF =GetQueryExpressionDataSource(""282460BA-480A-4F52-9217-43BC39FDB8CF"");DataTable result282460BA480A4F52921743BC39FDB8CF=iSpace.SetGridDataSource(querySource282460BA480A4F52921743BC39FDB8CF, _objectFactory.GetGridRPP(""TaskDetails""),@""EXEC [AddFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','5C0FC3F3-C652-466E-931C-2F3797DB6328','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskDetails_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""','"" + ISpace[""MFG_w1_requirement_id""].Value + @""','"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskDetails"",""11"",querySource282460BA480A4F52921743BC39FDB8CF,""EXEC [AddFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','5C0FC3F3-C652-466E-931C-2F3797DB6328','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskDetails_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""','"" + ISpace[""MFG_w1_requirement_id""].Value + @""','"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"",_objectFactory.GetGridRPP(""TaskDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '@@gv_InstanceId','@@gv_ActivityMapId','5C0FC3F3-C652-466E-931C-2F3797DB6328','#growid',#TaskDetails_Sequence,#MFG_w1_task_id,'#MFG_w1_task_code','#MFG_w1_task_name','#MFG_w1_task_type_code','#MFG_w1_complexity_code','#MFG_w1_requirement_id','#MFG_w1_task_status',#MFG_w1_is_active,'#MFG_w1_created_at',#MFG_w1_created_by,#MFG_w1_updated_by,'#MFG_w1_updated_at'");


List<Triplet<string, short, short?>> resultA53E448780174E6BB1FAE6C684BE15B3=acdataIspace91001EA5B50642288107E8201462FFC1.GetQueryExpressionBindings("A53E4487-8017-4E6B-B1FA-E6C684BE15B3");
iSpace.SetGridData(result282460BA480A4F52921743BC39FDB8CF,resultA53E448780174E6BB1FAE6C684BE15B3,"TaskDetails",ref ISpace);
iSpace.UpdateGridBindDetails("TaskDetails",resultA53E448780174E6BB1FAE6C684BE15B3);
}
else
{
base.WriteDebugInfo(@"else");

var querySource1398AE27CF1C4C8F94832198EB83EBF8 =GetQueryExpressionDataSource("1398AE27-CF1C-4C8F-9483-2198EB83EBF8");

DataTable result1398AE27CF1C4C8F94832198EB83EBF8=iSpace.SetGridDataSource(querySource1398AE27CF1C4C8F94832198EB83EBF8, _objectFactory.GetGridRPP("TaskDetails"),@"EXEC [UpdateFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','5C0FC3F3-C652-466E-931C-2F3797DB6328','" + ISpace["growid"].Value + @"'," + ISpace["TaskDetails_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"','" + ISpace["MFG_w1_requirement_id"].Value + @"','" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'");

iSpace.InsertGridBindDetails("TaskDetails","11",querySource1398AE27CF1C4C8F94832198EB83EBF8,"EXEC [UpdateFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','5C0FC3F3-C652-466E-931C-2F3797DB6328','" + ISpace["growid"].Value + @"'," + ISpace["TaskDetails_Sequence"].Value + @"," + ISpace["MFG_w1_task_id"].Value + @",'" + ISpace["MFG_w1_task_code"].Value + @"','" + ISpace["MFG_w1_task_name"].Value + @"','" + ISpace["MFG_w1_task_type_code"].Value + @"','" + ISpace["MFG_w1_complexity_code"].Value + @"','" + ISpace["MFG_w1_requirement_id"].Value + @"','" + ISpace["MFG_w1_task_status"].Value + @"'," + ISpace["MFG_w1_is_active"].Value + @",'" + ISpace["MFG_w1_created_at"].Value + @"'," + ISpace["MFG_w1_created_by"].Value + @"," + ISpace["MFG_w1_updated_by"].Value + @",'" + ISpace["MFG_w1_updated_at"].Value + @"'",_objectFactory.GetGridRPP("TaskDetails"));

base.WriteDebugInfo(@"var querySource1398AE27CF1C4C8F94832198EB83EBF8 =GetQueryExpressionDataSource(""1398AE27-CF1C-4C8F-9483-2198EB83EBF8"");DataTable result1398AE27CF1C4C8F94832198EB83EBF8=iSpace.SetGridDataSource(querySource1398AE27CF1C4C8F94832198EB83EBF8, _objectFactory.GetGridRPP(""TaskDetails""),@""EXEC [UpdateFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','5C0FC3F3-C652-466E-931C-2F3797DB6328','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskDetails_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""','"" + ISpace[""MFG_w1_requirement_id""].Value + @""','"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"");iSpace.InsertGridBindDetails(""TaskDetails"",""11"",querySource1398AE27CF1C4C8F94832198EB83EBF8,""EXEC [UpdateFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','5C0FC3F3-C652-466E-931C-2F3797DB6328','"" + ISpace[""growid""].Value + @""',"" + ISpace[""TaskDetails_Sequence""].Value + @"","" + ISpace[""MFG_w1_task_id""].Value + @"",'"" + ISpace[""MFG_w1_task_code""].Value + @""','"" + ISpace[""MFG_w1_task_name""].Value + @""','"" + ISpace[""MFG_w1_task_type_code""].Value + @""','"" + ISpace[""MFG_w1_complexity_code""].Value + @""','"" + ISpace[""MFG_w1_requirement_id""].Value + @""','"" + ISpace[""MFG_w1_task_status""].Value + @""',"" + ISpace[""MFG_w1_is_active""].Value + @"",'"" + ISpace[""MFG_w1_created_at""].Value + @""',"" + ISpace[""MFG_w1_created_by""].Value + @"","" + ISpace[""MFG_w1_updated_by""].Value + @"",'"" + ISpace[""MFG_w1_updated_at""].Value + @""'"",_objectFactory.GetGridRPP(""TaskDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData5C0FC3F3-C652-466E-931C-2F3797DB6328] '@@gv_InstanceId','@@gv_ActivityMapId','5C0FC3F3-C652-466E-931C-2F3797DB6328','#growid',#TaskDetails_Sequence,#MFG_w1_task_id,'#MFG_w1_task_code','#MFG_w1_task_name','#MFG_w1_task_type_code','#MFG_w1_complexity_code','#MFG_w1_requirement_id','#MFG_w1_task_status',#MFG_w1_is_active,'#MFG_w1_created_at',#MFG_w1_created_by,#MFG_w1_updated_by,'#MFG_w1_updated_at'");


List<Triplet<string, short, short?>> resultC141ED0B2E8E4FCA8110B438F9321016=acdataIspace91001EA5B50642288107E8201462FFC1.GetQueryExpressionBindings("C141ED0B-2E8E-4FCA-8110-B438F9321016");
iSpace.SetGridData(result1398AE27CF1C4C8F94832198EB83EBF8,resultC141ED0B2E8E4FCA8110B438F9321016,"TaskDetails",ref ISpace);
iSpace.UpdateGridBindDetails("TaskDetails",resultC141ED0B2E8E4FCA8110B438F9321016);
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
		if(elementName.ToLower().Equals("edit_taskdetails"))
{
			SubscribeElementEvents_edit_taskdetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_add"))
{
			SubscribeElementEvents_m_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_taskdetails"))
{
			SubscribeElementEvents_save_taskdetails(ref dfsParam);
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


	public partial class AcDataISpace91001EA5B50642288107E8201462FFC1  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"d4253319-5ef6-3c1c-1871-32348108d90a", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_task_status",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_requirement_id",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_complexity_code",6,
														   -1),
								}
			},
							{"A53E4487-8017-4E6B-B1FA-E6C684BE15B3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_updated_at",11,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_complexity_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_by",10,
														   -1),
								   new Triplet<string, short, short?>("TaskDetails_RowId",12,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_is_active",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_by",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_requirement_id",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",6,
														   -1),
								}
			},
							{"C141ED0B-2E8E-4FCA-8110-B438F9321016", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_w1_task_id",0,
														   -1),
								   new Triplet<string, short, short?>("TaskDetails_RowId",12,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_complexity_code",4,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_name",2,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_at",11,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_code",1,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_by",9,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_type_code",3,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_task_status",6,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_created_at",8,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_requirement_id",5,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_is_active",7,
														   -1),
								   new Triplet<string, short, short?>("MG_w1_updated_by",10,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"83113455-59DD-4B51-8DAF-4A63ACF917A3", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"82DF5FEA-A716-4EA1-AB96-AD46920D6C15", ""},
							{"CD65F26D-5976-4422-BADD-7A721DADFA40", ""},
							{"83113455-59DD-4B51-8DAF-4A63ACF917A3", ""},
							{"BA6E94FD-5777-44FB-A008-25EED2F4B720", ""},
							{"C1832F00-D17B-4EE8-8897-69C3A9C3CDCB", ""},
							{"8D3522D9-A778-4CCC-9E5B-4F8B8ED1BD86", ""},
							{"BEFC8E24-B83E-4B8F-A06C-CDF749E4CFBB", ""},
							{"C16BF51E-9D0C-43B6-970F-0852237188D6", ""},
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
		


