using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllAsync();

        Task<CustomerDto?> GetByIdAsync(int id);

        Task<CustomerDto> CreateAsync(CreateCustomerDto dto);

        Task<bool> UpdateAsync(int id, CreateCustomerDto dto);

        Task<bool> DeleteAsync(int id);
    }
}
