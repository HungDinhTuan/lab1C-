public class Program
{
    private static void Main(string[] args)
    {
        int year, month, day;

        do
        {
            Console.Write("Enter date of birth : ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month of birth : ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year of birth : ");
            year = Convert.ToInt32(Console.ReadLine());
        } while (!ValidDateOfBirth.validDOB(year, month, day));

        int numrology = Numerology.countNumrology(year, month, day);

        switch (numrology)
        {
            case 2:
                Console.WriteLine("The number 2 in numerology is considered to be quite rare as it is only made up of a total of 20. Therefore, people with the dominant number 2 are very special and less than people with other dominant numbers. These are people who love art, sensitive souls with good intuition. They live quite modestly and always want to help others.");
                break;
            case 3:
                Console.WriteLine("People whose dominant number is 3 are characterized by sharp thinking and reasoning. They are people with quick minds so they are suitable for business. With humor and flexible thinking, they bring many opportunities in life. But if they live in a less positive way, person number 3 shows a patriarchal personality. Prefers to direct others rather than accompany and sympathize.");
                break;
            case 4:
                Console.WriteLine("Practicality and practicality are the characteristics of people whose dominant numerology number is 4. Instead of sitting and discussing deeply, they will start implementing immediately. Thanks to that, they are always the ones who move forward and overcome all difficulties. Number 4 numerology personalities are people who live by principles and are very trustworthy. However, because they are too focused on work, they sometimes lack balance. Especially with surrounding relationships like family.");
                break;
            case 5:
                Console.WriteLine("This is a group of people who love freedom and do not want to be tied to any framework. They are quite sensitive people and always want to express their emotions outwardly. Is an art lover, has good intuition and is rich in love.");
                break;
            case 6:
                Console.WriteLine("People with the dominant number 6 are very good in the fields of creativity and art. They carry great responsibilities with deep dedication in everything. Because they like to contribute, they often face burdens and responsibilities. Sometimes there are insecurities and worries that cause them to live under pressure and stress.");
                break;
            case 7:
                Console.WriteLine("Those whose dominant numerology number is 7 will have a strong desire to learn. Want to learn in your own way and don't want to stop at simple learning. A person who always likes to explore and experience new things from many different angles. Therefore, this group of people often have to sacrifice one of three aspects: health, love, and money.");
                break;
            case 8:
                Console.WriteLine("For people with the dominant number 8, they attach great importance to each individual's independence. They have complex and multi-dimensional thoughts but possess quite strong personalities. Confidence and good thinking help them make accurate calculations to achieve success. However, it is difficult for them to show gratitude and appreciation to people around them.");
                break;
            case 9:
                Console.WriteLine("Numerology number 9 is a group of people who are considered to have 3 times more ambition, responsibility and ideals. They bring the human factor to the forefront. They live responsibly, seriously and value the whole more than details. They have big dreams and always want to pursue them, suitable for the field of arts and humanities.");
                break;
            case 10:
                Console.WriteLine("The ability to adapt and change is the highlight of those with number 10. They have a flexible and adaptable personality, so they are loved by many people. With a positive and sociable lifestyle, they will encounter many good opportunities. However, if they live with negativity, they can easily become insecure, lost and unsteady in life.");
                break;
            case 11:
                Console.WriteLine("For those who carry the theology number 11, they will often have quite a lot of spiritual energy. This is a group of people with extraordinary abilities in promoting surreal awareness. However, not everyone in this group can demonstrate that potential. Besides, they are also people who appreciate beauty and sophistication. They live very honestly, sensitively and always orient towards family and relatives.");
                break;
            case 22:
                Console.WriteLine("In Pythagorean numerology, this is a special leading number and is considered the king number. These are people who live very responsibly and always try to achieve results. They live confidently, have sharp thinking and quite good intuition. They are very good at controlling their emotions in different situations. Because they always strive, they will achieve most of their set goals");
                break;
        }
    }
}

public class ValidDateOfBirth
{
    public static bool validDOB(int year, int month, int day)
    {
        if (year < 0)
        {
            year = Math.Abs(year);
        }
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Month has to bigger than 1 and smaller than 12");
            return false;
        }
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                if (day < 1 | day > 31)
                {
                    Console.WriteLine("The number days in " + month + " isn't smaller than 1 and bigger than 31.");
                    return false;
                }
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                if (day < 1 | day > 30)
                {
                    Console.WriteLine("The number days in " + month + " isn't smaller than 1 and bigger than 30.");
                    return false;
                }
                break;
            case 2:
                bool isLeapYear = (year % 4 == 0 && year % 100 != 0) | (year % 400 == 0);
                if (isLeapYear && (day < 1 | day > 29))
                {
                    Console.WriteLine("The number days in " + month + " of the leap year isn't smaller than 1 and bigger than 29.");
                    return false;
                }
                else if (!isLeapYear && (day < 1 | day > 28))
                {
                    Console.WriteLine("The number days in " + month + " of the non leap year isn't smaller than 1 and bigger than 28.");
                    return false;
                }
                break;
        }
        return true;
    }
}

public class CountSumNumbers
{
    public static int sumNumbers(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}

public class Numerology
{
    public static int countNumrology(int year, int month, int day)
    {

        int numrology = CountSumNumbers.sumNumbers(year) + CountSumNumbers.sumNumbers(month) +
                        CountSumNumbers.sumNumbers(day);

        if (numrology == 22)
        {
            return numrology;
        }
        else
        {
            while (numrology > 11)
            {
                numrology = CountSumNumbers.sumNumbers(numrology);
            }
            return numrology;
        }
    }
}