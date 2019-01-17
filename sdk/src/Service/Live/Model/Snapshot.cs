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


namespace JDCloudSDK.Live.Model
{

    /// <summary>
    ///  snapshot
    /// </summary>
    public class Snapshot
    {

        ///<summary>
        /// 推流域名
        ///</summary>
        public string PublishDomain{ get; set; }
        ///<summary>
        /// 流所属应用名称
        ///</summary>
        public string AppName{ get; set; }
        ///<summary>
        /// 直播流名称
        ///</summary>
        public string StreamName{ get; set; }
        ///<summary>
        /// 截图时间
        ///</summary>
        public string SnapshotTime{ get; set; }
        ///<summary>
        /// 图片高
        ///</summary>
        public int? Height{ get; set; }
        ///<summary>
        /// 图片宽
        ///</summary>
        public int? Width{ get; set; }
        ///<summary>
        /// OSSBucket的名称
        ///</summary>
        public string OssBucket{ get; set; }
        ///<summary>
        /// OSSEndpoint域名
        ///</summary>
        public string OssEndpoint{ get; set; }
        ///<summary>
        /// OSSObject
        ///</summary>
        public string OssObject{ get; set; }
    }
}
