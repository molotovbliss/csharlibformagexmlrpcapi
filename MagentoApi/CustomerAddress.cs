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
    public class CustomerAddress
    {
        #region Private Member Variables
        private const string _customer_list = "customer_address.list";
        private const string _customer_create = "customer_address.create";
        private const string _customer_info = "customer_address.info";
        private const string _customer_update = "customer_address.update";
        private const string _customer_delete = "customer_address.delete";

        private string _city;
        private string _firstname;
        private string _updated_at;
        private string _suffix;
        private string _customer_id;
        private bool _is_default_shipping;
        private string _country_id;
        private string _increment_id;
        private string _company;
        private string _postcode;
        private string _prefix;
        private string _region;
        private string _lastname;
        private bool _is_default_billing;
        private string _fax;
        private string _street;
        private string _middlename;
        private string _telephone;
        private string _created_at;
        private string _region_id; 
        #endregion

        #region Private Properties
        
        #endregion

        #region Public Properties
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }
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
        public bool is_default_shipping
        {
            get { return _is_default_shipping; }
            set { _is_default_shipping = value; }
        }
        public string country_id
        {
            get { return _country_id; }
            set { _country_id = value; }
        }
        public string increment_id
        {
            get { return _increment_id; }
            set { _increment_id = value; }
        }
        public string company
        {
            get { return _company; }
            set { _company = value; }
        }
        public string postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
        public string prefix
        {
            get { return _prefix; }
            set { _prefix = value; }
        }
        public string region
        {
            get { return _region; }
            set { _region = value; }
        }
        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public bool is_default_billing
        {
            get { return _is_default_billing; }
            set { _is_default_billing = value; }
        }
        public string fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        public string street
        {
            get { return _street; }
            set { _street = value; }
        }
        public string middlename
        {
            get { return _middlename; }
            set { _middlename = value; }
        }
        public string telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        public string created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        public string region_id
        {
            get { return _region_id; }
            set { _region_id = value; }
        } 
        #endregion

        #region Constructor
        public CustomerAddress()
        {

        } 
        #endregion

        #region Private Methods
        
        #endregion

        #region Public Methods
        // method to get customers
        public static CustomerAddress[] List(string apiUrl, string sessionId, object[] args)
        {
            ICustomerAddress proxyCustomer = (ICustomerAddress)XmlRpcProxyGen.Create(typeof(ICustomerAddress));
            proxyCustomer.Url = apiUrl;

            return proxyCustomer.List(sessionId, _customer_list, args);
        }

        // method to create a customer address
        public static string Create(string apiUrl, string sessionId, CustomerAddress customer)
        {
            ICustomerAddress proxyCustomer = (ICustomerAddress)XmlRpcProxyGen.Create(typeof(ICustomerAddress));
            proxyCustomer.Url = apiUrl;

            return proxyCustomer.Create(sessionId, _customer_create, new object[] { customer });
        }

        // method to get a customer address
        public static CustomerAddress Info(string apiUrl, string sessionId, int customerAddressid)
        {
            ICustomerAddress proxyCustomer = (ICustomerAddress)XmlRpcProxyGen.Create(typeof(ICustomerAddress));
            proxyCustomer.Url = apiUrl;

            return proxyCustomer.Info(sessionId, _customer_info, new object[] { customerAddressid });
        }

        // method to update a customer address
        public static bool Update(string apiUrl, string sessionId, int customerAddressid, CustomerAddress customer)
        {
            ICustomerAddress proxyCustomer = (ICustomerAddress)XmlRpcProxyGen.Create(typeof(ICustomerAddress));
            proxyCustomer.Url = apiUrl;

            return proxyCustomer.Update(sessionId, _customer_update, new object[] { customerAddressid, customer });
        }

        // method to delete a customer address
        public static bool Delete(string apiUrl, string sessionId, int customerAddressid)
        {
            ICustomerAddress proxyCustomer = (ICustomerAddress)XmlRpcProxyGen.Create(typeof(ICustomerAddress));
            proxyCustomer.Url = apiUrl;

            return proxyCustomer.Update(sessionId, _customer_delete, new object[] { customerAddressid });
        }
        #endregion

        #region Interfaces
        // interface to customer address
        public interface ICustomerAddress : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            CustomerAddress[] List(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            string Create(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            CustomerAddress Info(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Update(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Delete(string sessionId, string method, object[] args);
        } 
        #endregion
    }
}
