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


namespace JDCloudSDK.Mps.Model
{

    /// <summary>
    ///  加密配置
    /// </summary>
    public class EncryptionSettings
    {

        ///<summary>
        /// 加密Key。HLS AES129KEY，必须为 16 个 ASCII 可打印字符
        /// 
        ///</summary>
        public string HlsKey{ get; set; }
        ///<summary>
        /// 加密Key地址。必须为合法的HTTP地址。
        /// 若 hleKey 已设置，表示开启 HLS 加密，其时该参数必须
        /// 
        ///</summary>
        public string HlsKeyUrl{ get; set; }
    }
}