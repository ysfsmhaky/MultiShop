using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccesLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoOperationManager : IGenericService<CargoOperation>
    {
        private readonly ICargoOperation _cargoOperation;

        public CargoOperationManager(ICargoOperation cargoOperation)
        {
            _cargoOperation = cargoOperation;
        }

        public void TDelete(int id)
        {
            _cargoOperation.Delete(id);
        }

        public List<CargoOperation> TGetAll()
        {
            return _cargoOperation.GetAll();    
        }

        public CargoOperation TGetById(int id)
        {
            return _cargoOperation.GetById(id); 
        }

        public void TInsert(CargoOperation entity)
        {
            _cargoOperation.Insert(entity);
        }

        public void TUpdate(CargoOperation entity)
        {
            _cargoOperation.Update(entity);
        }
    }
}
