﻿using System;
using System.Collections.Generic;
using WebAppCadeMeuJogo.Models.Entitys;

namespace WebAppCadeMeuJogo.Interfaces.Services
{
    public interface IEmprestimoValidation : IValidationBase<Emprestimo>
    {
        bool ValidarDataInicio(DateTime incio);

        bool ValidarDataFim(Emprestimo emprestimo);

        bool ValidarAmigo(int amigoId);

        bool ValidarJogosParaEmprestimo(ICollection<Jogo> jogos);
    }
}