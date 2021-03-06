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
using Aliyun.Acs.imm;
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class UpdateFaceGroupRequest : RpcAcsRequest<UpdateFaceGroupResponse>
    {
        public UpdateFaceGroupRequest()
            : base("imm", "2017-09-06", "UpdateFaceGroup")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string project;

		private string externalId;

		private string groupId;

		private string remarksB;

		private string remarksA;

		private string groupName;

		private string remarksArrayA;

		private string remarksArrayB;

		private string remarksD;

		private string remarksC;

		private string setId;

		private string groupCoverFaceId;

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string ExternalId
		{
			get
			{
				return externalId;
			}
			set	
			{
				externalId = value;
				DictionaryUtil.Add(QueryParameters, "ExternalId", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string RemarksB
		{
			get
			{
				return remarksB;
			}
			set	
			{
				remarksB = value;
				DictionaryUtil.Add(QueryParameters, "RemarksB", value);
			}
		}

		public string RemarksA
		{
			get
			{
				return remarksA;
			}
			set	
			{
				remarksA = value;
				DictionaryUtil.Add(QueryParameters, "RemarksA", value);
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
				DictionaryUtil.Add(QueryParameters, "GroupName", value);
			}
		}

		public string RemarksArrayA
		{
			get
			{
				return remarksArrayA;
			}
			set	
			{
				remarksArrayA = value;
				DictionaryUtil.Add(QueryParameters, "RemarksArrayA", value);
			}
		}

		public string RemarksArrayB
		{
			get
			{
				return remarksArrayB;
			}
			set	
			{
				remarksArrayB = value;
				DictionaryUtil.Add(QueryParameters, "RemarksArrayB", value);
			}
		}

		public string RemarksD
		{
			get
			{
				return remarksD;
			}
			set	
			{
				remarksD = value;
				DictionaryUtil.Add(QueryParameters, "RemarksD", value);
			}
		}

		public string RemarksC
		{
			get
			{
				return remarksC;
			}
			set	
			{
				remarksC = value;
				DictionaryUtil.Add(QueryParameters, "RemarksC", value);
			}
		}

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
				DictionaryUtil.Add(QueryParameters, "SetId", value);
			}
		}

		public string GroupCoverFaceId
		{
			get
			{
				return groupCoverFaceId;
			}
			set	
			{
				groupCoverFaceId = value;
				DictionaryUtil.Add(QueryParameters, "GroupCoverFaceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateFaceGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateFaceGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
