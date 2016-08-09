# stream-reader

Because the third part of the assignment said to capitalize all lowercase vowels, it occurred to me that it had to include 'y' when it's used as a vowel. Given the number of oddities and exceptions in English, it was infeasible to implement an exhaustive algorithm in a reasonable timeframe, but an inspection of the text reveals one instance in which 'y' is not used as a vowel — "young" — and all the rest are used as vowels, either on their own or as parts of diphthongs. A unique property of this 'y' is that it's the only 'y' used at the beginning of a word, so this program capitalizes all 'y' characters that are not preceded by a space. It seems fairly safe to assume that a leading 'y' will be a consonant, though it's worth noting that this test fails for the chemical element "yttrium". It is less safe to assume that a non-leading 'y' is a vowel. Though many of them seem to be, this test fails for "Kanye", an important case if ever there was one.

Then it also occurred to me that the text contained words with diphthongs like "known" in which 'w' could be considered a vowel, and I really had to stop here before I got too far down the linguistics rabbit hole, but I hope this is enough to get most of the points.

#TODO

Write a method to determine exhaustively if any instance of 'y' or 'w' in a string is a vowel.
