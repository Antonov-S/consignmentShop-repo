# consignmentShop-repo
Consignment Shop



Create an application that can be used by consignment shops to run their business. You need to know who the individuals/vendors are, who have items in the shop and you need to associate these vendors with thier items. Each vendor should be assigned a standard commission, but that may need to be changed on a per-vendor basis. The application should track how much should be paid to each vendor as well as how much money should be paid to the store.

Requirements:
1. List of vendors
2. List of items per vendor
3. Each vendor shoud have a default commission rate
4. Commissions can change
5. Track how much to pay the vendor
6. Track how much to pay the store


Vendor:
FirstName - string
LastName - string
Commission - double

Item:
Title - string
Description - string
Price - decimal
Sold - boolean
PaymentDistributed - boolean
Owner - Vendor

Store:
Name - string
Vendors - Vendor
Items - Item
