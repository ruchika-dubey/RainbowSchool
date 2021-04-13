using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Models;

namespace RainbowSchool.Controllers
{
   
    public class SubjectController : BaseController<SubjectModel>
    {

        public SubjectController(IBaseRepository<SubjectModel> repo) : base(repo)
        {
        }
    }
}
