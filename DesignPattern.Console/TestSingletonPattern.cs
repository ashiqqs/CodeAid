using DesignPattern.Singleton;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DesignPattern.Console
{
    public class TestSingletonPattern
    {
        public static void Test()
        {
            var appState1 = ApplicationState.GetInstance();
            appState1.LoggedUser = "Ashiq";
            appState1.Role = "Admin";

            var appState2 = ApplicationState.GetInstance();
            WriteLine($"AppState1: User {appState1.LoggedUser}");
            WriteLine($"AppState1: Role {appState1.Role}");
            WriteLine();
            WriteLine($"AppState2: User {appState2.LoggedUser}");
            WriteLine($"AppState2: Role {appState2.Role}");
            WriteLine();
            WriteLine($"AppState1 == AppState2 is {appState1==appState2}");

        }
    }
}
