using clean_arch_demo_v1.Core.Entities;
using clean_arch_demo_v1.Core.Interfaces;
using MediatR;

namespace clean_arch_demo_v1.Application.Commands;

public record UpdateEmployeeCommand(Guid EmployeeId, EmployeeEntity Employee)
 : IRequest<EmployeeEntity>;
public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
    : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
{
    public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
    {
        return await employeeRepository.UpdateEmployeeAsync(request.EmployeeId, request.Employee);
    }
}
