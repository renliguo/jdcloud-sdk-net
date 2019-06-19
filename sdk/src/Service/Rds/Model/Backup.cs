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


namespace JDCloudSDK.Rds.Model
{

    /// <summary>
    ///  backup
    /// </summary>
    public class Backup
    {

        ///<summary>
        /// 备份ID
        ///</summary>
        public string BackupId{ get; set; }
        ///<summary>
        /// 备份名称，最长支持64个英文字符或等长的中文字符
        ///</summary>
        public string BackupName{ get; set; }
        ///<summary>
        /// 备份所属实例ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 备份状态，请查看[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string BackupStatus{ get; set; }
        ///<summary>
        /// 备份开始时间，格式为：YYYY-MM-DD HH:mm:ss
        ///</summary>
        public string BackupStartTime{ get; set; }
        ///<summary>
        /// 备份结束时间，格式为：YYYY-MM-DD HH:mm:ss&lt;br&gt;- **SQL Server支持**&lt;br&gt;- **MySQL不支持**
        ///</summary>
        public string BackupEndTime{ get; set; }
        ///<summary>
        /// 备份类型，全量备份或增量备份，请查看[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)&lt;br&gt;- **SQL Server支持**&lt;br&gt;- **MySQL不支持**
        ///</summary>
        public string BackupType{ get; set; }
        ///<summary>
        /// 备份模式，系统自动备份或手动备份，请查看[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string BackupMode{ get; set; }
        ///<summary>
        /// 备份粒度，实例备份或者多库备份，请查看[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)&lt;br&gt;- **SQL Server支持**&lt;br&gt;- **MySQL不支持**
        ///</summary>
        public string BackupUnit{ get; set; }
        ///<summary>
        /// 备份文件列表&lt;br&gt;- **SQL Server支持**,备份可以有多个文件，文件名的命名规则为:&lt;br&gt;（1）全备：数据库名+.bak&lt;br&gt;（2）增量：数据库名+.diff&lt;br&gt;- **MySQL不支持**
        ///</summary>
        public List<string> BackupFiles{ get; set; }
        ///<summary>
        /// 整个备份集大小，单位：Byte
        ///</summary>
        public int? BackupSizeByte{ get; set; }
    }
}