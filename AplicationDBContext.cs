﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2
{
    public class AplicationDBContext: DbContext
    {
        
        //DbSet<Vuelo> Vuelo { get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {

        }
    }
}
