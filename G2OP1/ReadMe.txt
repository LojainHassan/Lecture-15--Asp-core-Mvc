Hello to my simple app 
Here is a basic notes to keep remember what we did in this project
1.controller with action method to return specific view 
2.return View(we can  load Model data here  )
3. to transfer data from view to action method in controller 
-viewData
-viewbag
4.always in razor view we must specifi type of coming data
@model IEnumerable<Employee> 
IEnumerable : it cant update or modify it 
5. @foreach(var item in Model) we use (Model) capital letter to itreat data 

we continue in lecture 16 :
1- I create asp-route-id ( attribute assigned to <a> tag ) to make action method accept this attribute
         <td><a class="btn btn-primary" asp-action="Details" asp-controller="Home" 
                    asp-route-id="@item.Id">Detailes</a></td>
