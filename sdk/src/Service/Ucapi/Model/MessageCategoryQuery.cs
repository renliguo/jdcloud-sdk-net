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
    /// messageCategoryQuery
    /// </summary>
    public class MessageCategoryQuery
    {

        ///<summary>
        ///主键
        ///</summary>
        public double? Id{ get; set; }
        ///<summary>
        ///父类别id
        ///</summary>
        public double? ParentId{ get; set; }
        ///<summary>
        ///分类
        ///</summary>
        public int? CategoryType{ get; set; }
        ///<summary>
        ///分类 code
        ///</summary>
        public string CategoryCode{ get; set; }
    }
}
