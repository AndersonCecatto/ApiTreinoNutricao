﻿using ApiTreinoNutricao.Domain.Common;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Empresa : BaseEntity
    {
        public string? Nome { get; set; }
        public string? CpfCnpj { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
    }
}
