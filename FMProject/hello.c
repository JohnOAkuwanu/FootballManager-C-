#include <stdio.h>

main()
{
    printf("hello, world \n");
}

#include <stdio.h>
/* This is my first attempt at C. Let's hope this goes well =)  */

main()
{
    #define COUNTER 0 /*First time using symbolic constants, it is a nice feature */
    long counter = 0;

    while ((c = getchar()) != EOF)
        counter += 1; /* Or use the expression ++counter;*/

    printf("%ld /n", counter); /*The %ld is used to indicate to the computer that the type being used is a long and not an int*/
}


main()
{
    long counter = 0;
    
    for (counter; getchar() != EOF; ++counter);

    printf("%ld /n", counter);
}


main()
{
    int current_char, no_of_lines;
    no_of_lines = 0;

    for (no_of_lines; (c = getchar()) == '/n'; ++no_of_lines)

    printf("%d /n", no_of_lines);
}

main()
{
    int nl, bl, tabs = 0;
    int c;

    while ((c = getchar()) != EOF)

        if (c=="    ")
            ++tabs;

        if (c==" ")
            ++bl;

        if (c=="/n")
            ++nl;
    
    printf("There are exactly %d blanks, %d tabs and %d lines in this passage of text", bl, tabs, nl);
}