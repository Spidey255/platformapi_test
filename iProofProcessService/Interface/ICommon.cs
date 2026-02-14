

namespace CPS.Proof.DFSExtension
{
    using System.Collections.Generic;

    public interface ICommon
    {
        SlotToken Authorize(string strslotToken, 
            UserActivities activity);

        void UpdateGlobalVariables(SlotToken token,Context context,
            ref Dictionary<string, object> globalVariables,
            ref Dictionary<string, ServiceElementData> dictParams);

        void RemoveVariables(ref Dictionary<string, ServiceElementData> dicParams,
             Dictionary<string, object> globalVariables,  Dictionary<string, object> userVariables);

        object GetObjectValue(object obj,int dataTypeId);
    }
}
