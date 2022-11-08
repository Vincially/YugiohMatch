using System.Collections;
using YugiohMatch.Domain.Core;

namespace YuGiOhMatch.Test.DataGenerator.Monsters
{
    public class MonstersWithEffectsActivatedInTheWrongPlace : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new MonsterCard()
                {
                    Name = "Dark Magician",
                    CurrentStatus = CardStatus.InHand,
                    Effects = new Dictionary<int, CardEffect>() {
                            {1, new CardEffect() {ActivationCondition = CardStatus.InHand} },
                            {2, new CardEffect() {ActivationCondition = CardStatus.InGraveyard} }
                        }
                },
                2
            };
            yield return new object[]
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
                },
                3
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
