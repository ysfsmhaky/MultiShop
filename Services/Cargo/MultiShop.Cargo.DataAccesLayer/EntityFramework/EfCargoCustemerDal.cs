using MultiShop.Cargo.DataAccesLayer.Abstract;
using MultiShop.Cargo.DataAccesLayer.Concrete;
using MultiShop.Cargo.DataAccesLayer.Repositoriess;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.DataAccesLayer.EntityFramework
{
    public class EfCargoCustemerDal : GenericRepositories<CargoCustomer> , ICargoCustomerDal
    {
        public EfCargoCustemerDal(CargoContext _context):base(_context)
        {
                
        }
    }
}
