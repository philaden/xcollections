﻿using Softmax.XCollections.Data.Contracts.Validations;
using Softmax.XCollections.Data.Entities;
using Softmax.XCollections.Extensions;
using Softmax.XCollections.Models;

namespace Softmax.XCollections.Services.Validations
{
    public class RefundValidation : IRefundValidation
    {
        private ValidationResult validationResult;
        
        public ValidationResult ValidateCreate(RefundModel model)
        {
            this.validationResult = new ValidationResult();

            if (model == null)
            {
                this.validationResult.AddErrorMessage(ResourceDesignation.Invalid_Designation);
                return this.validationResult;
            }

            this.ValidateName(model.EmployeeId);

            return this.validationResult;
        }

        public ValidationResult ValidateUpdate(RefundModel model)
        {
            this.validationResult = new ValidationResult();

            if (model == null)
            {
                this.validationResult.AddErrorMessage(ResourceDesignation.Invalid_Designation);
                return this.validationResult;
            }

            this.ValidateName(model.EmployeeId);

            return this.validationResult;
        }

        private void ValidateName(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                this.validationResult.AddErrorMessage(ResourceDesignation.Invalid_Designation);
            }
        }
    }
}
