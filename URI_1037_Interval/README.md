# URI_1037_Interval

## C# approach

<strong> <a href='https://www.urionlinejudge.com.br/judge/en/problems/view/1037'> LINK </a> </strong>  <br>

You must make a program that read a float-point number and print a message saying in which of following intervals the number belongs: [0,25] (25,50], (50,75], (75,100]. If the read number is less than zero or greather than 100, the program must print the message “Fora de intervalo” that means "Out of Interval".

The symbol '(' represents greather than. For example:
[0,25] indicates numbers between 0 and 25.0000, including both.
(25,50] indicates numbers greather than 25 (25.00001) up to 50.0000000.

## Input <br>
The input file contains a floating-point number.

## Output <br>
The output must be a message like following example.

### Input Samples
25.01 <br>
------------------------------------ <br>
-25.02 <br>
------------------------------------ <br>

### Output Samples
Intervalo (25,50] <br>
------------------------------------ <br>
Fora de intervalo <br>
------------------------------------ <br>