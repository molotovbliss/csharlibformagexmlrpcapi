/* 
MagentoApi CSharp Library
Copyright (c) 2009 ez.newsletter, LLC <ezmagento@ez-llc.com>
ez.newsletter - Advanced Targeted Email Marketing for Magento Store Owners
http://www.ez-llc.com/studio/site/eznewsletter/email-marketing-info-magento-customer-management.aspx
Contributions By:
	Keith Smyth keith@kkl.com.au

XML-RPC.NET library
Copyright (c) 2001-2006, Charles Cook <charlescook@cookcomputing.com>

Permission is hereby granted, free of charge, to any person 
obtaining a copy of this software and associated documentation 
files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, 
publish, distribute, sublicense, and/or sell copies of the Software, 
and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be 
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/

using System;
using CookComputing.XmlRpc;

namespace Ez.Newsletter.MagentoApi
{
    public class ProductTierPrice
    {
        #region Private Member Variables
        private const string _catalog_product_attribute_tier_price_info = "catalog_product_attribute_tier_price.info";
        private const string _catalog_product_attribute_tier_price_update = "catalog_product_attribute_tier_price.update";

        private string _customer_group_id;
        private string _qty;
        private string _price;
        private string _website;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string customer_group_id
        {
            get { return _customer_group_id; }
            set { _customer_group_id = value; }
        }
        public string qty
        {
            get { return _qty; }
            set { _qty = value; }
        }
        public string price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string website
        {
            get { return _website; }
            set { _website = value; }
        }
        #endregion

        #region Constructor

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        // method to get product tier prices
        public static ProductTierPrice[] List(string apiUrl, string sessionId, object[] args)
        {
            IProductTierPrice proxy = (IProductTierPrice)XmlRpcProxyGen.Create(typeof(IProductTierPrice));
            proxy.Url = apiUrl;

            return proxy.List(sessionId, _catalog_product_attribute_tier_price_info, args);
        }
        // method to get update tier prices
        public static bool Update(string apiUrl, string sessionId, object[] args)
        {
            IProductTierPrice proxy = (IProductTierPrice)XmlRpcProxyGen.Create(typeof(IProductTierPrice));
            proxy.Url = apiUrl;

            return proxy.Update(sessionId, _catalog_product_attribute_tier_price_update, args);
        }
        #endregion

        #region Interfaces
        // interface to product tier prices
        public interface IProductTierPrice : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            ProductTierPrice[] List(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Update(string sessionId, string method, object[] args);
        }
        #endregion
    }
}
