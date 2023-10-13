2023-10-6    2:30
Name of Program:Adore Soap
Purpose:Create A  Functioning Web Application Program with the product theme for your customers to showcase and market your brand

2:32
i was assigned the product soap for my web Application project and i proceeded to make research for the project,
to know who the competitors are,the properties and attributes associated with the project as well as getting the
license free images to use for my project.

4:35
After Comparing and Observing my competitors websites, i  thought of the unique name i could use for my project that was why i decided
to go for the name Adore Which mean to love and respect someone dearly,loving and respecting our customers is our number one piority
at adore Soap and this gives us the motivation to create products that are our customers are just in need of

2023-10-8 4:30
I started My Adore Soap Web Application ran into Multiple errors tried to fix them but i couldn't

2023-10-12   1:40
I had issues with my project so here is a new fresh one
I Created my AdoreSoap Web App tried to run but i saw an "can't reach this page error message"
went back to my MvcMovie README to look for solutions

1:49
Found it!! i was supposed to comment out the ssl port in my properties folder in my launchSettings.json file

1:52
I Have My Welcome Page Running
1:53
I created a Github Repository for my project

2:09
Trying to add the product catalogue link and the About Us link to my page which is adding a controller 

2:28
i added two controllers to my application the About me and the Product Catelogue page
i decided to add a default text to display on my web page with the content that came with the controller page when created just to see if my About me page works properly

2:29
MY TEXT WAS HIGHLIGHTED IN RED!!!
 something is wrong somewhere,it says cannot implicitly covert type string with  Microsoft.AspNetCore.Mvc.IActionResult

 2:30
 i changed the function IActionResult to string because my text is in string let see if it works
 IT WORKED!!!

 3:41
Moving to create My views for the links i have created in my Controller so that i can call the controller View method and display some content on my page

3:52
I created my Views For My About Us Page And The Product Catelogue Page To Create Content For My Adore Soap which will ne called as a method in My Controller

3:54
I added some Content in MY About Us page to try if it will be displayed on the About Me page 
YAYYY! It Worked
4:26
took break i will proceed to clean and build my app 

4:39
proceeded to change the view and layout page
to Add the AboutUs and The Product Catelogue Navigation in the home page
which was acheived from the shared _layouthtml.cs file

5:30
I ADDED CONTENTS TO MY ABOUT PAGE

5:38
i initially created a different folder for the about me and the product Catelogue page
but i was supposed to use the same home folder under the views so i created a new view razor empty page for my about us and the product catelogue page under the views/home
i decided to run the project again but i saw errors "the view index was not found"

6:15
i am still trying to fix the errors i can't really figure out where the errors are coming from

7:30
Ifound it!!!
It was referencing to the index.cshtml file which was in the folder i deleted folder i removed 
i went back to my home Controller to add the method that displays the content i have under my view folder (views/home/AboutUs.cshtml) and my (views/home/ProductCatelogue.cshtml) 
Also i had to make changes in the shared layout.cshtml to change the controller to home instead of the file(ProductCatelogue.cs and AboutUs.cs )i previously had
Good To Go!!!

7:35
Started with my project today by adding comments to my controllers methods
proceeded to downloading licence free images to use for my projects

7:40
created a folder in my wwwroot which is for my images and i transferred my downloaded images to the folder 

7:42
I started with my models,created a new .cs file for my project which is Adore.cs and i added my soap attributes 
