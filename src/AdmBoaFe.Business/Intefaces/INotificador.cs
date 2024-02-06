﻿using AdmBoaFe.Business.Notificacoes;

namespace AdmBoaFe.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}