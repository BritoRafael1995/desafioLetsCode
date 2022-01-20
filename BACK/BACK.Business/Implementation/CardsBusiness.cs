using BACK.Business.Interface;
using BACK.Model.Models;
using BACK.Repository;
using BACK.Repository.Implementation;
using BACK.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BACK.Business.Implementation
{
    public class CardsBusiness : ICardsBusiness
    {
        private readonly ICardsRepository _cardsRepository;

        public CardsBusiness(Context context)
        {
            _cardsRepository = new CardsRepository(context);
        }
        public Card AddCard(Card card)
        {
            ValidarCard(card);

            card.Id = Guid.NewGuid();
            return _cardsRepository.AddCard(card);
        }

        public List<Card> DeleteCard(Guid id)
        {
            return _cardsRepository.DeleteCard(id);
        }

        public List<Card> GetCards()
        {
            return _cardsRepository.GetCards();
        }

        public Card UpdateCard(Guid id, Card card)
        {
            ValidarCard(card);

            return _cardsRepository.UpdateCard(id, card);
        }

        private void ValidarCard(Card card)
        {
            if (string.IsNullOrEmpty(card.Titulo))
                throw new Exception("O título do card deve estar preenchido");
            else if (string.IsNullOrEmpty(card.Conteudo))
                throw new Exception("O conteúdo do card deve estar preenchido");
            else if (string.IsNullOrEmpty(card.Lista))
                throw new Exception("A lista do card deve estar preenchida");
        }
    }
}
