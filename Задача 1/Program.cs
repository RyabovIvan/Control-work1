using System;
using static System.Console;

Clear();

string[]array = AskArray();
string[]result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[]FindLessThan(string[] input, int N) {
    string[] output = new string[CountLessThan(input, N)];

    for(int A = 0, B = 0; A < input.Length; A++) {
        if(input[A].Length <= N) {
            output[B] = input[A];
            B++;
        }
    }

    return output;
}

int CountLessThan(string[]input, int N) {
    int count = 0;

    for(int A = 0; A < input.Length; A++) {
        if(input[A].Length <= N) {
            count++;
        }
    }

    return count;
}

string[]AskArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}