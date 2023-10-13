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
I started with my models,created a new .cs file for my project which is Adore.cs in the models folder and i added my
soap attributes and also included the comments for better understandings

7:46
Added the Nuget Packages,this was done in the Nuget Package Manager Console Under the tools because we are using 
the 3.1 .Net Application version we have to download a package that is compatible with our Application
Microsoft.EntityFrameworkCore.SqlServer (3.0.1)version was downloaded because this will work perfectly for my
Application

7:53
After the NuGet Package has been downloaded i created a data folder in my Adore Soap project
in My data folder i created a .cs Context folder the AdoreSoapContext.cs and added some lines of Code
then proceeded to register the database context in my startup.cs

7:56
i went to my appsettings.json file to add the AdoreSoapContext as part of the connection to the database

8:00
Time To scaffold my Adore Soap Page Under the Controller i added a new Scaffolding item using my Model class and data
context class name for my project

8:05
I ran the Add-Migration InitialCreate
Update-Database command in my Package Management Console,App was tested and it was working Perfectly
Went through the content of the controller that was generated for me after the scaffolding

8:15
went ahead to seed my database,adding product items to the database
also i went through the sql table under the view folder to see if my database was created properly
i also added a seed initializer in my program.cs file
i also remenbered the instruction told us to add an extra firld which is for rating so i ran the
I ran the Add-Migration Rating and it was successfully added

8:20
I proceeded to add a new field which was rating made some changes in my create,delete,details,edit and index,cshtml file to 
add this new product property
Also made some changes in my Adore.cs under my models to include this property
in my AdoresControlle.cs i added this property in the bind for the create 
i ran my code and i got errors

8:30
i already added the Migration Rating it already exist in the database
i tried to change the name of the property from Rating to ProductRating but it was still not taking the name
still getting errors

9:30
Still getting the errors,i shouldn't have created the Rating before adding the properties
i went to my solution folder to look for where the rating migration is Added

9:32
Found it under the Migration,so i am going to take it out of the project and go over the steps again this time,doing it the proper
way.

9:35
IT IS WORKING!!! I AM A GENIUS!!!

9:40
My Edit button is working but not displaying the value of rating on my page
what could have gone wrong!

9:43
I went through my steps again 
FOUND!!!
I didnt bind my Rating to the Edit Function in my AdoresController.cs
 Edit(int id, [Bind("Id,Name,ReleaseDate,Color,Purpose,Type,Price")]
 Added the Rating and run the Application
Everything is working Perfectly

9:50
I added validations to my Adore.cs to specify what i want in the fields provided
and to let users know the values that could be enetered this is to avoid GIGO
also i added the rating range of 1-5 if the user enters a number that is greater than 5 it will display a message
stating that the numbers within the range of 1-5 can only be entered

9:53
My RealeaseDate was written together so i displayed it in a better way by adding the space in between which
makes reading really easy

10:30
Added more images to my Images folder and created a font folder to change My Page Layout

10:35
having issues with my Css it is not displaying it the way i wanted it to work.
i found the bootstap library and the css properties i could change
yayy it worked

10:45
I will just take a break and continue later

2023-10-13
11:05
i decided to round up but i received an error i am denied access to the database
i decided to rin the add migration command and update  the database again the command i used was
Add-Migration InitialCreate
Update-Database

11:08
My Application is working perfectly!!!

12:16
I added more contents to my product catelogue page and also included some pictures on soap on the page 
I also added some styles to my site.css to syle and adjust the sizes of the images i have on the web page




