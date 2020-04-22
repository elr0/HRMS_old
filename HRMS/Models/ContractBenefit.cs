using System;
using System.Collections.Generic;

namespace HRMS.Models
{
    public partial class ContractBenefit
    {
        public int IdBenefitContract { get; set; }
        public int BenefitIdBenefit { get; set; }
        public int ContractIdContract { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public virtual Benefit BenefitIdBenefitNavigation { get; set; }
        public virtual Contract ContractIdContractNavigation { get; set; }
    }
}
