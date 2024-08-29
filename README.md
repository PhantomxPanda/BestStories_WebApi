This repository is only for scholar and general knowledge reasons about how a simple WEB API/RESTFULL works using C# and .NET CORE

This project consumes another web API, Hackers news API, please go to this web site if you want to know how this third party tool works:

URL:  https://github.com/HackerNews/API

To use this Web API you can use a very usefull tool, POSTMAN, i hardly recommend to download this aplication to make any web api tests.

-----------------------------------------------------------------------------------------------------------------------------------

Instructions to use this very simple example of consuming a 3rth web api service:


1. Please download this repository in to your local machine
2. Compile the whole project
3. You will see 3 different folders: Controllers, Models and Services
4. Consider that the Controller folder is the folder where we are creating our Web Api URLs that will be consumed
5. Make a test running chosing a HTTP running only
6. once your computer and the visual studio runs the web api solution you can use the browser or the postman application
7. Please use the next URL to retreive the more n scored stories, where n is the number that you choose, for example if you want to see the 5 most scroed stories you will need to use this URL:

http://localhost:5181/Stories/stories:int?stories=5

so the generic url would be like this:

http://localhost:5181/Stories/stories:int?stories=n

where n is the number of best rated stoeries that you want to see.
