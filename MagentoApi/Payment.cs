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
    public class Payment
    {
        #region Private Member Variables
        private string _increment_id;
        private string _parent_id;
        private string _store_id;
        private string _created_at;
        private string _updated_at;
        private string _is_active;
        private string _amount_ordered;
        private string _base_amount_ordered;
        private string _shipping_amount;
        private string _base_shipping_amount;
        private string _amount_paid;
        private string _base_amount_paid;
        private string _shipping_captured;
        private string _base_shipping_captured;
        private string _cc_exp_month;
        private string _cc_exp_year;
        private string _method;
        private string _po_number;
        private string _cc_type;
        private string _cc_number_enc;
        private string _cc_last4;
        private string _cc_owner;
        private string _cc_ss_start_month;
        private string _cc_ss_start_year;
        private string _payment_id;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string increment_id
        {
            get { return _increment_id; }
            set { _increment_id = value; }
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
        public string updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }
        public string is_active
        {
            get { return _is_active; }
            set { _is_active = value; }
        }
        public string amount_ordered
        {
            get { return _amount_ordered; }
            set { _amount_ordered = value; }
        }
        public string base_amount_ordered
        {
            get { return _base_amount_ordered; }
            set { _base_amount_ordered = value; }
        }
        public string shipping_amount
        {
            get { return _shipping_amount; }
            set { _shipping_amount = value; }
        }
        public string base_shipping_amount
        {
            get { return _base_shipping_amount; }
            set { _base_shipping_amount = value; }
        }
        public string amount_paid
        {
            get { return _amount_paid; }
            set { _amount_paid = value; }
        }
        public string base_amount_paid
        {
            get { return _base_amount_paid; }
            set { _base_amount_paid = value; }
        }
        public string shipping_captured
        {
            get { return _shipping_captured; }
            set { _shipping_captured = value; }
        }
        public string base_shipping_captured
        {
            get { return _base_shipping_captured; }
            set { _base_shipping_captured = value; }
        }
        public string cc_exp_month
        {
            get { return _cc_exp_month; }
            set { _cc_exp_month = value; }
        }
        public string cc_exp_year
        {
            get { return _cc_exp_year; }
            set { _cc_exp_year = value; }
        }
        public string method
        {
            get { return _method; }
            set { _method = value; }
        }
        public string po_number
        {
            get { return _po_number; }
            set { _po_number = value; }
        }
        public string cc_type
        {
            get { return _cc_type; }
            set { _cc_type = value; }
        }
        public string cc_number_enc
        {
            get { return _cc_number_enc; }
            set { _cc_number_enc = value; }
        }
        public string cc_last4
        {
            get { return _cc_last4; }
            set { _cc_last4 = value; }
        }
        public string cc_owner
        {
            get { return _cc_owner; }
            set { _cc_owner = value; }
        }
        public string cc_ss_start_month
        {
            get { return _cc_ss_start_month; }
            set { _cc_ss_start_month = value; }
        }
        public string cc_ss_start_year
        {
            get { return _cc_ss_start_year; }
            set { _cc_ss_start_year = value; }
        }
        public string payment_id
        {
            get { return _payment_id; }
            set { _payment_id = value; }
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