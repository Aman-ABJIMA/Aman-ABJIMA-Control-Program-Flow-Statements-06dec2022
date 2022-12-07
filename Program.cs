// See https://aka.ms/new-console-template for more information
int count = 0;
here:
Console.WriteLine("Enter a digit in range of \"1-7\"");
int day=Convert.ToInt16(Console.ReadLine());
switch(day)
{
        case 1:
        Console.WriteLine("MONDAY");
        break;
        case 2: Console.WriteLine("TUESDAY");
        break;
        case 3: Console.WriteLine("WEDNESDAY");
        break;
        case 4: Console.WriteLine("THURSDAY");
        break;
        case 5: Console.WriteLine("FRIDAY");
        break;
        case 6: Console.WriteLine("SATURDAY");
        break;
        case 7: Console.WriteLine("SUNDAY");
        break;
        default: Console.Clear();
        Console.WriteLine("Invalid Input\nTRY AGAIN!!!");
        count++;
        if (count == 3)
        {
            Console.Clear();
            Console.WriteLine("YOU TOOK MAXIMUM TRIALS!!!");
            goto exit;
        }
        goto here;
}
exit:
Console.Beep();
    
