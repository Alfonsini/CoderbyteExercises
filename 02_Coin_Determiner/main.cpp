#include <iostream>
#include <string>
using namespace std;

int MathChallenge(int num) {
    // Coins
    // [1,5,7,9,11]

    //1 Greedy Algorithm
    int coins[] = {11,9,7,5,1};
    int coinsLength = sizeof(coins)/sizeof(coins[0]);
    int totalNumberOfCoins = 0;
    int inputNumber = num;
    // Scenarios to test
    // 1. Two coins required
    // 16
    // 16 - 11 = 5
    // 5-5
    // 0

    // 2. Three coins required
    // 17
    // 17 - 11
    // 6 - 5
    // 1 - 1 
    // 0


    // 3. Four repeated coins and one no repeated required
    // 49
    // 49 - 11
    // 38 - 11


    // Solution
    // As this is an Greedy Algorithm, I am gonna try to choose the best option at every step.
    // Identify how many times the input number is divisible by the higher coin. If this is,
    // I'm gonna add it to the coins counter.
    // 8
    // 8 - 11 not possible
    // 8 - 9 not possible
    // 8 - 7 possible
    // 1 - 5 not possible
    // 1 - 1 possible

    for (int i = 0; 1 < coinsLength; i++)
    {
        // Identify how many times the input number is divisible by the current coin 
        int currentNumberOfCoins = inputNumber/coins[i];

        int currentCoin = coins[i];

        // If is divisible
        if (currentNumberOfCoins > 0 )
        {
            // add it to the counter
            totalNumberOfCoins += currentNumberOfCoins;
            
            // Substract the current number of coins required (quotien) multiply by the current coin
            inputNumber -= (currentNumberOfCoins * currentCoin);

        } 
        else
        {
            // skip the current coin when quotien is zero.
            continue;
        }
    }

    return totalNumberOfCoins;
}


int main(void)
{
    // keep this function call here
    cout << MathChallenge(400);
}