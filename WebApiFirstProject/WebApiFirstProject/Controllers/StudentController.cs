using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFirstProject.Models;

namespace WebApiFirstProject.Controllers
{
    public class StudentController : ApiController
    {
        //[Route("api/student/names")]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Murali", "Yashvant" };
        //}

        //public Student Get(int id)
        //{

        //}

        //public Student Post(Student stud)
        //{

        //}

        //public Student Post(int age, Student student)
        //{

        //}

        //public Student Get([FromUri] Student stud)
        //{

        //}

        //public Student Post([FromBody]string name)
        //{

        //}
        //public void Delete(int id)
        //{
        //    DeleteStudentFromDB(id);
        //}

        //public int GetId(string name)
        //{
        //    int id = GetStudentId(name);

        //    return id;
        //}

        //public Student GetStudent(int id)
        //{
        //    var student = GetStudentFromDB(id);

        //    return student;
        //}

        //public HttpResponseMessage Get(int id)
        //{
        //    Student stud = GetStudentFromDB(id);

        //    if (stud == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound, id);
        //    }

        //    return Request.CreateResponse(HttpStatusCode.OK, stud);
        //}

        //public IHttpActionResult Get(int id)
        //{
        //    Student stud = GetStudentFromDB(id);

        //    if (stud == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(stud);
        //}

        public Student Post(Student student)
        {
            // save student into db
            var insertedStudent = SaveStudent(student);

            return insertedStudent;
        }
    }
}
