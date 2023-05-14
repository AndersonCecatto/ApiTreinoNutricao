﻿using ApiTreinoNutricao.Domain.Common;
using ApiTreinoNutricao.Domain.Dto;

namespace ApiTreinoNutricao.Domain.Entities
{
    public class Treino : BaseEntity
    {
        public Treino() { }

        public Treino(TreinoDto treinoDto)
        {
            Id = treinoDto.Id;
            Descricao = treinoDto.Descricao;
            UsuarioId = treinoDto.UsuarioId;
            EmpresaId = treinoDto.EmpresaId;
            Ativo = treinoDto.Ativo;
        }

        public string? Descricao { get; set; }
        public long? UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
