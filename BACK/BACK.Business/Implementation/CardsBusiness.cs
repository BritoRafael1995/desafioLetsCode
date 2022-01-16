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
            throw new NotImplementedException();
        }

        public List<Card> DeleteCard(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Card> GetCards()
        {
            return _cardsRepository.GetCards();
        }

        public Card UpdateCard(Guid id, Card card)
        {
            throw new NotImplementedException();
        }
    }
}
