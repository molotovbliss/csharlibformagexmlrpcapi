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
    public class Connection
    {
        #region Private Member Variables
        
        #endregion

        #region Private Properties
        
        #endregion

        #region Public Properties
        
        #endregion

        #region Constructor
        
        #endregion

        #region Private Methods
        
        #endregion

        #region Public Methods
        // method to login
        public static string Login(string apiUrl, string apiUser, string apiPass)
        {
            IConnection proxyLogin = (IConnection)XmlRpcProxyGen.Create(typeof(IConnection));
            proxyLogin.Url = apiUrl;
            return proxyLogin.Login(apiUser, apiPass);
        }
        public static string Login(string apiUrl, object[] args)
        {
            IConnection proxyLogin = (IConnection)XmlRpcProxyGen.Create(typeof(IConnection));
            proxyLogin.Url = apiUrl;
            return proxyLogin.Login(args);
        }

        // method to end session
        public static bool EndSession(string apiUrl, string sessionId)
        {
            IConnection proxyLogin = (IConnection)XmlRpcProxyGen.Create(typeof(IConnection));
            proxyLogin.Url = apiUrl;

            return proxyLogin.EndSesion(sessionId);
        }        
        #endregion

        #region Interfaces
        // interface to login
        public interface IConnection : IXmlRpcProxy
        {
            [XmlRpcMethod("login")]
            string Login(string user, string pass);

            [XmlRpcMethod("login")]
            string Login(object[] args);

            [XmlRpcMethod("endSession")]
            bool EndSesion(string sessionId);
        } 
        #endregion
    }
}
