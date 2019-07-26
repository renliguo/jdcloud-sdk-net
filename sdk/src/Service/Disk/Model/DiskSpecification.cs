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


namespace JDCloudSDK.Disk.Model
{

    /// <summary>
    ///  diskSpecification
    /// </summary>
    public class DiskSpecification
    {

        ///<summary>
        /// 云硬盘类型
        ///</summary>
        public string DiskType{ get; set; }
        ///<summary>
        /// 支持的最小尺寸，单位为 GiB
        ///</summary>
        public int? MinSizeGB{ get; set; }
        ///<summary>
        /// 支持的最大尺寸，单位为 GiB
        ///</summary>
        public int? MaxSizeGB{ get; set; }
        ///<summary>
        /// 步长尺寸，单位为 GiB
        ///</summary>
        public int? StepSizeGB{ get; set; }
        ///<summary>
        /// 描述信息
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 默认的iops数量(基础iops数量)
        ///</summary>
        public int? DefaultIOPS{ get; set; }
        ///<summary>
        /// iops步长增量
        ///</summary>
        public float? StepIOPS{ get; set; }
        ///<summary>
        /// 最大iops数量
        ///</summary>
        public int? MaxIOPS{ get; set; }
        ///<summary>
        /// 默认的吞吐量
        ///</summary>
        public int? DefaultThroughput{ get; set; }
        ///<summary>
        /// 吞吐量步长增量
        ///</summary>
        public float? StepThroughput{ get; set; }
        ///<summary>
        /// 最大吞吐量
        ///</summary>
        public int? MaxThroughput{ get; set; }
        ///<summary>
        /// 是否开启IOPS可调整
        ///</summary>
        public bool ScalableIOPS{ get; set; }
        ///<summary>
        /// 最大iops步长
        ///</summary>
        public int? MaxStepIOPS{ get; set; }
    }
}
