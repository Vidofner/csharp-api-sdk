﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5466
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Currencies
	{

		private List<CurrencySubset> currencySubsetField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CurrencySubset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public List<CurrencySubset> CurrencySubset
		{
			get
			{
				return this.currencySubsetField;
			}
			set
			{
				this.currencySubsetField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class CurrencySubset
	{

		private string buyRateField;

		private string codeField;

		private string dateField;

		private string descriptionField;

		private string sellRateField;

		private string unitField;

		private string urlField;

		/// <remarks/>
		public string BuyRate
		{
			get
			{
				return this.buyRateField;
			}
			set
			{
				this.buyRateField = value;
			}
		}

		/// <remarks/>
		public string Code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
			}
		}

		/// <remarks/>
		public string Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}

		/// <remarks/>
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		public string SellRate
		{
			get
			{
				return this.sellRateField;
			}
			set
			{
				this.sellRateField = value;
			}
		}

		/// <remarks/>
		public string Unit
		{
			get
			{
				return this.unitField;
			}
			set
			{
				this.unitField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[ReadOnly(true)]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}
	}
}