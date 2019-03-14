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
 * Live-Video
 * 直播管理API
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Common.Model;

namespace  JDCloudSDK.Live.Apis
{

    /// <summary>
    ///  查询水印模板列表
    /// </summary>
    public class DescribeCustomLiveStreamWatermarkTemplatesRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码；默认为1；取值范围[1, 100000]
        ///</summary>
        public   int? PageNum{ get; set; }
        ///<summary>
        /// 分页大小；默认为10；取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 水印模板列表查询过滤条件:
        ///   - name:   template 录制模板自定义名称
        ///   - value:  如果参数为空，则查询全部
        /// 
        ///</summary>
        public List<Filter> Filters{ get; set; }

    }
}