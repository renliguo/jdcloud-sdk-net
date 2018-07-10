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


namespace JDCloudSDK.Cdn.Model
{

    /// <summary>
    /// cdnQueryPara
    /// </summary>
    public class CdnQueryPara
    {

        ///<summary>
        ///域名
        ///</summary>
        public string Domain{ get; set; }
        ///<summary>
        ///开始时间
        ///</summary>
        public string Start_time{ get; set; }
        ///<summary>
        ///结束时间
        ///</summary>
        public string End_time{ get; set; }
        ///<summary>
        ///HOUR(按小时下载)，DAY（按天下载）不传或者传错都是按照小时下载
        ///</summary>
        public string Interval{ get; set; }
    }
}
