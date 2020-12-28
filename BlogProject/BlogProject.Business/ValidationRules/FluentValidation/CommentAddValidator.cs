﻿using BlogProject.DTO.DTOs.CommentDtos;
using FluentValidation;

namespace BlogProject.Business.ValidationRules.FluentValidation
{
    public class CommentAddValidator : AbstractValidator<CommentAddDto>
    {
        public CommentAddValidator()
        {
            RuleFor(I => I.AuthorName).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");
            RuleFor(I => I.AuthorEmail).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");

            RuleFor(I => I.Description).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");

        }
    }
}
