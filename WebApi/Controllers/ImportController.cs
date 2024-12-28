using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Commands;

[Route("api/[controller]")]
[ApiController]
public class ImportController : ControllerBase
{
    private readonly IMediator _mediator;

    public ImportController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("import")]
    public async Task<IActionResult> ImportExcel([FromForm] IFormFile excelFile)
    {
        var result = await _mediator.Send(new ImportExcelCommand { ExcelFile = excelFile });
        return result ? Ok("Planilha importada com sucesso.") : BadRequest("Erro ao importar a planilha.");
    }
}
