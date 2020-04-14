Public Class Person
    Private firstname As String
    Private lastname As String
    Private dob As DateTime

    Public Property lastnameProperty() As String
        Set(value As String)
            lastname = value
        End Set
        Get
            Return lastname
        End Get
    End Property
    Public Property firstnameProperty() As String
        Set(value As String)
            firstname = value
        End Set
        Get
            Return firstname
        End Get
    End Property

    Public Property dobProperty As DateTime
        Set(value As DateTime)
            dob = value
        End Set
        Get
            Return dob
        End Get
    End Property

    Public Function computeAge() As Integer
        Dim age As Integer
        Dim timeSpan As TimeSpan = DateTime.Now.Subtract(dob)
        age = timeSpan.TotalDays \ 365
        Return age
    End Function

    Public Sub printDetails()
        Console.WriteLine("Name: {0} {1}", firstnameProperty, lastnameProperty)
        Console.WriteLine("DOB:  {0}", dobProperty)
        Console.WriteLine("Age:  {0}", computeAge)
    End Sub
End Class
