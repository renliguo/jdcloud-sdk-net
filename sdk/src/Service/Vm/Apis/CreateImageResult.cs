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
 * 云主机
 * 与主机操作相关的接口
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


namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    /// &quot;虚机创建私有镜像&quot;
        ///        ///&quot;虚机状态必须为stopped&quot;
        ///        ///&quot;如果虚机上有挂载数据盘，默认会将数据盘创建快照，生成打包镜像&quot;
        ///        ///&quot;主机没有未完成的任务才可制作镜像&quot;
        ///        ///
    /// </summary>
    public class CreateImageResult : JdcloudResult
    {
        ///<summary>
        ///镜像ID
        ///</summary>
        public   string ImageId{ get; set; }
    }
}