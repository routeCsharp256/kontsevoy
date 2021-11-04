﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.Enumerations
{
    public class MerchType : Enumeration
    {
        private static readonly Dictionary<int, MerchType> Registered = new();

        public static MerchType GetById(int id)
        {
            if (!Registered.ContainsKey(id))
                throw new ArgumentException($"Invalid {nameof(id)} for {nameof(MerchType)}: value = {id}", nameof(id));
            return Registered[id];
        }
        
        public static readonly MerchType TShirt = new(1, nameof(TShirt), MerchKind.Clothing);
        public static readonly MerchType Sweatshirt = new(2, nameof(Sweatshirt), MerchKind.Clothing);
        public static readonly MerchType Notepad = new(3, nameof(Notepad), MerchKind.Accessory);
        public static readonly MerchType Bag = new(4, nameof(Bag), MerchKind.Accessory);
        public static readonly MerchType Pen = new(5, nameof(Pen), MerchKind.Accessory);
        public static readonly MerchType Socks = new(6, nameof(Socks), MerchKind.Clothing);
        
        public MerchKind Kind { get; }

        private MerchType(int id, string name, [NotNull] MerchKind kind) : base(id, name)
        {
            Kind = kind;
            Registered[id] = this;
        }
    }
}