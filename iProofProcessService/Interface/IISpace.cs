using SRA.Proof.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CPS.Proof.DFSExtension
{
    public interface IISpace
    {

        static List<GridBindDetails> lstGridBindDetails { get; set; }

        /// <summary>
        /// Represents the method that set the 
        /// data source to the grid.
        /// </summary>
        /// <param name="querySourceDetails">
        /// A <see cref="Dictionary{String, String}"/> that represents the  querySourceDetails.
        /// </param>
        /// <param name="query">
        /// A <see cref="string"/> that contains the query 
        /// </param>
        DataTable SetGridDataSource(Dictionary<string, string> querySourceDetails,int gridRowsPerPage , string query);

     

        Dictionary<short, object> ExecuteQuery
              (Dictionary<string, string> querySourceDetails, string query, bool? isLookup);

        /// <summary>
        /// Represents the method that set the grid data to 
        /// the respective columns.
        /// </summary>
        /// <param name="queryresult">
        /// A <see cref="DataTable"/> that represents the quary expression id.
        /// </param>
        /// <param name="bindings">
        /// A list of triplets. Each triplet contains:
        /// - a <see cref="string"/> FirstValue,
        /// - a <see cref="short"/> Second Value,
        /// - a nullable <see cref="short"/> Third Value
        /// </param>
        /// <param name="elementId">
        /// A <see cref="string"/> that represents ElementId.
        /// </param>
        /// <param name="ISpace">
        /// A <see cref="Dictionary{String, Object}"/> that represents ISpace object.
        /// </param>
        /// <returns>
        /// Nothing
        /// </returns>
        void SetGridData(DataTable queryresult,
            List<Triplet<string, short, short?>> bindings, string elementId,
            ref Dictionary<string, ServiceElementData> ISpace);


        /// <summary>
        /// Represents a method the sets property and value to control.
        /// </summary>
        /// <param name="elementName">
        /// A <see cref="string"/> that represents element name.
        /// </param>
        /// <param name="property">
        /// A <see cref="string"/> that represents property name.
        /// </param>
        /// <param name="controlValue">
        /// A <see cref="string"/> that represents the property value.
        /// </param>
        /// <param name="iSpace">
        /// A <see cref="Dictionary{String,Object}"/> that represents the Dictionary of ServiceElementData
        /// </param>
        void SetControlProperty(string elementName,
         string property, object controlValue, ref Dictionary<string, ServiceElementData> iSpace);

        /// <summary>
        /// Represents a method the sets property and value to UI control.
        /// </summary>
        /// <param name="elementName">
        /// A <see cref="string"/> that represents element name.
        /// </param>
        /// <param name="property">
        /// A <see cref="string"/> that represents property name.
        /// </param>
        /// <param name="value">
        /// A <see cref="string"/> that represents the property value.
        /// </param>
        /// <param name="iSpace">
        /// A <see cref="Dictionary{String,Object}"/> that represents the Dictionary of ServiceElementData
        /// </param>
        void SetUIControlProperty(string elementName,
            string property, object value, ref Dictionary<string, ServiceElementData> iSpace);

         List<Dictionary<string, object>> Reload
                (string rElementName, string elementQuery, string connectionId);

        void InsertGridBindDetails(string gridName,string gridId,
            Dictionary<string, string> querySourceDetails, string gridQuery,int gridRPP);

        void UpdateGridBindDetails(string gridName, 
                List<Triplet<string, short, short?>> queryExpressionBinding);

        void GetLoopExpressionData(string gridName, ref Dictionary<string, ServiceElementData> ISpace);

        void SetLoopExpressionData(string gridName, string gridId, int gridRPP,string bulkInsertQuery,
                    ref Dictionary<string, ServiceElementData> ISpace);

        void RedirectNewWindow(ref Dictionary<string, ServiceElementData> ISpace, string url);

        void RedirectExternal(ref Dictionary<string, ServiceElementData> ISpace, string url);

        object Sum(string gridTable, string gridcolumn, string gridvalue);

    }
}
