﻿/* https://github.com/jwaliszko/ExpressiveAnnotations
 * Copyright (c) 2014 Jarosław Waliszko
 * Licensed MIT: http://opensource.org/licenses/MIT */

using ExpressiveAnnotations.NetCore.Attributes;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ExpressiveAnnotations.NetCore.Validators
{
    /// <summary>
    ///     Model validator for <see cref="AssertThatAttribute" />.
    /// </summary>
    public class AssertThatValidator : ExpressiveValidator<AssertThatAttribute>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AssertThatValidator" /> class.
        /// </summary>
        /// <param name="metadata">The model metadata.</param>
        /// <param name="attribute">The expressive assertion attribute instance.</param>
        /// <exception cref="System.ComponentModel.DataAnnotations.ValidationException"></exception>
        public AssertThatValidator(ModelMetadata metadata, AssertThatAttribute attribute)
            : base(metadata, attribute)
        {
        }

        /// <summary>
        ///     Attaches the validation rules to the context.
        /// </summary>
        /// <returns>
        ///     void
        /// </returns>
        public void AttachValidationRules()
        {
            AttachValidationRules("assertthat");
        }
    }
}
