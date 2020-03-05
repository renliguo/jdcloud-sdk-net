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
    ///  statisticsInfo
    /// </summary>
    public class StatisticsInfo
    {

        ///<summary>
        /// 已签合同数量
        ///</summary>
        public int? ContractNumber{ get; set; }
        ///<summary>
        /// 印章数量
        ///</summary>
        public int? StampNumber{ get; set; }
        ///<summary>
        /// 合同模板数量
        ///</summary>
        public int? TemplateNumber{ get; set; }
        ///<summary>
        /// 是否启用存管
        ///</summary>
        public bool ContractSave{ get; set; }
        ///<summary>
        /// 已用存储空间容量(单位:MB)
        ///</summary>
        public int? UsedSpace{ get; set; }
        ///<summary>
        /// 签章系统加密密钥ID
        ///</summary>
        public string KmsKeyId{ get; set; }
        ///<summary>
        /// 签章次数统计[24小时，7天，30天]
        ///</summary>
        public List<SignItem> SignStatistic{ get; set; }
    }
}