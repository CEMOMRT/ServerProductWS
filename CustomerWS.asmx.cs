using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerProductWS
{
    /// <summary>
    /// CustomerWS için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class CustomerWS : System.Web.Services.WebService
    {
        CustomerBaglantiDataContext cdc = new CustomerBaglantiDataContext();
        [WebMethod]

        public List<MusteriSonuc> MusteriGetir()
        {
            return cdc.Customers.Select(x => new MusteriSonuc
            {
                MusteriID = x.CustomerID,
                MusteriAdi = x.ContactName,
                SirketAdi = x.ContactName,
                Telefon = x.Phone
            }).ToList();
        }
    }
    public class MusteriSonuc
    {
        public string MusteriID { get; set; }//Northwind veri tabanında string değerdedir.
        public string SirketAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string Telefon { get; set; }
    }
}
