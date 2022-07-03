using AutoMapper;

namespace Warsztat_v2.Automapper
{
    public class MapperFactory
    {
        public IMapper Create(Profile profile)
        {
            var configuration = new MapperConfiguration(expression => expression.AddProfile(profile));
            return new Mapper(configuration).ConfigurationProvider.CreateMapper();
        }
    }
}
