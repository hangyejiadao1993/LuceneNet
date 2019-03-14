using System;
using System.Collections.Generic;

namespace NCL.Entity
{
    public partial class UucEmployee
    {
        public int Oid { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeNumber { get; set; }
        public string LoginName { get; set; }
        public string Name { get; set; }
        public string Cn { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string OutterMail { get; set; }
        public int Level { get; set; }
        public string Function { get; set; }
        public string O { get; set; }
        public DateTime? AccountOverdue { get; set; }
        public int? Addomain { get; set; }
        public string LevelName { get; set; }
        public int? EmployeeType { get; set; }
        public byte? UserType { get; set; }
        public string ErpId { get; set; }
        public string AdsyncId { get; set; }
        public string Vcode { get; set; }
        public string AreaCode { get; set; }
        public string Dn { get; set; }
        public byte Status { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string ProviderServiceTimelimit { get; set; }
        public byte PullinLimit { get; set; }
        public string Index1 { get; set; }
        public string Index2 { get; set; }
        public string SmapUserPassword { get; set; }
        public string SmapEmail { get; set; }
        public DateTime? SmapPasswordModifiedDate { get; set; }
        public string SmapDisplayOrder { get; set; }
        public string SmapO { get; set; }
        public string SmapEmployeeType { get; set; }
        public string IdcardNumberCn { get; set; }
    }
}
