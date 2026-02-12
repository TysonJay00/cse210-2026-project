


    
/*   for (int i = 5; i > 0; i--)

    {
        Console.Write(i);    /* How to create a timer counting down from 5. (Writeline) shows numbers creating a column, (Write) shows numbers in a row. Write(".") shows dots appearing one after the other. */
/*      Thread.Sleep(2000);     /* Pause timing in miliseconds */
 /*     Console.Write("\b \b");  /* This shows the numbers appearing in same space 
    }  */

//  |/-\|/-\|       /* Creating spinners */
    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");  /* needs two "\" backslash because it thinks I want to escape the */
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(10);
    int i = 0;
    
    while (DateTime.Now < endTime)

    {
        Console.Write(i);    /* How to create a timer counting down from 5. (Writeline) shows numbers creating a column, (Write) shows numbers in a row. Write(".") shows dots appearing one after the other. */
        Thread.Sleep(2000);     /* Pause timing in miliseconds */
        Console.Write("\b \b");  /* This shows the numbers appearing in same space */

        i++;

        if (i >= animationStrings.Count)
        {
            i = 0;
        }
    }
 
    Console.WriteLine("done");

