﻿using RestaurantReviews.Data.Interfaces;
using System;

namespace RestaurantReviews.Data.Extensions
{
    public static class IEntityExtensions
    {
        public static bool IsObjectNull(this IEntity entity)
        {
            return entity == null;
        }

        public static bool IsEmptyObject(this IEntity entity)
        {
            return entity.Id.Equals(Guid.Empty);
        }
    }
}
