using solucaDomain.Entities.Utilities;
using solucaoData.Repositories;
using solucaoDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace solucaoMaster.Controllers
{
    public class ClassificadoController : Controller
    {
        RepositoryClassificado _repositoryClassificado = new RepositoryClassificado();

        private List<ChkTela> chks = new List<ChkTela>();
        // GET: Classificado
        public ActionResult Index()
        {
            var l = _repositoryClassificado.ObterTodos();
            return View(l);
        }

        public ActionResult Detalhes(int id)
        {
            var classificado = _repositoryClassificado.ObterPorID(id);

            return View(classificado);
        }

        public ActionResult Editar(int id)
        {
            var classificado = _repositoryClassificado.ObterPorID(id);

            return View(classificado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Classificado classificado)
        {
            if (ModelState.IsValid)
            {
                _repositoryClassificado.Atualizar(classificado);
                classificado.Preco = Convert.ToDecimal(classificado.Preco);

                return RedirectToAction("Index");
            }
            
            return View(classificado);
        }

        public ActionResult Deletar() {
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmado(int id)
        {
            var classificado = _repositoryClassificado.ObterPorID(id);
            _repositoryClassificado.Remover(classificado);
            return RedirectToAction("Index");
        }

        public ActionResult Criar() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Classificado classificado) {

            _repositoryClassificado.Adicionar(classificado);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ObterLista(string json)
        {
            var serializer = new JavaScriptSerializer();
            var model = serializer.Deserialize<List<ChkTela>>(json).ToList();
            chks = model;
            //var model = new JavaScriptSerializer().Deserialize<ChkTela>(json);
            foreach (var item in chks)
            {
                RepositoryClassificado _repositoryClassificado = new RepositoryClassificado();
                var selecionado = _repositoryClassificado.ObterPorID(item.id);
                selecionado.Status = item.valor;
                _repositoryClassificado.Atualizar(selecionado);
            }
            return RedirectToAction("Index");
        }
    }
}