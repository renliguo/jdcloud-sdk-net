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

namespace JDCloudSDK.Logs.Model
{

    /// <summary>
    ///  createShipperSpec
    /// </summary>
    public class CreateShipperSpec
    {

        ///<summary>
        /// 压缩格式，为空不压缩
        ///</summary>
        public string Compress{ get; set; }
        ///<summary>
        /// 投递格式 json,  origin(原始日志格式), 默认origin
        ///</summary>
        public string FileFormat{ get; set; }
        ///<summary>
        /// 投递文件大小，单位MB，支持200,300,400,500,1000
        ///Required:true
        ///</summary>
        [Required]
        public long FileSize{ get; set; }
        ///<summary>
        /// 转储任务名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 目的地 配置
        ///Required:true
        ///</summary>
        [Required]
        public Dictionary<String,object> TargetConf{ get; set; }
        ///<summary>
        /// 转储目的地类型 0: oss, 目前只支持oss
        ///</summary>
        public long? TargetType{ get; set; }
        ///<summary>
        /// 投递时间间隔单位分钟，5分钟整数倍，支持5,10,15,20,30,60
        ///Required:true
        ///</summary>
        [Required]
        public long TimeInterval{ get; set; }
    }
}
