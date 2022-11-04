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
        var tarefas =  _context.Tarefas.ToList();
        return View(tarefas);
    }

    public IActionResult ObterTodos()
    {
        var tarefas =  _context.Tarefas.ToList();
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Index(Tarefa tarefa){
        
        if(ModelState.IsValid){
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpGet("{id}")]
    public IActionResult Index(int id)
    {
        List<Tarefa> tarefa = new List<Tarefa>();

        tarefa.Add(_context.Tarefas.Find(id));
        
        return View(tarefa);
    }

    public IActionResult Deletar(Tarefa tarefa){

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
