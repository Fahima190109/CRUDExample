using Entities;
using ServiceContracts;
using ServiceContracts.DTO;
using Services;

namespace CRUDTests
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService 
            _countriesServic;
        private CountriesService _countriesService;
        
        //Constructor
        public CountriesServiceTest()
        {
            _countriesService = new CountriesService();

        }
        #region AddCountry
        // When CountryAddRequest is null
        [Fact]
        public void AddCountry_NullCountry()
        {
            CountryAddRequest request = null;
            Assert.Throws<ArgumentNullException>(()
                => _countriesService.AddCountry(request));
        }
        //When countryname is null
        [Fact]
        public void AddCountry_NullCountryName()
        {
            CountryAddRequest? request = new CountryAddRequest
            {
                CountryName = null
            };
            Assert.Throws<ArgumentException>(()
                => _countriesService.AddCountry(request));
        }
        //When countryname is duplicate 
        [Fact]
        public void AddCountry_duplicateCountry()
        {
            CountryAddRequest? request1 = new CountryAddRequest
            {
                CountryName = "Bangladesh"
            };
            CountryAddRequest? request2 = new CountryAddRequest
            {
                CountryName = "Bangladesh"
            };
            Assert.Throws<ArgumentException>(()
                =>
            {
                _countriesService.AddCountry(request1);
                _countriesService.AddCountry(request2);
            });
        }
        //have a whole property of country
        [Fact]
        //Arrange
        public void AddCountry_ProperCountryDetails()
        {
            CountryAddRequest? request = new CountryAddRequest()
            {
                CountryName = "America"
            };

            //Act
            CountryResponse response = _countriesService.AddCountry(request);
            Assert.True(response.CountryID != Guid.Empty);
        }
        #endregion

        #region GetAllCountries
        [Fact]
        //the list of countries should be empty blyl default(before adding any countries)
        public void GetAllCountries_

    }

}
