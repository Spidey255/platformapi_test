
using System;
using log4net;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using SRA.Proof.Common;
using SRA.Proof.Middleware;
using Newtonsoft.Json.Linq;
// ReSharper disable once CheckNamespace
namespace CPS.Proof.DFSExtension
{
    internal  class ExternalQueryExecutorMsSql : MsSQLControllerBase, IExternalQueryController
    {
        #region Private Variables
        /// <summary>
        /// A <see cref="log4net.ILog"/> is used to write the log.
        /// </summary>
        private readonly ILog _sysLog;

        
        #endregion

        #region Constuctor
        /// <summary>
        /// method to get ExtarnalQueryExecutorMsSql
        /// </summary>
        public ExternalQueryExecutorMsSql()
        {
            _sysLog = LogManager.GetLogger(GetType());
        }
        #endregion

         /// <summary>
        /// Represents a member field which holds the app settings.
        /// </summary>
        private ConnectionString _connStrings;

        /// <summary>
      /// Represents a method to Excute the Query.
      /// </summary>
      /// <param name="connectionstring">
      /// A <see cref="string"/> hold the Connection String.
      /// </param>
      /// <param name="query">
      /// A <see cref="string"/> hold the query.
      /// </param>
      /// <param name="queryResult">
      /// A <see cref="Dicitionary{S,O}"/> hold the Result of the Query.
      /// </param>
      /// <returns>Execution Status</returns>
        public Status ExecuteQuery(string connectionString,
            string query,
                      out Dictionary<short, object> queryResults)
      {
          IDataReader reader = null;          

          queryResults = null;

          _sysLog.Debug("Entering ExecuteQuery.");

          _sysLog.DebugFormat("The QUERY RUNNING IS {0}", query);

          try
          {
                _sysLog.Debug("Entering ExecuteQuery");

               
                var dbConnectionString = 
                    GetConnectionString(connectionString);


                //Get Database instance from Enterprise library
                Database db = new SqlDatabase(dbConnectionString);

                if (db == null)
                {
                  
                    return Status.Failure;
                }

                
                using (DbCommand command = db.GetSqlStringCommand(query))
                {
                    command.CommandTimeout = 10000;

                   
                        using (reader = db.ExecuteReader(command))
                        {
                            //Get first row from result query.
                            //Only one row could be allowed to set result values to target
                            //elements.
                            if (reader.Read())
                            {
                                queryResults = new Dictionary<short, object>();

                                for (short index = 0;
                                    index < reader.FieldCount;
                                    index++)
                                    //Add column index and result value.
                                    queryResults.Add(index, reader[index]);
                            }

                        }
                    
                }



              return Status.Success;
          }
          catch (Exception ex)
          {
              _sysLog.Error("Error in ExecuteQuery", ex);

              return Status.Failure;
          }
          finally
          {

              if (reader != null)
              {
                  if (!reader.IsClosed)
                      reader.Close();
                    reader.Dispose();
              }

            
                _sysLog.Debug("Exiting ExecuteQuery");
            }
      }

    
         /// <summary>
        /// Represents a helper method to retrieve the 
        /// database instance.
        /// </summary>
        /// <returns>
        /// The <see cref="Database"/>instance.
        /// </returns>
        private string GetProofConnectionString
            ( string ProofConnectionId)
        {

           
            try
            {

               
                var connectionString =
                    base.GetConnectionStringById(
                        AppParams.GetAppSettings("RepConnectionName"), ProofConnectionId);


                return connectionString;


            }
            catch(Exception ex)
            {
                _sysLog.Error("Error in GetProofConnectionString", ex);

                return null;
            }


        }

