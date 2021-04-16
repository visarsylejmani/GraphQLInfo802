using GraphQLInfo802.IServices;
using GraphQLInfo802.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLInfo802.GraphQL
{
    public class Query
    {
        private readonly IProduitService _produitService;

        public Query(IProduitService produitService)
        {
            _produitService = produitService;
        }
        [UsePaging]
        [UseFiltering]
        public IQueryable<Produit> Produits => _produitService.GetAll();
    }
}
