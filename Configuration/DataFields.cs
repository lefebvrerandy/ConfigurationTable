using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration
{
    class DataFields
    {
        public string TimeScale;            /* Time scale is x1 */
        public string RefillRate;           /* Refille rate is 5 minutes */

        public string RookieDefectRate;     /* Rookie has a 0.85% chance to produce a defective product */
        public string RookieBuildRate;      /* Rookie will take 50% longer to build a product*/

        public string NormalDefectRate;     /* Normal has a 0.5% chance to produce a defective product */
        public string NormalBuildRate;      /* Normal will build a product at normal rate*/

        public string SuperDefectRate;      /* Super has a 0.15% chance to produce a defective product */
        public string SuperBuildRate;       /* Super will build a product 15% quicker than normal */

        public string BinHarness;           /* Default rate for Harness */
        public string BinReflector;         /* Default rate for Reflector */
        public string BinHousing;           /* Default rate for Housing */
        public string BinLens;              /* Default rate for Lens */
        public string BinBulb;              /* Default rate for Bulb */
        public string BinBezel;             /* Default rate for Bezel */

        public string connectionString;

        /// <summary>
        /// Default all class variables to empty strings
        /// </summary>
        public DataFields()
        {
            TimeScale = "";
            RefillRate = "";
            RookieDefectRate = "";
            RookieBuildRate = "";
            NormalDefectRate = "";
            NormalBuildRate = "";
            SuperDefectRate = "";
            SuperBuildRate = "";
            BinHarness = "";
            BinReflector = "";
            BinHousing = "";
            BinLens = "";
            BinBulb = "";
            BinBezel = "";
        }

    }
}
