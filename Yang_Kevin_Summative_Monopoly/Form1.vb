Public Class Form1
    Dim player(0 To 3) As Boolean ' declares the validity of the 4 players
    Dim cheatcode As String ' declares the cheat code
    Dim cc As Integer ' declares the random chance/community chest 
    Dim oldcash(0 To 3) As Integer ' declares the initial amount of cash at the start of the turn
    Dim jail(0 To 3) As Boolean ' declares the validity of jailed
    Dim freeparking As Integer ' declares the value of cash gained by landing on freeparking
    Dim railway(0 To 3) As Integer ' declares the amount of railways owned by one person
    Dim utility(0 To 3) As Integer ' declares the amount of utilities owned by one person
    Dim choice As Integer ' the answer in all vbYesNo MsgBoxes
    Dim dice1 As Integer = 1 ' value of dice1
    Dim dice2 As Integer = 1 ' value of dice2
    Dim turn As Integer = 0 ' determines who's turn it is
    Dim cash(0 To 3) As Integer ' declares the amount of cash one owns at the end of their turn
    Dim space(0 To 3) As Integer ' declares the space a player has landed on
    Dim street(0 To 39) As String ' declares all of the street names
    Dim Stats As List(Of Stats) = New List(Of Stats)
    Public street1 As Stats = New Stats("Badminton Ave.", 60, 30, 25, 2, 10, 30, 90, 160, 250, 0, 50, False, 0)
    Public street3 As Stats = New Stats("Computer Ave.", 60, 30, 25, 4, 20, 60, 180, 320, 450, 0, 50, False, 0)

    Public street5 As Stats = New Stats("Kevin's Awesome Railroad 1", 200, 100, 0, 25, 50, 100, 200, 200, 200, 0, 0, False, 0)

    Public street6 As Stats = New Stats("Asia Ave.", 100, 50, 25, 6, 30, 90, 270, 400, 550, 0, 50, False, 0)
    Public street8 As Stats = New Stats("China Ave.", 100, 50, 25, 6, 30, 90, 270, 400, 550, 0, 50, False, 0)
    Public street9 As Stats = New Stats("Canada Ave.", 120, 60, 25, 8, 40, 100, 300, 450, 500, 0, 50, False, 0)

    Public street11 As Stats = New Stats("St. Kevin's Place", 140, 70, 50, 10, 50, 150, 460, 625, 750, 0, 100, False, 0)
    Public street12 As Stats = New Stats("Hello Kitty Company", 150, 75, 0, 4, 10, 0, 0, 0, 0, 0, 0, False, 0)
    Public street13 As Stats = New Stats("Noob Ave.", 140, 70, 50, 10, 50, 150, 450, 625, 750, 0, 100, False, 0)
    Public street14 As Stats = New Stats("Ping Pong Ave.", 160, 80, 50, 12, 60, 180, 500, 700, 900, 0, 100, False, 0)

    Public street15 As Stats = New Stats("Kevin's Awesome Railroad 2", 200, 100, 0, 25, 50, 100, 200, 200, 200, 0, 0, False, 0)

    Public street16 As Stats = New Stats("St. Yang's Place", 180, 90, 50, 14, 70, 200, 550, 750, 950, 0, 100, False, 0)
    Public street18 As Stats = New Stats("Tennis Ave.", 180, 90, 50, 14, 70, 200, 550, 750, 950, 0, 100, False, 0)
    Public street19 As Stats = New Stats("Ottawa Ave.", 200, 100, 50, 16, 80, 200, 600, 800, 1000, 0, 100, False, 0)

    Public street21 As Stats = New Stats("McDonald's Ave.", 220, 110, 75, 18, 90, 250, 700, 875, 1050, 0, 150, False, 0)
    Public street23 As Stats = New Stats("Indian Ave.", 220, 110, 75, 18, 90, 250, 700, 875, 1050, 0, 150, False, 0)
    Public street24 As Stats = New Stats("Chili Ave.", 240, 120, 75, 20, 100, 300, 750, 925, 110, 0, 150, False, 0)

    Public street25 As Stats = New Stats("Kevin's Awesome Railroad 3", 200, 100, 0, 25, 50, 100, 200, 200, 200, 0, 0, False, 0)

    Public street26 As Stats = New Stats("Atlantis Ave.", 260, 130, 75, 22, 110, 330, 800, 975, 1150, 0, 150, False, 0)
    Public street27 As Stats = New Stats("Chinese Buffet Ave.", 260, 130, 75, 22, 110, 330, 800, 975, 1150, 0, 150, False, 0)
    Public street28 As Stats = New Stats("Badminton Courts", 150, 75, 0, 4, 10, 0, 0, 0, 0, 0, 0, False, 0)
    Public street29 As Stats = New Stats("Kevin's Garden", 280, 140, 75, 22, 120, 360, 850, 1025, 1200, 0, 150, False, 0)

    Public street31 As Stats = New Stats("Troll Ave.", 300, 150, 100, 26, 130, 390, 900, 1100, 1275, 0, 200, False, 0)
    Public street32 As Stats = New Stats("Mall Ave.", 300, 150, 100, 26, 130, 390, 900, 1100, 1275, 0, 200, False, 0)
    Public street34 As Stats = New Stats("Christmas Ave.", 320, 160, 100, 28, 150, 450, 1000, 1200, 1300, 0, 200, False, 0)

    Public street35 As Stats = New Stats("Kevin's Awesome Railroad 4", 200, 100, 0, 25, 50, 100, 200, 200, 200, 0, 0, False, 0)

    Public street37 As Stats = New Stats("Colonel By Secondary School", 350, 175, 100, 35, 175, 500, 1100, 1300, 1500, 0, 200, False, 0)
    Public street39 As Stats = New Stats("Chinatown", 400, 200, 100, 50, 200, 600, 1400, 1700, 2000, 0, 200, False, 0)

    ' these public streetXX variables are all of the property stats of each buyable property; each of them are part of a class

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize() ' this randomizes all of the dice rolls

        street(0) = "GO"
        street(1) = "Badminton Ave."
        street(2) = "Kevin's Drawer"
        street(3) = "Computer Ave."
        street(4) = "show me the money"
        street(5) = "Kevin's Awesome Railroad 1"
        street(6) = "Asia Ave."
        street(7) = "You Got Lucky"
        street(8) = "China Ave."
        street(9) = "Canada Ave."
        street(10) = "Visiting Kevin's House"
        street(11) = "St. Kevin's Place"
        street(12) = "Hello Kitty Company"
        street(13) = "Noob Ave."
        street(14) = "Ping Pong Ave."
        street(15) = "Kevin's Awesome Railroad 2"
        street(16) = "St. Yang's Place"
        street(17) = "Kevin's Drawer"
        street(18) = "Tennis Ave."
        street(19) = "Ottawa Ave."
        street(20) = "Toilet"
        street(21) = "McDonald's Ave."
        street(22) = "You Got Lucky"
        street(23) = "Indian Ave."
        street(24) = "Chili Ave."
        street(25) = "Kevin's Awesome Railroad 3"
        street(26) = "Atlantis Ave."
        street(27) = "Chinese Buffet Ave."
        street(28) = "Badminton Courts"
        street(29) = "Kevin's Garden"
        street(30) = "Kevin's Room"
        street(31) = "Troll Ave."
        street(32) = "Mall Ave."
        street(33) = "Kevin's Drawer"
        street(34) = "Christmas Ave."
        street(35) = "Kevin's Awesome Railroad 4"
        street(36) = "You Got Lucky"
        street(37) = "Colonel By Secondary School"
        street(38) = "Pay Up Noobs"
        street(39) = "Chinatown"
        ' these are all of the street names

        space(0) = 0
        space(1) = 0
        space(2) = 0
        space(3) = 0
        ' sets all of the players' start points

        jail(0) = False
        jail(1) = False
        jail(2) = False
        jail(3) = False
        ' sets all of the players' jail validity

        railway(0) = 0
        railway(1) = 0
        railway(2) = 0
        railway(3) = 0
        ' sets all of the players' railway ownage

        utility(0) = 0
        utility(1) = 0
        utility(2) = 0
        utility(3) = 0
        ' sets all of the players' utility ownage

        cash(0) = 1500
        cash(1) = 1500
        cash(2) = 1500
        cash(3) = 1500
        ' sets all of the players' cash

        oldcash(0) = 1500
        oldcash(1) = 1500
        oldcash(2) = 1500
        oldcash(3) = 1500
        ' sets all of the players' cash

        player(0) = True
        player(1) = True
        player(2) = True
        player(3) = True
        'sets all of the players' validity
    End Sub
    Public Sub Click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Click.Click
        If Val(MoneyNumber.Text) < 1 Then
            MsgBox("Everybody has to have at least some money") ' makes it so that the starting money can't be less than 1
        Else
            If Val(MoneyNumber.Text) > 2000 Then
                MsgBox("You can only have up to 2000") ' makes it so that the starting money can't be greater than 2000
            Else
                cash(0) = Val(MoneyNumber.Text)
                cash(1) = Val(MoneyNumber.Text)
                cash(2) = Val(MoneyNumber.Text)
                cash(3) = Val(MoneyNumber.Text) ' sets everybody's cash
            End If
        End If
        If Val(PlayerNumber.Text) < 2 Then
            MsgBox("There has to be at least 2 players") ' makes it so that there can't be less than 2 players
        Else
            If Val(PlayerNumber.Text) > 4 Then
                MsgBox("Only up to 4 players please") ' makes it so that there can only be up to 4 players
            Else
                Box1.Visible = False
                Box2.Visible = False
                Click.Visible = False
                Board.Visible = True
                Text1.Visible = True
                money.Visible = True
                money.Text = Val(MoneyNumber.Text)
                cashtext.Visible = True
                Distancer.Visible = True
                Spacer.Visible = True
                Roller.Visible = True ' exits out of the startup options and starts the game board
            End If
        End If
        If Val(PlayerNumber.Text) = 3 Then
            player(3) = False ' determines the validity of the players based on the amount of people playing
        End If
        If Val(PlayerNumber.Text) = 2 Then
            player(3) = False
            player(2) = False ' determines the validity of the players based on the amount of people playing
        End If
    End Sub

    Private Sub PlayerNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerNumber.TextChanged

    End Sub

    Private Sub CpuNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MoneyNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoneyNumber.TextChanged

    End Sub
    Private Sub Meh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Roller.Click
        Box4.Visible = False ' closes up the build houses groupbox of the last player
        Box5.Visible = False ' closes up the mortgage groupbox of the last player
        If player(turn) = False Then
            Text1.Visible = False
            Text2.Visible = False
            Text3.Visible = False
            Text4.Visible = False
            MsgBox("You're bankrupt. Nice try.")
            turn = turn + 1
            If turn > (Val(PlayerNumber.Text) - 1) Then
                turn = 0
            End If
            If turn = 0 Then
                Text1.Visible = True
            End If
            If turn = 1 Then
                Text2.Visible = True
            End If
            If turn = 2 Then
                Text3.Visible = True
            End If
            If turn = 3 Then
                Text4.Visible = True
            End If
            'checks to see if the current player has been eliminated already, and then skips their turn if it is
        Else
            Box3.Visible = True ' if the player hasn't been eliminated, then start their turn
            If player(0) = False Then
                If player(1) = False Then
                    If player(2) = False Then
                        MsgBox("Congratulations! Player 4 won!") ' checks to see if somebody won
                        Box3.Visible = False
                        Box4.Visible = False
                        Box5.Visible = False
                        Roller.Visible = False
                        Board.Visible = True
                        Text1.Visible = True
                        money.Visible = True
                        cashtext.Visible = True
                        Roller.Visible = True
                    End If
                End If
            End If
            If player(3) = False Then
                If player(1) = False Then
                    If player(0) = False Then
                        MsgBox("Congratulations! Player 3 won!") ' checks to see if somebody won
                        Box3.Visible = False
                        Box4.Visible = False
                        Box5.Visible = False
                        Roller.Visible = False
                        Board.Visible = True
                        Text1.Visible = True
                        money.Visible = True
                        cashtext.Visible = True
                        Roller.Visible = True
                    End If
                End If
            End If
            If player(0) = False Then
                If player(3) = False Then
                    If player(2) = False Then
                        MsgBox("Congratulations! Player 2 won!") ' checks to see if somebody won
                        Box3.Visible = False
                        Box4.Visible = False
                        Box5.Visible = False
                        Roller.Visible = False
                        Board.Visible = True
                        Text1.Visible = True
                        money.Visible = True
                        cashtext.Visible = True
                        Roller.Visible = True
                    End If
                End If
            End If
            If player(3) = False Then
                If player(1) = False Then
                    If player(2) = False Then
                        MsgBox("Congratulations! Player 1 won!") ' checks to see if somebody won
                        Box3.Visible = False
                        Box4.Visible = False
                        Box5.Visible = False
                        Roller.Visible = False
                        Board.Visible = True
                        Text1.Visible = True
                        money.Visible = True
                        cashtext.Visible = True
                        Roller.Visible = True
                    End If
                End If
            End If
            oldcash(turn) = cash(turn) ' sets up the initial amount at the start of the turn
            Dice11.Visible = False
            Dice21.Visible = False
            Dice31.Visible = False
            Dice41.Visible = False
            Dice51.Visible = False
            Dice61.Visible = False
            Dice12.Visible = False
            Dice22.Visible = False
            Dice32.Visible = False
            Dice42.Visible = False
            Dice52.Visible = False
            Dice62.Visible = False
            ' starts the dice rolling
            If jail(turn) = True Then
                choice = MsgBox("You're stuck in Kevin's Room (Jail). Would you like to pay 50$ to escape?", vbYesNo) ' checks if the current player is jailed
                If choice = vbYes Then ' the player pays 50 to get out and their turn starts
                    cash(turn) = cash(turn) - 50
                    jail(turn) = False
                    dice1 = Int(Rnd() * 6 + 1) ' dice rolling
                    dice2 = Int(Rnd() * 6 + 1)
                    space(turn) = space(turn) + dice1 + dice2
                    Distance.Text = space(turn)
                    If dice1 = 1 Then
                        Dice11.Visible = True
                    End If
                    If dice1 = 2 Then
                        Dice21.Visible = True
                    End If
                    If dice1 = 3 Then
                        Dice31.Visible = True
                    End If
                    If dice1 = 4 Then
                        Dice41.Visible = True
                    End If
                    If dice1 = 5 Then
                        Dice51.Visible = True
                    End If
                    If dice1 = 6 Then
                        Dice61.Visible = True
                    End If
                    If dice2 = 1 Then
                        Dice12.Visible = True
                    End If
                    If dice2 = 2 Then
                        Dice22.Visible = True
                    End If
                    If dice2 = 3 Then
                        Dice32.Visible = True
                    End If
                    If dice2 = 4 Then
                        Dice42.Visible = True
                    End If
                    If dice2 = 5 Then
                        Dice52.Visible = True
                    End If
                    If dice2 = 6 Then
                        Dice62.Visible = True
                    End If
                    ' dice visual
                    If dice1 = dice2 Then
                        MsgBox("Snake Eyes!!!") ' checks if the player has rolled a snake eyes
                        Roller.Visible = True
                        Ender.Visible = False
                    Else
                        Roller.Visible = False
                        Ender.Visible = True
                    End If
                End If
                If choice = vbNo Then ' the player remains in jail
                    MsgBox("Then the only way you can escape is if you roll a snake eyes!!!")
                    dice1 = Int(Rnd() * 6 + 1)
                    dice2 = Int(Rnd() * 6 + 1)
                    If dice1 = 1 Then
                        Dice11.Visible = True
                    End If
                    If dice1 = 2 Then
                        Dice21.Visible = True
                    End If
                    If dice1 = 3 Then
                        Dice31.Visible = True
                    End If
                    If dice1 = 4 Then
                        Dice41.Visible = True
                    End If
                    If dice1 = 5 Then
                        Dice51.Visible = True
                    End If
                    If dice1 = 6 Then
                        Dice61.Visible = True
                    End If
                    If dice2 = 1 Then
                        Dice12.Visible = True
                    End If
                    If dice2 = 2 Then
                        Dice22.Visible = True
                    End If
                    If dice2 = 3 Then
                        Dice32.Visible = True
                    End If
                    If dice2 = 4 Then
                        Dice42.Visible = True
                    End If
                    If dice2 = 5 Then
                        Dice52.Visible = True
                    End If
                    If dice2 = 6 Then
                        Dice62.Visible = True
                    End If
                    ' dice visual
                    If dice1 = dice2 Then
                        jail(turn) = False
                        space(turn) = space(turn) + dice1 + dice2
                        MsgBox("Congratulations, you got out!") ' if the player rolls a snake eyes, they get out
                    Else
                        space(turn) = 10 ' the player remains in jail
                    End If
                End If
            End If
            If jail(turn) = False Then ' player is a free man
                dice1 = Int(Rnd() * 6 + 1) ' dice roll
                dice2 = Int(Rnd() * 6 + 1)
                space(turn) = space(turn) + dice1 + dice2
            End If
            If dice1 = 1 Then
                Dice11.Visible = True
            End If
            If dice1 = 2 Then
                Dice21.Visible = True
            End If
            If dice1 = 3 Then
                Dice31.Visible = True
            End If
            If dice1 = 4 Then
                Dice41.Visible = True
            End If
            If dice1 = 5 Then
                Dice51.Visible = True
            End If
            If dice1 = 6 Then
                Dice61.Visible = True
            End If
            If dice2 = 1 Then
                Dice12.Visible = True
            End If
            If dice2 = 2 Then
                Dice22.Visible = True
            End If
            If dice2 = 3 Then
                Dice32.Visible = True
            End If
            If dice2 = 4 Then
                Dice42.Visible = True
            End If
            If dice2 = 5 Then
                Dice52.Visible = True
            End If
            If dice2 = 6 Then
                Dice62.Visible = True
            End If
            'dice visual
            If dice1 = dice2 Then
                MsgBox("Snake Eyes!!!") ' checks if the player has rolled a snake eyes
                Roller.Visible = True
                Ender.Visible = False
            Else
                Roller.Visible = False
                Ender.Visible = True
            End If
            If space(turn) > 39 Then ' pass Go
                space(turn) = space(turn) - 40
                cash(turn) = cash(turn) + 200
                money.Text = cash(turn)
            End If
            place.Text = street(space(turn)).ToString()
            If space(turn) = 40 Then ' lands on Go
                Lander.Text = "Nobody owns this"
                cash(turn) = cash(turn) + 400
            End If

            If space(turn) = 4 Then ' lands on show me the money
                Lander.Text = "Nobody owns this"
                cash(turn) = cash(turn) - 200
                freeparking = freeparking + 200
            End If
            If space(turn) = 38 Then ' Lands on Pay Up Noobs
                Lander.Text = "Nobody owns this"
                cash(turn) = cash(turn) - 75
                freeparking = freeparking + 75
            End If

            If space(turn) = 2 Then ' lands on Kevin's Drawer
                Lander.Text = "Nobody owns this"
                cc = Int(Rnd() * 5) ' chooses random card
                If cc = 0 Then ' random card 1
                    MsgBox("Kevin's Drawer : Collect 50$ from the bank!")
                    cash(turn) = cash(turn) + 50
                    money.Text = cash(turn)
                End If
                If cc = 1 Then ' random card 2
                    MsgBox("Kevin's Drawer : Donate 100$ to the bank!")
                    cash(turn) = cash(turn) - 100
                    freeparking = freeparking + 100
                End If
                If cc = 2 Then ' random card 3
                    MsgBox("Kevin's Drawer : Collect 50$ from each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                End If
                If cc = 3 Then ' random card 4
                    MsgBox("Kevin's Drawer : Donate 50$ to each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                End If
                If cc = 4 Then ' random card 5
                    MsgBox("Kevin's Drawer : Advance to Chinatown!")
                    space(turn) = 39
                End If
                money.Text = cash(turn)
            End If

            If space(turn) = 17 Then ' lands on Kevin's Drawer
                Lander.Text = "Nobody owns this"
                cc = Int(Rnd() * 5) ' chooses random card
                If cc = 0 Then ' random card 1
                    MsgBox("Kevin's Drawer : Collect 50$ from the bank!")
                    cash(turn) = cash(turn) + 50
                    money.Text = cash(turn)
                End If
                If cc = 1 Then ' random card 2
                    MsgBox("Kevin's Drawer : Donate 100$ to the bank!")
                    cash(turn) = cash(turn) - 100
                    freeparking = freeparking + 100
                End If
                If cc = 2 Then ' random card 3
                    MsgBox("Kevin's Drawer : Collect 50$ from each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                End If
                If cc = 3 Then ' random card 4
                    MsgBox("Kevin's Drawer : Donate 50$ to each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                End If
                If cc = 4 Then ' random card 5
                    MsgBox("Kevin's Drawer : Advance to Chinatown!")
                    space(turn) = 39
                End If
                money.Text = cash(turn)
            End If

            If space(turn) = 33 Then ' lands on Kevin's Drawer
                Lander.Text = "Nobody owns this"
                cc = Int(Rnd() * 5) ' chooses random card
                If cc = 0 Then ' random card 1
                    MsgBox("Kevin's Drawer : Collect 50$ from the bank!")
                    cash(turn) = cash(turn) + 50
                    money.Text = cash(turn)
                End If
                If cc = 1 Then ' random card 2
                    MsgBox("Kevin's Drawer : Donate 100$ to the bank!")
                    cash(turn) = cash(turn) - 100
                    freeparking = freeparking + 100
                End If
                If cc = 2 Then ' random card 3
                    MsgBox("Kevin's Drawer : Collect 50$ from each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) - 50
                        cash(turn) = cash(turn) + 50
                    End If
                End If
                If cc = 3 Then ' random card 4
                    MsgBox("Kevin's Drawer : Donate 50$ to each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) + 50
                        cash(turn) = cash(turn) - 50
                    End If
                End If
                If cc = 4 Then ' random card 5
                    MsgBox("Kevin's Drawer : Advance to Chinatown!")
                    space(turn) = 39
                End If
                money.Text = cash(turn)
            End If

            If space(turn) = 7 Then ' lands on You Got Lucky
                Lander.Text = "Nobody owns this"
                cc = Int(Rnd() * 5) ' chooses random card
                If cc = 0 Then ' random card 1
                    MsgBox("You Got Lucky : Collect 500$ from the bank!")
                    cash(turn) = cash(turn) + 500
                    money.Text = cash(turn)
                End If
                If cc = 1 Then ' random card 2
                    MsgBox("Kevin's Drawer : Donate 200$ to the bank!")
                    cash(turn) = cash(turn) - 100
                    freeparking = freeparking + 100
                End If
                If cc = 2 Then ' random card 3
                    MsgBox("Kevin's Drawer : Collect 150$ from each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                End If
                If cc = 3 Then ' random card 4
                    MsgBox("Kevin's Drawer : Donate 150$ to each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                End If
                If cc = 4 Then ' random card 5
                    MsgBox("Kevin's Drawer : GO TO KEVIN'S ROOM!")
                    jail(turn) = True
                End If
                money.Text = cash(turn)
            End If

            If space(turn) = 22 Then ' lands on You Got Lucky
                Lander.Text = "Nobody owns this"
                cc = Int(Rnd() * 5) ' chooses random card
                If cc = 0 Then ' random card 1
                    MsgBox("You Got Lucky : Collect 500$ from the bank!")
                    cash(turn) = cash(turn) + 500
                    money.Text = cash(turn)
                End If
                If cc = 1 Then ' random card 2
                    MsgBox("Kevin's Drawer : Donate 200$ to the bank!")
                    cash(turn) = cash(turn) - 100
                    freeparking = freeparking + 100
                End If
                If cc = 2 Then ' random card 3
                    MsgBox("Kevin's Drawer : Collect 150$ from each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                End If
                If cc = 3 Then ' random card 4
                    MsgBox("Kevin's Drawer : Donate 150$ to each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                End If
                If cc = 4 Then ' random card 5
                    MsgBox("Kevin's Drawer : GO TO KEVIN'S ROOM!")
                    jail(turn) = True
                End If
                money.Text = cash(turn)
            End If

            If space(turn) = 36 Then ' lands on You Got Lucky
                Lander.Text = "Nobody owns this"
                cc = Int(Rnd() * 5) ' chooses random card
                If cc = 0 Then ' random card 1
                    MsgBox("You Got Lucky : Collect 500$ from the bank!")
                    cash(turn) = cash(turn) + 500
                    money.Text = cash(turn)
                End If
                If cc = 1 Then ' random card 2
                    MsgBox("Kevin's Drawer : Donate 200$ to the bank!")
                    cash(turn) = cash(turn) - 100
                    freeparking = freeparking + 100
                End If
                If cc = 2 Then ' random card 3
                    MsgBox("Kevin's Drawer : Collect 150$ from each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) - 150
                        cash(turn) = cash(turn) + 150
                    End If
                End If
                If cc = 3 Then ' random card 4
                    MsgBox("Kevin's Drawer : Donate 150$ to each player!")
                    If player(0) = True Then
                        cash(0) = cash(0) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                    If player(1) = True Then
                        cash(1) = cash(1) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                    If player(2) = True Then
                        cash(2) = cash(2) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                    If player(3) = True Then
                        cash(3) = cash(3) + 150
                        cash(turn) = cash(turn) - 150
                    End If
                End If
                If cc = 4 Then ' random card 5
                    MsgBox("Kevin's Drawer : GO TO KEVIN'S ROOM!")
                    jail(turn) = True
                End If
                money.Text = cash(turn)
            End If
            If space(turn) = 10 Then ' lands on Visiting Kevin's House
                Lander.Text = "Nobody owns this"
            End If
            If space(turn) = 30 Then ' lands on Go To Kevin's Room
                Lander.Text = "Nobody owns this"
                MsgBox("GO TO KEVIN'S ROOM!")
                space(turn) = 10
                jail(turn) = True
            End If
            If space(turn) = 20 Then ' lands on Toilet
                Lander.Text = "Nobody owns this"
                MsgBox("Welcome to the Toilet! Here, you claim all of the money donated by every player!")
                cash(turn) = cash(turn) + freeparking
                money.Text = cash(turn)
            End If
            If space(turn) = 1 Then ' lands on Badminton Ave.
                Lander.Text = "Player " + street1.player.ToString() + " owns this"
                If street1.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street1.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street1.houses = 0 Then
                            cash(turn) = cash(turn) - street1.rent
                            cash(street1.player - 1) = cash(street1.player - 1) + street1.rent
                        End If
                        If street1.houses = 1 Then
                            cash(turn) = cash(turn) - street1.house1
                            cash(street1.player - 1) = cash(street1.player - 1) + street1.house1
                        End If
                        If street1.houses = 2 Then
                            cash(turn) = cash(turn) - street1.house2
                            cash(street1.player - 1) = cash(street1.player - 1) + street1.house2
                        End If
                        If street1.houses = 3 Then
                            cash(turn) = cash(turn) - street1.house3
                            cash(street1.player - 1) = cash(street1.player - 1) + street1.house3
                        End If
                        If street1.houses = 4 Then
                            cash(turn) = cash(turn) - street1.house4
                            cash(street1.player - 1) = cash(street1.player - 1) + street1.house4
                        End If
                        If street1.houses = 5 Then
                            cash(turn) = cash(turn) - street1.hotel
                            cash(street1.player - 1) = cash(street1.player - 1) + street1.hotel
                        End If
                    End If

                End If
            End If
            If space(turn) = 3 Then ' lands on Computer Ave.
                Lander.Text = "Player " + street3.player.ToString() + " owns this"
                If street3.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street3.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street3.houses = 0 Then
                            cash(turn) = cash(turn) - street3.rent
                            cash(street3.player - 1) = cash(street3.player - 1) + street3.rent
                        End If
                        If street3.houses = 1 Then
                            cash(turn) = cash(turn) - street3.house1
                            cash(street3.player - 1) = cash(street3.player - 1) + street3.house1
                        End If
                        If street3.houses = 2 Then
                            cash(turn) = cash(turn) - street3.house2
                            cash(street3.player - 1) = cash(street3.player - 1) + street3.house2
                        End If
                        If street3.houses = 3 Then
                            cash(turn) = cash(turn) - street3.house3
                            cash(street3.player - 1) = cash(street3.player - 1) + street3.house3
                        End If
                        If street3.houses = 4 Then
                            cash(turn) = cash(turn) - street3.house4
                            cash(street3.player - 1) = cash(street3.player - 1) + street3.house4
                        End If
                        If street3.houses = 5 Then
                            cash(turn) = cash(turn) - street3.hotel
                            cash(street3.player - 1) = cash(street3.player - 1) + street3.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 5 Then ' lands on Kevin's Awesome Railroad 1
                Lander.Text = "Player " + street5.player.ToString() + " owns this"
                If street5.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street5.owned = True Then ' determines how much rent is payed to the owner if owned
                        If railway(street5.player - 1) = 1 Then
                            cash(turn) = cash(turn) - 25
                            cash(street5.player - 1) = cash(street5.player - 1) + 25
                        End If
                        If railway(street5.player - 1) = 2 Then
                            cash(turn) = cash(turn) - 50
                            cash(street5.player - 1) = cash(street5.player - 1) + 50
                        End If
                        If railway(street5.player - 1) = 3 Then
                            cash(turn) = cash(turn) - 100
                            cash(street5.player - 1) = cash(street5.player - 1) + 100
                        End If
                        If railway(street5.player - 1) = 4 Then
                            cash(turn) = cash(turn) - 200
                            cash(street5.player - 1) = cash(street5.player - 1) + 200
                        End If
                    End If
                End If
            End If
            If space(turn) = 6 Then ' lands on Asia Ave.
                Lander.Text = "Player " + street6.player.ToString() + " owns this"
                If street6.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street6.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street6.houses = 0 Then
                            cash(turn) = cash(turn) - street6.rent
                            cash(street6.player - 1) = cash(street6.player - 1) + street6.rent
                        End If
                        If street6.houses = 1 Then
                            cash(turn) = cash(turn) - street6.house1
                            cash(street6.player - 1) = cash(street6.player - 1) + street6.house1
                        End If
                        If street6.houses = 2 Then
                            cash(turn) = cash(turn) - street6.house2
                            cash(street6.player - 1) = cash(street6.player - 1) + street6.house2
                        End If
                        If street6.houses = 3 Then
                            cash(turn) = cash(turn) - street6.house3
                            cash(street6.player - 1) = cash(street6.player - 1) + street6.house3
                        End If
                        If street6.houses = 4 Then
                            cash(turn) = cash(turn) - street6.house4
                            cash(street6.player - 1) = cash(street6.player - 1) + street6.house4
                        End If
                        If street6.houses = 5 Then
                            cash(turn) = cash(turn) - street6.hotel
                            cash(street6.player - 1) = cash(street6.player - 1) + street6.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 8 Then ' lands on China Ave.
                Lander.Text = "Player " + street8.player.ToString() + " owns this"
                If street8.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street8.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street8.houses = 0 Then
                            cash(turn) = cash(turn) - street8.rent
                            cash(street8.player - 1) = cash(street8.player - 1) + street8.rent
                        End If
                        If street8.houses = 1 Then
                            cash(turn) = cash(turn) - street8.house1
                            cash(street8.player - 1) = cash(street8.player - 1) + street8.house1
                        End If
                        If street8.houses = 2 Then
                            cash(turn) = cash(turn) - street8.house2
                            cash(street8.player - 1) = cash(street8.player - 1) + street8.house2
                        End If
                        If street8.houses = 3 Then
                            cash(turn) = cash(turn) - street8.house3
                            cash(street8.player - 1) = cash(street8.player - 1) + street8.house3
                        End If
                        If street8.houses = 4 Then
                            cash(turn) = cash(turn) - street8.house4
                            cash(street8.player - 1) = cash(street8.player - 1) + street8.house4
                        End If
                        If street8.houses = 5 Then
                            cash(turn) = cash(turn) - street8.hotel
                            cash(street8.player - 1) = cash(street8.player - 1) + street8.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 9 Then ' lands on Canada Ave.
                Lander.Text = "Player " + street9.player.ToString() + " owns this"
                If street9.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street9.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street9.houses = 0 Then
                            cash(turn) = cash(turn) - street9.rent
                            cash(street9.player - 1) = cash(street9.player - 1) + street9.rent
                        End If
                        If street9.houses = 1 Then
                            cash(turn) = cash(turn) - street9.house1
                            cash(street9.player - 1) = cash(street9.player - 1) + street9.house1
                        End If
                        If street9.houses = 2 Then
                            cash(turn) = cash(turn) - street9.house2
                            cash(street9.player - 1) = cash(street9.player - 1) + street9.house2
                        End If
                        If street9.houses = 3 Then
                            cash(turn) = cash(turn) - street9.house3
                            cash(street9.player - 1) = cash(street9.player - 1) + street9.house3
                        End If
                        If street9.houses = 4 Then
                            cash(turn) = cash(turn) - street9.house4
                            cash(street9.player - 1) = cash(street9.player - 1) + street9.house4
                        End If
                        If street9.houses = 5 Then
                            cash(turn) = cash(turn) - street9.hotel
                            cash(street9.player - 1) = cash(street9.player - 1) + street9.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 11 Then ' lands on St. Kevin's Place
                Lander.Text = "Player " + street11.player.ToString() + " owns this"
                If street11.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street11.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street11.houses = 0 Then
                            cash(turn) = cash(turn) - street11.rent
                            cash(street11.player - 1) = cash(street11.player - 1) + street11.rent
                        End If
                        If street11.houses = 1 Then
                            cash(turn) = cash(turn) - street11.house1
                            cash(street11.player - 1) = cash(street11.player - 1) + street11.house1
                        End If
                        If street11.houses = 2 Then
                            cash(turn) = cash(turn) - street11.house2
                            cash(street11.player - 1) = cash(street11.player - 1) + street11.house2
                        End If
                        If street11.houses = 3 Then
                            cash(turn) = cash(turn) - street11.house3
                            cash(street11.player - 1) = cash(street11.player - 1) + street11.house3
                        End If
                        If street11.houses = 4 Then
                            cash(turn) = cash(turn) - street11.house4
                            cash(street11.player - 1) = cash(street11.player - 1) + street11.house4
                        End If
                        If street11.houses = 5 Then
                            cash(turn) = cash(turn) - street11.hotel
                            cash(street11.player - 1) = cash(street11.player - 1) + street11.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 12 Then ' lands on Hello Kitty Company
                Lander.Text = "Player " + street12.player.ToString() + " owns this"
                If street12.player = 0 Then ' if the player owns it then do nothing

                Else
                    If utility(street12.player - 1) = 1 Then ' determines how much rent is payed to the owner if owned
                        cash(turn) = cash(turn) - (4 * (dice1 + dice2))
                        cash(street13.player - 1) = cash(street13.player - 1) + (4 * (dice1 + dice2))
                    End If
                    If utility(street12.player - 1) = 2 Then ' determines how much rent is payed to the owner if owned
                        cash(turn) = cash(turn) - (10 * (dice1 + dice2))
                        cash(street13.player - 1) = cash(street13.player - 1) + (10 * (dice1 + dice2))
                    End If
                End If
            End If
            If space(turn) = 13 Then ' lands on Noob Ave.
                Lander.Text = "Player " + street13.player.ToString() + " owns this"
                If street13.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street13.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street13.houses = 0 Then
                            cash(turn) = cash(turn) - street13.rent
                            cash(street13.player - 1) = cash(street13.player - 1) + street13.rent
                        End If
                        If street13.houses = 1 Then
                            cash(turn) = cash(turn) - street13.house1
                            cash(street13.player - 1) = cash(street13.player - 1) + street13.house1
                        End If
                        If street13.houses = 2 Then
                            cash(turn) = cash(turn) - street13.house2
                            cash(street13.player - 1) = cash(street13.player - 1) + street13.house2
                        End If
                        If street13.houses = 3 Then
                            cash(turn) = cash(turn) - street13.house3
                            cash(street13.player - 1) = cash(street13.player - 1) + street13.house3
                        End If
                        If street13.houses = 4 Then
                            cash(turn) = cash(turn) - street13.house4
                            cash(street13.player - 1) = cash(street13.player - 1) + street13.house4
                        End If
                        If street13.houses = 5 Then
                            cash(turn) = cash(turn) - street13.hotel
                            cash(street13.player - 1) = cash(street13.player - 1) + street13.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 14 Then ' lands on Ping Pong Ave.
                Lander.Text = "Player " + street14.player.ToString() + " owns this"
                If street14.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street14.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street14.houses = 0 Then
                            cash(turn) = cash(turn) - street14.rent
                            cash(street14.player - 1) = cash(street14.player - 1) + street14.rent
                        End If
                        If street14.houses = 1 Then
                            cash(turn) = cash(turn) - street14.house1
                            cash(street14.player - 1) = cash(street14.player - 1) + street14.house1
                        End If
                        If street14.houses = 2 Then
                            cash(turn) = cash(turn) - street14.house2
                            cash(street14.player - 1) = cash(street14.player - 1) + street14.house2
                        End If
                        If street14.houses = 3 Then
                            cash(turn) = cash(turn) - street14.house3
                            cash(street14.player - 1) = cash(street14.player - 1) + street14.house3
                        End If
                        If street14.houses = 4 Then
                            cash(turn) = cash(turn) - street14.house4
                            cash(street14.player - 1) = cash(street14.player - 1) + street14.house4
                        End If
                        If street14.houses = 5 Then
                            cash(turn) = cash(turn) - street14.hotel
                            cash(street14.player - 1) = cash(street14.player - 1) + street14.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 15 Then ' lands on Kevin's Awesome Railroad 2
                Lander.Text = "Player " + street15.player.ToString() + " owns this"
                If street15.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street15.owned = True Then ' determines how much rent is payed to the owner if owned
                        If railway(street15.player - 1) = 1 Then
                            cash(turn) = cash(turn) - 25
                            cash(street15.player - 1) = cash(street15.player - 1) + 25
                        End If
                        If railway(street15.player - 1) = 2 Then
                            cash(turn) = cash(turn) - 50
                            cash(street15.player - 1) = cash(street15.player - 1) + 50
                        End If
                        If railway(street15.player - 1) = 3 Then
                            cash(turn) = cash(turn) - 100
                            cash(street15.player - 1) = cash(street15.player - 1) + 100
                        End If
                        If railway(street15.player - 1) = 4 Then
                            cash(turn) = cash(turn) - 200
                            cash(street15.player - 1) = cash(street15.player - 1) + 200
                        End If
                    End If
                End If
            End If
            If space(turn) = 16 Then ' lands on St. Yang's Place
                Lander.Text = "Player " + street16.player.ToString() + " owns this"
                If street16.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street16.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street16.houses = 0 Then
                            cash(turn) = cash(turn) - street16.rent
                            cash(street16.player - 1) = cash(street16.player - 1) + street16.rent
                        End If
                        If street16.houses = 1 Then
                            cash(turn) = cash(turn) - street16.house1
                            cash(street16.player - 1) = cash(street16.player - 1) + street16.house1
                        End If
                        If street16.houses = 2 Then
                            cash(turn) = cash(turn) - street16.house2
                            cash(street16.player - 1) = cash(street16.player - 1) + street16.house2
                        End If
                        If street16.houses = 3 Then
                            cash(turn) = cash(turn) - street16.house3
                            cash(street16.player - 1) = cash(street16.player - 1) + street16.house3
                        End If
                        If street16.houses = 4 Then
                            cash(turn) = cash(turn) - street16.house4
                            cash(street16.player - 1) = cash(street16.player - 1) + street16.house4
                        End If
                        If street16.houses = 5 Then
                            cash(turn) = cash(turn) - street16.hotel
                            cash(street16.player - 1) = cash(street16.player - 1) + street16.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 18 Then ' lands on Tennis Ave.
                Lander.Text = "Player " + street18.player.ToString() + " owns this"
                If street18.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street18.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street18.houses = 0 Then
                            cash(turn) = cash(turn) - street18.rent
                            cash(street18.player - 1) = cash(street18.player - 1) + street18.rent
                        End If
                        If street18.houses = 1 Then
                            cash(turn) = cash(turn) - street18.house1
                            cash(street18.player - 1) = cash(street18.player - 1) + street18.house1
                        End If
                        If street18.houses = 2 Then
                            cash(turn) = cash(turn) - street18.house2
                            cash(street18.player - 1) = cash(street18.player - 1) + street18.house2
                        End If
                        If street18.houses = 3 Then
                            cash(turn) = cash(turn) - street18.house3
                            cash(street18.player - 1) = cash(street18.player - 1) + street18.house3
                        End If
                        If street18.houses = 4 Then
                            cash(turn) = cash(turn) - street18.house4
                            cash(street18.player - 1) = cash(street18.player - 1) + street18.house4
                        End If
                        If street18.houses = 5 Then
                            cash(turn) = cash(turn) - street18.hotel
                            cash(street18.player - 1) = cash(street18.player - 1) + street18.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 19 Then ' lands on Ottawa Ave.
                Lander.Text = "Player " + street19.player.ToString() + " owns this"
                If street19.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street19.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street19.houses = 0 Then
                            cash(turn) = cash(turn) - street19.rent
                            cash(street19.player - 1) = cash(street19.player - 1) + street19.rent
                        End If
                        If street19.houses = 1 Then
                            cash(turn) = cash(turn) - street19.house1
                            cash(street19.player - 1) = cash(street19.player - 1) + street19.house1
                        End If
                        If street19.houses = 2 Then
                            cash(turn) = cash(turn) - street19.house2
                            cash(street19.player - 1) = cash(street19.player - 1) + street19.house2
                        End If
                        If street19.houses = 3 Then
                            cash(turn) = cash(turn) - street19.house3
                            cash(street19.player - 1) = cash(street19.player - 1) + street19.house3
                        End If
                        If street19.houses = 4 Then
                            cash(turn) = cash(turn) - street19.house4
                            cash(street19.player - 1) = cash(street19.player - 1) + street19.house4
                        End If
                        If street19.houses = 5 Then
                            cash(turn) = cash(turn) - street19.hotel
                            cash(street19.player - 1) = cash(street19.player - 1) + street19.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 21 Then ' lands on McDonald's Ave.
                Lander.Text = "Player " + street21.player.ToString() + " owns this"
                If street21.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street21.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street21.houses = 0 Then
                            cash(turn) = cash(turn) - street21.rent
                            cash(street21.player - 1) = cash(street21.player - 1) + street21.rent
                        End If
                        If street21.houses = 1 Then
                            cash(turn) = cash(turn) - street21.house1
                            cash(street21.player - 1) = cash(street21.player - 1) + street21.house1
                        End If
                        If street21.houses = 2 Then
                            cash(turn) = cash(turn) - street21.house2
                            cash(street21.player - 1) = cash(street21.player - 1) + street21.house2
                        End If
                        If street21.houses = 3 Then
                            cash(turn) = cash(turn) - street21.house3
                            cash(street21.player - 1) = cash(street21.player - 1) + street21.house3
                        End If
                        If street21.houses = 4 Then
                            cash(turn) = cash(turn) - street21.house4
                            cash(street21.player - 1) = cash(street21.player - 1) + street21.house4
                        End If
                        If street21.houses = 5 Then
                            cash(turn) = cash(turn) - street21.hotel
                            cash(street21.player - 1) = cash(street21.player - 1) + street21.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 23 Then ' lands on Indian Ave.
                Lander.Text = "Player " + street23.player.ToString() + " owns this"
                If street23.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street23.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street23.houses = 0 Then
                            cash(turn) = cash(turn) - street23.rent
                            cash(street23.player - 1) = cash(street23.player - 1) + street23.rent
                        End If
                        If street23.houses = 1 Then
                            cash(turn) = cash(turn) - street23.house1
                            cash(street23.player - 1) = cash(street23.player - 1) + street23.house1
                        End If
                        If street23.houses = 2 Then
                            cash(turn) = cash(turn) - street23.house2
                            cash(street23.player - 1) = cash(street23.player - 1) + street23.house2
                        End If
                        If street23.houses = 3 Then
                            cash(turn) = cash(turn) - street23.house3
                            cash(street23.player - 1) = cash(street23.player - 1) + street23.house3
                        End If
                        If street23.houses = 4 Then
                            cash(turn) = cash(turn) - street23.house4
                            cash(street23.player - 1) = cash(street23.player - 1) + street23.house4
                        End If
                        If street23.houses = 5 Then
                            cash(turn) = cash(turn) - street23.hotel
                            cash(street23.player - 1) = cash(street23.player - 1) + street23.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 24 Then ' lands on Chili Ave.
                Lander.Text = "Player " + street24.player.ToString() + " owns this"
                If street24.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street24.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street24.houses = 0 Then
                            cash(turn) = cash(turn) - street24.rent
                            cash(street24.player - 1) = cash(street24.player - 1) + street24.rent
                        End If
                        If street24.houses = 1 Then
                            cash(turn) = cash(turn) - street24.house1
                            cash(street24.player - 1) = cash(street24.player - 1) + street24.house1
                        End If
                        If street24.houses = 2 Then
                            cash(turn) = cash(turn) - street24.house2
                            cash(street24.player - 1) = cash(street24.player - 1) + street24.house2
                        End If
                        If street24.houses = 3 Then
                            cash(turn) = cash(turn) - street24.house3
                            cash(street24.player - 1) = cash(street24.player - 1) + street24.house3
                        End If
                        If street24.houses = 4 Then
                            cash(turn) = cash(turn) - street24.house4
                            cash(street24.player - 1) = cash(street24.player - 1) + street24.house4
                        End If
                        If street24.houses = 5 Then
                            cash(turn) = cash(turn) - street24.hotel
                            cash(street24.player - 1) = cash(street24.player - 1) + street24.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 25 Then ' lands on Kevin's Awesome Railroad 3
                Lander.Text = "Player " + street25.player.ToString() + " owns this"
                If street25.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street25.owned = True Then ' determines how much rent is payed to the owner if owned
                        If railway(street25.player - 1) = 1 Then
                            cash(turn) = cash(turn) - 25
                            cash(street25.player - 1) = cash(street25.player - 1) + 25
                        End If
                        If railway(street25.player - 1) = 2 Then
                            cash(turn) = cash(turn) - 50
                            cash(street25.player - 1) = cash(street25.player - 1) + 50
                        End If
                        If railway(street25.player - 1) = 3 Then
                            cash(turn) = cash(turn) - 100
                            cash(street25.player - 1) = cash(street25.player - 1) + 100
                        End If
                        If railway(street25.player - 1) = 4 Then
                            cash(turn) = cash(turn) - 200
                            cash(street25.player - 1) = cash(street25.player - 1) + 200
                        End If
                    End If
                End If
            End If
            If space(turn) = 26 Then ' lands on Atlantis Ave.
                Lander.Text = "Player " + street26.player.ToString() + " owns this"
                If street26.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street26.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street26.houses = 0 Then
                            cash(turn) = cash(turn) - street26.rent
                            cash(street26.player - 1) = cash(street26.player - 1) + street26.rent
                        End If
                        If street26.houses = 1 Then
                            cash(turn) = cash(turn) - street26.house1
                            cash(street26.player - 1) = cash(street26.player - 1) + street26.house1
                        End If
                        If street26.houses = 2 Then
                            cash(turn) = cash(turn) - street26.house2
                            cash(street26.player - 1) = cash(street26.player - 1) + street26.house2
                        End If
                        If street26.houses = 3 Then
                            cash(turn) = cash(turn) - street26.house3
                            cash(street26.player - 1) = cash(street26.player - 1) + street26.house3
                        End If
                        If street26.houses = 4 Then
                            cash(turn) = cash(turn) - street26.house4
                            cash(street26.player - 1) = cash(street26.player - 1) + street26.house4
                        End If
                        If street26.houses = 5 Then
                            cash(turn) = cash(turn) - street26.hotel
                            cash(street26.player - 1) = cash(street26.player - 1) + street26.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 27 Then ' lands on Chinese Buffet Ave.
                Lander.Text = "Player " + street27.player.ToString() + " owns this"
                If street27.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street27.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street27.houses = 0 Then
                            cash(turn) = cash(turn) - street27.rent
                            cash(street27.player - 1) = cash(street27.player - 1) + street27.rent
                        End If
                        If street27.houses = 1 Then
                            cash(turn) = cash(turn) - street27.house1
                            cash(street27.player - 1) = cash(street27.player - 1) + street27.house1
                        End If
                        If street27.houses = 2 Then
                            cash(turn) = cash(turn) - street27.house2
                            cash(street27.player - 1) = cash(street27.player - 1) + street27.house2
                        End If
                        If street27.houses = 3 Then
                            cash(turn) = cash(turn) - street27.house3
                            cash(street27.player - 1) = cash(street27.player - 1) + street27.house3
                        End If
                        If street27.houses = 4 Then
                            cash(turn) = cash(turn) - street27.house4
                            cash(street27.player - 1) = cash(street27.player - 1) + street27.house4
                        End If
                        If street27.houses = 5 Then
                            cash(turn) = cash(turn) - street27.hotel
                            cash(street27.player - 1) = cash(street27.player - 1) + street27.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 28 Then ' lands on Badminton Courts
                Lander.Text = "Player " + street28.player.ToString() + " owns this"
                If street28.player = 0 Then ' if the player owns it then do nothing

                Else
                    If utility(street28.player - 1) = 1 Then ' determines how much rent is payed to the owner if owned
                        cash(turn) = cash(turn) - (4 * (dice1 + dice2))
                        cash(street28.player - 1) = cash(street28.player - 1) + (4 * (dice1 + dice2))
                    End If
                    If utility(street28.player - 1) = 2 Then ' determines how much rent is payed to the owner if owned
                        cash(turn) = cash(turn) - (10 * (dice1 + dice2))
                        cash(street28.player - 1) = cash(street28.player - 1) + (10 * (dice1 + dice2))
                    End If
                End If
            End If
            If space(turn) = 29 Then ' lands on Kevin's Garden
                Lander.Text = "Player " + street29.player.ToString() + " owns this"
                If street29.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street29.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street29.houses = 0 Then
                            cash(turn) = cash(turn) - street29.rent
                            cash(street29.player - 1) = cash(street29.player - 1) + street29.rent
                        End If
                        If street29.houses = 1 Then
                            cash(turn) = cash(turn) - street29.house1
                            cash(street29.player - 1) = cash(street29.player - 1) + street29.house1
                        End If
                        If street29.houses = 2 Then
                            cash(turn) = cash(turn) - street29.house2
                            cash(street29.player - 1) = cash(street29.player - 1) + street29.house2
                        End If
                        If street29.houses = 3 Then
                            cash(turn) = cash(turn) - street29.house3
                            cash(street29.player - 1) = cash(street29.player - 1) + street29.house3
                        End If
                        If street29.houses = 4 Then
                            cash(turn) = cash(turn) - street29.house4
                            cash(street29.player - 1) = cash(street29.player - 1) + street29.house4
                        End If
                        If street29.houses = 5 Then
                            cash(turn) = cash(turn) - street29.hotel
                            cash(street29.player - 1) = cash(street29.player - 1) + street29.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 31 Then ' lands on Troll Ave.
                Lander.Text = "Player " + street31.player.ToString() + " owns this"
                If street31.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street31.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street31.houses = 0 Then
                            cash(turn) = cash(turn) - street31.rent
                            cash(street31.player - 1) = cash(street31.player - 1) + street31.rent
                        End If
                        If street31.houses = 1 Then
                            cash(turn) = cash(turn) - street31.house1
                            cash(street31.player - 1) = cash(street31.player - 1) + street31.house1
                        End If
                        If street31.houses = 2 Then
                            cash(turn) = cash(turn) - street31.house2
                            cash(street31.player - 1) = cash(street31.player - 1) + street31.house2
                        End If
                        If street31.houses = 3 Then
                            cash(turn) = cash(turn) - street31.house3
                            cash(street31.player - 1) = cash(street31.player - 1) + street31.house3
                        End If
                        If street31.houses = 4 Then
                            cash(turn) = cash(turn) - street31.house4
                            cash(street31.player - 1) = cash(street31.player - 1) + street31.house4
                        End If
                        If street31.houses = 5 Then
                            cash(turn) = cash(turn) - street31.hotel
                            cash(street31.player - 1) = cash(street31.player - 1) + street31.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 32 Then ' lands on Mall Ave.
                Lander.Text = "Player " + street32.player.ToString() + " owns this"
                If street32.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street32.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street32.houses = 0 Then
                            cash(turn) = cash(turn) - street32.rent
                            cash(street32.player - 1) = cash(street32.player - 1) + street32.rent
                        End If
                        If street32.houses = 1 Then
                            cash(turn) = cash(turn) - street32.house1
                            cash(street32.player - 1) = cash(street32.player - 1) + street32.house1
                        End If
                        If street32.houses = 2 Then
                            cash(turn) = cash(turn) - street32.house2
                            cash(street32.player - 1) = cash(street32.player - 1) + street32.house2
                        End If
                        If street32.houses = 3 Then
                            cash(turn) = cash(turn) - street32.house3
                            cash(street32.player - 1) = cash(street32.player - 1) + street32.house3
                        End If
                        If street32.houses = 4 Then
                            cash(turn) = cash(turn) - street32.house4
                            cash(street32.player - 1) = cash(street32.player - 1) + street32.house4
                        End If
                        If street32.houses = 5 Then
                            cash(turn) = cash(turn) - street32.hotel
                            cash(street32.player - 1) = cash(street32.player - 1) + street32.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 34 Then ' lands on Christmas Ave.
                Lander.Text = "Player " + street34.player.ToString() + " owns this"
                If street34.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street34.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street34.houses = 0 Then
                            cash(turn) = cash(turn) - street34.rent
                            cash(street34.player - 1) = cash(street34.player - 1) + street34.rent
                        End If
                        If street34.houses = 1 Then
                            cash(turn) = cash(turn) - street34.house1
                            cash(street34.player - 1) = cash(street34.player - 1) + street34.house1
                        End If
                        If street34.houses = 2 Then
                            cash(turn) = cash(turn) - street34.house2
                            cash(street34.player - 1) = cash(street34.player - 1) + street34.house2
                        End If
                        If street34.houses = 3 Then
                            cash(turn) = cash(turn) - street34.house3
                            cash(street34.player - 1) = cash(street34.player - 1) + street34.house3
                        End If
                        If street34.houses = 4 Then
                            cash(turn) = cash(turn) - street34.house4
                            cash(street34.player - 1) = cash(street34.player - 1) + street34.house4
                        End If
                        If street34.houses = 5 Then
                            cash(turn) = cash(turn) - street34.hotel
                            cash(street34.player - 1) = cash(street34.player - 1) + street34.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 35 Then ' lands on Kevin's Awesome Railroad 4
                Lander.Text = "Player " + street35.player.ToString() + " owns this"
                If street35.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street35.owned = True Then ' determines how much rent is payed to the owner if owned
                        If railway(street35.player - 1) = 1 Then
                            cash(turn) = cash(turn) - 35
                            cash(street35.player - 1) = cash(street35.player - 1) + 25
                        End If
                        If railway(street35.player - 1) = 2 Then
                            cash(turn) = cash(turn) - 50
                            cash(street35.player - 1) = cash(street35.player - 1) + 50
                        End If
                        If railway(street35.player - 1) = 3 Then
                            cash(turn) = cash(turn) - 100
                            cash(street35.player - 1) = cash(street35.player - 1) + 100
                        End If
                        If railway(street35.player - 1) = 4 Then
                            cash(turn) = cash(turn) - 200
                            cash(street35.player - 1) = cash(street35.player - 1) + 200
                        End If
                    End If
                End If
            End If
            If space(turn) = 37 Then ' lands on Colonel By Secondary School
                Lander.Text = "Player " + street37.player.ToString() + " owns this"
                If street37.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street37.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street37.houses = 0 Then
                            cash(turn) = cash(turn) - street37.rent
                            cash(street37.player - 1) = cash(street37.player - 1) + street37.rent
                        End If
                        If street37.houses = 1 Then
                            cash(turn) = cash(turn) - street37.house1
                            cash(street37.player - 1) = cash(street37.player - 1) + street37.house1
                        End If
                        If street37.houses = 2 Then
                            cash(turn) = cash(turn) - street37.house2
                            cash(street37.player - 1) = cash(street37.player - 1) + street37.house2
                        End If
                        If street37.houses = 3 Then
                            cash(turn) = cash(turn) - street37.house3
                            cash(street37.player - 1) = cash(street37.player - 1) + street37.house3
                        End If
                        If street37.houses = 4 Then
                            cash(turn) = cash(turn) - street37.house4
                            cash(street37.player - 1) = cash(street37.player - 1) + street37.house4
                        End If
                        If street37.houses = 5 Then
                            cash(turn) = cash(turn) - street37.hotel
                            cash(street37.player - 1) = cash(street37.player - 1) + street37.hotel
                        End If
                    End If
                End If
            End If
            If space(turn) = 39 Then ' lands on Chinatown
                Lander.Text = "Player " + street39.player.ToString() + " owns this"
                If street39.player = turn + 1 Then ' if the player owns it then do nothing

                Else
                    If street39.owned = True Then ' determines how much rent is payed to the owner if owned
                        If street39.houses = 0 Then
                            cash(turn) = cash(turn) - street39.rent
                            cash(street39.player - 1) = cash(street39.player - 1) + street39.rent
                        End If
                        If street39.houses = 1 Then
                            cash(turn) = cash(turn) - street39.house1
                            cash(street39.player - 1) = cash(street39.player - 1) + street39.house1
                        End If
                        If street39.houses = 2 Then
                            cash(turn) = cash(turn) - street39.house2
                            cash(street39.player - 1) = cash(street39.player - 1) + street39.house2
                        End If
                        If street39.houses = 3 Then
                            cash(turn) = cash(turn) - street39.house3
                            cash(street39.player - 1) = cash(street39.player - 1) + street39.house3
                        End If
                        If street39.houses = 4 Then
                            cash(turn) = cash(turn) - street39.house4
                            cash(street39.player - 1) = cash(street39.player - 1) + street39.house4
                        End If
                        If street39.houses = 5 Then
                            cash(turn) = cash(turn) - street39.hotel
                            cash(street39.player - 1) = cash(street39.player - 1) + street39.hotel
                        End If
                    End If
                End If
            End If
            Distance.Text = space(turn) ' displays the current position of the player
            If jail(turn) = True Then
                Distance.Text = ("JAILED!") ' displays if the current player is jailed or not
            End If
            Renter.Text = ("Rent Paid : " + (oldcash(turn) - cash(turn)).ToString()) ' determines the money lost this round
            money.Text = cash(turn)
        End If
    End Sub
    Private Sub Buyer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buyer.Click
        If space(turn) = 0 Then ' lands on unbuyable space Go
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 2 Then ' lands on unbuyable space Kevin's Drawer
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 4 Then ' lands on unbuyable space show me the money
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 7 Then ' lands on unbuyable space You Got Lucky
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 10 Then ' lands on unbuyable space Vising Kevin's House
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 17 Then ' lands on unbuyable space Kevin's Drawer
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 20 Then ' lands on unbuyable space Toilet
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 22 Then ' lands on unbuyable space You Got Lucky
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 30 Then ' lands on unbuyable space Go To Kevin's Room
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 33 Then ' lands on unbuyable space Kevin's Drawer
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 36 Then ' lands on unbuyable space You Got Lucky
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 38 Then ' lands on unbuyable space Pay Up Noobs
            MsgBox("You cannot buy this property.")
        End If
        If space(turn) = 1 Then ' trying to buy Badminton Ave. 
            If street1.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street1.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street1.cost
                    money.Text = cash(turn)
                    street1.owned = True
                    street1.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street1.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 3 Then ' trying to buy Computer Ave.
            If street3.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street3.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street3.cost
                    money.Text = cash(turn)
                    street3.owned = True
                    street3.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street3.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 5 Then ' trying to buy Kevin's Awesome Railroad 1
            If street5.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street5.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street5.cost
                    money.Text = cash(turn)
                    street5.owned = True
                    street5.player = (turn + 1)
                    railway(turn) = railway(turn) + 1
                End If
            Else
                MsgBox("This property is already bought by Player " + (street5.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 6 Then ' trying to buy Asia Ave.
            If street6.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street6.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street6.cost
                    money.Text = cash(turn)
                    street6.owned = True
                    street6.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street6.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 8 Then ' trying to buy China Ave.
            If street8.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street8.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street8.cost
                    money.Text = cash(turn)
                    street8.owned = True
                    street8.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street8.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 9 Then ' trying to buy Canada Ave.
            If street9.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street9.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street9.cost
                    money.Text = cash(turn)
                    street9.owned = True
                    street9.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street9.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 11 Then ' trying to buy St. Kevin's Place
            If street11.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street11.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street11.cost
                    money.Text = cash(turn)
                    street11.owned = True
                    street11.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street11.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 12 Then ' trying to buy Hello Kitty Company
            If street12.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street12.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street12.cost
                    money.Text = cash(turn)
                    street12.owned = True
                    street12.player = (turn + 1)
                    utility(turn) = utility(turn) + 1
                End If
            Else
                MsgBox("This property is already bought by Player " + (street12.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 13 Then ' trying to buy Noob Ave.
            If street13.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street13.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street13.cost
                    money.Text = cash(turn)
                    street13.owned = True
                    street13.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street13.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 14 Then ' trying to buy Ping Pong Ave.
            If street14.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street14.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street14.cost
                    money.Text = cash(turn)
                    street14.owned = True
                    street14.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street14.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 15 Then ' trying to buy Kevin's Awesome Railroad 2
            If street15.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street15.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street15.cost
                    money.Text = cash(turn)
                    street15.owned = True
                    street15.player = (turn + 1)
                    railway(turn) = railway(turn) + 1
                End If
            Else
                MsgBox("This property is already bought by Player " + (street15.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 16 Then ' trying to buy St. Yang's Place
            If street16.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street16.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street16.cost
                    money.Text = cash(turn)
                    street16.owned = True
                    street16.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street16.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 18 Then ' trying to buy Tennis Ave.
            If street18.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street18.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street18.cost
                    money.Text = cash(turn)
                    street18.owned = True
                    street18.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street18.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 19 Then ' trying to buy Ottawa Ave.
            If street19.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street19.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street19.cost
                    money.Text = cash(turn)
                    street19.owned = True
                    street19.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street19.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 21 Then ' trying to buy mcDonald's Ave.
            If street21.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street21.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street21.cost
                    money.Text = cash(turn)
                    street21.owned = True
                    street21.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street21.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 23 Then ' trying to buy Indian Ave.
            If street23.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street23.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street23.cost
                    money.Text = cash(turn)
                    street23.owned = True
                    street23.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street23.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 24 Then ' trying to buy Chili Ave.
            If street24.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street24.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street24.cost
                    money.Text = cash(turn)
                    street24.owned = True
                    street24.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street24.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 25 Then ' trying to buy Kevin's Awesome Railroad 3
            If street25.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street25.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street25.cost
                    money.Text = cash(turn)
                    street25.owned = True
                    street25.player = (turn + 1)
                    railway(turn) = railway(turn) + 1
                End If
            Else
                MsgBox("This property is already bought by Player " + (street25.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 26 Then ' trying to buy Atlantis Ave.
            If street26.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street26.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street26.cost
                    money.Text = cash(turn)
                    street26.owned = True
                    street26.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street26.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 27 Then ' trying to buy Chinese Buffet Ave.
            If street27.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street27.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street27.cost
                    money.Text = cash(turn)
                    street27.owned = True
                    street27.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street27.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 28 Then ' trying to buy Badminton Courts
            If street28.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street28.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street28.cost
                    money.Text = cash(turn)
                    street28.owned = True
                    street28.player = (turn + 1)
                    utility(turn) = utility(turn) + 1
                End If
            Else
                MsgBox("This property is already bought by Player " + (street28.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 29 Then ' trying to buy Kevin's Garden
            If street29.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street29.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street29.cost
                    money.Text = cash(turn)
                    street29.owned = True
                    street29.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street29.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 31 Then ' trying to buy Troll
            If street31.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street31.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street31.cost
                    money.Text = cash(turn)
                    street31.owned = True
                    street31.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street31.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 32 Then ' trying to buy Mall Ave. 
            If street32.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street32.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street32.cost
                    money.Text = cash(turn)
                    street32.owned = True
                    street32.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street32.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 34 Then ' trying to buy Christmas Ave. 
            If street34.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street34.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street3.cost
                    money.Text = cash(turn)
                    street34.owned = True
                    street34.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street34.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 35 Then ' trying to buy Kevin's Awesome Railroad 4
            If street35.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street35.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street3.cost
                    money.Text = cash(turn)
                    street35.owned = True
                    street35.player = (turn + 1)
                    railway(turn) = railway(turn) + 1
                End If
            Else
                MsgBox("This property is already bought by Player " + (street35.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 37 Then ' trying to buy Colonel By Secondary School
            If street37.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street37.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street37.cost
                    money.Text = cash(turn)
                    street37.owned = True
                    street37.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street37.player.ToString()) + ".") ' property is already owned
            End If
        End If
        If space(turn) = 39 Then ' trying to buy Chinatown
            If street39.owned = False Then ' if not owned, asks if they really want to buy
                choice = MsgBox("Do you really want to buy " + street39.name.ToString() + "?", vbYesNo)
                If choice = vbYes Then ' if wish to buy, then subtract cost from cash and add property to player
                    cash(turn) = cash(turn) - street39.cost
                    money.Text = cash(turn)
                    street39.owned = True
                    street39.player = (turn + 1)
                End If
            Else
                MsgBox("This property is already bought by Player " + (street39.player.ToString()) + ".") ' property is already owned
            End If
        End If
        Renter.Text = ("Rent Paid : " + (oldcash(turn) - cash(turn)).ToString()) ' determines money lost
        money.Text = cash(turn)
    End Sub


    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub
    Private Sub Ender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ender.Click
        choice = MsgBox("Continue? If you have less than 0 cash you will die", vbYesNo)
        If choice = vbYes Then
            Text1.Visible = False
            Text2.Visible = False
            Text3.Visible = False
            Text4.Visible = False
            Box4.Visible = False
            Box5.Visible = False ' cancels out of all the mortgage/build houses group boxes
            If cash(turn) < 0 Then ' determines if the player is dead
                player(turn) = False
                If street1.player = turn + 1 Then
                    street1.player = 0
                    street1.owned = False
                End If
                If street3.player = turn + 1 Then
                    street3.player = 0
                    street3.owned = False
                End If
                If street6.player = turn + 1 Then
                    street6.player = 0
                    street6.owned = False
                End If
                If street11.player = turn + 1 Then
                    street11.player = 0
                    street11.owned = False
                End If
                If street13.player = turn + 1 Then
                    street3.player = 0
                    street3.owned = False
                End If
                If street14.player = turn + 1 Then
                    street14.player = 0
                    street14.owned = False
                End If
                If street16.player = turn + 1 Then
                    street16.player = 0
                    street16.owned = False
                End If
                If street18.player = turn + 1 Then
                    street18.player = 0
                    street18.owned = False
                End If
                If street19.player = turn + 1 Then
                    street19.player = 0
                    street19.owned = False
                End If
                If street21.player = turn + 1 Then
                    street21.player = 0
                    street21.owned = False
                End If
                If street23.player = turn + 1 Then
                    street23.player = 0
                    street23.owned = False
                End If
                If street24.player = turn + 1 Then
                    street24.player = 0
                    street24.owned = False
                End If
                If street26.player = turn + 1 Then
                    street26.player = 0
                    street26.owned = False
                End If
                If street27.player = turn + 1 Then
                    street27.player = 0
                    street27.owned = False
                End If
                If street29.player = turn + 1 Then
                    street29.player = 0
                    street29.owned = False
                End If
                If street31.player = turn + 1 Then
                    street31.player = 0
                    street31.owned = False
                End If
                If street32.player = turn + 1 Then
                    street32.player = 0
                    street32.owned = False
                End If
                If street34.player = turn + 1 Then
                    street34.player = 0
                    street34.owned = False
                End If
                If street37.player = turn + 1 Then
                    street37.player = 0
                    street37.owned = False
                End If
                If street39.player = turn + 1 Then
                    street39.player = 0
                    street39.owned = False
                End If
                If street8.player = turn + 1 Then
                    street8.player = 0
                    street8.owned = False
                End If
                If street9.player = turn + 1 Then
                    street9.player = 0
                    street9.owned = False
                    ' gives away all of the properties of the player if they're dead
                End If
            Else
                player(turn) = True ' the player is still alive
            End If
            If player(turn) = True Then ' if the player is still alive
                turn = turn + 1 ' advance to the next player
                If turn > (Val(PlayerNumber.Text) - 1) Then
                    turn = 0 ' if it is player 4's turn, then become player 1's turna again
                End If
            End If
            Box3.Visible = False
            Roller.Visible = True ' roller for the next player becomes visible
            If turn = 0 Then
                Text1.Visible = True
            End If
            If turn = 1 Then
                Text2.Visible = True
            End If
            If turn = 2 Then
                Text3.Visible = True
            End If
            If turn = 3 Then
                Text4.Visible = True
            End If
            ' player text visual
            money.Text = cash(turn) ' sets their cash for the turn
        Else

        End If
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENDGAME.Click
        End ' if you wish to exit
    End Sub

    Private Sub Builder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Builder.Click
        ' builds houses
        BH1.Visible = False
        BH2.Visible = False
        BH3.Visible = False
        BH4.Visible = False
        BH5.Visible = False
        BH6.Visible = False
        BH7.Visible = False
        BH8.Visible = False
        ' closes the current visible build houses groups
        If Box4.Visible = True Then
            Box4.Visible = False
        Else
            Box4.Visible = True
        End If
        ' allows the button to open/close the groupbox
        If street1.player = turn + 1 Then
            If street3.player = turn + 1 Then
                BH1.Visible = True
            End If
        End If
        If street6.player = turn + 1 Then
            If street8.player = turn + 1 Then
                If street9.player = turn + 1 Then
                    BH2.Visible = True
                End If
            End If
        End If
        If street11.player = turn + 1 Then
            If street13.player = turn + 1 Then
                If street14.player = turn + 1 Then
                    BH3.Visible = True
                End If
            End If
        End If
        If street16.player = turn + 1 Then
            If street18.player = turn + 1 Then
                If street19.player = turn + 1 Then
                    BH4.Visible = True
                End If
            End If
        End If
        If street21.player = turn + 1 Then
            If street23.player = turn + 1 Then
                If street24.player = turn + 1 Then
                    BH5.Visible = True
                End If
            End If
        End If
        If street26.player = turn + 1 Then
            If street27.player = turn + 1 Then
                If street29.player = turn + 1 Then
                    BH6.Visible = True
                End If
            End If
        End If
        If street31.player = turn + 1 Then
            If street32.player = turn + 1 Then
                If street34.player = turn + 1 Then
                    BH7.Visible = True
                End If
            End If
        End If
        If street1.player = turn + 1 Then
            If street3.player = turn + 1 Then
                BH8.Visible = True
            End If
        End If
        ' determines if the player has a monopoly to allow him to build houses
    End Sub

    Private Sub FolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHEATGAME.Click
        ' cheater
        cheatcode = InputBox("Enter cheat code", "Enter cheat code")
        If cheatcode = "c4iim3m4g3" Then
            cash(turn) = cash(turn) + 9999
            money.Text = cash(turn)
            MsgBox("Cheat accepted")
        End If
        ' gives 9999 cash
        If cheatcode = "werqwdasf" Then
            street1.player = turn + 1
            street3.player = turn + 1
            street5.player = turn + 1
            street6.player = turn + 1
            street8.player = turn + 1
            street9.player = turn + 1
            street11.player = turn + 1
            street12.player = turn + 1
            street13.player = turn + 1
            street14.player = turn + 1
            street15.player = turn + 1
            street16.player = turn + 1
            street18.player = turn + 1
            street19.player = turn + 1
            street21.player = turn + 1
            street23.player = turn + 1
            street24.player = turn + 1
            street25.player = turn + 1
            street26.player = turn + 1
            street27.player = turn + 1
            street28.player = turn + 1
            street29.player = turn + 1
            street31.player = turn + 1
            street32.player = turn + 1
            street34.player = turn + 1
            street35.player = turn + 1
            street37.player = turn + 1
            street39.player = turn + 1
            street1.owned = True
            street3.owned = True
            street5.owned = True
            street6.owned = True
            street8.owned = True
            street9.owned = True
            street11.owned = True
            street12.owned = True
            street13.owned = True
            street14.owned = True
            street15.owned = True
            street16.owned = True
            street18.owned = True
            street19.owned = True
            street21.owned = True
            street23.owned = True
            street24.owned = True
            street25.owned = True
            street26.owned = True
            street27.owned = True
            street28.owned = True
            street29.owned = True
            street31.owned = True
            street32.owned = True
            street34.owned = True
            street35.owned = True
            street37.owned = True
            street39.owned = True
            MsgBox("Cheat accepted")
        End If
        ' gives all properties
        If cheatcode = "kevinyang" Then
            street1.houses = 5
            street3.houses = 5
            street5.houses = 5
            street6.houses = 5
            street8.houses = 5
            street9.houses = 5
            street11.houses = 5
            street12.houses = 5
            street13.houses = 5
            street14.houses = 5
            street15.houses = 5
            street16.houses = 5
            street18.houses = 5
            street19.houses = 5
            street21.houses = 5
            street23.houses = 5
            street24.houses = 5
            street25.houses = 5
            street26.houses = 5
            street27.houses = 5
            street28.houses = 5
            street29.houses = 5
            street31.houses = 5
            street32.houses = 5
            street34.houses = 5
            street35.houses = 5
            street37.houses = 5
            street39.houses = 5
            MsgBox("Cheat accepted")
        End If
        ' gives full hotels
    End Sub

    Private Sub Morter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Morter.Click
        If Box5.Visible = True Then
            Box5.Visible = False
        Else
            Box5.Visible = True
        End If ' allows the mortgage button to open/close the mortgage groupbox

        If street1.player = turn + 1 Then
            M11.Visible = True
        Else
            M11.Visible = False
        End If
        If street3.player = turn + 1 Then
            M12.Visible = True
        Else
            M12.Visible = False
        End If
        If street6.player = turn + 1 Then
            M21.Visible = True
        Else
            M21.Visible = False
        End If
        If street8.player = turn + 1 Then
            M22.Visible = True
        Else
            M22.Visible = False
        End If
        If street9.player = turn + 1 Then
            M23.Visible = True
        Else
            M23.Visible = False
        End If
        If street11.player = turn + 1 Then
            M31.Visible = True
        Else
            M31.Visible = False
        End If
        If street13.player = turn + 1 Then
            M32.Visible = True
        Else
            M32.Visible = False
        End If
        If street14.player = turn + 1 Then
            M33.Visible = True
        Else
            M33.Visible = False
        End If
        If street16.player = turn + 1 Then
            M41.Visible = True
        Else
            M41.Visible = False
        End If
        If street18.player = turn + 1 Then
            M42.Visible = True
        Else
            M42.Visible = False
        End If
        If street19.player = turn + 1 Then
            M43.Visible = True
        Else
            M43.Visible = False
        End If
        If street21.player = turn + 1 Then
            M51.Visible = True
        Else
            M51.Visible = False
        End If
        If street23.player = turn + 1 Then
            M52.Visible = True
        Else
            M52.Visible = False
        End If
        If street24.player = turn + 1 Then
            M53.Visible = True
        Else
            M53.Visible = False
        End If
        If street26.player = turn + 1 Then
            M61.Visible = True
        Else
            M61.Visible = False
        End If
        If street27.player = turn + 1 Then
            M62.Visible = True
        Else
            M62.Visible = False
        End If
        If street29.player = turn + 1 Then
            M63.Visible = True
        Else
            M63.Visible = False
        End If
        If street31.player = turn + 1 Then
            M71.Visible = True
        Else
            M71.Visible = False
        End If
        If street32.player = turn + 1 Then
            M72.Visible = True
        Else
            M72.Visible = False
        End If
        If street34.player = turn + 1 Then
            M73.Visible = True
        Else
            M73.Visible = False
        End If
        If street37.player = turn + 1 Then
            M81.Visible = True
        Else
            M81.Visible = False
        End If
        If street39.player = turn + 1 Then
            M82.Visible = True
        Else
            M82.Visible = False
        End If
        ' these methods determines if the player owns the property or not
        ' if the player owns the property, the corresponding mortgage button for these buttons are visible
    End Sub

    Private Sub P11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P11.Click
        If street1.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street1.housecost
                street1.houses = street1.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P12.Click
        If street3.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street3.housecost
                street3.houses = street3.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P31.Click
        If street11.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street11.housecost
                street11.houses = street11.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P32.Click
        If street13.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street13.housecost
                street13.houses = street13.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P33.Click
        If street14.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street14.housecost
                street14.houses = street14.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P51.Click
        If street21.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street21.housecost
                street21.houses = street21.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P52.Click
        If street23.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street23.housecost
                street23.houses = street23.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P53.Click
        If street24.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street24.housecost
                street24.houses = street24.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P71.Click
        If street31.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street31.housecost
                street31.houses = street31.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P72.Click
        If street32.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street32.housecost
                street32.houses = street32.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P73.Click
        If street34.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street34.housecost
                street34.houses = street34.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P21.Click
        If street6.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street6.housecost
                street6.houses = street6.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P22.Click
        If street8.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street8.housecost
                street8.houses = street8.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P23.Click
        If street9.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street9.housecost
                street9.houses = street9.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P41.Click
        If street16.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street16.housecost
                street16.houses = street16.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P42.Click
        If street18.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street18.housecost
                street18.houses = street18.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P43.Click
        If street19.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street19.housecost
                street19.houses = street19.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P61.Click
        If street26.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street26.housecost
                street26.houses = street26.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P62.Click
        If street27.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street27.housecost
                street27.houses = street27.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P63.Click
        If street29.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street29.housecost
                street29.houses = street29.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P81.Click
        If street37.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street37.housecost
                street37.houses = street37.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub P82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P82.Click
        If street39.houses = 5 Then ' makes it so that you can't build more than a hotel on each property
            MsgBox("Sorry, you cannot build any more houses; you have a hotel already.")
        Else
            choice = MsgBox("Do you want to build a house?", vbYesNo)
            If choice = vbYes Then ' player chooses to build a house
                cash(turn) = cash(turn) - street39.housecost
                street39.houses = street39.houses + 1 ' subtracts the cost from cash and adds a house
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M11.Click
        If street1.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street1.owned = False
                street1.player = 0
                cash(turn) = cash(turn) + street1.mort
                M11.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street1.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street1.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street1.houses = street1.houses - 1
                cash(turn) = cash(turn) + street1.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M12.Click
        If street3.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street3.owned = False
                street3.player = 0
                cash(turn) = cash(turn) + street3.mort
                M12.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street3.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street3.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street3.houses = street3.houses - 1
                cash(turn) = cash(turn) + street3.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M31.Click
        If street11.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street11.owned = False
                street11.player = 0
                cash(turn) = cash(turn) + street11.mort
                M31.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street11.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street11.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street11.houses = street11.houses - 1
                cash(turn) = cash(turn) + street11.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M32.Click
        If street13.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street13.owned = False
                street13.player = 0
                cash(turn) = cash(turn) + street13.mort
                M32.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street13.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street13.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street13.houses = street13.houses - 1
                cash(turn) = cash(turn) + street13.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M33.Click
        If street14.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street14.owned = False
                street14.player = 0
                cash(turn) = cash(turn) + street14.mort
                M33.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street14.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street14.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street14.houses = street14.houses - 1
                cash(turn) = cash(turn) + street14.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M21.Click
        If street6.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street6.owned = False
                street6.player = 0
                cash(turn) = cash(turn) + street6.mort
                M21.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street6.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street6.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street6.houses = street6.houses - 1
                cash(turn) = cash(turn) + street6.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M22.Click
        If street8.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street8.owned = False
                street8.player = 0
                cash(turn) = cash(turn) + street8.mort
                M22.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street8.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street8.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street8.houses = street8.houses - 1
                cash(turn) = cash(turn) + street8.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M23.Click
        If street9.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street9.owned = False
                street9.player = 0
                cash(turn) = cash(turn) + street9.mort
                M23.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street9.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street9.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street9.houses = street9.houses - 1
                cash(turn) = cash(turn) + street9.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M41.Click
        If street14.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street14.owned = False
                street14.player = 0
                cash(turn) = cash(turn) + street14.mort
                M41.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street14.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street14.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street14.houses = street14.houses - 1
                cash(turn) = cash(turn) + street14.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M42.Click
        If street18.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street18.owned = False
                street18.player = 0
                cash(turn) = cash(turn) + street18.mort
                M42.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street18.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street18.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street18.houses = street18.houses - 1
                cash(turn) = cash(turn) + street18.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M43.Click
        If street19.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street19.owned = False
                street19.player = 0
                cash(turn) = cash(turn) + street19.mort
                M43.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street19.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street19.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street19.houses = street19.houses - 1
                cash(turn) = cash(turn) + street19.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M51.Click
        If street21.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street21.owned = False
                street21.player = 0
                cash(turn) = cash(turn) + street21.mort
                M51.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street21.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street21.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street21.houses = street21.houses - 1
                cash(turn) = cash(turn) + street21.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M52.Click
        If street23.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street23.owned = False
                street23.player = 0
                cash(turn) = cash(turn) + street23.mort
                M52.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street23.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street23.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street23.houses = street23.houses - 1
                cash(turn) = cash(turn) + street23.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M53.Click
        If street24.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street24.owned = False
                street24.player = 0
                cash(turn) = cash(turn) + street24.mort
                M53.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street24.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street24.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street24.houses = street24.houses - 1
                cash(turn) = cash(turn) + street24.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M61.Click
        If street26.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street26.owned = False
                street26.player = 0
                cash(turn) = cash(turn) + street26.mort
                M61.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street26.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street26.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street26.houses = street26.houses - 1
                cash(turn) = cash(turn) + street26.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M62.Click
        If street27.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street27.owned = False
                street27.player = 0
                cash(turn) = cash(turn) + street27.mort
                M62.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street27.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street27.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street27.houses = street27.houses - 1
                cash(turn) = cash(turn) + street27.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M63.Click
        If street29.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street29.owned = False
                street29.player = 0
                cash(turn) = cash(turn) + street29.mort
                M63.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street29.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street29.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street29.houses = street29.houses - 1
                cash(turn) = cash(turn) + street29.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M71.Click
        If street31.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street31.owned = False
                street31.player = 0
                cash(turn) = cash(turn) + street31.mort
                M71.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street31.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street31.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street31.houses = street31.houses - 1
                cash(turn) = cash(turn) + street31.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M72.Click
        If street32.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street32.owned = False
                street32.player = 0
                cash(turn) = cash(turn) + street32.mort
                M72.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street32.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street32.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street32.houses = street32.houses - 1
                cash(turn) = cash(turn) + street32.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M73.Click
        If street34.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street34.owned = False
                street34.player = 0
                cash(turn) = cash(turn) + street34.mort
                M73.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street34.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street34.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street34.houses = street34.houses - 1
                cash(turn) = cash(turn) + street34.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M81.Click
        If street37.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street37.owned = False
                street37.player = 0
                cash(turn) = cash(turn) + street37.mort
                M81.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street37.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street37.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street37.houses = street37.houses - 1
                cash(turn) = cash(turn) + street37.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub M82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M82.Click
        If street39.houses = 0 Then ' if there are no houses, then the player wishes to sell the property (mortgage)
            choice = MsgBox("Do you want to sell the property?", vbYesNo)
            If choice = vbYes Then
                street39.owned = False
                street39.player = 0
                cash(turn) = cash(turn) + street39.mort
                M82.Visible = False ' adds cost to cash and gives away ownership of the property
            End If
        End If
        If street39.houses > 0 Then ' if there are houses on the property, then sell one house
            choice = MsgBox("Do you want to sell houses? You have " + street39.houses.ToString() + " left", vbYesNo)
            If choice = vbYes Then
                street39.houses = street39.houses - 1
                cash(turn) = cash(turn) + street39.housemort ' sells one house and adds cost to cash
            End If
        End If
        money.Text = cash(turn)
    End Sub

    Private Sub Restarter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restarter.Click
        choice = MsgBox("Do you wish to restart game? This will reset everything.", vbYesNo) ' wishes to restart the game
        If choice = vbYes Then
            choice = MsgBox("Do you really wish to restart game? This will reset all progress.", vbYesNo) ' really wishes to restart the game
            If choice = vbYes Then ' if game restart is really wished, then reset the whole game, and make options in the beginning visible again
                Box1.Visible = True
                Box2.Visible = True
                Click.Visible = True
                Board.Visible = False
                Text1.Visible = False
                money.Visible = False
                money.Text = 0
                cashtext.Visible = False
                Distancer.Visible = False
                Spacer.Visible = False
                Roller.Visible = False
                Box3.Visible = False
                Dice11.Visible = False
                Dice12.Visible = False
                Dice21.Visible = False
                Dice22.Visible = False
                Dice31.Visible = False
                Dice32.Visible = False
                Dice41.Visible = False
                Dice42.Visible = False
                Dice51.Visible = False
                Dice52.Visible = False
                Dice61.Visible = False
                Dice62.Visible = False
                Distance.Visible = False
                street1.owned = False
                street3.owned = False
                street5.owned = False
                street6.owned = False
                street8.owned = False
                street9.owned = False
                street11.owned = False
                street12.owned = False
                street13.owned = False
                street14.owned = False
                street15.owned = False
                street16.owned = False
                street18.owned = False
                street19.owned = False
                street21.owned = False
                street23.owned = False
                street24.owned = False
                street25.owned = False
                street26.owned = False
                street27.owned = False
                street28.owned = False
                street28.owned = False
                street31.owned = False
                street32.owned = False
                street34.owned = False
                street35.owned = False
                street37.owned = False
                street39.owned = False
                street1.player = 0
                street3.player = 0
                street5.player = 0
                street6.player = 0
                street8.player = 0
                street9.player = 0
                street11.player = 0
                street12.player = 0
                street13.player = 0
                street14.player = 0
                street15.player = 0
                street16.player = 0
                street18.player = 0
                street19.player = 0
                street21.player = 0
                street23.player = 0
                street24.player = 0
                street25.player = 0
                street26.player = 0
                street27.player = 0
                street28.player = 0
                street28.player = 0
                street31.player = 0
                street32.player = 0
                street34.player = 0
                street35.player = 0
                street37.player = 0
                street39.player = 0
                space(0) = 0
                space(1) = 0
                space(2) = 0
                space(3) = 0
                cash(0) = 0
                cash(1) = 0
                cash(2) = 0
                cash(3) = 0
                oldcash(0) = 0
                oldcash(1) = 0
                oldcash(2) = 0
                oldcash(3) = 0
                turn = 0
                jail(0) = False
                jail(1) = False
                jail(2) = False
                jail(3) = False
                utility(0) = False
                utility(1) = False
                utility(2) = False
                utility(3) = False
                railway(0) = False
                railway(1) = False
                railway(2) = False
                railway(3) = False
                player(0) = True
                player(1) = True
                player(2) = True
                player(3) = True ' resets all variables and properties
            End If
        End If
    End Sub
End Class