       /// <summary>
        /// Represents the method that is used to get
        /// the grid data source based on the given 
        /// query and connection string.
        /// </summary>
        /// <param name="connectionstring">
        /// A <see cref="string"/> hold the Connection String.
        /// </param>
        /// <param name="query">
        /// A <see cref="string"/> hold the query.
        /// </param>
        /// <param name="queryResult">
        /// A <see cref="DataTable"/> hold the Result of the Query.
        /// </param>
        /// <returns>Execution Status</returns>
        public Status GetGridDataSource(ConnectionString connectionstring,
          string query, out DataTable queryResult)
        {
            queryResult = null;                   
                        

            try
            {
                _sysLog.Debug("Entering GetGridDataSource");

                _sysLog.DebugFormat("THE QUERY GOING TO RUN IS  {0}", query);


                var dbConnectionString =
                    GetConnectionString(connectionstring.Connection);


                //Get Database instance from Enterprise library
                Database db = new SqlDatabase(dbConnectionString);

                if (db == null)
                {

                    return Status.Failure;
                }

              
                if (string.IsNullOrWhiteSpace(query))
                    return Status.Failure;

                if (db == null)
                {
                    _sysLog.Error("Exiting ExecuteQuery");
                    return Status.Failure;
                }

                
                _sysLog.DebugFormat("THE QUERY GOING TO RUN IS  {0}", query);

                using (var command = db.GetSqlStringCommand(query))
                {

                    command.CommandTimeout = 10000;

                    var queryDataset = db.ExecuteDataSet(command);

                   
                    //If the data set is not null and if it having tables
                    //then setting the resulting table of index 0 to 
                    //query results data table.
                    if (queryDataset.Tables.Count == 1)
                        queryResult = queryDataset.Tables[0];
                }

                return Status.Success;
                      
            }
            catch (Exception exp)
            {
                _sysLog.Debug("Exiting GetGridDataSource on Exception", exp);

                return Status.Failure;
            }
           
        }


        /// <summary>
        /// Represents a helper method to retrieve the 
        /// database instance.
        /// </summary>
        /// <returns>
        /// The <see cref="Database"/>instance.
        /// </returns>
        private string GetConnectionString(string connectionString)
        {
                     

            var splitedString = connectionString.Split(';');

            var providerName = splitedString[0].Substring
                (splitedString[0].LastIndexOf("=", StringComparison.Ordinal) + 1);

            var connectionStrings = connectionString.Substring
                (connectionString.IndexOf(";", StringComparison.Ordinal) + 1);


            return connectionStrings;
        }

           public ConnectionString ConnectionById
            (string ProofconnectionId, string AppConnectionId)
        {

           
           
                GetSystemConnectionSettings(GetProofConnectionString( ProofconnectionId),
                    AppConnectionId, out _connStrings);


                return _connStrings;
            
        }

