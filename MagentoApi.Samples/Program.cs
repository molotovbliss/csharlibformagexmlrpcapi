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
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using CookComputing.XmlRpc;

namespace Ez.Newsletter.MagentoApi
{
    public class Samples
    {
        public static void Main(string[] args)
        {
            // api settings
            string apiUrl = "http://www.eznewsletterllc.com/magento/api/xmlrpc";
            string apiUser = "eznewsletter";
            string apiPass = "123456";

            // login (make sure you have user and role assigned in magento admin)
            string sessionId = Connection.Login(apiUrl, apiUser, apiPass);
            
            //string sessionId = Connection.Login(apiUrl, new object[] { apiUser, apiPass });
            Console.WriteLine("Authenticated with Session ID " + sessionId);

            #region Customer Examples
            //// create a new customer
            //Customer myCustomerCreated = new Customer();
            //myCustomerCreated.email = Guid.NewGuid().ToString() + "@eznewsletterllc.com";
            //string myCustomerCreatedId = Customer.Create(apiUrl, sessionId, myCustomerCreated);

            //// update the newly created customer
            //myCustomerCreated.firstname = "updated name at " + System.DateTime.Now.ToString();
            //bool wasUpdated = Customer.Update(apiUrl, sessionId, Convert.ToInt32(myCustomerCreatedId), myCustomerCreated);

            //// get the newly create customer info
            //Customer myCustomerCreatedInfo = new Customer();
            //myCustomerCreatedInfo = Customer.Info(apiUrl, sessionId, Convert.ToInt32(myCustomerCreatedId));
            //Console.WriteLine(myCustomerCreatedInfo.firstname);

            //// delete the newly created customer
            //bool wasDeleted = Customer.Delete(apiUrl, sessionId, Convert.ToInt32(myCustomerCreatedId));

            //// list all customers
            //Customer[] myCustomers = MagentoApi.Customer.List(apiUrl, sessionId, new string[] { });
            //foreach (Customer myCustomer in myCustomers)
            //{
            //    Console.WriteLine(myCustomer.firstname);

            //    // list all addresses for the customer
            //    CustomerAddress[] myCustomerAddresses = MagentoApi.CustomerAddress.GetCustomerAddresses(apiUrl, sessionId, Convert.ToInt32(myCustomer.customer_id));
            //    foreach (CustomerAddress myCustomerAddress in myCustomerAddresses)
            //    {
            //        Console.WriteLine(myCustomerAddress.street);
            //    }
            //} 
            #endregion

            #region Customer Group Examples

            //CustomerGroups[] myCustomerGroups = CustomerGroups.List(apiUrl, sessionId, new object[] { });
            //foreach (CustomerGroups myCustomerGroup in myCustomerGroups)
            //{
            //    Console.WriteLine(myCustomerGroup.customer_group_code);
            //}

            #endregion

            #region Customer Address Examples

            //// create a new customer address
            //CustomerAddress myCustomerAddressCreated = new CustomerAddress();
            //myCustomerAddressCreated.firstname = "new addy fname";
            //myCustomerAddressCreated.company = "new addy company";
            //string myCustomerAddressId = CustomerAddress.Create(apiUrl, sessionId, myCustomerAddressCreated);

            //// update a customer address
            //bool wasUpdated = CustomerAddress.Update(apiUrl, sessionId, Convert.ToInt32(myCustomerAddressId), myCustomerAddressCreated);

            //// get the customer address info
            //CustomerAddress myNewCustomerAddress = CustomerAddress.Info(apiUrl, sessionId, Convert.ToInt32(myCustomerAddressId));
            //Console.WriteLine(myNewCustomerAddress.company);

            //// delete the newly create address
            //CustomerAddress.Delete(apiUrl, sessionId, Convert.ToInt32(myCustomerAddressId));

            //// list all addresses
            //CustomerAddress[] myCustomerAddresses = CustomerAddress.List(apiUrl, sessionId, new object[] { });
            //foreach (CustomerAddress myCustomerAddress in myCustomerAddresses)
            //{
            //    Console.WriteLine(myCustomerAddress.company);
            //}

            #endregion

            #region Country Examples

            //Country[] myCountries = Country.List(apiUrl, sessionId, new object[] { });
            //foreach (Country myCountry in myCountries)
            //{
            //    Console.WriteLine(myCountry.name);
            //}

            #endregion

            #region Region Examples

            //Region[] myRegions = Region.List(apiUrl, sessionId, new object[] { "US" });
            //foreach (Region myRegion in myRegions)
            //{
            //    Console.WriteLine(myRegion.name);
            //}

            #endregion

            #region Category Examples

            //// get the current store (returns string instead of int)
            //string myCategoryCurrentStore = Category.CurrentStore(apiUrl, sessionId, new object[] { });
            //Console.WriteLine(myCategoryCurrentStore);

            //// get the tree (does not always return array)
            //object[] myCategoryTree = Category.Tree(apiUrl, sessionId);
            //Utils.StructDiscovery(myCategoryTree);

            //// get the level
            //object[] myCategoryLevel = Category.Level(apiUrl, sessionId, new object[] { 1 });
            //Utils.StructDiscovery(myCategoryLevel);

            // get the info
            //Category myCategoryInfo = Category.Info(apiUrl, sessionId, new object[] { 1 });
            //Console.WriteLine(myCategoryInfo.name);

            //// create a category
            //Category myCategory = new Category();
            //myCategory.name = "newly created category";
            //string myCategoryId = Category.Create(apiUrl, sessionId, new object[] { 1, myCategory });
            //Console.WriteLine("Category created with id : {0}", myCategoryId);

            //// update a category (docs say bool returned, but string instead)
            //myCategory.name = "newly updated/created category";
            //string wasCategoryUpdated = Category.Update(apiUrl, sessionId, new object[] {myCategoryId, myCategory });

            //// move a category
            //bool wasCategoryMoved = Category.Move(apiUrl, sessionId, new object[] { myCategoryId, Convert.ToInt32(myCategoryId)-1 });

            //// delete a category
            //bool wasCategoryDeleted = Category.Delete(apiUrl, sessionId, new object[] { myCategoryId });

            //// gets the assigned products
            //CategoryAssignedProduct[] myAssignedProducts = Category.AssignedProducts(apiUrl, sessionId, new object[] { 13 });
            //foreach (CategoryAssignedProduct myAssignedProduct in myAssignedProducts)
            //{
            //    Console.WriteLine(myAssignedProduct.sku);
            //}

            //// assigns a product to a category
            //int categoryId = 36;
            //int productId = 48;
            //bool wasProductAssignedToCategory = Category.AssignProduct(apiUrl, sessionId, new object[] { categoryId, productId });

            //// updates a product category assignment
            //int categoryId = 36;
            //int productId = 48;
            //bool wasProductCategoryAssignementUpdated = Category.UpdateProduct(apiUrl, sessionId, new object[] { categoryId, productId });

            //// removes a product from a category
            //int categoryId = 36;
            //int productId = 48;
            //bool wasProductRemovedFromCategory = Category.RemoveProduct(apiUrl, sessionId, new object[] { categoryId, productId });

            #endregion

            #region Category Attribute Examples

            //// sets the category attribute current store (docs say int returned, but is string)
            //string myCategoryAttributeCurrentStore = CategoryAttribute.CurrentStore(apiUrl, sessionId);
            //Console.WriteLine(myCategoryAttributeCurrentStore);

            ////lists the category attributes
            //CategoryAttribute[] myCategoryAttributes = CategoryAttribute.List(apiUrl, sessionId);
            //foreach (CategoryAttribute myCategoryAttribute in myCategoryAttributes)
            //{
            //    Console.WriteLine(myCategoryAttribute.code);
            //}

            //// gets the category attribute options
            //CategoryAttributeOption[] myCategoryAttributeOptions = CategoryAttribute.Options(apiUrl, sessionId, new object[] { "display_mode" });
            //foreach (CategoryAttributeOption myCategoryAttributeOption in myCategoryAttributeOptions)
            //{
            //    Console.WriteLine(myCategoryAttributeOption.label);
            //}

            #endregion

            #region Product Examples

            //// list current store view (docs say int returned, but is string)
            //string myProductCurrentStoreView = Product.CurrentStore(apiUrl, sessionId);
            //Console.WriteLine(myProductCurrentStoreView);

            //// list all products
            //XmlRpcStruct filterOn = new XmlRpcStruct();
            //XmlRpcStruct filterParams = new XmlRpcStruct();
            //filterParams.Add("like", "zol%");
            //filterOn.Add("sku", filterParams);
            //Product[] myProducts = MagentoApi.Product.List(apiUrl, sessionId, new object[] { filterOn });
            //foreach (Product myProduct in myProducts)
            //{
            //    Console.WriteLine(myProduct.name);
            //}

            //// create a new product (doc says int returned, but string is)
            //// *******************************************************************************
            //// YOU MUST PASS ALL ATTRIBUTES THAT ARE REQUIRED IN YOUR BACKEND SETTINGS
            //// AND YOU MUST ASSIGN A VALID AttributeSet ID USE AttributeSet Sample To See ID's
            //// *******************************************************************************
            //Product myNewProduct = new Product();
            //myNewProduct.name = "name";
            //myNewProduct.description = "description";
            //myNewProduct.short_description = "short description";
            //myNewProduct.sku = Guid.NewGuid().ToString();
            //myNewProduct.weight = "1";

            //myNewProduct.gift_message_available = "gift message available";
            //myNewProduct.websites = new string[] { "0" };
            //myNewProduct.category_ids = new string[] { "3" };

            //string myNewProductId = Product.Create(apiUrl, sessionId, new object[] { "simple", 4, myNewProduct.sku, myNewProduct });
            //Console.WriteLine(myNewProductId);

            //// get product info
            //Product myProduct = Product.Info(apiUrl, sessionId, new object[] { myNewProductId });
            //Console.WriteLine("Product name ({0})", myProduct.name);

            //// update a product
            //myNewProduct.name = "my new product name updated";
            //bool wasProductUpdated = Product.Update(apiUrl, sessionId, new object[] { myNewProduct.sku, myNewProduct });

            //// delete a product
            //bool wasProductDeleted = Product.Delete(apiUrl, sessionId, new object[] { myNewProduct.sku });

            //// set a products special price
            //bool wasSpecialPriceSet = Product.SetSpecialPrice(apiUrl, sessionId, new object[] { myNewProduct.sku, 13.95 });

            //// get a products special price
            //ProductSpecialPrice myProductSpecialPrice = Product.GetSpecialPrice(apiUrl, sessionId, new object[] { myNewProduct.sku });
            //Console.WriteLine(myProductSpecialPrice.sku);

            #endregion

            #region Product Attribute Examples

            //// sets the product attribute current store (docs say int returned, but is string)
            //string myProductAttributeCurrentStore = ProductAttribute.CurrentStore(apiUrl, sessionId);
            //Console.WriteLine(myProductAttributeCurrentStore);

            ////lists the product attributes
            //object[] myProductAttributes = ProductAttribute.List(apiUrl, sessionId, new object[] { 4 });
            //foreach (ProductAttribute myProductAttribute in myProductAttributes)
            //{
            //    Console.WriteLine(myProductAttribute.code);
            //}

            //// gets the product attribute options
            //ProductAttributeOption[] myProductAttributeOptions = ProductAttribute.Options(apiUrl, sessionId, new object[] { "color" });
            //foreach (ProductAttributeOption myProductAttributeOption in myProductAttributeOptions)
            //{
            //    Console.WriteLine(myProductAttributeOption.label);
            //}

            #endregion

            #region Product Attribute Set Examples

            //ProductAttributeSet[] myProductAttributeSets = ProductAttributeSet.List(apiUrl, sessionId);
            //foreach (ProductAttributeSet myProductAttributeSet in myProductAttributeSets)
            //{
            //    Console.WriteLine(String.Format("Attribute set name ({0}) id ({1})", myProductAttributeSet.name, myProductAttributeSet.set_id));
            //}

            #endregion

            #region Product Type Examples

            //ProductType[] myProductTypes = ProductType.List(apiUrl, sessionId);
            //foreach (ProductType myProductType in myProductTypes)
            //{
            //    Console.WriteLine(myProductType.label);
            //}

            #endregion

            #region Product Image Examples

            //// gets the product image current store view (doc says int returned, but is string)
            //string myProductImageCurrentStore = ProductImage.CurrentStore(apiUrl, sessionId, new object[] { });
            //Console.WriteLine(myProductImageCurrentStore);

            //// gets all the images for a product
            //ProductImage[] myProductImages = ProductImage.List(apiUrl, sessionId, new object[] { 164 });
            //foreach (ProductImage myProductImage in myProductImages)
            //{
            //    Console.WriteLine(myProductImage.file);
            //}

            //// get the image for the product
            //ProductImage myProductImage2 = ProductImage.Info(apiUrl, sessionId, new object[] { 164, "/g/a/gaming-computer.jpg" });
            //Console.WriteLine(myProductImage2.file);

            // get the product image types (cannot hit the id of product attribute set...)
            // TODO: Query db directly for the id to use below.
            //object[] myProductImageTypes = ProductImage.Types(apiUrl, sessionId, new object[] { 1 });
            //Utils.StructDiscovery(myProductImageTypes);

            //// creates a product image (can't use ProductImage object because they used the file property in two different ways, nice right...)
            //ProductImageFile myProductImageFile = new ProductImageFile();
            //ProductImageFile.Data myProductImageFileData = new ProductImageFile.Data();
            //byte[] imageFileBytes = File.ReadAllBytes("logo-site-newsletter-center.gif");
            //myProductImageFileData.content = System.Convert.ToBase64String(imageFileBytes);
            //myProductImageFileData.mime = "image/gif";
            //myProductImageFile.file = myProductImageFileData;
            //myProductImageFile.label = "new label";
            //myProductImageFile.types = new string[] { "image", "small_image", "thumbnail" };
            //string imageName = ProductImage.Create(apiUrl, sessionId, new object[] { "computer", myProductImageFile });
            //Console.WriteLine(imageName);

            //// updates a product image
            //ProductImage myUpdatedProductImageFile = new ProductImage();
            //myUpdatedProductImageFile.label = "updated label";
            //bool wasUpdated = ProductImage.Update(apiUrl, sessionId, new object[] { "computer", imageName, myUpdatedProductImageFile });

            //// remove a product image
            //bool wasRemoved = ProductImage.Remove(apiUrl, sessionId, new object[] { "computer", imageName });

            #endregion

            #region Product Tier Price Examples

            //// get the tier prices for a product
            //ProductTierPrice[] myProductTierPrices = ProductTierPrice.List(apiUrl, sessionId, new object[] { "250gb5400" });
            //foreach (ProductTierPrice myProductTierPrice in myProductTierPrices)
            //{
            //    Console.WriteLine(myProductTierPrice.price);
            //}

            //// update the product tier prices
            //myProductTierPrices[0].price = "100";
            //myProductTierPrices[1].price = "200";
            //bool wasProductTierPricesUpdated = ProductTierPrice.Update(apiUrl, sessionId, new object[] { "250gb5400", myProductTierPrices});

            #endregion

            #region Product Link Examples

            //// gets the links for a product
            //ProductLink[] myProductLinks = ProductLink.List(apiUrl, sessionId, new object[] { "cross_sell", "computer" });
            //foreach (ProductLink myProductLink in myProductLinks)
            //{
            //    Console.WriteLine(myProductLink.sku);
            //}

            //// assigns links to a product
            //bool wasProductLinkAssigned = ProductLink.Assign(apiUrl, sessionId, new object[] { "up_sell", "computer", "computer_fixed"});

            //// updates product link assignment
            //XmlRpcStruct myProductLinkData = new XmlRpcStruct();
            //myProductLinkData.Add("position", "1");
            //bool wasProductLinkUpdate = ProductLink.Update(apiUrl, sessionId, new object[] { "up_sell", "computer", "computer_fixed", myProductLinkData});

            //// removes the product link assignement
            //bool wasProductLinkRemoved = ProductLink.Remove(apiUrl, sessionId, new object[] { "up_sell", "computer", "computer_fixed"});

            //// gets the product link types (does not return struct, only array of strings)
            //string[] myProductLinkTypes = ProductLink.Types(apiUrl, sessionId);
            //foreach (string myProductLinkType in myProductLinkTypes)
            //{
            //    Console.WriteLine(myProductLinkType);
            //}

            //// gets the product link attributes
            //ProductLinkAttribute[] myProductLinkAttributes = ProductLink.Attributes(apiUrl, sessionId, new object[] { "cross_sell" });
            //foreach (ProductLinkAttribute myProductLinkAttribute in myProductLinkAttributes)
            //{
            //    Console.WriteLine(myProductLinkAttribute.type);
            //}

            #endregion

            #region Order Examples

            //// list orders with filter
            //XmlRpcStruct filterOn = new XmlRpcStruct();
            //XmlRpcStruct filterParams = new XmlRpcStruct();

            //filterParams.Add("gt", "1");
            //filterOn.Add("entity_id", filterParams);

            //Order[] myOrders = MagentoApi.Order.List(apiUrl, sessionId, new object[] { filterOn });
            //foreach (Order myOrder in myOrders)
            //{
            //    Console.WriteLine(myOrder.order_id);
            //}

            //// get a specific orders details
            //Order[] myOrderInfo = Order.Info(apiUrl, sessionId, new object[] { 2 });
            //Console.WriteLine(myOrderInfo[0].billing_firstname);

            //// add a comment to an order
            //bool wasOrderCommented = Order.AddComment(apiUrl, sessionId, new object[] { 100000002, "pending", "your order is pending", true });

            //// place an order on hold
            //bool wasOrderPlacedOnHold = Order.Hold(apiUrl, sessionId, new object[] { 100000002 });

            //// take an order off hold
            //bool wasOrderHoldRemoved = Order.Unhold(apiUrl, sessionId, new object[] { 100000002 });

            //// cancel an order
            //bool wasOrderCanceled = Order.Cancel(apiUrl, sessionId, new object[] { 100000002 });

            #endregion

            #region Order Export Example

            //// pull a list of orders starting from a specific order id
            //XmlRpcStruct filterOn = new XmlRpcStruct();
            //XmlRpcStruct filterParams = new XmlRpcStruct();

            //Console.WriteLine("Checking for orders after {0}", System.DateTime.Now.AddYears(-20).ToString("s"));
            //filterParams.Add("gt", System.DateTime.Now.AddYears(-20).ToString("s"));
            //filterOn.Add("created_at", filterParams);

            //MagentoApi.Order[] myOrders = MagentoApi.Order.List(apiUrl, sessionId, new object[] { filterOn });
            //for (int i=0; i<myOrders.Length; i++)
            //{
            //    // attempt to pull order info
            //    try
            //    {
            //        MagentoApi.OrderInfo myOrderInfo = MagentoApi.Order.Info(apiUrl, sessionId, new object[] { myOrders[i].increment_id });

            //        Console.WriteLine("Order Number {0} Increment ID {2} Dated {1}", myOrderInfo.order_id, myOrderInfo.created_at, myOrderInfo.increment_id);
            //        Console.WriteLine("Customer Name {0} {1}", myOrderInfo.billing_address.firstname, myOrderInfo.billing_address.lastname);
            //        Console.WriteLine("Customer Email {0}", myOrderInfo.customer_email);
            //        Console.WriteLine("Customer Address {0}, {1}, {2}, {3}, {4}", myOrderInfo.shipping_address.street, myOrderInfo.billing_address.city, myOrderInfo.billing_address.region, myOrderInfo.billing_address.postcode, myOrderInfo.billing_address.country_id);

            //        foreach (MagentoApi.OrderProduct myOrderProduct in myOrderInfo.items)
            //        {
            //            Console.WriteLine("Name {0} Sku {1} Price {2} Qty {3}", myOrderProduct.name, myOrderProduct.sku, myOrderProduct.price, myOrderProduct.qty_ordered);
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.ToString());
            //    }
            //    finally
            //    {
            //        Console.WriteLine("\n---------------------------------------------------------------\n");
            //    }
            //}

