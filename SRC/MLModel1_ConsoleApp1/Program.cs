﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace MLModel1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelNBA.ModelInput sampleData = new ModelNBA.ModelInput()
            {
                GAME_DATE_EST = @"2022-03-12",
                GAME_ID = 2.2101E+07F,
                GAME_STATUS_TEXT = @"Final",
                HOME_TEAM_ID = 1.610613E+09F,
                VISITOR_TEAM_ID = 1.610613E+09F,
                SEASON = 2021F,
                TEAM_ID_home = 1.610613E+09F,
                PTS_home = 104F,
                FG_PCT_home = 0.398F,
                FT_PCT_home = 0.76F,
                FG3_PCT_home = 0.333F,
                AST_home = 23F,
                REB_home = 53F,
                TEAM_ID_away = 1.610613E+09F,
                PTS_away = 113F,
                FG_PCT_away = 0.422F,
                FT_PCT_away = 0.875F,
                FG3_PCT_away = 0.357F,
                AST_away = 21F,
                REB_away = 46F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ModelNBA.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual HOME_TEAM_WINS with predicted HOME_TEAM_WINS from sample data...\n\n");


            Console.WriteLine($"GAME_DATE_EST: {@"2022-03-12"}");
            Console.WriteLine($"GAME_ID: {2.2101E+07F}");
            Console.WriteLine($"GAME_STATUS_TEXT: {@"Final"}");
            Console.WriteLine($"HOME_TEAM_ID: {1.610613E+09F}");
            Console.WriteLine($"VISITOR_TEAM_ID: {1.610613E+09F}");
            Console.WriteLine($"SEASON: {2021F}");
            Console.WriteLine($"TEAM_ID_home: {1.610613E+09F}");
            Console.WriteLine($"PTS_home: {104F}");
            Console.WriteLine($"FG_PCT_home: {0.398F}");
            Console.WriteLine($"FT_PCT_home: {0.76F}");
            Console.WriteLine($"FG3_PCT_home: {0.333F}");
            Console.WriteLine($"AST_home: {23F}");
            Console.WriteLine($"REB_home: {53F}");
            Console.WriteLine($"TEAM_ID_away: {1.610613E+09F}");
            Console.WriteLine($"PTS_away: {113F}");
            Console.WriteLine($"FG_PCT_away: {0.422F}");
            Console.WriteLine($"FT_PCT_away: {0.875F}");
            Console.WriteLine($"FG3_PCT_away: {0.357F}");
            Console.WriteLine($"AST_away: {21F}");
            Console.WriteLine($"REB_away: {46F}");
            Console.WriteLine($"HOME_TEAM_WINS: {0F}");


            Console.WriteLine($"\n\nPredicted HOME_TEAM_WINS: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
