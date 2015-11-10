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
    public class Category
    {
        #region Private Member Variables
        private const string _catalog_category_currentStore = "catalog_category.currentStore";
        private const string _catalog_category_tree = "catalog_category.tree";
        private const string _catalog_category_level = "catalog_category.level";
        private const string _catalog_category_info = "catalog_category.info";
        private const string _catalog_category_create = "catalog_category.create";
        private const string _catalog_category_update = "catalog_category.update";
        private const string _catalog_category_move = "catalog_category.move";
        private const string _catalog_category_delete = "catalog_category.delete";
        private const string _catalog_category_assignedProducts = "catalog_category.assignedProducts";
        private const string _catalog_category_assignProduct = "catalog_category.assignProduct";
        private const string _catalog_category_updateProduct = "catalog_category.updateProduct";
        private const string _catalog_category_removeProduct = "catalog_category.removeProduct";

        private string _display_mode;
        private string _custom_design;
        private string _all_children;
        private string _created_at;
        private string _meta_description;
        private string _category_id;
        private int _parent_id;
        private string _custom_design_from;
        private string _increment_id;
        private string _page_layout;
        private string _is_anchor;
        private string _custom_layout_update;
        private string _url_path;
        private string _path;
        private string _meta_keywords;
        private string _landing_page;
        private string _children;
        private string _meta_title;
        private string _custom_design_apply;
        private string _is_active;
        private string _description;
        private string _url_key;
        private string _name;
        private string _custom_design_to;
        private string _position;
        private string _level;
        private string _updated_at;
        private string _image;
        private string _path_in_store;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string display_mode
        {
            get { return _display_mode; }
            set { _display_mode = value; }
        }
        public string custom_design
        {
            get { return _custom_design; }
            set { _custom_design = value; }
        }
        public string all_children
        {
            get { return _all_children; }
            set { _all_children = value; }
        }
        public string created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        public string meta_description
        {
            get { return _meta_description; }
            set { _meta_description = value; }
        }
        public string category_id
        {
            get { return _category_id; }
            set { _category_id = value; }
        }
        public int parent_id
        {
            get { return _parent_id; }
            set { _parent_id = value; }
        }
        public string custom_design_from
        {
            get { return _custom_design_from; }
            set { _custom_design_from = value; }
        }
        public string increment_id
        {
            get { return _increment_id; }
            set { _increment_id = value; }
        }
        public string page_layout
        {
            get { return _page_layout; }
            set { _page_layout = value; }
        }
        public string is_anchor
        {
            get { return _is_anchor; }
            set { _is_anchor = value; }
        }
        public string custom_layout_update
        {
            get { return _custom_layout_update; }
            set { _custom_layout_update = value; }
        }
        public string url_path
        {
            get { return _url_path; }
            set { _url_path = value; }
        }
        public string path
        {
            get { return _path; }
            set { _path = value; }
        }
        public string meta_keywords
        {
            get { return _meta_keywords; }
            set { _meta_keywords = value; }
        }
        public string landing_page
        {
            get { return _landing_page; }
            set { _landing_page = value; }
        }
        public string children
        {
            get { return _children; }
            set { _children = value; }
        }
        public string meta_title
        {
            get { return _meta_title; }
            set { _meta_title = value; }
        }
        public string custom_design_apply
        {
            get { return _custom_design_apply; }
            set { _custom_design_apply = value; }
        }
        public string is_active
        {
            get { return _is_active; }
            set { _is_active = value; }
        }
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string url_key
        {
            get { return _url_key; }
            set { _url_key = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string custom_design_to
        {
            get { return _custom_design_to; }
            set { _custom_design_to = value; }
        }
        public string position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string level
        {
            get { return _level; }
            set { _level = value; }
        }
        public string updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }
        public string image
        {
            get { return _image; }
            set { _image = value; }
        }
        public string path_in_store
        {
            get { return _path_in_store; }
            set { _path_in_store = value; }
        }
        #endregion

        #region Constructor

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        // method to get countries
        public static string CurrentStore(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.CurrentStore(sessionId, _catalog_category_currentStore, args);
        }

        // method to get category tree
        public static object[] Tree(string apiUrl, string sessionId)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Tree(sessionId, _catalog_category_currentStore);
        }
        public static object[] Tree(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;
            proxy.UseIntTag = true;

            return proxy.Tree(sessionId, _catalog_category_currentStore, args);
        }
        public static object[] Tree(string apiUrl, string sessionId, object[] args, object[] args2)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Tree(sessionId, _catalog_category_currentStore, args, args2);
        }

        // method to get category level
        public static object[] Level(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Level(sessionId, _catalog_category_level, args);
        }
        public static object[] Level(string apiUrl, string sessionId, object[] args, object[] args2)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Level(sessionId, _catalog_category_level, args, args2);
        }
        public static object[] Level(string apiUrl, string sessionId, object[] args, object[] args2, object[] args3)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Level(sessionId, _catalog_category_level, args, args2, args3);
        }

        // method to get category info
        public static Category Info(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Info(sessionId, _catalog_category_info, args);
        }
        public static Category Info(string apiUrl, string sessionId, object[] args, object[] args2)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Info(sessionId, _catalog_category_info, args, args2);
        }
        public static Category Info(string apiUrl, string sessionId, object[] args, object[] args2, object[] args3)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Info(sessionId, _catalog_category_info, args, args2, args3);
        }

        // method to create category
        public static string Create(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;
            proxy.UseIntTag = true;

            return proxy.Create(sessionId, _catalog_category_create, args);
        }
        public static string Create(string apiUrl, string sessionId, object[] args, object[] args2)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;
            proxy.UseIntTag = true;

            return proxy.Create(sessionId, _catalog_category_create, args, args2);
        }

        // method to update category
        public static string Update(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;
            proxy.UseIntTag = true;

            return proxy.Update(sessionId, _catalog_category_create, args);
        }
        public static string Update(string apiUrl, string sessionId, object[] args, object[] args2)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;
            proxy.UseIntTag = true;

            return proxy.Update(sessionId, _catalog_category_create, args, args2);
        }

        // method to move category
        public static bool Move(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Move(sessionId, _catalog_category_move, args);
        }
        public static bool Move(string apiUrl, string sessionId, object[] args, object[] args2)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Move(sessionId, _catalog_category_create, args, args2);
        }

        // method to delete category
        public static bool Delete(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.Delete(sessionId, _catalog_category_delete, args);
        }

        // method to get category assigned products
        public static CategoryAssignedProduct[] AssignedProducts(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.AssignedProducts(sessionId, _catalog_category_assignedProducts, args);
        }

        // method to assign a product to a category
        public static bool AssignProduct(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.AssignProduct(sessionId, _catalog_category_assignProduct, args);
        }
        public static bool AssignProduct(string apiUrl, string sessionId, object[] args, object[] args2)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.AssignProduct(sessionId, _catalog_category_assignProduct, args, args2);
        }

        // method to move a product from one category to another
        public static bool UpdateProduct(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.UpdateProduct(sessionId, _catalog_category_updateProduct, args);
        }
        public static bool UpdateProduct(string apiUrl, string sessionId, object[] args, object[] args2)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.UpdateProduct(sessionId, _catalog_category_updateProduct, args, args2);
        }

        // method to remove product from category
        public static bool RemoveProduct(string apiUrl, string sessionId, object[] args)
        {
            ICategory proxy = (ICategory)XmlRpcProxyGen.Create(typeof(ICategory));
            proxy.Url = apiUrl;

            return proxy.RemoveProduct(sessionId, _catalog_category_removeProduct, args);
        }
        #endregion

        #region Interfaces
        // interface to categories
        public interface ICategory : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            string CurrentStore(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            object[] Tree(string sessionId, string method);
            [XmlRpcMethod("call")]
            object[] Tree(string sessionId, string method, object[] args);
            [XmlRpcMethod("call")]
            object[] Tree(string sessionId, string method, object[] args, object[] args2);

            [XmlRpcMethod("call")]
            object[] Level(string sessionId, string method, object[] args);
            [XmlRpcMethod("call")]
            object[] Level(string sessionId, string method, object[] args, object[] args2);
            [XmlRpcMethod("call")]
            object[] Level(string sessionId, string method, object[] args, object[] args2, object[] args3);

            [XmlRpcMethod("call")]
            Category Info(string sessionId, string method, object[] args);
            [XmlRpcMethod("call")]
            Category Info(string sessionId, string method, object[] args, object[] args2);
            [XmlRpcMethod("call")]
            Category Info(string sessionId, string method, object[] args, object[] args2, object[] args3);

            [XmlRpcMethod("call")]
            string Create(string sessionId, string method, object[] args);
            [XmlRpcMethod("call")]
            string Create(string sessionId, string method, object[] args, object[] args2);

            [XmlRpcMethod("call")]
            string Update(string sessionId, string method, object[] args);
            [XmlRpcMethod("call")]
            string Update(string sessionId, string method, object[] args, object[] args2);

            [XmlRpcMethod("call")]
            bool Move(string sessionId, string method, object[] args);
            [XmlRpcMethod("call")]
            bool Move(string sessionId, string method, object[] args, object[] args2);

            [XmlRpcMethod("call")]
            bool Delete(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            CategoryAssignedProduct[] AssignedProducts(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool AssignProduct(string sessionId, string method, object[] args);
            [XmlRpcMethod("call")]
            bool AssignProduct(string sessionId, string method, object[] args, object[] args2);

            [XmlRpcMethod("call")]
            bool UpdateProduct(string sessionId, string method, object[] args);
            [XmlRpcMethod("call")]
            bool UpdateProduct(string sessionId, string method, object[] args, object[] args2);

            [XmlRpcMethod("call")]
            bool RemoveProduct(string sessionId, string method, object[] args);
        }
        #endregion
    }
}
