﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class DestGoogleDriveController : ControllerTemplate<DestGoogleDrive>
    {
        public override DbSet DbSet => this.Context.DestGoogleDrives;
    }
}