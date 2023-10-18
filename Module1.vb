Imports System.Threading
Imports Microsoft.Win32

Module Module1
    'Logan Handley
    '10/16/23
    'probably painful project
    Sub Main()
        Console.WriteLine("This is a choose your own adventure story (with absolutely no secrets whatsoever). Choices will be presented to you, and you will follow the prompts to reach an ending.")
        Console.WriteLine("You wake up one morning, and you wonder what you should do today." & vbNewLine)
        Console.Write("Press 1 to stay inside. Press 2 to go out.")
        Dim choice As String = getAOneOrTwo("https://www.youtube.com/watch?v=hiRacdl02w4")
        Console.WriteLine("You chose: " & choice)

        If choice = "1" Then
            Console.Clear()
            Console.WriteLine("You decide that going outside is for chumps and stay inside. But what do you want to do?" & vbNewLine)
            Console.Write("Press 1 to play video games, press 2 to eat food.")
            choice = getAOneOrTwo("https://www.youtube.com/watch?v=dQw4w9WgXcQ")
            If choice = "1" Then
                Console.Clear()
                Console.WriteLine("You eventually decide you want to play some video games, but what kind of game do you start with?" & vbNewLine)
                Console.Write("Press 1 to play an RPG, or press 2 to play an FPS.")
                choice = getAOneOrTwo("https://jcw87.github.io/c2-sans-fight/")
                If choice = "1" Then
                    Console.Clear()
                    Console.WriteLine("You  decide you want to play an RPG. But which one do you want to play?" & vbNewLine)
                    Console.Write("Press 1 to play Final Fantasy VII, or press 2 to play Undertale.")
                    choice = getAOneOrTwo("https://www.youtube.com/watch?v=2LM0CZZ9Uw8")
                    If choice = "1" Then
                        Console.Clear()
                        Console.WriteLine("You decide you'd rather play something with a bit more action, and boot up Final Fantasy VII Remake.")
                        Console.WriteLine("Ending Unlocked: A (not so) Final Fantasy")
                        Threading.Thread.Sleep(3500)
                        Process.Start("https://store.steampowered.com/app/1462040/FINAL_FANTASY_VII_REMAKE_INTERGRADE/")
                        End
                    ElseIf choice = "2" Then
                        Console.Clear()
                        Console.WriteLine("You decide to have a more laid back experience and boot up Undertale.")
                        Console.WriteLine("Ending Unlocked: Mildly Determined")
                        Threading.Thread.Sleep(3500)
                        Process.Start("https://store.steampowered.com/app/391540/Undertale/")
                        End
                    End If
                Else
                    Console.Clear()
                    Console.WriteLine("You decide you want to play an FPS game, but which one will you play?")
                    Console.Write("Press 1 to play DOOM, press 2 to play Half-Life 2.")
                    choice = getAOneOrTwo("https://www.youtube.com/watch?v=FwSyhpv4BDk")
                    If choice = "1" Then
                        Console.WriteLine("You decide you want less story and more gameplay, and thus, DOOM is what you play.")
                        Console.WriteLine("Ending Unlocked: 30 Years Of Fun")
                        Threading.Thread.Sleep(3500)
                        Process.Start("https://store.steampowered.com/app/2280/DOOM_1993/")
                        End
                    ElseIf choice = "2" Then
                        Console.WriteLine("You decide you want more story and immersive gameplay, and so you play Half-Life 2.")
                        Console.WriteLine("Ending Unlocked: The Valve of Immersion")
                        Threading.Thread.Sleep(3500)
                        Process.Start("https://store.steampowered.com/app/2280/DOOM_1993/")
                        End
                    End If
                End If
            ElseIf choice = "2" Then
                Console.Clear()
                Console.WriteLine("You decide you're hungry. What food are you gonna eat?")
                Console.Write("Press 1 if you want steak. Press 2 to eat noodles.")
                choice = getAOneOrTwo("https://www.youtube.com/watch?v=waoVzJHUEz4")
                If choice = "1" Then
                    Console.Clear()
                    Console.WriteLine("It doesn't matter what you want. You're hungry enough you eat both.")
                    Console.WriteLine("Ending Unlocked: Insatiable Hunger")
                    Threading.Thread.Sleep(3500)
                    End
                ElseIf choice = "2" Then
                    Console.Clear()
                    Console.WriteLine("It doesn't matter what you want. You're hungry enough you eat both.")
                    Console.WriteLine("Ending Unlocked: Insatiable Hunger")
                    Threading.Thread.Sleep(3500)
                    End
                End If
            End If

        End If



        If choice = "2" Then
            Console.Clear()
            Console.WriteLine("You decide you should go out and enjoy the nice day, but what do you want to do out here?")
            Console.WriteLine("Press 1 to take a walk. Press 2 to go cycling.")
            choice = getAOneOrTwo("http://www.staggeringbeauty.com/")
            If choice = "1" Then
                Console.Clear()
                Console.WriteLine("You decide to take it slow and go for a walk. Where do you want to go?")
                Console.Write("Press 1 to walk to the park. Press 2 to walk until you figure out where to go.")
                choice = getAOneOrTwo("https://www.youtube.com/watch?v=z8EfXNeTVjw")
                If choice = "1" Then
                    Console.Clear()
                    Console.WriteLine("You end up heading for the nearby park, and think about how long you want to be here.")
                    Console.Write("Press 1 to stay for a few minutes. Press 2 to stay a while.")
                    choice = getAOneOrTwo("https://www.youtube.com/watch?v=hEV1guqZOi4")
                    If choice = "1" Then
                        Console.Clear()
                        Console.WriteLine("It doesn't matter how long you stay, you end up losing track of time and burning the day away.")
                        Console.WriteLine("Ending Unlocked: Space Cadet")
                        Threading.Thread.Sleep(3500)
                        End
                    ElseIf choice = "2" Then
                        Console.Clear()
                        Console.WriteLine("It doesn't matter how long you stay, you end up losing track of time and burning the day away.")
                        Console.WriteLine("Ending Unlocked: Space Cadet")
                        Threading.Thread.Sleep(3500)
                        End
                    End If
                ElseIf choice = "2" Then
                    Console.Clear()
                    Console.WriteLine("You end up aimlessly walking around without a clue as to where to go.")
                    Console.WriteLine("Ending Unlocked: Aimless Wanderer")
                    Threading.Thread.Sleep(3500)
                    End
                End If

            End If
            If choice = "2" Then
                Console.Clear()
                Console.WriteLine("You decide you want some spice in your life and go cycling. Where do you bike to?")
                Console.Write("Press 1 to bike around until you figure it out. Press 2 to head to the museum.")
                choice = getAOneOrTwo("https://www.youtube.com/watch?v=Nl5r-uoB2C4")
                If choice = "1" Then
                    Console.Clear()
                    Console.WriteLine("You end up aimlessly biking around without a clue as to where to go.")
                    Console.WriteLine("Ending Unlocked: Aimless Wanderer")
                    Threading.Thread.Sleep(3500)
                    End
                ElseIf choice = "2" Then
                    Console.Clear()
                    Console.WriteLine("As you arrive at the museum, a realization hits you: All you did was burn time, the museum isn't open.")
                    Console.WriteLine("Ending Unlocked: Fool")
                    Threading.Thread.Sleep(3500)
                    End
                End If
            End If
        End If

        If choice = "4" Then
            Console.Clear()
            Console.WriteLine("You decide that it isn't worth the trouble and go back to sleep.")
            Console.WriteLine("Secret Ending Unlocked: Minimal Effort")
            Threading.Thread.Sleep(3500)
            End
        End If

        If choice = "666" Then
            Process.Start("https://store.steampowered.com/app/601150/Devil_May_Cry_5/")
            End
        End If
        If choice = "bible" Then
            Process.Start("https://www.youtube.com/watch?v=GTh5J0HsIAg")
            End
        End If


        Console.ReadKey()
    End Sub
    Function getAOneOrTwo(link As String) As String

        Dim input As String

        Do

            Console.WriteLine()
            input = Console.ReadLine()
            input = input.Trim
            input.ToLower()


            If input <> "1" AndAlso input <> "2" Then
                Console.WriteLine()
                If input = "3" Then
                    Process.Start(link)
                    End
                End If
                If input = "2" Then
                    Console.WriteLine()
                End If
            End If


        Loop While input <> "1" AndAlso input <> "2" AndAlso input <> "3" AndAlso input <> "4" AndAlso input <> "666" AndAlso input <> "bible"

        Return input
    End Function
    'i never wanna code something like this again
End Module
