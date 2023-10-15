using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review.Models
{
    public class Repoistory
    {
        private static readonly List<CourseViewModel>_courses=new();
    static Repoistory(){
        _courses=new List<CourseViewModel>(){
        new CourseViewModel{Title="Asp.net kurs",
        Id=1,
        Description="Güzel Bir Kurs", 
        Image="1.jpg",
        Tags=new string[]{"aspnet","web geliştirme"},
        isActive=true,
        isHome=true,
        },
        new CourseViewModel{Title="Php.net kurs"
        ,Id=2
        ,Description="Güzel Bir Kurs", 
        Image="2.jpg",
        Tags=new string[]{"php","database"},
        isActive=true,
        isHome=true,},
        new CourseViewModel{Title="Django.net kurs"
        ,Id=3
        ,Description="Güzel Bir Kurs", 
        Image="3.jpg",
        Tags=new string[]{"django","web geliştirme"},
        isActive=false,
        isHome=true,},
        new CourseViewModel{Title="Javascript.net kurs"
        ,Id=4
        ,Description="Güzel Bir Kurs",
         Image="1.jpg",
         Tags=new string[]{"javascript","web geliştirme"},
        isActive=true,
        isHome=true,}
               };
    }
        public static List<CourseViewModel> Courses{
            get{
                return _courses;
            }
        }
        public static CourseViewModel? GetById(int? id){
            return _courses.FirstOrDefault(c => c.Id==id);
        }
    }
}