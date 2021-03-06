﻿using System;
using System.Threading.Tasks;

using McMaster.Extensions.CommandLineUtils;

namespace AdventOfCode_2020
{
    [Command("aoc")]
    [Subcommand(
        typeof(Day01.Solution),
        typeof(Day02.Solution),
        typeof(Day03.Solution),
        typeof(Day04.Solution),
        typeof(Day05.Solution),
        typeof(Day06.Solution),
        typeof(Day07.Solution)
    )]
    internal class AdventOfCode : Puzzle
    {
        public AdventOfCode(CommandLineApplication app) : base(app)
        {
        }

        protected override Task<int> Solve()
        {
            App.ShowHint();
            return Task.FromResult(0);
        }

        private static async Task<int> Main(string[] args)
        {
            var app = new CommandLineApplication<AdventOfCode>();

            app.Conventions.UseDefaultConventions();

            try
            {
                return await app.ExecuteAsync(args);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                app.Error.WriteLine(e.Message);
                Console.ResetColor();
                return 1;
            }
        }
    }
}