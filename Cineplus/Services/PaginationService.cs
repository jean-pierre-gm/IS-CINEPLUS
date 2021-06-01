using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cineplus.Models;
using System.Linq.Dynamic.Core;

namespace Cineplus.Services {
	public static class PaginationService {

		public static Pagination<T> GetPagination<T>(IQueryable<T> query, Pagination<T> pagination) {
			return GetPagination(query, pagination.CurrentPage, pagination.OrderBy, pagination.OrderByDesc,
				pagination.PageSize, pagination.FilerBy, pagination.FilerString);
		}
		
		public static Pagination<T> GetPagination<T>(IQueryable<T> query, int page = 1, string orderBy = null, bool orderByDesc = false,
			int pageSize = 10, string filterBy = null, string filterString = "") {

			page = page < 1 ? 1 : page;
			pageSize = pageSize < 1 ? 10 : pageSize;
			
			Pagination<T> pagination = new Pagination<T>() {
				TotalItems = query.Count(),
				PageSize = pageSize,
				CurrentPage = page,
				OrderBy = orderBy,
				OrderByDesc = orderByDesc,
				TotalPages = (int) Math.Ceiling(query.Count() * 1.0 / pageSize)
			};

			int skip = (page - 1) * pageSize;
			var props = typeof(T).GetProperties();

			if (orderBy != null) {

				var orderByProperty =
					props.FirstOrDefault(n => n.GetCustomAttribute<SortableAttribute>()?.OrderBy == orderBy);

				if (orderByProperty == null) {
					throw new Exception($"Field: '{orderBy}' is not sortable");
				}

				var orderStr = orderByDesc ? "descending" : "ascending";

				query = query.OrderBy($"{orderByProperty.Name} {orderStr}");
			}

			if (!string.IsNullOrEmpty(filterBy) && !string.IsNullOrEmpty(filterString)) {
				var filterByProperty =
					props.FirstOrDefault(n => n.GetCustomAttribute<FilterAttribute>()?.FilterBy == filterBy);
			
				if (filterByProperty == null) {
					throw new Exception($"Field: '{filterBy}' is not sortable");
				}

				query = query.Where(filterByProperty.Name + ".Contains(@0)", filterString);
			}

			pagination.Result = query
				.Skip(skip)
				.Take(pageSize)
				.ToList();

			return pagination;
		}
	}
}