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
 * 云硬盘相关接口
 * 云硬盘相关接口，提供批量创建云硬盘，查询云硬盘，删除云硬盘，对云硬盘进行扩容，修改云硬盘信息以及使用快照恢复云硬盘等功能。
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Client; 
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Disk.Client
{

    /// <summary>
    ///  -   创建一块或多块按配置或者按使用时长付费的云硬盘。
        /// -   云硬盘类型包括高效云盘(premium-hdd)、SSD云盘(ssd)、通用型SSD(ssd.gp1)、性能型SSD(ssd.io1)、容量型HDD(hdd.std1)。
        /// -   计费方式默认为按配置付费。
        /// -   创建完成后，云硬盘状态为 available。
        /// -   可选参数快照 ID用于从快照创建新盘。
        /// -   批量创建时，云硬盘的命名为 硬盘名称-数字，例如 myDisk-1，myDisk-2。
        /// -   maxCount为最大努力，不保证一定能达到maxCount。
        /// 
    /// </summary>
    public class CreateDisksExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  -   创建一块或多块按配置或者按使用时长付费的云硬盘。
        /// -   云硬盘类型包括高效云盘(premium-hdd)、SSD云盘(ssd)、通用型SSD(ssd.gp1)、性能型SSD(ssd.io1)、容量型HDD(hdd.std1)。
        /// -   计费方式默认为按配置付费。
        /// -   创建完成后，云硬盘状态为 available。
        /// -   可选参数快照 ID用于从快照创建新盘。
        /// -   批量创建时，云硬盘的命名为 硬盘名称-数字，例如 myDisk-1，myDisk-2。
        /// -   maxCount为最大努力，不保证一定能达到maxCount。
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "POST";
            }
        }
        /// <summary>
        ///  -   创建一块或多块按配置或者按使用时长付费的云硬盘。
        /// -   云硬盘类型包括高效云盘(premium-hdd)、SSD云盘(ssd)、通用型SSD(ssd.gp1)、性能型SSD(ssd.io1)、容量型HDD(hdd.std1)。
        /// -   计费方式默认为按配置付费。
        /// -   创建完成后，云硬盘状态为 available。
        /// -   可选参数快照 ID用于从快照创建新盘。
        /// -   批量创建时，云硬盘的命名为 硬盘名称-数字，例如 myDisk-1，myDisk-2。
        /// -   maxCount为最大努力，不保证一定能达到maxCount。
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/disks";
            }
        }
    }
}