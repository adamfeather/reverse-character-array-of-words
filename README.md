# reverse-character-array-of-words

Solution to an interview question whereby a character array containing words in reverse order should be word-reversed.

.e.g.

The intial array:

`{'f','o','x',' ','b','r','o','w','n',' ','q','u','i','c','k',' ','t','h','e'}`

should be reversed to:

`{'t','h','e',' ','q','u','i','c','k',' ','b','r','o','w','n',' ','f','o','x'}`

The arbitrary restrictions placed on this task are:

- The reordering need to be done in place, i.e. no new arrays can be created
- A single character variable can be used to temporarily store characters
- No LINQ

Without the restrictions a solution is fairly trivial:

`var reversedWords = string.Join(' ', new string(array).Split(' ').Reverse()).ToCharArray();`
