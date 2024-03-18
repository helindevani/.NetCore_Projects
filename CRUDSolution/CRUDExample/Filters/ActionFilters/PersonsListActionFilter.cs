﻿using Microsoft.AspNetCore.Mvc.Filters;
using ServiceContracts.DTO;

namespace CRUDExample.Filters.ActionFilters
{
 public class PersonsListActionFilter : IActionFilter
 {
  private readonly ILogger<PersonsListActionFilter> _logger;

  public PersonsListActionFilter(ILogger<PersonsListActionFilter> logger)
  {
   _logger = logger;
  }

  public void OnActionExecuted(ActionExecutedContext context)
  {
   //To do: add after logic here
   _logger.LogInformation("PersonsListActionFilter.OnActionExecuted method");
  }

  public void OnActionExecuting(ActionExecutingContext context)
  {
   //To do: add before logic here
   _logger.LogInformation("PersonsListActionFilter.OnActionExecuting method");

            if (context.ActionArguments.ContainsKey("searchBy"))
            {
                string? searchBy = Convert.ToString(context.ActionArguments["searchBy"]);

                if (string.IsNullOrEmpty(searchBy))
                {
                    var searchByOptions = new List<string>()                    {
                        nameof(PersonResponse.PersonName),
                         nameof(PersonResponse.Email),
                          nameof(PersonResponse.DateOfBirth),
                          nameof(PersonResponse.Gender),
                          nameof(PersonResponse.CountryID),
                          nameof(PersonResponse.Address),
                    };

                    if(searchByOptions.Any(temp => temp == searchBy)==false) {

                        _logger.LogInformation("searchBY Actual Value {searchby}", searchBy);
                        context.ActionArguments["searchby"] = nameof(PersonResponse.PersonName);
                        _logger.LogInformation("searchBY updated Value {searchby}", searchBy);

                    }
                }
            }
  }
 }
}
