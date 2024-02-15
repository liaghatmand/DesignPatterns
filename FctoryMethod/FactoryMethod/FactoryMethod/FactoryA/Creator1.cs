using FactoryMethod.Creators;
using FactoryMethod.MainFactory;
namespace FactoryMethod.FactoryA
{
    internal class Creator1 : Creator
    {
        //creates ProductA
        public override IProduct FactoryMethod()
        {
            return new ProductA();
        }
    }
}
