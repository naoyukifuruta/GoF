
namespace Framework
{
    public abstract class Factory
    {
        protected abstract Product CreateProduct(string owner);

        protected abstract void RegisterProduct(Product product);

        public Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);

            return p;
        }
    }
}
