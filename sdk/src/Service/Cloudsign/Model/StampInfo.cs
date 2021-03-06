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


namespace JDCloudSDK.Cloudsign.Model
{

    /// <summary>
    ///  stampInfo
    /// </summary>
    public class StampInfo
    {

        ///<summary>
        /// 印章ID
        ///</summary>
        public string StampId{ get; set; }
        ///<summary>
        /// 印章名称
        ///</summary>
        public string StampName{ get; set; }
        ///<summary>
        /// 印章图片（base64）
        ///</summary>
        public string StampContent{ get; set; }
        ///<summary>
        /// 印章摘要
        ///</summary>
        public string StampDigest{ get; set; }
        ///<summary>
        /// 印章上传时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
    }
}
