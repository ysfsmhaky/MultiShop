using MultiShop.Cargo.DataAccesLayer.Abstract;
using MultiShop.Cargo.DataAccesLayer.Concrete;
using MultiShop.Cargo.DataAccesLayer.Repositoriess;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.DataAccesLayer.EntityFramework
{
    public class EfCargoCompanyDal:GenericRepositories<CargoCompany>,ICargoCompanyDal
    {
        public EfCargoCompanyDal(CargoContext context) : base(context) 
        {
            
        }
    }
}
