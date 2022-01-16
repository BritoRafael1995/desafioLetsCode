using BACK.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BACK.Business.Interface
{
    public interface ICardsBusiness
    {
        Card AddCard(Card card);
        List<Card> DeleteCard(Guid id);
        List<Card> GetCards();
        Card UpdateCard(Guid id, Card card);
    }
}
