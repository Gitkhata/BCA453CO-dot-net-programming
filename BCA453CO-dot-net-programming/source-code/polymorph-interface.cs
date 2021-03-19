Using System;
using System.Collections.Generic;
namespace InheritanceInterface {
  interface IMovable {
    void Move();
  }
  class Human: IMovable {
    public void Move() // code that defines how human moves
    {
      Console.WriteLine("I am a Human, I move by Walking");
    }
  }
  class Fish: IMovable {
    public void Move() // code that defines how fish moves
    {
      Console.WriteLine("I am a Fish, I move by swimming");
    }
  }
  class Car: IMovable {
    public void Move() // code that defines how car moves
    {
      Console.WriteLine("I am Car, I move By wheel");
    }
  }
  class Program {
    static void Main(string[] args) {
      List < IMovable > lstMovable = new List < IMovable > {
        new Human(),
        new Fish(),
        new Car()
      };
      foreach(IMovable movableType in lstMovable) {
        movableType.Move();
      }
      Console.ReadLine();
    }
  }
}