         /// <summary>
        /// Represents the method that retrieves the System
        /// Application Settings Details.
        /// </summary>
        /// <param name="connectionStrings">
        /// A <see cref="System.Collections.Generic.Dictionary{TKey,TValue}"/> 
        /// that contains the application status id and its name.
        /// </param>
        /// <returns>
        /// A <see cref="System.Boolean"/> that holds the execution flag.
        /// </returns>
        public bool GetSystemConnectionSettings
            (string contextConnectionString, string connectionId,
                out ConnectionString connectionStrings)
        {

            connectionStrings = null;

            IDataReader reader = null;

            ICryptoManager crypt = null;

            try
            {
                //Entry log.
                _sysLog.Debug("Entering GetSystemAppSettings.");

                _sysLog.DebugFormat("GetSystemConnectionSettingsSql connectionstring {0}is", contextConnectionString);

                var database = CreateSQLDatabase(contextConnectionString);

                _sysLog.Debug("Exiting  CreateDBFromEncodedCS.");

                
                using (var command = database.GetStoredProcCommand
                    ("GetSysConnectionSettings"))
                {
                    command.CommandTimeout = 10000;
                    

                    database.AddInParameter(command, AppConnectionStringsConstants.ConnId, DbType.String,
                          connectionId);

                    reader = database.ExecuteReader(command);
                }

                var connIdIndex = reader.GetOrdinal(AppConnectionStringsConstants.ConnId);

                var connNameIndex = reader.GetOrdinal(AppConnectionStringsConstants.ConnName);

                var connStringIndex = reader.GetOrdinal(AppConnectionStringsConstants.ConnString);

                var methodIndex = reader.GetOrdinal(AppConnectionStringsConstants.MethodName);

                var hostIndex = reader.GetOrdinal(AppConnectionStringsConstants.HostName);

                var portIndex = reader.GetOrdinal(AppConnectionStringsConstants.Port);

                var tempIndex = reader.GetOrdinal(AppConnectionStringsConstants.Template);

                var connectionType = reader.GetOrdinal(AppConnectionStringsConstants.ConnectionType);

                var requestType = reader.GetOrdinal(AppConnectionStringsConstants.RequestType);

                var nameSpace = reader.GetOrdinal(AppConnectionStringsConstants.NameSpace);

                var contentType = reader.GetOrdinal(AppConnectionStringsConstants.ContentTypeConstant);

                var requireAuthentication = reader.GetOrdinal(AppConnectionStringsConstants.RequireAuthentication);

                var hasRequestBody = reader.GetOrdinal(AppConnectionStringsConstants.HasRequestBody);

                var usrNameIndex = reader.GetOrdinal(AppConnectionStringsConstants.UserName);

                var pswdIndex = reader.GetOrdinal(AppConnectionStringsConstants.Password);

                var tlsIndex = reader.GetOrdinal(AppConnectionStringsConstants.TLS);

                var autoconnectIndex = reader.GetOrdinal(AppConnectionStringsConstants.AutoConnect);

                var successCodesIndex = reader.GetOrdinal(AppConnectionStringsConstants.SuccessCodes);

                var errCodesIndex = reader.GetOrdinal(AppConnectionStringsConstants.ErrorCodes);

                var idleTimeIndex = reader.GetOrdinal(AppConnectionStringsConstants.IdleTimeout);

                var retriesIndex = reader.GetOrdinal(AppConnectionStringsConstants.Retries);

                var retryIntervalIndex = reader.GetOrdinal(AppConnectionStringsConstants.RetryInterval);

                var isAsyncIndex = reader.GetOrdinal(AppConnectionStringsConstants.IsAsync);

               crypt = ObjectManager.Acquire<ICryptoManager>();

                while (reader.Read())
                {
                    int dbType = reader.GetByte(connectionType);

                    var connString = new ConnectionString();

                    connString.ConnectionId = reader.GetString(connIdIndex);
                    connString.Connection = (dbType != 0 && dbType != 1 && dbType != 2)
                                                            ? reader.GetString(connStringIndex) :
                                                            crypt.Decrypt(reader.GetString(connStringIndex));
                    connString.Name = reader.GetString(connNameIndex);
                    connString.Template = reader.IsDBNull(tempIndex) ? null :
                                                        reader.GetString(tempIndex);
                    connString.HostName = reader.IsDBNull(hostIndex) ? null :
                                                        reader.GetString(hostIndex);
                    connString.Port = reader.IsDBNull(portIndex) ? 0 :
                                                        reader.GetInt32(portIndex);
                    connString.DbType = (DbTypes)dbType;
                    connString.ConnectionType = (ConnectionTypes)dbType;
                    connString.MethodName = reader.IsDBNull(methodIndex) ?
                                                        null : reader.GetString(methodIndex);
                    connString.RequestType = reader.IsDBNull(requestType)
                                                        ? RequestType.Get :
                                                        (RequestType)reader.GetByte(requestType);


                    connString.NameSpace = reader.IsDBNull(nameSpace) ? null :
                                                    reader.GetString(nameSpace);

                    connString.ContentType = reader.IsDBNull(contentType) ?
                        ContentType.XML : (ContentType)reader.GetByte(contentType);

                    connString.RequireAuthentication = reader.IsDBNull(requireAuthentication) ?
                        false : reader.GetBoolean(requireAuthentication);

                    connString.HasRequestBody = reader.IsDBNull(hasRequestBody) ?
                        false : reader.GetBoolean(hasRequestBody);

                    connString.UserName = reader.IsDBNull(usrNameIndex) ? null :
                        crypt.Decrypt(reader.GetString(usrNameIndex));

                    connString.Password = reader.IsDBNull(pswdIndex) ? null :
                        crypt.Decrypt(reader.GetString(pswdIndex));

                    connString.IdleTimeouts = reader.IsDBNull(idleTimeIndex) ? 30 :
                        reader.GetInt32(idleTimeIndex);

                    connString.AutoReConnect = reader.IsDBNull(autoconnectIndex) ? false
                        : reader.GetBoolean(autoconnectIndex);

                    connString.TransportLayeredService = reader.IsDBNull(tlsIndex) ? false
                         : reader.GetBoolean(tlsIndex);

                    connString.SuccessCodes = reader.IsDBNull(successCodesIndex) ? null
                         : reader.GetString(successCodesIndex);

                    connString.ErrorCodes = reader.IsDBNull(errCodesIndex) ? null
                         : reader.GetString(errCodesIndex);

                    connString.Retries = reader.IsDBNull(retriesIndex) ? 0
                         : Convert.ToInt32(reader.GetByte(retriesIndex));

                    connString.RetryInterval = reader.IsDBNull(retryIntervalIndex) ? 0
                         : Convert.ToDouble(reader.GetDecimal(retryIntervalIndex));

                    connString.IsAsync = reader.IsDBNull(isAsyncIndex) ? false
                         : reader.GetBoolean(isAsyncIndex);


                    connectionStrings = connString;
                }

                //Exit log.
                _sysLog.Debug("Exiting GetSystemAppSettings.");


                return true;
            }
            catch (Exception e)
            {
                //Error log.
                _sysLog.Error("ERROR in GetSystemAppSettings.", e);

                return false;
            }
            finally
            {
                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();

                    reader.Dispose();
                }

                if (crypt != null)
                    ObjectManager.Release(crypt);
            }
        }


