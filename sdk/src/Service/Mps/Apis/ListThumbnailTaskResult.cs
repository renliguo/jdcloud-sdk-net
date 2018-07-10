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
 * 媒体处理相关接口
 * 媒体处理API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Mps.Model;

namespace  JDCloudSDK.Mps.Apis
{

    /// <summary>
    /// 查询截图任务
    /// </summary>
    public class ListThumbnailTaskResult : JdcloudResult
    {
        ///<summary>
        ///状态 (SUCCESS, ERROR, PENDDING, RUNNING)
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        ///查询开始时间 时间格式(GMT): yyyy-MM-dd’T’HH:mm:ss.SSS’Z’
        ///</summary>
        public   string Begin{ get; set; }
        ///<summary>
        ///查询结束时间 时间格式(GMT): yyyy-MM-dd’T’HH:mm:ss.SSS’Z’
        ///</summary>
        public   string End{ get; set; }
        ///<summary>
        ///本次请求的marker, 标记查询的起始位置, 此处为taskID
        ///</summary>
        public   string Marker{ get; set; }
        ///<summary>
        ///本次请求返回的任务列表的最大元素个数, 有效值: [1-1000]，默认值: 1000
        ///</summary>
        public   int? Limit{ get; set; }
        ///<summary>
        ///获取下一页所需要传递的marker值(此处为taskID), 仅当isTruncated为true时(数据未全部返回)出现 (readonly)
        ///</summary>
        public   string NextMarker{ get; set; }
        ///<summary>
        ///指明返回数据是否被截断. true表示本页后面还有数据, 即数据未全部返回; false表示已是最后一页, 即数据已全部返回 (readonly)
        ///</summary>
        public   bool Truncated{ get; set; }
        ///<summary>
        ///返回的task列表 (readonly)
        ///</summary>
        public List<ThumbnailTask> TaskList{ get; set; }

    }
}