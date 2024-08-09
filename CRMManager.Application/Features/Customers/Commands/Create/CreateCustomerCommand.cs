using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CRMManager.Application.Features.Customers.Commands.Create
{
    public record CreateCustomerCommand
   (
        string Name,
        string TaxNumber,
        string Street
    ) : IRequest;
}
