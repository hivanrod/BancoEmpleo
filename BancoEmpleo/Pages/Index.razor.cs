using Microsoft.AspNetCore.Components;
using ClassLibraryBancoEmpleo.Interfaces;
using ClassLibraryBancoEmpleo.Models;
using BancoEmpleo.Services;
using System.Reflection.Metadata;

namespace BancoEmpleo.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject] EmpleoServices empleoServices { get; set; }

        [Parameter] public Empleo empleo { get; set; }
        [Parameter] public Empleo[] empleos { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await load();
        }
        public async Task load(int page = 1, int quantityPerPage = 1, string UsuarioId = "err56yh")
        {
            //empleos = await empleoServices.GetEmpleosTodos();

        }
    }
}
