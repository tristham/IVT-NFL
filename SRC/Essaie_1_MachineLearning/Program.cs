// See https://aka.ms/new-console-template for more information

using Essaie_1_MachineLearning;

MLNBA.ModelInput sampleData2 = new MLNBA.ModelInput()
{
    GAME_DATE_EST = @"2022-04-25",
    HOME_TEAM_ID = 1610612748F, // Miami Heat
    VISITOR_TEAM_ID = 1610612752F, // Knicks
    SEASON = 2022F,

    TEAM_ID_home = 1610612748F, // Miami Heat
    PTS_home = 110.1F,
    FG_PCT_home = 0.468F,
    FT_PCT_home = 0.814F,
    FG3_PCT_home = 0.37F,
    AST_home = 26.1F,
    REB_home = 43.9F,

    TEAM_ID_away = 1610612752F, // Knicks
    PTS_away = 106.3F,
    FG_PCT_away = 0.437F,
    FT_PCT_away = 0.744F,
    FG3_PCT_away = 0.355F,
    AST_away = 21.2F,
    REB_away = 46.5F,
};

var predictionResults = MLNBA.Predict(sampleData2);

Console.WriteLine(predictionResults.Score.ToString());
