using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class CosmosInterests
    {
        public string Title { get; set; }
        public string Interests { get; set; }

        public string SubInterest { get; set; }

    }
}
//                              ---- CONNECT / CREATE / DELETE / -- COSMOSDB -----
// (*) var connectionstring = "accountendpoint=https://ithscosmosdb.documents.azure.com:443/;accountkey=pdhyorucbffzr5dxqzgfwthjj28g2mqgplivbpiwqom88b9lfhajucvahps1qk8yghvuuqyymjxq4fm66ch7yw==;";
//(*) var client = new cosmosclientbuilder(connectionstring)
//                   .withserializeroptions(new cosmosserializationoptions
//                   {
//                       propertynamingpolicy = cosmospropertynamingpolicy.camelcase
//                   })
//                   .build();

//(*) var peoplecontainer = client.getcontainer("persondb", "personcontainer");

//if (deleteid != null)
//{
//    (*)  await peoplecontainer.deleteitemasync<models.people>(deleteid, new partitionkey(zip));
//}
//if (add == "true")
//{

//    var person = new models.people
//    {
//        id = idvalue
//        name = firstnamevalue + secondnamevalue
//        age = agevalue
//        address = new models.address
//        {
//            city = cityvalue
//            zipcode = zipvalue.tostring()
//        }
//    };

//    (*) await peoplecontainer.createitemasync(person);
//}
