Module mysub
   Sub CalculatePay(ByRef hours As Double, ByRef wage As Decimal)
      'local variable declaration
      Dim pay As Double
      pay = hours * wage
      Console.WriteLine("Total Pay: Rs {0}", pay)
   End Sub
   Sub Main()
      'calling the CalculatePay Sub Procedure
      CalculatePay(25, 10)
      CalculatePay(40, 20)
      CalculatePay(30, 27.5)
      Console.ReadLine()
   End Sub
End Module