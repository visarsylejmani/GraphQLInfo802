using GraphQLInfo802.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLInfo802.IServices
{
    public interface IProduitService 
    {
        IQueryable<Produit> GetAll();
        Produit Create(CreateProduitInput inputProduit);
        Produit Delete(DeleteProduitInput inputProduit);
    }
}
