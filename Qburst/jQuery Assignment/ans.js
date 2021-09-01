1.What selector would I use to query for all elements with an ID that ends with a particular string? 
Also, how would I modify the selector to retrieve only <div> elements whose IDs end with that same string? 
Provide an example.

Ans.

We can use the method $("[id$="string"]") as a selector in this scenario.
e.g:$("[id$="string"]").css("text-color","blue");

For div elements only, we can use $("div [id$="string"]").css("text-color","blue");

2.Explain what the following code does:

$( "div" ).css( "width", "300px" ).add( "p" ).css( "background-color", "blue" );

Ans:

This sets width of all divs to 300px and sets background color of all divs and p tags to blue.

3.Find the class (ul) of Student B3

$("li").last().prev().prev().parent();

4.
