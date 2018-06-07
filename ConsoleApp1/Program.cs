using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello.  What is your first name? ");
            var userFirstName = Console.ReadLine().Trim();

            Console.Write("What will be my name? ");
            var computerName = Console.ReadLine().Trim();

            var user = new User()
            {
                FirstName = userFirstName,
                ComputerName = computerName,
                HighestNumbersInARow = 0
            };

            Console.Clear();
            GameDecision(user);
        }

        private static void GameDecision(User user)
        {
            while (true)
            {
                Console.WriteLine("{0}, " +
                                  "What game do you want to play?\n" +
                                  "\t1)  Higher or Lower\n" +
                                  "\t2)  Rock, Papers, Scissors\n" +
                                  "\t3)  Memory\n" +
                                  "\t4)  Casino Blackjack\n" +
                                  "\t5)  US Capitals\n" +
                                  "\t6)  Simple Math\n" +
                                  "\t7)  What's Left\n" +
                                  "\t8)  US Holidays\n" +
                                  "\t9)  Search and Rescue (Coming soon)\n" +
                                  "\t10) Tic-Tac-Toe\n" +
                                  "\t11) US Presidents (Coming soon)\n" +
                                  "\t12) US Vice Presidents (Coming soon)\n\t...", user.FirstName);

                var input = Console.ReadLine()?.Trim().ToLower();
                var isNumber = int.TryParse(input, out var playGameInput);

                if (isNumber)
                {
                    switch (playGameInput)
                    {

                        case 1: PlayNumbersGame(user); return;
                        case 2: PlayRockPaperScissors(user); return;
                        case 3: PlayMemory(user); return;
                        case 4: PlayBlackjack(user); return;
                        case 5: PlayStateCapitals(user); return;
                        case 6: SimpleMath(user); return;
                        case 7: WhatsLeft(user); return;
                        case 8: HolidayQuiz(user); return;
                        case 9: SearchAndRescue(user); return;
                        case 10: TicTacToe(user); return;
                        case 11: USPresidents(user); return;
                        //case 12: USVicePresidents(user); return;
                        default: Console.WriteLine("\nYou didn't enter 1-12...\n"); break;
                    }
                }
                else
                {
                    Console.WriteLine("\nCome on {0}, You didn't enter 1-10...\n", user.FirstName);
                }
            }
        }

        private static void USPresidents(User user)
        {
            Console.WriteLine("\tWelcome, {0}!! How well do you know your US Presidents?\n\n" +
                              "\tDo you know how many there are...(hint - 45)?\n\n" +
                              "\tPress ENTER to begin", user.FirstName);
            Console.ReadLine();
            Console.Clear();

            Random rnd = new Random();

            List<int> presidentNumber = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28,
                29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45
            };

            var minNumber = presidentNumber.Min();
            var maxNumber = presidentNumber.Max();

            while (true)
            {
                var answer = rnd.Next(0, presidentNumber.IndexOf(maxNumber) + 1);
            }

            var listOfPresidents = GetPresidents(1, "president");


        }

        public static PresidentsStats GetPresidents(int presidentNumber)
        {
            var presidents = new Dictionary<int, PresidentsStats>
            {
                {
                    1,
                    new PresidentsStats
                    {
                        President = "George Washington",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "John Adams",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "4/30/1789 to 3/4/1797",
                        VpSecondTerm = "",
                        VpSecondTermDateRange = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        PresidentialDateRange = "4/3/1789 to 3/4/1797",
                        LifeRange = "1732-1799",
                        AgeAtDeath = 67,
                        Party = "Unaffiliated",
                        NumberOfTermsElected = 2
                    }
                },

                {
                    2,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "Thomas Jefferson",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1797 to 3/4/1801",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        AgeAtDeath = 90,
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    3,
                    new PresidentsStats
                    {
                        President = "Thomas Jefferson",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "Aaron Burr",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1801 to 3/4/1805",
                        VpSecondTerm = "George Clinton",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "3/4/1805 to 3/4/1809",
                        PresidentialDateRange = "3/4/1801 to 3/4/1809",
                        LifeRange = "1743-1826",
                        AgeAtDeath = 83,
                        Party = "Democratic-Republican",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    4,
                    new PresidentsStats
                    {
                        President = "James Madison",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "George Clinton",
                        VpFirstTermHasDiedInOffice = true,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1809 to 4/20/1812",
                        VpSecondTerm = "Elbridge Gerry",
                        VpSecondTermHasDiedInOffice = true,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "3/4/1813 to 11/23/1814",
                        PresidentialDateRange = "3/4/1809 to 3/4/1817",
                        LifeRange = "1751-1836",
                        AgeAtDeath = 85,
                        Party = "Democratic-Republican",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    5,
                    new PresidentsStats
                    {
                        President = "James Monroe",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "Daniel D. Tompkins",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1817 to 3/4/1825",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1817 to 3/4/1825",
                        LifeRange = "1758-1831",
                        AgeAtDeath = 73,
                        Party = "Democratic-Republican",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    6,
                    new PresidentsStats
                    {
                        President = "John Quincy Adams",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "John C. Calhoun",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1825 to 3/4/1829",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermDateRange = "",
                        VpSecondTermHasResignedInOffice = false,
                        PresidentialDateRange = "3/4/1825 to 3/4/1829",
                        LifeRange = "1767-1848",
                        AgeAtDeath = 80,
                        Party = "Democratic-Republican",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    7,
                    new PresidentsStats
                    {
                        President = "Andrew jackson",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "John C. Calhoun",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = true,
                        VpFirstTermDateRange = "3/4/1829 to 12/28/1832",
                        VpSecondTerm = "Martin Van Buren",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "3/4/1833 to 3/4/1837",
                        PresidentialDateRange = "3/4/1829 to 3/4/1837",
                        LifeRange = "1767-1845",
                        AgeAtDeath = 78,
                        Party = "Democratic",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    8,
                    new PresidentsStats
                    {
                        President = "Martin Van Buren",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "Richard M. Johnson",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1837 to 3/4/4/1841",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1837 to 3/4/1841",
                        LifeRange = "1782-1862",
                        AgeAtDeath = 79,
                        Party = "Democratic",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    9,
                    new PresidentsStats
                    {
                        President = "William Henry Harrison",
                        HasDiedInOfficePresident = true,
                        VpFirstTerm = "John Tyler",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1841 to 4/4/1841",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1841 to 4/4/1841",
                        LifeRange = "1773-1841",
                        AgeAtDeath = 68,
                        Party = "Whig",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    10,
                    new PresidentsStats
                    {
                        President = "John Tyler",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "4/4/1841 to 3/4/1845",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "4/4/1841 to  3/4/1845",
                        LifeRange = "1790-1862",
                        AgeAtDeath = 71,
                        Party = "Whig (4/4/1841 to 9/13/1841), Unaffiliated (9/13/1841 to 3/4/1845)",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    11,
                    new PresidentsStats
                    {
                        President = "James K. Polk",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "George M. Dallas",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1845 to 3/4/1849",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1845 to  3/4/1849",
                        LifeRange = "1795-1849",
                        AgeAtDeath = 53,
                        Party = "Democratic",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    12,
                    new PresidentsStats
                    {
                        President = "Zachary Taylor",
                        HasDiedInOfficePresident = true,
                        VpFirstTerm = "Millard Fillmore",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1849 to 7/9/1850",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1849 to 7/9/1850",
                        LifeRange = "1784-1850",
                        AgeAtDeath = 65,
                        Party = "Whig",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    13,
                    new PresidentsStats
                    {
                        President = "Millard Fillmore",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "7/9/1850 to  3/4/1853",
                        LifeRange = "1800-1874",
                        AgeAtDeath = 74,
                        Party = "Whig",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    14,
                    new PresidentsStats
                    {
                        President = "Franklin Pierce",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "William R. King",
                        VpFirstTermHasDiedInOffice = true,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1853 to 4/18/1853",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1853 to 3/4/1857",
                        LifeRange = "1804-1869",
                        AgeAtDeath = 64,
                        Party = "Democratic",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    15,
                    new PresidentsStats
                    {
                        President = "James Buchanan",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "John C. Breckinridge",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1857 to 3/4/1861",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1857 to 3/4/1861",
                        LifeRange = "1791-1868",
                        AgeAtDeath = 77,
                        Party = "Democratic",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    16,
                    new PresidentsStats
                    {
                        President = "Abraham Lincoln",
                        HasDiedInOfficePresident = true,
                        VpFirstTerm = "Hannibal Hamlin",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1861 to 3/4/1861",
                        VpSecondTerm = "Andrew Johnson",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "3/4/1865 to 4/15/1865",
                        PresidentialDateRange = "3/4/1861 to 4/15/1865",
                        LifeRange = "1809-1865",
                        AgeAtDeath = 56,
                        Party = "Republican",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    17,
                    new PresidentsStats
                    {
                        President = "Andrew Johnson",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "4/15/1865 to 3/4/1869",
                        LifeRange = "1808-1875",
                        AgeAtDeath = 66,
                        Party = "National Union (1865-1868), Democratic (1868-1869)",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    18,
                    new PresidentsStats
                    {
                        President = "Ulysses S. Grant",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "Schuyler Colfax",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1869 to 3/4/1873",
                        VpSecondTerm = "Henry Wilson",
                        VpSecondTermHasDiedInOffice = true,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "3/4/1873 to 11/22/1875",
                        PresidentialDateRange = "3/4/1869 to 3/4/1877",
                        LifeRange = "1822-1885",
                        AgeAtDeath = 63,
                        Party = "Republican",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    19,
                    new PresidentsStats
                    {
                        President = "Rutherford B. Hayes",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "William A. Wheeler",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1877 to 3/4/1881",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1877 to 3/4/1881",
                        LifeRange = "1822-1893",
                        AgeAtDeath = 70,
                        Party = "Republican",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    20,
                    new PresidentsStats
                    {
                        President = "James A. Garfield",
                        HasDiedInOfficePresident = true,
                        VpFirstTerm = "Chester A. Arthur",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1881 to 9/19/1881",
                        PresidentialDateRange = "3/4/1881 to 9/19/1881",
                        LifeRange = "1831-1881",
                        AgeAtDeath = 49,
                        Party = "Republican",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    21,
                    new PresidentsStats
                    {
                        President = "Chester A. Arthur",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1881 to 9/19/1881",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "9/19/1881 to 3/4/1885",
                        LifeRange = "1829-1886",
                        AgeAtDeath = 57,
                        Party = "Republican",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    22,
                    new PresidentsStats
                    {
                        President = "Grover Cleveland",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "Thomas A. Hendricks",
                        VpFirstTermHasDiedInOffice = true,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1885 to 11/25/1885",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1885 to 3/4/1889",
                        LifeRange = "1837-1908",
                        AgeAtDeath = 71,
                        Party = "Democratic",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    23,
                    new PresidentsStats
                    {
                        President = "Benjamin Harrison",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "Levi P. Morton",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1889 to 3/4/1893",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1889 to 3/4/1893",
                        LifeRange = "1883-1901",
                        AgeAtDeath = 67,
                        Party = "Republican",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    24,
                    new PresidentsStats
                    {
                        President = "Grover Cleveland",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "Adlai Stevenson",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1893 to 3/4/1897",
                        PresidentialDateRange = "3/4/1893 to 3/4/1897",
                        LifeRange = "1837-1908",
                        AgeAtDeath = 71,
                        Party = "Democratic",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    25,
                    new PresidentsStats
                    {
                        President = "William McKinley",
                        HasDiedInOfficePresident = true,
                        VpFirstTerm = "Garret Hobart",
                        VpFirstTermHasDiedInOffice = true,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1897 to 11/21/1899",
                        VpSecondTerm = "Theodore Roosevelt",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "3/4/1901 to 9/14/1901",
                        PresidentialDateRange = "3/4/1897 to 9/14/1901",
                        LifeRange = "1843-1901",
                        AgeAtDeath = 58,
                        Party = "Republican",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    26,
                    new PresidentsStats
                    {
                        President = "Theodore Roosevelt",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "",
                        VpSecondTerm = "Charles W. Fairbanks",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "3/4/1905 to 3/4/1909",
                        PresidentialDateRange = "9/14/1901 to 3/4/1909",
                        LifeRange = "1858-1919",
                        AgeAtDeath = 60,
                        Party = "Republican",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    27,
                    new PresidentsStats
                    {
                        President = "William Howard Taft",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "James S. Sherman",
                        VpFirstTermHasDiedInOffice = true,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1909 to 10/30/1912",
                        PresidentialDateRange = "3/4/1909 to 3/4/1913",
                        LifeRange = "1857-1930",
                        AgeAtDeath = 72,
                        Party = "Republican",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    28,
                    new PresidentsStats
                    {
                        President = "Woodrow Wilson",
                        HasDiedInOfficePresident = false,
                        VpFirstTerm = "Thomas R. Marshall",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1913 to 3/4/1917",
                        VpSecondTerm = "Thomas R. Marshall",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "3/4/1917 to 3/4/1921",
                        PresidentialDateRange = "3/4/1913 to 3/4/1921",
                        LifeRange = "1856-1924",
                        AgeAtDeath = 67,
                        Party = "Democratic",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    29,
                    new PresidentsStats
                    {
                        President = "Warren G. Harding",
                        HasDiedInOfficePresident = true,
                        VpFirstTerm = "Calvin Coolidge",
                        VpFirstTermHasDiedInOffice = false,
                        VpFirstTermHasResignedInOffice = false,
                        VpFirstTermDateRange = "3/4/1921 to 8/2/1923",
                        VpSecondTerm = "",
                        VpSecondTermHasDiedInOffice = false,
                        VpSecondTermHasResignedInOffice = false,
                        VpSecondTermDateRange = "",
                        PresidentialDateRange = "3/4/1921 to 8/2/1923",
                        LifeRange = "1865-1923",
                        AgeAtDeath = 57,
                        Party = "Republican",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    30,
                    new PresidentsStats
                    {
                        President = "Calvin Coolidge",
                        HasDiedInOfficePresident = false,
                        VICEPRESIDENT = "Office Vacant (8/2/1923 to 3/4/1925), Charles G. Dawes (3/4/1925 to 3/4/1929)",
                        PresidentialDateRange = "August 2, 1923 to 3/4/1929",
                        LifeRange = "1872-1933",
                        Party = "Republican",
                        NumberOfTermsElected = 2
                    }
                },
                {
                    31,
                    new PresidentsStats
                    {
                        President = "Herbert Hoover",
                        VICEPRESIDENT = "Charles Curtis",
                        PresidentialDateRange = "3/4/1929 to 3/4/1933",
                        LifeRange = "1874-1964",
                        Party = "Republican",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    32,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    33,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    34,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    35,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    36,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    37,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    38,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    39,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    40,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    41,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    42,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    43,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    44,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                },
                {
                    45,
                    new PresidentsStats
                    {
                        President = "John Adams",
                        VICEPRESIDENT = "Thomas Jefferson",
                        PresidentialDateRange = "3/4/1797 to 3/4/1801",
                        LifeRange = "1735-1826",
                        Party = "Federalist",
                        NumberOfTermsElected = 1
                    }
                }
            };

            return presidents[presidentNumber];

        }

        private static void TicTacToe(User user)
        {
            Console.Clear();

            bool isPlaying = true;

            string[,] grid =
            {
                { "_","|_|","_"},
                { "_","|_|","_"},
                { " ","| |"," "}
            };

            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i, j]);
                }

                Console.Write("\n");
            }


            Console.WriteLine("\n\n\tHello {0}.  The rules are simple.\n\n" +
                              "\t1. Each number on your key pad represents a square on a Tic Tac Toe board.\n" +
                              "\t\tFor example 7 would be the upper left corner,\n" +
                              "\t\t5 would be the center square,\n" +
                              "\t\tand 3 would be the lower left sqaure.\n" +
                              "\t2. You will go first and be 'X'.\n" +
                              "\t3. After that, whoever wins goes first.\n\n" +
                              "\tPress ENTER when you are ready...", user.FirstName);
            Console.ReadLine();

            Console.Clear();

            bool easy = false;

            Console.Write("Difficulty: Easy or Medium (1 or 2)? ");

            while (true)
            {
                var ehInput = int.TryParse(Console.ReadLine(), out var easyOrHardResult);
                if (!ehInput)
                {
                    Console.WriteLine("Must be 1 or 2");
                    continue;
                }

                if (easyOrHardResult != 1 && easyOrHardResult != 2)
                {
                    Console.WriteLine("Must be a 1 or 2");

                }
                else
                {
                    switch (easyOrHardResult)
                    {
                        case 1: easy = true; break;
                    }

                    break;
                }
            }

            Console.Clear();

            int userTurn = 0;
            List<int> choices = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> userChoices = new List<int>();
            List<int> computerChoices = new List<int>();

            string[,] inGameGrid =
            {
                { "_","|_|","_"},
                { "_","|_|","_"},
                { " ","| |"," "}
            };

            int cpuCounter = 0;
            int youCounter = 0;
            int tieCounter = 0;

            while (isPlaying)
            {
                userTurn = userTurn == 0 ? 1 : 0;   //Toggles users

                var userResult = 0;
                var computerInput = 0;

                Random rnd = new Random();

                Console.WriteLine("\tCPU: {0} || {1} :{2}\n" +
                                  "\tTIE: {3}\n\n", cpuCounter, youCounter, user.FirstName, tieCounter);


                //Displays Grid
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("\t");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(inGameGrid[i, j]);
                    }

                    Console.Write("\n");
                }

                //Toggles Turns
                if (userTurn == 0)
                {
                    //Computer's Turn
                    while (true)
                    {
                        if (choices.Contains(5))
                        {
                            computerInput = 5;  //Center Square
                        }
                        else
                        {
                            if (choices.Count == 8)
                            {
                                int[] tempList = { 1, 7, 9, 3 };  //Gets one of four corners
                                computerInput = tempList[rnd.Next(1, 4)];
                            }
                            else
                            {
                                computerInput = NextMove(userChoices, computerChoices, choices, easy);

                            }
                        }

                        if (!choices.Contains(computerInput)) continue;
                        choices.Remove(computerInput);
                        Console.Write("\nMy Turn: {0}", computerInput);
                        computerChoices.Add(computerInput);
                        Thread.Sleep(1500);
                        break;
                    }
                }
                else
                {
                    //User's Turn
                    while (true)
                    {
                        Console.Write("\nYour Turn: ");

                        var userInput = int.TryParse(Console.ReadLine(), out userResult);

                        if (!userInput)
                        {
                            Console.WriteLine("Must be a number");
                        }
                        else
                        {
                            if (userResult >= 1 && userResult <= 9)
                            {
                                if (choices.Contains(userResult))
                                {
                                    choices.Remove(userResult);
                                    userChoices.Add(userResult);
                                    break;
                                }

                                Console.WriteLine("That spot's already taken...{0}.", user.FirstName);
                            }
                            Console.WriteLine("Come on {0}, must be between 1 and 9...", user.FirstName);
                        }
                    }
                }

                var boardLetter = userTurn == 1 ? "X" : "O";
                var boardInput = userTurn == 1 ? userResult : computerInput;

                switch (boardInput)
                {
                    case 1: inGameGrid[2, 0] = boardLetter; break;
                    case 2: inGameGrid[2, 1] = "|" + boardLetter + "|"; break;
                    case 3: inGameGrid[2, 2] = boardLetter; break;
                    case 4: inGameGrid[1, 0] = boardLetter; break;
                    case 5: inGameGrid[1, 1] = "|" + boardLetter + "|"; break;
                    case 6: inGameGrid[1, 2] = boardLetter; break;
                    case 7: inGameGrid[0, 0] = boardLetter; break;
                    case 8: inGameGrid[0, 1] = "|" + boardLetter + "|"; break;
                    case 9: inGameGrid[0, 2] = boardLetter; break;
                }



                var winner = CheckWinner(inGameGrid);

                if (!string.IsNullOrWhiteSpace(winner))
                {

                    switch (winner)
                    {
                        case "X":

                            Console.Clear();

                            Console.WriteLine("\tCPU: {0} || {1} :{2}\n" +
                                              "\tTIE: {3}\n\n", cpuCounter, youCounter, user.FirstName, tieCounter);

                            //Displays Grid
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("\t");
                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write(inGameGrid[i, j]);
                                }

                                Console.Write("\n");
                            }

                            Console.WriteLine("\nYour Turn: {0}", userResult);

                            Console.WriteLine("\nYou Win!!");
                            youCounter++;

                            if (tieCounter + cpuCounter + youCounter == 3) ContinuePlaying(user);

                            userTurn = 0;
                            break;
                        default:

                            Console.Clear();

                            Console.WriteLine("\tCPU: {0} || {1} :{2}\n" +
                                              "\tTIE: {3}\n\n", cpuCounter, youCounter, user.FirstName, tieCounter);


                            //Displays Grid
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("\t");
                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write(inGameGrid[i, j]);
                                }

                                Console.Write("\n");
                            }

                            Console.WriteLine("\nMy Turn: {0}", computerInput);
                            Console.WriteLine("\nI Win... :)");

                            cpuCounter++;

                            if (tieCounter + cpuCounter + youCounter == 3) ContinuePlaying(user);

                            userTurn = 1;
                            break;
                    }


                    //RESET
                    choices = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    userChoices.Clear();
                    computerChoices.Clear();

                    inGameGrid = new[,]
                    {
                        { "_","|_|","_"},
                        { "_","|_|","_"},
                        { " ","| |"," "}
                    };

                    Console.ReadLine();

                }

                if (choices.Count == 0)
                {
                    Console.Clear();

                    Console.WriteLine("\tCPU: {0} || {1} :{2}\n" +
                                      "\tTIE: {3}\n\n", cpuCounter, youCounter, user.FirstName, tieCounter);


                    //Displays Grid
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("\t");
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(inGameGrid[i, j]);
                        }

                        Console.Write("\n");
                    }

                    Console.WriteLine("\nIt's a Tie");
                    tieCounter++;

                    if (tieCounter + cpuCounter + youCounter == 10) ContinuePlaying(user);

                    //RESET
                    choices = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    userChoices.Clear();
                    computerChoices.Clear();
                    inGameGrid = new[,]
                    {
                        { "_","|_|","_"},
                        { "_","|_|","_"},
                        { " ","| |"," "}
                    };
                    Console.ReadLine();
                }


                Console.Clear();
            }
        }

        private static void ContinuePlaying(User user)
        {
            Console.Write("\nContinue, New Game, or Quit all together (C, N, Q)?  ");
            var inputQuit = Console.ReadLine().Trim().ToLower();

            if (!string.IsNullOrWhiteSpace(inputQuit))
            {
                switch (inputQuit.Substring(0, 1))
                {
                    case "c": Console.Clear(); break;
                    case "n": Console.Clear(); GameDecision(user); break;
                    case "q": Console.Clear(); Console.WriteLine("Have a Great Day, {0}!!", user.FirstName); Thread.Sleep(3000); Environment.Exit(0); break;
                    default: Console.WriteLine("You have to pick a C, N, or Q..."); break;
                }
            }
            else
            {
                Console.WriteLine("Come on {0}, You have to pick a C, N, or Q...", user.FirstName);
            }
        }

        private static int NextMove(List<int> userChoices, List<int> computerChoices, List<int> choices, bool easy)
        {
            var userMoves = userChoices;
            var computerMoves = computerChoices;
            var whatsLeft = choices;
            var rnd = new Random();

            //Winning Sets
            int[] firstRow = { 7, 8, 9 };
            var firstRowCntX = 0;
            var firstRowCntO = 0;

            int[] secondRow = { 4, 5, 6 };
            var secondRowCntX = 0;
            var secondRowCntO = 0;

            int[] thirdRow = { 1, 2, 3 };
            var thirdRowCntX = 0;
            var thirdRowCntO = 0;

            int[] firstColumn = { 7, 4, 1 };
            var firstColumnX = 0;
            var firstColumnO = 0;

            int[] secondColumn = { 8, 5, 2 };
            var secondColumnX = 0;
            var secondColumnO = 0;

            int[] thirdColumn = { 9, 6, 3 };
            var thirdColumnX = 0;
            var thirdColumnO = 0;

            int[] diagTopBottom = { 7, 5, 3 };
            var diagTopRowCntX = 0;
            var diagTopRowCntO = 0;

            int[] diagBottomTop = { 1, 5, 9 };
            var diagBottomRowCntX = 0;
            var diagBottomRowCntO = 0;

            //PLOTS WHERE Xs AND Os ARE BY USING COUNTERS
            foreach (var t in userMoves)
            {
                if (firstRow.Contains(t)) firstRowCntX++;
                if (secondRow.Contains(t)) secondRowCntX++;
                if (thirdRow.Contains(t)) thirdRowCntX++;
                if (firstColumn.Contains(t)) firstColumnX++;
                if (secondColumn.Contains(t)) secondColumnX++;
                if (thirdColumn.Contains(t)) thirdColumnX++;
                if (diagTopBottom.Contains(t)) diagTopRowCntX++;
                if (diagBottomTop.Contains(t)) diagBottomRowCntX++;
            }

            foreach (var t in computerMoves)
            {
                if (firstRow.Contains(t)) firstRowCntO++;
                if (secondRow.Contains(t)) secondRowCntO++;
                if (thirdRow.Contains(t)) thirdRowCntO++;
                if (firstColumn.Contains(t)) firstColumnO++;
                if (secondColumn.Contains(t)) secondColumnO++;
                if (thirdColumn.Contains(t)) thirdColumnO++;
                if (diagTopBottom.Contains(t)) diagTopRowCntO++;
                if (diagBottomTop.Contains(t)) diagBottomRowCntO++;
            }


            //BLOCKS X
            if (firstRowCntX == 2)
            {
                if (whatsLeft.Contains(7)) return 7;
                if (whatsLeft.Contains(8)) return 8;
                if (whatsLeft.Contains(9)) return 9;
            }

            if (secondRowCntX == 2)
            {
                if (whatsLeft.Contains(4)) return 4;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(6)) return 6;
            }

            if (thirdRowCntX == 2)
            {
                if (whatsLeft.Contains(1)) return 1;
                if (whatsLeft.Contains(2)) return 2;
                if (whatsLeft.Contains(3)) return 3;
            }

            if (firstColumnX == 2)
            {
                if (whatsLeft.Contains(7)) return 7;
                if (whatsLeft.Contains(4)) return 4;
                if (whatsLeft.Contains(1)) return 1;
            }

            if (secondColumnX == 2)
            {
                if (whatsLeft.Contains(8)) return 8;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(2)) return 2;
            }

            if (thirdColumnX == 2)
            {
                if (whatsLeft.Contains(9)) return 9;
                if (whatsLeft.Contains(6)) return 6;
                if (whatsLeft.Contains(3)) return 3;
            }

            if (diagTopRowCntX == 2)
            {
                if (whatsLeft.Contains(7)) return 7;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(3)) return 3;
            }

            if (diagBottomRowCntX == 2)
            {
                if (whatsLeft.Contains(1)) return 1;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(9)) return 9;
            }

            //ENSURES CPU CHOOSES CORNER SQUARES
            if (!easy)
            {
                if (choices.Count >= 6)
                {
                    int[] choicesLeft = { 1, 7, 9, 3 };

                    while (true)
                    {
                        if (whatsLeft.Contains(choicesLeft[rnd.Next(1, 4)])) return choicesLeft[rnd.Next(1, 4)];

                    }

                }
            }

            //IF DOUBLE O's, THEN FINISHES
            if (firstRowCntO == 2)
            {
                if (whatsLeft.Contains(7)) return 7;
                if (whatsLeft.Contains(8)) return 8;
                if (whatsLeft.Contains(9)) return 9;
            }

            if (secondRowCntO == 2)
            {
                if (whatsLeft.Contains(4)) return 4;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(6)) return 6;
            }

            if (thirdRowCntO == 2)
            {
                if (whatsLeft.Contains(1)) return 1;
                if (whatsLeft.Contains(2)) return 2;
                if (whatsLeft.Contains(3)) return 3;
            }

            if (firstColumnO == 2)
            {
                if (whatsLeft.Contains(7)) return 7;
                if (whatsLeft.Contains(4)) return 4;
                if (whatsLeft.Contains(1)) return 1;
            }

            if (secondColumnO == 2)
            {
                if (whatsLeft.Contains(8)) return 8;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(2)) return 2;
            }

            if (thirdColumnO == 2)
            {
                if (whatsLeft.Contains(9)) return 9;
                if (whatsLeft.Contains(6)) return 6;
                if (whatsLeft.Contains(3)) return 3;
            }

            if (diagTopRowCntO == 2)
            {
                if (whatsLeft.Contains(7)) return 7;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(3)) return 3;
            }

            if (diagBottomRowCntO == 2)
            {
                if (whatsLeft.Contains(1)) return 1;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(9)) return 9;
            }

            if (firstRowCntX + firstRowCntO == 2)
            {
                if (whatsLeft.Contains(7)) return 7;
                if (whatsLeft.Contains(8)) return 8;
                if (whatsLeft.Contains(9)) return 9;
            }

            if (secondRowCntX + secondRowCntO == 2)
            {
                if (whatsLeft.Contains(4)) return 4;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(6)) return 6;
            }

            if (thirdRowCntX + thirdRowCntO == 2)
            {
                if (whatsLeft.Contains(1)) return 1;
                if (whatsLeft.Contains(2)) return 2;
                if (whatsLeft.Contains(3)) return 3;
            }

            if (firstColumnX + firstColumnO == 2)
            {
                if (whatsLeft.Contains(7)) return 7;
                if (whatsLeft.Contains(4)) return 4;
                if (whatsLeft.Contains(1)) return 1;
            }

            if (secondColumnX + secondColumnO == 2)
            {
                if (whatsLeft.Contains(8)) return 8;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(2)) return 2;
            }

            if (thirdColumnX + thirdColumnO == 2)
            {
                if (whatsLeft.Contains(9)) return 9;
                if (whatsLeft.Contains(6)) return 6;
                if (whatsLeft.Contains(3)) return 3;
            }

            if (diagTopRowCntX + diagTopRowCntO == 2)
            {
                if (whatsLeft.Contains(7)) return 7;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(3)) return 3;
            }

            if (diagBottomRowCntX + diagBottomRowCntO == 2)
            {
                if (whatsLeft.Contains(1)) return 1;
                if (whatsLeft.Contains(5)) return 5;
                if (whatsLeft.Contains(9)) return 9;
            }

            return whatsLeft[rnd.Next(1, whatsLeft.Count)];
        }

        private static string CheckWinner(string[,] inGameGrid)
        {
            var b = inGameGrid;
            var winner = "";

            //Horizontal
            if (b[0, 0].Contains("X") && b[0, 1].Contains("X") && b[0, 2].Contains("X")) winner = "X";
            if (b[1, 0].Contains("X") && b[1, 1].Contains("X") && b[1, 2].Contains("X")) winner = "X";
            if (b[2, 0].Contains("X") && b[2, 1].Contains("X") && b[2, 2].Contains("X")) winner = "X";

            //Vertical
            if (b[0, 0].Contains("X") && b[1, 0].Contains("X") && b[2, 0].Contains("X")) winner = "X";
            if (b[0, 1].Contains("X") && b[1, 1].Contains("X") && b[2, 1].Contains("X")) winner = "X";
            if (b[0, 2].Contains("X") && b[1, 2].Contains("X") && b[2, 2].Contains("X")) winner = "X";

            //Diaganol
            if (b[0, 0].Contains("X") && b[1, 1].Contains("X") && b[2, 2].Contains("X")) winner = "X";
            if (b[0, 2].Contains("X") && b[1, 1].Contains("X") && b[2, 0].Contains("X")) winner = "X";

            //Horizontal
            if (b[0, 0].Contains("O") && b[0, 1].Contains("O") && b[0, 2].Contains("O")) winner = "O";
            if (b[1, 0].Contains("O") && b[1, 1].Contains("O") && b[1, 2].Contains("O")) winner = "O";
            if (b[2, 0].Contains("O") && b[2, 1].Contains("O") && b[2, 2].Contains("O")) winner = "O";

            //Vertical
            if (b[0, 0].Contains("O") && b[1, 0].Contains("O") && b[2, 0].Contains("O")) winner = "O";
            if (b[0, 1].Contains("O") && b[1, 1].Contains("O") && b[2, 1].Contains("O")) winner = "O";
            if (b[0, 2].Contains("O") && b[1, 2].Contains("O") && b[2, 2].Contains("O")) winner = "O";

            //Diaganol
            if (b[0, 0].Contains("O") && b[1, 1].Contains("O") && b[2, 2].Contains("O")) winner = "O";
            if (b[0, 2].Contains("O") && b[1, 1].Contains("O") && b[2, 0].Contains("O")) winner = "O";

            return winner;
        }

        private static void SearchAndRescue(User user)
        {
            Console.Clear();

            Random rnd = new Random();

            string[] gridLocations =
            {
                "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10",
                "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10",
                "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10",
                "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10",
                "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "E10",
                "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10",
                "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10",
                "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10",
                "I1", "I2", "I3", "I4", "I5", "I6", "I7", "I8", "I9", "I10",
                "J1", "J2", "J3", "J4", "J5", "J6", "J7", "J8", "J9", "J10"
            };

            string[,] map =
            {

               /*0 */ {" ","1","2","3", "4", "5", "6", "7", "8", "9", "10"},
               /*1 */ { "A"," "," "," ", " ", " ", " ", " ", " ", " ", " "},
               /*2 */ { "B"," "," "," ", " ", " ", " ", " ", " ", " ", " "},
               /*3 */ { "C"," "," "," ", " ", " ", " ", " ", " ", " ", " "},
               /*4 */ { "D"," "," "," ", " ", " ", " ", " ", " ", " ", " "},
               /*5 */ { "E"," "," "," ", " ", " ", " ", " ", " ", " ", " "},
               /*6*/  { "F"," "," "," ", " ", " ", " ", " ", " ", " ", " "},
               /*7*/  { "G"," "," "," ", " ", " ", " ", " ", " ", " ", " "},
               /*8 */ { "H"," "," "," ", " ", " ", " ", " ", " ", " ", " "},
               /*9*/  { "I"," "," "," ", " ", " ", " ", " ", " ", " ", " "},
               /*10*/ { "J"," "," "," ", " ", " ", " ", " ", " ", " ", " "}
            };

            for (int i = 0; i < 11; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(map[i, j] + " | ");
                }

                Console.Write("\n");
            }

            Console.WriteLine("\n\nHello {0}.  " +
                              "The above grid represents the area where an aircraft went down approx. 2 hours ago.\n\n" +
                              "Your job is to figure out where the aircraft is within 5 guesses.\n\n" +
                              "After entering a grid location, a mark will be placed in your chosen grid.\n" +
                              "\t'X': Selected Coordinate\n" +
                              "\t'C': Close to Target - Either on same vertical or horizontal line\n" +
                              "\t'O': Plane Located\n\n" +
                              "Press ENTER when you are ready...", user.FirstName);

            Console.ReadLine();
            Console.Clear();

            var counter = 0;

            while (counter < 5)
            {
                var aircraftLocation = gridLocations[rnd.Next(0, 100)];

                //Console.WriteLine(aircraftLocation);
                //Console.ReadLine();

                for (int i = 0; i < 11; i++)
                {
                    Console.Write("\t");
                    for (int j = 0; j < 11; j++)
                    {
                        Console.Write(map[i, j] + " | ");
                    }

                    Console.Write("\n");
                }

                //Check if user entered appropriate coordinate
                while (true)
                {
                    Console.Write("Enter Coordinate: ");
                    var input = Console.ReadLine().ToUpper();

                    if (!gridLocations.Contains(input))
                    {
                        Console.WriteLine("You must enter a valid coordinate (Example, A1 or J7)");
                        continue;
                    }
                    break;
                }



            }



        }

        private static void HolidayQuiz(User user)
        {
            Console.Clear();
            Console.WriteLine("Hi {0}.  How well do you know your 2018 holidays??\n\n" +
                              "\t1. Choose how many questions you would like to do.\n" +
                              "\t2. I will display the holiday.\n" +
                              "\t3. You will then enter the month number (eg Dec is 12).\n" +
                              "\nPretty easy, right??  Press ENTER to begin...", user.FirstName);

            Console.ReadLine();
            Console.Clear();


            var holidays = GetHolidays();
            var counter = 0;
            var isPlaying = true;
            while (isPlaying)
            {
                int questionResult;

                while (true)
                {
                    Console.WriteLine("How many questions would you like to do?");
                    var numQuestions = int.TryParse(Console.ReadLine(), out questionResult);

                    if (!numQuestions)
                    {
                        Console.WriteLine("Must be a number...");
                    }
                    else
                    {
                        if (questionResult > holidays.Count)
                        {
                            Console.WriteLine("Must be less than {0}...", holidays.Count);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                Random rnd = new Random();

                int keyNumber;
                string display;

                for (int i = 0; i < questionResult; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Jan=1 | Feb=2 | Mar=3 | Apr=4 | May=5 | Jun=6 | Jul=7 | Aug=8 | Sep=9 | Oct=10 | Nov=11 | Dec=12\n\n");

                    while (true)
                    {
                        keyNumber = rnd.Next(1, holidays.Count);

                        if (holidays.ContainsKey(keyNumber)) break;

                    }

                    display = holidays[keyNumber].NAME + " is celebrated in what month?\n";

                    if (!string.IsNullOrWhiteSpace(holidays[keyNumber].DATE))
                    {
                        display = display + "\n\t\tDate: " + holidays[keyNumber].DATE;
                    }

                    if (!string.IsNullOrWhiteSpace(holidays[keyNumber].TYPE))
                    {
                        display = display + "\n\t\tType: " + holidays[keyNumber].TYPE;
                    }

                    if (!string.IsNullOrWhiteSpace(holidays[keyNumber].STATE))
                    {
                        display = display + "\n\t\tCelebrated in " + holidays[keyNumber].STATE;
                    }


                    Console.WriteLine("\t" + display + "\n\t");
                    Console.Write("\tYour Answer: ");

                    int userGuess;

                    while (true)
                    {
                        var inputGuess = int.TryParse(Console.ReadLine(), out userGuess);

                        if (!inputGuess)
                        {
                            Console.WriteLine("\n\tMust be a number");
                            continue;
                        }

                        if (userGuess < 1 || userGuess > 12)
                        {
                            Console.WriteLine("\n\tCome on {0}. You have to choose between 1 and 12.", user.FirstName);
                        }
                        else
                        {
                            break;
                        }
                    }

                    string month;

                    switch (holidays[keyNumber].MONTH)
                    {
                        case 1: month = "January"; break;
                        case 2: month = "February"; break;
                        case 3: month = "March"; break;
                        case 4: month = "April"; break;
                        case 5: month = "May"; break;
                        case 6: month = "June"; break;
                        case 7: month = "July"; break;
                        case 8: month = "August"; break;
                        case 9: month = "September"; break;
                        case 10: month = "October"; break;
                        case 11: month = "November"; break;
                        default: month = "December"; break;
                    }

                    if (userGuess == holidays[keyNumber].MONTH)
                    {
                        Console.WriteLine("\n\t" + month + "!! Great job!!");
                        counter++;
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("\n\tSorry... it was " + month);
                        Thread.Sleep(2000);
                    }

                    holidays.Remove(keyNumber);
                }

                Console.WriteLine("So far you have {0} correct....\n", counter);

                ContinuePlaying(user);
            }
        }

        private static Dictionary<int, Holiday> GetHolidays()
        {
            var usHolidays = new Dictionary<int, Holiday>
            {
                { 1, new Holiday { NAME = "New Year's Day", MONTH = 1, STATE = "", TYPE = "Federal Holiday", DATE = "1st"}},
                { 2, new Holiday { NAME = "New Year's Eve Observed" , MONTH = 1, STATE = "LA, MI, WI", TYPE = "State Holiday", DATE = "1st"}},
                {3, new Holiday {NAME = "Epiphany", MONTH = 1, STATE = "", TYPE = "Christian", DATE = "6th"} },
                {4, new Holiday {NAME = "Orthodox Christmas Day", MONTH = 1, STATE = "", TYPE = "Orthodox", DATE = "7th"} },
                {5, new Holiday {NAME = "Lee Jackson Day", MONTH = 1, STATE = "Virginia", TYPE = "State Holiday", DATE = "12th"} },
                {6, new Holiday {NAME = "Stephen Foster Memorial Day", MONTH = 1, STATE = "", TYPE = "Observance", DATE = "13th"} },
                {7, new Holiday {NAME = "Orthodox New Year", MONTH = 1, STATE = "", TYPE = "Orthodox", DATE = "14th"} },
                {8, new Holiday {NAME = "Martin Luther King Jr. Day", MONTH = 1, STATE = "", TYPE = "Federal Holiday", DATE = "15th"} },
                {9, new Holiday {NAME = "Robert E. Lee's Birthday", MONTH = 1, STATE = "Alabama, Mississippi, and Florida", TYPE = "State Holiday", DATE = "15th"} },
                {10, new Holiday {NAME = "Idaho Human Rights Day", MONTH = 1, STATE = "", TYPE = "State Holiday", DATE = "15th"} },
                {11, new Holiday {NAME = "Civil Rights Day", MONTH = 1, STATE = "Arizona and New Hampshire", TYPE = "State Holiday", DATE = "15th"} },
                {12, new Holiday {NAME = "Confederate Memorial Day", MONTH = 1, STATE = "Texas", TYPE = "State Holiday", DATE = "19th"} },
                {13, new Holiday {NAME = "Kansas Day", MONTH = 1, STATE = "", TYPE = "Observance", DATE = "29th"} },
                {14, new Holiday {NAME = "Tu Bishvat/Tu B'Shevat", MONTH = 1, STATE = "", TYPE = "Jewish Holiday", DATE = "31st"} },
                {15, new Holiday {NAME = "National Freedom Day", MONTH = 2, STATE = "", TYPE = "", DATE = "1st"} },
                {16, new Holiday {NAME = "Groundhog Day", MONTH = 2, STATE = "", TYPE = "Observance", DATE = "2nd"} },
                {17, new Holiday {NAME = "National Wear Red Day", MONTH = 2, STATE = "", TYPE = "Observance", DATE = "2nd"} },
                {18, new Holiday {NAME = "Rosa Parks Day", MONTH = 2, STATE = "California and Ohio", TYPE = "Local Observance", DATE = "4th"} },
                {19, new Holiday {NAME = "Super Bowl", MONTH = 2, STATE = "", TYPE = "Sporting Event", DATE = "4th"} },
                {20, new Holiday {NAME = "Lincoln's Birthday", MONTH = 2, STATE = "CT, IL, MO, NY, and FL", TYPE = "State Holiday and Local Observance (FL)", DATE = "12th"} },
                {21, new Holiday {NAME = "Maha Shivaratri", MONTH = 2, STATE = "", TYPE = "Hindu Holiday", DATE = "13th"} },
                {22, new Holiday {NAME = "Shrove Tuesday/Mardi Gras", MONTH = 2, STATE = "Alabama, Lousiana, and Florida", TYPE = "Observance, State Holiday (AL,LA), and Local Observance (FL)", DATE = "13th"} },
                {23, new Holiday {NAME = "Ash Wednesday", MONTH = 2, STATE = "", TYPE = "Christian Holiday", DATE = "14th"} },
                {24, new Holiday {NAME = "Valentine's Day", MONTH = 2, STATE = "", TYPE = "Observance", DATE = "14th"} },
                {25, new Holiday {NAME = "Statehood Day in Arizona", MONTH = 2, STATE = "", TYPE = "Local Observance", DATE = "14th"} },
                {26, new Holiday {NAME = "Susan B. Anthony's Birthday", MONTH = 2, STATE = "CA, FL, NY, WI", TYPE = "Local Observance", DATE = "15th"} },
                {27, new Holiday {NAME = "Chinese New Year", MONTH = 2, STATE = "", TYPE = "Observance", DATE = "16th"} },
                {28, new Holiday {NAME = "Elizabeth Peratrovich Day", MONTH = 2, STATE = "Alaska", TYPE = "Local Observance", DATE = "16th"} },
                {29, new Holiday {NAME = "Presidents' Day", MONTH = 2, STATE = "All EXCEPT DE, GA, IA, IN, KS, KY, LA, NC, NM, RI, WI", TYPE = "Federal Holiday", DATE = "19th"} },
                {30, new Holiday {NAME = "Daisy Gatson Bates Day", MONTH = 2, STATE = "Arkansas", TYPE = "State Holiday", DATE = "19th"} },
                {31, new Holiday {NAME = "Linus Pauling Day", MONTH = 2, STATE = "Oregon", TYPE = "Local Observance", DATE = "28th"} },
                {32, new Holiday {NAME = "Purim", MONTH = 3, STATE = "", TYPE = "Jewish Holiday", DATE = "1st"} },
                {33, new Holiday {NAME = "St. David's Day", MONTH = 3, STATE = "", TYPE = "Observance", DATE = "1st"} },
                {34, new Holiday {NAME = "Holi", MONTH = 3, STATE = "", TYPE = "Hindu Holiday", DATE = "2nd"} },
                {35, new Holiday {NAME = "Texas Independence Day", MONTH = 3, STATE = "", TYPE = "State Holiday", DATE = "2nd"} },
                {36, new Holiday {NAME = "Read Across America Day", MONTH = 3, STATE = "", TYPE = "Observance", DATE = "2nd"} },
                {37, new Holiday {NAME = "Employee Appreciation Day", MONTH = 3, STATE = "", TYPE = "Observance", DATE = "2nd"} },
                {38, new Holiday {NAME = "Casimir Pulaski Day", MONTH = 3, STATE = "Illinoi", TYPE = "State Holiday", DATE = "5th"} },
                {39, new Holiday {NAME = "Town Meeting Day Vermont", MONTH = 3, STATE = "", TYPE = "State Holiday", DATE = "6th"} },
                {40, new Holiday {NAME = "Daylight Savings Time", MONTH = 3, STATE = "", TYPE = "Clock Change", DATE = "11th"} },
                {41, new Holiday {NAME = "Evacuation Day", MONTH = 3, STATE = "Massachusetts", TYPE = "State Holiday", DATE = "16th"} },
                {42, new Holiday {NAME = "St. Patrick's Day", MONTH = 3, STATE = "", TYPE = "Observance", DATE = "17th"} },
                {43, new Holiday {NAME = "March Equinox", MONTH = 3, STATE = "", TYPE = "Season", DATE = "20th"} },
                {44, new Holiday {NAME = "Palm Sunday", MONTH = 3, STATE = "", TYPE = "Christian", DATE = "25th"} },
                {45, new Holiday {NAME = "Maryland Day", MONTH = 3, STATE = "", TYPE = "Local Observance", DATE = "25th"} },
                {46, new Holiday {NAME = "Prince Jonah Kuhio Kalanianaole Day", MONTH = 3, STATE = "Hawaii", TYPE = "State Holiday", DATE = "26th"} },
                {47, new Holiday {NAME = "Seward's Day", MONTH = 3, STATE = "Alaska", TYPE = "State Holiday", DATE = "26th"} },
                {48, new Holiday {NAME = "Maundy Thursday", MONTH = 3, STATE = "", TYPE = "Christian", DATE = "29th"} },
                {49, new Holiday {NAME = "Good Friday", MONTH = 3, STATE = "13 States", TYPE = "State Holiday", DATE = "30th"} },
                {50, new Holiday {NAME = "Holy Saturday", MONTH = 3, STATE = "", TYPE = "Christian", DATE = "31st"} },
                {51, new Holiday {NAME = "Passover (First Day)", MONTH = 3, STATE = "", TYPE = "Jewish Holiday", DATE = "31st"} },
                {52, new Holiday {NAME = "Cesar Chavez Day", MONTH = 3, STATE = "CA, CO, TX", TYPE = "State Holiday", DATE = "31st"} },
                {53, new Holiday {NAME = "Easter Sunday", MONTH = 4, STATE = "", TYPE = "Observance, Christian", DATE = "1st"} },
                {54, new Holiday {NAME = "Pascua Florida Day", MONTH = 4, STATE = "", TYPE = "Local Observance", DATE = "2nd"} },
                {55, new Holiday {NAME = "Orthodox Good Friday", MONTH = 4, STATE = "", TYPE = "Orthodox", DATE = "6th"} },
                {56, new Holiday {NAME = "National Tartan Day", MONTH = 4, STATE = "", TYPE = "Observance", DATE = "6th"} },
                {57, new Holiday {NAME = "Last Day of Passover", MONTH = 4, STATE = "", TYPE = "Jewish Holiday", DATE = "7th"} },
                {58, new Holiday {NAME = "Orthodox Holy Saturday", MONTH = 4, STATE = "", TYPE = "Orthodox", DATE = "7th"} },
                {59, new Holiday {NAME = "Orthodox Easter", MONTH = 4, STATE = "", TYPE = "Orthodox", DATE = "8th"} },
                {60, new Holiday {NAME = "National Library Workers' Day", MONTH = 4, STATE = "", TYPE = "Observance", DATE = "10th"} },
                {61, new Holiday {NAME = "Yom HaShoah", MONTH = 4, STATE = "", TYPE = "Jewish Holiday", DATE = "11th"} },
                {62, new Holiday {NAME = "Isra and Mi'raj", MONTH = 4, STATE = "", TYPE = "Muslim Holiday", DATE = "13th"} },
                {63, new Holiday {NAME = "Thomas Jefferson's Birthday", MONTH = 4, STATE = "", TYPE = "Observance", DATE = "13th"} },
                {64, new Holiday {NAME = "Father Damien Day", MONTH = 4, STATE = "Hawaii", TYPE = "Local Observance", DATE = "15th"} },
                {65, new Holiday {NAME = "Emancipation Day", MONTH = 4, STATE = "District of Columbia", TYPE = "State Holiday", DATE = "16th"} },
                {66, new Holiday {NAME = "Patriot's Day", MONTH = 4, STATE = "Maine, Massachusetts", TYPE = "State Holiday", DATE = "16th"} },
                {67, new Holiday {NAME = "Tax Day", MONTH = 4, STATE = "", TYPE = "Observance", DATE = "17th"} },
                {68, new Holiday {NAME = "Yom Ha'atzmaut", MONTH = 4, STATE = "", TYPE = "Jewish Holiday", DATE = "19th"} },
                {69, new Holiday {NAME = "San Jacinto Day", MONTH = 4, STATE = "Texas", TYPE = "State Holiday", DATE = "21st"} },
                {70, new Holiday {NAME = "Oklahoma Day", MONTH = 4, STATE = "", TYPE = "Local Observance", DATE = "22nd"} },
                {71, new Holiday {NAME = "Confederate Memorial Day", MONTH = 4, STATE = "Alabama, Florida, Mississippi", TYPE = "State Holiday", DATE = "23rd"} },
                {72, new Holiday {NAME = "State Holiday", MONTH = 4, STATE = "Georgia", TYPE = "State Holiday", DATE = "23rd"} },
                {73, new Holiday {NAME = "Administrative Professionals Day", MONTH = 4, STATE = "", TYPE = "Observance", DATE = "25th"} },
                {74, new Holiday {NAME = "Law Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "1st"} },
                {75, new Holiday {NAME = "Loyalty Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "1st"} },
                {76, new Holiday {NAME = "Lei Day", MONTH = 5, STATE = "Hawaii", TYPE = "Local Observance", DATE = "1st"} },
                {77, new Holiday {NAME = "Lag BaOmer", MONTH = 5, STATE = "", TYPE = "Jewish Holiday", DATE = "3rd"} },
                {78, new Holiday {NAME = "National Day of Prayer", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "3rd"} },
                {79, new Holiday {NAME = "Kent State Shootings Remembrance", MONTH = 5, STATE = "Ohio", TYPE = "Local Observance", DATE = "4th"} },
                {80, new Holiday {NAME = "Kentucky Oaks", MONTH = 5, STATE = "", TYPE = "Sporting Event", DATE = "4th"} },
                {81, new Holiday {NAME = "Rhode Island Independance Day", MONTH = 5, STATE = "", TYPE = "Local Observance", DATE = "4th"} },
                {82, new Holiday {NAME = "Cinco de Mayo", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "5th"} },
                {83, new Holiday {NAME = "National Explosive Ordnance Disposal (EOD) Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "5th"} },
                {84, new Holiday {NAME = "National Nurses Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "6th"} },
                {85, new Holiday {NAME = "Truman Day", MONTH = 5, STATE = "Missouri", TYPE = "State Holiday", DATE = "8th"} },
                {86, new Holiday {NAME = "Primary Election Day West Virginia", MONTH = 5, STATE = "", TYPE = "State Holiday", DATE = "8th"} },
                {87, new Holiday {NAME = "Ascension Day", MONTH = 5, STATE = "", TYPE = "Christian", DATE = "10th"} },
                {88, new Holiday {NAME = "Confederate Memorial Day", MONTH = 5, STATE = "North and South Carolina", TYPE = "State Holiday (SC) and Local Observance (NC)", DATE = "10th"} },
                {89, new Holiday {NAME = "Military Spouse Appreciation Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "11th"} },
                {90, new Holiday {NAME = "Mother's Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "13th"} },
                {91, new Holiday {NAME = "Peace Officers Memorial Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "15th"} },
                {92, new Holiday {NAME = "Ramadan starts", MONTH = 5, STATE = "", TYPE = "Muslim", DATE = "16th"} },
                {93, new Holiday {NAME = "National Defense Transportation Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "18th"} },
                {94, new Holiday {NAME = "Armed Forces Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "19th"} },
                {95, new Holiday {NAME = "Pentecost", MONTH = 5, STATE = "", TYPE = "Christian", DATE = "20th"} },
                {96, new Holiday {NAME = "Shavuot", MONTH = 5, STATE = "", TYPE = "Jewish", DATE = "20th"} },
                {97, new Holiday {NAME = "Whit Monday", MONTH = 5, STATE = "", TYPE = "Christian", DATE = "21st"} },
                {98, new Holiday {NAME = "National Maritime Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "22nd"} },
                {99, new Holiday {NAME = "Harvey Milk Day", MONTH = 5, STATE = "California", TYPE = "Local Observance", DATE = "22nd"} },
                {100, new Holiday {NAME = "Emergency Medical Services for Children Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "23rd"} },
                {101, new Holiday {NAME = "National Missing Children's Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "25th"} },
                {102, new Holiday {NAME = "Trinity Sunday", MONTH = 5, STATE = "", TYPE = "Christian", DATE = "27th"} },
                {103, new Holiday {NAME = "Memorial Day", MONTH = 5, STATE = "", TYPE = "Federal Holiday", DATE = "28th"} },
                {104, new Holiday {NAME = "Jefferson Davis Birthday", MONTH = 5, STATE = "Mississippi", TYPE = "Local Observance", DATE = "28th"} },
                {105, new Holiday {NAME = "Corpus Christi", MONTH = 5, STATE = "", TYPE = "Christian", DATE = "31st"} },
                {106, new Holiday {NAME = "Statehood Day", MONTH = 6, STATE = "Kentucky, Tennessee", TYPE = "Local Observance", DATE = "1st"} },
                {107, new Holiday {NAME = "Jefferson Davis Birthday", MONTH = 6, STATE = "Florida, Alabama", TYPE = "Local Observance (FL), State Holiday (AL)", DATE = "3rd (FL), 4th (AL)"} },
                {108, new Holiday {NAME = "D-Day", MONTH = 6, STATE = "", TYPE = "Observance", DATE = "6th"} },
                {109, new Holiday {NAME = "Lailat al-Qadr", MONTH = 6, STATE = "", TYPE = "Muslim", DATE = "10th"} },
                {110, new Holiday {NAME = "Kamehameha Day", MONTH = 6, STATE = "Hawaii", TYPE = "State Holiday", DATE = "11th"} },
                {111, new Holiday {NAME = "Army Birthday", MONTH = 6, STATE = "", TYPE = "Observance", DATE = "14th"} },
                {112, new Holiday {NAME = "Flag Day", MONTH = 6, STATE = "", TYPE = "Observance", DATE = "14th"} },
                {113, new Holiday {NAME = "Eid al-Fitr", MONTH = 6, STATE = "", TYPE = "Muslim", DATE = "15th"} },
                {114, new Holiday {NAME = "Father's Day", MONTH = 6, STATE = "", TYPE = "Observance", DATE = "17th"} },
                {115, new Holiday {NAME = "Bunker Hill Day", MONTH = 6, STATE = "Massachusetts", TYPE = "State Holiday", DATE = "17th, 18th (Observerd)"} },
                {116, new Holiday {NAME = "Juneteenth", MONTH = 6, STATE = "All EXCEPT HI, MD, MP, MT, ND, NG, SD, TX, UT", TYPE = "Local Observance", DATE = "19th"} },
                {117, new Holiday {NAME = "Emancipation Day", MONTH = 6, STATE = "Texas", TYPE = "State Holiday", DATE = "19th"} },
                {118, new Holiday {NAME = "West Virginia Day", MONTH = 6, STATE = "", TYPE = "State Holiday", DATE = "20th"} },
                {119, new Holiday {NAME = "American Eagle Day", MONTH = 6, STATE = "", TYPE = "Observance", DATE = "20th"} },
                {120, new Holiday {NAME = "June Solstice", MONTH = 6, STATE = "", TYPE = "Season", DATE = "21st"} },
                {121, new Holiday {NAME = "Independence Day", MONTH = 7, STATE = "", TYPE = "Federal Holiday", DATE = "4th"} },
                {122, new Holiday {NAME = "Tisha B'Av", MONTH = 7, STATE = "", TYPE = "Jewish Holiday", DATE = "22nd"} },
                {123, new Holiday {NAME = "Parents' Day", MONTH = 7, STATE = "", TYPE = "Observance", DATE = "22nd"} },
                {124, new Holiday {NAME = "Pioneer Day", MONTH = 7, STATE = "Utah", TYPE = "State Holiday", DATE = "24th"} },
                {125, new Holiday {NAME = "National Korean War Veterans Armistice Day", MONTH = 7, STATE = "", TYPE = "Observance", DATE = "27th"} },
                {126, new Holiday {NAME = "Colorado Day", MONTH = 8, STATE = "", TYPE = "Local Observance", DATE = "1st"} },
                {127, new Holiday {NAME = "Coast Guard Birthday", MONTH = 8, STATE = "", TYPE = "Observance", DATE = "4th"} },
                {128, new Holiday {NAME = "Purple Heart Day", MONTH = 8, STATE = "", TYPE = "Observance", DATE = "7th"} },
                {129, new Holiday {NAME = "Victory Day", MONTH = 8, STATE = "Rhode Island", TYPE = "State Holiday", DATE = "13th"} },
                {130, new Holiday {NAME = "Assumption of Mary", MONTH = 8, STATE = "", TYPE = "Christian", DATE = "15th"} },
                {131, new Holiday {NAME = "Bennington Battle Day", MONTH = 8, STATE = "Vermont", TYPE = "State Holiday", DATE = "16th"} },
                {132, new Holiday {NAME = "Statehood Day", MONTH = 8, STATE = "Hawaii", TYPE = "State Holiday", DATE = "17th"} },
                {133, new Holiday {NAME = "National Aviation Day", MONTH = 8, STATE = "", TYPE = "Observance", DATE = "19th"} },
                {134, new Holiday {NAME = "Senior Citizens Day", MONTH = 8, STATE = "", TYPE = "Observance", DATE = "21st"} },
                {135, new Holiday {NAME = "Eid al-Adha", MONTH = 8, STATE = "", TYPE = "Muslim", DATE = "22nd"} },
                {136, new Holiday {NAME = "Raksha Bandhan", MONTH = 8, STATE = "", TYPE = "Hindu Holiday", DATE = "25th"} },
                {137, new Holiday {NAME = "Women's Equaliy Day", MONTH = 8, STATE = "", TYPE = "Observance", DATE = "26th"} },
                {138, new Holiday {NAME = "Lyndon Baines Johnson Day", MONTH = 8, STATE = "Texas", TYPE = "State Holiday", DATE = "27th"} },
                {139, new Holiday {NAME = "Janmashtami", MONTH = 9, STATE = "", TYPE = "Hindu Holiday", DATE = "2nd"} },
                {140, new Holiday {NAME = "Labor Day", MONTH = 9, STATE = "", TYPE = "Federal Holiday", DATE = "3rd"} },
                {141, new Holiday {NAME = "Carl Garner Federal Lands Cleanup Day", MONTH = 9, STATE = "", TYPE = "Observance", DATE = "8th"} },
                {142, new Holiday {NAME = "National Grandparents Day", MONTH = 9, STATE = "", TYPE = "Observance", DATE = "9th"} },
                {143, new Holiday {NAME = "California Admission Day", MONTH = 9, STATE = "", TYPE = "Local Observance", DATE = "9th"} },
                {144, new Holiday {NAME = "Rosh Hashana", MONTH = 9, STATE = "Texas", TYPE = "State Holiday, Jewish Holiday", DATE = "10th"} },
                {145, new Holiday {NAME = "Patriot Day", MONTH = 9, STATE = "", TYPE = "Observance", DATE = "11th"} },
                {146, new Holiday {NAME = "Ganesh Chaurthi", MONTH = 9, STATE = "", TYPE = "Hindu Holiday", DATE = "12th"} },
                {147, new Holiday {NAME = "Muharram", MONTH = 9, STATE = "", TYPE = "Muslim", DATE = "12th"} },
                {148, new Holiday {NAME = "National CleanUp Day", MONTH = 9, STATE = "", TYPE = "Observance", DATE = "15th"} },
                {149, new Holiday {NAME = "Constitution Day and Citizenship Day", MONTH = 9, STATE = "", TYPE = "Observance", DATE = "17th"} },
                {150, new Holiday {NAME = "Air Force Birthday", MONTH = 9, STATE = "", TYPE = "Observance", DATE = "18th"} },
                {151, new Holiday {NAME = "Yom Kippur", MONTH = 9, STATE = "Texas", TYPE = "State Holiday, Jewish Holiday", DATE = "19th"} },
                {152, new Holiday {NAME = "National POW/MIA Recognition Day", MONTH = 9, STATE = "", TYPE = "Observance", DATE = "21st"} },
                {153, new Holiday {NAME = "Emancipation Day", MONTH = 9, STATE = "Ohio", TYPE = "Local Observance", DATE = "22nd"} },
                {154, new Holiday {NAME = "September Equinox", MONTH = 9, STATE = "", TYPE = "Season", DATE = "23rd"} },
                {155, new Holiday {NAME = "First Day of Sukkot", MONTH = 9, STATE = "", TYPE = "Jewish Holiday", DATE = "24th"} },
                {156, new Holiday {NAME = "Native Americans' Day", MONTH = 9, STATE = "California", TYPE = "Local Observance", DATE = "28th"} },
                {157, new Holiday {NAME = "Last Day of Sukkot", MONTH = 9, STATE = "", TYPE = "Jewish Holiday", DATE = "30th"} },
                {158, new Holiday {NAME = "Gold Star Mother's Day", MONTH = 9, STATE = "", TYPE = "Observance", DATE = "30th"} },
                {159, new Holiday {NAME = "Shmini Atzeret", MONTH = 10, STATE = "", TYPE = "Jewish Holiday", DATE = "1st"} },
                {160, new Holiday {NAME = "Feast of St. Francis of Assisi", MONTH = 10, STATE = "", TYPE = "Christian", DATE = "4th"} },
                {161, new Holiday {NAME = "Columbus Day", MONTH = 10, STATE = "All EXCEPT AK, AR, CA, DE, FL, HI, MI MN, ND, NV, OR, SD, TX, VT, WA, WY", TYPE = "Federal Holiday, Local Observance (FL)", DATE = "8th"} },
                {162, new Holiday {NAME = "Native Americans' Day", MONTH = 10, STATE = "South Dakota", TYPE = "Local Observance", DATE = "8th"} },
                {163, new Holiday {NAME = "Indigenous People's Day", MONTH = 10, STATE = "AK, CA, MN, WA", TYPE = "Local Observance", DATE = "8th"} },
                {164, new Holiday {NAME = "Navaratri", MONTH = 10, STATE = "", TYPE = "Hindu Holiday", DATE = "9th"} },
                {165, new Holiday {NAME = "Leif Erikson Day", MONTH = 10, STATE = "", TYPE = "Observance", DATE = "9th"} },
                {166, new Holiday {NAME = "Navy Birthday", MONTH = 10, STATE = "", TYPE = "Observance", DATE = "13th"} },
                {167, new Holiday {NAME = "White Cane Safety Day", MONTH = 10, STATE = "", TYPE = "Observance", DATE = "15th"} },
                {168, new Holiday {NAME = "Boss's Day", MONTH = 10, STATE = "", TYPE = "Observance", DATE = "16th"} },
                {169, new Holiday {NAME = "Dussehra", MONTH = 10, STATE = "", TYPE = "Hindu Holiday", DATE = "18th"} },
                {170, new Holiday {NAME = "Alaska Day", MONTH = 10, STATE = "", TYPE = "State Holiday", DATE = "18th"} },
                {171, new Holiday {NAME = "Sweetest Day", MONTH = 10, STATE = "13 States", TYPE = "Observance", DATE = "20th"} },
                {172, new Holiday {NAME = "Nevada Day", MONTH = 10, STATE = "", TYPE = "State Holiday", DATE = "26th"} },
                {173, new Holiday {NAME = "Halloween", MONTH = 10, STATE = "", TYPE = "Observance", DATE = "31st"} },
                {174, new Holiday {NAME = "All Saints' Day", MONTH = 11, STATE = "", TYPE = "Christian", DATE = "1st"} },
                {175, new Holiday {NAME = "All souls' Day", MONTH = 11, STATE = "", TYPE = "Christian", DATE = "2nd"} },
                {176, new Holiday {NAME = "Daylight Savings Time ends", MONTH = 11, STATE = "", TYPE = "Clock change/Daylight Saving Time", DATE = "4th"} },
                {177, new Holiday {NAME = "Election Day", MONTH = 11, STATE = "14 States", TYPE = "State Holiday", DATE = "6th"} },
                {178, new Holiday {NAME = "Diwali/Deepavali", MONTH = 11, STATE = "", TYPE = "Observance", DATE = "6th"} },
                {179, new Holiday {NAME = "Return Day", MONTH = 11, STATE = "Delaware", TYPE = "State Holiday", DATE = "8th"} },
                {180, new Holiday {NAME = "Marine Corps Birthday", MONTH = 11, STATE = "", TYPE = "Observance", DATE = "10th"} },
                {181, new Holiday {NAME = "Veterans Day", MONTH = 11, STATE = "", TYPE = "Federal Holiday", DATE = "10th, 11th (Observed)"} },
                {182, new Holiday {NAME = "The Prophet's Birthday", MONTH = 11, STATE = "", TYPE = "Muslim", DATE = "21nd"} },
                {183, new Holiday {NAME = "Thanksgiving Day", MONTH = 11, STATE = "", TYPE = "Federal Holiday", DATE = "22nd"} },
                {184, new Holiday {NAME = "State Holiday", MONTH = 11, STATE = "Georgia", TYPE = "State Holiday", DATE = "23rd"} },
                {185, new Holiday {NAME = "Presidents' Day", MONTH = 11, STATE = "New Mexico", TYPE = "State Holiday", DATE = "23rd"} },
                {186, new Holiday {NAME = "Lincoln's Birthday/Lincoln's Day", MONTH = 11, STATE = "Indiana, West Virginia", TYPE = "State Holiday", DATE = "23rd"} },
                {187, new Holiday {NAME = "Day After Thanksgiving", MONTH = 11, STATE = "22 States", TYPE = "State Holiday", DATE = "23rd"} },
                {188, new Holiday {NAME = "Family Day", MONTH = 11, STATE = "Nevada", TYPE = "State Holiday", DATE = "23rd"} },
                {189, new Holiday {NAME = "Black Friday", MONTH = 11, STATE = "", TYPE = "Observance", DATE = "23rd"} },
                {190, new Holiday {NAME = "American Indian Heritage Day", MONTH = 11, STATE = "Maryland", TYPE = "State Holiday", DATE = "23rd"} },
                {191, new Holiday {NAME = "Cyber Monday", MONTH = 11, STATE = "", TYPE = "Observance", DATE = "26th"} },
                {192, new Holiday {NAME = "First Sunday of Advent", MONTH = 12, STATE = "", TYPE = "Christian", DATE = "2nd"} },
                {193, new Holiday {NAME = "Chanukah/Hanukkah (first day)", MONTH = 12, STATE = "", TYPE = "Jewish Holiday", DATE = "3rd"} },
                {194, new Holiday {NAME = "St. Nicholas' Day", MONTH = 12, STATE = "", TYPE = "Observance", DATE = "6th"} },
                {195, new Holiday {NAME = "Pearl Harbor Remembrance Day", MONTH = 12, STATE = "", TYPE = "Observance", DATE = "7th"} },
                {196, new Holiday {NAME = "Feast of the Immaculate Conception", MONTH = 12, STATE = "", TYPE = "Christian", DATE = "8th"} },
                {197, new Holiday {NAME = "National Guard Birthday", MONTH = 12, STATE = "", TYPE = "Observance", DATE = "13th"} },
                {198, new Holiday {NAME = "Pan American Aviation Day", MONTH = 12, STATE = "", TYPE = "Observance", DATE = "17th"} },
                {199, new Holiday {NAME = "Wright Brothers Day", MONTH = 12, STATE = "", TYPE = "Observance", DATE = "17th"} },
                {200, new Holiday {NAME = "December Solstice", MONTH = 12, STATE = "", TYPE = "Season", DATE = "21st"} },
                {201, new Holiday {NAME = "Christmas Eve", MONTH = 12, STATE = "KS, LA, MI, NC, ND, OK, SC, TX, VA, WI", TYPE = "State Holiday, Observance, Christian", DATE = "24th"} },
                {202, new Holiday {NAME = "Washington's Birthday", MONTH = 12, STATE = "Indiana, Georgia", TYPE = "State Holiday", DATE = "24th"} },
                {203, new Holiday {NAME = "Christmas Day", MONTH = 12, STATE = "", TYPE = "Federal Holiday", DATE = "25th"} },
                {204, new Holiday {NAME = "Kwanzaa (until Jan 1)", MONTH = 12, STATE = "", TYPE = "Observance", DATE = "26th"} },
                {205, new Holiday {NAME = "Day After Christmas Day", MONTH = 12, STATE = "KS, KY, NC, NH, SC, TX", TYPE = "State Holiday", DATE = "26th"} },
                {206, new Holiday {NAME = "New Year's Eve", MONTH = 12, STATE = "LA, MI, WI", TYPE = "State Holiday, Observance", DATE = "31th"} },
                {207, new Holiday {NAME = "Robert E. Lee's Birthday", MONTH = 1, STATE = "Florida", TYPE = "State Holiday", DATE = "19th"} },
                {208, new Holiday {NAME = "Take our Daughters and Sons to Work Day", MONTH = 4, STATE = "", TYPE = "Observance", DATE = "26th"} },
                {209, new Holiday {NAME = "Arbor Day", MONTH = 4, STATE = "Nebraska", TYPE = "State Holiday", DATE = "27th"} },
                {210, new Holiday {NAME = "Star Wars Day", MONTH = 5, STATE = "", TYPE = "Observance", DATE = "4th"} },
                {211, new Holiday {NAME = "Child Health Day", MONTH = 10, STATE = "", TYPE = "Observance", DATE = "1st"} },
                {212, new Holiday {NAME = "Simchat Torah", MONTH = 10, STATE = "", TYPE = "Jewish Holiday", DATE = "2nd"} },
                {213, new Holiday {NAME = "Last Day of Chanukay", MONTH = 12, STATE = "", TYPE = "Jewish Holiday", DATE = "10th"} },
                {214, new Holiday {NAME = "Feast of Our Lady of Guadalupe", MONTH = 12, STATE = "", TYPE = "Observance", DATE = "12th"} }
            };
            return usHolidays;
        }

        private static void WhatsLeft(User user)
        {
            Console.Clear();
            Console.WriteLine("Hello {0}.  This game is easy...\n\n" +
                              "\t1. Enter how many numbers that you want to go through.\n" +
                              "\t2. I will start you off with a base number (Between 1 to 100).\n" +
                              "\t3. I will then display a number (-10 to 10) for 5 seconds.\n" +
                              "\t4. Depending on whether it is a positive or negative number, you will combine it with the base number.\n" +
                              "\t5. This will continue until we reach the number you specified earlier.\n" +
                              "\t6. After the last number, you will then enter what the final total should be.\n\n" +
                              "Press ENTER to begin.\n", user.FirstName);
            Console.ReadLine();

            Random rnd = new Random();

            var playingGame = true;
            while (playingGame)
            {
                var startingNumber = rnd.Next(1, 101);
                var numberOfIterations = 0;
                List<int> randomNumber = new List<int>();
                var finalTotal = startingNumber;


                Console.Clear();

                //GET NUMBER OF ITERATIONS
                while (true)
                {
                    Console.Write("How many numbers do you want to go through? ");
                    var input = int.TryParse(Console.ReadLine().Trim(), out numberOfIterations);

                    if (!input)
                    {
                        Console.WriteLine("Come on {0}, must be number...", user.FirstName);
                        continue;
                    }

                    if (numberOfIterations <= 0)
                    {
                        Console.WriteLine("Must be more than 0");
                    }
                    else
                    {
                        for (int i = 0; i < numberOfIterations; i++)
                        {
                            randomNumber.Add(rnd.Next(-10, 11));
                        }
                        break;
                    }

                }

                if (numberOfIterations == 1)
                {
                    Console.WriteLine("\nGot it.  You want to use only {0} little bitty number...", numberOfIterations);

                }
                else
                {
                    Console.WriteLine("\nGot it.  You want to use {0} numbers...", numberOfIterations);
                }

                Console.ReadLine();

                Console.Clear();
                Console.Write("The Initial Number is: {0}.  Press ENTER to begin...", startingNumber);

                Console.ReadLine();
                Console.Clear();

                for (int i = 0; i < numberOfIterations; i++)
                {
                    finalTotal = finalTotal + randomNumber[i];
                    Console.WriteLine("\t" + randomNumber[i] + "\n");

                    Thread.Sleep(4000);

                    Console.Clear();
                }

                int guessResult;

                while (true)
                {
                    Console.Write("Your Guess: ");
                    var userGuess = int.TryParse(Console.ReadLine().Trim(), out guessResult);

                    if (!userGuess)
                    {
                        Console.WriteLine("Must be a number...");
                    }
                    else
                    {
                        break;
                    }
                }

                List<string> numberSequence = new List<string>();

                numberSequence.Add(startingNumber.ToString());

                for (int i = 0; i < randomNumber.Count; i++)
                {
                    numberSequence.Add(randomNumber[i].ToString());
                }

                string sequence = string.Join(",", numberSequence);


                Console.WriteLine("\nCorrect Total: {0}", finalTotal);

                if (guessResult == finalTotal)
                {
                    Console.WriteLine("\nAwesome Job!!");
                }
                else
                {
                    Console.WriteLine("\nYou were off by {0}...", finalTotal - guessResult);
                }

                Console.WriteLine("\nNumber Sequence: {0}", sequence);

                Console.Write("\nContinue, New Game, or Quit all together (C, N, Q)?  ");
                var inputQuit = Console.ReadLine().Trim().ToLower();

                if (!string.IsNullOrWhiteSpace(inputQuit))
                {
                    switch (inputQuit.Substring(0, 1))
                    {
                        case "c": break;
                        case "n": Console.Clear(); GameDecision(user); break;
                        case "q": Console.Clear(); Console.WriteLine("Have a Great Day, {0}!!", user.FirstName); Thread.Sleep(3000); Environment.Exit(0); break;
                        default: Console.WriteLine("You have to pick a C, N, or Q..."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Come on {0}, You have to pick a C, N, or Q...", user.FirstName);
                }


            }
        }

        private static void SimpleMath(User user)
        {
            Console.Clear();
            Console.WriteLine("Wassaaaapppp!!!!  Something is not adding up here...\n");
            Console.WriteLine("It's you!!  Just kidding, {0}.  You are so dope, like chocolate\n" +
                              "in the rain falling off a chair in the middle of the desert... huh??\n", user.FirstName);
            Console.WriteLine("Sorry...need to wake up.");
            Console.WriteLine("\nHere are the rules:\n");
            Console.WriteLine("\t1. Choose how many questions you want?");
            Console.WriteLine("\t2. Choose the maximum number used in the equation (1 to 100).");
            Console.WriteLine("\t3. Press ENTER when you are ready.");
            Console.WriteLine("\t4. When I display the math problem, you type in the answer and press ENTER");
            Console.WriteLine("\t5. Continue until you finish\n");
            Console.WriteLine("I will show you how many you got correct and how long it took you.\n");
            Console.WriteLine("Press ENTER when you are ready...");
            Console.ReadLine();
            Console.Clear();



            var keepPlaying = true;

            TimeSpan highestTime25 = new TimeSpan(0);
            TimeSpan highestTime50 = new TimeSpan(0);
            TimeSpan highestTime75 = new TimeSpan(0);
            TimeSpan highestTime100 = new TimeSpan(0);

            int category = 0;



            //PLAY GAME
            while (keepPlaying)
            {
                int chosenNumOfQuestions;
                int chosenMaxNumber;
                var numberCorrect = 0;

                TimeSpan totalTime;

                Stopwatch stopwatch = new Stopwatch();

                //CHOOSE NUMBER OF QUESTIONS
                while (true)
                {
                    Console.Write("How many questions (25, 50, 75, 100)? ");
                    var numQuestions = Console.ReadLine().Trim();
                    var isNum = int.TryParse(numQuestions, out chosenNumOfQuestions);

                    if (!isNum)
                    {
                        Console.WriteLine("Must be a number");
                        continue;
                    }

                    if (chosenNumOfQuestions != 25 && chosenNumOfQuestions != 50 && chosenNumOfQuestions != 75 &&
                        chosenNumOfQuestions != 100)
                    {
                        Console.WriteLine("Must be 25, 50, 75, or 100...{0}", user.FirstName);
                    }
                    else
                    {
                        break;
                    }
                }

                category = chosenNumOfQuestions;


                //CHOOSE MAX NUMBER
                while (true)
                {
                    Console.Write("Max Number? ");
                    var maxNumber = Console.ReadLine().Trim();
                    var isNum = int.TryParse(maxNumber, out chosenMaxNumber);

                    if (isNum && chosenMaxNumber >= 1 && chosenMaxNumber <= 100) break;

                    Console.WriteLine("Must be a number between 1 and 100");
                }

                Console.Clear();
                for (int i = 0; i < chosenNumOfQuestions; i++)
                {
                    stopwatch.Start();

                    Random rnd = new Random(DateTime.Now.Millisecond);

                    double firstNumber = rnd.Next(1, chosenMaxNumber + 1);
                    double secondNumber = rnd.Next(1, chosenMaxNumber + 1);
                    double answer = 0;
                    var randomOperator = rnd.Next(1, 5);

                    char mathOperator;

                    switch (randomOperator)
                    {
                        case 1: answer = firstNumber * secondNumber; mathOperator = '*'; break;
                        case 2:
                            while (true)
                            {
                                //ENSURES NO DECIMAL ANSWERS
                                if (firstNumber % secondNumber == 0)
                                {
                                    answer = firstNumber / secondNumber;
                                    break;
                                }
                                if (secondNumber % firstNumber == 0)
                                {
                                    answer = secondNumber / firstNumber;
                                    break;
                                }
                                firstNumber = rnd.Next(1, chosenMaxNumber + 1);
                                secondNumber = rnd.Next(1, chosenMaxNumber + 1);
                            }

                            mathOperator = '/';
                            break;
                        case 3: answer = firstNumber + secondNumber; mathOperator = '+'; break;
                        default: answer = firstNumber - secondNumber; mathOperator = '-'; break;
                    }

                    string display;

                    if (mathOperator == '/' && firstNumber % secondNumber == 0)
                    {
                        display = "\t" + firstNumber + " " + mathOperator + " " + secondNumber + " = ";
                    }
                    else if (mathOperator == '/' && secondNumber % firstNumber == 0)
                    {
                        display = "\t" + secondNumber + " " + mathOperator + " " + firstNumber + " = ";
                    }
                    else
                    {
                        display = "\t" + firstNumber + " " + mathOperator + " " + secondNumber + " = ";

                    }

                    double userAnswer;

                    Console.WriteLine("{0} / {1}\n", i, chosenNumOfQuestions);
                    while (true)
                    {
                        Console.Write(display);
                        var userMathInput = Console.ReadLine().Trim();
                        var isANum = double.TryParse(userMathInput, out userAnswer);

                        if (isANum) break;
                        Console.WriteLine("Must be a number");
                    }

                    if (userAnswer != answer)
                    {
                        Console.WriteLine("Sorry, the answer was {0}.", answer);
                    }
                    else
                    {
                        Console.WriteLine("\n\tGood Job!!");
                        numberCorrect++;
                    }

                    Thread.Sleep(500);

                    Console.Clear();
                }

                stopwatch.Stop();
                totalTime = stopwatch.Elapsed;
                var min = totalTime.Minutes;
                var sec = totalTime.Seconds;
                var timeDisplay = min + " minutes and " + sec + " seconds.";

                switch (category)
                {
                    case 25:
                        if (totalTime < highestTime25 && highestTime25 != new TimeSpan(0))
                        {
                            var diff = highestTime25 - totalTime;
                            var diffMin = diff.Minutes;
                            var diffSec = diff.Seconds;
                            var diffDisplay = diffMin + " minutes and " + diffSec + " seconds.";
                            Console.WriteLine("You got {0} out of {1} correct in the 25 Question Category.  \n\nYour New Record Time: {2} (-{3}).", numberCorrect, chosenNumOfQuestions, timeDisplay, diffDisplay);
                            highestTime25 = totalTime;
                            break;
                        }
                        if (totalTime > highestTime25 && highestTime25 != new TimeSpan(0))
                        {
                            var diff = highestTime25 - totalTime;
                            var diffMin = diff.Minutes;
                            var diffSec = diff.Seconds;
                            var diffDisplay = diffMin + " minutes and " + diffSec + " seconds.";
                            Console.WriteLine("You got {0} out of {1} correct in the 25 Question Category.  \n\nYour Time: {2} (+{3}).", numberCorrect, chosenNumOfQuestions, timeDisplay, diffDisplay);
                            break;
                        }
                        else
                        {
                            Console.WriteLine(
                                "You got {0} out of {1} correct in the 25 Question Category.  \n\nYour Time: {2}.",
                                numberCorrect, chosenNumOfQuestions, timeDisplay);
                            highestTime25 = totalTime;
                            break;
                        }

                    case 50:
                        if (totalTime < highestTime50 && highestTime50 != new TimeSpan(0))
                        {
                            var diff = highestTime50 - totalTime;
                            var diffMin = diff.Minutes;
                            var diffSec = diff.Seconds;
                            var diffDisplay = diffMin + " minutes and " + diffSec + " seconds.";
                            Console.WriteLine("You got {0} out of {1} correct in the 50 Question Category.  \n\nYour New Record Time: {2} (-{3}).", numberCorrect, chosenNumOfQuestions, timeDisplay, diffDisplay);
                            highestTime50 = totalTime;
                            break;
                        }
                        if (totalTime > highestTime50 && highestTime25 != new TimeSpan(0))
                        {
                            var diff = highestTime50 - totalTime;
                            var diffMin = diff.Minutes;
                            var diffSec = diff.Seconds;
                            var diffDisplay = diffMin + " minutes and " + diffSec + " seconds.";
                            Console.WriteLine("You got {0} out of {1} correct in the 50 Question Category.  \n\nYour Time: {2} (+{3}).", numberCorrect, chosenNumOfQuestions, timeDisplay, diffDisplay);
                            break;
                        }
                        else
                        {
                            Console.WriteLine(
                                "You got {0} out of {1} correct in the 50 Question Category.  \n\nYour Time: {2}.",
                                numberCorrect, chosenNumOfQuestions, timeDisplay);
                            highestTime50 = totalTime;
                            break;
                        }
                    case 75:
                        if (totalTime < highestTime75 && highestTime75 != new TimeSpan(0))
                        {
                            var diff = highestTime75 - totalTime;
                            var diffMin = diff.Minutes;
                            var diffSec = diff.Seconds;
                            var diffDisplay = diffMin + " minutes and " + diffSec + " seconds.";
                            Console.WriteLine("You got {0} out of {1} correct in the 75 Question Category.  \n\nYour New Record Time: {2} (-{3}).", numberCorrect, chosenNumOfQuestions, timeDisplay, diffDisplay);
                            highestTime75 = totalTime;
                            break;
                        }
                        if (totalTime > highestTime75 && highestTime25 != new TimeSpan(0))
                        {
                            var diff = highestTime75 - totalTime;
                            var diffMin = diff.Minutes;
                            var diffSec = diff.Seconds;
                            var diffDisplay = diffMin + " minutes and " + diffSec + " seconds.";
                            Console.WriteLine("You got {0} out of {1} correct in the 75 Question Category.  \n\nYour Time: {2} (+{3}).", numberCorrect, chosenNumOfQuestions, timeDisplay, diffDisplay);
                            break;
                        }
                        else
                        {
                            Console.WriteLine(
                                "You got {0} out of {1} correct in the 75 Question Category.  \n\nYour Time: {2}.",
                                numberCorrect, chosenNumOfQuestions, timeDisplay);
                            highestTime75 = totalTime;
                            break;
                        }
                    case 100:
                        if (totalTime < highestTime100 && highestTime100 != new TimeSpan(0))
                        {
                            var diff = highestTime100 - totalTime;
                            var diffMin = diff.Minutes;
                            var diffSec = diff.Seconds;
                            var diffDisplay = diffMin + " minutes and " + diffSec + " seconds.";
                            Console.WriteLine("You got {0} out of {1} correct in the 100 Question Category.  \n\nYour New Record Time: {2} (-{3}).", numberCorrect, chosenNumOfQuestions, timeDisplay, diffDisplay);
                            highestTime100 = totalTime;
                            break;
                        }
                        if (totalTime > highestTime100 && highestTime25 != new TimeSpan(0))
                        {
                            var diff = highestTime100 - totalTime;
                            var diffMin = diff.Minutes;
                            var diffSec = diff.Seconds;
                            var diffDisplay = diffMin + " minutes and " + diffSec + " seconds.";
                            Console.WriteLine("You got {0} out of {1} correct in the 100 Question Category.  \n\nYour Time: {2} (+{3}).", numberCorrect, chosenNumOfQuestions, timeDisplay, diffDisplay);
                            break;
                        }
                        else
                        {
                            Console.WriteLine(
                                "You got {0} out of {1} correct in the 100 Question Category.  \n\nYour Time: {2}.",
                                numberCorrect, chosenNumOfQuestions, timeDisplay);
                            highestTime100 = totalTime;
                            break;
                        }
                }

                ContinuePlaying(user);
            }

        }

        private static void PlayBlackjack(User user)
        {
            var now = DateTime.Now.TimeOfDay;
            var day = DateTime.Now.DayOfWeek;
            var time = DateTime.Now.ToString("hh:mm tt");
            var noon = new TimeSpan(12, 0, 0);
            var greating = now < noon ? "Good Morning, " : "Good Afternoon, ";

            var rulesSection = true;

            while (rulesSection)
            {
                Console.Clear();
                Console.WriteLine(greating + user.FirstName + ". Happy " + day + "!!  The time is " + time + ".");
                Console.Write("\nWould you like to know the rules (Yes or No)? ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input.Substring(0, 1)))
                {
                    switch (input)
                    {
                        case "y": BlackjackRules(); rulesSection = false; break;
                        case "n": Console.WriteLine("\nCopy that!!  Press ENTER to begin!!\n"); Console.ReadLine(); rulesSection = false; break;
                        default: Console.WriteLine("\nYou have to enter Yes or No...\n"); break;
                    }
                }
                else
                {
                    Console.WriteLine("\nCome on {0}, You have to enter Yes or No...\n", user.FirstName);
                }
            }

            var playerScore = 0;
            var dealerScore = 0;
            var totalHands = 0;
            var totalCards = 0;

            var keepGoing = true;
            while (keepGoing)
            {

                int numberOfDecks;

                string input;
                while (true)
                {
                    Console.Clear();
                    Console.Write("How many decks will we use? ");
                    input = Console.ReadLine().Trim();

                    var number = int.TryParse(input, out numberOfDecks);

                    if (number)
                    {
                        break;
                    }

                    Console.WriteLine("Come one {0}, you must enter a number...", user.FirstName);
                }

                //RUN METHOD THAT SHUFFLES DECK - PARAMETER IS NUMBER OF DECKS
                var shuffledDeck = ShuffleDecks(numberOfDecks).ToArray();

                Console.WriteLine("\nPress ENTER to begin...");
                Console.ReadLine();

                Console.Clear();

                var dealerHand = new List<string>();
                var playerHand = new List<string>();

                var cardNumber = 0;

                while (true)
                {
                    totalHands++;

                    if (cardNumber >= (numberOfDecks * 52 * .75))
                    {
                        Console.WriteLine("Time to Shuffle...");
                        Console.ReadLine();
                        totalCards = 0;
                        break;    //WHEN REACHES 3/4 OF DECK, THIS MAKES IT THE LAST ROUND
                    }

                    //INITIAL DEAL
                    dealerHand.Add(shuffledDeck[cardNumber]);
                    playerHand.Add(shuffledDeck[++cardNumber]);
                    dealerHand.Add(shuffledDeck[++cardNumber]);
                    playerHand.Add(shuffledDeck[++cardNumber]);
                    totalCards = totalCards + dealerHand.Count + playerHand.Count;
                    Console.Clear();

                    //CHECKS IF DEALER HAS AUTO-BLACKJACK, THEN CHECKS WHETHER PLAYER HAS ONE AS WELL FOR THE PUSH
                    var dealerHasBlackjack = DealerHasBlackjack(dealerHand[0], dealerHand[1], playerHand[0], playerHand[1], dealerScore, playerScore, totalHands, totalCards);
                    if (dealerHasBlackjack)
                    {
                        dealerScore++;
                        dealerHand.Clear();
                        playerHand.Clear();
                        continue;
                    }

                    //CHECKS IF PLAYER HAS AUTO-BLACKJACK
                    var playerHasBlackjack = PlayerHasBlackJack(playerHand[0], playerHand[1], dealerHand[0], dealerScore, playerScore, totalHands, totalCards);
                    if (playerHasBlackjack)
                    {
                        playerScore++;
                        dealerHand.Clear();
                        playerHand.Clear();
                        continue;
                    }

                    Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);

                    Console.WriteLine("\tNew Deal\n");

                    Console.WriteLine("Dealer: {0} and X = ??", dealerHand[0]);
                    Console.WriteLine("Player: {0}", PlayerCalculator(playerHand));

                    bool isHitting = true;

                    //HIT OR STAY PHASE
                    while (isHitting)
                    {
                        //RETURNS 1 OR 3
                        var hitOrStay = HitOrStay(user.FirstName);

                        switch (hitOrStay)
                        {
                            case 1:
                                playerHand.Add(shuffledDeck[++cardNumber]);
                                totalCards++;
                                Console.Clear();
                                Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);
                                Console.WriteLine("\tPlayer Hits\n");
                                Console.WriteLine("Dealer: {0} and X = ??", dealerHand[0]);
                                if (PlayerCalculator(playerHand).Contains("BUSTED"))
                                {
                                    Console.WriteLine("Player: {0}", PlayerCalculator(playerHand));
                                    Console.ReadLine();
                                    isHitting = false;
                                }
                                else
                                {
                                    Console.WriteLine("Player: {0}", PlayerCalculator(playerHand));
                                }
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);
                                Console.WriteLine("\tPlayer Stays\n");
                                Console.WriteLine("Dealer: {0} and X = ??", dealerHand[0]);
                                Console.WriteLine("Player: {0}", PlayerCalculator(playerHand));
                                isHitting = false;
                                break;
                        }
                    }

                    Console.Clear();

                    bool dealersTurn = !PlayerCalculator(playerHand).Contains("BUSTED");

                    if (!dealersTurn) dealerScore++;

                    while (dealersTurn)
                    {
                        var dealerTotal = DealerHandTotal(dealerHand, shuffledDeck, cardNumber);
                        var playerTotal = PlayerHandTotal(playerHand);

                        //Accounts for addition of cards during DealerHandTotal()
                        totalCards = totalCards + (dealerHand.Count - 2);

                        //IF PLAYER'S HAND CONTAINS AN ACE
                        if (playerHand.Contains("AceS") || playerHand.Contains("AceC") || playerHand.Contains("AceH") ||
                            playerHand.Contains("AceD"))
                        {
                            if (playerTotal + 10 <= 21)
                            {
                                //DEALER WINS EVEN AGAINST SOFT 10's - eg. hard 18 vs soft 18
                                if (dealerTotal >= playerTotal + 10)
                                {
                                    Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);

                                    Console.WriteLine("\tDealer's Turn\n");

                                    if (PlayerCalculator(dealerHand).Contains("BUSTED"))
                                    {
                                        Console.WriteLine("Dealer: {0}", PlayerCalculator(dealerHand));
                                        Console.WriteLine("Player: {0} YOU WIN!!", PlayerCalculator(playerHand));
                                        playerScore++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Dealer: {0} DEALER WINS", PlayerCalculator(dealerHand));
                                        Console.WriteLine("Player: {0}", PlayerCalculator(playerHand));
                                        dealerScore++;
                                    }

                                    Console.ReadLine();
                                    break;
                                }
                                Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);

                                Console.WriteLine("\tDealer's Turn\n");
                                Console.WriteLine("Dealer: {0}", PlayerCalculator(dealerHand));
                                Console.WriteLine("Player: {0} YOU WIN!!", PlayerCalculator(playerHand));
                                dealerScore++;
                                Console.ReadLine();
                                break;
                            }

                        }

                        if (dealerTotal > playerTotal)
                        {
                            Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);

                            Console.WriteLine("\tDealer's Turn\n");

                            if (PlayerCalculator(dealerHand).Contains("BUSTED"))
                            {
                                Console.WriteLine("Dealer: {0}", PlayerCalculator(dealerHand));
                                Console.WriteLine("Player: {0} YOU WIN!!", PlayerCalculator(playerHand));
                                playerScore++;
                            }
                            else
                            {
                                Console.WriteLine("Dealer: {0} DEALER WINS", PlayerCalculator(dealerHand));
                                Console.WriteLine("Player: {0}", PlayerCalculator(playerHand));
                                dealerScore++;
                            }

                            Console.ReadLine();
                            break;
                        }

                        if (dealerTotal < playerTotal)
                        {
                            Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);

                            Console.WriteLine("\tDealer's Turn\n");
                            Console.WriteLine("Dealer: {0}", PlayerCalculator(dealerHand));
                            Console.WriteLine("Player: {0} YOU WIN!!", PlayerCalculator(playerHand));
                            playerScore++;
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);

                        Console.WriteLine("\tDealer's Turn\n");
                        Console.WriteLine("Dealer: {0} ITS A PUSH", PlayerCalculator(dealerHand));
                        Console.WriteLine("Player: {0}", PlayerCalculator(playerHand));
                        Console.ReadLine();
                        break;
                    }

                    dealerHand.Clear();
                    playerHand.Clear();
                    Console.Clear();
                }


                ContinuePlaying(user);
            }

        }

        private static int PlayerHandTotal(List<string> hand)
        {
            var total = 0;

            for (int i = 0; i < hand.Count; i++)
            {
                total = total + CardRank(hand[i]);
            }

            return total;
        }

        private static int DealerHandTotal(List<string> hand, string[] shuffledDeck, int cardNumber)
        {
            var total = 0;

            while (true)
            {
                for (int i = 0; i < hand.Count; i++)
                {
                    total = total + CardRank(hand[i]);
                }

                //ACCOUNTS FOR SOFT ACE UP TO 17 - DEALER ALWAYS HITS ON SOFT 17
                if (total + 10 <= 21 || total < 17)
                {
                    hand.Add(shuffledDeck[++cardNumber]);

                }
                else
                {
                    return total;
                }

                total = 0;
            }
        }

        private static string PlayerCalculator(List<string> hand)
        {
            var total = 0;
            var display = "";

            if (hand.Contains("AceS") || hand.Contains("AceC") || hand.Contains("AceH") || hand.Contains("AceD"))
            {
                for (int i = 0; i < hand.Count; i++)
                {

                    if (hand.Count - 1 == i)
                    {
                        display = display + hand[i];
                    }
                    else
                    {
                        display = display + hand[i] + " and ";
                    }

                    total = total + CardRank(hand[i]);
                }

                //TOTAL CONTAINS SOFT ACE
                if (total + 10 <= 21)
                {
                    return display + " = " + total + " or " + (total + 10);
                }

                //IF TOTAL, WITH HARD ACES, ARE OVER 21
                if (total > 21)
                {
                    return display + " = " + total + " BUSTED";
                }

                //TOTAL CONTAINS HARD ACE
                return display + " = " + total;

            }

            for (int i = 0; i < hand.Count; i++)
            {
                if (hand.Count - 1 == i)
                {
                    display = display + hand[i];
                }
                else
                {
                    display = display + hand[i] + " and ";
                }

                total = total + CardRank(hand[i]);
            }

            if (total > 21)
            {

                return display + " = " + total + " BUSTED";
            }

            return display + " = " + total;

        }

        private static bool PlayerHasBlackJack(string playerCard1, string playerCard2, string dealerCard1, int dealerScore, int playerScore, int totalHands, int totalCards)
        {
            //CHECK IF DEALER HAS BLACKJACK
            if (CardRank(playerCard1) + CardRank(playerCard2) == 11 && (playerCard1.Contains("Ace") || playerCard2.Contains("Ace")))
            {
                Console.Clear();
                Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);
                Console.WriteLine("\tNew Deal\n");
                Console.WriteLine("Dealer: {0} and X = ??", dealerCard1);
                Console.WriteLine("Player: {0} and {1} = Blackjack", playerCard1, playerCard2);
                Console.WriteLine("\nYou Automatically Win!!");
                Console.ReadLine();

                return true;
            }

            return false;
        }

        public static bool DealerHasBlackjack(string d, string d1, string p, string p1, int dealerScore, int playerScore, int totalHands, int totalCards)
        {
            //CHECK IF DEALER HAS BLACKJACK
            if (CardRank(d) + CardRank(d1) == 11 && (d.Contains("Ace") || d1.Contains("Ace")))
            {
                if (CardRank(p) + CardRank(p1) == 11 && (p.Contains("Ace") || p1.Contains("Ace")))
                {
                    Console.Clear();
                    Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);
                    Console.WriteLine("\tNew Deal\n");
                    Console.WriteLine("Dealer: {0} and {1} = Blackjack", d, d1);
                    Console.WriteLine("Player: {0} and {1} = Blackjack", p, p1);
                    Console.WriteLine("\nAutomatic Push");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Dealer: {0} || {1} :Player\tTotal Hands: {2}\tCards Used: {3}\n", dealerScore, playerScore, totalHands, totalCards);
                    Console.WriteLine("\tNew Deal\n");
                    Console.WriteLine("Dealer: {0} and {1} = Blackjack", d, d1);
                    Console.WriteLine("Player: {0} and {1} = {2}", p, p1, CardRank(p) + CardRank(p1));
                    Console.WriteLine("\nDealer Automatically Wins");
                    Console.ReadLine();
                }

                return true;
            }

            return false;
        }

        private static int HitOrStay(string user)
        {

            //VERIFY HIT OR STAY
            while (true)
            {
                Console.WriteLine("\nHIT or STAY (1 or 3)");

                var inputHitOrStay = Console.ReadLine();

                var isNum = int.TryParse(inputHitOrStay, out int choice);

                if (isNum)
                {
                    if (choice == 1 || choice == 3)
                    {
                        return choice;
                    }

                    Console.WriteLine("Must be 1 or 3");
                }
                else
                {
                    Console.WriteLine("Come on {0}, Must be 1 or 3", user);
                }
            }

        }

        private static int CardRank(string card)
        {
            var num = 0;
            switch (card)
            {
                case "2H": case "2S": case "2D": case "2C": num = 2; break;
                case "3H": case "3S": case "3D": case "3C": num = 3; break;
                case "4H": case "4S": case "4D": case "4C": num = 4; break;
                case "5H": case "5S": case "5D": case "5C": num = 5; break;
                case "6H": case "6S": case "6D": case "6C": num = 6; break;
                case "7H": case "7S": case "7D": case "7C": num = 7; break;
                case "8H": case "8S": case "8D": case "8C": num = 8; break;
                case "9H": case "9S": case "9D": case "9C": num = 9; break;
                case "10H": case "10S": case "10D": case "10C": num = 10; break;
                case "JackH": case "JackS": case "JackD": case "JackC": num = 10; break;
                case "QueenH": case "QueenS": case "QueenD": case "QueenC": num = 10; break;
                case "KingH": case "KingS": case "KingD": case "KingC": num = 10; break;
                case "AceH": case "AceS": case "AceD": case "AceC": num = 1; break;
            }

            return num;
        }

        private static IEnumerable<string> ShuffleDecks(int numberOfDecks)
        {
            var singleDeck = new List<string>
            {
                "2H", "3H", "4H","5H","6H","7H","8H","9H", "10H", "JackH", "QueenH", "KingH", "AceH",
                "2S", "3S", "4S","5S","6S","7S","8S","9S", "10S", "JackS", "QueenS", "KingS", "AceS",
                "2D", "3D", "4D","5D","6D","7D","8D","9D", "10D", "JackD", "QueenD", "KingD", "AceD",
                "2C", "3C", "4C","5C","6C","7C","8C","9C", "10C", "JackC", "QueenC", "KingC", "AceC"
            };

            var multipleDecks = new List<string>();

            //Adds requested # of decks to one deck
            for (int i = 0; i < numberOfDecks; i++)
            {
                foreach (var card in singleDeck)
                {
                    multipleDecks.Add(i + card);      //Adds Deck Number in front of card name to prevent duplicates from multiple decks
                }
            }

            var rnd = new Random(DateTime.Now.Millisecond);

            var shuffledDeck = new List<string>();

            var shuffle = true;

            var totalCards = numberOfDecks * 52;

            while (shuffle)
            {
                var randomIndex = rnd.Next(1, totalCards + 1);

                if (!shuffledDeck.Contains(multipleDecks[randomIndex - 1]))
                {
                    shuffledDeck.Add(multipleDecks[randomIndex - 1]);
                }

                //FULLY SHUFFLED
                if (shuffledDeck.Count == totalCards)
                {
                    shuffle = false;
                }
            }

            var normalizedDeck = new List<string>();

            //REMOVES DECK NUMBER FROM BEGINNING OF CARD NAME
            foreach (var card in shuffledDeck)
            {
                normalizedDeck.Add(card.Remove(0, 1));
            }

            var deckArray = normalizedDeck.ToArray();

            return deckArray;
        }

        public static void BlackjackRules()
        {
            Console.Clear();
            Console.WriteLine("Brief history of Blackjack...\n" +
                              "\tWhile the popularity of Blackjack dates from World War I, its roots go back to the 1760s in France,\n" +
                              "\twhere it is called Vingt-et-Un (French for 21).\n\n" +
                              "OBJECT OF THE GAME\n" +
                              "\tYou have to beat the Dealer by getting a count as close to 21 as possible, without going over 21.\n\n" +
                              "CARD VALUES/SCORING\n" +
                              "\tIt is up to you if an Ace is worth 1 or 11.  Face cards (Kings, Queens, and Jacks)\n" +
                              "\tare 10 and any other card are the face values.\n\n" +
                              "THE DEAL\n" +
                              "\tThe Dealer will give you one showing card, itself one showing card, then you one showing card,\n" +
                              "\tthen itself one not-showing card.\n" +
                              "\tIf the Dealer already has a Blackjack (Ace and Face), they win, unless you have one as well, then it is a tie\n" +
                              "\tand a new deal will take place.\n\n" +
                              "\tIf you have an Ace and and a Face card and the Dealer does not, they you automatically win.\n" +
                              "\tSorry, no splitting 10's\n\n" +
                              "THE STAND, HIT, AND BUST\n" +
                              "\tSTAND is when one does not want another card.\n" +
                              "\tHIT is when one requests another card.\n" +
                              "\tBUST is when one goes over 21.\n\n" +
                              "THE DEALER\n" +
                              "\tOnce the Dealer serves your cards, their non-showing card is displayed.\n" +
                              "\tIf the total is 17, the Dealer must STAND, unless it is a soft 17 (Ace and 6), then it must HIT.\n" +
                              "\tIf the total is 16 or less, the Dealer must HIT until the totalling cards reach 17 or higher without BUSTing.\n\n" +
                              "Press ENTER to begin.");
            Console.ReadLine();
            Console.Clear();
        }

        private static void PlayMemory(User user)
        {
            Console.Clear();
            Console.WriteLine("Hello, {0}.\n", user.FirstName);
            Console.WriteLine("This is a fun game that tests your short-term memory.");
            Console.WriteLine("\nI will display a number next to the words 'In Memory: '." +
                              "\nYour job is to retype what i just showed you." +
                              "\n\nAfter each round, I will add a number to the end of the last number," +
                              "\ngive you 3 seconds to memorize that number, and allow you to enter the new number.");
            Console.WriteLine("\nThink of this game as if you were playing Simon, only with numbers.  No spaces are needed.");
            Console.WriteLine("\nHit ENTER to begin...\n");
            Console.ReadLine();
            Console.Clear();

            List<int> numbers = new List<int>();
            List<int> numbersInput = new List<int>();

            Random rnd = new Random(DateTime.Now.Millisecond);

            var playing = true;
            var totalCorrect = 0;

            while (playing)
            {

                numbers.Add(rnd.Next(1, 10));


                Console.Write("In Memory: ");

                foreach (var t in numbers)
                {
                    Console.Write("{0} ", t);
                }

                Console.WriteLine("\n");

                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }

                Console.Clear();

                Console.WriteLine("GO!!\n");

                //PUT NUMBER IN SECOND LIST
                var checkInput = true;
                while (checkInput)
                {
                    var input = Console.ReadLine().Trim();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("You have to enter something...");
                        continue;
                    }

                    var inputNumber = input.ToCharArray();

                    foreach (var t in inputNumber)
                    {
                        var numChecker = int.TryParse(t.ToString(), out var temp);

                        if (!numChecker)
                        {
                            Console.WriteLine("Has to be a number...");
                            continue;
                        }

                        numbersInput.Add(temp);
                        checkInput = false;
                    }

                }

                var highestNumberInARow = user.HighestNumbersInARow;

                //COMPARE LISTS
                for (var i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] != numbersInput[i] || numbers.Count != numbersInput.Count)
                    {
                        Console.WriteLine("Sorry...Top is the Correct Sequence.  Bottom is what you entered.\n");

                        foreach (var t in numbers)
                        {
                            Console.Write("{0} ", t);
                        }

                        Console.WriteLine("");

                        foreach (var v in numbersInput)
                        {
                            Console.Write("{0} ", v);
                        }

                        Console.WriteLine("\n");

                        if (totalCorrect == highestNumberInARow)
                        {
                            Console.WriteLine("\nYou matched your high score of {0}.", totalCorrect);
                        }

                        if (totalCorrect > highestNumberInARow)
                        {
                            Console.WriteLine("\nYou Beat Your High Score!!  You Got {0} numbers in a row!!", totalCorrect);
                            user.HighestNumbersInARow = totalCorrect;
                        }
                        else
                        {
                            Console.WriteLine("\nYour Top Record is {0} numbers in a row.", highestNumberInARow);
                        }

                        ContinuePlaying(user);
                    }
                }

                totalCorrect++;

                if (totalCorrect == numbers.Count)
                {
                    Console.WriteLine("\nYou Got It!! ");
                    Thread.Sleep(1500);
                    Console.Clear();
                }


                numbersInput.Clear();
            }
        }

        private static void PlayStateCapitals(User user)
        {
            Console.Clear();
            Console.WriteLine("Welcome {0}, to State Capitals!!", user.FirstName);
            Console.WriteLine("We are going to test you on how well do you know your State Capitals...");
            Console.WriteLine("These questions are multiple choice...");
            Console.WriteLine("Good Luck!!\n\n");

            var capitals = GetCapitals();
            var counter = 0;
            var play = true;

            int[] numberedCapitals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            var numStatesCounter = 1;
            var score = 0;

            var incorrectAnswers = new List<string>();

            while (play)
            {
                //GETS LOWEST AND HIGHEST NUMBERS
                int minNum = numberedCapitals.Min();
                int maxNum = numberedCapitals.Max();

                //GETS THEIR INDEX POSITIONS
                var minNumIndex = Array.IndexOf(numberedCapitals, minNum);
                var maxNumIndex = Array.IndexOf(numberedCapitals, maxNum);
                var rnd = new Random();

                var question = minNum != maxNum ? numberedCapitals[rnd.Next(minNumIndex, maxNumIndex + 1)] : numberedCapitals[0];

                var secondGuess = 0;
                var thirdGuess = 0;
                var fourthGuess = 0;
                var fifthGuess = 0;

                //Makes sure second answer is not the same as the first
                while (true)
                {
                    secondGuess = rnd.Next(1, 51);
                    if (secondGuess != question) break;
                }

                //Makes sure third answer is not the same as first and second
                while (true)
                {
                    thirdGuess = rnd.Next(1, 51);
                    if (thirdGuess != question && thirdGuess != secondGuess) break;
                }

                while (true)
                {
                    fourthGuess = rnd.Next(1, 51);
                    if (fourthGuess != question && fourthGuess != secondGuess && fourthGuess != thirdGuess) break;
                }

                while (true)
                {
                    fifthGuess = rnd.Next(1, 51);
                    if (fifthGuess != question && fifthGuess != secondGuess && fifthGuess != thirdGuess && fifthGuess != fourthGuess) break;
                }

                //REMOVES NUMBER FROM LIST AND MAKES A NEW INT ARRAY
                var numToRemove = question;
                int numIndex = Array.IndexOf(numberedCapitals, numToRemove);    //REMOVES NUMBER ACCORDING TO INDEX
                List<int> tempList = new List<int>(numberedCapitals);
                tempList.RemoveAt(numIndex);
                numberedCapitals = tempList.ToArray();

                Console.Clear();
                Console.WriteLine("{0} / 50.  What is the Capital of {1}?", numStatesCounter, capitals[question].STATE);

                var answers = new[] { capitals[question].CAPITAL, capitals[secondGuess].CAPITAL, capitals[thirdGuess].CAPITAL, capitals[fourthGuess].CAPITAL, capitals[fifthGuess].CAPITAL };

                var optionOne = rnd.Next(0, 5);
                int optionTwo;
                int optionThree;
                int optionFour;
                int optionFive;
                while (true)
                {
                    optionTwo = rnd.Next(0, 5);
                    if (optionTwo != optionOne) break;
                }

                while (true)
                {
                    optionThree = rnd.Next(0, 5);
                    if (optionThree != optionOne && optionThree != optionTwo) break;
                }
                while (true)
                {
                    optionFour = rnd.Next(0, 5);
                    if (optionFour != optionOne && optionFour != optionTwo && optionFour != optionThree) break;
                }
                while (true)
                {
                    optionFive = rnd.Next(0, 5);
                    if (optionFive != optionOne && optionFive != optionTwo && optionFive != optionThree && optionFive != optionFour) break;
                }

                Console.WriteLine("\t1 - {0}", answers[optionOne]);
                Console.WriteLine("\t2 - {0}", answers[optionTwo]);
                Console.WriteLine("\t3 - {0}", answers[optionThree]);
                Console.WriteLine("\t4 - {0}", answers[optionFour]);
                Console.WriteLine("\t5 - {0}", answers[optionFive]);

                int guess;

                //Ensure user enters 1, 2, 3, 4, or 5
                while (true)
                {
                    var input = Console.ReadLine().Trim();
                    var result = int.TryParse(input, out guess);

                    if (result)
                    {
                        if (guess >= 1 && guess <= 5)
                        {
                            break;
                        }

                        Console.WriteLine("Must be between 1 and 5");
                    }
                    else
                    {
                        Console.WriteLine("Must be a number");
                    }
                }

                string userGuess;
                switch (guess)
                {
                    case 1: userGuess = answers[optionOne]; break;
                    case 2: userGuess = answers[optionTwo]; break;
                    case 3: userGuess = answers[optionThree]; break;
                    case 4: userGuess = answers[optionFour]; break;
                    default: userGuess = answers[optionFive]; break;
                }

                if (userGuess == capitals[question].CAPITAL)
                {
                    Console.WriteLine("\nGood Job!!");
                    score++;
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("\nSorry, the answer was {0}...", capitals[question].CAPITAL);
                    var correctAnswer = "The Capital of " + capitals[question].STATE + " is " + capitals[question].CAPITAL;
                    incorrectAnswers.Add(correctAnswer);
                    Thread.Sleep(1000);
                }

                //counter++;
                if (counter == 10 || numStatesCounter == 50)
                {
                    var keepGoing = true;
                    while (keepGoing)
                    {
                        if (numStatesCounter == 50)
                        {
                            Console.WriteLine("You've Finishd!!  Great Job!!\n");
                            Console.WriteLine("Your got {0} out of 50.\n", score);

                            if (incorrectAnswers.Any())
                            {
                                Console.WriteLine("To review:\n");

                                foreach (var correctAnswer in incorrectAnswers)
                                {
                                    Console.WriteLine(correctAnswer);
                                }
                            }

                            //REMOVE LAST NUMBER FROM LIST
                            var removeLastNumber = new List<int>(numberedCapitals);
                            removeLastNumber.Clear();

                            //RENUMBER 1-50
                            for (int i = 1; i < 51; i++)
                            {
                                removeLastNumber.Add(i);
                            }

                            numberedCapitals = removeLastNumber.ToArray();

                        }

                        ContinuePlaying(user);
                    }
                }
                numStatesCounter++;
                Console.Clear();
            }
        }

        private static Dictionary<int, State> GetCapitals()
        {
            var capitals = new Dictionary<int, State>
           {
               { 1, new State(){STATE = "Alabama", CAPITAL = "Montgomery"}},
               { 2, new State(){STATE = "Alaska", CAPITAL = "Juneau"}},
               { 3, new State(){STATE = "Arizona", CAPITAL = "Phoenix"}},
               { 4, new State(){STATE = "Arkansas", CAPITAL = "Little Rock"}},
               { 5, new State(){STATE = "California", CAPITAL = "Sacramento"}},
               { 6, new State(){STATE = "Colorado", CAPITAL = "Denver"}},
               { 7, new State(){STATE = "Connecticut", CAPITAL = "Hartford"}},
               { 8, new State(){STATE = "Delaware", CAPITAL = "Dover"}},
               { 9, new State(){STATE = "Florida", CAPITAL = "Tallahassee"}},
               { 10, new State(){STATE = "Georgia", CAPITAL = "Atlanta"}},
               { 11, new State(){STATE = "Hawaii", CAPITAL = "Honolulu"}},
               { 12, new State(){STATE = "Idaho", CAPITAL = "Boise"}},
               { 13, new State(){STATE = "Illinois", CAPITAL = "Springfield"}},
               { 14, new State(){STATE = "Indiana", CAPITAL = "Indianapolis"}},
               { 15, new State(){STATE = "Iowa", CAPITAL = "Des Moines"}},
               { 16, new State(){STATE = "Kansas", CAPITAL = "Topeka"}},
               { 17, new State(){STATE = "Kentucky", CAPITAL = "Frankfort"}},
               { 18, new State(){STATE = "Louisiana", CAPITAL = "Baton Rouge"}},
               { 19, new State(){STATE = "Maine", CAPITAL = "Augusta"}},
               { 20, new State(){STATE = "Maryland", CAPITAL = "Annapolis"}},
               { 21, new State(){STATE = "Massachusetts", CAPITAL = "Boston"}},
               { 22, new State(){STATE = "Michigan", CAPITAL = "Lansing"}},
               { 23, new State(){STATE = "Minnesota", CAPITAL = "Saint Paul"}},
               { 24, new State(){STATE = "Mississippi", CAPITAL = "Jackson"}},
               { 25, new State(){STATE = "Missouri", CAPITAL = "Jefferson City"}},
               { 26, new State(){STATE = "Montana", CAPITAL = "Helena"}},
               { 27, new State(){STATE = "Nebraska", CAPITAL = "Lincoln"}},
               { 28, new State(){STATE = "Nevada", CAPITAL = "Carson City"}},
               { 29, new State(){STATE = "New Hampshire", CAPITAL = "Concord"}},
               { 30, new State(){STATE = "New Jersey", CAPITAL = "Trenton"}},
               { 31, new State(){STATE = "New Mexico", CAPITAL = "Santa Fe"}},
               { 32, new State(){STATE = "New York", CAPITAL = "Albany"}},
               { 33, new State(){STATE = "North Carolina", CAPITAL = "Raleigh"}},
               { 34, new State(){STATE = "North Dakota", CAPITAL = "Bismarck"}},
               { 35, new State(){STATE = "Ohio", CAPITAL = "Columbus"}},
               { 36, new State(){STATE = "Oklahoma", CAPITAL = "Oklahoma City"}},
               { 37, new State(){STATE = "Oregon", CAPITAL = "Salem"}},
               { 38, new State(){STATE = "Pennsylvania", CAPITAL = "Harrisburg"}},
               { 39, new State(){STATE = "Rhode Island", CAPITAL = "Providence"}},
               { 40, new State(){STATE = "South Carolina", CAPITAL = "Columbia"}},
               { 41, new State(){STATE = "South Dakota", CAPITAL = "Pierre"}},
               { 42, new State(){STATE = "Tennessee", CAPITAL = "Nashville"}},
               { 43, new State(){STATE = "Texas", CAPITAL = "Austin"}},
               { 44, new State(){STATE = "Utah", CAPITAL = "Salt Lake City"}},
               { 45, new State(){STATE = "Vermont", CAPITAL = "Montpelier"}},
               { 46, new State(){STATE = "Virginia", CAPITAL = "Richmond"}},
               { 47, new State(){STATE = "Washington", CAPITAL = "Olympia"}},
               { 48, new State(){STATE = "West Virgina", CAPITAL = "Charleston"}},
               { 49, new State(){STATE = "Wisconsin", CAPITAL = "Madison"}},
               { 50, new State(){STATE = "Wyoming", CAPITAL = "Cheyenne"}}

           };
            return capitals;
        }

        private static void PlayRockPaperScissors(User user)
        {
            Console.Clear();

            Console.WriteLine("Welcome to Rock, Paper, Scissors...We'll start off with some introductions.\n" +
                              "As you already know, my name is {0}...\n", user.ComputerName);

            Console.WriteLine("\n{0}, it is wonderful to meet you.  Now for the instructions...\n" +
                                "The screen will count down - 3, 2, 1 - and then you choose what you have Rock (1), Paper (2), or Scissors (3).  Easy right?\n" +
                                "Once you make your selection, I will show you what I got.  Don't worry {0}, I won't cheat. :)", user.FirstName);
            Console.WriteLine("Okay.  All you have to do is hit ENTER whenever you are ready...");
            Console.ReadLine();

            var play = true;
            var counter = 0;

            var dealerScore = 0;
            var playerScore = 0;

            while (play)
            {
                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(800);
                }

                var rnd = new Random(DateTime.Now.Millisecond);
                var computerRoll = rnd.Next(1, 4);
                int yourRoll = 0;

                var hasChosen = true;
                while (hasChosen)
                {
                    Console.Clear();

                    Console.WriteLine("Dealer: {0}", dealerScore);
                    Console.WriteLine("Player: {0}\n", playerScore);

                    Console.Write("\nRock (1), Paper (2), or Scissors (3)? ");
                    var choice = Console.ReadLine().Trim();
                    var isNumeric = int.TryParse(choice, out yourRoll);

                    if (isNumeric)
                    {
                        switch (yourRoll)
                        {
                            case (1): case (2): case (3): hasChosen = false; break;
                            default: Console.WriteLine("You have to choose 1, 2, or 3\n"); break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Come on, {0}...Must be a number...\n", user.FirstName);
                    }
                }

                var computerTranslated = computerRoll == 1 ? "Rock" : computerRoll == 2 ? "Paper" : "Scissors";
                var userTranslated = yourRoll == 1 ? "Rock" : yourRoll == 2 ? "Paper" : "Scissors";

                if (computerRoll == yourRoll) Console.WriteLine("Its a Tie!!  I got a {0} and you got a {1}. \n", computerTranslated, userTranslated);

                if (computerRoll == 2 && yourRoll == 1)
                {
                    Console.WriteLine("Ha! I win!!  Paper covers Rock...\n");
                    dealerScore++;
                }

                if (computerRoll == 2 && yourRoll == 3)
                {
                    Console.WriteLine("You win!!  Scissors cuts Paper...\n");
                    playerScore++;
                }

                if (computerRoll == 3 && yourRoll == 1)
                {
                    Console.WriteLine("You win, {0}!!  Rock breaks Scissors...\n", user.FirstName);
                    playerScore++;
                }

                if (computerRoll == 3 && yourRoll == 2)
                {
                    Console.WriteLine("Ha! I win!!  Scissors cuts Paper...\n");
                    dealerScore++;
                }

                if (computerRoll == 1 && yourRoll == 2)
                {
                    Console.WriteLine("You win!!  Paper covers Rock...\n");
                    playerScore++;
                }

                if (computerRoll == 1 && yourRoll == 3)
                {
                    Console.WriteLine("Ha! I win!!  Rock breaks Scissors...\n");
                    dealerScore++;
                }

                counter++;

                if (counter != 5) continue;

                ContinuePlaying(user);
            }
        }

        private static void PlayNumbersGame(User user)
        {
            Console.Clear();
            Console.WriteLine(
                "\nHello, {0}.  We are going to play Higher or Lower.\n" +
                "Basically, you will press enter to Roll the Dice,\n" +
                "then guess whether the next roll will be Higher or Lower.\n\n", user.FirstName);

            var counter = 0;

            var dealerScore = 0;
            var playerScore = 0;

            var playing = true;
            while (playing)
            {
                Console.WriteLine("Press ENTER to roll");
                Console.ReadLine();

                Console.Clear();

                var rnd = new Random(DateTime.Now.Millisecond);

                int firstDice = rnd.Next(1, 7);
                int secondDice = rnd.Next(1, 7);
                int totalFirstRoll = firstDice + secondDice;

                Console.WriteLine("Dealer: {0}", dealerScore);
                Console.WriteLine("Player: {0}\n", playerScore);

                Console.WriteLine("First dice is a {0}.\nSecond dice is a {1}.\nTotal for the First Roll is {2}.", firstDice, secondDice, totalFirstRoll);

                var guess = true;
                var userGuess = "";

                while (guess)
                {
                    Console.Write("\nHigher or Lower (H or L)? ");
                    var input = Console.ReadLine()?.Trim().ToLower();

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        switch (input.Substring(0, 1))
                        {
                            case "h": userGuess = "h"; guess = false; break;
                            case "l": guess = false; userGuess = "l"; break;
                            default: Console.WriteLine("You need to guess H or L.\n"); break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Come on {0}, You need to guess H or L.\n", user.FirstName);
                    }

                }

                int thirdDice = rnd.Next(1, 7);
                int fourthdice = rnd.Next(1, 7);
                int totalSecondRoll = thirdDice + fourthdice;

                Console.WriteLine("\nThird dice is a {0}.\nFourth dice is a {1}.\nTotal for the Second Roll is {2}.", thirdDice, fourthdice, totalSecondRoll);


                var higher = false;
                var lower = false;
                var matches = false;

                if (totalSecondRoll > totalFirstRoll)
                {
                    higher = true;
                }
                else
                {
                    if (totalSecondRoll < totalFirstRoll)
                    {
                        lower = true;
                    }
                    else
                    {
                        if (totalSecondRoll == totalFirstRoll)
                        {
                            matches = true;
                        }
                    }
                }

                if (userGuess == "h" && higher || userGuess == "l" && lower)
                {
                    Console.WriteLine("\nYou were correct, {0}! \n", user.FirstName);
                    playerScore++;
                }
                else
                {
                    if (matches)
                    {
                        Console.WriteLine("\nSorry they were matches...\n");
                    }
                    else
                    {
                        Console.WriteLine("\n{0} Wins...Try Again...\n", user.ComputerName);
                        dealerScore++;
                    }
                }

                counter++;
                if (counter != 3) continue; //Counter of 3
                ContinuePlaying(user);
            }

            // ReSharper disable once FunctionNeverReturns
        }

    }

    public class PresidentsStats
    {
        public string President { get; set; }
        public bool HasDiedInOfficePresident { get; set; }
        public int AgeAtDeath { get; set; }
        public string VpFirstTerm { get; set; }
        public string VpFirstTermDateRange { get; set; }
        public bool VpFirstTermHasDiedInOffice { get; set; }
        public bool VpFirstTermHasResignedInOffice { get; set; }
        public string VpSecondTerm { get; set; }
        public string VpSecondTermDateRange { get; set; }
        public bool VpSecondTermHasDiedInOffice { get; set; }
        public bool VpSecondTermHasResignedInOffice { get; set; }
        public string PresidentialDateRange { get; set; }
        public string Party { get; set; }
        public int NumberOfTermsElected { get; set; }
        public string LifeRange { get; set; }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string ComputerName { get; set; }
        public int HighestNumbersInARow { get; set; }
    }

    public class State
    {
        public string STATE { get; set; }
        public string CAPITAL { get; set; }
    }

    public class Holiday
    {
        public string NAME { get; set; }
        public int MONTH { get; set; }
        public string STATE { get; set; }
        public string TYPE { get; set; }
        public string DATE { get; set; }
    }
}
