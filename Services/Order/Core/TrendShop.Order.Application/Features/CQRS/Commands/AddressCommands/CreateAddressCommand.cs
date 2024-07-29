﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendShop.Order.Application.Features.CQRS.Commands.AddressCommands
{
    public class CreateAddressCommand
    {
        public string UserID { get; set; }
        public string District { get; set; } // Şehir bilgisi
        public string City { get; set; }
        public string Detail { get; set; }
    }
}
