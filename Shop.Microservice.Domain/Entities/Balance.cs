﻿using Authorization.Microservice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Microservice.Domain.Common;

namespace Shop.Microservice.Domain.Entities
{
    public class Balance : BaseAuditableEntity
    {
        public Guid UserID { get; set; }
        public double Amount { get; set; }
        public double AmountForSend { get; set; }
    }
}
