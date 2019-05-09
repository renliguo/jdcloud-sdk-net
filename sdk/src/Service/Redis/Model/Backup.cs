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

namespace JDCloudSDK.Redis.Model
{

    /// <summary>
    ///  缓存Redis实例的一个备份文件对象
    /// </summary>
    public class Backup
    {

        ///<summary>
        /// 备份操作ID
        ///Required:true
        ///</summary>
        [Required]
        public string BaseId{ get; set; }
        ///<summary>
        /// 备份文件的名称
        ///Required:true
        ///</summary>
        [Required]
        public string BackupFileName{ get; set; }
        ///<summary>
        /// 备份文件对应的实例ID
        ///Required:true
        ///</summary>
        [Required]
        public string CacheInstanceId{ get; set; }
        ///<summary>
        /// 备份开始时间（ISO 8601标准的UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ）
        ///Required:true
        ///</summary>
        [Required]
        public DateTime BackupStartTime{ get; set; }
        ///<summary>
        /// 备份结束时间（ISO 8601标准的UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ）
        ///Required:true
        ///</summary>
        [Required]
        public DateTime BackupEndTime{ get; set; }
        ///<summary>
        /// 备份类型，1表示手动备份，0表示自动备份
        ///Required:true
        ///</summary>
        [Required]
        public int BackupType{ get; set; }
        ///<summary>
        /// 备份文件总字节大小，如果实例是集群版，则表示每个分片备份文件大小的总和
        ///Required:true
        ///</summary>
        [Required]
        public long BackupSize{ get; set; }
        ///<summary>
        /// 备份任务状态状态，0表示备份中，1表示失败，2表示成功
        ///Required:true
        ///</summary>
        [Required]
        public int BackupStatus{ get; set; }
        ///<summary>
        /// 备份文件下载地址，已置空，需要调用获取备份文件下载地址接口获取
        ///Required:true
        ///</summary>
        [Required]
        public string BackupDownloadURL{ get; set; }
    }
}
