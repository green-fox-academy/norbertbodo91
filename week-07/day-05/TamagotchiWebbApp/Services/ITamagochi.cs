using System;
namespace TamagotchiWebbApp
{
    public interface ITamagochi
    {
        void SetName(string givenName);
        void DoTrick(int numberOfTrick);
    }
}
