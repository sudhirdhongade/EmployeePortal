using EmployeePortal.Models;

namespace EmployeePortal.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int id);
        Task<IEnumerable<Employee>> SearchAsync(string? department, decimal? minSalary, decimal? maxSalary);
    }
}
