/*
 * Copyright 2018 JDCLOUD.COM
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http:#www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  metricCm
    /// </summary>
    public class MetricCm
    {

        ///<summary>
        /// AggrPeriod
        ///</summary>
        public string AggrPeriod{ get; set; }
        ///<summary>
        /// AggrType
        ///</summary>
        public string AggrType{ get; set; }
        ///<summary>
        /// CalculateUnit
        ///</summary>
        public string CalculateUnit{ get; set; }
        ///<summary>
        /// DownSampleType
        ///</summary>
        public string DownSampleType{ get; set; }
        ///<summary>
        /// Metric
        ///</summary>
        public string Metric{ get; set; }
        ///<summary>
        /// MetricName
        ///</summary>
        public string MetricName{ get; set; }
        ///<summary>
        /// MetricUID
        ///</summary>
        public string MetricUID{ get; set; }
        ///<summary>
        /// Tags
        ///</summary>
        public Dictionary<string,string> Tags{ get; set; }
    }
}
