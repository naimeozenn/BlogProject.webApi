﻿using BlogProject.DTO.DTOs.CategoryDtos;
using FluentValidation;

namespace BlogProject.Business.ValidationRules.FluentValidation
{
    public class CategoryAddValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        }
    }
}
