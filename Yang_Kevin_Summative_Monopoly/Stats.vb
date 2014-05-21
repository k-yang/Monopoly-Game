Public Class Stats
    Public name As String ' property name
    Public cost As Integer ' property cost
    Public mort As Integer ' property mortgage value
    Public housemort As Integer ' property house mortgage value
    Public rent As Integer ' property land on value
    Public house1 As Integer ' property 1 house rent
    Public house2 As Integer ' property 2 house rent
    Public house3 As Integer ' property 3 house rent
    Public house4 As Integer ' property 4 house rent
    Public hotel As Integer ' property hotel rent
    Public houses As Integer ' property amount of houses
    Public housecost As Integer ' property cost of one house
    Public owned As Boolean ' property ownership validity
    Public player As Integer ' property who owns it
    Public Sub New(ByVal spot As String, ByVal price As Integer, ByVal sell As Integer, _
                     ByVal sellhouse As Integer, ByVal pay As Integer, ByVal pay1 As Integer, ByVal pay2 As Integer, _
                     ByVal pay3 As Integer, ByVal pay4 As Integer, ByVal payfull As Integer, _
                     ByVal number As Integer, ByVal construct As Integer, ByVal bought As Boolean, _
                     ByVal owner As Integer)
        name = spot
        cost = price
        mort = sell
        housemort = sellhouse
        rent = pay
        house1 = pay1
        house2 = pay2
        house3 = pay3
        house4 = pay4
        hotel = payfull
        houses = number
        housecost = construct
        owned = bought
        player = owner
    End Sub
End Class
