// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Detailed information of the anomalous time stamp. </summary>
    public partial class AnomalyValue
    {
        /// <summary> Initializes a new instance of AnomalyValue. </summary>
        /// <param name="isAnomaly"> True if an anomaly is detected at the current time stamp. </param>
        /// <param name="severity">
        /// Indicates the significance of the anomaly. The higher the severity, the more
        /// significant the anomaly is.
        /// </param>
        /// <param name="score"> Raw anomaly score of severity, to help indicate the degree of abnormality. </param>
        internal AnomalyValue(bool isAnomaly, float severity, float score)
        {
            IsAnomaly = isAnomaly;
            Severity = severity;
            Score = score;
            Interpretation = new ChangeTrackingList<AnomalyInterpretation>();
        }

        /// <summary> Initializes a new instance of AnomalyValue. </summary>
        /// <param name="isAnomaly"> True if an anomaly is detected at the current time stamp. </param>
        /// <param name="severity">
        /// Indicates the significance of the anomaly. The higher the severity, the more
        /// significant the anomaly is.
        /// </param>
        /// <param name="score"> Raw anomaly score of severity, to help indicate the degree of abnormality. </param>
        /// <param name="interpretation"> Interpretation of this anomalous time stamp. </param>
        internal AnomalyValue(bool isAnomaly, float severity, float score, IReadOnlyList<AnomalyInterpretation> interpretation)
        {
            IsAnomaly = isAnomaly;
            Severity = severity;
            Score = score;
            Interpretation = interpretation;
        }

        /// <summary> True if an anomaly is detected at the current time stamp. </summary>
        public bool IsAnomaly { get; }
        /// <summary>
        /// Indicates the significance of the anomaly. The higher the severity, the more
        /// significant the anomaly is.
        /// </summary>
        public float Severity { get; }
        /// <summary> Raw anomaly score of severity, to help indicate the degree of abnormality. </summary>
        public float Score { get; }
        /// <summary> Interpretation of this anomalous time stamp. </summary>
        public IReadOnlyList<AnomalyInterpretation> Interpretation { get; }
    }
}
