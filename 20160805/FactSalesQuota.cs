//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _20160805
{
    using System;
    using System.Collections.Generic;
    
    public partial class FactSalesQuota
    {
        public int SalesQuotaKey { get; set; }
        public int EmployeeKey { get; set; }
        public int DateKey { get; set; }
        public short CalendarYear { get; set; }
        public byte CalendarQuarter { get; set; }
        public decimal SalesAmountQuota { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual DimDate DimDate { get; set; }
        public virtual DimEmployee DimEmployee { get; set; }
    }
}
