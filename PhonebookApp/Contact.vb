Class Contact 
    Property Name As string
    Property PhoneNumber As integer
    'also define getters and setters with properties
    'properties is equivalent to getter and setters
    Public Sub New(ByVal name as String, ByVal number as integer)
        Me.Name = name
        Me.PhoneNumber = number
    End Sub
    
    Public Sub New()
        'parameterless constructor
    End Sub

    Overrides Function ToString()  As String
        return $"Name: {Me.Name} Number: {Me.PhoneNumber}"

    End Function
      

End Class