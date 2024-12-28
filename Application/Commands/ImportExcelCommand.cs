using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Commands;

public class ImportExcelCommand : IRequest<bool>
{
    public IFormFile? ExcelFile { get; set; }
}
