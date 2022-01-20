using BACK.Model.Models;
using BACK.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BACK.Repository.Implementation
{
    public class CardsRepository : ICardsRepository
    {
        private readonly Context _context;

        public CardsRepository(Context context)
        {
            _context = context;
        }
        public Card AddCard(Card card)
        {
            var retorno = _context.Cards.Add(card);
            if(retorno.State == EntityState.Added)
            {
                _context.SaveChanges();
                return retorno.Entity;
            }
            
            throw new Exception("Não foi possível adicionar o card");

        }

        public List<Card> DeleteCard(Card card)
        {
            var result = _context.Cards.Remove(card);

            if (result.State == EntityState.Deleted)
            {
                _context.SaveChanges();
                return GetCards();
            }
            throw new Exception("Não foi possível remover o card");
        }

        public List<Card> GetCards()
        {
            var cards = _context.Cards.AsNoTracking().ToListAsync().Result;

            return cards;
        }

        public Card GetCardById(Guid id)
        {
            var card = _context.Cards.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id).Result;
            return card;
        }

        public Card UpdateCard(Guid id, Card card)
        {
            var result = _context.Cards.Update(card);

            if(result.State == EntityState.Modified)
            {
                _context.SaveChanges();
                return result.Entity;
            }
            throw new Exception("Não foi possível atualizar o card");
        }
    }
}
