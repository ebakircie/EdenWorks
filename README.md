
## Restaurant CMS 

I created back-end of a Content Management System for a Restaurant Menu using ASP.Net Core and MVC. Only admin can login and manage the web site like adding new items on the menu or category. Customers will reach website via physical copy of QR Codes to see what's on the menu by phone's web browsers.

I tried to abide [Solid Principles](https://github.com/ebakircie/Software_Principles) so if its required, project can easily extend and implement new requests such as stock tracking, shift tracking system, orders etc.

## How to test?

1 - Right click on EdenWorks.Presentation and ![indir (1)](https://user-images.githubusercontent.com/77506856/171291625-e5a00712-8166-47db-a120-563b4ced4d90.png)
  
2 - ISS can appoint different port numbers on different computers which is okay. http://localhost:27955 for example;
  - http://localhost:27955/admin/account/login if user is not logged, it will redirect to login page whenever a controller gets request. 
  - > Username = Admin, Password = 123456
  

## Screenshots from the app
 
![output_AImP2O](https://user-images.githubusercontent.com/77506856/171415593-6c2ea267-bca8-4179-ba3b-59be104e01bd.gif)


## Requirements

- .Net Core v6.0+
