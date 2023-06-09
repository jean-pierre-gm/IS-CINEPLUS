using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cineplus.Data;
using Microsoft.EntityFrameworkCore;

namespace Cineplus.Models {
	public class SqlRepository<T>: IRepository<T> where T: DbEntity {
		private ApplicationDbContext _context;
		private readonly DbSet<T> _entities;


		public SqlRepository(ApplicationDbContext context) {
			_context = context;
			_entities = _context.Set<T>();
		}

		public IQueryable<T> Data(bool tracked = true) {
			return tracked ? _entities : _entities.AsNoTracking();
		}

		public T Add(T entity) {
			if (entity == null) {
				throw new ArgumentNullException(nameof(entity));
			}
			var check = _entities.FirstOrDefault(item => item.Id == entity.Id);
			if (check is not null)
				return check;
			_entities.Add(entity);
			_context.SaveChanges();
			return entity;
		}

		public T Update(T entity) {
			if (entity == null) {
				throw new ArgumentNullException(nameof(entity));
			}
			_entities.Update(entity);
			_context.SaveChanges();
			return entity;
		}

		public IEnumerable<T> RemoveRange(IQueryable<T> query) {
			_entities.RemoveRange(query);
			try {
				_context.SaveChanges();	
			} catch (DbUpdateConcurrencyException exception) {
				
			}
			return query;
		}
		
		public T Remove(int id) {
			var entity = _entities.FirstOrDefault(t => t.Id == id);
			if (entity != null) {
				_entities.Remove(entity);
				_context.SaveChanges();
			}
			return entity;
		}

		public IEnumerable<T> UpdateAll(IEnumerable<T> entities)
		{
			foreach (var entity in entities)
			{
				_entities.Update(entity);
			}

			_context.SaveChanges();
			return entities;
		}
	}
}