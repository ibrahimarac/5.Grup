﻿namespace Uzaktan.Core.Domain.Dto.Category
{
    public class CategoryDto:BaseDto<int>
    {
        //public string CatName { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
