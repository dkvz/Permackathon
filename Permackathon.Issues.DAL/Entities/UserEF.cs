﻿using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Models
{
    public class UserEF 
    {
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
