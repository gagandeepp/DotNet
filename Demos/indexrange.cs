int[] numbers = { 0, 1, 2, 3, 4, 5 };
int first = numbers[0];    // 0
int last = numbers[^1]  // 5 (using ^1 to get the last element)
int secondLast = numbers[^2]


int[] numbers = { 0, 1, 2, 3, 4, 5 };
int[] subArray = numbers[1..4]; // { 1, 2, 3 } (from index 1 to index 4, exclusive)
int[] lastTwo = numbers[^2..];  // { 4, 5 } (from the second last element to the end)
