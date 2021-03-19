public class Person {
  public string Name {
    get; set;
  }
  public int Age {
    get; set;
  }
  public Person(string name, int age) {
    Name = name;
    Age = age;
  }
}

class Program {
  static void Main() {
    Person person1 = new Person("JP", 40);
    Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);
  }
}

