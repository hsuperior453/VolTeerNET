//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VolTeer.DataAccessLayer.VT
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSkill
    {
        public tblSkill()
        {
            this.tblSkill1 = new HashSet<tblSkill>();
            this.tblVolunteers = new HashSet<tblVolunteer>();
        }
    
        public System.Guid SkillID { get; set; }
        public string SkillName { get; set; }
        public Nullable<System.Guid> MstrSkillID { get; set; }
        public Nullable<bool> ReqCert { get; set; }
        public int ActiveFlg { get; set; }
    
        public virtual ICollection<tblSkill> tblSkill1 { get; set; }
        public virtual tblSkill tblSkill2 { get; set; }
        public virtual ICollection<tblVolunteer> tblVolunteers { get; set; }
    }
}
