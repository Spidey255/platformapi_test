  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class DocumentLoadandSaveImplementationinReactProcessMetadata : ExtensionProcessBase
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
            get { return "71d5fd3d-c295-4a64-956a-9a7262954afb"; }
        }

        public override string ProcessName
        {
            get { return "DocumentLoadandSaveImplementationinReact"; }
        }

		public override string ProcessDescription
        {
            get { return "Document Load and Save Implementation in React"; }
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
            get {return "71d5fd3d-c295-4a64-956a-9a7262954afb";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "A17C6012-D270-4980-875F-BEEE496D550D";	}
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
	

	public partial class DocumentLoadandSaveImplementationinReactObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new DocumentLoadandSaveImplementationinReactProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("462fbe4a-9a6e-91e8-801a-90753eb279b9","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2C3E6AF8-ED91-4182-A4C4-478C8DB4B2A3"),
			
						
			     new Triplet<string, string, string>("71ba49b3-b8da-cf91-c78d-e4f01191c367","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2C3E6AF8-ED91-4182-A4C4-478C8DB4B2A3"),
			
			
			
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
											case "C370B0BE-CF5C-4B59-83E7-16407152A864":
							virtualInstance=new ISpaceC370B0BECF5C4B5983E716407152A864();
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
	

	public partial class DocumentLoadandSaveImplementationinReactDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public DocumentLoadandSaveImplementationinReactDataElementFactory()
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

               
                
                                      case "A17C6012-D270-4980-875F-BEEE496D550D":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [A17C6012-D270-4980-875F-BEEE496D550D] WHERE InstanceId='{0}' AND  
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [A17C6012-D270-4980-875F-BEEE496D550D](InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,M_ProjectCode,M_DocumentUpload)  
       VALUES( {3}) END ELSE BEGIN UPDATE [A17C6012-D270-4980-875F-BEEE496D550D]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,M_ProjectCode,M_DocumentUpload";
                                    
                     
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
public class ISpaceC370B0BECF5C4B5983E716407152A864 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceC370B0BECF5C4B5983E716407152A864 acdataIspaceC370B0BECF5C4B5983E716407152A864=new AcDataISpaceC370B0BECF5C4B5983E716407152A864();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetDocData");

var querySource462fbe4a9a6e91e8801a90753eb279b9 =GetQueryExpressionDataSource("462fbe4a-9a6e-91e8-801a-90753eb279b9");
Dictionary<short,object> result462fbe4a9a6e91e8801a90753eb279b9=iSpace.ExecuteQuery(querySource462fbe4a9a6e91e8801a90753eb279b9,@"EXEC GetDocData",false);

base.WriteDebugInfo(@"var querySource462fbe4a9a6e91e8801a90753eb279b9 =GetQueryExpressionDataSource(""462fbe4a-9a6e-91e8-801a-90753eb279b9"");Dictionary<short,object> result462fbe4a9a6e91e8801a90753eb279b9=iSpace.ExecuteQuery(querySource462fbe4a9a6e91e8801a90753eb279b9,@""EXEC GetDocData"",false);");
base.WriteDebugInfo(@"");

if((result462fbe4a9a6e91e8801a90753eb279b9!=null) && (result462fbe4a9a6e91e8801a90753eb279b9.Count!=0))
{
if(result462fbe4a9a6e91e8801a90753eb279b9.ContainsKey(1))
ISpace["M_DocumentUpload"].Value = result462fbe4a9a6e91e8801a90753eb279b9[1];
if(result462fbe4a9a6e91e8801a90753eb279b9.ContainsKey(0))
ISpace["M_ProjectCode"].Value = result462fbe4a9a6e91e8801a90753eb279b9[0];
}
else{
ISpace["M_DocumentUpload"].Value = null;ISpace["M_ProjectCode"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_save (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Save-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UPSERTDocData '#M_DocumentUpload.DocId'");

var querySource71ba49b3b8dacf91c78de4f01191c367 =GetQueryExpressionDataSource("71ba49b3-b8da-cf91-c78d-e4f01191c367");
Dictionary<short,object> result71ba49b3b8dacf91c78de4f01191c367=iSpace.ExecuteQuery(querySource71ba49b3b8dacf91c78de4f01191c367,@"EXEC UPSERTDocData '" + ISpace["M_DocumentUpload"].Value + @".DocId'",false);

base.WriteDebugInfo(@"var querySource71ba49b3b8dacf91c78de4f01191c367 =GetQueryExpressionDataSource(""71ba49b3-b8da-cf91-c78d-e4f01191c367"");Dictionary<short,object> result71ba49b3b8dacf91c78de4f01191c367=iSpace.ExecuteQuery(querySource71ba49b3b8dacf91c78de4f01191c367,@""EXEC UPSERTDocData '"" + ISpace[""M_DocumentUpload""].Value + @"".DocId'"",false);");
base.WriteDebugInfo(@"");

if((result71ba49b3b8dacf91c78de4f01191c367!=null) && (result71ba49b3b8dacf91c78de4f01191c367.Count!=0))
{
if(result71ba49b3b8dacf91c78de4f01191c367.ContainsKey(0))
ISpace["Subject"].Value = result71ba49b3b8dacf91c78de4f01191c367[0];
}
else{
ISpace["Subject"].Value = null;
}
ISpace["Message"].Value=@"Saved Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Saved Successfully"";");
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
		if(elementName.ToLower().Equals("m_save"))
{
			SubscribeElementEvents_m_save(ref dfsParam);
}
}
}
}
}
namespace CPS.Proof.DFSExtension
{
}

  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceC370B0BECF5C4B5983E716407152A864  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"1EAF254A-6501-4C1B-94C2-B62DDBAC4876", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"58FB0826-6C94-4BC6-8F9B-971FE79EB563", ""},
							{"F061332C-76DE-4E69-A06D-628ED9A9596E", ""},
							{"1EAF254A-6501-4C1B-94C2-B62DDBAC4876", ""},
							{"F8EF12CA-D15F-4B33-A0EC-BD14CCDC14B9", ""},
							{"EBC3CDBF-3BBE-42FD-B2B1-8C74756EB53E", ""},
							{"3433BF59-616A-4A20-95E0-4ACDABCEE072", ""},
							{"EC72111E-B6EA-4F9F-8C70-A86F55AD1406", ""},
							{"E57DF6FE-D02E-4745-90B7-934E91150230", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceCB8917C5E81F489CADC5EDB3D71E1FBD  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"1EAF254A-6501-4C1B-94C2-B62DDBAC4876", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"58FB0826-6C94-4BC6-8F9B-971FE79EB563", ""},
							{"F061332C-76DE-4E69-A06D-628ED9A9596E", ""},
							{"1EAF254A-6501-4C1B-94C2-B62DDBAC4876", ""},
							{"F8EF12CA-D15F-4B33-A0EC-BD14CCDC14B9", ""},
							{"EBC3CDBF-3BBE-42FD-B2B1-8C74756EB53E", ""},
							{"3433BF59-616A-4A20-95E0-4ACDABCEE072", ""},
							{"EC72111E-B6EA-4F9F-8C70-A86F55AD1406", ""},
							{"E57DF6FE-D02E-4745-90B7-934E91150230", ""},
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
		


