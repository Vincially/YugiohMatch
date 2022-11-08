using System.Collections;
using YugiohMatch.Domain.Core;

namespace YuGiOhMatch.Test.DataGenerator.Monsters
{
    public class MonstersThatCannotBeDiscarded : IEnumerable<MonsterCard[]>
    {

        public IEnumerator<MonsterCard[]> GetEnumerator()
        {
            yield return new MonsterCard[]
            {
                new MonsterCard()
                {
                    Name = "Dark Magician",
                    CurrentStatus = CardStatus.Set,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.InHand} },
                            {2, new CardEffect() {ActivationCondition = CardStatus.InGraveyard} }
                        }
                }
            };
            yield return new MonsterCard[]
            {
                new MonsterCard()
                {
                    Name = "Blue-Eyes White Dragon",
                    CurrentStatus = CardStatus.Summoned,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.InHand} },
                            {2, new CardEffect() {ActivationCondition = CardStatus.Summoned} },
                            {3, new CardEffect() {ActivationCondition = CardStatus.InHand} }
                        }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
