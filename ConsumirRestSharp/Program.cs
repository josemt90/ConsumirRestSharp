using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirRestSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RestClient client = new RestClient("https://navision.furgotrayler.com/DynamicsNAV80USER/Odata/Company('Furgo-Trayler%20SL')/Proveedores?$filter=VAT_Registration_No%20eq%20%27A25221433%27");

        }
    }
}
