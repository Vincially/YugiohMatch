﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YugiohMatch.Domain.Core
{
    public class CardEffect
    {
        public CardStatus ActivationCondition { get; set; }
        public string Effect { get; set; }
    }
}
