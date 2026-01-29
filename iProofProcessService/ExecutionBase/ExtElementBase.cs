using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Proof.DFSExtension
{
    public abstract class ExtElementBase:IExtElementBase
    {
        private ILog _logger = LogManager.GetLogger(typeof(ExtElementBase));

        public abstract string GetGridLoopQuery(string gridId, string gridName, Dictionary<string, ServiceElementData> gridData);

        public abstract string GetInsertFormDataQuery(string instanceId, string packageProcessMapId, string processActivityMapId,
          string formId, long usermapid, string formJsonData);

        public abstract string GetInsertGridDataQuery(string instanceId, string packageProcessMapId, string processActivityMapId,
          string formId, long usermapid, string formJsonData);
    }
}
