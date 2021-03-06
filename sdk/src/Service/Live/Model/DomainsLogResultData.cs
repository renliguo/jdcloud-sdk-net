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
    ///  domainsLogResultData
    /// </summary>
    public class DomainsLogResultData
    {

        ///<summary>
        /// 文件名称
        /// 
        ///</summary>
        public string FileName{ get; set; }
        ///<summary>
        /// 下载地址
        /// 
        ///</summary>
        public string LogUrl{ get; set; }
        ///<summary>
        /// 文件md5
        /// 
        ///</summary>
        public string Md5{ get; set; }
        ///<summary>
        /// 文件大小，单位：Byte
        /// 
        ///</summary>
        public long? Size{ get; set; }
        ///<summary>
        /// 开始时间，UTC时间格式
        /// 
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 结束时间，UTC时间格式
        /// 
        ///</summary>
        public string EndTime{ get; set; }
    }
}
