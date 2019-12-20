# MagicSquare-CSharp
Magic Square in C Sharp Console project.  
This original commit handles only odd Magic Square. 
Test cases were done for 1x1 through 21x21, but the function can handle bigger odd Magic Square.

Example output:

 8,1,6
 3,5,7
 4,9,2
Sum of each row or column in above Magic Square 3x3 is 15

I learned the rule for constructing the odd Magic Square from my Math instructor. 
But I found this citation from Wikipedia regarding possibly the original source.  
Please go to Wikipedia and search for Magic Square for a full history and multiple algorithms of odd and even Magic Square.

A small excerpt from Wikipedia on one way of constructing odd Magic Square is shown below:

The method prescribes starting in the central column of the first row with the number 1. After that, the fundamental movement for filling the squares is diagonally up and right, one step at a time. If a filled square is encountered, one moves vertically down one square instead, then continues as before. When an "up and to the right" move would leave the square, it is wrapped around to the last row or first column, respectively.

