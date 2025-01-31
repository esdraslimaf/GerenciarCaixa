﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCaixa.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset? DateCreated { get; set; } = DateTime.Now;
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? DateTimeDeleted { get; set; }
    }
}
