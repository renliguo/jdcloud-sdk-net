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
    ///  系统盘配置
    /// </summary>
    public class SysDiskInfo
    {

        ///<summary>
        /// 硬盘大小
        ///</summary>
        public int? DiskSize{ get; set; }
        ///<summary>
        /// 磁盘介质分类，目前为预留，可以为空
        ///</summary>
        public string DiskMediumType{ get; set; }
        ///<summary>
        /// 磁盘名称
        ///</summary>
        public string DiskName{ get; set; }
        ///<summary>
        /// 磁盘是否随主机一起删除
        ///</summary>
        public string AutoDelete{ get; set; }
        ///<summary>
        /// 磁盘状态
        ///</summary>
        public string Status{ get; set; }
    }
}