        public Status GetElementClientData(string instanceId, string widgetId, out string ClientData)
        {
            _sysLog.Debug("Entering GetElementClientData");

            IDataReader reader = null;

            ClientData = null;

            try
            {

                Database database = GetDatabaseInstance();

                using (DbCommand command =
                    database.GetStoredProcCommand("GetFormInstanceData"))
                {
                    command.CommandTimeout = 10000;

                    database.AddInParameter(command, "FormInstanceId", DbType.String, instanceId);


                    database.AddInParameter(command, "ComplexElementId", DbType.String, widgetId);


                    reader = database.ExecuteReader(command);

                    if (reader != null)
                    {
                        while (reader.Read())
                        {

                            ClientData = reader.GetString(0);
                        }
                    }


                    return Status.Success;
                }
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in GetFormInstanceData", ex);

                return Status.Failure;
            }
            finally
            {
                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    reader.Dispose();
                }

                _sysLog.Debug("Exiting GetFormInstanceData");
            }
        }


         public Status GetComboDataSource(SlotToken token, Tuple<string,string> comboSource,
            out DataTable queryResult)
        {
            _sysLog.Debug("Entering GetComboDataSource");

            IDataReader reader = null;

            ICryptoManager cryptoManager = null;

            queryResult = null;

            try
            {
                Database database = GetDatabaseInstance(token);

                cryptoManager = ObjectManager.Acquire<ICryptoManager>();

                 string connectionString=DecryptConnectionstring(comboSource.Item1);

                string query = comboSource.Item2;               

                if (string.IsNullOrEmpty(connectionString))
                    return Status.Failure;

                var splitconnectionString = connectionString.Split(new[] { ';' }, 2);

                var status = ExecuteComboQuery(splitconnectionString[1], query, out queryResult);

                return status;                


            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in GetComboDataSource", ex);

                return Status.Failure;

            }
            finally
            {

                ObjectManager.Release<ICryptoManager>(cryptoManager);


                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    reader.Dispose();
                }


                _sysLog.Debug("Exiting GetComboDataSource");
            }
        }

        private string DecryptConnectionstring(string connectionString)
        {
            ICryptoManager cryptoManager = null;

            try
            {
                cryptoManager = ObjectManager.Acquire<ICryptoManager>();

                return cryptoManager.Decrypt(connectionString);

            }
            catch
            {
                if (cryptoManager != null)
                {
                    ObjectManager.Release<ICryptoManager>(cryptoManager);
                }

                return null;
            }
        }


        public Status ExecuteComboQuery(string connectionString,
          string query,
                    out DataTable queryResults)
        {
            IDataReader reader = null;

            queryResults = null;

            _sysLog.Debug("Entering ExecuteQuery.");

            _sysLog.DebugFormat("The QUERY RUNNING IS {0}", query);

            try
            {
                _sysLog.Debug("Entering ExecuteQuery");

                //Get Database instance from Enterprise library
                Database db = new SqlDatabase(connectionString);

                if (db == null)
                {

                    return Status.Failure;
                }


                using (DbCommand command = db.GetSqlStringCommand(query))
                {
                    command.CommandTimeout = 10000;


                    using (reader = db.ExecuteReader(command))
                    {
                        var queryDataset = db.ExecuteDataSet(command);


                        //If the data set is not null and if it having tables
                        //then setting the resulting table of index 0 to 
                        //query results data table.
                        if (queryDataset.Tables.Count == 1)
                            queryResults = queryDataset.Tables[0];

                    }
                }

                return Status.Success;
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in ExecuteQuery", ex);

                return Status.Failure;
            }
            finally
            {

                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    reader.Dispose();
                }


                _sysLog.Debug("Exiting ExecuteQuery");
            }
        }


         /// <summary>
        /// Represents a method to Excute the Query.
        /// </summary>
        /// <param name="connectionstring">
        /// A <see cref="string"/> hold the Connection String.
        /// </param>
        /// <param name="query">
        /// A <see cref="string"/> hold the query.
        /// </param>
        /// <param name="queryResult">
        /// A <see cref="Dicitionary{S,O}"/> hold the Result of the Query.
        /// </param>
        /// <returns>Execution Status</returns>
        public Status ExecuteQuery(string connectionString,
            string query,
                      out DataTable queryResults)
        {
            IDataReader reader = null;

            queryResults = null;

            _sysLog.Debug("Entering ExecuteQuery.");

            _sysLog.DebugFormat("The QUERY RUNNING IS {0}", query);

            try
            {
                _sysLog.Debug("Entering ExecuteQuery");


                var dbConnectionString =
                    GetConnectionString(connectionString);


                //Get Database instance from Enterprise library
                Database db = new SqlDatabase(dbConnectionString);

                if (db == null)
                {

                    return Status.Failure;
                }


                using (DbCommand command = db.GetSqlStringCommand(query))
                {
                    command.CommandTimeout = 10000;


                    using (reader = db.ExecuteReader(command))
                    {
                        var queryDataset = db.ExecuteDataSet(command);


                        //If the data set is not null and if it having tables
                        //then setting the resulting table of index 0 to 
                        //query results data table.
                        if (queryDataset.Tables.Count == 1)
                            queryResults = queryDataset.Tables[0];

                    }

                }



                return Status.Success;
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in ExecuteQuery", ex);

                return Status.Failure;
            }
            finally
            {

                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    reader.Dispose();
                }


                _sysLog.Debug("Exiting ExecuteQuery");
            }
        }

         public Status GetFormInstanceData(SlotToken token,
              Context context, out DataTable queryResult)
        {
            _sysLog.Debug("Entering GetFormInstanceData");

            queryResult = null;

          
            try
            {

                Database database = GetDatabaseInstance(token);


                string getSPName = string.Empty;

                getSPName = "GetFormData" + context.WidgetId.Replace("-", "");


                using (DbCommand command =
                    database.GetStoredProcCommand
                        (getSPName))
                {
                    command.CommandTimeout = 10000;

                    database.AddInParameter(command, "InstanceId", DbType.String, context.FormInstanceId);

                    database.AddInParameter(command, "ProcessActivityMapId", DbType.String, context.ProcessActivityMapId);

                    database.AddInParameter(command, "FormId", DbType.String, context.WidgetId);                  

                    var queryDataset = database.ExecuteDataSet(command);

                    //If the data set is not null and if it having tables
                    //then setting the resulting table of index 0 to 
                    //query results data table.
                    if (queryDataset.Tables.Count > 0)
                        queryResult = queryDataset.Tables[0];
                                      
                    return Status.Success;
                }
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in GetFormInstanceData", ex);

                return Status.Failure;
            }
            finally
            {
                _sysLog.Debug("Exiting GetFormInstanceData");
            }
        }


         public Status SaveFormInstanceData(SlotToken token,  string insertQuery)
        {
            _sysLog.Debug("Entering SaveFormData");

           
            try
            {

                Database database = GetDatabaseInstance(token);

                          
              
                using (DbCommand command = 
                    database.GetSqlStringCommand
                        (insertQuery))
                {
                    command.CommandTimeout = 10000;

                    database.ExecuteNonQuery(command);
                   


                    return Status.Success;
                }
            }
            catch(Exception ex)
            {
                _sysLog.Error("Error in SaveFormData", ex);

                return Status.Failure;
            }
            finally
            {
                _sysLog.Debug("Exiting SaveFormData");
            }
        }

         private string InsertFormData(string instanceId, string packageProcessMapId, string processActivityMapId,
          string formId, long usermapid, string formJsonData)
        {
            _sysLog.Debug("Entering  InsertFormData");

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
       ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A](InstanceId,ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_w1_task_id,MF_w1_task_code,MF_w1_task_name,MF_w1_task_type_code,MF_w1_complexity_code,MF_w1_requirement_id,MF_w1_task_status,MF_w1_is_active,MF_w1_created_at,MF_w1_created_by,MF_w1_updated_by,MF_w1_updated_at,MFG_w2_step_id,MFG_w2_task_description,MFG_w2_task_id,MFG_w2_step_state,MFG_w2_step_sequence,MFG_w2_updated_at,MFG_w2_updated_by,MFG_w2_created_by,MFG_w2_created_at,MFG_w2_is_active,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid)  
       VALUES( {3}) END ELSE BEGIN UPDATE [74DE8FDB-50E6-4EF1-BA80-FBD2FF5FD49A]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

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
                _sysLog.Error("Error in  InsertFormData", ex);

                return null;
            }
            _sysLog.Debug("Exiting InsertFormData");
        }



       private string InsertGridData(string instanceId,string packageProcessMapId,string processActivityMapId,
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
		
		DECLARE  @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w2_step_id] INT	, [MG_w2_task_description] VARCHAR(50)	, [MG_w2_task_id] INT	, [MG_w2_step_state] VARCHAR(50)	, [MG_w2_updated_at] DATETIME	, [MG_w2_updated_by] INT	, [MG_w2_created_by] INT	, [MG_w2_created_at] DATETIME	, [MG_w2_is_active] BIT){0}INSERT INTO [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w2_step_id,TDT.MG_w2_task_description,TDT.MG_w2_task_id,TDT.MG_w2_step_state,TDT.MG_w2_updated_at,TDT.MG_w2_updated_by,TDT.MG_w2_created_by,TDT.MG_w2_created_at,TDT.MG_w2_is_active FROM @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 TDT
							LEFT JOIN [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active";

                                     tempInsertQuery=@"INSERT INTO @TBL_4EA7F6C5714844C1A8EF2BB10145EC09(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active)VALUES({0});";
                                     

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



      public Status GetGridInstanceData(SlotToken token,  
            Context context,out DataTable queryResult,out DataTable pagination)
      {
         _sysLog.Debug("Entering GetGridInstanceData");

         queryResult=null;

         pagination=null;
           
            try
            {

                Database database = GetDatabaseInstance(token);

                
                string getSPName = "GetGridData" + context.WidgetId.Replace("-", "");

                using (DbCommand command = 
                    database.GetStoredProcCommand
                        (getSPName))
                {
                    command.CommandTimeout = 10000;

                     command.CommandTimeout = 10000;

                    database.AddInParameter(command, "InstanceId", DbType.String, context.FormInstanceId);

                    database.AddInParameter(command, "ProcessActivityMapId", DbType.String, context.ProcessActivityMapId);

                    database.AddInParameter(command, "GridId", DbType.String, context.WidgetId);

                    database.AddInParameter(command, "PageDirection", DbType.Int16, context.PageDirection);

                    database.AddInParameter(command, "CurrentRowIndex", DbType.Int64, context.CurrentRowIndex);

                    database.AddInParameter(command, "PageSize", DbType.Int32, context.PageSize);

                    database.AddInParameter(command, "SearchFilter", DbType.String, context.SearchFilter);

                    var queryDataset = database.ExecuteDataSet(command);
                                       
                    //If the data set is not null and if it having tables
                    //then setting the resulting table of index 0 to 
                    //query results data table.
                     if (queryDataset.Tables.Count>0)
                        queryResult = queryDataset.Tables[0];

                    if (queryDataset.Tables.Count > 1)
                    {
                       
                        pagination = queryDataset.Tables[1];
                    }

                    return Status.Success;
                }
            }
            catch(Exception ex)
            {
                _sysLog.Error("Error in GetGridInstanceData", ex);

                return Status.Failure;
            }
            finally
            {
                _sysLog.Debug("Exiting GetGridInstanceData");
            }      
      }

      
     /*  public Status UpdateGridLoopData(string gridId,string gridName,int gridRPP, 
                 Dictionary<string,ServiceElementData> gridData)
        {
            _sysLog.Debug("Entering UpdateGridLoopData");

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
		
		DECLARE  @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_w2_step_id] INT	, [MG_w2_task_description] VARCHAR(50)	, [MG_w2_task_id] INT	, [MG_w2_step_state] VARCHAR(50)	, [MG_w2_updated_at] DATETIME	, [MG_w2_updated_by] INT	, [MG_w2_created_by] INT	, [MG_w2_created_at] DATETIME	, [MG_w2_is_active] BIT){0}INSERT INTO [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_w2_step_id,TDT.MG_w2_task_description,TDT.MG_w2_task_id,TDT.MG_w2_step_state,TDT.MG_w2_updated_at,TDT.MG_w2_updated_by,TDT.MG_w2_created_by,TDT.MG_w2_created_at,TDT.MG_w2_is_active FROM @TBL_4EA7F6C5714844C1A8EF2BB10145EC09 TDT
							LEFT JOIN [4EA7F6C5-7148-44C1-A8EF-2BB10145EC09] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active";

                            tempInsertQuery=@"INSERT INTO @TBL_4EA7F6C5714844C1A8EF2BB10145EC09(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_w2_step_id,MG_w2_task_description,MG_w2_task_id,MG_w2_step_state,MG_w2_updated_at,MG_w2_updated_by,MG_w2_created_by,MG_w2_created_at,MG_w2_is_active)VALUES({0});";

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

                var database = GetDatabaseInstance();

                using (DbCommand command =
                                   database.GetSqlStringCommand
                                       (bulkInsertQuery))
                {
                    command.CommandTimeout = 10000;

                    database.ExecuteNonQuery(command);

                }               

                return Status.Success;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  UpdateGridLoopData", ex);

                return Status.Failure;
            }
           
        }
        */


         public Status UpdateGridLoopData(string bulkInsertQuery)
        {
            _sysLog.Debug("Entering UpdateGridLoopData");

            try
            {

                var database = GetDatabaseInstance();

                using (DbCommand command =
                                   database.GetSqlStringCommand
                                       (bulkInsertQuery))
                {
                    command.CommandTimeout = 10000;

                    database.ExecuteNonQuery(command);

                }               

                return Status.Success;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  UpdateGridLoopData", ex);

                return Status.Failure;
            }
           
        }

        public Status DeleteGridInstanceData(Context context)
        {
            _sysLog.Debug("Entering DeleteGridInstanceData");

            var instanceId = context.FormInstanceId;

            var processActivityMapId = context.ProcessActivityMapId;


            try
            {
                Database database = GetDatabaseInstance();


                string getSPName = "DeleteGridData" + context.WidgetId.Replace("-", "");

                using (DbCommand command =
                    database.GetStoredProcCommand
                        (getSPName))
                {
                    command.CommandTimeout = 10000;

                    database.AddInParameter(command, "InstanceId", DbType.String, instanceId);

                    database.AddInParameter(command, "ProcessActivityMapId", DbType.String, processActivityMapId);

                    database.AddInParameter(command, "GridId", DbType.String, context.WidgetId);

                    database.AddInParameter(command, "RowIds", DbType.String, context.SelectedRowIds);

                    database.ExecuteNonQuery(command);


                    return Status.Success;
                }
            }
            catch (Exception ex)
            {

                _sysLog.Error("Error in DeleteGridInstanceData", ex);

                return Status.Failure;
            }
        }

        public Status AggregateGridData(string tableName, string gridColumnName, 
                string aggregatorType, string filter, out object aggregateValue)
        {
             _sysLog.Debug("Entering AggregateGridData");

            aggregateValue = null;

            var sqlQuery = @"SELECT {0} FROM {1} WHERE 1=1 {2}";

            try
            {
                var db = GetProofInstance();

                if (string.IsNullOrEmpty(filter))
                    filter = string.Empty;

                string aggfunction = string.Empty;

                switch (aggregatorType.ToLower())
                {
                    case "sum":

                        aggfunction = string.Concat("SUM(", gridColumnName, ")");                        

                        sqlQuery = string.Format(sqlQuery, aggfunction,tableName,filter);

                        break;

                    case "average":
                        aggfunction = string.Concat("AVG(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;

                    case "count":
                        aggfunction = string.Concat("COUNT(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;
                    case "min":
                        aggfunction = string.Concat("MIN(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;
                    case "max":
                        aggfunction = string.Concat("MAX(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;
                    case "stDev":
                        aggfunction = string.Concat("STDEV(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;



                }               

                using(var command= db.GetSqlStringCommand(sqlQuery))
                {
                    aggregateValue=db.ExecuteScalar(command);
                }

                return Status.Success;

            }
            catch(Exception ex)
            {
                _sysLog.Error("Error in AggregateGridData");

                return Status.Failure;
            }
            finally
            {

                _sysLog.Debug("Exting AggregateGridData");
            }
        }
       
    }
}