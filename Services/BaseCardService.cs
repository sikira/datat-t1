using DataTalksFrontendExercise.Dto;

namespace DataTalksFrontendExercise.Services
{
    public class BaseCardService : IBaseCardService
    {

        private string text_Helper = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Metus aliquam eleifend mi in nulla posuere sollicitudin. Consectetur adipiscing elit pellentesque habitant morbi tristique. Nunc vel risus commodo viverra maecenas accumsan lacus vel. Montes nascetur ridiculus mus mauris vitae ultricies leo. Fames ac turpis egestas sed tempus urna. Urna condimentum mattis pellentesque id. Tristique nulla aliquet enim tortor. Et tortor consequat id porta. Duis convallis convallis tellus id interdum velit laoreet id donec. Nulla aliquet enim tortor at auctor urna nunc. Non arcu risus quis varius quam quisque. Sollicitudin aliquam ultrices sagittis orci a. Vulputate sapien nec sagittis aliquam. Aliquam sem fringilla ut morbi tincidunt augue interdum velit euismod. Consectetur purus ut faucibus pulvinar elementum. Lorem ipsum dolor sit amet.";

        public BaseCardService() { }

        public async Task Delete(int id)
        {

        }

        public async Task Dismiss(int id)
        {

        }

        public async Task Copy(int id)
        {

        }


        public List<BaseCardModel> GetList()
        {
            var r = new Random();
            var res = new List<BaseCardModel>();
            var elemntLen = r.Next(10, 40);

            for (int i = 0; i < elemntLen; i++)
            {
                var type = r.Next(i, 100);
                if (type < 30)
                    res.Add(GetLoremIpsumModelShort);
                else if (type < 50)
                    res.Add(GetLoremIpsumModelLong);
                else
                    res.Add(GetLoremIpsumModel);
            }

            return res;
        }


        public BaseCardModel GetLoremIpsumModelShort => new BaseCardModel()
        {
            Title = "Short title",
            Description = $"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Metus aliquam eleifend mi in nulla posuere sollicitudin. Consectetur adipiscing elit pellentesque habitant morbi tristique. Nunc vel risus commodo viverra maecenas accumsan lacus vel. ",
            Icon = ""
        };


        public BaseCardModel GetLoremIpsumModel => new BaseCardModel()
        {
            Title = "This is a card's title",
            Description = $"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Metus aliquam eleifend mi in nulla posuere sollicitudin. Consectetur adipiscing elit pellentesque habitant morbi tristique. Nunc vel risus commodo viverra maecenas accumsan lacus vel. Montes nascetur ridiculus mus mauris vitae ultricies leo. Fames ac turpis egestas sed tempus urna. Urna condimentum mattis pellentesque id. Tristique nulla aliquet enim tortor. Et tortor consequat id porta. Duis convallis convallis tellus id interdum velit laoreet id donec. Nulla aliquet enim tortor at auctor urna nunc. Non arcu risus quis varius quam quisque. Sollicitudin aliquam ultrices sagittis orci a. Vulputate sapien nec sagittis aliquam. Aliquam sem fringilla ut morbi tincidunt augue interdum velit euismod. Consectetur purus ut faucibus pulvinar elementum. Lorem ipsum dolor sit amet.",
            Icon = ""
        };

        public BaseCardModel GetLoremIpsumModelLong => new BaseCardModel()
        {
            Title = "This is a card's title as long as it can get, so there can be large number of chars in here!Lorem ipsum dolor sit amet, consectetur adipiscing elitLorem ipsum dolor sit amet, consectetur adipiscing elit",
            Description = $"{text_Helper}|{text_Helper}Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Metus aliquam eleifend mi in nulla posuere sollicitudin. Consectetur adipiscing elit pellentesque habitant morbi tristique. Nunc vel risus commodo viverra maecenas accumsan lacus vel. Montes nascetur ridiculus mus mauris vitae ultricies leo. Fames ac turpis egestas sed tempus urna. Urna condimentum mattis pellentesque id. Tristique nulla aliquet enim tortor. Et tortor consequat id porta. Duis convallis convallis tellus id interdum velit laoreet id donec. Nulla aliquet enim tortor at auctor urna nunc. Non arcu risus quis varius quam quisque. Sollicitudin aliquam ultrices sagittis orci a. Vulputate sapien nec sagittis aliquam. Aliquam sem fringilla ut morbi tincidunt augue interdum velit euismod. Consectetur purus ut faucibus pulvinar elementum. Lorem ipsum dolor sit amet.",
            //Icon = "https://picsum.photos/200/300",
            Icon = "https://picsum.photos/seed/picsum/200/300"
        };



    }
}
