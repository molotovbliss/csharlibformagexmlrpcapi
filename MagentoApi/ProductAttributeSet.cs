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
    public class ProductAttributeSet
    {
        #region Private Member Variables
        private const string _catalog_product_attribute_set_list = "catalog_product_attribute_set.list";

        private string _name;
        private string _set_id;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string set_id
        {
            get { return _set_id; }
            set { _set_id = value; }
        }
        #endregion

        #region Constructor

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        // method to get countries
        public static ProductAttributeSet[] List(string apiUrl, string sessionId)
        {
            IProductAttributeSets proxy = (IProductAttributeSets)XmlRpcProxyGen.Create(typeof(IProductAttributeSets));
            proxy.Url = apiUrl;

            return proxy.List(sessionId, _catalog_product_attribute_set_list);
        }
        #endregion

        #region Interfaces
        // interface to countries
        public interface IProductAttributeSets : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            ProductAttributeSet[] List(string sessionId, string method);
        }
        #endregion
    }
}
