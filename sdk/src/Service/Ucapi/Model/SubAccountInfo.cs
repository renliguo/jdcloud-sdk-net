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


namespace JDCloudSDK.Ucapi.Model
{

    /// <summary>
    /// subAccountInfo
    /// </summary>
    public class SubAccountInfo
    {

        ///<summary>
        ///主账号
        ///</summary>
        public string Account{ get; set; }
        ///<summary>
        ///当前登录用户pin，即子账号
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        ///新密码
        ///</summary>
        public string NewPwd{ get; set; }
        ///<summary>
        ///原密码
        ///</summary>
        public string OldPwd{ get; set; }
    }
}
