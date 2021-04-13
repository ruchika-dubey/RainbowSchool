﻿using System;
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
    
    public class ClassController : BaseController<ClassModel>
    {

        public ClassController(IBaseRepository<ClassModel> repo) : base(repo)
        {
        }
    }
}
