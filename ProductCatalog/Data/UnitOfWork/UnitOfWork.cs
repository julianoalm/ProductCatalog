using ProjectCatalog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDataContext _context;

        public UnitOfWork(StoreDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Nesse caso não precisamos fazer nada, vamos deixar para o Garbage Collector entrar em ação e remover da memória.
        }
    }
}
