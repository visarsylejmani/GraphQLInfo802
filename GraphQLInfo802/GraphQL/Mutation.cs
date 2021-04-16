using GraphQLInfo802.IServices;
using GraphQLInfo802.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLInfo802.GraphQL
{
    public class Mutation
    {
        private readonly IProduitService _produitService;

        public Mutation(IProduitService produitService)
        {
            _produitService = produitService;
        }

        public Produit CreateProduit(CreateProduitInput inputProduit)
        {
            return _produitService.Create(inputProduit);
        }

        public Produit DeleteProduit(DeleteProduitInput inputProduit)
        {
            return _produitService.Delete(inputProduit);
        }
    }
}
