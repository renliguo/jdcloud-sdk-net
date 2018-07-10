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

namespace JDCloudSDK.Apigateway.Model
{

    /// <summary>
    /// createApi
    /// </summary>
    public class CreateApi
    {

        ///<summary>
        ///分组ID
        ///Required:true
        ///</summary>
        [Required]
        public string ApiGroupId{ get; set; }
        ///<summary>
        ///名称
        ///Required:true
        ///</summary>
        [Required]
        public string ApiName{ get; set; }
        ///<summary>
        ///动作
        ///Required:true
        ///</summary>
        [Required]
        public string Action{ get; set; }
        ///<summary>
        ///请求路径
        ///Required:true
        ///</summary>
        [Required]
        public string Path{ get; set; }
        ///<summary>
        ///描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        ///请求参数列表
        ///</summary>
        public List<Parameter> ReqParams{ get; set; }
        ///<summary>
        ///请求参数列表
        ///</summary>
        public List<Parameter> HeadParams{ get; set; }
        ///<summary>
        ///请求格式
        ///</summary>
        public string ReqBody{ get; set; }
        ///<summary>
        ///返回格式
        ///</summary>
        public string ResBody{ get; set; }
        ///<summary>
        ///请求格式类型,1:application/json,2:text/xml,3:其他
        ///</summary>
        public int? ReqBodyType{ get; set; }
        ///<summary>
        ///返回格式类型,1:application/json,2:text/xml,3:其他
        ///</summary>
        public int? ResbodyType{ get; set; }
    }
}
