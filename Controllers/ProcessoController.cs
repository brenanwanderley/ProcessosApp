using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProcessosApp.Contexts;
using ProcessosApp.Models;
using ProcessosApp.Data.DataTransferObjects;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProcessosApp.Services;

namespace ProcessosApp.Controllers
{
    public class ProcessoController : Controller
    {
        private readonly ProcessosContext _context;
        private readonly IBGEService _ibgeService;

        public ProcessoController(ProcessosContext context, IBGEService ibgeService)
        {
            _context = context;
            _ibgeService = ibgeService;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Controle de Processos";
            var processos = _context.Processos.ToList();
            return View(processos);
        }

        public async Task<IActionResult> Create()
        {
            ViewData["Title"] = "Novo Processo";

            // Obtendo a lista de estados para o dropdown
            var estados = await _ibgeService.GetEstadosAsync();
            ViewBag.Estados = new SelectList(estados, "Sigla", "Sigla");

            // Inicializando a lista de municípios (vazia inicialmente)
            ViewBag.Municipios = new SelectList(new List<MunicipioDto>(), "Id", "Nome");

            return View("Form");
        }

        [HttpPost]
        public IActionResult Create(ProcessoDto processoDto)
        {
            if (ModelState.IsValid)
            {
                var processo = new Processo
                {
                    DataCadastro = DateTime.Now,
                    NomeProcesso = processoDto.NomeProcesso,
                    Npu = processoDto.Npu,
                    EstadoSigla = processoDto.EstadoSigla,
                    MunicipioId = processoDto.MunicipioId
                };

                _context.Processos.Add(processo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["Title"] = "Novo Processo";
            return View("Form", processoDto);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var processo = _context.Processos.Find(id);
            ViewData["Title"] = "Visualizar Processo";

            // Obtendo a lista de estados para o dropdown
            var estados = await _ibgeService.GetEstadosAsync();
            ViewBag.Estados = new SelectList(estados, "Sigla", "Sigla");

            // Obtendo o município selecionado para o processo
            var municipio = processo.MunicipioId != null
                ? await _ibgeService.GetMunicipioAsync(processo.MunicipioId)
                : new MunicipioDto();

            // Criando uma lista com o município selecionado
            var municipios = new List<MunicipioDto>();
            if (municipio != null && municipio.Id != 0)
            {
                municipios.Add(municipio);
            }

            // Criando o SelectList para os municípios
            ViewBag.Municipios = new SelectList(municipios, "Id", "Nome", processo.MunicipioId);

            return View("Form", processo);
        }

        [HttpPost]
        public IActionResult Edit(Processo processo)
        {
            if (ModelState.IsValid)
            {
                _context.Processos.Update(processo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Title"] = "Visualizar Processo";
            return View("Form", processo);
        }

        public IActionResult Delete(int id)
        {
            var processo = _context.Processos.Find(id);
            ViewData["Title"] = "Excluir Processo";
            return View(processo);
        }

        [HttpPost]
        public IActionResult Delete(Processo processo)
        {
            _context.Processos.Remove(processo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Ação para buscar os municípios quando um estado for selecionado
        [HttpGet]
        public async Task<IActionResult> GetMunicipiosPorEstado(string siglaEstado)
        {
            var municipios = await _ibgeService.GetMunicipiosAsync(siglaEstado);
            return Json(municipios);
        }


        [HttpPost]
        public IActionResult ConfirmarVisualizacao(int id)
        {
            var processo = _context.Processos.FirstOrDefault(p => p.Id == id);
            if (processo == null)
            {
                return NotFound();
            }

            processo.DataVisualizacao = DateTime.Now;
            _context.SaveChanges();

            return Json(new { success = true });
        }

    }
}
