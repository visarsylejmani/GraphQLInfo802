using GraphQLInfo802.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLInfo802.GraphQL
{
    public class ProduitType : ObjectType<Produit>
    {
        protected override void Configure(IObjectTypeDescriptor<Produit> descriptor)
        {
            descriptor.Field(x => x.ProduitID).Type<IdType>();
            descriptor.Field(x => x.VendeurID).Type<StringType>();
            descriptor.Field(x => x.Nom).Type<StringType>();
            descriptor.Field(x => x.Description).Type<StringType>();
            descriptor.Field(x => x.Prix).Type<FloatType>();
            descriptor.Field(x => x.Latitude).Type<FloatType>();
            descriptor.Field(x => x.Longitude).Type<FloatType>();
        }
    }

}
