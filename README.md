[![Build Status](https://travis-ci.org/mattmtx/FizzBuzz.svg?branch=master)](https://travis-ci.org/mattmtx/FizzBuzz)
# FizzBuzz

# Usage
Itterate through the FizzBuzz results:
```c#
FizzBuzz fb = new FizzBuzz();
IEnumerable<string> results = fb.GetFizzBuzz(20);
foreach (string result in results)
{
  Console.WriteLine(result);
}
```
Access a single element of the FizzBuzz result:
```c#
FizzBuzz fb = new FizzBuzz();
Console.WriteLine(fb[5]);
```
Overwrite the FizzBuzz Multiple-Word parameters:
```c#
FizzBuzz fb = new FizzBuzz();
fb.SetMultipleNamePair(2, "Hire", 3, "MattM");
IEnumerable<string> results = fb.GetFizzBuzz(20);
foreach (string result in results)
{
  Console.WriteLine(result);
}
```
Alternative method for directly overwriting the Muliple-Word parameter:
```c#
fb.MultipleNamePair = new List<KeyValuePair<int, string>>()
{
  new KeyValuePair<int, string>(3, "Fizz"),
  new KeyValuePair<int, string>(5, "Buzz"),
  new KeyValuePair<int, string>(4, "Foo"),
};
```

# Design Decisions
* The GetFizzBuzz method returns an IEnumerable<string> response
  * This allows for the lines to be returned/output as they are being generated.
  * Pre-generating large Lists of output experienced way too much memory pressure (on large inputs).

There are two mechanisms for retrieving the FizzBuzz results:

1. Calling GetFizzBuzz, passing in the Upper Bound the IEnumerable itterator will run through (starting at 1)

2. Calling the overloaded indexer/accessor (square brackets - []).  This will return the translated FizzBuzz output for the given integer.

## Setting the Multiple-Word pairs...
By default the standard FizzBuzz parameters are used:
```
Multiples of 3 print "Fizz"
Multiples of 5 print "Buzz"
```
These can be overwritten:
#### Directly
The FizzBuzz Class-field MultipleNamePair is made public to allow it to be directly overwritten.  
Set it to a new List<KeyValuePair<int, string>>,   where:  
* Each KeyValuePair represents a Multiple-Word pair
* Where the Key is the integer Multiple, and the string is the Word which will be displayed
* Any number of KeyValuePairs can be provided, as long as the Multiple number is a non-zero integer.

#### Helper Method
The FizzBuzz Class-method SetMultipleNamePair(...) provides an easy-to-call method for updating the underlying MultipleNamePair datastructure.  
It can only be used when specifying 2 Multiple-Word pairs.  
```
int multiple1 = The first Multiple
string word1 = The string to output when the number is divisible by multiple1
int multiple2 = The second Multiple
string word2 = The string to output when the number is divisible by multiple2
```
ToDo - Additional helper methods can be created if there is large customer demand for varying amounts of Multiple-Word pairs
