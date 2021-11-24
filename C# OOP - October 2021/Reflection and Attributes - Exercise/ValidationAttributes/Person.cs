namespace ValidationAttributes
{
    public class Person
    {
        public Person(string fullname, int age)
        {
            Fullname = fullname;
            Age = age;
        }

        [MyRequired]
        public string Fullname { get; set; }
        [MyRange(10,99)]
        public int Age { get; set; }
    }
}