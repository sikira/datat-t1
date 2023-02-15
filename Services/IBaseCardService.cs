using DataTalksFrontendExercise.Dto;

namespace DataTalksFrontendExercise.Services
{
    public interface IBaseCardService
    {
        BaseCardModel GetLoremIpsumModel { get; }
        BaseCardModel GetLoremIpsumModelLong { get; }
        BaseCardModel GetLoremIpsumModelShort { get; }

        Task Duplicate(int id);
        Task Delete(int id);
        Task Dismiss(int id);
        List<BaseCardModel> GetList();
    }
}