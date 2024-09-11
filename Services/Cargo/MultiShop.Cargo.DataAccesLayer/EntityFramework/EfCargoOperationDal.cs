using MultiShop.Cargo.DataAccesLayer.Abstract;
using MultiShop.Cargo.DataAccesLayer.Concrete;
using MultiShop.Cargo.DataAccesLayer.Repositoriess;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccesLayer.EntityFramework
{
    public class EfCargoOperationDal :GenericRepositories<CargoOperation> , ICargoOperation
    {
        public EfCargoOperationDal(CargoContext context):base(context) 
        {
            
        }
    }
}
