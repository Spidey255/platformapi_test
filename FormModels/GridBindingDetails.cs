using System.Collections.Generic;

namespace CPS.Proof.DFSExtension
{
    public  class GridBindDetails
    {
        public string GridName { get; set; }

        public Dictionary<string, string> QuerySourceDetails { get;set; }

        public string GridQuery { get; set; }

        public List<Triplet<string, short, short?>> QueryExpressionBinding { get; set; }

        public int GridRPP { get; set; }

        public string GridId { get; set; }
    }
}
