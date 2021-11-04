﻿using System;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.ValueObjects
{
    public class NonNegativeQuantity : ValueObject<int>
    {
        public NonNegativeQuantity(int value) : base(value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                    $"{nameof(value)} of {nameof(NonNegativeQuantity)} must not be less than zero");
        }
    }
}