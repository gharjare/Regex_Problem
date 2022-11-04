namespace UserRegistration
{
    class program
    {
        public static void Main(string[] args)
        {
            //Pattern pattern = new Pattern();
            //Console.WriteLine("please enter the pattern");
            //string name = Console.ReadLine();

            //bool value = pattern.ValidateName(name);

            //if(value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            //Pattern1 pattern1 = new Pattern1();
            //Console.WriteLine("please enter the pattern");
            //string name = Console.ReadLine();

            //bool value = pattern1.ValidateName(name);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            //Pattern2 pattern2 = new Pattern2();
            //Console.WriteLine("please enter the pattern");
            //string Email = Console.ReadLine();

            //bool value = pattern2.ValidateEmail(Email);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            //Pattern3 pattern3 = new Pattern3();
            //Console.WriteLine("please enter the pattern");
            //string Number = Console.ReadLine();

            //bool value = pattern3.ValidateNumber(Number);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            //Pattern4 pattern4 = new Pattern4();
            //Console.WriteLine("please enter the pattern");
            //string Password = Console.ReadLine();

            //bool value = pattern4.ValidatePassword(Password);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}
            //Pattern5 pattern5 = new Pattern5();
            //Console.WriteLine("please enter the pattern");
            //string Upper = Console.ReadLine();

            //bool value = pattern5.ValidateUpper(Upper);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            //Pattern6 pattern6 = new Pattern6();
            //Console.WriteLine("please enter the pattern");
            //string Numeric = Console.ReadLine();

            //bool value = pattern6.ValidateNumeric(Numeric);

            //if (value)
            //{
            //    Console.WriteLine("pattern is match");
            //}
            //else
            //{
            //    Console.WriteLine("pattern is not match");
            //}

            Pattern7 pattern7 = new Pattern7();
            Console.WriteLine("please enter the pattern");
            string Character = Console.ReadLine();

            bool value = pattern7.ValidateCharacter(Character);

            if (value)
            {
                Console.WriteLine("pattern is match");
            }
            else
            {
                Console.WriteLine("pattern is not match");
            }
        }
    }
}