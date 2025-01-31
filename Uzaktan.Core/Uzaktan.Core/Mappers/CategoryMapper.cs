﻿using AutoMapper;
using Uzaktan.Core.Domain.Dto.Category;
using Uzaktan.Core.Domain.Entites;

namespace Uzaktan.Core.Mappers
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<CategoryDto, Category>();
                //.ForMember(entity => entity.Name, dto => dto.MapFrom(dto => dto.CatName));
            CreateMap<Category, CategoryDto>();

            CreateMap<CreateCategoryDto, Category>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<CategoryUpdateRequestDto, Category>();
            CreateMap<Category, CategoryUpdateRequestDto>();
        }
    }
}
