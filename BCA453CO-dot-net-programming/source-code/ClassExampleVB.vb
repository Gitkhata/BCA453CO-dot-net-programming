Imports System
Module Class_Example
    Sub Main()
        Dim rect As Rectangle = New Rectangle() 'create an object
        Dim rect2 As Rectangle = New Rectangle() 'create an object
        Dim area, para As Integer

        rect.setLength = (60)
        rect.setBreadth= (50)

        rect2.setLength = (1000)
        rect2.setBreadth = (600)
        
        area = rect.length * rect.Breadth

        Console.WriteLine(" Area of Rectangle is {0}", area)

        para = 2 (rect2.length + rect.Breadth)
        
        Console.WriteLine(" Parameter of Rectangle is {0}", para)
        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
    
    Public Class Rectangle
        Public length As Integer
        Public Breadth As Integer

        Public Sub setLength(ByVal len As Integer)
            length = len
        End Sub

        Public Sub setBreadth(ByVal bre As Integer)
            Breadth = bre
        End Sub
        Public Function GetArea() As Integer
            Return length * Breadth
        End Function

        Public Function GetParameter() As Integer
            Return 2 * (length + Breadth)
        End Function
    End Class
End Module
