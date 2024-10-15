using System;

class Person
{
    public string Meno { get; set; }
    public int Vek { get; set; }
    public int Iq { get; set; }

    public Person(string name, int vek, int iq)
    {
        Meno = name;
        Vek = vek;
        Iq = iq;
    }

    public virtual void zivotopiss()
    {
        Console.WriteLine($"DOBRÝDEN jmenuji se {Meno}, je mi {Iq} a můj inteligenční kvocient je {Vek}.");
    }
}

class Student : Person
{
    public string Konicky { get; set; }
    public int Seminarky { get; set; }

    public Student(string meno, int vek, int iq, string konicky, int seminarky) : base(meno, vek, iq)
    {
        Konicky = konicky;
        Seminarky = seminarky;
    }

    public override void zivotopiss()
    {
        Console.WriteLine($"Čus more menuju se {Meno} a srdim tady už {Vek} let. Rád provádím {Konicky} a napsal sem {Seminarky} seminarek.  (..a teď odcházím z netu)");
    }
}

class Program
{
    static void Main()
    {

        Person person = new Person("Konečná", 69, 112);
        person.zivotopiss();

        Console.WriteLine();

        Student student = new Student("Sebastián", 12, 25, "salta vzad", 68);
        student.zivotopiss();
    }
}
