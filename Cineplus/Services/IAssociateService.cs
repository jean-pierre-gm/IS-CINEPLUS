using System.Threading.Tasks;
using Cineplus.Models;

namespace Cineplus.Services {
	public interface IAssociateService {
		Associate GetById(int id);
		Associate GetByCode(string code);
		Pagination<Associate> GetAll(Pagination<Associate> pagination);
		Task<Associate> Add(Associate entity);
		Associate Update(Associate entity);
		Associate Remove(int id);
		Task<Associate> GetCurrentUserAssociate();
	}
}