#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using Cimsco.EntityDataModel;

namespace Cimsco.EntityDataModel	
{
	public partial class AspNetUserClaim
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private string _userId;
		public virtual string UserId
		{
			get
			{
				return this._userId;
			}
			set
			{
				this._userId = value;
			}
		}
		
		private string _claimType;
		public virtual string ClaimType
		{
			get
			{
				return this._claimType;
			}
			set
			{
				this._claimType = value;
			}
		}
		
		private string _claimValue;
		public virtual string ClaimValue
		{
			get
			{
				return this._claimValue;
			}
			set
			{
				this._claimValue = value;
			}
		}
		
		private AspNetUser _aspNetUser;
		public virtual AspNetUser AspNetUser
		{
			get
			{
				return this._aspNetUser;
			}
			set
			{
				this._aspNetUser = value;
			}
		}
		
	}
}
#pragma warning restore 1591
