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
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class CategoryAttribute
    {
        #region Private Member Variables
        private const string _catalog_category_attribute_currentStore = "catalog_category_attribute.currentStore";
        private const string _catalog_category_attribute_list = "catalog_category_attribute.list";
        private const string _catalog_category_attribute_options = "catalog_category_attribute.options";

        private string _attribute_id;
        private string _code;
        private string _scope;
        private string _type;
        private string _required;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string attribute_id
        {
            get { return _attribute_id; }
            set { _attribute_id = value; }
        }
        public string code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string scope
        {
            get { return _scope; }
            set { _scope = value; }
        }
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string required
        {
            get { return _required; }
            set { _required = value; }
        }
        #endregion

        #region Constructor

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        // method to get category attributes
        public static string CurrentStore(string apiUrl, string sessionId)
        {
            ICategoryAttributes proxy = (ICategoryAttributes)XmlRpcProxyGen.Create(typeof(ICategoryAttributes));
            proxy.Url = apiUrl;

            return proxy.CurrentStore(sessionId, _catalog_category_attribute_currentStore);
        }
        public static string CurrentStore(string apiUrl, string sessionId, object[] args)
        {
            ICategoryAttributes proxy = (ICategoryAttributes)XmlRpcProxyGen.Create(typeof(ICategoryAttributes));
            proxy.Url = apiUrl;

            return proxy.CurrentStore(sessionId, _catalog_category_attribute_currentStore, args);
        }

        // method to list category attributes
        public static CategoryAttribute[] List(string apiUrl, string sessionId)
        {
            ICategoryAttributes proxy = (ICategoryAttributes)XmlRpcProxyGen.Create(typeof(ICategoryAttributes));
            proxy.Url = apiUrl;

            return proxy.List(sessionId, _catalog_category_attribute_list);
        }

        // method to get category attribute options
        public static CategoryAttributeOption[] Options(string apiUrl, string sessionId, object[] args)
        {
            ICategoryAttributes proxy = (ICategoryAttributes)XmlRpcProxyGen.Create(typeof(ICategoryAttributes));
            proxy.Url = apiUrl;

            return proxy.Options(sessionId, _catalog_category_attribute_options, args);
        }
        #endregion

        #region Interfaces
        // interface to category attributes
        public interface ICategoryAttributes : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            string CurrentStore(string sessionId, string method);
            [XmlRpcMethod("call")]
            string CurrentStore(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            CategoryAttribute[] List(string sessionId, string method);

            [XmlRpcMethod("call")]
            CategoryAttributeOption[] Options(string sessionId, string method, object[] args);
        }
        #endregion
    }
}
