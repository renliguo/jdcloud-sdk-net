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
    ///  describeDashboardsSpec
    /// </summary>
    public class DescribeDashboardsSpec
    {

        ///<summary>
        /// folderIds-文件夹Id，精确匹配，支持单个;
        ///</summary>
        public List<Filter> Filters{ get; set; }
        ///<summary>
        /// 当前所在页，默认为1
        /// in: query
        ///</summary>
        public long? PageNumber{ get; set; }
        ///<summary>
        /// 页面大小，默认为20；取值范围[1, 100]
        /// in: query
        ///</summary>
        public long? PageSize{ get; set; }
    }
}
