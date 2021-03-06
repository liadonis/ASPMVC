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
    
    public partial class DimGeography
    {
        public DimGeography()
        {
            this.DimCustomer = new HashSet<DimCustomer>();
            this.DimReseller = new HashSet<DimReseller>();
        }
    
        public int GeographyKey { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string StateProvinceName { get; set; }
        public string CountryRegionCode { get; set; }
        public string EnglishCountryRegionName { get; set; }
        public string SpanishCountryRegionName { get; set; }
        public string FrenchCountryRegionName { get; set; }
        public string PostalCode { get; set; }
        public Nullable<int> SalesTerritoryKey { get; set; }
        public string IpAddressLocator { get; set; }
    
        public virtual ICollection<DimCustomer> DimCustomer { get; set; }
        public virtual DimSalesTerritory DimSalesTerritory { get; set; }
        public virtual ICollection<DimReseller> DimReseller { get; set; }
    }
}
