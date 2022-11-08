namespace YugiohMatch.Domain.Core
{
    public abstract class Card
    {
        public string Name { get; set; }
        public Dictionary<int, CardEffect> Effects { get; set; }
        public CardStatus CurrentStatus { get; set; }
        public CardType Type { get; protected set; }

        public bool ActivateEffect(int effectNumber)
        {
            if(Effects.ContainsKey(effectNumber) && 
            Effects[effectNumber].ActivationCondition == CurrentStatus)
            {
                CurrentStatus = CardStatus.Activated;
                return true;
            }
            else
                return false;        
        }
            

        public bool Set()
        {
            if (CurrentStatus == CardStatus.InHand)
            {
                CurrentStatus = CardStatus.Set;
                return true;
            }
            else
                return false;
        }
        

        public bool Discard()
        {
            if (CurrentStatus == CardStatus.InHand)
            {
                CurrentStatus = CardStatus.InGraveyard;
                return true;
            }
            else
                return false;
        }
    }
}