using DataTalksFrontendExercise.Dto;
using DataTalksFrontendExercise.Services;
using Microsoft.AspNetCore.Components;

namespace DataTalksFrontendExercise.Components
{

    public partial class BaseCard : ComponentBase
    {
        [Inject]
        private IBaseCardService baseCardService { get; set; } = null!;

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
            if (BaseCardModel?.Id > 0)
                await baseCardService.Dismiss(BaseCardModel.Id);
        }

        private async Task OnDelete()
        {
            if (BaseCardModel?.Id > 0)
                await baseCardService.Delete(BaseCardModel.Id);
        }

        private async Task OnDuplicate()
        {
            if (BaseCardModel?.Id > 0)
                await baseCardService.Duplicate(BaseCardModel.Id);
        }




    }
}
