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
    public class ProductSpecialPrice
    {
        #region Private Member Variables
        private string _type;
        private string _product_id;
        private string _sku;
        private string[] _websites;
        private string _set;
        private string[] _categories;
        #endregion

        #region Private Properties

        #endregion

        #region Public Properties
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }
        public string sku
        {
            get { return _sku; }
            set { _sku = value; }
        }
        public string[] websites
        {
            get { return _websites; }
            set { _websites = value; }
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
