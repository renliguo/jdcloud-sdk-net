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
 * 后端服务
 * 后端服务相关接口
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

using JDCloudSDK.Lb.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Lb.Apis
{

    /// <summary>
    /// 创建一个后端服务
    /// </summary>
    public class CreateBackendRequest : JdcloudRequest
    {
        ///<summary>
        ///后端服务名字,只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符
        ///Required:true
        ///</summary>
        [Required]
        public   string BackendName{ get; set; }
        ///<summary>
        ///后端服务所属负载均衡的Id
        ///Required:true
        ///</summary>
        [Required]
        public   string LoadBalancerId{ get; set; }
        ///<summary>
        ///后端服务的协议【alb】取值范围：Http、Tcp【nlb】取值范围：Tcp
        ///Required:true
        ///</summary>
        [Required]
        public   string Protocol{ get; set; }
        ///<summary>
        ///后端服务的端口，取值范围为[1, 65535]，如指定了TargetSpec中的port，实际按照target指定的port进行转发
        ///Required:true
        ///</summary>
        [Required]
        public   double Port{ get; set; }
        ///<summary>
        ///健康检查信息
        ///Required:true
        ///</summary>
        [Required]
        public   HealthCheckSpec HealthCheckSpec{ get; set; }
        ///<summary>
        ///调度算法, 取值范围为[IpHash, RoundRobin,和LeastConn]（取值范围的含义分别为：源Ip hash，加权轮询和加权最小连接），默认为RoundRobin（加权轮询）
        ///</summary>
        public   string Algorithm{ get; set; }
        ///<summary>
        ///服务器组的Id列表，目前只支持一个，且与agIds不能同时存在
        ///</summary>
        public List<string> TargetGroupIds{ get; set; }

        ///<summary>
        ///可用性组Id列表，目前只支持一个，且与targetGroupIds不能同时存在
        ///</summary>
        public List<string> AgIds{ get; set; }

        ///<summary>
        ///【alb Tcp协议】获取真实ip, 取值为False(不获取)或者True(获取,支持Proxy Protocol v1版本)，默认为False
        ///</summary>
        public   bool ProxyProtocol{ get; set; }
        ///<summary>
        ///描述,允许输入UTF-8编码下的全部字符，不超过256字符
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        ///后端服务的后端保持, 取值为False(不开启)或者True(开启)，默认为False【alb Http协议】支持基于cookie的会话保持【nlb】支持基于报文二元组、三元组和四元组的会话保持
        ///</summary>
        public   bool SessionStickiness{ get; set; }
        ///<summary>
        ///【nlb】后端服务会话保持方式, 取值范围：[srcIp、srcIp_protocol、srcIp_pro_port]
        ///</summary>
        public   string SessionStickyType{ get; set; }
        ///<summary>
        ///【nlb】移除target前，连接的最大保持时间，默认300s，范围[0，3600]
        ///</summary>
        public   double? ConnectionDrainingSeconds{ get; set; }
        ///<summary>
        ///【alb Http协议】cookie的过期时间,取值范围为[0,86400], 默认为0（表示cookie与浏览器同生命周期）, 当alb的sessionStickiness为True时，必传
        ///</summary>
        public   double? HttpCookieExpireSeconds{ get; set; }
        ///<summary>
        ///【alb Http协议】获取负载均衡的协议, 取值为False(不获取)或True(获取), 默认为False
        ///</summary>
        public   bool HttpForwardedProtocol{ get; set; }
        ///<summary>
        ///【alb Http协议】获取负载均衡的端口, 取值为False(不获取)或True(获取), 默认为False
        ///</summary>
        public   bool HttpForwardedPort{ get; set; }
        ///<summary>
        ///【alb Http协议】获取负载均衡的host信息, 取值为False(不获取)或True(获取), 默认为False
        ///</summary>
        public   bool HttpForwardedHost{ get; set; }
        ///<summary>
        ///【alb Http协议】获取负载均衡的vip, 取值为False(不获取)或True(获取), 默认为False
        ///</summary>
        public   bool HttpForwardedVip{ get; set; }
        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}