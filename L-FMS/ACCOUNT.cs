//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace L_FMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACCOUNT
    {
        public ACCOUNT()
        {
            this.USER_INFO = new HashSet<USER_INFO>();
            this.DIALOG = new HashSet<DIALOG>();
            this.DIALOG1 = new HashSet<DIALOG>();
            this.MESSAGE = new HashSet<MESSAGE>();
            this.PUBLISHMENT = new HashSet<PUBLISHMENT>();
            this.COMMENT_ITEM_USER = new HashSet<COMMENT_ITEM_USER>();
            this.QUESTION = new HashSet<QUESTION>();
        }
    
        public decimal USER_ID { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public decimal PRIVILEGE { get; set; }
        public decimal VERIFIED { get; set; }
    
        public virtual ICollection<USER_INFO> USER_INFO { get; set; }
        public virtual ICollection<DIALOG> DIALOG { get; set; }
        public virtual ICollection<DIALOG> DIALOG1 { get; set; }
        public virtual ICollection<MESSAGE> MESSAGE { get; set; }
        public virtual ICollection<PUBLISHMENT> PUBLISHMENT { get; set; }
        public virtual ICollection<COMMENT_ITEM_USER> COMMENT_ITEM_USER { get; set; }
        public virtual ICollection<QUESTION> QUESTION { get; set; }
    }
}
