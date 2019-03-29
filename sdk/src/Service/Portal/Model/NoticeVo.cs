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


namespace JDCloudSDK.Portal.Model
{

    /// <summary>
    ///  noticeVo
    /// </summary>
    public class NoticeVo
    {

        ///<summary>
        /// uuid
        ///</summary>
        public int? Uuid{ get; set; }
        ///<summary>
        /// 主键id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 标题
        ///</summary>
        public string Title{ get; set; }
        ///<summary>
        /// 公告类型; 1:产品公告; 2:域名公告; 3:活动公告; 4:其他公告
        ///</summary>
        public byte Type{ get; set; }
        ///<summary>
        /// 置顶; 100:不置顶; 1;2;3;4;5:置顶位置(数字不能重复)
        ///</summary>
        public byte GoTop{ get; set; }
        ///<summary>
        /// 位置; 0:不显示; 1:左边; 2:左中; 3:中; 4:右中; 5:右
        ///</summary>
        public byte Inlet{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 修改时间
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
        ///<summary>
        /// 创建人
        ///</summary>
        public string CreatePin{ get; set; }
        ///<summary>
        /// 是否失效; 0:生效; 1:失效
        ///</summary>
        public byte Yn{ get; set; }
        ///<summary>
        /// 公告内容
        ///</summary>
        public string Content{ get; set; }
        ///<summary>
        /// 发送开始时间
        ///</summary>
        public DateTime? StartTime{ get; set; }
        ///<summary>
        /// 发送结束时间
        ///</summary>
        public DateTime? EndTime{ get; set; }
        ///<summary>
        /// 位置; 1:置顶; 2:入口
        ///</summary>
        public int? Site{ get; set; }
        ///<summary>
        /// 页码数
        ///</summary>
        public int? PageNum{ get; set; }
        ///<summary>
        /// 页显示数量
        ///</summary>
        public int? PageSize{ get; set; }
        ///<summary>
        /// 语言
        ///</summary>
        public string Lang{ get; set; }
        ///<summary>
        /// 中英文关联id
        ///</summary>
        public int? LangId{ get; set; }
        ///<summary>
        /// 查询时间
        ///</summary>
        public DateTime? Ts{ get; set; }
    }
}
