using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerProductWS
{
    /// <summary>
    /// ProductWS için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class ProductWS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Durdu Dünya Yokluğunda";
        }

        ProductBaglantiDataContext db = new ProductBaglantiDataContext();
        [WebMethod]
        public List<UrunSonuc> urunGetir()
        {
            return db.Products.Select(x => new UrunSonuc
            {
                UrunID = x.ProductID,
                UrunAdi = x.ProductName,
                Fiyat = x.UnitPrice,
                Stok = x.UnitsInStock
            }).ToList();
        }

    }
    public class UrunSonuc
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Fiyat { get; set; }//Bu alanlar null geçilebileceği için soru işareti eklenildi
        public short? Stok { get; set; }
    }
}
