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
 * 云硬盘资源相关接口
 * 提供批量查询云硬盘名称以及绑定资源信息功能。
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Disk.Apis
{

    /// <summary>
    ///  -   根据diskId查询云硬盘名称及云硬盘绑定的资源ID。
        ///         /// -   可以进行批量查询，各个卷ID用逗号隔开。
        ///         /// 
    /// </summary>
    public class SelectDetailListResponse : JdcloudResponse<SelectDetailListResult>
    {
    }
}