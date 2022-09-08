﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace ML_Favorite_Console
{
    public partial class ML_Favorite
    {
        /// <summary>
        /// model input class for ML_Favorite.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"schedule_date")]
            public string Schedule_date { get; set; }

            [ColumnName(@"schedule_season")]
            public float Schedule_season { get; set; }

            [ColumnName(@"schedule_week")]
            public float Schedule_week { get; set; }

            [ColumnName(@"schedule_playoff")]
            public string Schedule_playoff { get; set; }

            [ColumnName(@"team_home")]
            public string Team_home { get; set; }

            [ColumnName(@"score_home")]
            public float Score_home { get; set; }

            [ColumnName(@"score_away")]
            public float Score_away { get; set; }

            [ColumnName(@"team_away")]
            public string Team_away { get; set; }

            [ColumnName(@"team_favorite_id")]
            public string Team_favorite_id { get; set; }

            [ColumnName(@"spread_favorite")]
            public float Spread_favorite { get; set; }

            [ColumnName(@"over_under_line")]
            public float Over_under_line { get; set; }

            [ColumnName(@"stadium")]
            public string Stadium { get; set; }

            [ColumnName(@"stadium_neutral")]
            public string Stadium_neutral { get; set; }

            [ColumnName(@"weather_temperature")]
            public float Weather_temperature { get; set; }

            [ColumnName(@"weather_wind_mph")]
            public float Weather_wind_mph { get; set; }

            [ColumnName(@"weather_humidity")]
            public float Weather_humidity { get; set; }

            [ColumnName(@"weather_detail")]
            public string Weather_detail { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for ML_Favorite.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            public float Score { get; set; }
        }
        #endregion

        private static string MLNetModelPath = Path.GetFullPath("ML-Favorite.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
