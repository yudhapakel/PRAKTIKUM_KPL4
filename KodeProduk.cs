using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD_4
{
    internal class KodeProduk
    {
        private static Dictionary<string, string> KodeProduktable = new Dictionary<string, string>
        {
            {"laptop", "E100" },
            {"smartphone", "E101" },
            {"tablet", "E102" },
            {"headset", "E103" },
            {"keyboard", "E104" },
            {"mouse", "E105" },
            {"printer", "E106" },
            {"monitor", "E107" },
            {"smartwacth", "E108" },
            {"kamera", "E109" }
        };

        public static string GetKodeProduk(string produk)
        {
            return KodeProduktable.ContainsKey(produk) ? KodeProduktable[produk] : "Produk Gagal ditemukan !!";
        }
    }
}
