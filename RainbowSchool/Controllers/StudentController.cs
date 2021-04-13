using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RainbowSchool;
using RainbowSchool.Models;
using DataLayer;

namespace RainbowSchool.Controllers
{
    public class StudentController : BaseController<StudentModel>
    {

        public StudentController(IBaseRepository<StudentModel> repo) : base(repo)
        {
        }
    }
   }
