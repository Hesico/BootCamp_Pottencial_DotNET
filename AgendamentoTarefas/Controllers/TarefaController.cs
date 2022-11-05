using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AgendamentoTarefas.Models;
using AgendamentoTarefas.Context;

namespace AgendamentoTarefas.Controllers;

public class TarefaController : Controller
{

    private readonly TarefaContext _context;

    public TarefaController(TarefaContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var tarefas = _context.Tarefas.ToList();
        return View(tarefas);
    }

    [HttpPost]
    public IActionResult Criar(Tarefa tarefa)
    {

        if (ModelState.IsValid)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpGet("ObterTodos")]
    public IActionResult ObterTodos()
    {
        return RedirectToAction("Index");
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        var tarefa = _context.Tarefas.Find(id);
        if(tarefa == null) return RedirectToAction(nameof(Index));

        return View(tarefa);
    }

    //[HttpGet("ObterPorTitulo")]
    public IActionResult ObterPorTitulo(string titulo)
    {
        var tarefas = new List<Tarefa>();

        if(titulo == null){
            tarefas = _context.Tarefas.ToList();
        }else{
            tarefas = _context.Tarefas.Where(x => x.Titulo.Contains(titulo)).ToList();
        }
        
        return View(tarefas);
    }

    public IActionResult ObterPorData(DateTime data)
    {
        var tarefas = new List<Tarefa>();

        if(data == DateTime.MinValue){
            tarefas = _context.Tarefas.ToList();
        }else{
            tarefas = _context.Tarefas.Where(x => x.Data.Date == data.Date).ToList();
        }
        
        return View(tarefas);
    }

    public IActionResult ObterPorStatus(EnumStatusTarefa? status)
    {
        var tarefas = new List<Tarefa>();

        if(status == null){
            tarefas = _context.Tarefas.ToList();
        }else{
            tarefas = _context.Tarefas.Where(x => x.Status == status).ToList();
        }
        
        return View(tarefas);
    }

    [HttpGet("Atualizar")]
    public IActionResult Atualizar(int id)
    {
        var tarefa =  _context.Tarefas.Find(id);
        if(tarefa == null) return RedirectToAction(nameof(Index));

        return View(tarefa);
    }

    [HttpPost("Atualizar")]
    public IActionResult Atualizar(Tarefa tarefa)
    {
        var tarefaBanco = _context.Tarefas.Find(tarefa.Id);

        if (tarefaBanco == null)
            return NotFound();

        if (tarefa.Data == DateTime.MinValue)
            return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

        tarefaBanco.Titulo = tarefa.Titulo;
        tarefaBanco.Descricao = tarefa.Descricao;
        tarefaBanco.Data = tarefa.Data;
        tarefaBanco.Status = tarefa.Status;

        _context.Tarefas.Update(tarefaBanco);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Deletar(int id)
    {

        var tarefa = _context.Tarefas.Find(id);

        if (tarefa == null) return NotFound();

        _context.Tarefas.Remove(tarefa);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
