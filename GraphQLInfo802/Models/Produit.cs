using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLInfo802.Models
{
    public class Produit
    {
        public int ProduitID { get; set; }
        public string VendeurID { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public double Prix { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class CreateProduitInput
    {
        public string VendeurID { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public double Prix { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class DeleteProduitInput
    {
        public int ProduitID { get; set; }
    }
}
