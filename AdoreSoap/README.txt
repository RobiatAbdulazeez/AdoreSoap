2023-10-10   10:40
I had issues with my project so here is a new fresh one
I Created my AlureSoap Web App tried to run but i saw an "can't reach this page error message"
went back to my MvcMovie README to look for solutions

10:49
Found it!! i was supposed to comment out the ssl port in my properties folder in my launchSettings.json file

10:52
I Have My Welcome Page Running
10:53
I created a Github Repository for my project

11:09
Trying to add the product catalogue link and the About Us link to my page which is adding a controller 

11:28
i added two controllers to my application the About me and the Product Catelogue page
i decided to add a default text to display on my web page with the content that came with the controller page when created just to see if my About me page works properly
 11:29
 MY TEXT WAS HIGHLIGHTED IN RED!!!
 something is wrong somewhere,it says cannot implicitly covert type string with  Microsoft.AspNetCore.Mvc.IActionResult

 11:30
 i changed the function IActionResult to string because my text is in string let see if it works
 IT WORKED!!!

 11:41
Moving to create My views for the links i have created in my Controller so that i can call the controller View method and display some content on my page

11:52
I created my Views For My About Us Page And The Product Catelogue Page To Create Content For My Alure Soap which will ne called as a method in My Controller

11:54
I added some Content in MY About Us page to try if it will be displayed on the About Me page 
YAYYY! It Worked
12:26
took break i will proceed to clean and rebuild my app 

12:39
proceeded to change the view and layout page
to Add the AboutUs and The Product Catelogue Navigation in the home page
which was acheived from the shared _layouthtml.cs file

2:30
I ADDED CONTENTS TO MY ABOUT PAGE

3:38
i initially created a different folder for the about me and the product Catelogue page
but i was supposed to use the same home folder under the views so i created a new view razor empty page for my about us and the product catelogue page under the views/home
i decided to run the project again but i saw errors "the view index was not found"

4:15
i am still trying to fix the errors i can't really figure out where the errors are coming from

4:30
Ifound it!!!
It was referencing to the index.cshtml file which was in the folder i deleted folder i removed 
i went back to my home Controller to add the method that displays the content i have under my view folder (views/home/AboutUs.cshtml) and my (views/home/ProductCatelogue.cshtml) 
Also i had to make changes in the shared layout.cshtml to change the controller to home instead of the file(ProductCatelogue.cs and AboutUs.cs )i previously had
Good To Go!!!

2023-10-12  1245
Started with my project today by adding comments to my controllers methods
proceeded to downloading licence free images to use for my projects

12:47
created a folder in my wwwroot which is for my images and i transferred my downloaded images to the folder 

1:06
I started with my models,created a new .cs file for my project which is Alure.cs and i added my soap attributes 
