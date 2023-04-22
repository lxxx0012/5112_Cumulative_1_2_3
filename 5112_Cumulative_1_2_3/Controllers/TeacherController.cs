using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5112_Cumulative_1_2_3.Models;

namespace _5112_Cumulative_1_2_3.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        //Get: /Teacher/List
        public ActionResult List(string SearchKey = null)
        {
            TeachersDataController controller = new TeachersDataController();   
            IEnumerable<Teacher> Teachers = controller.ListTeachers(SearchKey);
            return View(Teachers);
        }

        //Get: /Teacher/Show/{id}
        public ActionResult Show(int id)
        {
            TeachersDataController controller = new TeachersDataController();
            Teacher NewTeacher = controller.FindTeacher(id);

            return View(NewTeacher);

        }

    }
}