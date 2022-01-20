using BACK.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BACK.Repository.Interface
{
    public interface ICardsRepository
    {
        Card AddCard(Card card);
        List<Card> DeleteCard(Card card);
        List<Card> GetCards();
        Card GetCardById(Guid id);
        Card UpdateCard(Guid id, Card card);
    }
}
