//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class LG_CRD_ADC_SMS_MSG
    {
        public decimal SMS_ID { get; set; }
        public string BRANCH_ID { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string CUSTOMER_ID { get; set; }
        public string CELL_NO { get; set; }
        public string MSG_TXT { get; set; }
        public short MSG_SENT_FLAG { get; set; }
        public string REASON_FOR_FAIL { get; set; }
        public Nullable<System.DateTime> SMS_INIT_TIME { get; set; }
        public Nullable<System.DateTime> SMS_SENT_TIME { get; set; }
        public Nullable<short> SMS_TRY_NO { get; set; }
        public Nullable<short> SMS_FNC_ID { get; set; }
        public string AUTH_STATUS_ID { get; set; }
        public string LAST_ACTION { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DT { get; set; }
        public System.DateTime MAKE_DT { get; set; }
    }
}