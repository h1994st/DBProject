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
    
    public partial class QUESTION
    {
        public QUESTION()
        {
            this.ACCOUNT = new HashSet<ACCOUNT>();
        }
    
        public decimal QUESTION_ID { get; set; }
        public string CONTENT { get; set; }
        public string QUESTION_FORMAT { get; set; }
        public string FORMAT_TIP { get; set; }
    
        public virtual ICollection<ACCOUNT> ACCOUNT { get; set; }
    }
}
