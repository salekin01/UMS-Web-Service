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
    
    public partial class LG_USER_CLASS_AREA_FUNCTION
    {
        public int SL_ID { get; set; }
        public string CLASSIFICATION_ID { get; set; }
        public string AREA_ID { get; set; }
        public string FUNCTION_ID { get; set; }
        public string AUTH_STATUS_ID { get; set; }
        public string LAST_ACTION { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DT { get; set; }
        public System.DateTime MAKE_DT { get; set; }
    
        public virtual LG_USER_AREA LG_USER_AREA { get; set; }
        public virtual LG_USER_CLASSIFACTION LG_USER_CLASSIFACTION { get; set; }
        public virtual LG_FNR_FUNCTION LG_FNR_FUNCTION { get; set; }
    }
}