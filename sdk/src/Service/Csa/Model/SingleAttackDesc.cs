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


namespace JDCloudSDK.Csa.Model
{

    /// <summary>
    /// singleAttackDesc
    /// </summary>
    public class SingleAttackDesc
    {

        ///<summary>
        ///事件类型
        ///</summary>
        public string EventType{ get; set; }
        ///<summary>
        ///攻击目标
        ///</summary>
        public string AttackTarget{ get; set; }
        ///<summary>
        ///攻击类型
        ///</summary>
        public string AttackType{ get; set; }
        ///<summary>
        ///发现时间
        ///</summary>
        public string OccurrenceTime{ get; set; }
        ///<summary>
        ///攻击端口
        ///</summary>
        public string AttackPort{ get; set; }
        ///<summary>
        ///回连地址
        ///</summary>
        public string BacklinkIp{ get; set; }
        ///<summary>
        ///破解协议
        ///</summary>
        public string AttackApp{ get; set; }
        ///<summary>
        ///攻击源
        ///</summary>
        public string AttackSrcIp{ get; set; }
        ///<summary>
        ///首次登陆成功
        ///</summary>
        public string FirstLoginTime{ get; set; }
        ///<summary>
        ///安装路径
        ///</summary>
        public string InstalledPath{ get; set; }
        ///<summary>
        ///安装时间
        ///</summary>
        public string InstalledTime{ get; set; }
        ///<summary>
        ///webshell类型
        ///</summary>
        public string WebshellType{ get; set; }
        ///<summary>
        ///恶意IP
        ///</summary>
        public string BadIp{ get; set; }
        ///<summary>
        ///登陆IP
        ///</summary>
        public string LoginRemoteIp{ get; set; }
        ///<summary>
        ///登陆地址 
        ///</summary>
        public string LoginLocation{ get; set; }
        ///<summary>
        ///开始时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        ///持续时间（秒）
        ///</summary>
        public string DurantTime{ get; set; }
        ///<summary>
        ///攻击IP
        ///</summary>
        public string AttackIp{ get; set; }
        ///<summary>
        ///可打印的payload
        ///</summary>
        public string PayloadPrintable{ get; set; }
        ///<summary>
        ///扫描工具
        ///</summary>
        public string ScanTool{ get; set; }
        ///<summary>
        ///账号信息
        ///</summary>
        public string AccountInfo{ get; set; }
        ///<summary>
        ///CVE
        ///</summary>
        public string Cve{ get; set; }
        ///<summary>
        ///漏洞组件
        ///</summary>
        public string AppModule{ get; set; }
        ///<summary>
        ///攻击取证
        ///</summary>
        public string PcapProof{ get; set; }
        ///<summary>
        ///威胁标签
        ///</summary>
        public string TrojanName{ get; set; }
        ///<summary>
        ///下载文件
        ///</summary>
        public string DownloadFile{ get; set; }
    }
}
