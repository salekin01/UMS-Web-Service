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
    
    public partial class LG_AA_NFT_AUTH_LOG_DTLS
    {
        public long LOG_DETAILS_ID { get; set; }
        public long LOG_ID { get; set; }
        public string AUTH_OR_DEC_BY { get; set; }
        public System.DateTime AUTH_OR_DEC_DT { get; set; }
        public short AUTH_LEVEL { get; set; }
        public string AUTH_STATUS_ID { get; set; }
    
        public virtual LG_AA_NFT_AUTH_LOG LG_AA_NFT_AUTH_LOG { get; set; }
    }
}
