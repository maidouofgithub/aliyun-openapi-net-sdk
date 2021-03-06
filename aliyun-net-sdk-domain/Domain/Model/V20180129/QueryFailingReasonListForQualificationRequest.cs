/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class QueryFailingReasonListForQualificationRequest : RpcAcsRequest<QueryFailingReasonListForQualificationResponse>
    {
        public QueryFailingReasonListForQualificationRequest()
            : base("Domain", "2018-01-29", "QueryFailingReasonListForQualification")
        {
        }

		private string instanceId;

		private string userClientIp;

		private int? limit;

		private string lang;

		private string qualificationType;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string QualificationType
		{
			get
			{
				return qualificationType;
			}
			set	
			{
				qualificationType = value;
				DictionaryUtil.Add(QueryParameters, "QualificationType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryFailingReasonListForQualificationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryFailingReasonListForQualificationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
