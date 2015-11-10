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
    public class ProductImage
    {
        #region Private Member Variables
        private const string _catalog_product_attribute_media_currentStore = "catalog_product_attribute_media.currentStore";
        private const string _catalog_product_attribute_media_list = "catalog_product_attribute_media.list";
        private const string _catalog_product_attribute_media_info = "catalog_product_attribute_media.info";
        private const string _catalog_product_attribute_media_types = "catalog_product_attribute_media.types";
        private const string _catalog_product_attribute_media_create = "catalog_product_attribute_media.create";
        private const string _catalog_product_attribute_media_update = "catalog_product_attribute_media.update";
        private const string _catalog_product_attribute_media_remove = "catalog_product_attribute_media.remove";

        private string _label;
        private string _url;
        private string _exclude;
        private string _position;
        private string[] _types;
        private string _file;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string label
        {
            get { return _label; }
            set { _label = value; }
        }
        public string url
        {
            get { return _url; }
            set { _url = value; }
        }
        public string exclude
        {
            get { return _exclude; }
            set { _exclude = value; }
        }
        public string position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string[] types
        {
            get { return _types; }
            set { _types = value; }
        }
        public string file
        {
            get { return _file; }
            set { _file = value; }
        }
        #endregion

        #region Constructor

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        // method to get product image current store
        public static string CurrentStore(string apiUrl, string sessionId, object[] args)
        {
            IProductImage proxy = (IProductImage)XmlRpcProxyGen.Create(typeof(IProductImage));
            proxy.Url = apiUrl;

            return proxy.CurrentStore(sessionId, _catalog_product_attribute_media_currentStore, args);
        }

        // method to list product images
        public static ProductImage[] List(string apiUrl, string sessionId, object[] args)
        {
            IProductImage proxy = (IProductImage)XmlRpcProxyGen.Create(typeof(IProductImage));
            proxy.Url = apiUrl;

            return proxy.List(sessionId, _catalog_product_attribute_media_list, args);
        }

        // method to get product image
        public static ProductImage Info(string apiUrl, string sessionId, object[] args)
        {
            IProductImage proxy = (IProductImage)XmlRpcProxyGen.Create(typeof(IProductImage));
            proxy.Url = apiUrl;

            return proxy.Info(sessionId, _catalog_product_attribute_media_info, args);
        }

        // method to get product image types
        public static object[] Types(string apiUrl, string sessionId, object[] args)
        {
            IProductImage proxy = (IProductImage)XmlRpcProxyGen.Create(typeof(IProductImage));
            proxy.Url = apiUrl;

            return proxy.Types(sessionId, _catalog_product_attribute_media_types, args);
        }

        // method to create product image
        public static string Create(string apiUrl, string sessionId, object[] args)
        {
            IProductImage proxy = (IProductImage)XmlRpcProxyGen.Create(typeof(IProductImage));
            proxy.Url = apiUrl;

            return proxy.Create(sessionId, _catalog_product_attribute_media_create, args);
        }

        // method to update product image
        public static bool Update(string apiUrl, string sessionId, object[] args)
        {
            IProductImage proxy = (IProductImage)XmlRpcProxyGen.Create(typeof(IProductImage));
            proxy.Url = apiUrl;

            return proxy.Update(sessionId, _catalog_product_attribute_media_update, args);
        }

        // method to remove product image
        public static bool Remove(string apiUrl, string sessionId, object[] args)
        {
            IProductImage proxy = (IProductImage)XmlRpcProxyGen.Create(typeof(IProductImage));
            proxy.Url = apiUrl;

            return proxy.Remove(sessionId, _catalog_product_attribute_media_remove, args);
        }
        #endregion

        #region Interfaces
        // interface to product image
        public interface IProductImage : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            string CurrentStore(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            ProductImage[] List(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            ProductImage Info(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            object[] Types(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            string Create(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Update(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Remove(string sessionId, string method, object[] args);
        }
        #endregion
    }
}
