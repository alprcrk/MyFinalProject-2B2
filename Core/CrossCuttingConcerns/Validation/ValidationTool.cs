﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate (IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            //  ProductValidator productValidator = new ProductValidator(); // Validate(IValidator validator) ile bu satıra ihtiyaç kalmadı sildik
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
