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
    public class Invoice
    {
        #region Private Member Variables
        private const string _sales_order_invoice_list = "sales_order_invoice.list";
        private const string _sales_order_invoice_info = "sales_order_invoice.info";
        private const string _sales_order_invoice_create = "sales_order_invoice.create";
        private const string _sales_order_invoice_addComment = "sales_order_invoice.addComment";
        private const string _sales_order_invoice_capture = "sales_order_invoice.capture";
        private const string _sales_order_invoice_void = "sales_order_invoice.void";
        private const string _sales_order_invoice_cancel = "sales_order_invoice.cancel";

        private string _billing_address_id;
        private string _invoice_id;
        private string _order_increment_id;
        private string _is_active;
        private string _order_currency_code;
        private string _parent_id;
        private string _store_id;
        private string _created_at;
        private string _increment_id;
        private string _updated_at;
        private string _billing_firstname;
        private string _order_created_at;
        private string _order_id;
        private string _billing_lastname;
        private string _state;
        private string _grand_total;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string billing_address_id
        {
            get { return _billing_address_id; }
            set { _billing_address_id = value; }
        }
        public string invoice_id
        {
            get { return _invoice_id; }
            set { _invoice_id = value; }
        }
        public string order_increment_id
        {
            get { return _order_increment_id; }
            set { _order_increment_id = value; }
        }
        public string is_active
        {
            get { return _is_active; }
            set { _is_active = value; }
        }
        public string order_currency_code
        {
            get { return _order_currency_code; }
            set { _order_currency_code = value; }
        }
        public string parent_id
        {
            get { return _parent_id; }
            set { _parent_id = value; }
        }
        public string store_id
        {
            get { return _store_id; }
            set { _store_id = value; }
        }
        public string created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        public string increment_id
        {
            get { return _increment_id; }
            set { _increment_id = value; }
        }
        public string updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }
        public string billing_firstname
        {
            get { return _billing_firstname; }
            set { _billing_firstname = value; }
        }
        public string order_created_at
        {
            get { return _order_created_at; }
            set { _order_created_at = value; }
        }
        public string order_id
        {
            get { return _order_id; }
            set { _order_id = value; }
        }
        public string billing_lastname
        {
            get { return _billing_lastname; }
            set { _billing_lastname = value; }
        }
        public string state
        {
            get { return _state; }
            set { _state = value; }
        }
        public string grand_total
        {
            get { return _grand_total; }
            set { _grand_total = value; }
        }
        #endregion

        #region Constructor

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        // method to list all invoice
        public static Invoice[] List(string apiUrl, string sessionId, object[] args)
        {
            IInvoice proxy = (IInvoice)XmlRpcProxyGen.Create(typeof(IInvoice));
            proxy.Url = apiUrl;

            return proxy.List(sessionId, _sales_order_invoice_list, args);
        }

        // method get the details of an invoice
        public static Invoice Info(string apiUrl, string sessionId, object[] args)
        {
            IInvoice proxy = (IInvoice)XmlRpcProxyGen.Create(typeof(IInvoice));
            proxy.Url = apiUrl;

            return proxy.Info(sessionId, _sales_order_invoice_info, args);
        }

        // method to create an invoice
        public static string Create(string apiUrl, string sessionId, object[] args)
        {
            IInvoice proxy = (IInvoice)XmlRpcProxyGen.Create(typeof(IInvoice));
            proxy.Url = apiUrl;

            return proxy.Create(sessionId, _sales_order_invoice_create, args);
        }

        // method to add a comment to an invoice
        public static bool AddComment(string apiUrl, string sessionId, object[] args)
        {
            IInvoice proxy = (IInvoice)XmlRpcProxyGen.Create(typeof(IInvoice));
            proxy.Url = apiUrl;

            return proxy.AddComment(sessionId, _sales_order_invoice_addComment, args);
        }

        // method to add capture an invoice
        public static bool Capture(string apiUrl, string sessionId, object[] args)
        {
            IInvoice proxy = (IInvoice)XmlRpcProxyGen.Create(typeof(IInvoice));
            proxy.Url = apiUrl;

            return proxy.Capture(sessionId, _sales_order_invoice_capture, args);
        }

        // method to void an invoice
        public static bool Void(string apiUrl, string sessionId, object[] args)
        {
            IInvoice proxy = (IInvoice)XmlRpcProxyGen.Create(typeof(IInvoice));
            proxy.Url = apiUrl;

            return proxy.Void(sessionId, _sales_order_invoice_void, args);
        }

        // method to cancel and invoice
        public static bool Cancel(string apiUrl, string sessionId, object[] args)
        {
            IInvoice proxy = (IInvoice)XmlRpcProxyGen.Create(typeof(IInvoice));
            proxy.Url = apiUrl;

            return proxy.Cancel(sessionId, _sales_order_invoice_cancel, args);
        }
        #endregion

        #region Interfaces
        // interface to invoices
        public interface IInvoice : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            Invoice[] List(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            Invoice Info(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            string Create(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool AddComment(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Capture(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Void(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Cancel(string sessionId, string method, object[] args);
        }
        #endregion
    }
}
