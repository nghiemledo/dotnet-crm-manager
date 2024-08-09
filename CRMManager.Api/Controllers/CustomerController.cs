using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using CRMManager.Application.Features.Customers.Querries;
using CRMManager.Contracts.Requests.Customer;
using MapsterMapper;
using CRMManager.Application.Features.Customers.Commands.Create;
using CRMManager.Application.Features.Customers.Commands.Update;
using CRMManager.Application.Features.Customers.Commands.Delete;
using CRMManager.Application.Features.Customers.Querries.ListAll;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using CRMManager.Application.Features.Customers.Querries.GetById;

namespace CRMManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CustomerController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;   
            _mapper = mapper;   
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new ListAllCustomersQuery();
            var result = await _mediator.Send(query);
            return Ok(result);  
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = _mapper.Map<GetCustomerByIdQuery>(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerRequest request)
        {
            // Manually //var command = new CreateCustomerCommand(request.Name, request.TaxNumber, request.Street); 
            // Automatically map 
            var command = _mapper.Map<CreateCustomerCommand>(request);
            await _mediator.Send(command);
            return Ok(); 
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCustomerRequest request)
        {
            // Manually //var command = new CreateCustomerCommand(request.Name, request.TaxNumber, request.Street); 
            // Automatically map 
            var command = _mapper.Map<UpdateCustomerCommand>(request);
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            // Manually //var command = new CreateCustomerCommand(request.Name, request.TaxNumber, request.Street); 
            // Automatically map 
            var command = _mapper.Map<DeleteCustomerCommand>(id);
            await _mediator.Send(command);
            return Ok();
        }
    }
}
