﻿using Easy.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKEACMS.FormGenerator.Models;
using Microsoft.EntityFrameworkCore;
using Easy;

namespace ZKEACMS.FormGenerator.Service
{
    public class FormDataItemService : ServiceBase<FormDataItem>, IFormDataItemService
    {
        public FormDataItemService(IApplicationContext applicationContext, FormGeneratorDbContext dbContext) : base(applicationContext, dbContext)
        {
        }

        public override DbSet<FormDataItem> CurrentDbSet => (DbContext as FormGeneratorDbContext).FormDataItem;
    }
}
