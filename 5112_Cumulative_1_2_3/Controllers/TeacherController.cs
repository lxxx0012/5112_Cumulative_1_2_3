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

        //Get : /Teacher/List
        public ActionResult List(string SearchKey = null)
        {
            TeachersDataController controller = new TeachersDataController();
            IEnumerable<Teacher> Teachers = controller.ListTeachers(SearchKey);
            return View(Teachers);
        }

        //Get: /Teacher/Teachersfname
        public ActionResult Teachersfname(string Searchfname = null)
        {
            TeachersDataController controller = new TeachersDataController();   
            IEnumerable<Teacher> Teachers = controller.Teachersfname(Searchfname);
            return View(Teachers);
        }

        //Get: /Teacher/Teacherslname
        public ActionResult Teacherslname(string Searchlname = null)
        {
            TeachersDataController controller = new TeachersDataController();
            IEnumerable<Teacher> Teachers = controller.Teacherslname(Searchlname);
            return View(Teachers);
        }

        //Get: /Teacher/TeachersHiredate
        public ActionResult TeachersHiredate(DateTime Searchdate)
        {
            TeachersDataController controller = new TeachersDataController();
            IEnumerable<Teacher> Teachers = controller.TeachersHiredate(Searchdate);
            return View(Teachers);
        }

        //Get: /Teacher/TeachersSalary
        public ActionResult TeachersSalary(Decimal Searchsalary)
        {
            TeachersDataController controller = new TeachersDataController();
            IEnumerable<Teacher> Teachers = controller.TeachersSalary(Searchsalary.ToString());
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