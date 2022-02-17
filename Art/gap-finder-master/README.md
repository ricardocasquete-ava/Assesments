# Gap Finder App
This project is an implementation of the following challenge:

> For a given input array with consecutive numbers with which one random number has been removed, find the missing number.

## Requirements
* The numbers should start from 1 to N (i.e.: 1, 2, 3, ... N)
* There should be one missing number from the sequence. If there are no missing numbers, it is assumed that the last number is the missing one.
* The numbers can be in any order.

## The `run` verb
### Usage
```
... gap-finder\app> dotnet run -- run -i "path/to/input.file"
```
Reads a file and outputs the missing number in the sequence.

|Options|Description       |Notes|
|:-----:|:-----------------|:----|
|-i     |Input file to read|Required. Content should have one line that contains a series of numbers separated by spaces|

### Sample output:
```
Input: path/to/input.file
Missing number in the sequence: 23
```

## The `generate` verb

### Usage
```
... gap-finder\app> dotnet run -- generate -o "path/to/output.file" [-r] [-c 100]
```
Generates a file that can be used as input for the `run` verb.

|Options|Description|Notes|
|:-----:|:----------|:----|
|-o|Output file to generate|Required. Content will have one line that contains a series of numbers separated by spaces|
|-c|The count of items to generate|Optional. Default is 100|
|-r|Randomises the order of the items in the series|Optional|

### Sample output:
```
Generated output: path/to/output.file
Missing number in the sequence: 23
```