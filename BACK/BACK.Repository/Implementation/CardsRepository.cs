﻿using BACK.Model.Models;
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
            throw new NotImplementedException();
        }

        public List<Card> DeleteCard(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Card> GetCards()
        {
            var cards = _context.Cards.ToListAsync().Result;

            return cards;
        }

        public Card UpdateCard(Guid id, Card card)
        {
            throw new NotImplementedException();
        }
    }
}