            #endregion

            #region Shipment Examples

            //// get a list of shipments
            //Shipment[] myShipments = Shipment.List(apiUrl, sessionId, new object[] { });
            //foreach (Shipment myShipment in myShipments)
            //{
            //    Console.WriteLine(myShipment.shipping_firstname);
            //}

            //// get the details of a specific shipment
            //ShipmentInfo myShipmentInfo = Shipment.Info(apiUrl, sessionId, new object[] { 100000001 });
            //foreach (string myShipmentInfoTrack in myShipmentInfo.tracks)
            //{
            //    Console.WriteLine(myShipmentInfoTrack);
            //}
            //foreach (Product myShipmentInfoProduct in myShipmentInfo.items)
            //{
            //    Console.WriteLine(myShipmentInfoProduct.sku);
            //}

            //// create a shipment
            //string myShipmentId = Shipment.Create(apiUrl, sessionId, new object[] { 100000010, new object[] { }, "Shipment Created", true, true });

            //// add a comment to a shipment
            //bool wasShipmentCommented = Shipment.AddComment(apiUrl, sessionId, new object[] { 100000001, "Shipment comment added.", true, true });

            //// get the allowed carriers (returns a struct with dynamic amount of members, odd indeed...)
            //XmlRpcStruct myShipmentAllowedCarriers = Shipment.GetCarriers(apiUrl, sessionId, new object[] { myShipmentId });
            //foreach (string myShipmentAllowedCarriersKey in myShipmentAllowedCarriers.Keys)
            //{
            //    // writes the key value pairs
            //    Console.WriteLine(myShipmentAllowedCarriersKey + " = " + myShipmentAllowedCarriers[myShipmentAllowedCarriersKey]);
            //}

