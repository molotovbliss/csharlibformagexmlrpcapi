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
    public class ProductLink
    {
        #region Private Member Variables
        private const string _catalog_product_link_list = "catalog_product_link.list";
        private const string _catalog_product_link_assign = "catalog_product_link.assign";
        private const string _catalog_product_link_update = "catalog_product_link.update";
        private const string _catalog_product_link_remove = "catalog_product_link.remove";
        private const string _catalog_product_link_types = "catalog_product_link.types";
        private const string _catalog_product_link_attributes = "catalog_product_link.attributes";

        private string _type;
        private string _product_id;
        private string _sku;
        private string _position;
        private string _set;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }
        public string sku
        {
            get { return _sku; }
            set { _sku = value; }
        }
        public string position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string set
        {
            get { return _set; }
            set { _set = value; }
        }
        #endregion

        #region Constructor

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        // method to get product links
        public static ProductLink[] List(string apiUrl, string sessionId, object[] args)
        {
            IProductLinks proxy = (IProductLinks)XmlRpcProxyGen.Create(typeof(IProductLinks));
            proxy.Url = apiUrl;

            return proxy.List(sessionId, _catalog_product_link_list, args);
        }

        // method to assign product link
        public static bool Assign(string apiUrl, string sessionId, object[] args)
        {
            IProductLinks proxy = (IProductLinks)XmlRpcProxyGen.Create(typeof(IProductLinks));
            proxy.Url = apiUrl;

            return proxy.Assign(sessionId, _catalog_product_link_assign, args);
        }

        // method to update product link
        public static bool Update(string apiUrl, string sessionId, object[] args)
        {
            IProductLinks proxy = (IProductLinks)XmlRpcProxyGen.Create(typeof(IProductLinks));
            proxy.Url = apiUrl;

            return proxy.Update(sessionId, _catalog_product_link_update, args);
        }

        // method to remove product link
        public static bool Remove(string apiUrl, string sessionId, object[] args)
        {
            IProductLinks proxy = (IProductLinks)XmlRpcProxyGen.Create(typeof(IProductLinks));
            proxy.Url = apiUrl;

            return proxy.Remove(sessionId, _catalog_product_link_remove, args);
        }

        // method to gets product link types
        public static string[] Types(string apiUrl, string sessionId)
        {
            IProductLinks proxy = (IProductLinks)XmlRpcProxyGen.Create(typeof(IProductLinks));
            proxy.Url = apiUrl;

            return proxy.Types(sessionId, _catalog_product_link_types);
        }

        // method to gets product link attributes
        public static ProductLinkAttribute[] Attributes(string apiUrl, string sessionId, object[] args)
        {
            IProductLinks proxy = (IProductLinks)XmlRpcProxyGen.Create(typeof(IProductLinks));
            proxy.Url = apiUrl;

            return proxy.Attributes(sessionId, _catalog_product_link_attributes, args);
        }
        #endregion

        #region Interfaces
        // interface to product links
        public interface IProductLinks : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            ProductLink[] List(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Assign(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Update(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Remove(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            string[] Types(string sessionId, string method);

            [XmlRpcMethod("call")]
            ProductLinkAttribute[] Attributes(string sessionId, string method, object[] args);
        }
        #endregion
    }
}
