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
 * 相关接口
 * API related to order
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Order.Model
{

    /// <summary>
    ///  orderResourceInfo
    /// </summary>
    public class OrderResourceInfo
    {

        ///<summary>
        /// 订单号
        ///</summary>
        public string OrderNumber{ get; set; }
        ///<summary>
        /// 用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 资源id,下单没有传替，则预生成一个
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 创建资源唯一标识
        ///</summary>
        public string SourceId{ get; set; }
    }
}
