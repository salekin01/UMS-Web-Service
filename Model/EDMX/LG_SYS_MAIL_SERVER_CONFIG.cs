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
    
    public partial class LG_SYS_MAIL_SERVER_CONFIG
    {
        public string MAIL_ID { get; set; }
        public string MAIL_SENDER_IP { get; set; }
        public string MAIL_SENDER_ADDRESS { get; set; }
        public string MAIL_SENDER_PASSWORD { get; set; }
        public string MAIL_SENDER_NAME { get; set; }
        public string APPLICATION_ID { get; set; }
        public string AUTH_STATUS_ID { get; set; }
        public string LAST_ACTION { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DT { get; set; }
        public System.DateTime MAKE_DT { get; set; }
    
        public virtual LG_FNR_APPLICATION LG_FNR_APPLICATION { get; set; }
    }
}