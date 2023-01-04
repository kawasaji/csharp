public class Students
{
    public class Student
    {
        public Student(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    List<Student> students = new();

    public Student this[int i]
    {
        get { return students[i]; }
        set { students[i] = value; }
    }
}

public class Fraction
{
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("There cannot be zero!");
        }

        this.numerator = Math.Abs(numerator);
        this.denominator = Math.Abs(denominator);

        if ((numerator * denominator) < 0)
        {
            this.sign = -1;
        }
        else
        {
            this.sign = 1;
        }
    }
    public static Fraction operator +(Fraction a, Fraction b)
    {

        return a + b;
    }
    public static Fraction operator -(Fraction a, Fraction b)
    {
        return a - b;
    }
    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction((a.numerator * a.sign * b.numerator * b.sign), (a.denominator * b.denominator));
    }
    public static Fraction operator /(Fraction a, Fraction b)
    {
        Fraction tmp = new Fraction(b.denominator, b.numerator);
        return a * tmp;
    }

    public int numerator;
    public int denominator;
    public int sign;
}