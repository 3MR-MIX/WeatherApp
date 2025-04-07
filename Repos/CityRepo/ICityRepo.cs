using WeatherApp.DTOs.City;

namespace WeatherApp.Repos.CityRepo
{
    public interface ICityRepo
    {
        List<CityResponseDto> GetAllCities();
        CityResponseDto GetCityById(int id);
        bool AddCity(CityRequestDto cityRequestDto);


    }
}
