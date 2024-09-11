using MultiShop.Cargo.DataAccesLayer.Abstract;
using MultiShop.Cargo.DataAccesLayer.Concrete;

namespace MultiShop.Cargo.DataAccesLayer.Repositoriess
{
    public class GenericRepositories<T> : IGenericDal<T> where T : class
    {
        private readonly CargoContext _context;

        public GenericRepositories(CargoContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var values = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(values);
            _context.SaveChanges();
          
        }

        public T GetById(int id)
        {
            var values = _context.Set<T>().Find(id);
            return values;
        }

        public List<T> GetAll()
        {
            var values = _context.Set<T>().ToList();
            return values;
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
           _context.Set<T>().Update(entity);
           _context.SaveChanges();

        }
    }
}
