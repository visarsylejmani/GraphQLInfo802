using GraphQLInfo802.Exceptions;
using GraphQLInfo802.IServices;
using GraphQLInfo802.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLInfo802.Services
{
    public class ProduitService : IProduitService
    {
        private readonly IList<Produit> _produits;

        public ProduitService()
        {
            _produits = new List<Produit>
            {
                /*new Produit{ ProduitID = 1, Nom="Sac à main",   Description = "Joli sac à main comme neuf", Latitude = 46.146748, Longitude = 6.076364,   Prix = 29.50},
                new Produit{ ProduitID = 2, Nom="Sac à dos",    Description = "Joli sac à dos comme neuf",  Latitude = 46.146748, Longitude = 6.076364,   Prix = 35.00},
                new Produit{ ProduitID = 3, Nom="Tee-shirt",    Description = "Joli tee-shirt comme neuf",  Latitude = 46.146748, Longitude = 6.076364,   Prix = 20.00},*/
            };
        }

        public Produit Create(CreateProduitInput inputProduit)
        {
            var produit = new Produit
            {
                ProduitID = _produits.Count() + 1,
                VendeurID = inputProduit.VendeurID,
                Nom = inputProduit.Nom,
                Description = inputProduit.Description,
                Prix = inputProduit.Prix,
                Latitude = inputProduit.Latitude,
                Longitude = inputProduit.Longitude
            };
            _produits.Add(produit);
            return produit;
        }

        public Produit Delete(DeleteProduitInput inputProduit)
        {
            var produit = _produits.FirstOrDefault(x => x.ProduitID == inputProduit.ProduitID);
            if (produit == null) throw new ProduitNotFoundException() { ProduitID = inputProduit.ProduitID};
            _produits.Remove(produit);

            return produit;
        }

        public IQueryable<Produit> GetAll()
        {
            return _produits.AsQueryable();
        }
    }
}
