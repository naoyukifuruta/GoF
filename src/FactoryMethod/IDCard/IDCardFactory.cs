using System.Collections.Generic;
using Framework;

namespace IDCard
{
    public class IDCardFactory : Factory
    {
        private List<string> Owners { get; set; } = new List<string>();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            Owners.Add(((IDCard)product).Owner);
        }
    }
}
