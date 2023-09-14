using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;

public class ProdutosController : Controller
{
    private readonly Contexto _contexto;

    public ProdutosController(Contexto contexto)
    {
        _contexto = contexto;
    }

    public IActionResult Index()
    {
        var produtos = _contexto.Produto.ToList();
        return View(produtos);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Adicionar(Produto produto)
    {
        if (ModelState.IsValid)
        {
            _contexto.Produto.Add(produto);
            _contexto.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(produto);
    }

    public IActionResult Editar(int id)
    {
        var produto = _contexto.Produto.FirstOrDefault(p => p.Id == id);
        return View(produto);
    }

    [HttpPost]
    public IActionResult Editar(Produto produto)
    {
        if (ModelState.IsValid)
        {
            _contexto.Entry(produto).State = EntityState.Modified;
            _contexto.SaveChanges();
            return RedirectToAction("Index");
        }

       
        return View(produto);
    }

    public IActionResult Remover(int id)
    {
        var produto = _contexto.Produto.FirstOrDefault(p => p.Id == id);
        _contexto.Produto.Remove(produto);
        _contexto.SaveChanges();
        return RedirectToAction("Index");
    }
}
