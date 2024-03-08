<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using ModelValidationExample.Models;

namespace ModelValidationsExample.CustomModelBinders
{
    public class PersonBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(Person))
            {
                return new BinderTypeModelBinder(typeof(PersonModelBinder));
            }
            return null;
        }
    }
=======
﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using ModelValidationExample.Models;

namespace ModelValidationsExample.CustomModelBinders
{
    public class PersonBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(Person))
            {
                return new BinderTypeModelBinder(typeof(PersonModelBinder));
            }
            return null;
        }
    }
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
}