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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Iotcloudgateway.Model
{

    /// <summary>
    ///  ossSpec
    /// </summary>
    public class OssSpec
    {

        ///<summary>
        /// OSS AK
        ///Required:true
        ///</summary>
        [Required]
        public string Oss_ak{ get; set; }
        ///<summary>
        /// OSS SK
        ///Required:true
        ///</summary>
        [Required]
        public string Oss_sk{ get; set; }
        ///<summary>
        /// OSS region
        ///Required:true
        ///</summary>
        [Required]
        public string Oss_region{ get; set; }
        ///<summary>
        /// OSS endpoint
        ///Required:true
        ///</summary>
        [Required]
        public string Oss_endpoint{ get; set; }
        ///<summary>
        /// OSS bucket
        ///Required:true
        ///</summary>
        [Required]
        public string Oss_bucket{ get; set; }
    }
}
