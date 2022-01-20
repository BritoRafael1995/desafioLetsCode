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
            var card = _cardsRepository.GetCardById(id);
            if (card != null)
                return _cardsRepository.DeleteCard(card);
            else
                throw new NullReferenceException();
        }

        public List<Card> GetCards()
        {
            return _cardsRepository.GetCards();
        }

        public Card UpdateCard(Guid id, Card card)
        {
            if (_cardsRepository.GetCardById(id) != null)
            {
                ValidarCard(card);

                return _cardsRepository.UpdateCard(id, card);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private void ValidarCard(Card card)
        {
            if (string.IsNullOrEmpty(card.Titulo) || string.IsNullOrEmpty(card.Lista) || string.IsNullOrEmpty(card.Conteudo))
                throw new InvalidOperationException();
        }
    }
}
