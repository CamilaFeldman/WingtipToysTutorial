//// -----------------------------------------------------------------------
//// <copyright file="App_Start.cs" company="Fluent.Infrastructure">
////     Copyright © Fluent.Infrastructure. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
/// See more at: https://github.com/dn32/Fluent.Infrastructure/wiki
////-----------------------------------------------------------------------

using Fluent.Infrastructure.FluentTools;
using WingtipToysTutorial.DataBase;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WingtipToysTutorial.AppStart), "PreStart")]

namespace WingtipToysTutorial {
    public static class AppStart
    {
        public static void PreStart() {
            FluentStartup.Initialize(typeof(DbContextLocal));
        }
    }
}