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
    public class OrderProduct : Product
    {
        #region Private Member Variables
        private string _item_id;
        private string _order_id;
        private string _parent_item_id;
        private string _quote_item_id;
        private string _product_type;
        private string _product_options;
        private string _is_virtual;
        private string _applied_rule_ids;
        private string _additional_data;
        private string _free_shipping;
        private string _is_qty_decimal;
        private string _no_discount;
        private string _qty_backordered;
        private string _qty_canceled;
        private string _qty_invoiced;
        private string _qty_ordered;
        private string _qty_refunded;
        private string _qty_shipped;
        private string _base_price;
        private string _original_price;
        private string _base_original_price;
        private string _tax_percent;
        private string _tax_amount;
        private string _base_tax_amount;
        private string _tax_invoiced;
        private string _base_tax_invoiced;
        private string _discount_percent;
        private string _discount_amount;
        private string _base_discount_amount;
        private string _discount_invoiced;
        private string _base_discount_invoiced;
        private string _amount_refunded;
        private string _base_amount_refunded;
        private string _row_total;
        private string _base_row_total;
        private string _row_invoiced;
        private string _base_row_invoiced;
        private string _row_weight;
        private string _gift_message_id;
        private string _base_tax_before_discount;
        private string _tax_before_discount;
        private string _weee_tax_applied;
        private string _weee_tax_applied_amount;
        private string _weee_tax_applied_row_amount;
        private string _base_weee_tax_applied_amount;
        private string _base_weee_tax_applied_row_amount;
        private string _weee_tax_disposition;
        private string _weee_tax_row_disposition;
        private string _base_weee_tax_disposition;
        private string _base_weee_tax_row_disposition;
        private bool _has_children;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string order_id
        {
            get { return _order_id; }
            set { _order_id = value; }
        }
        public string parent_item_id
        {
            get { return _parent_item_id; }
            set { _parent_item_id = value; }
        }
        public string quote_item_id
        {
            get { return _quote_item_id; }
            set { _quote_item_id = value; }
        }
        public string product_type
        {
            get { return _product_type; }
            set { _product_type = value; }
        }
        public string product_options
        {
            get { return _product_options; }
            set { _product_options = value; }
        }
        public string is_virtual
        {
            get { return _is_virtual; }
            set { _is_virtual = value; }
        }
        public string applied_rule_ids
        {
            get { return _applied_rule_ids; }
            set { _applied_rule_ids = value; }
        }
        public string additional_data
        {
            get { return _additional_data; }
            set { _additional_data = value; }
        }
        public string free_shipping
        {
            get { return _free_shipping; }
            set { _free_shipping = value; }
        }
        public string is_qty_decimal
        {
            get { return _is_qty_decimal; }
            set { _is_qty_decimal = value; }
        }
        public string no_discount
        {
            get { return _no_discount; }
            set { _no_discount = value; }
        }
        public string qty_backordered
        {
            get { return _qty_backordered; }
            set { _qty_backordered = value; }
        }
        public string qty_canceled
        {
            get { return _qty_canceled; }
            set { _qty_canceled = value; }
        }
        public string qty_invoiced
        {
            get { return _qty_invoiced; }
            set { _qty_invoiced = value; }
        }
        public string qty_ordered
        {
            get { return _qty_ordered; }
            set { _qty_ordered = value; }
        }
        public string qty_refunded
        {
            get { return _qty_refunded; }
            set { _qty_refunded = value; }
        }
        public string qty_shipped
        {
            get { return _qty_shipped; }
            set { _qty_shipped = value; }
        }
        public string base_price
        {
            get { return _base_price; }
            set { _base_price = value; }
        }
        public string original_price
        {
            get { return _original_price; }
            set { _original_price = value; }
        }
        public string base_original_price
        {
            get { return _base_original_price; }
            set { _base_original_price = value; }
        }
        public string tax_percent
        {
            get { return _tax_percent; }
            set { _tax_percent = value; }
        }
        public string tax_amount
        {
            get { return _tax_amount; }
            set { _tax_amount = value; }
        }
        public string base_tax_amount
        {
            get { return _base_tax_amount; }
            set { _base_tax_amount = value; }
        }
        public string tax_invoiced
        {
            get { return _tax_invoiced; }
            set { _tax_invoiced = value; }
        }
        public string base_tax_invoiced
        {
            get { return _base_tax_invoiced; }
            set { _base_tax_invoiced = value; }
        }
        public string discount_percent
        {
            get { return _discount_percent; }
            set { _discount_percent = value; }
        }
        public string discount_amount
        {
            get { return _discount_amount; }
            set { _discount_amount = value; }
        }
        public string base_discount_amount
        {
            get { return _base_discount_amount; }
            set { _base_discount_amount = value; }
        }
        public string discount_invoiced
        {
            get { return _discount_invoiced; }
            set { _discount_invoiced = value; }
        }
        public string base_discount_invoiced
        {
            get { return _base_discount_invoiced; }
            set { _base_discount_invoiced = value; }
        }
        public string amount_refunded
        {
            get { return _amount_refunded; }
            set { _amount_refunded = value; }
        }
        public string base_amount_refunded
        {
            get { return _base_amount_refunded; }
            set { _base_amount_refunded = value; }
        }
        public string row_total
        {
            get { return _row_total; }
            set { _row_total = value; }
        }
        public string base_row_total
        {
            get { return _base_row_total; }
            set { _base_row_total = value; }
        }
        public string row_invoiced
        {
            get { return _row_invoiced; }
            set { _row_invoiced = value; }
        }
        public string base_row_invoiced
        {
            get { return _base_row_invoiced; }
            set { _base_row_invoiced = value; }
        }
        public string row_weight
        {
            get { return _row_weight; }
            set { _row_weight = value; }
        }
        public string gift_message_id
        {
            get { return _gift_message_id; }
            set { _gift_message_id = value; }
        }
        public string base_tax_before_discount
        {
            get { return _base_tax_before_discount; }
            set { _base_tax_before_discount = value; }
        }
        public string tax_before_discount
        {
            get { return _tax_before_discount; }
            set { _tax_before_discount = value; }
        }
        public string weee_tax_applied
        {
            get { return _weee_tax_applied; }
            set { _weee_tax_applied = value; }
        }
        public string weee_tax_applied_amount
        {
            get { return _weee_tax_applied_amount; }
            set { _weee_tax_applied_amount = value; }
        }
        public string weee_tax_applied_row_amount
        {
            get { return _weee_tax_applied_row_amount; }
            set { _weee_tax_applied_row_amount = value; }
        }
        public string base_weee_tax_applied_amount
        {
            get { return _base_weee_tax_applied_amount; }
            set { _base_weee_tax_applied_amount = value; }
        }
        public string base_weee_tax_applied_row_amount
        {
            get { return _base_weee_tax_applied_row_amount; }
            set { _base_weee_tax_applied_row_amount = value; }
        }
        public string weee_tax_disposition
        {
            get { return _weee_tax_disposition; }
            set { _weee_tax_disposition = value; }
        }
        public string weee_tax_row_disposition
        {
            get { return _weee_tax_row_disposition; }
            set { _weee_tax_row_disposition = value; }
        }
        public string base_weee_tax_disposition
        {
            get { return _base_weee_tax_disposition; }
            set { _base_weee_tax_disposition = value; }
        }
        public string base_weee_tax_row_disposition
        {
            get { return _base_weee_tax_row_disposition; }
            set { _base_weee_tax_row_disposition = value; }
        }
        public bool has_children
        {
            get { return _has_children; }
            set { _has_children = value; }
        }
        #endregion

        #region Constructor

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        #endregion

        #region Interfaces

        #endregion
    }
}
