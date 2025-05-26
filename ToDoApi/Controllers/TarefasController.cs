using Microsoft.AspNetCore.Mvc;
using ToDoApi.Models;

namespace ToDoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TarefasController : ControllerBase
{
    private static List<Tarefa> tarefas = new();
    private static int nextId = 1;

    [HttpGet]
    public IActionResult Get() => Ok(tarefas);

    [HttpPost]
    public IActionResult Post([FromBody] Tarefa tarefa)
    {
        tarefa.Id = nextId++;
        tarefa.Concluida = false;
        tarefa.Status = tarefa.Status ?? "afazer";
        tarefas.Add(tarefa);
        return CreatedAtAction(nameof(Get), new { id = tarefa.Id }, tarefa);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Tarefa update)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null) return NotFound();

        // Atualiza apenas o campo concluida, se enviado
        if (update.Concluida != tarefa.Concluida)
            tarefa.Concluida = update.Concluida;

        return NoContent();
    }

    [HttpPut("{id}/mover")]
    public IActionResult Mover(int id, [FromBody] Tarefa update)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null) return NotFound();

        if (!string.IsNullOrEmpty(update.Status))
            tarefa.Status = update.Status;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null) return NotFound();

        tarefas.Remove(tarefa);
        return NoContent();
    }
}

// Não esqueça de adicionar o campo Status no seu modelo Tarefa:
public class Tarefa
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public bool Concluida { get; set; }
    public string? Status { get; set; } // "afazer", "progresso", "concluido"
}