            //// add a tracking number to a shipment
            //string myShipmentTrackingNumber = Shipment.AddTrack(apiUrl, sessionId, new object[] { myShipmentId, "ups", "added tracking number", Guid.NewGuid().ToString() });
            //Console.WriteLine(myShipmentTrackingNumber);

            //// remove a tracking number from a shipment
            //bool wasShipmentTrackingNumberRemoved = Shipment.RemoveTrack(apiUrl, sessionId, new object[] { myShipmentId, myShipmentTrackingNumber });

            #endregion

            #region Invoice Examples

            //// list all invoices
            //Invoice[] myInvoices = Invoice.List(apiUrl, sessionId, new object[] { });
            //foreach (Invoice myInvoice in myInvoices)
            //{
            //    Console.WriteLine(myInvoice.invoice_id);
            //}

            //// get an invoice
            //Invoice myInvoiceInfo = Invoice.Info(apiUrl, sessionId, new object[] { 100000002 });
            //Console.WriteLine(myInvoiceInfo.billing_firstname);

            //// create an invoice
            //Invoice myInvoiceCreated = new Invoice();
            //string myInvoiceCreatedId = Invoice.Create(apiUrl, sessionId, new object[] { 100000012, new object[] { }, "invoice created", true, true });
            //Console.WriteLine(myInvoiceCreatedId);

