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
    
    public partial class MESSAGE
    {
        public MESSAGE()
        {
            this.DIALOG_MESSAGE = new HashSet<DIALOG_MESSAGE>();
        }
    
        public decimal MESSAGE_ID { get; set; }
        public decimal SENDER_ID { get; set; }
        public string CONTENT { get; set; }
        public Nullable<System.DateTime> SENDTIME { get; set; }
        public decimal IS_READ { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual ICollection<DIALOG_MESSAGE> DIALOG_MESSAGE { get; set; }
    }
}