using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface ICountriesService
    {

    CountryResponse AddCountry(CountryResponse? 
        countryResponse);
    }
}