            //// add a comment to an invoice
            //bool wasInvoiceCommentAdded = Invoice.AddComment(apiUrl, sessionId, new object[] { 100000002, "invoice comment added", true, true });

            //// capture and invoice
            //bool wasInvoiceCaptured = Invoice.Capture(apiUrl, sessionId, new object[] { 100000002 });

            //// void an invoice
            //bool wasInvoiceVoided = Invoice.Void(apiUrl, sessionId, new object[] { 100000002 });

            //// cancel an invoice
            //bool wasInvoiceCanceled = Invoice.Cancel(apiUrl, sessionId, new object[] { 100000002 });

            #endregion

            #region Inventory Examples

            //// list the inventory
            //Inventory[] myInventoryList = Inventory.List(apiUrl, sessionId, new object[] { "computer" });
            //foreach (Inventory myInventoryItem in myInventoryList)
            //{
            //    Console.WriteLine(myInventoryItem.is_in_stock);
            //}

            //// update the inventory
            //Inventory myInventoryUpdate = new Inventory();
            //myInventoryUpdate.is_in_stock = "0";
            //bool wasInventoryUpdated = Inventory.Update(apiUrl, sessionId, new object[] { "computer", myInventoryUpdate });

            #endregion

            // end session
            bool wasSessionEnded = Connection.EndSession(apiUrl, sessionId);
        }
    }
}
