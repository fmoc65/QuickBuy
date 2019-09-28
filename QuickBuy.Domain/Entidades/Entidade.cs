using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entidades
{
    public abstract class Entidade
    {
        public List<string> _menssagensValidacao { get; set; }

        protected List<string> MenssagemValidacao
        {
            get { return _menssagensValidacao ?? (_menssagensValidacao = new List<string>()); }
        }

        protected void LimparMenssagemValidacao()
        {
            MenssagemValidacao.Clear();
        }

        protected void AdicionarCritica(string menssagem)
        {
            MenssagemValidacao.Add(menssagem);
        }
        public abstract void Validate();
        protected bool EhValidado
        {
            get { return !MenssagemValidacao.Any(); }
        }
    }
}
