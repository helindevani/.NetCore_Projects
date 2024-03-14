using Entities;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
  public class CountriesService : ICountriesService
  {
    //private field
    private readonly List<Country> _countries;

    //constructor
    public CountriesService(bool initialize=true)
    {
      _countries = new List<Country>();
      if(initialize)
      {
		 _countries.AddRange(new List<Country>() 
         { 
                new Country { CountryID = Guid.Parse("56FE9CDE-ACF5-4AA9-8CBA-AB1DCF10B2E6"), CountryName = "USA" },
                new Country { CountryID = Guid.Parse("572F5E89-040E-49B1-9321-0BC85127F101"), CountryName = "UK" },
                new Country { CountryID = Guid.Parse("2D03B94F-561C-428E-AB41-7783C91B9832"), CountryName = "Australia" },
                new Country { CountryID = Guid.Parse("CE5FEDEF-505B-45C7-8106-E7F7909BD410"), CountryName = "Denmark" },
				new Country { CountryID = Guid.Parse("ED832131-A6C7-4DDA-84DA-24A4D1E1B93D"), CountryName = "India" },
                new Country { CountryID = Guid.Parse("20C2B418-601B-4149-A4AC-CE116AFE7468"), CountryName = "USA" },
				new Country { CountryID = Guid.Parse("AEEF3A9C-8916-480D-B0D4-FC3E9685F6EF"), CountryName = "UK" },
				new Country { CountryID = Guid.Parse("CA287617-7617-4E7F-8315-138961EAD775"), CountryName = "Australia" },
				new Country { CountryID = Guid.Parse("034C4C92-09CB-4979-9B72-10A00E5DB8B2"), CountryName = "Denmark" },
				new Country { CountryID = Guid.Parse("617843EE-7DEF-419C-B7D1-D5E17A247553"), CountryName = "India" }
		  });

      }
    }

    public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
    {

      //Validation: countryAddRequest parameter can't be null
      if (countryAddRequest == null)
      {
        throw new ArgumentNullException(nameof(countryAddRequest));
      }

      //Validation: CountryName can't be null
      if (countryAddRequest.CountryName == null)
      {
        throw new ArgumentException(nameof(countryAddRequest.CountryName));
      }

      //Validation: CountryName can't be duplicate
      if (_countries.Where(temp => temp.CountryName == countryAddRequest.CountryName).Count() > 0)
      {
        throw new ArgumentException("Given country name already exists");
      }

      //Convert object from CountryAddRequest to Country type
      Country country = countryAddRequest.ToCountry();

      //generate CountryID
      country.CountryID = Guid.NewGuid();

      //Add country object into _countries
      _countries.Add(country);

      return country.ToCountryResponse();
    }

    public List<CountryResponse> GetAllCountries()
    {
      return _countries.Select(country => country.ToCountryResponse()).ToList();
    }

    public CountryResponse? GetCountryByCountryID(Guid? countryID)
    {
      if (countryID == null)
        return null;

      Country? country_response_from_list = _countries.FirstOrDefault(temp => temp.CountryID == countryID);

      if (country_response_from_list == null)
        return null;

      return country_response_from_list.ToCountryResponse();
    }
  }
}

