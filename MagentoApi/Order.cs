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
    public class Order
    {
        #region Private Member Variables
        private const string _sales_order_list = "sales_order.list";
        private const string _sales_order_info = "sales_order.info";
        private const string _sales_order_addComment = "sales_order.addComment";
        private const string _sales_order_hold = "sales_order.hold";
        private const string _sales_order_unhold = "sales_order.unhold";
        private const string _sales_order_cancel = "sales_order.cancel";

        private string _shipping_method;
        private string _total_invoiced;
        private string _updated_at;
        private string _base_subtotal_refunded;
        private string _subtotal_refunded;
        private string _parent_id;
        private string _base_shipping_canceled;
        private string _tax_invoiced;
        private string _shipping_refunded;
        private string _store_id;
        private string _total_canceled;
        private string _order_id;
        private string _customer_email;
        private string _base_shipping_tax_amount;
        private string _base_to_order_rate;
        private string _quote_id;
        private string _tax_canceled;
        private string _base_tax_invoiced;
        private string _base_total_offline_refunded;
        private string _base_discount_refunded;
        private string _shipping_firstname;
        private string _shipping_canceled;
        private string _base_discount_invoiced;
        private string _base_total_qty_ordered;
        private string _discount_refunded;
        private string _increment_id;
        private string _billing_lastname;
        private string _base_total_paid;
        private string _customer_note_notify;
        private string _store_currency_code;
        private string _shipping_tax_amount;
        private string _base_discount_canceled;
        private string _base_subtotal_canceled;
        private string _discount_amount;
        private string _created_at;
        private string _billing_firstname;
        private string _base_total_canceled;
        private string _store_to_base_rate;
        private string _grand_total;
        private string _base_shipping_invoiced;
        private string _tax_refunded;
        private string _order_currency_code;
        private string _shipping_invoiced;
        private string _email_sent;
        private string _applied_rule_ids;
        private string _base_currency_code;
        private string _base_subtotal;
        private string _base_total_refunded;
        private string _global_currency_code;
        private string _total_refunded;
        private string _base_tax_amount;
        private string _subtotal_invoiced;
        private string _is_active;
        private string _base_discount_amount;
        private string _customer_group_id;
        private string _customer_id;
        private string _subtotal_canceled;
        private string _base_tax_refunded;
        private string _base_to_global_rate;
        private string _billing_address_id;
        private string _remote_ip;
        private string _base_tax_canceled;
        private string _shipping_amount;
        private string _base_shipping_tax_refunded;
        private string _is_virtual;
        private string _weight;
        private string _shipping_name;
        private string _billing_name;
        private string _shipping_address_id;
        private string _total_offline_refunded;
        private string _base_shipping_refunded;
        private string _customer_is_guest;
        private string _status;
        private string _state;
        private string _store_name;
        private string _store_to_order_rate;
        private string _base_total_online_refunded;
        private string _base_total_invoiced;
        private string _base_subtotal_invoiced;
        private string _total_paid;
        private string _discount_canceled;
        private string _total_qty_ordered;
        private string _shipping_tax_refunded;
        private string _total_online_refunded;
        private string _tax_amount;
        private string _discount_invoiced;
        private string _base_shipping_amount;
        private string _shipping_lastname;
        private string _shipping_description;
        private string _subtotal;
        private string _base_grand_total; 
        #endregion

        #region Private Properties
        
        #endregion

        #region Public Properties
        public string shipping_method
        {
            get { return _shipping_method; }
            set { _shipping_method = value; }
        }
        public string total_invoiced
        {
            get { return _total_invoiced; }
            set { _total_invoiced = value; }
        }
        public string updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }
        public string base_subtotal_refunded
        {
            get { return _base_subtotal_refunded; }
            set { _base_subtotal_refunded = value; }
        }
        public string subtotal_refunded
        {
            get { return _subtotal_refunded; }
            set { _subtotal_refunded = value; }
        }
        public string parent_id
        {
            get { return _parent_id; }
            set { _parent_id = value; }
        }
        public string base_shipping_canceled
        {
            get { return _base_shipping_canceled; }
            set { _base_shipping_canceled = value; }
        }
        public string tax_invoiced
        {
            get { return _tax_invoiced; }
            set { _tax_invoiced = value; }
        }
        public string shipping_refunded
        {
            get { return _shipping_refunded; }
            set { _shipping_refunded = value; }
        }
        public string store_id
        {
            get { return _store_id; }
            set { _store_id = value; }
        }
        public string total_canceled
        {
            get { return _total_canceled; }
            set { _total_canceled = value; }
        }
        public string order_id
        {
            get { return _order_id; }
            set { _order_id = value; }
        }
        public string customer_email
        {
            get { return _customer_email; }
            set { _customer_email = value; }
        }
        public string base_shipping_tax_amount
        {
            get { return _base_shipping_tax_amount; }
            set { _base_shipping_tax_amount = value; }
        }
        public string base_to_order_rate
        {
            get { return _base_to_order_rate; }
            set { _base_to_order_rate = value; }
        }
        public string quote_id
        {
            get { return _quote_id; }
            set { _quote_id = value; }
        }
        public string tax_canceled
        {
            get { return _tax_canceled; }
            set { _tax_canceled = value; }
        }
        public string base_tax_invoiced
        {
            get { return _base_tax_invoiced; }
            set { _base_tax_invoiced = value; }
        }
        public string base_total_offline_refunded
        {
            get { return _base_total_offline_refunded; }
            set { _base_total_offline_refunded = value; }
        }
        public string base_discount_refunded
        {
            get { return _base_discount_refunded; }
            set { _base_discount_refunded = value; }
        }
        public string shipping_firstname
        {
            get { return _shipping_firstname; }
            set { _shipping_firstname = value; }
        }
        public string shipping_canceled
        {
            get { return _shipping_canceled; }
            set { _shipping_canceled = value; }
        }
        public string base_discount_invoiced
        {
            get { return _base_discount_invoiced; }
            set { _base_discount_invoiced = value; }
        }
        public string base_total_qty_ordered
        {
            get { return _base_total_qty_ordered; }
            set { _base_total_qty_ordered = value; }
        }
        public string discount_refunded
        {
            get { return _discount_refunded; }
            set { _discount_refunded = value; }
        }
        public string increment_id
        {
            get { return _increment_id; }
            set { _increment_id = value; }
        }
        public string billing_lastname
        {
            get { return _billing_lastname; }
            set { _billing_lastname = value; }
        }
        public string base_total_paid
        {
            get { return _base_total_paid; }
            set { _base_total_paid = value; }
        }
        public string customer_note_notify
        {
            get { return _customer_note_notify; }
            set { _customer_note_notify = value; }
        }
        public string store_currency_code
        {
            get { return _store_currency_code; }
            set { _store_currency_code = value; }
        }
        public string shipping_tax_amount
        {
            get { return _shipping_tax_amount; }
            set { _shipping_tax_amount = value; }
        }
        public string base_discount_canceled
        {
            get { return _base_discount_canceled; }
            set { _base_discount_canceled = value; }
        }
        public string base_subtotal_canceled
        {
            get { return _base_subtotal_canceled; }
            set { _base_subtotal_canceled = value; }
        }
        public string discount_amount
        {
            get { return _discount_amount; }
            set { _discount_amount = value; }
        }
        public string created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        public string billing_firstname
        {
            get { return _billing_firstname; }
            set { _billing_firstname = value; }
        }
        public string base_total_canceled
        {
            get { return _base_total_canceled; }
            set { _base_total_canceled = value; }
        }
        public string store_to_base_rate
        {
            get { return _store_to_base_rate; }
            set { _store_to_base_rate = value; }
        }
        public string grand_total
        {
            get { return _grand_total; }
            set { _grand_total = value; }
        }
        public string base_shipping_invoiced
        {
            get { return _base_shipping_invoiced; }
            set { _base_shipping_invoiced = value; }
        }
        public string tax_refunded
        {
            get { return _tax_refunded; }
            set { _tax_refunded = value; }
        }
        public string order_currency_code
        {
            get { return _order_currency_code; }
            set { _order_currency_code = value; }
        }
        public string shipping_invoiced
        {
            get { return _shipping_invoiced; }
            set { _shipping_invoiced = value; }
        }
        public string email_sent
        {
            get { return _email_sent; }
            set { _email_sent = value; }
        }
        public string applied_rule_ids
        {
            get { return _applied_rule_ids; }
            set { _applied_rule_ids = value; }
        }
        public string base_currency_code
        {
            get { return _base_currency_code; }
            set { _base_currency_code = value; }
        }
        public string base_subtotal
        {
            get { return _base_subtotal; }
            set { _base_subtotal = value; }
        }
        public string base_total_refunded
        {
            get { return _base_total_refunded; }
            set { _base_total_refunded = value; }
        }
        public string global_currency_code
        {
            get { return _global_currency_code; }
            set { _global_currency_code = value; }
        }
        public string total_refunded
        {
            get { return _total_refunded; }
            set { _total_refunded = value; }
        }
        public string base_tax_amount
        {
            get { return _base_tax_amount; }
            set { _base_tax_amount = value; }
        }
        public string subtotal_invoiced
        {
            get { return _subtotal_invoiced; }
            set { _subtotal_invoiced = value; }
        }
        public string is_active
        {
            get { return _is_active; }
            set { _is_active = value; }
        }
        public string base_discount_amount
        {
            get { return _base_discount_amount; }
            set { _base_discount_amount = value; }
        }
        public string customer_group_id
        {
            get { return _customer_group_id; }
            set { _customer_group_id = value; }
        }
        public string customer_id
        {
            get { return _customer_id; }
            set { _customer_id = value; }
        }
        public string subtotal_canceled
        {
            get { return _subtotal_canceled; }
            set { _subtotal_canceled = value; }
        }
        public string base_tax_refunded
        {
            get { return _base_tax_refunded; }
            set { _base_tax_refunded = value; }
        }
        public string base_to_global_rate
        {
            get { return _base_to_global_rate; }
            set { _base_to_global_rate = value; }
        }
        public string billing_address_id
        {
            get { return _billing_address_id; }
            set { _billing_address_id = value; }
        }
        public string remote_ip
        {
            get { return _remote_ip; }
            set { _remote_ip = value; }
        }
        public string base_tax_canceled
        {
            get { return _base_tax_canceled; }
            set { _base_tax_canceled = value; }
        }
        public string shipping_amount
        {
            get { return _shipping_amount; }
            set { _shipping_amount = value; }
        }
        public string base_shipping_tax_refunded
        {
            get { return _base_shipping_tax_refunded; }
            set { _base_shipping_tax_refunded = value; }
        }
        public string is_virtual
        {
            get { return _is_virtual; }
            set { _is_virtual = value; }
        }
        public string weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string shipping_name
        {
            get { return _shipping_name; }
            set { _shipping_name = value; }
        }
        public string billing_name
        {
            get { return _billing_name; }
            set { _billing_name = value; }
        }
        public string shipping_address_id
        {
            get { return _shipping_address_id; }
            set { _shipping_address_id = value; }
        }
        public string total_offline_refunded
        {
            get { return _total_offline_refunded; }
            set { _total_offline_refunded = value; }
        }
        public string base_shipping_refunded
        {
            get { return _base_shipping_refunded; }
            set { _base_shipping_refunded = value; }
        }
        public string customer_is_guest
        {
            get { return _customer_is_guest; }
            set { _customer_is_guest = value; }
        }
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string state
        {
            get { return _state; }
            set { _state = value; }
        }
        public string store_name
        {
            get { return _store_name; }
            set { _store_name = value; }
        }
        public string store_to_order_rate
        {
            get { return _store_to_order_rate; }
            set { _store_to_order_rate = value; }
        }
        public string base_total_online_refunded
        {
            get { return _base_total_online_refunded; }
            set { _base_total_online_refunded = value; }
        }
        public string base_total_invoiced
        {
            get { return _base_total_invoiced; }
            set { _base_total_invoiced = value; }
        }
        public string base_subtotal_invoiced
        {
            get { return _base_subtotal_invoiced; }
            set { _base_subtotal_invoiced = value; }
        }
        public string total_paid
        {
            get { return _total_paid; }
            set { _total_paid = value; }
        }
        public string discount_canceled
        {
            get { return _discount_canceled; }
            set { _discount_canceled = value; }
        }
        public string total_qty_ordered
        {
            get { return _total_qty_ordered; }
            set { _total_qty_ordered = value; }
        }
        public string shipping_tax_refunded
        {
            get { return _shipping_tax_refunded; }
            set { _shipping_tax_refunded = value; }
        }
        public string total_online_refunded
        {
            get { return _total_online_refunded; }
            set { _total_online_refunded = value; }
        }
        public string tax_amount
        {
            get { return _tax_amount; }
            set { _tax_amount = value; }
        }
        public string discount_invoiced
        {
            get { return _discount_invoiced; }
            set { _discount_invoiced = value; }
        }
        public string base_shipping_amount
        {
            get { return _base_shipping_amount; }
            set { _base_shipping_amount = value; }
        }
        public string shipping_lastname
        {
            get { return _shipping_lastname; }
            set { _shipping_lastname = value; }
        }
        public string shipping_description
        {
            get { return _shipping_description; }
            set { _shipping_description = value; }
        }
        public string subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }
        public string base_grand_total
        {
            get { return _base_grand_total; }
            set { _base_grand_total = value; }
        } 
        #endregion

        #region Constructor
        
        #endregion

        #region Private Methods
        
        #endregion

        #region Public Methods
        // method to get orders
        public static Order[] List(string apiUrl, string sessionId, object[] args)
        {
            IOrder proxy = (IOrder)XmlRpcProxyGen.Create(typeof(IOrder));
            proxy.Url = apiUrl;

            return proxy.List(sessionId, _sales_order_list, args);
        }

        // method to get an order
        public static OrderInfo Info(string apiUrl, string sessionId, object[] args)
        {
            IOrder proxy = (IOrder)XmlRpcProxyGen.Create(typeof(IOrder));
            proxy.Url = apiUrl;
            return proxy.Info(sessionId, _sales_order_info, args);
        }

        // method to add comments to an order
        public static bool AddComment(string apiUrl, string sessionId, object[] args)
        {
            IOrder proxy = (IOrder)XmlRpcProxyGen.Create(typeof(IOrder));
            proxy.Url = apiUrl;
            return proxy.AddComment(sessionId, _sales_order_addComment, args);
        }

        // method to place an order on hold
        public static bool Hold(string apiUrl, string sessionId, object[] args)
        {
            IOrder proxy = (IOrder)XmlRpcProxyGen.Create(typeof(IOrder));
            proxy.Url = apiUrl;
            return proxy.Hold(sessionId, _sales_order_hold, args);
        }

        // method to take an order off hold
        public static bool Unhold(string apiUrl, string sessionId, object[] args)
        {
            IOrder proxy = (IOrder)XmlRpcProxyGen.Create(typeof(IOrder));
            proxy.Url = apiUrl;
            return proxy.Unhold(sessionId, _sales_order_unhold, args);
        }

        // method to cancel an order
        public static bool Cancel(string apiUrl, string sessionId, object[] args)
        {
            IOrder proxy = (IOrder)XmlRpcProxyGen.Create(typeof(IOrder));
            proxy.Url = apiUrl;
            return proxy.Cancel(sessionId, _sales_order_cancel, args);
        }
        #endregion

        #region Interfaces
        // interface to orders
        public interface IOrder : IXmlRpcProxy
        {
            [XmlRpcMethod("call")]
            Order[] List(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            OrderInfo Info(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool AddComment(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Hold(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Unhold(string sessionId, string method, object[] args);

            [XmlRpcMethod("call")]
            bool Cancel(string sessionId, string method, object[] args);
        } 
        #endregion
    }
}
