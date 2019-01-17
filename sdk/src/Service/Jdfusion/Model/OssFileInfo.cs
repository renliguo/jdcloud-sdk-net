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


namespace JDCloudSDK.Jdfusion.Model
{

    /// <summary>
    ///  OSS文件信息
    /// </summary>
    public class OssFileInfo
    {

        ///<summary>
        /// 存储桶名称
        ///</summary>
        public string BucketName{ get; set; }
        ///<summary>
        /// 文件存储Key值
        ///</summary>
        public string Key{ get; set; }
        ///<summary>
        /// 文件大小（字节）
        ///</summary>
        public double? Size{ get; set; }
        ///<summary>
        /// 上次修改时间
        ///</summary>
        public string LastModifiedTime{ get; set; }
        ///<summary>
        /// 存储类型
        ///</summary>
        public string StorageClass{ get; set; }
    }
}
