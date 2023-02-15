using DataTalksFrontendExercise.Dto;
using Microsoft.AspNetCore.Components;

namespace DataTalksFrontendExercise.Components
{

    public partial class BaseCard : ComponentBase
    {
        [Parameter]
        public BaseCardModel? BaseCardModel { get; set; }

        [Parameter]
        public string? HolderClass { get; set; }

        [Parameter]
        public string? HolderStyle { get; set; }


        // If I were to use blazor @onclick to toggle the menu 
        //private bool submenuCollapsed = true;
        //private string submenuStyle => submenuCollapsed ? "display:none;" : "";
        //private string submenuBtnStateClass => submenuCollapsed ? "" : "openClassToChageBtn";
        //private void MenuToggle() => submenuCollapsed = !submenuCollapsed;


        private async Task OnDismiss()
        {
            // I assume that the action will be async
            await Task.CompletedTask;
            Console.WriteLine($"Dismis card with id:{BaseCardModel?.Id}");
        }

        private async Task OnDelete()
        {
            // I assume that the action will be async
            await Task.CompletedTask;
            Console.WriteLine($"Delete card with id:{BaseCardModel?.Id}");
        }

        private async Task OnDuplicate()
        {
            // I assume that the action will be async
            await Task.CompletedTask;
            Console.WriteLine($"Duplicate card with id:{BaseCardModel?.Id}");
        }




    }
}
