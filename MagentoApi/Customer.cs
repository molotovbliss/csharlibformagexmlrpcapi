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
    public class Customer
    {
        #region Private Member Variables
        private const string _customer_list = "customer.list";
        private const string _customer_create = "customer.create";
        private const string _customer_info = "customer.info";
        private const string _customer_update = "customer.update";
        private const string _customer_delete = "customer.delete";

        private string _firstname;
        private string _updated_at;
        private string _group_id;
        private string _suffix;
        private string _customer_id;
        private string _increment_id;
        private string _default_billing;
        private string _prefix;
        private string _store_id;
        private string _lastname;
        private string _taxvat;
        private string _password_hash;
        private string _default_shipping;
        private string _website_id;
        private string _middlename;
        private string _created_at;
        private string _email; 
        #endregion

        #region Private Properties
        
        #endregion

        #region Public Properties
        public string firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }
        public string group_id
        {
            get { return _group_id; }
            set { _group_id = value; }
        }
        public string suffix
        {
            get { return _suffix; }
            set { _suffix = value; }
        }
        public string customer_id
        {
            get { return _customer_id; }
            set { _customer_id = value; }
        }
        public string increment_id
        {
            get { return _increment_id; }
            set { _increment_id = value; }
        }
        public string default_billing
        {
            get { return _default_billing; }
            set { _default_billing = value; }
        }
        public string prefix
        {
            get { return _prefix; }
            set { _prefix = value; }
        }
        public string store_id
        {
            get { return _store_id; }
            set { _store_id = value; }
        }
        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public string taxvat
        {
            get { return _taxvat; }
            set { _taxvat = value; }
        }
        public string password_hash
        {
            get { return _password_hash; }
            set { _password_hash = value; }
        }
        public string default_shipping
        {
            get { return _default_shipping; }
            set { _default_shipping = value; }
        }
        public string website_id
        {
            get { return _website_id; }
            set { _website_id = value; }
        }
        public string middlename
        {
            get { return _middlename; }
            set { _middlename = value; }
        }
        public string created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        } 
        #endregion

        #region Constructor
        public Customer()
        {

        } 
        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        // method to get customers
        public static Customer[] List(string apiUrl, string sessionId, object[] args)
        {
            ICustomer proxy = (ICustomer)XmlRpcProxyGen.Create(typeof(ICustomer));
            proxy.Url = apiUrl;

            return proxy.List(sessionId, _customer_list, args);
        }

        // method to create a customer
        public static string Create(string apiUrl, string sessionId, Customer customer)
        {
            ICustomer proxy = (ICustomer)XmlRpcProxyGen.Create(typeof(ICustomer));
            proxy.Url = apiUrl;

            return proxy.Create(sessionId, _customer_create, new object[] { customer });
        }

        // method to get a customer
        public static Customer Info(string apiUrl, string sessionId, int customerId)
        {
            ICustomer proxy = (ICustomer)XmlRpcProxyGen.Create(typeof(ICustomer));
            proxy.Url = apiUrl;

            return proxy.Info(sessionId, _customer_info, new object[] { customerId });
        }

        // method to update a customer
        public static bool Update(string apiUrl, string sessionId, int customerid, Customer customer)
        {
            ICustomer proxy = (ICustomer)XmlRpcProxyGen.Create(typeof(ICustomer));
            proxy.Url = apiUrl;

            return proxy.Update(sessionId, _customer_update, new object[] { customerid, customer });
        }

        // method to delete a customer
        public static bool Delete(string apiUrl, string sessionId, int customerid)
        {
            ICustomer proxy = (ICustomer)XmlRpcProxyGen.Create(typeof(ICustomer));
            proxy.Url = apiUrl;

            return proxy.Update(sessionId, _customer_delete, new object[] { customerid });
        }
        #endregion

        #region Interfaces
        // interface to customers
        public interface ICustomer : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            Customer[] List(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            string Create(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            Customer Info(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Update(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Delete(string sessionId, string method, object[] args);
        } 
        #endregion
    }
}
