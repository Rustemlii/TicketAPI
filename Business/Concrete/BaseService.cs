using AutoMapper;
using Business.Abstract;
using DataAccess.MyContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaseService<Send,T,Bring>:IBase<Send,T,Bring>where T : class
    {
        protected readonly IMapper _mapper;
        protected readonly Context _context;
        protected readonly DbSet<T> _dbSet;

        public BaseService(IMapper mapper, Context context)
        {
            _mapper = mapper;
            _context = context;
            _dbSet=_context.Set<T>();
        }

        public virtual void Delete(int id)
        {
            var values = _dbSet.Find(id);
            _dbSet.Remove(values);  
            _context.SaveChanges();         
        }

        public virtual List<Bring> GetAll()
        {
            var values = _dbSet.ToList();
            var bringDto=_mapper.Map<List<Bring>>(values);
            return bringDto;
        }

        public virtual Bring GetbyId(int id)
        {
            var values=_dbSet.Find(id);
            var bringDto=_mapper.Map<Bring>(values);
            return bringDto;
        }

        public virtual Bring Insert(Send dto)
        {
            var values = _mapper.Map<T>(dto);
            _dbSet.Add(values);
            _context.SaveChanges();

            var bringDto = _mapper.Map<Bring>(values);
            return bringDto;
        }

        public virtual void Update(Send dto)
        {
          var values=_mapper.Map<T>(dto);
            _dbSet.Update(values);
            _context.SaveChanges();
        }
    }
}
