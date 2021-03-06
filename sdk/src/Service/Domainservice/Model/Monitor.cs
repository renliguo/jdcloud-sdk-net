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


namespace JDCloudSDK.Domainservice.Model
{

    /// <summary>
    ///  monitor
    /// </summary>
    public class Monitor
    {

        ///<summary>
        /// 连续几次触发报警
        ///</summary>
        public int? AlarmLimit{ get; set; }
        ///<summary>
        /// 现在是否可以恢复
        ///</summary>
        public bool CanRecover{ get; set; }
        ///<summary>
        /// 现在是否可以切换
        ///</summary>
        public bool CanSwitch{ get; set; }
        ///<summary>
        /// 机房探测点的集合
        ///</summary>
        public string Clusters{ get; set; }
        ///<summary>
        /// 主域名
        ///</summary>
        public string DomainName{ get; set; }
        ///<summary>
        /// 主机状态，0正常，1异常
        ///</summary>
        public int? HostStatus{ get; set; }
        ///<summary>
        /// 监控对象
        ///</summary>
        public string HostValue{ get; set; }
        ///<summary>
        /// 监控项ID
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 备用地址1
        ///</summary>
        public string IpBackup01{ get; set; }
        ///<summary>
        /// 备用地址1的状态，0正常，1异常
        ///</summary>
        public int? IpBackup01Status{ get; set; }
        ///<summary>
        /// 备用地址1的类型，1为ip 2为域名
        ///</summary>
        public int? IpBackup01Type{ get; set; }
        ///<summary>
        /// 备用地址2
        ///</summary>
        public string IpBackup02{ get; set; }
        ///<summary>
        /// 备用地址2的状态，0正常，1异常
        ///</summary>
        public int? IpBackup02Status{ get; set; }
        ///<summary>
        /// 备用地址1的类型，1为ip 2为域名
        ///</summary>
        public int? IpBackup02Type{ get; set; }
        ///<summary>
        /// 手动切换的地址
        ///</summary>
        public string ManualBackup{ get; set; }
        ///<summary>
        /// 手动切换的地址的状态，0正常，1异常
        ///</summary>
        public int? ManualBackupStatus{ get; set; }
        ///<summary>
        /// 手动切换的地址的类型，1为ip 2为域名
        ///</summary>
        public int? ManualBackupType{ get; set; }
        ///<summary>
        /// 监控状况 开启监控 2，暂停监控 4
        ///</summary>
        public int? MonitorEnable{ get; set; }
        ///<summary>
        /// 监控频率，单位秒
        ///</summary>
        public int? MonitorFreq{ get; set; }
        ///<summary>
        /// 监控端口
        ///</summary>
        public int? MonitorPort{ get; set; }
        ///<summary>
        /// 不做任何修改0，强制暂停解析记录1，自动切换到备用地址2
        ///</summary>
        public int? MonitorRule{ get; set; }
        ///<summary>
        /// 监控路径
        ///</summary>
        public string MonitorUri{ get; set; }
        ///<summary>
        /// 邮箱地址
        ///</summary>
        public string NotifyEmail{ get; set; }
        ///<summary>
        /// 不发送邮件0， 发送邮件1
        ///</summary>
        public int? NotifyEmailEnable{ get; set; }
        ///<summary>
        /// 不发送通知栏 0， 发送通知栏 1
        ///</summary>
        public int? NotifyMsgBarEnable{ get; set; }
        ///<summary>
        /// 手机号码
        ///</summary>
        public string NotifySms{ get; set; }
        ///<summary>
        /// 不发送短信 0， 发送短信 1
        ///</summary>
        public int? NotifySmsEnable{ get; set; }
        ///<summary>
        /// http协议:0，https协议:1
        ///</summary>
        public int? Protocol{ get; set; }
        ///<summary>
        /// 自动恢复:0 手动恢复:1
        ///</summary>
        public int? StopRecoverRule{ get; set; }
        ///<summary>
        /// 子域名
        ///</summary>
        public string SubDomainName{ get; set; }
        ///<summary>
        /// 自动恢复至主host:0 手动恢复至主host:1
        ///</summary>
        public int? SwitchRecoverRule{ get; set; }
        ///<summary>
        /// 1为A记录，2为CNAME
        ///</summary>
        public int? Type{ get; set; }
        ///<summary>
        /// 使用记录，host_value 0，ip_backup_01 1，ip_backup_02 2，cname_backup 3
        ///</summary>
        public int? UsedType{ get; set; }
        ///<summary>
        /// 备用地址及其状态列表
        ///</summary>
        public List<BackupAddressesInfo> BackupAddressList{ get; set; }
        ///<summary>
        /// 探测请求携带自定义头域及其域值列表
        ///</summary>
        public List<HttpHeader> RequestHeaders{ get; set; }
        ///<summary>
        /// 探测响应Body体中包含的字符串
        ///</summary>
        public string ResponseBodyMatch{ get; set; }
        ///<summary>
        /// 探测响应码范围列表
        ///</summary>
        public List<HttpResponseCodeRange> ResponseCodeRanges{ get; set; }
        ///<summary>
        /// 正在使用的有效解析地址
        ///</summary>
        public string EffectAddr{ get; set; }
    }
}
