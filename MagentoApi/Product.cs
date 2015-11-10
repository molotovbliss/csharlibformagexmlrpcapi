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
    public class Product
    {
        #region Private Member Variables
        private const string _catalog_product_currentStore = "catalog_product.currentStore";
        private const string _catalog_product_list = "catalog_product.list";
        private const string _catalog_product_info = "catalog_product.info";
        private const string _catalog_product_create = "catalog_product.create";
        private const string _catalog_product_update = "catalog_product.update";
        private const string _catalog_product_setSpecialPrice = "catalog_product.setSpecialPrice";
        private const string _catalog_product_getSpecialPrice = "catalog_product.getSpecialPrice";
        private const string _catalog_product_delete = "catalog_product.delete";

        private string _custom_layout_update;
        private string _type;
        private string _special_from_date;
        private string _created_at;
        private string _status;
        private string _color;
        private string _custom_design_to;
        private string _options_container;
        private string _meta_description;
        private string[] _category_ids;
        private string _news_from_date;
        private string _in_depth;
        private string _description;
        private string _special_price;
        private string[] _tier_price;
        private string _activation_information;
        private string _custom_design_from;
        private string _model;
        private string _small_image_label;
        private string _visibility;
        private string _short_description;
        private string _required_options;
        private string _thumbnail_label;
        private string _url_key;
        private string _updated_at;
        private string _manufacturer;
        private string[] _websites;
        private string _image_label;
        private string _url_path;
        private string _custom_design;
        private string _meta_keyword;
        private string _has_options;
        private string _product_id;
        private string _old_id;
        private string _meta_title;
        private string _dimension;
        private string _tax_class_id;
        private string _special_to_date;
        private string _gift_message_available;
        private string _type_id;
        private string _cost;
        private string _news_to_date;
        private string _set;
        private string[] _categories;
        private string _enable_googlecheckout;
        private string _minimal_price;
        private string _sku;
        private string _name;
        private string _weight;
        private string _price;
        #endregion

        #region Private Properties
        
        #endregion

        #region Public Properties
        public string custom_layout_update
        {
            get { return _custom_layout_update; }
            set { _custom_layout_update = value; }
        }
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string special_from_date
        {
            get { return _special_from_date; }
            set { _special_from_date = value; }
        }
        public string created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string custom_design_to
        {
            get { return _custom_design_to; }
            set { _custom_design_to = value; }
        }
        public string options_container
        {
            get { return _options_container; }
            set { _options_container = value; }
        }
        public string meta_description
        {
            get { return _meta_description; }
            set { _meta_description = value; }
        }
        public string[] category_ids
        {
            get { return _category_ids; }
            set { _category_ids = value; }
        }
        public string news_from_date
        {
            get { return _news_from_date; }
            set { _news_from_date = value; }
        }
        public string in_depth
        {
            get { return _in_depth; }
            set { _in_depth = value; }
        }
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string special_price
        {
            get { return _special_price; }
            set { _special_price = value; }
        }
        public string[] tier_price
        {
            get { return _tier_price; }
            set { _tier_price = value; }
        }
        public string activation_information
        {
            get { return _activation_information; }
            set { _activation_information = value; }
        }
        public string custom_design_from
        {
            get { return _custom_design_from; }
            set { _custom_design_from = value; }
        }
        public string model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string small_image_label
        {
            get { return _small_image_label; }
            set { _small_image_label = value; }
        }
        public string visibility
        {
            get { return _visibility; }
            set { _visibility = value; }
        }
        public string short_description
        {
            get { return _short_description; }
            set { _short_description = value; }
        }
        public string required_options
        {
            get { return _required_options; }
            set { _required_options = value; }
        }
        public string thumbnail_label
        {
            get { return _thumbnail_label; }
            set { _thumbnail_label = value; }
        }
        public string url_key
        {
            get { return _url_key; }
            set { _url_key = value; }
        }
        public string updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }
        public string manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        public string[] websites
        {
            get { return _websites; }
            set { _websites = value; }
        }
        public string image_label
        {
            get { return _image_label; }
            set { _image_label = value; }
        }
        public string url_path
        {
            get { return _url_path; }
            set { _url_path = value; }
        }
        public string custom_design
        {
            get { return _custom_design; }
            set { _custom_design = value; }
        }
        public string meta_keyword
        {
            get { return _meta_keyword; }
            set { _meta_keyword = value; }
        }
        public string has_options
        {
            get { return _has_options; }
            set { _has_options = value; }
        }
        public string product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }
        public string old_id
        {
            get { return _old_id; }
            set { _old_id = value; }
        }
        public string meta_title
        {
            get { return _meta_title; }
            set { _meta_title = value; }
        }
        public string dimension
        {
            get { return _dimension; }
            set { _dimension = value; }
        }
        public string tax_class_id
        {
            get { return _tax_class_id; }
            set { _tax_class_id = value; }
        }
        public string special_to_date
        {
            get { return _special_to_date; }
            set { _special_to_date = value; }
        }
        public string gift_message_available
        {
            get { return _gift_message_available; }
            set { _gift_message_available = value; }
        }
        public string type_id
        {
            get { return _type_id; }
            set { _type_id = value; }
        }
        public string cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        public string news_to_date
        {
            get { return _news_to_date; }
            set { _news_to_date = value; }
        }
        public string set
        {
            get { return _set; }
            set { _set = value; }
        }
        public string[] categories
        {
            get { return _categories; }
            set { _categories = value; }
        }
        public string enable_googlecheckout
        {
            get { return _enable_googlecheckout; }
            set { _enable_googlecheckout = value; }
        }
        public string minimal_price
        {
            get { return _minimal_price; }
            set { _minimal_price = value; }
        }
        public string sku
        {
            get { return _sku; }
            set { _sku = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string price
        {
            get { return _price; }
            set { _price = value; }
        } 
        #endregion

        #region Constructor
        public Product()
        {

        }
        #endregion

        #region Private Methods
        
        #endregion

        #region Public Methods
        // method to get current store view
        public static string CurrentStore(string apiUrl, string sessionId)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.CurrentStore(sessionId, _catalog_product_currentStore);
        }
        public static string CurrentStore(string apiUrl, string sessionId, object[] args)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.CurrentStore(sessionId, _catalog_product_currentStore, args);
        }
        
        // method list products
        public static Product[] List(string apiUrl, string sessionId)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.List(sessionId, _catalog_product_list);
        }
        public static Product[] List(string apiUrl, string sessionId, object[] args)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.List(sessionId, _catalog_product_list, args);
        }

        // method to get a product
        public static Product Info(string apiUrl, string sessionId, object[] args)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.Info(sessionId, _catalog_product_info, args);
        }

        // method to create a product
        public static string Create(string apiUrl, string sessionId, object[] args)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.Create(sessionId, _catalog_product_create, args);
        }

        // method to update a product
        public static bool Update(string apiUrl, string sessionId, object[] args)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.Update(sessionId, _catalog_product_update, args);
        }

        // method to set a products special price
        public static bool SetSpecialPrice(string apiUrl, string sessionId, object[] args)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.SetSpecialPrice(sessionId, _catalog_product_setSpecialPrice, args);
        }

        // method to get a products special price
        public static ProductSpecialPrice GetSpecialPrice(string apiUrl, string sessionId, object[] args)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.GetSpecialPrice(sessionId, _catalog_product_getSpecialPrice, args);
        }

        // method to delete a product
        public static bool Delete(string apiUrl, string sessionId, object[] args)
        {
            IProduct prox = (IProduct)XmlRpcProxyGen.Create(typeof(IProduct));
            prox.Url = apiUrl;
            return prox.Delete(sessionId, _catalog_product_delete, args);
        }
        #endregion

        #region Interfaces
        // interface to products
        public interface IProduct : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            string CurrentStore(string sessionId, string method);
            [XmlRpcMethod("call")]
            string CurrentStore(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            Product[] List(string sessionId, string method);
            [XmlRpcMethod("call")]
            Product[] List(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            Product Info(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            string Create(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Update(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool SetSpecialPrice(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            ProductSpecialPrice GetSpecialPrice(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Delete(string sessionId, string method, object[] args);
        } 
        #endregion
    }
}
