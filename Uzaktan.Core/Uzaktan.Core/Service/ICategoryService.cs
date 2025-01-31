﻿using System.Collections.Generic;
using Uzaktan.Core.Domain.Dto.Category;
using Uzaktan.Core.Utilities.Results;

namespace Uzaktan.Core.Service
{
    public interface ICategoryService
    {
        IResult AddCategory(CreateCategoryDto categoryDto);
        IResult DeleteCategory(int categoryId);
        IResult UpdateCategory(CategoryUpdateRequestDto categoryDto,int id);
        IResult GetAllCategories();
        IResult GetCategoryById(int id);
    }
}
