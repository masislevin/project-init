using project.web.Core.Context;
using project.web.Core.Entities;
using project.web.Core.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.web.Core.Repos
{
    public class SampleRepo : BaseRepo<Sample>, ISampleRepo
    {
        public SampleRepo(DatabaseContext context) : base(context) { }
    }
}
