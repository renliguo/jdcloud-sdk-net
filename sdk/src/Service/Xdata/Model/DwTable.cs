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


namespace JDCloudSDK.Xdata.Model
{

    /// <summary>
    /// dwTable
    /// </summary>
    public class DwTable
    {

        ///<summary>
        ///数据库id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        ///用户名
        ///</summary>
        public string UserName{ get; set; }
        ///<summary>
        ///数据库名
        ///</summary>
        public string DbName{ get; set; }
        ///<summary>
        ///表名
        ///</summary>
        public string TableName{ get; set; }
        ///<summary>
        ///创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        ///最新更新时间
        ///</summary>
        public string LastUpdateTime{ get; set; }
        ///<summary>
        ///物理存储量
        ///</summary>
        public string PhysicalStorageCapacity{ get; set; }
        ///<summary>
        ///类别
        ///</summary>
        public string Category{ get; set; }
        ///<summary>
        ///来源
        ///</summary>
        public string Source{ get; set; }
        ///<summary>
        ///所有者
        ///</summary>
        public string Owner{ get; set; }
        ///<summary>
        ///文件存储类型
        ///</summary>
        public string HiveFileFormat{ get; set; }
        ///<summary>
        ///是否加密
        ///</summary>
        public string Encryption{ get; set; }
        ///<summary>
        ///位置
        ///</summary>
        public string Location{ get; set; }
        ///<summary>
        ///描述信息
        ///</summary>
        public string Comments{ get; set; }
        ///<summary>
        ///hive表权限信息
        ///</summary>
        public DwHiveObjectPrivileges HiveObjectPrivileges{ get; set; }
        ///<summary>
        ///参数
        ///</summary>
        public Object Parameters{ get; set; }
    }
}
