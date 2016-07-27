<<<<<<< d946c432e06962e63f876580038b87d691dfd136
﻿using System.Collections.Generic;
using System.Web.Mvc;
using Nop.Web.Framework;

namespace Nop.Plugin.DiscountRules.HasOrderedXTimes.Models
{
    public class RequirementModel
    {
        public int DiscountId { get; set; }

        public int RequirementId { get; set; }

        public ComparisonOperators ComparisonOperator { get; set; }

        //TODO: Come back to this
        public int OrderCount { get; set; }
    }
=======
﻿using System.Collections.Generic;
using System.Web.Mvc;
using Nop.Web.Framework;

namespace Nop.Plugin.DiscountRules.HasOrderedXTimes.Models
{
    public class RequirementModel
    {
        public int DiscountId { get; set; }

        public int RequirementId { get; set; }

        //TODO: Come back to this
        public int OrderCount { get; set; }
    }
>>>>>>> Initial commit
}