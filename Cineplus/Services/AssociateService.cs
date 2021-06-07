using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cineplus.Models;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cineplus.Services {
	public class AssociateService: IAssociateService {

		private IRepository<Associate> _associateRepository;
		private IUserService _userService;
		public AssociateService(IRepository<Associate> associateRepository, IUserService userService) {
			_associateRepository = associateRepository;
			_userService = userService;
		}

		public Associate GetById(int id) {
			return this._associateRepository.Data().FirstOrDefault(associate => associate.Id == id);
		}
		
		public Associate GetByCode(string code) {
			return this._associateRepository.Data().FirstOrDefault(associate => associate.Code.ToString() == code);
		}

		public Pagination<Associate> GetAll(Pagination<Associate> pagination) {
			return PaginationService.GetPagination(this._associateRepository.Data(), pagination);
		}

		public async Task<Associate> Add(Associate entity) {
			var user = await _userService.GetCurrentUser();

			if (user.Associate != null) {
				return null;
			}
			
			if (string.IsNullOrEmpty(entity.Address) ||
			    string.IsNullOrEmpty(entity.Name) ||
			    string.IsNullOrEmpty(entity.LastName) ||
			    string.IsNullOrEmpty(entity.PhoneNumber)) {
				return null;
			}

			if (!Regex.IsMatch(entity.PhoneNumber, @"\+?\d+")) {
				return null;
			}

			var associate = new Associate() {
				Id = 0,
				Address = entity.Address,
				Code = Guid.NewGuid(),
				LastName = entity.LastName,
				Name = entity.Name,
				PhoneNumber = entity.PhoneNumber,
				Points = 0,
				UserId = user.Id
			};

			return _associateRepository.Add(associate);
		}

		public Associate Update(Associate entity) {
			return _associateRepository.Update(entity);
		}

		public Associate Remove(int id) {
			return _associateRepository.Remove(id);
		}

		public async Task<Associate> GetCurrentUserAssociate() {
			var user = await _userService.GetCurrentUser();

			return user?.Associate;
		}
	}
}