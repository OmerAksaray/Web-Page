



using Microsoft.AspNetCore.Mvc;
using review.Models;

namespace review.Controllers;

public class CourseController : Controller{




public IActionResult List(){
    

return View("CourseList",Repoistory.Courses);

}
public IActionResult Details(int? id){
    if(id==null){
        return Redirect("/course/list");
    }
    var kurs=Repoistory.GetById(id);

    
return View(kurs);

}


}
