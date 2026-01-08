  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class AssetVerificationProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 20126; }
        }

        public override string PackageName
        {
            get { return "testGrid"; }
        }

		public override string PackageDescription
        {
            get { return "for testing purpose"; }
        }

        public override string ProcessId
        {
            get { return "B0EDBC7F-E6F9-4F68-92D1-C2D70DA0933A"; }
        }

        public override string ProcessName
        {
            get { return "AssetVerification"; }
        }

		public override string ProcessDescription
        {
            get { return "Asset Verification Smart UI Latest"; }
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
            get {return "B0EDBC7F-E6F9-4F68-92D1-C2D70DA0933A";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "97FE9653-E760-4DDE-B22E-5247CBB725F3";	}
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
	

	public partial class AssetVerificationObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new AssetVerificationProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("30FF4DF1-4F20-46D7-A96C-168BAF2E20AC","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("41121bd1-6404-a61b-433c-376ab8a46061","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("E8E68574-E8CA-4C9A-9702-20EB321C093B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("30FF4DF1-4F20-46D7-A96C-168BAF2E20AC","Grid Binding",
												     @"2DA46861-844C-4840-8ACA-977A3F92D54A"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_AssetList_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77q8ayfct700fBGWxfJ+CkJHiYHXFtC2NZEpOV50VmuGqOsCv58i39pQ==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
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
		
	  			
			     new Tuple<string, int>("AssetList",5),
			
						
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
											case "6B5E748F-516A-4136-8016-3464FB30137D":
							virtualInstance=new ISpace6B5E748F516A413680163464FB30137D();
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
	

	public partial class AssetVerificationDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public AssetVerificationDataElementFactory()
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

               
                
                                      case "97FE9653-E760-4DDE-B22E-5247CBB725F3":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [97FE9653-E760-4DDE-B22E-5247CBB725F3] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [97FE9653-E760-4DDE-B22E-5247CBB725F3](InstanceId,ProcessActivityMapId,FormId,MF_AssetList_GridRows,MF_AssetList_RecordsRange,MF_AssetList_PageIndex,MF_AssetList_TotalPages,MF_AssetList_SelectAll,MF_A1_AssetId,MF_A1_AssetTagId,MF_A1_AssetName,MF_A1_SupplierName,MF_A1_PONumber,MF_A1_AssetValue,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_A1_AssetStatus,MF_A1_Status,F_AssetName,F_SupplierName,MF_SelectedIDs,MF_UnSelectedIDs,MF_IsContain,MF_Option,M_TotalAssets,M_VerifiedAssets,M_UnverifiedAssets)  
       VALUES( {3}) END ELSE BEGIN UPDATE [97FE9653-E760-4DDE-B22E-5247CBB725F3]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,MF_AssetList_GridRows,MF_AssetList_RecordsRange,MF_AssetList_PageIndex,MF_AssetList_TotalPages,MF_AssetList_SelectAll,MF_A1_AssetId,MF_A1_AssetTagId,MF_A1_AssetName,MF_A1_SupplierName,MF_A1_PONumber,MF_A1_AssetValue,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_A1_AssetStatus,MF_A1_Status,F_AssetName,F_SupplierName,MF_SelectedIDs,MF_UnSelectedIDs,MF_IsContain,MF_Option,M_TotalAssets,M_VerifiedAssets,M_UnverifiedAssets";
                                    
                     
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

                
                 
                                      case "2DA46861-844C-4840-8ACA-977A3F92D54A":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_2DA46861844C48408ACA977A3F92D54A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_A1_PONumber] VARCHAR(50)	, [MGG_A1_Status] VARCHAR(50)	, [MGG_A1_AssetTagId] NVARCHAR(37)	, [MGG_A1_AssetName] NVARCHAR(MAX)	, [MGG_A1_SupplierName] NVARCHAR(MAX)){0}INSERT INTO [2DA46861-844C-4840-8ACA-977A3F92D54A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_A1_PONumber,MGG_A1_AssetValue,MGG_A1_Status,MGG_A1_AssetTagId,MGG_A1_AssetName,MGG_A1_SupplierName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_A1_PONumber,TDT.MGG_A1_AssetValue,TDT.MGG_A1_Status,TDT.MGG_A1_AssetTagId,TDT.MGG_A1_AssetName,TDT.MGG_A1_SupplierName FROM @TBL_2DA46861844C48408ACA977A3F92D54A TDT
							LEFT JOIN [2DA46861-844C-4840-8ACA-977A3F92D54A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_A1_PONumber,MGG_A1_AssetValue,MGG_A1_Status,MGG_A1_AssetTagId,MGG_A1_AssetName,MGG_A1_SupplierName";

                                     tempInsertQuery=@"INSERT INTO @TBL_2DA46861844C48408ACA977A3F92D54A(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_A1_PONumber,MGG_A1_AssetValue,MGG_A1_Status,MGG_A1_AssetTagId,MGG_A1_AssetName,MGG_A1_SupplierName)VALUES({0});";
                                     

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
                     

                                         case "2DA46861-844C-4840-8ACA-977A3F92D54A":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_2DA46861844C48408ACA977A3F92D54A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_A1_PONumber] VARCHAR(50)	, [MGG_A1_Status] VARCHAR(50)	, [MGG_A1_AssetTagId] NVARCHAR(37)	, [MGG_A1_AssetName] NVARCHAR(MAX)	, [MGG_A1_SupplierName] NVARCHAR(MAX)){0}INSERT INTO [2DA46861-844C-4840-8ACA-977A3F92D54A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_A1_PONumber,MGG_A1_AssetValue,MGG_A1_Status,MGG_A1_AssetTagId,MGG_A1_AssetName,MGG_A1_SupplierName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_A1_PONumber,TDT.MGG_A1_AssetValue,TDT.MGG_A1_Status,TDT.MGG_A1_AssetTagId,TDT.MGG_A1_AssetName,TDT.MGG_A1_SupplierName FROM @TBL_2DA46861844C48408ACA977A3F92D54A TDT
							LEFT JOIN [2DA46861-844C-4840-8ACA-977A3F92D54A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_A1_PONumber,MGG_A1_AssetValue,MGG_A1_Status,MGG_A1_AssetTagId,MGG_A1_AssetName,MGG_A1_SupplierName";

                            tempInsertQuery=@"INSERT INTO @TBL_2DA46861844C48408ACA977A3F92D54A(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_A1_PONumber,MGG_A1_AssetValue,MGG_A1_Status,MGG_A1_AssetTagId,MGG_A1_AssetName,MGG_A1_SupplierName)VALUES({0});";

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
public class ISpace6B5E748F516A413680163464FB30137D : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace6B5E748F516A413680163464FB30137D acdataIspace6B5E748F516A413680163464FB30137D=new AcDataISpace6B5E748F516A413680163464FB30137D();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
Dictionary<short, object> keyValuePairs = null;base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource("30FF4DF1-4F20-46D7-A96C-168BAF2E20AC");

DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP("AssetList"),@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("AssetList","11",querySource30FF4DF14F2046D7A96C168BAF2E20AC,"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'",_objectFactory.GetGridRPP("AssetList"));

base.WriteDebugInfo(@"var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource(""30FF4DF1-4F20-46D7-A96C-168BAF2E20AC"");DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP(""AssetList""),@""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""AssetList"",""11"",querySource30FF4DF14F2046D7A96C168BAF2E20AC,""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""AssetList""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'#F_AssetName','#F_SupplierName','',#MF_AssetList_PageIndex,'#MF_AssetList_GridRows'");


List<Triplet<string, short, short?>> result0CA100A4A68A4238A02766DE4A5B7E6D=acdataIspace6B5E748F516A413680163464FB30137D.GetQueryExpressionBindings("0CA100A4-A68A-4238-A027-66DE4A5B7E6D");
iSpace.SetGridData(result30FF4DF14F2046D7A96C168BAF2E20AC,result0CA100A4A68A4238A02766DE4A5B7E6D,"AssetList",ref ISpace);
iSpace.UpdateGridBindDetails("AssetList",result0CA100A4A68A4238A02766DE4A5B7E6D);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec GetAssetStatistics");

var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource("41121bd1-6404-a61b-433c-376ab8a46061");
Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@"execGetAssetStatistics",false);

base.WriteDebugInfo(@"var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource(""41121bd1-6404-a61b-433c-376ab8a46061"");Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@""execGetAssetStatistics"",false);");
base.WriteDebugInfo(@"");

if((result41121bd16404a61b433c376ab8a46061!=null) && (result41121bd16404a61b433c376ab8a46061.Count!=0))
{
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(2))
ISpace["M_UnverifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[2];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(0))
ISpace["M_TotalAssets"].Value = result41121bd16404a61b433c376ab8a46061[0];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(1))
ISpace["M_VerifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[1];
}
else{
ISpace["M_UnverifiedAssets"].Value = null;ISpace["M_TotalAssets"].Value = null;ISpace["M_VerifiedAssets"].Value = null;
}
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

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource("30FF4DF1-4F20-46D7-A96C-168BAF2E20AC");

DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP("AssetList"),@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("AssetList","11",querySource30FF4DF14F2046D7A96C168BAF2E20AC,"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'",_objectFactory.GetGridRPP("AssetList"));

base.WriteDebugInfo(@"var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource(""30FF4DF1-4F20-46D7-A96C-168BAF2E20AC"");DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP(""AssetList""),@""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""AssetList"",""11"",querySource30FF4DF14F2046D7A96C168BAF2E20AC,""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""AssetList""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'#F_AssetName','#F_SupplierName','',#MF_AssetList_PageIndex,'#MF_AssetList_GridRows'");


List<Triplet<string, short, short?>> result0CA100A4A68A4238A02766DE4A5B7E6D=acdataIspace6B5E748F516A413680163464FB30137D.GetQueryExpressionBindings("0CA100A4-A68A-4238-A027-66DE4A5B7E6D");
iSpace.SetGridData(result30FF4DF14F2046D7A96C168BAF2E20AC,result0CA100A4A68A4238A02766DE4A5B7E6D,"AssetList",ref ISpace);
iSpace.UpdateGridBindDetails("AssetList",result0CA100A4A68A4238A02766DE4A5B7E6D);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec GetAssetStatistics");

var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource("41121bd1-6404-a61b-433c-376ab8a46061");
Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@"execGetAssetStatistics",false);

base.WriteDebugInfo(@"var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource(""41121bd1-6404-a61b-433c-376ab8a46061"");Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@""execGetAssetStatistics"",false);");
base.WriteDebugInfo(@"");

if((result41121bd16404a61b433c376ab8a46061!=null) && (result41121bd16404a61b433c376ab8a46061.Count!=0))
{
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(2))
ISpace["M_UnverifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[2];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(0))
ISpace["M_TotalAssets"].Value = result41121bd16404a61b433c376ab8a46061[0];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(1))
ISpace["M_VerifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[1];
}
else{
ISpace["M_UnverifiedAssets"].Value = null;ISpace["M_TotalAssets"].Value = null;ISpace["M_VerifiedAssets"].Value = null;
}
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

ISpace["MF_A1_AssetId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetId""].Value=null;");
ISpace["MF_A1_AssetTagId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetTagId""].Value=null;");
ISpace["MF_A1_AssetName"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetName""].Value=null;");
ISpace["MF_A1_SupplierName"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_SupplierName""].Value=null;");
ISpace["MF_A1_PONumber"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_PONumber""].Value=null;");
ISpace["MF_A1_AssetValue"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetValue""].Value=null;");
ISpace["MF_A1_AssetStatus"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetStatus""].Value=null;");
ISpace["MF_A1_Status"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_Status""].Value=null;");
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

ISpace["MF_A1_AssetId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetId""].Value=null;");
ISpace["MF_A1_AssetTagId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetTagId""].Value=null;");
ISpace["MF_A1_AssetName"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetName""].Value=null;");
ISpace["MF_A1_SupplierName"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_SupplierName""].Value=null;");
ISpace["MF_A1_PONumber"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_PONumber""].Value=null;");
ISpace["MF_A1_AssetValue"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetValue""].Value=null;");
ISpace["MF_A1_AssetStatus"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_AssetStatus""].Value=null;");
ISpace["MF_A1_Status"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_A1_Status""].Value=null;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT AssetDetails.[AssetId], AssetDetails.[AssetTagId], AssetDetails.[AssetName], AssetDetails.[SupplierName], AssetDetails.[PONumber], AssetDetails.[AssetValue], AssetDetails.[AssetStatus], AssetDetails.[Status] FROM  HR..AssetDetails  WHERE AssetDetails.AssetId= '#MGG_A1_AssetId'");

var querySourceE8E68574E8CA4C9A970220EB321C093B =GetQueryExpressionDataSource("E8E68574-E8CA-4C9A-9702-20EB321C093B");
Dictionary<short,object> resultE8E68574E8CA4C9A970220EB321C093B=iSpace.ExecuteQuery(querySourceE8E68574E8CA4C9A970220EB321C093B,@"SELECT AssetDetails.[AssetId], AssetDetails.[AssetTagId], AssetDetails.[AssetName], AssetDetails.[SupplierName], AssetDetails.[PONumber], AssetDetails.[AssetValue], AssetDetails.[AssetStatus], AssetDetails.[Status] FROM  HR..AssetDetails  WHERE AssetDetails.AssetId= '" + ISpace["MGG_A1_AssetId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE8E68574E8CA4C9A970220EB321C093B =GetQueryExpressionDataSource(""E8E68574-E8CA-4C9A-9702-20EB321C093B"");Dictionary<short,object> resultE8E68574E8CA4C9A970220EB321C093B=iSpace.ExecuteQuery(querySourceE8E68574E8CA4C9A970220EB321C093B,@""SELECT AssetDetails.[AssetId], AssetDetails.[AssetTagId], AssetDetails.[AssetName], AssetDetails.[SupplierName], AssetDetails.[PONumber], AssetDetails.[AssetValue], AssetDetails.[AssetStatus], AssetDetails.[Status] FROM  HR..AssetDetails  WHERE AssetDetails.AssetId= '"" + ISpace[""MGG_A1_AssetId""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT AssetDetails.[AssetId], AssetDetails.[AssetTagId], AssetDetails.[AssetName], AssetDetails.[SupplierName], AssetDetails.[PONumber], AssetDetails.[AssetValue], AssetDetails.[AssetStatus], AssetDetails.[Status] FROM  HR..AssetDetails  WHERE AssetDetails.AssetId= '#MGG_A1_AssetId'");

if((resultE8E68574E8CA4C9A970220EB321C093B!=null) && (resultE8E68574E8CA4C9A970220EB321C093B.Count!=0))
{
if(resultE8E68574E8CA4C9A970220EB321C093B.ContainsKey(6))
ISpace["MF_A1_AssetStatus"].Value = resultE8E68574E8CA4C9A970220EB321C093B[6];
if(resultE8E68574E8CA4C9A970220EB321C093B.ContainsKey(5))
ISpace["MF_A1_AssetValue"].Value = resultE8E68574E8CA4C9A970220EB321C093B[5];
if(resultE8E68574E8CA4C9A970220EB321C093B.ContainsKey(4))
ISpace["MF_A1_PONumber"].Value = resultE8E68574E8CA4C9A970220EB321C093B[4];
if(resultE8E68574E8CA4C9A970220EB321C093B.ContainsKey(7))
ISpace["MF_A1_Status"].Value = resultE8E68574E8CA4C9A970220EB321C093B[7];
if(resultE8E68574E8CA4C9A970220EB321C093B.ContainsKey(1))
ISpace["MF_A1_AssetTagId"].Value = resultE8E68574E8CA4C9A970220EB321C093B[1];
if(resultE8E68574E8CA4C9A970220EB321C093B.ContainsKey(2))
ISpace["MF_A1_AssetName"].Value = resultE8E68574E8CA4C9A970220EB321C093B[2];
if(resultE8E68574E8CA4C9A970220EB321C093B.ContainsKey(0))
ISpace["MF_A1_AssetId"].Value = resultE8E68574E8CA4C9A970220EB321C093B[0];
if(resultE8E68574E8CA4C9A970220EB321C093B.ContainsKey(3))
ISpace["MF_A1_SupplierName"].Value = resultE8E68574E8CA4C9A970220EB321C093B[3];
}
else{
ISpace["MF_A1_AssetStatus"].Value = null;ISpace["MF_A1_AssetValue"].Value = null;ISpace["MF_A1_PONumber"].Value = null;ISpace["MF_A1_Status"].Value = null;ISpace["MF_A1_AssetTagId"].Value = null;ISpace["MF_A1_AssetName"].Value = null;ISpace["MF_A1_AssetId"].Value = null;ISpace["MF_A1_SupplierName"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_projectexplorer (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_ProjectExplorer-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="AssetVerification?PkActMId=241BCCC0-C68C-4EFE-8E69-4E620A010097&frmElementId=DE2C7BF1-BA90-4AB8-853A-765F349ABF38&PkPrMId=3A7935C9-D8A6-4D6E-B274-7F9D55385FBF&formVersionId=E8FBB04E-9AEE-43DA-BE29-6BCD8ACC6191&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""AssetVerification?PkActMId=241BCCC0-C68C-4EFE-8E69-4E620A010097&frmElementId=DE2C7BF1-BA90-4AB8-853A-765F349ABF38&PkPrMId=3A7935C9-D8A6-4D6E-B274-7F9D55385FBF&formVersionId=E8FBB04E-9AEE-43DA-BE29-6BCD8ACC6191&Ver=0.0000"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_cancel (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Cancel-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_assetlist_pageindex (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_AssetList_PageIndex-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource("30FF4DF1-4F20-46D7-A96C-168BAF2E20AC");

DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP("AssetList"),@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("AssetList","11",querySource30FF4DF14F2046D7A96C168BAF2E20AC,"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'",_objectFactory.GetGridRPP("AssetList"));

base.WriteDebugInfo(@"var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource(""30FF4DF1-4F20-46D7-A96C-168BAF2E20AC"");DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP(""AssetList""),@""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""AssetList"",""11"",querySource30FF4DF14F2046D7A96C168BAF2E20AC,""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""AssetList""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'#F_AssetName','#F_SupplierName','',#MF_AssetList_PageIndex,'#MF_AssetList_GridRows'");


List<Triplet<string, short, short?>> result0CA100A4A68A4238A02766DE4A5B7E6D=acdataIspace6B5E748F516A413680163464FB30137D.GetQueryExpressionBindings("0CA100A4-A68A-4238-A027-66DE4A5B7E6D");
iSpace.SetGridData(result30FF4DF14F2046D7A96C168BAF2E20AC,result0CA100A4A68A4238A02766DE4A5B7E6D,"AssetList",ref ISpace);
iSpace.UpdateGridBindDetails("AssetList",result0CA100A4A68A4238A02766DE4A5B7E6D);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec GetAssetStatistics");

var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource("41121bd1-6404-a61b-433c-376ab8a46061");
Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@"execGetAssetStatistics",false);

base.WriteDebugInfo(@"var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource(""41121bd1-6404-a61b-433c-376ab8a46061"");Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@""execGetAssetStatistics"",false);");
base.WriteDebugInfo(@"");

if((result41121bd16404a61b433c376ab8a46061!=null) && (result41121bd16404a61b433c376ab8a46061.Count!=0))
{
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(2))
ISpace["M_UnverifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[2];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(0))
ISpace["M_TotalAssets"].Value = result41121bd16404a61b433c376ab8a46061[0];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(1))
ISpace["M_VerifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[1];
}
else{
ISpace["M_UnverifiedAssets"].Value = null;ISpace["M_TotalAssets"].Value = null;ISpace["M_VerifiedAssets"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_assetlist_gridrows (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_AssetList_GridRows-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource("30FF4DF1-4F20-46D7-A96C-168BAF2E20AC");

DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP("AssetList"),@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("AssetList","11",querySource30FF4DF14F2046D7A96C168BAF2E20AC,"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'",_objectFactory.GetGridRPP("AssetList"));

base.WriteDebugInfo(@"var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource(""30FF4DF1-4F20-46D7-A96C-168BAF2E20AC"");DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP(""AssetList""),@""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""AssetList"",""11"",querySource30FF4DF14F2046D7A96C168BAF2E20AC,""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""AssetList""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'#F_AssetName','#F_SupplierName','',#MF_AssetList_PageIndex,'#MF_AssetList_GridRows'");


List<Triplet<string, short, short?>> result0CA100A4A68A4238A02766DE4A5B7E6D=acdataIspace6B5E748F516A413680163464FB30137D.GetQueryExpressionBindings("0CA100A4-A68A-4238-A027-66DE4A5B7E6D");
iSpace.SetGridData(result30FF4DF14F2046D7A96C168BAF2E20AC,result0CA100A4A68A4238A02766DE4A5B7E6D,"AssetList",ref ISpace);
iSpace.UpdateGridBindDetails("AssetList",result0CA100A4A68A4238A02766DE4A5B7E6D);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec GetAssetStatistics");

var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource("41121bd1-6404-a61b-433c-376ab8a46061");
Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@"execGetAssetStatistics",false);

base.WriteDebugInfo(@"var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource(""41121bd1-6404-a61b-433c-376ab8a46061"");Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@""execGetAssetStatistics"",false);");
base.WriteDebugInfo(@"");

if((result41121bd16404a61b433c376ab8a46061!=null) && (result41121bd16404a61b433c376ab8a46061.Count!=0))
{
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(2))
ISpace["M_UnverifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[2];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(0))
ISpace["M_TotalAssets"].Value = result41121bd16404a61b433c376ab8a46061[0];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(1))
ISpace["M_VerifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[1];
}
else{
ISpace["M_UnverifiedAssets"].Value = null;ISpace["M_TotalAssets"].Value = null;ISpace["M_VerifiedAssets"].Value = null;
}
}
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

var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource("30FF4DF1-4F20-46D7-A96C-168BAF2E20AC");

DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP("AssetList"),@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("AssetList","11",querySource30FF4DF14F2046D7A96C168BAF2E20AC,"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'" + ISpace["F_AssetName"].Value + @"','" + ISpace["F_SupplierName"].Value + @"','','" + ISpace["MF_AssetList_PageIndex"].Value + @"','" + ISpace["MF_AssetList_GridRows"].Value + @"'",_objectFactory.GetGridRPP("AssetList"));

base.WriteDebugInfo(@"var querySource30FF4DF14F2046D7A96C168BAF2E20AC =GetQueryExpressionDataSource(""30FF4DF1-4F20-46D7-A96C-168BAF2E20AC"");DataTable result30FF4DF14F2046D7A96C168BAF2E20AC=iSpace.SetGridDataSource(querySource30FF4DF14F2046D7A96C168BAF2E20AC, _objectFactory.GetGridRPP(""AssetList""),@""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""AssetList"",""11"",querySource30FF4DF14F2046D7A96C168BAF2E20AC,""EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'"" + ISpace[""F_AssetName""].Value + @""','"" + ISpace[""F_SupplierName""].Value + @""','','"" + ISpace[""MF_AssetList_PageIndex""].Value + @""','"" + ISpace[""MF_AssetList_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""AssetList""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_163bd743-08f4-4cbe-b08a-1833f5443e75_FilterData] 1,'#F_AssetName','#F_SupplierName','',#MF_AssetList_PageIndex,'#MF_AssetList_GridRows'");


List<Triplet<string, short, short?>> result0CA100A4A68A4238A02766DE4A5B7E6D=acdataIspace6B5E748F516A413680163464FB30137D.GetQueryExpressionBindings("0CA100A4-A68A-4238-A027-66DE4A5B7E6D");
iSpace.SetGridData(result30FF4DF14F2046D7A96C168BAF2E20AC,result0CA100A4A68A4238A02766DE4A5B7E6D,"AssetList",ref ISpace);
iSpace.UpdateGridBindDetails("AssetList",result0CA100A4A68A4238A02766DE4A5B7E6D);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec GetAssetStatistics");

var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource("41121bd1-6404-a61b-433c-376ab8a46061");
Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@"execGetAssetStatistics",false);

base.WriteDebugInfo(@"var querySource41121bd16404a61b433c376ab8a46061 =GetQueryExpressionDataSource(""41121bd1-6404-a61b-433c-376ab8a46061"");Dictionary<short,object> result41121bd16404a61b433c376ab8a46061=iSpace.ExecuteQuery(querySource41121bd16404a61b433c376ab8a46061,@""execGetAssetStatistics"",false);");
base.WriteDebugInfo(@"");

if((result41121bd16404a61b433c376ab8a46061!=null) && (result41121bd16404a61b433c376ab8a46061.Count!=0))
{
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(2))
ISpace["M_UnverifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[2];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(0))
ISpace["M_TotalAssets"].Value = result41121bd16404a61b433c376ab8a46061[0];
if(result41121bd16404a61b433c376ab8a46061.ContainsKey(1))
ISpace["M_VerifiedAssets"].Value = result41121bd16404a61b433c376ab8a46061[1];
}
else{
ISpace["M_UnverifiedAssets"].Value = null;ISpace["M_TotalAssets"].Value = null;ISpace["M_VerifiedAssets"].Value = null;
}
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
		if(elementName.ToLower().Equals("mf_assetlist_pageindex"))
    {
    			SubscribeElementEvents_mf_assetlist_pageindex(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_assetlist_gridrows"))
    {
    			SubscribeElementEvents_mf_assetlist_gridrows(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("save"))
{
			SubscribeElementEvents_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("add"))
{
			SubscribeElementEvents_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit"))
{
			SubscribeElementEvents_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_projectexplorer"))
{
			SubscribeElementEvents_m_projectexplorer(ref dfsParam);
}
		if(elementName.ToLower().Equals("cancel"))
{
			SubscribeElementEvents_cancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("apply"))
{
			SubscribeElementEvents_apply(ref dfsParam);
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


	public partial class AcDataISpace6B5E748F516A413680163464FB30137D  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"0CA100A4-A68A-4238-A027-66DE4A5B7E6D", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MGG_A1_AssetName",2,
														   -1),
								   new Triplet<string, short, short?>("MGG_A1_SupplierName",3,
														   -1),
								   new Triplet<string, short, short?>("MGG_A1_AssetValue",5,
														   -1),
								   new Triplet<string, short, short?>("MGG_A1_PONumber",4,
														   -1),
								   new Triplet<string, short, short?>("MGG_A1_AssetTagId",1,
														   -1),
								   new Triplet<string, short, short?>("MGG_A1_Status",7,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"770944B9-E280-449C-AE7E-B27EB1909CF1", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5251EA11-248D-4DB3-96E0-3E7827310496", ""},
							{"A262F62A-DBCD-4D48-B666-88B4D7A79204", ""},
							{"770944B9-E280-449C-AE7E-B27EB1909CF1", ""},
							{"F5CE6056-FE8B-4BBC-9C9F-9CEAB27C1CC3", ""},
							{"B0A09BD6-32C3-471D-B15F-1D10ED6BB1E2", ""},
							{"FACB2E54-A0E4-4163-926A-5ED1C59CFA1F", ""},
							{"D268C966-A50E-4F8E-8BD8-46C2F6A5AC50", ""},
							{"B843883F-A454-4118-8879-AE9B6ED500BA", ""},
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
		


